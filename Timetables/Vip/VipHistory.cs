using Timetables.Models;

namespace Timetables.Vip;

public class VipHistory : IHistory
{
    public static IHistoryEntry[] History { get; } =
    [
        new HistoryEntry(new DateOnly(2024, 1, 2), "Übersicht über die aktuellen Linien:")
    ];
}
