using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Tram92;

public class Tram92From20250110Until20250112 : ILineInstance
{
    private static Line.TripCreate.Connection ContinuesAs99(TimeSpan delay) => new Line.TripCreate.Connection
    {
        Delay = delay,
        Type = Line.Trip.ConnectionType.ContinuesAs,
        ConnectingLineIdentifier = "tram99",
        ConnectingRouteIndex = 7,
    };

    private static Line.TripCreate.Connection ContinuesAs93(TimeSpan delay) => new Line.TripCreate.Connection
    {
        Delay = delay,
        Type = Line.Trip.ConnectionType.ContinuesAs,
        ConnectingLineIdentifier = "tram93",
        ConnectingRouteIndex = 11,
    };

    public DateOnly ValidFrom { get; } = new(2025, 1, 10);
    public DateOnly? ValidUntilInclusive() => new(2025, 1, 12);
    private static Tram92From20241215 Original { get; } = new();

    public Line Line { get; } = Original.Line with
    {
        MainRouteIndices = [..Original.Line.MainRouteIndices, Original.Line.Routes.Length],
        Routes =
        [
            Original.Line.Routes[0] with
            {
                TimeProfiles =
                [
                    ..Original.Line.Routes[0].TimeProfiles,
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M0, M1, M1, M1, M1, M1, M1, M1, M2, M2, M1, M1, M3, M2, M0, M1, M1, M2, M2, M1, M1, M2,
                            M1, M1, M1, M1, M1, M1, M2,
                        ],
                    },
                ],
            },
            ..Original.Line.Routes[1..],
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
                    Stops.ReiterwegAlleestr,
                    Stops.Rathaus,
                    Stops.NauenerTor,
                    Stops.BrandenburgerStr,
                    Stops.PlatzDerEinheitWest,
                ],
                TimeProfiles =
                    [new Line.Route.TimeProfile { StopDistances = [M1, M0, M1, M1, M1, M1, M1, M1, M1, M2, M2,], },],
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
                    Stops.Wiesenpark,
                    Stops.HannesMeyerStr,
                    Stops.JohanBoumanPlatz,
                    Stops.Kirschallee,
                ],
                TimeProfiles =
                    [new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M0, M2, M2, M1, M0, M2, M1, M1,], },],
                CommonStopIndex = 0,
            },
        ],
        TripsCreate = Original.Line.TripsCreate.SelectMany(trip =>
        {
            List<Line.TripCreate>? returnTrips = null;
            if (trip.StartTime == new TimeOnly(21, 31))
            {
                returnTrips =
                [
                    trip with
                    {
                        RouteIndex = 0 /* Kirschallee -> M.-Juchacz-Str. */,
                        TimeProfileIndex = 4,
                        DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekday,
                    },
                    trip with
                    {
                        RouteIndex = Original.Line.Routes.Length /* Kirschallee -> Pl.d.Einh./W. */,
                        TimeProfileIndex = 0,
                        DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekend,
                        Connections = [ContinuesAs99(M2),],
                    },
                ];
            }
            else if (trip.StartTime == new TimeOnly(20, 28))
            {
                returnTrips = [];
            }
            else if ((trip.RouteIndex.Equals(0) || trip.RouteIndex.Equals(2) || trip.RouteIndex.Equals(3)) &&
                     (trip.StartTime > new TimeOnly(18, 40) || trip.StartTime < new TimeOnly(2, 0)))
            {
                if (trip.StartTime <= new TimeOnly(21, 50) && trip.StartTime >= new TimeOnly(2, 0))
                {
                    returnTrips =
                    [
                        trip with
                        {
                            DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekday,
                        },
                        trip with
                        {
                            RouteIndex = Original.Line.Routes.Length /* Kirschallee -> Pl.d.Einh./W. */,
                            TimeProfileIndex = 0,
                            DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekend,
                            Connections =
                            [
                                trip.StartTime < new TimeOnly(19, 50)
                                    ? ContinuesAs93(M4)
                                    : ContinuesAs99(trip.StartTime switch
                                    {
                                        _ when trip.StartTime == new TimeOnly(20, 5).AddMinutes(-12) => M0,
                                        _ when trip.StartTime == new TimeOnly(20, 25).AddMinutes(-12) => M5,
                                        _ => M2,
                                    })
                            ],
                        }
                    ];
                }
                else
                {
                    returnTrips =
                    [
                        trip with
                        {
                            RouteIndex = Original.Line.Routes.Length /* Kirschallee -> Pl.d.Einh./W. */,
                            TimeProfileIndex = 0,
                            DaysOfOperation = trip.DaysOfOperation & ~(DaysOfOperation.Friday | DaysOfOperation.Saturday),
                            Connections =
                            trip.StartTime > new TimeOnly(23, 30) || trip.StartTime < new TimeOnly(2, 0)
                                ? []
                                : [ContinuesAs99(M2)],
                        },
                        trip with
                        {
                            RouteIndex = Original.Line.Routes.Length /* Kirschallee -> Pl.d.Einh./W. */,
                            TimeProfileIndex = 0,
                            DaysOfOperation = trip.DaysOfOperation & (DaysOfOperation.Friday | DaysOfOperation.Saturday),
                            Connections =
                            trip.StartTime == new TimeOnly(0, 51) || trip.StartTime == new TimeOnly(1, 11)
                                ? []
                                : [ContinuesAs99(M2)],
                        },
                    ];
                }
            }
            else if ((trip.RouteIndex.Equals(6) || trip.RouteIndex.Equals(8) || trip.RouteIndex.Equals(9)) &&
                     (trip.StartTime > new TimeOnly(18, 36) || trip.StartTime < new TimeOnly(2, 0)))
            {
                if (trip.StartTime <= new TimeOnly(21, 50) && trip.StartTime >= new TimeOnly(2, 0))
                {
                    returnTrips =
                    [
                        trip with
                        {
                            DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekday,
                        },
                        trip with
                        {
                            RouteIndex = Original.Line.Routes.Length + 1 /* Pl.d.Einh./W. -> Kirschallee */,
                            TimeProfileIndex = 0,
                            DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekend,
                            StartTime = trip.StartTime.AddMinutes(trip.RouteIndex.Equals(6) ? 26 :
                                trip.RouteIndex.Equals(8) ? 14 : 5),
                        }
                    ];
                }
                else
                {
                    returnTrips =
                    [
                        trip with
                        {
                            RouteIndex =
                            trip.StartTime > new TimeOnly(23, 50) || trip.StartTime < new TimeOnly(2, 0)
                                ? 10 /* Pl.d.Einh./N. -> Kirschallee */
                                : Original.Line.Routes.Length + 1 /* Pl.d.Einh./W. -> Kirschallee */,
                            TimeProfileIndex = 0,
                            DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Sunday,
                            StartTime = trip.StartTime.AddMinutes(5),
                        },
                        trip with
                        {
                            RouteIndex = Original.Line.Routes.Length + 1 /* Pl.d.Einh./W. -> Kirschallee */,
                            TimeProfileIndex = 0,
                            DaysOfOperation = trip.DaysOfOperation & ~DaysOfOperation.Sunday,
                            StartTime = trip.StartTime.AddMinutes(5),
                        },
                    ];
                }
            }

            return returnTrips ?? [trip];
        }).Where(trip => trip.DaysOfOperation != DaysOfOperation.None).ToArray(),
    };
}
