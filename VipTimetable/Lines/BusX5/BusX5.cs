namespace VipTimetable.Lines.BusX5;

internal class BusX5 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } =
    [
        new BusX5From20241214Until20241220(), new BusX5From20250106(), new BusX5From20250203(),
        new BusX5From20250210Until20250404(), new BusX5On20250502(), new BusX5On20250530(),
        new BusX5From20250721Until20251010(), new BusX5From20260209Until20260410(),
    ];
}
