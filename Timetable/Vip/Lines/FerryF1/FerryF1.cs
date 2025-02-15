namespace Timetable.Vip.Lines.FerryF1;

internal class FerryF1 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new FerryF1From20241214()];
}