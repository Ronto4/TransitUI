using System.Numerics;

namespace Timetable;

/// <summary>
/// Data representing a station in the world.
/// </summary>
public partial record Stop
{
    // This is currently the default. In the long run this should be configurable in some way.
    private const string Potsdam = "Potsdam";

    /// <summary>
    /// The default <see cref="City"/> assigned to a <see cref="Stop"/>.
    /// </summary>
    public const string DefaultCity = Potsdam;

    /// <summary>
    /// Allow creation of a <see cref="Stop"/> from its <see cref="Name"/> alone.
    /// </summary>
    public static implicit operator Stop(string name) => new() { Name = name };

    /// <summary>
    /// Create a new <see cref="Stop"/> instance.
    /// </summary>
    /// <remarks>Defaults <see cref="Positions"/> to a single-element array.</remarks>
    public Stop()
    {
        Positions = ["Haltestelle"];
    }

    /// <summary>
    /// The name of this <see cref="Stop"/>, without any city names.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// The city of this <see cref="Stop"/>. Defaults to <see cref="DefaultCity"/>.
    /// </summary>
    /// <remarks>"City" here refers to settlement names found in station names, not necessarily cities in the legal definition.</remarks>
    public string City { get; init; } = DefaultCity;

    /// <summary>
    /// The name of this <see cref="Stop"/> as it should be shown to users.
    /// </summary>
    /// <remarks>Includes the <see cref="City"/> if and only if it is not the <see cref="DefaultCity"/>.</remarks>
    public string DisplayName => City is DefaultCity ? Name : $"{City}, {Name}";

    private readonly Position[] _positions = null!; // Will be set below.

    /// <summary>
    /// All <see cref="Position"/>s of this <see cref="Stop"/>.
    /// </summary>
    /// <remarks>Defaults to a single-element array if omitted.</remarks>
    public /*required*/ Position[] Positions
    {
        get => _positions;
        init
        {
            _positions = value;
            foreach (var position in _positions)
            {
                if (position.Stop is not null)
                {
                    throw new ArgumentException($"{position} is already assigned a stop!", nameof(value));
                }

                position.Stop = this;
            }
        }
    }
}
