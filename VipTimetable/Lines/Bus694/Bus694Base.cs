using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus694;

public interface IBus694Base<TSelf> where TSelf : IBus694Base<TSelf>
{
    internal static abstract Line.Route[] InstanceRoutes { get; }
}

public class Bus694Base<TSelf> : Bus694Base where TSelf : IBus694Base<TSelf>
{
    protected static int RouteIndex(Line.Route route) => TSelf.InstanceRoutes.Select((r, i) => (route: r, index: i))
        .Single(tuple => tuple.route == route).index;
}

public class Bus694Base
{
    protected static class Routes
    {
        public static class TowardsDrewitz
        {
            public static Line.Route GerlachstrSternCenter { get; } = new()
            {
                StopPositions =
                [
                    Stops.Gerlachstr,
                    Stops.SternCenterGerlachstr,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile { StopDistances = [M1] }
                ],
                CommonStopIndex = 0,
            };

            public static Line.Route SGriebnitzseeSternCenter { get; } = new()
            {
                StopPositions =
                [
                    Stops.SGriebnitzsee,
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
                    Stops.Gerlachstr,
                    Stops.SternCenterGerlachstr,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                        { StopDistances = [M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M2, M1,], },
                ],
                CommonStopIndex = 0,
            };

            public static Line.Route RathausBabelsbergSternCenter { get; } = new()
            {
                StopPositions =
                [
                    Stops.RathausBabelsberg,
                    Stops.RathausBabelsberg,
                    Stops.Spindelstr,
                    Stops.Kreuzstr,
                    Stops.Plantagenstr,
                    Stops.Fontanestr,
                    Stops.Freiligrathstr,
                    Stops.OttoErichStr,
                    Stops.HiroshimaNagasakiPlatz,
                    Stops.SGriebnitzsee,
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
                    Stops.Gerlachstr,
                    Stops.SternCenterGerlachstr,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M2, M1, M1, M1, M2, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M2,
                            M1,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            };

            public static Line.Route SHauptbahnhofSternCenter { get; } = new()
            {
                StopPositions =
                [
                    Stops.SHauptbahnhof,
                    Stops.SHauptbahnhofNordIlb,
                    Stops.HumboldtringLottePulewkaStr,
                    Stops.WiesenstrLottePulewkaStr,
                    Stops.AltNowawes,
                    Stops.RathausBabelsberg,
                    Stops.RathausBabelsberg,
                    Stops.Spindelstr,
                    Stops.Kreuzstr,
                    Stops.Plantagenstr,
                    Stops.Fontanestr,
                    Stops.Freiligrathstr,
                    Stops.OttoErichStr,
                    Stops.HiroshimaNagasakiPlatz,
                    Stops.SGriebnitzsee,
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
                    Stops.Gerlachstr,
                    Stops.SternCenterGerlachstr,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M4, M2, M1, M3, M1, M1, M1, M1, M1, M2, M1, M1, M1, M2, M1, M1, M1, M1, M1, M1, M1, M1, M1,
                            M1,
                            M1, M1, M1, M2, M1,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            };

            public static Line.Route KüsselstrSternCenter { get; } = new()
            {
                StopPositions =
                [
                    Stops.Küsselstr,
                    Stops.Tornowstr,
                    Stops.AlterTornow,
                    Stops.TemplinerEck,
                    Stops.TemplinerEck,
                    Stops.TemplinerStr,
                    Stops.Finkenweg,
                    Stops.SHauptbahnhof,
                    Stops.SHauptbahnhofNordIlb,
                    Stops.HumboldtringLottePulewkaStr,
                    Stops.WiesenstrLottePulewkaStr,
                    Stops.AltNowawes,
                    Stops.RathausBabelsberg,
                    Stops.RathausBabelsberg,
                    Stops.Spindelstr,
                    Stops.Kreuzstr,
                    Stops.Plantagenstr,
                    Stops.Fontanestr,
                    Stops.Freiligrathstr,
                    Stops.OttoErichStr,
                    Stops.HiroshimaNagasakiPlatz,
                    Stops.SGriebnitzsee,
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
                    Stops.Gerlachstr,
                    Stops.SternCenterGerlachstr,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M0, M1, M1, M3, M4, M2, M1, M3, M1, M1, M1, M1, M1, M2, M1, M1, M1, M2, M1, M1,
                            M1,
                            M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M2, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M0, M2, M1, M4, M4, M2, M1, M3, M1, M1, M1, M1, M1, M2, M1, M1, M1, M2, M1, M1,
                            M1,
                            M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M2, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M0, M2, M1, M4, M4, M2, M1, M3, M1, M1, M1, M1, M1, M2, M1, M1, M1, M2, M1, M1,
                            M1,
                            M1, M1, M1, M1, M1, M1, M1, M1, M1, M2, M2, M1,
                        ],
                    },
                ],
                CommonStopIndex = 7 /* S Hauptbahnhof */,
            };

            public static Line.Route HoffbauerStiftungSHauptbahnhof { get; } = new()
            {
                StopPositions =
                [
                    Stops.HoffbauerStiftung,
                    Stops.AlterTornow,
                    Stops.TemplinerEck,
                    Stops.TemplinerEck,
                    Stops.TemplinerStr,
                    Stops.Finkenweg,
                    Stops.SHauptbahnhof,
                ],
                TimeProfiles = [new Line.Route.TimeProfile { StopDistances = [M2, M1, M0, M2, M1, M4] }],
                CommonStopIndex = 0,
            };

            public static Line.Route KüsselstrSternCenterViaDrewitz { get; } = new()
            {
                ManualAnnotation = "via Robert-Baberske-Str.",
                StopPositions =
                [
                    Stops.Küsselstr,
                    Stops.Tornowstr,
                    Stops.AlterTornow,
                    Stops.TemplinerEck,
                    Stops.TemplinerEck,
                    Stops.TemplinerStr,
                    Stops.Finkenweg,
                    Stops.SHauptbahnhof,
                    Stops.SHauptbahnhofNordIlb,
                    Stops.HumboldtringLottePulewkaStr,
                    Stops.WiesenstrLottePulewkaStr,
                    Stops.AltNowawes,
                    Stops.RathausBabelsberg,
                    Stops.RathausBabelsberg,
                    Stops.Spindelstr,
                    Stops.Kreuzstr,
                    Stops.Plantagenstr,
                    Stops.Fontanestr,
                    Stops.Freiligrathstr,
                    Stops.OttoErichStr,
                    Stops.HiroshimaNagasakiPlatz,
                    Stops.SGriebnitzsee,
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
                    Stops.MaxBornStr,
                    Stops.OttoHahnRing,
                    Stops.HansAlbersStr,
                    Stops.RobertBaberskeStr,
                    Stops.KonradWolfAlleeSternstr,
                    Stops.Gerlachstr,
                    Stops.SternCenterGerlachstr,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M0, M2, M1, M4, M4, M2, M1, M3, M1, M1, M1, M1, M1, M2, M1, M1, M1, M2, M1, M1,
                            M1,
                            M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M2, M2, M1, M1, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M0, M1, M1, M3, M2, M2, M1, M2, M1, M1, M1, M1, M1, M2, M1, M1, M1, M6, M1, M1,
                            M1,
                            M1, M1, M1, M1, M0, M1, M0, M1, M1, M1, M1, M1, M2, M1, M2, M1, M1,
                        ],
                    },
                ],
                CommonStopIndex = 7 /* S Hauptbahnhof */,
            };

            public static Line.Route SHauptbahnhofSternCenterViaDrewitz { get; } = new()
            {
                ManualAnnotation = "via Robert-Baberske-Str.",
                StopPositions =
                [
                    Stops.SHauptbahnhof,
                    Stops.SHauptbahnhofNordIlb,
                    Stops.HumboldtringLottePulewkaStr,
                    Stops.WiesenstrLottePulewkaStr,
                    Stops.AltNowawes,
                    Stops.RathausBabelsberg,
                    Stops.RathausBabelsberg,
                    Stops.Spindelstr,
                    Stops.Kreuzstr,
                    Stops.Plantagenstr,
                    Stops.Fontanestr,
                    Stops.Freiligrathstr,
                    Stops.OttoErichStr,
                    Stops.HiroshimaNagasakiPlatz,
                    Stops.SGriebnitzsee,
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
                    Stops.MaxBornStr,
                    Stops.OttoHahnRing,
                    Stops.HansAlbersStr,
                    Stops.RobertBaberskeStr,
                    Stops.KonradWolfAlleeSternstr,
                    Stops.Gerlachstr,
                    Stops.SternCenterGerlachstr,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M2, M2, M1, M2, M1, M1, M1, M1, M1, M2, M1, M1, M1, M6, M1, M1, M1, M1, M1, M1, M1, M0, M1,
                            M0,
                            M1, M1, M1, M1, M1, M2, M1, M2, M1, M1,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            };

            public static Line.Route SGriebnitzseeSternCenterViaDrewitz { get; } = new()
            {
                ManualAnnotation = "via Robert-Baberske-Str.",
                StopPositions =
                [
                    Stops.SGriebnitzsee,
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
                    Stops.MaxBornStr,
                    Stops.OttoHahnRing,
                    Stops.HansAlbersStr,
                    Stops.RobertBaberskeStr,
                    Stops.KonradWolfAlleeSternstr,
                    Stops.Gerlachstr,
                    Stops.SternCenterGerlachstr,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M1, M1, M0, M1, M0, M1, M1, M1, M1, M1, M2, M1, M2, M1, M1,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            };

            public static Line.Route SGriebnitzseeKonradWolfAlleeViaDrewitz { get; } = new()
            {
                ManualAnnotation = "via Robert-Baberske-Str.",
                StopPositions =
                [
                    Stops.SGriebnitzsee,
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
                    Stops.MaxBornStr,
                    Stops.OttoHahnRing,
                    Stops.HansAlbersStr,
                    Stops.RobertBaberskeStr,
                    Stops.KonradWolfAlleeSternstr,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M1, M1, M0, M1, M0, M1, M1, M1, M1, M1, M2, M1, M2,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            };

            public static Line.Route KüsselstrRathausBabelsberg { get; } = new()
            {
                StopPositions =
                [
                    Stops.Küsselstr,
                    Stops.Tornowstr,
                    Stops.AlterTornow,
                    Stops.TemplinerEck,
                    Stops.TemplinerEck,
                    Stops.TemplinerStr,
                    Stops.Finkenweg,
                    Stops.SHauptbahnhof,
                    Stops.SHauptbahnhofNordIlb,
                    Stops.HumboldtringLottePulewkaStr,
                    Stops.WiesenstrLottePulewkaStr,
                    Stops.AltNowawes,
                    Stops.RathausBabelsberg,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M0, M1, M1, M3, M2, M2, M1, M2, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M0, M1, M1, M3, M4, M2, M1, M3, M1,
                        ],
                    },
                ],
                CommonStopIndex = 7 /* S Hauptbahnhof */,
            };

            public static Line.Route SHauptbahnhofRathausBabelsberg { get; } = new()
            {
                StopPositions =
                [
                    Stops.SHauptbahnhof,
                    Stops.SHauptbahnhofNordIlb,
                    Stops.HumboldtringLottePulewkaStr,
                    Stops.WiesenstrLottePulewkaStr,
                    Stops.AltNowawes,
                    Stops.RathausBabelsberg,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M2, M2, M1, M2, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M4, M2, M1, M3, M1,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            };
        }

        public static class TowardsKüsselstr
        {
            public static Line.Route JKeplerPlatzRathausBabelsberg { get; } = new()
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
                    Stops.RathausBabelsberg,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M2, M2, M0, M1, M1, M1, M2, M1, M1, M1]
                    }
                ],
                CommonStopIndex = 11 /* S Griebnitzsee */,
            };

            public static Line.Route JKeplerPlatzSGriebnitzsee { get; } = new()
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
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M2],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M1, M1, M1, M1, M0, M1, M1, M1, M1, M0, M1, M2],
                    },
                ],
                CommonStopIndex = 0,
            };

            public static Line.Route SternCenterSHauptbahnhof { get; } = new()
            {
                StopPositions =
                [
                    Stops.SternCenterGerlachstr,
                    Stops.OttoHahnRing,
                    Stops.MaxBornStr,
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
                            M3, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M2, M2, M0, M1, M1, M1, M2, M1,
                            M1, M1, M1, M3, M1, M2, M2, M2,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M1, M1, M1, M1, M1, M1, M1, M0, M1, M1, M1, M1, M0, M1, M2, M2, M0, M1, M1, M1, M2, M1,
                            M1, M0, M1, M2, M1, M1, M1, M2,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            };

            public static Line.Route SternCenterKüsselstr { get; } = new()
            {
                StopPositions =
                [
                    Stops.SternCenterGerlachstr,
                    Stops.OttoHahnRing,
                    Stops.MaxBornStr,
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
                    Stops.RathausBabelsberg,
                    Stops.AltNowawes,
                    Stops.WiesenstrLottePulewkaStr,
                    Stops.HumboldtringLottePulewkaStr,
                    Stops.SHauptbahnhofNordIlb,
                    Stops.LangeBrücke,
                    Stops.SHauptbahnhof,
                    Stops.Finkenweg,
                    Stops.TemplinerStr,
                    Stops.TemplinerEck,
                    Stops.AlterTornow,
                    Stops.HoffbauerStiftung,
                    Stops.Tornowstr,
                    Stops.Küsselstr,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M2, M2, M0, M1, M1, M1, M2, M1,
                            M1, M1, M1, M3, M1, M2, M2, M2, M3, M0, M2, M1, M2, M1, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M1, M1, M1, M1, M1, M1, M2, M1, M1, M1, M1, M1, M1, M1, M2, M2, M0, M1, M1, M1, M2, M1,
                            M1, M1, M1, M3, M1, M2, M2, M2, M3, M0, M2, M1, M2, M1, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M1, M1, M1, M1, M1, M1, M2, M1, M1, M1, M1, M1, M1, M1, M2, M2, M1, M1, M1, M1, M2, M1,
                            M1, M1, M1, M3, M1, M2, M2, M2, M3, M0, M2, M1, M2, M1, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M1, M1, M1, M1, M1, M1, M1, M0, M1, M1, M1, M1, M0, M1, M2, M2, M0, M1, M1, M1, M2, M1,
                            M1, M0, M1, M2, M1, M1, M1, M2, M3, M0, M2, M1, M2, M1, M1,
                        ],
                    },
                ],
                CommonStopIndex = 8 /* Stadtwerke */,
            };

            public static Line.Route RathausBabelsbergHoffbauerStiftung { get; } = new()
            {
                StopPositions =
                [
                    Stops.RathausBabelsberg,
                    Stops.AltNowawes,
                    Stops.WiesenstrLottePulewkaStr,
                    Stops.HumboldtringLottePulewkaStr,
                    Stops.SHauptbahnhofNordIlb,
                    Stops.LangeBrücke,
                    Stops.SHauptbahnhof,
                    Stops.Finkenweg,
                    Stops.TemplinerStr,
                    Stops.TemplinerEck,
                    Stops.AlterTornow,
                    Stops.HoffbauerStiftung,
                ],
                TimeProfiles =
                    [new Line.Route.TimeProfile { StopDistances = [M1, M3, M1, M2, M2, M2, M3, M0, M2, M1, M2,], },],
                CommonStopIndex = 0,
            };

            public static Line.Route SHauptbahnhofHoffbauerStiftung { get; } = new()
            {
                StopPositions =
                [
                    Stops.SHauptbahnhof,
                    Stops.Finkenweg,
                    Stops.TemplinerStr,
                    Stops.TemplinerEck,
                    Stops.AlterTornow,
                    Stops.HoffbauerStiftung,
                ],
                TimeProfiles =
                    [new Line.Route.TimeProfile { StopDistances = [M3, M0, M2, M1, M2,], },],
                CommonStopIndex = 0,
            };

            public static Line.Route SternCenterSGriebnitzsee { get; } = new()
            {
                StopPositions =
                [
                    Stops.SternCenterGerlachstr,
                    Stops.OttoHahnRing,
                    Stops.MaxBornStr,
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
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M1, M1, M1, M1, M1, M1, M1, M0, M1, M1, M1, M1, M0, M1, M2,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M2,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            };

            public static Line.Route RathausBabelsbergSHauptbahnhof { get; } = new()
            {
                StopPositions =
                [
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
                    new Line.Route.TimeProfile { StopDistances = [M1, M2, M1, M1, M1, M2] },
                    new Line.Route.TimeProfile { StopDistances = [M1, M3, M1, M2, M2, M2] },
                ],
                CommonStopIndex = 0,
            };

            public static Line.Route RathausBabelsbergKüsselstr { get; } = new()
            {
                StopPositions =
                [
                    Stops.RathausBabelsberg,
                    Stops.AltNowawes,
                    Stops.WiesenstrLottePulewkaStr,
                    Stops.HumboldtringLottePulewkaStr,
                    Stops.SHauptbahnhofNordIlb,
                    Stops.LangeBrücke,
                    Stops.SHauptbahnhof,
                    Stops.Finkenweg,
                    Stops.TemplinerStr,
                    Stops.TemplinerEck,
                    Stops.AlterTornow,
                    Stops.HoffbauerStiftung,
                    Stops.Tornowstr,
                    Stops.Küsselstr,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile { StopDistances = [M1, M2, M1, M1, M1, M2, M3, M0, M2, M1, M2, M1, M1] },
                    new Line.Route.TimeProfile { StopDistances = [M1, M3, M1, M2, M2, M2, M3, M0, M2, M1, M2, M1, M1] },
                ],
                CommonStopIndex = 0,
            };

            public static Line.Route SHauptbahnhofKüsselstr { get; } = new()
            {
                StopPositions =
                [
                    Stops.SHauptbahnhof,
                    Stops.Finkenweg,
                    Stops.TemplinerStr,
                    Stops.TemplinerEck,
                    Stops.AlterTornow,
                    Stops.HoffbauerStiftung,
                    Stops.Tornowstr,
                    Stops.Küsselstr,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile { StopDistances = [M3, M0, M2, M1, M2, M1, M1] }
                ],
                CommonStopIndex = 0,
            };
        }
    }
}
