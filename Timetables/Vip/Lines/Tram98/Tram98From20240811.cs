using Timetables.Models;

namespace Timetables.Vip.Lines.Tram98;

public class Tram98From20240811 : ILineInstance
{
    private static readonly Tram98From20240226 Original = new();
    public DateOnly ValidFrom { get; } = new(2024, 8, 11);
    public Line Line { get; } = Original.Line;
}
