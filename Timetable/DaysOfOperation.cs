// ReSharper disable InconsistentNaming
namespace Timetable;

[Flags]
public enum DaysOfOperation
{
    None = 0,
    SchoolMonday = 1 << 0,
    SchoolTuesday = 1 << 1,
    SchoolWednesday = 1 << 2,
    SchoolThursday = 1 << 3,
    SchoolFriday = 1 << 4,
    HolidayMonday = 1 << 5,
    HolidayTuesday = 1 << 6,
    HolidayWednesday = 1 << 7,
    HolidayThursday = 1 << 8,
    HolidayFriday = 1 << 9,
    Saturday = 1 << 10,
    Sunday = 1 << 11,
    Monday = HolidayMonday | SchoolMonday,
    Tuesday = HolidayTuesday | SchoolTuesday,
    Wednesday = HolidayWednesday | SchoolWednesday,
    Thursday = HolidayThursday | SchoolThursday,
    Friday = HolidayFriday | SchoolFriday,
    School = SchoolMonday | SchoolTuesday | SchoolWednesday | SchoolThursday | SchoolFriday,
    Holiday = HolidayMonday | HolidayTuesday | HolidayWednesday | HolidayThursday | HolidayFriday,
    Weekday = School | Holiday,
    Weekend = Saturday | Sunday,
    Daily = Weekday | Weekend,
}
