using Timetable.Models;

namespace VipTimetable.Lines.Tram92;

using static Minutes;

public class Tram92From20240923 : ILineInstance
{
    private static readonly Tram92From20240610 Original = new();
    public DateOnly ValidFrom { get; } = new(2024, 9, 23);

    public Line Line { get; } = Original.Line with
    {
        Routes = Original.Line.Routes.Select(route =>
            {
                if (route.StopPositions[0].Stop != Stops.Kirschallee)
                {
                    return route;
                }

                return route with
                {
                    TimeProfiles = route.TimeProfiles.Select(profile => profile with
                    {
                        StopDistances = [..profile.StopDistances[..6], M2, ..profile.StopDistances[7..]],
                    }).ToArray()
                };
            }).Select((route, index) =>
            {
                // Special case for evening trips from S Hbf and Marie-Juchacz-Str. to Kirschallee.
                if (index is 6 or 8)
                {
                    return route with
                    {
                        TimeProfiles =
                        [
                            new Line.Route.TimeProfile
                            {
                                StopDistances =
                                [
                                    ..route.TimeProfiles[0].StopDistances[..^7], M2,
                                    ..route.TimeProfiles[0].StopDistances[^6..]
                                ]
                            },
                            new Line.Route.TimeProfile
                            {
                                StopDistances =
                                [
                                    ..route.TimeProfiles[1].StopDistances[..^6], M2,
                                    ..route.TimeProfiles[1].StopDistances[^5..]
                                ]
                            }
                        ]
                    };
                }

                if (route.StopPositions[^1].Stop != Stops.Kirschallee)
                {
                    return route;
                }

                return route with
                {
                    TimeProfiles = route.TimeProfiles.Select(profile => profile with
                    {
                        StopDistances = [..profile.StopDistances[..^7], M2, ..profile.StopDistances[^6..]],
                    }).ToArray()
                };
            })
            .ToArray(),
        TripsCreate = Original.Line.TripsCreate.Select(tripCreate =>
            {
                if (!tripCreate.TripCreateStartsAt(Stops.Kirschallee) || tripCreate.StartTime > new TimeOnly(19, 15) ||
                    tripCreate.StartTime < new TimeOnly(2, 0) ||
                    (tripCreate.DaysOfOperation & DaysOfOperation.Weekend) != 0)
                {
                    return tripCreate;
                }

                return tripCreate with
                {
                    StartTime = tripCreate.StartTime.AddMinutes(1),
                };
            }).Select(tripCreate =>
            {
                if (!tripCreate.TripCreateEndsAt(Stops.Kirschallee) || tripCreate.StartTime > new TimeOnly(20, 0) ||
                    tripCreate.StartTime < new TimeOnly(2, 0) ||
                    (tripCreate.DaysOfOperation & DaysOfOperation.Weekend) != 0 && tripCreate.StartTime > new TimeOnly(19, 38))
                {
                    return tripCreate;
                }

                return tripCreate with
                {
                    StartTime = tripCreate.StartTime.AddMinutes(2),
                };
            })
            .ToArray(),
    };
}

file static class TripCreateExtensions
{
    private static readonly Tram92From20240610 Original = new();

    public static bool TripCreateStartsAt(this Line.TripCreate tripCreate, Stop stop) =>
        Original.Line.Routes[tripCreate.RouteIndex].StopPositions[0].Stop == stop;

    public static bool TripCreateEndsAt(this Line.TripCreate tripCreate, Stop stop) =>
        Original.Line.Routes[tripCreate.RouteIndex].StopPositions[^1].Stop == stop;
}
