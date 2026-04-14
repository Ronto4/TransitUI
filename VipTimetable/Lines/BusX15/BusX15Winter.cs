using Timetable;

namespace VipTimetable.Lines.BusX15;

public class BusX15Winter
{
    public Line Line { get; } = new BusX15From20250418().Line with { TripsCreate = [] };
}
