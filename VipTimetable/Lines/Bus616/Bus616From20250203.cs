using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus616;

public class Bus616From20250203 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 2, 3);
    private static Bus616From20241214 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        Routes =
        [
            Previous.Line.Routes[0], Previous.Line.Routes[1] with
            {
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                        { StopDistances = [M1, M1, M1, M1, M2, M1, M1, M1, M1, M1, M2, M0, M1, M1,], },
                ],
            },
        ],
        TripsCreate = Previous.Line.TripsCreate.Select(trip =>
        {
            ReadOnlySpan<TimeOnly> cancelledTowardsGriebnitzsee =
            [
                new(6, 53), new(7, 33), new(8, 13), new(8, 53), new(13, 33), new(14, 13), new(14, 53), new(15, 33),
                new(16, 13)
            ];
            ReadOnlySpan<TimeOnly> cancelledTowardsBabelsberg =
            [
                new(7, 14), new(7, 54), new(8, 34), new(13, 14), new(13, 54), new(14, 34), new(15, 14), new(15, 54),
                new(16, 34),
            ];
            if (trip.RouteIndex.Equals(0) && cancelledTowardsGriebnitzsee.Contains(trip.StartTime) ||
                trip.RouteIndex.Equals(1) && cancelledTowardsBabelsberg.Contains(trip.StartTime))
                return trip with
                {
                    DaysOfOperation = trip.DaysOfOperation & (DaysOfOperation.School | DaysOfOperation.Weekend)
                };
            return trip;
        }).Where(trip => trip.DaysOfOperation is not DaysOfOperation.None).ToArray(),
    };
}
