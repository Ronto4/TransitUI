namespace VipTimetable.Lines.Bus690;

internal class Bus690 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new Bus690From20241214()];
}