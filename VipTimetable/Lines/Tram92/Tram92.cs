namespace VipTimetable.Lines.Tram92;

internal class Tram92 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } =
    [
        new Tram92From20240102(), new Tram92From20240422(), new Tram92From20240606(), new Tram92From20240608(),
        new Tram92From20240610(), new Tram92From20240816Until20240818(), new Tram92From20240921Until20240922(),
        new Tram92From20240923(), new Tram92From20241012Until20241013(), new Tram92From20241104(),
        new Tram92From20241215(), new Tram92From20250110Until20250112(),
    ];
}
