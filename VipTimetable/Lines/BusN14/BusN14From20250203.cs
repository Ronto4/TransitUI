using Timetable;
using static VipTimetable.Minutes;


namespace VipTimetable.Lines.BusN14;

public class BusN14From20250203 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 2, 3);
    private static BusN14From20241214 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        Routes = Previous.Line.Routes
            .Select((route, index) =>
                index < 2
                    ? route with
                    {
                        TimeProfiles =
                        [
                            route.TimeProfiles[0] with
                            {
                                StopDistances =
                                [
                                    ..route.TimeProfiles[0].StopDistances[..20], M1,
                                    ..route.TimeProfiles[0].StopDistances[21..]
                                ]
                            }
                        ]
                    }
                    : route.StopPositions[0].Stop == Stops.JohannesKeplerPlatz
                        ? route.WithoutStop(Stops.ZumHeizwerk, false)
                            .WithStopBetween(Stops.DrewitzerStrAmBuchhorst, Stops.AnDerBrauerei, Stops.AmMoosfenn, M1,
                                M60)
                            .WithStopBetween(Stops.AnDerBrauerei, Stops.BergholzRehbrückeVerdistr, Stops.AmMoosfenn, M0,
                                M60)
                            .WithStopBetween(Stops.BergholzRehbrückeVerdistr, Stops.BahnhofRehbrückeSüd,
                                Stops.AmMoosfenn, M1, M60)
                            .WithStopBetween(Stops.BahnhofRehbrückeSüd,
                                Stops.BahnhofRehbrücke, Stops.AmMoosfenn, M1, M1)
                        : route)
            .Select(route =>
                route.StopPositions.Last().Stop == Stops.ScienceParkUniversität
                    ? route
                        .WithoutStop(Stops.WerderscherDammForststr, false)
                        .WithStopBetween(Stops.SchlüterstrForststr,
                            Stops.WerderscherDammForststr, Stops.BahnhofParkSanssouci, M0, M1)
                        .WithoutStop(Stops.NeuesPalais, false)
                        .WithStopBetween(Stops.BahnhofParkSanssouci, Stops.NeuesPalais,
                            Stops.CampusUniversitätAbrahamGeigerKolleg, M1, M1)
                        .WithoutStop(Stops.StudentenwohnheimEiche, false)
                        .WithStopBetween(Stops.AbzweigNachEiche, Stops.StudentenwohnheimEiche,
                            Stops.KaiserFriedrichStrPolizei, M1, M1)
                    : route)
            .ToArray(),
        TripsCreate = Previous.Line.TripsCreate.Select(trip =>
            trip.RouteIndex.Equals(0) || trip.RouteIndex.Equals(1)
                ? trip with { StartTime = trip.StartTime.AddMinutes(-1) }
                : trip).ToArray(),
    };
}
