using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus695;

public class Bus695From20250203 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 2, 3);
    private static Bus695From20241214 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        Routes =
        [
            Previous.Line.Routes[0] with
            {
                CommonStopIndex = Previous.Line.Routes[0].CommonStopIndex + 1,
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M2, M1, M1, M1, M1, M1, M0, M1, M0, M1, M1, M1, M1, M1, M1, M2, M3, M1, M1, M1, M1, M2,
                            M2, M3,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M2, M1, M1, M1, M1, M1, M1, M1, M0, M1, M1, M1, M1, M1, M2, M2, M3, M1, M1, M1, M2, M2,
                            M2, M3,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M2, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M2, M2, M3, M1, M1, M1, M2, M2,
                            M2, M3,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M2, M1, M1, M1, M1, M1, M0, M1, M0, M1, M1, M0, M1, M1, M1, M2, M3, M1, M1, M1, M1, M2,
                            M1, M3,
                        ],
                    },
                ],
            },
            Previous.Line.Routes[1] with
            {
                CommonStopIndex = Previous.Line.Routes[1].CommonStopIndex + 1,
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M0, M1, M0, M1, M1, M1, M1, M1, M1, M2, M3, M1, M1, M1, M1, M2, M2, M3,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M1, M1, M0, M1, M1, M1, M1, M1, M2, M2, M3, M1, M1, M1, M2, M2, M2, M3,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M0, M1, M0, M1, M1, M0, M1, M1, M1, M2, M3, M1, M1, M1, M1, M2, M1, M3,
                        ],
                    },
                ],
            },
            Previous.Line.Routes[2] with
            {
                CommonStopIndex = Previous.Line.Routes[2].CommonStopIndex + 1,
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M2, M3, M1, M1, M1, M1, M2, M2, M3,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M2, M3, M1, M1, M1, M2, M2, M2, M3,],
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
                            M3, M1, M1, M1, M2, M2, M1, M3, M2, M1, M0, M1, M0, M1, M0, M1, M0, M1, M1, M1, M1, M1, M2,
                            M2, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M2, M1, M2, M2, M2, M1, M3, M2, M1, M1, M1, M0, M1, M1, M0, M1, M1, M1, M1, M1, M1, M2,
                            M2, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M2, M2, M2, M2, M2, M1, M3, M2, M1, M1, M1, M0, M1, M1, M0, M1, M1, M1, M1, M2, M1, M2,
                            M2, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M1, M1, M2, M2, M2, M1, M2, M2, M1, M1, M1, M0, M1, M0, M1, M0, M1, M1, M1, M1, M1, M2,
                            M2, M1,
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
                        [
                            M3, M1, M1, M1, M2, M2, M1, M3, M2, M1, M0, M1, M0, M1, M0, M1, M0, M1, M1, M1, M1, M1, M2,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M2, M1, M2, M2, M2, M1, M3, M2, M1, M1, M1, M0, M1, M1, M0, M1, M1, M1, M1, M1, M1, M2,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M1, M1, M2, M2, M2, M1, M2, M2, M1, M1, M1, M0, M1, M0, M1, M0, M1, M1, M1, M1, M1, M2,
                        ],
                    },
                ],
            },
            Previous.Line.Routes[5] with
            {
                TimeProfiles = [new Line.Route.TimeProfile { StopDistances = [M3, M2, M1, M2, M2, M2, M1,], },],
            },
            Previous.Line.Routes[6] with
            {
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M3, M1, M1, M1, M2, M2, M1, M3,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M3, M2, M1, M2, M2, M2, M1, M3,],
                    },
                ],
            },
        ],
        TripsCreate =
        [
            ..Trips.TowardsSHauptbahnhof15,
            ..Trips.TowardsSHauptbahnhof67,
            ..Trips.FromSHauptbahnhof15,
            ..Trips.FromSHauptbahnhof67,
        ]
    };
}

file static class Trips
{
    private static Line.TripCreate[] TowardsSHauptbahnhof15Route0 { get; } =
    [
        new()
        {
            RouteIndex = 0,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(5, 10),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 0,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(6, 7),
        }.AlsoEvery(M20, 3),
        ..new Line.TripCreate
        {
            RouteIndex = 0,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(7, 6),
        }.AlsoEvery(M20, new TimeOnly(8, 6)),
        ..new Line.TripCreate
        {
            RouteIndex = 0,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(8, 27),
        }.AlsoEvery(M20, 2),
        ..new Line.TripCreate
        {
            RouteIndex = 0,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(9, 7),
        }.AlsoEvery(M60, new TimeOnly(11, 7)),
        ..new Line.TripCreate
        {
            RouteIndex = 0,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(12, 7),
        }.AlsoEvery(M20, new TimeOnly(13, 47)),
        ..new Line.TripCreate
        {
            RouteIndex = 0,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(14, 6),
        }.AlsoEvery(M20, new TimeOnly(16, 26)),
        ..new Line.TripCreate
        {
            RouteIndex = 0,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(16, 47),
        }.AlsoEvery(M20, new TimeOnly(19, 7)),
        new()
        {
            RouteIndex = 0,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(20, 7),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 0,
            TimeProfileIndex = 3,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(20, 59),
        }.AlsoEvery(M60, new TimeOnly(23, 59)),
    ];

    private static Line.TripCreate[] TowardsSHauptbahnhof15Route1 { get; } =
    [
        ..new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(4, 53),
        }.AlsoEvery(M60, 2),
        new()
        {
            RouteIndex = 1,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(5, 33),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(9, 30),
        }.AlsoEvery(M60, new TimeOnly(11, 30)),
        ..new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(9, 50),
        }.AlsoEvery(M60, new TimeOnly(11, 50)),
        new()
        {
            RouteIndex = 1,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(19, 30),
        },
        new()
        {
            RouteIndex = 1,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(19, 50),
        },
    ];

    public static Line.TripCreate[] TowardsSHauptbahnhof15 { get; } =
    [
        ..TowardsSHauptbahnhof15Route0,
        ..TowardsSHauptbahnhof15Route1,
    ];

    private static Line.TripCreate[] TowardsSHauptbahnhof67Route0 { get; } =
    [
        new()
        {
            RouteIndex = 0,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Saturday,
            StartTime = new TimeOnly(6, 50),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 0,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(7, 50),
        }.AlsoEvery(M60, new TimeOnly(9, 50)),
        ..new Line.TripCreate
        {
            RouteIndex = 0,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(10, 47),
        }.AlsoEvery(M60, new TimeOnly(19, 47)),
        ..new Line.TripCreate
        {
            RouteIndex = 0,
            TimeProfileIndex = 3,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(20, 59),
        }.AlsoEvery(M60, new TimeOnly(21, 59)),
        new()
        {
            RouteIndex = 0,
            TimeProfileIndex = 3,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(23, 59),
        },
    ];

    private static Line.TripCreate[] TowardsSHauptbahnhof67Route1 { get; } =
    [
        new()
        {
            RouteIndex = 1,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(23, 2),
        },
    ];

    private static Line.TripCreate[] TowardsSHauptbahnhof67Route2 { get; } =
    [
        ..new Line.TripCreate
        {
            RouteIndex = 2,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Saturday,
            StartTime = new TimeOnly(8, 25),
        }.AlsoEvery(M60, 2),
        ..new Line.TripCreate
        {
            RouteIndex = 2,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Saturday,
            StartTime = new TimeOnly(8, 45),
        }.AlsoEvery(M60, 2),
        ..new Line.TripCreate
        {
            RouteIndex = 2,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(10, 24),
        }.AlsoEvery(M60, new TimeOnly(19, 24)),
        ..new Line.TripCreate
        {
            RouteIndex = 2,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(10, 44),
        }.AlsoEvery(M60, new TimeOnly(19, 44)),
    ];

    public static Line.TripCreate[] TowardsSHauptbahnhof67 { get; } =
    [
        ..TowardsSHauptbahnhof67Route0,
        ..TowardsSHauptbahnhof67Route1,
        ..TowardsSHauptbahnhof67Route2,
    ];

    private static Line.TripCreate[] FromSHauptbahnhof15Route3 { get; } =
    [
        ..new Line.TripCreate
        {
            RouteIndex = 3,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(4, 34),
        }.AlsoEvery(M60, 2),
        new()
        {
            RouteIndex = 3,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(5, 54),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 3,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(6, 17),
        }.AlsoEvery(M20, new TimeOnly(8, 17)),
        ..new Line.TripCreate
        {
            RouteIndex = 3,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(9, 17),
        }.AlsoEvery(M60, new TimeOnly(10, 17)),
        ..new Line.TripCreate
        {
            RouteIndex = 3,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(11, 17),
        }.AlsoEvery(M20, new TimeOnly(12, 37)),
        ..new Line.TripCreate
        {
            RouteIndex = 3,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(12, 57),
        }.AlsoEvery(M20, new TimeOnly(17, 17)),
        ..new Line.TripCreate
        {
            RouteIndex = 3,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(17, 37),
        }.AlsoEvery(M20, 2),
        ..new Line.TripCreate
        {
            RouteIndex = 3,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(18, 17),
        }.AlsoEvery(M60, 2),
        ..new Line.TripCreate
        {
            RouteIndex = 3,
            TimeProfileIndex = 3,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(20, 14),
        }.AlsoEvery(M60, new TimeOnly(23, 14)),
    ];

    private static Line.TripCreate[] FromSHauptbahnhof15Route4 { get; } =
    [
        ..new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(4, 54),
        }.AlsoEvery(M20, 2),
        ..new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(8, 37),
        }.AlsoEvery(M60, new TimeOnly(10, 37)),
        ..new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(8, 57),
        }.AlsoEvery(M60, new TimeOnly(10, 57)),
        ..new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(18, 37),
        }.AlsoEvery(M60, 2),
        new()
        {
            RouteIndex = 4,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(18, 57),
        },
    ];

    private static Line.TripCreate[] FromSHauptbahnhof15Route5 { get; } =
    [
        new()
        {
            RouteIndex = 5,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Daily,
            StartTime = new TimeOnly(19, 57)
        }
    ];

    public static Line.TripCreate[] FromSHauptbahnhof15 { get; } =
    [
        ..FromSHauptbahnhof15Route3,
        ..FromSHauptbahnhof15Route4,
        ..FromSHauptbahnhof15Route5,
    ];

    private static Line.TripCreate[] FromSHauptbahnhof67Route3 { get; } =
    [
        ..new Line.TripCreate
        {
            RouteIndex = 3,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(7, 37),
        }.AlsoEvery(M60, new TimeOnly(9, 37)),
        ..new Line.TripCreate
        {
            RouteIndex = 3,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(10, 37),
        }.AlsoEvery(M60, new TimeOnly(19, 37)),
        ..new Line.TripCreate
        {
            RouteIndex = 3,
            TimeProfileIndex = 3,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(20, 14),
        }.AlsoEvery(M60, 2),
        new()
        {
            RouteIndex = 3,
            TimeProfileIndex = 3,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(23, 14),
        },
    ];

    private static Line.TripCreate[] FromSHauptbahnhof67Route4 { get; } =
    [
        ..new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Saturday,
            StartTime = new TimeOnly(5, 37),
        }.AlsoEvery(M60, 2),
        new()
        {
            RouteIndex = 4,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(22, 14),
        },
    ];

    private static Line.TripCreate[] FromSHauptbahnhof67Route6 { get; } =
    [
        ..new Line.TripCreate
        {
            RouteIndex = 6,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Saturday,
            StartTime = new TimeOnly(7, 57),
        }.AlsoEvery(M60, 2),
        ..new Line.TripCreate
        {
            RouteIndex = 6,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Saturday,
            StartTime = new TimeOnly(8, 17),
        }.AlsoEvery(M60, 2),
        new()
        {
            RouteIndex = 6,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(9, 57),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 6,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(10, 17),
        }.AlsoEvery(M60, new TimeOnly(19, 17)),
        ..new Line.TripCreate
        {
            RouteIndex = 6,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(10, 57),
        }.AlsoEvery(M60, new TimeOnly(18, 57)),
    ];

    public static Line.TripCreate[] FromSHauptbahnhof67 { get; } =
    [
        ..FromSHauptbahnhof67Route3,
        ..FromSHauptbahnhof67Route4,
        ..FromSHauptbahnhof67Route6,
    ];
}
