using System.Numerics;

namespace Timetables.Models;

public record Stop
{
    private const string Potsdam = "Potsdam";
    public record Position : IEqualityOperators<Position, Position, bool>
    {
        public required string Description { get; init; }
        public static implicit operator Position(string description) => new() { Description = description };
        public static implicit operator Position(Stop stop) => stop.Positions[0];
        public Stop Stop { get; internal set; } = null!; // Will be set when Position gets assigned to a Station.
        public string Name => Stop is { } stop ? stop.DisplayName : Description;
        // public string Name => Stop is { } stop ? $"{stop.DisplayName} [{Description}]" : Description;
    }

    public Stop()
    {
        Positions = ["Haltestelle"];
    }

    public required string Name { get; init; }
    public string City { get; init; } = Potsdam;
    public string DisplayName => City is Potsdam ? Name : $"{City}, {Name}";
    private readonly Position[] _positions = null!; // Will be set below.

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
