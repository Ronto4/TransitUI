using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Tram96;

public class Tram96From20250110Until20250112 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 1, 10);
    public DateOnly? ValidUntilInclusive() => new(2025, 1, 12);
    private static Tram96From20241215 Original { get; } = new();

    public Line Line { get; } = Original.Line with
    {
        OverviewRouteIndices =
        [..Original.Line.OverviewRouteIndices, Original.Line.Routes.Length + 3, Original.Line.Routes.Length + 4],
        MainRouteIndices =
        [
            ..Original.Line.MainRouteIndices, Original.Line.Routes.Length, Original.Line.Routes.Length + 1,
            Original.Line.Routes.Length + 2, Original.Line.Routes.Length + 3, Original.Line.Routes.Length + 4
        ],
        Routes =
        [
            ..Original.Line.Routes,
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
                ],
                TimeProfiles =
                    [new Line.Route.TimeProfile { StopDistances = [M2, M1, M1, M1, M1, M1, M1, M1, M1, M2, M2,], },],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.PlatzDerEinheitNord,
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
                    Stops.CampusJungfernsee,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M0, M2, M2, M1, M1, M1, M1, M3,], },
                    new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M0, M2, M2, M1, M1, M1, M1, M4,], },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
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
                    Stops.CampusJungfernsee,
                ],
                TimeProfiles =
                    [new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M0, M2, M2, M1, M1, M1, M1, M3,], },],
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
                        { StopDistances = [M0, M1, M1, M1, M3, M2, M2, M1, M2, M1, M1, M1, M1, M1, M1, M2,], },
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
                    Stops.EduardClaudiusStrHeinrichMannAllee,
                    Stops.ZumKahleberg,
                    Stops.FriedrichWolfStr,
                    Stops.AmMoosfenn,
                    Stops.BahnhofRehbrücke,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                        { StopDistances = [M0, M1, M1, M1, M2, M1, M1, M0, M2, M2, M1, M4, M1, M1, M1, M2,], },
                    new Line.Route.TimeProfile
                        { StopDistances = [M0, M1, M1, M1, M2, M1, M2, M0, M2, M2, M1, M4, M1, M1, M1, M2,], },
                ],
                CommonStopIndex = 0,
            }
        ],
        TripsCreate =
        [
            ..Original.Line.TripsCreate.SelectMany(trip =>
            {
                List<Line.TripCreate>? returnTrips = null;
                if (trip.RouteIndex.Equals(1) && trip.StartTime == new TimeOnly(22, 40))
                {
                    returnTrips = [];
                }
                else if (trip.RouteIndex.Equals(0) &&
                         (trip.StartTime > new TimeOnly(18, 30) || trip.StartTime < new TimeOnly(2, 0)))
                {
                    if (trip.StartTime < new TimeOnly(21, 30) && trip.StartTime > new TimeOnly(2, 0))
                    {
                        returnTrips =
                        [
                            trip with
                            {
                                DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekday,
                            },
                            trip with
                            {
                                RouteIndex = Original.Line.Routes.Length,
                                TimeProfileIndex = 0,
                                DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekend,
                            },
                        ];
                    }
                    else
                    {
                        returnTrips =
                        [
                            trip with
                            {
                                RouteIndex = Original.Line.Routes.Length,
                                TimeProfileIndex = 0,
                            },
                        ];
                    }
                }
                else if (trip.RouteIndex.Equals(5) &&
                         (trip.StartTime > new TimeOnly(18, 30) || trip.StartTime < new TimeOnly(2, 0)))
                {
                    if (trip.StartTime < new TimeOnly(21, 30) && trip.StartTime > new TimeOnly(2, 0))
                    {
                        var cutoffTime = new TimeOnly(19, 25);
                        returnTrips =
                        [
                            trip with
                            {
                                DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekday,
                            },
                            trip with
                            {
                                RouteIndex = trip.StartTime switch
                                {
                                    _ when trip.StartTime < cutoffTime => Original.Line.Routes.Length + 1,
                                    _ when trip.StartTime < new TimeOnly(20, 20) => Original.Line.Routes.Length + 2,
                                    _ => Original.Line.Routes.Length + 1,
                                },
                                TimeProfileIndex = trip.StartTime switch
                                {
                                    _ when trip.StartTime < cutoffTime => 1,
                                    _ => 0,
                                },
                                DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekend,
                                StartTime = trip.StartTime.AddMinutes(trip.StartTime < cutoffTime ? 26 : 27)
                            },
                        ];
                    }
                    else
                    {
                        returnTrips =
                        [
                            trip with
                            {
                                RouteIndex = Original.Line.Routes.Length + 1,
                                TimeProfileIndex = 0,
                                StartTime = trip.StartTime.AddMinutes(27),
                            },
                        ];
                    }
                }

                return returnTrips ?? [trip];
            }).Where(trip => trip.DaysOfOperation != DaysOfOperation.None),
            ..new Line.TripCreate
            {
                RouteIndex = Original.Line.Routes.Length + 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(18, 38),
            }.AlsoEvery(M10, new TimeOnly(19, 38)),
            ..new Line.TripCreate
            {
                RouteIndex = Original.Line.Routes.Length + 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(19, 52),
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = Original.Line.Routes.Length + 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(20, 29),
            }.AlsoEvery(M20, new TimeOnly(21, 49)),
            ..new Line.TripCreate
            {
                RouteIndex = Original.Line.Routes.Length + 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(22, 9),
            }.AlsoEvery(M20, new TimeOnly(1, 29)),
            ..new Line.TripCreate
            {
                RouteIndex = Original.Line.Routes.Length + 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(21, 55),
            }.AlsoEvery(M20, new TimeOnly(23, 55)),
            ..new Line.TripCreate
            {
                RouteIndex = Original.Line.Routes.Length + 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(0, 15),
            }.AlsoEvery(M20, new TimeOnly(1, 15)),
            ..new Line.TripCreate
            {
                RouteIndex = Original.Line.Routes.Length + 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(18, 29),
            }.AlsoEvery(M10, new TimeOnly(19, 29)),
            ..new Line.TripCreate
            {
                RouteIndex = Original.Line.Routes.Length + 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(19, 38),
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = Original.Line.Routes.Length + 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(20, 14),
            }.AlsoEvery(M20, new TimeOnly(23, 54)),
            ..new Line.TripCreate
            {
                RouteIndex = Original.Line.Routes.Length + 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(0, 14),
            }.AlsoEvery(M20, new TimeOnly(1, 14)),
        ],
    };
}
