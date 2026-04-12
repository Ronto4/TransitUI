namespace VipTimetable.Lines.Bus612;

internal class Bus612 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } =
        [new Bus612From20241214(), new Bus612From20241215(), new Bus612From20250203()];
}
