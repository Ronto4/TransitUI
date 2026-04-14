namespace VipTimetable.Lines.BusX15;

public class BusX15From20251011Until20260402 : BusX15Winter, ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 10, 11);
    public DateOnly? ValidUntilInclusive() => new DateOnly(2026, 3, 2);
}
