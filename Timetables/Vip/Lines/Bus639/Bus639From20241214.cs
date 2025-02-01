using Timetables.Models;
using static Timetables.Vip.Minutes;

namespace Timetables.Vip.Lines.Bus639;

public class Bus639From20241214 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 12, 14);

    public Line Line { get; } = new()
    {
        Name = "639",
        TransportationType = TransportationType.Bus,
        MainRouteIndices = [0, 1, 2],
        OverviewRouteIndices = [0, 1],
        Annotations = new Dictionary<string, string>
        {
            { "KB", "Einsatz eines Kleinbusses" },
            { "G", "nach kurzem Aufenthalt weiter über Landesumweltamt zurück nach Am Park" }
        },
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.AmPark,
                    Stops.WaldsiedlungGroßGlienicke,
                ],
                TimeProfiles = [new Line.Route.TimeProfile { StopDistances = [M3,], },],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions = [
                    Stops.WaldsiedlungGroßGlienicke,
                    Stops.Landesumweltamt,
                    Stops.AmPark,
                    Stops.KircheGroßGlienicke,
                    Stops.AmAnger,
                ],
                TimeProfiles = [new Line.Route.TimeProfile { StopDistances = [M1, M2, M2, M1,], },],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions = [
                    Stops.WaldsiedlungGroßGlienicke,
                    Stops.Landesumweltamt,
                    Stops.AmPark,
                ],
                TimeProfiles = [new Line.Route.TimeProfile{StopDistances = [M1, M2,],},],
                CommonStopIndex = 0,
            },
        ],
        TripsCreate =
        [
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 25),
                AnnotationSymbols = ["KB", "G"],
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 44),
                AnnotationSymbols = ["KB", "G"],
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 13),
                AnnotationSymbols = ["KB"],
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 29),
                AnnotationSymbols = ["KB"],
            },
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 48),
                AnnotationSymbols = ["KB"],
            },
        ],
    };
}