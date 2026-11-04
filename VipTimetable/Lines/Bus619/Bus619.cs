namespace VipTimetable.Lines.Bus619;

internal class Bus619 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new Bus619From20250804()];
}