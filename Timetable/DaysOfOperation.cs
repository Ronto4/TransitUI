namespace Timetable;

/// <summary>
/// Describes on which day(s) a <see cref="Line.Trip"/> operates.
/// <br/><br/>
/// Note that this applies to the previous calendar day for all <see cref="LineOperationTime.Daytime"/>
/// only lines from midnight to 2am.
/// </summary>
[Flags]
public enum DaysOfOperation
{
    /// <summary>
    /// No days
    /// </summary>
    None = 0,

    /// <summary>
    /// Mondays that are school days
    /// </summary>
    SchoolMonday = 1 << 0,

    /// <summary>
    /// Tuesdays that are school days
    /// </summary>
    SchoolTuesday = 1 << 1,

    /// <summary>
    /// Wednesdays that are school days
    /// </summary>
    SchoolWednesday = 1 << 2,

    /// <summary>
    /// Thursdays that are school days
    /// </summary>
    SchoolThursday = 1 << 3,

    /// <summary>
    /// Fridays that are school days
    /// </summary>
    SchoolFriday = 1 << 4,

    /// <summary>
    /// Mondays that are not school days
    /// </summary>
    HolidayMonday = 1 << 5,

    /// <summary>
    /// Tuesdays that are not school days
    /// </summary>
    HolidayTuesday = 1 << 6,

    /// <summary>
    /// Wednesdays that are not school days
    /// </summary>
    HolidayWednesday = 1 << 7,

    /// <summary>
    /// Thursdays that are not school days
    /// </summary>
    HolidayThursday = 1 << 8,

    /// <summary>
    /// Fridays that are not school days
    /// </summary>
    HolidayFriday = 1 << 9,

    /// <summary>
    /// Saturdays
    /// </summary>
    Saturday = 1 << 10,

    /// <summary>
    /// Sundays
    /// </summary>
    Sunday = 1 << 11,

    /// <summary>
    /// Mondays
    /// </summary>
    Monday = HolidayMonday | SchoolMonday,

    /// <summary>
    /// Tuesdays
    /// </summary>
    Tuesday = HolidayTuesday | SchoolTuesday,

    /// <summary>
    /// Wednesdays
    /// </summary>
    Wednesday = HolidayWednesday | SchoolWednesday,

    /// <summary>
    /// Thursdays
    /// </summary>
    Thursday = HolidayThursday | SchoolThursday,

    /// <summary>
    /// Fridays
    /// </summary>
    Friday = HolidayFriday | SchoolFriday,

    /// <summary>
    /// Any school day
    /// </summary>
    School = SchoolMonday | SchoolTuesday | SchoolWednesday | SchoolThursday | SchoolFriday,

    /// <summary>
    /// Any Monday to Friday non-school day. Does not include <see cref="Weekend"/>.
    /// </summary>
    Holiday = HolidayMonday | HolidayTuesday | HolidayWednesday | HolidayThursday | HolidayFriday,

    /// <summary>
    /// Monday to Friday
    /// </summary>
    Weekday = School | Holiday,

    /// <summary>
    /// Saturday and Sunday
    /// </summary>
    Weekend = Saturday | Sunday,

    /// <summary>
    /// Every day
    /// </summary>
    Daily = Weekday | Weekend,
}
