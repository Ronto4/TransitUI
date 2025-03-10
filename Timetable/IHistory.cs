namespace Timetable;

/// <summary>
/// The entrypoint for a timetable, containing all historic data about the network.
/// </summary>
public interface IHistory
{
    /// <summary>
    /// The historic data about the network.
    /// </summary>
    public static abstract IHistoryEntry[] History { get; }
}
