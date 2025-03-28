using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus603;

public class Bus603From20241215 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 12, 15);

    public Line Line { get; } = new()
    {
        Name = "603",
        TransportationType = TransportationType.Bus,
        MainRouteIndices = [0, 1],
        OverviewRouteIndices = [0, 1],
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Höhenstr,
                    Stops.LanghansstrGroßeWeinmeisterstr,
                    Stops.Persiusstr,
                    Stops.KleineWeinmeisterstr,
                    Stops.BirkenstrAlleestr,
                    Stops.ReiterwegAlleestr,
                    Stops.Rathaus,
                    Stops.Hebbelstr,
                    Stops.Bassinplatz,
                    Stops.PlatzDerEinheitWest,
                ],
                TimeProfiles = [new Line.Route.TimeProfile { StopDistances = [M0, M2, M1, M1, M1, M1, M2, M2, M1,], },],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.PlatzDerEinheitWest,
                    Stops.Bassinplatz,
                    Stops.Hebbelstr,
                    Stops.Rathaus,
                    Stops.ReiterwegAlleestr,
                    Stops.BirkenstrAlleestr,
                    Stops.AmNeuenGartenGroßeWeinmeisterstr,
                    Stops.Glumestr,
                    Stops.SchlossCecilienhof,
                    Stops.Höhenstr,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile { StopDistances = [M1, M1, M3, M1, M1, M2, M1, M1, M2,], },
                    new Line.Route.TimeProfile { StopDistances = [M1, M1, M3, M1, M0, M2, M1, M1, M2,], },
                ],
                CommonStopIndex = 5 /* Birkenstr./Alleestr. */,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.PlatzDerEinheitWest,
                    Stops.Bassinplatz,
                    Stops.Hebbelstr,
                    Stops.Rathaus,
                    Stops.ReiterwegAlleestr,
                    Stops.BirkenstrAlleestr,
                    Stops.AmNeuenGartenGroßeWeinmeisterstr,
                    Stops.Glumestr,
                    Stops.SchlossCecilienhof,
                    Stops.Höhenstr,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M3, M1, M0, M2, M1, M1, M2,], },
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
                StartTime = new TimeOnly(6, 2),
            }.AlsoEvery(M40, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 52),
            }.AlsoEvery(M30, new TimeOnly(9, 22)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(10, 2),
            }.AlsoEvery(M40, new TimeOnly(13, 22)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(13, 52),
            }.AlsoEvery(M30, new TimeOnly(15, 22)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(16, 2),
            }.AlsoEvery(M40, new TimeOnly(20, 2)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 52),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        Type = Line.Trip.ConnectionType.ContinuesAs,
                        ConnectingLineIdentifier = "busN16",
                        ConnectingRouteIndex = 1,
                        Delay = M2,
                    },
                ],
            }.AlsoEvery(M60, new TimeOnly(22, 52)),
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(6, 2),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(7, 2),
            }.AlsoEvery(M40, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(9, 2),
            }.AlsoEvery(M20, new TimeOnly(19, 42)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 48),
            }.AlsoEvery(M40, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 38),
            }.AlsoEvery(M30, new TimeOnly(9, 8)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(9, 48),
            }.AlsoEvery(M40, new TimeOnly(13, 8)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(13, 38),
            }.AlsoEvery(M30, new TimeOnly(15, 8)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(15, 48),
            }.AlsoEvery(M40, new TimeOnly(19, 48)),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 39),
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(5, 48),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(6, 48),
            }.AlsoEvery(M40, new TimeOnly(8, 8)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(8, 48),
            }.AlsoEvery(M20, new TimeOnly(19, 28)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(21, 38),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        Type = Line.Trip.ConnectionType.ComesAs,
                        ConnectingLineIdentifier = "busN16",
                        ConnectingRouteIndex = 5,
                        Delay = M4,
                    },
                ]
            }.AlsoEvery(M60, new TimeOnly(22, 38)),
        ],
    };
}
