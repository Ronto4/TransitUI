using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Tram93;

public class Tram93From20250404Until20250405 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 4, 4);
    public DateOnly? ValidUntilInclusive() => new DateOnly(2025, 4, 5);
    private static Tram93From20240102 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        Annotations = new Dictionary<string, string>
        {
            { "A", "ab Platz der Einheit/West weiter als Linie 92 nach Kirschallee" },
            { "B", "ab Platz der Einheit/West weiter als Linie 96 nach Campus Jungfernsee" },
        },
        MainRouteIndices = [..Previous.Line.MainRouteIndices, 8, 10],
        Routes =
        [
            ..Previous.Line.Routes,
            new Line.Route
            {
                StopPositions =
                [
                    Stops.GlienickerBrücke,
                    Stops.LeonardoDaVinciStr,
                    Stops.Mangerstr,
                    Stops.SchiffbauergasseBerlinerStr,
                    Stops.Holzmarktstr,
                    Stops.BurgstrKlinikum,
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.PlatzDerEinheitWest,
                ],
                TimeProfiles = [new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M2, M1, M1, M2,], },],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.GlienickerBrücke,
                    Stops.LeonardoDaVinciStr,
                    Stops.Mangerstr,
                    Stops.SchiffbauergasseBerlinerStr,
                    Stops.Holzmarktstr,
                    Stops.BurgstrKlinikum,
                    Stops.PlatzDerEinheitNord,
                ],
                TimeProfiles = [new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M2, M1, M2,], },],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.PlatzDerEinheitWest,
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.BurgstrKlinikum,
                    Stops.Holzmarktstr,
                    Stops.SchiffbauergasseBerlinerStr,
                    Stops.Mangerstr,
                    Stops.LeonardoDaVinciStr,
                    Stops.GlienickerBrücke,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile { StopDistances = [M1, M1, M2, M1, M1, M1, M2,], },
                    new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M1, M1, M0, M2,], },
                ],
                CommonStopIndex = 6, // L.-d.-V.-Str.
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.PlatzDerEinheitNord,
                    Stops.PlatzDerEinheitWest,
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.BurgstrKlinikum,
                    Stops.Holzmarktstr,
                    Stops.SchiffbauergasseBerlinerStr,
                    Stops.Mangerstr,
                    Stops.LeonardoDaVinciStr,
                    Stops.GlienickerBrücke,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M2, M1, M1, M1, M2,], },
                    new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M1, M1, M1, M0, M2,], },
                ],
                CommonStopIndex = 7, // L.-d.-V.-Str.
            },
        ],
        TripsCreate =
        [
            ..Previous.Line.TripsCreate.SelectMany<Line.TripCreate, Line.TripCreate>(trip =>
            {
                trip = trip with { DaysOfOperation = trip.DaysOfOperation & ~DaysOfOperation.Saturday, };
                var routeStartsGb = trip.RouteIndex.Value is 0 or 1 or 2 or 3;
                var routeEndssGb = trip.RouteIndex.Value is 4 or 5 or 6 or 7;
                if (routeStartsGb && new TimeOnly(18, 30) < trip.StartTime)
                {
                    return [];
                }

                if (routeEndssGb && new TimeOnly(18, 40) < trip.StartTime)
                {
                    return [];
                }

                return [trip];
            }).Where(trip => trip.DaysOfOperation is not DaysOfOperation.None),
            new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 28),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 48),
                AnnotationSymbols = ["A"],
            }.AlsoEvery(M20, new TimeOnly(19, 28)),
            ..new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Friday,
                StartTime = new TimeOnly(18, 48),
                AnnotationSymbols = ["A"],
            }.AlsoEvery(M20, 2),
            new Line.TripCreate
            {
                RouteIndex = 9,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Friday,
                StartTime = new TimeOnly(19, 26),
            },
            new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(19, 46),
                AnnotationSymbols = ["B"],
            },
            new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Friday,
                StartTime = new TimeOnly(19, 47),
                AnnotationSymbols = ["B"],
            },
            ..new Line.TripCreate
            {
                RouteIndex = 9,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 8),
            }.AlsoEvery(M20, 3),
            new Line.TripCreate
            {
                RouteIndex = 9,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(21, 0),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 10,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 11),
            }.AlsoEvery(M20, new TimeOnly(19, 51)),
            new Line.TripCreate
            {
                RouteIndex = 10,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Friday,
                StartTime = new TimeOnly(19, 11),
            },
            new Line.TripCreate
            {
                RouteIndex = 11,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Friday,
                StartTime = new TimeOnly(19, 30),
            },
            new Line.TripCreate
            {
                RouteIndex = 10,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Friday,
                StartTime = new TimeOnly(19, 51),
            },
            new Line.TripCreate
            {
                RouteIndex = 10,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 8),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 11,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 27),
            }.AlsoEvery(M20, 2),
        ],
    };
}
