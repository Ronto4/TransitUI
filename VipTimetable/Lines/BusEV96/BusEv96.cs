namespace VipTimetable.Lines.BusEV96;

internal class BusEv96 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } =
        [new BusEv96From20250110Until20250112(), new BusEv96From20250120Until20250124()];
}
