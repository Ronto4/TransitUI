using Timetables.Models;

namespace Timetables.Vip.Lines.Tram94;

internal class Tram94From20240211 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 2, 11);
    public Line Line { get; } = new Tram94From20240102().Line;
}
