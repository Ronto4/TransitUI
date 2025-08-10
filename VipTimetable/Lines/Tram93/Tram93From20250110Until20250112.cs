using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Tram93;

public class Tram93From20250110Until20250112 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 1, 10);
    public DateOnly? ValidUntilInclusive() => new(2025, 1, 12);
    private static Tram93From20240102 Original { get; } = new();

    public Line Line { get; } = Original.Line with
    {
        Annotations = new Dictionary<string, string>
        {
            { "B", "weiter als 91 nach Bhf Pirschheide" },
            { "C", "weiter als 92 nach Kirschallee" },
            { "D", "weiter als 96 nach Campus Jungfernsee" },
        },
        MainRouteIndices =
        [
            ..Original.Line.MainRouteIndices, Original.Line.Routes.Length, Original.Line.Routes.Length + 1,
            Original.Line.Routes.Length + 2, Original.Line.Routes.Length + 3
        ],
        Routes =
        [
            ..Original.Line.Routes, new Line.Route
            {
                StopPositions =
                [
                    Stops.GlienickerBrücke,
                    Stops.LeonardoDaVinciStr,
                    Stops.Mangerstr,
                    Stops.SchiffbauergasseBerlinerStr,
                    Stops.Holzmarktstr,
                    Stops.BurgstrKlinikum,
                    Stops.PlatzDerEinheitNord,
                ],
                TimeProfiles = [new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M2, M1, M2,], },],
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
                    Stops.PlatzDerEinheitWest,
                ],
                TimeProfiles = [new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M2, M1, M1, M2,], },],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.PlatzDerEinheitNord,
                    Stops.PlatzDerEinheitWest,
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.BurgstrKlinikum,
                    Stops.Holzmarktstr,
                    Stops.SchiffbauergasseBerlinerStr,
                    Stops.Mangerstr,
                    Stops.LeonardoDaVinciStr,
                    Stops.GlienickerBrücke,
                ],
                TimeProfiles = [new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M1, M1, M1, M0, M2,], },],
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
                    Stops.SchiffbauergasseBerlinerStr,
                    Stops.Mangerstr,
                    Stops.LeonardoDaVinciStr,
                    Stops.GlienickerBrücke,
                ],
                TimeProfiles = [new Line.Route.TimeProfile { StopDistances = [M1, M1, M2, M1, M1, M1, M2,], },],
                CommonStopIndex = 0,
            },
        ],
        TripsCreate = Original.Line.TripsCreate.SelectMany(trip =>
        {
            List<Line.TripCreate>? returnTrips = null;
            if ((trip.RouteIndex.Equals(0) || trip.RouteIndex.Equals(2)) && trip.StartTime > new TimeOnly(18, 30))
            {
                if (trip.StartTime < new TimeOnly(19, 0) || trip.StartTime >= new TimeOnly(20, 28))
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
                    if (trip.StartTime < new TimeOnly(19, 30))
                    {
                        returnTrips =
                        [
                            trip with
                            {
                                DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekday,
                            },
                            trip with
                            {
                                RouteIndex = Original.Line.Routes.Length + 1,
                                TimeProfileIndex = 0,
                                DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekend,
                                AnnotationSymbols = ["C"],
                            },
                        ];
                    }
                    else if (trip.StartTime == new TimeOnly(19, 46))
                    {

                        returnTrips =
                        [
                            trip with
                            {
                                DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekday,
                            },
                            trip with
                            {
                                RouteIndex = Original.Line.Routes.Length + 1,
                                TimeProfileIndex = 0,
                                DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekend,
                                AnnotationSymbols = ["D"],
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
                                RouteIndex = Original.Line.Routes.Length + 1,
                                TimeProfileIndex = 0,
                                DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekend,
                                AnnotationSymbols = ["B"],
                            },
                        ];
                    }
                }
            }
            else if (trip.RouteIndex.Equals(4) && trip.StartTime > new TimeOnly(18, 40))
            {
                if (trip.StartTime < new TimeOnly(19, 50))
                {
                    var weekendStartTime = trip.StartTime.AddMinutes(14);
                    var connectionId = 9293 * 10000 + weekendStartTime.Hour * 100 + weekendStartTime.Minute;
                    var weekendDays = (trip.DaysOfOperation & DaysOfOperation.Weekend).HasFlag(DaysOfOperation.Sunday)
                        ? DaysOfOperation.None
                        : (trip.DaysOfOperation & DaysOfOperation.Weekend) is DaysOfOperation.None
                        // This prevents the weekday trip from generating another weekend trip.
                            ? DaysOfOperation.None
                            : DaysOfOperation.Weekend;
                    returnTrips =
                    [
                        trip with
                        {
                            DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekday,
                        },
                        trip with
                        {
                            RouteIndex = Original.Line.Routes.Length + 3,
                            TimeProfileIndex = 0,
                            DaysOfOperation = weekendDays,
                            StartTime = weekendStartTime,
                            ConnectionId = connectionId,
                            Connections =
                            [
                                new Line.TripCreate.Connection
                                {
                                    ConnectingLineIdentifier = "tram92", ConnectingRouteIndex = 11, Delay = M4,
                                    Type = Line.Trip.ConnectionType.ComesAs, ConnectingId = connectionId
                                },
                            ],
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
                            RouteIndex = Original.Line.Routes.Length + 2,
                            TimeProfileIndex = 0,
                            DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekend,
                            StartTime = trip.StartTime.AddMinutes(13),
                        },
                    ];
                }
            }

            return returnTrips ?? [trip];
        }).Where(trip => trip.DaysOfOperation != DaysOfOperation.None).ToArray(),
    };
}
