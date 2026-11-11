using Timetable;
using static VipTimetable.Minutes;

using Routes609 = VipTimetable.Lines.Bus609.Bus609BaseKrampnitz.Routes;

namespace VipTimetable.Lines.Bus619;

public class Bus619From20250804 : ILineInstance
{
    private static Index RouteIndex609(Line.Route route) =>
        Bus609.Bus609BaseKrampnitz<Bus609.Bus609From20250804>.RouteIndex(route);

    public DateOnly ValidFrom { get; } = new(2025, 8, 4);

    public Line Line { get; } = new()
    {
        Name = "619",
        TransportationType = TransportationType.Bus,
        MainRouteIndices = [0, 1, 2, 3],
        OverviewRouteIndices = [1, 3],
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.BahnhofMarquardt,
                    Stops.MarquardterStr,
                    Stops.KietzerStr,
                    Stops.Kienhorststr,
                    Stops.Eisbergstücke,
                    Stops.AmUpstall,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M2, M2, M1, M1, M4,],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Kirschallee,
                    Stops.Thaerstr,
                    Stops.AmundsenstrPotsdamerStr,
                    Stops.Florastr,
                    Stops.LindstedterChaussee,
                    Stops.KircheBornim,
                    Stops.Heineberg,
                    Stops.SacrowParetzerKanal,
                    Stops.BahnhofMarquardt,
                    Stops.BahnhofMarquardt, /* because no different arrival and departure time are supported, see https://github.com/Ronto4/TransitUI/issues/34 */
                    Stops.MarquardterStr,
                    Stops.KietzerStr,
                    Stops.Kienhorststr,
                    Stops.Eisbergstücke,
                    Stops.AmUpstall,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M3, M1, M1, M1, M1, M2, M2, M2, M4, M2, M2, M1, M1, M3,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M3, M1, M1, M2, M1, M2, M2, M2, M2, M2, M2, M1, M1, M3,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M3, M1, M1, M1, M1, M2, M2, M2, M3, M2, M2, M1, M1, M3,],
                    },
                ],
                CommonStopIndex = 13 /* Eisbergstücke */,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.AmUpstall,
                    Stops.Eisbergstücke,
                    Stops.Kienhorststr,
                    Stops.KietzerStr,
                    Stops.MarquardterStr,
                    Stops.BahnhofMarquardt,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M2, M1, M1, M1, M3,],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.AmUpstall,
                    Stops.Eisbergstücke,
                    Stops.Kienhorststr,
                    Stops.KietzerStr,
                    Stops.MarquardterStr,
                    Stops.BahnhofMarquardt,
                    Stops.SacrowParetzerKanal,
                    Stops.Heineberg,
                    Stops.KircheBornim,
                    Stops.LindstedterChaussee,
                    Stops.Florastr,
                    Stops.AmundsenstrPotsdamerStr,
                    Stops.Thaerstr,
                    Stops.Kirschallee,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M2, M1, M1, M1, M3, M2, M2, M2, M0, M2, M1, M1, M3,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M2, M1, M1, M1, M3, M2, M2, M2, M0, M2, M1, M2, M3,],
                    },
                ],
                CommonStopIndex = 12 /* Thaerstr. */,
            },
        ],
        TripsCreate =
        [
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 15),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus609",
                        ConnectingRouteIndex = RouteIndex609(Routes609.AmUpstallJungfernsee),
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ContinuesAs,
                    },
                ],
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 14),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus609",
                        ConnectingRouteIndex = RouteIndex609(Routes609.AmUpstallJungfernsee),
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ContinuesAs,
                    },
                ],
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 14),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus609",
                        ConnectingRouteIndex = RouteIndex609(Routes609.AmUpstallKaserne),
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ContinuesAs,
                    },
                ],
            }.AlsoEvery(M60, new TimeOnly(17, 14)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(18, 14),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus609",
                        ConnectingRouteIndex = RouteIndex609(Routes609.AmUpstallJungfernsee),
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ContinuesAs,
                    },
                ],
            }.AlsoEvery(M60, new TimeOnly(19, 14)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 14),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus609",
                        ConnectingRouteIndex = RouteIndex609(Routes609.AmUpstallJungfernsee),
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ContinuesAs,
                    },
                ],
            }.AlsoEvery(M60, new TimeOnly(19, 14)),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 37),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus692",
                        ConnectingRouteIndex = 9,
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ComesAs,
                    },
                ],
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 38),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus692",
                        ConnectingRouteIndex = 9,
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ComesAs,
                    },
                ],
            },
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(13, 38),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus692",
                        ConnectingRouteIndex = 9,
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ComesAs,
                    },
                ],
            }.AlsoEvery(M60, new TimeOnly(16, 38)),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(17, 38),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus692",
                        ConnectingRouteIndex = 9,
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ComesAs,
                    },
                ],
            },
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 38),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus609",
                        ConnectingRouteIndex = RouteIndex609(Routes609.JungfernseeUpstall),
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ComesAs,
                    },
                ],
            }.AlsoEvery(M60, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 40),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus609",
                        ConnectingRouteIndex = RouteIndex609(Routes609.JungfernseeUpstall),
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ComesAs,
                    },
                ],
            }.AlsoEvery(M60, new TimeOnly(18, 40)),
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(19, 38),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus609",
                        ConnectingRouteIndex = RouteIndex609(Routes609.JungfernseeUpstall),
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ComesAs,
                    },
                ],
            },
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(9, 38),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus609",
                        ConnectingRouteIndex = RouteIndex609(Routes609.JungfernseeUpstall),
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ComesAs,
                    },
                ],
            },
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 40),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus609",
                        ConnectingRouteIndex = RouteIndex609(Routes609.JungfernseeUpstall),
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ComesAs,
                    },
                ],
            }.AlsoEvery(M60, new TimeOnly(18, 40)),
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 6),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus692",
                        ConnectingRouteIndex = 8,
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ContinuesAs,
                    },
                ],
            },
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(8, 4),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus692",
                        ConnectingRouteIndex = 8,
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ContinuesAs,
                    },
                ],
            },
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(14, 5),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus692",
                        ConnectingRouteIndex = 8,
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ContinuesAs,
                    },
                ],
            }.AlsoEvery(M60, new TimeOnly(16, 5)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(17, 6),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus692",
                        ConnectingRouteIndex = 8,
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ContinuesAs,
                    },
                ],
            }.AlsoEvery(M60, new TimeOnly(18, 6)),
        ]
    };
}
