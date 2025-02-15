using Timetable.Models;
using static Timetable.Vip.Minutes;

namespace Timetable.Vip.Lines.Bus694;

public class Bus694From20241214 : Bus694Base<Bus694From20241214>, IBus694Base<Bus694From20241214>, ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 12, 14);

    public static Line.Route[] InstanceRoutes { get; } =
    [
        Routes.TowardsDrewitz.GerlachstrSternCenter,
        Routes.TowardsDrewitz.SGriebnitzseeSternCenter,
        Routes.TowardsDrewitz.RathausBabelsbergSternCenter,
        Routes.TowardsDrewitz.SHauptbahnhofSternCenter,
        Routes.TowardsDrewitz.KüsselstrSternCenter,
        Routes.TowardsDrewitz.HoffbauerStiftungSHauptbahnhof,
        Routes.TowardsDrewitz.KüsselstrSternCenterViaDrewitz,
        Routes.TowardsDrewitz.SHauptbahnhofSternCenterViaDrewitz,
        Routes.TowardsDrewitz.SGriebnitzseeSternCenterViaDrewitz,
        Routes.TowardsDrewitz.SGriebnitzseeKonradWolfAlleeViaDrewitz,
        Routes.TowardsDrewitz.KüsselstrRathausBabelsberg,
        Routes.TowardsDrewitz.SHauptbahnhofRathausBabelsberg,
        Routes.TowardsKüsselstr.JKeplerPlatzRathausBabelsberg,
        Routes.TowardsKüsselstr.JKeplerPlatzSGriebnitzsee,
        Routes.TowardsKüsselstr.SternCenterSHauptbahnhof,
        Routes.TowardsKüsselstr.SternCenterKüsselstr,
        Routes.TowardsKüsselstr.RathausBabelsbergHoffbauerStiftung,
        Routes.TowardsKüsselstr.SHauptbahnhofHoffbauerStiftung,
        Routes.TowardsKüsselstr.SternCenterSGriebnitzsee,
        Routes.TowardsKüsselstr.RathausBabelsbergSHauptbahnhof,
        Routes.TowardsKüsselstr.RathausBabelsbergKüsselstr,
        Routes.TowardsKüsselstr.SHauptbahnhofKüsselstr,
    ];

    public Line Line { get; } = new()
    {
        Name = "694",
        TransportationType = TransportationType.Bus,
        MainRouteIndices =
        [
            RouteIndex(Routes.TowardsDrewitz.KüsselstrSternCenter),
            RouteIndex(Routes.TowardsDrewitz.KüsselstrRathausBabelsberg),
            RouteIndex(Routes.TowardsDrewitz.SHauptbahnhofRathausBabelsberg),
            RouteIndex(Routes.TowardsDrewitz.SGriebnitzseeSternCenterViaDrewitz),
            RouteIndex(Routes.TowardsDrewitz.SGriebnitzseeKonradWolfAlleeViaDrewitz),
            RouteIndex(Routes.TowardsKüsselstr.SternCenterKüsselstr),
            RouteIndex(Routes.TowardsKüsselstr.JKeplerPlatzSGriebnitzsee),
            RouteIndex(Routes.TowardsKüsselstr.RathausBabelsbergSHauptbahnhof),
            RouteIndex(Routes.TowardsKüsselstr.RathausBabelsbergKüsselstr),
        ],
        OverviewRouteIndices =
        [
            RouteIndex(Routes.TowardsDrewitz.KüsselstrSternCenter),
            RouteIndex(Routes.TowardsKüsselstr.SternCenterKüsselstr),
        ],
        Routes = InstanceRoutes,
        TripsCreate =
        [
            ..Trips.TowardsDrewitz.Weekday,
            ..Trips.TowardsDrewitz.School,
            ..Trips.TowardsDrewitz.Saturday,
            ..Trips.TowardsDrewitz.Sunday,
            ..Trips.TowardsDrewitz.Daily,
            ..Trips.TowardsKüsselstr.Weekday,
            ..Trips.TowardsKüsselstr.School,
            ..Trips.TowardsKüsselstr.Saturday,
            ..Trips.TowardsKüsselstr.Sunday,
            ..Trips.TowardsKüsselstr.Daily,
        ],
    };


    private static class Trips
    {
        public static class TowardsDrewitz
        {
            public static Line.TripCreate[] Daily { get; } =
            [
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.KüsselstrSternCenterViaDrewitz),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(18, 50),
                }.AlsoEvery(M20, new TimeOnly(19, 50)),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.KüsselstrSternCenterViaDrewitz),
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(20, 32),
                }.AlsoEvery(M60, 2),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.SHauptbahnhofSternCenterViaDrewitz),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(20, 20),
                }.AlsoEvery(M60, 2),
                new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.SHauptbahnhofSternCenterViaDrewitz),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(21, 0),
                },
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.SGriebnitzseeSternCenterViaDrewitz),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(22, 43),
                }.AlsoEvery(M60, 3),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.SGriebnitzseeKonradWolfAlleeViaDrewitz),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(22, 23),
                }.AlsoEvery(M60, new TimeOnly(1, 23)),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.SGriebnitzseeKonradWolfAlleeViaDrewitz),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(23, 3),
                }.AlsoEvery(M60, new TimeOnly(1, 3)),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.KüsselstrRathausBabelsberg),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(22, 27),
                    Connections = [new Line.TripCreate.Connection{Type = Line.Trip.ConnectionType.ContinuesAs, ConnectingLineIdentifier = "bus693", ConnectingRouteIndex = 1, Delay = M0,},],
                }.AlsoEvery(M60, 2),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.SHauptbahnhofRathausBabelsberg),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(21, 55),
                    Connections = [new Line.TripCreate.Connection{Type = Line.Trip.ConnectionType.ContinuesAs, ConnectingLineIdentifier = "bus693", ConnectingRouteIndex = 1, Delay = M0,},],
                }.AlsoEvery(M60, new TimeOnly(0, 55)),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.SHauptbahnhofRathausBabelsberg),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(22, 15),
                    Connections = [new Line.TripCreate.Connection{Type = Line.Trip.ConnectionType.ContinuesAs, ConnectingLineIdentifier = "bus693", ConnectingRouteIndex = 1, Delay = M0,},],
                }.AlsoEvery(M60, new TimeOnly(0, 15)),
                new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.SHauptbahnhofRathausBabelsberg),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(0, 35),
                    Connections = [new Line.TripCreate.Connection{Type = Line.Trip.ConnectionType.ContinuesAs, ConnectingLineIdentifier = "bus693", ConnectingRouteIndex = 1, Delay = M0,},],
                },
            ];

            public static Line.TripCreate[] Weekday { get; } =
            [
                new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.GerlachstrSternCenter),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(4, 17),
                },
                new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.SGriebnitzseeSternCenter),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(4, 22),
                },
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.RathausBabelsbergSternCenter),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(4, 31),
                }.AlsoEvery(M20, 2),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.SHauptbahnhofSternCenter),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(5, 0),
                }.AlsoEvery(M20, 2),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.KüsselstrSternCenter),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(5, 32),
                }.AlsoEvery(M20, 2),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.KüsselstrSternCenter),
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(6, 10),
                }.AlsoEvery(M20, 3),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.KüsselstrSternCenter),
                    TimeProfileIndex = 2,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(7, 10),
                }.AlsoEvery(M20, 3),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.KüsselstrSternCenter),
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(8, 10),
                }.AlsoEvery(M20, new TimeOnly(13, 50)),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.KüsselstrSternCenter),
                    TimeProfileIndex = 2,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(14, 10),
                }.AlsoEvery(M20, new TimeOnly(17, 10)),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.KüsselstrSternCenter),
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(17, 30),
                }.AlsoEvery(M20, new TimeOnly(18, 30)),
            ];

            public static Line.TripCreate[] School { get; } =
            [
                new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.HoffbauerStiftungSHauptbahnhof),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(7, 28),
                },
                new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.HoffbauerStiftungSHauptbahnhof),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(13, 31),
                },
                new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.HoffbauerStiftungSHauptbahnhof),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(15, 13),
                },
                new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.HoffbauerStiftungSHauptbahnhof),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(16, 0),
                },
            ];

            public static Line.TripCreate[] Saturday { get; } =
            [
                new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.GerlachstrSternCenter),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Saturday,
                    StartTime = new TimeOnly(4, 37),
                },
                new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.SGriebnitzseeSternCenter),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Saturday,
                    StartTime = new TimeOnly(5, 22),
                },
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.SGriebnitzseeSternCenter),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Saturday,
                    StartTime = new TimeOnly(6, 2),
                }.AlsoEvery(M20, new TimeOnly(7, 2)),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.KüsselstrSternCenter),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Saturday,
                    StartTime = new TimeOnly(6, 52),
                }.AlsoEvery(M20, new TimeOnly(9, 52)),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.KüsselstrSternCenter),
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Saturday,
                    StartTime = new TimeOnly(10, 10),
                }.AlsoEvery(M20, new TimeOnly(18, 30)),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.KüsselstrRathausBabelsberg),
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Saturday,
                    StartTime = new TimeOnly(5, 35),
                    Connections = [new Line.TripCreate.Connection{Type = Line.Trip.ConnectionType.ContinuesAs, ConnectingLineIdentifier = "bus693", ConnectingRouteIndex = 1, Delay = M0,},],
                }.AlsoEvery(M60, 2),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.SHauptbahnhofRathausBabelsberg),
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Saturday,
                    StartTime = new TimeOnly(6, 3),
                    Connections = [new Line.TripCreate.Connection{Type = Line.Trip.ConnectionType.ContinuesAs, ConnectingLineIdentifier = "bus693", ConnectingRouteIndex = 1, Delay = M0,},],
                }.AlsoEvery(M20, 2),
            ];

            public static Line.TripCreate[] Sunday { get; } =
            [
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.SGriebnitzseeSternCenter),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Sunday,
                    StartTime = new TimeOnly(7, 22),
                }.AlsoEvery(M20, new TimeOnly(9, 22)),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.KüsselstrSternCenter),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Sunday,
                    StartTime = new TimeOnly(9, 12),
                }.AlsoEvery(M20, new TimeOnly(9, 52)),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.KüsselstrSternCenter),
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Sunday,
                    StartTime = new TimeOnly(10, 10),
                }.AlsoEvery(M20, new TimeOnly(18, 30)),
                new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.KüsselstrRathausBabelsberg),
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Sunday,
                    StartTime = new TimeOnly(6, 55),
                    Connections = [new Line.TripCreate.Connection{Type = Line.Trip.ConnectionType.ContinuesAs, ConnectingLineIdentifier = "bus693", ConnectingRouteIndex = 1, Delay = M0,},],
                },
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.KüsselstrRathausBabelsberg),
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Sunday,
                    StartTime = new TimeOnly(7, 55),
                    Connections = [new Line.TripCreate.Connection{Type = Line.Trip.ConnectionType.ContinuesAs, ConnectingLineIdentifier = "bus693", ConnectingRouteIndex = 1, Delay = M0,},],
                }.AlsoEvery(M20, new TimeOnly(8, 55)),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsDrewitz.SHauptbahnhofRathausBabelsberg),
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Sunday,
                    StartTime = new TimeOnly(7, 23),
                    Connections = [new Line.TripCreate.Connection{Type = Line.Trip.ConnectionType.ContinuesAs, ConnectingLineIdentifier = "bus693", ConnectingRouteIndex = 1, Delay = M0,},],
                }.AlsoEvery(M20, 2),
            ];
        }

        public static class TowardsKüsselstr
        {
            public static Line.TripCreate[] Daily { get; } =
            [
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.SternCenterSHauptbahnhof),
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(19, 44),
                }.AlsoEvery(M20, 2),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.SternCenterSHauptbahnhof),
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(20, 44),
                }.AlsoEvery(M20, 2),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.SternCenterKüsselstr),
                    TimeProfileIndex = 3,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(20, 24),
                }.AlsoEvery(M60, 2),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.SternCenterSGriebnitzsee),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(21, 44),
                }.AlsoEvery(M20, 3),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.SternCenterSGriebnitzsee),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(23, 4),
                }.AlsoEvery(M60, 3),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.JKeplerPlatzSGriebnitzsee),
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(22, 49),
                }.AlsoEvery(M60, 3),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.JKeplerPlatzSGriebnitzsee),
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(23, 29),
                }.AlsoEvery(M60, 2),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.RathausBabelsbergSHauptbahnhof),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(22, 3),
                    Connections = [new Line.TripCreate.Connection
                    {
                        Type = Line.Trip.ConnectionType.ComesAs,
                        ConnectingLineIdentifier = "bus693",
                        ConnectingRouteIndex = 3,
                        Delay = M0,
                    },],
                }.AlsoEvery(M20, 2),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.RathausBabelsbergSHauptbahnhof),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(23, 3),
                    Connections = [new Line.TripCreate.Connection
                    {
                        Type = Line.Trip.ConnectionType.ComesAs,
                        ConnectingLineIdentifier = "bus693",
                        ConnectingRouteIndex = 3,
                        Delay = M0,
                    },],
                }.AlsoEvery(M20, new TimeOnly(0, 43)),
                new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.RathausBabelsbergKüsselstr),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(22, 43),
                    Connections = [new Line.TripCreate.Connection
                    {
                        Type = Line.Trip.ConnectionType.ComesAs,
                        ConnectingLineIdentifier = "bus693",
                        ConnectingRouteIndex = 3,
                        Delay = M0,
                    },],
                },
            ];

            public static Line.TripCreate[] Weekday { get; } =
            [
                new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.JKeplerPlatzRathausBabelsberg),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(3, 48),
                },
                new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.JKeplerPlatzSGriebnitzsee),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(4, 8),
                },
                new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.SternCenterSHauptbahnhof),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(4, 23),
                },
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.SternCenterKüsselstr),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(4, 43),
                }.AlsoEvery(M20, new TimeOnly(5, 23)),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.SternCenterKüsselstr),
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(5, 42),
                }.AlsoEvery(M20, new TimeOnly(6, 42)),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.SternCenterKüsselstr),
                    TimeProfileIndex = 2,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(7, 2),
                }.AlsoEvery(M20, new TimeOnly(8, 22)),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.SternCenterKüsselstr),
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(8, 42),
                }.AlsoEvery(M20, new TimeOnly(14, 2)),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.SternCenterKüsselstr),
                    TimeProfileIndex = 2,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(14, 22),
                }.AlsoEvery(M20, new TimeOnly(16, 22)),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.SternCenterKüsselstr),
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(16, 42),
                }.AlsoEvery(M20, new TimeOnly(19, 22)),
            ];

            public static Line.TripCreate[] School { get; } =
            [
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.RathausBabelsbergHoffbauerStiftung),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(7, 5),
                    Connections = [new Line.TripCreate.Connection
                    {
                        Type = Line.Trip.ConnectionType.ComesAs,
                        ConnectingLineIdentifier = "bus693",
                        ConnectingRouteIndex = 3,
                        Delay = M0,
                    },],
                }.AlsoEvery(M20, 2),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.SHauptbahnhofHoffbauerStiftung),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(7, 32),
                }.AlsoEvery(TimeSpan.FromMinutes(21), 2),
            ];

            public static Line.TripCreate[] Saturday { get; } =
            [
                new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.SternCenterSGriebnitzsee),
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Saturday,
                    StartTime = new TimeOnly(4, 43),
                },
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.SternCenterSGriebnitzsee),
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Saturday,
                    StartTime = new TimeOnly(5, 43),
                }.AlsoEvery(M20, new TimeOnly(6, 43)),
                new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.SHauptbahnhofKüsselstr),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Saturday,
                    StartTime = new TimeOnly(5, 3),
                },
                new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.RathausBabelsbergSHauptbahnhof),
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Saturday,
                    StartTime = new TimeOnly(5, 32),
                    Connections = [new Line.TripCreate.Connection
                    {
                        Type = Line.Trip.ConnectionType.ComesAs,
                        ConnectingLineIdentifier = "bus693",
                        ConnectingRouteIndex = 3,
                        Delay = M0,
                    },],
                },
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.RathausBabelsbergKüsselstr),
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Saturday,
                    StartTime = new TimeOnly(5, 52),
                    Connections = [new Line.TripCreate.Connection
                    {
                        Type = Line.Trip.ConnectionType.ComesAs,
                        ConnectingLineIdentifier = "bus693",
                        ConnectingRouteIndex = 3,
                        Delay = M0,
                    },],
                }.AlsoEvery(M20, new TimeOnly(7, 12)),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.SternCenterKüsselstr),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Saturday,
                    StartTime = new TimeOnly(7, 3),
                }.AlsoEvery(M20, new TimeOnly(9, 43)),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.SternCenterKüsselstr),
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Saturday,
                    StartTime = new TimeOnly(10, 2),
                }.AlsoEvery(M20, new TimeOnly(19, 22)),
            ];

            public static Line.TripCreate[] Sunday { get; } =
            [
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.SternCenterSGriebnitzsee),
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Sunday,
                    StartTime = new TimeOnly(6, 43),
                }.AlsoEvery(M20, new TimeOnly(9, 3)),
                new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.SHauptbahnhofKüsselstr),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Sunday,
                    StartTime = new TimeOnly(6, 23),
                },
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.RathausBabelsbergKüsselstr),
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Sunday,
                    StartTime = new TimeOnly(7, 12),
                    Connections = [new Line.TripCreate.Connection
                    {
                        Type = Line.Trip.ConnectionType.ComesAs,
                        ConnectingLineIdentifier = "bus693",
                        ConnectingRouteIndex = 3,
                        Delay = M0,
                    },],
                }.AlsoEvery(M20, new TimeOnly(9, 32)),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.SternCenterKüsselstr),
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Sunday,
                    StartTime = new TimeOnly(9, 23),
                }.AlsoEvery(M20, new TimeOnly(9, 43)),
                ..new Line.TripCreate
                {
                    RouteIndex = RouteIndex(Routes.TowardsKüsselstr.SternCenterKüsselstr),
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Sunday,
                    StartTime = new TimeOnly(10, 2),
                }.AlsoEvery(M20, new TimeOnly(19, 22)),
            ];
        }
    }
}