using Timetable;

namespace VipTimetable.Lines.Tram92;

public class Tram92From20241012Until20241013 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 10, 12);
    public DateOnly? ValidUntilInclusive() => new(2024, 10, 13);
    public Line Line { get; } = new Tram92From20240608().Line;
}