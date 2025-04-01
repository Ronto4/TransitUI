using Timetable;

namespace VipTimetable.Lines.Tram96;

public class Tram96From20241215 : ILineInstance
{
    private static readonly Tram96From20240102 Original = new();
    public DateOnly ValidFrom { get; } = new(2024, 12, 15);
    public Line Line { get; } = Original.Line;
}
