namespace VipTimetable.Lines.Bus603;

internal class Bus603 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [
        new Bus603From20241214(), new Bus603From20241215(),
    ];
}
