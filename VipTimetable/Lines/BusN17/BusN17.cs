namespace VipTimetable.Lines.BusN17;

internal class BusN17 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new BusN17From20241214(), new BusN17From20241215()];
}
