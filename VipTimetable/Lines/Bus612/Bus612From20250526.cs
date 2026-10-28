using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus612;

public class Bus612From20250526 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 5, 26);
    private static Bus612From20250203 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        Routes =
        [
            ..Previous.Line.Routes[..3],
            Previous.Line.Routes[3]
                .WithoutStops([Stops.Thaerstr, Stops.AmundsenstrPotsdamerStr, Stops.Katharinenholzstr])
                .WithStopBetween(Stops.Kirschallee, Stops.SchlossSanssouciBornstedterStr, Stops.AbzweigNachEiche,
                    [M4, M4, M2, M2], [M0, M0, M0, M0])
                .WithStopBetween(Stops.SchlossSanssouciBornstedterStr, Stops.Orangerie, Stops.AbzweigNachEiche,
                    [M2, M2, M1, M1], [M0, M0, M0, M0])
                .WithStopBetween(Stops.Orangerie, Stops.Drachenhaus, Stops.AbzweigNachEiche, [M1, M1, M1, M1],
                    [M0, M1, M1, M1])
                // HACK: Fix time between Abzweig nach Eiche and Studentenwohnheim Eiche.
                .WithoutStop(Stops.StudentenwohnheimEiche)
                .WithStopBetween(Stops.AbzweigNachEiche, Stops.StudentenwohnheimEiche, Stops.KaiserFriedrichStrPolizei,
                    M1, M0)
                // HACK: Fix time between Am Grünen Weg and Mehlbeerenweg.
                .WithoutStop(Stops.AmAltenMörtelwerk)
                .WithStopBetween(Stops.AmGrünenWeg, Stops.AmAltenMörtelwerk, Stops.Mehlbeerenweg,
                    [M0, M1, M1, M0], [M2, M2, M2, M2]),
            ..Previous.Line.Routes[4..],
        ],
        TripsCreate = Previous.Line.TripsCreate.Select(tripCreate =>
            tripCreate.RouteIndex.Equals(3) && (tripCreate.StartTime < new TimeOnly(18, 30) ||
                                                tripCreate.StartTime == new TimeOnly(19, 41))
                ? tripCreate with { StartTime = tripCreate.StartTime.Add(-M1) }
                : tripCreate).ToArray(),
    };
}
