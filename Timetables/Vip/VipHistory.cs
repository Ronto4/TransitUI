using Timetables.Models;

namespace Timetables.Vip;

public class VipHistory : IHistory
{
    public static IHistoryEntry[] History { get; } =
    [
        new HistoryEntry(new DateOnly(2024, 1, 2), """
                                                   Bei diesem Stand der Linien zum 02.01.2024 ist zu beachten,
                                                   dass bereits seit Juni 2022 ein Notfahrplan wegen Fahrermangel in Kraft ist.
                                                   Dieser hatte in den vergangenen Monaten verschieden starke Auswirkungen,
                                                   zur Zeit sind dies die Änderungen bei den hier vorgestellten Linien:
                                                   <ul class="list-group">
                                                    <li class="list-group-item">
                                                        Tram 92: Normalerweise verkehrt die 92 an Schultagen in der HVZ alle 20 Minuten zwischen Kirschallee und Marie-Juchacz-Str.,
                                                        zwischen Kirschallee und Bisamkiez auf einen 10-Minuten-Takt verdichtet.
                                                        Ein Großteil der Fahrten nach Marie-Juchacz-Str. verkehrt zur Zeit nur bis Gaußstr.
                                                        Dafür ist der 10-Minuten-Takt morgens bis Gaußstr. verlängert.
                                                    </li>
                                                    <li class="list-group-item">
                                                        Tram 98: Diese Linie entfällt aktuell komplett.
                                                        Normalerweise verkehrt sie an Schultagen in der HVZ alle 20 Minuten zwischen Bhf Rehbrücke und Schloss Charlottenhof.
                                                        Dabei fährt sie für gewöhnlich in beiden Richtungen jeweils 5 Minuten hinter der 91.
                                                    </li>
                                                    <li class="list-group-item">
                                                        Tram 99: In der Woche tagsüber verkehrt die Linie außerplanmäßig nicht zwischen Platz der Einheit und S Hauptbahnhof.
                                                    </li>
                                                   </ul>
                                                   Übersicht über die aktuellen Linien:
                                                   """),
        new HistoryEntry(new DateOnly(2024, 2, 5), "Aufgrund von Bauarbeiten während der Winterferien wird die Haltestelle Schillerplatz/Schafgraben nicht bedient."),
        new HistoryEntry(new DateOnly(2024, 2, 11), "Die Bauarbeiten sind beendet; die Haltestelle Schillerplatz/Schafgraben wird wieder bedient."),
        new HistoryEntry(new DateOnly(2024, 2, 26), """
                                                    Nach mehr als eineinhalb Jahren kehrt die 98 zurück ins Stadtbild (außerhalb der Schlössernacht).
                                                    Drei Fahrten im 50-Minuten-Takt morgens an Schultagen zwischen Platz der Einheit und Bhf Rehbrücke unterstützen den Berufsverkehr.
                                                    Die erste nach Platz der Einheit und die letzte ab Platz der Einheit verkehren dabei ab/bis Bisamkiez.
                                                    """),
        new HistoryEntry(new DateOnly(2024, 4, 22), """
                                                    Nach einer geplanten Eröffnung im Frühjahr 2021 wird am 22. April 2024 die neue Haltestelle
                                                    Wiesenpark (ursprünglicher Planungsname: Horst-Bienek-Str.) zwischen Campus Fachhochschule und
                                                    Hannes-Meyer-Str. in Betrieb genommen. Ohne Feierlichkeiten wurde die Haltestelle mit
                                                    Betriebsbeginn planmäßig bedient. Die Haltestelle wurde nach Informationen der ViP
                                                    bereits zum Fahrplanwechsel im Dezember 2023 in den Fahrplan aufgenommen, sodass es
                                                    an den anderen Haltestellen zu keinen Verschiebungen der Abfahrtszeiten kam.
                                                    """),
        new HistoryEntry(new DateOnly(2024, 6, 6), """
                                                   Aufgrund der Bauarbeiten in der nördlichen Friedrich-Ebert-Straße können die Straßenbahnen
                                                   die Haltestelle Reiterweg/Alleestraße in Richtung Süden (Platz der Einheit) bis auf Weiteres nicht mehr bedienen.
                                                   """),
        new HistoryEntry(new DateOnly(2024, 6, 8), """
                                                   Aufgrund der Bauerbeiten in der nördlichen Friedrich-Ebert-Straße müssen am Wochenende des 8. und 9. Juni 2024
                                                   die Straßenbahnlinien zwischen Platz der Einheit und Kirschallee bzw. Campus Jungfernsee unterbrochen werden.
                                                   Es werden zwei Bauweichen für den ab 10. Juni 2024 eingleisig geführten Tramverkehr im Bereich der Haltestelle Reiterweg/Alleestraße eingebaut.
                                                   Ersatzweise fahren Busse, auf der 96 auch die zum Platz der Einheit verlängerten Linien 609 und 638.
                                                   Außerdem kommt es zu kleinen Fahrplanverschiebungen auf der Linie 99.
                                                   """),
        new HistoryEntry(new DateOnly(2024, 6, 10), """
                                                    Aufgrund der Bauarbeiten in der nördlichen Friedrich-Ebert-Straße wird der Tramverkehr im Bereich der Haltestelle
                                                    Reiterweg/Alleestraße eingleisig auf dem stadtauswärtigem Gleis geführt. Dadurch kann die Haltestelle
                                                    Reiterweg/Alleestraße in beiden Richtungen nicht mehr bedient werden. Außerdem kommt es zu Fahrtzeitverlängerungen
                                                    auf den Linien 92 und 96 in beiden Richtungen sowie kleinen Anpassungen auf den Linien 91 und 94.
                                                    Die baustellenbedingten Änderungen auf der Linie 99 vom Wochenende werden wieder rückgängig gemacht.
                                                    """),
        new HistoryEntry(new DateOnly(2024, 8, 9), """
                                                   Anlässlich der Schlössernacht wird von ca. 16 Uhr bis 20 Uhr und von ca. 21 Uhr bis 0:30 Uhr wieder die Tram 98 zwischen S Hauptbahnhof
                                                   und Schloss Charlottenhof verkehren. Ebenso verkehrt der Bus X15 bis in die Nacht vom Hauptbahnhof zur Kirschallee.
                                                   """),
        new HistoryEntry(new DateOnly(2024, 8, 11), "Mit dem Ende der Schlössernacht werden auch die Verstärkerleistungen wieder eingestellt."),
        new HistoryEntry(new DateOnly(2024, 8, 16), """
                                                    Erneut wird die Friedrich-Ebert-Straße voll gesperrt; es wird die befahrene Gleisseite gewechselt.
                                                    Die Tramlinien 92 und 96 verkehren wieder nur zwischen Marie-Juchacz-Str. und Platz der Einheit.
                                                    Die Tram 99 wird freitags ganztägig bis S Hauptbahnhof verlängert.
                                                    """),
    ];
}
