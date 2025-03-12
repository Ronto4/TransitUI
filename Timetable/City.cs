namespace Timetable;

/// <summary>
/// A wrapper around a city/town/etc.
/// </summary>
public record City
{
    /// <summary>
    /// The name of the <see cref="City"/> as used by normal people.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Create a <see cref="City"/> instance with <see cref="Name"/> <paramref name="name"/>.
    /// </summary>
    public static implicit operator City(string name) => new() { Name = name };
}
