using Timetables.Models;
using static Timetables.Vip.Minutes;

namespace Timetables.Vip.Lines.Bus609;

public interface IBus609Base<TSelf> where TSelf : IBus609Base<TSelf>
{
    internal static abstract Line.Route[] InstanceRoutes { get; }
}

public class Bus609Base<TSelf> : Bus609Base where TSelf : IBus609Base<TSelf>
{
    protected static int RouteIndex(Line.Route route) => TSelf.InstanceRoutes.Select((r, i) => (route: r, index: i))
        .Single(tuple => tuple.route == route).index;
}

public class Bus609Base
{
    protected static class Routes
    {
        public static Line.Route SatzkornJungfernsee { get; } = new()
        {
            StopPositions =
            [
                Stops.Satzkorn,
                Stops.DorfstrKönigsweg,
                Stops.KetzinerStrKönigsweg,
                Stops.AnDerWindmühle,
                Stops.SchuleFahrland,
                Stops.Kaiserplatz,
                Stops.Kienhorststr,
                Stops.Eisbergstücke,
                Stops.AmUpstall,
                Stops.Eisbergstücke,
                Stops.FahrländerSee,
                Stops.Plantagenweg,
                Stops.Bassewitz,
                Stops.HeinrichHeineWeg,
                Stops.Römerschanze,
                Stops.AmundsenstrNedlitzerStr,
                Stops.CampusJungfernsee,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances = [M1, M1, M1, M1, M1, M1, M1, M4, M2, M3, M1, M1, M2, M1, M1, M2],
                },
                new Line.Route.TimeProfile
                {
                    StopDistances = [M1, M1, M1, M1, M1, M1, M1, M4, M2, M3, M1, M1, M1, M1, M1, M2],
                },
            ],
            CommonStopIndex = 0,
        };

        public static Line.Route UpstallJungfernsee { get; } = new()
        {
            StopPositions =
            [
                Stops.AmUpstall,
                Stops.Eisbergstücke,
                Stops.FahrländerSee,
                Stops.Plantagenweg,
                Stops.Bassewitz,
                Stops.HeinrichHeineWeg,
                Stops.Römerschanze,
                Stops.AmundsenstrNedlitzerStr,
                Stops.CampusJungfernsee,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances = [M2, M3, M1, M1, M2, M1, M1, M2],
                },
                new Line.Route.TimeProfile
                {
                    StopDistances = [M2, M3, M1, M1, M1, M1, M1, M2],
                },
            ],
            CommonStopIndex = 0,
        };

        public static Line.Route MarquardtJungfernsee { get; } = new()
        {
            StopPositions =
            [
                Stops.BahnhofMarquardt,
                Stops.Kienheide,
                Stops.DorfstrKönigsweg,
                Stops.KetzinerStrKönigsweg,
                Stops.AnDerWindmühle,
                Stops.SchuleFahrland,
                Stops.Kaiserplatz,
                Stops.Kienhorststr,
                Stops.Eisbergstücke,
                Stops.AmUpstall,
                Stops.Eisbergstücke,
                Stops.FahrländerSee,
                Stops.Plantagenweg,
                Stops.Bassewitz,
                Stops.HeinrichHeineWeg,
                Stops.Römerschanze,
                Stops.AmundsenstrNedlitzerStr,
                Stops.CampusJungfernsee,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances = [M2, M2, M1, M1, M1, M1, M1, M1, M4, M2, M3, M1, M1, M2, M1, M1, M2],
                },
                new Line.Route.TimeProfile
                {
                    StopDistances = [M2, M2, M1, M1, M1, M1, M1, M1, M4, M2, M3, M1, M1, M1, M1, M1, M2],
                },
            ],
            CommonStopIndex = 0,
        };

        public static Line.Route KartzowJungfernsee { get; } = new()
        {
            StopPositions =
            [
                Stops.KircheKartzow,
                Stops.ImWinkel,
                Stops.Satzkorn,
                Stops.DorfstrKönigsweg,
                Stops.KetzinerStrKönigsweg,
                Stops.AnDerWindmühle,
                Stops.SchuleFahrland,
                Stops.Kaiserplatz,
                Stops.Kienhorststr,
                Stops.Eisbergstücke,
                Stops.AmUpstall,
                Stops.Eisbergstücke,
                Stops.FahrländerSee,
                Stops.Plantagenweg,
                Stops.Bassewitz,
                Stops.HeinrichHeineWeg,
                Stops.Römerschanze,
                Stops.AmundsenstrNedlitzerStr,
                Stops.CampusJungfernsee,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances = [M1, M4, M1, M1, M1, M1, M1, M1, M1, M4, M2, M3, M1, M1, M2, M1, M1, M2],
                },
                new Line.Route.TimeProfile
                {
                    StopDistances = [M1, M4, M1, M1, M1, M1, M1, M1, M1, M4, M2, M3, M1, M1, M1, M1, M1, M2],
                },
            ],
            CommonStopIndex = 0,
        };

        public static Line.Route UpstallHbfViaLuisenplatz { get; } = new()
        {
            StopPositions =
            [
                Stops.AmUpstall,
                Stops.Eisbergstücke,
                Stops.FahrländerSee,
                Stops.Plantagenweg,
                Stops.Bassewitz,
                Stops.HeinrichHeineWeg,
                Stops.Römerschanze,
                Stops.AmundsenstrNedlitzerStr,
                Stops.CampusJungfernseeNedlitzerStr,
                Stops.RoteKaserneNedlitzerStr,
                Stops.AmPfingstberg,
                Stops.ReiterwegJägerallee,
                Stops.JägertorJustizzentrum,
                Stops.Mauerstr,
                Stops.LuisenplatzNordParkSanssouci,
                Stops.LuisenplatzOstParkSanssouci,
                Stops.Dortustr,
                Stops.PlatzDerEinheitWest,
                Stops.AlterMarktLandtag,
                Stops.SHauptbahnhof,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances = [M2, M3, M1, M1, M2, M1, M1, M1, M1, M1, M4, M1, M1, M2, M1, M1, M2, M1, M3],
                },
            ],
            CommonStopIndex = 0,
        };

        public static Line.Route KartzowHbfViaLuisenplatz { get; } = new()
        {
            StopPositions =
            [
                Stops.KircheKartzow,
                Stops.ImWinkel,
                Stops.Satzkorn,
                Stops.DorfstrKönigsweg,
                Stops.KetzinerStrKönigsweg,
                Stops.AnDerWindmühle,
                Stops.SchuleFahrland,
                Stops.Kaiserplatz,
                Stops.Kienhorststr,
                Stops.Eisbergstücke,
                Stops.AmUpstall,
                Stops.Eisbergstücke,
                Stops.FahrländerSee,
                Stops.Plantagenweg,
                Stops.Bassewitz,
                Stops.HeinrichHeineWeg,
                Stops.Römerschanze,
                Stops.AmundsenstrNedlitzerStr,
                Stops.CampusJungfernseeNedlitzerStr,
                Stops.RoteKaserneNedlitzerStr,
                Stops.AmPfingstberg,
                Stops.ReiterwegJägerallee,
                Stops.JägertorJustizzentrum,
                Stops.Mauerstr,
                Stops.LuisenplatzNordParkSanssouci,
                Stops.LuisenplatzOstParkSanssouci,
                Stops.Dortustr,
                Stops.PlatzDerEinheitWest,
                Stops.AlterMarktLandtag,
                Stops.SHauptbahnhof,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances =
                    [
                        M1, M4, M1, M1, M1, M1, M1, M1, M1, M4, M2, M3, M1, M1, M2, M1, M1, M1, M1, M1, M4, M1, M1, M2,
                        M1, M1, M2, M1, M3
                    ],
                },
            ],
            CommonStopIndex = 0,
        };

        public static Line.Route SatzkornPdeViaLuisenplatz { get; } = new()
        {
            StopPositions =
            [
                Stops.Satzkorn,
                Stops.DorfstrKönigsweg,
                Stops.KetzinerStrKönigsweg,
                Stops.AnDerWindmühle,
                Stops.SchuleFahrland,
                Stops.Kaiserplatz,
                Stops.Kienhorststr,
                Stops.Eisbergstücke,
                Stops.AmUpstall,
                Stops.Eisbergstücke,
                Stops.FahrländerSee,
                Stops.Plantagenweg,
                Stops.Bassewitz,
                Stops.HeinrichHeineWeg,
                Stops.Römerschanze,
                Stops.AmundsenstrNedlitzerStr,
                Stops.CampusJungfernseeNedlitzerStr,
                Stops.RoteKaserneNedlitzerStr,
                Stops.AmPfingstberg,
                Stops.ReiterwegJägerallee,
                Stops.JägertorJustizzentrum,
                Stops.Mauerstr,
                Stops.LuisenplatzNordParkSanssouci,
                Stops.LuisenplatzOstParkSanssouci,
                Stops.Dortustr,
                Stops.PlatzDerEinheitWest,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances =
                    [
                        M1, M1, M1, M1, M1, M1, M1, M4, M2, M3, M1, M1, M2, M1, M1, M1, M1, M1, M4, M1, M1, M2,
                        M1, M1, M2,
                    ],
                },
            ],
            CommonStopIndex = 0,
        };

        public static Line.Route PaarenPdeViaLuisenplatz { get; } = new()
        {
            StopPositions =
            [
                Stops.Paaren,
                Stops.KircheUetz,
                Stops.Fährweg,
                Stops.AmWald,
                Stops.SchuleMarquardt,
                Stops.SchlossMarquardt,
                Stops.EisenbahnbrückeMarquardt,
                Stops.BahnhofMarquardt,
                Stops.Kienheide,
                Stops.DorfstrKönigsweg,
                Stops.ImWinkel,
                Stops.KircheKartzow,
                Stops.ImWinkel,
                Stops.KetzinerStrKönigsweg,
                Stops.AnDerWindmühle,
                Stops.SchuleFahrland,
                Stops.Kaiserplatz,
                Stops.Kienhorststr,
                Stops.Eisbergstücke,
                Stops.AmUpstall,
                Stops.Eisbergstücke,
                Stops.FahrländerSee,
                Stops.Plantagenweg,
                Stops.Bassewitz,
                Stops.HeinrichHeineWeg,
                Stops.Römerschanze,
                Stops.AmundsenstrNedlitzerStr,
                Stops.CampusJungfernseeNedlitzerStr,
                Stops.RoteKaserneNedlitzerStr,
                Stops.AmPfingstberg,
                Stops.ReiterwegJägerallee,
                Stops.JägertorJustizzentrum,
                Stops.Mauerstr,
                Stops.LuisenplatzNordParkSanssouci,
                Stops.LuisenplatzOstParkSanssouci,
                Stops.Dortustr,
                Stops.PlatzDerEinheitWest,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances =
                    [
                        M4, M3, M1, M1, M1, M2, M3, M2, M2, M3, M2, M1, M2, M1, M1, M1, M1, M1, M4, M2, M3, M1, M1, M2,
                        M1, M1, M1, M1, M1, M4, M1, M1, M2, M1, M1, M2,
                    ],
                },
            ],
            CommonStopIndex = 0,
        };
        
        public static Line.Route MarquardtKartzowJungfernsee { get; } = new()
        {
            StopPositions =
            [
                Stops.BahnhofMarquardt,
                Stops.Kienheide,
                Stops.DorfstrKönigsweg,
                Stops.ImWinkel,
                Stops.KircheKartzow,
                Stops.ImWinkel,
                Stops.KetzinerStrKönigsweg,
                Stops.AnDerWindmühle,
                Stops.SchuleFahrland,
                Stops.Kaiserplatz,
                Stops.Kienhorststr,
                Stops.Eisbergstücke,
                Stops.AmUpstall,
                Stops.Eisbergstücke,
                Stops.FahrländerSee,
                Stops.Plantagenweg,
                Stops.Bassewitz,
                Stops.HeinrichHeineWeg,
                Stops.Römerschanze,
                Stops.AmundsenstrNedlitzerStr,
                Stops.CampusJungfernsee,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances = [M2, M2, M3, M2, M1, M2, M1, M1, M1, M1, M1, M4, M2, M3, M1, M1, M2, M1, M1, M2],
                },
                new Line.Route.TimeProfile
                {
                    StopDistances = [M2, M2, M3, M2, M1, M2, M1, M1, M1, M1, M1, M4, M2, M3, M1, M1, M1, M1, M1, M2],
                },
            ],
            CommonStopIndex = 0,
        };
        
        public static Line.Route PaarenJungfernsee { get; } = new()
        {
            StopPositions =
            [
                Stops.Paaren,
                Stops.Fährweg,
                Stops.AmWald,
                Stops.SchuleMarquardt,
                Stops.SchlossMarquardt,
                Stops.EisenbahnbrückeMarquardt,
                Stops.BahnhofMarquardt,
                Stops.Kienheide,
                Stops.DorfstrKönigsweg,
                Stops.KetzinerStrKönigsweg,
                Stops.AnDerWindmühle,
                Stops.SchuleFahrland,
                Stops.Kaiserplatz,
                Stops.Kienhorststr,
                Stops.Eisbergstücke,
                Stops.AmUpstall,
                Stops.Eisbergstücke,
                Stops.FahrländerSee,
                Stops.Plantagenweg,
                Stops.Bassewitz,
                Stops.HeinrichHeineWeg,
                Stops.Römerschanze,
                Stops.AmundsenstrNedlitzerStr,
                Stops.CampusJungfernsee,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances = [M3, M1, M1, M1, M2, M3, M2, M2, M1, M1, M1, M1, M1, M1, M4, M2, M3, M1, M1, M2, M1, M1, M2],
                },
            ],
            CommonStopIndex = 0,
        };
        
        public static Line.Route SchuleFahrlandJungfernsee { get; } = new()
        {
            StopPositions =
            [
                Stops.SchuleFahrland,
                Stops.Kaiserplatz,
                Stops.Kienhorststr,
                Stops.Eisbergstücke,
                Stops.AmUpstall,
                Stops.Eisbergstücke,
                Stops.FahrländerSee,
                Stops.Plantagenweg,
                Stops.Bassewitz,
                Stops.HeinrichHeineWeg,
                Stops.Römerschanze,
                Stops.AmundsenstrNedlitzerStr,
                Stops.CampusJungfernsee,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances = [M1, M1, M1, M4, M2, M3, M1, M1, M2, M1, M1, M2],
                },
            ],
            CommonStopIndex = 0,
        };
        
        public static Line.Route MarquardtJungfernseeExpress { get; } = new()
        {
            StopPositions =
            [
                Stops.BahnhofMarquardt,
                Stops.AmUpstall,
                Stops.Eisbergstücke,
                Stops.FahrländerSee,
                Stops.Plantagenweg,
                Stops.Bassewitz,
                Stops.HeinrichHeineWeg,
                Stops.Römerschanze,
                Stops.AmundsenstrNedlitzerStr,
                Stops.CampusJungfernsee,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances = [M5, M2, M3, M1, M1, M2, M1, M1, M2],
                },
            ],
            CommonStopIndex = 0,
        };
    }
}
