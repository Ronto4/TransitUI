namespace Timetables.Vip.Lines.Tram98;

internal class Tram98 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [
        new Tram98From20240102(),
        new Tram98From20240205(),
        new Tram98From20240211(),
    ];
}
