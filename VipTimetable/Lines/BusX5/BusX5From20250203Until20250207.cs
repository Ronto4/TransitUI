using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.BusX5;

public class BusX5From20250203Until20250207 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 2, 3);
    public DateOnly? ValidUntilInclusive() => new DateOnly(2025, 2, 7);
    private static BusX5From20250106 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        Routes =
        [
            Previous.Line.Routes[0] with
            {
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                        { StopDistances = [M1, M3, M2, M3, M1, M1, M0, M2, M2, M3, M3, M2, M4,], },
                    new Line.Route.TimeProfile
                        { StopDistances = [M1, M3, M3, M3, M1, M1, M0, M2, M2, M3, M3, M2, M4,], },
                ],
            },
            ..Previous.Line.Routes[1..3]
        ],
        MainRouteIndices = [0, 1, 2],
        TripsCreate = Previous.Line.TripsCreate
            .Select(trip => trip.RouteIndex.Equals(3)
                ? trip with { RouteIndex = 2 }
                : trip.RouteIndex.Equals(0) && trip.StartTime == new TimeOnly(15, 50)
                    ? trip with { TimeProfileIndex = 1 }
                    : trip).ToArray(),
    };
}
