using Timetable.Models;
using static Timetable.Vip.Minutes;

namespace Timetable.Vip.Lines.BusN17;

public class BusN17From20241214 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 12, 14);

    public Line Line { get; } = new()
    {
        Name = "N17",
        TransportationType = TransportationType.Bus,
        OperationTime = LineOperationTime.Nighttime,
        MainRouteIndices = [0, 1, 2, 4, 5, 6, 7],
        OverviewRouteIndices = [0, 4],
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.InstitutFürAgrartechnik,
                    Stops.TüvAkademie,
                    Stops.AbzweigNachNedlitz,
                    Stops.Rückerstr,
                    Stops.KircheBornim,
                    Stops.LindstedterChaussee,
                    Stops.Florastr,
                    Stops.AmundsenstrPotsdamerStr,
                    Stops.Thaerstr,
                    Stops.Kirschallee,
                    Stops.JohanBoumanPlatz,
                    Stops.Ruinenbergstr,
                    Stops.CampusFachhochschule,
                    Stops.Volkspark,
                    Stops.RoteKaserne,
                    Stops.AmPfingstberg,
                    Stops.ReiterwegJägerallee,
                    Stops.JägertorJustizzentrum,
                    Stops.Hebbelstr,
                    Stops.Bassinplatz,
                    Stops.PlatzDerEinheitWest,
                    Stops.AlterMarktLandtag,
                    Stops.LangeBrücke,
                    Stops.SHauptbahnhof,
                    Stops.SHauptbahnhof, /* because no different arrival and departure time are supported, see https://github.com/Ronto4/TransitUI/issues/34 */
                    Stops.Schlaatzstr,
                    Stops.Übergang,
                    Stops.SBabelsbergLutherplatz,
                    Stops.SBabelsbergSchulstr,
                    Stops.RathausBabelsberg,
                    Stops.Spindelstr,
                    Stops.Kreuzstr,
                    Stops.Plantagenstr,
                    Stops.Fontanestr,
                    Stops.Freiligrathstr,
                    Stops.OttoErichStr,
                    Stops.HiroshimaNagasakiPlatz,
                    Stops.SGriebnitzsee,
                    Stops.SGriebnitzsee, /* because no different arrival and departure time are supported, see https://github.com/Ronto4/TransitUI/issues/34 */
                    Stops.StahnsdorferStrAugustBebelStr,
                    Stops.RoteKreuzStr,
                    Stops.BerlinStahnsdorferBrücke,
                    Stops.BerlinSteinstücken,
                    Stops.AmGehölz,
                    Stops.InDerAue,
                    Stops.HubertusdammSteinstr,
                    Stops.Stadtwerke,
                    Stops.Jagdhausstr,
                    Stops.Chopinstr,
                    Stops.NeuendorferStrMendelssohnBartholdyStr,
                    Stops.Lilienthalstr,
                    Stops.JohannesKeplerPlatz,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M0, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M3, M1, M3, M2, M1, M1, M2, M1,
                            M1, M2, M1, M1, M0, M2, M1, M1, M1, M2, M1, M1, M0, M1, M3, M1, M1, M1, M0, M2, M0, M1, M0,
                            M1, M0, M1, M0, M2,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.InstitutFürAgrartechnik,
                    Stops.TüvAkademie,
                    Stops.AbzweigNachNedlitz,
                    Stops.Rückerstr,
                    Stops.KircheBornim,
                    Stops.LindstedterChaussee,
                    Stops.Florastr,
                    Stops.AmundsenstrPotsdamerStr,
                    Stops.Thaerstr,
                    Stops.Kirschallee,
                    Stops.JohanBoumanPlatz,
                    Stops.Ruinenbergstr,
                    Stops.CampusFachhochschule,
                    Stops.Volkspark,
                    Stops.RoteKaserne,
                    Stops.AmPfingstberg,
                    Stops.ReiterwegJägerallee,
                    Stops.JägertorJustizzentrum,
                    Stops.Hebbelstr,
                    Stops.Bassinplatz,
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
                            M1, M1, M1, M1, M0, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M3, M1, M3, M2, M1, M1, M2, M1,
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
                    Stops.JohanBoumanPlatz,
                    Stops.Ruinenbergstr,
                    Stops.CampusFachhochschule,
                    Stops.Volkspark,
                    Stops.RoteKaserne,
                    Stops.AmPfingstberg,
                    Stops.ReiterwegJägerallee,
                    Stops.JägertorJustizzentrum,
                    Stops.Hebbelstr,
                    Stops.Bassinplatz,
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
                            M1, M1, M1, M1, M1, M1, M3, M1, M3, M2, M1, M1, M2, M1,
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
                    Stops.Schlaatzstr,
                    Stops.Übergang,
                    Stops.SBabelsbergLutherplatz,
                    Stops.SBabelsbergSchulstr,
                    Stops.RathausBabelsberg,
                    Stops.Spindelstr,
                    Stops.Kreuzstr,
                    Stops.Plantagenstr,
                    Stops.Fontanestr,
                    Stops.Freiligrathstr,
                    Stops.OttoErichStr,
                    Stops.HiroshimaNagasakiPlatz,
                    Stops.SGriebnitzsee,
                    Stops.SGriebnitzsee, /* because no different arrival and departure time are supported, see https://github.com/Ronto4/TransitUI/issues/34 */
                    Stops.StahnsdorferStrAugustBebelStr,
                    Stops.RoteKreuzStr,
                    Stops.BerlinStahnsdorferBrücke,
                    Stops.BerlinSteinstücken,
                    Stops.AmGehölz,
                    Stops.InDerAue,
                    Stops.HubertusdammSteinstr,
                    Stops.Stadtwerke,
                    Stops.Jagdhausstr,
                    Stops.Chopinstr,
                    Stops.NeuendorferStrMendelssohnBartholdyStr,
                    Stops.Lilienthalstr,
                    Stops.JohannesKeplerPlatz,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M2, M1, M1, M0, M2, M1, M1, M1, M2, M1, M1, M0, M1, M3, M1, M1, M1, M0, M2, M0, M1, M0, M1,
                            M0, M1, M0, M2,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.JohannesKeplerPlatz,
                    Stops.JohannesKeplerPlatz,
                    Stops.NeuendorferStrMendelssohnBartholdyStr,
                    Stops.Chopinstr,
                    Stops.Jagdhausstr,
                    Stops.Stadtwerke,
                    Stops.HubertusdammSteinstr,
                    Stops.InDerAue,
                    Stops.AmGehölz,
                    Stops.BerlinSteinstücken,
                    Stops.BerlinStahnsdorferBrücke,
                    Stops.RoteKreuzStr,
                    Stops.StahnsdorferStrAugustBebelStr,
                    Stops.SGriebnitzsee,
                    Stops.HiroshimaNagasakiPlatz,
                    Stops.OttoErichStr,
                    Stops.Freiligrathstr,
                    Stops.Fontanestr,
                    Stops.Plantagenstr,
                    Stops.Kreuzstr,
                    Stops.Spindelstr,
                    Stops.RathausBabelsberg,
                    Stops.SBabelsbergSchulstr,
                    Stops.SBabelsbergLutherplatz,
                    Stops.Übergang,
                    Stops.Schlaatzstr,
                    Stops.SHauptbahnhof,
                    Stops.SHauptbahnhof, /* because no different arrival and departure time are supported, see https://github.com/Ronto4/TransitUI/issues/34 */
                    Stops.AlterMarktLandtag,
                    Stops.PlatzDerEinheitWest,
                    Stops.Bassinplatz,
                    Stops.Hebbelstr,
                    Stops.NauenerTor,
                    Stops.JägertorJustizzentrum,
                    Stops.ReiterwegJägerallee,
                    Stops.AmPfingstberg,
                    Stops.RoteKaserneNedlitzerStr,
                    Stops.RoteKaserne,
                    Stops.Volkspark,
                    Stops.CampusFachhochschule,
                    Stops.Ruinenbergstr,
                    Stops.JohanBoumanPlatz,
                    Stops.Kirschallee,
                    Stops.Thaerstr,
                    Stops.AmundsenstrPotsdamerStr,
                    Stops.Florastr,
                    Stops.LindstedterChaussee,
                    Stops.KircheBornim,
                    Stops.Rückerstr,
                    Stops.AbzweigNachNedlitz,
                    Stops.TüvAkademie,
                    Stops.InstitutFürAgrartechnik,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M0, M0, M1, M1, M0, M1, M0, M1, M1, M1, M1, M1, M2, M1, M0, M1, M1, M1, M2, M1, M1, M2, M0,
                            M1, M1, M2, M8, M3, M1, M1, M1, M1, M1, M1, M2, M1, M1, M1, M1, M1, M1, M1, M2, M0, M1, M1,
                            M1, M1, M1, M1, M1,
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
                    Stops.AmPfingstberg,
                    Stops.RoteKaserneNedlitzerStr,
                    Stops.RoteKaserne,
                    Stops.Volkspark,
                    Stops.CampusFachhochschule,
                    Stops.Ruinenbergstr,
                    Stops.JohanBoumanPlatz,
                    Stops.Kirschallee,
                    Stops.Thaerstr,
                    Stops.AmundsenstrPotsdamerStr,
                    Stops.Florastr,
                    Stops.LindstedterChaussee,
                    Stops.KircheBornim,
                    Stops.Rückerstr,
                    Stops.AbzweigNachNedlitz,
                    Stops.TüvAkademie,
                    Stops.InstitutFürAgrartechnik,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M1, M1, M1, M1, M1, M1, M2, M1, M1, M1, M1, M1, M1, M1, M2, M0, M1, M1, M1, M1, M1, M1,
                            M1,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.JohannesKeplerPlatz,
                    Stops.JohannesKeplerPlatz,
                    Stops.NeuendorferStrMendelssohnBartholdyStr,
                    Stops.Chopinstr,
                    Stops.Jagdhausstr,
                    Stops.Stadtwerke,
                    Stops.HubertusdammSteinstr,
                    Stops.InDerAue,
                    Stops.AmGehölz,
                    Stops.BerlinSteinstücken,
                    Stops.BerlinStahnsdorferBrücke,
                    Stops.RoteKreuzStr,
                    Stops.StahnsdorferStrAugustBebelStr,
                    Stops.SGriebnitzsee,
                    Stops.HiroshimaNagasakiPlatz,
                    Stops.OttoErichStr,
                    Stops.Freiligrathstr,
                    Stops.Fontanestr,
                    Stops.Plantagenstr,
                    Stops.Kreuzstr,
                    Stops.Spindelstr,
                    Stops.RathausBabelsberg,
                    Stops.SBabelsbergSchulstr,
                    Stops.SBabelsbergLutherplatz,
                    Stops.Übergang,
                    Stops.Schlaatzstr,
                    Stops.SHauptbahnhof,
                    Stops.SHauptbahnhof, /* because no different arrival and departure time are supported, see https://github.com/Ronto4/TransitUI/issues/34 */
                    Stops.AlterMarktLandtag,
                    Stops.PlatzDerEinheitWest,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M0, M0, M1, M1, M0, M1, M0, M1, M1, M1, M1, M1, M2, M1, M0, M1, M1, M1, M2, M1, M1, M2, M0,
                            M1, M1, M2, M8, M3, M1,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.JohannesKeplerPlatz,
                    Stops.JohannesKeplerPlatz,
                    Stops.NeuendorferStrMendelssohnBartholdyStr,
                    Stops.Chopinstr,
                    Stops.Jagdhausstr,
                    Stops.Stadtwerke,
                    Stops.HubertusdammSteinstr,
                    Stops.InDerAue,
                    Stops.AmGehölz,
                    Stops.BerlinSteinstücken,
                    Stops.BerlinStahnsdorferBrücke,
                    Stops.RoteKreuzStr,
                    Stops.StahnsdorferStrAugustBebelStr,
                    Stops.SGriebnitzsee,
                    Stops.HiroshimaNagasakiPlatz,
                    Stops.OttoErichStr,
                    Stops.Freiligrathstr,
                    Stops.Fontanestr,
                    Stops.Plantagenstr,
                    Stops.Kreuzstr,
                    Stops.Spindelstr,
                    Stops.RathausBabelsberg,
                    Stops.SBabelsbergSchulstr,
                    Stops.SBabelsbergLutherplatz,
                    Stops.Übergang,
                    Stops.Schlaatzstr,
                    Stops.SHauptbahnhof,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M0, M0, M1, M1, M0, M1, M0, M1, M1, M1, M1, M1, M2, M1, M0, M1, M1, M1, M2, M1, M1, M2, M0,
                            M1, M1, M2,
                        ],
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
                StartTime = new TimeOnly(2, 5),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(2, 5),
            }.AlsoEvery(M60, new TimeOnly(4, 5)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(2, 5),
            }.AlsoEvery(M60, new TimeOnly(6, 5)),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 5),
            },
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(3, 31),
            },
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(1, 34),
            },
            new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(1, 34),
            },
            new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(2, 2),
            },
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(3, 2),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(2, 2),
            }.AlsoEvery(M60, new TimeOnly(3, 2)),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(2, 2),
            }.AlsoEvery(M60, new TimeOnly(5, 2)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(4, 2),
            }.AlsoEvery(M60, 2),
            new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(6, 2),
            },
        ],
    };
}