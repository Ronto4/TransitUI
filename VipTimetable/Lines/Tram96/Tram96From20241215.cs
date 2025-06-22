using Timetable;

namespace VipTimetable.Lines.Tram96;

public class Tram96From20241215 : ILineInstance
{
    private static readonly Tram96From20240102 Original = new();
    public DateOnly ValidFrom { get; } = new(2024, 12, 15);

    public Line Line { get; } = Original.Line with
    {
        TripsCreate = Original.Line.TripsCreate.SelectMany<Line.TripCreate, Line.TripCreate>(trip =>
            trip.RouteIndex.Equals(0) && trip.StartTime == new TimeOnly(10, 3)
                ?
                [
                    trip with { DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekday },
                    trip with { DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekend, TimeProfileIndex = 1 }
                ]
                : trip.RouteIndex.Equals(7) && trip.StartTime == new TimeOnly(5, 20)
                    ? [trip with { StartTime = trip.StartTime.AddMinutes(1) }]
                    : [trip]).ToArray(),
    };
}
