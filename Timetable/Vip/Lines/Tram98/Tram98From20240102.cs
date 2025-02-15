using Timetable.Models;

namespace Timetable.Vip.Lines.Tram98;

internal class Tram98From20240102 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 1, 2);

    public Line Line { get; } = new()
    {
        Name = "98",
        TransportationType = TransportationType.Tram,
        OverviewRouteIndices = [0, 1],
        MainRouteIndices = [0, 1],
        Routes = [
            new Line.Route
            {
                StopPositions = [
                    Stops.BahnhofRehbrücke,
                    Stops.AmMoosfenn,
                    Stops.FriedrichWolfStr,
                    Stops.ZumKahleberg,
                    Stops.EduardClaudiusStrHeinrichMannAllee,
                    Stops.WaldstrHorstweg,
                    Stops.KunersdorferStr,
                    Stops.Sporthalle,
                    Stops.Friedhöfe,
                    Stops.SHauptbahnhof,
                    Stops.LangeBrücke,
                    Stops.AlterMarktLandtag,
                    Stops.PlatzDerEinheitWest,
                    Stops.Dortustr,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.Feuerbachstr,
                    Stops.AufDemKiewitt,
                    Stops.BahnhofCharlottenhofGeschwisterSchollStr,
                    Stops.SchlossCharlottenhof,
                ],
                TimeProfiles = [],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions = [
                    Stops.SchlossCharlottenhof,
                    Stops.KastanienalleeZeppelinstr,
                    Stops.SchillerplatzSchafgraben,
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
            }
        ],
        TripsCreate = [],
    };
}
