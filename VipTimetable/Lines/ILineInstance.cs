using Timetable;

namespace VipTimetable.Lines;

internal interface ILineInstance
{
    public DateOnly ValidFrom { get; }

    public DateOnly? ValidUntilInclusive() => null;

    public ValidityMode ValidityMode() => ValidUntilInclusive() is null ? Timetable.ValidityMode.Regular : Timetable.ValidityMode.Temporary;
    public Line Line { get; }
}
