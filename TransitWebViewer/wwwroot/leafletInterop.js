const vehicles = {};
const routes = {};
const removeAllRoutes = () => {
    for (const [tripId, polyline] of Object.entries(routes)) {
        polyline.remove();
        delete routes[tripId];
    }
};
window.leafletMap = {
    initialize: function (mapId, lat, lng, zoom) {
        // Initialize the Leaflet map
        var map = L.map(mapId).setView([lat, lng], zoom);

        // Add OpenStreetMap tile layer
        L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
            attribution: '© OpenStreetMap contributors',
            referrerPolicy: 'strict-origin-when-cross-origin',
        }).addTo(map);

        return map;
    },

    vehicleAt: function (dotNetObject, map, vehicleId, lat, lng, popupText, colour, tripId) {
        if (vehicles[vehicleId]) {
            const [marker, oldTripId] = vehicles[vehicleId];
            marker.setLatLng([lat, lng]);
            marker.color = colour;
            marker.setTooltipContent(popupText);
            if (marker.isPopupOpen() && marker.getPopup().content !== popupText) {
                console.log(`Resetting popup old '${marker.getPopup().content}' new '${popupText}'.`);
                marker.closePopup();
                marker.openPopup();
            }
            if (oldTripId !== tripId) {
                console.log(`Resetting trip ${tripId} (was ${oldTripId}) (${popupText}).`);
                if (routes[oldTripId]) {
                    console.log("Redrawing!");
                    removeAllRoutes();
                    dotNetObject.invokeMethodAsync('OnOpenTripMarker', tripId);
                }
                vehicles[vehicleId] = [marker, tripId];
            }
            return;
        }
        const marker = L.circleMarker([lat, lng], { color: colour });
        vehicles[vehicleId] = [marker, tripId];
        return marker
            .addTo(map)
            .on('popupopen', _event => {
                if (routes[tripId]) {
                    return;
                }
                removeAllRoutes();
                dotNetObject.invokeMethodAsync('OnOpenTripMarker', tripId);
            })
            // .on('popupclose', _event => {
            //     if (routes[tripId]) {
            //         routes[tripId].remove();
            //         delete routes[tripId];
            //     } else {
            //         console.warn(`Could not remove path of trip ${tripId}.`);
            //     }
            // })
            .bindPopup(popupText);
        // return L.marker([lat, lng]).addTo(map)
           //  .bindPopup(popupText);
    },

    keepOnlyVehicles: function (vehicleIds, a) {
        for (const [vehicleId, [marker, tripId]] of Object.entries(vehicles)) {
          if (vehicleIds.includes(vehicleId)) {
              continue;
          }
          marker.remove();
          if (routes[tripId]) {
              routes[tripId].remove();
              delete routes[tripId];
          }
          delete vehicles[vehicleId];
        }
    },

    drawRoute: function (map, points, colour, focus, tripId) {
        const leafletPoints = points.map(point => new L.LatLng(point.latitude, point.longitude));
        const polyline = new L.polyline(leafletPoints, {
            color: colour,
            weight: 3,
            opacity: 1,
            smoothFactor: 1,
        });
        if (tripId) {
            if (routes[tripId]) {
                routes[tripId].remove();
            }
            routes[tripId] = polyline;
        } else {
            console.warn(`Could not store polyline for colour ${colour}.`);
        }
        if (focus) {
            map.fitBounds(polyline.getBounds());
        }
        polyline.addTo(map);
        return polyline.bringToBack();
    }
};
