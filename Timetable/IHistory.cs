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
    /// (first, last) day of school holidays.
    /// </summary>
    public static abstract (DateOnly FirstDay, DateOnly LastDay)[] SchoolHolidays { get; }

    /// <summary>
    /// Dates on which transit is performed as on Saturdays due to a public holiday.
    /// </summary>
    public static abstract DateOnly[] PublicHolidaysSaturday { get; }

    /// <summary>
    /// Dates on which transit is performed as on Sundays due to a public holiday.
    /// </summary>
    public static abstract DateOnly[] PublicHolidaysSunday { get; }

    /// <summary>
    /// Returns the <see cref="IHistoryEntry"/> valid at the given <paramref name="date"/>.
    ///
    /// If the <paramref name="date"/> is before the first <see cref="IHistoryEntry"/> in <see cref="History"/>, <c>null</c> will be returned.
    /// </summary>
    public static IHistoryEntry? EntryAt(DateOnly date) =>
        TSelf.History.LastOrDefault(entry => entry.EffectiveDate <= date);

    /// <summary>
    /// Get the <see cref="DaysOfOperation"/> of the provided <paramref name="date"/>.
    /// </summary>
    public static DaysOfOperation OperationOn(DateOnly date)
    {
        if (TSelf.PublicHolidaysSunday.Contains(date))
        {
            return DaysOfOperation.Sunday;
        }

        if (TSelf.PublicHolidaysSaturday.Contains(date))
        {
            return DaysOfOperation.Saturday;
        }

        var generalDate = date.DayOfWeek switch
        {
            DayOfWeek.Monday => DaysOfOperation.Monday,
            DayOfWeek.Tuesday => DaysOfOperation.Tuesday,
            DayOfWeek.Wednesday => DaysOfOperation.Wednesday,
            DayOfWeek.Thursday => DaysOfOperation.Thursday,
            DayOfWeek.Friday => DaysOfOperation.Friday,
            DayOfWeek.Saturday => DaysOfOperation.Saturday,
            DayOfWeek.Sunday => DaysOfOperation.Sunday,
            _ => throw new Exception($"Unexpected day of week {date.DayOfWeek}."),
        };

        if ((generalDate & DaysOfOperation.Weekend) != DaysOfOperation.None)
        {
            return generalDate;
        }

        var isSchoolHoliday = TSelf.SchoolHolidays.Any(holiday => holiday.FirstDay <= date && date <= holiday.LastDay);
        return generalDate & (isSchoolHoliday ? DaysOfOperation.Holiday : DaysOfOperation.School);
    }

    /// <summary>
    /// Whether the provided <paramref name="date"/> is operated as a <see cref="DaysOfOperation.School"/> day.
    /// </summary>
    public static bool IsSchool(DateOnly date) => (OperationOn(date) & DaysOfOperation.School) != DaysOfOperation.None;

    /// <summary>
    /// Whether the provided <paramref name="date"/> is operated as a <see cref="DaysOfOperation.Holiday"/> day.
    /// </summary>
    public static bool IsSchoolHoliday(DateOnly date) =>
        (OperationOn(date) & DaysOfOperation.Holiday) != DaysOfOperation.None;

    /// <summary>
    /// Whether the provided <paramref name="date"/> is operated as a <see cref="DaysOfOperation.Saturday"/> day.
    /// </summary>
    public static bool IsSaturday(DateOnly date) =>
        (OperationOn(date) & DaysOfOperation.Saturday) != DaysOfOperation.None;

    /// <summary>
    /// Whether the provided <paramref name="date"/> is operated as a <see cref="DaysOfOperation.Sunday"/> day.
    /// </summary>
    public static bool IsSunday(DateOnly date) => (OperationOn(date) & DaysOfOperation.Sunday) != DaysOfOperation.None;
}
