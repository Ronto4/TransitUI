namespace Timetables.Models;

public record Line
{
    public record Route
    {
        public override string ToString() => $"{StopPositions.First().Name} > {StopPositions.Last().Name}";

        public record TimeProfile
        {
            public required TimeSpan[] StopDistances { get; init; }
        }

        public required Stop.Position[] StopPositions { get; init; }
        public required TimeProfile[] TimeProfiles { get; init; }

        /// <summary>
        /// The stop that is used when calculating frequencies.
        /// It is advised that the departure time does not vary due to time adjustments at this stop.
        /// </summary>
        public required int CommonStopIndex { get; init; }
    }

    public record Trip
    {
        public required Route Route { get; init; }
        public required Route.TimeProfile TimeProfile { get; init; }
        public required TimeOnly StartTime { get; init; }
        public required DaysOfOperation DaysOfOperation { get; init; }

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
        public required Index RouteIndex { get; init; }
        public required Index TimeProfileIndex { get; init; }
        public required TimeOnly StartTime { get; init; }
        public required DaysOfOperation DaysOfOperation { get; init; }

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
            while ((newStartTime = newStartTime.Add(interval)) <= until)
            {
                yield return this with { StartTime = newStartTime };
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
    public required Route[] Routes { get; init; }
    public Trip[] Trips { get; private init; } = null!; // Will be set below.

    public required IEnumerable<TripCreate> TripsCreate
    {
        init
        {
            Trips = value.Select(trip => new Trip
            {
                Route = Routes[trip.RouteIndex], StartTime = trip.StartTime,
                TimeProfile = Routes[trip.RouteIndex].TimeProfiles[trip.TimeProfileIndex],
                DaysOfOperation = trip.DaysOfOperation
            }).ToArray();
        }
    }

    public required TransportationType TransportationType { get; init; }

    public Dictionary<Route, List<string>> GetFrequencies(List<(TimeOnly startTime, TimeOnly endTime)> timeLimits,
        DaysOfOperation daysOfOperation)
    {
        const string none = "—";
        const string singleTrips = "EF";
        return new Dictionary<Route, List<string>>(Trips
            .Where(trip => (trip.DaysOfOperation & daysOfOperation) == daysOfOperation)
            .GroupBy(trip => trip.Route)
            .Select(tripGroups =>
            {
                return new KeyValuePair<Route, List<string>>(tripGroups.Key, timeLimits.Select(timeLimit =>
                {
                    var trips = tripGroups.OrderBy(trip => trip.TimeAtCommonStop()).ToList();
                    var (startTime, endTime) = timeLimit;
                    Func<Trip, bool> condition = startTime < endTime
                        ? trip => trip.TimeAtCommonStop() >= startTime && trip.TimeAtCommonStop() < endTime
                        : trip => trip.TimeAtCommonStop() >= startTime || trip.TimeAtCommonStop() < endTime;
                    var tripsInTime = trips
                        .Where(condition)
                        .ToList();
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

                    // Check if there are enough trips to cover the time.
                    {
                        var averageInterval = TimeSpan.FromTicks((long)intervals.Average(interval => interval.Ticks));
                        var totalTime = endTime - startTime;
                        var tripsRequiredForFullCover = totalTime / averageInterval;
                        const double requiredRatio = 0.6;
                        if (tripsInTime.Count / tripsRequiredForFullCover < requiredRatio)
                        {
                            // There are not enough trips.
                            // Maybe there is a sensible interval, but it is too infrequent to be worth reporting.
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
                    var minimumInterval = intervals.Min();
                    var maximumInterval = intervals.Max();
                    return $"{minimumInterval}–{maximumInterval}";
                    // // Check histogram
                    // var frequencies = intervals
                    //     .GroupBy(self => self)
                    //     .Select(group => (Interval: group.Key, Frequency: group.Count()))
                    //     .OrderBy(group => group.Frequency)
                    //     .ToList();
                    // var rarestFrequency = frequencies.First();
                    // var mostCommonFrequency = frequencies.Last();
                }).ToList());
            }));
    }
}
