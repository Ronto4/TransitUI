using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus694;

public class Bus694From20250804 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 8, 4);
    private static Bus694From20241214 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        MainRouteIndices = Previous.Line.MainRouteIndices.Where(index => !index.Equals(8)).ToArray(),
        Routes =
        [
            ..Previous.Line.Routes,
            new Line.Route
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
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M0, M1, M1, M3, M2, M2, M1, M2, M1, M1, M1, M1, M1, M2, M1, M1, M1, M6, M1, M1,
                            M1, M1, M1, M1, M1, M0, M1, M0, M1, M1, M1,
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
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M2, M2, M1, M2, M1, M1, M1, M1, M1, M2, M1, M1, M1, M6, M1, M1, M1, M1, M1, M1, M1, M0, M1,
                            M0, M1, M1, M1,
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
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M2, M2, M1, M2, M1, M1, M1, M1, M1, M2, M1, M1, M1, M6, M1, M1, M1, M1, M1, M1, M1, M0, M1,
                            M0, M1, M1, M1, M1, M1, M2, M1, M2,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
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
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M1, M1, M0, M1, M0, M1, M1, M1,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
        ],
        TripsCreate = Previous.Line.TripsCreate.SelectMany(trip =>
            trip.RouteIndex.Equals(6) && trip.StartTime == new TimeOnly(20, 32)
                ?
                [
                    trip with
                    {
                        RouteIndex = 22,
                        TimeProfileIndex = 0,
                        DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Weekday | DaysOfOperation.Saturday,
                        Connections =
                        [
                            new Line.TripCreate.Connection
                            {
                                ConnectingLineIdentifier = "bus699",
                                ConnectingRouteIndex = 2,
                                Delay = M0,
                                Type = Line.Trip.ConnectionType.ContinuesAs,
                            },
                        ],
                    },
                    trip with { DaysOfOperation = trip.DaysOfOperation & DaysOfOperation.Sunday }
                ]
                : trip.RouteIndex.Equals(7) &&
                  (trip.StartTime == new TimeOnly(20, 20) || trip.StartTime == new TimeOnly(21, 20))
                    ? (trip with
                    {
                        RouteIndex = 23,
                        TimeProfileIndex = 0,
                        Connections =
                        [
                            new Line.TripCreate.Connection
                            {
                                ConnectingLineIdentifier = "bus699", ConnectingRouteIndex = 2,
                                Delay = M0,
                                Type = Line.Trip.ConnectionType.ContinuesAs,
                            },
                        ],
                    }).Iter()
                    : trip.RouteIndex.Equals(7) && trip.StartTime == new TimeOnly(21, 0)
                        ? (trip with
                        {
                            RouteIndex = 24,
                            TimeProfileIndex = 0,
                        }).Iter()
                        : trip.RouteIndex.Equals(8) && (trip.StartTime == new TimeOnly(22, 43) ||
                                                        trip.StartTime == new TimeOnly(23, 43))
                            ? (trip with
                            {
                                RouteIndex = 25,
                                TimeProfileIndex = 0,
                                Connections =
                                [
                                    new Line.TripCreate.Connection
                                    {
                                        ConnectingLineIdentifier = "bus699",
                                        ConnectingRouteIndex = 2,
                                        Delay = M0,
                                        Type = Line.Trip.ConnectionType.ContinuesAs,
                                    },
                                ],
                            }).Iter()
                            : trip.Iter()).ToArray(),
    };
}

file static class Extensions {
    extension<T>(T elem)
    {
        public IEnumerable<T> Iter() => [elem];
    }
}
