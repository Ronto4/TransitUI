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
                                                    Drei Fahrten im 50-Minuten-Takt morgens zwischen Platz der Einheit und Bhf Rehbrücke unterstützen den Berufsverkehr.
                                                    Die erste nach Platz der Einheit und die letzte ab Platz der Einheit verkehren dabei ab/bis Bisamkiez.
                                                    """)
    ];
}
