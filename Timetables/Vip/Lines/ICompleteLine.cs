namespace Timetables.Vip.Lines;

internal interface ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; }

    public ILineInstance? AtTime(DateOnly date) =>
        LineInstances.Where(line => line.ValidFrom <= date).MaxBy(line => line.ValidFrom);
}
