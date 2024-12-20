using Timetables.Models;
using static Timetables.Vip.Minutes;

namespace Timetables.Vip.Lines.Bus612;

public class Bus612From20241214 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 12, 14);

    public Line Line { get; } = new()
    {
        Name = "612",
        TransportationType = TransportationType.Bus,
        MainRouteIndices = [0],
        OverviewRouteIndices = [0],
        Annotations = new Dictionary<string, string>
        {
            { "KB", "Einsatz eines Kleinbusses" },
        },
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.NeuTöplitzWendeplatz,
                    Stops.NeuTöplitzWeinbergstr,
                    Stops.TöplitzZurAltenFähre,
                    Stops.TöplitzSportplatz,
                    Stops.TöplitzFeuerwehr,
                    Stops.TöplitzKirschweg,
                    Stops.TöplitzLeesterStr,
                    Stops.LeestKirche,
                    Stops.LeestEichholzweg,
                    Stops.SchlänitzseeWeg,
                    Stops.AmKüssel,
                    Stops.WublitzstrAmBahnhof,
                    Stops.ScienceParkWest,
                    Stops.BahnhofGolm,
                    Stops.GolmerFichten,
                    Stops.ZumGroßenHerzberg,
                    Stops.Eichenring,
                    Stops.Mehlbeerenweg,
                    Stops.AmAltenMörtelwerk,
                    Stops.AmGrünenWeg,
                    Stops.KaiserFriedrichStrPolizei,
                    Stops.StudentenwohnheimEiche,
                    Stops.AbzweigNachEiche,
                    Stops.Katharinenholzstr,
                    Stops.Thaerstr,
                    Stops.Kirschallee,
                    Stops.JohanBoumanPlatz,
                    Stops.Ruinenbergstr,
                    Stops.CampusFachhochschule,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M0, M1, M1, M1, M1, M1, M1, M1, M1, M3, M1, M1, M1, M1, M1, M1, M0, M1, M1, M0, M2,
                            M2, M3, M1, M1, M2,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M0, M1, M1, M1, M1, M2, M1, M1, M1, M3, M1, M1, M1, M2, M1, M1, M0, M1, M1, M1, M2,
                            M3, M3, M2, M1, M2,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M0, M1, M1, M1, M1, M2, M1, M2, M1, M3, M1, M1, M1, M2, M1, M1, M1, M1, M1, M1, M2,
                            M3, M3, M2, M1, M2,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M0, M1, M1, M1, M1, M2, M1, M2, M1, M3, M1, M1, M1, M2, M1, M1, M0, M1, M1, M1, M2,
                            M3, M3, M2, M1, M2,
                        ],
                    },
                ],
                CommonStopIndex = 26,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.SchlänitzseeWeg,
                    Stops.AmKüssel,
                    Stops.WublitzstrAmBahnhof,
                    Stops.ScienceParkWest,
                    Stops.BahnhofGolm,
                    Stops.GolmerFichten,
                    Stops.ZumGroßenHerzberg,
                    Stops.Eichenring,
                    Stops.Mehlbeerenweg,
                    Stops.AmAltenMörtelwerk,
                    Stops.AmGrünenWeg,
                    Stops.KaiserFriedrichStrPolizei,
                    Stops.StudentenwohnheimEiche,
                    Stops.AbzweigNachEiche,
                    Stops.Katharinenholzstr,
                    Stops.Thaerstr,
                    Stops.Kirschallee,
                    Stops.JohanBoumanPlatz,
                    Stops.Ruinenbergstr,
                    Stops.CampusFachhochschule,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M3, M1, M1, M1, M2, M1, M1, M0, M1, M1, M1, M2,
                            M3, M3, M2, M1, M2,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M2, M1, M3, M1, M1, M1, M2, M1, M1, M0, M1, M1, M1, M2,
                            M3, M3, M2, M1, M2,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                ManualAnnotation = "via Bornim",
                StopPositions = [
                    Stops.SchlänitzseeWeg,
                    Stops.AmKüssel,
                    Stops.WublitzstrAmBahnhof,
                    Stops.Geiselberg,
                    Stops.SportplatzBornim,
                    Stops.Hugstr,
                    Stops.KircheBornim,
                    Stops.LindstedterChaussee,
                    Stops.Florastr,
                    Stops.AmundsenstrPotsdamerStr,
                    Stops.Thaerstr,
                    Stops.Kirschallee,
                    Stops.JohanBoumanPlatz,
                    Stops.Ruinenbergstr,
                    Stops.CampusFachhochschule,
                ],
                TimeProfiles = [new Line.Route.TimeProfile{StopDistances = [M2, M1, M1, M1, M1, M1, M0, M2, M1, M2, M3, M2, M1, M2]}],
                CommonStopIndex = 0,
            }
        ],
        TripsCreate =
        [
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 37),
                AnnotationSymbol = "KB",
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 41),
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 2),
                AnnotationSymbol = "KB",
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 27),
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 7),
            },
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(7, 30),
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 32),
                AnnotationSymbol = "KB",
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(8, 7),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 3,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(9, 8),
            }.AlsoEvery(M60, new TimeOnly(14, 8)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(15, 7),
            }.AlsoEvery(M60, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 3,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(17, 8),
            }.AlsoEvery(M60, new TimeOnly(18, 8)),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(18, 47),
                AnnotationSymbol = "KB",
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 3,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(19, 38),
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(20, 38),
                AnnotationSymbol = "KB",
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(21, 38),
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(22, 38),
                AnnotationSymbol = "KB",
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(6, 38),
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(8, 38),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 3,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 37),
            }.AlsoEvery(M120, new TimeOnly(18, 37)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(20, 38),
            }.AlsoEvery(M120, new TimeOnly(22, 38)),
        ],
    };
}
