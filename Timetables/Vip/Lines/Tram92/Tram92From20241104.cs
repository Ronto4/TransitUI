using Timetables.Models;

namespace Timetables.Vip.Lines.Tram92;

public class Tram92From20241104 : ILineInstance
{
    private static readonly Tram92From20240422 Original = new();
    public DateOnly ValidFrom { get; } = new(2024, 11, 4);

    public Line Line { get; } = Original.Line with
    {
        Routes = Original.Line.Routes.Select(route => route.WithoutStop(Stops.ReiterwegAlleestr)).ToArray(),
    };
}