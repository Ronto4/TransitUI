using System.Numerics;
using Timetables.Models;

namespace Timetables.Vip.Lines.Tram93;

using static Minutes;

public class Tram93From20240909Until20240920 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 9, 9);
    public DateOnly? ValidUntilInclusive() => new(2024, 9, 20);

    public Line Line { get; } = new()
    {
        Name = "93",
        TransportationType = TransportationType.Tram,
        MainRouteIndices = [0, 1],
        OverviewRouteIndices = [0, 1],
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.PlatzDerEinheitNord,
                    Stops.PlatzDerEinheitWest,
                    Stops.AlterMarktLandtag,
                    Stops.LangeBrücke,
                    Stops.SHauptbahnhof,
                    Stops.Friedhöfe,
                    Stops.Sporthalle,
                    Stops.KunersdorferStr,
                    Stops.WaldstrHorstweg,
                    Stops.EduardClaudiusStrHeinrichMannAllee,
                    Stops.ZumKahleberg,
                    Stops.FriedrichWolfStr,
                    Stops.AmMoosfenn,
                    Stops.BahnhofRehbrücke
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M3, M2, M1, M1, M1, M1, M1, M1, M1, M2] },
                    new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M3, M2, M0, M1, M1, M1, M1, M1, M1, M2] },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.BahnhofRehbrücke,
                    Stops.AmMoosfenn,
                    Stops.FriedrichWolfStr,
                    Stops.ZumKahleberg,
                    Stops.EduardClaudiusStrHeinrichMannAllee,
                    Stops.WaldstrHorstweg,
                    Stops.KunersdorferStr,
                    Stops.Sporthalle,
                    Stops.Friedhöfe,
                    Stops.SHauptbahnhof,
                    Stops.LangeBrücke,
                    Stops.AlterMarktLandtag,
                    Stops.PlatzDerEinheitBildungsforum,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile { StopDistances = [M0, M1, M1, M1, M2, M1, M0, M1, M4, M1, M1, M2] },
                    new Line.Route.TimeProfile { StopDistances = [M0, M1, M1, M1, M1, M1, M1, M1, M4, M1, M1, M2] }
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Bisamkiez,
                    Stops.MagnusZellerPlatz,
                    Stops.WaldstrHorstweg,
                    Stops.KunersdorferStr,
                    Stops.Sporthalle,
                    Stops.Friedhöfe,
                    Stops.SHauptbahnhof,
                    Stops.LangeBrücke,
                    Stops.AlterMarktLandtag,
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.PlatzDerEinheitNord,
                ],
                TimeProfiles =
                    [new Line.Route.TimeProfile { StopDistances = [M1, M2, M1, M0, M1, M4, M1, M1, M2, M1] }],
                CommonStopIndex = 1,
            }
        ],
        TripsCreate =
        [
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(5, 13)
            }.AlsoEvery(M20, new TimeOnly(7, 53)),
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 58)
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(8, 6)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(8, 14)
            }.AlsoEvery(M20, new TimeOnly(9, 54)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School | DaysOfOperation.Saturday | DaysOfOperation.Sunday,
                StartTime = new TimeOnly(10, 14)
            }.AlsoEvery(M20, new TimeOnly(19, 54)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School | DaysOfOperation.Saturday | DaysOfOperation.Sunday,
                StartTime = new TimeOnly(20, 14)
            }.AlsoEvery(M20, new TimeOnly(20, 54)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(5, 37)
            }.AlsoEvery(M20, new TimeOnly(8, 37)),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(7, 22)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(8, 57)
            }.AlsoEvery(M20, new TimeOnly(10, 37)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School | DaysOfOperation.Saturday | DaysOfOperation.Sunday,
                StartTime = new TimeOnly(10, 57)
            }.AlsoEvery(M20, new TimeOnly(19, 37)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School | DaysOfOperation.Saturday | DaysOfOperation.Sunday,
                StartTime = new TimeOnly(19, 54)
            }.AlsoEvery(M20, new TimeOnly(20, 34)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(4, 59)
            }.AlsoEvery(M20, 2),
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(5, 34)
            },
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 41)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(7, 59)
            }.AlsoEvery(M20, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(9, 59)
            }.AlsoEvery(M20, 3),
        ],
    };
}
