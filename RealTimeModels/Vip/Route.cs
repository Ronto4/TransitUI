using JSO = RealTimeModels.Vip.JsonObjects;
using System;
using System.Collections.Generic;

namespace RealTimeModels.Vip;

public class Route
{
    // Attributes
    public List<Alert> Alerts { get; }
    public string Authority { get; }
    public List<string>? Directions { get; }
    public long Id { get; }
    public string LineName { get; }
    public string RouteType { get; }
    public string ShortLineName { get; }
    // Constructors
    public Route(List<Alert> alerts, string authority, long id, string lineName, string routeType, string shortLineName, List<string>? directions = null)
    {
        Alerts = alerts;
        Authority = authority;
        Directions = directions;
        Id = id;
        LineName = lineName;
        RouteType = routeType;
        ShortLineName = shortLineName;
    }
    internal Route(JSO.Route route)
    {
        Alerts = route.alerts.Select((alert) => new Alert(alert)).ToList();
        Authority = route.authority;
        Directions = route.directions;
        Id = Convert.ToInt64(route.id);
        LineName = route.name;
        RouteType = route.routeType;
        ShortLineName = route.shortName;
    }
}
