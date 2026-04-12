using Timetable;
using static VipTimetable.Minutes;

namespace VipTimetable.Lines.BusN16;

public class BusN16On20250308 : ILineInstance
{
    public DateOnly ValidFrom { get; } = new(2025, 3, 8);
    public DateOnly? ValidUntilInclusive() => ValidFrom;

    private static BusN16From20250203 Previous { get; } = new();

    public Line Line { get; } = Previous.Line with
    {
        Routes =
        [
            ..Previous.Line.Routes,
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
                ],
                TimeProfiles = Previous.Line.Routes[6].TimeProfiles
                    .Select(profile => profile with { StopDistances = profile.StopDistances[..19] }).ToArray(),
                CommonStopIndex = Previous.Line.Routes[6].CommonStopIndex,
            },
        ],
        TripsCreate =
        [
            ..Previous.Line.TripsCreate,
            new Line.TripCreate
            {
                RouteIndex = 7,
                TimeProfileIndex = 0,
                DaysOfOperation = DaysOfOperation.Saturday,
                StartTime = new TimeOnly(5, 2),
            },
        ],
    };
}
