using System;
using System.Collections.Generic;

namespace RealTimeModels.Vip;

public class RealTimeEntry
    {
        // Attributes
        public TimeSpan ActualRelativeTime { get; }
        public DateTime? ActualTime { get; }
        public List<Alert>? Alerts { get; }
        public string Direction { get; }
        public string MixedTime { get; }
        public long PassageId { get; } // Usage unclear
        public string? PatternText { get; }
        public DateTime PlannedTime { get; }
        public Route Route { get; }
        public string Status { get; }
        public long TripId { get; } // Id of trip, may be extracted to class at some point
        public Vehicle? Vehicle { get; }
        public List<string>? Vias { get; }
        // Constructors
        public RealTimeEntry(TimeSpan actualRelativeTime, DateTime? actualTime, List<Alert>? alerts, string direction, string mixedTime, long passageId, string? patternText, DateTime plannedTime, Route route, string status, long tripId, Vehicle? vehicle, List<string>? vias)
        {
            ActualRelativeTime = actualRelativeTime;
            ActualTime = actualTime;
            Alerts = alerts;
            Direction = direction;
            MixedTime = mixedTime;
            PassageId = passageId;
            PatternText = patternText;
            PlannedTime = plannedTime;
            Route = route;
            Status = status;
            TripId = tripId;
            Vehicle = vehicle;
            Vias = vias;
        }
        // Methods
        public override string ToString()
        {
            string info = string.Empty;
            info += $"Fahrt der Linie {(Route.RouteType is null ? string.Empty : $"{Route.RouteType} ")}{(PatternText is string && PatternText.Length > 0 ? PatternText : Route.LineName)} Richtung {Direction}{(Vias is null ? string.Empty : $" ({string.Join(", ", Vias)})")}, planmäßig um {PlannedTime}, erwartet um {ActualTime} (in {ActualRelativeTime.TotalSeconds} Sekunden){(Vehicle is null ? string.Empty : $" mit Fahrzeug-Id {Vehicle.Id}")}.";
            return info;
        }
    }
