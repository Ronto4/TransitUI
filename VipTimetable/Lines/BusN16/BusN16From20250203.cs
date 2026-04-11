using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.BusN16;

public class BusN16From20250203 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 2, 3);
    private static BusN16From20241215 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        Routes =
        [
            Previous.Line.Routes[0] with
            {
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M3, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1,],
                    },
                ],
            },
            Previous.Line.Routes[1] with
            {
                TimeProfiles = [new Line.Route.TimeProfile { StopDistances = [M2, M1, M1, M1, M1, M1, M1,], },],
            },
            Previous.Line.Routes[2] with
            {
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M0, M1,
                            M1, M2,
                        ],
                    },
                ],
            },
            ..Previous.Line.Routes[3..],
        ],
    };
}
