namespace Timetable.Models;

public interface IHistoryEntry
{
    public DateOnly EffectiveDate { get; }
    public IReadOnlyDictionary<string, Line> LinesById { get; }

    public IEnumerable<KeyValuePair<string, Line>> OrderedLinesById =>
        LinesById.OrderBy(entry => entry.Value, new LineOrdering.NaturalCustomerLineComparer());

    /// <summary>
    /// A short text, to be rendered above the line overview.
    /// </summary>
    /// <remarks>This field supports HTML rendering.</remarks>
    public string Description { get; }
}
