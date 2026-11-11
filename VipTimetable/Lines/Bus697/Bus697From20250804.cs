using Timetable;

namespace VipTimetable.Lines.Bus697;

public class Bus697From20250804 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 8, 4);
    private static Bus697From20250526 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        MainRouteIndices = [0, 1, 2, 4],
        OverviewRouteIndices = [0, 2],
        Routes =
        [
            ..Previous.Line.Routes[..1],
            // Remove route via Hebbelstr.
            ..Previous.Line.Routes[2..],
        ],
        TripsCreate = Previous.Line.TripsCreate
            .Where(trip => !trip.RouteIndex.Equals(1))
            .Select(trip => trip.DaysOfOperation == DaysOfOperation.Holiday
                ? trip with { DaysOfOperation = DaysOfOperation.Weekday, }
                : trip)
            .Select(trip => trip.RouteIndex.Value > 1 ? trip with { RouteIndex = trip.RouteIndex.Value - 1, } : trip)
            .ToArray(),
    };
}
