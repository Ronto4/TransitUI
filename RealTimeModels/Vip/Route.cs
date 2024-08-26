using System.Diagnostics.CodeAnalysis;
using JSO = RealTimeModels.Vip.JsonObjects;

namespace RealTimeModels.Vip;

public record Route
{
    public required List<Alert> Alerts { get; init; }
    public required string Authority { get; init; }
    public required List<string> Directions { get; init; }
    public required long Id { get; init; }
    public required string LineName { get; init; }
    public required string RouteType { get; init; }
    public required string ShortLineName { get; init; }
    
    [SetsRequiredMembers]
    internal Route(JSO.Route route)
    {
        Alerts = route.alerts.Select(alert => new Alert(alert)).ToList();
        Authority = route.authority;
        Directions = route.directions;
        Id = Convert.ToInt64(route.id);
        LineName = route.name;
        RouteType = route.routeType;
        ShortLineName = route.shortName;
    }
}
