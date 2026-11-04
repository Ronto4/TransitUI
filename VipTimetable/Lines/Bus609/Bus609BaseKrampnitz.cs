using System.Numerics;
using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus609;

public interface IBus609BaseKrampnitz<TSelf> where TSelf : IBus609BaseKrampnitz<TSelf>
{
    internal static abstract Line.Route[] InstanceRoutes { get; }
}

public class Bus609BaseKrampnitz<TSelf> : Bus609BaseKrampnitz where TSelf : IBus609BaseKrampnitz<TSelf>
{
    public static Index RouteIndex(Line.Route route) => Array.IndexOf(TSelf.InstanceRoutes, route).RunIf(-1,
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

public class Bus609BaseKrampnitz
{
    public static class Routes
    {
        private const string ViaFahrländerSee = "via Fahrländer See";

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
                Stops.KrampnitzMitte,
                Stops.KrampnitzerTor,
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
                    StopDistances = [M1, M1, M1, M1, M1, M1, M1, M4, M2, M4, M1, M2, M2, M1, M1, M2,],
                },
                new Line.Route.TimeProfile
                {
                    StopDistances = [M1, M1, M1, M1, M1, M1, M1, M4, M2, M4, M2, M2, M2, M1, M1, M2,],
                },
                new Line.Route.TimeProfile
                {
                    StopDistances = [M1, M1, M1, M1, M1, M1, M1, M4, M2, M4, M1, M2, M1, M1, M1, M2,],
                },
            ],
            CommonStopIndex = 11 /* Krampnitzer Tor */,
        };

        public static Line.Route AmUpstallJungfernsee { get; } = new()
        {
            StopPositions =
            [
                Stops.AmUpstall,
                Stops.Eisbergstücke,
                Stops.KrampnitzMitte,
                Stops.KrampnitzerTor,
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
                    StopDistances = [M2, M4, M1, M2, M2, M1, M1, M2,],
                },
                new Line.Route.TimeProfile
                {
                    StopDistances = [M2, M4, M2, M2, M2, M1, M1, M2,],
                },
                new Line.Route.TimeProfile
                {
                    StopDistances = [M2, M4, M1, M2, M1, M1, M1, M2,],
                },
            ],
            CommonStopIndex = 3 /* Krampnitzer Tor */,
        };

        public static Line.Route SatzkornHbf { get; } = new()
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
                Stops.KrampnitzMitte,
                Stops.KrampnitzerTor,
                Stops.Bassewitz,
                Stops.HeinrichHeineWeg,
                Stops.Römerschanze,
                Stops.AmundsenstrNedlitzerStr,
                Stops.CampusJungfernseeNedlitzerStr,
                Stops.RoteKaserneNedlitzerStr,
                Stops.AmPfingstberg,
                Stops.AmSchragenRussischeKolonie,
                Stops.ReiterwegAlleestr,
                Stops.Rathaus,
                Stops.NauenerTor,
                Stops.BrandenburgerStr,
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
                        M1, M1, M1, M1, M1, M1, M1, M4, M2, M4, M2, M2, M2, M1, M1, M1, M1, M1, M2, M2, M1, M1, M1, M1,
                        M1, M3,
                    ],
                },
                new Line.Route.TimeProfile
                {
                    StopDistances =
                    [
                        M1, M1, M1, M1, M1, M1, M1, M4, M2, M4, M2, M2, M2, M1, M1, M1, M1, M1, M4, M2, M1, M1, M1, M1,
                        M1, M3,
                    ],
                },
            ],
            CommonStopIndex = 11 /* Krampnitzer Tor */,
        };

        public static Line.Route KartzowKaserne { get; } = new()
        {
            StopPositions =
            [
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
                Stops.RoteKaserne,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances = [M1, M2, M1, M1, M1, M1, M1, M4, M2, M3, M1, M1, M2, M1, M1, M1, M1, M1,],
                },
            ],
            CommonStopIndex = 0,
            ManualAnnotation = ViaFahrländerSee,
        };

        public static Line.Route AmUpstallJungfernseeViaAltstrecke { get; } = new()
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
                    StopDistances = [M2, M3, M1, M1, M2, M1, M1, M2,],
                },
            ],
            CommonStopIndex = 0,
            ManualAnnotation = ViaFahrländerSee,
        };

        public static Line.Route SatzkornPde { get; } = new()
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
                Stops.AmSchragenRussischeKolonie,
                Stops.ReiterwegAlleestr,
                Stops.Rathaus,
                Stops.NauenerTor,
                Stops.BrandenburgerStr,
                Stops.PlatzDerEinheitWest,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances =
                    [
                        M1, M1, M1, M1, M1, M1, M1, M4, M2, M3, M1, M1, M2, M1, M1, M1, M1, M1, M4, M2, M1, M1, M1, M1,
                    ],
                },
            ],
            CommonStopIndex = 0,
            ManualAnnotation = ViaFahrländerSee,
        };

        public static Line.Route AmUpstallKaserne { get; } = new()
        {
            StopPositions =
            [
                Stops.AmUpstall,
                Stops.Eisbergstücke,
                Stops.KrampnitzMitte,
                Stops.KrampnitzerTor,
                Stops.Bassewitz,
                Stops.HeinrichHeineWeg,
                Stops.Römerschanze,
                Stops.AmundsenstrNedlitzerStr,
                Stops.CampusJungfernseeNedlitzerStr,
                Stops.RoteKaserneNedlitzerStr,
                Stops.RoteKaserne,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances = [M2, M4, M2, M2, M2, M1, M1, M1, M1, M1,],
                },
            ],
            CommonStopIndex = 3 /* Krampnitzer Tor */,
        };

        public static Line.Route PaarenPde { get; } = new()
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
                Stops.AmSchragenRussischeKolonie,
                Stops.ReiterwegAlleestr,
                Stops.Rathaus,
                Stops.NauenerTor,
                Stops.BrandenburgerStr,
                Stops.PlatzDerEinheitWest,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances =
                    [
                        M4, M3, M1, M1, M1, M2, M3, M2, M2, M3, M2, M1, M2, M1, M1, M1, M1, M1, M4, M2, M3, M1, M1, M2,
                        M1, M1, M1, M1, M1, M4, M2, M1, M1, M1, M1,
                    ],
                },
            ],
            CommonStopIndex = 0,
            ManualAnnotation = ViaFahrländerSee,
        };

        public static Line.Route SatzkornKaserne { get; } = new()
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
                Stops.KrampnitzMitte,
                Stops.KrampnitzerTor,
                Stops.Bassewitz,
                Stops.HeinrichHeineWeg,
                Stops.Römerschanze,
                Stops.AmundsenstrNedlitzerStr,
                Stops.CampusJungfernseeNedlitzerStr,
                Stops.RoteKaserneNedlitzerStr,
                Stops.RoteKaserne,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances = [M1, M1, M1, M1, M1, M1, M1, M4, M2, M4, M2, M2, M2, M1, M1, M1, M1, M1,],
                },
            ],
            CommonStopIndex = 11 /* Krampnitzer Tor */,
        };

        public static Line.Route MarquardtSatzkorn { get; } = new()
        {
            StopPositions =
            [
                Stops.BahnhofMarquardt,
                Stops.Kienheide,
                Stops.Satzkorn,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances = [M2, M3,],
                },
            ],
            CommonStopIndex = 0,
        };

        public static Line.Route SatzkornKaserneViaAltstrecke { get; } = new()
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
                Stops.RoteKaserne,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances = [M1, M1, M1, M1, M1, M1, M1, M4, M2, M3, M1, M1, M2, M1, M1, M1, M1, M1,],
                },
            ],
            CommonStopIndex = 0,
            ManualAnnotation = ViaFahrländerSee
        };

        public static Line.Route PaarenAmUpstall { get; } = new()
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
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances = [M3, M1, M1, M1, M2, M3, M2, M2, M1, M1, M1, M1, M1, M1, M3,],
                },
            ],
            CommonStopIndex = 0,
        };

        public static Line.Route SchuleMarquardtKaserne { get; } = new()
        {
            StopPositions =
            [
                Stops.SchuleMarquardt,
                Stops.SchlossMarquardt,
                Stops.EisenbahnbrückeMarquardt,
                Stops.BahnhofMarquardt,
                Stops.Kienheide,
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
                Stops.KrampnitzMitte,
                Stops.KrampnitzerTor,
                Stops.Bassewitz,
                Stops.HeinrichHeineWeg,
                Stops.Römerschanze,
                Stops.AmundsenstrNedlitzerStr,
                Stops.CampusJungfernseeNedlitzerStr,
                Stops.RoteKaserneNedlitzerStr,
                Stops.RoteKaserne,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances =
                        [M1, M2, M3, M2, M3, M1, M1, M1, M1, M1, M1, M1, M4, M2, M4, M2, M2, M2, M1, M1, M1, M1, M1,],
                },
            ],
            CommonStopIndex = 16 /* Krampnitzer Tor */,
        };

        public static Line.Route SchuleFahrlandKaserneViaAltstrecke { get; } = new()
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
                Stops.CampusJungfernseeNedlitzerStr,
                Stops.RoteKaserneNedlitzerStr,
                Stops.RoteKaserne,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances = [M1, M1, M1, M4, M2, M3, M1, M1, M2, M1, M1, M1, M1, M1,],
                },
            ],
            CommonStopIndex = 0,
            ManualAnnotation = ViaFahrländerSee
        };

        public static Line.Route MarquardtJungfernseeViaKartzow { get; } = new()
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
                Stops.KrampnitzMitte,
                Stops.KrampnitzerTor,
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
                    StopDistances = [M2, M2, M3, M2, M1, M2, M1, M1, M1, M1, M1, M4, M2, M4, M1, M2, M1, M1, M1, M2,],
                },
            ],
            CommonStopIndex = 15 /* Krampnitzer Tor */,
            ManualAnnotation = "via Kartzow",
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
                Stops.KrampnitzMitte,
                Stops.KrampnitzerTor,
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
                    StopDistances = [M2, M2, M1, M1, M1, M1, M1, M1, M4, M2, M4, M1, M2, M1, M1, M1, M2,],
                },
            ],
            CommonStopIndex = 12 /* Krampnitzer Tor */,
        };

        public static Line.Route KartzowJungfernsee { get; } = new()
        {
            StopPositions =
            [
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
                Stops.KrampnitzMitte,
                Stops.KrampnitzerTor,
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
                    StopDistances = [M1, M2, M1, M1, M1, M1, M1, M4, M2, M4, M1, M2, M1, M1, M1, M2,],
                },
            ],
            CommonStopIndex = 11 /* Krampnitzer Tor */,
        };

        public static Line.Route KartzowJungfernseeViaSatzkorn { get; } = new()
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
                Stops.KrampnitzMitte,
                Stops.KrampnitzerTor,
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
                    StopDistances = [M1, M4, M1, M1, M1, M1, M1, M1, M1, M4, M2, M4, M1, M2, M2, M1, M1, M2,],
                },
                new Line.Route.TimeProfile
                {
                    StopDistances = [M1, M4, M1, M1, M1, M1, M1, M1, M1, M4, M2, M4, M2, M2, M2, M1, M1, M2,],
                },
            ],
            CommonStopIndex = 13 /* Krampnitzer Tor */,
            ManualAnnotation = "via Satzkorn",
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
                Stops.KrampnitzerTor,
                Stops.KrampnitzMitte,
                Stops.Eisbergstücke,
                Stops.AmUpstall,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances = [M1, M1, M1, M1, M2, M1, M4, M4,],
                },
                new Line.Route.TimeProfile
                {
                    StopDistances = [M2, M1, M1, M1, M2, M2, M4, M4,],
                },
                new Line.Route.TimeProfile
                {
                    StopDistances = [M2, M1, M1, M1, M2, M2, M4, M3,],
                },
                new Line.Route.TimeProfile
                {
                    StopDistances = [M1, M1, M1, M1, M2, M1, M4, M3,],
                },
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
                Stops.KrampnitzerTor,
                Stops.KrampnitzMitte,
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
                    StopDistances = [M1, M1, M1, M1, M2, M1, M4, M4, M2, M1, M1, M2, M1, M1, M1,],
                },
                new Line.Route.TimeProfile
                {
                    StopDistances = [M2, M1, M1, M1, M2, M2, M4, M4, M2, M1, M1, M2, M1, M1, M1,],
                },
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
                Stops.KrampnitzerTor,
                Stops.KrampnitzMitte,
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
                Stops.Birnenweg,
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
                    StopDistances = [M2, M1, M1, M1, M2, M2, M4, M4, M2, M1, M1, M2, M1, M1, M2, M2, M1, M4, M2, M1, M2, M3, M1, M1,],
                },
            ],
            CommonStopIndex = 0,
        };

        public static Line.Route SatzkornMarquardt { get; } = new()
        {
            StopPositions =
            [
                Stops.Satzkorn,
                Stops.Birnenweg,
                Stops.Kienheide,
                Stops.BahnhofMarquardt,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances = [M2, M1, M3,],
                },
            ],
            CommonStopIndex = 0,
        };

        public static Line.Route SchuleFahrlandPaarenViaKartzow { get; } = new()
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
                Stops.Birnenweg,
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
                    StopDistances = [M1, M1, M2, M2, M1, M4, M2, M1, M2, M3, M1, M1, M1, M2, M3, M4,],
                },
            ],
            CommonStopIndex = 0,
            ManualAnnotation = "via Kartzow",
        };

        public static Line.Route SchuleFahrlandPaaren { get; } = new()
        {
            StopPositions =
            [
                Stops.SchuleFahrland,
                Stops.AnDerWindmühle,
                Stops.KetzinerStrKönigsweg,
                Stops.Satzkorn,
                Stops.Birnenweg,
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
                    StopDistances = [M1, M1, M1, M2, M1, M2, M3, M1, M1, M1, M2, M3, M4,],
                },
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
                Stops.KrampnitzerTor,
                Stops.KrampnitzMitte,
                Stops.Eisbergstücke,
                Stops.AmUpstall,
                Stops.Eisbergstücke,
                Stops.Kienhorststr,
                Stops.Kaiserplatz,
                Stops.SchuleFahrland,
                Stops.AnDerWindmühle,
                Stops.KetzinerStrKönigsweg,
                Stops.Satzkorn,
                Stops.Birnenweg,
                Stops.Kienheide,
                Stops.BahnhofMarquardt,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances = [M1, M1, M1, M1, M2, M1, M4, M4, M2, M1, M1, M2, M1, M1, M1, M2, M1, M2,],
                },
            ],
            CommonStopIndex = 0,
        };

        public static Line.Route JungfernseeMarquardtViaKartzow { get; } = new()
        {
            StopPositions =
            [
                Stops.CampusJungfernsee,
                Stops.AmundsenstrNedlitzerStr,
                Stops.Römerschanze,
                Stops.HeinrichHeineWeg,
                Stops.Bassewitz,
                Stops.KrampnitzerTor,
                Stops.KrampnitzMitte,
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
                Stops.Birnenweg,
                Stops.Kienheide,
                Stops.BahnhofMarquardt,
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances = [M1, M1, M1, M1, M2, M1, M4, M4, M2, M1, M1, M2, M1, M1, M2, M2, M1, M4, M2, M1, M2,],
                },
            ],
            CommonStopIndex = 0,
            ManualAnnotation = "via Kartzow",
        };

        public static Line.Route JungfernseeKartzowViaSatzkorn { get; } = new()
        {
            StopPositions =
            [
                Stops.CampusJungfernsee,
                Stops.AmundsenstrNedlitzerStr,
                Stops.Römerschanze,
                Stops.HeinrichHeineWeg,
                Stops.Bassewitz,
                Stops.KrampnitzerTor,
                Stops.KrampnitzMitte,
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
                {
                    StopDistances = [M1, M1, M1, M1, M2, M1, M4, M4, M2, M1, M1, M2, M1, M1, M1, M1, M3, M2,],
                },
                new Line.Route.TimeProfile
                {
                    StopDistances = [M2, M1, M1, M1, M2, M2, M4, M4, M2, M1, M1, M2, M1, M1, M1, M1, M3, M2,],
                },
            ],
            CommonStopIndex = 0,
            ManualAnnotation = "via Satzkorn",
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
                Stops.KrampnitzerTor,
                Stops.KrampnitzMitte,
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
            ],
            TimeProfiles =
            [
                new Line.Route.TimeProfile
                {
                    StopDistances = [M1, M1, M1, M1, M2, M1, M4, M4, M2, M1, M1, M2, M1, M1, M2, M2,],
                },
            ],
            CommonStopIndex = 0,
        };
    }
}
