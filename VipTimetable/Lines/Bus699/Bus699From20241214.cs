using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus699;

public class Bus699From20241214 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 12, 14);

    public Line Line { get; } = new()
    {
        Name = "699",
        TransportationType = TransportationType.Bus,
        MainRouteIndices = [0, 1, 2],
        OverviewRouteIndices = [0, 2],
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.BahnhofRehbrücke,
                    Stops.BergholzRehbrückeVerdistr,
                    Stops.AnDerBrauerei,
                    Stops.DrewitzerStrAmBuchhorst,
                    Stops.TrebbinerStr,
                    Stops.DrewitzOrt,
                    Stops.KonradWolfAlleeSternstr,
                    Stops.RobertBaberskeStr,
                    Stops.HansAlbersStr,
                    Stops.SternCenterGerlachstr,
                    Stops.Gerlachstr,
                    Stops.JohannesKeplerPlatz,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M2, M1, M1, M2, M1, M1, M1, M2, M2, M2, M2,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M2, M1, M1, M2, M1, M1, M1, M1, M1, M1, M2,],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                ManualAnnotation = "via Zum Heizwerk",
                StopPositions =
                [
                    Stops.BahnhofRehbrücke,
                    Stops.BergholzRehbrückeVerdistr,
                    Stops.AnDerBrauerei,
                    Stops.ZumHeizwerk,
                    Stops.DrewitzerStrAmBuchhorst,
                    Stops.TrebbinerStr,
                    Stops.DrewitzOrt,
                    Stops.KonradWolfAlleeSternstr,
                    Stops.RobertBaberskeStr,
                    Stops.HansAlbersStr,
                    Stops.SternCenterGerlachstr,
                    Stops.Gerlachstr,
                    Stops.JohannesKeplerPlatz,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M2, M1, M2, M2, M2, M1, M1, M1, M2, M2, M2, M2,],
                    },
                ],
                CommonStopIndex = 0,
            },
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
                    Stops.ZumHeizwerk,
                    Stops.AmMoosfenn,
                    Stops.BahnhofRehbrücke,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M3, M1, M2, M2, M1, M1, M1, M2, M1, M5, M2,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M3, M1, M2, M2, M1, M1, M1, M2, M1, M5, M1,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M2, M1, M2, M1, M2, M1, M1, M2, M1, M5, M1,],
                    },
                ],
                CommonStopIndex = 11 /* Bhf Rehbrücke */,
            },
        ],
        TripsCreate =
        [
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 18),
            }.AlsoEvery(M20, new TimeOnly(6, 38)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 38),
            }.AlsoEvery(M60, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(7, 18),
            }.AlsoEvery(M20, new TimeOnly(20, 18)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(7, 38),
            }.AlsoEvery(M60, new TimeOnly(19, 38)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 58),
            }.AlsoEvery(M20, new TimeOnly(8, 38)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(8, 58),
            }.AlsoEvery(M20, new TimeOnly(14, 58)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(15, 18),
            }.AlsoEvery(M20, new TimeOnly(17, 58)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(18, 18),
            }.AlsoEvery(M20, new TimeOnly(20, 18)),
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(20, 35),
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(21, 31),
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(20, 38),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(20, 51),
            }.AlsoEvery(M20, new TimeOnly(21, 51)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(22, 31),
            }.AlsoEvery(M60, new TimeOnly(0, 31)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 10),
            }.AlsoEvery(M20, new TimeOnly(6, 30)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 10),
            }.AlsoEvery(M60, new TimeOnly(6, 10)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(6, 50),
            }.AlsoEvery(M20, new TimeOnly(19, 10)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(7, 10),
            }.AlsoEvery(M60, new TimeOnly(19, 10)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 51),
            }.AlsoEvery(M20, new TimeOnly(8, 31)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(8, 50),
            }.AlsoEvery(M20, new TimeOnly(14, 50)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(15, 11),
            }.AlsoEvery(M20, new TimeOnly(17, 51)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(18, 10),
            }.AlsoEvery(M20, new TimeOnly(19, 10)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(19, 30),
            }.AlsoEvery(M20, new TimeOnly(21, 10)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(20, 10),
            }.AlsoEvery(M40, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(21, 50),
            }.AlsoEvery(M60, new TimeOnly(23, 50)),
        ],
    };
}
