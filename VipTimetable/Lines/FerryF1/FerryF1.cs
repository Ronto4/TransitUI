namespace VipTimetable.Lines.FerryF1;

internal class FerryF1 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new FerryF1From20241214(), new FerryF1From20250418()];
}
