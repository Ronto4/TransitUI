using Timetables.Models;

namespace Timetables.Vip.Lines.Tram96;

public class Tram96From20241104 : ILineInstance
{
    private static readonly Tram96From20240102 Original = new();
    public DateOnly ValidFrom { get; } = new(2024, 11, 4);

    public Line Line { get; } = Original.Line with
    {
        Routes = Original.Line.Routes.Select(route => route.WithoutStop(Stops.ReiterwegAlleestr)).ToArray(),
    };
}