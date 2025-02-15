using System.Diagnostics.Contracts;
using Timetable.Models;

namespace Timetable;

public class StopTimetableView
{
    private readonly List<Line.Trip.AnnotationDefinition> _tripAnnotations = [];

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
            public record Continuation(Stop Target, Line Line);
            public required int Minute { get; init; }
            public required DaysOfOperation Days { get; init; }
            public required List<Line.Trip.AnnotationDefinition> Annotations { get; init; }
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

    public IReadOnlyCollection<Line.Trip.AnnotationDefinition> TripAnnotations => _tripAnnotations;

    private char NextAnnotationCharacter(IEnumerable<char> candidates)
    {
        const char placeholder = ' ';
        var annotationCharacter = candidates.FirstOrDefault(
            c => !char.IsWhiteSpace(c) &&
                 _tripAnnotations.All(annotation => annotation.Symbol != char.ToUpperInvariant(c).ToString()),
            placeholder);
        if (annotationCharacter is not placeholder)
        {
            return char.ToUpperInvariant(annotationCharacter);
        }

        var maxChar = _tripAnnotations.Select(annotation => annotation.Symbol).Where(symbol => symbol.Length == 1)
            .Max();
        if (maxChar is null) throw new Exception($"Hm...");
        // We hope that this suffices...
        return (char)(maxChar[0] + 1);
    }

    private (Line.Trip.OnlyToAnnotation annotation, bool created) GetOrCreateTargetStopAnnotation(
        (Stop stop, int routeIndex) index)
    {
        var existing = _tripAnnotations.FirstOrDefault(annotation =>
            annotation is Line.Trip.OnlyToAnnotation { To: var to, DisplayRouteIndex: var displayRouteIndex } &&
            to == index.stop && displayRouteIndex == index.routeIndex);
        if (existing is Line.Trip.OnlyToAnnotation onlyToAnnotation)
        {
            return (onlyToAnnotation, false);
        }

        var created = new Func<Line.Trip.AnnotationDefinition>(() =>
        {
            var annotationCharacter = NextAnnotationCharacter(index.stop.Name);
            var annotation = new Line.Trip.OnlyToAnnotation
                { Symbol = annotationCharacter.ToString(), To = index.stop, DisplayRouteIndex = index.routeIndex, };
            _tripAnnotations.Add(annotation);
            return annotation;
        })() as Line.Trip.OnlyToAnnotation ?? throw new Exception($"Incorrect type received.");
        return (created, true);
    }

    private (Line.Trip.ContinuesAnnotation annotation, bool created) GetOrCreateContinuesToAnnotation(
        (Stop stop, Line line, Line.Route route, TimeSpan delay, Stop? notableViaStop) index)
    {
        var existing = _tripAnnotations.FirstOrDefault(annotation =>
            annotation is Line.Trip.ContinuesAnnotation
            {
                To: var to, As: var line, Via: var route, Delay: var delay, NotableViaStop: var notableViaStop
            } && to == index.stop && line == index.line && route == index.route && delay == index.delay &&
            notableViaStop == index.notableViaStop);
        if (existing is Line.Trip.ContinuesAnnotation continuesAnnotation)
        {
            return (continuesAnnotation, false);
        }

        var created = new Func<Line.Trip.AnnotationDefinition>(() =>
        {
            var annotationCharacter = NextAnnotationCharacter(index.stop.Name);
            var annotation = new Line.Trip.ContinuesAnnotation
            {
                Symbol = annotationCharacter.ToString(), To = index.stop, As = index.line, Via = index.route,
                Delay = index.delay, NotableViaStop = index.notableViaStop
            };
            _tripAnnotations.Add(annotation);
            return annotation;
        })() as Line.Trip.ContinuesAnnotation ?? throw new Exception($"Incorrect type received.");
        return (created, true);
    }

    private (Line.Trip.ContinuesFromToAnnotation annotation, bool created) GetOrCreateContinuesFromToAnnotation(
        (Stop stop, int routeIndex) targetStop,
        (Stop stop, Line line, Line.Route route, TimeSpan delay, Stop? notableViaStop) continues)
    {
        var existing = _tripAnnotations.FirstOrDefault(annotation =>
            annotation is Line.Trip.ContinuesFromToAnnotation
            {
                ContinuesAnnotation:
                {
                    To: var continuesTo, As: var continuesAs, Via: var continuesVia, Delay: var delay,
                    NotableViaStop: var notableViaStop
                },
                OnlyToAnnotation: { To: var onlyTo, DisplayRouteIndex: var onlyToRouteIndex, }
            } && continuesTo == continues.stop && continuesAs == continues.line &&
            continuesVia == continues.route && delay == continues.delay && notableViaStop == continues.notableViaStop &&
            onlyTo == targetStop.stop && onlyToRouteIndex == targetStop.routeIndex);
        if (existing is Line.Trip.ContinuesFromToAnnotation continuesFromToAnnotation)
        {
            return (continuesFromToAnnotation, false);
        }

        var created = new Func<Line.Trip.AnnotationDefinition>(() =>
        {
            var annotationCharacter = NextAnnotationCharacter(continues.stop.Name);
            var continuesToAnnotation = new Line.Trip.ContinuesAnnotation
            {
                Symbol = annotationCharacter.ToString(), To = continues.stop, As = continues.line,
                Via = continues.route, Delay = continues.delay, NotableViaStop = continues.notableViaStop,
            };
            var targetStopAnnotation = new Line.Trip.OnlyToAnnotation
            {
                Symbol = annotationCharacter.ToString(), To = targetStop.stop, DisplayRouteIndex = targetStop.routeIndex
            };
            var annotation = new Line.Trip.ContinuesFromToAnnotation
            {
                Symbol = annotationCharacter.ToString(), ContinuesAnnotation = continuesToAnnotation,
                OnlyToAnnotation = targetStopAnnotation
            };
            _tripAnnotations.Add(annotation);
            return annotation;
        })() as Line.Trip.ContinuesFromToAnnotation ?? throw new Exception($"Incorrect type received.");
        return (created, true);
    }

    public int RouteCount => StopInfos.First().Times.Count;
    public bool MultipleRoutes => RouteCount > 1;

    public StopTimetableView(IReadOnlyDictionary<string, Line> allLines, IReadOnlyCollection<Line.Trip> trips,
        IReadOnlyCollection<DaysOfOperation> daysPartition,
        Stop startStop)
    {
        StartStop = startStop;
        DaysPartition = daysPartition;

        CollectManualAnnotations(trips);

        Lines = GetLines(trips);
        (StopInfos, RouteToStopInfoColumnMapping) = GetStops(allLines.Select(kvp => kvp.Value).ToList(), trips, Lines,
            startStop,
            daysPartition.Aggregate(DaysOfOperation.None, (current, trip) => current | trip));
        TargetStops = GetTargetStops();
        HourInfos = GetHourInfos(trips, RouteToStopInfoColumnMapping, startStop, daysPartition, allLines);
        MaximumColumns = daysPartition.Select((_, index) => index).Select(index =>
            HourInfos.Select(info => info.Value.Departures.ElementAt(index).Count).Max()).ToArray();
    }

    private static List<Line> GetLines(IReadOnlyCollection<Line.Trip> trips) =>
        trips.Select(trip => trip.Line).OrderBy(line => line.Name).Distinct().ToList();

    private List<Stop> GetTargetStops() => Enumerable.Range(0, RouteCount).Select(LastStopOfRoute).Distinct().ToList();

    private static (List<StopInfo>, Dictionary<Line.Route, int>) GetStops(IReadOnlyCollection<Line> allLines,
        IReadOnlyCollection<Line.Trip> trips,
        ICollection<Line> ownLines, Stop startStop, DaysOfOperation allDays)
    {
        var routes = trips.Select(trip => trip.Route).Distinct().ToList();
        List<StopInfo> stopInfos = [];
        var timeOfOperation = ownLines.Select(line => line.OperationTime)
            .Aggregate(LineOperationTime.None, (previous, current) => previous | current);
        var relevantLinesForConnections = allLines.Except(ownLines)
            .Where(otherLine => otherLine.OperationTime.HasAnyFlag(timeOfOperation)).ToList();
        foreach (var (route, routeIndex) in routes.Select((route, routeIndex) => (route, routeIndex)))
        {
            if (!route.TryGetIndexOfStopFirst /*TryGetIndexOfStop*/(startStop, out var indexOfStartStop)) continue;
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
                    stopInfos[previousIndex].Times[routeIndex] =
                        route.TimeBetweenStops(indexOfStartStop, indexOfStartStop + index);
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
                minutes[routeIndex] = route.TimeBetweenStops(indexOfStartStop, indexOfStartStop + index);
                stopInfos.Insert(lastAssignedIndex + 1, new StopInfo
                {
                    Stop = stop,
                    Times = minutes,
                    ConnectionLines = stoppingLines,
                });
                lastAssignedIndex++; // = stopInfos.Count - 1;
                if (index == relevantStops.Count - 1)
                {
                    stopInfos[lastAssignedIndex].IsRelevantStop = true;
                }
            }

            stopInfos[0].IsRelevantStop = true;
        }

        var mapping = routes.Select((route, index) => (route, index)).ToDictionary();

        // Collapse & reorder routes.
        var currentRouteCount = routes.Count;
        {
            bool collapsed;
            do
            {
                collapsed = false;
                // Re-order routes such that the most-used ones are first.
                {
                    var previousRoutes = Enumerable.Range(0, currentRouteCount)
                        .Select(routeIndex => stopInfos.Select(stopInfo => stopInfo.Times[routeIndex]).ToList())
                        .ToList();
                    var previousToOrderedMapping = Enumerable.Range(0, currentRouteCount).Select(routeIndex => new
                    {
                        PreviousIndex = routeIndex,
                        PhysicalRoutes = mapping.Where(kvp => kvp.Value == routeIndex).Select(kvp => kvp.Key).ToList(),
                    }).Select(tmp => new
                    {
                        tmp.PreviousIndex,
                        TripCount = tmp.PhysicalRoutes.Select(route => route.TripCount(allDays) ?? 0)
                            .Aggregate(0, (prev, current) => prev + current),
                    }).OrderByDescending(tmp => tmp.TripCount).Select(tmp => tmp.PreviousIndex).ToList();
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
                // Now collapse.
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

    private void CollectManualAnnotations(IReadOnlyCollection<Line.Trip> trips)
    {
        foreach (var manualAnnotation in trips.SelectMany(trip => trip.Annotations).Distinct())
        {
            _tripAnnotations.Add(manualAnnotation);
        }
    }

    private Dictionary<int, HourInfo> GetHourInfos(IReadOnlyCollection<Line.Trip> trips,
        Dictionary<Line.Route, int> routeMapping, Stop startStop, IReadOnlyCollection<DaysOfOperation> daysPartition,
        IReadOnlyDictionary<string, Line> allLines) => Enumerable.Range(0, 24)
        .Select(hour => (hour, GetHourInfo(hour, trips, routeMapping, startStop, daysPartition, allLines)))
        .ToDictionary();

    private HourInfo GetHourInfo(int hour, IReadOnlyCollection<Line.Trip> trips,
        Dictionary<Line.Route, int> routeMapping, Stop startStop, IReadOnlyCollection<DaysOfOperation> daysPartition,
        IReadOnlyDictionary<string, Line> allLines)
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
                var startStopIndex = route.GetIndexOfStopFirst(startStop);
                var time = trip.TimeAtStop(startStopIndex);
                if (time.Hour != hour) continue;
                var minute = time.Minute;
                var routeIndex = routeMapping[route];
                List<Line.Trip.AnnotationDefinition> annotations = [..trip.Annotations];
                Line.Trip.OnlyToAnnotation? targetStopAnnotation = null;
                var targetStopAnnotationCreated = false;
                if (routeIndex > 0 || LastStopOfRoute(routeIndex) != route.StopPositions.Last().Stop)
                {
                    (targetStopAnnotation, targetStopAnnotationCreated) = GetOrCreateTargetStopAnnotation((route.StopPositions.Last().Stop, routeIndex));
                }

                var connection = trip.GetConnections(allLines)
                    .Where(connection => connection.Type is Line.Trip.ConnectionType.ContinuesAs)
                    // There should be at most one trip this trip is connecting *to*.
                    .SingleOrDefault((Line.Trip.Connection?)null);

                if (connection is not null && ConnectionIsRelevant(connection, startStop))
                {
                    var (annotation, annotationCreated) = GetOrCreateContinuesToAnnotation((
                        connection.Trip.Route.StopPositions.Last().Stop, connection.Trip.Line, connection.Trip.Route,
                        connection.Trip.StartTime - trip.TimeAtLastStop(), connection.NotableViaStop));
                    if (targetStopAnnotation is not null)
                    {
                        // This trip does not continue as normal to the final stop of this line.
                        // Remove ContinuesTo annotation from the line annotations.
                        if (targetStopAnnotationCreated)
                            _tripAnnotations.RemoveAt(_tripAnnotations.Count - 1);
                        // Remove target stop annotation from the line annotations.
                        if (annotationCreated)
                            _tripAnnotations.RemoveAt(_tripAnnotations.Count - 1);
                        // Add combined annotation.
                        var (combinedAnnotation, _) = GetOrCreateContinuesFromToAnnotation(
                            (targetStopAnnotation.To, targetStopAnnotation.DisplayRouteIndex),
                            (annotation.To, annotation.As, annotation.Via, annotation.Delay,
                                annotation.NotableViaStop));
                        annotations.Add(combinedAnnotation);
                    }
                    else
                    {
                        annotations.Add(annotation);
                    }
                }
                else if (targetStopAnnotation is not null)
                {
                    // This should only be added if there is no continuation as otherwise a combined annotation will be produced above.
                    annotations.Add(targetStopAnnotation);
                }

                departures.Add(new HourInfo.Departure
                {
                    Annotations = [..annotations],
                    Days = trip.DaysOfOperation,
                    Minute = minute,
                    RouteIndex = routeIndex,
                    TargetStop = trip.Route.StopPositions.Last().Stop,
                });
                continue;

                static bool ConnectionIsRelevant(Line.Trip.Connection connection, Stop currentStop)
                {
                    // Never disregard manually specified via stops.
                    if (connection.NotableViaStop is not null) return true;
                    // If we are at a stop that the connecting trip also calls at we assume it to NOT be interesting
                    // since a passenger would choose to later board this trip.
                    if (connection.Trip.Route.StopPositions.Select(pos => pos.Stop).Any(stop => stop == currentStop))
                        return false;
                    // Default to a relevant connection.
                    return true;
                }
            }

            return departures;
        }
    }
}

file static class DepartureEnumerableExtension
{
    private class ValueEqualityListWrapper<T> : IEquatable<ValueEqualityListWrapper<T>> where T : notnull
    {
        private readonly List<T> _list = null! /* will be set by required property below */;

        public required IReadOnlyCollection<T> List
        {
            get => _list;
            init => _list = value as List<T> ?? [..value];
        }

        public bool Equals(ValueEqualityListWrapper<T>? other)
        {
            if (other is null) return false;
            return ReferenceEquals(this, other) || ScrambledEquals(_list, other._list);
        }

        // Source: https://stackoverflow.com/a/3670089/13849454
        private static bool ScrambledEquals(List<T> list1, List<T> list2)
        {
            var cnt = new Dictionary<T, int>();
            // ReSharper disable once ForeachCanBePartlyConvertedToQueryUsingAnotherGetEnumerator
            foreach (var s in list1)
            {
                if (!cnt.TryAdd(s, 1))
                {
                    cnt[s]++;
                }
            }

            foreach (var s in list2)
            {
                if (cnt.TryGetValue(s, out var value))
                {
                    cnt[s] = --value;
                }
                else
                {
                    return false;
                }
            }

            return cnt.Values.All(c => c == 0);
        }

        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ValueEqualityListWrapper<T>)obj);
        }

        public override int GetHashCode()
        {
            return _list.Aggregate(0, HashCode.Combine);
        }
    }

    private static ValueEqualityListWrapper<T> ToValueEqualityList<T>(this IEnumerable<T> source) => new()
    {
        List = source as List<T> ?? source.ToList(),
    };

    private class KeyComparer : IEqualityComparer<(int Minute, int RouteIndex,
        ValueEqualityListWrapper<Line.Trip.AnnotationDefinition> Annotations, Stop TargetStop)>
    {
        public bool Equals(
            (int Minute, int RouteIndex, ValueEqualityListWrapper<Line.Trip.AnnotationDefinition> Annotations, Stop
                TargetStop) x,
            (int Minute, int RouteIndex, ValueEqualityListWrapper<Line.Trip.AnnotationDefinition> Annotations, Stop
                TargetStop) y)
        {
            return x.Minute == y.Minute && x.RouteIndex == y.RouteIndex && Equals(x.Annotations, y.Annotations) &&
                   Equals(x.TargetStop, y.TargetStop);
        }

        public int GetHashCode(
            (int Minute, int RouteIndex, ValueEqualityListWrapper<Line.Trip.AnnotationDefinition> Annotations, Stop
                TargetStop) obj)
        {
            return HashCode.Combine(obj.Minute, obj.RouteIndex, obj.Annotations, obj.TargetStop);
        }
    }

    public static IEnumerable<StopTimetableView.HourInfo.Departure>
        Collapse(this IEnumerable<StopTimetableView.HourInfo.Departure> departures) => departures
        .GroupBy(
            departure => (departure.Minute, departure.RouteIndex,
                Annotations: departure.Annotations.ToValueEqualityList(), departure.TargetStop),
            new KeyComparer())
        .Select(group =>
            new StopTimetableView.HourInfo.Departure
            {
                Annotations = group.Key.Annotations.List.ToList(),
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