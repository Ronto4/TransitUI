using Timetable.Models;

namespace Timetable.Vip.Lines.Tram92;

using static Minutes;

public class Tram92From20240816Until20240818 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 8, 16);

    public DateOnly? ValidUntilInclusive() => new DateOnly(2024, 8, 18);

    public Line Line { get; } = new()
    {
        Name = "92",
        TransportationType = TransportationType.Tram,
        MainRouteIndices = [0, 1, 2, 3],
        OverviewRouteIndices = [1, 3],
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
                    Stops.MagnusZellerPlatz,
                    Stops.Bisamkiez,
                ],
                TimeProfiles =
                    [new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M3, M2, M1, M1, M1, M1, M2] }],
                CommonStopIndex = 0,
            },
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
                    Stops.MagnusZellerPlatz,
                    Stops.Bisamkiez,
                    Stops.AbzweigBetriebshofViP,
                    Stops.Turmstr,
                    Stops.JohannesKeplerPlatz,
                    Stops.MaxBornStr,
                    Stops.Gaußstr,
                    Stops.HansAlbersStr,
                    Stops.RobertBaberskeStr,
                    Stops.Priesterweg,
                    Stops.AmHirtengraben,
                    Stops.MarieJuchaczStr,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M3, M2, M1, M1, M1, M1, M2, M2, M1, M2, M1, M1, M1, M1, M1, M1, M2]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M3, M2, M1, M1, M1, M1, M2, M2, M1, M2, M1, M2, M1, M1, M1, M1, M2]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M3, M2, M0, M1, M1, M2, M2, M1, M1, M2, M1, M1, M1, M1, M1, M1, M2]
                    }
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
                CommonStopIndex = 9,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.MarieJuchaczStr,
                    Stops.AmHirtengraben,
                    Stops.Priesterweg,
                    Stops.RobertBaberskeStr,
                    Stops.HansAlbersStr,
                    Stops.Gaußstr,
                    Stops.MaxBornStr,
                    Stops.JohannesKeplerPlatz,
                    Stops.Turmstr,
                    Stops.AbzweigBetriebshofViP,
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
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M0, M1, M1, M1, M2, M1, M2, M0, M2, M2, M1, M2, M1, M0, M1, M4, M1, M1, M2, M1]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M0, M1, M1, M1, M2, M1, M1, M0, M2, M2, M1, M2, M1, M1, M1, M4, M1, M1, M2, M1]
                    }
                ],
                CommonStopIndex = 0,
            }
        ],
        TripsCreate =
        [
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(7, 2)
            }.AlsoEvery(M10, new TimeOnly(19, 12)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(8, 26)
            }.AlsoEvery(M20, new TimeOnly(10, 6)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 26)
            }.AlsoEvery(M20, new TimeOnly(19, 46)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(20, 19)
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(6, 48)
            }.AlsoEvery(M10, new TimeOnly(18, 48)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(8, 51)
            }.AlsoEvery(M20, new TimeOnly(19, 31)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(19, 39)
            }.AlsoEvery(M20, new TimeOnly(20, 19)),
        ],
    };
}
