using System.Collections.Generic;

namespace RealTimeModels.Vip.JsonObjects;

class ActualPredictionEntry
{
    public int actualRelativeTime { get; set; } = default;
    public string? actualTime { get; set; } = null;
    public List<AlertEntry>? alerts { get; set; } = null;
    public string direction { get; set; } = string.Empty;
    public string mixedTime { get; set; } = string.Empty;
    public string passageid { get; set; } = string.Empty;
    public string patternText { get; set; } = string.Empty;
    public string plannedTime { get; set; } = string.Empty;
    public string routeId { get; set; } = string.Empty;
    public string status { get; set; } = string.Empty;
    public string tripId { get; set; } = string.Empty;
    public string? vehicleId { get; set; } = null;
    public List<string>? vias { get; set; } = null;
}
