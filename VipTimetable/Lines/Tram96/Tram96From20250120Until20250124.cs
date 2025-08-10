using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Tram96;

public class Tram96From20250120Until20250124 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 1, 20);
    public DateOnly? ValidUntilInclusive() => new DateOnly(2025, 1, 24);

    private static Tram96From20241215 Original { get; } = new();

    public Line Line { get; } = Original.Line with
    {
        MainRouteIndices = [..Original.Line.MainRouteIndices, 1 /* CJ > Bisamkiez */, 8 /* Bisamkiez > CJ */],
        Routes =
        [
            ..Original.Line.Routes[..1], Original.Line.Routes[1] with
            {
                TimeProfiles =
                [
                    ..Original.Line.Routes[1].TimeProfiles,
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M2, M1, M1, M1, M1, M1, M1, M1, M1, M2, M2, M1, M1, M4, M2, M0, M1, M1, M2, M2,],
                    },
                ],
            },
            ..Original.Line.Routes[2..8], Original.Line.Routes[8] with
            {
                TimeProfiles =
                [
                    ..Original.Line.Routes[8].TimeProfiles,
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M2, M1, M1, M1, M5, M1, M1, M3, M1, M1, M1, M0, M2, M2, M1, M1, M1, M1, M3,],
                    },
                ],
            },
            ..Original.Line.Routes[9..],
        ],
        TripsCreate = Original.Line.TripsCreate.SelectMany(trip =>
        {
            List<Line.TripCreate>? returnTrips = null;
            if (trip.RouteIndex.Equals(0 /* CJ > MJS */))
            {
                if (trip.StartTime > new TimeOnly(19, 3) ||
                    trip.StartTime < new TimeOnly(2, 0))
                {
                    returnTrips =
                    [
                        trip with
                        {
                            DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekend,
                        },
                        trip with
                        {
                            DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekday,
                            RouteIndex = 1,
                            TimeProfileIndex =
                            trip.StartTime > new TimeOnly(19, 50) || trip.StartTime < new TimeOnly(2, 0) ? 1 : 0,
                        },
                    ];
                }
            }
            else if (trip.RouteIndex.Equals(1 /* CJ > Bisamkiez */))
            {
                returnTrips =
                [
                    trip with
                    {
                        DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekend,
                    },
                    trip with
                    {
                        DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekday,
                        TimeProfileIndex = 1,
                    },
                ];
            }
            else if (trip.RouteIndex.Equals(4 /* PdE > Bisamkiez */))
            {
                returnTrips = [];
            }
            else if (trip.RouteIndex.Equals(6 /* MJS > PdE */))
            {
                returnTrips = [];
            }
            else if (trip.RouteIndex.Equals(5 /* MJS > CJ */))
            {
                if (trip.StartTime > new TimeOnly(19, 50) || trip.StartTime < new TimeOnly(2, 0))
                {
                    returnTrips =
                    [
                        trip with
                        {
                            DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekend,
                        },
                        trip with
                        {
                            DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekday,
                            RouteIndex = 8,
                            TimeProfileIndex = 1,
                            StartTime = trip.StartTime.AddMinutes(11),
                        },
                    ];
                }
            }

            return returnTrips ?? [trip];
        }).Where(trip => trip.DaysOfOperation != DaysOfOperation.None).ToArray(),
    };
}
