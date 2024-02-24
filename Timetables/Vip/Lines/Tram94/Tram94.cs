namespace Timetables.Vip.Lines.Tram94;

internal class Tram94 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [
        new Tram94From20240102(),
        new Tram94From20240205(),
        new Tram94From20240211(),
    ];
}
