using System.Collections.Frozen;
using Timetable.Models;

namespace VipTimetable;

public class HistoryEntry : IHistoryEntry
{
    public HistoryEntry(DateOnly fromDate, string description)
    {
        EffectiveDate = fromDate;
        LinesById = new Dictionary<string, Line>(Lines.Lines.LinesById
            .Select(entry => (lineId: entry.Key, Line: entry.Value.AtTime(EffectiveDate)))
            .Where(tuple => tuple.Line is not null)
            .Select(tuple => new KeyValuePair<string, Line>(tuple.lineId, tuple.Line!.Line))).ToFrozenDictionary();
        Description = description;
    }

    public DateOnly EffectiveDate { get; }
    public IReadOnlyDictionary<string, Line> LinesById { get; }
    public string Description { get; }
}
