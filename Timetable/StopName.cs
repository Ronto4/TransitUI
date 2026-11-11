namespace Timetable;

public partial record Stop
{
    /// <summary>
    /// Represents a name of a <see cref="Timetable.Stop"/>.
    /// </summary>
    public interface IName
    {
        /// <summary>
        /// Get the name of the <see cref="Timetable.Stop"/> in <see cref="City"/> <paramref name="cityOfStop"/>.
        /// </summary>
        /// <param name="cityOfStop">The <see cref="City"/> where the <see cref="Timetable.Stop"/> is.</param>
        /// <param name="isFromExternalCity">Whether to render the name as seen in another <see cref="City"/>.</param>
        public string GetName(City cityOfStop, bool isFromExternalCity);
        
        /// <summary>
        /// Same as <see cref="GetName"/> but always assumes to be in the <paramref name="cityOfStop"/>.
        /// </summary>
        public string GetCityInternalName(City cityOfStop) => GetName(cityOfStop, false);
        
        /// <summary>
        /// Same as <see cref="GetName"/> but never assumes to be in the <paramref name="cityOfStop"/>.
        /// </summary>
        public string GetCityExternalName(City cityOfStop) => GetName(cityOfStop, true);
    }

    /// <summary>
    /// A classical name for a <see cref="Timetable.Stop"/>, e.g. "Potsdam, Kirschallee".
    /// </summary>
    public readonly record struct ClassicName : IName
    {
        /// <summary>
        /// The name of the <see cref="Timetable.Stop"/>.
        /// </summary>
        public required string Name { private get; init; }

        /// <inheritdoc />
        public string GetName(City cityOfStop, bool isFromExternalCity) =>
            isFromExternalCity ? $"{cityOfStop.Name}, {Name}" : Name;
    }

    /// <summary>
    /// A <see cref="Timetable.Stop"/> name that only consists of the <see cref="City"/>'s name, as often seen in small villages.
    /// </summary>
    public readonly record struct CityName : IName
    {
        /// <inheritdoc />
        public string GetName(City cityOfStop, bool isFromExternalCity) => cityOfStop.Name;
    }
}