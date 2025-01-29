using Timetables.Models;
using static Timetables.Vip.Minutes;

namespace Timetables.Vip.Lines.Bus697;

public class Bus697From20241214 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 12, 14);

    public Line Line { get; } = new()
    {
        Name = "697",
        TransportationType = TransportationType.Bus,
        MainRouteIndices = [0, 2, 3, 5],
        OverviewRouteIndices = [0, 3],
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.BerlinGutsparkNeukladow,
                    Stops.BerlinNeukladowerAllee,
                    Stops.BerlinFinnenhausSiedlung,
                    Stops.BerlinAltKladow,
                    Stops.BerlinParnemannweg,
                    Stops.BerlinGößweinsteinerGang,
                    Stops.BerlinTemmeweg,
                    Stops.BerlinKaserneHottengrund,
                    Stops.AmHämphorn,
                    Stops.Weinmeisterweg,
                    Stops.SchlossSacrow,
                    Stops.SacrowerSee,
                    Stops.Zedlitzberg,
                    Stops.Rotkehlchenweg,
                    Stops.Krampnitzsee,
                    Stops.Bassewitz,
                    Stops.HeinrichHeineWeg,
                    Stops.Römerschanze,
                    Stops.AmundsenstrNedlitzerStr,
                    Stops.CampusJungfernseeNedlitzerStr,
                    Stops.RoteKaserneNedlitzerStr,
                    Stops.AmPfingstberg,
                    Stops.AmSchragen,
                    Stops.CampusFachhochschule,
                    Stops.Ruinenbergstr,
                    Stops.JohanBoumanPlatz,
                    Stops.Kirschallee,
                    Stops.Kirschallee, /* because no different arrival and departure time are supported, see https://github.com/Ronto4/TransitUI/issues/34 */
                    Stops.Thaerstr,
                    Stops.AmundsenstrPotsdamerStr,
                    Stops.Katharinenholzstr,
                    Stops.AbzweigNachEiche,
                    Stops.CampusUniversitätAbrahamGeigerKolleg,
                    Stops.NeuesPalais,
                    Stops.BahnhofParkSanssouci,
                    Stops.WerderscherDammForststr,
                    Stops.SchlüterstrForststr,
                    Stops.ImBogenForststr,
                    Stops.Sonnenlandstr,
                    Stops.ZumBahnhofPirschheide,
                    Stops.BahnhofPirschheide,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M2, M1, M0, M1, M4, M1, M1, M1, M1, M4, M2, M2, M2, M1, M1, M1, M1, M1, M2, M1,
                            M2, M1, M3, M2, M3, M1, M2, M1, M2, M1, M1, M1, M1, M1, M0, M1, M2,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M2, M1, M0, M1, M4, M1, M1, M1, M1, M4, M2, M2, M2, M1, M1, M1, M1, M1, M2, M1,
                            M2, M1, M2, M3, M3, M1, M2, M1, M2, M1, M1, M1, M1, M1, M0, M1, M2,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M2, M1, M1, M0, M1, M4, M1, M1, M1, M1, M4, M2, M1, M1, M1, M1, M1, M1, M1, M2, M1,
                            M2, M1, M3, M1, M2, M1, M1, M1, M1, M1, M1, M1, M1, M1, M0, M1, M2,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M0, M1, M4, M1, M1, M1, M1, M4, M2, M2, M2, M1, M1, M1, M1, M1, M2, M1,
                            M2, M1, M3, M2, M3, M1, M1, M1, M1, M1, M1, M1, M1, M1, M0, M1, M2,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                ManualAnnotation = "via Hebbelstr.",
                StopPositions =
                [
                    Stops.BerlinGutsparkNeukladow,
                    Stops.BerlinNeukladowerAllee,
                    Stops.BerlinFinnenhausSiedlung,
                    Stops.BerlinAltKladow,
                    Stops.BerlinParnemannweg,
                    Stops.BerlinGößweinsteinerGang,
                    Stops.BerlinTemmeweg,
                    Stops.BerlinKaserneHottengrund,
                    Stops.AmHämphorn,
                    Stops.Weinmeisterweg,
                    Stops.SchlossSacrow,
                    Stops.SacrowerSee,
                    Stops.Zedlitzberg,
                    Stops.Rotkehlchenweg,
                    Stops.Krampnitzsee,
                    Stops.Bassewitz,
                    Stops.HeinrichHeineWeg,
                    Stops.Römerschanze,
                    Stops.AmundsenstrNedlitzerStr,
                    Stops.CampusJungfernseeNedlitzerStr,
                    Stops.RoteKaserneNedlitzerStr,
                    Stops.AmPfingstberg,
                    Stops.ReiterwegJägerallee,
                    Stops.JägertorJustizzentrum,
                    Stops.Hebbelstr,
                    Stops.Dortustr,
                    Stops.LuisenplatzNordParkSanssouci,
                    Stops.Kirschallee,
                    Stops.Kirschallee, /* because no different arrival and departure time are supported, see https://github.com/Ronto4/TransitUI/issues/34 */
                    Stops.Thaerstr,
                    Stops.AmundsenstrPotsdamerStr,
                    Stops.Katharinenholzstr,
                    Stops.AbzweigNachEiche,
                    Stops.CampusUniversitätAbrahamGeigerKolleg,
                    Stops.NeuesPalais,
                    Stops.BahnhofParkSanssouci,
                    Stops.WerderscherDammForststr,
                    Stops.SchlüterstrForststr,
                    Stops.ImBogenForststr,
                    Stops.Sonnenlandstr,
                    Stops.ZumBahnhofPirschheide,
                    Stops.BahnhofPirschheide,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M2, M1, M0, M1, M4, M1, M1, M1, M1, M4, M2, M2, M2, M1, M1, M1, M1, M1, M4, M1,
                            M3, M3, M2, M5, M3, M3, M1, M2, M1, M2, M1, M1, M1, M1, M1, M0, M1, M2,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Kirschallee,
                    Stops.Thaerstr,
                    Stops.AmundsenstrPotsdamerStr,
                    Stops.Katharinenholzstr,
                    Stops.AbzweigNachEiche,
                    Stops.CampusUniversitätAbrahamGeigerKolleg,
                    Stops.NeuesPalais,
                    Stops.BahnhofParkSanssouci,
                    Stops.WerderscherDammForststr,
                    Stops.SchlüterstrForststr,
                    Stops.ImBogenForststr,
                    Stops.Sonnenlandstr,
                    Stops.ZumBahnhofPirschheide,
                    Stops.BahnhofPirschheide,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M1, M1, M1, M1, M1, M1, M1, M1, M1, M0, M1, M2,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M1, M2, M1, M2, M1, M1, M1, M1, M1, M0, M1, M2,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.BahnhofPirschheide,
                    Stops.ZumBahnhofPirschheide,
                    Stops.Sonnenlandstr,
                    Stops.ImBogenForststr,
                    Stops.SchlüterstrForststr,
                    Stops.WerderscherDammForststr,
                    Stops.BahnhofParkSanssouci,
                    Stops.NeuesPalais,
                    Stops.CampusUniversitätAbrahamGeigerKolleg,
                    Stops.AbzweigNachEiche,
                    Stops.Katharinenholzstr,
                    Stops.Thaerstr,
                    Stops.Kirschallee,
                    Stops.JohanBoumanPlatz,
                    Stops.Ruinenbergstr,
                    Stops.CampusFachhochschule,
                    Stops.AmSchragen,
                    Stops.AmPfingstberg,
                    Stops.RoteKaserneNedlitzerStr,
                    Stops.CampusJungfernseeNedlitzerStr,
                    Stops.AmundsenstrNedlitzerStr,
                    Stops.Römerschanze,
                    Stops.HeinrichHeineWeg,
                    Stops.Bassewitz,
                    Stops.Krampnitzsee,
                    Stops.Rotkehlchenweg,
                    Stops.Zedlitzberg,
                    Stops.SacrowerSee,
                    Stops.SchlossSacrow,
                    Stops.Weinmeisterweg,
                    Stops.AmHämphorn,
                    Stops.BerlinKaserneHottengrund,
                    Stops.BerlinTemmeweg,
                    Stops.BerlinGößweinsteinerGang,
                    Stops.BerlinParnemannweg,
                    Stops.BerlinAltKladow,
                    Stops.BerlinFinnenhausSiedlung,
                    Stops.BerlinNeukladowerAllee,
                    Stops.BerlinGutsparkNeukladow,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M1, M1, M1, M1, M2, M3, M3, M2, M1, M2, M1, M2, M1, M2, M1, M1, M1, M1,
                            M2, M1, M4, M1, M1, M1, M1, M4, M1, M0, M1, M2, M0, M1, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M1, M1, M1, M1, M2, M3, M3, M2, M1, M2, M1, M2, M1, M2, M1, M1, M1, M1,
                            M2, M1, M4, M1, M1, M1, M1, M4, M1, M0, M1, M2, M1, M1, M2,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M2, M3, M1, M1, M2, M1, M2, M1, M2, M1, M1, M1, M1,
                            M2, M1, M4, M1, M1, M1, M1, M4, M1, M0, M1, M2, M0, M1, M1,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.AmSchragen,
                    Stops.AmPfingstberg,
                    Stops.RoteKaserneNedlitzerStr,
                    Stops.CampusJungfernseeNedlitzerStr,
                    Stops.AmundsenstrNedlitzerStr,
                    Stops.Römerschanze,
                    Stops.HeinrichHeineWeg,
                    Stops.Bassewitz,
                    Stops.Krampnitzsee,
                    Stops.Rotkehlchenweg,
                    Stops.Zedlitzberg,
                    Stops.SacrowerSee,
                    Stops.SchlossSacrow,
                    Stops.Weinmeisterweg,
                    Stops.AmHämphorn,
                    Stops.BerlinKaserneHottengrund,
                    Stops.BerlinTemmeweg,
                    Stops.BerlinGößweinsteinerGang,
                    Stops.BerlinParnemannweg,
                    Stops.BerlinAltKladow,
                    Stops.BerlinFinnenhausSiedlung,
                    Stops.BerlinNeukladowerAllee,
                    Stops.BerlinGutsparkNeukladow,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M2, M1, M2, M1, M1, M1, M1, M2, M1, M4, M1, M1, M1, M1, M4, M1, M0, M1, M2, M0, M1, M1,],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.BahnhofPirschheide,
                    Stops.ZumBahnhofPirschheide,
                    Stops.Sonnenlandstr,
                    Stops.ImBogenForststr,
                    Stops.SchlüterstrForststr,
                    Stops.WerderscherDammForststr,
                    Stops.BahnhofParkSanssouci,
                    Stops.NeuesPalais,
                    Stops.CampusUniversitätAbrahamGeigerKolleg,
                    Stops.AbzweigNachEiche,
                    Stops.Katharinenholzstr,
                    Stops.Thaerstr,
                    Stops.Kirschallee,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M1, M1, M1, M1, M1, M1, M2, M3, M3,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M2, M3,],
                    },
                ],
                CommonStopIndex = 0,
            },
        ],
        TripsCreate =
        [
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 45),
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(6, 45),
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 35),
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 3,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(6, 47),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 3,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(7, 47),
            }.AlsoEvery(M60, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(9, 45),
            }.AlsoEvery(M60, new TimeOnly(18, 45)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 45),
            }.AlsoEvery(M60, new TimeOnly(18, 45)),
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(19, 44),
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 43),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(21, 19),
            }.AlsoEvery(M60, 2),
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 29),
            },
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(6, 27),
            },
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(7, 27),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 6),
            }.AlsoEvery(M60, new TimeOnly(18, 6)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 46),
            }.AlsoEvery(M60, new TimeOnly(18, 46)),
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(6, 21),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(7, 21),
            }.AlsoEvery(M60, new TimeOnly(18, 21)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 21),
            }.AlsoEvery(M60, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(9, 21),
            }.AlsoEvery(M60, new TimeOnly(13, 21)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(14, 21),
            }.AlsoEvery(M60, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(17, 21),
            }.AlsoEvery(M60, new TimeOnly(18, 21)),
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(19, 20),
            },
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 21),
            },
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(21, 15),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 53),
            }.AlsoEvery(M60, 2),
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 53),
            },
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(6, 44),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 1),
            }.AlsoEvery(M60, new TimeOnly(19, 1)),
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 41),
            }.AlsoEvery(M60, new TimeOnly(18, 41)),
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(22, 15),
            }.AlsoEvery(M60, 2),
        ],
    };
}