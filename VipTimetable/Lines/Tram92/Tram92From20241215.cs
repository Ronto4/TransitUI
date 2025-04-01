using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Tram92;

public class Tram92From20241215 : ILineInstance
{
    private static readonly Tram92From20241104 Previous = new();
    public DateOnly ValidFrom { get; } = new(2024, 12, 15);

    public Line Line { get; } = Previous.Line with
    {
        Routes = Previous.Line.Routes.Select(route =>
            route.WithStopBetween(Stops.Puschkinallee, Stops.ReiterwegAlleestr, Stops.Rathaus, M1, M1)
                .WithStopBetween(Stops.Rathaus, Stops.ReiterwegAlleestr, Stops.Puschkinallee, M0, M2)).ToArray(),
        TripsCreate =
        [
            ..Previous.Line.TripsCreate.Where(trip => trip.DaysOfOperation != DaysOfOperation.Holiday),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(4, 50),
            }.AlsoEvery(M20, 2),
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(5, 27),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(5, 50),
            }.AlsoEvery(M20, new TimeOnly(6, 50)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(7, 9),
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(7, 49),
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(8, 30),
            }.AlsoEvery(M20, new TimeOnly(14, 10)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(14, 29),
            }.AlsoEvery(M20, new TimeOnly(16, 9)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(16, 30),
            }.AlsoEvery(M20, new TimeOnly(17, 50)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(18, 10),
            }.AlsoEvery(M20, new TimeOnly(19, 10)),
            ..new Line.TripCreate
            {
                RouteIndex = 9,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(5, 17),
            }.AlsoEvery(M20, new TimeOnly(7, 57)),
            ..new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(8, 8),
            }.AlsoEvery(M20, new TimeOnly(18, 8)),
            new Line.TripCreate
            {
                RouteIndex = 9,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(18, 37)
            },
        ],
    };
}
