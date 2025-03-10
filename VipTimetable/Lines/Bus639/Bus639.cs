namespace VipTimetable.Lines.Bus639;

internal class Bus639 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new Bus639From20241214()];
}
