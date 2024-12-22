namespace Timetables.Vip.Lines.Bus638;

internal class Bus638 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new Bus638From20241214()];
}
