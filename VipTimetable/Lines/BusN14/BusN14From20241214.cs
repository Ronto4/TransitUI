using Timetable.Models;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.BusN14;

public class BusN14From20241214 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 12, 14);

    public Line Line { get; } = new()
    {
        Name = "N14",
        TransportationType = TransportationType.Bus,
        OperationTime = LineOperationTime.Nighttime,
        MainRouteIndices = [0, 2],
        OverviewRouteIndices = [0, 2],
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.ScienceParkUniversität,
                    Stops.AmUrnenfeld,
                    Stops.Kuhfortdamm,
                    Stops.Ehrenpfortenbergstr,
                    Stops.Baumschulenweg,
                    Stops.AmAltenMörtelwerk,
                    Stops.AmGrünenWeg,
                    Stops.KaiserFriedrichStrPolizei,
                    Stops.StudentenwohnheimEiche,
                    Stops.AbzweigNachEiche,
                    Stops.CampusUniversitätAbrahamGeigerKolleg,
                    Stops.NeuesPalais,
                    Stops.BahnhofParkSanssouci,
                    Stops.WerderscherDammForststr,
                    Stops.SchlüterstrForststr,
                    Stops.ImBogenForststr,
                    Stops.Sonnenlandstr,
                    Stops.Luftschiffhafen,
                    Stops.ImBogenZeppelinstr,
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
                    Stops.SHauptbahnhofNordIlb,
                    Stops.HumboldtringLottePulewkaStr,
                    Stops.WiesenstrLottePulewkaStr,
                    Stops.AltNowawes,
                    Stops.RathausBabelsberg,
                    Stops.SBabelsbergSchulstr,
                    Stops.HorstwegGroßbeerenstr,
                    Stops.Falkenhorst,
                    Stops.Schilfhof,
                    Stops.MagnusZellerPlatz,
                    Stops.EduardClaudiusStrDrewitzerStr,
                    Stops.EduardClaudiusStrHeinrichMannAllee,
                    Stops.ZumKahleberg,
                    Stops.FriedrichWolfStr,
                    Stops.AmMoosfenn,
                    Stops.BahnhofRehbrücke,
                    Stops.BergholzRehbrückeVerdistr,
                    Stops.AnDerBrauerei,
                    Stops.DrewitzerStrAmBuchhorst,
                    Stops.TrebbinerStr,
                    Stops.ClaraSchumannStrTrebbinerStr,
                    Stops.MarieJuchaczStr,
                    Stops.AmHirtengraben,
                    Stops.Priesterweg,
                    Stops.RobertBaberskeStr,
                    Stops.HansAlbersStr,
                    Stops.OttoHahnRing,
                    Stops.MaxBornStr,
                    Stops.JohannesKeplerPlatz,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M0, M1, M0, M1, M1, M0, M1, M1, M1, M1, M1, M1, M1, M0, M1, M2, M1, M0, M1, M1,
                            M1, M1, M2, M1, M2, M2, M2, M1, M1, M1, M1, M1, M1, M2, M0, M1, M1, M0, M1, M1, M0, M1, M1,
                            M1, M1, M1, M2, M1, M1, M0, M1, M2, M2, M0, M1
                        ]
                    }
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.ScienceParkUniversität,
                    Stops.AmUrnenfeld,
                    Stops.Kuhfortdamm,
                    Stops.Ehrenpfortenbergstr,
                    Stops.Baumschulenweg,
                    Stops.AmAltenMörtelwerk,
                    Stops.AmGrünenWeg,
                    Stops.KaiserFriedrichStrPolizei,
                    Stops.StudentenwohnheimEiche,
                    Stops.AbzweigNachEiche,
                    Stops.CampusUniversitätAbrahamGeigerKolleg,
                    Stops.NeuesPalais,
                    Stops.BahnhofParkSanssouci,
                    Stops.WerderscherDammForststr,
                    Stops.SchlüterstrForststr,
                    Stops.ImBogenForststr,
                    Stops.Sonnenlandstr,
                    Stops.Luftschiffhafen,
                    Stops.ImBogenZeppelinstr,
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
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M0, M1, M0, M1, M1, M0, M1, M1, M1, M1, M1, M1, M1, M0, M1, M2, M1, M0, M1, M1,
                            M1, M1, M2, M1, M2, M1
                        ]
                    }
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.JohannesKeplerPlatz,
                    Stops.MaxBornStr,
                    Stops.OttoHahnRing,
                    Stops.HansAlbersStr,
                    Stops.RobertBaberskeStr,
                    Stops.Priesterweg,
                    Stops.AmHirtengraben,
                    Stops.MarieJuchaczStr,
                    Stops.TrebbinerStr,
                    Stops.DrewitzerStrAmBuchhorst,
                    Stops.ZumHeizwerk,
                    Stops.AmMoosfenn,
                    Stops.FriedrichWolfStr,
                    Stops.ZumKahleberg,
                    Stops.EduardClaudiusStrHeinrichMannAllee,
                    Stops.MagnusZellerPlatz,
                    Stops.Schilfhof,
                    Stops.Falkenhorst,
                    Stops.Moosgarten,
                    Stops.HorstwegGroßbeerenstr,
                    Stops.SBabelsbergSchulstr,
                    Stops.RathausBabelsberg,
                    Stops.AltNowawes,
                    Stops.WiesenstrLottePulewkaStr,
                    Stops.HumboldtringLottePulewkaStr,
                    Stops.SHauptbahnhofNordIlb,
                    Stops.LangeBrücke,
                    Stops.SHauptbahnhof,
                    Stops.AlterMarktLandtag,
                    Stops.PlatzDerEinheitWest,
                    Stops.Dortustr,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.Feuerbachstr,
                    Stops.AufDemKiewitt,
                    Stops.BahnhofCharlottenhofGeschwisterSchollStr,
                    Stops.SchlossCharlottenhof,
                    Stops.KastanienalleeZeppelinstr,
                    Stops.ImBogenZeppelinstr,
                    Stops.Luftschiffhafen,
                    Stops.Sonnenlandstr,
                    Stops.ImBogenForststr,
                    Stops.SchlüterstrForststr,
                    Stops.WerderscherDammForststr,
                    Stops.BahnhofParkSanssouci,
                    Stops.NeuesPalais,
                    Stops.CampusUniversitätAbrahamGeigerKolleg,
                    Stops.AbzweigNachEiche,
                    Stops.StudentenwohnheimEiche,
                    Stops.KaiserFriedrichStrPolizei,
                    Stops.AmGrünenWeg,
                    Stops.AmAltenMörtelwerk,
                    Stops.Mehlbeerenweg,
                    Stops.Eichenring,
                    Stops.ZumGroßenHerzberg,
                    Stops.GolmerFichten,
                    Stops.ScienceParkUniversität,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M0, M2, M1, M1, M1, M1, M3, M1, M1, M3, M1, M0, M1, M1, M1, M1, M1, M1, M0, M1, M1, M1,
                            M2, M1, M1, M2, M3, M1, M1, M1, M2, M1, M1, M1, M1, M2, M1, M1, M0, M1, M1, M1, M0, M1, M1,
                            M0, M1, M1, M1, M1, M1, M1, M1, M1,
                        ],
                    },
                ],
                CommonStopIndex = 53 /* Zum Großen Herzberg, to 'fake' frequency table */,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.SHauptbahnhof,
                    Stops.AlterMarktLandtag,
                    Stops.PlatzDerEinheitWest,
                    Stops.Dortustr,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.Feuerbachstr,
                    Stops.AufDemKiewitt,
                    Stops.BahnhofCharlottenhofGeschwisterSchollStr,
                    Stops.SchlossCharlottenhof,
                    Stops.KastanienalleeZeppelinstr,
                    Stops.ImBogenZeppelinstr,
                    Stops.Luftschiffhafen,
                    Stops.Sonnenlandstr,
                    Stops.ImBogenForststr,
                    Stops.SchlüterstrForststr,
                    Stops.WerderscherDammForststr,
                    Stops.BahnhofParkSanssouci,
                    Stops.NeuesPalais,
                    Stops.CampusUniversitätAbrahamGeigerKolleg,
                    Stops.AbzweigNachEiche,
                    Stops.StudentenwohnheimEiche,
                    Stops.KaiserFriedrichStrPolizei,
                    Stops.AmGrünenWeg,
                    Stops.AmAltenMörtelwerk,
                    Stops.Mehlbeerenweg,
                    Stops.Eichenring,
                    Stops.ZumGroßenHerzberg,
                    Stops.GolmerFichten,
                    Stops.ScienceParkUniversität,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M1, M1, M1, M2, M1, M1, M1, M1, M2, M1, M1, M0, M1, M1, M1, M0, M1, M1, M0, M1, M1, M1, M1, M1, M1, M1, M1,
                        ],
                    },
                ],
                CommonStopIndex = 26 /* Zum Großen Herzberg, to 'fake' frequency table */,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.JohannesKeplerPlatz,
                    Stops.MaxBornStr,
                    Stops.OttoHahnRing,
                    Stops.HansAlbersStr,
                    Stops.RobertBaberskeStr,
                    Stops.Priesterweg,
                    Stops.AmHirtengraben,
                    Stops.MarieJuchaczStr,
                    Stops.TrebbinerStr,
                    Stops.DrewitzerStrAmBuchhorst,
                    Stops.ZumHeizwerk,
                    Stops.AmMoosfenn,
                    Stops.FriedrichWolfStr,
                    Stops.ZumKahleberg,
                    Stops.EduardClaudiusStrHeinrichMannAllee,
                    Stops.MagnusZellerPlatz,
                    Stops.Schilfhof,
                    Stops.Falkenhorst,
                    Stops.Moosgarten,
                    Stops.HorstwegGroßbeerenstr,
                    Stops.SBabelsbergSchulstr,
                    Stops.RathausBabelsberg,
                    Stops.AltNowawes,
                    Stops.WiesenstrLottePulewkaStr,
                    Stops.HumboldtringLottePulewkaStr,
                    Stops.SHauptbahnhofNordIlb,
                    Stops.LangeBrücke,
                    Stops.SHauptbahnhof,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M0, M2, M1, M1, M1, M1, M3, M1, M1, M3, M1, M0, M1, M1, M1, M1, M1, M1, M0, M1, M1, M1, M2, M1, M1, M1,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.BahnhofRehbrücke,
                    Stops.AmMoosfenn,
                    Stops.FriedrichWolfStr,
                    Stops.ZumKahleberg,
                    Stops.EduardClaudiusStrHeinrichMannAllee,
                    Stops.MagnusZellerPlatz,
                    Stops.Schilfhof,
                    Stops.Falkenhorst,
                    Stops.Moosgarten,
                    Stops.HorstwegGroßbeerenstr,
                    Stops.SBabelsbergSchulstr,
                    Stops.RathausBabelsberg,
                    Stops.AltNowawes,
                    Stops.WiesenstrLottePulewkaStr,
                    Stops.HumboldtringLottePulewkaStr,
                    Stops.SHauptbahnhofNordIlb,
                    Stops.LangeBrücke,
                    Stops.SHauptbahnhof,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M0, M1, M1, M1, M1, M1, M1, M0, M1, M1, M1, M2, M1, M1, M1,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
        ],
        TripsCreate =
        [
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(1, 5),
            }.AlsoEvery(M60, new TimeOnly(4, 5)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(1, 35),
            }.AlsoEvery(M60, new TimeOnly(4, 45)),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 35),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(5, 5),
            }.AlsoEvery(M30, new TimeOnly(6, 5)),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(6, 35),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(1, 2),
            }.AlsoEvery(M60, new TimeOnly(3, 2)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(1, 32),
            }.AlsoEvery(M60, new TimeOnly(3, 32)),
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(4, 2),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(4, 32),
            }.AlsoEvery(M30, new TimeOnly(5, 32)),
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(1, 3),
            },
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(4, 32),
            },
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(6, 2),
            },
            new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 12),
            },
        ],
    };
}