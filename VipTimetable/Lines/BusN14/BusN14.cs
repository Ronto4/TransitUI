namespace VipTimetable.Lines.BusN14;

internal class BusN14 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new BusN14From20241214(), new BusN14From20250203()];
}
