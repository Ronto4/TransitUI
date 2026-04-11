using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus698;

public class Bus698From20250203 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 2, 3);
    private static Bus698From20241214 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        TripsCreate = Previous.Line.TripsCreate.SelectMany<Line.TripCreate, Line.TripCreate>(trip =>
            trip.StartTime == new TimeOnly(6, 32)
                ?
                [
                    trip with { DaysOfOperation = DaysOfOperation.Saturday },
                    trip with { DaysOfOperation = DaysOfOperation.Sunday, StartTime = new TimeOnly(6, 34) }
                ]
                : [trip]).ToArray(),
    };
}
