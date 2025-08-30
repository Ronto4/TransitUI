namespace VipTimetable.Lines.Bus638;

internal class Bus638 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } =
        [new Bus638From20241214(), new Bus638From20241215(), new Bus638From20250203()];
}
