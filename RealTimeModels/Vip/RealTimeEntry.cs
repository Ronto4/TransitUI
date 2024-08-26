namespace RealTimeModels.Vip;

public record RealTimeEntry
{
    public required TimeSpan ActualRelativeTime { get; init; }
    public required DateTime? ActualTime { get; init; }
    public required List<Alert> Alerts { get; init; }
    public required string Direction { get; init; }
    public required string MixedTime { get; init; }
    public required long PassageId { get; init; } // Usage unclear
    public required string? PatternText { get; init; }
    public required DateTime PlannedTime { get; init; }
    public required Route Route { get; init; }
    public required string Status { get; init; }
    public required long TripId { get; init; } // Id of trip, may be extracted to class at some point
    public required Vehicle? Vehicle { get; init; }

    public required List<string> Vias { get; init; }

    public override string ToString()
    {
        return
            $"Fahrt der Linie {Route.RouteType} {(PatternText is { Length: > 0 } ? PatternText : Route.LineName)} Richtung {Direction}{(Vias is { Count: 0 } ? string.Empty : $" ({string.Join(", ", Vias)})")}, planmäßig um {PlannedTime}, erwartet um {ActualTime} (in {ActualRelativeTime.TotalSeconds} Sekunden){(Vehicle is null ? string.Empty : $" mit Fahrzeug-Id {Vehicle.Id}")}.";
    }
}
