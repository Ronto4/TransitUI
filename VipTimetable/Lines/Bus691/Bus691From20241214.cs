using Timetable.Models;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus691;

public class Bus691From20241214 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 12, 14);

    public Line Line { get; } = new()
    {
        Name = "691",
        TransportationType = TransportationType.Bus,
        MainRouteIndices = [0, 1],
        OverviewRouteIndices = [0, 1],
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.SHauptbahnhof,
                    Stops.AmHavelblick,
                    Stops.ZumTelegrafenberg,
                    Stops.Telegrafenberg,
                ],
                TimeProfiles = [new Line.Route.TimeProfile { StopDistances = [M3, M1, M2,], },],
                CommonStopIndex = 1,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Telegrafenberg,
                    Stops.ZumTelegrafenberg,
                    Stops.AmHavelblick,
                    Stops.SHauptbahnhof,
                ],
                TimeProfiles = [new Line.Route.TimeProfile { StopDistances = [M2, M1, M3,], },],
                CommonStopIndex = 0,
            },
        ],
        TripsCreate =
        [
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 18),
            }.AlsoEvery(M20, new TimeOnly(9, 38)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(12, 58),
            }.AlsoEvery(M20, new TimeOnly(19, 18)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 31),
            }.AlsoEvery(M20, new TimeOnly(9, 51)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(13, 11),
            }.AlsoEvery(M20, new TimeOnly(19, 31)),
        ],
    };
}
