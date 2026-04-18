using Timetable;

namespace VipTimetable.Lines.BusX5;

public class BusX5On20250530 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 5, 30);
    public DateOnly? ValidUntilInclusive() => ValidFrom;

    private static BusX5From20250203 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        TripsCreate = [],
    };
}