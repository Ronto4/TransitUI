using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus605;

public class Bus605From20250203 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 2, 3);
    private static Bus605From20241215 Previous { get; } = new();

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
                            M1, M1, M1, M1, M2, M1, M1, M1, M1, M1, M2, M1, M1, M0, M2, M2, M2, M2, M1, M1, M2, M1, M2,
                            M1, M3,
                        ],
                    },
                ],
            },
            ..Previous.Line.Routes[1..]
        ],
        TripsCreate =
        [
            ..Previous.Line.TripsCreate.Where(trip =>
            {
                if (trip.RouteIndex.Equals(1) && new TimeOnly(7, 52) <= trip.StartTime &&
                    trip.StartTime <= new TimeOnly(13, 54))
                {
                    return false;
                }

                if (trip.RouteIndex.Equals(1) && trip.StartTime > new TimeOnly(16, 40))
                {
                    return false;
                }

                if (trip.RouteIndex.Equals(0) && trip.DaysOfOperation == DaysOfOperation.School)
                {
                    return false;
                }

                if (trip.RouteIndex.Equals(5) && new TimeOnly(8, 10) <= trip.StartTime &&
                    trip.StartTime <= new TimeOnly(14, 30))
                {
                    return false;
                }

                if (trip.RouteIndex.Equals(5) && trip.StartTime >= new TimeOnly(17, 10))
                {
                    return false;
                }

                return true;
            }).SelectMany(trip =>
            {
                Line.TripCreate[]? returnTrips = null;
                if (trip.RouteIndex.Equals(0) && new TimeOnly(7, 0) <= trip.StartTime &&
                    trip.StartTime <= new TimeOnly(10, 0))
                {
                    var startTimeDiffMinutes = trip.StartTime < new TimeOnly(9, 0) ? -1 : -3;
                    returnTrips =
                    [
                        trip with
                        {
                            DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekday,
                            TimeProfileIndex = 4,
                            StartTime = trip.StartTime.AddMinutes(startTimeDiffMinutes),
                        },
                        trip with
                        {
                            DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekend,
                        },
                    ];
                }
                else if (trip.RouteIndex.Equals(0) && new TimeOnly(13, 10) <= trip.StartTime &&
                         trip.StartTime <= new TimeOnly(17, 30))
                {
                    var startTimeDiffMinutes =
                        trip.StartTime > new TimeOnly(14, 30) && trip.StartTime < new TimeOnly(16, 40) ? -1 : -3;
                    returnTrips =
                    [
                        trip with
                        {
                            DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekday,
                            TimeProfileIndex = 4,
                            StartTime = trip.StartTime.AddMinutes(startTimeDiffMinutes),
                        },
                        trip with
                        {
                            DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekend,
                        },
                    ];
                }

                else if (trip.RouteIndex.Equals(1) && new TimeOnly(14, 0) <= trip.StartTime &&
                         trip.StartTime <= new TimeOnly(14, 40))
                {
                    returnTrips =
                    [
                        trip with
                        {
                            DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekday,
                            TimeProfileIndex = 1,
                            StartTime = trip.StartTime.AddMinutes(-2),
                        },
                        trip with
                        {
                            DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekend,
                        },
                    ];
                }

                else if (trip.RouteIndex.Equals(4) && trip.StartTime == new TimeOnly(10, 4))
                {
                    returnTrips =
                    [
                        trip with
                        {
                            DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekday,
                        },
                        trip with
                        {
                            DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekend,
                            TimeProfileIndex = 1,
                        },
                    ];
                }

                return returnTrips ?? [trip];
            }).Where(trip => trip.DaysOfOperation is not DaysOfOperation.None),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 4,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(7, 50),
            }.AlsoEvery(M20, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 4,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(16, 50),
            }.AlsoEvery(M20, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(13, 34),
            }.AlsoEvery(M20, 3),
        ],
    };
}
