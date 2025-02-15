using Timetable.Models;

namespace VipTimetable.Lines.Tram94;

public class Tram94From20241104 : ILineInstance
{
    private static readonly Tram94From20240211 Original = new();
    public DateOnly ValidFrom { get; } = new(2024, 11, 4);

    public Line Line { get; } = Original.Line;
}