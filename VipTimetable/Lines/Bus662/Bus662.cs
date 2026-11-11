namespace VipTimetable.Lines.Bus662;

internal class Bus662 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new Bus662From20250804()];
}