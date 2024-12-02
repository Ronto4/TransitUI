using Timetables.Models;

namespace Timetables;

public class StopTimetableView
{
    public record StopInfo
    {
        public required List<Line> ConnectionLines { get; init; }
        public required List<(TimeSpan minimumTime, TimeSpan maximumTime)?> Times { get; init; }
        public required Stop Stop { get; init; }
    }

    public record HourInfo
    {
        public record Departure
        {
            public required int Minute { get; init; }
            public required DaysOfOperation Days { get; init; }
            public required Line.Trip.AnnotationDefinition? Annotation { get; init; }
            public required int RouteIndex { get; init; }
        }

        public required int Hour { get; init; }
        public required List<Departure> MoFrDepartures { get; init; }
        public required List<Departure> SaSoDepartures { get; init; }
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

    /// <summary>
    /// The stops to be shown in the line overview.
    /// </summary>
    public List<StopInfo> StopInfos { get; }

    public Dictionary<int, HourInfo> HourInfos { get; }
    
    public (int moFrColumns, int saSoColumns) MaximumColumns { get; }

    public StopTimetableView(ICollection<Line> allLines, ICollection<Line.Trip> trips, DaysOfOperation daysOfOperation,
        Stop startStop)
    {
        StartStop = startStop;

        Lines = GetLines(trips);
        TargetStops = GetTargetStops(trips);
        (StopInfos, RouteToStopInfoColumnMapping) = GetStops(allLines, trips, Lines, startStop);
        HourInfos = GetHourInfos(trips, RouteToStopInfoColumnMapping, startStop);
        MaximumColumns = (moFrColumns: HourInfos.Select(info => info.Value.MoFrDepartures.Count).Max(),
            saSoColumns: HourInfos.Select(info => info.Value.SaSoDepartures.Count).Max());
    }

    private static List<Line> GetLines(ICollection<Line.Trip> trips) =>
        trips.Select(trip => trip.Line).OrderBy(line => line.Name).Distinct().ToList();

    private static List<Stop> GetTargetStops(ICollection<Line.Trip> trips) => trips.Select(trip => trip.Route)
        .Select(route => route.StopPositions.Last().Stop).Distinct().ToList();

    private static (List<StopInfo>, Dictionary<Line.Route, int>) GetStops(ICollection<Line> allLines,
        ICollection<Line.Trip> trips,
        ICollection<Line> ownLines, Stop startStop)
    {
        var routes = trips.Select(trip => trip.Route).Distinct().ToList();
        List<StopInfo> stopInfos = [];
        var relevantLinesForConnections = allLines.Except(ownLines).ToList();
        for (var routeIndex = 0; routeIndex < routes.Count; ++routeIndex)
        {
            if (!routes[routeIndex].TryGetIndexOfStop(startStop, out var indexOfStartStop)) continue;
            foreach (var stop in routes[routeIndex].StopPositions.Skip(indexOfStartStop).Select(pos => pos.Stop))
            {
                var stoppingLines = relevantLinesForConnections.Where(line => line.DoesStopAt(stop)).ToList();
                var minutes = Enumerable.Repeat<(TimeSpan minimumTime, TimeSpan maximumTime)?>(null, routes.Count)
                    .ToList();
                minutes[routeIndex] = routes[routeIndex].TimeBetweenStops(startStop, stop);
                stopInfos.Add(new StopInfo
                {
                    Stop = stop,
                    Times = minutes,
                    ConnectionLines = stoppingLines,
                });
            }
        }

        var mapping =
            new Dictionary<Line.Route, int>(routes.Select((route, index) =>
                new KeyValuePair<Line.Route, int>(route, index)));

        return (stopInfos, mapping);
    }

    private static Dictionary<int, HourInfo> GetHourInfos(ICollection<Line.Trip> trips,
        Dictionary<Line.Route, int> routeMapping, Stop startStop) => new Dictionary<int, HourInfo>()
    {
        { 0, GetHourInfo(0, trips, routeMapping, startStop) },
        { 1, GetHourInfo(1, trips, routeMapping, startStop) },
        { 2, GetHourInfo(2, trips, routeMapping, startStop) },
        { 3, GetHourInfo(3, trips, routeMapping, startStop) },
        { 4, GetHourInfo(4, trips, routeMapping, startStop) },
        { 5, GetHourInfo(5, trips, routeMapping, startStop) },
        { 6, GetHourInfo(6, trips, routeMapping, startStop) },
        { 7, GetHourInfo(7, trips, routeMapping, startStop) },
        { 8, GetHourInfo(8, trips, routeMapping, startStop) },
        { 9, GetHourInfo(9, trips, routeMapping, startStop) },
        { 10, GetHourInfo(10, trips, routeMapping, startStop) },
        { 11, GetHourInfo(11, trips, routeMapping, startStop) },
        { 12, GetHourInfo(12, trips, routeMapping, startStop) },
        { 13, GetHourInfo(13, trips, routeMapping, startStop) },
        { 14, GetHourInfo(14, trips, routeMapping, startStop) },
        { 15, GetHourInfo(15, trips, routeMapping, startStop) },
        { 16, GetHourInfo(16, trips, routeMapping, startStop) },
        { 17, GetHourInfo(17, trips, routeMapping, startStop) },
        { 18, GetHourInfo(18, trips, routeMapping, startStop) },
        { 19, GetHourInfo(19, trips, routeMapping, startStop) },
        { 20, GetHourInfo(20, trips, routeMapping, startStop) },
        { 21, GetHourInfo(21, trips, routeMapping, startStop) },
        { 22, GetHourInfo(22, trips, routeMapping, startStop) },
        { 23, GetHourInfo(23, trips, routeMapping, startStop) },
    };

    private static HourInfo GetHourInfo(int hour, ICollection<Line.Trip> trips,
        Dictionary<Line.Route, int> routeMapping, Stop startStop)
    {
        List<HourInfo.Departure> moFrDepartures = [];

        foreach (var trip in trips)
        {
            if ((trip.DaysOfOperation & DaysOfOperation.Weekday) == DaysOfOperation.None) continue;
            var route = trip.Route;
            var startStopIndex = route.GetIndexOfStop(startStop);
            var time = trip.TimeAtStop(startStopIndex);
            if (time.Hour != hour) continue;
            var minute = time.Minute;
            moFrDepartures.Add(new HourInfo.Departure
            {
                Annotation = trip.Annotation,
                Days = trip.DaysOfOperation,
                Minute = minute,
                RouteIndex = routeMapping[route],
            });
        }

        List<HourInfo.Departure> saSoDepartures = [];

        foreach (var trip in trips)
        {
            if ((trip.DaysOfOperation & DaysOfOperation.Weekend) == DaysOfOperation.None) continue;
            var route = trip.Route;
            var startStopIndex = route.GetIndexOfStop(startStop);
            var time = trip.TimeAtStop(startStopIndex);
            if (time.Hour != hour) continue;
            var minute = time.Minute;
            saSoDepartures.Add(new HourInfo.Departure
            {
                Annotation = trip.Annotation,
                Days = trip.DaysOfOperation,
                Minute = minute,
                RouteIndex = routeMapping[route],
            });
        }

        return new HourInfo
        {
            Hour = hour,
            MoFrDepartures = moFrDepartures.Collapse().ToList(),
            SaSoDepartures = saSoDepartures.Collapse().ToList(),
        };
    }
}

file static class DepartureEnumerableExtension
{
    public static IEnumerable<StopTimetableView.HourInfo.Departure>
        Collapse(this IEnumerable<StopTimetableView.HourInfo.Departure> departures) => departures
        .GroupBy(departure => (departure.Minute, departure.RouteIndex, departure.Annotation)).Select(group =>
            new StopTimetableView.HourInfo.Departure
            {
                Annotation = group.Key.Annotation,
                Days = group.Select(departure => departure.Days)
                    .Aggregate(DaysOfOperation.None, (current, next) => current | next),
                Minute = group.Key.Minute, RouteIndex = group.Key.RouteIndex,
            }).OrderBy(departure => departure.Minute);

}
