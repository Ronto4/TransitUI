using Timetables.Models;
using static Timetables.Vip.Minutes;

namespace Timetables.Vip.Lines.Bus690;

public class Bus690From20241214 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 12, 14);

    public Line Line { get; } = new()
    {
        Name = "690",
        TransportationType = TransportationType.Bus,
        MainRouteIndices = [0, 1],
        OverviewRouteIndices = [0, 1],
        Annotations = new Dictionary<string, string>
        {
            { "A", "nach kurzem Aufenthalt zurück nach S Hauptbahnhof" }
        },
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.SHauptbahnhof,
                    Stops.Schlaatzstr,
                    Stops.Übergang,
                    Stops.RathausBabelsberg,
                    Stops.SBabelsbergSchulstr,
                    Stops.HorstwegGroßbeerenstr,
                    Stops.HeinrichVonKleistStr,
                    Stops.AmFindlingWilliFrohweinPlatz,
                    Stops.Eichenweg,
                    Stops.KleineStr,
                    Stops.Filmpark,
                    Stops.BahnhofMedienstadtBabelsberg,
                    Stops.BahnhofMedienstadtBabelsberg,
                    Stops.Katjes,
                    Stops.BetriebshofViP,
                    Stops.AbzweigBetriebshofViP,
                    Stops.SternCenterNuthestr,
                    Stops.OttoHahnRing,
                    Stops.MaxBornStr,
                    Stops.JohannesKeplerPlatz,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M3, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M0, M1, M3, M3, M1, M1,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M2, M1, M1, M1, M1, M1, M1, M1, M0, M0, M1, M0, M1, M3, M3, M1, M1,],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.JohannesKeplerPlatz,
                    Stops.BetriebshofViP,
                    Stops.BahnhofMedienstadtBabelsberg,
                    Stops.BahnhofMedienstadtBabelsberg,
                    Stops.Filmpark,
                    Stops.KleineStr,
                    Stops.Eichenweg,
                    Stops.AmFindlingWilliFrohweinPlatz,
                    Stops.HeinrichVonKleistStr,
                    Stops.HorstwegGroßbeerenstr,
                    Stops.SBabelsbergSchulstr,
                    Stops.RathausBabelsberg,
                    Stops.Übergang,
                    Stops.Schlaatzstr,
                    Stops.SHauptbahnhof,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                        { StopDistances = [M3, M2, M1, M1, M1, M1, M1, M1, M1, M1, M2, M2, M1, M2,], },
                    new Line.Route.TimeProfile
                        { StopDistances = [M3, M2, M1, M0, M1, M1, M1, M0, M1, M1, M1, M2, M1, M1,], },
                ],
                CommonStopIndex = 0,
            },
        ],
        TripsCreate =
        [
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 58),
                AnnotationSymbol = "A",
            }.AlsoEvery(M20, new TimeOnly(20, 18)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(5, 38),
                AnnotationSymbol = "A",
            }.AlsoEvery(M60, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(5, 58),
                AnnotationSymbol = "A",
            }.AlsoEvery(M60, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(7, 38),
                AnnotationSymbol = "A",
            }.AlsoEvery(M20, new TimeOnly(20, 18)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 43),
                AnnotationSymbol = "A",
            }.AlsoEvery(M20, new TimeOnly(0, 23)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(0, 43),
            }.AlsoEvery(M20, 2),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 25),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 5),
            }.AlsoEvery(M20, new TimeOnly(20, 45)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(5, 25),
            }.AlsoEvery(M60, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(6, 5),
            }.AlsoEvery(M60, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(8, 5),
            }.AlsoEvery(M20, new TimeOnly(20, 45)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(21, 4),
            }.AlsoEvery(M20, new TimeOnly(0, 44)),
        ],
    };
}
