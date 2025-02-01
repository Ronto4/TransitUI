namespace Timetables.Models;

[Flags]
public enum LineOperationTime
{
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

public static class LineOperationTimeExtensions
{
    public static bool HasAnyFlag(this LineOperationTime value, LineOperationTime flag) => (value & flag) != 0;
}