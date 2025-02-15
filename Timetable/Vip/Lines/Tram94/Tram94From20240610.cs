using Timetable.Models;

namespace Timetable.Vip.Lines.Tram94;

public class Tram94From20240610 : ILineInstance
{
    private static readonly Tram94From20240211 Original = new();
    public DateOnly ValidFrom { get; } = new(2024, 6, 10);

    public Line Line { get; } = Original.Line with
    {
        TripsCreate =
        [
            ..Original.Line.TripsCreate.Where(tripCreate =>
                tripCreate.RouteIndex.Value != 2 && tripCreate.RouteIndex.Value != 5)
        ]
    };
}
