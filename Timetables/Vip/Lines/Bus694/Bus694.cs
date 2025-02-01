namespace Timetables.Vip.Lines.Bus694;

internal class Bus694 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new Bus694From20241214()];
}