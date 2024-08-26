using System.Diagnostics.CodeAnalysis;
using System.Text;
using RealTimeModels.Vip.JsonObjects;
using System.Text.Json;

namespace RealTimeModels.Vip;

public record Station
{
    public required List<RealTimeEntry> Actual { get; init; }
    public required List<object> Directions { get; init; } // Usage unclear, it always seems to be empty.
    public required DateTime FirstPassageTime { get; init; }
    public required List<Alert> Alerts { get; init; }

    public required DateTime LastPassageTime { get; init; }

    //public List<RealTimeEntry> AlreadyDeparted { get; }
    public required List<Route> Routes { get; init; }
    public required string StationName { get; init; }
    public required int StationId { get; init; }

    [SetsRequiredMembers]
    private Station(PredictionJsonObject json)
    {
        Directions = json.directions;
        FirstPassageTime = new DateTime(json.firstPassageTime * 1000 * 10).AddTicks(DateTime.UnixEpoch.Ticks);
        Alerts = json.generalAlerts.Select(alert => new Alert(alert)).ToList();
        LastPassageTime = new DateTime(json.lastPassageTime * 1000 * 10).AddTicks(DateTime.UnixEpoch.Ticks);
        Routes = json.routes.Select(route => new Route(route)).ToList();
        StationName = json.stopName;
        StationId = Convert.ToInt32(json.stopShortName);
        Actual = json.actual.Select(actual => new RealTimeEntry
        {
            Alerts = actual.alerts?.Select(alert => new Alert(alert)).ToList() ?? [],
            Direction = actual.direction,
            Route = Routes.First(route => route.Id == Convert.ToInt64(actual.routeId)),
            Status = actual.status,
            Vehicle = actual.vehicleId is not null ? new Vehicle(actual.vehicleId) : null,
            Vias = actual.vias ?? [],
            ActualTime = actual.actualTime is null ? null : DateTime.Parse(actual.actualTime),
            MixedTime = actual.mixedTime,
            PassageId = Convert.ToInt64(actual.passageid),
            PatternText = actual.patternText,
            PlannedTime = DateTime.Parse(actual.plannedTime),
            TripId = Convert.ToInt64(actual.tripId),
            ActualRelativeTime = new TimeSpan(0, 0, actual.actualRelativeTime),
        }).ToList();
    }

    public static Station GetFromJsonString(string jsonString)
    {
        var json = JsonSerializer.Deserialize<PredictionJsonObject>(jsonString);
        if (json is null)
            throw new ArgumentNullException(nameof(json), $"JsonSerializer returned null.");

        return new Station(json);
    }

    public override string ToString()
    {
        var infoSb = new StringBuilder();
        infoSb.Append($"Haltestellenname: {StationName}, Id: {StationId}{Environment.NewLine}");
        if (Alerts.Count > 0)
        {
            infoSb.Append("Hinweise:");
            foreach (var alert in Alerts)
            {
                infoSb.Append($"  - {alert.Message}{Environment.NewLine}");
            }
        }

        infoSb.Append($"Erste Zeit: {FirstPassageTime}, letzte Zeit: {LastPassageTime}{Environment.NewLine}");
        if (Directions.Count > 0)
        {
            infoSb.Append("Ziele (Directions):");
            for (var i = 0; i < Directions.Count; i++)
            {
                infoSb.Append($"  - {Directions[i]}{Environment.NewLine}");
            }
        }

        infoSb.Append($"Es fahren:{Environment.NewLine}");
        for (var i = 0; i < Actual.Count; i++)
        {
            infoSb.Append($"  {i + 1}. {Actual[i]}{Environment.NewLine}");
        }

        return infoSb.ToString();
    }
}
