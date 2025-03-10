namespace VipTimetable.Lines.Bus605;

internal class Bus605 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new Bus605From20241214()];
}
