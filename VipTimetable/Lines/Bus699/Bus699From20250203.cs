using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus699;

public class Bus699From20250203 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 2, 3);
    private static Bus699From20241215 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        MainRouteIndices = [0, 1, 2, 3],
        OverviewRouteIndices = [0, 2],
        Routes =
        [
            ..Previous.Line.Routes[..2],
            new Line.Route
            {
                StopPositions =
                [
                    Stops.JohannesKeplerPlatz,
                    Stops.Gerlachstr,
                    Stops.SternCenterGerlachstr,
                    Stops.HansAlbersStr,
                    Stops.RobertBaberskeStr,
                    Stops.KonradWolfAlleeSternstr,
                    Stops.DrewitzOrt,
                    Stops.TrebbinerStr,
                    Stops.DrewitzerStrAmBuchhorst,
                    Stops.AnDerBrauerei,
                    Stops.BergholzRehbrückeVerdistr,
                    Stops.BahnhofRehbrückeSüd,
                    Stops.BahnhofRehbrücke,
                ],
                CommonStopIndex = 10,
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M3, M1, M2, M2, M1, M1, M1, M2, M1, M1, M1, M1,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M2, M1, M2, M1, M2, M1, M1, M2, M1, M0, M1, M1,],
                    },
                ],
            },
            new Line.Route
            {
                ManualAnnotation = "via Zum Heizwerk",
                StopPositions =
                [
                    Stops.JohannesKeplerPlatz,
                    Stops.Gerlachstr,
                    Stops.SternCenterGerlachstr,
                    Stops.HansAlbersStr,
                    Stops.RobertBaberskeStr,
                    Stops.KonradWolfAlleeSternstr,
                    Stops.DrewitzOrt,
                    Stops.TrebbinerStr,
                    Stops.DrewitzerStrAmBuchhorst,
                    Stops.ZumHeizwerk,
                    Stops.AnDerBrauerei,
                    Stops.BergholzRehbrückeVerdistr,
                    Stops.BahnhofRehbrückeSüd,
                    Stops.BahnhofRehbrücke,
                ],
                CommonStopIndex = 11,
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M3, M1, M2, M2, M1, M1, M1, M2, M1, M3, M1, M1, M1,],
                    },
                ],
            },
        ],
        TripsCreate =
        [
            ..Previous.Line.TripsCreate.Where(trip => !trip.RouteIndex.Equals(2)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 6)
            }.AlsoEvery(M20, new TimeOnly(6, 26)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 6)
            }.AlsoEvery(M60, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(7, 6)
            }.AlsoEvery(M60, new TimeOnly(19, 6)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(6, 46)
            }.AlsoEvery(M20, new TimeOnly(19, 46)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 43)
            }.AlsoEvery(M20, new TimeOnly(8, 23)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(8, 46)
            }.AlsoEvery(M20, new TimeOnly(14, 46)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(15, 3)
            }.AlsoEvery(M20, new TimeOnly(17, 43)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(18, 6)
            }.AlsoEvery(M20, new TimeOnly(19, 46)),
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 8)
            },
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(20, 28)
            },
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 54)
            },
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(21, 14)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(21, 54)
            }.AlsoEvery(M60, new TimeOnly(23, 54)),
        ],
    };
}
