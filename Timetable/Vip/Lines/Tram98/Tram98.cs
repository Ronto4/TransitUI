namespace Timetable.Vip.Lines.Tram98;

internal class Tram98 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [
        new Tram98From20240102(),
        new Tram98From20240205(),
        new Tram98From20240211(),
        new Tram98From20240226(),
        new Tram98From20240809(),
        new Tram98From20240811(),
        new Tram98From20241021Until20241102(),
    ];
}
