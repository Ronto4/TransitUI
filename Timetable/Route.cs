namespace Timetable;

public partial record Line
{
    /// <summary>
    /// A route of the network, connecting multiple <see cref="Stop.Position"/>s.
    /// Different routes, even ones using a proper, contiguous subset of positions
    /// must be represented using multiple routes.
    /// </summary>
    public partial record Route
    {
        /// <inheritdoc />
        public override string ToString() => //throw new NotImplementedException();
            $"{StopPositions.First().Stop} {(InterpretAsBidirectional ? "–" : ">")} {StopPositions.Last().Stop}{(ManualAnnotation is null ? "" : $" {ManualAnnotation}")}";

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
        /// Get all indices of all occurrences of <paramref name="stop"/> in this route.
        /// </summary>
        public IEnumerable<int> GetIndicesOfStop(Stop stop) => StopPositions.Select((pos, index) => (pos, index))
            .Where(tuple => tuple.pos.Stop == stop).Select(tuple => tuple.index);

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
                    $"The provided stop {stop.NameAt(new DateOnly())} is not part of the route from {StopPositions.First().Stop.NameAt(new DateOnly())} to {StopPositions.Last().Stop.NameAt(new DateOnly())}.",
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
            index = Array.IndexOf(StopPositions, stop);
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
        /// Get the same route as this but omitting all <paramref name="stopsToExclude"/>.
        /// </summary>
        public Route WithoutStops(IEnumerable<Stop> stopsToExclude) =>
            stopsToExclude.Aggregate(this, (route, stopToExclude) => route.WithoutStop(stopToExclude));

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
        /// Return this same <see cref="Line.Route"/>, with <paramref name="inserted"/>
        /// between <paramref name="before"/> and <paramref name="after"/>,
        /// if those two stations exist and are next to each other.
        /// </summary>
        /// <returns></returns>
        public Route WithStopBetween(Stop before, Stop.Position inserted, Stop after, TimeSpan firstTime, TimeSpan secondTime)
        {
            var beforeIndex = Array.IndexOf(StopPositions, before);
            if (beforeIndex == -1) return this;
            var afterIndex = Array.IndexOf(StopPositions, after);
            if (afterIndex == -1) return this;
            if (afterIndex != beforeIndex + 1) return this;
            Stop.Position[] insertedPositions =
                [..StopPositions[..(beforeIndex + 1)], inserted, ..StopPositions[afterIndex..]];
            var timeProfiles = TimeProfiles.Select(timeProfile => new TimeProfile
            {
                StopDistances =
                [
                    ..timeProfile.StopDistances[..beforeIndex], firstTime, secondTime,
                    ..timeProfile.StopDistances[afterIndex..]
                ]
            }).ToArray();
            return this with
            {
                StopPositions = insertedPositions,
                TimeProfiles = timeProfiles,
                CommonStopIndex = CommonStopIndex > beforeIndex ? CommonStopIndex + 1 : CommonStopIndex,
            };
        }

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
}
