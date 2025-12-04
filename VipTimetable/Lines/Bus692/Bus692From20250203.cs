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
                    ..Previous.Line.Routes[0].TimeProfiles,
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
                        ]
                    },
                ],
            },
            Previous.Line.Routes[1] with
            {
                TimeProfiles =
                [
                    ..Previous.Line.Routes[1].TimeProfiles,
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M0, M1, M2, M0, M2, M1, M1, M3, M2, M0, M1, M2, M1, M1, M1, M1, M1, M3, M1, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M0, M1, M2, M0, M2, M1, M2, M3, M2, M1, M1, M2, M1, M1, M1, M2, M1, M3, M1, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M0, M1, M2, M0, M2, M1, M1, M3, M2, M0, M1, M2, M1, M1, M1, M2, M1, M3, M1, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M0, M1, M2, M0, M2, M1, M2, M3, M2, M0, M1, M2, M1, M1, M1, M2, M1, M3, M1, M1,
                        ]
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
                    ..Previous.Line.Routes[2].TimeProfiles[1..],
                ],
            },
            Previous.Line.Routes[3] with
            {
                TimeProfiles =
                [
                    ..Previous.Line.Routes[3].TimeProfiles,
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
                    ..Previous.Line.Routes[4].TimeProfiles,
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
                    ..Previous.Line.Routes[5].TimeProfiles,
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
                    ..Previous.Line.Routes[6].TimeProfiles,
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
                ],
            },
            ..Previous.Line.Routes[7..],
        ],
        TripsCreate = Previous.Line.TripsCreate.Select(Helpers.Transform).ToArray(),
    };
}

file static class Helpers
{
    public static Line.TripCreate Transform(Line.TripCreate trip)
    {
        // Some special cases
        if (trip.RouteIndex.Equals(4) && trip.StartTime == new TimeOnly(0, 4))
        {
            return trip with
            {
                TimeProfileIndex = 7,
            };
        }

        return (trip.DaysOfOperation & DaysOfOperation.Weekend) > 0 ? TransformWeekend(trip) : TransformWeekday(trip);
    }

    private static Line.TripCreate TransformWeekday(Line.TripCreate trip) =>
        trip.RouteIndex.Value switch
        {
            <= 3 => TransformWeekdayToKlinikum(trip),
            >= 4 => TransformWeekdayFromKlinikum(trip),
        };

    private static Line.TripCreate TransformWeekdayFromKlinikum(Line.TripCreate trip)
    {
        if (trip.RouteIndex.Equals(4))
        {
            if (trip.StartTime < new TimeOnly(6, 20))
            {
                return trip with
                {
                    TimeProfileIndex = 4,
                };
            }

            if (new TimeOnly(6, 20) < trip.StartTime && trip.StartTime < new TimeOnly(11, 0))
            {
                return trip with
                {
                    TimeProfileIndex = 5,
                };
            }

            if (new TimeOnly(11, 0) < trip.StartTime && trip.StartTime < new TimeOnly(17, 20))
            {
                return trip with
                {
                    TimeProfileIndex = 6,
                };
            }

            if (new TimeOnly(17, 20) < trip.StartTime)
            {
                return trip with
                {
                    TimeProfileIndex = 5,
                };
            }
        }

        if (trip.RouteIndex.Equals(5))
        {
            if (trip.StartTime == new TimeOnly(5, 41))
            {
                return trip with
                {
                    TimeProfileIndex = 3,
                };
            }

            if (new TimeOnly(8, 40) < trip.StartTime && trip.StartTime < new TimeOnly(11, 40))
            {
                return trip with
                {
                    TimeProfileIndex = 4,
                };
            }

            if (new TimeOnly(11, 40) < trip.StartTime && trip.StartTime < new TimeOnly(17, 40))
            {
                return trip with
                {
                    TimeProfileIndex = 5,
                };
            }

            if (new TimeOnly(17, 40) < trip.StartTime)
            {
                return trip with
                {
                    TimeProfileIndex = 4,
                };
            }
        }

        if (trip.RouteIndex.Equals(6))
        {
            if (trip.StartTime < new TimeOnly(13, 40))
            {
                return trip with
                {
                    TimeProfileIndex = 4,
                };
            }

            if (new TimeOnly(13, 40) < trip.StartTime)
            {
                return trip with
                {
                    TimeProfileIndex = 5,
                };
            }
        }

        return trip;
    }

    private static Line.TripCreate TransformWeekdayToKlinikum(Line.TripCreate trip)
    {
        if (trip.RouteIndex.Equals(0) && trip.StartTime == new TimeOnly(5, 7))
        {
            return trip with
            {
                TimeProfileIndex = 4,
                StartTime = new TimeOnly(5, 8),
            };
        }

        if (trip.RouteIndex.Equals(0) && trip.StartTime > new TimeOnly(6, 0) &&
            trip.StartTime < new TimeOnly(20, 0))
        {
            return trip with
            {
                TimeProfileIndex = trip.StartTime < new TimeOnly(12, 0) ? 5 : 6,
                StartTime = trip.StartTime.AddMinutes(trip.StartTime > new TimeOnly(15, 0) ? 0 :
                    trip.StartTime > new TimeOnly(7, 0) ? -1 : -2),
            };
        }

        if (trip.RouteIndex.Equals(1) && trip.StartTime == new TimeOnly(5, 55))
        {
            return trip with
            {
                TimeProfileIndex = 3,
                StartTime = new TimeOnly(5, 56),
            };
        }

        if (trip.RouteIndex.Equals(1) && trip.StartTime > new TimeOnly(6, 20) &&
            trip.StartTime < new TimeOnly(10, 30))
        {
            return trip with
            {
                TimeProfileIndex = 4,
                StartTime = trip.StartTime.AddMinutes(
                    trip.StartTime > new TimeOnly(7, 0) && trip.StartTime < new TimeOnly(8, 30) ? -1 : -2),
            };
        }

        if (trip.RouteIndex.Equals(1) && ((trip.StartTime > new TimeOnly(10, 30) &&
                                           trip.StartTime < new TimeOnly(12, 0)) ||
                                          (trip.StartTime > new TimeOnly(16, 30) &&
                                           trip.StartTime < new TimeOnly(20, 0))))
        {
            return trip with
            {
                TimeProfileIndex = 5,
            };
        }

        if (trip.RouteIndex.Equals(1) && trip.StartTime > new TimeOnly(12, 0) &&
            trip.StartTime < new TimeOnly(16, 30))
        {
            return trip with
            {
                TimeProfileIndex = 6,
                StartTime = trip.StartTime.AddMinutes(trip.StartTime < new TimeOnly(14, 30) ? -1 : 0),
            };
        }

        if (trip.RouteIndex.Equals(2) && trip.StartTime == new TimeOnly(7, 9))
        {
            return trip with
            {
                StartTime = new TimeOnly(7, 8),
            };
        }

        if (trip.RouteIndex.Equals(3) && trip.StartTime < new TimeOnly(11, 0))
        {
            return trip with
            {
                TimeProfileIndex = 2,
                StartTime = trip.StartTime.AddMinutes(-2),
            };
        }

        if (trip.RouteIndex.Equals(3) && trip.StartTime > new TimeOnly(11, 0))
        {
            return trip with
            {
                TimeProfileIndex = 3,
            };
        }

        return trip;
    }

    private static Line.TripCreate TransformWeekend(Line.TripCreate trip)
    {
        if (trip.RouteIndex.Equals(0) && trip.StartTime < new TimeOnly(9, 0))
        {
            return trip with
            {
                TimeProfileIndex = 4,
            };
        }

        if (trip.RouteIndex.Equals(1) && trip.StartTime < new TimeOnly(10, 0) && trip.StartTime > new TimeOnly(1, 0))
        {
            return trip with
            {
                TimeProfileIndex = 3,
            };
        }

        if (trip.RouteIndex.Equals(1) && trip.StartTime > new TimeOnly(10, 0) && trip.StartTime < new TimeOnly(19, 50))
        {
            return trip with
            {
                TimeProfileIndex = 5,
            };
        }

        if (trip.RouteIndex.Equals(3) && trip.StartTime < new TimeOnly(10, 0))
        {
            return trip with
            {
                TimeProfileIndex = 4,
            };
        }

        if (trip.RouteIndex.Equals(3) && trip.StartTime > new TimeOnly(10, 0))
        {
            return trip with
            {
                TimeProfileIndex = 3,
            };
        }

        return trip;
    }
}
