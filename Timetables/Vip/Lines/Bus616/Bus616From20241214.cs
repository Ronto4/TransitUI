using Timetables.Models;
using static Timetables.Vip.Minutes;

namespace Timetables.Vip.Lines.Bus616;

public class Bus616From20241214 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 12, 14);

    public Line Line { get; } = new()
    {
        Name = "616",
        TransportationType = TransportationType.Bus,
        MainRouteIndices = [0, 1],
        OverviewRouteIndices = [0, 1],
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.SBabelsbergSchulstr,
                    Stops.RathausBabelsberg,
                    Stops.Spindelstr,
                    Stops.KarlLiebknechtStadion,
                    Stops.Sternwarte,
                    Stops.SchlossBabelsberg,
                    Stops.KarlMarxStrBehringstr,
                    Stops.HermannMaaßStr,
                    Stops.Scheffelstr,
                    Stops.Goetheplatz,
                    Stops.Plantagenstr,
                    Stops.RotdornwegStahnsdorferStr,
                    Stops.Lindenpark,
                    Stops.StahnsdorferStrAugustBebelStr,
                    Stops.SGriebnitzsee,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                        { StopDistances = [M2, M1, M1, M2, M1, M1, M1, M1, M1, M1, M1, M1, M1, M2] }
                ],
                CommonStopIndex = 5,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.SGriebnitzsee,
                    Stops.StahnsdorferStrAugustBebelStr,
                    Stops.Lindenpark,
                    Stops.RotdornwegStahnsdorferStr,
                    Stops.Plantagenstr,
                    Stops.Goetheplatz,
                    Stops.Scheffelstr,
                    Stops.HermannMaaßStr,
                    Stops.KarlMarxStrBehringstr,
                    Stops.SchlossBabelsberg,
                    Stops.Sternwarte,
                    Stops.KarlLiebknechtStadion,
                    Stops.Spindelstr,
                    Stops.RathausBabelsberg,
                    Stops.SBabelsbergSchulstr,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                        { StopDistances = [M1, M1, M1, M1, M2, M1, M1, M1, M1, M1, M2, M0, M2, M1,] }
                ],
                CommonStopIndex = 0,
            },
        ],
        TripsCreate =
        [
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 13)
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 53)
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(6, 33)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(7, 33)
            }.AlsoEvery(M60, new TimeOnly(19, 33)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 33)
            }.AlsoEvery(M20, new TimeOnly(9, 13)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(9, 53)
            }.AlsoEvery(M40, new TimeOnly(13, 13)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(13, 33)
            }.AlsoEvery(M20, new TimeOnly(16, 33)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(17, 13)
            }.AlsoEvery(M40, new TimeOnly(19, 53)),
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 34)
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(21, 14)
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(21, 34)
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(21, 54)
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(22, 44)
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(23, 44)
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Friday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(0, 44)
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 34)
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(6, 14)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 54),
            }.AlsoEvery(M20, new TimeOnly(8, 54)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(7, 14),
            }.AlsoEvery(M60, new TimeOnly(19, 14)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(9, 34)
            }.AlsoEvery(M40, new TimeOnly(12, 54)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(13, 14)
            }.AlsoEvery(M20, new TimeOnly(16, 54)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(17, 34)
            }.AlsoEvery(M40, new TimeOnly(19, 34)),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 13)
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(20, 53)
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(21, 13)
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(21, 33)
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(22, 23)
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(23, 23)
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Friday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(0, 23)
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Friday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(1, 23)
            },
        ],
    };
}
