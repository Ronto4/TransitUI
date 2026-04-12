namespace VipTimetable.Lines.BusX15;

internal class BusX15 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new BusX15From20250418(), new BusX15On20250502()];
}
