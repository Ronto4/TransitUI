namespace Timetables.Vip.Lines.Tram96;

internal class Tram96 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } =
    [
        new Tram96From20240102(), new Tram96From20240606(), new Tram96From20240608(), new Tram96From20240610(),
        new Tram96From20240816Until20240818(), new Tram96From20240921Until20240922()
    ];
}
