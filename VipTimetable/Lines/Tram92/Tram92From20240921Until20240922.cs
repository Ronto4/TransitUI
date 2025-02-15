using Timetable;

namespace VipTimetable.Lines.Tram92;

public class Tram92From20240921Until20240922 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 9, 21);
    public DateOnly? ValidUntilInclusive() => new(2024, 9, 22);
    public Line Line { get; } = new Tram92From20240608().Line;
}
