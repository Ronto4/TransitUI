using Timetables.Models;
using static Timetables.Vip.Minutes;

namespace Timetables.Vip.Lines.Bus605;

public class Bus605From20241214 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 12, 14);

    public Line Line { get; } = new()
    {
        Name = "605",
        TransportationType = TransportationType.Bus,
        MainRouteIndices = [0, 1, 2, 4, 5, 6],
        OverviewRouteIndices = [0, 4],
        Annotations = [],
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.ScienceParkWest,
                    Stops.BahnhofGolm,
                    Stops.GolmerFichten,
                    Stops.ZumGroßenHerzberg,
                    Stops.Eichenring,
                    Stops.Mehlbeerenweg,
                    Stops.AmAltenMörtelwerk,
                    Stops.AmGrünenWeg,
                    Stops.KaiserFriedrichStrPolizei,
                    Stops.StudentenwohnheimEiche,
                    Stops.AbzweigNachEiche,
                    Stops.CampusUniversitätAbrahamGeigerKolleg,
                    Stops.NeuesPalais,
                    Stops.BahnhofParkSanssouci,
                    Stops.BahnhofParkSanssouci,
                    Stops.SchlossCharlottenhof,
                    Stops.KastanienalleeZeppelinstr,
                    Stops.SchillerplatzSchafgraben,
                    Stops.BahnhofCharlottenhof,
                    Stops.AufDemKiewitt,
                    Stops.Feuerbachstr,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.Dortustr,
                    Stops.PlatzDerEinheitWest,
                    Stops.AlterMarktLandtag,
                    Stops.SHauptbahnhof,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M2, M1, M1, M0, M1, M1, M1, M1, M1, M1, M0, M2, M1, M2, M1, M1, M0, M2, M1, M2,
                            M1, M3
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M2, M1, M1, M0, M1, M1, M1, M2, M1, M1, M0, M2, M2, M2, M1, M1, M0, M2, M1, M2,
                            M1, M3
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M2, M1, M1, M1, M1, M1, M1, M2, M1, M1, M0, M2, M2, M2, M2, M1, M0, M2, M1, M2,
                            M1, M3
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M1, M0, M1, M1, M0, M1, M1, M1, M0, M2, M1, M2, M1, M1, M0, M2, M1, M1,
                            M1, M3
                        ],
                    },
                ],
                CommonStopIndex = 18,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.ScienceParkWest,
                    Stops.BahnhofGolm,
                    Stops.GolmerFichten,
                    Stops.ZumGroßenHerzberg,
                    Stops.Eichenring,
                    Stops.Mehlbeerenweg,
                    Stops.AmAltenMörtelwerk,
                    Stops.AmGrünenWeg,
                    Stops.KaiserFriedrichStrPolizei,
                    Stops.StudentenwohnheimEiche,
                    Stops.AbzweigNachEiche,
                    Stops.CampusUniversitätAbrahamGeigerKolleg,
                    Stops.NeuesPalais,
                    Stops.BahnhofParkSanssouci,
                    Stops.BahnhofParkSanssouci,
                    Stops.SchlossCharlottenhof,
                    Stops.KastanienalleeZeppelinstr,
                    Stops.SchillerplatzSchafgraben,
                    Stops.BahnhofCharlottenhof,
                    Stops.AufDemKiewitt,
                    Stops.LuisenplatzSüdParkSanssouci,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M2, M1, M1, M0, M1, M1, M1, M2, M1, M1, M0, M2, M2, M2, M1, M1, M4,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M2, M1, M1, M1, M1, M1, M1, M2, M1, M1, M0, M2, M2, M2, M2, M1, M4,
                        ],
                    },
                ],
                CommonStopIndex = 20,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.ScienceParkWest,
                    Stops.BahnhofGolm,
                    Stops.GolmerFichten,
                    Stops.ZumGroßenHerzberg,
                    Stops.Eichenring,
                    Stops.Mehlbeerenweg,
                    Stops.AmAltenMörtelwerk,
                    Stops.AmGrünenWeg,
                    Stops.KaiserFriedrichStrPolizei,
                    Stops.StudentenwohnheimEiche,
                    Stops.AbzweigNachEiche,
                    Stops.CampusUniversitätAbrahamGeigerKolleg,
                    Stops.NeuesPalais,
                    Stops.BahnhofParkSanssouci,
                    Stops.BahnhofParkSanssouci,
                    Stops.SchlossCharlottenhof,
                    Stops.KastanienalleeZeppelinstr,
                    Stops.SchillerplatzSchafgraben,
                    Stops.BahnhofCharlottenhof,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M1, M0, M1, M1, M0, M1, M1, M1, M0, M2, M1, M2, M1,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.BahnhofGolm,
                    Stops.GolmerFichten,
                    Stops.ZumGroßenHerzberg,
                    Stops.Eichenring,
                    Stops.Mehlbeerenweg,
                    Stops.AmAltenMörtelwerk,
                    Stops.AmGrünenWeg,
                    Stops.KaiserFriedrichStrPolizei,
                    Stops.StudentenwohnheimEiche,
                    Stops.AbzweigNachEiche,
                    Stops.CampusUniversitätAbrahamGeigerKolleg,
                    Stops.NeuesPalais,
                    Stops.BahnhofParkSanssouci,
                    Stops.BahnhofParkSanssouci,
                    Stops.SchlossCharlottenhof,
                    Stops.KastanienalleeZeppelinstr,
                    Stops.SchillerplatzSchafgraben,
                    Stops.BahnhofCharlottenhof,
                    Stops.AufDemKiewitt,
                    Stops.Feuerbachstr,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.Dortustr,
                    Stops.PlatzDerEinheitWest,
                    Stops.AlterMarktLandtag,
                    Stops.SHauptbahnhof,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M2, M1, M1, M0, M1, M1, M1, M1, M1, M1, M0, M2, M1, M2, M1, M1, M0, M2, M1, M2,
                            M1, M3
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions = [
                    Stops.SHauptbahnhof,
                    Stops.AlterMarktLandtag,
                    Stops.PlatzDerEinheitWest,
                    Stops.Dortustr,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.Feuerbachstr,
                    Stops.AufDemKiewitt,
                    Stops.BahnhofCharlottenhofGeschwisterSchollStr,
                    Stops.SchlossCharlottenhof,
                    Stops.SchlossCharlottenhof,
                    Stops.BahnhofParkSanssouci,
                    Stops.NeuesPalais,
                    Stops.CampusUniversitätAbrahamGeigerKolleg,
                    Stops.AbzweigNachEiche,
                    Stops.StudentenwohnheimEiche,
                    Stops.KaiserFriedrichStrPolizei,
                    Stops.AmGrünenWeg,
                    Stops.AmAltenMörtelwerk,
                    Stops.Mehlbeerenweg,
                    Stops.Eichenring,
                    Stops.ZumGroßenHerzberg,
                    Stops.GolmerFichten,
                    Stops.BahnhofGolm,
                    Stops.ScienceParkWest,
                ],
                TimeProfiles = [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M3, M2, M1, M1, M1, M1, M1, M2, M0, M2, M1, M1, M1, M1, M0, M1, M1, M1, M1, M1, M1, M1, M2],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M3, M2, M1, M2, M1, M1, M1, M2, M0, M2, M1, M1, M1, M1, M0, M1, M1, M2, M1, M1, M1, M1, M2],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M3, M1, M1, M1, M1, M1, M1, M1, M0, M1, M1, M1, M1, M1, M0, M1, M1, M1, M1, M2, M1, M1, M2],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions = [
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.Feuerbachstr,
                    Stops.AufDemKiewitt,
                    Stops.BahnhofCharlottenhofGeschwisterSchollStr,
                    Stops.SchlossCharlottenhof,
                    Stops.SchlossCharlottenhof,
                    Stops.BahnhofParkSanssouci,
                    Stops.NeuesPalais,
                    Stops.CampusUniversitätAbrahamGeigerKolleg,
                    Stops.AbzweigNachEiche,
                    Stops.StudentenwohnheimEiche,
                    Stops.KaiserFriedrichStrPolizei,
                    Stops.AmGrünenWeg,
                    Stops.AmAltenMörtelwerk,
                    Stops.Mehlbeerenweg,
                    Stops.Eichenring,
                    Stops.ZumGroßenHerzberg,
                    Stops.GolmerFichten,
                    Stops.BahnhofGolm,
                    Stops.ScienceParkWest,
                ],
                TimeProfiles = [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M1, M2, M0, M2, M1, M1, M1, M1, M0, M1, M1, M2, M1, M1, M1, M1, M2],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions = [
                    Stops.SchlossCharlottenhof,
                    Stops.SchlossCharlottenhof,
                    Stops.BahnhofParkSanssouci,
                    Stops.NeuesPalais,
                    Stops.CampusUniversitätAbrahamGeigerKolleg,
                    Stops.AbzweigNachEiche,
                    Stops.StudentenwohnheimEiche,
                    Stops.KaiserFriedrichStrPolizei,
                    Stops.AmGrünenWeg,
                    Stops.AmAltenMörtelwerk,
                    Stops.Mehlbeerenweg,
                    Stops.Eichenring,
                    Stops.ZumGroßenHerzberg,
                    Stops.GolmerFichten,
                    Stops.BahnhofGolm,
                    Stops.ScienceParkWest,
                ],
                TimeProfiles = [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M0, M1, M1, M1, M1, M1, M0, M1, M1, M1, M1, M2, M1, M1, M2],
                    },
                ],
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
                StartTime = new TimeOnly(5, 5)
            }.AlsoEvery(M20, new TimeOnly(6, 5)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 23)
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 1)
            }.AlsoEvery(M20, new TimeOnly(8, 41)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(9, 3)
            }.AlsoEvery(M20, new TimeOnly(14, 23)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(14, 41)
            }.AlsoEvery(M20, new TimeOnly(16, 21)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(16, 43)
            }.AlsoEvery(M20, new TimeOnly(19, 23)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 3,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(19, 45)
            }.AlsoEvery(M20, new TimeOnly(20, 25)),
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 3,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(0, 45)
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 45)
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(6, 25)
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(6, 45)
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(7, 25)
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(7, 45)
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(8, 25)
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(8, 45)
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(9, 5)
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(9, 25)
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(9, 45)
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(10, 3)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 23)
            }.AlsoEvery(M20, new TimeOnly(19, 23)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 52)
            }.AlsoEvery(M20, new TimeOnly(8, 52)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(9, 14)
            }.AlsoEvery(M20, new TimeOnly(14, 34)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(14, 52)
            }.AlsoEvery(M20, new TimeOnly(16, 32)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(16, 54)
            }.AlsoEvery(M20, new TimeOnly(17, 34)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(17, 53)
            }.AlsoEvery(M20, new TimeOnly(18, 33)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 45)
            }.AlsoEvery(M20, new TimeOnly(0, 25)),
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 21)
            },
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 26)
            },
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(7, 26)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 44),
            }.AlsoEvery(M20, new TimeOnly(6, 4)),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 14),
            }.AlsoEvery(M10, new TimeOnly(7, 4)),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 24),
            }.AlsoEvery(M20, new TimeOnly(20, 4)),
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 4),
            },
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 44),
            },
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(6, 4),
            },
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(6, 44),
            },
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(7, 4),
            },
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(7, 44),
            },
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(8, 4),
            },
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(8, 24),
            },
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(8, 44),
            },
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(9, 4),
            },
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(9, 24),
            },
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(9, 44),
            },
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 4),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 24),
            }.AlsoEvery(M20, new TimeOnly(20, 4)),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 16),
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 20),
            }.AlsoEvery(M20, new TimeOnly(18, 0)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(21, 6),
            }.AlsoEvery(M20, new TimeOnly(0, 46)),
        ],
    };
}
