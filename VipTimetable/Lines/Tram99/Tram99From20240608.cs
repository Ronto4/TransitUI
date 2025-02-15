using Timetable.Models;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Tram99;

public class Tram99From20240608 : ILineInstance
{
    private static readonly Tram99From20240102 Original = new();
    public DateOnly ValidFrom { get; } = new(2024, 6, 8);

    public Line Line { get; } = Original.Line with
    {
        Routes =
        [
            ..Original.Line.Routes[..3],
            Original.Line.Routes[3] with
            {
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M1, M1, M1, M1, M2, M1, M1, M0, M1]
                    }
                ]
            },
            Original.Line.Routes[4],
            Original.Line.Routes[5] with
            {
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M1, M1, M1, M4, M1, M1, M2, M1, M1, M1, M1, M1, M2, M1, M1, M0, M1]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M1, M0, M1, M4, M1, M1, M2, M1, M2, M1, M1, M1, M2, M1, M1, M1, M1]
                    }
                ]
            }
        ],
        TripsCreate =
        [
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(19, 36)
            }.AlsoEvery(M20, new TimeOnly(20, 36)),
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(20, 56)
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(20, 56)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(21, 16)
            }.AlsoEvery(M20, new TimeOnly(22, 56)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(23, 16)
            }.AlsoEvery(M20, new TimeOnly(23, 56)),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(0, 16)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(23, 16)
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(0, 36)
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(4, 25)
            }.AlsoEvery(M20, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(6, 25)
            }.AlsoEvery(M20, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(19, 54)
            }.AlsoEvery(M20, new TimeOnly(20, 54)),
            new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(21, 4)
            },
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(21, 14)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(21, 34)
            }.AlsoEvery(M20, new TimeOnly(23, 14)),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(23, 34)
            }.AlsoEvery(M20, new TimeOnly(23, 54)),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(0, 14)
            }.AlsoEvery(M20, new TimeOnly(0, 34)),
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(19, 59)
            }
        ]
    };
}
