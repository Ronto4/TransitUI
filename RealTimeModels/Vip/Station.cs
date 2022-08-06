using RealTimeModels.Vip.JsonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace RealTimeModels.Vip;

public class Station
    {
        // Attributes
        public List<RealTimeEntry> Actual { get; }
        public List<object> Directions { get; } // Usage unclear, it always seems to be empty.
        public DateTime FirstPassageTime { get; }
        public List<Alert> Alerts { get; }
        public DateTime LastPassageTime { get; }
        //public List<RealTimeEntry> AlreadyDeparted { get; }
        public List<Route> Routes { get; }
        public string StationName { get; }
        public int StationId { get; }
        // Constructors
        internal Station(PredictionJsonObject json)
        {
            Directions = json.directions;
            //FirstPassageTime = new DateTime(json.firstPassageTime);
            FirstPassageTime = new DateTime(json.firstPassageTime * 1000 * 10).AddTicks(DateTime.UnixEpoch.Ticks);
            Alerts = json.generalAlerts.Select((alert) => new Alert(alert)).ToList();
            //LastPassageTime = new DateTime(json.lastPassageTime);
            LastPassageTime = new DateTime(json.lastPassageTime * 1000 * 10).AddTicks(DateTime.UnixEpoch.Ticks);
            Routes = json.routes.Select((route) => new Route(route)).ToList();
            StationName = json.stopName;
            StationId = Convert.ToInt32(json.stopShortName);
            Actual = json.actual.Select((actual) => new RealTimeEntry(new TimeSpan(0, 0, actual.actualRelativeTime), actual.actualTime is null ? (DateTime?)null : DateTime.Parse(actual.actualTime), actual.alerts?.Select((alert) => new Alert(alert)).ToList(), actual.direction, actual.mixedTime, Convert.ToInt64(actual.passageid), actual.patternText, DateTime.Parse(actual.plannedTime), Routes.Where((route) => route.Id == Convert.ToInt64(actual.routeId)).First(), actual.status, Convert.ToInt64(actual.tripId), null, actual.vias)).ToList();
        }
        // Methods
        public static Station GetFromJsonString(string jsonString, bool catalogue = true)
        {
            var json = JsonSerializer.Deserialize<PredictionJsonObject>(jsonString);
            if (json is null)
                throw new ArgumentNullException(nameof(json), $"JsonSerializer returned null.");

            Station station = new(json);
            if (catalogue)
            {
            }

            return station;
        }
        public override string ToString()
        {
            string info = string.Empty;
            info += $"Haltestellenname: {StationName}, Id: {StationId}{Environment.NewLine}";
            if (Alerts.Count > 0)
            {
                info += $"Hinweise:";
                for (int i = 0; i < Alerts.Count; i++)
                {
                    info += $"  - {Alerts[i].Message}{Environment.NewLine}";
                }
            }
            info += $"Erste Zeit: {FirstPassageTime}, letzte Zeit: {LastPassageTime}{Environment.NewLine}";
            if(Directions.Count > 0)
            {
                info += $"Ziele (Directions):";
                for (int i = 0; i < Directions.Count; i++)
                {
                    info += $"  - {Directions[i]}{Environment.NewLine}";
                }
            }
            info += $"Es fahren:{Environment.NewLine}";
            for (int i = 0; i < Actual.Count; i++)
            {
                info += $"  {i + 1}. {Actual[i]}{Environment.NewLine}";
            }
            return info;
        }
    }
