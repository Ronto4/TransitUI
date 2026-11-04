using Timetable;
using static VipTimetable.Minutes;

using Routes609 = VipTimetable.Lines.Bus609.Bus609BaseKrampnitz.Routes;

namespace VipTimetable.Lines.Bus662;

public class Bus662From20250804 : ILineInstance
{
    private static Index RouteIndex609(Line.Route route) =>
        Bus609.Bus609BaseKrampnitz<Bus609.Bus609From20250804>.RouteIndex(route);

    public DateOnly ValidFrom { get; } = new(2025, 8, 4);

    public Line Line { get; } = new()
    {
        Name = "662",
        TransportationType = TransportationType.Bus,
        MainRouteIndices = [0, 7],
        OverviewRouteIndices = [0, 7],
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.ElstalBahnhof,
                    Stops.ElstalEduardScheveAllee,
                    Stops.ElstalUnterDenKiefern,
                    Stops.ElstalAhornweg,
                    Stops.ElstalBreiteStr,
                    Stops.ElstalPuschkinstrSchule,
                    Stops.ElstalDesignerOutlet,
                    Stops.PriortAmObstgarten,
                    Stops.PriortBahnhof,
                    Stops.PriortAltesDorf,
                    Stops.KircheKartzow,
                    Stops.KircheKartzow, /* because no different arrival and departure time are supported, see https://github.com/Ronto4/TransitUI/issues/34 */
                    Stops.ImWinkel,
                    Stops.Satzkorn,
                    Stops.DorfstrKönigsweg,
                    Stops.KetzinerStrKönigsweg,
                    Stops.AnDerWindmühle,
                    Stops.SchuleFahrland,
                    Stops.Kaiserplatz,
                    Stops.Kienhorststr,
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
                        StopDistances =
                        [
                            M2, M1, M1, M1, M0, M2, M4, M1, M1, M4, M4, M1, M4, M1, M1, M1, M1, M1, M1, M4, M2, M2, M2,
                            M1, M1, M2,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.ElstalBahnhof,
                    Stops.ElstalEduardScheveAllee,
                    Stops.ElstalUnterDenKiefern,
                    Stops.ElstalAhornweg,
                    Stops.ElstalBreiteStr,
                    Stops.ElstalPuschkinstrSchule,
                    Stops.ElstalDesignerOutlet,
                    Stops.PriortAmObstgarten,
                    Stops.PriortBahnhof,
                    Stops.PriortAltesDorf,
                    Stops.KircheKartzow,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M2, M1, M1, M1, M0, M2, M4, M1, M1, M4,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.ElstalBahnhof,
                    Stops.ElstalEduardScheveAllee,
                    Stops.ElstalUnterDenKiefern,
                    Stops.ElstalAhornweg,
                    Stops.ElstalBreiteStr,
                    Stops.ElstalPuschkinstrSchule,
                    Stops.ElstalDesignerOutlet,
                    Stops.PriortAmObstgarten,
                    Stops.PriortBahnhof,
                    Stops.PriortAltesDorf,
                    Stops.KircheKartzow,
                    Stops.KircheKartzow, /* because no different arrival and departure time are supported, see https://github.com/Ronto4/TransitUI/issues/34 */
                    Stops.ImWinkel,
                    Stops.Satzkorn,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M2, M1, M1, M1, M0, M2, M4, M1, M1, M4, M4, M1, M4,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.ElstalBahnhof,
                    Stops.ElstalEduardScheveAllee,
                    Stops.ElstalUnterDenKiefern,
                    Stops.ElstalAhornweg,
                    Stops.ElstalBreiteStr,
                    Stops.ElstalPuschkinstrSchule,
                    Stops.ElstalDesignerOutlet,
                    Stops.PriortAmObstgarten,
                    Stops.PriortBahnhof,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M2, M1, M1, M1, M0, M2, M4, M1,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.WustermarkSchule,
                    Stops.WustermarkBerlinerStr,
                    Stops.Dyrotz,
                    Stops.ElstalOlympischesDorf,
                    Stops.ElstalEulenspiegelsiedlung,
                    Stops.ElstalRadelandberg,
                    Stops.ElstalUnterDenKiefern,
                    Stops.ElstalAhornweg,
                    Stops.ElstalBreiteStr,
                    Stops.ElstalPuschkinstrSchule,
                    Stops.ElstalDesignerOutlet,
                    Stops.PriortAmObstgarten,
                    Stops.PriortBahnhof,
                    Stops.BuchowKarpzow,
                    Stops.HoppenradeAusbau,
                    Stops.HoppenradeWernitzerWeg,
                    Stops.HoppenradeKnoblaucherWeg,
                    Stops.WustermarkMittelallee,
                    Stops.WustermarkBrunnenplatz,
                    Stops.WustermarkSchule,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M4, M3, M1, M1, M1, M1, M1, M2, M3, M1, M4, M1, M1, M1, M1, M2, M1,],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M4, M3, M1, M1, M1, M1, M0, M2, M4, M1, M4, M1, M1, M1, M1, M1, M1,],
                    },
                ],
                CommonStopIndex = 2 /* Dyrotz */,
                ManualAnnotation = "via Elstal & Priort",
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.WustermarkSchule,
                    Stops.WustermarkBerlinerStr,
                    Stops.Dyrotz,
                    Stops.ElstalOlympischesDorf,
                    Stops.ElstalEulenspiegelsiedlung,
                    Stops.ElstalRadelandberg,
                    Stops.ElstalUnterDenKiefern,
                    Stops.ElstalAhornweg,
                    Stops.ElstalBreiteStr,
                    Stops.ElstalPuschkinstrSchule,
                    Stops.ElstalDesignerOutlet,
                    Stops.PriortAmObstgarten,
                    Stops.PriortBahnhof,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M4, M3, M1, M1, M1, M1, M1, M2, M3, M1,],
                    },
                ],
                CommonStopIndex = 0,
                ManualAnnotation = "via Elstal",
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.ElstalPuschkinstrSchule,
                    Stops.ElstalDesignerOutlet,
                    Stops.PriortAmObstgarten,
                    Stops.PriortBahnhof,
                    Stops.BuchowKarpzow,
                    Stops.HoppenradeAusbau,
                    Stops.HoppenradeWernitzerWeg,
                    Stops.HoppenradeKnoblaucherWeg,
                    Stops.WustermarkMittelallee,
                    Stops.WustermarkBrunnenplatz,
                    Stops.WustermarkSchule,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M2, M4, M1, M4, M1, M1, M1, M1, M1, M1,],
                    },
                ],
                CommonStopIndex = 0,
                ManualAnnotation = "via Priort",
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
                    Stops.KrampnitzerTor,
                    Stops.KrampnitzMitte,
                    Stops.Kienhorststr,
                    Stops.Kaiserplatz,
                    Stops.SchuleFahrland,
                    Stops.AnDerWindmühle,
                    Stops.KetzinerStrKönigsweg,
                    Stops.Satzkorn,
                    Stops.DorfstrKönigsweg,
                    Stops.ImWinkel,
                    Stops.PriortAltesDorf,
                    Stops.PriortBahnhof,
                    Stops.PriortAmObstgarten,
                    Stops.ElstalDesignerOutlet,
                    Stops.ElstalDesignerOutlet, /* because no different arrival and departure time are supported, see https://github.com/Ronto4/TransitUI/issues/34 */
                    Stops.ElstalPuschkinstrSchule,
                    Stops.ElstalBreiteStr,
                    Stops.ElstalAhornweg,
                    Stops.ElstalUnterDenKiefern,
                    Stops.ElstalEduardScheveAllee,
                    Stops.ElstalBahnhof,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M2, M1, M4, M1, M2, M1, M1, M1, M1, M3, M5, M1, M2, M4, M3, M1, M1, M1, M1,
                            M1, M2,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M2, M1, M1, M1, M2, M2, M4, M1, M2, M1, M1, M1, M1, M3, M5, M1, M2, M4, M3, M1, M1, M1, M1,
                            M1, M2,
                        ],
                    },
                ],
                CommonStopIndex = 6 /* Krampnitz-Mitte */,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.PriortBahnhof,
                    Stops.PriortAmObstgarten,
                    Stops.ElstalDesignerOutlet,
                    Stops.ElstalDesignerOutlet, /* because no different arrival and departure time are supported, see https://github.com/Ronto4/TransitUI/issues/34 */
                    Stops.ElstalPuschkinstrSchule,
                    Stops.ElstalBreiteStr,
                    Stops.ElstalAhornweg,
                    Stops.ElstalUnterDenKiefern,
                    Stops.ElstalEduardScheveAllee,
                    Stops.ElstalBahnhof,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M2, M4, M0, M1, M1, M1, M1, M1, M2,],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.PriortBahnhof,
                    Stops.PriortAmObstgarten,
                    Stops.ElstalDesignerOutlet,
                    Stops.ElstalDesignerOutlet, /* because no different arrival and departure time are supported, see https://github.com/Ronto4/TransitUI/issues/34 */
                    Stops.ElstalPuschkinstrSchule,
                    Stops.ElstalBreiteStr,
                    Stops.ElstalAhornweg,
                    Stops.ElstalUnterDenKiefern,
                    Stops.ElstalEulenspiegelsiedlung,
                    Stops.ElstalRadelandberg,
                    Stops.ElstalUnterDenKiefern,
                    Stops.ElstalSportplatz,
                    Stops.ElstalFeuerwehr,
                    Stops.ElstalSchulzentrum,
                    Stops.ElstalDesignerOutlet,
                    Stops.Dyrotz,
                    Stops.WustermarkBerlinerStr,
                    Stops.WustermarkSchule,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M4, M0, M1, M1, M1, M1, M3, M1, M1, M1, M2, M1, M2, M3, M2, M1],
                    },
                ],
                CommonStopIndex = 0,
                ManualAnnotation = "via Elstal",
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Satzkorn,
                    Stops.DorfstrKönigsweg,
                    Stops.ImWinkel,
                    Stops.PriortAltesDorf,
                    Stops.PriortBahnhof,
                    Stops.PriortAmObstgarten,
                    Stops.ElstalDesignerOutlet,
                    Stops.ElstalDesignerOutlet, /* because no different arrival and departure time are supported, see https://github.com/Ronto4/TransitUI/issues/34 */
                    Stops.ElstalPuschkinstrSchule,
                    Stops.ElstalBreiteStr,
                    Stops.ElstalAhornweg,
                    Stops.ElstalUnterDenKiefern,
                    Stops.ElstalEduardScheveAllee,
                    Stops.ElstalBahnhof,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M3, M5, M1, M2, M4, M0, M1, M1, M1, M1, M1, M2,],
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
                StartTime = new TimeOnly(5, 34),
            },
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 34),
                Connections =
                [
                    new Line.TripCreate.Connection
                    {
                        ConnectingLineIdentifier = "bus609",
                        ConnectingRouteIndex = RouteIndex609(Routes609.KartzowKaserne),
                        Delay = M4,
                        Type = Line.Trip.ConnectionType.ContinuesAs,
                    },
                ],
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(6, 34),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(7, 34),
            }.AlsoEvery(M60, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(9, 34),
            }.AlsoEvery(M60, new TimeOnly(18, 34)),
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(19, 34),
            },
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(20, 34),
            },
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(11, 48),
            },
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(13, 7),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(13, 45),
            }.AlsoEvery(TimeSpan.FromMinutes(55), 2),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(14, 21),
            }.AlsoEvery(TimeSpan.FromMinutes(50), 2),
            new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 45),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 43),
            }.AlsoEvery(M60, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(9, 43),
            }.AlsoEvery(M60, new TimeOnly(18, 43)),
            new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 15),
            },
            new Line.TripCreate
            {
                RouteIndex = 8,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(7, 45),
            },
            new Line.TripCreate
            {
                RouteIndex = 9,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 53),
            },
            new Line.TripCreate
            {
                RouteIndex = 10,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday | DaysOfOperation.Saturday,
                StartTime = new TimeOnly(20, 5),
            },
        ],
    };
}
