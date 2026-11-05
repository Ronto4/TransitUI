using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.BusN15;

public class BusN15From20250203 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 2, 3);
    private static BusN15From20241215 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        Routes =
        [
            Previous.Line.Routes[0],
            Previous.Line.Routes[1] with
            {
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M2, M1, M1, M1, M1, M0, M1, M1, M1, M2, M1, M1, M1, M1, M1, M2, M1,],
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
                            M3, M1, M1, M1, M1, M1, M1, M2, M1, M1, M0, M1, M1, M1, M2, M2, M1, M1, M1, M1, M1, M1, M1,
                            M2,
                        ],
                    },
                ],
            },
            ..Previous.Line.Routes[3..4],
            Previous.Line.Routes[4] with
            {
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M2, M1, M1, M1, M1, M1, M2, M2,],
                    },
                ],
            },
            ..Previous.Line.Routes[5..],
        ],
        TripsCreate = Previous.Line.TripsCreate.Select(trip =>
            trip.RouteIndex.Equals(0) || trip.RouteIndex.Equals(1)
                ? trip with { StartTime = trip.StartTime.AddMinutes(-2) }
                : trip.RouteIndex.Equals(4)
                    ? trip with { StartTime = trip.StartTime.AddMinutes(-1), }
                    : trip).ToArray(),
    };
}
