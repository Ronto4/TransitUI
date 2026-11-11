using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus699;

public class Bus699From20250804 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 8, 4);
    private static Bus699From20250203 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        TripsCreate = Previous.Line.TripsCreate.Select(trip =>
            trip.RouteIndex.Equals(2) && trip.StartTime > new TimeOnly(20, 30)
                ? trip with
                {
                    Connections =
                    [
                        new Line.TripCreate.Connection
                        {
                            ConnectingLineIdentifier = "bus694",
                            ConnectingRouteIndex = Data.From694RouteIds[trip.StartTime],
                            Delay = M0,
                            Type = Line.Trip.ConnectionType.ComesAs,
                        },
                    ],
                }
                : trip).ToArray(),
    };
}

file static class Data
{
    public static Dictionary<TimeOnly, Index> From694RouteIds { get; } = new()
    {
        [new TimeOnly(20, 54)] = 23,
        [new TimeOnly(21, 14)] = 22,
        [new TimeOnly(21, 54)] = 23,
        [new TimeOnly(22, 54)] = 25,
        [new TimeOnly(23, 54)] = 25,
    };
}
