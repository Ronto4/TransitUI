using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.BusN15;

public class BusN15From20241215 : ILineInstance
{
    private static readonly BusN15From20241214 Previous = new();
    public DateOnly ValidFrom { get; } = new(2024, 12, 15);

    public Line Line { get; } = Previous.Line with
    {
        Routes = Previous.Line.Routes
            .Select(route => route
                .WithoutStops([
                    Stops.ReiterwegJägerallee, Stops.JägertorJustizzentrum, Stops.Mauerstr,
                    Stops.LuisenplatzNordParkSanssouci, Stops.LuisenplatzOstParkSanssouci, Stops.Dortustr,
                    Stops.Bassinplatz, Stops.Hebbelstr, Stops.NauenerTor,
                ])
                .WithStopBetween(Stops.AmPfingstberg, Stops.AmSchragenRussischeKolonie, Stops.PlatzDerEinheitWest,
                    M2,
                    M0)
                .WithStopBetween(Stops.AmSchragenRussischeKolonie, Stops.ReiterwegAlleestr,
                    Stops.PlatzDerEinheitWest,
                    M1, M0).WithStopBetween(Stops.ReiterwegAlleestr, Stops.Rathaus, Stops.PlatzDerEinheitWest, M1,
                    M0)
                .WithStopBetween(Stops.Rathaus, Stops.NauenerTor, Stops.PlatzDerEinheitWest, M1, M0)
                .WithStopBetween(Stops.NauenerTor, Stops.BrandenburgerStr, Stops.PlatzDerEinheitWest, M1, M0)
                .WithStopBetween(Stops.PlatzDerEinheitWest, Stops.BrandenburgerStr, Stops.AmPfingstberg, M1, M0)
                .WithStopBetween(Stops.BrandenburgerStr, Stops.NauenerTor, Stops.AmPfingstberg, M1, M0)
                .WithStopBetween(Stops.NauenerTor, Stops.Rathaus, Stops.AmPfingstberg, M1, M0)
                .WithStopBetween(Stops.Rathaus, Stops.ReiterwegAlleestr, Stops.AmPfingstberg, M1, M0)
                .WithStopBetween(Stops.ReiterwegAlleestr, Stops.AmSchragenRussischeKolonie, Stops.AmPfingstberg, M1,
                    M2))
            .ToArray(),
    };
}
