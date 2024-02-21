namespace Timetables.Models;

public interface IHistoryEntry
{
    public DateOnly EffectiveDate { get; }
    internal IReadOnlyDictionary<string, Line> LinesById { get; }
    public IEnumerable<KeyValuePair<string, Line>> OrderedLinesById => LinesById.OrderBy(entry => entry.Key);
    public string Description { get; }
}
