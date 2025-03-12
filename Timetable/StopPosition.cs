using System.Numerics;

namespace Timetable;

public partial record Stop
{
    /// <summary>
    /// Represents a stop position of a <see cref="Timetable.Stop"/>, e.g. multiple platforms.
    /// </summary>
    public record Position : IEqualityOperators<Position, Position, bool>
    {
        /// <summary>
        /// A name or short description of the <see cref="Position"/>, distinguishing it from other <see cref="Position"/>s of the same <see cref="Timetable.Stop"/>.
        /// </summary>
        public required string Description { get; init; }

        /// <summary>
        /// Allow creation of a <see cref="Position"/> from the <see cref="Description"/> string alone.
        /// </summary>
        public static implicit operator Position(string description) => new() { Description = description };

        /// <summary>
        /// Let a <see cref="Timetable.Stop"/> decay into a <see cref="Position"/> without additional work.
        /// </summary>
        /// <remarks>This was introduced to allow for simple operations in networks without defined <see cref="Position"/>s.</remarks>
        public static implicit operator Position(Stop stop) => stop.Positions[0];

        /// <summary>
        /// The <see cref="Timetable.Stop"/> this <see cref="Position"/> belongs to.
        /// </summary>
        public Stop Stop { get; internal set; } = null!; // Will be set when Position gets assigned to a Station.

        // public string Name => Stop is { } stop ? $"{stop.DisplayName} [{Description}]" : Description;
    }
}
