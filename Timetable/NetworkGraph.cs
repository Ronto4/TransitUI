using System.Collections.Frozen;
using System.Diagnostics.Contracts;

namespace Timetable;

/// <summary>
/// A class representing a transit network as a graph.
/// </summary>
public class NetworkGraph
{
    /// <summary>
    /// Stats about a single <see cref="Timetable.Stop"/> in the network.
    /// </summary>
    public readonly record struct StopStatistic
    {
        /// <summary>
        /// The <see cref="Timetable.Stop"/> in question.
        /// </summary>
        public required Stop Stop { get; init; }
        
        /// <summary>
        /// The total number of departures from the <see cref="Stop"/>.
        ///
        /// This uses the counting rules from <see cref="Timetable.Line.Route.TripCount"/>.
        /// </summary>
        public required int TotalDepartures { get; init; }
        
        /// <summary>
        /// The number of departures each line has from the <see cref="Stop"/>.
        ///
        /// This uses the counting rules from <see cref="Timetable.Line.Route.TripCount"/>.
        /// </summary>
        public required IReadOnlyDictionary<Line, int> DeparturesByLine { get; init; }
        
        /// <summary>
        /// The connections this <see cref="Stop"/> has to other <see cref="Timetable.Stop"/>s.
        /// </summary>
        public required ConnectionStatistic[] Connections { get; init; }

        internal static StopStatistic GetFromTrips(IHistoryEntry historyEntry, Stop stop, (Line.Route Route, int TripCount)[] routes)
        {
            var relevantRoutes = routes.Where(route => route.Route.DoesStopAt(stop, true)).ToArray();
            return new StopStatistic
            {
                Stop = stop,
                TotalDepartures = relevantRoutes.Aggregate(0, (previous, route) => previous + route.TripCount),
                Connections = GetConnectionStatistics(historyEntry, stop).ToArray(),
                DeparturesByLine = relevantRoutes.GroupBy(tuple => tuple.Route.Line ?? throw new Exception())
                    .Select(lineGroup => (lineGroup.Key,
                        lineGroup.Aggregate(0, (previous, route) => previous + route.TripCount)))
                    .ToFrozenDictionary(tuple => tuple.Key, tuple => tuple.Item2),
            };
        }
    }
    
    /// <summary>
    /// Stats about a connection between two <see cref="Timetable.Stop"/>s.
    /// </summary>
    public readonly record struct ConnectionStatistic
    {
        /// <summary>
        /// The first <see cref="Timetable.Stop"/> of this connection.
        /// </summary>
        public required Stop StartStop { get; init; }
        
        /// <summary>
        /// The second <see cref="Timetable.Stop"/> of this connection.
        /// </summary>
        public required Stop NeighbouringStop { get; init; }
        
        /// <summary>
        /// The total number of departures from the <see cref="Stop"/>.
        ///
        /// This uses the counting rules from <see cref="Timetable.Line.Route.TripCount"/>.
        /// </summary>
        public required int TotalTrips { get; init; }
        
        /// <summary>
        /// The number of departures each line has from the <see cref="Stop"/>.
        ///
        /// This uses the counting rules from <see cref="Timetable.Line.Route.TripCount"/>.
        /// </summary>
        public required IReadOnlyDictionary<Line, int> TripsByLine { get; init; }
        
        public required (TimeSpan minimumTime, TimeSpan maximumTime) TripTime { get; init; }
    }
    
    

    private static IOrderedEnumerable<StopStatistic> GetStopStatistics(IHistoryEntry historyEntry)
    {
        var lines = historyEntry.LinesById.Select(kvp => kvp.Value).ToArray();
        var routes = lines.SelectMany(line => line.Routes).Select(route => (route, route.TripCount(DaysOfOperation.Daily) ?? 0)).ToArray();
        var stops = lines.SelectMany(line => line.Routes).SelectMany(route => route.StopPositions).Select(position => position.Stop).Distinct();
        var stats = stops.Select(stop => StopStatistic.GetFromTrips(historyEntry, stop, routes)).OrderByDescending(stat => stat.TotalDepartures);
        return stats;
    }

    private static IOrderedEnumerable<ConnectionStatistic> GetConnectionStatistics(IHistoryEntry historyEntry,
        Stop startStop)
    {
        var lines = historyEntry.LinesById.Select(kvp => kvp.Value);
        var relevantRoutes = lines.SelectMany(line => line.Routes).Where(route => route.DoesStopAt(startStop, true))
            .ToArray();
        var neighbouringStops = relevantRoutes.SelectMany(route =>
            route.GetIndicesOfStop(startStop)
                .Where(index => /* only choose departure indices */ index < route.StopPositions.Length - 1)
                .Select(index => (Route: route, TripCount: route.TripCount(DaysOfOperation.Daily),
                    NeighbouringStop: route.StopPositions[index + 1].Stop)));
        // var neighbouringStops = relevantRoutes.Select(route => (TripCount: route.TripCount(DaysOfOperation.Daily), NeighbouringStop: route.StopPositions[route.GetIndicesOfStop(startStop) + 1].Stop));
        return neighbouringStops
            .GroupBy(tuple => tuple.NeighbouringStop)
            .Select(group => (Routes: group.Select(g => g.Route).ToArray(), NeighbouringStop: group.Key,
                TotalTrips: group.Aggregate(0, (previous, g) => previous + g.TripCount ?? 0)))
            .Select(tuple => new ConnectionStatistic
            {
                StartStop = startStop,
                NeighbouringStop = tuple.NeighbouringStop,
                TotalTrips = tuple.TotalTrips,
                TripsByLine = tuple.Routes.GroupBy(route => route.Line ?? throw new Exception())
                    .Select(lineGroup => (lineGroup.Key,
                        lineGroup.Aggregate(0,
                            (previous, route) => previous + route.TripCount(DaysOfOperation.Daily)!.Value)))
                    .ToFrozenDictionary(tuple => tuple.Key, tuple => tuple.Item2),
                TripTime = tuple.Routes.Where(route => route.TimeProfiles.Length > 0)
                    .Select(route => (route, startStopIndices: route.GetIndicesOfStop(startStop),
                        toStopIndices: route.GetIndicesOfStop(tuple.NeighbouringStop).ToArray()))
                    .Select(triple => (route: triple.route,
                        startStopIndices: triple.startStopIndices.Where(i => triple.toStopIndices.Contains(i + 1))))
                    .SelectMany(t => t.startStopIndices.Select(index => t.route.TimeBetweenStops(index, index + 1)))
                    .Combine() ?? throw new Exception($"{tuple.Routes.Length}"),
            })
            .OrderByDescending(stat => stat.TotalTrips);
    }

    private StopStatistic[] Stops { get; init; }
    private Dictionary<Stop, int> StopIndices { get; init; }
    
    /// <summary>
    /// Get the stats of the provided <see cref="Timetable.Stop"/>.
    /// </summary>
    public StopStatistic this[Stop stop] => Stops[StopIndices[stop]];
    
    /// <summary>
    /// Create a new <see cref="NetworkGraph"/> for the provided <see cref="IHistoryEntry"/>.
    /// </summary>
    public NetworkGraph(IHistoryEntry historyEntry)
    {
        Stops = GetStopStatistics(historyEntry).ToArray();
        StopIndices = Stops.Select((stop, index) => (stop.Stop, index)).ToDictionary();
    }

    /// <summary>
    /// Traverse the graph in the order of usage of each stop.
    /// </summary>
    public IEnumerable<(Stop stop, StopStatistic statistic)> TraverseMostUsedStops() =>
        Stops.Select(stats => (stats.Stop, stats));

    /// <summary>
    /// Traverses the graph in a depth-first manner, starting at the most departed stop and using most used edges preferred.
    /// </summary>
    public IEnumerable<ConnectionStatistic> TraverseDepthFirstViaMostUsed()
    {
        Dictionary<Stop, bool> stopsAlreadySeen = new();
        return TraverseDepthFirstViaMostUsed(Stops[0], stopsAlreadySeen);
    }

    /// <summary>
    /// Traverses the graph in a depth-first manner, starting at the most departed stop and using most used edges preferred.
    ///
    /// <paramref name="onlyLine"/> MUST depart from <paramref name="startStop"/> at least once!
    ///
    /// Only uses edges where <paramref name="onlyLine"/> exists.
    /// </summary>
    public IEnumerable<ConnectionStatistic> TraverseDepthFirstViaMostUsedLine(Stop startStop, Line onlyLine)
    {
        Dictionary<Stop, bool> stopsAlreadySeen = new();
        return TraverseDepthFirstViaMostUsed(Stops[StopIndices[startStop]], stopsAlreadySeen, onlyLine);
    }

    private IEnumerable<ConnectionStatistic> TraverseDepthFirstViaMostUsed(StopStatistic currentStopStat, Dictionary<Stop, bool> seenStops, Line? onlyLine = null)
    {
        seenStops.Add(currentStopStat.Stop, true);
        IEnumerable<ConnectionStatistic> connections = onlyLine is not null
            ? currentStopStat.Connections.OrderByDescending(stat => stat.TripsByLine.GetValueOrDefault(onlyLine, 0))
                .ThenByDescending(stat => stat.TotalTrips)
            : currentStopStat.Connections;
        foreach (var connection in connections)
        {
            if (onlyLine is not null && !connection.TripsByLine.ContainsKey(onlyLine)) continue;
            yield return connection;
            if (seenStops.TryGetValue(connection.NeighbouringStop, out var exists) && exists) continue;
            foreach (var nextConnection in
                     TraverseDepthFirstViaMostUsed(Stops[StopIndices[connection.NeighbouringStop]], seenStops, onlyLine))
                yield return nextConnection;
        }
    }

    /// <summary>
    /// Traverses the graph in a breadth-first manner, starting at the most departed stop and using most used edges preferred.
    /// </summary>
    public IEnumerable<ConnectionStatistic> TraverseBreadthFirstViaMostUsed()
    {
        HashSet<Stop> stopsAlreadySeen = [];
        Queue<StopStatistic> stopsToHandle = new();
        stopsToHandle.Enqueue(Stops[0]);
        stopsAlreadySeen.Add(Stops[0].Stop);
        while (stopsToHandle.TryDequeue(out var currentStop))
        {
            foreach (var connection in currentStop.Connections)
            {
                yield return connection;
                if (stopsAlreadySeen.Add(connection.NeighbouringStop) == false /* i.e. it was present already */) continue;
                // Console.WriteLine($"Currently at {currentStop.Stop.DisplayName(DateOnly.FromDateTime(DateTime.Now), currentStop.Stop.City)}, adding {connection.NeighbouringStop.DisplayName(DateOnly.FromDateTime(DateTime.Now), currentStop.Stop.City)}");
                stopsToHandle.Enqueue(Stops[StopIndices[connection.NeighbouringStop]]);
            }
        }
    }

    public readonly record struct LineSegment
    {
        public required Line Line { get; init; }
        public required Stop From { get; init; }
        public required Stop To { get; init; }
        public required int TripCount { get; init; }
    }

    // TODO: This is broken when a connection of a line is not reachable from its most used station.
    public IEnumerable<LineSegment> TraverseLineWise()
    {
        var linesDone = new HashSet<Line>();
        foreach (var (initialStopStats, lines) in Stops.Select(stop => (stop, stop.DeparturesByLine.OrderByDescending(kvp => kvp.Value)
                     .Select(kvp => kvp.Key))))
        {
            foreach (var line in lines)
            {
                if (linesDone.Add(line) == false /* Was already in the set */) continue;
                foreach (var stat in TraverseDepthFirstViaMostUsedLine(initialStopStats.Stop, line))
                {
                    yield return new LineSegment
                    {
                        Line = line,
                        From = stat.StartStop,
                        To = stat.NeighbouringStop,
                        TripCount = stat.TripsByLine[line],
                    };
                }
            }
        }
    }
}

file static class TimeAtStopExtension
{
    /// <summary>
    /// Combines two time entries. DOES NOT modify any time entry.
    /// </summary>
    [Pure]
    private static (TimeSpan minimumTime, TimeSpan maximumTime)? CombineWith(
        this (TimeSpan minimumTime, TimeSpan maximumTime)? @base, (TimeSpan minimumTime, TimeSpan maximumTime) other)
    {
        if (@base is null) return other;

        return (new TimeSpan(Math.Min(@base.Value.minimumTime.Ticks, other.minimumTime.Ticks)),
            new TimeSpan(Math.Max(@base.Value.maximumTime.Ticks, other.maximumTime.Ticks)));
    }

    /// <summary>
    /// Combines an entire <see cref="IEnumerable{T}"/> of time entries into one.
    /// </summary>
    public static (TimeSpan minimumTime, TimeSpan maximumTime)?
        Combine(this IEnumerable<(TimeSpan minimumTime, TimeSpan maximumTime)> enumerable) =>
        enumerable.Aggregate(((TimeSpan minimumTime, TimeSpan maximumTime)?)null, CombineWith);
}