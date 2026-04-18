using System.Collections.Frozen;
using Timetable;

namespace VipTimetable;

public class HistoryEntry : IHistoryEntry
{
    public HistoryEntry(DateOnly fromDate, string description) : this(fromDate, null, description)
    {
    }

    public HistoryEntry(DateOnly fromDate, DateOnly? untilDate, string description)
    {
        EffectiveFrom = fromDate;
        EffectiveUntil = untilDate;
        LinesById = new Dictionary<string, Line>(Lines.Lines.LinesById
            .Select(entry => (lineId: entry.Key, Line: entry.Value.AtTime(EffectiveFrom)))
            .Where(tuple => tuple.Line is not null)
            .Select(tuple => new KeyValuePair<string, Line>(tuple.lineId, tuple.Line!.Line))).ToFrozenDictionary();
        Description = description;
    }

    public DateOnly EffectiveFrom { get; }
    public DateOnly? EffectiveUntil { get; }
    public IReadOnlyDictionary<string, Line> LinesById { get; }
    public string Description { get; }
}
