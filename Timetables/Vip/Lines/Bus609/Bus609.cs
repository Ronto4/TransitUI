namespace Timetables.Vip.Lines.Bus609;

internal class Bus609 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new Bus609From20241214()];
}
