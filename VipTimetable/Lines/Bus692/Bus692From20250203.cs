using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus692;

public class Bus692From20250203 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 2, 3);
    private static Bus692From20241214 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        Routes =
        [
            Previous.Line.Routes[0] with
            {
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M2, M1, M0, M1, M1, M0, M2, M1, M0, M1, M2, M0, M2, M1, M1, M3, M2, M0, M1, M2, M1, M1,
                            M1, M1, M1, M3, M1, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M2, M2, M1, M0, M2, M1, M0, M2, M1, M0, M1, M2, M0, M2, M1, M2, M3, M2, M1, M1, M2, M1, M1,
                            M1, M2, M1, M3, M1, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M2, M2, M1, M0, M2, M1, M0, M2, M1, M0, M1, M2, M0, M2, M1, M2, M3, M2, M0, M1, M2, M1, M1,
                            M1, M2, M1, M3, M1, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M2, M1, M0, M1, M1, M0, M2, M1, M0, M1, M1, M0, M1, M1, M1, M3, M1, M1, M0, M2, M1, M1,
                            M1, M1, M1, M3, M1, M1,
                        ],
                    },
                ],
            },
            Previous.Line.Routes[1] with
            {
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M0, M1, M2, M0, M2, M1, M1, M3, M2, M0, M1, M2, M1, M1, M1, M1, M1, M3, M1, M1,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M0, M1, M2, M0, M2, M1, M1, M3, M2, M0, M1, M2, M1, M1, M1, M2, M1, M3, M1, M1,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M0, M1, M2, M0, M2, M1, M2, M3, M2, M1, M1, M2, M1, M1, M1, M2, M1, M3, M1, M1,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M0, M1, M2, M0, M2, M1, M2, M3, M2, M0, M1, M2, M1, M1, M1, M2, M1, M3, M1, M1,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M0, M1, M1, M0, M1, M1, M1, M3, M1, M1, M0, M2, M1, M1, M1, M1, M1, M3, M1, M1,],
                    },
                ],
            },
            Previous.Line.Routes[2] with
            {
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M0, M2, M1, M0, M2, M1, M0, M1, M2, M0, M2, M1, M2, M3, M2, M1, M1, M2, M1, M1, M1, M2,
                            M1, M3, M1, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M0, M1, M1, M0, M2, M1, M0, M1, M1, M0, M1, M1, M1, M3, M1, M1, M0, M2, M1, M1, M1, M1,
                            M1, M3, M1, M1,
                        ],
                    },
                ],
            },
            Previous.Line.Routes[3] with
            {
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M2, M2, M1, M0, M2, M1, M1, M2, M0, M2, M1, M2, M3, M2, M1, M1, M2, M1, M1, M1, M2, M1, M3,
                            M1, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M2, M2, M1, M0, M2, M1, M1, M2, M0, M2, M1, M1, M3, M2, M0, M1, M2, M1, M1, M1, M2, M1, M3,
                            M1, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M2, M1, M0, M1, M1, M1, M2, M0, M2, M1, M1, M3, M2, M0, M1, M2, M1, M1, M1, M1, M1, M3,
                            M1, M1,
                        ],
                    },
                ],
            },
            Previous.Line.Routes[4] with
            {
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M1, M1, M1, M1, M1, M2, M1, M2, M1, M1, M3, M3, M1, M1, M1, M1, M1, M1, M0, M2,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M1, M1, M1, M1, M2, M2, M1, M2, M1, M1, M3, M3, M1, M1, M1, M1, M1, M1, M0, M2,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M1, M1, M1, M1, M2, M2, M1, M2, M1, M1, M3, M3, M1, M1, M2, M1, M1, M1, M0, M2,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M1, M1, M1, M1, M1, M2, M1, M1, M1, M1, M3, M2, M1, M1, M1, M1, M1, M1, M0, M2,],
                    },
                ],
            },
            Previous.Line.Routes[5] with
            {
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M1, M2, M1, M2, M1, M1, M3, M3, M1, M1, M1, M1, M1, M1, M2, M1, M0, M1,
                            M3, M2,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M2, M2, M1, M2, M1, M1, M3, M3, M1, M1, M1, M1, M1, M1, M2, M1, M0, M1,
                            M3, M2,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M2, M2, M1, M2, M1, M1, M3, M3, M1, M1, M2, M1, M1, M1, M2, M1, M1, M1,
                            M3, M2,
                        ],
                    },
                ],
            },
            Previous.Line.Routes[6] with
            {
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M2, M2, M1, M2, M1, M1, M3, M3, M1, M1, M1, M1, M1, M1, M0, M2, M1, M0,
                            M2, M1, M0, M1, M3, M2,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M2, M2, M1, M2, M1, M1, M3, M3, M1, M1, M2, M1, M1, M1, M0, M2, M1, M0,
                            M2, M1, M1, M1, M3, M2,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M1, M2, M1, M1, M1, M1, M3, M2, M1, M1, M1, M1, M1, M1, M0, M2, M1, M0,
                            M1, M1, M0, M1, M2, M2,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M1, M2, M1, M2, M1, M1, M3, M3, M1, M1, M1, M1, M1, M1, M0, M2, M1, M0,
                            M1, M1, M0, M1, M3, M2,
                        ],
                    },
                ],
            },
            Previous.Line.Routes[7] with
            {
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M1, M2, M1, M1, M1, M1, M3, M2, M1, M1, M1, M1, M1, M1, M0, M2, M1, M0,
                            M1, M1, M0, M1,
                        ],
                    },
                ],
            },
        ],
        TripsCreate =
        [
            ..Trips.TowardsKlinikum15,
            ..Trips.TowardsKlinikum67,
            ..Trips.FromKlinikum15,
            ..Trips.FromKlinikum67,
        ],
    };
}

file static class Trips
{
    private static Line.TripCreate[] TowardsKlinikum15Route0 { get; } =
    [
        new()
        {
            RouteIndex = 0,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(5, 8),
        },
        new()
        {
            RouteIndex = 0,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(6, 24),
        },
        new()
        {
            RouteIndex = 0,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(7, 24),
        },
        new()
        {
            RouteIndex = 0,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.School,
            StartTime = new TimeOnly(7, 44),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 0,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(12, 25),
        }.AlsoEvery(M60, new TimeOnly(16, 25)),
        ..new Line.TripCreate
        {
            RouteIndex = 0,
            TimeProfileIndex = 3,
            DaysOfOperation = DaysOfOperation.Daily,
            StartTime = new TimeOnly(20, 32),
        }.AlsoEvery(M60, 2),
    ];

    private static Line.TripCreate[] TowardsKlinikum15Route1 { get; } =
    [
        new()
        {
            RouteIndex = 1,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(5, 56),
        },
        new()
        {
            RouteIndex = 1,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(6, 16),
        },
        new()
        {
            RouteIndex = 1,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(6, 54),
        },
        new()
        {
            RouteIndex = 1,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Holiday,
            StartTime = new TimeOnly(7, 14),
        },
        new()
        {
            RouteIndex = 1,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Holiday,
            StartTime = new TimeOnly(7, 54),
        },
        new()
        {
            RouteIndex = 1,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(8, 14),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(8, 54),
        }.AlsoEvery(M60, 2),
        ..new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(9, 14),
        }.AlsoEvery(M60, 2),
        ..new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(10, 56),
        }.AlsoEvery(M60, 2),
        new()
        {
            RouteIndex = 1,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(11, 16),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 3,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(12, 15),
        }.AlsoEvery(M60, new TimeOnly(16, 15)),
        ..new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 3,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(12, 55),
        }.AlsoEvery(M60, new TimeOnly(15, 55)),
        ..new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(16, 56),
        }.AlsoEvery(M60, new TimeOnly(18, 56)),
        ..new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(17, 16),
        }.AlsoEvery(M60, new TimeOnly(19, 16)),
        new()
        {
            RouteIndex = 1,
            TimeProfileIndex = 4,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(20, 20),
        },
        new()
        {
            RouteIndex = 1,
            TimeProfileIndex = 4,
            DaysOfOperation = DaysOfOperation.Friday | DaysOfOperation.Saturday,
            StartTime = new TimeOnly(0, 40),
        },
    ];

    private static Line.TripCreate[] TowardsKlinikum15Route2 { get; } =
    [
        new()
        {
            RouteIndex = 2,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.School,
            StartTime = new TimeOnly(7, 8),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 2,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Daily,
            StartTime = new TimeOnly(22, 35),
        }.AlsoEvery(M60, 2),
    ];

    private static Line.TripCreate[] TowardsKlinikum15Route3 { get; } =
    [
        ..new Line.TripCreate
        {
            RouteIndex = 3,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(8, 27),
        }.AlsoEvery(M60, 3),
        new()
        {
            RouteIndex = 3,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(11, 29),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 3,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(17, 29),
        }.AlsoEvery(M60, 3),
    ];

    public static Line.TripCreate[] TowardsKlinikum15 { get; } =
    [
        ..TowardsKlinikum15Route0,
        ..TowardsKlinikum15Route1,
        ..TowardsKlinikum15Route2,
        ..TowardsKlinikum15Route3,
    ];

    private static Line.TripCreate[] TowardsKlinikum67Route0 { get; } =
    [
        ..new Line.TripCreate
        {
            RouteIndex = 0,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Saturday,
            StartTime = new TimeOnly(5, 13),
        }.AlsoEvery(M60, 3),
        ..new Line.TripCreate
        {
            RouteIndex = 0,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Sunday,
            StartTime = new TimeOnly(6, 13),
        }.AlsoEvery(M60, 3),
    ];

    private static Line.TripCreate[] TowardsKlinikum67Route1 { get; } =
    [
        new()
        {
            RouteIndex = 1,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Saturday,
            StartTime = new TimeOnly(8, 1),
        },
        new()
        {
            RouteIndex = 1,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Saturday,
            StartTime = new TimeOnly(8, 41),
        },
        new()
        {
            RouteIndex = 1,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(9, 1),
        },
        new()
        {
            RouteIndex = 1,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(9, 41),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(10, 1),
        }.AlsoEvery(M60, new TimeOnly(19, 1)),
        ..new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(10, 41),
        }.AlsoEvery(M60, new TimeOnly(18, 41)),
        ..new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 4,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(19, 55),
        }.AlsoEvery(M20, 2),
    ];

    private static Line.TripCreate[] TowardsKlinikum67Route3 { get; } =
    [
        new()
        {
            RouteIndex = 3,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Saturday,
            StartTime = new TimeOnly(8, 16),
        },
        new()
        {
            RouteIndex = 3,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(9, 16),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 3,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(10, 14),
        }.AlsoEvery(M60, new TimeOnly(19, 14)),
    ];

    public static Line.TripCreate[] TowardsKlinikum67 { get; } =
    [
        ..TowardsKlinikum67Route0,
        ..TowardsKlinikum67Route1,
        ..TowardsKlinikum67Route3,
    ];

    private static Line.TripCreate[] FromKlinikum15Route4 { get; } =
    [
        ..new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(5, 21),
        }.AlsoEvery(M40, 2),
        ..new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(6, 21),
        }.AlsoEvery(M60, new TimeOnly(10, 21)),
        new()
        {
            RouteIndex = 4,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Holiday,
            StartTime = new TimeOnly(7, 1),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(8, 1),
        }.AlsoEvery(M60, new TimeOnly(10, 1)),
        ..new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(11, 1),
        }.AlsoEvery(M60, new TimeOnly(17, 1)),
        ..new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(11, 21),
        }.AlsoEvery(M60, new TimeOnly(16, 21)),
        ..new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(17, 21),
        }.AlsoEvery(M60, new TimeOnly(19, 21)),
        ..new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(18, 1),
        }.AlsoEvery(M60, new TimeOnly(19, 1)),
        new()
        {
            RouteIndex = 4,
            TimeProfileIndex = 3,
            DaysOfOperation = DaysOfOperation.Friday | DaysOfOperation.Saturday,
            StartTime = new TimeOnly(0, 4),
        },
    ];

    private static Line.TripCreate[] FromKlinikum15Route5 { get; } =
    [
        new()
        {
            RouteIndex = 5,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(5, 41),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 5,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(8, 41),
        }.AlsoEvery(M60, 3),
        ..new Line.TripCreate
        {
            RouteIndex = 5,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(11, 41),
        }.AlsoEvery(M60, 2),
        new()
        {
            RouteIndex = 5,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(16, 41),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 5,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(17, 41),
        }.AlsoEvery(M60, 3),
    ];

    private static Line.TripCreate[] FromKlinikum15Route6 { get; } =
    [
        ..new Line.TripCreate
        {
            RouteIndex = 6,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(6, 41),
        }.AlsoEvery(M60, 2),
        new()
        {
            RouteIndex = 6,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.School,
            StartTime = new TimeOnly(7, 1),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 6,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(13, 41),
        }.AlsoEvery(M60, new TimeOnly(15, 41)),
        new()
        {
            RouteIndex = 6,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Daily,
            StartTime = new TimeOnly(20, 4),
        },
    ];

    private static Line.TripCreate[] FromKlinikum15Route7 { get; } =
    [
        ..new Line.TripCreate
        {
            RouteIndex = 7,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Daily,
            StartTime = new TimeOnly(21, 4),
        }.AlsoEvery(M60, 3),
    ];

    public static Line.TripCreate[] FromKlinikum15 { get; } =
    [
        ..FromKlinikum15Route4,
        ..FromKlinikum15Route5,
        ..FromKlinikum15Route6,
        ..FromKlinikum15Route7,
    ];

    private static Line.TripCreate[] FromKlinikum67Route4 { get; } =
    [
        ..new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Saturday,
            StartTime = new TimeOnly(7, 17),
        }.AlsoEvery(M40, 2),
        ..new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(8, 17),
        }.AlsoEvery(M60, new TimeOnly(9, 17)),
        new()
        {
            RouteIndex = 4,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(8, 57),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(9, 56),
        }.AlsoEvery(M60, new TimeOnly(18, 56)),
        ..new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(10, 16),
        }.AlsoEvery(M60, new TimeOnly(19, 16)),
    ];

    private static Line.TripCreate[] FromKlinikum67Route5 { get; } =
    [
        new()
        {
            RouteIndex = 5,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Saturday,
            StartTime = new TimeOnly(7, 37),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 5,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(8, 37),
        }.AlsoEvery(M60, 2),
        ..new Line.TripCreate
        {
            RouteIndex = 5,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(10, 36),
        }.AlsoEvery(M60, new TimeOnly(19, 36)),
    ];

    private static Line.TripCreate[] FromKlinikum67Route6 { get; } =
    [
        ..new Line.TripCreate
        {
            RouteIndex = 6,
            TimeProfileIndex = 3,
            DaysOfOperation = DaysOfOperation.Saturday,
            StartTime = new TimeOnly(5, 17),
        }.AlsoEvery(M60, 2),
        ..new Line.TripCreate
        {
            RouteIndex = 6,
            TimeProfileIndex = 3,
            DaysOfOperation = DaysOfOperation.Sunday,
            StartTime = new TimeOnly(6, 17),
        }.AlsoEvery(M60, 2),
    ];

    public static Line.TripCreate[] FromKlinikum67 { get; } =
    [
        ..FromKlinikum67Route4,
        ..FromKlinikum67Route5,
        ..FromKlinikum67Route6,
    ];
}
