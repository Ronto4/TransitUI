using Timetable;

namespace VipTimetable.Lines.Tram94;

public class Tram94From20241021Until20241102 : ILineInstance
{
    private static readonly Tram94From20240610 Original = new();
    public DateOnly ValidFrom { get; } = new(2024, 10, 21);
    public DateOnly? ValidUntilInclusive() => new(2024, 11, 2);

    public Line Line { get; } = Original.Line with
    {
        Routes = Original.Line.Routes.Select(route => route.WithoutStop(Stops.LuisenplatzSüdParkSanssouci)).ToArray(),
    };
}
