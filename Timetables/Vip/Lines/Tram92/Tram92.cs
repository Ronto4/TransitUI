namespace Timetables.Vip.Lines.Tram92;

internal class Tram92 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } =
    [
        new Tram92From20240102(), new Tram92From20240422(), new Tram92From20240606(), new Tram92From20240608(),
        new Tram92From20240610(), new Tram92From20240816(),
    ];
}
