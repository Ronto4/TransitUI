using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus699;

public class Bus699From20241215 : ILineInstance
{
    private static readonly Bus699From20241214 Previous = new();
    public DateOnly ValidFrom { get; } = new(2024, 12, 15);

    public Line Line { get; } = Previous.Line with
    {
        Routes =
        [
            ..Previous.Line.Routes[..2],
            new Line.Route
            {
                StopPositions =
                [
                    Stops.JohannesKeplerPlatz,
                    Stops.Gerlachstr,
                    Stops.SternCenterGerlachstr,
                    Stops.HansAlbersStr,
                    Stops.RobertBaberskeStr,
                    Stops.KonradWolfAlleeSternstr,
                    Stops.DrewitzOrt,
                    Stops.TrebbinerStr,
                    Stops.DrewitzerStrAmBuchhorst,
                    Stops.ZumHeizwerk,
                    Stops.AmMoosfenn,
                    Stops.BahnhofRehbrücke,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile { StopDistances = [M3, M1, M2, M2, M1, M1, M1, M2, M1, M5, M2,], },
                    new Line.Route.TimeProfile { StopDistances = [M3, M1, M2, M2, M1, M1, M1, M2, M1, M5, M1,], },
                    new Line.Route.TimeProfile { StopDistances = [M2, M1, M2, M1, M2, M1, M1, M2, M1, M5, M1,], },
                ],
                CommonStopIndex = 0,
            }
        ],
        TripsCreate =
        [
            ..Previous.Line.TripsCreate.Select<Line.TripCreate, Line.TripCreate?>(trip =>
            {
                if (trip.RouteIndex.Equals(0) || trip.RouteIndex.Equals(1))
                {
                    // Bf Rehbrücke > J.-Kepler-Platz
                    if (new TimeOnly(5, 18) <= trip.StartTime && trip.StartTime <= new TimeOnly(20, 18))
                    {
                        return trip with { StartTime = trip.StartTime.AddMinutes(8), };
                    }

                    if (trip.StartTime == new TimeOnly(20, 35))
                    {
                        if (trip.DaysOfOperation == DaysOfOperation.Saturday)
                        {
                            return null;
                        }

                        return trip with
                        {
                            DaysOfOperation = DaysOfOperation.Sunday, StartTime = new TimeOnly(20, 46),
                        };
                    }

                    if (trip.StartTime == new TimeOnly(20, 38))
                    {
                        return null;
                    }

                    if (trip.StartTime == new TimeOnly(0, 31))
                    {
                        return trip with { StartTime = new TimeOnly(0, 33), };
                    }
                }
                else if (trip.RouteIndex.Equals(2))
                {
                    // J.-Kepler-Platz > Bf Rehbrücke
                    // Will be re-added later on.
                    return null;
                }

                return trip;
            }).NonNull(),
            // Trips J.-Kepler-Platz > Bf Rehbrücke
            ..new Line.TripCreate
            {
                RouteIndex = 2, TimeProfileIndex = 0, DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 2),
            }.AlsoEvery(M20, new TimeOnly(5, 42)),
            ..new Line.TripCreate
            {
                RouteIndex = 2, TimeProfileIndex = 1, DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 3),
            }.AlsoEvery(M20, new TimeOnly(19, 43)),
            ..new Line.TripCreate
            {
                RouteIndex = 2, TimeProfileIndex = 2, DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(20, 4),
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 2, TimeProfileIndex = 1, DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 5),
            }.AlsoEvery(M60, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 2, TimeProfileIndex = 1, DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(6, 45),
            }.AlsoEvery(M20, new TimeOnly(19, 45)),
            ..new Line.TripCreate
            {
                RouteIndex = 2, TimeProfileIndex = 2, DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(20, 5),
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 2, TimeProfileIndex = 1, DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(7, 5),
            }.AlsoEvery(M60, new TimeOnly(19, 5)),
            new Line.TripCreate
            {
                RouteIndex = 2, TimeProfileIndex = 2, DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(20, 5),
            },
            new Line.TripCreate
            {
                RouteIndex = 2, TimeProfileIndex = 2, DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 50),
            },
            new Line.TripCreate
            {
                RouteIndex = 2, TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekday | DaysOfOperation.Saturday, StartTime = new TimeOnly(21, 10),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 2, TimeProfileIndex = 2, DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(21, 50),
            }.AlsoEvery(M60, new TimeOnly(23, 50)),
        ],
    };
}

file static class Extensions
{
    public static IEnumerable<T> NonNull<T>(this IEnumerable<T?> enumerable) where T : struct =>
        enumerable.Where(element => element is not null).Cast<T>();
}
