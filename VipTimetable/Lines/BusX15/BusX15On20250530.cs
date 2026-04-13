using Timetable;

namespace VipTimetable.Lines.BusX15;

public class BusX15On20250530 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 5, 30);
    private static BusX15From20250418 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        TripsCreate = Previous.Line.TripsCreate
            .Select(trip => trip with { DaysOfOperation = DaysOfOperation.HolidayFriday }).ToArray(),
    };
}
