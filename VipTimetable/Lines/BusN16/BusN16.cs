namespace VipTimetable.Lines.BusN16;

internal class BusN16 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } =
    [
        new BusN16From20241214(), new BusN16From20241215(), new BusN16From20250203(), new BusN16On20250308(),
        new BusN16On20250508()
    ];
}
