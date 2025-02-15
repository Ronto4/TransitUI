namespace VipTimetable.Lines.Bus699;

internal class Bus699 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new Bus699From20241214()];
}