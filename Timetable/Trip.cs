namespace Timetable;

public partial record Line
{
    /// <summary>
    /// A single trip along a given <see cref="Line.Route"/>.
    /// </summary>
    public partial record Trip
    {
        /// <inheritdoc cref="object.ToString"/>
        public override string ToString() => new
        {
            Line = Line.Name,
            Route = $"{Route.StopPositions.First().Stop.InitialName} > {Route.StopPositions.Last().Stop.InitialName}",
            DaysOfOperation, StartTime, ConnectionId, Connections = Connections.Print(", ")
        }.ToString()!;

        /// <summary>
        /// The <see cref="Timetable.Line"/> this <see cref="Trip"/> uses.
        /// </summary>
        public required Line Line { get; init; }

        /// <summary>
        /// The <see cref="Line.Route"/> this <see cref="Trip"/> uses.
        /// </summary>
        public required Route Route { get; init; }

        /// <summary>
        /// The <see cref="TimeProfile"/> this <see cref="Trip"/> uses.
        /// </summary>
        public required Route.TimeProfile TimeProfile { get; init; }

        /// <summary>
        /// The time at which this <see cref="Trip"/> departs the first <see cref="Stop"/> of its <see cref="Route"/>.
        /// </summary>
        public required TimeOnly StartTime { get; init; }

        /// <summary>
        /// The days on which this <see cref="Trip"/> operates.
        /// </summary>
        public required DaysOfOperation DaysOfOperation { get; init; }

        /// <summary>
        /// All manually (in the timetable) specified <see cref="ManualAnnotation"/> for this <see cref="Trip"/>.
        /// </summary>
        public required List<ManualAnnotation> Annotations { get; init; }

        /// <summary>
        /// An ID used to match trips that should connect with each other.
        /// Ignored if it is <c>0</c> (the default).
        /// </summary>
        /// <remarks>
        /// Links to <see cref="Line.TripCreate.Connection.ConnectingId"/>.
        /// </remarks>
        public long ConnectionId { get; init; } = 0;

        /// <summary>
        /// All through services this <see cref="Trip"/> participates in.
        /// <br/><br/>
        /// This should have 0 (no through service), 1 (start or end of through service), or 2 (middle of a through service) elements.
        /// </summary>
        public required List<TripCreate.Connection> Connections { private get; init; }

        /// <summary>
        /// Translate the trip-create <see cref="Timetable.Line.TripCreate.Connection"/>s present on this <see cref="Trip"/> into trip <see cref="Connection"/>s.
        /// </summary>
        /// <param name="allLines">All <see cref="Line"/>s present in the current network, indexed by their id.</param>
        // Consider adding more validation steps if it becomes a problem.
        public IEnumerable<Connection> GetConnections(IReadOnlyDictionary<string, Line> allLines) =>
            Connections.Select(connection =>
            {
                Trip? connectingTrip;
                List<Trip> connectingTrips = [];
                try
                {
                    connectingTrips = (connection.Type is ConnectionType.ContinuesAs
                        ? allLines[connection.ConnectingLineIdentifier]
                            .TripsOfRouteIndex(connection.ConnectingRouteIndex)
                            .Where(TripMatchesContinuing)
                        : allLines[connection.ConnectingLineIdentifier]
                            .TripsOfRouteIndex(connection.ConnectingRouteIndex)
                            .Where(TripMatchesComing)).ToList();
                    connectingTrip = connectingTrips.SingleOrDefault();
                }
                catch (InvalidOperationException ex)
                {
                    if (ex.Message != "Sequence contains more than one element") throw;
                    Console.WriteLine(
                        $"[WARNING] Found more than one connecting trip for connection {connection}!\nTrip: {this}\nFound {connectingTrips.Print(",\n\t")}\nSkipping it.");
                    return null;
                }

                if (connectingTrip is null)
                {
                    Console.WriteLine(
                        $"[WARNING] Could not find a connecting trip for connection {connection}!\nTrip: {this}\nSkipping it.");
                    return null;
                }

                return new Connection
                {
                    Type = connection.Type,
                    NotableViaStop = connection.NotableViaStop,
                    Trip = connectingTrip,
                };

                bool TripMatchesComing(Trip trip) =>
                    StartTime == trip.TimeAtStop(trip.Route.StopPositions.Length - 1).Add(connection.Delay) &&
                    (connection.ConnectingId is 0
                        ? trip.DaysOfOperation == DaysOfOperation
                        : trip.ConnectionId == connection.ConnectingId);

                bool TripMatchesContinuing(Trip trip) =>
                    trip.StartTime == TimeAtStop(Route.StopPositions.Length - 1).Add(connection.Delay) &&
                    (connection.ConnectingId is 0
                        ? trip.DaysOfOperation == DaysOfOperation
                        : trip.ConnectionId == connection.ConnectingId);
            }).WhereNotNull();

        /// <summary>
        /// The time at which this <see cref="Trip"/> departs the <see cref="Stop"/> specified by the <see cref="Route"/>'s <see cref="Line.Route.CommonStopIndex"/>.
        /// </summary>
        public TimeOnly TimeAtCommonStop() => TimeAtStop(Route.CommonStopIndex);

        /// <summary>
        /// The time at which this <see cref="Trip"/> departs at the <see cref="Stop"/> of the <see cref="Route"/> specified by <paramref name="stopIndex"/>.
        /// </summary>
        public TimeOnly TimeAtStop(int stopIndex)
        {
            var time = StartTime;
            while (stopIndex-- > 0)
            {
                time = time.Add(TimeProfile.StopDistances[stopIndex]);
            }

            return time;
        }

        /// <summary>
        /// The time at which this <see cref="Trip"/> arrives at the last <see cref="Stop"/> of the <see cref="Route"/>.
        /// </summary>
        /// <returns></returns>
        public TimeOnly TimeAtLastStop() => TimeAtStop(Route.StopPositions.Length - 1);
    }
}

file static class Extensions
{
    public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T?> enumerable) where T : class =>
        enumerable.Where(item => item is not null)!;

    public static string Print<T>(this IEnumerable<T> enumerable, string separator) =>
        $"[{string.Join(separator, enumerable)}]";
}
