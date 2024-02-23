using Timetables.Models;

namespace Timetables.Vip.Lines.Tram98;

internal class Tram98From20240205 : ILineInstance
{
    private static readonly Tram98From20240102 Original = new();
    public DateOnly ValidFrom { get; } = new(2024, 2, 5);

    public Line Line { get; } = Original.Line with
    {
        Routes =
        [
            ..Original.Line.Routes[..1],
            new Line.Route
            {
                StopPositions =
                [
                    Stops.SchlossCharlottenhof,
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
                    Stops.BahnhofRehbrücke,
                ],
                TimeProfiles = [],
                CommonStopIndex = 0,
            },
            ..Original.Line.Routes[2..],
        ]
    };
}
