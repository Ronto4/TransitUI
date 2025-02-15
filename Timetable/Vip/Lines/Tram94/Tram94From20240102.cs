using Timetable.Models;

namespace Timetable.Vip.Lines.Tram94;

using static Minutes;

internal class Tram94From20240102 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 1, 2);

    public Line Line { get; } = new()
    {
        Name = "94",
        TransportationType = TransportationType.Tram,
        OverviewRouteIndices = [0, 3],
        MainRouteIndices = [0, 1, 3, 4],
        Routes = [
            new Line.Route
            {
                StopPositions = [
                    Stops.BahnhofPirschheide,
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
                TimeProfiles = [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M2, M1, M1, M1, M2, M1, M3, M1, M1, M2, M1, M1, M1, M2, M1, M1, M1, M1]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M2, M1, M1, M1, M1, M1, M3, M1, M1, M2, M1, M1, M1, M2, M1, M1, M1, M1]
                    }
                ],
                CommonStopIndex = 10,
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
                TimeProfiles = [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M1, M1, M1, M1, M1, M2, M1, M1, M2, M1, M1, M1, M2, M1, M1, M1, M1]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M1, M1, M1, M1, M1, M3, M1, M1, M2, M1, M1, M1, M2, M1, M1, M1, M1]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M2, M1, M1, M1, M2, M1, M3, M1, M1, M2, M1, M1, M1, M2, M1, M1, M1, M1]
                    },
                ],
                CommonStopIndex = 11,
            },
            new Line.Route
            {
                StopPositions = [
                    Stops.BahnhofPirschheide,
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
                    Stops.PlatzDerEinheitBildungsforum,
                ],
                TimeProfiles = [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M2, M1, M1, M1, M1, M1, M3, M1]
                    }
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions = [
                    Stops.Fontanestr,
                    Stops.Plantagenstr,
                    Stops.Anhaltstr,
                    Stops.SBabelsbergWattstr,
                    Stops.RathausBabelsberg,
                    Stops.AltNowawes,
                    Stops.HumboldtringNuthestr,
                    Stops.SchiffbauergasseUferweg,
                    Stops.Holzmarktstr,
                    Stops.BurgstrKlinikum,
                    Stops.PlatzDerEinheitBildungsforum,
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
                    Stops.BahnhofPirschheide
                ],
                TimeProfiles = [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M1, M1, M2, M1, M1, M1, M1, M2, M1, M1, M2, M1, M1, M2, M1, M2, M1, M3]
                    }
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions = [
                    Stops.Fontanestr,
                    Stops.Plantagenstr,
                    Stops.Anhaltstr,
                    Stops.SBabelsbergWattstr,
                    Stops.RathausBabelsberg,
                    Stops.AltNowawes,
                    Stops.HumboldtringNuthestr,
                    Stops.SchiffbauergasseUferweg,
                    Stops.Holzmarktstr,
                    Stops.BurgstrKlinikum,
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.PlatzDerEinheitWest,
                    Stops.Dortustr,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.Feuerbachstr,
                    Stops.AufDemKiewitt,
                    Stops.BahnhofCharlottenhofGeschwisterSchollStr,
                    Stops.SchlossCharlottenhof,
                ],
                TimeProfiles = [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M1, M1, M2, M1, M1, M1, M1, M2, M1, M1, M1, M1, M1, M2]
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M1, M1, M1, M2, M1, M1, M1, M1, M2, M1, M1, M2, M1, M1, M2]
                    }
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions = [
                    Stops.PlatzDerEinheitNord,
                    Stops.Dortustr,
                    Stops.LuisenplatzSüdParkSanssouci,
                    Stops.Feuerbachstr,
                    Stops.AufDemKiewitt,
                    Stops.BahnhofCharlottenhofGeschwisterSchollStr,
                    Stops.SchlossCharlottenhof,
                    Stops.KastanienalleeZeppelinstr,
                    Stops.ImBogenZeppelinstr,
                    Stops.Luftschiffhafen,
                    Stops.BahnhofPirschheide
                ],
                TimeProfiles = [
                    new Line.Route.TimeProfile
                    {
                        StopDistances = [M1, M1, M2, M1, M1, M2, M1, M2, M1, M3]
                    }
                ],
                CommonStopIndex = 0,
            },
        ],
        TripsCreate = [
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(7, 3)
            }.AlsoEvery(M20, new TimeOnly(8, 23)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(13, 44)
            }.AlsoEvery(M20, new TimeOnly(14, 24)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(14, 43)
            }.AlsoEvery(M20, new TimeOnly(16, 23)),
            ..new Line.TripCreate
            {
                RouteIndex = 0,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(16, 44)
            }.AlsoEvery(M20, new TimeOnly(17, 24)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 27)
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(6, 6)
            }.AlsoEvery(M20, 3),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(7, 5)
            }.AlsoEvery(M20, new TimeOnly(8, 25)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(8, 46)
            }.AlsoEvery(M20, new TimeOnly(13, 26)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(13, 46)
            }.AlsoEvery(M20, new TimeOnly(14, 26)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 2,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(14, 45)
            }.AlsoEvery(M20, new TimeOnly(16, 25)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(16, 46)
            }.AlsoEvery(M20, new TimeOnly(17, 26)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(17, 46)
            }.AlsoEvery(M20, new TimeOnly(19, 26)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 27)
            }.AlsoEvery(M20, new TimeOnly(7, 7)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(7, 27)
            }.AlsoEvery(M20, new TimeOnly(10, 7)),
            ..new Line.TripCreate
            {
                RouteIndex = 1,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 26)
            }.AlsoEvery(M20, new TimeOnly(19, 26)),
            new Line.TripCreate
            {
                RouteIndex = 2,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(8, 36)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 43)
            }.AlsoEvery(M20, new TimeOnly(8, 3)),
            ..new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(13, 23)
            }.AlsoEvery(M20, new TimeOnly(17, 3)),
            new Line.TripCreate
            {
                RouteIndex = 3,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Daily,
                StartTime = new TimeOnly(19, 23)
            },
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekday,
                StartTime = new TimeOnly(5, 3)
            }.AlsoEvery(M20, new TimeOnly(5, 43)),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(6, 3)
            }.AlsoEvery(M20, 2),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(8, 23)
            }.AlsoEvery(M20, new TimeOnly(13, 3)),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(17, 23)
            }.AlsoEvery(M20, new TimeOnly(19, 3)),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Holiday,
                StartTime = new TimeOnly(6, 3)
            }.AlsoEvery(M20, new TimeOnly(19, 3)),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 3)
            }.AlsoEvery(M20, new TimeOnly(6, 43)),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(7, 3)
            }.AlsoEvery(M20, new TimeOnly(9, 43)),
            ..new Line.TripCreate
            {
                RouteIndex = 4,
                TimeProfileIndex = 1,
                DaysOfOperation = DaysOfOperation.Weekend,
                StartTime = new TimeOnly(10, 3)
            }.AlsoEvery(M20, new TimeOnly(19, 3)),
            new Line.TripCreate
            {
                RouteIndex = 5,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.School,
                StartTime = new TimeOnly(13, 19)
            }
        ],
    };
}
