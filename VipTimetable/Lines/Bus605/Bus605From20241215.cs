using Timetable;

namespace VipTimetable.Lines.Bus605;

public class Bus605From20241215 : ILineInstance
{
    private static readonly Bus605From20241214 Previous = new();
    public DateOnly ValidFrom { get; } = new(2024, 12, 15);

    public Line Line { get; } = Previous.Line with
    {
        TripsCreate = Previous.Line.TripsCreate.Select(trip => trip.RouteIndex.Equals(1) || trip.RouteIndex.Equals(5)
            ?
            trip with
            {
                DaysOfOperation = DaysOfOperation.School,
            }
            : new[]
            {
                new TimeOnly(6, 14), new TimeOnly(6, 34), new TimeOnly(6, 54), new TimeOnly(17, 53),
                new TimeOnly(18, 13), new TimeOnly(18, 33)
            }.Contains(trip.StartTime)
                ? trip with { DaysOfOperation = DaysOfOperation.School }
                : trip).ToArray(),
    };
}
