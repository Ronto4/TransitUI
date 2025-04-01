using Timetable;

namespace VipTimetable;

internal static class Stops
{
    private static City Potsdam => Cities.Potsdam;
    private static City Berlin => Cities.Berlin;
    private static City Leest => Cities.Leest;
    private static City Töplitz => Cities.Töplitz;
    private static City NeuTöplitz => Cities.NeuTöplitz;
    private static City BergholzRehbrücke => Cities.BergholzRehbrücke;

    public static Stop AbzweigBetriebshofViP { get; } = new()
        { City = Potsdam, InitialName = "Abzweig Betriebshof ViP", Positions = ["Norden", "Süden"] };

    public static Stop AbzweigNachEiche { get; } = new()
    {
        City = Potsdam,
        InitialName = "Abzweig nach Eiche",
        Positions = ["Amundsenstr.", "Maulbeerallee", "Kaiser-Friedrich-Str.", "Am Neuen Palais"]
    };

    public static Stop AbzweigNachNedlitz { get; } = new()
    {
        City = Potsdam,
        InitialName = "Abzweig nach Nedlitz",
        Positions = ["Rückertstr.", "Max-Eyth-Allee", "Lerchensteig"]
    };

    public static Stop AltNowawes { get; } = new()
    {
        City = Potsdam, InitialName = "Alt Nowawes",
        Positions = ["Tram Norden", "Tram Süden", "Bus Norden", "Bus Süden"]
    };

    public static Stop AltGolm { get; } =
        new() { City = Potsdam, InitialName = "Alt-Golm", Positions = ["Wendeschleife"] };

    public static Stop BerlinAltKladow { get; } = new()
        { InitialName = "Alt-Kladow", City = Berlin, Positions = ["Ri. Sacrow", "Ri. Berlin"] };

    public static Stop AlterMarktLandtag { get; } = new()
    {
        City = Potsdam, InitialName = "Alter Markt/Landtag",
        Positions = ["Ri. S\u00a0Hauptbahnhof", "Ri. Platz der Einheit"]
    };

    public static Stop AlterTornow { get; } = new()
    {
        City = Potsdam, InitialName = "Alter Tornow",
        Positions = ["Ri. S\u00a0Hauptbahnhof", "Ri. Hermannswerder", "Ri. Caputh"]
    };

    public static Stop AmAltenMörtelwerk { get; } = new() { City = Potsdam, InitialName = "Am Alten Mörtelwerk" };
    public static Stop AmAnger { get; } = new() { City = Potsdam, InitialName = "Am Anger" };
    public static Stop AmFenn { get; } = new() { City = Potsdam, InitialName = "Am Fenn" };

    public static Stop RoteKaserneNedlitzerStr { get; } =
        new() { City = Potsdam, InitialName = "Rote Kaserne/Nedlitzer Str." };

    public static Stop AmGrünenWeg { get; } = new() { City = Potsdam, InitialName = "Am Grünen Weg" };
    public static Stop AmHämphorn { get; } = new() { City = Potsdam, InitialName = "Am Hämphorn" };
    public static Stop AmHavelblick { get; } = new() { City = Potsdam, InitialName = "Am Havelblick" };
    public static Stop AmHirtengraben { get; } = new() { City = Potsdam, InitialName = "Am Hirtengraben" };
    public static Stop AmKüssel { get; } = new() { City = Potsdam, InitialName = "Am Küssel" };
    public static Stop AmMoosfenn { get; } = new() { City = Potsdam, InitialName = "Am Moosfenn" };

    public static Stop AmNeuenGartenGroßeWeinmeisterstr { get; } =
        new() { City = Potsdam, InitialName = "Am Neuen Garten/Große Weinmeisterstr." };

    public static Stop BerlinAmOmnibusbahnhof { get; } = new() { InitialName = "Am Omnibusbahnhof", City = Berlin };
    public static Stop AmPark { get; } = new() { City = Potsdam, InitialName = "Am Park" };
    public static Stop AmPfingstberg { get; } = new() { City = Potsdam, InitialName = "Am Pfingstberg" };
    public static Stop AmSchlahn { get; } = new() { City = Potsdam, InitialName = "Am Schlahn" };
    public static Stop AmSchragen { get; } = new() { City = Potsdam, InitialName = "Am Schragen" };
    public static Stop AmSchragenRussischeKolonie { get; } = new() { City = Potsdam, InitialName = "Am Schragen/Russische Kolonie" };
    public static Stop AmUpstall { get; } = new() { City = Potsdam, InitialName = "Am Upstall" };
    public static Stop AmUrnenfeld { get; } = new() { City = Potsdam, InitialName = "Am Urnenfeld" };
    public static Stop AmWald { get; } = new() { City = Potsdam, InitialName = "Am Wald" };

    public static Stop AmundsenstrNedlitzerStr { get; } =
        new() { City = Potsdam, InitialName = "Amundsenstr./Nedlitzer Str." };

    public static Stop AmundsenstrPotsdamerStr { get; } =
        new() { City = Potsdam, InitialName = "Amundsenstr./Potsdamer Str." };

    public static Stop AnDerWindmühle { get; } = new() { City = Potsdam, InitialName = "An der Windmühle" };
    public static Stop Anhaltstr { get; } = new() { City = Potsdam, InitialName = "Anhaltstr." };
    public static Stop AufDemKiewitt { get; } = new() { City = Potsdam, InitialName = "Auf dem Kiewitt" };
    public static Stop BerlinAußenweg { get; } = new() { InitialName = "Außenweg", City = Berlin };
    public static Stop BahnhofCharlottenhof { get; } = new() { City = Potsdam, InitialName = "Bahnhof Charlottenhof" };

    public static Stop BahnhofCharlottenhofGeschwisterSchollStr { get; } =
        new() { City = Potsdam, InitialName = "Bahnhof Charlottenhof/Geschwister-Scholl-Str." };

    public static Stop BahnhofGolm { get; } = new() { City = Potsdam, InitialName = "Bahnhof Golm" };

    public static Stop ScienceParkUniversität { get; } =
        new() { City = Potsdam, InitialName = "Science Park/Universität" };

    public static Stop BahnhofMarquardt { get; } = new() { City = Potsdam, InitialName = "Bahnhof Marquardt" };
    public static Stop BahnhofParkSanssouci { get; } = new() { City = Potsdam, InitialName = "Bahnhof Park Sanssouci" };
    public static Stop BahnhofPirschheide { get; } = new() { City = Potsdam, InitialName = "Bahnhof Pirschheide" };
    public static Stop BahnhofRehbrücke { get; } = new() { City = Potsdam, InitialName = "Bahnhof Rehbrücke" };
    public static Stop Bassewitz { get; } = new() { City = Potsdam, InitialName = "Bassewitz" };
    public static Stop Bassinplatz { get; } = new() { City = Potsdam, InitialName = "Bassinplatz" };
    public static Stop Baumschulenweg { get; } = new() { City = Potsdam, InitialName = "Baumschulenweg" };
    public static Stop BayrischesHaus { get; } = new() { City = Potsdam, InitialName = "Bayrisches Haus" };
    public static Stop BirkenstrAlleestr { get; } = new() { City = Potsdam, InitialName = "Birkenstr./Alleestr." };
    public static Stop Birkenweg { get; } = new() { City = Potsdam, InitialName = "Birkenweg" };
    public static Stop Bisamkiez { get; } = new() { City = Potsdam, InitialName = "Bisamkiez" };
    public static Stop BrandenburgerStr { get; } = new() { City = Potsdam, InitialName = "Brandenburger Str." };
    public static Stop Brentanoweg { get; } = new() { City = Potsdam, InitialName = "Brentanoweg" };

    public static Stop BerlinBrunsbüttlerDammRuhlebenerStr { get; } =
        new() { InitialName = "Brunsbüttler Damm/Ruhlebener Str.", City = Berlin };

    public static Stop Bullenwinkel { get; } = new() { City = Potsdam, InitialName = "Bullenwinkel" };
    public static Stop BurgstrKlinikum { get; } = new() { City = Potsdam, InitialName = "Burgstr./Klinikum" };
    public static Stop CampusFachhochschule { get; } = new() { City = Potsdam, InitialName = "Campus Fachhochschule" };
    public static Stop CampusJungfernsee { get; } = new() { City = Potsdam, InitialName = "Campus Jungfernsee" };

    public static Stop CampusJungfernseeNedlitzerStr { get; } =
        new() { City = Potsdam, InitialName = "Campus Jungfernsee/Nedlitzer Str." };

    public static Stop CampusUniversitätAbrahamGeigerKolleg { get; } =
        new() { City = Potsdam, InitialName = "Campus Universität/Abraham-Geiger-Kolleg" };

    public static Stop DeutscherWetterdienst { get; } =
        new() { City = Potsdam, InitialName = "Deutscher Wetterdienst" };

    public static Stop TöplitzDorfplatz { get; } = new() { InitialName = "Dorfplatz", City = Töplitz };
    public static Stop Dortustr { get; } = new() { City = Potsdam, InitialName = "Dortustr." };
    public static Stop Drachenhaus { get; } = new() { City = Potsdam, InitialName = "Drachenhaus" };

    public static Stop DrewitzerStrErichWeinertStr { get; } =
        new() { City = Potsdam, InitialName = "Drewitzer Str./Erich-Weinert-Str." };

    public static Stop Ecksteinweg { get; } = new() { City = Potsdam, InitialName = "Ecksteinweg" };

    public static Stop EduardClaudiusStrDrewitzerStr { get; } =
        new() { City = Potsdam, InitialName = "Eduard-Claudius-Str./Drewitzer-Str." };

    public static Stop EduardClaudiusStrHeinrichMannAllee { get; } =
        new() { City = Potsdam, InitialName = "Eduard-Claudius-Str./Heinrich-Mann-Allee" };

    public static Stop Ehrenpfortenbergstr { get; } = new() { City = Potsdam, InitialName = "Ehrenpfortenbergstr." };
    public static Stop Eichenring { get; } = new() { City = Potsdam, InitialName = "Eichenring" };
    public static Stop LeestEichholzweg { get; } = new() { InitialName = "Eichholzweg", City = Leest };
    public static Stop Eisbergstücke { get; } = new() { City = Potsdam, InitialName = "Eisbergstücke" };

    public static Stop EisenbahnbrückeMarquardt { get; } =
        new() { City = Potsdam, InitialName = "Eisenbahnbrücke Marquardt" };

    public static Stop FahrländerSee { get; } = new() { City = Potsdam, InitialName = "Fahrländer See" };
    public static Stop Fährweg { get; } = new() { City = Potsdam, InitialName = "Fährweg" };
    public static Stop Falkenhorst { get; } = new() { City = Potsdam, InitialName = "Falkenhorst" };
    public static Stop Feuerbachstr { get; } = new() { City = Potsdam, InitialName = "Feuerbachstr." };
    public static Stop TöplitzFeuerwehr { get; } = new() { InitialName = "Feuerwehr", City = Töplitz };
    public static Stop Finkenweg { get; } = new() { City = Potsdam, InitialName = "Finkenweg" };
    public static Stop BerlinFinnenhausSiedlung { get; } = new() { InitialName = "Finnenhaus-Siedlung", City = Berlin };
    public static Stop Florastr { get; } = new() { City = Potsdam, InitialName = "Florastr." };
    public static Stop Fontanestr { get; } = new() { City = Potsdam, InitialName = "Fontanestr." };
    public static Stop ForsthausTemplin { get; } = new() { City = Potsdam, InitialName = "Forsthaus Templin" };
    public static Stop Friedenskirche { get; } = new() { City = Potsdam, InitialName = "Friedenskirche" };
    public static Stop Friedhöfe { get; } = new() { City = Potsdam, InitialName = "Friedhöfe" };
    public static Stop FriedrichGüntherPark { get; } = new() { City = Potsdam, InitialName = "Friedrich-Günther-Park" };
    public static Stop FriedrichWolfStr { get; } = new() { City = Potsdam, InitialName = "Friedrich-Wolf-Str." };
    public static Stop Gaußstr { get; } = new() { City = Potsdam, InitialName = "Gaußstr." };
    public static Stop Geiselberg { get; } = new() { City = Potsdam, InitialName = "Geiselberg" };
    public static Stop GlienickerBrücke { get; } = new() { City = Potsdam, InitialName = "Glienicker Brücke" };
    public static Stop Glumestr { get; } = new() { City = Potsdam, InitialName = "Glumestr." };
    public static Stop GolmerFichten { get; } = new() { City = Potsdam, InitialName = "Golmer Fichten" };
    public static Stop BerlinGößweinsteinerGang { get; } = new() { InitialName = "Gößweinsteiner Gang", City = Berlin };
    public static Stop HannesMeyerStr { get; } = new() { City = Potsdam, InitialName = "Hannes-Meyer-Str." };
    public static Stop HansAlbersStr { get; } = new() { City = Potsdam, InitialName = "Hans-Albers-Str." };
    public static Stop Hebbelstr { get; } = new() { City = Potsdam, InitialName = "Hebbelstr." };
    public static Stop Hechtsprung { get; } = new() { City = Potsdam, InitialName = "Hechtsprung" };
    public static Stop BerlinHeerstrWilhelmstr { get; } = new() { InitialName = "Heerstr./Wilhelmstr.", City = Berlin };
    public static Stop Heineberg { get; } = new() { City = Potsdam, InitialName = "Heineberg" };
    public static Stop HeinrichHeineWeg { get; } = new() { City = Potsdam, InitialName = "Heinrich-Heine-Weg" };
    public static Stop Hermannswerder { get; } = new() { City = Potsdam, InitialName = "Hermannswerder" };
    public static Stop HoffbauerStiftung { get; } = new() { City = Potsdam, InitialName = "Hoffbauer-Stiftung" };
    public static Stop Höhenstr { get; } = new() { City = Potsdam, InitialName = "Höhenstr." };

    public static Stop HorstwegGroßbeerenstr { get; } =
        new() { City = Potsdam, InitialName = "Horstweg/Großbeerenstr." };

    public static Stop Holzmarktstr { get; } = new() { City = Potsdam, InitialName = "Holzmarktstr." };
    public static Stop Hugstr { get; } = new() { City = Potsdam, InitialName = "Hugstr." };
    public static Stop LeestKirche { get; } = new() { InitialName = "Kirche", City = Leest };
    public static Stop KircheBornim { get; } = new() { City = Potsdam, InitialName = "Kirche Bornim" };

    public static Stop HumboldtringLottePulewkaStr { get; } =
        new() { City = Potsdam, InitialName = "Humboldtring/Lotte-Pulewka-Str." };

    public static Stop HumboldtringNuthestr { get; } = new() { City = Potsdam, InitialName = "Humboldtring/Nuthestr." };
    public static Stop ImBogenForststr { get; } = new() { City = Potsdam, InitialName = "Im Bogen/Forststr." };
    public static Stop ImBogenZeppelinstr { get; } = new() { City = Potsdam, InitialName = "Im Bogen/Zeppelinstr." };
    public static Stop ImWinkel { get; } = new() { City = Potsdam, InitialName = "Im Winkel" };

    public static Stop InstitutFürAgrartechnik { get; } =
        new() { City = Potsdam, InitialName = "Institut für Agrartechnik" };

    public static Stop JägertorJustizzentrum { get; } =
        new() { City = Potsdam, InitialName = "Jägertor/Justizzentrum" };

    public static Stop JohanBoumanPlatz { get; } = new() { City = Potsdam, InitialName = "Johan-Bouman-Platz" };
    public static Stop JohannesKeplerPlatz { get; } = new() { City = Potsdam, InitialName = "Johannes-Kepler-Platz" };

    public static Stop KaiserFriedrichStrPolizei { get; } =
        new() { City = Potsdam, InitialName = "Kaiser-Friedrich-Str./Polizei" };

    public static Stop Kaiserplatz { get; } = new() { City = Potsdam, InitialName = "Kaiserplatz" };

    public static Stop KarlLiebknechtStadion { get; } =
        new() { City = Potsdam, InitialName = "Karl-Liebknecht-Stadion" };

    public static Stop BerlinKarolinenhöhe { get; } = new() { InitialName = "Karolinenhöhe", City = Berlin };
    public static Stop BerlinKaserneHottengrund { get; } = new() { InitialName = "Kaserne Hottengrund", City = Berlin };

    public static Stop KastanienalleeZeppelinstr { get; } =
        new() { City = Potsdam, InitialName = "Kastanienallee/Zeppelinstr." };

    public static Stop KetzinerStrKönigsweg { get; } =
        new() { City = Potsdam, InitialName = "Ketziner Str./Königsweg" };

    public static Stop Kienheide { get; } = new() { City = Potsdam, InitialName = "Kienheide" };
    public static Stop Kienhorststr { get; } = new() { City = Potsdam, InitialName = "Kienhorststr." };
    public static Stop Kieskutenberg { get; } = new() { City = Potsdam, InitialName = "Kieskutenberg" };
    public static Stop KircheGolm { get; } = new() { City = Potsdam, InitialName = "Kirche Golm" };
    public static Stop KircheGroßGlienicke { get; } = new() { City = Potsdam, InitialName = "Kirche Groß Glienicke" };
    public static Stop KircheKartzow { get; } = new() { City = Potsdam, InitialName = "Kirche Kartzow" };
    public static Stop KircheUetz { get; } = new() { City = Potsdam, InitialName = "Kirche Uetz" };
    public static Stop Kirschallee { get; } = new() { City = Potsdam, InitialName = "Kirschallee" };
    public static Stop TöplitzKirschweg { get; } = new() { InitialName = "Kirschweg", City = Töplitz };

    public static Stop KläranlagePotsdamNord { get; } =
        new() { City = Potsdam, InitialName = "Kläranlage Potsdam-Nord" };

    public static Stop KleineWeinmeisterstr { get; } = new() { City = Potsdam, InitialName = "Kleine Weinmeisterstr." };
    public static Stop Klinikum { get; } = new() { City = Potsdam, InitialName = "Klinikum" };
    public static Stop Krampnitzsee { get; } = new() { City = Potsdam, InitialName = "Krampnitzsee" };
    public static Stop Kuhfort { get; } = new() { City = Potsdam, InitialName = "Kuhfort" };
    public static Stop Kuhfortdamm { get; } = new() { City = Potsdam, InitialName = "Kuhfortdamm" };
    public static Stop KunersdorferStr { get; } = new() { City = Potsdam, InitialName = "Kunersdorfer Str." };
    public static Stop Küsselstr { get; } = new() { City = Potsdam, InitialName = "Küsselstr." };
    public static Stop Landesumweltamt { get; } = new() { City = Potsdam, InitialName = "Landesumweltamt" };

    public static Stop BerlinLandschaftsfriedhofGatow { get; } =
        new() { InitialName = "Landschaftsfriedhof Gatow", City = Berlin };

    public static Stop LangeBrücke { get; } = new() { City = Potsdam, InitialName = "Lange Brücke" };

    public static Stop LanghansstrGroßeWeinmeisterstr { get; } = new()
        { City = Potsdam, InitialName = "Langhansstr./Große Weinmeisterstr." };

    public static Stop TöplitzLeesterStr { get; } = new() { InitialName = "Leester Str.", City = Töplitz };

    public static Stop LerchensteigKleingartenanlage { get; } =
        new() { City = Potsdam, InitialName = "Lerchensteig/Kleingartenanlage" };

    public static Stop LindstedterChaussee { get; } = new() { City = Potsdam, InitialName = "Lindstedter Chaussee" };
    public static Stop LeonardoDaVinciStr { get; } = new() { City = Potsdam, InitialName = "Leonardo-da-Vinci-Str." };
    public static Stop Luftschiffhafen { get; } = new() { City = Potsdam, InitialName = "Luftschiffhafen" };

    public static Stop LuisenplatzNordParkSanssouci { get; } =
        new() { City = Potsdam, InitialName = "Luisenplatz-Nord/Park Sanssouci" };

    public static Stop LuisenplatzOstParkSanssouci { get; } =
        new() { City = Potsdam, InitialName = "Luisenplatz-Ost/Park Sanssouci" };

    public static Stop LuisenplatzSüdParkSanssouci { get; } =
        new() { City = Potsdam, InitialName = "Luisenplatz-Süd/Park Sanssouci" };

    public static Stop MagnusZellerPlatz { get; } = new() { City = Potsdam, InitialName = "Magnus-Zeller-Platz" };
    public static Stop Mangerstr { get; } = new() { City = Potsdam, InitialName = "Mangerstr." };
    public static Stop MarieJuchaczStr { get; } = new() { City = Potsdam, InitialName = "Marie-Juchacz-Str." };
    public static Stop Mauerstr { get; } = new() { City = Potsdam, InitialName = "Mauerstr." };
    public static Stop MaxBornStr { get; } = new() { City = Potsdam, InitialName = "Max-Born-Str." };
    public static Stop Mehlbeerenweg { get; } = new() { City = Potsdam, InitialName = "Mehlbeerenweg" };
    public static Stop BerlinMelanchtonplatz { get; } = new() { InitialName = "Melanchtonplatz", City = Berlin };
    public static Stop BerlinMetzerStr { get; } = new() { InitialName = "Metzer Str.", City = Berlin };

    public static Stop MichendorferChausseeFriedhof { get; } =
        new() { City = Potsdam, InitialName = "Michendorfer Chaussee/Friedhof" };

    public static Stop Naturkundemuseum { get; } = new() { City = Potsdam, InitialName = "Naturkundemuseum" };
    public static Stop NauenerTor { get; } = new() { City = Potsdam, InitialName = "Nauener Tor" };
    public static Stop Nesselgrund { get; } = new() { City = Potsdam, InitialName = "Nesselgrund" };
    public static Stop NeuesPalais { get; } = new() { City = Potsdam, InitialName = "Neues Palais" };
    public static Stop BerlinNeukladowerAllee { get; } = new() { InitialName = "Neukladower Allee", City = Berlin };
    public static Stop BerlinGutsparkNeukladow { get; } = new() { InitialName = "Gutspark Neukladow", City = Berlin };
    public static Stop Orangerie { get; } = new() { City = Potsdam, InitialName = "Orangerie" };
    public static Stop Paaren { get; } = new() { City = Potsdam, InitialName = "Paaren" };
    public static Stop BerlinParnemannweg { get; } = new() { InitialName = "Parnemannweg", City = Berlin };
    public static Stop Persiusstr { get; } = new() { City = Potsdam, InitialName = "Persiusstr." };
    public static Stop Plantagenstr { get; } = new() { City = Potsdam, InitialName = "Plantagenstr." };
    public static Stop Plantagenweg { get; } = new() { City = Potsdam, InitialName = "Plantagenweg" };

    public static Stop PlatzDerEinheitBildungsforum { get; } =
        new() { City = Potsdam, InitialName = "Platz der Einheit/Bildungsforum" };

    public static Stop PlatzDerEinheitNord { get; } = new() { City = Potsdam, InitialName = "Platz der Einheit/Nord" };
    public static Stop PlatzDerEinheitOst { get; } = new() { City = Potsdam, InitialName = "Platz der Einheit/Ost" };
    public static Stop PlatzDerEinheitWest { get; } = new() { City = Potsdam, InitialName = "Platz der Einheit/West" };
    public static Stop Priesterweg { get; } = new() { City = Potsdam, InitialName = "Priesterweg" };
    public static Stop Puschkinallee { get; } = new() { City = Potsdam, InitialName = "Puschkinallee" };
    public static Stop Rathaus { get; } = new() { City = Potsdam, InitialName = "Rathaus" };
    public static Stop RathausBabelsberg { get; } = new() { City = Potsdam, InitialName = "Rathaus Babelsberg" };
    public static Stop ReiterwegAlleestr { get; } = new() { City = Potsdam, InitialName = "Reiterweg/Alleestr." };
    public static Stop ReiterwegJägerallee { get; } = new() { City = Potsdam, InitialName = "Reiterweg/Jägerallee" };
    public static Stop Ribbeckstr { get; } = new() { City = Potsdam, InitialName = "Ribbeckstr." };

    public static Stop BerlinRitterfelddammPotsdamerChaussee { get; } =
        new() { InitialName = "Ritterfelddamm/Potsdamer Chaussee", City = Berlin };

    public static Stop BerlinRodensteinstr { get; } = new() { InitialName = "Rodensteinstr.", City = Berlin };
    public static Stop RobertBaberskeStr { get; } = new() { City = Potsdam, InitialName = "Robert-Baberske-Str." };
    public static Stop Römerschanze { get; } = new() { City = Potsdam, InitialName = "Römerschanze" };
    public static Stop RoteKaserne { get; } = new() { City = Potsdam, InitialName = "Rote Kaserne" };
    public static Stop Rotkehlchenweg { get; } = new() { City = Potsdam, InitialName = "Rotkehlchenweg" };
    public static Stop Rückerstr { get; } = new() { City = Potsdam, InitialName = "Rückerstr." };
    public static Stop Ruinenbergstr { get; } = new() { City = Potsdam, InitialName = "Ruinenbergstr." };

    public static Stop SBabelsbergLutherplatz { get; } =
        new() { City = Potsdam, InitialName = "S\u00a0Babelsberg/Lutherplatz" };

    public static Stop SBabelsbergSchulstr { get; } =
        new() { City = Potsdam, InitialName = "S\u00a0Babelsberg/Schulstr." };

    public static Stop SBabelsbergWattstr { get; } =
        new() { City = Potsdam, InitialName = "S\u00a0Babelsberg/Wattstr." };

    public static Stop SHauptbahnhof { get; } = new() { City = Potsdam, InitialName = "S\u00a0Hauptbahnhof" };

    public static Stop SHauptbahnhofFriedrichEngelsStr { get; } =
        new() { City = Potsdam, InitialName = "S\u00a0Hauptbahnhof/Friedrich-Engels-Str." };

    public static Stop SHauptbahnhofNordIlb { get; } =
        new() { City = Potsdam, InitialName = "S\u00a0Hauptbahnhof/Nord ILB" };

    public static Stop BerlinSuRathausSpandau { get; } =
        new() { InitialName = "S+U\u00a0Rathaus Spandau", City = Berlin };

    public static Stop SacrowParetzerKanal { get; } = new() { City = Potsdam, InitialName = "Sacrow-Paretzer-Kanal" };

    public static Stop SacrowerAlleeRichardWagnerStr { get; } =
        new() { City = Potsdam, InitialName = "Sacrower Allee/Richard-Wagner-Str" };

    public static Stop SacrowerSee { get; } = new() { City = Potsdam, InitialName = "Sacrower See" };
    public static Stop Satzkorn { get; } = new() { City = Potsdam, InitialName = "Satzkorn" };

    public static Stop SchiffbauergasseBerlinerStr { get; } =
        new() { City = Potsdam, InitialName = "Schiffbauergasse/Berliner Str." };

    public static Stop SchiffbauergasseUferweg { get; } =
        new() { City = Potsdam, InitialName = "Schiffbauergasse/Uferweg" };

    public static Stop Schilfhof { get; } = new() { City = Potsdam, InitialName = "Schilfhof" };

    public static Stop SchillerplatzSchafgraben { get; } =
        new() { City = Potsdam, InitialName = "Schillerplatz/Schafgraben" };

    public static Stop Schlaatzstr { get; } = new() { City = Potsdam, InitialName = "Schlaatzstr." };
    public static Stop SchlänitzseeWeg { get; } = new() { City = Potsdam, InitialName = "Schlänitzseer Weg" };

    public static Stop SchlegelstrPappelallee { get; } =
        new() { City = Potsdam, InitialName = "Schlegelstr./Pappelallee" };

    public static Stop SchlossCecilienhof { get; } = new() { City = Potsdam, InitialName = "Schloss Cecilienhof" };
    public static Stop SchlossMarquardt { get; } = new() { City = Potsdam, InitialName = "Schloss Marquardt" };
    public static Stop SchlossCharlottenhof { get; } = new() { City = Potsdam, InitialName = "Schloss Charlottenhof" };
    public static Stop SchlossSacrow { get; } = new() { City = Potsdam, InitialName = "Schloss Sacrow" };
    public static Stop SchlossSanssouci { get; } = new() { City = Potsdam, InitialName = "Schloss Sanssouci" };
    public static Stop Katharinenholzstr { get; } = new() { City = Potsdam, InitialName = "Katharinenholzstr." };
    public static Stop Schlossstr { get; } = new() { City = Potsdam, InitialName = "Schlossstr." };
    public static Stop SchlüterstrForststr { get; } = new() { City = Potsdam, InitialName = "Schlüterstr./Forststr." };
    public static Stop Schneiderremise { get; } = new() { City = Potsdam, InitialName = "Schneiderremise" };
    public static Stop SchuleFahrland { get; } = new() { City = Potsdam, InitialName = "Schule Fahrland" };
    public static Stop SchuleMarquardt { get; } = new() { City = Potsdam, InitialName = "Schule Marquardt" };
    public static Stop Sonnenlandstr { get; } = new() { City = Potsdam, InitialName = "Sonnenlandstr." };
    public static Stop Spindelstr { get; } = new() { City = Potsdam, InitialName = "Spindelstr." };
    public static Stop Sporthalle { get; } = new() { City = Potsdam, InitialName = "Sporthalle" };
    public static Stop TöplitzSportplatz { get; } = new() { InitialName = "Sportplatz", City = Töplitz };
    public static Stop SportplatzBornim { get; } = new() { City = Potsdam, InitialName = "Sportplatz Bornim" };

    public static Stop StudentenwohnheimEiche { get; } =
        new() { City = Potsdam, InitialName = "Studentenwohnheim Eiche" };

    public static Stop Telegrafenberg { get; } = new() { City = Potsdam, InitialName = "Telegrafenberg" };
    public static Stop BerlinTemmeweg { get; } = new() { InitialName = "Temmeweg", City = Berlin };
    public static Stop TemplinerEck { get; } = new() { City = Potsdam, InitialName = "Templiner Eck" };
    public static Stop Thaerstr { get; } = new() { City = Potsdam, InitialName = "Thaerstr." };
    public static Stop TheodorFontaneStr { get; } = new() { City = Potsdam, InitialName = "Theodor-Fontane-Str." };
    public static Stop Tornowstr { get; } = new() { City = Potsdam, InitialName = "Tornowstr." };
    public static Stop Turmstr { get; } = new() { City = Potsdam, InitialName = "Turmstr." };
    public static Stop TüvAkademie { get; } = new() { City = Potsdam, InitialName = "TÜV-Akademie" };
    public static Stop Übergang { get; } = new() { City = Potsdam, InitialName = "Übergang" };
    public static Stop UnderDenEichen { get; } = new() { City = Potsdam, InitialName = "Under den Eichen" };
    public static Stop ErichArendtStr { get; } = new() { City = Potsdam, InitialName = "Erich-Arendt-Str." };
    public static Stop Volkspark { get; } = new() { City = Potsdam, InitialName = "Volkspark" };

    public static Stop WaldsiedlungGroßGlienicke { get; } =
        new() { City = Potsdam, InitialName = "Waldsiedlung Groß Glienicke" };

    public static Stop WaldstrHorstweg { get; } = new() { City = Potsdam, InitialName = "Waldstr./Horstweg" };
    public static Stop WasserwerkWildpark { get; } = new() { City = Potsdam, InitialName = "Wasserwerk Wildpark" };
    public static Stop NeuTöplitzWeinbergstr { get; } = new() { InitialName = "Weinbergstr.", City = NeuTöplitz };
    public static Stop Weinmeisterweg { get; } = new() { City = Potsdam, InitialName = "Weinmeisterweg" };
    public static Stop BerlinWeinmeisterhornweg { get; } = new() { InitialName = "Weinmeisterhornweg", City = Berlin };
    public static Stop Weinmeisterstr { get; } = new() { City = Potsdam, InitialName = "Weinmeisterstr." };
    public static Stop WeißerSee { get; } = new() { City = Potsdam, InitialName = "Weißer See" };
    public static Stop NeuTöplitzWendeplatz { get; } = new() { InitialName = "Wendeplatz", City = NeuTöplitz };

    public static Stop WerderscherDammForststr { get; } =
        new() { City = Potsdam, InitialName = "Werderscher Damm/Forststr." };

    public static Stop WiesenstrLottePulewkaStr { get; } =
        new() { City = Potsdam, InitialName = "Wiesenstr./Lotte-Pulewka-Str." };

    public static Stop ScienceParkWest { get; } = new() { City = Potsdam, InitialName = "Science Park West" };
    public static Stop WublitzstrAmBahnhof { get; } = new() { City = Potsdam, InitialName = "Wublitzstr./Am Bahnhof" };
    public static Stop Zedlitzberg { get; } = new() { City = Potsdam, InitialName = "Zedlitzberg" };
    public static Stop BerlinZiegelhof { get; } = new() { InitialName = "Ziegelhof", City = Berlin };

    public static Stop ZumBahnhofPirschheide { get; } =
        new() { City = Potsdam, InitialName = "Zum Bahnhof Pirschheide" };

    public static Stop ZumGroßenHerzberg { get; } = new() { City = Potsdam, InitialName = "Zum Großen Herzberg" };
    public static Stop ZumKahleberg { get; } = new() { City = Potsdam, InitialName = "Zum Kahleberg" };
    public static Stop ZumTelegrafenberg { get; } = new() { City = Potsdam, InitialName = "Zum Telegrafenberg" };
    public static Stop TöplitzZurAltenFähre { get; } = new() { InitialName = "Zur alten Fähre", City = Töplitz };
    public static Stop Moosgarten { get; } = new() { City = Potsdam, InitialName = "Moosgarten" };
    public static Stop DorfstrKönigsweg { get; } = new() { City = Potsdam, InitialName = "Dorfstr./Königsweg", NameChanges = [(new DateOnly(2024, 12, 15), "Satzkorn/Dorfstr.")]};
    public static Stop TemplinerStr { get; } = new() { City = Potsdam, InitialName = "Templiner Str." };
    public static Stop Tierheim { get; } = new() { City = Potsdam, InitialName = "Tierheim" };
    public static Stop BerlinSteinstücken { get; } = new() { InitialName = "Steinstücken", City = Berlin };
    public static Stop BerlinStahnsdorferBrücke { get; } = new() { InitialName = "Stahnsdorfer Brücke", City = Berlin };
    public static Stop Wiesenpark { get; } = new() { City = Potsdam, InitialName = "Wiesenpark" };
    public static Stop Sternwarte { get; } = new() { City = Potsdam, InitialName = "Sternwarte" };
    public static Stop SchlossBabelsberg { get; } = new() { City = Potsdam, InitialName = "Schloss Babelsberg" };

    public static Stop KarlMarxStrBehringstr { get; } =
        new() { City = Potsdam, InitialName = "Karl-Marx-Str./Behringstr." };

    public static Stop HermannMaaßStr { get; } = new() { City = Potsdam, InitialName = "Hermann-Maaß-Str." };
    public static Stop Scheffelstr { get; } = new() { City = Potsdam, InitialName = "Scheffelstr." };
    public static Stop Goetheplatz { get; } = new() { City = Potsdam, InitialName = "Goetheplatz" };

    public static Stop RotdornwegStahnsdorferStr { get; } =
        new() { City = Potsdam, InitialName = "Rotdornweg/Stahnsdorfer Str." };

    public static Stop Lindenpark { get; } = new() { City = Potsdam, InitialName = "Lindenpark" };

    public static Stop StahnsdorferStrAugustBebelStr { get; } = new()
        { City = Potsdam, InitialName = "Stahnsdorfer Str./August-Bebel-Str." };

    public static Stop SGriebnitzsee { get; } = new() { City = Potsdam, InitialName = "S Griebnitzsee Bhf/Süd" };

    public static Stop HeinrichVonKleistStr { get; } =
        new() { City = Potsdam, InitialName = "Heinrich-von-Kleist-Str." };

    public static Stop AmFindlingWilliFrohweinPlatz { get; } =
        new() { City = Potsdam, InitialName = "Am Findling/Willi-Frohwein-Platz" };

    public static Stop Eichenweg { get; } = new() { City = Potsdam, InitialName = "Eichenweg" };
    public static Stop KleineStr { get; } = new() { City = Potsdam, InitialName = "Kleine Str." };
    public static Stop Filmpark { get; } = new() { City = Potsdam, InitialName = "Filmpark" };

    public static Stop BahnhofMedienstadtBabelsberg { get; } =
        new() { City = Potsdam, InitialName = "Bahnhof Medienstadt Babelsberg" };

    public static Stop Katjes { get; } = new() { City = Potsdam, InitialName = "Katjes" };
    public static Stop BetriebshofViP { get; } = new() { City = Potsdam, InitialName = "Betriebshof ViP" };
    public static Stop SternCenterNuthestr { get; } = new() { City = Potsdam, InitialName = "Stern-Center/Nuthestr." };
    public static Stop OttoHahnRing { get; } = new() { City = Potsdam, InitialName = "Otto-Hahn-Ring" };
    public static Stop Gerlachstr { get; } = new() { City = Potsdam, InitialName = "Gerlachstr." };

    public static Stop SternCenterGerlachstr { get; } =
        new() { City = Potsdam, InitialName = "Stern-Center/Gerlachstr." };

    public static Stop Kreuzstr { get; } = new() { City = Potsdam, InitialName = "Kreuzstr." };
    public static Stop Freiligrathstr { get; } = new() { City = Potsdam, InitialName = "Freiligrathstr." };
    public static Stop OttoErichStr { get; } = new() { City = Potsdam, InitialName = "Otto-Erich-Str." };

    public static Stop HiroshimaNagasakiPlatz { get; } =
        new() { City = Potsdam, InitialName = "Hiroshima-Nagasaki-Platz" };

    public static Stop RoteKreuzStr { get; } = new() { City = Potsdam, InitialName = "Rote-Kreuz-Str." };
    public static Stop AmGehölz { get; } = new() { City = Potsdam, InitialName = "Am Gehölz" };
    public static Stop InDerAue { get; } = new() { City = Potsdam, InitialName = "In der Aue" };
    public static Stop HubertusdammSteinstr { get; } = new() { City = Potsdam, InitialName = "Hubertusdamm/Steinstr." };
    public static Stop Stadtwerke { get; } = new() { City = Potsdam, InitialName = "Stadtwerke" };
    public static Stop Jagdhausstr { get; } = new() { City = Potsdam, InitialName = "Jagdhausstr." };
    public static Stop Chopinstr { get; } = new() { City = Potsdam, InitialName = "Chopinstr." };

    public static Stop NeuendorferStrMendelssohnBartholdyStr { get; } = new()
        { City = Potsdam, InitialName = "Neuendorfer Str./Mendelssohn-Bartholdy-Str." };

    public static Stop Lilienthalstr { get; } = new() { City = Potsdam, InitialName = "Lilienthalstr." };

    public static Stop KonradWolfAlleeSternstr { get; } =
        new() { City = Potsdam, InitialName = "Konrad-Wolf-Allee/Sternstr." };

    public static Stop StudioBabelsberg { get; } = new() { City = Potsdam, InitialName = "Studio Babelsberg" };
    public static Stop Gutsstr { get; } = new() { City = Potsdam, InitialName = "Gutsstr." };
    public static Stop HermannStruveStr { get; } = new() { City = Potsdam, InitialName = "Hermann-Struve-Str." };

    public static Stop BergholzRehbrückeVerdistr { get; } =
        new() { InitialName = "Verdistr.", City = BergholzRehbrücke };

    public static Stop AnDerBrauerei { get; } = new() { City = Potsdam, InitialName = "An der Brauerei" };
    public static Stop ZumHeizwerk { get; } = new() { City = Potsdam, InitialName = "Zum Heizwerk" };

    public static Stop DrewitzerStrAmBuchhorst { get; } =
        new() { City = Potsdam, InitialName = "Drewitzer Str./Am Buchhorst" };

    public static Stop TrebbinerStr { get; } = new() { City = Potsdam, InitialName = "Trebbiner Str." };
    public static Stop DrewitzOrt { get; } = new() { City = Potsdam, InitialName = "Drewitz-Ort" };

    public static Stop ClaraSchumannStrTrebbinerStr { get; } =
        new() { City = Potsdam, InitialName = "Clara-Schumann-Str./Trebbiner Str." };

    public static Stop BerlinGlienickerLake { get; } = new() { City = Berlin, InitialName = "Glienicker Lake" };
    public static Stop BerlinSchlossGlienicke { get; } = new() { City = Berlin, InitialName = "Schloss Glienicke" };
    public static Stop BerlinNikolskoerWeg { get; } = new() { City = Berlin, InitialName = "Nikolskoer Weg" };
    public static Stop BerlinSchäferberg { get; } = new() { City = Berlin, InitialName = "Schäferberg" };
    public static Stop BerlinFriedenstr { get; } = new() { City = Berlin, InitialName = "Friedenstr." };
    public static Stop BerlinSchuchardtweg { get; } = new() { City = Berlin, InitialName = "Schuchardtweg" };
    public static Stop BerlinRathausWannsee { get; } = new() { City = Berlin, InitialName = "Rathaus Wannsee" };

    public static Stop BerlinPfaueninselchausseeKönigstr { get; } =
        new() { City = Berlin, InitialName = "Pfaueninselchaussee/Königstr." };

    public static Stop BerlinWernerstr { get; } = new() { City = Berlin, InitialName = "Wernerstr." };
    public static Stop BerlinAmKleinenWannsee { get; } = new() { City = Berlin, InitialName = "Am Kleinen Wannsee" };
    public static Stop BerlinWannseebrücke { get; } = new() { City = Berlin, InitialName = "Wannseebrücke" };
    public static Stop BerlinSWannsee { get; } = new() { City = Berlin, InitialName = "S Wannsee" };
    public static Stop BerlinTillmannsweg { get; } = new() { City = Berlin, InitialName = "Tillmannsweg" };
    public static Stop BerlinAmSandwerer { get; } = new() { City = Berlin, InitialName = "Am Sandwerder" };

    public static Stop BerlinWasserwerkBeelitzhof { get; } =
        new() { City = Berlin, InitialName = "Wasserwerk Beelitzhof" };

    public static Stop BerlinBadeweg { get; } = new() { City = Berlin, InitialName = "Badeweg" };
    public static Stop BerlinWannseebadweg { get; } = new() { City = Berlin, InitialName = "Wannseebadweg" };
    public static Stop BerlinSNikolassee { get; } = new() { City = Berlin, InitialName = "S Nikolassee" };
    public static Stop KietzerStr { get; } = new() { City = Potsdam, InitialName = "Kietzer Str." };
    public static Stop MarquardterStr { get; } = new() { City = Potsdam, InitialName = "Marquardter Str." };
}
