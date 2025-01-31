using Timetables.Models;
using static Timetables.Vip.Minutes;

namespace Timetables.Vip.Lines.BusN16;

public class BusN16From20241214 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 12, 14);

    public Line Line { get; } = new()
    {
        Name = "N16",
        TransportationType = TransportationType.Bus,
        OperationTime = LineOperationTime.Complete,
        MainRouteIndices = [0, 1, 2, 3, 5, 6],
        OverviewRouteIndices = [2, 6],
        Annotations = new Dictionary<string, string>
        {
            { "H", "weiter als 603 nach Höhenstr." },
            { "Ö", "kommt als 603 von Höhenstr." },
            { "Z", "S Nikolassee besteht Anschluss zur Linie N18 Richtung Zehlendorf Eiche" }
        },
        Routes =
        [
            new Line.Route
            {
                StopPositions =
                [
                    Stops.SHauptbahnhof,
                    Stops.AlterMarktLandtag,
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.BurgstrKlinikum,
                    Stops.Holzmarktstr,
                    Stops.SchiffbauergasseBerlinerStr,
                    Stops.Mangerstr,
                    Stops.LeonardoDaVinciStr,
                    Stops.GlienickerBrücke,
                    Stops.BerlinGlienickerLake,
                    Stops.BerlinSchlossGlienicke,
                    Stops.BerlinNikolskoerWeg,
                    Stops.BerlinSchäferberg,
                    Stops.BerlinFriedenstr,
                    Stops.BerlinSchuchardtweg,
                    Stops.BerlinRathausWannsee,
                    Stops.BerlinPfaueninselchausseeKönigstr,
                    Stops.BerlinWernerstr,
                    Stops.BerlinAmKleinenWannsee,
                    Stops.BerlinWannseebrücke,
                    Stops.BerlinSWannsee,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M3, M1, M1, M1, M2, M1, M1, M1, M0, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.PlatzDerEinheitWest,
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.BurgstrKlinikum,
                    Stops.Holzmarktstr,
                    Stops.SchiffbauergasseBerlinerStr,
                    Stops.Mangerstr,
                    Stops.LeonardoDaVinciStr,
                    Stops.GlienickerBrücke,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M2, M1, M1, M2, M1, M1, M1],
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
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.BurgstrKlinikum,
                    Stops.Holzmarktstr,
                    Stops.SchiffbauergasseBerlinerStr,
                    Stops.Mangerstr,
                    Stops.LeonardoDaVinciStr,
                    Stops.GlienickerBrücke,
                    Stops.BerlinGlienickerLake,
                    Stops.BerlinSchlossGlienicke,
                    Stops.BerlinNikolskoerWeg,
                    Stops.BerlinSchäferberg,
                    Stops.BerlinFriedenstr,
                    Stops.BerlinSchuchardtweg,
                    Stops.BerlinRathausWannsee,
                    Stops.BerlinPfaueninselchausseeKönigstr,
                    Stops.BerlinWernerstr,
                    Stops.BerlinAmKleinenWannsee,
                    Stops.BerlinWannseebrücke,
                    Stops.BerlinSWannsee,
                    Stops.BerlinTillmannsweg,
                    Stops.BerlinAmSandwerer,
                    Stops.BerlinWasserwerkBeelitzhof,
                    Stops.BerlinBadeweg,
                    Stops.BerlinSNikolassee,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M3, M1, M1, M1, M2, M1, M1, M1, M0, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M0, M1,
                            M1, M2
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.BerlinSWannsee,
                    Stops.BerlinWannseebrücke,
                    Stops.BerlinAmKleinenWannsee,
                    Stops.BerlinWernerstr,
                    Stops.BerlinPfaueninselchausseeKönigstr,
                    Stops.BerlinRathausWannsee,
                    Stops.BerlinSchuchardtweg,
                    Stops.BerlinFriedenstr,
                    Stops.BerlinSchäferberg,
                    Stops.BerlinNikolskoerWeg,
                    Stops.BerlinSchlossGlienicke,
                    Stops.BerlinGlienickerLake,
                    Stops.GlienickerBrücke,
                    Stops.LeonardoDaVinciStr,
                    Stops.Mangerstr,
                    Stops.SchiffbauergasseBerlinerStr,
                    Stops.Holzmarktstr,
                    Stops.BurgstrKlinikum,
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.AlterMarktLandtag,
                    Stops.LangeBrücke,
                    Stops.SHauptbahnhof,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M1, M1, M1, M1, M0, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1, M2, M1]
                    }
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.GlienickerBrücke,
                    Stops.LeonardoDaVinciStr,
                    Stops.Mangerstr,
                    Stops.SchiffbauergasseBerlinerStr,
                    Stops.Holzmarktstr,
                    Stops.BurgstrKlinikum,
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.AlterMarktLandtag,
                    Stops.LangeBrücke,
                    Stops.SHauptbahnhof,
                ],
                TimeProfiles = [new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M1, M1, M1, M1, M2, M1] }],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.GlienickerBrücke,
                    Stops.LeonardoDaVinciStr,
                    Stops.Mangerstr,
                    Stops.SchiffbauergasseBerlinerStr,
                    Stops.Holzmarktstr,
                    Stops.BurgstrKlinikum,
                    Stops.PlatzDerEinheitBildungsforum,
                ],
                TimeProfiles = [new Line.Route.TimeProfile { StopDistances = [M1, M1, M1, M1, M1, M1] }],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.BerlinSNikolassee,
                    Stops.BerlinSNikolassee,
                    Stops.BerlinWannseebadweg,
                    Stops.BerlinBadeweg,
                    Stops.BerlinWasserwerkBeelitzhof,
                    Stops.BerlinAmSandwerer,
                    Stops.BerlinTillmannsweg,
                    Stops.BerlinSWannsee,
                    Stops.BerlinWannseebrücke,
                    Stops.BerlinAmKleinenWannsee,
                    Stops.BerlinWernerstr,
                    Stops.BerlinPfaueninselchausseeKönigstr,
                    Stops.BerlinRathausWannsee,
                    Stops.BerlinSchuchardtweg,
                    Stops.BerlinFriedenstr,
                    Stops.BerlinSchäferberg,
                    Stops.BerlinNikolskoerWeg,
                    Stops.BerlinSchlossGlienicke,
                    Stops.BerlinGlienickerLake,
                    Stops.GlienickerBrücke,
                    Stops.LeonardoDaVinciStr,
                    Stops.Mangerstr,
                    Stops.SchiffbauergasseBerlinerStr,
                    Stops.Holzmarktstr,
                    Stops.BurgstrKlinikum,
                    Stops.PlatzDerEinheitBildungsforum,
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
                            M0, M2, M0, M1, M0, M1, M1, M1, M1, M1, M1, M1, M0, M1, M1, M1, M1, M1, M1, M1, M1, M1, M1,
                            M1, M1, M1, M2, M1
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
                StartTime = new TimeOnly(21, 33),
            }.AlsoEvery(M60, new TimeOnly(23, 33)),
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(4, 33),
            },
            new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(6, 33),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(21, 5),
                AnnotationSymbols = ["Ö"],
            }.AlsoEvery(M60, new TimeOnly(23, 5)),
            ..new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(0, 33),
                AnnotationSymbols = ["Z"],
            }.AlsoEvery(M60, new TimeOnly(3, 33)),
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(4, 33),
                AnnotationSymbols = ["Z"],
            },
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(5, 33),
                AnnotationSymbols = ["Z"],
            },
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(20, 57),
            }.AlsoEvery(M60, new TimeOnly(23, 57)),
            new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(23, 38),
            },
            ..new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(21, 28),
                AnnotationSymbols = ["H"],
            }.AlsoEvery(M60, new TimeOnly(22, 28)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(1, 2),
            }.AlsoEvery(M60, new TimeOnly(4, 2)),
            ..new Line.TripCreate
            {
                RouteIndex = 6,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Sunday,
                StartTime = new TimeOnly(5, 2),
            }.AlsoEvery(M60, new TimeOnly(6, 2)),
        ],
    };
}