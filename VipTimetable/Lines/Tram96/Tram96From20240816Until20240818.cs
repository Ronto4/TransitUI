using Timetable;

namespace VipTimetable.Lines.Tram96;

using static Minutes;

public class Tram96From20240816Until20240818 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 8, 16);

    public DateOnly? ValidUntilInclusive() => new DateOnly(2024, 8, 18);

    public Line Line { get; } = new()
    {
        Name = "96",
        TransportationType = TransportationType.Tram,
        MainRouteIndices = [1, 2],
        OverviewRouteIndices = [1, 2],
        Routes =
        [
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
                    Stops.MarieJuchaczStr
                ],
                TimeProfiles = [new Line.Route.TimeProfile { StopDistances = [M1, M2, M1, M1, M1, M1, M1, M1, M2] }],
                CommonStopIndex = 0,
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
                    Stops.MarieJuchaczStr
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M3, M2, M1, M1, M1, M1, M2, M2, M1, M2, M1, M1, M1, M1, M1, M1, M2]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M3, M2, M1, M1, M1, M1, M2, M2, M1, M2, M1, M2, M1, M1, M1, M1, M2]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M4, M2, M0, M1, M1, M2, M2, M1, M1, M2, M1, M1, M1, M1, M1, M1, M2]
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
                    Stops.PlatzDerEinheitNord
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M0, M1, M1, M1, M2, M1, M2, M0, M2, M2, M1, M2, M1, M0, M1, M4, M1, M1, M2, M1]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M0, M1, M1, M1, M2, M1, M1, M0, M2, M2, M1, M2, M1, M1, M1, M5, M1, M1, M2, M1]
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
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.PlatzDerEinheitNord
                ],
                TimeProfiles =
                    [new Line.Route.TimeProfile { StopDistances = [M1, M2, M1, M0, M1, M4, M1, M1, M2, M1] }],
                CommonStopIndex = 0,
            }
        ],
        TripsCreate =
        [
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(3, 43)
            }.AlsoEvery(M20, new TimeOnly(5, 43)),
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(4, 53)
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(5, 48)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(3, 52)
            }.AlsoEvery(M20, new TimeOnly(4, 32)),
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(5, 52)
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(8, 22)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(4, 57)
            }.AlsoEvery(M20, new TimeOnly(5, 17)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(5, 37)
            }.AlsoEvery(M10, new TimeOnly(6, 7)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(6, 17)
            }.AlsoEvery(M10, new TimeOnly(19, 57)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(20, 8)
            }.AlsoEvery(M10, new TimeOnly(20, 48)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Holiday | DaysOfOperation.Weekend,
                StartTime = new TimeOnly(21, 8)
            }.AlsoEvery(M20, new TimeOnly(23, 48)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Holiday | DaysOfOperation.Weekend,
                StartTime = new TimeOnly(0, 8)
            }.AlsoEvery(M20, new TimeOnly(1, 8)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(4, 36)
            }.AlsoEvery(M20, new TimeOnly(5, 36)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(5, 56)
            }.AlsoEvery(M20, new TimeOnly(9, 56)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 16)
            }.AlsoEvery(M20, new TimeOnly(19, 56)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(20, 8)
            }.AlsoEvery(M20, new TimeOnly(20, 48)),
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(4, 1)
            },
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(4, 18)
            },
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(4, 41)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(5, 1)
            }.AlsoEvery(M10, new TimeOnly(19, 21)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(19, 29)
            }.AlsoEvery(M10, new TimeOnly(20, 29)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday | DaysOfOperation.Weekend,
                StartTime = new TimeOnly(20, 49)
            }.AlsoEvery(M20, new TimeOnly(23, 49)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday | DaysOfOperation.Weekend,
                StartTime = new TimeOnly(0, 9)
            }.AlsoEvery(M20, new TimeOnly(0, 29)),
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(4, 18)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(4, 41)
            }.AlsoEvery(M20, new TimeOnly(6, 1)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(6, 21)
            }.AlsoEvery(M20, new TimeOnly(19, 21)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(19, 29)
            }.AlsoEvery(M20, new TimeOnly(20, 29)),
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(4, 13)
            },
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(5, 20)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(5, 53)
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(8, 3)
            }.AlsoEvery(M20, new TimeOnly(8, 43)),
        ],
    };
}
