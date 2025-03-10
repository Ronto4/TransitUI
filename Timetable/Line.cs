using System.Diagnostics;

namespace Timetable;

/// <summary>
/// A single line in the network.
/// It must have exactly *one* name,
/// i.e. lines like <c>6</c> and <c>6E</c> *MUST* be split into two <see cref="Line"/>s.
/// </summary>
public record Line
{
    /// <summary>
    /// A route of the network, connecting multiple <see cref="Stop.Position"/>s.
    /// Different routes, even ones using a proper, contiguous subset of positions
    /// must be represented using multiple routes.
    /// </summary>
    public record Route
    {
        /// <inheritdoc />
        public override string ToString() =>
            $"{StopPositions.First().Stop.Name} {(InterpretAsBidirectional ? "–" : ">")} {StopPositions.Last().Stop.Name}{(ManualAnnotation is null ? "" : $" {ManualAnnotation}")}";

        /// <summary>
        /// A wrapper around intervals between stops of the route.
        /// Multiple <see cref="Route.TimeProfile"/> can be used to indicate multiple times taken between stops,
        /// e.g. on different times of day.
        /// </summary>
        public record TimeProfile
        {
            /// <summary>
            /// At index <c>i</c> there is the time it takes to travel from stop position <c>i</c> to <c>i+1</c>.
            /// </summary>
            public required TimeSpan[] StopDistances { get; init; }

            /// <summary>
            /// Get the time it takes to travel from stop index <paramref name="fromIndex"/> to <paramref name="toIndex"/>.
            /// </summary>
            /// <remarks><paramref name="fromIndex"/> MUST NOT be greater than <paramref name="toIndex"/>!</remarks>
            public TimeSpan TimeBetweenStops(int fromIndex, int toIndex)
            {
#if DEBUG
                if (fromIndex > toIndex)
                    throw new ArgumentOutOfRangeException(nameof(fromIndex), fromIndex,
                        $"{nameof(fromIndex)} MUST NOT be greater than {nameof(toIndex)}, but was {fromIndex} when {nameof(toIndex)} was {toIndex}.");
#endif
                return TimeSpan.FromTicks(StopDistances
                    .Skip(fromIndex).Take(toIndex - fromIndex).Select(time => time.Ticks).Sum());
            }
        }

        internal Line? Line { get; set; }

        /// <summary>
        /// The <see cref="Stop.Position"/>s where this route calls at.
        /// </summary>
        public required Stop.Position[] StopPositions { get; init; }

        /// <summary>
        /// All the existing timing patterns for this route.
        /// </summary>
        public required TimeProfile[] TimeProfiles { get; init; }

        /// <summary>
        /// A text to be displayed alongside this route.
        /// Useful e.g. when multiple routes of the same line have the same start and end stops but a different way.
        /// </summary>
        public string? ManualAnnotation { get; init; }

        /// <summary>
        /// The stop that is used when calculating frequencies.
        /// It is advised that the departure time does not vary due to time adjustments at this stop.
        /// </summary>
        public required int CommonStopIndex { get; init; }

        /// <summary>
        /// Get the minimum and maximum time it takes to travel from stop index <paramref name="fromIndex"/> to <paramref name="toIndex"/>
        /// depending on the time profiles.
        /// </summary>
        public (TimeSpan minimum, TimeSpan maximum) TimeBetweenStops(int fromIndex, int toIndex)
        {
            if (toIndex < fromIndex) throw new ArgumentException($"The indices are swapped: {fromIndex} -> {toIndex}");
            var times = TimeProfiles.Select(profile => profile.TimeBetweenStops(fromIndex, toIndex)).ToList();
            return (times.Min(), times.Max());
        }

        /// <summary>
        /// A throwing wrapper around <see cref="TryGetIndexOfStopFirst"/>.
        /// </summary>
        /// <exception cref="ArgumentException">The <paramref name="stop" /> is not part of this route.</exception>
        public int GetIndexOfStopFirst(Stop stop)
        {
            var exists = TryGetIndexOfStopFirst(stop, out var index);
            return exists
                ? index
                : throw new ArgumentException(
                    $"The provided stop {stop.DisplayName} is not part of the route from {StopPositions.First().Stop.DisplayName} to {StopPositions.Last().Stop.DisplayName}.",
                    nameof(stop));
        }

        /// <summary>
        /// Get the index of the single occurrence of <paramref name="stop" /> in this route
        /// and store it in <paramref name="index"/>.
        /// </summary>
        /// <returns><c>true</c> if and only if the <paramref name="stop"/> exists in this route, <c>false</c> otherwise.</returns>
        /// <exception cref="InvalidOperationException">The stop exists more than once in the route.</exception>
        public bool TryGetIndexOfStop(Stop stop, out int index)
        {
            index = StopPositions.Select((position, index) => (position.Stop, index))
                .SingleOrDefault(tuple => stop == tuple.Stop, (Stop: stop, index: -1)).index;
            return index != -1;
        }

        /// <summary>
        /// Get the index of the first occurrence of <paramref name="stop" /> in this route
        /// and store it in <paramref name="index"/>.
        /// </summary>
        /// <returns><c>true</c> if and only if the <paramref name="stop"/> exists in this route, <c>false</c> otherwise.</returns>
        public bool TryGetIndexOfStopFirst(Stop stop, out int index)
        {
            index = StopPositions.Select((position, index) => (position.Stop, index))
                .FirstOrDefault(tuple => stop == tuple.Stop, (Stop: stop, index: -1)).index;
            return index != -1;
        }

        /// <summary>
        /// Whether this route contains <paramref name="stop"/>.
        /// </summary>
        /// <param name="stop">The <see cref="Stop"/> to check for.</param>
        /// <param name="onlyDepartures">Only consider departures, i.e. the last stop of this route is ignored.</param>
        public bool DoesStopAt(Stop stop, bool onlyDepartures) => StopPositions
            .Take(StopPositions.Length - (onlyDepartures
                ? /* when we only want departures, the last stop is no longer relevant */ 1
                : 0)).Select(pos => pos.Stop).Contains(stop);

        /// <summary>
        /// Whether this route and <paramref name="other"/> route have reversed start and end stops.
        /// </summary>
        public bool LooselyIsReverse(Route other) => StopPositions.Last().Stop == other.StopPositions.First().Stop &&
                                                     StopPositions.First().Stop == other.StopPositions.Last().Stop;

        /// <summary>
        /// Whether this route and <paramref name="other"/> route have identical start and end stops.
        /// </summary>
        public bool LooselyIsSame(Route other) => InterpretAsBidirectional == other.InterpretAsBidirectional &&
                                                  StopPositions.First().Stop == other.StopPositions.First().Stop &&
                                                  StopPositions.Last().Stop == other.StopPositions.Last().Stop;

        /// <summary>
        /// Whether this route stops at exactly the same <see cref="Stop"/>s as <paramref name="other"/> but in reverse.
        /// </summary>
        public bool StrictlyIsReverse(Route other) => StopPositions.Select(position => position.Stop).Reverse()
            .SequenceEqual(other.StopPositions.Select(position => position.Stop));

        /// <summary>
        /// Whether this route stops at exactly the same <see cref="Stop"/>s as <paramref name="other"/>.
        /// </summary>
        public bool StrictlyIsSame(Route other) => InterpretAsBidirectional == other.InterpretAsBidirectional &&
                                                   StopPositions.Select(position => position.Stop)
                                                       .SequenceEqual(
                                                           other.StopPositions.Select(position => position.Stop));

        /// <summary>
        /// Whether this route should be displayed as being bidirectional.
        /// Used in the context of collapsing multiple routes into one entry when displaying a <see cref="Line"/>.
        /// </summary>
        // TODO: This is probably not at the right spot here.
        public bool InterpretAsBidirectional { get; set; } = false;

        /// <summary>
        /// Get the same route as this but omitting <paramref name="stopToExclude"/>, if it is present.
        /// </summary>
        public Route WithoutStop(Stop stopToExclude) => StopPositions.Any(pos => pos.Stop == stopToExclude)
            ? this with
            {
                StopPositions = StopPositions.Where(stop => stop.Stop != stopToExclude)
                    .ToArray(),
                TimeProfiles = TimeProfiles.Select(profile =>
                {
                    var indexOfLps = StopPositions.Select((pos, index) => (pos, index))
                        .First(tuple => tuple.pos.Stop == stopToExclude).index;
                    return profile with
                    {
                        StopDistances =
                        [
                            ..profile.StopDistances[..(indexOfLps - 1)],
                            profile.StopDistances[indexOfLps - 1] + profile.StopDistances[indexOfLps],
                            ..profile.StopDistances[(indexOfLps + 1)..]
                        ],
                    };
                }).ToArray(),
            }
            : this;

        /// <summary>
        /// The number of trips of this route on the selected days.
        /// <br/><br/>
        /// Note: School days and Holiday days count separately,
        /// internally the bits from <see cref="DaysOfOperation"/> are used per trip.
        /// <br/><br/>
        /// Note: It is <c>null</c> if the <see cref="Line"/> of this route is not set.
        /// This should not happen in normal operation.
        /// </summary>
        public int? TripCount(DaysOfOperation days) => Line?.Trips.Where(trip => trip.Route == this)
            .Select(trip => int.PopCount((int)(trip.DaysOfOperation & days))).Sum();
    }

    /// <summary>
    /// A single trip along a given <see cref="Line.Route"/>.
    /// </summary>
    public record Trip
    {
        /// <summary>
        /// Contains the definition of a through service with another <see cref="Trip"/>.
        /// </summary>
        public record Connection
        {
            /// <summary>
            /// Indicating the part of the through service the <see cref="Trip"/> containing this object plays.
            /// </summary>
            public required ConnectionType Type { get; init; }

            /// <summary>
            /// The other <see cref="Trip"/> associated with this through service.
            /// </summary>
            public required Trip Trip { get; init; }

            /// <summary>
            /// Used for stops along the way of the connecting route that are noteworthy to be mentioned in timetables
            /// regardless of the fact they appear as normal on the route.
            /// </summary>
            public required Stop? NotableViaStop { get; init; }
        }

        /// <summary>
        /// Indicates the type of through service a <see cref="Connection"/> instance plays.
        /// </summary>
        public enum ConnectionType
        {
            /// <summary>
            /// Indicates that the associated <see cref="Trip"/> is the originating <see cref="Trip"/>.
            /// </summary>
            ContinuesAs,

            /// <summary>
            /// Indicates that the associated <see cref="Trip"/> is the continuing <see cref="Trip"/>.
            /// </summary>
            ComesAs,
        }

        /// <summary>
        /// Basis for all types of annotations.
        /// </summary>
        public abstract record AnnotationDefinition
        {
            /// <summary>
            /// The short name or representation of this annotation.
            /// <br/><br/>
            /// Should be small enough to fit into a timetable, e.g. a single letter.
            /// </summary>
            public required string Symbol { get; init; }
        }

        /// <summary>
        /// An annotation that uses a manually specified <see cref="Text"/> for display.
        /// </summary>
        public record ManualAnnotation : AnnotationDefinition
        {
            /// <summary>
            /// The text to display when explaining this annotation.
            /// </summary>
            public required string Text { get; init; }
        }

        /// <summary>
        /// An annotation used to show that the associated <see cref="Trip"/> is the first part of a through service
        /// continuing on another <see cref="Trip"/>.
        /// </summary>
        public record ContinuesAnnotation : AnnotationDefinition
        {
            /// <summary>
            /// The final <see cref="Stop"/> of the next <see cref="Trip"/> in this through service.
            /// </summary>
            public required Stop To { get; init; }

            /// <summary>
            /// The <see cref="Line"/> the next <see cref="Trip"/> in this through service uses.
            /// </summary>
            public required Line As { get; init; }

            /// <summary>
            /// The <see cref="Route"/> the next <see cref="Trip"/> in this though service uses
            /// on the <see cref="Line"/> stored in <see cref="As"/>.
            /// </summary>
            public required Route Via { get; init; }

            /// <summary>
            /// The time between arriving at the final <see cref="Stop"/> of this <see cref="Trip"/> and the departure
            /// at this <see cref="Stop"/> as the new <see cref="Trip"/>.
            /// </summary>
            public required TimeSpan Delay { get; init; }

            /// <summary>
            /// Used for stops along the way of the connecting route that are noteworthy to be mentioned in timetables
            /// regardless of the fact they appear as normal on the route.
            /// </summary>
            public required Stop? NotableViaStop { get; init; }
        }

        /// <summary>
        /// An annotation indicating that this <see cref="Trip"/> does not continue to the final stop of the default
        /// display route (in the stop timetable represented as route [1] or unspecified if there is only one).
        /// </summary>
        public record OnlyToAnnotation : AnnotationDefinition
        {
            /// <summary>
            /// The final <see cref="Stop"/> of this <see cref="Trip"/>.
            /// </summary>
            public required Stop To { get; init; }

            /// <summary>
            /// The 0-based index of the display route this <see cref="Trip"/> takes.
            /// </summary>
            public required int DisplayRouteIndex { get; init; }
        }

        /// <summary>
        /// An annotation combining a <see cref="ContinuesAnnotation"/> and a <see cref="OnlyToAnnotation"/>
        /// indicating that this <see cref="Trip"/> does not go to the final stop of the default display route
        /// and then continues as another <see cref="Trip"/>.
        /// </summary>
        public record ContinuesFromToAnnotation : AnnotationDefinition
        {
            /// <summary>
            /// The <see cref="ContinuesAnnotation"/> aspect of this annotation.
            /// </summary>
            public required ContinuesAnnotation ContinuesAnnotation { get; init; }

            /// <summary>
            /// The <see cref="OnlyToAnnotation"/> aspect of this annotation.
            /// </summary>
            public required OnlyToAnnotation OnlyToAnnotation { get; init; }
        }

        /// <summary>
        /// The <see cref="Timetable.Line"/> this <see cref="Trip"/> uses.
        /// </summary>
        public required Line Line { get; init; }

        /// <summary>
        /// The <see cref="Line.Route"/> this <see cref="Trip"/> uses.
        /// </summary>
        public required Route Route { get; init; }

        /// <summary>
        /// The <see cref="TimeProfile"/> this <see cref="Trip"/> uses.
        /// </summary>
        public required Route.TimeProfile TimeProfile { get; init; }

        /// <summary>
        /// The time at which this <see cref="Trip"/> departs the first <see cref="Stop"/> of its <see cref="Route"/>.
        /// </summary>
        public required TimeOnly StartTime { get; init; }

        /// <summary>
        /// The days on which this <see cref="Trip"/> operates.
        /// </summary>
        public required DaysOfOperation DaysOfOperation { get; init; }

        /// <summary>
        /// All manually (in the timetable) specified <see cref="ManualAnnotation"/> for this <see cref="Trip"/>.
        /// </summary>
        public required List<ManualAnnotation> Annotations { get; init; }

        /// <summary>
        /// All through services this <see cref="Trip"/> participates in.
        /// <br/><br/>
        /// This should have 0 (no through service), 1 (start or end of through service), or 2 (middle of a through service) elements.
        /// </summary>
        public required List<TripCreate.Connection> Connections { private get; init; }

        /// <summary>
        /// Translate the trip-create <see cref="Timetable.Line.TripCreate.Connection"/>s present on this <see cref="Trip"/> into trip <see cref="Connection"/>s.
        /// </summary>
        /// <param name="allLines">All <see cref="Line"/>s present in the current network, indexed by their id.</param>
        // Consider adding more validation steps if it becomes a problem.
        public IEnumerable<Connection> GetConnections(IReadOnlyDictionary<string, Line> allLines) => Connections.Select(
            connection => new Connection
            {
                Type = connection.Type,
                NotableViaStop = connection.NotableViaStop,
                Trip = connection.Type is ConnectionType.ContinuesAs
                    ? allLines[connection.ConnectingLineIdentifier].TripsOfRouteIndex(connection.ConnectingRouteIndex)
                        .Single(trip =>
                            trip.StartTime == TimeAtStop(Route.StopPositions.Length - 1).Add(connection.Delay) &&
                            trip.DaysOfOperation == DaysOfOperation)
                    : allLines[connection.ConnectingLineIdentifier].TripsOfRouteIndex(connection.ConnectingRouteIndex)
                        .Single(trip =>
                            StartTime == trip.TimeAtStop(trip.Route.StopPositions.Length - 1).Add(connection.Delay) &&
                            trip.DaysOfOperation == DaysOfOperation),
            });

        /// <summary>
        /// The time at which this <see cref="Trip"/> departs the <see cref="Stop"/> specified by the <see cref="Route"/>'s <see cref="Line.Route.CommonStopIndex"/>.
        /// </summary>
        public TimeOnly TimeAtCommonStop() => TimeAtStop(Route.CommonStopIndex);

        /// <summary>
        /// The time at which this <see cref="Trip"/> departs at the <see cref="Stop"/> of the <see cref="Route"/> specified by <paramref name="stopIndex"/>.
        /// </summary>
        public TimeOnly TimeAtStop(int stopIndex)
        {
            var time = StartTime;
            while (stopIndex-- > 0)
            {
                time = time.Add(TimeProfile.StopDistances[stopIndex]);
            }

            return time;
        }

        /// <summary>
        /// The time at which this <see cref="Trip"/> arrives at the last <see cref="Stop"/> of the <see cref="Route"/>.
        /// </summary>
        /// <returns></returns>
        public TimeOnly TimeAtLastStop() => TimeAtStop(Route.StopPositions.Length - 1);
    }

    /// <summary>
    /// A small helper struct used to create a <see cref="Trip"/> in a timetable definition.
    /// </summary>
    public readonly record struct TripCreate
    {
        /// <summary>
        /// Denotes a through service as part of the <see cref="TripCreate"/>.
        /// </summary>
        public record Connection
        {
            /// <summary>
            /// The role this trip plays in the through service.
            /// </summary>
            public required Trip.ConnectionType Type { get; init; }

            /// <summary>
            /// The identifier of the line the other part of the through service relates to.
            /// </summary>
            public required string ConnectingLineIdentifier { get; init; }

            /// <summary>
            /// The index of the <see cref="Route"/> in the other <see cref="Line"/> the other part of the through service uses on that <see cref="Line"/>.
            /// </summary>
            public required Index ConnectingRouteIndex { get; init; }

            /// <summary>
            /// The time between the two time points at the <see cref="Stop"/> where the through service changes trips.
            /// </summary>
            public required TimeSpan Delay { get; init; }

            /// <summary>
            /// Used for stops along the way of the connecting route that are noteworthy to be mentioned in timetables
            /// regardless of the fact they appear as normal on the route.
            /// </summary>
            public Stop? NotableViaStop { get; init; } = null;
        }

        /// <summary>
        /// Create a new <see cref="TripCreate"/> without any fields set.
        /// </summary>
        public TripCreate()
        {
        }

        /// <summary>
        /// The index of the <see cref="Route"/> this trip uses.
        /// </summary>
        public required Index RouteIndex { get; init; }

        /// <summary>
        /// The index of the <see cref="Line.Route.TimeProfile"/> this trip uses.
        /// </summary>
        public required Index TimeProfileIndex { get; init; }

        /// <summary>
        /// The departure time from the first <see cref="Stop"/> of the <see cref="Route"/> specified by <see cref="RouteIndex"/>.
        /// </summary>
        public required TimeOnly StartTime { get; init; }

        /// <summary>
        /// The days on which this trip operates.
        /// </summary>
        public required DaysOfOperation DaysOfOperation { get; init; }

        /// <summary>
        /// Use <see cref="AnnotationSymbols"/> instead.
        /// <br/><br/>Was:<br/>
        /// Specify the symbol of the annotation that should be used for the annotation of this trip.
        /// </summary>
        [Obsolete($"Use {nameof(AnnotationSymbols)} instead.", false)]
        public string AnnotationSymbol
        {
            init => AnnotationSymbols.Add(value);
        }

        /// <summary>
        /// The symbols (defined as the keys of <see cref="Line.Annotations"/>) of the annotations this trip has.
        /// </summary>
        public List<string> AnnotationSymbols { get; init; } = [];

        /// <summary>
        /// All through services this trip participates in.
        /// <br/><br/>
        /// This should have 0 (no through service), 1 (start or end of through service), or 2 (middle of a through service) elements.
        /// </summary>
        public List<Connection> Connections { get; init; } = [];

        /// <summary>
        /// Repeat this <see cref="TripCreate"/> instance for every <paramref name="interval"/>.
        /// </summary>
        /// <param name="interval">The time between each of the trips that will be created.</param>
        /// <param name="until">The latest <see cref="StartTime"/> a trip of this repetition can have.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of the <see cref="TripCreate"/>s to create,
        /// including the original <see cref="TripCreate"/>.</returns>
        /// <exception cref="ArgumentException">
        /// If the <paramref name="until"/> time is <i>before</i> the <see cref="StartTime"/>
        /// of this <see cref="TripCreate"/> but the <see cref="DaysOfOperation"/> do not specify a daily operation,
        /// it is impossible to represent the resulting trips with the used model, thus this exception is thrown.
        /// </exception>
        public IEnumerable<TripCreate> AlsoEvery(TimeSpan interval, TimeOnly until)
        {
            // If until is before this trip, this only works for trips that occur every day.
            if (until < StartTime && DaysOfOperation != DaysOfOperation.Daily)
            {
                throw new ArgumentException(
                    $"{nameof(until)} of {until} is before {nameof(StartTime)} of {StartTime}, and {nameof(DaysOfOperation)} is not {nameof(DaysOfOperation.Daily)}");
            }

            yield return this;
            var newStartTime = StartTime;
            while ((newStartTime = newStartTime.Add(interval)) <= until ||
                   newStartTime >= StartTime && until < StartTime)
            {
                yield return this with { StartTime = newStartTime };
                // The next add would land after `until`.
                // However, when `newStartTime.Add(interval)` wraps around midnight, this loop would run forever.
                // Thus, abort early.
                if (newStartTime == until) break;
            }
        }

        /// <summary>
        /// Repeat this <see cref="TripCreate"/> instance <paramref name="totalNumberOfTrips"/> times.
        /// </summary>
        /// <param name="interval">The time between each of the trips that will be created.</param>
        /// <param name="totalNumberOfTrips">The total number of <see cref="TripCreate"/>s that will be created, including this <see cref="TripCreate"/>.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of the <see cref="TripCreate"/>s to create,
        /// including the original <see cref="TripCreate"/>.</returns>
        public IEnumerable<TripCreate> AlsoEvery(TimeSpan interval, int totalNumberOfTrips)
        {
            var newStartTime = StartTime;
            while (totalNumberOfTrips-- > 0)
            {
                yield return this with { StartTime = newStartTime };
                newStartTime = newStartTime.Add(interval);
            }
        }
    }

    /// <summary>
    /// The end-user-friendly name of this <see cref="Line"/>, e.g. line number.
    /// </summary>
    public required string Name { get; init; }

    private readonly Route[] _routes = null!; // Will be set by *required* init-er below.

    /// <summary>
    /// All <see cref="Line.Route"/>s assigned to this <see cref="Line"/>.
    /// </summary>
    public required Route[] Routes
    {
        get => _routes;
        init
        {
            _routes = value;
            foreach (var route in Routes)
            {
                route.Line = this;
                // Validate that stop distances length matches route length.
                Debug.Assert(
                    route.TimeProfiles.All(profile => profile.StopDistances.Length == route.StopPositions.Length - 1),
                    $"For {this.Name}, {route.ToString()}, at least one time profile has an incorrect stop distance count.");
            }
        }
    }

    /// <summary>
    /// Get the minimum and maximum time it takes to travel from <c>from</c> to <c>to</c> using all <see cref="Line.Route"/>s and all of their <see cref="Line.Route.TimeProfile"/>s.
    /// </summary>
    public (TimeSpan minimum, TimeSpan maximum) TimeBetweenStops(Stop from, Stop to)
    {
        if (from == to) return (TimeSpan.Zero, TimeSpan.Zero);
        var currentMinimum = TimeSpan.MaxValue;
        var currentMaximum = TimeSpan.MinValue;
        foreach (var route in Routes)
        {
            var fromExists = route.TryGetIndexOfStop(from, out var fromIndex);
            var toExists = route.TryGetIndexOfStop(to, out var toIndex);
            if (!(fromExists && toExists)) continue;
            if (fromIndex > toIndex) continue;
            var (min, max) = route.TimeBetweenStops(fromIndex, toIndex);
            currentMinimum = Min(currentMinimum, min);
            currentMaximum = Max(currentMaximum, max);
        }

        return (currentMinimum, currentMaximum);

        static TimeSpan Min(TimeSpan a, TimeSpan b) => a < b ? a : b;
        static TimeSpan Max(TimeSpan a, TimeSpan b) => a > b ? a : b;
    }

    /// <summary>
    /// Iterator over all <see cref="Line.Trip"/>s included in this <see cref="Line"/>.
    /// </summary>
    public IEnumerable<Trip> Trips => TripsCreate.Select(trip => new Trip
    {
        Line = this,
        Route = Routes[trip.RouteIndex],
        StartTime = trip.StartTime,
        TimeProfile = Routes[trip.RouteIndex].TimeProfiles[trip.TimeProfileIndex],
        DaysOfOperation = trip.DaysOfOperation,
        Annotations = trip.AnnotationSymbols
            .Select(symbol => new Trip.ManualAnnotation { Symbol = symbol, Text = Annotations[symbol] }).ToList(),
        Connections = trip.Connections,
    });

    /// <summary>
    /// Iterate over all <see cref="Line.Trip"/>s included in the <see cref="Line.Route"/> at index <c>routeIndex</c> in this <see cref="Line"/>.
    /// </summary>
    public IEnumerable<Trip> TripsOfRouteIndex(Index routeIndex) =>
        Trips.Where(trip => trip.Route == Routes[routeIndex]);

    /// <summary>
    /// All <see cref="TripCreate"/>s used to specify which <see cref="Line.Trip"/>s exist for this <see cref="Line"/>.
    /// </summary>
    public required ICollection<TripCreate> TripsCreate { get; init; }

    /// <summary>
    /// Which medium of transportation is the one used by this <see cref="Line"/>.
    /// </summary>
    public required TransportationType TransportationType { get; init; }

    // public required Stop[] NotableStops { get; init; }

    /// <summary>
    /// <see cref="Line.Route"/>s that are considered to be primary <see cref="Line.Route"/>s for this <see cref="Line"/>.
    /// <br/><br/>
    /// These can be <see cref="Line.Route"/>s that are frequently operated or form some other kind of importantness
    /// to either the line or the stops it takes along the route.
    /// </summary>
    public IEnumerable<Route> MainRoutes => MainRouteIndices.Select(index => Routes[index]);

    /// <summary>
    /// Specifies the indices of the <see cref="Line.Route"/>s that are considers <see cref="MainRoutes"/>.
    /// </summary>
    public required Index[] MainRouteIndices { get; init; }

    /// <summary>
    /// <see cref="Line.Route"/>s that are considered to be representative <see cref="Line.Route"/>s for this <see cref="Line"/>.
    /// <br/><br/>
    /// These are typically the longest routes regularly operated by this <see cref="Line"/>,
    /// even if such routes would only be operated occasionally, e.g. only during rush hour.
    /// </summary>
    public IEnumerable<Route> OverviewRoutes => OverviewRouteIndices.Select(index => Routes[index]);

    /// <summary>
    /// Specifies the indices of the <see cref="Line.Route"/>s that are considers <see cref="OverviewRoutes"/>.
    /// </summary>
    public required Index[] OverviewRouteIndices { get; init; }

    /// <summary>
    /// Manual annotations, indexed by their symbol, mapping to their text.
    /// </summary>
    public Dictionary<string, string> Annotations { get; init; } = new();

    /// <summary>
    /// The typical time of day where this <see cref="Line"/> operates.
    /// Defaults to <see cref="LineOperationTime.Daytime"/>.
    /// </summary>
    public LineOperationTime OperationTime { get; init; } = LineOperationTime.Daytime;

    /// <summary>
    /// Checks whether this <see cref="Line"/> has a <see cref="Line.Route"/> that includes <paramref name="stop"/>.
    /// </summary>
    /// <param name="stop">The <see cref="Stop"/> to check for.</param>
    /// <param name="onlyMainRoutes">Whether to ignore all non-<see cref="MainRoutes"/>-<see cref="Line.Route"/>s.</param>
    /// <param name="onlyDepartures">Whether to ignore all <see cref="Stop"/>s that do not have a departure, i.e. are the last <see cref="Stop"/> of a <see cref="Line.Route"/>.</param>
    /// <returns>Whether the <paramref name="stop"/> fulfills the given criteria.</returns>
    public bool DoesStopAt(Stop stop, bool onlyMainRoutes, bool onlyDepartures) =>
        (onlyMainRoutes ? MainRoutes : Routes).Any(route => route.DoesStopAt(stop, onlyDepartures));
}

/// <summary>
/// A helper class for <see cref="NaturalCustomerOrdering{TCollection}"/>.
/// </summary>
public static class LineOrdering
{
    /// <summary>
    /// Order a collection of lines by their natural order towards customers.
    /// This order is as follows:
    /// <br/>1. Long-distance trains
    /// <br/>2. Regional trains
    /// <br/>3. S-Bahn
    /// <br/>4. U-Bahn
    /// <br/>5. Tram
    /// <br/>6. Bus
    /// <br/>7. Ferry
    /// <br/>
    /// Each group in itself is ordered as follows:
    /// <br/>1. All lines that are not night-only precede all night-only lines.
    /// <br/>2. Lines are ordered alphabetically according to the *current culture*.
    /// </summary>
    public class NaturalCustomerLineComparer : IComparer<Line>
    {
        /// <inheritdoc />
        public int Compare(Line? x, Line? y)
        {
            // Default comparer stuff...
            if (ReferenceEquals(x, y)) return 0;
            if (y is null) return 1;
            if (x is null) return -1;
            // 1. Order by type.
            if (x.TransportationType != y.TransportationType)
                return x.TransportationType.CompareTo(y.TransportationType);
            // 2. Order by night-only/not night-only.
            var xIsNightOnly = x.OperationTime is LineOperationTime.Nighttime;
            var yIsNightOnly = y.OperationTime is LineOperationTime.Nighttime;
            if (xIsNightOnly != yIsNightOnly)
                return xIsNightOnly ? 1 : -1;
            // 3. Order by name using current culture.
            return string.Compare(x.Name, y.Name, StringComparison.CurrentCulture);
        }
    }

    /// <summary>
    /// Order a collection of lines according to <see cref="NaturalCustomerLineComparer"/>.
    /// </summary>
    public static IOrderedEnumerable<Line> NaturalCustomerOrdering<TCollection>(this TCollection collection)
        where TCollection : IEnumerable<Line> => collection.OrderBy(line => line, new NaturalCustomerLineComparer());
}

// file static class MedianExtension
// {
//     // Source: https://stackoverflow.com/a/70164857
//     public static double Median<T>(this IReadOnlyCollection<T> list, Func<T, long> selector) => list.Select(selector).OrderBy(x => x)
//         .Skip((list.Count - 1) / 2).Take(2 - list.Count % 2).Average();
// }