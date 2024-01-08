using Timetables.Models;

namespace Timetables.Vip.Lines;

internal interface ILineInstance
{
    public DateOnly ValidFrom { get; }
    public Line Line { get; }
}
