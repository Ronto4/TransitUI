using Timetable.Models;

namespace Timetable.Vip.Lines.Tram96;

public class Tram96From20240921Until20240922 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 9, 21);
    public DateOnly? ValidUntilInclusive() => new(2024, 9, 22);
    public Line Line { get; } = new Tram96From20240608().Line;
}
