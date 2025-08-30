using Timetable;

namespace VipTimetable.Lines.Bus639;

public class Bus639From20250203 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 2, 3);
    private static Bus639From20241214 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        TripsCreate = Previous.Line.TripsCreate.Select(trip => trip with { DaysOfOperation = DaysOfOperation.School })
            .ToArray(),
    };
}
