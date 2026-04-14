namespace VipTimetable.Lines.Bus609E;

internal class Bus609E : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new Bus609EOn20250614()];
}
