namespace VipTimetable.Lines.Bus697;

internal class Bus697 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new Bus697From20241214()];
}
