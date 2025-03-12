namespace Timetable;

public partial record Line
{
    public partial record Route
    {
        /// <summary>
        /// A wrapper around intervals between stops of the route.
        /// Multiple <see cref="Route.TimeProfile"/> can be used to indicate multiple times taken between stops,
        /// e.g. on different times of day.
        /// </summary>
        public record TimeProfile
        {
            /// <summary>
            /// At index <c>i</c> there is the time it takes to travel from stop position <c>i</c> to <c>i+1</c>.
            /// </summary>
            public required TimeSpan[] StopDistances { get; init; }

            /// <summary>
            /// Get the time it takes to travel from stop index <paramref name="fromIndex"/> to <paramref name="toIndex"/>.
            /// </summary>
            /// <remarks><paramref name="fromIndex"/> MUST NOT be greater than <paramref name="toIndex"/>!</remarks>
            public TimeSpan TimeBetweenStops(int fromIndex, int toIndex)
            {
#if DEBUG
                if (fromIndex > toIndex)
                    throw new ArgumentOutOfRangeException(nameof(fromIndex), fromIndex,
                        $"{nameof(fromIndex)} MUST NOT be greater than {nameof(toIndex)}, but was {fromIndex} when {nameof(toIndex)} was {toIndex}.");
#endif
                return TimeSpan.FromTicks(StopDistances
                    .Skip(fromIndex).Take(toIndex - fromIndex).Select(time => time.Ticks).Sum());
            }
        }
    }
}
