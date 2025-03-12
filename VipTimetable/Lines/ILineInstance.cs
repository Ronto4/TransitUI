using Timetable;

namespace VipTimetable.Lines;

internal interface ILineInstance
{
    public DateOnly ValidFrom { get; }
    public DateOnly? ValidUntilInclusive() => null;
    public Line Line { get; }
}
