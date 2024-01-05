namespace Timetables.Models;

public interface IHistory
{
    public static abstract IHistoryEntry[] History { get; }
}
