using Timetables.Models;
using static Timetables.Vip.Minutes;

namespace Timetables.Vip.Lines.Bus692;

public class Bus692From20241214 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2024, 12, 14);

    public Line Line { get; } = new()
    {
        Name = "692",
        TransportationType = TransportationType.Bus,
        MainRouteIndices = [0, 1, 2, 3, 4, 5, 6, 7],
        OverviewRouteIndices = [0, 6],
        Routes =
        [
            new Line.Route
            {
                ManualAnnotation = "via Institut für Agrartechnik",
                StopPositions =
                [
                    Stops.CampusJungfernsee,
                    Stops.AmundsenstrNedlitzerStr,
                    Stops.WeißerSee,
                    Stops.LerchensteigKleingartenanlage,
                    Stops.KläranlagePotsdamNord,
                    Stops.Schneiderremise,
                    Stops.AbzweigNachNedlitz,
                    Stops.TüvAkademie,
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
                    Stops.SchlegelstrPappelallee,
                    Stops.ReiterwegJägerallee,
                    Stops.JägertorJustizzentrum,
                    Stops.Mauerstr,
                    Stops.LuisenplatzNordParkSanssouci,
                    Stops.LuisenplatzOstParkSanssouci,
                    Stops.Dortustr,
                    Stops.PlatzDerEinheitWest,
                    Stops.Bassinplatz,
                    Stops.Klinikum,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M2, M1, M0, M1, M1, M1, M1, M1, M0, M1, M2, M0, M2, M1, M1, M3, M2, M1, M1, M2, M1, M1,
                            M1, M1, M1, M3, M1, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M2, M2, M1, M0, M2, M1, M1, M1, M1, M0, M1, M2, M0, M2, M1, M1, M3, M2, M1, M1, M2, M1, M1,
                            M1, M1, M1, M3, M1, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M2, M2, M1, M0, M2, M1, M1, M1, M1, M0, M1, M2, M0, M2, M1, M2, M3, M2, M1, M1, M2, M1, M1,
                            M1, M1, M1, M3, M1, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M2, M1, M0, M1, M1, M1, M1, M1, M0, M1, M1, M0, M1, M1, M1, M3, M1, M1, M1, M1, M1, M1,
                            M1, M1, M1, M3, M1, M1,
                        ],
                    },
                ],
                CommonStopIndex = 24,
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
                    Stops.SchlegelstrPappelallee,
                    Stops.ReiterwegJägerallee,
                    Stops.JägertorJustizzentrum,
                    Stops.Mauerstr,
                    Stops.LuisenplatzNordParkSanssouci,
                    Stops.LuisenplatzOstParkSanssouci,
                    Stops.Dortustr,
                    Stops.PlatzDerEinheitWest,
                    Stops.Bassinplatz,
                    Stops.Klinikum,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M0, M1, M2, M0, M2, M1, M1, M3, M2, M1, M1, M2, M1, M1, M1, M1, M1, M3, M1, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M0, M1, M2, M0, M2, M1, M2, M3, M2, M1, M1, M2, M1, M1, M1, M1, M1, M3, M1, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M0, M1, M1, M0, M1, M1, M1, M3, M1, M1, M1, M1, M1, M1, M1, M1, M1, M3, M1, M1,
                        ],
                    },
                ],
                CommonStopIndex = 16,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.WeißerSee,
                    Stops.LerchensteigKleingartenanlage,
                    Stops.KläranlagePotsdamNord,
                    Stops.Schneiderremise,
                    Stops.AbzweigNachNedlitz,
                    Stops.TüvAkademie,
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
                    Stops.SchlegelstrPappelallee,
                    Stops.ReiterwegJägerallee,
                    Stops.JägertorJustizzentrum,
                    Stops.Mauerstr,
                    Stops.LuisenplatzNordParkSanssouci,
                    Stops.LuisenplatzOstParkSanssouci,
                    Stops.Dortustr,
                    Stops.PlatzDerEinheitWest,
                    Stops.Bassinplatz,
                    Stops.Klinikum,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M0, M2, M1, M1, M1, M1, M0, M1, M2, M0, M2, M1, M2, M3, M2, M1, M1, M2, M1, M1, M1, M1,
                            M1, M3, M1, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M0, M1, M1, M1, M1, M1, M0, M1, M1, M0, M1, M1, M1, M3, M1, M1, M1, M1, M1, M1,
                            M1, M1, M1, M3, M1, M1,
                        ],
                    },
                ],
                CommonStopIndex = 22,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.CampusJungfernsee,
                    Stops.AmundsenstrNedlitzerStr,
                    Stops.WeißerSee,
                    Stops.LerchensteigKleingartenanlage,
                    Stops.KläranlagePotsdamNord,
                    Stops.Schneiderremise,
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
                    Stops.SchlegelstrPappelallee,
                    Stops.ReiterwegJägerallee,
                    Stops.JägertorJustizzentrum,
                    Stops.Mauerstr,
                    Stops.LuisenplatzNordParkSanssouci,
                    Stops.LuisenplatzOstParkSanssouci,
                    Stops.Dortustr,
                    Stops.PlatzDerEinheitWest,
                    Stops.Bassinplatz,
                    Stops.Klinikum,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M2, M2, M1, M0, M2, M1, M1, M2, M0, M2, M1, M1, M3, M2, M1, M1, M2, M1, M1, M1, M1, M1, M3,
                            M1, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M2, M1, M0, M1, M1, M1, M2, M0, M2, M1, M1, M3, M2, M1, M1, M2, M1, M1, M1, M1, M1, M3,
                            M1, M1,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M2, M2, M1, M0, M2, M1, M1, M2, M0, M2, M1, M1, M3, M2, M1, M1, M2, M1, M1, M1, M1, M1, M3,
                            M1, M1,
                        ],
                    },
                ],
                CommonStopIndex = 20,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Klinikum,
                    Stops.BurgstrKlinikum,
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.PlatzDerEinheitWest,
                    Stops.Dortustr,
                    Stops.LuisenplatzOstParkSanssouci,
                    Stops.LuisenplatzNordParkSanssouci,
                    Stops.JägertorJustizzentrum,
                    Stops.ReiterwegJägerallee,
                    Stops.SchlegelstrPappelallee,
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
                            [M1, M1, M1, M1, M1, M1, M2, M1, M1, M2, M1, M3, M3, M1, M1, M1, M1, M1, M1, M1, M1],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M1, M1, M1, M1, M2, M2, M1, M1, M2, M1, M3, M3, M1, M1, M1, M1, M1, M1, M1, M1],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M1, M1, M1, M1, M2, M2, M1, M1, M2, M1, M3, M3, M1, M1, M2, M1, M1, M1, M1, M1],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                            [M1, M1, M1, M1, M1, M1, M2, M1, M1, M1, M1, M3, M2, M1, M1, M1, M1, M1, M1, M1, M1],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Klinikum,
                    Stops.BurgstrKlinikum,
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.PlatzDerEinheitWest,
                    Stops.Dortustr,
                    Stops.LuisenplatzOstParkSanssouci,
                    Stops.LuisenplatzNordParkSanssouci,
                    Stops.JägertorJustizzentrum,
                    Stops.ReiterwegJägerallee,
                    Stops.SchlegelstrPappelallee,
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
                    Stops.Schneiderremise,
                    Stops.KläranlagePotsdamNord,
                    Stops.LerchensteigKleingartenanlage,
                    Stops.WeißerSee,
                    Stops.AmundsenstrNedlitzerStr,
                    Stops.CampusJungfernsee,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M1, M2, M1, M1, M2, M1, M3, M3, M1, M1, M1, M1, M1, M1, M2, M1, M0, M1,
                            M3, M2
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M2, M2, M1, M1, M2, M1, M3, M3, M1, M1, M2, M1, M1, M1, M2, M1, M1, M1,
                            M3, M2
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M2, M2, M1, M1, M2, M1, M3, M3, M1, M1, M1, M1, M1, M1, M2, M1, M0, M1,
                            M3, M2
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                ManualAnnotation = "via Institut für Agrartechnik",
                StopPositions =
                [
                    Stops.Klinikum,
                    Stops.BurgstrKlinikum,
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.PlatzDerEinheitWest,
                    Stops.Dortustr,
                    Stops.LuisenplatzOstParkSanssouci,
                    Stops.LuisenplatzNordParkSanssouci,
                    Stops.JägertorJustizzentrum,
                    Stops.ReiterwegJägerallee,
                    Stops.SchlegelstrPappelallee,
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
                    Stops.TüvAkademie,
                    Stops.AbzweigNachNedlitz,
                    Stops.Schneiderremise,
                    Stops.KläranlagePotsdamNord,
                    Stops.LerchensteigKleingartenanlage,
                    Stops.WeißerSee,
                    Stops.AmundsenstrNedlitzerStr,
                    Stops.CampusJungfernsee,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M2, M2, M1, M1, M2, M1, M3, M3, M1, M1, M1, M1, M1, M1, M1, M1, M1, M0,
                            M1, M1, M0, M1, M3, M2,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M2, M2, M1, M1, M2, M1, M3, M3, M1, M1, M2, M1, M1, M1, M1, M1, M1, M0,
                            M1, M1, M1, M1, M3, M2,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M1, M2, M1, M1, M1, M1, M3, M2, M1, M1, M1, M1, M1, M1, M1, M1, M1, M0,
                            M1, M1, M0, M1, M2, M2,
                        ],
                    },
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M1, M2, M1, M1, M2, M1, M3, M3, M1, M1, M1, M1, M1, M1, M1, M1, M1, M0,
                            M1, M1, M0, M1, M3, M2,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            new Line.Route
            {
                StopPositions =
                [
                    Stops.Klinikum,
                    Stops.BurgstrKlinikum,
                    Stops.PlatzDerEinheitBildungsforum,
                    Stops.PlatzDerEinheitWest,
                    Stops.Dortustr,
                    Stops.LuisenplatzOstParkSanssouci,
                    Stops.LuisenplatzNordParkSanssouci,
                    Stops.JägertorJustizzentrum,
                    Stops.ReiterwegJägerallee,
                    Stops.SchlegelstrPappelallee,
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
                    Stops.TüvAkademie,
                    Stops.AbzweigNachNedlitz,
                    Stops.Schneiderremise,
                    Stops.KläranlagePotsdamNord,
                    Stops.LerchensteigKleingartenanlage,
                    Stops.WeißerSee,
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M1, M1, M1, M1, M2, M1, M1, M1, M1, M3, M2, M1, M1, M1, M1, M1, M1, M1, M1, M1, M0,
                            M1, M1, M0, M1,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
        ],
        TripsCreate =
        [
            ..Trips.TowardsKlinikum,
            ..Trips.FromKlinikum,
        ],
    };
}

file static class Trips
{
    public static Line.TripCreate[] TowardsKlinikum { get; } =
    [
        new Line.TripCreate
        {
            RouteIndex = 0,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(5, 7),
        },
        new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(5, 55),
        },
        new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(6, 16),
        },
        new Line.TripCreate
        {
            RouteIndex = 0,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(6, 26),
        },
        new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(6, 56),
        },
        new Line.TripCreate
        {
            RouteIndex = 2,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.School,
            StartTime = new TimeOnly(7, 9),
        },
        new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Holiday,
            StartTime = new TimeOnly(7, 15),
        },
        new Line.TripCreate
        {
            RouteIndex = 0,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(7, 25),
        },
        new Line.TripCreate
        {
            RouteIndex = 0,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.School,
            StartTime = new TimeOnly(7, 45),
        },
        new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Holiday,
            StartTime = new TimeOnly(7, 55),
        },
        new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(8, 15),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 3,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(8, 29),
        }.AlsoEvery(M60, new TimeOnly(11, 29)),
        ..new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(8, 56),
        }.AlsoEvery(M60, new TimeOnly(13, 56)),
        ..new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(9, 16),
        }.AlsoEvery(M60, new TimeOnly(14, 16)),
        ..new Line.TripCreate
        {
            RouteIndex = 0,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(12, 26),
        }.AlsoEvery(M60, new TimeOnly(14, 26)),
        ..new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(14, 55),
        }.AlsoEvery(M60, new TimeOnly(15, 55)),
        ..new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(15, 15),
        }.AlsoEvery(M60, new TimeOnly(16, 15)),
        ..new Line.TripCreate
        {
            RouteIndex = 0,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(15, 25),
        }.AlsoEvery(M60, new TimeOnly(16, 25)),
        ..new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(16, 56),
        }.AlsoEvery(M60, new TimeOnly(18, 56)),
        ..new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(17, 16),
        }.AlsoEvery(M60, new TimeOnly(19, 16)),
        ..new Line.TripCreate
        {
            RouteIndex = 3,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(17, 29),
        }.AlsoEvery(M60, new TimeOnly(19, 29)),
        new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(20, 20),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 0,
            TimeProfileIndex = 3,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(20, 32),
        }.AlsoEvery(M60, 2),
        ..new Line.TripCreate
        {
            RouteIndex = 2,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(22, 35),
        }.AlsoEvery(M60, 2),
        new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Friday,
            StartTime = new TimeOnly(0, 40),
        },
        new Line.TripCreate
        {
            RouteIndex = 0,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Saturday,
            StartTime = new TimeOnly(5, 13),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 0,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(6, 13),
        }.AlsoEvery(M60, 2),
        new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Saturday,
            StartTime = new TimeOnly(8, 1),
        },
        new Line.TripCreate
        {
            RouteIndex = 0,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Sunday,
            StartTime = new TimeOnly(8, 13),
        },
        new Line.TripCreate
        {
            RouteIndex = 3,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Saturday,
            StartTime = new TimeOnly(8, 16),
        },
        new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Saturday,
            StartTime = new TimeOnly(8, 41),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(9, 1),
        }.AlsoEvery(M60, new TimeOnly(19, 1)),
        ..new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(9, 41),
        }.AlsoEvery(M60, new TimeOnly(18, 41)),
        new Line.TripCreate
        {
            RouteIndex = 3,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(9, 16),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 3,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(10, 14),
        }.AlsoEvery(M60, new TimeOnly(19, 14)),
        new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(19, 55),
        },
        new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(20, 15),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 0,
            TimeProfileIndex = 3,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(20, 32),
        }.AlsoEvery(M60, 2),
        ..new Line.TripCreate
        {
            RouteIndex = 2,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(22, 35),
        }.AlsoEvery(M60, 2),
        new Line.TripCreate
        {
            RouteIndex = 1,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Saturday,
            StartTime = new TimeOnly(0, 40),
        },
    ];

    public static Line.TripCreate[] FromKlinikum { get; } =
    [
        new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(5, 21),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(6, 1),
        }.AlsoEvery(M20, 2),
        new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Holiday,
            StartTime = new TimeOnly(7, 1),
        },
        new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(7, 21),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(8, 1),
        }.AlsoEvery(M20, 2),
        ..new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(9, 1),
        }.AlsoEvery(M60, new TimeOnly(14, 1)),
        ..new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(9, 21),
        }.AlsoEvery(M60, new TimeOnly(14, 21)),
        ..new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(15, 1),
        }.AlsoEvery(M60, new TimeOnly(16, 1)),
        ..new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(15, 21),
        }.AlsoEvery(M60, new TimeOnly(16, 21)),
        ..new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(17, 1),
        }.AlsoEvery(M60, new TimeOnly(19, 1)),
        ..new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(17, 21),
        }.AlsoEvery(M60, new TimeOnly(19, 21)),
        new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 3,
            DaysOfOperation = DaysOfOperation.Friday | DaysOfOperation.Saturday,
            StartTime = new TimeOnly(0, 4),
        },
        new Line.TripCreate
        {
            RouteIndex = 5,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(5, 41),
        },
        new Line.TripCreate
        {
            RouteIndex = 5,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(8, 41),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 5,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(9, 41),
        }.AlsoEvery(M60, new TimeOnly(12, 41)),
        ..new Line.TripCreate
        {
            RouteIndex = 5,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(16, 41),
        }.AlsoEvery(M60, new TimeOnly(19, 41)),
        new Line.TripCreate
        {
            RouteIndex = 6,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(6, 41),
        },
        new Line.TripCreate
        {
            RouteIndex = 6,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.School,
            StartTime = new TimeOnly(7, 1),
        },
        new Line.TripCreate
        {
            RouteIndex = 6,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(7, 41),
        },
        new Line.TripCreate
        {
            RouteIndex = 6,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(13, 41),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 6,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekday,
            StartTime = new TimeOnly(14, 41),
        }.AlsoEvery(M60, 2),
        new Line.TripCreate
        {
            RouteIndex = 6,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Daily,
            StartTime = new TimeOnly(20, 4),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 7,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Daily,
            StartTime = new TimeOnly(21, 4),
        }.AlsoEvery(M60, 3),
        new Line.TripCreate
        {
            RouteIndex = 6,
            TimeProfileIndex = 3,
            DaysOfOperation = DaysOfOperation.Saturday,
            StartTime = new TimeOnly(5, 17),
        },
        new Line.TripCreate
        {
            RouteIndex = 6,
            TimeProfileIndex = 3,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(6, 17),
        },
        new Line.TripCreate
        {
            RouteIndex = 6,
            TimeProfileIndex = 3,
            DaysOfOperation = DaysOfOperation.Sunday,
            StartTime = new TimeOnly(7, 17),
        },
        new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Saturday,
            StartTime = new TimeOnly(7, 17),
        },
        new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Saturday,
            StartTime = new TimeOnly(7, 57),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(8, 17),
        }.AlsoEvery(M60, 2),
        new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(8, 57),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(9, 56),
        }.AlsoEvery(M60, new TimeOnly(18, 56)),
        ..new Line.TripCreate
        {
            RouteIndex = 4,
            TimeProfileIndex = 1,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(10, 16),
        }.AlsoEvery(M60, new TimeOnly(19, 16)),
        new Line.TripCreate
        {
            RouteIndex = 5,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Saturday,
            StartTime = new TimeOnly(7, 37),
        },
        ..new Line.TripCreate
        {
            RouteIndex = 5,
            TimeProfileIndex = 0,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(8, 37),
        }.AlsoEvery(M60, 2),
        ..new Line.TripCreate
        {
            RouteIndex = 5,
            TimeProfileIndex = 2,
            DaysOfOperation = DaysOfOperation.Weekend,
            StartTime = new TimeOnly(10, 36),
        }.AlsoEvery(M60, new TimeOnly(19, 36)),
    ];
}
