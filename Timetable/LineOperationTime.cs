namespace Timetable;

/// <summary>
/// Describes at which time of day the line *typically* operates.
/// <br/><br/>
/// Note the interaction with <see cref="DaysOfOperation"/> for <see cref="Daytime"/> only lines.
/// </summary>
[Flags]
public enum LineOperationTime
{
    /// <summary>
    /// To be used when representing an instance of <see cref="LineOperationTime"/> that represents no operation time at all.
    /// </summary>
    None = 0,

    /// <summary>
    /// To be used for lines typically not operating during the night, i.e. that have a break between their last and first trip.
    /// </summary>
    /// <example>Normal bus routes</example>
    Daytime = 1 << 0,

    /// <summary>
    /// To be used for lines typically only operating during the night, i.e. there are no services at daytime and they are typically advertised as running on nights from Monday to Tuesday or similar.
    /// </summary>
    /// <example>Nightbuses serving routes not operated during the day</example>
    Nighttime = 1 << 1,

    /// <summary>
    /// To be used for lines that on at least some regularity have trips both during the day and during the night.
    /// </summary>
    /// <example>Train services like S-Bahns which offer a night service in at least some regular nights</example>
    Complete = Daytime | Nighttime,
}

/// <summary>
/// Provider for helper methods for <see cref="LineOperationTime"/>.
/// </summary>
public static class LineOperationTimeExtensions
{
    /// <summary>
    /// Returns whether any of the bits set in <paramref name="flag"/> are also set in <paramref name="value"/>.
    /// </summary>
    public static bool HasAnyFlag(this LineOperationTime value, LineOperationTime flag) => (value & flag) != 0;
}