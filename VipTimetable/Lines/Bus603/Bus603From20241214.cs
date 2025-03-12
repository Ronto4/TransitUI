using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus603;

public class Bus603From20241214 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 12, 14);

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
                    Stops.ReiterwegJägerallee,
                    Stops.JägertorJustizzentrum,
                    Stops.Hebbelstr,
                    Stops.Bassinplatz,
                    Stops.PlatzDerEinheitWest,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M0, M2, M1, M1, M2, M1, M3, M2, M1]
                    }
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.PlatzDerEinheitWest,
                    Stops.Bassinplatz,
                    Stops.Hebbelstr,
                    Stops.NauenerTor,
                    Stops.JägertorJustizzentrum,
                    Stops.ReiterwegJägerallee,
                    Stops.BirkenstrAlleestr,
                    Stops.AmNeuenGartenGroßeWeinmeisterstr,
                    Stops.Glumestr,
                    Stops.SchlossCecilienhof,
                    Stops.Höhenstr,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M2, M1, M2, M2, M1, M1, M2],
                    }
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.PlatzDerEinheitWest,
                    Stops.Bassinplatz,
                    Stops.Hebbelstr,
                    Stops.NauenerTor,
                    Stops.JägertorJustizzentrum,
                    Stops.ReiterwegJägerallee,
                    Stops.BirkenstrAlleestr,
                    Stops.AmNeuenGartenGroßeWeinmeisterstr,
                    Stops.Glumestr,
                    Stops.SchlossCecilienhof,
                    Stops.Höhenstr,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M1, M2, M1, M2, M2, M1, M1, M2],
                    }
                ],
                CommonStopIndex = 0,
            },
        ],
        TripsCreate =
        [
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(6, 2),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 42),
            }.AlsoEvery(M20, new TimeOnly(9, 22)),
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
                StartTime = new TimeOnly(13, 42),
            }.AlsoEvery(M20, new TimeOnly(16, 42)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(17, 22),
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
                        Delay = M0,
                    },
                ],
            }.AlsoEvery(M60, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(7, 2),
            }.AlsoEvery(M40, new TimeOnly(9, 2)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(9, 22),
            }.AlsoEvery(M20, new TimeOnly(19, 42)),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(5, 47),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 27),
            }.AlsoEvery(M20, new TimeOnly(9, 7)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(9, 47),
            }.AlsoEvery(M40, new TimeOnly(13, 7)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(13, 27),
            }.AlsoEvery(M20, new TimeOnly(16, 27)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(17, 7),
            }.AlsoEvery(M40, new TimeOnly(19, 47)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(21, 36),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        Type = Line.Trip.ConnectionType.ComesAs,
                        ConnectingLineIdentifier = "busN16",
                        ConnectingRouteIndex = 5,
                        Delay = M2,
                    },
                ],
            }.AlsoEvery(M60, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(6, 47),
            }.AlsoEvery(M40, new TimeOnly(8, 47)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(9, 7),
            }.AlsoEvery(M20, new TimeOnly(19, 27)),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 37),
            },
        ],
    };
}
