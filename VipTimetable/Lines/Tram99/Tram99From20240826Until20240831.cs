using Timetable.Models;

namespace VipTimetable.Lines.Tram99;

public class Tram99From20240826Until20240831 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 8, 26);
    public DateOnly? ValidUntilInclusive() => new(2024, 8, 31);

    public Line Line { get; } = new Tram99From20240610().Line with
    {
        TripsCreate = [],
    };
}
