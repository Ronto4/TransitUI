namespace RealTimeModels.Vip.JsonObjects;

class Route
{
    public List<AlertEntry> alerts { get; set; } = new List<AlertEntry>();
    public string authority { get; set; } = string.Empty;
    public List<string> directions { get; set; } = new List<string>();
    public string id { get; set; } = string.Empty;
    public string name { get; set; } = string.Empty;
    public string routeType { get; set; } = string.Empty;
    public string shortName { get; set; } = string.Empty;
}
