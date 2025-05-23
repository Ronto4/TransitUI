using System.Globalization;
using System.Numerics;

namespace Timetable.Views;

/// <summary>
/// A function to compare two instances of <typeparamref name="T"/> for some definition of equality.
/// </summary>
public delegate bool Comparer<in T>(T x, T y);

file static class EnumerableExtensions
{
    public static IReadOnlyCollection<T> AsReadOnlyCollection<T>(this IEnumerable<T> collection) => collection switch
    {
        T[] array => new ArraySegment<T>(array),
        _ => throw new NotImplementedException(),
    };

    public static int IndexOf<TSource>(this IEnumerable<TSource> collection, TSource element, int startIndex,
        Comparer<TSource> comparer)
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

/// <summary>
/// A wrapper around a line timetable.
/// </summary>
public class TimetableView
{
    /// <summary>
    /// One column in a line timetable.
    /// </summary>
    public interface ITimetableColumn
    {
        /// <summary>
        /// The days that should be printed as the operating days of this <see cref="ITimetableColumn"/>.
        /// <c>null</c> to be used for columns not requiring this information.
        /// </summary>
        public DaysOfOperation? DaysOfOperation { get; }

        /// <summary>
        /// All annotation symbols that need to be displayed for this <see cref="ITimetableColumn"/>.
        /// </summary>
        public List<string> AnnotationSymbols { get; }

        /// <summary>
        /// What to print at position <paramref name="index"/> of this <see cref="ITimetableColumn"/>.
        /// </summary>
        public string? ElementAt(int index);
    }

    /// <summary>
    /// An <see cref="ITimetableColumn"/> used to display that the neighbouring <see cref="ITimetableColumn"/> are separated by a fixed <see cref="Interval"/>.
    /// </summary>
    public record FrequencyColumn : ITimetableColumn
    {
        /// <summary>
        /// The frequency to display.
        /// </summary>
        public required TimeSpan Interval { get; init; }

        /// <summary>
        /// The row at which the first time entry is present.
        /// </summary>
        public required int StartRow { get; init; }

        DaysOfOperation? ITimetableColumn.DaysOfOperation => null;

        List<string> ITimetableColumn.AnnotationSymbols => [];

        string? ITimetableColumn.ElementAt(int index) => StartRow > 0 ? index switch
            {
                _ when index == StartRow - 1 => Interval.TotalMinutes.ToString(CultureInfo.CurrentCulture),
                _ when index == StartRow => @"\/",
                _ => null,
            } :
            index == 0 ? $@"{Interval.TotalMinutes.ToString(CultureInfo.CurrentCulture)} \/" : null;
    }

    /// <summary>
    /// An <see cref="ITimetableColumn"/> used to display one or more <see cref="Timetable.Line.Trip"/>s.
    /// </summary>
    public record TripView : ITimetableColumn
    {
        /// <summary>
        /// One cell in this <see cref="ITimetableColumn"/>.
        /// </summary>
        public record TimeEntry
        {
            /// <summary>
            /// The kind of <see cref="TimeEntry"/>.
            /// </summary>
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

            /// <summary>
            /// The kind of <see cref="TimeEntry"/>.
            /// </summary>
            public Variant Type { get; private init; }

            /// <summary>
            /// The time to display in the timetable in this cell.
            /// <c>null</c> if and only if the <see cref="Type"/> is not <see cref="Variant.Time"/>.
            /// </summary>
            public TimeOnly? Time { get; private init; }

            /// <summary>
            /// Create a new <see cref="TimeEntry"/> with <see cref="Type"/> <see cref="Variant.Time"/> at <paramref name="time"/>.
            /// </summary>
            public static TimeEntry FromTime(TimeOnly time) => new()
            {
                Type = Variant.Time,
                Time = time,
            };

            /// <summary>
            /// Create a new <see cref="TimeEntry"/> with <see cref="Type"/> <see cref="Variant.BeforeOrAfter"/>.
            /// </summary>
            public static TimeEntry BeforeOrAfter() => new()
            {
                Type = Variant.BeforeOrAfter,
                Time = null,
            };

            /// <summary>
            /// Create a new <see cref="TimeEntry"/> with <see cref="Type"/> <see cref="Variant.Skip"/>.
            /// </summary>
            public static TimeEntry Skip() => new()
            {
                Type = Variant.Skip,
                Time = null,
            };

            /// <inheritdoc />
            public override string ToString() => Type switch
            {
                Variant.Time => Time!.Value.ToString(),
                Variant.Skip => "|",
                Variant.BeforeOrAfter => "·",
                _ => throw new ArgumentOutOfRangeException(nameof(Type), Type, "Enumerable was outside range."),
            };
        }

        /// <summary>
        /// The days on which the <see cref="Timetable.Line.Trip"/>s operate that form this <see cref="TripView"/>.
        /// </summary>
        public required DaysOfOperation DaysOfOperation { get; init; }

        DaysOfOperation? ITimetableColumn.DaysOfOperation => DaysOfOperation;
        // public required string? AnnotationSymbol { get; init; }

        /// <summary>
        /// All annotation symbols to be displayed for this <see cref="TripView"/>.
        /// </summary>
        public required List<string> AnnotationSymbols { get; init; }

        /// <summary>
        /// The row-wise time entries of this <see cref="TripView"/>.
        /// </summary>
        public required ICollection<TimeEntry> Times { get; init; }

        string ITimetableColumn.ElementAt(int index) => Times.ElementAt(index).ToString();
    }

    /// <summary>
    /// All <see cref="Timetable.Line.Trip"/>s that should be displayed in this <see cref="TimetableView"/>.
    /// </summary>
    public required IReadOnlyCollection<Line.Trip> SourceTrips { private get; init; }

    /// <summary>
    /// The days that should be considered when creating this <see cref="TimetableView"/>.
    /// </summary>
    public required DaysOfOperation DaysOfOperation { get; init; }

    /// <summary>
    /// Whether to collapse neighbouring <see cref="TripView"/>s when they form a fixed interval.
    /// </summary>
    public required bool DoCollapseTrips { get; init; }

    /// <summary>
    /// The first day on which this timetable is valid.
    /// </summary>
    public required DateOnly DayOfTimetable { get; init; }

    private readonly Dictionary<string, string> _manualAnnotations = new();

    /// <summary>
    /// All <see cref="Timetable.Line.Trip.ManualAnnotation"/>s used in this <see cref="TimetableView"/>.
    /// </summary>
    public IReadOnlyCollection<Line.Trip.ManualAnnotation> ManualAnnotations => _manualAnnotations
        .Select(kvp => new Line.Trip.ManualAnnotation { Symbol = kvp.Key, Text = kvp.Value }).ToArray();

    /// <summary>
    /// How two <see cref="Timetable.Stop.Position"/>s should be compared for equality when looking to collapse identical <see cref="Timetable.Stop.Position"/>s from different <see cref="Timetable.Line.Route"/>s.
    /// Defaults to an equality check of their respective <see cref="Timetable.Stop"/>'s <see cref="Timetable.Stop.FullName"/>s.
    /// </summary>
    public Func<TimetableView, Comparer<Stop.Position>> GetPositionEqualityProvider { private get; init; } =
        timetableView => (a, b) =>
            a.Stop.FullName(timetableView.DayOfTimetable) == b.Stop.FullName(timetableView.DayOfTimetable);

    private ICollection<Stop>? _stops = null;
    private ICollection<ITimetableColumn>? _trips = null;

    /// <summary>
    /// All <see cref="Timetable.Stop"/>s in the order they should be displayed in (as they appear in the used <see cref="Timetable.Line.Route"/>s).
    /// </summary>
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

    /// <summary>
    /// All <see cref="ITimetableColumn"/>s in the order they should be displayed in (chronologically).
    /// </summary>
    public ICollection<ITimetableColumn> Trips
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
                               .IndexOf(position, currentStartPosition, GetPositionEqualityProvider(this))) >= 0)
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
        var trips = CleanTrips(SourceTrips, DaysOfOperation).ToList();
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
            AnnotationSymbols = trip.Annotations.Select(annotation =>
            {
                if (!_manualAnnotations.ContainsKey(annotation.Symbol))
                {
                    _manualAnnotations.Add(annotation.Symbol, annotation.Text);
                }

                return annotation.Symbol;
            }).ToList(),
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
        var tripViews = allTrips.ToList();
        for (var positionIndex = allPositions.Count - 1; positionIndex >= 0; --positionIndex)
        {
            tripViews = tripViews
                .OrderBy(
                    tripView => tripView.Times.ElementAt(positionIndex).Time,
                    new NullableTimeOnlyComparer(new TimeOnly(3, 0))
                )
                .ToList();
        }

        _trips = DoCollapseTrips ? CollapseTrips(tripViews, DaysOfOperation).ToList() : [..tripViews];

        _stops = allPositions.Select(position => position.Stop).ToList();
    }

    private static IEnumerable<ITimetableColumn> CollapseTrips(List<TripView> trips, DaysOfOperation tripDays)
    {
        // Up to two trips *never* create an interval.
        if (trips.Count < 3)
        {
            foreach (var tmp in trips)
                yield return tmp;
            yield break;
        }

        var intervals = GetIntervals(trips, tripDays);

        var intervalsIndices = intervals.Select((interval, index) => (interval, index)).ToList();
        List<int> indicesToYield =
        [
            // The first entry is always required.
            0,
            // Before every `null`
            ..intervalsIndices.Where(tuple => tuple.interval is null).Select(tuple => tuple.index),
            // In-between every change
            ..intervalsIndices.Where(tuple => tuple.index != 0)
                .Where(tuple => tuple.interval != intervals[tuple.index - 1]).Select(tuple => tuple.index),
            // The last entry is always required.
            trips.Count - 1,
        ];
        indicesToYield = indicesToYield.Order().Distinct().ToList();
        var lastYieldedIndex = -1;
        foreach (var index in indicesToYield)
        {
            if (index - lastYieldedIndex > 1)
                yield return new FrequencyColumn
                {
                    Interval = intervals[index - 1] ?? throw new NullReferenceException(),
                    StartRow = GetFirstTimeEntryRow(trips[index])
                };
            yield return trips[index];
            lastYieldedIndex = index;
        }

        yield break;

        static TimeSpan?[] GetIntervals(List<TripView> trips, DaysOfOperation tripDays)
        {
            var intervals = new TimeSpan?[trips.Count - 1];
            for (var i = 1; i < trips.Count; i++)
            {
                var previous = trips[i - 1];
                var current = trips[i];
                var interval = current.Times.First(time => time.Time is not null).Time!.Value -
                               previous.Times.First(time => time.Time is not null).Time!.Value;
                // The trips happen at different days -> no interval.
                if ((previous.DaysOfOperation & tripDays) != (current.DaysOfOperation & tripDays)) continue;
                // The trips are annotated differently -> no interval.
                if (!previous.AnnotationSymbols.SequenceEqual(current.AnnotationSymbols)) continue;
                // There is at least one stop where the trips do not differ by exactly the interval -> no interval.
                if (previous.Times.Zip(current.Times,
                        (previousTimeEntry, currentTimeEntry) =>
                            previousTimeEntry.Time?.Add(interval) != currentTimeEntry.Time).Any(b => b)) continue;
                intervals[i - 1] = interval;
            }

            return intervals;
        }

        static int GetFirstTimeEntryRow(TripView trip) => trip.Times.Select((time, index) => (time, index))
            .First(tuple => tuple.time.Time is not null).index;
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

    private static IEnumerable<Line.Trip> CleanTrips(IEnumerable<Line.Trip> trips, DaysOfOperation daysOfOperation)
    {
        // Sort. Consider every start of a trip until 01:15 LOC as belonging to the previous day.
        // Also, remove all trips that are only on other days.
        var sortedTrips = trips
            .Where(trip => (trip.DaysOfOperation & daysOfOperation) != DaysOfOperation.None)
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
                .Where(other =>
                    trip.StartTime == other.other.StartTime && trip.TimeProfile == other.other.TimeProfile &&
                    trip.Annotations.SequenceEqual(other.other.Annotations))
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
