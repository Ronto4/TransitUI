namespace Timetable;

/// <summary>
/// The entrypoint for a timetable, containing all historic data about the network.
/// </summary>
public interface IHistory<TSelf> where TSelf : IHistory<TSelf>
{
    /// <summary>
    /// The historic data about the network.
    /// </summary>
    public static abstract IHistoryEntry[] History { get; }

    /// <summary>
    /// Returns the <see cref="IHistoryEntry"/> valid at the given <paramref name="date"/>.
    ///
    /// If the <paramref name="date"/> is before the first <see cref="IHistoryEntry"/> in <see cref="History"/>, <c>null</c> will be returned.
    /// </summary>
    public static IHistoryEntry? EntryAt(DateOnly date) => TSelf.History.LastOrDefault(entry => entry.EffectiveDate <= date);
}
