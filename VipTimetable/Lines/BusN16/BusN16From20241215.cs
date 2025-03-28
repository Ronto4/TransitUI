using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.BusN16;

public class BusN16From20241215 : ILineInstance
{
    private static readonly BusN16From20241214 Previous = new();
    public DateOnly ValidFrom { get; } = new(2024, 12, 15);

    public Line Line { get; } = Previous.Line with
    {
        TripsCreate = Previous.Line.TripsCreate.Select(trip => trip with
        {
            Connections = trip.Connections.Select(connection => connection with
            {
                Delay = connection.Delay + M2,
            }).ToList()
        }).ToArray(),
    };
}
