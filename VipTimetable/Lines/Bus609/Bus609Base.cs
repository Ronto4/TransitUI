using System.Numerics;
using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus609;

public interface IBus609Base<TSelf> where TSelf : IBus609Base<TSelf>
{
    internal static abstract Line.Route[] InstanceRoutes { get; }
}

public class Bus609Base<TSelf> : Bus609Base where TSelf : IBus609Base<TSelf>
{
    protected static Index RouteIndex(Line.Route route) => Array.IndexOf(TSelf.InstanceRoutes, route).RunIf(-1,
        () => throw new ArgumentException(
            $"Route {route} not found in instance routes{Environment.NewLine}{string.Join(Environment.NewLine, TSelf.InstanceRoutes.Select(instanceRoute => instanceRoute.ToString()))}",
            nameof(route)));
}

file static class DebugExtension
{
    public static T RunIf<T>(this T value, T checkValue, Action action) where T : IEqualityOperators<T, T, bool>
    {
        if (value == checkValue) action();
        return value;
    }
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

        public static Line.Route UpstallHbf { get; } = UpstallHbfViaLuisenplatz.RemoveLuisenplatzDetour();

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
            ManualAnnotation = "via Kartzow",
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
                    StopDistances =
                        [M3, M1, M1, M1, M2, M3, M2, M2, M1, M1, M1, M1, M1, M1, M4, M2, M3, M1, M1, M2, M1, M1, M2],
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
            ManualAnnotation = "(Express)",
            StopPositions =
            [
                Stops.BahnhofMarquardt,
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
                    StopDistances = [M5, M1, M4, M2, M3, M1, M1, M2, M1, M1, M2,],
                },
            ],
            CommonStopIndex = 0,
        };

        public static Line.Route JungfernseeMarquardtSatzkorn { get; } = new()
        {
            ManualAnnotation = "via Bhf Marquardt",
            StopPositions =
            [
                Stops.CampusJungfernsee,
                Stops.AmundsenstrNedlitzerStr,
                Stops.Römerschanze,
                Stops.HeinrichHeineWeg,
                Stops.Bassewitz,
                Stops.Plantagenweg,
                Stops.FahrländerSee,
                Stops.Eisbergstücke,
                Stops.AmUpstall,
                Stops.Eisbergstücke,
                Stops.Kienhorststr,
                Stops.BahnhofMarquardt,
                Stops.Kienheide,
                Stops.Satzkorn,
            ],
            TimeProfiles =
                [new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M1, M1, M1, M3, M4, M2, M1, M5, M2, M3] }],
            CommonStopIndex = 0,
        };

        public static Line.Route JungfernseeKartzow { get; } = new()
        {
            StopPositions =
            [
                Stops.CampusJungfernsee,
                Stops.AmundsenstrNedlitzerStr,
                Stops.Römerschanze,
                Stops.HeinrichHeineWeg,
                Stops.Bassewitz,
                Stops.Plantagenweg,
                Stops.FahrländerSee,
                Stops.Eisbergstücke,
                Stops.AmUpstall,
                Stops.Eisbergstücke,
                Stops.Kienhorststr,
                Stops.Kaiserplatz,
                Stops.SchuleFahrland,
                Stops.AnDerWindmühle,
                Stops.KetzinerStrKönigsweg,
                Stops.Satzkorn,
                Stops.DorfstrKönigsweg,
                Stops.ImWinkel,
                Stops.KircheKartzow,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                    { StopDistances = [M1, M1, M1, M1, M1, M1, M3, M4, M2, M1, M1, M2, M1, M1, M1, M1, M3, M2] },
                new Line.Route.TimeProfile
                    { StopDistances = [M2, M1, M1, M1, M1, M1, M3, M4, M2, M1, M1, M2, M1, M1, M1, M1, M3, M2] }
            ],
            CommonStopIndex = 0,
        };

        public static Line.Route JungfernseeUpstall { get; } = new()
        {
            StopPositions =
            [
                Stops.CampusJungfernsee,
                Stops.AmundsenstrNedlitzerStr,
                Stops.Römerschanze,
                Stops.HeinrichHeineWeg,
                Stops.Bassewitz,
                Stops.Plantagenweg,
                Stops.FahrländerSee,
                Stops.Eisbergstücke,
                Stops.AmUpstall,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M1, M1, M1, M3, M3] },
                new Line.Route.TimeProfile { StopDistances = [M2, M1, M1, M1, M1, M1, M3, M3] },
            ],
            CommonStopIndex = 0,
        };

        public static Line.Route JungfernseeMarquardt { get; } = new()
        {
            StopPositions =
            [
                Stops.CampusJungfernsee,
                Stops.AmundsenstrNedlitzerStr,
                Stops.Römerschanze,
                Stops.HeinrichHeineWeg,
                Stops.Bassewitz,
                Stops.Plantagenweg,
                Stops.FahrländerSee,
                Stops.Eisbergstücke,
                Stops.AmUpstall,
                Stops.Eisbergstücke,
                Stops.Kienhorststr,
                Stops.Kaiserplatz,
                Stops.SchuleFahrland,
                Stops.AnDerWindmühle,
                Stops.KetzinerStrKönigsweg,
                Stops.Satzkorn,
                Stops.Kienheide,
                Stops.BahnhofMarquardt,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                    { StopDistances = [M1, M1, M1, M1, M1, M1, M3, M4, M2, M1, M1, M2, M1, M1, M1, M3, M2] },
                new Line.Route.TimeProfile
                    { StopDistances = [M2, M1, M1, M1, M1, M1, M3, M4, M2, M1, M1, M2, M1, M1, M1, M3, M2] }
            ],
            CommonStopIndex = 0,
        };

        public static Line.Route JungfernseeSchuleMarquardt { get; } = new()
        {
            StopPositions =
            [
                Stops.CampusJungfernsee,
                Stops.AmundsenstrNedlitzerStr,
                Stops.Römerschanze,
                Stops.HeinrichHeineWeg,
                Stops.Bassewitz,
                Stops.Plantagenweg,
                Stops.FahrländerSee,
                Stops.Eisbergstücke,
                Stops.AmUpstall,
                Stops.Eisbergstücke,
                Stops.Kienhorststr,
                Stops.Kaiserplatz,
                Stops.SchuleFahrland,
                Stops.AnDerWindmühle,
                Stops.KetzinerStrKönigsweg,
                Stops.ImWinkel,
                Stops.KircheKartzow,
                Stops.ImWinkel,
                Stops.Satzkorn,
                Stops.Kienheide,
                Stops.BahnhofMarquardt,
                Stops.EisenbahnbrückeMarquardt,
                Stops.SchlossMarquardt,
                Stops.SchuleMarquardt,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances =
                        [M2, M1, M1, M1, M1, M1, M3, M4, M2, M1, M1, M2, M1, M1, M2, M2, M1, M4, M3, M2, M3, M1, M1]
                }
            ],
            CommonStopIndex = 0,
        };

        public static Line.Route JungfernseeKartzowMarquardt { get; } = new()
        {
            ManualAnnotation = "via Kartzow",
            StopPositions =
            [
                Stops.CampusJungfernsee,
                Stops.AmundsenstrNedlitzerStr,
                Stops.Römerschanze,
                Stops.HeinrichHeineWeg,
                Stops.Bassewitz,
                Stops.Plantagenweg,
                Stops.FahrländerSee,
                Stops.Eisbergstücke,
                Stops.AmUpstall,
                Stops.Eisbergstücke,
                Stops.Kienhorststr,
                Stops.Kaiserplatz,
                Stops.SchuleFahrland,
                Stops.AnDerWindmühle,
                Stops.KetzinerStrKönigsweg,
                Stops.ImWinkel,
                Stops.KircheKartzow,
                Stops.ImWinkel,
                Stops.Satzkorn,
                Stops.Kienheide,
                Stops.BahnhofMarquardt,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances = [M1, M1, M1, M1, M1, M1, M3, M4, M2, M1, M1, M2, M1, M1, M2, M2, M1, M4, M3, M2]
                },
                new Line.Route.TimeProfile
                    { StopDistances = [M2, M1, M1, M1, M1, M1, M3, M4, M2, M1, M1, M2, M1, M1, M2, M2, M1, M4, M3, M2] }
            ],
            CommonStopIndex = 0,
        };

        public static Line.Route SchuleFahrlandPaaren { get; } = new()
        {
            StopPositions =
            [
                Stops.SchuleFahrland,
                Stops.AnDerWindmühle,
                Stops.KetzinerStrKönigsweg,
                Stops.ImWinkel,
                Stops.KircheKartzow,
                Stops.ImWinkel,
                Stops.Satzkorn,
                Stops.Kienheide,
                Stops.BahnhofMarquardt,
                Stops.EisenbahnbrückeMarquardt,
                Stops.SchlossMarquardt,
                Stops.SchuleMarquardt,
                Stops.AmWald,
                Stops.Fährweg,
                Stops.KircheUetz,
                Stops.Paaren,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                    { StopDistances = [M1, M1, M2, M2, M1, M4, M3, M2, M3, M1, M1, M1, M2, M3, M4] }
            ],
            CommonStopIndex = 0,
        };

        public static Line.Route JungfernseePaaren { get; } = new()
        {
            StopPositions =
            [
                Stops.CampusJungfernsee,
                Stops.AmundsenstrNedlitzerStr,
                Stops.Römerschanze,
                Stops.HeinrichHeineWeg,
                Stops.Bassewitz,
                Stops.Plantagenweg,
                Stops.FahrländerSee,
                Stops.Eisbergstücke,
                Stops.AmUpstall,
                Stops.Eisbergstücke,
                Stops.Kienhorststr,
                Stops.Kaiserplatz,
                Stops.SchuleFahrland,
                Stops.AnDerWindmühle,
                Stops.KetzinerStrKönigsweg,
                Stops.ImWinkel,
                Stops.KircheKartzow,
                Stops.ImWinkel,
                Stops.Satzkorn,
                Stops.Kienheide,
                Stops.BahnhofMarquardt,
                Stops.EisenbahnbrückeMarquardt,
                Stops.SchlossMarquardt,
                Stops.SchuleMarquardt,
                Stops.AmWald,
                Stops.Fährweg,
                Stops.KircheUetz,
                Stops.Paaren,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances =
                    [
                        M2, M1, M1, M1, M1, M1, M3, M4, M2, M1, M1, M2, M1, M1, M2, M2, M1, M4, M3, M2, M3, M1, M1, M1,
                        M2, M3, M4
                    ]
                }
            ],
            CommonStopIndex = 0,
        };

        public static Line.Route JungfernseeSatzkorn { get; } = new()
        {
            StopPositions =
            [
                Stops.CampusJungfernsee,
                Stops.AmundsenstrNedlitzerStr,
                Stops.Römerschanze,
                Stops.HeinrichHeineWeg,
                Stops.Bassewitz,
                Stops.Plantagenweg,
                Stops.FahrländerSee,
                Stops.Eisbergstücke,
                Stops.AmUpstall,
                Stops.Eisbergstücke,
                Stops.Kienhorststr,
                Stops.Kaiserplatz,
                Stops.SchuleFahrland,
                Stops.AnDerWindmühle,
                Stops.KetzinerStrKönigsweg,
                Stops.Satzkorn,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances =
                    [
                        M1, M1, M1, M1, M1, M1, M3, M4, M2, M1, M1, M2, M1, M1, M1
                    ]
                },
                new Line.Route.TimeProfile
                {
                    StopDistances =
                    [
                        M2, M1, M1, M1, M1, M1, M3, M4, M2, M1, M1, M2, M1, M1, M1
                    ]
                }
            ],
            CommonStopIndex = 0,
        };

        public static Line.Route JungfernseeMarquardtExpress { get; } = new()
        {
            ManualAnnotation = "(Express)",
            StopPositions =
            [
                Stops.CampusJungfernsee,
                Stops.AmundsenstrNedlitzerStr,
                Stops.Römerschanze,
                Stops.HeinrichHeineWeg,
                Stops.Bassewitz,
                Stops.Plantagenweg,
                Stops.FahrländerSee,
                Stops.Eisbergstücke,
                Stops.AmUpstall,
                Stops.Eisbergstücke,
                Stops.Kienhorststr,
                Stops.BahnhofMarquardt,
            ],
            TimeProfiles =
                [new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M1, M1, M1, M3, M4, M2, M1, M5] },
                    new Line.Route.TimeProfile { StopDistances = [M2, M1, M1, M1, M1, M1, M3, M4, M2, M1, M5] }],
            CommonStopIndex = 0,
        };
    }

    /// <summary>
    /// Remove the Luisenplatz and Bassinplatz detours from the given <see cref="Line.Route"/> used until 2024-12-14.
    /// </summary>
    protected static Line.Route RemoveDetours(Line.Route route) => route.RemoveLuisenplatzDetour();

    /// <summary>
    /// Add the <see cref="Stop"/>s Marquardter Str. and Kietzer Str. to the fast routes between Fahrland and Marquardt.
    /// </summary>
    /// <param name="route"></param>
    /// <returns></returns>
    protected static Line.Route AddStopsMarquardterStr(Line.Route route) => route
        .WithStopBetween(Stops.BahnhofMarquardt, Stops.MarquardterStr, Stops.Kienhorststr, M2, M0)
        .WithStopBetween(Stops.MarquardterStr, Stops.KietzerStr, Stops.Kienhorststr, M2, M1)
        .WithStopBetween(Stops.Kienhorststr, Stops.KietzerStr, Stops.BahnhofMarquardt, M1, M0)
        .WithStopBetween(Stops.KietzerStr, Stops.MarquardterStr, Stops.BahnhofMarquardt, M1, M3);
}

file static class Bus609RouteExtensions
{
    public static Line.Route RemoveLuisenplatzDetour(this Line.Route route) => route
        .WithoutStops([
            Stops.ReiterwegJägerallee, Stops.JägertorJustizzentrum, Stops.Mauerstr, Stops.LuisenplatzNordParkSanssouci,
            Stops.LuisenplatzOstParkSanssouci, Stops.Dortustr
        ]).WithStopBetween(Stops.AmPfingstberg, Stops.AmSchragenRussischeKolonie, Stops.PlatzDerEinheitWest, M4, M0)
        .WithStopBetween(Stops.AmSchragenRussischeKolonie, Stops.ReiterwegAlleestr, Stops.PlatzDerEinheitWest, M2, M0)
        .WithStopBetween(Stops.ReiterwegAlleestr, Stops.Rathaus, Stops.PlatzDerEinheitWest, M1, M0)
        .WithStopBetween(Stops.Rathaus, Stops.NauenerTor, Stops.PlatzDerEinheitWest, M1, M0)
        .WithStopBetween(Stops.NauenerTor, Stops.BrandenburgerStr, Stops.PlatzDerEinheitWest, M1, M1);
}
