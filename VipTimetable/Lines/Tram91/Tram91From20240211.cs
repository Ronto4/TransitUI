using Timetable.Models;

namespace VipTimetable.Lines.Tram91;

internal class Tram91From20240211 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 2, 11);
    public Line Line { get; } = new Tram91From20240102().Line;
}
