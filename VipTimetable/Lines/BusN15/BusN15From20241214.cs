using Timetable.Models;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.BusN15;

public class BusN15From20241214 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 12, 14);

    public Line Line { get; } = new()
    {
        Name = "N15",
        TransportationType = TransportationType.Bus,
        OperationTime = LineOperationTime.Nighttime,
        MainRouteIndices = [0, 1, 2, 3],
        OverviewRouteIndices = [0, 1, 2, 3],
        Annotations = new Dictionary<string, string>
        {
            { "KB", "Einsatz eines Kleinbusses" },
        },
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.AmUpstall,
                    Stops.Eisbergstücke,
                    Stops.FahrländerSee,
                    Stops.Plantagenweg,
                    Stops.Bassewitz,
                    Stops.HeinrichHeineWeg,
                ],
                TimeProfiles = [new Line.Route.TimeProfile { StopDistances = [M1, M2, M1, M1, M1] }],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Birkenweg,
                    Stops.AmSchlahn,
                    Stops.Bullenwinkel,
                    Stops.Krampnitzsee,
                    Stops.Bassewitz,
                    Stops.HeinrichHeineWeg,
                    Stops.Römerschanze,
                    Stops.AmundsenstrNedlitzerStr,
                    Stops.CampusJungfernseeNedlitzerStr,
                    Stops.RoteKaserneNedlitzerStr,
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
                        { StopDistances = [M1, M1, M2, M1, M1, M1, M0, M0, M1, M1, M3, M1, M3, M2, M1, M1, M2, M1] }
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
                    Stops.CampusJungfernseeNedlitzerStr,
                    Stops.AmundsenstrNedlitzerStr,
                    Stops.Römerschanze,
                    Stops.HeinrichHeineWeg,
                    Stops.Bassewitz,
                    Stops.Krampnitzsee,
                    Stops.Bullenwinkel,
                    Stops.AmSchlahn,
                    Stops.TheodorFontaneStr,
                    Stops.KircheGroßGlienicke,
                    Stops.AmAnger,
                    Stops.FriedrichGüntherPark,
                    Stops.SacrowerAlleeRichardWagnerStr,
                    Stops.Hechtsprung,
                    Stops.Birkenweg,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M1, M1, M1, M1, M1, M1, M2, M1, M1, M1, M1, M0, M1, M2, M2, M1, M1, M1, M1, M1, M1, M1,
                            M1
                        ]
                    }
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.HeinrichHeineWeg,
                    Stops.Bassewitz,
                    Stops.Plantagenweg,
                    Stops.FahrländerSee,
                    Stops.Eisbergstücke,
                    Stops.AmUpstall,
                ],
                TimeProfiles = [new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M2, M2] }],
                CommonStopIndex = 0,
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
                    Stops.Plantagenweg,
                    Stops.FahrländerSee,
                    Stops.Eisbergstücke,
                    Stops.AmUpstall,
                ],
                TimeProfiles = [new Line.Route.TimeProfile { StopDistances = [M2, M1, M0, M1, M1, M1, M2, M2] }],
                CommonStopIndex = 0,
            },
        ],
        TripsCreate =
        [
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(1, 40),
                AnnotationSymbols = ["KB"],
            }.AlsoEvery(M60, new TimeOnly(4, 40)),
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday
                /*
                 On the official timetable it was indicated that this trip only occurs on Saturdays instead.
                 Since none of the timetables before and after the timetable valid on 2024-12-14 indicate this,
                 and the GTFS feed valid on this date also indicates operation on Sundays, it is assumed here.
                 */,
                StartTime = new TimeOnly(5, 40),
                AnnotationSymbols = ["KB"],
            },
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(1, 42),
            }.AlsoEvery(M60, new TimeOnly(4, 42)),
            new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday
                /*
                 On the official timetable it was indicated that this trip only occurs on Saturdays instead.
                 Since none of the timetables before and after the timetable valid on 2024-12-14 indicate this,
                 and the GTFS feed valid on this date also indicates operation on Sundays, it is assumed here.
                 */,
                StartTime = new TimeOnly(5, 42),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(1, 10),
            }.AlsoEvery(M60, new TimeOnly(5, 10)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(1, 26),
                AnnotationSymbols = ["KB"],
            }.AlsoEvery(M60, new TimeOnly(5, 26)),
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(6, 23),
                AnnotationSymbols = ["KB"],
            },
        ],
    };
}