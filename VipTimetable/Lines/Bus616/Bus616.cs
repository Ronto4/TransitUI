namespace VipTimetable.Lines.Bus616;

internal class Bus616 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new Bus616From20241214(), new Bus616From20250203()];
}
