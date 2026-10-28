using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus697;

public class Bus697From20250526 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 5, 26);
    private static Bus697From20250203 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        Routes =
        [
            Previous.Line.Routes[0]
                .WithStopBetween(Stops.Katharinenholzstr, Stops.SchlossSanssouciBornstedterStr, Stops.AbzweigNachEiche,
                    M0, M0)
                .WithStopBetween(Stops.SchlossSanssouciBornstedterStr, Stops.Orangerie, Stops.AbzweigNachEiche,
                    [M2, M2, M1, M2], [M0, M0, M0, M0])
                .WithStopBetween(Stops.Orangerie, Stops.Drachenhaus, Stops.AbzweigNachEiche, M1, M1)
                .WithoutStops([
                    Stops.Thaerstr, Stops.AmundsenstrPotsdamerStr, Stops.Katharinenholzstr
                ])
                .ReplaceTimeInterval(Stops.Kirschallee, Stops.SchlossSanssouciBornstedterStr, [M4, M4, M2, M2])
                .ReplaceTimeInterval(Stops.AbzweigNachEiche, Stops.CampusUniversitätAbrahamGeigerKolleg,
                    [M2, M2, M1, M2]),
            Previous.Line.Routes[1]
                .WithStopBetween(Stops.Katharinenholzstr, Stops.SchlossSanssouciBornstedterStr, Stops.AbzweigNachEiche,
                    M0, M0)
                .WithStopBetween(Stops.SchlossSanssouciBornstedterStr, Stops.Orangerie, Stops.AbzweigNachEiche,
                    M2, M0)
                .WithStopBetween(Stops.Orangerie, Stops.Drachenhaus, Stops.AbzweigNachEiche, M1, M1)
                .WithoutStops([
                    Stops.Thaerstr, Stops.AmundsenstrPotsdamerStr, Stops.Katharinenholzstr
                ])
                .ReplaceTimeInterval(Stops.Kirschallee, Stops.SchlossSanssouciBornstedterStr, M4)
                .ReplaceTimeInterval(Stops.AbzweigNachEiche, Stops.CampusUniversitätAbrahamGeigerKolleg, M2),
            Previous.Line.Routes[2]
                .WithoutStops([
                    Stops.Thaerstr, Stops.AmundsenstrPotsdamerStr, Stops.Katharinenholzstr
                ])
                .WithStopBetween(Stops.Kirschallee, Stops.SchlossSanssouciBornstedterStr, Stops.AbzweigNachEiche,
                    [M2, M4], [M0, M0])
                .WithStopBetween(Stops.SchlossSanssouciBornstedterStr, Stops.Orangerie, Stops.AbzweigNachEiche, M2, M0)
                .WithStopBetween(Stops.Orangerie, Stops.Drachenhaus, Stops.AbzweigNachEiche, M1, M1)
                .ReplaceTimeInterval(Stops.AbzweigNachEiche, Stops.CampusUniversitätAbrahamGeigerKolleg, M2),
            ..Previous.Line.Routes[3..],
        ]
    };
}
