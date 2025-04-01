using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus697;

public class Bus697From20241215 : ILineInstance
{
    private static readonly Bus697From20241214 Previous = new();
    public DateOnly ValidFrom { get; } = new(2024, 12, 15);

    public Line Line { get; } = Previous.Line with
    {
        Routes =
        [
            ..Previous.Line.Routes[..1],
            Previous.Line.Routes[1].Map(route =>
                route.WithoutStops([Stops.ReiterwegJägerallee, Stops.JägertorJustizzentrum])
                        .WithStopBetween(Stops.AmPfingstberg, Stops.AmSchragenRussischeKolonie, Stops.Hebbelstr, M4, M0)
                        .WithStopBetween(Stops.AmSchragenRussischeKolonie, Stops.ReiterwegAlleestr, Stops.Hebbelstr, M2,
                            M0).WithStopBetween(Stops.ReiterwegAlleestr, Stops.Rathaus, Stops.Hebbelstr, M1, M2)).Map(route => route with
                    {
                        TimeProfiles =
                        [
                            route.TimeProfiles[0] with
                            {
                                StopDistances =
                                [
                                    ..route.TimeProfiles[0]
                                        .StopDistances[..Array.IndexOf(route.StopPositions, Stops.Kirschallee)],
                                    M2,
                                    ..route.TimeProfiles[0]
                                        .StopDistances
                                            [(Array.IndexOf(route.StopPositions, Stops.Kirschallee) + 1)..]
                                ]
                            }
                        ]
                    }),
            ..Previous.Line.Routes[2..],
        ],
        TripsCreate = Previous.Line.TripsCreate.Select(trip =>
            trip.RouteIndex.Equals(0) && trip.TimeProfileIndex.Equals(1)
                ? trip with { TimeProfileIndex = 0 }
                : trip).ToArray(),
    };
}

file static class Extensions
{
    public static T Map<T>(this T self, Func<T, T> mapper) => mapper(self);
}
