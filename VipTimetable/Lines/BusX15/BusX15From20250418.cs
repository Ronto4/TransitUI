using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.BusX15;

public class BusX15From20250418 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 4, 18);

    public Line Line { get; } = new()
    {
        Name = "X15",
        TransportationType = TransportationType.Bus,
        OperationTime = LineOperationTime.Daytime,
        MainRouteIndices = [0, 1],
        OverviewRouteIndices = [0, 1],
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.NeuesPalais,
                    Stops.CampusUniversitätAbrahamGeigerKolleg,
                    Stops.AbzweigNachEiche,
                    Stops.Drachenhaus,
                    Stops.Orangerie,
                    Stops.SchlossSanssouci,
                    Stops.Friedenskirche,
                    Stops.LuisenplatzNordParkSanssouci,
                    Stops.LuisenplatzOstParkSanssouci,
                    Stops.PlatzDerEinheitWest,
                    Stops.AlterMarktLandtag,
                    Stops.SHauptbahnhof,
                ],
                TimeProfiles =
                    [new Line.Route.TimeProfile { StopDistances = [M2, M1, M1, M1, M2, M3, M1, M2, M2, M1, M3,], },],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.SHauptbahnhof,
                    Stops.AlterMarktLandtag,
                    Stops.PlatzDerEinheitWest,
                    Stops.LuisenplatzOstParkSanssouci,
                    Stops.Friedenskirche,
                    Stops.SchlossSanssouci,
                    Stops.Orangerie,
                    Stops.Drachenhaus,
                    Stops.AbzweigNachEiche,
                    Stops.CampusUniversitätAbrahamGeigerKolleg,
                    Stops.NeuesPalais,
                ],
                TimeProfiles =
                    [new Line.Route.TimeProfile { StopDistances = [M3, M2, M2, M2, M3, M2, M1, M1, M2, M1,], },],
                CommonStopIndex = 0,
            },
        ],
        TripsCreate =
        [
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 32),
            }.AlsoEvery(M20, new TimeOnly(18, 52)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 13),
            }.AlsoEvery(M20, new TimeOnly(18, 33)),
        ],
    };
}
