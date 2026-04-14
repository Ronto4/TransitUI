using Timetable;

namespace VipTimetable.Lines.FerryF1;

public class FerryF1From20260108Until20260223 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2026, 1, 8);
    public DateOnly? ValidUntilInclusive() => new DateOnly(2026, 2, 23);

    private static FerryF1From20250418 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with { TripsCreate = [], };
}
