using Timetable.Models;

namespace Timetable.Vip.Lines.Tram91;

using static Minutes;

public class Tram91From20240102 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 1, 2);

    public Line Line { get; } = new()
    {
        Name = "91",
        TransportationType = TransportationType.Tram,
        MainRouteIndices = [0, 3],
        OverviewRouteIndices = [0, 3],
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.BahnhofPirschheide,
                    Stops.Luftschiffhafen,
                    Stops.ImBogenZeppelinstr,
                    Stops.KastanienalleeZeppelinstr,
                    Stops.SchillerplatzSchafgraben,
                    Stops.BahnhofCharlottenhof,
                    Stops.AufDemKiewitt,
                    Stops.Feuerbachstr,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.Dortustr,
                    Stops.PlatzDerEinheitWest,
                    Stops.AlterMarktLandtag,
                    Stops.LangeBrücke,
                    Stops.SHauptbahnhof,
                    Stops.Friedhöfe,
                    Stops.Sporthalle,
                    Stops.KunersdorferStr,
                    Stops.WaldstrHorstweg,
                    Stops.EduardClaudiusStrHeinrichMannAllee,
                    Stops.ZumKahleberg,
                    Stops.FriedrichWolfStr,
                    Stops.AmMoosfenn,
                    Stops.BahnhofRehbrücke
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M1, M1, M2, M1, M1, M1, M1, M1, M2, M1, M1, M3, M2, M1, M1, M1, M1, M1, M1, M1, M2]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M1, M1, M2, M1, M1, M1, M1, M1, M3, M1, M1, M3, M2, M1, M1, M1, M1, M1, M1, M1, M2]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M1, M1, M2, M1, M1, M1, M2, M1, M3, M1, M1, M3, M2, M1, M1, M1, M1, M1, M1, M1, M2]
                    },
                ],
                CommonStopIndex = 10
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.PlatzDerEinheitNord,
                    Stops.PlatzDerEinheitWest,
                    Stops.AlterMarktLandtag,
                    Stops.LangeBrücke,
                    Stops.SHauptbahnhof,
                    Stops.Friedhöfe,
                    Stops.Sporthalle,
                    Stops.KunersdorferStr,
                    Stops.WaldstrHorstweg,
                    Stops.EduardClaudiusStrHeinrichMannAllee,
                    Stops.ZumKahleberg,
                    Stops.FriedrichWolfStr,
                    Stops.AmMoosfenn,
                    Stops.BahnhofRehbrücke
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M3, M2, M1, M1, M1, M1, M1, M1, M1, M2]
                    },
                ],
                CommonStopIndex = 0
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.BahnhofPirschheide,
                    Stops.Luftschiffhafen,
                    Stops.ImBogenZeppelinstr,
                    Stops.KastanienalleeZeppelinstr,
                    Stops.SchillerplatzSchafgraben,
                    Stops.BahnhofCharlottenhof,
                    Stops.AufDemKiewitt,
                    Stops.Feuerbachstr,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.Dortustr,
                    Stops.PlatzDerEinheitWest,
                    Stops.AlterMarktLandtag,
                    Stops.LangeBrücke,
                    Stops.SHauptbahnhof,
                    Stops.Friedhöfe,
                    Stops.Sporthalle,
                    Stops.KunersdorferStr,
                    Stops.WaldstrHorstweg,
                    Stops.MagnusZellerPlatz,
                    Stops.Bisamkiez
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M2, M1, M1, M1, M1, M1, M2, M1, M1, M4, M2, M0, M1, M1, M2, M2]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M2, M1, M1, M1, M1, M1, M3, M1, M1, M3, M2, M1, M1, M1, M2, M2]
                    },
                ],
                CommonStopIndex = 10
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.BahnhofRehbrücke,
                    Stops.AmMoosfenn,
                    Stops.FriedrichWolfStr,
                    Stops.ZumKahleberg,
                    Stops.EduardClaudiusStrHeinrichMannAllee,
                    Stops.WaldstrHorstweg,
                    Stops.KunersdorferStr,
                    Stops.Sporthalle,
                    Stops.Friedhöfe,
                    Stops.SHauptbahnhof,
                    Stops.LangeBrücke,
                    Stops.AlterMarktLandtag,
                    Stops.PlatzDerEinheitWest,
                    Stops.Dortustr,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.Feuerbachstr,
                    Stops.AufDemKiewitt,
                    Stops.BahnhofCharlottenhofGeschwisterSchollStr,
                    Stops.SchlossCharlottenhof,
                    Stops.KastanienalleeZeppelinstr,
                    Stops.ImBogenZeppelinstr,
                    Stops.Luftschiffhafen,
                    Stops.BahnhofPirschheide
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M0, M1, M1, M1, M2, M1, M0, M1, M4, M1, M1, M3, M1, M1, M1, M1, M1, M2, M1, M2, M1, M3]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M0, M1, M1, M1, M2, M1, M0, M1, M4, M1, M1, M3, M1, M1, M2, M1, M1, M2, M1, M2, M1, M3]
                    }
                ],
                CommonStopIndex = 0
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.BahnhofRehbrücke,
                    Stops.AmMoosfenn,
                    Stops.FriedrichWolfStr,
                    Stops.ZumKahleberg,
                    Stops.EduardClaudiusStrHeinrichMannAllee,
                    Stops.MagnusZellerPlatz,
                    Stops.Bisamkiez,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M0, M1, M1, M1, M3, M2]
                    }
                ],
                CommonStopIndex = 0
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Bisamkiez,
                    Stops.MagnusZellerPlatz,
                    Stops.WaldstrHorstweg,
                    Stops.KunersdorferStr,
                    Stops.Sporthalle,
                    Stops.Friedhöfe,
                    Stops.SHauptbahnhof,
                    Stops.LangeBrücke,
                    Stops.AlterMarktLandtag,
                    Stops.PlatzDerEinheitWest,
                    Stops.Dortustr,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.Feuerbachstr,
                    Stops.AufDemKiewitt,
                    Stops.BahnhofCharlottenhofGeschwisterSchollStr,
                    Stops.SchlossCharlottenhof,
                    Stops.KastanienalleeZeppelinstr,
                    Stops.ImBogenZeppelinstr,
                    Stops.Luftschiffhafen,
                    Stops.BahnhofPirschheide
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M1, M0, M1, M4, M1, M1, M3, M1, M1, M1, M1, M1, M2, M1, M2, M1, M3]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M1, M0, M1, M4, M1, M1, M3, M1, M1, M2, M1, M1, M2, M1, M2, M1, M3]
                    }
                ],
                CommonStopIndex = 0
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Bisamkiez,
                    Stops.MagnusZellerPlatz,
                    Stops.WaldstrHorstweg,
                    Stops.KunersdorferStr,
                    Stops.Sporthalle,
                    Stops.Friedhöfe,
                    Stops.SHauptbahnhof,
                    Stops.LangeBrücke,
                    Stops.AlterMarktLandtag,
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.PlatzDerEinheitNord
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M1, M0, M1, M4, M1, M1, M2, M1]
                    }
                ],
                CommonStopIndex = 0
            },
        ],
        TripsCreate =
        [
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(4, 43)
            }.AlsoEvery(M20, 2),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(8, 8)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(6, 43)
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 12)
            }.AlsoEvery(M20, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 11)
            }.AlsoEvery(M20, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 10)
            }.AlsoEvery(M20, 4),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(8, 31)
            }.AlsoEvery(M20, new TimeOnly(14, 11)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(14, 30)
            }.AlsoEvery(M20, new TimeOnly(16, 10)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(16, 31)
            }.AlsoEvery(M20, new TimeOnly(19, 51)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(19, 58)
            }.AlsoEvery(M20, new TimeOnly(0, 58)),
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(17, 36)
            },
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 28)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 7)
            }.AlsoEvery(M20, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 7)
            }.AlsoEvery(M20, new TimeOnly(19, 47)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 0)
            }.AlsoEvery(M20, new TimeOnly(0, 20)),
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(0, 58)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(4, 29)
            }.AlsoEvery(M20, 2),
            new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 25)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 25)
            }.AlsoEvery(M20, 2),
            new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(7, 52)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 12)
            }.AlsoEvery(M20, new TimeOnly(6, 52)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(7, 12)
            }.AlsoEvery(M20, new TimeOnly(9, 52)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 11)
            }.AlsoEvery(M20, new TimeOnly(19, 51)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(4, 26)
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 7)
            }.AlsoEvery(M20, new TimeOnly(6, 47)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(7, 7)
            }.AlsoEvery(M20, new TimeOnly(10, 7)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 27)
            }.AlsoEvery(M20, new TimeOnly(19, 47)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(6, 26)
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(6, 29)
            }.AlsoEvery(M20, 2),
        ]
    };
}
