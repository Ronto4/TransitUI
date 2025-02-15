namespace Timetable.Vip.Lines.Tram99;

internal class Tram99 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } =
    [
        new Tram99From20240102(), new Tram99From20240608(), new Tram99From20240610(), new Tram99From20240816(),
        new Tram99From20240826Until20240831(), new Tram99From20240921Until20240922(),
        new Tram99From20241012Until20241013(),
    ];
}
