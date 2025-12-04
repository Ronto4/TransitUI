namespace VipTimetable.Lines.Tram96;

internal class Tram96 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } =
    [
        new Tram96From20240102(), new Tram96From20240606(), new Tram96From20240608(), new Tram96From20240610(),
        new Tram96From20240816Until20240818(), new Tram96From20240921Until20240922(),
        new Tram96From20241012Until20241013(), new Tram96From20241104(), new Tram96From20241215(),
        new Tram96From20250110Until20250112(), new Tram96From20250120Until20250124(), new Tram96From20250203(),
    ];
}
