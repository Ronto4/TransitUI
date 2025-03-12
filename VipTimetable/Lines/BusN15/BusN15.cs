namespace VipTimetable.Lines.BusN15;

internal class BusN15 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new BusN15From20241214()];
}
