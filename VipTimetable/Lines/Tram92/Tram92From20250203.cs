using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Tram92;

public class Tram92From20250203 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 2, 3);
    private static Tram92From20241215 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        Routes = [..Previous.Line.Routes[..4], ..Previous.Line.Routes[6..10], ..Previous.Line.Routes[11..]],
        MainRouteIndices = [0, 1, 2, 3, 4, 5, 6, 7,],
        OverviewRouteIndices = [0, 4],
        TripsCreate =
        [
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 50),
            }.AlsoEvery(M20, 2),
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 27),
            },
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(5, 50),
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 10),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 30),
            }.AlsoEvery(M10, 3),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 59),
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(7, 9),
            },
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(7, 19),
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(7, 29),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(7, 39),
            }.AlsoEvery(M10, new TimeOnly(8, 9)),
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(8, 19),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(8, 30),
            }.AlsoEvery(M20, new TimeOnly(9, 10)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(8, 40),
            }.AlsoEvery(M20, new TimeOnly(9, 0)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(9, 20),
            }.AlsoEvery(M10, new TimeOnly(12, 40)),
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(12, 47),
            },
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(12, 50),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(13, 0),
            }.AlsoEvery(M20, new TimeOnly(14, 20)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(13, 10),
            }.AlsoEvery(M20, new TimeOnly(14, 10)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(14, 29),
            }.AlsoEvery(M10, new TimeOnly(15, 29)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(15, 39),
            }.AlsoEvery(M20, new TimeOnly(16, 19)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(15, 49),
            }.AlsoEvery(M20, new TimeOnly(16, 9)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(16, 30),
            }.AlsoEvery(M10, new TimeOnly(17, 50)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(18, 0),
            }.AlsoEvery(M10, new TimeOnly(18, 40)),
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(18, 50),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(19, 0),
            }.AlsoEvery(M10, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(19, 31),
            }.AlsoEvery(M20, new TimeOnly(20, 11)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(5, 50),
            }.AlsoEvery(M20, new TimeOnly(6, 50)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(7, 9),
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(7, 49),
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(8, 30),
            }.AlsoEvery(M20, new TimeOnly(14, 10)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(14, 29),
            }.AlsoEvery(M20, new TimeOnly(16, 9)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(16, 30),
            }.AlsoEvery(M20, new TimeOnly(17, 50)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(18, 10),
            }.AlsoEvery(M20, new TimeOnly(19, 10)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(19, 31),
            }.AlsoEvery(M20, new TimeOnly(20, 11)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(4, 55),
            }.AlsoEvery(M20, new TimeOnly(6, 55)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(7, 15),
            }.AlsoEvery(M20, new TimeOnly(7, 55)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(8, 15),
            }.AlsoEvery(M20, new TimeOnly(9, 55)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 15),
            }.AlsoEvery(M20, new TimeOnly(19, 35)),
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(19, 53),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 3,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(20, 8),
            }.AlsoEvery(M20, 2),
            // These must be the last ones.
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 31),
            }.AlsoEvery(M20, new TimeOnly(0, 11)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(0, 31),
            }.AlsoEvery(M20, new TimeOnly(1, 11)),
            // The other direction.
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 8)
            }.AlsoEvery(M20, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(5, 17)
            }.AlsoEvery(M20, new TimeOnly(5, 57)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 8)
            }.AlsoEvery(M10, new TimeOnly(6, 58)),
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(7, 1)
            }.AlsoEvery(M10, new TimeOnly(7, 41)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(7, 58)
            }.AlsoEvery(M20, new TimeOnly(8, 38)),
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(7, 56)
            },
            new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(8, 21)
            },
            new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(8, 54)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(8, 48)
            }.AlsoEvery(M20, new TimeOnly(9, 28)),
            ..new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(9, 7)
            }.AlsoEvery(M20, new TimeOnly(9, 27)),
            ..new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(9, 47)
            }.AlsoEvery(M10, new TimeOnly(13, 17)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(13, 18)
            }.AlsoEvery(M10, new TimeOnly(13, 58)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(14, 18)
            }.AlsoEvery(M20, new TimeOnly(14, 58)),
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(14, 1)
            }.AlsoEvery(M20, new TimeOnly(17, 1)),
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(15, 11)
            }.AlsoEvery(M20, new TimeOnly(15, 51)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(16, 18)
            }.AlsoEvery(M20, new TimeOnly(16, 58)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(17, 18)
            }.AlsoEvery(M10, new TimeOnly(18, 8)),
            ..new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(18, 27)
            }.AlsoEvery(M10, new TimeOnly(18, 57)),
            ..new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(19, 17)
            }.AlsoEvery(M20, new TimeOnly(20, 37)),
            ..new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(5, 17)
            }.AlsoEvery(M20, new TimeOnly(7, 57)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(8, 8)
            }.AlsoEvery(M20, new TimeOnly(18, 8)),
            ..new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(18, 37)
            }.AlsoEvery(M20, new TimeOnly(20, 37)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(4, 23)
            }.AlsoEvery(M20, new TimeOnly(5, 23)),
            new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 26)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 52)
            }.AlsoEvery(M20, new TimeOnly(7, 12)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(6, 43)
            }.AlsoEvery(M20, 2),
            new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(7, 26)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(7, 32)
            }.AlsoEvery(M20, new TimeOnly(8, 12)),
            new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(8, 23)
            },
            new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(8, 32)
            },
            new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(8, 43)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(8, 51)
            }.AlsoEvery(M20, new TimeOnly(19, 11)),
            new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(19, 37)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(19, 39)
            }.AlsoEvery(M20, new TimeOnly(20, 19)),
            // This must be the last one.
            ..new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 57)
            }.AlsoEvery(M20, new TimeOnly(0, 37)),
        ],
    };
}
