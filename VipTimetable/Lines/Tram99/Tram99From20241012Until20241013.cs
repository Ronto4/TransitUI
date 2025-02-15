using Timetable.Models;

namespace VipTimetable.Lines.Tram99;

public class Tram99From20241012Until20241013 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 10, 12);
    public DateOnly? ValidUntilInclusive() => new(2024, 10, 13);
    public Line Line { get; } = new Tram99From20240608().Line;
}