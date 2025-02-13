using Timetables.Models;
using static Timetables.Vip.Minutes;

namespace Timetables.Vip.Lines.Bus609;

public class Bus609From20241214 : Bus609Base<Bus609From20241214>, IBus609Base<Bus609From20241214>, ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 12, 14);

    public static Line.Route[] InstanceRoutes { get; } =
    [
        Routes.SatzkornJungfernsee,
        Routes.UpstallJungfernsee,
        Routes.MarquardtJungfernsee,
        Routes.KartzowJungfernsee,
        Routes.UpstallHbfViaLuisenplatz,
        Routes.KartzowHbfViaLuisenplatz,
        Routes.SatzkornPdeViaLuisenplatz,
        Routes.PaarenPdeViaLuisenplatz,
        Routes.MarquardtKartzowJungfernsee,
        Routes.PaarenJungfernsee,
        Routes.SchuleFahrlandJungfernsee,
        Routes.MarquardtJungfernseeExpress,
        Routes.JungfernseeMarquardtSatzkorn,
        Routes.JungfernseeKartzow,
        Routes.JungfernseeUpstall,
        Routes.JungfernseeMarquardt,
        Routes.JungfernseeSchuleMarquardt,
        Routes.JungfernseeKartzowMarquardt,
        Routes.SchuleFahrlandPaaren,
        Routes.JungfernseePaaren,
        Routes.JungfernseeSatzkorn,
        Routes.JungfernseeMarquardtExpress,
    ];

    public Line Line { get; } = new()
    {
        Name = "609",
        TransportationType = TransportationType.Bus,
        MainRouteIndices =
        [
            RouteIndex(Routes.SatzkornJungfernsee), RouteIndex(Routes.UpstallJungfernsee),
            RouteIndex(Routes.MarquardtJungfernsee), RouteIndex(Routes.KartzowJungfernsee),
            RouteIndex(Routes.MarquardtJungfernseeExpress), RouteIndex(Routes.JungfernseeKartzow),
            RouteIndex(Routes.JungfernseeUpstall), RouteIndex(Routes.JungfernseeMarquardt),
            RouteIndex(Routes.JungfernseeSatzkorn), RouteIndex(Routes.JungfernseeMarquardtExpress),
        ],
        OverviewRouteIndices =
            [RouteIndex(Routes.MarquardtKartzowJungfernsee), RouteIndex(Routes.JungfernseeKartzowMarquardt)],
        Routes = InstanceRoutes,
        TripsCreate =
        [
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 16),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(12, 46),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.SchoolFriday,
                StartTime = new TimeOnly(13, 6),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornJungfernsee),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Monday | DaysOfOperation.Tuesday | DaysOfOperation.Wednesday |
                                  DaysOfOperation.Thursday,
                StartTime = new TimeOnly(23, 8),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornJungfernsee),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Friday,
                StartTime = new TimeOnly(0, 8),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(6, 16),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(7, 56),
            }.AlsoEvery(M120, new TimeOnly(17, 56)),
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornJungfernsee),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(20, 8),
            }.AlsoEvery(M120, 2),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornJungfernsee),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(0, 8),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.UpstallJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 7),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.UpstallJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 57),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.UpstallJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(6, 47),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.UpstallJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 57),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.UpstallJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(8, 7),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.UpstallJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(9, 57),
            }.AlsoEvery(M60, 3),
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.UpstallJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(14, 7),
            }.AlsoEvery(M60, new TimeOnly(17, 7)),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.UpstallJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(18, 7),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.UpstallJungfernsee),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(20, 19),
            }.AlsoEvery(M60, 3),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.MarquardtJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 13),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.MarquardtJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 13),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.MarquardtJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(7, 13),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.MarquardtJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(8, 13),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.MarquardtJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(9, 13),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.MarquardtJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(11, 13),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.MarquardtJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(13, 13),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.MarquardtJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(14, 13),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.MarquardtJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(15, 13),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.MarquardtJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(16, 13),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.MarquardtJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(17, 13),
            }.AlsoEvery(M60, 3),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.MarquardtJungfernsee),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(21, 25),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.KartzowJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 51),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.KartzowJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(6, 51),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.KartzowJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 31),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.KartzowJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(8, 41),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.KartzowJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(13, 31),
            }.AlsoEvery(M60, new TimeOnly(17, 31)),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.KartzowJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(18, 41),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.KartzowJungfernsee),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Friday,
                StartTime = new TimeOnly(23, 3),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.KartzowJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(6, 51),
            }.AlsoEvery(M120, new TimeOnly(18, 51)),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.KartzowJungfernsee),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(21, 3),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.KartzowJungfernsee),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(23, 3),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.UpstallHbfViaLuisenplatz),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 47),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.KartzowHbfViaLuisenplatz),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 51),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SatzkornPdeViaLuisenplatz),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(7, 6),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.PaarenPdeViaLuisenplatz),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 56),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.MarquardtKartzowJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(10, 6),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.MarquardtKartzowJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(12, 6),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.MarquardtKartzowJungfernsee),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(20, 18),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.MarquardtKartzowJungfernsee),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(22, 18),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.PaarenJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(13, 42),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.PaarenJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(14, 42),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.PaarenJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(15, 2),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.PaarenJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(16, 2),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.PaarenJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(16, 42),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SchuleFahrlandJungfernsee),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(16, 0),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.MarquardtJungfernseeExpress),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 17),
            }.AlsoEvery(M60, new TimeOnly(19, 17)),
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeMarquardtSatzkorn),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 23),
            }.AlsoEvery(M60, 2),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeKartzow),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 3),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeKartzow),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 53),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeKartzow),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(12, 43),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeKartzow),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(13, 53),
            }.AlsoEvery(M60, new TimeOnly(17, 53)),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeKartzow),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Friday,
                StartTime = new TimeOnly(22, 33),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeKartzow),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(6, 3),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeKartzow),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(8, 3),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeKartzow),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 3),
            }.AlsoEvery(M120, new TimeOnly(18, 3)),
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeKartzow),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(20, 33),
            }.AlsoEvery(M120, 2),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeUpstall),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 43),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeUpstall),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 33),
            }.AlsoEvery(M60, 2),
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeUpstall),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(8, 43),
            }.AlsoEvery(M60, new TimeOnly(11, 43)),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeUpstall),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(13, 33),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeUpstall),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(16, 33),
            }.AlsoEvery(M60, new TimeOnly(18, 33)),
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeUpstall),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(19, 33),
            }.AlsoEvery(M60, new TimeOnly(21, 33)),
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeMarquardt),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 13),
            }.AlsoEvery(M60, new TimeOnly(8, 13)),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeMarquardt),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(10, 13),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeMarquardt),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(12, 13),
            }.AlsoEvery(M60, new TimeOnly(18, 13)),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeMarquardt),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(20, 13),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeSchuleMarquardt),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 53),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeKartzow),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(6, 53),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeKartzowMarquardt),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(9, 13),
            }.AlsoEvery(M120, 2),
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeKartzowMarquardt),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(19, 13),
            }.AlsoEvery(M120, 2),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SchuleFahrlandPaaren),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.SchoolFriday,
                StartTime = new TimeOnly(13, 8),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.SchuleFahrlandPaaren),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(14, 8),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseePaaren),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(14, 33),
            }.AlsoEvery(M60, 2),
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeUpstall),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(14, 33),
            }.AlsoEvery(M60, 2),
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeSatzkorn),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(18, 53),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeSatzkorn),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Monday | DaysOfOperation.Tuesday | DaysOfOperation.Wednesday |
                                  DaysOfOperation.Thursday,
                StartTime = new TimeOnly(22, 33),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeSatzkorn),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(23, 33),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeSatzkorn),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Friday,
                StartTime = new TimeOnly(0, 33),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeSatzkorn),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(7, 3),
            }.AlsoEvery(M120, 2),
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeSatzkorn),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(11, 3),
            }.AlsoEvery(M120, new TimeOnly(19, 3)),
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
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(23, 33),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeSatzkorn),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(0, 33),
            },
            new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeMarquardtExpress),
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(9, 23),
            },
            ..new Line.TripCreate
            {
                RouteIndex = RouteIndex(Routes.JungfernseeMarquardtExpress),
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 23),
            }.AlsoEvery(M60, new TimeOnly(19, 23)),
        ],
    };
}
