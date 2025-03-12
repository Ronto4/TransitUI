namespace Timetable;

public partial record Line
{
    public partial record Trip
    {
        /// <summary>
        /// Contains the definition of a through service with another <see cref="Trip"/>.
        /// </summary>
        public record Connection
        {
            /// <summary>
            /// Indicating the part of the through service the <see cref="Trip"/> containing this object plays.
            /// </summary>
            public required ConnectionType Type { get; init; }

            /// <summary>
            /// The other <see cref="Trip"/> associated with this through service.
            /// </summary>
            public required Trip Trip { get; init; }

            /// <summary>
            /// Used for stops along the way of the connecting route that are noteworthy to be mentioned in timetables
            /// regardless of the fact they appear as normal on the route.
            /// </summary>
            public required Stop? NotableViaStop { get; init; }
        }

        /// <summary>
        /// Indicates the type of through service a <see cref="Connection"/> instance plays.
        /// </summary>
        public enum ConnectionType
        {
            /// <summary>
            /// Indicates that the associated <see cref="Trip"/> is the originating <see cref="Trip"/>.
            /// </summary>
            ContinuesAs,

            /// <summary>
            /// Indicates that the associated <see cref="Trip"/> is the continuing <see cref="Trip"/>.
            /// </summary>
            ComesAs,
        }
    }
}
