using Timetable.Models;

namespace Timetable.Vip.Lines.Tram94;

using static Minutes;

internal class Tram94From20240205 : ILineInstance
{
    private static readonly Tram94From20240102 Original = new();
    public DateOnly ValidFrom { get; } = new(2024, 2, 5);

    public Line Line { get; } = Original.Line with
    {
        Routes =
        [
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
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.BurgstrKlinikum,
                    Stops.Holzmarktstr,
                    Stops.SchiffbauergasseUferweg,
                    Stops.HumboldtringNuthestr,
                    Stops.AltNowawes,
                    Stops.RathausBabelsberg,
                    Stops.SBabelsbergWattstr,
                    Stops.Anhaltstr,
                    Stops.Plantagenstr,
                    Stops.Fontanestr
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M3, M1, M1, M2, M1, M3, M1, M1, M2, M1, M1, M1, M2, M1, M1, M1, M1]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M3, M1, M1, M1, M1, M3, M1, M1, M2, M1, M1, M1, M2, M1, M1, M1, M1]
                    }
                ],
                CommonStopIndex = 9,
            },
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
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.BurgstrKlinikum,
                    Stops.Holzmarktstr,
                    Stops.SchiffbauergasseUferweg,
                    Stops.HumboldtringNuthestr,
                    Stops.AltNowawes,
                    Stops.RathausBabelsberg,
                    Stops.SBabelsbergWattstr,
                    Stops.Anhaltstr,
                    Stops.Plantagenstr,
                    Stops.Fontanestr
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M3, M1, M1, M1, M1, M2, M1, M1, M2, M1, M1, M1, M2, M1, M1, M1, M1]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M3, M1, M1, M1, M1, M3, M1, M1, M2, M1, M1, M1, M2, M1, M1, M1, M1]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M3, M1, M1, M2, M1, M3, M1, M1, M2, M1, M1, M1, M2, M1, M1, M1, M1]
                    },
                ],
                CommonStopIndex = 10,
            },
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
                    Stops.PlatzDerEinheitBildungsforum,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M3, M1, M1, M1, M1, M3, M1]
                    }
                ],
                CommonStopIndex = 0,
            },
            ..Original.Line.Routes[3..],
        ]
    };
}
