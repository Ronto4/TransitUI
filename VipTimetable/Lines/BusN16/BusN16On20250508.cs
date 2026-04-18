using Timetable;

namespace VipTimetable.Lines.BusN16;

public class BusN16On20250508 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 5, 8);
    public DateOnly? ValidUntilInclusive() => ValidFrom;

    private static BusN16On20250308 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        TripsCreate = Previous.Line.TripsCreate
            .Select(trip => trip.StartTime == new TimeOnly(4, 33) ? trip with { RouteIndex = 2 } :
                trip.RouteIndex.Equals(7) ? trip with { DaysOfOperation = DaysOfOperation.Daily } : trip).ToArray(),
    };
}
