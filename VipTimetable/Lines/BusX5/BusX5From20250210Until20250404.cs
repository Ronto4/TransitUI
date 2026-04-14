namespace VipTimetable.Lines.BusX5;

public class BusX5From20250210Until20250404 : BusX5Semesterferien, ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 2, 10);
    public DateOnly? ValidUntilInclusive() => new DateOnly(2025, 4, 4);
}