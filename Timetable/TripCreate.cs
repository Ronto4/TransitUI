using LanguageExt;

namespace Timetable;

public partial record Line
{
    /// <summary>
    /// A small helper struct used to create a <see cref="Trip"/> in a timetable definition.
    /// </summary>
    public readonly partial record struct TripCreate
    {
        /// <summary>
        /// Create a new <see cref="TripCreate"/> without any fields set.
        /// </summary>
        public TripCreate()
        {
        }

        /// <summary>
        /// The index of the <see cref="Route"/> this trip uses.
        /// </summary>
        public required Index RouteIndex { get; init; }

        /// <summary>
        /// The index of the <see cref="Line.Route.TimeProfile"/> this trip uses.
        /// </summary>
        public required Index TimeProfileIndex { get; init; }

        /// <summary>
        /// The departure time from the first <see cref="Stop"/> of the <see cref="Route"/> specified by <see cref="RouteIndex"/>.
        /// </summary>
        public required TimeOnly StartTime { get; init; }

        /// <summary>
        /// The days on which this trip operates.
        /// </summary>
        public required DaysOfOperation DaysOfOperation { get; init; }

        /// <summary>
        /// Use <see cref="AnnotationSymbols"/> instead.
        /// <br/><br/>Was:<br/>
        /// Specify the symbol of the annotation that should be used for the annotation of this trip.
        /// </summary>
        [Obsolete($"Use {nameof(AnnotationSymbols)} instead.", false)]
        public string AnnotationSymbol
        {
            init => _annotationSymbols = Arr.create(value);
        }

        private readonly Arr<string> _annotationSymbols = Arr.empty<string>();

        /// <summary>
        /// The symbols (defined as the keys of <see cref="Line.Annotations"/>) of the annotations this trip has.
        /// </summary>
        public IReadOnlyList<string> AnnotationSymbols
        {
            get => _annotationSymbols;
            init => _annotationSymbols = Arr.createRange(value);
        }

        private readonly Arr<Connection> _connections = Arr.empty<Connection>();

        /// <summary>
        /// All through services this trip participates in.
        /// <br/><br/>
        /// This should have 0 (no through service), 1 (start or end of through service), or 2 (middle of a through service) elements.
        /// </summary>
        public IReadOnlyList<Connection> Connections
        {
            get => _connections;
            init => _connections = Arr.createRange(value);
        }

        /// <summary>
        /// Repeat this <see cref="TripCreate"/> instance for every <paramref name="interval"/>.
        /// </summary>
        /// <param name="interval">The time between each of the trips that will be created.</param>
        /// <param name="until">The latest <see cref="StartTime"/> a trip of this repetition can have.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of the <see cref="TripCreate"/>s to create,
        /// including the original <see cref="TripCreate"/>.</returns>
        /// <exception cref="ArgumentException">
        /// If the <paramref name="until"/> time is <i>before</i> the <see cref="StartTime"/>
        /// of this <see cref="TripCreate"/> but the <see cref="DaysOfOperation"/> do not specify a daily operation,
        /// it is impossible to represent the resulting trips with the used model, thus this exception is thrown.
        /// </exception>
        public IEnumerable<TripCreate> AlsoEvery(TimeSpan interval, TimeOnly until)
        {
            // If until is before this trip, this only works for trips that occur every day.
            if (until < StartTime && DaysOfOperation != DaysOfOperation.Daily)
            {
                throw new ArgumentException(
                    $"{nameof(until)} of {until} is before {nameof(StartTime)} of {StartTime}, and {nameof(DaysOfOperation)} is not {nameof(DaysOfOperation.Daily)}");
            }

            yield return this;
            var newStartTime = StartTime;
            while ((newStartTime = newStartTime.Add(interval)) <= until ||
                   newStartTime >= StartTime && until < StartTime)
            {
                yield return this with { StartTime = newStartTime };
                // The next add would land after `until`.
                // However, when `newStartTime.Add(interval)` wraps around midnight, this loop would run forever.
                // Thus, abort early.
                if (newStartTime == until) break;
            }
        }

        /// <summary>
        /// Repeat this <see cref="TripCreate"/> instance <paramref name="totalNumberOfTrips"/> times.
        /// </summary>
        /// <param name="interval">The time between each of the trips that will be created.</param>
        /// <param name="totalNumberOfTrips">The total number of <see cref="TripCreate"/>s that will be created, including this <see cref="TripCreate"/>.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of the <see cref="TripCreate"/>s to create,
        /// including the original <see cref="TripCreate"/>.</returns>
        public IEnumerable<TripCreate> AlsoEvery(TimeSpan interval, int totalNumberOfTrips)
        {
            var newStartTime = StartTime;
            while (totalNumberOfTrips-- > 0)
            {
                yield return this with { StartTime = newStartTime };
                newStartTime = newStartTime.Add(interval);
            }
        }
    }
}
