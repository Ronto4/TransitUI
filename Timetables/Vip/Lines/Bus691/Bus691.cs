namespace Timetables.Vip.Lines.Bus691;

internal class Bus691 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new Bus691From20241214()];
}
