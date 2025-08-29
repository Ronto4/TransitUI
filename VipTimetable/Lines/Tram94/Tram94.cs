namespace VipTimetable.Lines.Tram94;

internal class Tram94 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [
        new Tram94From20240102(),
        new Tram94From20240205(),
        new Tram94From20240211(),
        new Tram94From20240610(),
        new Tram94From20240826Until20240831(),
        new Tram94From20241021Until20241102(),
        new Tram94From20241104(),
        new Tram94From20250203(),
    ];
}
