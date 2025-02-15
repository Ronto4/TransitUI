using Timetable.Models;
using static Timetable.Vip.Minutes;

namespace Timetable.Vip.Lines.Bus698;

public class Bus698From20241214 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 12, 14);

    public Line Line { get; } = new()
    {
        Name = "698",
        TransportationType = TransportationType.Bus,
        MainRouteIndices = [0, 1, 2, 3],
        OverviewRouteIndices = [0, 2],
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.KircheGolm,
                    Stops.Weinmeisterstr,
                    Stops.ScienceParkUniversität,
                    Stops.BahnhofGolm,
                    Stops.ScienceParkWest,
                    Stops.Geiselberg,
                    Stops.SportplatzBornim,
                    Stops.Hugstr,
                    Stops.Gutsstr,
                    Stops.HermannStruveStr,
                    Stops.Florastr,
                    Stops.AmundsenstrPotsdamerStr,
                    Stops.Thaerstr,
                    Stops.Kirschallee,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M1, M2, M2, M1, M1, M1, M2, M2, M1, M1, M3,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M1, M2, M2, M1, M1, M1, M2, M2, M1, M2, M3,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M1, M2, M2, M1, M1, M1, M2, M1, M1, M1, M3,],
                    },
                ],
                CommonStopIndex = 12 /* Thaerstr. */,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.ScienceParkUniversität,
                    Stops.BahnhofGolm,
                    Stops.ScienceParkWest,
                    Stops.Geiselberg,
                    Stops.SportplatzBornim,
                    Stops.Hugstr,
                    Stops.Gutsstr,
                    Stops.HermannStruveStr,
                    Stops.Florastr,
                    Stops.AmundsenstrPotsdamerStr,
                    Stops.Thaerstr,
                    Stops.Kirschallee,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M2, M1, M1, M1, M2, M2, M1, M1, M3,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M2, M1, M1, M1, M2, M2, M1, M2, M3,],
                    },
                ],
                CommonStopIndex = 10 /* Thaerstr. */,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Kirschallee,
                    Stops.Thaerstr,
                    Stops.AmundsenstrPotsdamerStr,
                    Stops.Florastr,
                    Stops.HermannStruveStr,
                    Stops.Gutsstr,
                    Stops.Hugstr,
                    Stops.SportplatzBornim,
                    Stops.Geiselberg,
                    Stops.ScienceParkWest,
                    Stops.BahnhofGolm,
                    Stops.ScienceParkUniversität,
                    Stops.Weinmeisterstr,
                    Stops.KircheGolm,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M3, M1, M1, M1, M1, M2, M1, M1, M2, M1, M1, M2, M2,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M3, M1, M1, M2, M1, M2, M1, M1, M2, M1, M1, M2, M2,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M2, M1, M1, M1, M1, M1, M1, M1, M2, M1, M1, M2, M2,],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Kirschallee,
                    Stops.Thaerstr,
                    Stops.AmundsenstrPotsdamerStr,
                    Stops.Florastr,
                    Stops.HermannStruveStr,
                    Stops.Gutsstr,
                    Stops.Hugstr,
                    Stops.SportplatzBornim,
                    Stops.Geiselberg,
                    Stops.ScienceParkWest,
                    Stops.BahnhofGolm,
                    Stops.ScienceParkUniversität,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M3, M1, M1, M1, M1, M2, M1, M1, M2, M1, M1,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M3, M1, M1, M2, M1, M2, M1, M1, M2, M1, M1,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M2, M1, M1, M1, M1, M1, M1, M1, M2, M1, M1,],
                    },
                ],
                CommonStopIndex = 0,
            },
        ],
        TripsCreate =
        [
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 5),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 4),
            }.AlsoEvery(M60, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(9, 5),
            }.AlsoEvery(M60, new TimeOnly(14, 5)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(15, 4),
            }.AlsoEvery(M60, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(17, 5),
            }.AlsoEvery(M60, new TimeOnly(19, 5)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(20, 10),
            }.AlsoEvery(M60, new TimeOnly(23, 10)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(6, 53),
            }.AlsoEvery(M60, new TimeOnly(18, 53)),
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(20, 7),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(21, 10),
            }.AlsoEvery(M60, new TimeOnly(23, 10)),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 8),
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 38),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 37),
            }.AlsoEvery(M60, 2),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(13, 38),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(14, 37),
            }.AlsoEvery(M60, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(16, 38),
            }.AlsoEvery(M60, new TimeOnly(18, 38)),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(4, 56),
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(5, 56),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 38),
            }.AlsoEvery(M60, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 38),
            }.AlsoEvery(M60, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(9, 38),
            }.AlsoEvery(M60, new TimeOnly(13, 38)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(14, 38),
            }.AlsoEvery(M60, new TimeOnly(16, 38)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(17, 38),
            }.AlsoEvery(M60, new TimeOnly(19, 38)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(20, 37),
            }.AlsoEvery(M60, new TimeOnly(22, 37)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(6, 32),
            }.AlsoEvery(M60, new TimeOnly(19, 32)),
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(20, 40),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(21, 37),
            }.AlsoEvery(M60, new TimeOnly(22, 37)),
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 32),
            },
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 8),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 8),
            }.AlsoEvery(M60, 2),
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(9, 8),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(13, 8),
            }.AlsoEvery(M60, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(15, 8),
            }.AlsoEvery(M60, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(17, 8),
            }.AlsoEvery(M60, 2),
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(23, 37),
            },
        ],
    };
}