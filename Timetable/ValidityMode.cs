namespace Timetable;

/// <summary>
/// Indicate how to interpret validity dates.
/// </summary>
public enum ValidityMode
{
    /// <summary>
    /// Consider the provided date as the start of a validity period.
    /// </summary>
    Regular,
    /// <summary>
    /// Consider the provided timetable period as a temporary measure.
    /// </summary>
    Temporary,
}