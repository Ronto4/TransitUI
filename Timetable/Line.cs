using System.Diagnostics;
using LanguageExt;

namespace Timetable;

/// <summary>
/// A single line in the network.
/// It must have exactly *one* name,
/// i.e. lines like <c>6</c> and <c>6E</c> *MUST* be split into two <see cref="Line"/>s.
/// </summary>
public partial record Line
{
    /// <summary>
    /// The end-user-friendly name of this <see cref="Line"/>, e.g. line number.
    /// </summary>
    public required string Name { get; init; }

    private readonly Arr<Route> _routes = null!; // Will be set by *required* init-er below.

    /// <summary>
    /// All <see cref="Line.Route"/>s assigned to this <see cref="Line"/>.
    /// </summary>
    public required IReadOnlyList<Route> Routes
    {
        get => _routes;
        init
        {
            foreach (var route in value)
            {
                route.Line = this;
                // Validate that stop distances length matches route length.
                Debug.Assert(
                    route.TimeProfiles.All(profile => profile.StopDistances.Length == route.StopPositions.Length - 1),
                    $"For {this.Name}, {route.ToString()}, at least one time profile has an incorrect stop distance count.");
            }
            _routes = Arr.createRange(value);
        }
    }

    /// <summary>
    /// Get the minimum and maximum time it takes to travel from <c>from</c> to <c>to</c> using all <see cref="Line.Route"/>s and all of their <see cref="Line.Route.TimeProfile"/>s.
    /// </summary>
    public (TimeSpan minimum, TimeSpan maximum) TimeBetweenStops(Stop from, Stop to)
    {
        if (from == to) return (TimeSpan.Zero, TimeSpan.Zero);
        var currentMinimum = TimeSpan.MaxValue;
        var currentMaximum = TimeSpan.MinValue;
        foreach (var route in Routes)
        {
            var fromExists = route.TryGetIndexOfStop(from, out var fromIndex);
            var toExists = route.TryGetIndexOfStop(to, out var toIndex);
            if (!(fromExists && toExists)) continue;
            if (fromIndex > toIndex) continue;
            var (min, max) = route.TimeBetweenStops(fromIndex, toIndex);
            currentMinimum = Min(currentMinimum, min);
            currentMaximum = Max(currentMaximum, max);
        }

        return (currentMinimum, currentMaximum);

        static TimeSpan Min(TimeSpan a, TimeSpan b) => a < b ? a : b;
        static TimeSpan Max(TimeSpan a, TimeSpan b) => a > b ? a : b;
    }

    /// <summary>
    /// Iterator over all <see cref="Line.Trip"/>s included in this <see cref="Line"/>.
    /// </summary>
    public IEnumerable<Trip> Trips => TripsCreate.Select(trip => new Trip
    {
        Line = this,
        Route = Routes[trip.RouteIndex],
        StartTime = trip.StartTime,
        TimeProfile = Routes[trip.RouteIndex].TimeProfiles[trip.TimeProfileIndex],
        DaysOfOperation = trip.DaysOfOperation,
        Annotations = trip.AnnotationSymbols
            .Select(symbol => new Trip.ManualAnnotation { Symbol = symbol, Text = Annotations[symbol] }).ToList(),
        Connections = trip.Connections,
    });

    /// <summary>
    /// Iterate over all <see cref="Line.Trip"/>s included in the <see cref="Line.Route"/> at index <c>routeIndex</c> in this <see cref="Line"/>.
    /// </summary>
    public IEnumerable<Trip> TripsOfRouteIndex(Index routeIndex) =>
        Trips.Where(trip => trip.Route == Routes[routeIndex]);

    private readonly Arr<TripCreate> _tripsCreate = null!; // Will be set by *required* init-er below.

    /// <summary>
    /// All <see cref="TripCreate"/>s used to specify which <see cref="Line.Trip"/>s exist for this <see cref="Line"/>.
    /// </summary>
    public required IReadOnlyList<TripCreate> TripsCreate
    {
        get => _tripsCreate;
        init => _tripsCreate = Arr.createRange(value);
    }

    /// <summary>
    /// Which medium of transportation is the one used by this <see cref="Line"/>.
    /// </summary>
    public required TransportationType TransportationType { get; init; }

    // public required Stop[] NotableStops { get; init; }

    /// <summary>
    /// <see cref="Line.Route"/>s that are considered to be primary <see cref="Line.Route"/>s for this <see cref="Line"/>.
    /// <br/><br/>
    /// These can be <see cref="Line.Route"/>s that are frequently operated or form some other kind of importantness
    /// to either the line or the stops it takes along the route.
    /// </summary>
    public IEnumerable<Route> MainRoutes => MainRouteIndices.Select(index => Routes[index]);

    private readonly Arr<Index> _mainRouteIndices = null!; // Will be set by *required* init-er below.

    /// <summary>
    /// Specifies the indices of the <see cref="Line.Route"/>s that are considered <see cref="MainRoutes"/>.
    /// </summary>
    public required IReadOnlyList<Index> MainRouteIndices
    {
        get => _mainRouteIndices;
        init => _mainRouteIndices = Arr.createRange(value);
    }

    /// <summary>
    /// <see cref="Line.Route"/>s that are considered to be representative <see cref="Line.Route"/>s for this <see cref="Line"/>.
    /// <br/><br/>
    /// These are typically the longest routes regularly operated by this <see cref="Line"/>,
    /// even if such routes would only be operated occasionally, e.g. only during rush hour.
    /// </summary>
    public IEnumerable<Route> OverviewRoutes => OverviewRouteIndices.Select(index => Routes[index]);

    private readonly Arr<Index> _overviewRouteIndices = null!; // Will be set by *required* init-er below.

    /// <summary>
    /// Specifies the indices of the <see cref="Line.Route"/>s that are considers <see cref="OverviewRoutes"/>.
    /// </summary>
    public required IReadOnlyList<Index> OverviewRouteIndices
    {
        get => _overviewRouteIndices;
        init => _overviewRouteIndices = Arr.createRange(value);
    }

    private readonly HashMap<string, string> _annotations = HashMap<string, string>.Empty;

    /// <summary>
    /// Manual annotations, indexed by their symbol, mapping to their text.
    /// </summary>
    // TODO: Find a better way here, potentially with a native value equality dictionary.
    public IReadOnlyDictionary<string, string> Annotations
    {
        get => _annotations.ToReadOnlyDictionary();
        init => _annotations = HashMap.createRange(value);
    }

    /// <summary>
    /// The typical time of day where this <see cref="Line"/> operates.
    /// Defaults to <see cref="LineOperationTime.Daytime"/>.
    /// </summary>
    public LineOperationTime OperationTime { get; init; } = LineOperationTime.Daytime;

    /// <summary>
    /// Checks whether this <see cref="Line"/> has a <see cref="Line.Route"/> that includes <paramref name="stop"/>.
    /// </summary>
    /// <param name="stop">The <see cref="Stop"/> to check for.</param>
    /// <param name="onlyMainRoutes">Whether to ignore all non-<see cref="MainRoutes"/>-<see cref="Line.Route"/>s.</param>
    /// <param name="onlyDepartures">Whether to ignore all <see cref="Stop"/>s that do not have a departure, i.e. are the last <see cref="Stop"/> of a <see cref="Line.Route"/>.</param>
    /// <returns>Whether the <paramref name="stop"/> fulfills the given criteria.</returns>
    public bool DoesStopAt(Stop stop, bool onlyMainRoutes, bool onlyDepartures) =>
        (onlyMainRoutes ? MainRoutes : Routes).Any(route => route.DoesStopAt(stop, onlyDepartures));
}

// file static class MedianExtension
// {
//     // Source: https://stackoverflow.com/a/70164857
//     public static double Median<T>(this IReadOnlyCollection<T> list, Func<T, long> selector) => list.Select(selector).OrderBy(x => x)
//         .Skip((list.Count - 1) / 2).Take(2 - list.Count % 2).Average();
// }
