using Timetable.Models;

namespace Timetable.Vip.Lines.BusX5;

public class BusX5From20250106 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 1, 6);
    public Line Line { get; } = new BusX5From20241214Until20241220().Line;
}