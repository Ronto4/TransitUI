using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus612;

public class Bus612From20250203 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 2, 3);
    private static Bus612From20241215 Previous { get; } = new();

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
                            M1, M1, M0, M1, M2, M1, M1, M2, M2, M2, M1, M3, M1, M1, M1, M1, M2, M1, M1, M1, M1, M1, M2,
                            M3, M3, M2, M1, M2,
                        ],
                    },
                ]
            },
            ..Previous.Line.Routes[1..2],
            Previous.Line.Routes[2] with
            {
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M0, M1, M2, M1, M1, M2, M2, M2, M1, M1, M1, M1, M1, M0, M2, M1, M2, M3, M2, M1, M2,
                            M1,
                        ],
                    },
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
                            M2, M1, M3, M2, M1, M1, M1, M0, M0, M1, M0, M2, M1, M1, M1, M1, M2, M3, M1, M1, M1, M1, M1,
                            M1, M1, M1, M0, M0, M1, M1,
                        ],
                    },
                ],
            },
        ],
        TripsCreate = Previous.Line.TripsCreate.SelectMany(trip =>
        {
            Line.TripCreate[]? returnTrips = null;
            if (trip.RouteIndex.Equals(0) && new TimeOnly(6, 20) <= trip.StartTime &&
                trip.StartTime <= new TimeOnly(9, 0))
            {
                returnTrips =
                [
                    trip with
                    {
                        DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekday,
                        StartTime = trip.StartTime.AddMinutes(-2),
                        TimeProfileIndex = 4,
                    },
                    trip with
                    {
                        DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekend,
                    },
                ];
            }

            else if (trip.RouteIndex.Equals(2))
            {
                returnTrips =
                [
                    trip with
                    {
                        StartTime = trip.StartTime.AddMinutes(-2),
                    }
                ];
            }

            else if (trip.RouteIndex.Equals(3) && trip.StartTime > new TimeOnly(19, 45))
            {
                returnTrips =
                [
                    trip with
                    {
                        TimeProfileIndex = 3,
                    },
                ];
            }

            return returnTrips ?? [trip];
        }).Where(trip => trip.DaysOfOperation is not DaysOfOperation.None).ToArray(),
    };
}
