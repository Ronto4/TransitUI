using System.Diagnostics;

namespace Timetables.Models;

public record Line
{
    public record Route
    {
        public override string ToString() =>
            $"{StopPositions.First().Name} {(InterpretAsBidirectional ? "–" : ">")} {StopPositions.Last().Name}{(ManualAnnotation is null ? "" : $" {ManualAnnotation}")}";

        public record TimeProfile
        {
            public required TimeSpan[] StopDistances { get; init; }

            /// <summary>
            /// Get the time it takes to travel from stop index <paramref name="fromIndex"/> to <paramref name="toIndex"/>.
            /// </summary>
            /// <remarks><paramref name="fromIndex"/> MUST be smaller than <paramref name="toIndex"/>!</remarks>
            public TimeSpan TimeBetweenStops(int fromIndex, int toIndex) => TimeSpan.FromTicks(StopDistances
                .Skip(fromIndex).Take(toIndex - fromIndex).Select(time => time.Ticks).Sum());
        }

        internal Line? Line { get; set; }
        public required Stop.Position[] StopPositions { get; init; }
        public required TimeProfile[] TimeProfiles { get; init; }
        
        public string? ManualAnnotation { get; init; }

        /// <summary>
        /// The stop that is used when calculating frequencies.
        /// It is advised that the departure time does not vary due to time adjustments at this stop.
        /// </summary>
        public required int CommonStopIndex { get; init; }
        
        /// <summary>
        /// Get the minimum and maximum time it takes to travel from stop index <see cref="fromIndex"/> to <see cref="toIndex"/>
        /// depending on the time profiles.
        /// </summary>
        public (TimeSpan minimum, TimeSpan maximum) TimeBetweenStops(int fromIndex, int toIndex)
        {
            if (toIndex < fromIndex) throw new ArgumentException($"The indices are swapped: {fromIndex} -> {toIndex}");
            var times = TimeProfiles.Select(profile => profile.TimeBetweenStops(fromIndex, toIndex)).ToList();
            return (times.Min(), times.Max());
        }

        public (TimeSpan minimum, TimeSpan maximum) TimeBetweenStops(Stop from, Stop to) =>
            TimeBetweenStops(GetIndexOfStop(from), GetIndexOfStop(to));

        public (TimeSpan minimum, TimeSpan maximum) TimeBetweenStops(Stop from, int toIndex) =>
            TimeBetweenStops(GetIndexOfStop(from), toIndex);

        public int GetIndexOfStop(Stop stop)
        {
            var exists = TryGetIndexOfStop(stop, out var index);
            return exists
                ? index
                : throw new ArgumentException(
                    $"The provided stop {stop.DisplayName} is not part of the route from {StopPositions.First().Stop.DisplayName} to {StopPositions.Last().Stop.DisplayName}.",
                    nameof(stop));
        }
        
        public int GetIndexOfStopFirst(Stop stop)
        {
            var exists = TryGetIndexOfStopFirst(stop, out var index);
            return exists
                ? index
                : throw new ArgumentException(
                    $"The provided stop {stop.DisplayName} is not part of the route from {StopPositions.First().Stop.DisplayName} to {StopPositions.Last().Stop.DisplayName}.",
                    nameof(stop));
        }

        public bool TryGetIndexOfStop(Stop stop, out int index)
        {
            index = StopPositions.Select((position, index) => (position.Stop, index))
                .SingleOrDefault(tuple => stop == tuple.Stop, (Stop: stop, index: -1)).index;
            return index != -1;
        }
        
        public bool TryGetIndexOfStopFirst(Stop stop, out int index)
        {
            index = StopPositions.Select((position, index) => (position.Stop, index))
                .FirstOrDefault(tuple => stop == tuple.Stop, (Stop: stop, index: -1)).index;
            return index != -1;
        }

        public bool DoesStopAt(Stop stop, bool onlyDepartures) => StopPositions
            .Take(StopPositions.Length - (onlyDepartures
                ? /* when we only want departures, the last stop is no longer relevant */ 1
                : 0)).Select(pos => pos.Stop).Contains(stop);

        public bool LooslyIsReverse(Route other) => StopPositions.Last().Stop == other.StopPositions.First().Stop &&
                                                    StopPositions.First().Stop == other.StopPositions.Last().Stop;

        public bool LooslyIsSame(Route other) => InterpretAsBidirectional == other.InterpretAsBidirectional &&
                                                 StopPositions.First().Stop == other.StopPositions.First().Stop &&
                                                 StopPositions.Last().Stop == other.StopPositions.Last().Stop;

        public bool StrictlyIsReverse(Route other) => StopPositions.Select(position => position.Stop).Reverse()
            .SequenceEqual(other.StopPositions.Select(position => position.Stop));

        public bool StrictlyIsSame(Route other) => InterpretAsBidirectional == other.InterpretAsBidirectional &&
                                                   StopPositions.Select(position => position.Stop)
                                                       .SequenceEqual(
                                                           other.StopPositions.Select(position => position.Stop));

        public bool InterpretAsBidirectional { get; set; } = false;

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

        public int? TripCount(DaysOfOperation days) => Line?.Trips.Where(trip => trip.Route == this)
            .Select(trip => int.PopCount((int)(trip.DaysOfOperation & days))).Sum();
    }

    public record Trip
    {
        public record AnnotationDefinition(string Symbol, string Text);
        public required Line Line { get; init; }
        public required Route Route { get; init; }
        public required Route.TimeProfile TimeProfile { get; init; }
        public required TimeOnly StartTime { get; init; }
        public required DaysOfOperation DaysOfOperation { get; init; }
        public required List<AnnotationDefinition> Annotations { get; init; }

        public TimeOnly TimeAtCommonStop() => TimeAtStop(Route.CommonStopIndex);

        public TimeOnly TimeAtStop(int stopIndex)
        {
            var time = StartTime;
            while (stopIndex-- > 0)
            {
                time = time.Add(TimeProfile.StopDistances[stopIndex]);
            }

            return time;
        }
    }

    public readonly record struct TripCreate
    {
        public TripCreate()
        {
        }

        public required Index RouteIndex { get; init; }
        public required Index TimeProfileIndex { get; init; }
        public required TimeOnly StartTime { get; init; }
        public required DaysOfOperation DaysOfOperation { get; init; }

        [Obsolete($"Use {nameof(AnnotationSymbols)} instead.", false)]
        public string AnnotationSymbol
        {
            init => AnnotationSymbols.Add(value);
        }

        public List<string> AnnotationSymbols { get; init; } = [];

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

    public required string Name { get; init; }
    private readonly Route[] _routes = null!; // Will be set by *required* init-er below.
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

    public IEnumerable<Trip> Trips => TripsCreate.Select(trip => new Trip
    {
        Line = this,
        Route = Routes[trip.RouteIndex],
        StartTime = trip.StartTime,
        TimeProfile = Routes[trip.RouteIndex].TimeProfiles[trip.TimeProfileIndex],
        DaysOfOperation = trip.DaysOfOperation,
        Annotations = trip.AnnotationSymbols.Select(symbol => new Trip.AnnotationDefinition(symbol, Annotations[symbol])).ToList(),
        // Annotations = trip.AnnotationSymbol is { } symbol ? new Trip.AnnotationDefinition(symbol, Annotations[symbol]) : null,
    });

    public required ICollection<TripCreate> TripsCreate { internal get; init; }

    public required TransportationType TransportationType { get; init; }

    // public required Stop[] NotableStops { get; init; }
    public IEnumerable<Route> MainRoutes => MainRouteIndices.Select(index => Routes[index]);

    public required Index[] MainRouteIndices { get; init; }
    public IEnumerable<Route> OverviewRoutes => OverviewRouteIndices.Select(index => Routes[index]);

    public required Index[] OverviewRouteIndices { get; init; }

    public Dictionary<string, string> Annotations { get; init; } = new();

    public LineOperationTime OperationTime { get; init; } = LineOperationTime.Daytime;

    public bool DoesStopAt(Stop stop, bool onlyMainRoutes, bool onlyDepartures) =>
        (onlyMainRoutes ? MainRoutes : Routes).Any(route => route.DoesStopAt(stop, onlyDepartures));

    public Dictionary<Route, List<string>> GetFrequencies(List<(TimeOnly startTime, TimeOnly endTime)> timeLimits,
        DaysOfOperation daysOfOperation)
    {
        const string none = "—";
        const string singleTrips = "EF";
        // Reset all bidirectional annotations.
        foreach (var route in Routes)
        {
            route.InterpretAsBidirectional = false;
        }

        var result = Trips
            .Where(trip => (trip.DaysOfOperation & daysOfOperation) == daysOfOperation)
            .GroupBy(trip => trip.Route)
            .Select(tripGroups => new KeyValuePair<Route, List<string>>(tripGroups.Key, timeLimits.Select(timeLimit =>
            {
                var (startTime, endTime) = timeLimit;
                var trips = startTime < endTime
                    ? tripGroups.OrderBy(trip => trip.TimeAtCommonStop()).ToList()
                    : tripGroups.ToList(); // When the time wraps around, we cannot sort.
                Func<Trip, bool> condition = startTime < endTime
                    ? trip => trip.TimeAtCommonStop() >= startTime && trip.TimeAtCommonStop() < endTime
                    : trip => trip.TimeAtCommonStop() >= startTime || trip.TimeAtCommonStop() < endTime;
                var tripsInTime = trips
                    .Where(condition)
                    .ToList();
                // Console.WriteLine($"{tripGroups.Key} in {timeLimit}: {string.Join(", ", tripsInTime.Select(trip => trip.TimeAtCommonStop()))}");
                if (tripsInTime.Count == 0)
                {
                    return none;
                }

                var intervals = new List<TimeSpan>();
                for (var i = 1; i < tripsInTime.Count; ++i)
                {
                    intervals.Add(tripsInTime[i].TimeAtCommonStop() - tripsInTime[i - 1].TimeAtCommonStop());
                }

                if (intervals.Count == 0)
                {
                    return singleTrips;
                }

                // Check histogram (only if there is more than one different interval).
                var frequencies = intervals
                    .GroupBy(self => self)
                    .Select(group => (Interval: group.Key, Frequency: group.Count()))
                    .OrderBy(group => group.Frequency)
                    .ToList();
                if (frequencies.Count > 1)
                {
                    var rarestFrequency = frequencies.First();
                    var secondRarestFrequency = frequencies.Skip(1).First();
                    if (rarestFrequency.Frequency == 1 &&
                        secondRarestFrequency.Frequency > rarestFrequency.Frequency)
                    {
                        var mostCommonFrequency = frequencies.Last();
                        const int requiredFrequency = 3;
                        if (mostCommonFrequency.Frequency >= requiredFrequency)
                        {
                            // There is a unique rarest interval that occurs once, and the most common interval occurs quite often.
                            // This indicates that the rarest interval is not an interval change but rather a change in departure minutes, so remove it.
                            intervals = intervals.Where(interval => interval != rarestFrequency.Interval).ToList();
                        }
                    }
                }

                // Check if there are enough trips to cover the time.
                {
                    // // Ignore largest interval.
                    // var intervalSum = intervals.Sum(interval => interval.Ticks);
                    // // intervalSum -= intervals.MinBy(interval => interval.Ticks).Ticks;
                    // intervalSum -= intervals.MaxBy(interval => interval.Ticks).Ticks;
                    // var averageInterval = intervals.Count - 1 > 0
                    //     ? TimeSpan.FromTicks((long)(intervalSum / (double)(intervals.Count - 1)))
                    //     // If there is just one interval, use that instead.
                    //     : intervals.Single();
                    //     // If there is only one or two intervals, use their average instead.
                    //     // : TimeSpan.FromTicks((long)intervals.Average(interval => interval.Ticks));
                    var averageInterval = TimeSpan.FromTicks((long)intervals.Average(interval => interval.Ticks));
                    // var medianInterval = TimeSpan.FromTicks((long)intervals.Median(interval => interval.Ticks));
                    var totalTime = endTime - startTime;
                    var tripsRequiredForFullCover = totalTime / averageInterval;
                    const double requiredRatio = 0.54;
                    if (tripsInTime.Count / tripsRequiredForFullCover < requiredRatio)
                    {
                        // There are not enough trips.
                        // Maybe there is a sensible interval, but it is too infrequent to be worth reporting.
                        // Console.Error.WriteLine($"{timeLimit} failed ratio check with {tripsInTime.Count / tripsRequiredForFullCover}, required was {requiredRatio}.");
                        return singleTrips;
                    }
                }

                // Check if all are identical.
                if (intervals.All(o => o == intervals[0]))
                {
                    return $"{intervals[0].TotalMinutes}";
                }

                // Check for patterns like 20/40.
                {
                    var firstInterval = intervals[0];
                    var secondInterval = intervals[1];
                    if (firstInterval == secondInterval)
                    {
                        // No pattern, use default handling.
                        goto DEFAULT;
                    }

                    for (var i = 2; i < intervals.Count; ++i)
                    {
                        var compareInterval = i % 2 == 0 ? firstInterval : secondInterval;
                        if (intervals[i] != compareInterval)
                        {
                            goto DEFAULT;
                        }
                    }

                    var smaller = TimeSpan.FromTicks(Math.Min(firstInterval.Ticks, secondInterval.Ticks));
                    var larger = TimeSpan.FromTicks(Math.Max(firstInterval.Ticks, secondInterval.Ticks));
                    return $"{smaller.TotalMinutes}/{larger.TotalMinutes}";
                }
                DEFAULT:
                // // Check histogram
                // var frequencies = intervals
                //     .GroupBy(self => self)
                //     .Select(group => (Interval: group.Key, Frequency: group.Count()))
                //     .OrderBy(group => group.Frequency)
                //     .ToList();
                // var rarestFrequency = frequencies.First();
                // var secondRarestFrequency = frequencies.Skip(1).First();
                // if (rarestFrequency.Frequency == 1 && secondRarestFrequency.Frequency > rarestFrequency.Frequency)
                // {
                //     var mostCommonFrequency = frequencies.Last();
                //     const int requiredFrequency = 3;
                //     if (mostCommonFrequency.Frequency >= requiredFrequency)
                //     {
                //         // There is a unique rarest interval that occurs once, and the most common interval occurs quite often.
                //         // This indicates that the rarest interval is not an interval change but rather a change in departure minutes, so remove it.
                //         intervals = intervals.Where(interval => interval != rarestFrequency.Interval).ToList();
                //     }
                // }
                var minimumInterval = intervals.Min();
                var maximumInterval = intervals.Max();
                return minimumInterval == maximumInterval
                    ? $"{minimumInterval.TotalMinutes}"
                    : $"{minimumInterval.TotalMinutes}–{maximumInterval.TotalMinutes}";
            }).ToList())).ToDictionary();
        foreach (var route in Routes)
        {
            if (result.ContainsKey(route)) continue;
            result.Add(route, Enumerable.Range(0, timeLimits.Count).Select(_ => none).ToList());
        }

        return result;
    }
}

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
