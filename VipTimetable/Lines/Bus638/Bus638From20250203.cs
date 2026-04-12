using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus638;

public class Bus638From20250203 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 2, 3);
    private static Bus638From20241215 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        Routes =
        [
            ..Previous.Line.Routes[..2], ..Previous.Line.Routes[3..5], Previous.Line.Routes[5] with
            {
                TimeProfiles =
                [
                    ..Previous.Line.Routes[5].TimeProfiles,
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M2, M1, M2, M2, M2, M1, M1, M1, M1, M1, M4, M2, M1, M1, M1, M1, M1, M3,
                        ],
                    },
                ],
            },
            Previous.Line.Routes[6], new Line.Route
            {
                StopPositions =
                [
                    Stops.CampusJungfernsee,
                    Stops.AmundsenstrNedlitzerStr,
                    Stops.Römerschanze,
                    Stops.HeinrichHeineWeg,
                    Stops.Bassewitz,
                    Stops.Krampnitzsee,
                    Stops.Bullenwinkel,
                    Stops.AmSchlahn,
                    Stops.TheodorFontaneStr,
                    Stops.KircheGroßGlienicke,
                ],
                TimeProfiles = [new Line.Route.TimeProfile { StopDistances = [M2, M1, M1, M1, M2, M2, M1, M1, M1,], },],
                CommonStopIndex = 0,
            },
            ..Previous.Line.Routes[8..],
        ],
        MainRouteIndices = Previous.Line.MainRouteIndices
            .Select(index => new Index(index.Value >= 2 ? index.Value - 1 : index.Value)).ToArray(),
        OverviewRouteIndices = Previous.Line.OverviewRouteIndices
            .Select(index => new Index(index.Value >= 2 ? index.Value - 1 : index.Value)).ToArray(),
        TripsCreate =
        [
            ..Previous.Line.TripsCreate.Select(trip =>
                trip.RouteIndex.Value > 2 ? trip with { RouteIndex = new Index(trip.RouteIndex.Value - 1) } :
                trip.RouteIndex.Equals(2) ? trip with
                {
                    RouteIndex = 4, StartTime = trip.StartTime.AddMinutes(2), TimeProfileIndex = 1,
                } :
                trip).Where(trip => !trip.RouteIndex.Equals(6)).Select(trip =>
                trip.RouteIndex.Value > 4 &&
                (trip.StartTime > new TimeOnly(20, 30) || trip.StartTime < new TimeOnly(1, 0))
                    ? trip with { StartTime = trip.StartTime.AddMinutes(2) }
                    : trip),
            new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 37)
            },
        ],
    };
}
