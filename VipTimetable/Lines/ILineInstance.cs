using Timetable;

namespace VipTimetable.Lines;

internal interface ILineInstance
{
    public DateOnly ValidFrom { get; }

    public DateOnly? ValidUntilInclusive() =>
        ValidityMode() is Timetable.ValidityMode.OnlyOnThisDay ? ValidFrom.AddDays(1) : null;

    public ValidityMode ValidityMode() => Timetable.ValidityMode.Regular;
    public Line Line { get; }
}
