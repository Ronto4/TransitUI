namespace Timetables.Vip.Lines.Bus692;

internal class Bus692 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new Bus692From20241214()];
}
