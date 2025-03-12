namespace Timetable;

public partial record Line
{
    public readonly partial record struct TripCreate
    {
        /// <summary>
        /// Denotes a through service as part of the <see cref="TripCreate"/>.
        /// </summary>
        public record Connection
        {
            /// <summary>
            /// The role this trip plays in the through service.
            /// </summary>
            public required Trip.ConnectionType Type { get; init; }

            /// <summary>
            /// The identifier of the line the other part of the through service relates to.
            /// </summary>
            public required string ConnectingLineIdentifier { get; init; }

            /// <summary>
            /// The index of the <see cref="Route"/> in the other <see cref="Line"/> the other part of the through service uses on that <see cref="Line"/>.
            /// </summary>
            public required Index ConnectingRouteIndex { get; init; }

            /// <summary>
            /// The time between the two time points at the <see cref="Stop"/> where the through service changes trips.
            /// </summary>
            public required TimeSpan Delay { get; init; }

            /// <summary>
            /// Used for stops along the way of the connecting route that are noteworthy to be mentioned in timetables
            /// regardless of the fact they appear as normal on the route.
            /// </summary>
            public Stop? NotableViaStop { get; init; } = null;
        }
    }
}
