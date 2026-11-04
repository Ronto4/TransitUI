using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus609;

public class Bus609From20250804 : Bus609BaseKrampnitz<Bus609From20250804>, IBus609BaseKrampnitz<Bus609From20250804>,
    ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 8, 4);

    public static Line.Route[] InstanceRoutes { get; } =
    [
        Routes.SatzkornJungfernsee,
        Routes.AmUpstallJungfernsee,
        Routes.SatzkornHbf,
        Routes.KartzowKaserne,
        Routes.AmUpstallJungfernseeViaAltstrecke,
        Routes.SatzkornPde,
        Routes.AmUpstallKaserne,
        Routes.PaarenPde,
        Routes.SatzkornKaserne,
        Routes.MarquardtSatzkorn,
        Routes.SatzkornKaserneViaAltstrecke,
        Routes.PaarenAmUpstall,
        Routes.SchuleMarquardtKaserne,
        Routes.SchuleFahrlandKaserneViaAltstrecke,
        Routes.MarquardtJungfernseeViaKartzow,
        Routes.MarquardtJungfernsee,
        Routes.KartzowJungfernsee,
        Routes.KartzowJungfernseeViaSatzkorn,
        Routes.JungfernseeUpstall,
        Routes.JungfernseeSatzkorn,
        Routes.JungfernseeSchuleMarquardt,
        Routes.SatzkornMarquardt,
        Routes.SchuleFahrlandPaarenViaKartzow,
        Routes.SchuleFahrlandPaaren,
        Routes.JungfernseeMarquardt,
        Routes.JungfernseeMarquardtViaKartzow,
        Routes.JungfernseeKartzowViaSatzkorn,
        Routes.JungfernseeKartzow,
    ];

    public Line Line { get; } = new()
    {
        Name = "609",
        TransportationType = TransportationType.Bus,
        MainRouteIndices =
        [
            RouteIndex(Routes.SatzkornJungfernsee),
            RouteIndex(Routes.AmUpstallJungfernsee),
            RouteIndex(Routes.AmUpstallKaserne),
            RouteIndex(Routes.SatzkornKaserne),
            RouteIndex(Routes.MarquardtSatzkorn),
            RouteIndex(Routes.KartzowJungfernseeViaSatzkorn),
            RouteIndex(Routes.JungfernseeUpstall),
            RouteIndex(Routes.JungfernseeSatzkorn),
            RouteIndex(Routes.SatzkornMarquardt),
            RouteIndex(Routes.JungfernseeKartzowViaSatzkorn),
        ],
        OverviewRouteIndices =
        [
            RouteIndex(Routes.SatzkornKaserne),
            RouteIndex(Routes.JungfernseeSatzkorn),
        ],
        Routes = InstanceRoutes,
        TripsCreate =
        [
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 14),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornJungfernsee),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 33),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornJungfernsee),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(6, 33),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornJungfernsee),
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(20, 8),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornJungfernsee),
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(20, 6),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornJungfernsee),
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Friday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(0, 6),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 55),
            }.AlsoEvery(M120, 2),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornJungfernsee),
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(22, 6),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(7, 55),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(9, 54),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornJungfernsee),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(11, 53),
            }.AlsoEvery(M120, new TimeOnly(17, 53)),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.AmUpstallJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 5),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.AmUpstallJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 25),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus619",
                        ConnectingRouteIndex = 0,
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ComesAs,
                    },
                ],
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.AmUpstallJungfernsee),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 24),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus619",
                        ConnectingRouteIndex = 0,
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ComesAs,
                    },
                ],
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.AmUpstallJungfernsee),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(18, 24),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus619",
                        ConnectingRouteIndex = 0,
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ComesAs,
                    },
                ],
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.AmUpstallJungfernsee),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(18, 44),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.AmUpstallJungfernsee),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(19, 24),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus619",
                        ConnectingRouteIndex = 0,
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ComesAs,
                    },
                ],
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.AmUpstallJungfernsee),
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(19, 57),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.AmUpstallJungfernsee),
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(21, 17),
            }.AlsoEvery(M60, 2),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.AmUpstallJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(9, 45),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.AmUpstallJungfernsee),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 24),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus619",
                        ConnectingRouteIndex = 0,
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ComesAs,
                    },
                ],
            }.AlsoEvery(M60, new TimeOnly(19, 24)),
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.AmUpstallJungfernsee),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(10, 44),
            }.AlsoEvery(M60, new TimeOnly(18, 44)),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornHbf),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 33),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornHbf),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 53),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.KartzowKaserne),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 55),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.AmUpstallJungfernseeViaAltstrecke),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(7, 7),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornPde),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(7, 6),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.AmUpstallKaserne),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 24),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus619",
                        ConnectingRouteIndex = 0,
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ComesAs,
                    },
                ],
            }.AlsoEvery(M60, new TimeOnly(17, 24)),
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.AmUpstallKaserne),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(8, 44),
            }.AlsoEvery(M60, new TimeOnly(12, 44)),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.PaarenPde),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 56),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornKaserne),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 33),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornKaserne),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(13, 33),
            }.AlsoEvery(M60, 2),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornKaserne),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(15, 33),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornKaserne),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(16, 33),
            }.AlsoEvery(M60, 2),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.MarquardtSatzkorn),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(7, 48),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.MarquardtSatzkorn),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(9, 48),
            }.AlsoEvery(M120, 2),
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.MarquardtSatzkorn),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(14, 0),
            }.AlsoEvery(M120, 2),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.MarquardtSatzkorn),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(18, 0),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornKaserneViaAltstrecke),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.SchoolFriday,
                StartTime = new TimeOnly(13, 6),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.PaarenAmUpstall),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(13, 44),
            }.AlsoEvery(M60, 2),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.PaarenAmUpstall),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(15, 55),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SchuleMarquardtKaserne),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(15, 22),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SchuleFahrlandKaserneViaAltstrecke),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(15, 50),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.MarquardtJungfernseeViaKartzow),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(20, 16),
            }.AlsoEvery(M120, 2),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.MarquardtJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(21, 23),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.KartzowJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(23, 5),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus609",
                        ConnectingRouteIndex = RouteIndex(Routes.JungfernseeKartzowViaSatzkorn),
                        Delay = M2,
                        Type = Line.Trip.ConnectionType.ComesAs,
                        NotableViaStop = Stops.Satzkorn,
                    },
                ],
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.KartzowJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(21, 5),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus609",
                        ConnectingRouteIndex = RouteIndex(Routes.JungfernseeKartzowViaSatzkorn),
                        Delay = M2,
                        Type = Line.Trip.ConnectionType.ComesAs,
                        NotableViaStop = Stops.Satzkorn,
                    },
                ],
            }.AlsoEvery(M120, 2),
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.KartzowJungfernseeViaSatzkorn),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(6, 50),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus609",
                        ConnectingRouteIndex = RouteIndex(Routes.JungfernseeKartzow),
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ComesAs,
                    },
                ],
            }.AlsoEvery(M120, 2),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.KartzowJungfernseeViaSatzkorn),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(6, 50),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.KartzowJungfernseeViaSatzkorn),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(8, 50),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus609",
                        ConnectingRouteIndex = RouteIndex(Routes.JungfernseeKartzow),
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ComesAs,
                    },
                ],
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.KartzowJungfernseeViaSatzkorn),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(10, 48),
            }.AlsoEvery(M120, new TimeOnly(18, 48)),
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeUpstall),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 23),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus619",
                        ConnectingRouteIndex = 2,
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ContinuesAs,
                    },
                ],
            }.AlsoEvery(M60, 2),
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeUpstall),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 23),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus619",
                        ConnectingRouteIndex = 2,
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ContinuesAs,
                    },
                ],
            }.AlsoEvery(M60, new TimeOnly(18, 23)),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeUpstall),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(19, 23),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus619",
                        ConnectingRouteIndex = 2,
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ContinuesAs,
                    },
                ],
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeUpstall),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(9, 23),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus619",
                        ConnectingRouteIndex = 2,
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ContinuesAs,
                    },
                ],
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeUpstall),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 23),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus619",
                        ConnectingRouteIndex = 2,
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ContinuesAs,
                    },
                ],
            }.AlsoEvery(M60, new TimeOnly(18, 23)),
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeUpstall),
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(8, 3),
            }.AlsoEvery(M60, new TimeOnly(12, 3)),
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeUpstall),
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(18, 3),
            }.AlsoEvery(M60, 2),
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeUpstall),
                TimeProfileIndex = 3,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(20, 33),
            }.AlsoEvery(M60, 2),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeUpstall),
                TimeProfileIndex = 3,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(9, 3),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeUpstall),
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(10, 3),
            }.AlsoEvery(M60, new TimeOnly(19, 3)),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeSatzkorn),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 3),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeSatzkorn),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 3),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeSatzkorn),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(7, 3),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeSatzkorn),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(7, 23),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeSatzkorn),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(9, 3),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeSatzkorn),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(11, 3),
            }.AlsoEvery(M120, new TimeOnly(19, 3)),
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeSatzkorn),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(13, 3),
            }.AlsoEvery(M60, new TimeOnly(17, 3)),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeSatzkorn),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(19, 43),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeSatzkorn),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(21, 33),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeSatzkorn),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(23, 33),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeSatzkorn),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Friday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(0, 33),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeSchuleMarquardt),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(7, 3),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornMarquardt),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(7, 53),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornMarquardt),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(9, 53),
            }.AlsoEvery(M120, 2),
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornMarquardt),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(14, 5),
            }.AlsoEvery(M120, 2),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornMarquardt),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(18, 5),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SchuleFahrlandPaarenViaKartzow),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.SchoolFriday,
                StartTime = new TimeOnly(13, 8),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SchuleFahrlandPaarenViaKartzow),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(14, 8),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SchuleFahrlandPaaren),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(14, 55),
            }.AlsoEvery(TimeSpan.FromMinutes(55), 2),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeMarquardt),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(20, 13),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeMarquardtViaKartzow),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(21, 13),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeKartzowViaSatzkorn),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(22, 33),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus609",
                        ConnectingRouteIndex = RouteIndex(Routes.KartzowJungfernsee),
                        Delay = M2,
                        Type = Line.Trip.ConnectionType.ContinuesAs,
                    },
                ],
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeKartzow),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(6, 23),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus609",
                        ConnectingRouteIndex = RouteIndex(Routes.KartzowJungfernseeViaSatzkorn),
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ContinuesAs,
                        NotableViaStop = Stops.Satzkorn,
                    },
                ],
            }.AlsoEvery(M120, 2),
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeKartzowViaSatzkorn),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(20, 33),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus609",
                        ConnectingRouteIndex = RouteIndex(Routes.KartzowJungfernsee),
                        Delay = M2,
                        Type = Line.Trip.ConnectionType.ContinuesAs,
                    },
                ],
            }.AlsoEvery(M120, 2),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeKartzow),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(8, 23),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus609",
                        ConnectingRouteIndex = RouteIndex(Routes.KartzowJungfernseeViaSatzkorn),
                        Delay = M0,
                        Type = Line.Trip.ConnectionType.ContinuesAs,
                        NotableViaStop = Stops.Satzkorn,
                    },
                ],
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeKartzowViaSatzkorn),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(10, 3),
            }.AlsoEvery(M120, new TimeOnly(18, 3)),
        ],
    };
}
