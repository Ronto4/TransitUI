using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus697;

public class Bus697From20250203 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 2, 3);
    private static Bus697From20241215 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        Routes =
        [
            ..Previous.Line.Routes[..3],
            Previous.Line.Routes[3] with
            {
                TimeProfiles =
                [
                    ..Previous.Line.Routes[3].TimeProfiles.Select((profile, index) =>
                        index == 0
                            ? profile with
                            {
                                StopDistances = [..profile.StopDistances[..13], M0, M3, ..profile.StopDistances[15..]]
                            }
                            : profile),
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M1, M1, M1, M1, M2, M3, M3, M2, M0, M3, M1, M2, M1, M2, M1, M1, M1, M1,
                            M2, M1, M4, M1, M1, M1, M1, M4, M1, M0, M1, M2, M1, M1, M2,
                        ],
                    },
                ],
            },
            ..Previous.Line.Routes[4..],
        ],
        TripsCreate = Previous.Line.TripsCreate
            .Select(trip => trip.RouteIndex.Equals(3) && trip.DaysOfOperation == DaysOfOperation.Weekday &&
                            new TimeOnly(14, 21) <= trip.StartTime &&
                            trip.StartTime <= new TimeOnly(16, 21)
                ? trip with { TimeProfileIndex = 3 }
                : trip).ToArray(),
    };
}
