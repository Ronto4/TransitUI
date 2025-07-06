using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Tram99;

public class Tram99From20250110Until20250112 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 1, 10);
    public DateOnly? ValidUntilInclusive() => new(2025, 1, 12);
    private static Tram99From20241215 Original { get; } = new();

    public Line Line { get; } = Original.Line with
    {
        Annotations = new Dictionary<string, string>
        {
            { "A", "weiter als 92 nach Kirschallee" },
        },
        MainRouteIndices =
        [..Original.Line.MainRouteIndices, Original.Line.Routes.Length, Original.Line.Routes.Length + 1],
        Routes =
        [
            Original.Line.Routes[0] with
            {
                TimeProfiles =
                [
                    ..Original.Line.Routes[0].TimeProfiles,
                    new Line.Route.TimeProfile { StopDistances = [M1, M0, M1, M1, M1, M2, M1, M1, M1, M2,], },
                ],
            },
            ..Original.Line.Routes[1..3],
            Original.Line.Routes[3] with
            {
                TimeProfiles =
                [
                    ..Original.Line.Routes[3].TimeProfiles,
                    new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M1, M1, M1, M1, M2, M1, M1, M0, M1,], },
                ],
            },
            ..Original.Line.Routes[4..],
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
                    Stops.PlatzDerEinheitWest,
                ],
                TimeProfiles =
                    [new Line.Route.TimeProfile { StopDistances = [M1, M0, M1, M1, M1, M2, M1, M1, M1, M1, M2,], },],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
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
                TimeProfiles =
                    [new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M1, M1, M1, M2, M1, M1, M0, M1,], },],
                CommonStopIndex = 0,
            },
        ],
        TripsCreate =
        [
            ..Original.Line.TripsCreate.SelectMany(trip =>
            {
                List<Line.TripCreate>? returnTrips = null;
                if ((trip.RouteIndex.Equals(1) || trip.RouteIndex.Equals(2)) &&
                    (trip.StartTime > new TimeOnly(19, 30) || trip.StartTime < new TimeOnly(2, 0)))
                {
                    if (trip.StartTime == new TimeOnly(21, 26))
                    {
                        returnTrips =
                        [
                            trip with
                            {
                                StartTime = trip.StartTime.AddMinutes(10),
                                DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekday,
                            },
                        ];
                    }
                    else if (trip.StartTime == new TimeOnly(21, 36))
                    {
                        returnTrips = [];
                    }
                    else if (trip.StartTime < new TimeOnly(21, 50) && trip.StartTime > new TimeOnly(2, 0))
                    {
                        if (trip.StartTime < new TimeOnly(20, 10))
                        {
                            returnTrips =
                            [
                                trip with
                                {
                                    DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekday,
                                },
                            ];
                        }
                        else
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
                                    AnnotationSymbols = ["A"],
                                    StartTime = trip.StartTime.AddMinutes(-6),
                                },
                            ];
                        }
                    }
                    else if (trip.StartTime == new TimeOnly(0, 56))
                    {
                        returnTrips =
                        [
                            trip with
                            {
                                RouteIndex = 0,
                                TimeProfileIndex = 1,
                                StartTime = trip.StartTime.AddMinutes(-6),
                            }
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
                                AnnotationSymbols = ["A"],
                                StartTime = trip.StartTime.AddMinutes(-6),
                            },
                        ];
                    }
                }
                else if (trip.RouteIndex.Equals(4) &&
                         (trip.StartTime > new TimeOnly(19, 30) || trip.StartTime < new TimeOnly(2, 0)))
                {
                    if (trip.StartTime == new TimeOnly(20, 24))
                    {
                        returnTrips = [];
                    }
                    else if (trip.StartTime < new TimeOnly(21, 54) && trip.StartTime > new TimeOnly(2, 0))
                    {
                        returnTrips =
                        [
                            trip with
                            {
                                DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekday,
                            },
                            trip with
                            {
                                DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekend,
                                RouteIndex = Original.Line.Routes.Length + 1,
                                StartTime = trip.StartTime.AddMinutes(11),
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
                                StartTime = trip.StartTime.AddMinutes(11),
                            },
                        ];
                    }
                }

                return returnTrips ?? [trip];
            }).Where(trip => trip.DaysOfOperation != DaysOfOperation.None).Select(trip =>
            {
                if (trip.RouteIndex.Equals(7) && trip.StartTime.IsBetween(new TimeOnly(20, 0), new TimeOnly(2, 0)))
                {
                    return trip with
                    {
                        Connections =
                        [
                            new Line.TripCreate.Connection
                            {
                                Delay = trip.StartTime switch
                                {
                                    _ when trip.StartTime == new TimeOnly(20, 5) => M0,
                                    _ when trip.StartTime == new TimeOnly(20, 25) => M5,
                                    _ => M2,
                                },
                                Type = Line.Trip.ConnectionType.ComesAs,
                                ConnectingLineIdentifier = "tram92",
                                ConnectingRouteIndex = 11,
                            }
                        ],
                    };
                }

                return trip;
            }),
            ..new Line.TripCreate
            {
                RouteIndex = Original.Line.Routes.Length,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(19, 35),
                AnnotationSymbols = ["A"],
            }.AlsoEvery(TimeSpan.FromMinutes(18), 2),
            new Line.TripCreate
            {
                RouteIndex = Original.Line.Routes.Length,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(21, 30),
                AnnotationSymbols = ["A"],
            },
            new Line.TripCreate
            {
                RouteIndex = Original.Line.Routes.Length + 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(19, 44),
            },
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(19, 44),
            },
        ],
    };
}
