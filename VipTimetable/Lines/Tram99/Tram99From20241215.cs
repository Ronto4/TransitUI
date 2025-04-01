using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Tram99;

public class Tram99From20241215 : ILineInstance
{
    private static readonly Tram99From20240102 Previous = new();
    public DateOnly ValidFrom { get; } = new(2024, 12, 15);

    public Line Line { get; } = Previous.Line with
    {
        TripsCreate =
        [
            ..Previous.Line.TripsCreate.Select(trip =>
                new TimeOnly(6, 0) <= trip.StartTime && trip.StartTime < new TimeOnly(20, 0) ||
                trip.StartTime == new TimeOnly(20, 6) || trip.StartTime == new TimeOnly(21, 26)
                    ? trip with
                    {
                        DaysOfOperation = trip.DaysOfOperation & ~DaysOfOperation.Weekday,
                    }
                    : trip).Where(trip => trip.DaysOfOperation != DaysOfOperation.None),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 53),
            }.AlsoEvery(M20, new TimeOnly(18, 53)),
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(19, 13),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(19, 36)
            }.AlsoEvery(M20, 2),
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(20, 6),
            },
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(21, 26),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 15),
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(7, 6),
            }.AlsoEvery(M20, new TimeOnly(19, 6)),
            new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(19, 15),
            },
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(19, 54),
            },
        ],
    };
}
