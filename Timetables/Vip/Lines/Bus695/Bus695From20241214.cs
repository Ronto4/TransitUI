using Timetables.Models;
using static Timetables.Vip.Minutes;

namespace Timetables.Vip.Lines.Bus695;

public class Bus695From20241214 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 12, 14);

    public Line Line { get; } = new()
    {
        Name = "695",
        TransportationType = TransportationType.Bus,
        MainRouteIndices = [0, 1, 2, 3, 4, 6],
        OverviewRouteIndices = [0, 3],
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.AltGolm,
                    Stops.KircheGolm,
                    Stops.ScienceParkWest,
                    Stops.BahnhofGolm,
                    Stops.ScienceParkUniversität,
                    Stops.AmUrnenfeld,
                    Stops.Kuhfortdamm,
                    Stops.Ehrenpfortenbergstr,
                    Stops.Baumschulenweg,
                    Stops.AmAltenMörtelwerk,
                    Stops.AmGrünenWeg,
                    Stops.KaiserFriedrichStrPolizei,
                    Stops.StudentenwohnheimEiche,
                    Stops.AbzweigNachEiche,
                    Stops.Drachenhaus,
                    Stops.Orangerie,
                    Stops.SchlossSanssouci,
                    Stops.Brentanoweg,
                    Stops.ReiterwegJägerallee,
                    Stops.JägertorJustizzentrum,
                    Stops.Mauerstr,
                    Stops.LuisenplatzNordParkSanssouci,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.Naturkundemuseum,
                    Stops.Schlossstr,
                    Stops.SHauptbahnhof,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M2, M1, M1, M1, M1, M1, M0, M1, M0, M1, M1, M1, M1, M1, M2, M2, M3, M1, M1, M1, M1, M2,
                            M2, M3,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M2, M1, M1, M1, M1, M1, M1, M1, M0, M1, M1, M1, M1, M1, M2, M2, M3, M1, M1, M2, M1, M2,
                            M2, M3,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M2, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M2, M2, M3, M1, M1, M2, M1, M2,
                            M2, M3,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M2, M1, M1, M1, M1, M1, M0, M1, M0, M1, M1, M0, M1, M1, M1, M2, M3, M1, M1, M1, M1, M2,
                            M1, M3,
                        ],
                    },
                ],
                CommonStopIndex = 21 /* Luisenplatz-Nord/Park Sanssouci */,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.ScienceParkWest,
                    Stops.BahnhofGolm,
                    Stops.ScienceParkUniversität,
                    Stops.AmUrnenfeld,
                    Stops.Kuhfortdamm,
                    Stops.Ehrenpfortenbergstr,
                    Stops.Baumschulenweg,
                    Stops.AmAltenMörtelwerk,
                    Stops.AmGrünenWeg,
                    Stops.KaiserFriedrichStrPolizei,
                    Stops.StudentenwohnheimEiche,
                    Stops.AbzweigNachEiche,
                    Stops.Drachenhaus,
                    Stops.Orangerie,
                    Stops.SchlossSanssouci,
                    Stops.Brentanoweg,
                    Stops.ReiterwegJägerallee,
                    Stops.JägertorJustizzentrum,
                    Stops.Mauerstr,
                    Stops.LuisenplatzNordParkSanssouci,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.Naturkundemuseum,
                    Stops.Schlossstr,
                    Stops.SHauptbahnhof,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M0, M1, M0, M1, M1, M1, M1, M1, M2, M2, M3, M1, M1, M1, M1, M2, M2, M3,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M1, M1, M0, M1, M1, M1, M1, M1, M2, M2, M3, M1, M1, M2, M1, M2, M2, M3,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M0, M1, M0, M1, M1, M0, M1, M1, M1, M2, M3, M1, M1, M1, M1, M2, M1, M3,
                        ],
                    },
                ],
                CommonStopIndex = 19 /* Luisenplatz-Nord/Park Sanssouci */,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.SchlossSanssouci,
                    Stops.Brentanoweg,
                    Stops.ReiterwegJägerallee,
                    Stops.JägertorJustizzentrum,
                    Stops.Mauerstr,
                    Stops.LuisenplatzNordParkSanssouci,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.Naturkundemuseum,
                    Stops.Schlossstr,
                    Stops.SHauptbahnhof,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M2, M3, M1, M1, M1, M1, M2, M2, M3,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M2, M3, M1, M1, M2, M1, M2, M2, M3,
                        ],
                    },
                ],
                CommonStopIndex = 5 /* Luisenplatz-Nord/Park Sanssouci */,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.SHauptbahnhof,
                    Stops.Schlossstr,
                    Stops.Naturkundemuseum,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.LuisenplatzNordParkSanssouci,
                    Stops.JägertorJustizzentrum,
                    Stops.ReiterwegJägerallee,
                    Stops.Brentanoweg,
                    Stops.SchlossSanssouci,
                    Stops.Orangerie,
                    Stops.Drachenhaus,
                    Stops.AbzweigNachEiche,
                    Stops.StudentenwohnheimEiche,
                    Stops.KaiserFriedrichStrPolizei,
                    Stops.AmGrünenWeg,
                    Stops.AmAltenMörtelwerk,
                    Stops.Ecksteinweg,
                    Stops.Baumschulenweg,
                    Stops.Ehrenpfortenbergstr,
                    Stops.Kuhfortdamm,
                    Stops.AmUrnenfeld,
                    Stops.ScienceParkUniversität,
                    Stops.BahnhofGolm,
                    Stops.ScienceParkWest,
                    Stops.KircheGolm,
                    Stops.AltGolm,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M1, M1, M2, M2, M2, M1, M3, M1, M1, M1, M1, M0, M1, M1, M0, M1, M0, M1, M1, M1, M1, M2,
                            M2, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M2, M1, M2, M2, M3, M1, M3, M2, M1, M1, M1, M0, M1, M1, M0, M1, M0, M1, M1, M1, M1, M2,
                            M2, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M2, M2, M2, M2, M3, M1, M3, M2, M1, M1, M1, M0, M1, M1, M0, M1, M0, M1, M1, M2, M1, M2,
                            M2, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M1, M1, M2, M2, M2, M1, M3, M1, M1, M1, M1, M0, M1, M1, M0, M1, M0, M1, M1, M1, M1, M2,
                            M2, M1,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.SHauptbahnhof,
                    Stops.Schlossstr,
                    Stops.Naturkundemuseum,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.LuisenplatzNordParkSanssouci,
                    Stops.JägertorJustizzentrum,
                    Stops.ReiterwegJägerallee,
                    Stops.Brentanoweg,
                    Stops.SchlossSanssouci,
                    Stops.Orangerie,
                    Stops.Drachenhaus,
                    Stops.AbzweigNachEiche,
                    Stops.StudentenwohnheimEiche,
                    Stops.KaiserFriedrichStrPolizei,
                    Stops.AmGrünenWeg,
                    Stops.AmAltenMörtelwerk,
                    Stops.Ecksteinweg,
                    Stops.Baumschulenweg,
                    Stops.Ehrenpfortenbergstr,
                    Stops.Kuhfortdamm,
                    Stops.AmUrnenfeld,
                    Stops.ScienceParkUniversität,
                    Stops.BahnhofGolm,
                    Stops.ScienceParkWest,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M1, M1, M2, M2, M2, M1, M3, M1, M1, M1, M1, M0, M1, M1, M0, M1, M0, M1, M1, M1, M1, M2,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M2, M1, M2, M2, M3, M1, M3, M2, M1, M1, M1, M0, M1, M1, M0, M1, M0, M1, M1, M1, M1, M2,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M1, M1, M2, M2, M2, M1, M3, M1, M1, M1, M1, M0, M1, M1, M0, M1, M0, M1, M1, M1, M1, M2,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.SHauptbahnhof,
                    Stops.Schlossstr,
                    Stops.Naturkundemuseum,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.LuisenplatzNordParkSanssouci,
                    Stops.JägertorJustizzentrum,
                    Stops.ReiterwegJägerallee,
                    Stops.Brentanoweg,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M2, M1, M2, M2, M3, M1,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.SHauptbahnhof,
                    Stops.Schlossstr,
                    Stops.Naturkundemuseum,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.LuisenplatzNordParkSanssouci,
                    Stops.JägertorJustizzentrum,
                    Stops.ReiterwegJägerallee,
                    Stops.Brentanoweg,
                    Stops.SchlossSanssouci,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M1, M1, M2, M2, M2, M1, M3,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M2, M1, M2, M2, M3, M1, M3,
                        ],
                    },
                ],
                CommonStopIndex = 1,
            },
        ],
        TripsCreate =
        [
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 9),
            }.AlsoEvery(M60, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 27),
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 6),
            }.AlsoEvery(M20, new TimeOnly(8, 46)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(9, 7),
            }.AlsoEvery(M60, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(12, 7),
            }.AlsoEvery(M20, new TimeOnly(14, 27)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(14, 46),
            }.AlsoEvery(M20, new TimeOnly(16, 26)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(16, 47),
            }.AlsoEvery(M20, new TimeOnly(19, 7)),
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(20, 7),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 3,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(20, 59),
            }.AlsoEvery(M60, new TimeOnly(23, 59)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 52),
            }.AlsoEvery(M60, 2),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 32),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(9, 30),
            }.AlsoEvery(M60, new TimeOnly(11, 30)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(9, 50),
            }.AlsoEvery(M60, new TimeOnly(11, 50)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(19, 30),
            }.AlsoEvery(M20, 2),
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(6, 49),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(7, 49),
            }.AlsoEvery(M60, new TimeOnly(9, 49)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 47),
            }.AlsoEvery(M60, new TimeOnly(19, 47)),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(20, 50),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 3,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(20, 59),
            }.AlsoEvery(M60, 2),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(23, 2),
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 3,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(23, 59),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(8, 25),
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(9, 25),
            }.AlsoEvery(M20, 2),
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 25),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 44),
            }.AlsoEvery(M60, new TimeOnly(19, 44)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(11, 24),
            }.AlsoEvery(M60, new TimeOnly(19, 24)),
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 34),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 34),
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 17),
            }.AlsoEvery(M20, new TimeOnly(8, 17)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(9, 17),
            }.AlsoEvery(M60, new TimeOnly(10, 17)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(11, 17),
            }.AlsoEvery(M20, new TimeOnly(13, 57)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(14, 17),
            }.AlsoEvery(M20, new TimeOnly(17, 17)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(17, 37),
            }.AlsoEvery(M20, new TimeOnly(18, 17)),
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(19, 17),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 3,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(20, 14),
            }.AlsoEvery(M60, new TimeOnly(23, 14)),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 54),
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(8, 37),
            }.AlsoEvery(M60, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(8, 57),
            }.AlsoEvery(M60, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(18, 37),
            }.AlsoEvery(M20, 2),
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(19, 37),
            },
            new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(19, 57),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 37),
            }.AlsoEvery(M60, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(7, 37),
            }.AlsoEvery(M60, new TimeOnly(9, 37)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 37),
            }.AlsoEvery(M60, new TimeOnly(19, 37)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 3,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(20, 14),
            }.AlsoEvery(M60, new TimeOnly(21, 14)),
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(22, 14),
            },
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 3,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(23, 14),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(7, 57),
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(8, 57),
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(9, 57),
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 57),
            }.AlsoEvery(M60, new TimeOnly(18, 57)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(11, 17),
            }.AlsoEvery(M60, new TimeOnly(19, 17)),
        ],
    };
}