using R4Utils.ValueEqualityCollections;

namespace Timetable;

/// <summary>
/// Data representing a station in the world.
/// </summary>
public partial record Stop
{
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
    public required string InitialName { private get; init; }

    private readonly ValueEqualityCollection<(DateOnly Date, string Name), List<(DateOnly Date, string Name)>>
        _nameChanges = null!; // Will be set by *required* init-er below.

    /// <summary>
    /// Maps the <see cref="DateOnly"/> of a change of name of this <see cref="Stop"/> to its new name.
    /// </summary>
    public List<(DateOnly Date, string Name)> NameChanges
    {
        get => _nameChanges.Underlying;
        init => _nameChanges =
            value.AsGenericOrderedValueEqualityCollection<(DateOnly Date, string Name),
                List<(DateOnly Date, string Name)>>();
    }

    /// <summary>
    /// The <see cref="City"/> of this <see cref="Stop"/>.
    /// </summary>
    public required City City { get; init; }

    /// <summary>
    /// Get the non-<see cref="City"/>-prepended name of this <see cref="Stop"/> at day <paramref name="date"/>.
    /// </summary>
    public string NameAt(DateOnly date) => NameChanges.Count == 0 || NameChanges[0].Date > date
        ? InitialName
        : NameChanges.Last(change => change.Date <= date).Name;

    /// <summary>
    /// The name of this <see cref="Stop"/> including its <see cref="City"/>, as it was on <paramref name="date"/>.
    /// </summary>
    public string FullName(DateOnly date) => $"{City.Name}, {NameAt(date)}";

    /// <summary>
    /// The name of this <see cref="Stop"/> as it should be shown to users on <paramref name="date"/> in city <paramref name="referenceCity"/>.
    /// </summary>
    public string DisplayName(DateOnly date, City referenceCity) => DisplayNameFor(NameAt(date), referenceCity);

    private string DisplayNameFor(string name, City referenceCity) =>
        referenceCity == City ? name : $"{City.Name}, {name}";

    private readonly ValueEqualityCollection<Position, Position[]> _positions =
        Array.Empty<Position>().AsGenericOrderedValueEqualityCollection<Position, Position[]>();

    /// <summary>
    /// All <see cref="Position"/>s of this <see cref="Stop"/>.
    /// </summary>
    /// <remarks>Defaults to a single-element array if omitted.</remarks>
    public /*required*/ Position[] Positions
    {
        get => _positions.Underlying;
        init
        {
            _positions = value.AsGenericOrderedValueEqualityCollection<Position, Position[]>();
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
