using Timetables.Models;

namespace Timetables.Vip.Lines.Tram91;

using static Minutes;

internal class Tram91From20240205 : ILineInstance
{
    private static readonly Tram91From20240102 Original = new();
    public DateOnly ValidFrom { get; } = new(2024, 2, 5);
    public Line Line { get; } = Original.Line with
    {
        Routes = [
            ..Original.Line.Routes[..0],
            new Line.Route
            {
                StopPositions =
                [
                    Stops.BahnhofPirschheide,
                    Stops.Luftschiffhafen,
                    Stops.ImBogenZeppelinstr,
                    Stops.KastanienalleeZeppelinstr,
                    Stops.BahnhofCharlottenhof,
                    Stops.AufDemKiewitt,
                    Stops.Feuerbachstr,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.Dortustr,
                    Stops.PlatzDerEinheitWest,
                    Stops.AlterMarktLandtag,
                    Stops.LangeBrücke,
                    Stops.SHauptbahnhof,
                    Stops.Friedhöfe,
                    Stops.Sporthalle,
                    Stops.KunersdorferStr,
                    Stops.WaldstrHorstweg,
                    Stops.EduardClaudiusStrHeinrichMannAllee,
                    Stops.ZumKahleberg,
                    Stops.FriedrichWolfStr,
                    Stops.AmMoosfenn,
                    Stops.BahnhofRehbrücke
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M1, M1, M3, M1, M1, M1, M1, M2, M1, M1, M3, M2, M1, M1, M1, M1, M1, M1, M1, M2]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M1, M1, M3, M1, M1, M1, M1, M3, M1, M1, M3, M2, M1, M1, M1, M1, M1, M1, M1, M2]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M1, M1, M3, M1, M1, M2, M1, M3, M1, M1, M3, M2, M1, M1, M1, M1, M1, M1, M1, M2]
                    },
                ],
                CommonStopIndex = 9
            },
            Original.Line.Routes[1],
            new Line.Route
            {
                StopPositions =
                [
                    Stops.BahnhofPirschheide,
                    Stops.Luftschiffhafen,
                    Stops.ImBogenZeppelinstr,
                    Stops.KastanienalleeZeppelinstr,
                    Stops.BahnhofCharlottenhof,
                    Stops.AufDemKiewitt,
                    Stops.Feuerbachstr,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.Dortustr,
                    Stops.PlatzDerEinheitWest,
                    Stops.AlterMarktLandtag,
                    Stops.LangeBrücke,
                    Stops.SHauptbahnhof,
                    Stops.Friedhöfe,
                    Stops.Sporthalle,
                    Stops.KunersdorferStr,
                    Stops.WaldstrHorstweg,
                    Stops.MagnusZellerPlatz,
                    Stops.Bisamkiez
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M3, M1, M1, M1, M1, M2, M1, M1, M3, M2, M1, M1, M1, M2, M2]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M3, M1, M1, M1, M1, M3, M1, M1, M3, M2, M1, M1, M1, M2, M2]
                    },
                ],
                CommonStopIndex = 9
            },
            ..Original.Line.Routes[3..],
        ]
    };
}
