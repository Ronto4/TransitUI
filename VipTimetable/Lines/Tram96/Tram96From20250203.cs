using Timetable;

namespace VipTimetable.Lines.Tram96;

public class Tram96From20250203 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 2, 3);
    private static Tram96From20241215 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        TripsCreate =
        [
            ..Previous.Line.TripsCreate.Select(trip =>
                trip.RouteIndex.Equals(4) && trip.StartTime == new TimeOnly(20, 52)
                    ?
                    trip with { StartTime = trip.StartTime.AddMinutes(6) }
                    : trip.RouteIndex.Equals(0) && trip.DaysOfOperation == DaysOfOperation.Weekend &&
                      trip.StartTime == new TimeOnly(10, 3)
                        ? trip with { TimeProfileIndex = 0 }
                        : trip.RouteIndex.Equals(7) && trip.StartTime == new TimeOnly(5, 21)
                            ? trip with { StartTime = trip.StartTime.AddMinutes(-1) }
                            : trip).ToArray(),
            // For future reference: This trip was previously part of a 92 from Kirschallee to Marie-Juchacz-Str.
            // that was cut back to end at Bisamkiez instead.
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(8, 37),
            },
        ],
    };
}
