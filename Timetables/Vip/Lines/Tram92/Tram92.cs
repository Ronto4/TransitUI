namespace Timetables.Vip.Lines.Tram92;

internal class Tram92 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new Tram92From20240102()];
}
