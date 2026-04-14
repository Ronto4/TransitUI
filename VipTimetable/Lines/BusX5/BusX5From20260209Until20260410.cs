namespace VipTimetable.Lines.BusX5;

public class BusX5From20260209Until20260410 : BusX5Semesterferien, ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2026, 2, 9);
    public DateOnly? ValidUntilInclusive() => new DateOnly(2026, 4, 10);
}
