using Timetable.Models;

namespace Timetable.Vip.Lines.Tram93;

using static Minutes;

internal class Tram93From20240102 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 1, 2);

    public Line Line { get; } = new()
    {
        Name = "93",
        TransportationType = TransportationType.Tram,
        OverviewRouteIndices = [0, 4],
        MainRouteIndices = [0, 3, 4, 7],
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.GlienickerBrücke,
                    Stops.LeonardoDaVinciStr,
                    Stops.Mangerstr,
                    Stops.SchiffbauergasseBerlinerStr,
                    Stops.Holzmarktstr,
                    Stops.BurgstrKlinikum,
                    Stops.PlatzDerEinheitBildungsforum,
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
                        StopDistances = [M1, M1, M1, M2, M1, M1, M2, M1, M3, M2, M1, M1, M1, M1, M1, M1, M1, M2]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M2, M1, M1, M1, M1, M3, M2, M0, M1, M1, M1, M1, M1, M1, M2]
                    }
                ],
                CommonStopIndex = 11,
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
                    }
                ],
                CommonStopIndex = 2,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.GlienickerBrücke,
                    Stops.LeonardoDaVinciStr,
                    Stops.Mangerstr,
                    Stops.SchiffbauergasseBerlinerStr,
                    Stops.Holzmarktstr,
                    Stops.BurgstrKlinikum,
                    Stops.PlatzDerEinheitBildungsforum,
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
                        StopDistances = [M1, M1, M1, M2, M1, M1, M1, M1, M3, M2, M0, M1, M1, M2, M2]
                    }
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.GlienickerBrücke,
                    Stops.LeonardoDaVinciStr,
                    Stops.Mangerstr,
                    Stops.SchiffbauergasseBerlinerStr,
                    Stops.Holzmarktstr,
                    Stops.BurgstrKlinikum,
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.AlterMarktLandtag,
                    Stops.LangeBrücke,
                    Stops.SHauptbahnhofFriedrichEngelsStr
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M2, M1, M1, M1, M1, M4]
                    }
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions = [
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
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.BurgstrKlinikum,
                    Stops.Holzmarktstr,
                    Stops.SchiffbauergasseBerlinerStr,
                    Stops.Mangerstr,
                    Stops.LeonardoDaVinciStr,
                    Stops.GlienickerBrücke
                ],
                TimeProfiles = [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M0, M1, M1, M1, M2, M1, M0, M1, M4, M1, M1, M2, M1, M2, M1, M1, M1, M2]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M0, M1, M1, M1, M1, M1, M1, M1, M4, M1, M1, M2, M1, M1, M1, M1, M0, M2]
                    },
                ],
                CommonStopIndex = 17,
            },
            new Line.Route
            {
                StopPositions = [
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
                    Stops.BurgstrKlinikum,
                    Stops.Holzmarktstr,
                    Stops.SchiffbauergasseBerlinerStr,
                    Stops.Mangerstr,
                    Stops.LeonardoDaVinciStr,
                    Stops.GlienickerBrücke
                ],
                TimeProfiles = [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M1, M0, M1, M4, M1, M1, M2, M1, M2, M1, M1, M1, M2]
                    }
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions = [
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
                TimeProfiles = [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M1, M0, M1, M4, M1, M1, M2, M1]
                    }
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions = [
                    Stops.SHauptbahnhof,
                    Stops.LangeBrücke,
                    Stops.AlterMarktLandtag,
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.BurgstrKlinikum,
                    Stops.Holzmarktstr,
                    Stops.SchiffbauergasseBerlinerStr,
                    Stops.Mangerstr,
                    Stops.LeonardoDaVinciStr,
                    Stops.GlienickerBrücke
                ],
                TimeProfiles = [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M2, M1, M2, M1, M1, M1, M2]
                    }
                ],
                CommonStopIndex = 0,
            },
        ],
        TripsCreate = [
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 26),
            }.AlsoEvery(M20, new TimeOnly(19, 46)),
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(7, 59),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(8, 6),
            }.AlsoEvery(M20, new TimeOnly(19, 46)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(10, 6),
            }.AlsoEvery(M20, new TimeOnly(19, 46)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 8),
            }.AlsoEvery(M20, 3),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 13),
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 58),
            },
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(21, 0),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 26),
            }.AlsoEvery(M20, new TimeOnly(7, 46)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(7, 6),
            }.AlsoEvery(M20, new TimeOnly(9, 46)),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 37),
            }.AlsoEvery(M20, new TimeOnly(19, 37)),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(8, 57),
            }.AlsoEvery(M20, new TimeOnly(19, 37)),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(10, 57),
            }.AlsoEvery(M20, new TimeOnly(19, 37)),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(19, 54),
            }.AlsoEvery(M20, 3),
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(7, 22),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 59),
            }.AlsoEvery(M20, 2),
            new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(4, 59),
            },
            new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(8, 39),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(6, 39),
            }.AlsoEvery(M20, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(10, 19),
            }.AlsoEvery(M20, 2),
            new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 56),
            },
            new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 41),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 28),
            }.AlsoEvery(M20, new TimeOnly(8, 28)),
            ..new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(7, 48),
            }.AlsoEvery(M20, new TimeOnly(10, 8)),
        ]
    };
}
