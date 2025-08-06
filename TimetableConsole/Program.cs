/*

using System.Diagnostics;
using Timetable;

var sw = new Stopwatch();
sw.Start();
var history = VipTimetable.VipHistory.History;
var entry = history[0];
var lines = entry.OrderedLinesById.ToArray();
var line = lines[0].Value;
var routes = line.Routes;
var route = routes[0];
var trips = line.TripsOfRouteIndex(0).ToArray();
var stopTimetableView = new Timetable.Views.StopTimetableView(lines.ToDictionary(), trips,
    [DaysOfOperation.Weekday, DaysOfOperation.Weekend], route.StopPositions[0].Stop, new DateOnly(2024, 1, 3));
sw.Stop();
Console.WriteLine($"Got {trips.Length} trips for route {route}.");
Console.WriteLine($"Last stop of route 0: {stopTimetableView.LastStopOfRoute(0)}");
Console.WriteLine($"Took {sw.Elapsed}");
*/

List<int> Test()
{
    List<int> list = [1, 2, 3];
    IReadOnlyList<int> d = list;
    var x = list[1..];
    var y = d.Mem
    return x;
}


Console.WriteLine(Test().Count);