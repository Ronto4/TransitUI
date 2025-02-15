using Timetable.Models;

namespace VipTimetable.Lines.Tram98;

internal class Tram98From20240211 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 2, 11);
    public Line Line { get; } = new Tram98From20240102().Line;
}
