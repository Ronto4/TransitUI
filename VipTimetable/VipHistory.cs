using Timetable;

namespace VipTimetable;

public class VipHistory : IHistory<VipHistory>
{
    public static (DateOnly, DateOnly)[] SchoolHolidays { get; } =
    [
        (new DateOnly(2023, 12, 23), new DateOnly(2024, 1, 5)),
        (new DateOnly(2024, 2, 5), new DateOnly(2024, 2, 9)),
        (new DateOnly(2024, 3, 25), new DateOnly(2024, 4, 5)),
        (new DateOnly(2024, 7, 18), new DateOnly(2024, 8, 31)),
        (new DateOnly(2024, 10, 4), new DateOnly(2024, 10, 4)),
        (new DateOnly(2024, 10, 21), new DateOnly(2024, 11, 2)),
        (new DateOnly(2024, 12, 23), new DateOnly(2024, 12, 31)),
        (new DateOnly(2025, 2, 3), new DateOnly(2025, 2, 8)),
        (new DateOnly(2025, 4, 14), new DateOnly(2025, 4, 25)),
        (new DateOnly(2025, 5, 2), new DateOnly(2025, 5, 2)),
        (new DateOnly(2025, 5, 30), new DateOnly(2025, 5, 30)),
        (new DateOnly(2025, 6, 10), new DateOnly(2025, 6, 10)),
        (new DateOnly(2025, 7, 24), new DateOnly(2025, 9, 6)),
        (new DateOnly(2025, 10, 20), new DateOnly(2025, 11, 1)),
        (new DateOnly(2025, 12, 22), new DateOnly(2026, 1, 2)),
        (new DateOnly(2026, 2, 2), new DateOnly(2026, 2, 7)),
        (new DateOnly(2026, 3, 30), new DateOnly(2026, 4, 10)),
        (new DateOnly(2026, 5, 15), new DateOnly(2026, 5, 15)),
        (new DateOnly(2026, 5, 26), new DateOnly(2026, 5, 26)),
        (new DateOnly(2026, 7, 9), new DateOnly(2026, 8, 22)),
        (new DateOnly(2026, 10, 19), new DateOnly(2026, 10, 30)),
        (new DateOnly(2026, 12, 23), new DateOnly(2027, 1, 2)),
    ];

    public static DateOnly[] PublicHolidaysSaturday { get; } =
    [
        new(2024, 12, 24),
        new(2024, 12, 31),
        new(2025, 12, 24),
        new(2025, 12, 31),
    ];

    public static DateOnly[] PublicHolidaysSunday { get; } =
    [
        new(2024, 12, 25),
        new(2024, 12, 26),
        new(2025, 1, 1),
        new(2025, 4, 18),
        new(2025, 4, 20),
        new(2025, 4, 21),
        new(2025, 5, 1),
        new(2025, 5, 29),
        new(2025, 6, 8),
        new(2025, 6, 9),
        new(2025, 10, 3),
        new(2025, 10, 31),
        new(2025, 12, 25),
        new(2025, 12, 26),
        new(2026, 1, 1),
        new(2026, 4, 3),
        new(2026, 4, 5),
        new(2026, 4, 6),
    ];

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
        new HistoryEntry(new DateOnly(2024, 2, 5),
            "Aufgrund von Bauarbeiten während der Winterferien wird die Haltestelle Schillerplatz/Schafgraben nicht bedient."),
        new HistoryEntry(new DateOnly(2024, 2, 11),
            "Die Bauarbeiten sind beendet; die Haltestelle Schillerplatz/Schafgraben wird wieder bedient."),
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
        new HistoryEntry(new DateOnly(2024, 8, 11),
            "Mit dem Ende der Schlössernacht werden auch die Verstärkerleistungen wieder eingestellt."),
        new HistoryEntry(new DateOnly(2024, 8, 16), """
                                                    Erneut wird die Friedrich-Ebert-Straße voll gesperrt; es wird die befahrene Gleisseite gewechselt.
                                                    Die Tramlinien 92 und 96 verkehren wieder nur zwischen Marie-Juchacz-Str. und Platz der Einheit.
                                                    Die Tram 99 wird freitags ganztägig bis S Hauptbahnhof verlängert.
                                                    """),
        new HistoryEntry(new DateOnly(2024, 8, 19),
            "Nach Beendigung der Sperrung gilt wieder der reguläre Baufahrplan."),
        new HistoryEntry(new DateOnly(2024, 8, 26), """
                                                    Aufgrund von Gleisbauarbeiten in Höhe Alt Nowawes wird die Tram 94 nach Glienicker Brücke umgeleitet;
                                                    ein Ersatzverkehr verkehrt alle 20 Minuten ab Plantagenstr. als Ringlinie über Rathaus Babelsberg,
                                                    S Hauptbahnhof/Nord ILB und Platz der Einheit/Bildungsforum.
                                                    Die Tram 99 entfällt ersatzlos.
                                                    Die Tram 93 verkehrt zwischen S Hauptbahnhof und Glienicker Brücke freitags und samstags bis 1 Uhr im Spätverkehr.
                                                    """),
        new HistoryEntry(new DateOnly(2024, 9, 1),
            "Die Bauarbeiten in Alt Nowawes sind beendet, die Fahrten nach Babelsberg folgen wieder dem regulären Fahrplan."),
        new HistoryEntry(new DateOnly(2024, 9, 9), """
                                                   Aufgrund von Gleisbauarbeiten in der Ankunftshaltestelle des Wendedreiecks Glienicker Brücke
                                                   verkehrt die Tram 93 nur zwischen Platz der Einheit und Bf Rehbrücke.
                                                   Der Ersatzverkehr verkehrt auch morgens am Wochenende nur bis Platz der Einheit;
                                                   der Abschnitt nach S Hauptbahnhof entfällt ersatzlos zu diesen Zeiten.
                                                   """),
        new HistoryEntry(new DateOnly(2024, 9, 21), """
                                                    Die Bauarbeiten in der Berliner Straße sind beendet, die Tram 93 fährt wieder nach dem regulären Fahrplan.
                                                    <br>
                                                    Außerdem ist an diesem Wochenende die Friedrich-Ebert-Straße wieder voll gesperrt.
                                                    Es wird das Konzept der Juni-Sperrung vergleichbares gefahren, auch wenn die Änderungen an der Tram 99 diesmal nicht kommuniziert wurden.
                                                    Außerdem wird die Ersatzlinie der 92 am Sonntag mit einer Schleife von Campus Fachhochschule zusätzlich die Haltestelle Volkspark
                                                    bedienen, da dort an diesem Wochenende das Stadtwerke-Fest stattfindet.
                                                    """),
        new HistoryEntry(new DateOnly(2024, 9, 23), """
                                                    Die Vollsperrung der Friedrich-Ebert-Straße ist wieder beendet, die Tramlinien 92 und 96 fahren wieder nach einem Baufahrplan.
                                                    Dieser wurde aber angepasst. So wird nun in beide Richtungen eine Minute weniger zwischen Puschkinallee und Rathaus eingeplant.
                                                    """),
        new HistoryEntry(new DateOnly(2024, 10, 12), """
                                                     Erneut ist die Friedrich-Ebert-Straße für ein Wochenende gesperrt.
                                                     """),
        new HistoryEntry(new DateOnly(2024, 10, 14), """
                                                     Die Sperrung ist wieder beendet.
                                                     """),
        new HistoryEntry(new DateOnly(2024, 10, 21), """
                                                     Aufgrund von Bauarbeiten wird während der Herbstferien die Haltestelle Luisenplatz-Süd/Park Sanssouci in beide Richtungen nicht bedient.
                                                     """),
        new HistoryEntry(new DateOnly(2024, 10, 26), """
                                                     Die Friedrich-Ebert-Straße ist ein letztes Mal gesperrt, dieses Mal für über eine Woche.
                                                     Abends in der Woche entfällt dabei die 92 zwischen Platz der Einheit und S Hauptbahnhof ersatzlos.
                                                     Ebenso verkehrt der Ersatzverkehr der 92 in der Woche nur alle 20 Minuten.
                                                     <br>
                                                     <b>Die Fahrpläne fehlen aktuell noch.</b>
                                                     """),
        new HistoryEntry(new DateOnly(2024, 11, 3), """
                                                    Die Haltestelle Luisenplatz-Süd/Park Sanssouci wird wieder bedient.
                                                    """),
        new HistoryEntry(new DateOnly(2024, 11, 4), """
                                                    Die Sperrung und Eingleisigkeit der Friedrich-Ebert-Straße sind beendet.
                                                    Die Fahrpläne von vor der Sperrung treten wieder in Kraft.
                                                    Die Haltestelle Reiterweg/Alleestr. wird weiterhin in beide Richtungen nicht bedient.
                                                    """),
        new HistoryEntry(new DateOnly(2024, 12, 14), """
                                                     Es werden nun auch Buslinien der ViP in dieser Historie gepflegt.
                                                     Dabei werden zunächst nur langfristige Fahrplanänderungen berücksichtigt.
                                                     Dabei sind aktuelle baubedingte Änderungen direkt eingearbeitet.
                                                     """),
        new HistoryEntry(new DateOnly(2024, 12, 15), """
                                                     Zum Fahrplanwechsel kommt es hauptsächlich zu Verschlechterungen im Ferienverkehr.
                                                     Die Linen 92 und 605 verkehren nur noch alle 20 Minuten, die Linie 99 entfällt tagsüber ersatzlos.
                                                     Außerdem werden neue Haltestellen in Fahrland in Betrieb genommen, die die Linie 609 auf dem Expressweg nach Bhf Marquardt bedient.
                                                     Zudem ist die Baustelle in der Friedrich-Ebert-Str. beendet und alle Linien kehren auf ihren ursprünglichen Weg zurück.
                                                     Abschließend kommt es zu einigen Verschiebungen im Minutenbereich.
                                                     """),
        new HistoryEntry(new DateOnly(2024, 12, 23),
            "Wie üblich verkehrt während der Akademischen Weihnachtsferien die Linie X5 nicht."),
        new HistoryEntry(new DateOnly(2024, 12, 31),
            """
            Zum Jahreswechsel gab es wieder einen Sonderfahrplan.
            Erstmals gab es dabei keinen durchgehenden Nachtverkehr; zwischen 23:30 Uhr und 0:30 Uhr wurde eine Betriebspause eingelegt.
            Aus technischen Gründen stehen die Fahrpläne zur Zeit nicht zur Verfügung.
            """),
        new HistoryEntry(new DateOnly(2025, 1, 1),
            "Der durchgehende Nachtverkehr gilt nicht mehr."),
        new HistoryEntry(new DateOnly(2025, 1, 6),
            "Zum Start in die Vorlesungszeit verkehrt auch die Linie X5 wieder."),
        new HistoryEntry(new DateOnly(2025, 1, 10),
            """
            Es gibt Fahrleitungsarbeiten am Hauptbahnhof.
            Für drei Tage wird Abends der Tramverkehr zwischen Platz der Einheit und Waldstr./Horstweg unterbrochen, es gibt einen Ersatzverkehr mit Bussen. 
            """),
        new HistoryEntry(new DateOnly(2025, 1, 13),
            "Die Bauarbeiten sind beendet."),
        new HistoryEntry(new DateOnly(2025, 1, 20),
            """
            Es gibt Fahrleitungsarbeiten im Bereich Abzweig Betriebshof ViP.
            Daher wird montags bis freitags die Linie 96 ab ca. 20 Uhr zwischen Bisamkiez und Marie-Juchacz-Str. durch Busse ersetzt.
            """
        ),
        new HistoryEntry(new DateOnly(2025, 1, 25),
            "Ursprünglich auch noch in der Folgewoche geplant sind die Bauarbeiten in Abzweig Betriebshof bereits nach einer Woche beendet."),
        new HistoryEntry(new DateOnly(2025, 2, 3),
            """
            Zu Beginn der Winterferien wird ein Fahrplanwechsel durchgeführt.
            Als Verbesserung wird der 10-Minuten-Takt der 92 an Schultagen zwischen Bisamkiez und Gaußstr. ausgeweitet.
            Auf der anderen Seite wird in den Ferien der 20-Minuten-Takt auf der Linie 616 ersatzlos gestrichen.
            Auch wird der 10-Minuten-Takt der 605 nur noch in der Hauptverkehrszeit angeboten
            und die Linie 639 in den Ferien ersatzlos gestrichen.
            Außerdem kommt es zu kleineren Fahrplananpassungen.
            """
        ),
        new HistoryEntry(new DateOnly(2025, 2, 10), "Während der vorlesungsfreien Zeit verkehrt die Linie X5 nicht."),
        new HistoryEntry(new DateOnly(2025, 3, 8),
            "Aufgrund des Feiertages in Berlin gibt es eine zusätzliche Fahrt der Linie N16."),
        new HistoryEntry(new DateOnly(2025, 3, 9), "Der reguläre Fahrplan auf der Linie N16 gilt wieder."),
        new HistoryEntry(new DateOnly(2025, 4, 7), "Nach Ende der vorlesungsfreien Zeit verkehrt die Linie X5 wieder."),
        new HistoryEntry(new DateOnly(2025, 4, 18),
            """
            Mit Beginn der Tourismussaison verkehrt die Linie X15 wieder.
            Darüberhinaus kommt es zu Änderungen der Betriebszeiten der F1; diese werden an Wochenenden um eine Stunde nach hinten verschoben.
            """
        ),
        new HistoryEntry(new DateOnly(2025, 5, 2), ValidityMode.OnlyOnThisDay,
            "Am Brückentag nach dem Ersten Mai verkehrt die Linie X15 anstelle der Linie X5."),
        new HistoryEntry(new DateOnly(2025, 5, 8), ValidityMode.OnlyOnThisDay,
            "Wegen des Feiertags in Berlin gibt es Zusatzfahrten auf der Linie N16."),
        new HistoryEntry(new DateOnly(2025, 5, 30), ValidityMode.OnlyOnThisDay,
            "Am Brückentag nach Christi Himmelfahrt verkehrt die Linie X15 anstelle der Linie X5."),
        new HistoryEntry(new DateOnly(2025, 6, 14), ValidityMode.OnlyOnThisDay,
            """
            Aufgrund des Tages der offenen Tür in Krampnitz wird
            die Linie 609 tagsüber durch das Kasernengelände geleitet
            und Richtung Campus Jungfernsee durch die Linie 609E auf einen 20-Minuten-Takt verdichtet.
            Der Fahrplan der Linie 609 von diesem Tag liegt leider aktuell nicht vor.
            """
        ),
        new HistoryEntry(new DateOnly(2025, 7, 21), "Während der vorlesungsfreien Zeit verkehrt die Linie X5 nicht."),
        new HistoryEntry(new DateOnly(2025, 10, 13),
            "Nach Ende der vorlesungsfreien Zeit verkehrt die Linie X5 wieder."),
        new HistoryEntry(new DateOnly(2026, 2, 9), "Während der vorlesungsfreien Zeit verkehrt die Linie X5 nicht."),
        new HistoryEntry(new DateOnly(2026, 4, 13),
            "Nach Ende der vorlesungsfreien Zeit verkehrt die Linie X5 wieder."),
    ];
}
