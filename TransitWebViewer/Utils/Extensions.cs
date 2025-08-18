using Timetable;

namespace TransitWebViewer.Utils;

internal static class Extensions
{
    public static string Display(this DaysOfOperation days) => DisplayDaysOfOperation(days.ToString());

    private static string DisplayDaysOfOperation(string days) => days.Contains(", ")
        ? string.Join(", ", days.Split(", ").Select(DisplayDaysOfOperation))
        : days switch
        {
            nameof(DaysOfOperation.Monday) => "Mo",
            nameof(DaysOfOperation.SchoolMonday) => "Mo (Schule)",
            nameof(DaysOfOperation.HolidayMonday) => "Mo (Ferien)",
            nameof(DaysOfOperation.Tuesday) => "Di",
            nameof(DaysOfOperation.SchoolTuesday) => "Di (Schule)",
            nameof(DaysOfOperation.HolidayTuesday) => "Di (Ferien)",
            nameof(DaysOfOperation.Wednesday) => "Mi",
            nameof(DaysOfOperation.SchoolWednesday) => "Mi (Schule)",
            nameof(DaysOfOperation.HolidayWednesday) => "Mi (Ferien)",
            nameof(DaysOfOperation.Thursday) => "Do",
            nameof(DaysOfOperation.SchoolThursday) => "Do (Schule)",
            nameof(DaysOfOperation.HolidayThursday) => "Do (Ferien)",
            nameof(DaysOfOperation.Friday) => "Fr",
            nameof(DaysOfOperation.SchoolFriday) => "Fr (Schule)",
            nameof(DaysOfOperation.HolidayFriday) => "Fr (Ferien)",
            nameof(DaysOfOperation.Saturday) => "Sa",
            nameof(DaysOfOperation.Sunday) => "So",
            nameof(DaysOfOperation.School) => "Schule",
            nameof(DaysOfOperation.Holiday) => "Ferien",
            nameof(DaysOfOperation.Weekday) => "Mo–Fr",
            nameof(DaysOfOperation.Weekend) => "Sa–So",
            nameof(DaysOfOperation.Daily) => "täglich",
            _ => days,
        };

    /// <summary>
    /// Returns optional CSS classes to be used when the <paramref name="days"/> need to be displayed, e.g., in a table.
    /// </summary>
    public static string CssColor(this DaysOfOperation days) => days switch
    {
        DaysOfOperation.Daily => "",
        DaysOfOperation.School or DaysOfOperation.Weekday => "table-primary",
        DaysOfOperation.Holiday => "table-secondary",
        DaysOfOperation.Saturday or DaysOfOperation.Weekend => "table-warning",
        DaysOfOperation.Sunday => "table-danger",
        _ => "",
    };

    public static IEnumerable<T> Intersect<T>(this IEnumerable<IEnumerable<T>> enumerable)
    {
        var listOfEnumerables = enumerable.ToList();
        if (listOfEnumerables.Count < 2)
        {
            return listOfEnumerables.SelectMany(t => t);
        }
        var intersection = listOfEnumerables
            .Skip(1)
            .Aggregate(
                new HashSet<T>(listOfEnumerables.First()),
                (h, e) => { h.IntersectWith(e); return h; }
            );
        return intersection;
    }
}
