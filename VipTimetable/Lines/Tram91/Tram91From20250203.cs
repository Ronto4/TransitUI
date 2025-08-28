using Timetable;

namespace VipTimetable.Lines.Tram91;

public class Tram91From20250203 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 2, 3);
    private static Tram91From20241215 Original { get; } = new();

    public Line Line { get; } = Original.Line with
    {
        TripsCreate =
        [
            ..Original.Line.TripsCreate,
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(8, 36),
            },
            new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(13, 5),
            },
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(0, 40),
            },
        ],
    };
}
