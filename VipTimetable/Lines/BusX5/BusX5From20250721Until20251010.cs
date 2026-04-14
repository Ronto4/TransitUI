namespace VipTimetable.Lines.BusX5;

public class BusX5From20250721Until20251010 : BusX5Semesterferien, ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 7, 21);
    public DateOnly? ValidUntilInclusive() => new DateOnly(2025, 10, 10);
}
