using System.Numerics;
using Timetables.Models;

namespace Timetables;

public delegate bool Comparer<in T>(T x, T y);

file static class EnumerableExtensions
{
    public static IReadOnlyCollection<T> AsReadOnlyCollection<T>(this IEnumerable<T> collection) => collection switch
    {
        T[] array => new ArraySegment<T>(array),
        _ => throw new NotImplementedException(),
    };

    public static int IndexOf<TSource>(this IEnumerable<TSource> collection, TSource element, int startIndex, Comparer<TSource> comparer)
    where TSource : IEqualityOperators<TSource, TSource, bool>
    {
        (TSource, int) defaultValueTuple = default;
        var firstOrDefault = collection
            .Select((source, index) => (element: source, index))
            .Skip(startIndex)
            .FirstOrDefault(pair => comparer(element, pair.element));
        return firstOrDefault == defaultValueTuple ? -1 : firstOrDefault.index;
    }
}

public class TimetableView
{
    public record TripView
    {
        public record TimeEntry
        {
            public enum Variant
            {
                /// <summary>
                /// Used to display a concrete time (e.g. `12:13`).
                /// </summary>
                Time,
                /// <summary>
                /// Used to indicate that this trip skips this stop (e.g. `|`).
                /// </summary>
                Skip,
                /// <summary>
                /// Used to indicate that this stop is either before the first or after the last trip stop in the list.
                /// May be indicated by a centred dot.
                /// </summary>
                BeforeOrAfter,
            }

            public Variant Type { get; private init; }
            public TimeOnly? Time { get; private init; }

            public static TimeEntry FromTime(TimeOnly time) => new()
            {
                Type = Variant.Time,
                Time = time,
            };

            public static TimeEntry BeforeOrAfter() => new()
            {
                Type = Variant.BeforeOrAfter,
                Time = null,
            };

            public static TimeEntry Skip() => new()
            {
                Type = Variant.Skip,
                Time = null,
            };

            public override string ToString() => Type switch
            {
                Variant.Time => Time!.Value.ToString(),
                Variant.Skip => "|",
                Variant.BeforeOrAfter => "·",
                _ => throw new ArgumentOutOfRangeException(nameof(Type), Type, "Enumerable was outside range."),
            };

            public TimeOnly? TimeOrNull() => Time;
        }

        public required DaysOfOperation DaysOfOperation { get; init; }
        public required string? AnnotationSymbol { get; init; }
        public required ICollection<TimeEntry> Times { get; init; }
    }

    public required ICollection<Line.Trip> SourceTrips { private get; init; }

    public Comparer<Stop.Position> PositionEqualityProvider { private get; init; } =
        (a, b) => a.Stop.DisplayName == b.Stop.DisplayName;

    private ICollection<Stop>? _stops = null;
    private ICollection<TripView>? _trips = null;

    public ICollection<Stop> Stops
    {
        get
        {
            if (_stops is null)
            {
                CalculateView();
            }

            return _stops!;
        }
    }

    public ICollection<TripView> Trips
    {
        get
        {
            if (_trips is null)
            {
                CalculateView();
            }

            return _trips!;
        }
    }

    private List<Stop.Position> CollapsePositions(Dictionary<int, List<int>> mapping,
        IReadOnlyCollection<IReadOnlyCollection<Stop.Position>> routes)
    {
        // Initialize mapping
        for (var i = 0; i < routes.Count; ++i)
        {
            mapping[i] = Enumerable.Range(0, routes.ElementAt(i).Count).Select(_ => -1).ToList();
        }

        var firstCollapsedIndex = routes.Select(_ => -1).ToArray();
        var positions = new List<Stop.Position>();
        for (var i = 0; i < routes.Count; ++i)
        {
            var route = routes.ElementAt(i);
            for (var j = 0; j < route.Count; ++j)
            {
                if (mapping[i][j] >= 0) continue; // This position was already collapsed by a previous route.
                var position = route.ElementAt(j);
                int addedAt;
                if (firstCollapsedIndex[i] == -1 || firstCollapsedIndex[i] < j)
                {
                    addedAt = positions.Count;
                    positions.Add(position);
                }
                else
                {
                    // The position has to be put at the start since collapsed positions are down below in the route.
                    addedAt = j;
                    positions.Insert(addedAt, position);
                    // Adjust mappings by this one offset by the added position.
                    foreach (var (_, map) in mapping)
                    {
                        for (var k = 0; k < map.Count; ++k)
                        {
                            if (map[k] == -1 || map[k] < addedAt) continue;
                            ++map[k];
                        }
                    }

                    // Adjust collapsed indices the same way as the mapping.
                    for (var k = 0; k < firstCollapsedIndex.Length; ++k)
                    {
                        if (firstCollapsedIndex[k] == -1 || firstCollapsedIndex[k] < addedAt) continue;
                        ++firstCollapsedIndex[k];
                    }
                }

                // For each route, find matching index of position (if any) and add it to the mapping.
                for (var k = 0; k < routes.Count; ++k)
                {
                    var currentStartPosition = 0;
                    int index;
                    while ((index = routes.ElementAt(k)
                               .IndexOf(position, currentStartPosition, PositionEqualityProvider)) >= 0)
                    {
                        if (mapping[k][index] >= 0)
                        {
                            // The found position was already collapsed.
                            // Continue search after the current find.
                            currentStartPosition = index + 1;
                            continue;
                        }

                        mapping[k][index] = addedAt;
                        if (k != i) // You never collapse on your own station.
                        {
                            if (firstCollapsedIndex[k] == -1 || index < firstCollapsedIndex[k])
                            {
                                firstCollapsedIndex[k] = index;
                            }
                        }

                        break;
                    }
                }
            }
        }

        return positions;
    }

    private void CalculateView()
    {
        var trips = CleanTrips(SourceTrips).ToList();
        var routes = trips.Select(trip => trip.Route).Distinct().ToList();
        var positionsLookup = routes.Select((_, index) => (index, new List<int>())).ToDictionary();
        var routeLookup = routes.Select((route, index) => (route, index)).ToDictionary();
        var allPositions = CollapsePositions(positionsLookup,
            routes.Select(route => route.StopPositions.AsReadOnlyCollection()).ToList());
        var routeFirstPositions =
            positionsLookup.Select(kv => (kv.Key, kv.Value.Where(v => v >= 0).Min())).ToDictionary();
        var routeLastPositions = positionsLookup.Select(kv => (kv.Key, kv.Value.Max())).ToDictionary();
        var allTrips = trips.Select(trip => new TripView
        {
            DaysOfOperation = trip.DaysOfOperation,
            AnnotationSymbol = trip.Annotation is {} annotation ? annotation.symbol : null,
            Times = allPositions
                .Select((_, positionIndex) => (
                    routePositionIndex: positionsLookup[routeLookup[trip.Route]].IndexOf(positionIndex),
                    index: positionIndex))
                .Select(r => r.routePositionIndex switch
                {
                    -1 => r.index >= routeFirstPositions[routeLookup[trip.Route]] &&
                          r.index <= routeLastPositions[routeLookup[trip.Route]]
                        ? TripView.TimeEntry.Skip()
                        : TripView.TimeEntry.BeforeOrAfter(),
                    _ => TripView.TimeEntry.FromTime(trip.TimeAtStop(r.routePositionIndex)),
                })
                .ToList(),
        });
        _trips = allTrips.ToList();
        for (var positionIndex = allPositions.Count - 1; positionIndex >= 0; --positionIndex)
        {
            _trips = _trips
                .OrderBy(
                    tripView => tripView.Times.ElementAt(positionIndex).TimeOrNull(),
                    new NullableTimeOnlyComparer(new TimeOnly(3, 0))
                )
                .ToList();
        }

        _stops = allPositions.Select(position => position.Stop).ToList();
    }

    private class NullableTimeOnlyComparer(TimeOnly startOfNewDay) : IComparer<TimeOnly?>
    {
        private static readonly long TotalTicks = new TimeOnly(23, 59, 59).Ticks;

        public int Compare(TimeOnly? x, TimeOnly? y)
        {
            if (x is null || y is null) return 0;
            var xVal = x.Value.Ticks - startOfNewDay.Ticks;
            xVal = xVal >= 0 ? xVal : xVal + TotalTicks;
            var yVal = y.Value.Ticks - startOfNewDay.Ticks;
            yVal = yVal >= 0 ? yVal : yVal + TotalTicks;
            var compare = xVal.CompareTo(yVal);
            return compare;
        }
    }

    private static IEnumerable<Line.Trip> CleanTrips(IEnumerable<Line.Trip> trips)
    {
        // Sort. Consider every start of a trip until 01:15 LOC as belonging to the previous day.
        var sortedTrips = trips
            .Select(trip => (trip, trip.StartTime - new TimeOnly(1, 15)))
            .OrderBy(trip => trip.Item2)
            .Select(trip => trip.trip)
            .ToList();
        // Eliminate identical trips.
        for (var i = 0; i < sortedTrips.Count; ++i)
        {
            var trip = sortedTrips[i];
            var daysOfIdenticalTrips = sortedTrips
                .Select((other, index) => (other, index))
                .Skip(i + 1)
                .Where(other => trip.StartTime == other.other.StartTime && trip.TimeProfile == other.other.TimeProfile)
                .Select(other => (other.other.DaysOfOperation, other.index))
                .ToList();
            var days = daysOfIdenticalTrips.Aggregate(trip.DaysOfOperation,
                (current, day) => current | day.DaysOfOperation);
            yield return trip with { DaysOfOperation = days };
            // Remove duplicate entries
            for (var j = 0; j < daysOfIdenticalTrips.Count; ++j)
            {
                sortedTrips.RemoveAt(daysOfIdenticalTrips[j].index - j);
            }
        }
    }
}
