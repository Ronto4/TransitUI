namespace Timetable;

/// <summary>
/// One point in time of the network with all of the lines available from <see cref="EffectiveFrom"/>.
/// </summary>
public interface IHistoryEntry
{
    // TODO: I don't think this note works as of now.
    /// <summary>
    /// The first day on which the lines listed here are running.
    /// <br/><br/>
    /// Note: <see cref="LineOperationTime.Nighttime"/> only lines switch to the new timetable in the evening of this day.
    /// </summary>
    public DateOnly EffectiveFrom { get; }

    /// <summary>
    /// Indicate whether this history entry is valid
    /// also for all dates following <see cref="EffectiveFrom"/> (<see cref="ValidityMode.Regular"/>)
    /// or only for <see cref="EffectiveFrom"/> (<see cref="ValidityMode.OnlyOnThisDay"/>).
    /// </summary>
    public ValidityMode ValidityMode { get; }

    /// <summary>
    /// All lines, indexed by their ID.
    /// </summary>
    public IReadOnlyDictionary<string, Line> LinesById { get; }

    /// <summary>
    /// All lines ordered by their <see cref="LineOrdering.NaturalCustomerLineComparer"/>.
    /// </summary>
    public IEnumerable<KeyValuePair<string, Line>> OrderedLinesById =>
        LinesById.OrderBy(entry => entry.Value, new LineOrdering.NaturalCustomerLineComparer());

    /// <summary>
    /// A short text detailing the changes since the last <see cref="IHistoryEntry"/>,
    /// to be rendered above the line overview.
    /// </summary>
    /// <remarks>This field supports HTML rendering.</remarks>
    public string Description { get; }
}
