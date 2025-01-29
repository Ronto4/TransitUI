namespace Timetables.Vip.Lines.Bus698;

internal class Bus698 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new Bus698From20241214()];
}