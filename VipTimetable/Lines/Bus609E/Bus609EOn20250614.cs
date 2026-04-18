using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus609E;

public class Bus609EOn20250614 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 6, 14);
    public DateOnly? ValidUntilInclusive() => ValidFrom;

    public Line Line { get; } = new()
    {
        Name = "609E",
        TransportationType = TransportationType.Bus,
        MainRouteIndices = [0, 1],
        OverviewRouteIndices = [0, 1],
        Routes = [
            new Line.Route
            {
                StopPositions = [
                    Stops.KrampnitzerTor,
                    Stops.Bassewitz,
                    Stops.HeinrichHeineWeg,
                    Stops.Römerschanze,
                    Stops.AmundsenstrNedlitzerStr,
                    Stops.CampusJungfernsee,
                ],
                TimeProfiles = [new Line.Route.TimeProfile{StopDistances = [M1, M2, M1, M1, M2,],},],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions = [
                    Stops.CampusJungfernsee,
                    Stops.AmundsenstrNedlitzerStr,
                    Stops.Römerschanze,
                    Stops.HeinrichHeineWeg,
                    Stops.Bassewitz,
                    Stops.Plantagenweg,
                    Stops.FahrländerSee,
                    Stops.FahrländerSee,
                    Stops.KrampnitzerTor,
                ],
                TimeProfiles = [new Line.Route.TimeProfile{StopDistances = [M2, M1, M1, M1, M1, M1, M0, M1,],},],
                CommonStopIndex = 0,
            },
        ],
        TripsCreate = [
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(9, 51),
            }.AlsoEvery(M60, new TimeOnly(16, 51)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(9, 43),
            }.AlsoEvery(M60, new TimeOnly(16, 43)),
        ],
    };
}
