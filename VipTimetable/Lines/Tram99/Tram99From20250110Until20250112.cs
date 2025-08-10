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
                            var weekendStartTime = trip.StartTime.AddMinutes(-6);
                            var tram92Departure =
                                weekendStartTime == new TimeOnly(20, 10) || weekendStartTime == new TimeOnly(20, 30)
                                    ? weekendStartTime.AddMinutes(15)
                                    : weekendStartTime.AddMinutes(12);
                            var connectionId = 9992 * 10000 + tram92Departure.Hour * 100 + tram92Departure.Minute;
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
                                    StartTime = weekendStartTime,
                                    ConnectionId = connectionId,
                                    Connections =
                                    [
                                        new Line.TripCreate.Connection
                                        {
                                            ConnectingLineIdentifier = "tram92",
                                            ConnectingRouteIndex = 12,
                                            Delay = tram92Departure - weekendStartTime - TimeSpan.FromMinutes(12),
                                            Type = Line.Trip.ConnectionType.ContinuesAs,
                                            ConnectingId = connectionId,
                                        },
                                    ],
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
                        var newDays = trip.StartTime == new TimeOnly(23, 16) || trip.StartTime == new TimeOnly(23, 36)
                            ? trip.DaysOfOperation.HasFlag(DaysOfOperation.Sunday)
                                ? DaysOfOperation.None
                                : DaysOfOperation.Daily
                            : trip.DaysOfOperation;
                        var startTime = trip.StartTime.AddMinutes(-6);
                        var tram92Departure = startTime.AddMinutes(12);
                        var connectionId = 9992 * 10000 + tram92Departure.Hour * 100 + tram92Departure.Minute;
                        returnTrips =
                        [
                            trip with
                            {
                                RouteIndex = Original.Line.Routes.Length,
                                TimeProfileIndex = 0,
                                StartTime = startTime,
                                DaysOfOperation = newDays,
                                ConnectionId = connectionId,
                                Connections =
                                [
                                    new Line.TripCreate.Connection
                                    {
                                        ConnectingLineIdentifier = "tram92",
                                        ConnectingRouteIndex = 12,
                                        Delay = M0,
                                        Type = Line.Trip.ConnectionType.ContinuesAs,
                                        ConnectingId = connectionId,
                                    },
                                ],
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
            }).Where(trip => trip.DaysOfOperation != DaysOfOperation.None),
            new Line.TripCreate
            {
                RouteIndex = Original.Line.Routes.Length,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(19, 35),
                ConnectionId = 9992 * 10000 + 19 /* hour of 92 departure */ * 100 + 51 /* minute of 92 departure */,
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "tram92",
                        ConnectingRouteIndex = 12,
                        Delay = M4,
                        Type = Line.Trip.ConnectionType.ContinuesAs,
                        ConnectingId =
                            9992 * 10000 + 19 /* hour of 92 departure */ * 100 + 51 /* minute of 92 departure */,
                    },
                ],
            },
            new Line.TripCreate
            {
                RouteIndex = Original.Line.Routes.Length,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(19, 53),
                ConnectionId = 9992 * 10000 + 20 /* hour of 92 departure */ * 100 + 5 /* minute of 92 departure */,
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "tram92",
                        ConnectingRouteIndex = 12,
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ContinuesAs,
                        ConnectingId =
                            9992 * 10000 + 20 /* hour of 92 departure */ * 100 + 5 /* minute of 92 departure */,
                    },
                ],
            },
            new Line.TripCreate
            {
                RouteIndex = Original.Line.Routes.Length,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(21, 30),
                ConnectionId = 9992 * 10000 + 21 /* hour of 92 departure */ * 100 + 42 /* minute of 92 departure */,
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "tram92",
                        ConnectingRouteIndex = 12,
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ContinuesAs,
                        ConnectingId =
                            9992 * 10000 + 21 /* hour of 92 departure */ * 100 + 42 /* minute of 92 departure */,
                    },
                ],
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
