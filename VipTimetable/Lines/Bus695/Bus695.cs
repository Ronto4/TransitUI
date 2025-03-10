namespace VipTimetable.Lines.Bus695;

internal class Bus695 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new Bus695From20241214()];
}
