using Timetable;

namespace VipTimetable.Lines.Tram91;

public class Tram91From20241215 : ILineInstance
{
    private static readonly Tram91From20241104 Original = new();
    public DateOnly ValidFrom { get; } = new(2024, 12, 15);

    public Line Line { get; } = Original.Line with
    {
        TripsCreate = Original.Line.TripsCreate.Select(tripCreate =>
            tripCreate.StartTime == new TimeOnly(0, 58) &&
            tripCreate.RouteIndex.Equals(4) /* Rehbrücke > Bisamkiez */
                ? tripCreate with { StartTime = new TimeOnly(1, 8) }
                : tripCreate).ToArray(),
    };
}
