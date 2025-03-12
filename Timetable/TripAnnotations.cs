namespace Timetable;

public partial record Line
{
    public partial record Trip
    {
        /// <summary>
        /// Basis for all types of annotations.
        /// </summary>
        public abstract record AnnotationDefinition
        {
            /// <summary>
            /// The short name or representation of this annotation.
            /// <br/><br/>
            /// Should be small enough to fit into a timetable, e.g. a single letter.
            /// </summary>
            public required string Symbol { get; init; }
        }

        /// <summary>
        /// An annotation that uses a manually specified <see cref="Text"/> for display.
        /// </summary>
        public record ManualAnnotation : AnnotationDefinition
        {
            /// <summary>
            /// The text to display when explaining this annotation.
            /// </summary>
            public required string Text { get; init; }
        }

        /// <summary>
        /// An annotation used to show that the associated <see cref="Trip"/> is the first part of a through service
        /// continuing on another <see cref="Trip"/>.
        /// </summary>
        public record ContinuesAnnotation : AnnotationDefinition
        {
            /// <summary>
            /// The final <see cref="Stop"/> of the next <see cref="Trip"/> in this through service.
            /// </summary>
            public required Stop To { get; init; }

            /// <summary>
            /// The <see cref="Line"/> the next <see cref="Trip"/> in this through service uses.
            /// </summary>
            public required Line As { get; init; }

            /// <summary>
            /// The <see cref="Route"/> the next <see cref="Trip"/> in this though service uses
            /// on the <see cref="Line"/> stored in <see cref="As"/>.
            /// </summary>
            public required Route Via { get; init; }

            /// <summary>
            /// The time between arriving at the final <see cref="Stop"/> of this <see cref="Trip"/> and the departure
            /// at this <see cref="Stop"/> as the new <see cref="Trip"/>.
            /// </summary>
            public required TimeSpan Delay { get; init; }

            /// <summary>
            /// Used for stops along the way of the connecting route that are noteworthy to be mentioned in timetables
            /// regardless of the fact they appear as normal on the route.
            /// </summary>
            public required Stop? NotableViaStop { get; init; }
        }

        /// <summary>
        /// An annotation indicating that this <see cref="Trip"/> does not continue to the final stop of the default
        /// display route (in the stop timetable represented as route [1] or unspecified if there is only one).
        /// </summary>
        public record OnlyToAnnotation : AnnotationDefinition
        {
            /// <summary>
            /// The final <see cref="Stop"/> of this <see cref="Trip"/>.
            /// </summary>
            public required Stop To { get; init; }

            /// <summary>
            /// The 0-based index of the display route this <see cref="Trip"/> takes.
            /// </summary>
            public required int DisplayRouteIndex { get; init; }
        }

        /// <summary>
        /// An annotation combining a <see cref="ContinuesAnnotation"/> and a <see cref="OnlyToAnnotation"/>
        /// indicating that this <see cref="Trip"/> does not go to the final stop of the default display route
        /// and then continues as another <see cref="Trip"/>.
        /// </summary>
        public record ContinuesFromToAnnotation : AnnotationDefinition
        {
            /// <summary>
            /// The <see cref="ContinuesAnnotation"/> aspect of this annotation.
            /// </summary>
            public required ContinuesAnnotation ContinuesAnnotation { get; init; }

            /// <summary>
            /// The <see cref="OnlyToAnnotation"/> aspect of this annotation.
            /// </summary>
            public required OnlyToAnnotation OnlyToAnnotation { get; init; }
        }
    }
}
