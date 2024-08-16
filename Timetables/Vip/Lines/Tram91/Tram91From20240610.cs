using Timetables.Models;

namespace Timetables.Vip.Lines.Tram91;

using static Minutes;

public class Tram91From20240610 : ILineInstance
{
    private static readonly Tram91From20240211 Original = new();
    public DateOnly ValidFrom { get; } = new DateOnly(2024, 6, 10);

    public Line Line { get; } = Original.Line with
    {
        Routes =
        [
            ..Original.Line.Routes[..2],
            Original.Line.Routes[2] with
            {
                TimeProfiles =
                [
                    Original.Line.Routes[2].TimeProfiles[0], new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M2, M1, M1, M1, M1, M1, M3, M1, M1, M3, M2, M1, M1, M1, M1, M2]
                    }
                ]
            },
            ..Original.Line.Routes[3..]
        ],
        TripsCreate =
        [
            ..Original.Line.TripsCreate,
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(8, 36),
            },
            new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(13, 5),
            },
        ],
    };
}
