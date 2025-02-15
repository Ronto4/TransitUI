using Timetable.Models;

namespace VipTimetable.Lines.Tram98;

using static Minutes;

public class Tram98From20240809 : ILineInstance
{
    private static readonly Tram98From20240226 Original = new();
    public DateOnly ValidFrom { get; } = new(2024, 8, 9);

    public Line Line { get; } = Original.Line with
    {
        MainRouteIndices = [..Original.Line.MainRouteIndices, 6, 9],
        Routes =
        [
            ..Original.Line.Routes, new Line.Route
            {
                StopPositions =
                [
                    Stops.SchlossCharlottenhof,
                    Stops.KastanienalleeZeppelinstr,
                    Stops.SchillerplatzSchafgraben,
                    Stops.BahnhofCharlottenhof,
                    Stops.AufDemKiewitt,
                    Stops.Feuerbachstr,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.Dortustr,
                    Stops.PlatzDerEinheitWest,
                    Stops.AlterMarktLandtag,
                    Stops.LangeBrücke,
                    Stops.SHauptbahnhofFriedrichEngelsStr
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M1, M1, M1, M1, M1, M3, M1, M1, M4]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M2, M1, M1, M1, M1, M1, M1, M2, M1, M1, M4]
                    }
                ],
                CommonStopIndex = 1,
            },
            new Line.Route
            {
                StopPositions = [
                    Stops.SchlossCharlottenhof,
                    Stops.KastanienalleeZeppelinstr,
                    Stops.SchillerplatzSchafgraben,
                    Stops.BahnhofCharlottenhof,
                    Stops.AufDemKiewitt,
                    Stops.Feuerbachstr,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.Dortustr,
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
                TimeProfiles = [new Line.Route.TimeProfile{StopDistances = [M2, M1, M1, M1, M1, M1, M1, M2, M1, M1, M3, M2, M0, M1, M1, M2, M2]}],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions = [
                    Stops.Bisamkiez,
                    Stops.MagnusZellerPlatz,
                    Stops.WaldstrHorstweg,
                    Stops.KunersdorferStr,
                    Stops.Sporthalle,
                    Stops.Friedhöfe,
                    Stops.SHauptbahnhof,
                    Stops.LangeBrücke,
                    Stops.AlterMarktLandtag,
                    Stops.PlatzDerEinheitWest,
                    Stops.Dortustr,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.Feuerbachstr,
                    Stops.AufDemKiewitt,
                    Stops.BahnhofCharlottenhofGeschwisterSchollStr,
                    Stops.SchlossCharlottenhof,
                ],
                TimeProfiles = [new Line.Route.TimeProfile{StopDistances = [M1, M2, M1, M0, M1, M4, M1, M1, M3, M1, M1, M2, M1, M1, M2]}],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions = [
                    Stops.SHauptbahnhof,
                    Stops.LangeBrücke,
                    Stops.AlterMarktLandtag,
                    Stops.PlatzDerEinheitWest,
                    Stops.Dortustr,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.Feuerbachstr,
                    Stops.AufDemKiewitt,
                    Stops.BahnhofCharlottenhofGeschwisterSchollStr,
                    Stops.SchlossCharlottenhof,
                ],
                TimeProfiles = [new Line.Route.TimeProfile{StopDistances = [M1, M1, M3, M1, M1, M2, M1, M1, M2]},
                new Line.Route.TimeProfile{StopDistances = [M1, M1, M3, M1, M1, M1, M1, M1, M2]}],
                CommonStopIndex = 0,
            },
        ],
        TripsCreate =
        [
            ..Original.Line.TripsCreate, ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(16, 20)
            }.AlsoEvery(M20, new TimeOnly(19, 20)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(21, 9)
            }.AlsoEvery(M20, new TimeOnly(23, 49)),
            new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(0, 9)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(0, 29)
            }.AlsoEvery(M20, new TimeOnly(0, 49)),
            ..new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(15, 56)
            }.AlsoEvery(M20, new TimeOnly(16, 16)),
            ..new Line.TripCreate
            {
                RouteIndex = 9,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(16, 45)
            }.AlsoEvery(M20, new TimeOnly(19, 45)),
            ..new Line.TripCreate
            {
                RouteIndex = 9,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(21, 27)
            }.AlsoEvery(M20, new TimeOnly(23, 47)),
            ..new Line.TripCreate
            {
                RouteIndex = 9,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(0, 7)
            }.AlsoEvery(M20, 2),
        ]
    };
}
