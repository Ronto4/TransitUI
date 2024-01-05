namespace Timetables.Models;

public interface IHistoryEntry
{
    public DateOnly EffectiveDate { get; }
    public Line[] Lines { get; }
    public static abstract IHistoryEntry Entry { get; }
}
