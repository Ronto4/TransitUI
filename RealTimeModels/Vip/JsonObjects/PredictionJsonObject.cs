using System.Collections.Generic;

namespace RealTimeModels.Vip.JsonObjects;

class PredictionJsonObject
{
    // Attributes
    public List<ActualPredictionEntry> actual { get; set; } = new List<ActualPredictionEntry>();
    public List<object> directions { get; set; } = new List<object>(); // Usage unclear, seems to be empty
    public long firstPassageTime { get; set; } = default;
    public List<AlertEntry> generalAlerts { get; set; } = new List<AlertEntry>();
    public long lastPassageTime { get; set; } = default;
    public List<ActualPredictionEntry> old { get; set; } = new List<ActualPredictionEntry>(); // Already departed
    public List<Route> routes { get; set; } = new List<Route>();
    public string stopName { get; set; } = string.Empty;
    public string stopShortName { get; set; } = string.Empty;
    // Constructor
    public PredictionJsonObject() { }
}
