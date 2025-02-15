using Timetable.Models;

namespace Timetable.Vip.Lines.Tram91;

public class Tram91From20241104 : ILineInstance
{
    private static readonly Tram91From20240211 Original = new();
    public DateOnly ValidFrom { get; } = new(2024, 11, 4);

    public Line Line { get; } = Original.Line;
}