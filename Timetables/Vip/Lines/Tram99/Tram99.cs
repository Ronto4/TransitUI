namespace Timetables.Vip.Lines.Tram99;

internal class Tram99 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new Tram99From20240102()];
}
