namespace VipTimetable.Lines.Bus696;

internal class Bus696 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new Bus696From20241214()];
}