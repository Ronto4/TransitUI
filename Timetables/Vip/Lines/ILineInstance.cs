using Timetables.Models;

namespace Timetables.Vip.Lines;

internal interface ILineInstance
{
    public DateOnly ValidFrom { get; }
    public DateOnly? ValidUntilInclusive() => null;
    public Line Line { get; }
}
