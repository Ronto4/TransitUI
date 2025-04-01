using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus638;

public class Bus638From20241215 : ILineInstance
{
    private static readonly Bus638From20241214 Original = new();
    public DateOnly ValidFrom { get; } = new(2024, 12, 15);

    public Line Line { get; } = Original.Line with
    {
        Routes =
        [
            ..Original.Line.Routes[..2], new Line.Route
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
                            M2, M1, M1, M1, M1, M1, M2, M1, M2, M2, M2, M1, M1, M1, M1, M1, M4, M2, M1, M1, M1, M1, M1,
                            M3,
                        ],
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
                            M2, M1, M2, M2, M1, M2, M2, M1, M1, M2, M2, M2, M1, M2, M1, M1, M1, M1, M1, M2, M1, M2, M2,
                            M2, M1, M1, M1, M1, M1, M4, M2, M1, M1, M1, M1, M1, M3,
                        ]
                    }
                ],
                CommonStopIndex = 0,
            },
            Original.Line.Routes[4], new Line.Route
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
                            M1, M1, M1, M1, M1, M1, M1, M2, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M3,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            Original.Line.Routes[6],
            new Line.Route
            {
                StopPositions =
                [
                    Stops.SHauptbahnhof,
                    Stops.AlterMarktLandtag,
                    Stops.PlatzDerEinheitWest,
                    Stops.BrandenburgerStr,
                    Stops.NauenerTor,
                    Stops.Rathaus,
                    Stops.ReiterwegAlleestr,
                    Stops.AmSchragenRussischeKolonie,
                    Stops.Landesumweltamt,
                    Stops.WaldsiedlungGroßGlienicke,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                        { StopDistances = [M3, M2, M1, M1, M1, M1, M2, TimeSpan.FromMinutes(14), M1,], },
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
                    Stops.BrandenburgerStr,
                    Stops.NauenerTor,
                    Stops.Rathaus,
                    Stops.ReiterwegAlleestr,
                    Stops.AmSchragenRussischeKolonie,
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
                            M3, M2, M1, M1, M1, M1, M2, M2, M1, M2, M2, M2, M1, M1, M1, M2, M2, M1, M1, M1, M1, M1, M1,
                            M1, M2, M2, M2, M2, M2, M1, M1, M1, M2, M2, M1, M2, M2, M2,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            Original.Line.Routes[9],
        ],
        TripsCreate = Original.Line.TripsCreate.Select(tripCreate =>
            tripCreate.RouteIndex.Equals(8)
                ? tripCreate with { StartTime = tripCreate.StartTime.AddMinutes(1) }
                : tripCreate).ToArray(),
    };
}
