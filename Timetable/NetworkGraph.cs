namespace Timetable;

/// <summary>
/// A class representing a transit network as a graph.
/// </summary>
public class NetworkGraph
{
    private readonly record struct StopStatistic
    {
        public required Stop Stop { get; init; }
        public required int TotalDepartures { get; init; }
        public required ConnectionStatistic[] Connections { get; init; }

        public static StopStatistic GetFromTrips(IHistoryEntry historyEntry, Stop stop, (Line.Route Route, int TripCount)[] routes)
        {
            var relevantRoutes = routes.Where(route => route.Route.DoesStopAt(stop, true));
            return new StopStatistic
            {
                Stop = stop,
                TotalDepartures = relevantRoutes.Aggregate(0, (previous, route) => previous + route.TripCount),
                Connections = GetConnectionStatistics(historyEntry, stop).ToArray(),
            };
        }
    }
    private readonly record struct ConnectionStatistic
    {
        public required Stop StartStop { get; init; }
        public required Stop NeighbouringStop { get; init; }
        public required int TotalTrips { get; init; }
    }
    
    

    private static IOrderedEnumerable<StopStatistic> GetStopStatistics(IHistoryEntry historyEntry)
    {
        var lines = historyEntry.LinesById.Select(kvp => kvp.Value).ToArray();
        var routes = lines.SelectMany(line => line.Routes).Select(route => (route, route.TripCount(DaysOfOperation.Daily) ?? 0)).ToArray();
        var stops = lines.SelectMany(line => line.Routes).SelectMany(route => route.StopPositions).Select(position => position.Stop).Distinct();
        var stats = stops.Select(stop => StopStatistic.GetFromTrips(historyEntry, stop, routes)).OrderByDescending(stat => stat.TotalDepartures);
        return stats;
    }

    private static IOrderedEnumerable<ConnectionStatistic> GetConnectionStatistics(IHistoryEntry historyEntry, Stop startStop)
    {
        var lines = historyEntry.LinesById.Select(kvp => kvp.Value);
        var relevantRoutes = lines.SelectMany(line => line.Routes).Where(route => route.DoesStopAt(startStop, true));
        var neighbouringStops = relevantRoutes.Select(route => (TripCount: route.TripCount(DaysOfOperation.Daily), NeighbouringStop: route.StopPositions[route.GetIndexOfStopFirst(startStop) + 1].Stop));
        return neighbouringStops
            .GroupBy(tuple => tuple.NeighbouringStop)
            .Select(group => (NeighbouringStop: group.Key, TotalTrips: group.Aggregate(0, (previous, g) => previous + g.TripCount ?? 0)))
            .Select(tuple => new ConnectionStatistic { StartStop = startStop, NeighbouringStop = tuple.NeighbouringStop, TotalTrips = tuple.TotalTrips })
            .OrderByDescending(stat => stat.TotalTrips);
    }
    
    private StopStatistic[] Stops { get; init; }
    private Dictionary<Stop, int> StopIndices { get; init; }
    
    /// <summary>
    /// Create a new <see cref="NetworkGraph"/> for the provided <see cref="IHistoryEntry"/>.
    /// </summary>
    public NetworkGraph(IHistoryEntry historyEntry)
    {
        Stops = GetStopStatistics(historyEntry).ToArray();
        StopIndices = Stops.Select((stop, index) => (stop.Stop, index)).ToDictionary();
    }

    /// <summary>
    /// Traverses the graph in a depth-first manner, starting at the most departed stop and using most used edges preferred.
    /// </summary>
    /// <returns></returns>
    public Stop?[] TraverseDepthFirstViaMostUsed()
    {
        Dictionary<Stop, bool> stopsAlreadySeen = new();
        var stops = new Stop?[Stops.Length];
        var currentIndex = 0;
        TraverseDepthFirstViaMostUsed(Stops[0], stopsAlreadySeen, stops, ref currentIndex);
        return stops;
    }

    private void TraverseDepthFirstViaMostUsed(StopStatistic currentStopStat, Dictionary<Stop, bool> seenStops, Stop?[] stops, ref int currentIndex)
    {
        seenStops.Add(currentStopStat.Stop, true);
        stops[currentIndex++] = currentStopStat.Stop;
        foreach (var connection in currentStopStat.Connections)
        {
            if (seenStops.TryGetValue(connection.NeighbouringStop, out var exists) && exists) continue;
            TraverseDepthFirstViaMostUsed(Stops[StopIndices[connection.NeighbouringStop]], seenStops, stops,
                ref currentIndex);
        }
    }
}