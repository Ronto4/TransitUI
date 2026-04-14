namespace Timetable;

/// <summary>
/// Indicate how to interpret validity dates.
/// </summary>
public enum ValidityMode
{
    /// <summary>
    /// Consider the provided date as the start of a validiity period.
    /// </summary>
    Regular,
    /// <summary>
    /// Consider the provided date as the only day on which the information is valid.
    /// </summary>
    OnlyOnThisDay,
}