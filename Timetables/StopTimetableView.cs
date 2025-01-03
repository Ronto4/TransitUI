using System.Diagnostics.Contracts;
using Timetables.Models;

namespace Timetables;

public class StopTimetableView
{
    private readonly Dictionary<string, string> _tripAnnotations = new();

    public record StopInfo
    {
        public required List<Line> ConnectionLines { get; init; }
        public required List<(TimeSpan minimumTime, TimeSpan maximumTime)?> Times { get; init; }
        public required Stop Stop { get; init; }
        public bool IsRelevantStop { get; internal set; } = false;
    }

    public record HourInfo
    {
        public record Departure
        {
            public required int Minute { get; init; }
            public required DaysOfOperation Days { get; init; }
            public required Line.Trip.AnnotationDefinition? Annotation { get; init; }
            public required int RouteIndex { get; init; }
            public required Stop TargetStop { get; init; }
        }

        public required int Hour { get; init; }
        public required IReadOnlyCollection<IReadOnlyCollection<Departure>> Departures { get; init; }
    }

    /// <summary>
    /// The stop to display as the current stop of the timetable.
    /// </summary>
    public Stop StartStop { get; }

    /// <summary>
    /// The lines contained in the timetable.
    /// </summary>
    public List<Line> Lines { get; }

    /// <summary>
    /// The stops to display as the targets of the timetable.
    /// </summary>
    public List<Stop> TargetStops { get; }

    private Dictionary<Line.Route, int> RouteToStopInfoColumnMapping { get; }
    
    public IReadOnlyCollection<DaysOfOperation> DaysPartition { get; init; }

    /// <summary>
    /// The stops to be shown in the line overview.
    /// </summary>
    public List<StopInfo> StopInfos { get; }

    public Dictionary<int, HourInfo> HourInfos { get; }

    public IReadOnlyCollection<int> MaximumColumns { get; }

    public Stop LastStopOfRoute(int routeIndex) =>
        StopInfos.Last(stopInfo => stopInfo.Times[routeIndex] is not null).Stop;

    public IReadOnlyCollection<Line.Trip.AnnotationDefinition> TripAnnotations => _tripAnnotations
        .Select(kvp => new Line.Trip.AnnotationDefinition(kvp.Key, kvp.Value)).ToArray();

    private Dictionary<(Stop stop, int routeIndex), char> TargetStopAnnotations { get; } = new();

    public IReadOnlyCollection<(char symbol, (Stop stop, int routeIndex))> AllTargetStopAnnotations =>
        TargetStopAnnotations.Select(kvp => (kvp.Value, kvp.Key)).OrderBy(kvp => kvp.Value).ToArray();

    public char GetTargetStopAnnotation((Stop stop, int routeIndex) index) => TargetStopAnnotations[index];

    private char GetOrCreateTargetStopAnnotation((Stop stop, int routeIndex) index) =>
        TargetStopAnnotations.TryGetValue(index, out var annotation)
            ? annotation
            : new Func<char>(
                () =>
                {
                    var annotationCharacter = index.stop.Name.FirstOrDefault(
                        c => !char.IsWhiteSpace(c) && !TargetStopAnnotations.ContainsValue(char.ToUpperInvariant(c)),
                        'a');
                    if (annotationCharacter is not 'a')
                    {
                        TargetStopAnnotations.Add(index, annotationCharacter);
                        return TargetStopAnnotations[index];
                    }

                    var maxChar = TargetStopAnnotations.Values.Max();
                    // We hope that this suffices...
                    TargetStopAnnotations.Add(index, (char)(maxChar + 1));
                    return TargetStopAnnotations[index];
                })();

    public int RouteCount => StopInfos.First().Times.Count;
    public bool MultipleRoutes => RouteCount > 1;

    public StopTimetableView(IReadOnlyCollection<Line> allLines, IReadOnlyCollection<Line.Trip> trips, IReadOnlyCollection<DaysOfOperation> daysPartition,
        Stop startStop)
    {
        StartStop = startStop;
        DaysPartition = daysPartition;

        Lines = GetLines(trips);
        (StopInfos, RouteToStopInfoColumnMapping) = GetStops(allLines, trips, Lines, startStop);
        TargetStops = GetTargetStops();
        HourInfos = GetHourInfos(trips, RouteToStopInfoColumnMapping, startStop, daysPartition);
        MaximumColumns = daysPartition.Select((_, index) => index).Select(index =>
            HourInfos.Select(info => info.Value.Departures.ElementAt(index).Count).Max()).ToArray();
    }

    private static List<Line> GetLines(IReadOnlyCollection<Line.Trip> trips) =>
        trips.Select(trip => trip.Line).OrderBy(line => line.Name).Distinct().ToList();

    private List<Stop> GetTargetStops() => Enumerable.Range(0, RouteCount).Select(LastStopOfRoute).ToList();

    private static (List<StopInfo>, Dictionary<Line.Route, int>) GetStops(IReadOnlyCollection<Line> allLines,
        IReadOnlyCollection<Line.Trip> trips,
        ICollection<Line> ownLines, Stop startStop)
    {
        var routes = trips.Select(trip => trip.Route).Distinct().ToList();
        List<StopInfo> stopInfos = [];
        var relevantLinesForConnections = allLines.Except(ownLines).ToList();
        foreach (var (route, routeIndex) in routes.Select((route, routeIndex) => (route, routeIndex)))
        {
            if (!route.TryGetIndexOfStop(startStop, out var indexOfStartStop)) continue;
            var lastAssignedIndex = -1;
            var relevantStops = route.StopPositions.Skip(indexOfStartStop).ToList();
            foreach (var (stop, index) in relevantStops.Select((pos, index) => (pos.Stop, index)))
            {
                // First, check whether we can collapse this stop into an existing one.
                var previousIndex = stopInfos.Select((info, infoIndex) => (info, index: infoIndex))
                    .Skip(lastAssignedIndex + 1).FirstOrDefault(
                        tuple =>
                        {
                            var (info, _) = tuple;
                            return info.Stop == stop && info.Times[routeIndex] is null;
                        }, (null! /* will be discarded immediately */, -1)).index;
                if (previousIndex >= 0)
                {
                    stopInfos[previousIndex].Times[routeIndex] = route.TimeBetweenStops(startStop, stop);
                    lastAssignedIndex = previousIndex;
                    if (index == relevantStops.Count - 1)
                    {
                        stopInfos[lastAssignedIndex].IsRelevantStop = true;
                    }

                    continue;
                }

                var stoppingLines = relevantLinesForConnections.Where(line => line.DoesStopAt(stop, true, true))
                    .ToList();
                var minutes = Enumerable.Repeat<(TimeSpan minimumTime, TimeSpan maximumTime)?>(null, routes.Count)
                    .ToList();
                minutes[routeIndex] = route.TimeBetweenStops(startStop, stop);
                stopInfos.Add(new StopInfo
                {
                    Stop = stop,
                    Times = minutes,
                    ConnectionLines = stoppingLines,
                });
                lastAssignedIndex = stopInfos.Count - 1;
                if (index == relevantStops.Count - 1)
                {
                    stopInfos[lastAssignedIndex].IsRelevantStop = true;
                }
            }

            stopInfos[0].IsRelevantStop = true;
        }

        var mapping = routes.Select((route, index) => (route, index)).ToDictionary();

        // Collapse routes.
        var currentRouteCount = routes.Count;
        {
            bool collapsed;
            do
            {
                collapsed = false;
                for (var routeIndex = 0; routeIndex < currentRouteCount; routeIndex++)
                {
                    var containingRouteIndex = Enumerable.Range(0, currentRouteCount)
                        .Where(index => index != routeIndex)
                        .FirstOrDefault(
                            index =>
                            {
                                var haveSeenAdditionalStop = false;
                                foreach (var info in stopInfos)
                                {
                                    // We have already seen an additional stop in the candidate, but the route has still a stop.
                                    if (haveSeenAdditionalStop && info.Times[routeIndex] is not null) return false;
                                    // They are identical.
                                    if (info.Times[index] is null == info.Times[routeIndex] is null) continue;
                                    // The candidate misses a stop, thus cannot contain the route.
                                    if (info.Times[index] is null) return false;
                                    // The candidate has an additional stop.
                                    // It can now only be a valid collapse target if the route has no further stops.
                                    if (info.Times[routeIndex] is null) haveSeenAdditionalStop = true;
                                }

                                return true;
                            }, -1);
                    if (containingRouteIndex == -1) continue;
                    // Otherwise, collapse.
                    CollapseRoutes(containingRouteIndex, routeIndex, stopInfos);
                    var routesToReroute = mapping.Where(kvp => kvp.Value == routeIndex).ToList();
                    foreach (var (route, _) in routesToReroute)
                    {
                        // Reroute.
                        mapping[route] = containingRouteIndex;
                    }

                    // Reduce every route index above `routeIndex` by one as this index is now missing.
                    var routesToDecrease = mapping.Where(kvp => kvp.Value > routeIndex).ToList();
                    foreach (var (route, _) in routesToDecrease)
                    {
                        --mapping[route];
                    }

                    --currentRouteCount;
                    collapsed = true;
                    break;
                }
            } while (collapsed);
        }

        // Re-order routes such that the longest ones are first.
        {
            var previousRoutes = Enumerable.Range(0, currentRouteCount)
                .Select(routeIndex => stopInfos.Select(stopInfo => stopInfo.Times[routeIndex]).ToList()).ToList();
            var previousToOrderedMapping = Enumerable.Range(0, currentRouteCount)
                .Select(routeIndex => (previousIndex: routeIndex,
                    maximumTime: stopInfos.Last(stopInfo => stopInfo.Times[routeIndex] is not null).Times[routeIndex]!
                        .Value.maximumTime)).OrderByDescending(tuple => tuple.maximumTime)
                .Select(tuple => tuple.previousIndex).ToList();
            // Re-order entries in stop info.
            foreach (var (stopInfo, stopInfoIndex) in stopInfos.Select((stopInfo, index) => (stopInfo, index)))
            {
                foreach (var (previousIndex, orderedIndex) in previousToOrderedMapping.Select(
                             (previousIndex, orderedIndex) => (previousIndex, orderedIndex)))
                {
                    stopInfo.Times[orderedIndex] = previousRoutes[previousIndex][stopInfoIndex];
                }
            }

            // Re-order route mapping.
            foreach (var (route, previouslyMappedIndex) in mapping)
            {
                mapping[route] = previousToOrderedMapping.IndexOf(previouslyMappedIndex);
            }
        }

        return (stopInfos, mapping);

        static void CollapseRoutes(int baseRouteIndex, int otherRouteIndex, List<StopInfo> stopInfos)
        {
            foreach (var stopInfo in stopInfos)
            {
                stopInfo.Times[baseRouteIndex] =
                    stopInfo.Times[baseRouteIndex].CombineWith(stopInfo.Times[otherRouteIndex]);
                stopInfo.Times.RemoveAt(otherRouteIndex);
            }
        }
    }

    private Dictionary<int, HourInfo> GetHourInfos(IReadOnlyCollection<Line.Trip> trips,
        Dictionary<Line.Route, int> routeMapping, Stop startStop, IReadOnlyCollection<DaysOfOperation> daysPartition) => Enumerable.Range(0, 24)
        .Select(hour => (hour, GetHourInfo(hour, trips, routeMapping, startStop, daysPartition))).ToDictionary();

    private HourInfo GetHourInfo(int hour, IReadOnlyCollection<Line.Trip> trips,
        Dictionary<Line.Route, int> routeMapping, Stop startStop, IReadOnlyCollection<DaysOfOperation> daysPartition)
    {
        var departureGroups = daysPartition.Select(ForDays);

        return new HourInfo
        {
            Hour = hour,
            Departures = departureGroups.Select(group => group.Collapse().ToArray()).ToArray(),
        };

        List<HourInfo.Departure> ForDays(DaysOfOperation days)
        {
            var departures = new List<HourInfo.Departure>();
            foreach (var trip in trips)
            {
                if ((trip.DaysOfOperation & days) == DaysOfOperation.None) continue;
                var route = trip.Route;
                var startStopIndex = route.GetIndexOfStop(startStop);
                var time = trip.TimeAtStop(startStopIndex);
                if (time.Hour != hour) continue;
                var minute = time.Minute;
                var routeIndex = routeMapping[route];
                if (routeIndex > 0 || LastStopOfRoute(routeIndex) != route.StopPositions.Last().Stop)
                {
                    GetOrCreateTargetStopAnnotation((route.StopPositions.Last().Stop, routeIndex));
                }

                var annotation = trip.Annotation;
                if (annotation is not null && !_tripAnnotations.ContainsKey(annotation.Symbol))
                {
                    _tripAnnotations.Add(annotation.Symbol, annotation.Text);
                }

                departures.Add(new HourInfo.Departure
                {
                    Annotation = annotation,
                    Days = trip.DaysOfOperation,
                    Minute = minute,
                    RouteIndex = routeIndex,
                    TargetStop = trip.Route.StopPositions.Last().Stop,
                });
            }

            return departures;
        }
    }
}

file static class DepartureEnumerableExtension
{
    public static IEnumerable<StopTimetableView.HourInfo.Departure>
        Collapse(this IEnumerable<StopTimetableView.HourInfo.Departure> departures) => departures
        .GroupBy(departure => (departure.Minute, departure.RouteIndex, departure.Annotation, departure.TargetStop)).Select(group =>
            new StopTimetableView.HourInfo.Departure
            {
                Annotation = group.Key.Annotation,
                Days = group.Select(departure => departure.Days)
                    .Aggregate(DaysOfOperation.None, (current, next) => current | next),
                Minute = group.Key.Minute, RouteIndex = group.Key.RouteIndex,
                TargetStop = group.Key.TargetStop,
            }).OrderBy(departure => departure.Minute);

}

file static class TimeAtStopExtension
{
    /// <summary>
    /// Combines two time entries. DOES NOT modify any time entry.
    /// </summary>
    [Pure]
    public static (TimeSpan minimumTime, TimeSpan maximumTime)? CombineWith(
        this (TimeSpan minimumTime, TimeSpan maximumTime)? @base, (TimeSpan minimumTime, TimeSpan maximumTime)? other)
    {
        if (other is null) return @base;
        if (@base is null) return other;

        return (new TimeSpan(Math.Min(@base.Value.minimumTime.Ticks, other.Value.minimumTime.Ticks)),
            new TimeSpan(Math.Max(@base.Value.maximumTime.Ticks, other.Value.maximumTime.Ticks)));
    }
}
