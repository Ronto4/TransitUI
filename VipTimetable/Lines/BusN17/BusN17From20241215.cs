using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.BusN17;

public class BusN17From20241215 : ILineInstance
{
    private static readonly BusN17From20241214 Previous = new();
    public DateOnly ValidFrom { get; } = new(2024, 12, 15);

    public Line Line { get; } = Previous.Line with
    {
        Routes = Previous.Line.Routes.Select(route =>
                route
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
            .Select((route, index) => (route, index))
            .Select(tuple =>
            {
                if (tuple.index != 0) return tuple.route;
                tuple.route.TimeProfiles.Single()
                    .StopDistances[Array.IndexOf(tuple.route.StopPositions, Stops.SHauptbahnhof)] = M3;
                return tuple.route;
            }).ToArray(),
        TripsCreate = Previous.Line.TripsCreate.Select(trip =>
            trip.RouteIndex.Equals(2) && trip.StartTime == new TimeOnly(3, 31)
                ? trip with { StartTime = new TimeOnly(3, 35) }
                : trip.RouteIndex.Equals(0) || trip.RouteIndex.Equals(1)
                    ? trip with { StartTime = trip.StartTime.AddMinutes(2) }
                    : trip).ToArray(),
    };
}
