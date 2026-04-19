using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Tram91;

public class Tram91From20250404Until20250405 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 4, 4);
    public DateOnly? ValidUntilInclusive() => new DateOnly(2025, 4, 5);
    private static Tram91From20250203 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        Annotations = new Dictionary<string, string>
        {
            { "B", "ab Platz der Einheit/West weiter als Linie 99 nach Babelsberg, Fontanestr." },
        },
        MainRouteIndices = [..Previous.Line.MainRouteIndices, 7, 8],
        Routes =
        [
            ..Previous.Line.Routes,
            new Line.Route
            {
                StopPositions =
                [
                    Stops.BahnhofPirschheide,
                    Stops.Luftschiffhafen,
                    Stops.ImBogenZeppelinstr,
                    Stops.KastanienalleeZeppelinstr,
                    Stops.SchillerplatzSchafgraben,
                    Stops.BahnhofCharlottenhof,
                    Stops.AufDemKiewitt,
                    Stops.Feuerbachstr,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.Dortustr,
                    Stops.PlatzDerEinheitWest,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M2, M1, M1, M1, M1, M1, M3,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M2, M1, M1, M1, M1, M1, M1, M2,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M2, M1, M1, M1, M1, M1, M2,],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.PlatzDerEinheitNord,
                    Stops.Dortustr,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.Feuerbachstr,
                    Stops.AufDemKiewitt,
                    Stops.BahnhofCharlottenhofGeschwisterSchollStr,
                    Stops.SchlossCharlottenhof,
                    Stops.KastanienalleeZeppelinstr,
                    Stops.ImBogenZeppelinstr,
                    Stops.Luftschiffhafen,
                    Stops.BahnhofPirschheide,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M2, M1, M1, M2, M1, M2, M1, M3,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M1, M1, M2, M2, M2, M1, M2,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M1, M1, M2, M1, M2, M1, M3,],
                    },
                ],
                CommonStopIndex = 0,
            },
        ],
        TripsCreate =
        [
            ..Previous.Line.TripsCreate.SelectMany<Line.TripCreate, Line.TripCreate>(trip =>
            {
                trip = trip with { DaysOfOperation = trip.DaysOfOperation & ~DaysOfOperation.Saturday, };
                if ((trip.RouteIndex.Equals(0) || trip.RouteIndex.Equals(1) || trip.RouteIndex.Equals(2)) &&
                    (trip.StartTime < new TimeOnly(2, 0) || new TimeOnly(18, 40) < trip.StartTime))
                {
                    return [];
                }

                if ((trip.RouteIndex.Equals(3) || trip.RouteIndex.Equals(4) || trip.RouteIndex.Equals(5) ||
                     trip.RouteIndex.Equals(6)) &&
                    (trip.StartTime < new TimeOnly(2, 0) || new TimeOnly(18, 40) < trip.StartTime))
                {
                    return [];
                }

                return [trip];
            }).Where(trip => trip.DaysOfOperation != DaysOfOperation.None),
            ..new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 12),
            }.AlsoEvery(M20, new TimeOnly(9, 52)),
            ..new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(10, 11),
            }.AlsoEvery(M20, new TimeOnly(18, 31)),
            ..new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(18, 51),
            }.AlsoEvery(M20, new TimeOnly(19, 31)),
            new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(19, 51),
                AnnotationSymbols = ["B"],
            },
            ..new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(19, 58),
            }.AlsoEvery(M20, 2),
            new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 28),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 38),
            }.AlsoEvery(M20, new TimeOnly(0, 58)),
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(4, 29),
            }.AlsoEvery(M20, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 43),
            }.AlsoEvery(M20, new TimeOnly(10, 23)),
            ..new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(10, 43),
            }.AlsoEvery(M20, new TimeOnly(18, 43)),
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Friday,
                StartTime = new TimeOnly(18, 49),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(19, 3),
            }.AlsoEvery(M20, new TimeOnly(20, 3)),
            ..new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 17),
            }.AlsoEvery(M20, new TimeOnly(0, 37)),
        ],
    };
}
