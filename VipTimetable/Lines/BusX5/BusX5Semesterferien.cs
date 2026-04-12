using Timetable;

namespace VipTimetable.Lines.BusX5;

public abstract class BusX5Semesterferien
{
    public Line Line { get; } = new BusX5From20250203().Line with { TripsCreate = [] };
}
