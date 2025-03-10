// ReSharper disable InconsistentNaming
namespace Timetable;

/// <summary>
/// Defines means of transportation.
/// </summary>
// The exact numeric values are used for natural sorting of lines. Change with care!
public enum TransportationType
{
    /// <summary>
    /// Trains running between large cities across the country or even across borders.
    /// </summary>
    /// <example>EC services</example>
    LongDistanceTrains = 10,

    /// <summary>
    /// Trains connecting cities within a region.
    /// </summary>
    /// <example>Regionalbahn, Regionalexpress</example>
    RegionalTrains = 20,

    /// <summary>
    /// Trains connecting parts of a city or nearby cities, preferably on dedicated tracks.
    /// </summary>
    /// <example>S-Bahn Berlin, Paris RER</example>
    SBahn = 30,

    /// <summary>
    /// Trains or light rail running on dedicated tracks, mostly underground, through a city.
    /// </summary>
    /// <example>U-Bahn Berlin, London Underground</example>
    UBahn = 40,

    /// <summary>
    /// Light rail trains running through a city, partially integrated into the normal traffic on street-level.
    /// </summary>
    /// <example>Croyden trams</example>
    Tram = 50,

    /// <summary>
    /// Buses within cities or even long-distance coaches.
    /// </summary>
    /// <example>City Buses, Flixbus</example>
    Bus = 60,

    /// <summary>
    /// Ferry services running on a river or similar waters.
    /// </summary>
    /// <example>Thameslink</example>
    Ferry = 70,
}
