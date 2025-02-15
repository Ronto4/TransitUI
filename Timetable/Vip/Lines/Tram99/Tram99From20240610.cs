using Timetable.Models;

namespace Timetable.Vip.Lines.Tram99;

public class Tram99From20240610 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 6, 10);
    public Line Line { get; } = new Tram99From20240102().Line;
}
