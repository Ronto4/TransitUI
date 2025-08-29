using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Tram94;

public class Tram94From20250203 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 2, 3);
    private static Tram94From20241104 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        Routes =
        [
            ..Previous.Line.Routes[..2],
            Previous.Line.Routes[3] with
            {
                TimeProfiles =
                [
                    ..Previous.Line.Routes[3].TimeProfiles,
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M1, M1, M1, M1, M2, M2, M1, M1, M1, M2, M1, M1, M2, M1, M1, M2, M1, M2, M1, M3,],
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
                            [M1, M1, M1, M1, M1, M2, M2, M1, M1, M1, M2, M1, M1, M2, M1, M1, M2,],
                    },
                ],
            },
            ..Previous.Line.Routes[5..5], ..Previous.Line.Routes[6..]
        ],
        MainRouteIndices = Previous.Line.MainRouteIndices.Select(Helpers.ReduceIndex).ToArray(),
        OverviewRouteIndices = Previous.Line.OverviewRouteIndices.Select(Helpers.ReduceIndex).ToArray(),
        TripsCreate = Previous.Line.TripsCreate.Where(trip => !trip.RouteIndex.Equals(2) && !trip.RouteIndex.Equals(5))
            .Select(trip =>
            {
                trip = trip with
                {
                    RouteIndex = Helpers.ReduceIndex(trip.RouteIndex),
                };
                if (trip.RouteIndex.Equals(2) && (trip.StartTime > new TimeOnly(7, 3) &&
                                                  trip.StartTime < new TimeOnly(9, 0) ||
                                                  trip.StartTime > new TimeOnly(13, 3) &&
                                                  trip.StartTime < new TimeOnly(16, 40)))
                {
                    return trip with
                    {
                        StartTime = trip.StartTime.AddMinutes(-1),
                        TimeProfileIndex = 1,
                    };
                }

                if (trip.RouteIndex.Equals(3) && trip.DaysOfOperation == DaysOfOperation.Holiday &&
                    (trip.StartTime > new TimeOnly(7, 22) && trip.StartTime <= new TimeOnly(8, 3) ||
                     trip.StartTime > new TimeOnly(13, 22) && trip.StartTime <= new TimeOnly(16, 23)))
                {
                    return trip with
                    {
                        StartTime = trip.StartTime.AddMinutes(-1),
                        TimeProfileIndex = 2,
                    };
                }

                return trip;
            }).ToArray()
    };
}

file static class Helpers
{
    public static Index ReduceIndex(Index index) =>
        new(index.Value > 5 ? index.Value - 2 : index.Value > 2 ? index.Value - 1 : index.Value);
}
