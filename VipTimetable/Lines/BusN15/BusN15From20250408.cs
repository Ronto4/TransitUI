using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.BusN15;

public class BusN15From20250408 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 8, 4);
    private static BusN15From20250203 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        Routes = Previous.Line.Routes.Select(route => route
                .WithoutStops([Stops.FahrländerSee, Stops.Plantagenweg])
                .WithStopBetween(Stops.Eisbergstücke, Stops.KrampnitzMitte, Stops.Bassewitz, M4, M0)
                .WithStopBetween(Stops.KrampnitzMitte, Stops.KrampnitzerTor, Stops.Bassewitz, M1, M2)
                .WithStopBetween(Stops.Bassewitz, Stops.KrampnitzerTor, Stops.Eisbergstücke, M2, M0)
                .WithStopBetween(Stops.KrampnitzerTor, Stops.KrampnitzMitte, Stops.Eisbergstücke, M1, M4))
            .ToArray(),
        TripsCreate = Previous.Line.TripsCreate.SelectMany(trip =>
            trip.RouteIndex.Equals(0)
                ? (trip with { StartTime = trip.StartTime.AddMinutes(-3) }).Iter()
                : trip.RouteIndex.Equals(1)
                    ? (trip with
                    {
                        Connections =
                        [
                            new Line.TripCreate.Connection
                            {
                                ConnectingLineIdentifier = "busN15", ConnectingRouteIndex = 2, Delay = M3,
                                Type = Line.Trip.ConnectionType.ComesAs,
                            },
                        ],
                    }).Iter()
                    : trip.RouteIndex.Equals(2)
                        ? trip.StartTime == new TimeOnly(5, 10)
                            ?
                            [
                                trip with
                                {
                                    DaysOfOperation = DaysOfOperation.Saturday,
                                    StartTime = trip.StartTime.AddMinutes(-2),
                                },
                                trip with
                                {
                                    DaysOfOperation = DaysOfOperation.Sunday,
                                    StartTime = trip.StartTime.AddMinutes(-2),
                                    Connections =
                                    [
                                        new Line.TripCreate.Connection
                                        {
                                            ConnectingLineIdentifier = "busN15", ConnectingRouteIndex = 1, Delay = M3,
                                            Type = Line.Trip.ConnectionType.ContinuesAs,
                                        },
                                    ],
                                }
                            ]
                            : (trip with
                            {
                                StartTime = trip.StartTime.AddMinutes(-2),
                                Connections =
                                [
                                    new Line.TripCreate.Connection
                                    {
                                        ConnectingLineIdentifier = "busN15", ConnectingRouteIndex = 1, Delay = M3,
                                        Type = Line.Trip.ConnectionType.ContinuesAs,
                                    },
                                ],
                            }).Iter()
                        : trip.RouteIndex.Equals(3)
                            ? (trip with { StartTime = trip.StartTime.AddMinutes(-2) }).Iter()
                            : trip.Iter()).ToArray(),
    };
}

file static class Extensions {
    extension<T>(T elem)
    {
        public IEnumerable<T> Iter() => [elem];
    }
}
