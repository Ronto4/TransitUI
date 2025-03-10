namespace Timetable;

/// <summary>
/// A helper class for <see cref="NaturalCustomerOrdering{TCollection}"/>.
/// </summary>
public static class LineOrdering
{
    /// <summary>
    /// Order a collection of lines by their natural order towards customers.
    /// This order is as follows:
    /// <br/>1. Long-distance trains
    /// <br/>2. Regional trains
    /// <br/>3. S-Bahn
    /// <br/>4. U-Bahn
    /// <br/>5. Tram
    /// <br/>6. Bus
    /// <br/>7. Ferry
    /// <br/>
    /// Each group in itself is ordered as follows:
    /// <br/>1. All lines that are not night-only precede all night-only lines.
    /// <br/>2. Lines are ordered alphabetically according to the *current culture*.
    /// </summary>
    public class NaturalCustomerLineComparer : IComparer<Line>
    {
        /// <inheritdoc />
        public int Compare(Line? x, Line? y)
        {
            // Default comparer stuff...
            if (ReferenceEquals(x, y)) return 0;
            if (y is null) return 1;
            if (x is null) return -1;
            // 1. Order by type.
            if (x.TransportationType != y.TransportationType)
                return x.TransportationType.CompareTo(y.TransportationType);
            // 2. Order by night-only/not night-only.
            var xIsNightOnly = x.OperationTime is LineOperationTime.Nighttime;
            var yIsNightOnly = y.OperationTime is LineOperationTime.Nighttime;
            if (xIsNightOnly != yIsNightOnly)
                return xIsNightOnly ? 1 : -1;
            // 3. Order by name using current culture.
            return string.Compare(x.Name, y.Name, StringComparison.CurrentCulture);
        }
    }

    /// <summary>
    /// Order a collection of lines according to <see cref="NaturalCustomerLineComparer"/>.
    /// </summary>
    public static IOrderedEnumerable<Line> NaturalCustomerOrdering<TCollection>(this TCollection collection)
        where TCollection : IEnumerable<Line> => collection.OrderBy(line => line, new NaturalCustomerLineComparer());
}
