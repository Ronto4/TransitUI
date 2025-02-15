using Timetable.Models;

namespace VipTimetable.Lines.Tram96;

using static Minutes;

internal class Tram96From20240102 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 1, 2);

    public Line Line { get; } = new()
    {
        Name = "96",
        TransportationType = TransportationType.Tram,
        OverviewRouteIndices = [0, 5],
        MainRouteIndices = [0, 5],
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.CampusJungfernsee,
                    Stops.RoteKaserne,
                    Stops.ErichArendtStr,
                    Stops.Volkspark,
                    Stops.CampusFachhochschule,
                    Stops.AmSchragen,
                    Stops.Puschkinallee,
                    Stops.ReiterwegAlleestr,
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
                    Stops.MarieJuchaczStr,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M2, M1, M1, M2, M1, M1, M1, M1, M1, M1, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2, M2, M1, M2,
                            M1, M1, M1, M1, M1, M1, M2
                        ]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M2, M1, M1, M2, M1, M1, M1, M1, M1, M1, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2, M2, M1, M2,
                            M2, M1, M1, M1, M1, M1, M2
                        ]
                    }
                ],
                CommonStopIndex = 0
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.CampusJungfernsee,
                    Stops.RoteKaserne,
                    Stops.ErichArendtStr,
                    Stops.Volkspark,
                    Stops.CampusFachhochschule,
                    Stops.AmSchragen,
                    Stops.Puschkinallee,
                    Stops.ReiterwegAlleestr,
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
                        StopDistances = [M2, M1, M1, M2, M1, M1, M1, M1, M1, M1, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2]
                    }
                ],
                CommonStopIndex = 0
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.AbzweigBetriebshofViP,
                    Stops.Turmstr,
                    Stops.JohannesKeplerPlatz,
                    Stops.MaxBornStr,
                    Stops.Gaußstr,
                    Stops.HansAlbersStr,
                    Stops.RobertBaberskeStr,
                    Stops.Priesterweg,
                    Stops.AmHirtengraben,
                    Stops.MarieJuchaczStr,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M1, M1, M1, M1, M1, M1, M2]
                    }
                ],
                CommonStopIndex = 0
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
                    Stops.MarieJuchaczStr,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M3, M2, M1, M1, M1, M1, M2, M2, M1, M2, M1, M1, M1, M1, M1, M1, M2]
                    }
                ],
                CommonStopIndex = 4
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
                    Stops.MagnusZellerPlatz,
                    Stops.Bisamkiez,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M3, M2, M0, M1, M1, M1, M2]
                    }
                ],
                CommonStopIndex = 4
            },
            new Line.Route
            {
                StopPositions =
                [
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
                    Stops.ReiterwegAlleestr,
                    Stops.Puschkinallee,
                    Stops.AmSchragen,
                    Stops.CampusFachhochschule,
                    Stops.Volkspark,
                    Stops.ErichArendtStr,
                    Stops.RoteKaserne,
                    Stops.CampusJungfernsee
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M0, M1, M1, M1, M2, M1, M2, M0, M2, M2, M1, M2, M1, M0, M1, M4, M1, M1, M3, M1, M1, M1, M0,
                            M2, M2, M1, M1, M1, M1, M3
                        ]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M0, M1, M1, M1, M2, M1, M2, M0, M2, M2, M1, M2, M1, M0, M1, M4, M1, M1, M3, M1, M1, M1, M0,
                            M2, M2, M1, M1, M1, M1, M4
                        ]
                    }
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
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
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.PlatzDerEinheitNord,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M0, M1, M1, M1, M2, M1, M2, M0, M2, M2, M1, M2, M1, M0, M1, M4, M1, M1, M2, M1
                        ]
                    }
                ],
                CommonStopIndex = 2,
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
                    Stops.PlatzDerEinheitNord,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M2, M1, M0, M1, M4, M1, M1, M2, M1
                        ]
                    }
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
                    Stops.PlatzDerEinheitWest,
                    Stops.BrandenburgerStr,
                    Stops.NauenerTor,
                    Stops.Rathaus,
                    Stops.ReiterwegAlleestr,
                    Stops.Puschkinallee,
                    Stops.AmSchragen,
                    Stops.CampusFachhochschule,
                    Stops.Volkspark,
                    Stops.ErichArendtStr,
                    Stops.RoteKaserne,
                    Stops.CampusJungfernsee
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M2, M1, M0, M1, M4, M1, M1, M3, M1, M1, M1, M0, M2, M2, M1, M1, M1, M1, M3
                        ]
                    }
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
                StartTime = new TimeOnly(4, 43)
            }.AlsoEvery(M20, new TimeOnly(5, 43)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 3)
            }.AlsoEvery(M10, new TimeOnly(19, 43)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(19, 55)
            }.AlsoEvery(M10, new TimeOnly(20, 35)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 55)
            }.AlsoEvery(M20, new TimeOnly(0, 55)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 3)
            }.AlsoEvery(M20, new TimeOnly(6, 23)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(6, 43)
            }.AlsoEvery(M20, new TimeOnly(10, 3)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 23)
            }.AlsoEvery(M20, new TimeOnly(19, 43)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(19, 55)
            }.AlsoEvery(M20, new TimeOnly(20, 35)),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(22, 40)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(3, 42)
            }.AlsoEvery(M20, new TimeOnly(6, 2)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 52)
            }.AlsoEvery(M10, new TimeOnly(5, 2)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(3, 52)
            }.AlsoEvery(M20, new TimeOnly(5, 12)),
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(5, 52)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(6, 32)
            }.AlsoEvery(M20, new TimeOnly(6, 52)),
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 6)
            },
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(5, 56)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(20, 32)
            }.AlsoEvery(M20, new TimeOnly(20, 52)),
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 1)
            }.AlsoEvery(M40, new TimeOnly(4, 41)),
            new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(4, 18)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 1)
            }.AlsoEvery(M10, new TimeOnly(5, 51)),
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 1)
            }.AlsoEvery(M10, new TimeOnly(19, 21)),
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(19, 29)
            }.AlsoEvery(M20, new TimeOnly(20, 9)),
            new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(19, 39)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 29)
            }.AlsoEvery(M20, new TimeOnly(0, 9)),
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(4, 41)
            }.AlsoEvery(M20, new TimeOnly(6, 1)),
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(6, 21)
            }.AlsoEvery(M20, new TimeOnly(10, 1)),
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 21)
            }.AlsoEvery(M20, new TimeOnly(19, 21)),
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(19, 29)
            }.AlsoEvery(M20, new TimeOnly(20, 9)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(19, 59)
            }.AlsoEvery(M20, new TimeOnly(20, 19)),
            new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 46)
            },
            new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(5, 20)
            },
            new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(4, 13)
            },
            new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(5, 53)
            },
            new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(6, 13)
            },
        ],
    };
}
