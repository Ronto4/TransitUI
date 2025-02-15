using Timetable.Models;
using static Timetable.Vip.Minutes;

namespace Timetable.Vip.Lines.Bus638;

public class Bus638From20241214 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 12, 14);

    public Line Line { get; } = new()
    {
        Name = "638",
        TransportationType = TransportationType.Bus,
        MainRouteIndices = [1, 6],
        OverviewRouteIndices = [1, 6],
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.KircheGroßGlienicke,
                    Stops.AmAnger,
                    Stops.FriedrichGüntherPark,
                    Stops.SacrowerAlleeRichardWagnerStr,
                    Stops.Hechtsprung,
                    Stops.Birkenweg,
                    Stops.AmSchlahn,
                    Stops.Bullenwinkel,
                    Stops.Krampnitzsee,
                    Stops.Bassewitz,
                    Stops.HeinrichHeineWeg,
                    Stops.Römerschanze,
                    Stops.AmundsenstrNedlitzerStr,
                    Stops.CampusJungfernsee,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M1, M1, M2, M1, M2, M2, M2, M1, M1, M2] }
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.BerlinSuRathausSpandau,
                    Stops.BerlinBrunsbüttlerDammRuhlebenerStr,
                    Stops.BerlinZiegelhof,
                    Stops.BerlinMetzerStr,
                    Stops.BerlinMelanchtonplatz,
                    Stops.BerlinAmOmnibusbahnhof,
                    Stops.BerlinHeerstrWilhelmstr,
                    Stops.BerlinRodensteinstr,
                    Stops.BerlinWeinmeisterhornweg,
                    Stops.BerlinKarolinenhöhe,
                    Stops.BerlinLandschaftsfriedhofGatow,
                    Stops.BerlinAußenweg,
                    Stops.BerlinRitterfelddammPotsdamerChaussee,
                    Stops.AmPark,
                    Stops.KircheGroßGlienicke,
                    Stops.AmAnger,
                    Stops.FriedrichGüntherPark,
                    Stops.SacrowerAlleeRichardWagnerStr,
                    Stops.Hechtsprung,
                    Stops.Birkenweg,
                    Stops.AmSchlahn,
                    Stops.Bullenwinkel,
                    Stops.Krampnitzsee,
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
                        [
                            M2, M1, M2, M2, M1, M2, M2, M1, M1, M2, M2, M2, M1, M2, M1, M1, M1, M1, M1, M2, M1, M2, M2,
                            M2, M1, M1, M2,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M2, M1, M2, M1, M1, M1, M1, M2, M2, M1, M1, M1, M1, M1, M1, M1, M1, M1, M2, M1,
                            M1, M1, M1, M2,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.AmPark,
                    Stops.KircheGroßGlienicke,
                    Stops.AmAnger,
                    Stops.FriedrichGüntherPark,
                    Stops.SacrowerAlleeRichardWagnerStr,
                    Stops.Hechtsprung,
                    Stops.Birkenweg,
                    Stops.AmSchlahn,
                    Stops.Bullenwinkel,
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
                            M2, M1, M1, M1, M1, M1, M2, M1, M2, M2, M2, M1, M1, M1, M1, M1, M4, M1, M1, M2, M1, M1, M2,
                            M1, M3
                        ]
                    }
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.BerlinSuRathausSpandau,
                    Stops.BerlinBrunsbüttlerDammRuhlebenerStr,
                    Stops.BerlinZiegelhof,
                    Stops.BerlinMetzerStr,
                    Stops.BerlinMelanchtonplatz,
                    Stops.BerlinAmOmnibusbahnhof,
                    Stops.BerlinHeerstrWilhelmstr,
                    Stops.BerlinRodensteinstr,
                    Stops.BerlinWeinmeisterhornweg,
                    Stops.BerlinKarolinenhöhe,
                    Stops.BerlinLandschaftsfriedhofGatow,
                    Stops.BerlinAußenweg,
                    Stops.BerlinRitterfelddammPotsdamerChaussee,
                    Stops.AmPark,
                    Stops.KircheGroßGlienicke,
                    Stops.AmAnger,
                    Stops.FriedrichGüntherPark,
                    Stops.SacrowerAlleeRichardWagnerStr,
                    Stops.Hechtsprung,
                    Stops.Birkenweg,
                    Stops.AmSchlahn,
                    Stops.Bullenwinkel,
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
                            M2, M1, M2, M2, M1, M2, M2, M1, M1, M2, M2, M2, M1, M2, M1, M1, M1, M1, M1, M2, M1, M2, M2,
                            M2, M1, M1, M1, M1, M1, M4, M1, M1, M2, M1, M1, M2, M1, M3
                        ]
                    }
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.BerlinSuRathausSpandau,
                    Stops.BerlinBrunsbüttlerDammRuhlebenerStr,
                    Stops.BerlinZiegelhof,
                    Stops.BerlinMetzerStr,
                    Stops.BerlinMelanchtonplatz,
                    Stops.BerlinAmOmnibusbahnhof,
                    Stops.BerlinHeerstrWilhelmstr,
                    Stops.BerlinRodensteinstr,
                    Stops.BerlinWeinmeisterhornweg,
                    Stops.BerlinKarolinenhöhe,
                    Stops.BerlinLandschaftsfriedhofGatow,
                    Stops.BerlinAußenweg,
                    Stops.BerlinRitterfelddammPotsdamerChaussee,
                    Stops.AmPark,
                    Stops.KircheGroßGlienicke,
                    Stops.AmAnger,
                    Stops.FriedrichGüntherPark,
                    Stops.SacrowerAlleeRichardWagnerStr,
                    Stops.Hechtsprung,
                    Stops.Birkenweg,
                    Stops.AmSchlahn,
                    Stops.Bullenwinkel,
                    Stops.Krampnitzsee,
                    Stops.Bassewitz,
                    Stops.HeinrichHeineWeg,
                    Stops.Römerschanze,
                    Stops.AmundsenstrNedlitzerStr,
                    Stops.CampusJungfernseeNedlitzerStr,
                    Stops.RoteKaserneNedlitzerStr,
                    Stops.RoteKaserne,
                    Stops.Volkspark,
                    Stops.CampusFachhochschule,
                    Stops.AmSchragen,
                    Stops.ReiterwegJägerallee,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M2, M1, M2, M2, M1, M2, M2, M1, M1, M2, M2, M2, M1, M2, M1, M1, M1, M1, M1, M2, M1, M2, M2,
                            M2, M1, M1, M1, M1, M1, M1, M1, M2, M2,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.KircheGroßGlienicke,
                    Stops.AmAnger,
                    Stops.FriedrichGüntherPark,
                    Stops.SacrowerAlleeRichardWagnerStr,
                    Stops.Hechtsprung,
                    Stops.Birkenweg,
                    Stops.AmSchlahn,
                    Stops.Bullenwinkel,
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
                            M1, M1, M1, M1, M1, M1, M1, M2, M1, M1, M1, M1, M1, M1, M1, M3, M1, M1, M1, M1, M1, M1, M1,
                            M3,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.CampusJungfernsee,
                    Stops.AmundsenstrNedlitzerStr,
                    Stops.Römerschanze,
                    Stops.HeinrichHeineWeg,
                    Stops.Bassewitz,
                    Stops.Krampnitzsee,
                    Stops.Bullenwinkel,
                    Stops.AmSchlahn,
                    Stops.Birkenweg,
                    Stops.Hechtsprung,
                    Stops.SacrowerAlleeRichardWagnerStr,
                    Stops.FriedrichGüntherPark,
                    Stops.AmAnger,
                    Stops.KircheGroßGlienicke,
                    Stops.AmPark,
                    Stops.BerlinRitterfelddammPotsdamerChaussee,
                    Stops.BerlinAußenweg,
                    Stops.BerlinLandschaftsfriedhofGatow,
                    Stops.BerlinKarolinenhöhe,
                    Stops.BerlinWeinmeisterhornweg,
                    Stops.BerlinRodensteinstr,
                    Stops.BerlinHeerstrWilhelmstr,
                    Stops.BerlinAmOmnibusbahnhof,
                    Stops.BerlinMelanchtonplatz,
                    Stops.BerlinMetzerStr,
                    Stops.BerlinZiegelhof,
                    Stops.BerlinBrunsbüttlerDammRuhlebenerStr,
                    Stops.BerlinSuRathausSpandau,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M2, M2, M1, M1, M1, M1, M1, M1, M1, M2, M2, M2, M2, M2, M1, M1, M1, M2, M2,
                            M1, M1, M1, M2,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M2, M1, M1, M1, M2, M2, M1, M1, M1, M1, M1, M1, M1, M2, M2, M2, M2, M2, M1, M1, M1, M2, M2,
                            M1, M2, M2, M2,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M2, M2, M1, M1, M1, M1, M1, M1, M1, M1, M2, M2, M2, M1, M1, M1, M1, M1, M2,
                            M1, M1, M1, M2,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.SHauptbahnhof,
                    Stops.AlterMarktLandtag,
                    Stops.PlatzDerEinheitWest,
                    Stops.Bassinplatz,
                    Stops.Hebbelstr,
                    Stops.NauenerTor,
                    Stops.JägertorJustizzentrum,
                    Stops.ReiterwegJägerallee,
                    Stops.Landesumweltamt,
                    Stops.WaldsiedlungGroßGlienicke,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                        { StopDistances = [M3, M2, M1, M1, M1, M2, M1, TimeSpan.FromMinutes(14), M1,], },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.SHauptbahnhof,
                    Stops.AlterMarktLandtag,
                    Stops.PlatzDerEinheitWest,
                    Stops.Bassinplatz,
                    Stops.Hebbelstr,
                    Stops.NauenerTor,
                    Stops.JägertorJustizzentrum,
                    Stops.ReiterwegJägerallee,
                    Stops.AmPfingstberg,
                    Stops.RoteKaserneNedlitzerStr,
                    Stops.CampusJungfernseeNedlitzerStr,
                    Stops.CampusJungfernsee,
                    Stops.AmundsenstrNedlitzerStr,
                    Stops.Römerschanze,
                    Stops.HeinrichHeineWeg,
                    Stops.Bassewitz,
                    Stops.Krampnitzsee,
                    Stops.Bullenwinkel,
                    Stops.AmSchlahn,
                    Stops.Birkenweg,
                    Stops.Hechtsprung,
                    Stops.SacrowerAlleeRichardWagnerStr,
                    Stops.FriedrichGüntherPark,
                    Stops.AmAnger,
                    Stops.KircheGroßGlienicke,
                    Stops.AmPark,
                    Stops.BerlinRitterfelddammPotsdamerChaussee,
                    Stops.BerlinAußenweg,
                    Stops.BerlinLandschaftsfriedhofGatow,
                    Stops.BerlinKarolinenhöhe,
                    Stops.BerlinWeinmeisterhornweg,
                    Stops.BerlinRodensteinstr,
                    Stops.BerlinHeerstrWilhelmstr,
                    Stops.BerlinAmOmnibusbahnhof,
                    Stops.BerlinMelanchtonplatz,
                    Stops.BerlinMetzerStr,
                    Stops.BerlinZiegelhof,
                    Stops.BerlinBrunsbüttlerDammRuhlebenerStr,
                    Stops.BerlinSuRathausSpandau,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M2, M1, M1, M1, M2, M1, M3, M1, M2, M2, M2, M1, M1, M1, M2, M2, M1, M1, M1, M1, M1, M1,
                            M1, M2, M2, M2, M2, M2, M1, M1, M1, M2, M2, M1, M2, M2, M2,
                        ],
                    },
                ],
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
                    Stops.Krampnitzsee,
                    Stops.Bullenwinkel,
                    Stops.AmSchlahn,
                    Stops.TheodorFontaneStr,
                    Stops.KircheGroßGlienicke,
                    Stops.AmAnger,
                    Stops.FriedrichGüntherPark,
                    Stops.SacrowerAlleeRichardWagnerStr,
                    Stops.Hechtsprung,
                    Stops.Birkenweg,
                ],
                TimeProfiles = [new Line.Route.TimeProfile{StopDistances = [M1, M1, M1, M1, M2, M2, M1, M1, M1, M1, M1, M1, M1, M1,],},],
                CommonStopIndex = 0,
            },
        ],
        TripsCreate =
        [
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 1),
            }.AlsoEvery(M20, new TimeOnly(5, 41)),
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(6, 1),
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(7, 1),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(7, 38),
            }.AlsoEvery(M60, new TimeOnly(18, 38)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 18),
            }.AlsoEvery(M60, new TimeOnly(18, 18)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 38),
            }.AlsoEvery(M20, new TimeOnly(6, 18)),
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 49),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 38),
            }.AlsoEvery(M20, 2),
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(7, 18),
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(7, 18),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 38),
            }.AlsoEvery(M20, new TimeOnly(9, 38)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(10, 8),
            }.AlsoEvery(M30, new TimeOnly(12, 38)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(12, 58),
            }.AlsoEvery(M20, new TimeOnly(17, 38)),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(18, 8),
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(18, 28),
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(18, 58),
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(19, 21),
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(19, 31),
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(19, 51),
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 19),
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(20, 39),
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(20, 59),
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(21, 19),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(21, 39),
            }.AlsoEvery(M60, 3),
            new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(0, 27),
            },
            new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Friday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(0, 57),
            },
            new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 43),
            },
            new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 23),
            },
            new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 43),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 3),
            }.AlsoEvery(M20, new TimeOnly(7, 3)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(6, 23),
            }.AlsoEvery(M60, new TimeOnly(9, 23)),
            new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(9, 43),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 23),
            }.AlsoEvery(M60, new TimeOnly(19, 23)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 43),
            }.AlsoEvery(M60, new TimeOnly(18, 43)),
            new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(8, 23),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(8, 43),
            }.AlsoEvery(M30, new TimeOnly(11, 43)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(12, 3),
            }.AlsoEvery(M20, new TimeOnly(13, 43)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(14, 23),
            }.AlsoEvery(M20, new TimeOnly(15, 23)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(16, 23),
            }.AlsoEvery(M20, new TimeOnly(17, 43)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(18, 13),
            }.AlsoEvery(M30, new TimeOnly(19, 43)),
            new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 13),
            },
            new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(20, 31),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 51),
            }.AlsoEvery(M60, 3),
            new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 16),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 4),
            }.AlsoEvery(M20, 3),
            new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(13, 44),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(15, 24),
            }.AlsoEvery(M20, 2),
            new Line.TripCreate
            {
                RouteIndex = 9,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(23, 51),
            },
            new Line.TripCreate
            {
                RouteIndex = 9,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Friday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(0, 31),
            },
        ],
    };
}
