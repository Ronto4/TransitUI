namespace Timetables.Vip.Lines.Tram96;

internal class Tram96 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new Tram96From20240102()];
}
