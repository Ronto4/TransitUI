using Timetables.Models;

namespace Timetables.Vip.Lines.Tram93;

using static Minutes;

public class Tram93From20240826Until20240831 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 8, 26);
    public DateOnly? ValidUntilInclusive() => new(2024, 8, 31);

    public Line Line { get; } = new()
    {
        Name = "93",
        TransportationType = TransportationType.Tram,
        MainRouteIndices = [1, 3, 6, 7],
        OverviewRouteIndices = [1, 6],
        Routes =
        [
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
                    Stops.BahnhofRehbrücke,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M3, M2, M1, M1, M1, M1, M1, M1, M1, M2] }
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
                    Stops.SHauptbahnhof,
                    Stops.Friedhöfe,
                    Stops.Sporthalle,
                    Stops.KunersdorferStr,
                    Stops.WaldstrHorstweg,
                    Stops.EduardClaudiusStrHeinrichMannAllee,
                    Stops.ZumKahleberg,
                    Stops.FriedrichWolfStr,
                    Stops.AmMoosfenn,
                    Stops.BahnhofRehbrücke,
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
                    Stops.Bisamkiez,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M2, M1, M1, M2, M1, M3, M2, M1, M1, M1, M1, M2]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M2, M1, M1, M1, M1, M3, M2, M0, M1, M1, M2, M2]
                    }
                ],
                CommonStopIndex = 11,
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
                    Stops.SHauptbahnhofFriedrichEngelsStr,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M2, M1, M1, M1, M1, M4] },
                    new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M2, M1, M1, M2, M1, M4] }
                ],
                CommonStopIndex = 0,
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
                    Stops.BurgstrKlinikum,
                    Stops.Holzmarktstr,
                    Stops.SchiffbauergasseBerlinerStr,
                    Stops.Mangerstr,
                    Stops.LeonardoDaVinciStr,
                    Stops.GlienickerBrücke
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                        { StopDistances = [M1, M2, M1, M0, M1, M4, M1, M1, M2, M1, M2, M1, M1, M1, M2] }
                ],
                CommonStopIndex = 0,
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
                        { StopDistances = [M1, M2, M1, M0, M1, M4, M1, M1, M2, M1] }
                ],
                CommonStopIndex = 0,
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
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.BurgstrKlinikum,
                    Stops.Holzmarktstr,
                    Stops.SchiffbauergasseBerlinerStr,
                    Stops.Mangerstr,
                    Stops.LeonardoDaVinciStr,
                    Stops.GlienickerBrücke
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                        { StopDistances = [M0, M1, M1, M1, M2, M1, M0, M1, M4, M1, M1, M2, M1, M2, M1, M1, M1, M2] },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M0, M1, M1, M1, M1, M1, M1, M1, M4, M1, M1, M2, M1, M1, M1, M1, M0, M2]
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
                    Stops.GlienickerBrücke,
                ],
                TimeProfiles = [new Line.Route.TimeProfile{StopDistances = [M1, M1, M2, M1, M1, M1, M1, M0, M2]}, new Line.Route.TimeProfile{StopDistances = [M1, M1, M2, M1, M2, M1, M1, M1, M2]}],
                CommonStopIndex = 0,
            },
        ],
        TripsCreate =
        [
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(5, 13),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(5, 26)
            }.AlsoEvery(M20, new TimeOnly(19, 46)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(20, 8)
            }.AlsoEvery(M20, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(19, 38)
            }.AlsoEvery(M20, 2),
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday & ~DaysOfOperation.HolidayFriday,
                StartTime = new TimeOnly(21, 0)
            },
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.HolidayFriday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(21, 0)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.HolidayFriday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(21, 19)
            }.AlsoEvery(M20, new TimeOnly(23, 59)),
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.HolidayFriday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(0, 19)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.HolidayFriday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(0, 39)
            }.AlsoEvery(M20, new TimeOnly(0, 59)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 26)
            }.AlsoEvery(M20, new TimeOnly(7, 46)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(8, 6)
            }.AlsoEvery(M20, new TimeOnly(19, 46)),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(19, 58)
            },
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(19, 38)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(20, 8)
            }.AlsoEvery(M20, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(4, 25)
            }.AlsoEvery(M20, 3),
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(4, 59)
            },
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(5, 19)
            },
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(8, 39)
            },
            new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(4, 56)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(5, 37)
            }.AlsoEvery(M20, new TimeOnly(19, 37)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(19, 54)
            }.AlsoEvery(M20, new TimeOnly(20, 34)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(8, 57)
            }.AlsoEvery(M20, new TimeOnly(19, 37)),
            ..new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 28)
            }.AlsoEvery(M20, new TimeOnly(8, 28)),
            ..new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.HolidayFriday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(20, 54)
            }.AlsoEvery(M20, new TimeOnly(23, 54)),
            ..new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.HolidayFriday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(0, 14)
            }.AlsoEvery(M20, new TimeOnly(0, 34)),
        ],
    };
}
