using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Tram99;

public class Tram99From20250203 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 2, 3);
    private static Tram99From20241215 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        Routes =
        [
            Previous.Line.Routes[0] with
            {
                TimeProfiles =
                [
                    ..Previous.Line.Routes[0].TimeProfiles,
                    new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M1, M1, M2, M2, M1, M1, M2,], },
                ],
            },
            ..Previous.Line.Routes[1..]
        ],
        TripsCreate = Previous.Line.TripsCreate.SelectMany(trip =>
        {
            Line.TripCreate[]? returnTrips = null;
            if (trip.RouteIndex.Equals(0) &&
                (new TimeOnly(7, 12) <= trip.StartTime && trip.StartTime <= new TimeOnly(7, 53) ||
                 new TimeOnly(13, 32) <= trip.StartTime && trip.StartTime <= new TimeOnly(16, 33)))
            {
                returnTrips =
                [
                    trip with
                    {
                        StartTime = trip.StartTime.AddMinutes(-1),
                        TimeProfileIndex = 1
                    },
                ];
            }

            else if (trip.RouteIndex.Equals(2) && trip.StartTime == new TimeOnly(19, 13))
            {
                returnTrips =
                [
                    trip with
                    {
                        RouteIndex = 0,
                        TimeProfileIndex = 0,
                    },
                ];
            }

            else if (trip.RouteIndex.Equals(1) && trip.StartTime == new TimeOnly(19, 36))
            {
                returnTrips =
                [
                    trip with
                    {
                        DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.School,
                        RouteIndex = 2,
                        TimeProfileIndex = 0,
                    },
                    trip with
                    {
                        DaysOfOperation = trip.DaysOfOperation & (DaysOfOperation.Holiday | DaysOfOperation.Weekend),
                    },
                ];
            }

            else if (trip.RouteIndex.Equals(5) && trip.StartTime == new TimeOnly(19, 15))
            {
                returnTrips =
                [
                    trip with
                    {
                        RouteIndex = 3,
                        StartTime = trip.StartTime.AddMinutes(11),
                        TimeProfileIndex = 0,
                    },
                ];
            }

            return returnTrips ?? [trip];
        }).ToArray(),
    };
}
