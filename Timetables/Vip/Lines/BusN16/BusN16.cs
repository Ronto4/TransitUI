namespace Timetables.Vip.Lines.BusN16;

internal class BusN16 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new BusN16From20241214()];
}