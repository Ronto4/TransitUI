namespace VipTimetable.Lines.BusX5;

internal class BusX5 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } =
        [new BusX5From20241214Until20241220(), new BusX5From20250106()];
}
