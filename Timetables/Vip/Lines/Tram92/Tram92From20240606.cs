using Timetables.Models;
using static Timetables.Vip.Minutes;

namespace Timetables.Vip.Lines.Tram92;

public class Tram92From20240606 : ILineInstance
{
    private static readonly Tram92From20240422 Original = new();
    public DateOnly ValidFrom { get; } = new(2024, 6, 6);

    public Line Line { get; } = Original.Line with
    {
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Kirschallee,
                    Stops.JohanBoumanPlatz,
                    Stops.HannesMeyerStr,
                    Stops.Wiesenpark,
                    Stops.CampusFachhochschule,
                    Stops.AmSchragen,
                    Stops.Puschkinallee,
                    Stops.Rathaus,
                    Stops.NauenerTor,
                    Stops.BrandenburgerStr,
                    Stops.PlatzDerEinheitWest,
                    Stops.AlterMarktLandtag,
                    Stops.LangeBrücke,
                    Stops.SHauptbahnhof,
                    Stops.Friedhöfe,
                    Stops.Sporthalle,
                    Stops.KunersdorferStr,
                    Stops.WaldstrHorstweg,
                    Stops.MagnusZellerPlatz,
                    Stops.Bisamkiez,
                    Stops.AbzweigBetriebshofViP,
                    Stops.Turmstr,
                    Stops.JohannesKeplerPlatz,
                    Stops.MaxBornStr,
                    Stops.Gaußstr,
                    Stops.HansAlbersStr,
                    Stops.RobertBaberskeStr,
                    Stops.Priesterweg,
                    Stops.AmHirtengraben,
                    Stops.MarieJuchaczStr
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M2, M1, M1, M2, M1, M1, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2, M2, M1, M2, M1,
                            M2, M1, M1, M1, M1, M2
                        ]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M0, M2, M1, M1, M2, M1, M1, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2, M2, M1, M2, M1,
                            M1, M1, M1, M1, M1, M2
                        ]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M0, M2, M1, M1, M2, M1, M1, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2, M2, M1, M2, M1,
                            M2, M1, M1, M1, M1, M2
                        ]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M0, M0, M2, M1, M1, M2, M1, M2, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2, M1, M1, M2, M1,
                            M1, M1, M1, M1, M1, M2
                        ]
                    },
                ],
                CommonStopIndex = 5,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Kirschallee,
                    Stops.JohanBoumanPlatz,
                    Stops.HannesMeyerStr,
                    Stops.Wiesenpark,
                    Stops.CampusFachhochschule,
                    Stops.AmSchragen,
                    Stops.Puschkinallee,
                    Stops.Rathaus,
                    Stops.NauenerTor,
                    Stops.BrandenburgerStr,
                    Stops.PlatzDerEinheitWest,
                    Stops.AlterMarktLandtag,
                    Stops.LangeBrücke,
                    Stops.SHauptbahnhof,
                    Stops.Friedhöfe,
                    Stops.Sporthalle,
                    Stops.KunersdorferStr,
                    Stops.WaldstrHorstweg,
                    Stops.MagnusZellerPlatz,
                    Stops.Bisamkiez,
                    Stops.AbzweigBetriebshofViP,
                    Stops.Turmstr,
                    Stops.JohannesKeplerPlatz,
                    Stops.MaxBornStr,
                    Stops.Gaußstr
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M2, M1, M1, M2, M1, M1, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2, M2, M1, M2, M1,
                            M2
                        ]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M0, M2, M1, M1, M2, M1, M1, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2, M2, M1, M2, M1,
                            M1
                        ]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M0, M2, M1, M1, M2, M1, M1, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2, M2, M1, M2, M1,
                            M2
                        ]
                    },
                ],
                CommonStopIndex = 5,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Kirschallee,
                    Stops.JohanBoumanPlatz,
                    Stops.HannesMeyerStr,
                    Stops.Wiesenpark,
                    Stops.CampusFachhochschule,
                    Stops.AmSchragen,
                    Stops.Puschkinallee,
                    Stops.Rathaus,
                    Stops.NauenerTor,
                    Stops.BrandenburgerStr,
                    Stops.PlatzDerEinheitWest,
                    Stops.AlterMarktLandtag,
                    Stops.LangeBrücke,
                    Stops.SHauptbahnhof,
                    Stops.Friedhöfe,
                    Stops.Sporthalle,
                    Stops.KunersdorferStr,
                    Stops.WaldstrHorstweg,
                    Stops.MagnusZellerPlatz,
                    Stops.Bisamkiez,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M2, M1, M1, M2, M1, M1, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M0, M2, M1, M1, M2, M1, M1, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M0, M1, M1, M1, M1, M2, M1, M2, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2]
                    },
                ],
                CommonStopIndex = 5,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Kirschallee,
                    Stops.JohanBoumanPlatz,
                    Stops.HannesMeyerStr,
                    Stops.Wiesenpark,
                    Stops.CampusFachhochschule,
                    Stops.AmSchragen,
                    Stops.Puschkinallee,
                    Stops.Rathaus,
                    Stops.NauenerTor,
                    Stops.BrandenburgerStr,
                    Stops.PlatzDerEinheitWest,
                    Stops.AlterMarktLandtag,
                    Stops.LangeBrücke,
                    Stops.SHauptbahnhofFriedrichEngelsStr
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M2, M1, M1, M2, M1, M1, M2, M1, M1, M4]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M0, M2, M1, M1, M2, M1, M1, M2, M1, M1, M4]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M0, M1, M1, M1, M1, M2, M1, M2, M2, M1, M1, M4]
                    },
                ],
                CommonStopIndex = 5,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Kirschallee,
                    Stops.JohanBoumanPlatz,
                    Stops.HannesMeyerStr,
                    Stops.Wiesenpark,
                    Stops.CampusFachhochschule,
                    Stops.AmSchragen,
                    Stops.Puschkinallee,
                    Stops.Rathaus,
                    Stops.NauenerTor,
                    Stops.BrandenburgerStr,
                    Stops.PlatzDerEinheitWest,
                    Stops.PlatzDerEinheitBildungsforum
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M0, M2, M1, M1, M2, M1, M1, M2, M1]
                    },
                ],
                CommonStopIndex = 5,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.AbzweigBetriebshofViP,
                    Stops.Turmstr,
                    Stops.JohannesKeplerPlatz,
                    Stops.MaxBornStr,
                    Stops.Gaußstr
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M1, M2]
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.MarieJuchaczStr,
                    Stops.AmHirtengraben,
                    Stops.Priesterweg,
                    Stops.RobertBaberskeStr,
                    Stops.HansAlbersStr,
                    Stops.Gaußstr,
                    Stops.MaxBornStr,
                    Stops.JohannesKeplerPlatz,
                    Stops.Turmstr,
                    Stops.AbzweigBetriebshofViP,
                    Stops.Bisamkiez,
                    Stops.MagnusZellerPlatz,
                    Stops.WaldstrHorstweg,
                    Stops.KunersdorferStr,
                    Stops.Sporthalle,
                    Stops.Friedhöfe,
                    Stops.SHauptbahnhof,
                    Stops.LangeBrücke,
                    Stops.AlterMarktLandtag,
                    Stops.PlatzDerEinheitWest,
                    Stops.BrandenburgerStr,
                    Stops.NauenerTor,
                    Stops.Rathaus,
                    Stops.ReiterwegAlleestr,
                    Stops.Puschkinallee,
                    Stops.AmSchragen,
                    Stops.CampusFachhochschule,
                    Stops.Wiesenpark,
                    Stops.HannesMeyerStr,
                    Stops.JohanBoumanPlatz,
                    Stops.Kirschallee
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M0, M1, M1, M1, M2, M1, M2, M0, M2, M2, M1, M2, M1, M0, M1, M4, M1, M1, M3, M1, M1, M1, M0,
                            M2, M2, M1, M0, M2, M1, M1
                        ]
                    }
                ],
                CommonStopIndex = 0
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Gaußstr,
                    Stops.MaxBornStr,
                    Stops.JohannesKeplerPlatz,
                    Stops.Turmstr,
                    Stops.AbzweigBetriebshofViP,
                    Stops.Bisamkiez,
                    Stops.MagnusZellerPlatz,
                    Stops.WaldstrHorstweg,
                    Stops.KunersdorferStr,
                    Stops.Sporthalle,
                    Stops.Friedhöfe,
                    Stops.SHauptbahnhof,
                    Stops.LangeBrücke,
                    Stops.AlterMarktLandtag,
                    Stops.PlatzDerEinheitWest,
                    Stops.BrandenburgerStr,
                    Stops.NauenerTor,
                    Stops.Rathaus,
                    Stops.ReiterwegAlleestr,
                    Stops.Puschkinallee,
                    Stops.AmSchragen,
                    Stops.CampusFachhochschule,
                    Stops.Wiesenpark,
                    Stops.HannesMeyerStr,
                    Stops.JohanBoumanPlatz,
                    Stops.Kirschallee
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M2, M0, M2, M2, M1, M2, M1, M0, M1, M4, M1, M1, M3, M1, M1, M1, M0, M2, M2, M1, M0, M2,
                            M1,
                            M1
                        ]
                    }
                ],
                CommonStopIndex = 0
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Bisamkiez,
                    Stops.MagnusZellerPlatz,
                    Stops.WaldstrHorstweg,
                    Stops.KunersdorferStr,
                    Stops.Sporthalle,
                    Stops.Friedhöfe,
                    Stops.SHauptbahnhof,
                    Stops.LangeBrücke,
                    Stops.AlterMarktLandtag,
                    Stops.PlatzDerEinheitWest,
                    Stops.BrandenburgerStr,
                    Stops.NauenerTor,
                    Stops.Rathaus,
                    Stops.ReiterwegAlleestr,
                    Stops.Puschkinallee,
                    Stops.AmSchragen,
                    Stops.CampusFachhochschule,
                    Stops.Wiesenpark,
                    Stops.HannesMeyerStr,
                    Stops.JohanBoumanPlatz,
                    Stops.Kirschallee
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M1, M0, M1, M4, M1, M1, M3, M1, M1, M1, M0, M2, M2, M1, M0, M2, M1, M1]
                    }
                ],
                CommonStopIndex = 0
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.SHauptbahnhof,
                    Stops.LangeBrücke,
                    Stops.AlterMarktLandtag,
                    Stops.PlatzDerEinheitWest,
                    Stops.BrandenburgerStr,
                    Stops.NauenerTor,
                    Stops.Rathaus,
                    Stops.ReiterwegAlleestr,
                    Stops.Puschkinallee,
                    Stops.AmSchragen,
                    Stops.CampusFachhochschule,
                    Stops.Wiesenpark,
                    Stops.HannesMeyerStr,
                    Stops.JohanBoumanPlatz,
                    Stops.Kirschallee
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M3, M1, M1, M1, M0, M2, M2, M1, M0, M2, M1, M1]
                    }
                ],
                CommonStopIndex = 0
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.PlatzDerEinheitNord,
                    Stops.BrandenburgerStr,
                    Stops.NauenerTor,
                    Stops.Rathaus,
                    Stops.ReiterwegAlleestr,
                    Stops.Puschkinallee,
                    Stops.AmSchragen,
                    Stops.CampusFachhochschule,
                    Stops.Wiesenpark,
                    Stops.HannesMeyerStr,
                    Stops.JohanBoumanPlatz,
                    Stops.Kirschallee
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M0, M2, M2, M1, M0, M2, M1, M1]
                    }
                ],
                CommonStopIndex = 0
            }
        ]
    };
}
