using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Tram92;

public class Tram92From20250404Until20250405 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 4, 4);
    public DateOnly? ValidUntilInclusive() => new DateOnly(2025, 4, 5);
    private static Tram92From20250203 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        Annotations = new Dictionary<string, string>
        {
            { "A", "ab Platz der Einheit/West weiter als Linie 99 nach Babelsberg, Fontanestr." },
            { "B", "ab Platz der Einheit/West weiter als Linie 93 nach Glienicker Brücke" },
        },
        MainRouteIndices = [..Previous.Line.MainRouteIndices, 8, 9],
        Routes =
        [
            ..Previous.Line.Routes,
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Kirschallee,
                    Stops.JohanBoumanPlatz,
                    Stops.HannesMeyerStr,
                    Stops.Wiesenpark,
                    Stops.CampusFachhochschule,
                    Stops.AmSchragen,
                    Stops.Puschkinallee,
                    Stops.ReiterwegAlleestr,
                    Stops.Rathaus,
                    Stops.NauenerTor,
                    Stops.BrandenburgerStr,
                    Stops.PlatzDerEinheitWest,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M0, M2, M1, M1, M1, M1, M1, M1, M2,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M0, M1, M1, M1, M1, M1, M1, M1, M2, M2,],
                    },
                ],
                CommonStopIndex = 2, // Hannes-Meyer-Str.
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.PlatzDerEinheitWest,
                    Stops.BrandenburgerStr,
                    Stops.NauenerTor,
                    Stops.Rathaus,
                    Stops.ReiterwegAlleestr,
                    Stops.Puschkinallee,
                    Stops.AmSchragen,
                    Stops.CampusFachhochschule,
                    Stops.Wiesenpark,
                    Stops.HannesMeyerStr,
                    Stops.JohanBoumanPlatz,
                    Stops.Kirschallee,
                ],
                TimeProfiles =
                    [new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M0, M2, M2, M1, M0, M2, M1, M1,], },],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.PlatzDerEinheitNord,
                    Stops.BrandenburgerStr,
                    Stops.NauenerTor,
                    Stops.Rathaus,
                    Stops.ReiterwegAlleestr,
                    Stops.Puschkinallee,
                    Stops.AmSchragen,
                    Stops.CampusFachhochschule,
                    Stops.Wiesenpark,
                    Stops.HannesMeyerStr,
                    Stops.JohanBoumanPlatz,
                    Stops.Kirschallee,
                ],
                TimeProfiles =
                    [new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M0, M2, M2, M1, M0, M2, M1, M1,], },],
                CommonStopIndex = 0,
            },
        ],
        TripsCreate =
        [
            ..Previous.Line.TripsCreate.SelectMany<Line.TripCreate, Line.TripCreate>(trip =>
            {
                trip = trip with { DaysOfOperation = trip.DaysOfOperation & ~DaysOfOperation.Saturday, };
                var routeStartsAtKirschallee = trip.RouteIndex.Value is 0 or 1 or 2 or 3;
                var routeTowardsKirschallee = trip.RouteIndex.Value is 4 or 5 or 6 or 7;
                if (routeStartsAtKirschallee &&
                    (trip.StartTime < new TimeOnly(2, 0) || new TimeOnly(18, 20) < trip.StartTime))
                {
                    return [];
                }

                if (routeTowardsKirschallee &&
                    (trip.StartTime < new TimeOnly(2, 0) || new TimeOnly(18, 50) < trip.StartTime))
                {
                    return [];
                }

                return [trip];
            }).Where(trip => trip.DaysOfOperation != DaysOfOperation.None),
            ..new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(4, 55),
                AnnotationSymbols = ["B"],
            }.AlsoEvery(M20, new TimeOnly(19, 35)),
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Friday,
                StartTime = new TimeOnly(18, 30),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Friday,
                StartTime = new TimeOnly(18, 40),
            }.AlsoEvery(M10, new TimeOnly(19, 10)),
            ..new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Friday,
                StartTime = new TimeOnly(19, 31),
            }.AlsoEvery(M20, 2),
            new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(19, 53),
                AnnotationSymbols = ["B"],
            },
            new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(20, 8),
            },
            new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Friday,
                StartTime = new TimeOnly(20, 11),
                AnnotationSymbols = ["A"],
            },
            new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(20, 28),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 31),
                AnnotationSymbols = ["A"],
            }.AlsoEvery(M20, new TimeOnly(0, 31)),
            ..new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(0, 51),
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(4, 23),
            }.AlsoEvery(M20, 3),
            new Line.TripCreate
            {
                RouteIndex = 10,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 40),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 9,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 37),
            }.AlsoEvery(M20, new TimeOnly(19, 37)),
            new Line.TripCreate
            {
                RouteIndex = 9,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(19, 51),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 9,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(20, 5),
            }.AlsoEvery(M20, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 9,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Friday,
                StartTime = new TimeOnly(19, 2),
            }.AlsoEvery(M20, new TimeOnly(20, 42)),
            ..new Line.TripCreate
            {
                RouteIndex = 9,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(21, 2),
            }.AlsoEvery(M20, new TimeOnly(0, 42)),
        ],
    };
}
