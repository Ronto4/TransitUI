namespace Timetables.Models;

public interface IHistoryEntry
{
    public DateOnly EffectiveDate { get; }
    public IReadOnlyDictionary<string, Line> LinesById { get; }
    public string Description { get; }
}
