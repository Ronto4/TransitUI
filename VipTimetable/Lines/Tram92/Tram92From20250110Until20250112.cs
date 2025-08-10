using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Tram92;

public class Tram92From20250110Until20250112 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 1, 10);
    public DateOnly? ValidUntilInclusive() => new(2025, 1, 12);
    private static Tram92From20241215 Original { get; } = new();

    public Line Line { get; } = Original.Line with
    {
        Annotations = new Dictionary<string, string>
        {
            { "A", "weiter als 99 nach Fontanestr." },
            { "B", "weiter als 93 nach Glienicker Brücke." },
        },
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
                        AnnotationSymbols = ["A"],
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
                            AnnotationSymbols = [trip.StartTime < new TimeOnly(19, 50) ? "B" : "A"],
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
                            DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Sunday,
                            AnnotationSymbols =
                            trip.StartTime > new TimeOnly(23, 30) || trip.StartTime < new TimeOnly(2, 0) ? [] : ["A"],
                        },
                        trip with
                        {
                            RouteIndex = Original.Line.Routes.Length /* Kirschallee -> Pl.d.Einh./W. */,
                            TimeProfileIndex = 0,
                            DaysOfOperation = trip.DaysOfOperation & ~DaysOfOperation.Sunday,
                            AnnotationSymbols =
                            trip.StartTime == new TimeOnly(0, 51) || trip.StartTime == new TimeOnly(1, 11) ? [] : ["A"],
                        },
                    ];
                }
            }
            else if ((trip.RouteIndex.Equals(6) || trip.RouteIndex.Equals(8) || trip.RouteIndex.Equals(9)) &&
                     (trip.StartTime > new TimeOnly(18, 36) || trip.StartTime < new TimeOnly(2, 0)))
            {
                if (trip.StartTime <= new TimeOnly(21, 50) && trip.StartTime >= new TimeOnly(2, 0))
                {
                    var weekendStartTime =
                        trip.StartTime.AddMinutes(trip.RouteIndex.Equals(6) ? 26 : trip.RouteIndex.Equals(8) ? 14 : 5);
                    var connectionId = 9992 * 10000 + weekendStartTime.Hour * 100 + weekendStartTime.Minute;
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
                            StartTime = weekendStartTime,
                            ConnectionId = connectionId,
                            Connections = weekendStartTime <= new TimeOnly(19, 37)
                                ? []
                                :
                                [
                                    new Line.TripCreate.Connection
                                    {
                                        ConnectingLineIdentifier = "tram99",
                                        ConnectingRouteIndex = 6,
                                        Delay = weekendStartTime == new TimeOnly(19, 51) ? M4 :
                                            weekendStartTime == new TimeOnly(20, 25) ||
                                            weekendStartTime == new TimeOnly(20, 45) ? M3 : M0,
                                        Type = Line.Trip.ConnectionType.ComesAs,
                                        ConnectingId = connectionId,
                                    },
                                ],
                        }
                    ];
                }
                else
                {
                    var startTime = trip.StartTime.AddMinutes(5);
                    var connectionId = 9992 * 10000 + startTime.Hour * 100 + startTime.Minute;
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
                            StartTime = startTime,
                        },
                        trip with
                        {
                            RouteIndex = Original.Line.Routes.Length + 1 /* Pl.d.Einh./W. -> Kirschallee */,
                            TimeProfileIndex = 0,
                            DaysOfOperation = trip.DaysOfOperation & ~DaysOfOperation.Sunday,
                            StartTime = startTime,
                            ConnectionId = connectionId,
                            Connections =
                            [
                                new Line.TripCreate.Connection
                                {
                                    ConnectingLineIdentifier = "tram99",
                                    ConnectingRouteIndex = 6,
                                    Delay = M0,
                                    Type = Line.Trip.ConnectionType.ComesAs,
                                    ConnectingId = connectionId,
                                },
                            ],
                        },
                    ];
                }
            }

            return returnTrips ?? [trip];
        }).Where(trip => trip.DaysOfOperation != DaysOfOperation.None).ToArray(),
    };
}
