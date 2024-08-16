using Timetables.Models;

namespace Timetables.Vip.Lines.Tram92;

using static Minutes;

public class Tram92From20240610 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 6, 10);

    public Line Line { get; } = new()
    {
        Name = "92",
        TransportationType = TransportationType.Tram,
        MainRouteIndices = [0, 1, 3, 4, 5, 6, 7, 8],
        OverviewRouteIndices = [3, 8],
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Kirschallee,
                    Stops.JohanBoumanPlatz,
                    Stops.HannesMeyerStr,
                    Stops.Wiesenpark,
                    Stops.CampusFachhochschule,
                    Stops.AmSchragen,
                    Stops.Puschkinallee,
                    Stops.Rathaus,
                    Stops.NauenerTor,
                    Stops.BrandenburgerStr,
                    Stops.PlatzDerEinheitWest,
                    Stops.AlterMarktLandtag,
                    Stops.LangeBrücke,
                    Stops.SHauptbahnhofFriedrichEngelsStr
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M0, M2, M1, M1, M3, M1, M2, M2, M1, M1, M4
                        ]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M0, M1, M1, M1, M1, M2, M1, M3, M2, M1, M1, M4
                        ]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M2, M1, M1, M3, M1, M2, M2, M1, M1, M4
                        ]
                    }
                ],
                CommonStopIndex = 3,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Kirschallee,
                    Stops.JohanBoumanPlatz,
                    Stops.HannesMeyerStr,
                    Stops.Wiesenpark,
                    Stops.CampusFachhochschule,
                    Stops.AmSchragen,
                    Stops.Puschkinallee,
                    Stops.Rathaus,
                    Stops.NauenerTor,
                    Stops.BrandenburgerStr,
                    Stops.PlatzDerEinheitWest,
                    Stops.AlterMarktLandtag,
                    Stops.LangeBrücke,
                    Stops.SHauptbahnhof,
                    Stops.Friedhöfe,
                    Stops.Sporthalle,
                    Stops.KunersdorferStr,
                    Stops.WaldstrHorstweg,
                    Stops.MagnusZellerPlatz,
                    Stops.Bisamkiez,
                    Stops.AbzweigBetriebshofViP,
                    Stops.Turmstr,
                    Stops.JohannesKeplerPlatz,
                    Stops.MaxBornStr,
                    Stops.Gaußstr
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M0, M2, M1, M1, M3, M1, M2, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2, M2, M1, M2, M1,
                            M2
                        ]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M2, M1, M1, M3, M1, M2, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2, M2, M1, M2, M1,
                            M2
                        ]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M0, M2, M1, M1, M3, M1, M2, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2, M2, M1, M2, M1,
                            M1
                        ]
                    }
                ],
                CommonStopIndex = 9 /* Used to adjust frequency table. Required: 3 */,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.AbzweigBetriebshofViP,
                    Stops.Turmstr,
                    Stops.JohannesKeplerPlatz,
                    Stops.MaxBornStr,
                    Stops.Gaußstr
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M1, M2]
                    }
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Kirschallee,
                    Stops.JohanBoumanPlatz,
                    Stops.HannesMeyerStr,
                    Stops.Wiesenpark,
                    Stops.CampusFachhochschule,
                    Stops.AmSchragen,
                    Stops.Puschkinallee,
                    Stops.Rathaus,
                    Stops.NauenerTor,
                    Stops.BrandenburgerStr,
                    Stops.PlatzDerEinheitWest,
                    Stops.AlterMarktLandtag,
                    Stops.LangeBrücke,
                    Stops.SHauptbahnhof,
                    Stops.Friedhöfe,
                    Stops.Sporthalle,
                    Stops.KunersdorferStr,
                    Stops.WaldstrHorstweg,
                    Stops.MagnusZellerPlatz,
                    Stops.Bisamkiez,
                    Stops.AbzweigBetriebshofViP,
                    Stops.Turmstr,
                    Stops.JohannesKeplerPlatz,
                    Stops.MaxBornStr,
                    Stops.Gaußstr,
                    Stops.HansAlbersStr,
                    Stops.RobertBaberskeStr,
                    Stops.Priesterweg,
                    Stops.AmHirtengraben,
                    Stops.MarieJuchaczStr
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M2, M1, M1, M3, M1, M2, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2, M2, M1, M2, M1,
                            M2, M1, M1, M1, M1, M2
                        ]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M0, M2, M1, M1, M3, M1, M2, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2, M2, M1, M2, M1,
                            M1, M1, M1, M1, M1, M2
                        ]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M0, M2, M1, M1, M3, M1, M2, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2, M2, M1, M2, M1,
                            M2, M1, M1, M1, M1, M2
                        ]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M0, M1, M1, M1, M1, M2, M1, M3, M2, M1, M1, M3, M2, M0, M1, M1, M2, M2, M1, M1, M2, M1,
                            M1, M1, M1, M1, M1, M2
                        ]
                    },
                ],
                CommonStopIndex = 3,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Kirschallee,
                    Stops.JohanBoumanPlatz,
                    Stops.HannesMeyerStr,
                    Stops.Wiesenpark,
                    Stops.CampusFachhochschule,
                    Stops.AmSchragen,
                    Stops.Puschkinallee,
                    Stops.Rathaus,
                    Stops.NauenerTor,
                    Stops.BrandenburgerStr,
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
                        StopDistances =
                        [
                            M1, M1, M1, M2, M1, M1, M3, M1, M2, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2
                        ]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M0, M2, M1, M1, M3, M1, M2, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2
                        ]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M0, M1, M1, M1, M1, M2, M1, M3, M2, M1, M1, M3, M2, M0, M1, M1, M2, M2
                        ]
                    }
                ],
                CommonStopIndex = 3,
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
                    Stops.PlatzDerEinheitWest,
                    Stops.BrandenburgerStr,
                    Stops.NauenerTor,
                    Stops.Rathaus,
                    Stops.Puschkinallee,
                    Stops.AmSchragen,
                    Stops.CampusFachhochschule,
                    Stops.Wiesenpark,
                    Stops.HannesMeyerStr,
                    Stops.JohanBoumanPlatz,
                    Stops.Kirschallee
                ],
                TimeProfiles = [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M1, M0, M1, M4, M1, M1, M3, M1, M1, M1, M3, M3, M1, M0, M2, M1, M1]
                    }
                ],
                CommonStopIndex = 3,
            },
            new Line.Route
            {
                StopPositions = [
                    Stops.SHauptbahnhof,
                    Stops.LangeBrücke,
                    Stops.AlterMarktLandtag,
                    Stops.PlatzDerEinheitWest,
                    Stops.BrandenburgerStr,
                    Stops.NauenerTor,
                    Stops.Rathaus,
                    Stops.Puschkinallee,
                    Stops.AmSchragen,
                    Stops.CampusFachhochschule,
                    Stops.Wiesenpark,
                    Stops.HannesMeyerStr,
                    Stops.JohanBoumanPlatz,
                    Stops.Kirschallee,
                ],
                TimeProfiles = [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M3, M1, M1, M1, M3, M3, M1, M0, M2, M1, M1]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M3, M1, M1, M1, M2, M3, M1, M0, M2, M1, M1]
                    }
                ],
                CommonStopIndex = 7,
            },
            new Line.Route
            {
                StopPositions = [
                    Stops.Gaußstr,
                    Stops.MaxBornStr,
                    Stops.JohannesKeplerPlatz,
                    Stops.Turmstr,
                    Stops.AbzweigBetriebshofViP,
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
                    Stops.BrandenburgerStr,
                    Stops.NauenerTor,
                    Stops.Rathaus,
                    Stops.Puschkinallee,
                    Stops.AmSchragen,
                    Stops.CampusFachhochschule,
                    Stops.Wiesenpark,
                    Stops.HannesMeyerStr,
                    Stops.JohanBoumanPlatz,
                    Stops.Kirschallee
                ],
                TimeProfiles = [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M0, M2, M2, M1, M2, M1, M0, M1, M4, M1, M1, M3, M1, M1, M1, M3, M3, M1, M0, M2, M1, M1]
                    }
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions = [
                    Stops.MarieJuchaczStr,
                    Stops.AmHirtengraben,
                    Stops.Priesterweg,
                    Stops.RobertBaberskeStr,
                    Stops.HansAlbersStr,
                    Stops.Gaußstr,
                    Stops.MaxBornStr,
                    Stops.JohannesKeplerPlatz,
                    Stops.Turmstr,
                    Stops.AbzweigBetriebshofViP,
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
                    Stops.BrandenburgerStr,
                    Stops.NauenerTor,
                    Stops.Rathaus,
                    Stops.Puschkinallee,
                    Stops.AmSchragen,
                    Stops.CampusFachhochschule,
                    Stops.Wiesenpark,
                    Stops.HannesMeyerStr,
                    Stops.JohanBoumanPlatz,
                    Stops.Kirschallee
                ],
                TimeProfiles = [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M0, M1, M1, M1, M2, M1, M2, M0, M2, M2, M1, M2, M1, M0, M1, M4, M1, M1, M3, M1, M1, M1, M3, M3, M1, M0, M2, M1, M1]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M0, M1, M1, M1, M2, M1, M1, M0, M2, M2, M1, M2, M1, M1, M1, M4, M1, M1, M3, M1, M1, M1, M2, M3, M1, M0, M2, M1, M1]
                    }
                ],
                CommonStopIndex = 0
            }
        ],
        TripsCreate =
        [
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(4, 49)
            }.AlsoEvery(M20, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(8, 39)
            }.AlsoEvery(M20, new TimeOnly(12, 39)),
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(18, 19)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(18, 29)
            }.AlsoEvery(M20, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(19, 31)
            }.AlsoEvery(M20, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 31)
            }.AlsoEvery(M20, new TimeOnly(0, 11)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(4, 49)
            }.AlsoEvery(M20, new TimeOnly(6, 49)),
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(6, 39)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(6, 58)
            }.AlsoEvery(M10, new TimeOnly(7, 38)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(7, 58)
            }.AlsoEvery(M20, new TimeOnly(8, 18)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(8, 39)
            }.AlsoEvery(M20, new TimeOnly(14, 19)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(14, 38)
            }.AlsoEvery(M20, new TimeOnly(16, 18)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(16, 39)
            }.AlsoEvery(M20, new TimeOnly(17, 39)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(17, 59)
            }.AlsoEvery(M10, new TimeOnly(18, 49)),
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(19, 9)
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(19, 21)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(4, 54)
            }.AlsoEvery(M20, new TimeOnly(6, 54)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(7, 14)
            }.AlsoEvery(M20, new TimeOnly(7, 54)),
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(19, 51)
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(5, 49)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 9)
            }.AlsoEvery(M20, new TimeOnly(6, 49)),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 39)
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 58)
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(7, 28)
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(7, 48)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(12, 49)
            }.AlsoEvery(M20, new TimeOnly(14, 9)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(14, 28)
            }.AlsoEvery(M20, new TimeOnly(16, 8)),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(14, 38)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(16, 29)
            }.AlsoEvery(M20, new TimeOnly(16, 49)),
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 48)
            },
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(12, 58)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(7, 8)
            }.AlsoEvery(M60, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(8, 14)
            }.AlsoEvery(M20, new TimeOnly(9, 54)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 14)
            }.AlsoEvery(M20, new TimeOnly(19, 34)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 3,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(20, 7)
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(7, 18)
            }.AlsoEvery(M20, new TimeOnly(8, 18)),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(8, 29)
            }.AlsoEvery(M20, new TimeOnly(12, 29)),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(12, 59)
            }.AlsoEvery(M20, new TimeOnly(14, 19)),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(14, 58)
            }.AlsoEvery(M20, new TimeOnly(16, 18)),
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(16, 39)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(16, 59)
            }.AlsoEvery(M10, new TimeOnly(17, 49)),
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(18, 0)
            },
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(18, 9)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(18, 39)
            }.AlsoEvery(M20, 2),
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(19, 21)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(0, 31)
            }.AlsoEvery(M20, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(7, 48)
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(8, 29)
            }.AlsoEvery(M20, new TimeOnly(14, 9)),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(14, 28)
            }.AlsoEvery(M20, new TimeOnly(16, 8)),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(16, 29)
            }.AlsoEvery(M20, new TimeOnly(17, 49)),
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(18, 59)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 6)
            }.AlsoEvery(M20, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(5, 56)
            }.AlsoEvery(M10, new TimeOnly(6, 36)),
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(7, 56)
            }.AlsoEvery(M20, new TimeOnly(8, 36)),
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(9, 6)
            }.AlsoEvery(M20, new TimeOnly(13, 6)),
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(13, 16)
            }.AlsoEvery(M20, new TimeOnly(14, 56)),
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(15, 36)
            }.AlsoEvery(M20, new TimeOnly(17, 36)),
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(17, 56)
            }.AlsoEvery(M10, new TimeOnly(18, 26)),
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(5, 56)
            }.AlsoEvery(M20, new TimeOnly(6, 36)),
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(8, 6)
            }.AlsoEvery(M20, new TimeOnly(18, 6)),
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(4, 21)
            }.AlsoEvery(M20, new TimeOnly(5, 21)),
            new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 26)
            },
            new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(8, 21)
            },
            new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(8, 41)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(6, 41)
            }.AlsoEvery(M20, 2),
            new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(7, 26)
            },
            new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(19, 35)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 15)
            }.AlsoEvery(M20, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(9, 5)
            }.AlsoEvery(M20, new TimeOnly(13,5)),
            new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(18, 45)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(18, 55)
            }.AlsoEvery(M20, new TimeOnly(19,55)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(20, 17)
            }.AlsoEvery(M20, new TimeOnly(20,37)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 57)
            }.AlsoEvery(M20, new TimeOnly(0,37)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(6, 15)
            }.AlsoEvery(M20, new TimeOnly(6,35)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(6, 55)
            }.AlsoEvery(M10, new TimeOnly(8,5)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(8, 25)
            }.AlsoEvery(M20, new TimeOnly(18,5)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(18, 25)
            }.AlsoEvery(M10, new TimeOnly(18,35)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 50)
            }.AlsoEvery(M20, new TimeOnly(7,10)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(7, 30)
            }.AlsoEvery(M20, new TimeOnly(8,10)),
            new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(8, 30)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 39)
            }.AlsoEvery(M10, new TimeOnly(7, 39)),
            ..new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(8, 19)
            }.AlsoEvery(M20, new TimeOnly(8, 39)),
            ..new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(13, 19)
            }.AlsoEvery(M20, new TimeOnly(17, 39)),
            new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(15, 9)
            },
            new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(7, 54)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(8, 49)
            }.AlsoEvery(M20, new TimeOnly(19, 9)),
            ..new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(19, 39)
            }.AlsoEvery(M20, new TimeOnly(20, 19)),
        ],
    };
}
