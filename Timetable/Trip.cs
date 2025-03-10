namespace Timetable;

public partial record Line
{
    /// <summary>
    /// A single trip along a given <see cref="Line.Route"/>.
    /// </summary>
    public partial record Trip
    {
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
        public IEnumerable<Connection> GetConnections(IReadOnlyDictionary<string, Line> allLines) => Connections.Select(
            connection => new Connection
            {
                Type = connection.Type,
                NotableViaStop = connection.NotableViaStop,
                Trip = connection.Type is ConnectionType.ContinuesAs
                    ? allLines[connection.ConnectingLineIdentifier].TripsOfRouteIndex(connection.ConnectingRouteIndex)
                        .Single(trip =>
                            trip.StartTime == TimeAtStop(Route.StopPositions.Length - 1).Add(connection.Delay) &&
                            trip.DaysOfOperation == DaysOfOperation)
                    : allLines[connection.ConnectingLineIdentifier].TripsOfRouteIndex(connection.ConnectingRouteIndex)
                        .Single(trip =>
                            StartTime == trip.TimeAtStop(trip.Route.StopPositions.Length - 1).Add(connection.Delay) &&
                            trip.DaysOfOperation == DaysOfOperation),
            });

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
