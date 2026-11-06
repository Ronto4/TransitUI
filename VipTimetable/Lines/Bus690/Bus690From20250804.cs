using Timetable;

namespace VipTimetable.Lines.Bus690;

public class Bus690From20250804 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 8, 4);
    private static Bus690From20241214 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        TripsCreate = Previous.Line.TripsCreate
            .Where(trip => !Data.MissingStartingHbf.Contains(trip.StartTime))
            .Where(trip => !Data.MissingStartingStern.Contains(trip.StartTime))
            .Select(trip =>
                trip.RouteIndex.Equals(0) &&
                (trip.StartTime > new TimeOnly(20, 0) || trip.StartTime < new TimeOnly(2, 0))
                    ? trip with { StartTime = trip.StartTime.AddMinutes(-4) }
                    : trip)
            .Select(trip =>
                trip.RouteIndex.Equals(1) &&
                (trip.StartTime > new TimeOnly(21, 0) || trip.StartTime < new TimeOnly(2, 0))
                    ? trip with { StartTime = trip.StartTime.AddMinutes(-4) }
                    : trip)
            .Select(trip => trip.RouteIndex.Equals(0) && Data.NoContinues.Contains(trip.StartTime)
                ? trip with { Connections = [] }
                : trip)
            .Select(trip => trip.RouteIndex.Equals(1) && Data.NoComes.Contains(trip.StartTime)
                ? trip with { Connections = [] }
                : trip)
            .ToArray(),
    };
}

file static class Data
{
    public static TimeOnly[] MissingStartingHbf { get; } =
        [new(20, 18), new(21, 23), new(22, 23), new(23, 23), new(0, 23)];

    public static TimeOnly[] MissingStartingStern { get; } =
        [new(20, 25), new(21, 24), new(22, 24), new(23, 24), new(0, 44)];

    public static TimeOnly[] NoContinues { get; } =
        [new(19, 58), new(20, 59), new(21, 59), new(22, 59), new(0, 39), new(0, 59)];

    public static TimeOnly[] NoComes { get; } =
        [new(20, 45), new(21, 40), new(22, 40), new(23, 40)];
}
