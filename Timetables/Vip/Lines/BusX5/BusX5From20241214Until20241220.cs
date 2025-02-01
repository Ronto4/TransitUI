using Timetables.Models;
using static Timetables.Vip.Minutes;

namespace Timetables.Vip.Lines.BusX5;

public class BusX5From20241214Until20241220 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 12, 14);
    public DateOnly? ValidUntilInclusive() => new(2024, 12, 20);

    public Line Line { get; } = new()
    {
        Name = "X5",
        TransportationType = TransportationType.Bus,
        MainRouteIndices = [0, 1, 2, 3],
        OverviewRouteIndices = [0, 2],
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.BahnhofGolm,
                    Stops.ScienceParkUniversität,
                    Stops.Baumschulenweg,
                    Stops.StudentenwohnheimEiche,
                    Stops.CampusUniversitätAbrahamGeigerKolleg,
                    Stops.NeuesPalais,
                    Stops.BahnhofParkSanssouci,
                    Stops.BahnhofParkSanssouci,
                    Stops.SchlossCharlottenhof,
                    Stops.KastanienalleeZeppelinstr,
                    Stops.BahnhofCharlottenhof,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.PlatzDerEinheitWest,
                    Stops.SHauptbahnhof,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile { StopDistances = [M1, M2, M3, M3, M1, M1, M0, M2, M2, M3, M3, M2, M4] }
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.CampusUniversitätAbrahamGeigerKolleg,
                    Stops.NeuesPalais,
                    Stops.BahnhofParkSanssouci,
                    Stops.BahnhofParkSanssouci,
                    Stops.SchlossCharlottenhof,
                    Stops.KastanienalleeZeppelinstr,
                    Stops.BahnhofCharlottenhof,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.PlatzDerEinheitWest,
                    Stops.SHauptbahnhof,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile { StopDistances = [M1, M1, M0, M2, M2, M3, M3, M2, M4] }
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.SHauptbahnhof,
                    Stops.PlatzDerEinheitWest,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.BahnhofCharlottenhofGeschwisterSchollStr,
                    Stops.BahnhofParkSanssouci,
                    Stops.NeuesPalais,
                    Stops.CampusUniversitätAbrahamGeigerKolleg,
                    Stops.StudentenwohnheimEiche,
                    Stops.Baumschulenweg,
                    Stops.ScienceParkUniversität,
                    Stops.BahnhofGolm,
                ],
                TimeProfiles =
                    [new Line.Route.TimeProfile { StopDistances = [M5, M2, M4, M2, M1, M1, M2, M3, M3, M1] }],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.SHauptbahnhof,
                    Stops.PlatzDerEinheitWest,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.BahnhofCharlottenhofGeschwisterSchollStr,
                    Stops.BahnhofParkSanssouci,
                    Stops.NeuesPalais,
                    Stops.CampusUniversitätAbrahamGeigerKolleg,
                ],
                TimeProfiles = [new Line.Route.TimeProfile { StopDistances = [M5, M2, M4, M2, M1, M1] }],
                CommonStopIndex = 0,
            },
        ],
        TripsCreate =
        [
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(11, 50),
            }.AlsoEvery(M120, new TimeOnly(17, 50)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(13, 52),
            }.AlsoEvery(M120, new TimeOnly(15, 52)),
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(9, 42),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(11, 42),
            }.AlsoEvery(M120, new TimeOnly(15, 42)),
        ],
    };
}