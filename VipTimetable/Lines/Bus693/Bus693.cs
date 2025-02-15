namespace VipTimetable.Lines.Bus693;

internal class Bus693 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new Bus693From20241214()];
}