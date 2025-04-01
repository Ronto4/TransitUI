using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.Bus612;

public class Bus612From20241215 : ILineInstance
{
    private static readonly Bus612From20241214 Original = new();
    public DateOnly ValidFrom { get; } = new(2024, 12, 15);

    public Line Line { get; } = Original.Line with
    {
        Routes =
        [
            ..Original.Line.Routes[..2], new Line.Route
            {
                ManualAnnotation = "via Bornim",
                StopPositions =
                [
                    Stops.NeuTöplitzWendeplatz,
                    Stops.NeuTöplitzWeinbergstr,
                    Stops.TöplitzZurAltenFähre,
                    Stops.TöplitzSportplatz,
                    Stops.TöplitzFeuerwehr,
                    Stops.TöplitzKirschweg,
                    Stops.TöplitzLeesterStr,
                    Stops.LeestKirche,
                    Stops.LeestEichholzweg,
                    Stops.SchlänitzseeWeg,
                    Stops.AmKüssel,
                    Stops.WublitzstrAmBahnhof,
                    Stops.Geiselberg,
                    Stops.SportplatzBornim,
                    Stops.Hugstr,
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
                ],
                TimeProfiles =
                [
                    new Line.Route.TimeProfile
                    {
                        StopDistances =
                        [
                            M1, M1, M0, M1, M1, M1, M1, M2, M1, M2, M1, M1, M1, M1, M1, M0, M2, M1, M2, M3, M2, M1, M2,
                            M1,
                        ],
                    },
                ],
                CommonStopIndex = 0,
            },
            ..Original.Line.Routes[3..]
        ],
        TripsCreate = Original.Line.TripsCreate.Select(tripCreate =>
            tripCreate.StartTime == new TimeOnly(7, 30) && tripCreate.RouteIndex.Equals(2)
                ? tripCreate with { StartTime = new TimeOnly(7, 21) }
                : tripCreate).ToArray(),
    };
}
