using Timetables.Models;
using static Timetables.Vip.Minutes;

namespace Timetables.Vip.Lines.Bus693;

public class Bus693From20241214 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 12, 14);

    public Line Line { get; } = new()
    {
        Name = "693",
        TransportationType = TransportationType.Bus,
        MainRouteIndices = [0, 1, 2, 3],
        OverviewRouteIndices = [0, 2],
        Annotations = new Dictionary<string, string>
        {
            { "H", "weiter als 694 Richtung S Hauptbahnhof" },
            { "B", "kommt als 694 aus Richtung S Hauptbahnhof" },
        },
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.SBabelsbergLutherplatz,
                    Stops.RathausBabelsberg,
                    Stops.SBabelsbergSchulstr,
                    Stops.HorstwegGroßbeerenstr,
                    Stops.Falkenhorst,
                    Stops.Schilfhof,
                    Stops.MagnusZellerPlatz,
                    Stops.EduardClaudiusStrDrewitzerStr,
                    Stops.UnderDenEichen,
                    Stops.AmFenn,
                    Stops.DrewitzerStrErichWeinertStr,
                    Stops.AmMoosfenn,
                    Stops.BahnhofRehbrücke,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M2, M1, M1, M4, M1, M1, M1, M1, M1, M1, M2, M2],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M2, M1, M1, M4, M1, M1, M1, M1, M1, M1, M2, M1],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.RathausBabelsberg,
                    Stops.SBabelsbergSchulstr,
                    Stops.HorstwegGroßbeerenstr,
                    Stops.Falkenhorst,
                    Stops.Schilfhof,
                    Stops.MagnusZellerPlatz,
                    Stops.EduardClaudiusStrDrewitzerStr,
                    Stops.UnderDenEichen,
                    Stops.AmFenn,
                    Stops.DrewitzerStrErichWeinertStr,
                    Stops.AmMoosfenn,
                    Stops.BahnhofRehbrücke,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M2, M1, M4, M1, M1, M1, M1, M1, M1, M2, M1],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M2, M1, M4, M1, M1, M1, M1, M1, M1, M2, M2],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.BahnhofRehbrücke,
                    Stops.AmMoosfenn,
                    Stops.DrewitzerStrErichWeinertStr,
                    Stops.AmFenn,
                    Stops.UnderDenEichen,
                    Stops.EduardClaudiusStrDrewitzerStr,
                    Stops.MagnusZellerPlatz,
                    Stops.Schilfhof,
                    Stops.Falkenhorst,
                    Stops.Moosgarten,
                    Stops.HorstwegGroßbeerenstr,
                    Stops.SBabelsbergSchulstr,
                    Stops.RathausBabelsberg,
                    Stops.SBabelsbergLutherplatz,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M1, M1, M1, M1, M1, M1, M2, M1, M1, M2, M2],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M1, M1, M1, M1, M1, M1, M3, M1, M1, M2, M2],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M1, M0, M1, M1, M1, M2, M1, M1, M1, M2],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.BahnhofRehbrücke,
                    Stops.AmMoosfenn,
                    Stops.DrewitzerStrErichWeinertStr,
                    Stops.AmFenn,
                    Stops.UnderDenEichen,
                    Stops.EduardClaudiusStrDrewitzerStr,
                    Stops.MagnusZellerPlatz,
                    Stops.Schilfhof,
                    Stops.Falkenhorst,
                    Stops.Moosgarten,
                    Stops.HorstwegGroßbeerenstr,
                    Stops.SBabelsbergSchulstr,
                    Stops.RathausBabelsberg,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M1, M1, M1, M1, M1, M1, M2, M1, M1, M2],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M1, M1, M1, M1, M1, M1, M3, M1, M2, M2],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M1, M0, M1, M1, M1, M2, M1, M4, M1],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M1, M1, M1, M1, M1, M1, M2, M1, M2, M2],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M1, M1, M1, M1, M1, M1, M2, M1, M4, M2],
                    },
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
                StartTime = new TimeOnly(4, 53),
            }.AlsoEvery(M20, new TimeOnly(20, 13)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 54),
                AnnotationSymbols = ["B"],
            }.AlsoEvery(M20, new TimeOnly(6, 54)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(7, 13),
            }.AlsoEvery(M20, new TimeOnly(20, 13)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(7, 14),
                AnnotationSymbols = ["B"],
            }.AlsoEvery(M20, new TimeOnly(9, 14)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(9, 33),
            }.AlsoEvery(M20, new TimeOnly(20, 13)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 27),
            }.AlsoEvery(M20, new TimeOnly(21, 47)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(22, 3),
                AnnotationSymbols = ["B"],
            }.AlsoEvery(M20, new TimeOnly(1, 3)),
            // --- Other direction ---
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 34),
            }.AlsoEvery(M20, new TimeOnly(6, 54)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 4,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 14),
                AnnotationSymbols = ["H"],
            }.AlsoEvery(M20, new TimeOnly(6, 54)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(7, 14),
            }.AlsoEvery(M20, new TimeOnly(19, 34)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 4,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(6, 54),
                AnnotationSymbols = ["H"],
            }.AlsoEvery(M20, new TimeOnly(9, 14)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(9, 34),
            }.AlsoEvery(M20, new TimeOnly(19, 34)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 3,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 49),
                AnnotationSymbols = ["H"],
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 14),
            }.AlsoEvery(M20, new TimeOnly(8, 14)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(8, 34),
            }.AlsoEvery(M20, new TimeOnly(14, 14)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(14, 34),
            }.AlsoEvery(M20, new TimeOnly(16, 14)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(16, 34),
            }.AlsoEvery(M20, new TimeOnly(19, 34)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(19, 48),
            }.AlsoEvery(M20, new TimeOnly(21, 28)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(21, 48),
                AnnotationSymbols = ["H"],
            }.AlsoEvery(M20, new TimeOnly(0, 28)),
        ],
    };
}