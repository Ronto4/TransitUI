using Timetables.Models;

namespace Timetables.Vip.Lines.Tram99;

using static Minutes;

public class Tram99From20240816 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 8, 16);

    public Line Line { get; } = new()
    {
        Name = "99",
        TransportationType = TransportationType.Tram,
        OverviewRouteIndices = [0, 3],
        MainRouteIndices = [0, 3],
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Fontanestr,
                    Stops.Plantagenstr,
                    Stops.Anhaltstr,
                    Stops.SBabelsbergWattstr,
                    Stops.RathausBabelsberg,
                    Stops.AltNowawes,
                    Stops.HumboldtringNuthestr,
                    Stops.SchiffbauergasseUferweg,
                    Stops.Holzmarktstr,
                    Stops.BurgstrKlinikum,
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.AlterMarktLandtag,
                    Stops.LangeBrücke,
                    Stops.SHauptbahnhofFriedrichEngelsStr
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M1, M1, M2, M1, M1, M1, M1, M2, M1, M4] },
                    new Line.Route.TimeProfile { StopDistances = [M1, M0, M1, M1, M1, M2, M1, M1, M1, M1, M1, M1, M4] }
                ],
                CommonStopIndex = 0
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Fontanestr,
                    Stops.Plantagenstr,
                    Stops.Anhaltstr,
                    Stops.SBabelsbergWattstr,
                    Stops.RathausBabelsberg,
                    Stops.AltNowawes,
                    Stops.HumboldtringNuthestr,
                    Stops.SchiffbauergasseUferweg,
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
                        StopDistances = [M1, M1, M1, M1, M1, M2, M1, M1, M1, M1, M2, M1, M3, M2, M1, M1, M1, M1, M2]
                    },
                    new Line.Route.TimeProfile
                        { StopDistances = [M1, M0, M1, M1, M1, M2, M1, M1, M1, M1, M1, M1, M3, M2, M0, M1, M1, M2, M2] }
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
                    Stops.SchiffbauergasseUferweg,
                    Stops.HumboldtringNuthestr,
                    Stops.AltNowawes,
                    Stops.RathausBabelsberg,
                    Stops.SBabelsbergWattstr,
                    Stops.Anhaltstr,
                    Stops.Plantagenstr,
                    Stops.Fontanestr,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M1, M0, M1, M4, M1, M1, M2, M1, M2, M1, M1, M1, M2, M1, M1, M1, M1]
                    },
                    new Line.Route.TimeProfile
                        { StopDistances = [M1, M2, M1, M1, M1, M4, M1, M1, M2, M1, M1, M1, M1, M1, M2, M1, M1, M0, M1] }
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
                Stops.SchiffbauergasseUferweg,
                Stops.HumboldtringNuthestr,
                Stops.AltNowawes,
                Stops.RathausBabelsberg,
                Stops.SBabelsbergWattstr,
                Stops.Anhaltstr,
                Stops.Plantagenstr,
                Stops.Fontanestr,
                ],
                TimeProfiles = [new Line.Route.TimeProfile{StopDistances = [M1, M1, M2, M1, M2, M1, M1, M1, M2, M1, M1, M1, M1]},
                new Line.Route.TimeProfile{StopDistances = [M1, M1, M2, M1, M1, M1, M1, M1, M2, M1, M1, M0, M1]}],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions = [
                    Stops.PlatzDerEinheitNord,
                    Stops.PlatzDerEinheitWest,
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.BurgstrKlinikum,
                    Stops.Holzmarktstr,
                    Stops.SchiffbauergasseUferweg,
                    Stops.HumboldtringNuthestr,
                    Stops.AltNowawes,
                    Stops.RathausBabelsberg,
                    Stops.SBabelsbergWattstr,
                    Stops.Anhaltstr,
                    Stops.Plantagenstr,
                    Stops.Fontanestr,
                ],
                TimeProfiles = [new Line.Route.TimeProfile{StopDistances = [M1, M1, M1, M1, M1, M1, M1, M2, M1, M1, M0, M1]}],
                CommonStopIndex = 1,
            }
        ],
        TripsCreate =
        [
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(6, 53)
            }.AlsoEvery(M20, new TimeOnly(18, 53)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(19, 36)
            }.AlsoEvery(M20, new TimeOnly(23, 56)),
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(0, 16)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(19, 36)
            }.AlsoEvery(M20, new TimeOnly(20, 36)),
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(20, 56)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(21, 16)
            }.AlsoEvery(M20, new TimeOnly(22, 56)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(23, 16)
            }.AlsoEvery(M20, new TimeOnly(23, 56)),
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(0, 16)
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(19, 13)
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(20, 6)
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(20, 56)
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(23, 26)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(0, 36)
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(23, 16)
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(4, 25)
            }.AlsoEvery(M20, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(6, 15)
            }.AlsoEvery(M20, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(6, 25)
            }.AlsoEvery(M20, 3),
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(21, 4)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(7, 24)
            }.AlsoEvery(M20, new TimeOnly(19, 24)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(19, 54)
            }.AlsoEvery(M20, new TimeOnly(23, 54)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(0, 14)
            }.AlsoEvery(M20, new TimeOnly(0, 34)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(19, 54)
            }.AlsoEvery(M20, new TimeOnly(20, 54)),
            new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Sunday,
                    StartTime = new TimeOnly(21, 14)
                },
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(21, 34)
            }.AlsoEvery(M20, new TimeOnly(23, 14)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(23, 34)
            }.AlsoEvery(M20, new TimeOnly(23, 54)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(0, 14)
            }.AlsoEvery(M20, new TimeOnly(0, 34)),
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(19, 59),
            }
        ],
    };
}
