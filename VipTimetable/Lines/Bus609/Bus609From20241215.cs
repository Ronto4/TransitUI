using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus609;

using TPrevious = Bus609From20241214;

public class Bus609From20241215 : Bus609Base<Bus609From20241215>, IBus609Base<Bus609From20241215>, ILineInstance
{
    private static readonly TPrevious Previous = new();

    public static Line.Route[] InstanceRoutes { get; } =
        TPrevious.InstanceRoutes.Select(RemoveDetours).Select(AddStopsMarquardterStr).ToArray();

    private static readonly TimeOnly[] AmUpstallNowFromBhfMarquardt = [new(8, 7), new(18, 7)];
    private static readonly TimeOnly[] JungfernseeNowToBhfMarquardt = [new(7, 33), new(16, 33), new(17, 33)];

    public DateOnly ValidFrom { get; } = new(2024, 12, 15);

    public Line Line { get; } = Previous.Line with
    {
        Routes = InstanceRoutes, TripsCreate = Previous.Line.TripsCreate.Select(trip =>
        {
            if (trip.RouteIndex.Equals(RouteIndex(Routes.UpstallJungfernsee)) &&
                AmUpstallNowFromBhfMarquardt.Contains(trip.StartTime))
            {
                return trip with
                {
                    RouteIndex = TPrevious.RouteIndex(Routes.MarquardtJungfernseeExpress),
                    StartTime = new TimeOnly(trip.StartTime.Ticks - M10.Ticks),
                };
            }

            if (trip.RouteIndex.Equals(RouteIndex(Routes.JungfernseeUpstall)) &&
                JungfernseeNowToBhfMarquardt.Contains(trip.StartTime))
            {
                return trip with
                {
                    RouteIndex = TPrevious.RouteIndex(Routes.JungfernseeMarquardtExpress),
                };
            }

            return trip;
        }).ToArray(),
    };
}
