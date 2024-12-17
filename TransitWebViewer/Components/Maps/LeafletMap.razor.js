export class LeafletMap {
    initialize(mapId, lat, lng, zoom) {
        // Initialize the Leaflet map
        const map = L.map(mapId).setView([lat, lng], zoom);

        // Add OpenStreetMap tile layer
        L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
            attribution: '© OpenStreetMap contributors'
        }).addTo(map);

        return map;
    }
}

window.LeafletMap = LeafletMap;
