using Timetables.Models;

namespace Timetables.Vip;

public class VipHistory : IHistory
{
    public static IHistoryEntry[] History { get; } =
    [
        Vip20240102.Entry,
    ];
}
