using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.FerryF1;

public class FerryF1From20250418 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 4, 18);
    private static FerryF1From20241214 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        TripsCreate =
        [
            ..Previous.Line.TripsCreate
                .Select(trip => trip with { DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekday })
                .Where(trip => trip.DaysOfOperation != DaysOfOperation.None),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(8, 3),
            }.AlsoEvery(M15, new TimeOnly(10, 3)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 33),
            }.AlsoEvery(M15, new TimeOnly(12, 48)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(13, 18),
            }.AlsoEvery(M15, new TimeOnly(17, 18)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(17, 48),
            }.AlsoEvery(M15, new TimeOnly(19, 18)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(8, 10),
            }.AlsoEvery(M15, new TimeOnly(10, 10)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 40),
            }.AlsoEvery(M15, new TimeOnly(12, 55)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(13, 25),
            }.AlsoEvery(M15, new TimeOnly(17, 25)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(17, 55),
            }.AlsoEvery(M15, new TimeOnly(19, 25)),
        ],
    };
}
