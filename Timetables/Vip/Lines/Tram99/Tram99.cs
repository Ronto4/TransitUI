namespace Timetables.Vip.Lines.Tram99;

internal class Tram99 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } =
    [
        new Tram99From20240102(), new Tram99From20240608(), new Tram99From20240610(), new Tram99From20240816()
    ];
}
