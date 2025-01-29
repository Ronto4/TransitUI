using Timetables.Models;
using static Timetables.Vip.Minutes;

namespace Timetables.Vip.Lines.Bus696;

public class Bus696From20241214 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 12, 14);

    public Line Line { get; } = new()
    {
        Name = "696",
        TransportationType = TransportationType.Bus,
        MainRouteIndices = [0, 3],
        OverviewRouteIndices = [0, 3],
        Annotations = new Dictionary<string, string>
        {
            { "S", "weiter via Stern-Center/Gerlachstr. zurück nach S Griebnitzsee" },
        },
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.SGriebnitzsee,
                    Stops.StahnsdorferStrAugustBebelStr,
                    Stops.StudioBabelsberg,
                    Stops.BahnhofMedienstadtBabelsberg,
                    Stops.BahnhofMedienstadtBabelsberg,
                    Stops.Katjes,
                    Stops.BetriebshofViP,
                    Stops.AbzweigBetriebshofViP,
                    Stops.Gerlachstr,
                    Stops.KonradWolfAlleeSternstr,
                    Stops.RobertBaberskeStr,
                ],
                TimeProfiles =
                    [new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M1, M1, M0, M1, M3, M1, M1] }],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.SGriebnitzsee,
                    Stops.StahnsdorferStrAugustBebelStr,
                    Stops.StudioBabelsberg,
                    Stops.BahnhofMedienstadtBabelsberg,
                    Stops.BahnhofMedienstadtBabelsberg,
                    Stops.Katjes,
                    Stops.BetriebshofViP,
                ],
                TimeProfiles =
                    [new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M1, M1, M0] }],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.AbzweigBetriebshofViP,
                    Stops.Gerlachstr,
                    Stops.KonradWolfAlleeSternstr,
                    Stops.RobertBaberskeStr,
                ],
                TimeProfiles =
                    [new Line.Route.TimeProfile { StopDistances = [M3, M1, M1] }],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.RobertBaberskeStr,
                    Stops.HansAlbersStr,
                    Stops.SternCenterGerlachstr,
                    Stops.Gerlachstr,
                    Stops.BetriebshofViP,
                    Stops.BahnhofMedienstadtBabelsberg,
                    Stops.BahnhofMedienstadtBabelsberg,
                    Stops.StudioBabelsberg,
                    Stops.StahnsdorferStrAugustBebelStr,
                    Stops.SGriebnitzsee,
                ],
                TimeProfiles = [new Line.Route.TimeProfile { StopDistances = [M2, M2, M2, M3, M2, M1, M1, M1, M2] }],
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
                AnnotationSymbols = ["S"],
                StartTime = new TimeOnly(6, 4),
            }.AlsoEvery(M20, new TimeOnly(20, 44)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(21, 4),
            }.AlsoEvery(M20, new TimeOnly(21, 24)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                AnnotationSymbols = ["S"],
                StartTime = new TimeOnly(5, 30),
            }.AlsoEvery(M20, new TimeOnly(5, 50)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 35),
            }.AlsoEvery(M20, new TimeOnly(20, 55)),
        ],
    };
}