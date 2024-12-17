window.leafletMap = {
    initialize: function (mapId, lat, lng, zoom) {
        // Initialize the Leaflet map
        var map = L.map(mapId).setView([lat, lng], zoom);

        // Add OpenStreetMap tile layer
        L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
            attribution: '© OpenStreetMap contributors'
        }).addTo(map);

        return map;
    },
    
    vehicleAt: function (map, lat, lng, popupText) {
        return L.marker([lat, lng]).addTo(map)
            .bindPopup(popupText);
    }
};
