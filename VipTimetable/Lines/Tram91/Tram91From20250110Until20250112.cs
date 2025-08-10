using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Tram91;

public class Tram91From20250110Until20250112 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 1, 10);
    public DateOnly? ValidUntilInclusive() => new(2025, 1, 12);
    private static Tram91From20241215 Original { get; } = new();

    public Line Line { get; } = Original.Line with
    {
        MainRouteIndices = [..Original.Line.MainRouteIndices, Original.Line.Routes.Length, Original.Line.Routes.Length + 1],
        Routes =
        [
            ..Original.Line.Routes, new Line.Route
            {
                StopPositions =
                [
                    Stops.BahnhofPirschheide,
                    Stops.Luftschiffhafen,
                    Stops.ImBogenZeppelinstr,
                    Stops.KastanienalleeZeppelinstr,
                    Stops.SchillerplatzSchafgraben,
                    Stops.BahnhofCharlottenhof,
                    Stops.AufDemKiewitt,
                    Stops.Feuerbachstr,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.Dortustr,
                    // Unclear whether this was served but ending at Dortustr. seems stupid.
                    Stops.PlatzDerEinheitWest,
                ],
                TimeProfiles =
                    [new Line.Route.TimeProfile { StopDistances = [M1, M1, M2, M1, M1, M1, M1, M1, M1, M2,], },],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.PlatzDerEinheitNord,
                    Stops.Dortustr,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.Feuerbachstr,
                    Stops.AufDemKiewitt,
                    Stops.BahnhofCharlottenhofGeschwisterSchollStr,
                    Stops.SchlossCharlottenhof,
                    Stops.KastanienalleeZeppelinstr,
                    Stops.ImBogenZeppelinstr,
                    Stops.Luftschiffhafen,
                    Stops.BahnhofPirschheide,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M1, M1, M2, M2, M2, M1, M2,], },
                    new Line.Route.TimeProfile { StopDistances = [M1, M1, M2, M1, M1, M2, M1, M2, M1, M3,], },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.PlatzDerEinheitWest,
                    Stops.Dortustr,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.Feuerbachstr,
                    Stops.AufDemKiewitt,
                    Stops.BahnhofCharlottenhofGeschwisterSchollStr,
                    Stops.SchlossCharlottenhof,
                    Stops.KastanienalleeZeppelinstr,
                    Stops.ImBogenZeppelinstr,
                    Stops.Luftschiffhafen,
                    Stops.BahnhofPirschheide,
                ],
                TimeProfiles =
                    [new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M1, M1, M2, M2, M2, M1, M2,], },],
                CommonStopIndex = 0,
            },
        ],
        TripsCreate = Original.Line.TripsCreate.SelectMany(trip =>
        {
            List<Line.TripCreate>? returnTrips = null;
            if ((trip.RouteIndex.Equals(0) || trip.RouteIndex.Equals(2)) &&
                (trip.StartTime > new TimeOnly(18, 31) || trip.StartTime < new TimeOnly(1, 0)))
            {
                if (trip.StartTime <= new TimeOnly(21, 18) && trip.StartTime >= new TimeOnly(1, 0))
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
                        },
                    ];
                }
            }
            else if ((trip.RouteIndex.Equals(3) || trip.RouteIndex.Equals(4)) &&
                     (trip.StartTime > new TimeOnly(18, 27) || trip.StartTime < new TimeOnly(2, 0)))
            {
                if (trip.RouteIndex.Equals(4))
                {
                    returnTrips = [];
                }
                else
                {
                    if (trip.StartTime <= new TimeOnly(21, 40) && trip.StartTime >= new TimeOnly(2, 0))
                    {
                        var weekendStartTime =
                            trip.StartTime.AddMinutes(trip.StartTime < new TimeOnly(20, 0) ? 16 : 17);
                        var connectionId = 9391 * 10000 + weekendStartTime.Hour * 100 + weekendStartTime.Minute;
                        returnTrips =
                        [
                            trip with
                            {
                                DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekday,
                            },
                            trip with
                            {
                                RouteIndex = trip.StartTime == new TimeOnly(20, 0)
                                    ? Original.Line.Routes.Length + 2
                                    : Original.Line.Routes.Length + 1,
                                TimeProfileIndex = trip.StartTime < new TimeOnly(20, 0) ? 1 : 0,
                                DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekend,
                                StartTime = weekendStartTime,
                                ConnectionId = trip.StartTime == new TimeOnly(20, 0) ? connectionId : 0,
                                Connections = trip.StartTime == new TimeOnly(20, 0)
                                    ?
                                    [
                                        new Line.TripCreate.Connection
                                        {
                                            ConnectingLineIdentifier = "tram93",
                                            ConnectingRouteIndex = 9,
                                            Delay = M0,
                                            Type = Line.Trip.ConnectionType.ComesAs,
                                            ConnectingId = connectionId,
                                        },
                                    ]
                                    : [],
                            }
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
                                StartTime = trip.StartTime.AddMinutes(17),
                            },
                        ];
                    }
                }
            }

            return returnTrips ?? [trip];
        }).Where(trip => trip.DaysOfOperation != DaysOfOperation.None).ToArray(),
    };
}
