namespace Timetables.Vip.Lines.Bus612;

internal class Bus612 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new Bus612From20241214()];
}