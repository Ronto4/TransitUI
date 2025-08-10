using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.BusEV96;

public class BusEv96From20250120Until20250124 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 1, 20);
    public DateOnly? ValidUntilInclusive() => new DateOnly(2025, 1, 24);

    public Line Line { get; } = new Line
    {
        Name = "EV 96",
        TransportationType = TransportationType.Bus,
        MainRouteIndices = [0, 1],
        OverviewRouteIndices = [0, 1],
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.WaldstrHorstweg,
                    Stops.Falkenhorst,
                    Stops.JohannesKeplerPlatz,
                    Stops.MaxBornStr,
                    Stops.OttoHahnRing,
                    Stops.HansAlbersStr,
                    Stops.RobertBaberskeStr,
                    Stops.Priesterweg,
                    Stops.AmHirtengraben,
                    Stops.MarieJuchaczStr,
                ],
                CommonStopIndex = 0,
                TimeProfiles = [new Line.Route.TimeProfile { StopDistances = [M1, M6, M1, M1, M2, M1, M1, M1, M1,], },],
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.MarieJuchaczStr,
                    Stops.AmHirtengraben,
                    Stops.Priesterweg,
                    Stops.RobertBaberskeStr,
                    Stops.HansAlbersStr,
                    Stops.OttoHahnRing,
                    Stops.MaxBornStr,
                    Stops.JohannesKeplerPlatz,
                    Stops.Falkenhorst,
                    Stops.Schilfhof,
                    Stops.MagnusZellerPlatz,
                    Stops.EduardClaudiusStrDrewitzerStr,
                    Stops.EduardClaudiusStrHeinrichMannAllee,
                    Stops.WaldstrHorstweg,
                ],
                CommonStopIndex = 0,
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                        { StopDistances = [M1, M1, M1, M2, M2, M1, M1, M5, M1, M1, M1, M2, M2,], },
                ],
            },
        ],
        TripsCreate =
        [
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(19, 30),
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(19, 39),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(19, 50),
            }.AlsoEvery(M10, new TimeOnly(20, 20)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(20, 43),
            }.AlsoEvery(M20, new TimeOnly(23, 43)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(0, 3),
            }.AlsoEvery(M20, new TimeOnly(1, 23)),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(19, 59),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(20, 20),
            }.AlsoEvery(M20, new TimeOnly(23, 40)),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(0, 0),
            },
        ],
    };
}
