using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus692;

public class Bus692From20250804 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 8, 4);
    private static Bus692From20250203 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        MainRouteIndices = [..Previous.Line.MainRouteIndices, 8, 9],
        Routes =
        [
            ..Previous.Line.Routes[..0],
            Previous.Line.Routes[0] with
            {
                TimeProfiles =
                [
                    ..Previous.Line.Routes[0].TimeProfiles,
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M2, M2, M1, M0, M2, M1, M0, M2, M1, M0, M1, M2, M0, M2, M1, M1, M3, M2, M0, M1, M2, M1, M1,
                            M1, M2, M1, M3, M1, M1,
                        ],
                    },
                ],
            },
            ..Previous.Line.Routes[1..3],
            Previous.Line.Routes[3] with
            {
                TimeProfiles =
                [
                    ..Previous.Line.Routes[3].TimeProfiles,
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M2, M2, M1, M0, M2, M1, M1, M2, M0, M2, M1, M2, M3, M2, M0, M1, M2, M1, M1, M1, M2, M1, M3,
                            M1, M1,
                        ],
                    },
                ],
            },
            ..Previous.Line.Routes[4..],
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Kirschallee,
                    Stops.JohanBoumanPlatz,
                    Stops.Ruinenbergstr,
                    Stops.SchlegelstrPappelallee,
                    Stops.ReiterwegJägerallee,
                    Stops.JägertorJustizzentrum,
                    Stops.Mauerstr,
                    Stops.LuisenplatzNordParkSanssouci,
                    Stops.LuisenplatzOstParkSanssouci,
                    Stops.Dortustr,
                    Stops.PlatzDerEinheitWest,
                    Stops.Bassinplatz,
                    Stops.Klinikum,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M2, M0, M1, M2, M1, M1, M1, M2, M1, M3, M1, M1,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M2, M1, M1, M2, M1, M1, M1, M2, M1, M3, M1, M1,],
                    },
                ],
                CommonStopIndex = 2 /* Ruinenbergstr. */,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Klinikum,
                    Stops.BurgstrKlinikum,
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.PlatzDerEinheitWest,
                    Stops.Dortustr,
                    Stops.LuisenplatzOstParkSanssouci,
                    Stops.LuisenplatzNordParkSanssouci,
                    Stops.JägertorJustizzentrum,
                    Stops.ReiterwegJägerallee,
                    Stops.SchlegelstrPappelallee,
                    Stops.Ruinenbergstr,
                    Stops.JohanBoumanPlatz,
                    Stops.Kirschallee,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M1, M1, M1, M1, M1, M2, M1, M2, M1, M1, M3,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M1, M1, M1, M1, M2, M2, M1, M2, M1, M1, M3,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M1, M1, M1, M1, M2, M2, M1, M2, M1, M1, M3,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M1, M1, M1, M1, M1, M2, M1, M1, M1, M1, M3,],
                    },
                ],
                CommonStopIndex = 0,
            }
        ],
        TripsCreate = Previous.Line.TripsCreate.Select(trip =>
        {
            if (CheckStartingAtKirschallee(trip) is { } newTripKirschallee) return newTripKirschallee;
            if (CheckToKlinikumViaAgrar(trip) is { } newTripAgrarToKlinikum) return newTripAgrarToKlinikum;
            if (CheckToKlinikumNotViaAgrar(trip) is { } newTripNotAgrarToKlinikum) return newTripNotAgrarToKlinikum;
            if (CheckEndingAtKirschallee(trip) is { } newTripEndingKirschallee) return newTripEndingKirschallee;
            if (CheckFromKlinikumViaAgrar(trip) is { } newTripAgrarFromKlinikum) return newTripAgrarFromKlinikum;

            return trip;

            static Line.TripCreate? CheckStartingAtKirschallee(Line.TripCreate trip)
            {
                TimeOnly[] fahrlandOldStartTimesAgrar =
                [
                    new(6, 16),
                    new(8, 14),
                    new(14, 15),
                    new(15, 15),
                    new(16, 15),
                    new(17, 16),
                    new(18, 16)
                ];
                if (trip.RouteIndex.Equals(1) && fahrlandOldStartTimesAgrar.Contains(trip.StartTime))
                {
                    var offset = trip.StartTime < new TimeOnly(8, 0) || trip.StartTime > new TimeOnly(17, 0)
                        ? TimeSpan.FromMinutes(11)
                        : TimeSpan.FromMinutes(12);
                    var timeProfileIndex = trip.StartTime == new TimeOnly(8, 14) ? 1 : 0;
                    return trip with
                    {
                        RouteIndex = 8,
                        TimeProfileIndex = timeProfileIndex,
                        StartTime = trip.StartTime.Add(offset),
                        Connections =
                        [
                            new Line.TripCreate.Connection
                            {
                                ConnectingLineIdentifier = "bus619",
                                ConnectingRouteIndex = 3,
                                Delay = M0,
                                Type = Line.Trip.ConnectionType.ComesAs,
                            },
                        ],
                    };
                }

                return null;
            }

            static Line.TripCreate? CheckToKlinikumViaAgrar(Line.TripCreate trip)
            {
                TimeOnly[] times = [new(8, 27), new(17, 29), new(18, 29)];
                if (trip.RouteIndex.Equals(3) && times.Contains(trip.StartTime))
                {
                    var timeProfileIndex = trip.StartTime == new TimeOnly(8, 27) ? 1 : 4;
                    return trip with
                    {
                        RouteIndex = 0,
                        TimeProfileIndex = timeProfileIndex,
                        StartTime = trip.StartTime.AddMinutes(-3),
                    };
                }

                return null;
            }

            static Line.TripCreate? CheckToKlinikumNotViaAgrar(Line.TripCreate trip)
            {
                TimeOnly[] times = [new(12, 25)];
                if (trip.RouteIndex.Equals(0) && times.Contains(trip.StartTime))
                {
                    var timeProfileIndex = 3;
                    return trip with
                    {
                        RouteIndex = 3,
                        TimeProfileIndex = timeProfileIndex,
                        StartTime = trip.StartTime.AddMinutes(3),
                    };
                }

                return null;
            }

            static Line.TripCreate? CheckEndingAtKirschallee(Line.TripCreate trip)
            {
                TimeOnly[] times =
                [
                    new(5, 21),
                    new(7, 21),
                    new(13, 21),
                    new(14, 21),
                    new(15, 21),
                    new(16, 21),
                    new(17, 21),
                ];
                if (trip.RouteIndex.Equals(4) && times.Contains(trip.StartTime))
                {
                    return trip with
                    {
                        RouteIndex = 9,
                        Connections =
                        [
                            new Line.TripCreate.Connection
                            {
                                ConnectingLineIdentifier = "bus619",
                                ConnectingRouteIndex = 1,
                                Delay = M0,
                                Type = Line.Trip.ConnectionType.ContinuesAs,
                            },
                        ],
                    };
                }

                return null;
            }

            static Line.TripCreate? CheckFromKlinikumViaAgrar(Line.TripCreate trip)
            {
                TimeOnly[] times =
                [
                    new(5, 41),
                    new(12, 41),
                    new(16, 41),
                    new(17, 41),
                ];
                if (trip.RouteIndex.Equals(5) && times.Contains(trip.StartTime))
                {
                    var timeProfileIndex = trip.StartTime == new TimeOnly(5, 41) ? 3 :
                        trip.StartTime == new TimeOnly(17, 41) ? 0 : 1;
                    return trip with
                    {
                        RouteIndex = 6,
                        TimeProfileIndex = timeProfileIndex,
                    };
                }

                return null;
            }
        }).ToArray(),
    };
}
