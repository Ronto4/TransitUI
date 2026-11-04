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
    private static City Elstal => Cities.Elstal;
    private static City Priort => Cities.Priort;
    private static City Wustermark => Cities.Wustermark;
    private static City DyrotzCity => Cities.Dyrotz;
    private static City BuchowKarpzowCity => Cities.BuchowKarpzow;
    private static City Hoppenrade => Cities.Hoppenrade;

    public static Stop AbzweigBetriebshofViP { get; } = new()
        { City = Potsdam, InitialName = "Abzweig Betriebshof ViP".ToClassicalName(), Positions = ["Norden", "Süden"] };

    public static Stop AbzweigNachEiche { get; } = new()
    {
        City = Potsdam,
        InitialName = "Abzweig nach Eiche".ToClassicalName(),
        Positions = ["Amundsenstr.", "Maulbeerallee", "Kaiser-Friedrich-Str.", "Am Neuen Palais"]
    };

    public static Stop AbzweigNachNedlitz { get; } = new()
    {
        City = Potsdam,
        InitialName = "Abzweig nach Nedlitz".ToClassicalName(),
        Positions = ["Rückertstr.", "Max-Eyth-Allee", "Lerchensteig"]
    };

    public static Stop AltNowawes { get; } = new()
    {
        City = Potsdam, InitialName = "Alt Nowawes".ToClassicalName(),
        Positions = ["Tram Norden", "Tram Süden", "Bus Norden", "Bus Süden"]
    };

    public static Stop AltGolm { get; } =
        new() { City = Potsdam, InitialName = "Alt-Golm".ToClassicalName(), Positions = ["Wendeschleife"] };

    public static Stop BerlinAltKladow { get; } = new()
        { InitialName = "Alt-Kladow".ToClassicalName(), City = Berlin, Positions = ["Ri. Sacrow", "Ri. Berlin"] };

    public static Stop AlterMarktLandtag { get; } = new()
    {
        City = Potsdam, InitialName = "Alter Markt/Landtag".ToClassicalName(),
        Positions = ["Ri. S\u00a0Hauptbahnhof", "Ri. Platz der Einheit"]
    };

    public static Stop AlterTornow { get; } = new()
    {
        City = Potsdam, InitialName = "Alter Tornow".ToClassicalName(),
        Positions = ["Ri. S\u00a0Hauptbahnhof", "Ri. Hermannswerder", "Ri. Caputh"]
    };

    public static Stop AmAltenMörtelwerk { get; } = new() { City = Potsdam, InitialName = "Am Alten Mörtelwerk".ToClassicalName() };
    public static Stop AmAnger { get; } = new() { City = Potsdam, InitialName = "Am Anger".ToClassicalName() };
    public static Stop AmFenn { get; } = new() { City = Potsdam, InitialName = "Am Fenn".ToClassicalName() };

    public static Stop RoteKaserneNedlitzerStr { get; } =
        new() { City = Potsdam, InitialName = "Rote Kaserne/Nedlitzer Str.".ToClassicalName() };

    public static Stop AmGrünenWeg { get; } = new() { City = Potsdam, InitialName = "Am Grünen Weg".ToClassicalName() };
    public static Stop AmHämphorn { get; } = new() { City = Potsdam, InitialName = "Am Hämphorn".ToClassicalName() };
    public static Stop AmHavelblick { get; } = new() { City = Potsdam, InitialName = "Am Havelblick".ToClassicalName() };
    public static Stop AmHirtengraben { get; } = new() { City = Potsdam, InitialName = "Am Hirtengraben".ToClassicalName() };
    public static Stop AmKüssel { get; } = new() { City = Potsdam, InitialName = "Am Küssel".ToClassicalName() };
    public static Stop AmMoosfenn { get; } = new() { City = Potsdam, InitialName = "Am Moosfenn".ToClassicalName() };

    public static Stop AmNeuenGartenGroßeWeinmeisterstr { get; } =
        new() { City = Potsdam, InitialName = "Am Neuen Garten/Große Weinmeisterstr.".ToClassicalName() };

    public static Stop BerlinAmOmnibusbahnhof { get; } = new() { InitialName = "Am Omnibusbahnhof".ToClassicalName(), City = Berlin };
    public static Stop AmPark { get; } = new() { City = Potsdam, InitialName = "Am Park".ToClassicalName() };
    public static Stop AmPfingstberg { get; } = new() { City = Potsdam, InitialName = "Am Pfingstberg".ToClassicalName() };
    public static Stop AmSchlahn { get; } = new() { City = Potsdam, InitialName = "Am Schlahn".ToClassicalName() };
    public static Stop AmSchragen { get; } = new() { City = Potsdam, InitialName = "Am Schragen".ToClassicalName() };
    public static Stop AmSchragenRussischeKolonie { get; } = new() { City = Potsdam, InitialName = "Am Schragen/Russische Kolonie".ToClassicalName() };
    public static Stop AmUpstall { get; } = new() { City = Potsdam, InitialName = "Am Upstall".ToClassicalName() };
    public static Stop AmUrnenfeld { get; } = new() { City = Potsdam, InitialName = "Am Urnenfeld".ToClassicalName() };
    public static Stop AmWald { get; } = new() { City = Potsdam, InitialName = "Am Wald".ToClassicalName() };

    public static Stop AmundsenstrNedlitzerStr { get; } =
        new() { City = Potsdam, InitialName = "Amundsenstr./Nedlitzer Str.".ToClassicalName() };

    public static Stop AmundsenstrPotsdamerStr { get; } =
        new() { City = Potsdam, InitialName = "Amundsenstr./Potsdamer Str.".ToClassicalName() };

    public static Stop AnDerWindmühle { get; } = new() { City = Potsdam, InitialName = "An der Windmühle".ToClassicalName() };
    public static Stop Anhaltstr { get; } = new() { City = Potsdam, InitialName = "Anhaltstr.".ToClassicalName() };
    public static Stop AufDemKiewitt { get; } = new() { City = Potsdam, InitialName = "Auf dem Kiewitt".ToClassicalName() };
    public static Stop BerlinAußenweg { get; } = new() { InitialName = "Außenweg".ToClassicalName(), City = Berlin };
    public static Stop BahnhofCharlottenhof { get; } = new() { City = Potsdam, InitialName = "Bahnhof Charlottenhof".ToClassicalName() };

    public static Stop BahnhofCharlottenhofGeschwisterSchollStr { get; } =
        new() { City = Potsdam, InitialName = "Bahnhof Charlottenhof/Geschwister-Scholl-Str.".ToClassicalName() };

    public static Stop BahnhofGolm { get; } = new() { City = Potsdam, InitialName = "Bahnhof Golm".ToClassicalName() };

    public static Stop ScienceParkUniversität { get; } =
        new() { City = Potsdam, InitialName = "Science Park/Universität".ToClassicalName() };

    public static Stop BahnhofMarquardt { get; } = new() { City = Potsdam, InitialName = "Bahnhof Marquardt".ToClassicalName() };
    public static Stop BahnhofParkSanssouci { get; } = new() { City = Potsdam, InitialName = "Bahnhof Park Sanssouci".ToClassicalName() };
    public static Stop BahnhofPirschheide { get; } = new() { City = Potsdam, InitialName = "Bahnhof Pirschheide".ToClassicalName() };
    public static Stop BahnhofRehbrücke { get; } = new() { City = Potsdam, InitialName = "Bahnhof Rehbrücke".ToClassicalName() };
    public static Stop BahnhofRehbrückeSüd { get; } = new() { City = Potsdam, InitialName = "Bahnhof Rehbrücke/Süd".ToClassicalName() };
    public static Stop Bassewitz { get; } = new() { City = Potsdam, InitialName = "Bassewitz".ToClassicalName() };
    public static Stop Bassinplatz { get; } = new() { City = Potsdam, InitialName = "Bassinplatz".ToClassicalName() };
    public static Stop Baumschulenweg { get; } = new() { City = Potsdam, InitialName = "Baumschulenweg".ToClassicalName() };
    public static Stop BayrischesHaus { get; } = new() { City = Potsdam, InitialName = "Bayrisches Haus".ToClassicalName() };
    public static Stop BirkenstrAlleestr { get; } = new() { City = Potsdam, InitialName = "Birkenstr./Alleestr.".ToClassicalName() };
    public static Stop Birkenweg { get; } = new() { City = Potsdam, InitialName = "Birkenweg".ToClassicalName() };
    public static Stop Birnenweg { get; } = new() { City = Potsdam, InitialName = "Birnenweg".ToClassicalName() };
    public static Stop Bisamkiez { get; } = new() { City = Potsdam, InitialName = "Bisamkiez".ToClassicalName() };
    public static Stop BrandenburgerStr { get; } = new() { City = Potsdam, InitialName = "Brandenburger Str.".ToClassicalName() };
    public static Stop Brentanoweg { get; } = new() { City = Potsdam, InitialName = "Brentanoweg".ToClassicalName() };

    public static Stop BerlinBrunsbüttlerDammRuhlebenerStr { get; } =
        new() { InitialName = "Brunsbüttler Damm/Ruhlebener Str.".ToClassicalName(), City = Berlin };

    public static Stop Bullenwinkel { get; } = new() { City = Potsdam, InitialName = "Bullenwinkel".ToClassicalName() };
    public static Stop BurgstrKlinikum { get; } = new() { City = Potsdam, InitialName = "Burgstr./Klinikum".ToClassicalName() };
    public static Stop CampusFachhochschule { get; } = new() { City = Potsdam, InitialName = "Campus Fachhochschule".ToClassicalName() };
    public static Stop CampusJungfernsee { get; } = new() { City = Potsdam, InitialName = "Campus Jungfernsee".ToClassicalName() };

    public static Stop CampusJungfernseeNedlitzerStr { get; } =
        new() { City = Potsdam, InitialName = "Campus Jungfernsee/Nedlitzer Str.".ToClassicalName() };

    public static Stop CampusUniversitätAbrahamGeigerKolleg { get; } =
        new() { City = Potsdam, InitialName = "Campus Universität/Abraham-Geiger-Kolleg".ToClassicalName() };

    public static Stop DeutscherWetterdienst { get; } =
        new() { City = Potsdam, InitialName = "Deutscher Wetterdienst".ToClassicalName() };

    public static Stop TöplitzDorfplatz { get; } = new() { InitialName = "Dorfplatz".ToClassicalName(), City = Töplitz };
    public static Stop Dortustr { get; } = new() { City = Potsdam, InitialName = "Dortustr.".ToClassicalName() };
    public static Stop Drachenhaus { get; } = new() { City = Potsdam, InitialName = "Drachenhaus".ToClassicalName() };

    public static Stop DrewitzerStrErichWeinertStr { get; } =
        new() { City = Potsdam, InitialName = "Drewitzer Str./Erich-Weinert-Str.".ToClassicalName() };

    public static Stop Ecksteinweg { get; } = new() { City = Potsdam, InitialName = "Ecksteinweg".ToClassicalName() };

    public static Stop EduardClaudiusStrDrewitzerStr { get; } =
        new() { City = Potsdam, InitialName = "Eduard-Claudius-Str./Drewitzer-Str.".ToClassicalName() };

    public static Stop EduardClaudiusStrHeinrichMannAllee { get; } =
        new() { City = Potsdam, InitialName = "Eduard-Claudius-Str./Heinrich-Mann-Allee".ToClassicalName() };

    public static Stop Ehrenpfortenbergstr { get; } = new() { City = Potsdam, InitialName = "Ehrenpfortenbergstr.".ToClassicalName() };
    public static Stop Eichenring { get; } = new() { City = Potsdam, InitialName = "Eichenring".ToClassicalName() };
    public static Stop LeestEichholzweg { get; } = new() { InitialName = "Eichholzweg".ToClassicalName(), City = Leest };
    public static Stop Eisbergstücke { get; } = new() { City = Potsdam, InitialName = "Eisbergstücke".ToClassicalName() };

    public static Stop EisenbahnbrückeMarquardt { get; } =
        new() { City = Potsdam, InitialName = "Eisenbahnbrücke Marquardt".ToClassicalName() };

    public static Stop FahrländerSee { get; } = new() { City = Potsdam, InitialName = "Fahrländer See".ToClassicalName() };
    public static Stop Fährweg { get; } = new() { City = Potsdam, InitialName = "Fährweg".ToClassicalName() };
    public static Stop Falkenhorst { get; } = new() { City = Potsdam, InitialName = "Falkenhorst".ToClassicalName() };
    public static Stop Feuerbachstr { get; } = new() { City = Potsdam, InitialName = "Feuerbachstr.".ToClassicalName() };
    public static Stop TöplitzFeuerwehr { get; } = new() { InitialName = "Feuerwehr".ToClassicalName(), City = Töplitz };
    public static Stop Finkenweg { get; } = new() { City = Potsdam, InitialName = "Finkenweg".ToClassicalName() };
    public static Stop BerlinFinnenhausSiedlung { get; } = new() { InitialName = "Finnenhaus-Siedlung".ToClassicalName(), City = Berlin };
    public static Stop Florastr { get; } = new() { City = Potsdam, InitialName = "Florastr.".ToClassicalName() };
    public static Stop Fontanestr { get; } = new() { City = Potsdam, InitialName = "Fontanestr.".ToClassicalName() };
    public static Stop ForsthausTemplin { get; } = new() { City = Potsdam, InitialName = "Forsthaus Templin".ToClassicalName() };
    public static Stop Friedenskirche { get; } = new() { City = Potsdam, InitialName = "Friedenskirche".ToClassicalName() };
    public static Stop Friedhöfe { get; } = new() { City = Potsdam, InitialName = "Friedhöfe".ToClassicalName() };
    public static Stop FriedrichGüntherPark { get; } = new() { City = Potsdam, InitialName = "Friedrich-Günther-Park".ToClassicalName() };
    public static Stop FriedrichWolfStr { get; } = new() { City = Potsdam, InitialName = "Friedrich-Wolf-Str.".ToClassicalName() };
    public static Stop Gaußstr { get; } = new() { City = Potsdam, InitialName = "Gaußstr.".ToClassicalName() };
    public static Stop Geiselberg { get; } = new() { City = Potsdam, InitialName = "Geiselberg".ToClassicalName() };
    public static Stop GlienickerBrücke { get; } = new() { City = Potsdam, InitialName = "Glienicker Brücke".ToClassicalName() };
    public static Stop Glumestr { get; } = new() { City = Potsdam, InitialName = "Glumestr.".ToClassicalName() };
    public static Stop GolmerFichten { get; } = new() { City = Potsdam, InitialName = "Golmer Fichten".ToClassicalName() };
    public static Stop BerlinGößweinsteinerGang { get; } = new() { InitialName = "Gößweinsteiner Gang".ToClassicalName(), City = Berlin };
    public static Stop HannesMeyerStr { get; } = new() { City = Potsdam, InitialName = "Hannes-Meyer-Str.".ToClassicalName() };
    public static Stop HansAlbersStr { get; } = new() { City = Potsdam, InitialName = "Hans-Albers-Str.".ToClassicalName() };
    public static Stop Hebbelstr { get; } = new() { City = Potsdam, InitialName = "Hebbelstr.".ToClassicalName() };
    public static Stop Hechtsprung { get; } = new() { City = Potsdam, InitialName = "Hechtsprung".ToClassicalName() };
    public static Stop BerlinHeerstrWilhelmstr { get; } = new() { InitialName = "Heerstr./Wilhelmstr.".ToClassicalName(), City = Berlin };
    public static Stop Heineberg { get; } = new() { City = Potsdam, InitialName = "Heineberg".ToClassicalName() };
    public static Stop HeinrichHeineWeg { get; } = new() { City = Potsdam, InitialName = "Heinrich-Heine-Weg".ToClassicalName() };
    public static Stop Hermannswerder { get; } = new() { City = Potsdam, InitialName = "Hermannswerder".ToClassicalName() };
    public static Stop HoffbauerStiftung { get; } = new() { City = Potsdam, InitialName = "Hoffbauer-Stiftung".ToClassicalName() };
    public static Stop Höhenstr { get; } = new() { City = Potsdam, InitialName = "Höhenstr.".ToClassicalName() };

    public static Stop HorstwegGroßbeerenstr { get; } =
        new() { City = Potsdam, InitialName = "Horstweg/Großbeerenstr.".ToClassicalName() };

    public static Stop Holzmarktstr { get; } = new() { City = Potsdam, InitialName = "Holzmarktstr.".ToClassicalName() };
    public static Stop Hugstr { get; } = new() { City = Potsdam, InitialName = "Hugstr.".ToClassicalName() };
    public static Stop LeestKirche { get; } = new() { InitialName = "Kirche".ToClassicalName(), City = Leest };
    public static Stop KircheBornim { get; } = new() { City = Potsdam, InitialName = "Kirche Bornim".ToClassicalName() };

    public static Stop HumboldtringLottePulewkaStr { get; } =
        new() { City = Potsdam, InitialName = "Humboldtring/Lotte-Pulewka-Str.".ToClassicalName() };

    public static Stop HumboldtringNuthestr { get; } = new() { City = Potsdam, InitialName = "Humboldtring/Nuthestr.".ToClassicalName() };
    public static Stop ImBogenForststr { get; } = new() { City = Potsdam, InitialName = "Im Bogen/Forststr.".ToClassicalName() };
    public static Stop ImBogenZeppelinstr { get; } = new() { City = Potsdam, InitialName = "Im Bogen/Zeppelinstr.".ToClassicalName() };

    public static Stop ImWinkel { get; } = new()
        { City = Potsdam, InitialName = "Im Winkel".ToClassicalName(), NameChanges = [(new DateOnly(2025, 8, 4), "Kartzow".ToClassicalName())] };

    public static Stop InstitutFürAgrartechnik { get; } =
        new() { City = Potsdam, InitialName = "Institut für Agrartechnik".ToClassicalName() };

    public static Stop JägertorJustizzentrum { get; } =
        new() { City = Potsdam, InitialName = "Jägertor/Justizzentrum".ToClassicalName() };

    public static Stop JohanBoumanPlatz { get; } = new() { City = Potsdam, InitialName = "Johan-Bouman-Platz".ToClassicalName() };
    public static Stop JohannesKeplerPlatz { get; } = new() { City = Potsdam, InitialName = "Johannes-Kepler-Platz".ToClassicalName() };

    public static Stop KaiserFriedrichStrPolizei { get; } =
        new() { City = Potsdam, InitialName = "Kaiser-Friedrich-Str./Polizei".ToClassicalName() };

    public static Stop Kaiserplatz { get; } = new() { City = Potsdam, InitialName = "Kaiserplatz".ToClassicalName() };

    public static Stop KarlLiebknechtStadion { get; } =
        new() { City = Potsdam, InitialName = "Karl-Liebknecht-Stadion".ToClassicalName() };

    public static Stop BerlinKarolinenhöhe { get; } = new() { InitialName = "Karolinenhöhe".ToClassicalName(), City = Berlin };
    public static Stop BerlinKaserneHottengrund { get; } = new() { InitialName = "Kaserne Hottengrund".ToClassicalName(), City = Berlin };

    public static Stop KastanienalleeZeppelinstr { get; } =
        new() { City = Potsdam, InitialName = "Kastanienallee/Zeppelinstr.".ToClassicalName() };

    public static Stop KetzinerStrKönigsweg { get; } =
        new() { City = Potsdam, InitialName = "Ketziner Str./Königsweg".ToClassicalName() };

    public static Stop Kienheide { get; } = new() { City = Potsdam, InitialName = "Kienheide".ToClassicalName() };
    public static Stop Kienhorststr { get; } = new() { City = Potsdam, InitialName = "Kienhorststr.".ToClassicalName() };
    public static Stop Kieskutenberg { get; } = new() { City = Potsdam, InitialName = "Kieskutenberg".ToClassicalName() };
    public static Stop KircheGolm { get; } = new() { City = Potsdam, InitialName = "Kirche Golm".ToClassicalName() };
    public static Stop KircheGroßGlienicke { get; } = new() { City = Potsdam, InitialName = "Kirche Groß Glienicke".ToClassicalName() };
    public static Stop KircheKartzow { get; } = new() { City = Potsdam, InitialName = "Kirche Kartzow".ToClassicalName() };
    public static Stop KircheUetz { get; } = new() { City = Potsdam, InitialName = "Kirche Uetz".ToClassicalName() };
    public static Stop Kirschallee { get; } = new() { City = Potsdam, InitialName = "Kirschallee".ToClassicalName() };
    public static Stop TöplitzKirschweg { get; } = new() { InitialName = "Kirschweg".ToClassicalName(), City = Töplitz };

    public static Stop KläranlagePotsdamNord { get; } =
        new() { City = Potsdam, InitialName = "Kläranlage Potsdam-Nord".ToClassicalName() };

    public static Stop KleineWeinmeisterstr { get; } = new() { City = Potsdam, InitialName = "Kleine Weinmeisterstr.".ToClassicalName() };
    public static Stop Klinikum { get; } = new() { City = Potsdam, InitialName = "Klinikum".ToClassicalName() };
    public static Stop Krampnitzsee { get; } = new() { City = Potsdam, InitialName = "Krampnitzsee".ToClassicalName() };
    public static Stop Kuhfort { get; } = new() { City = Potsdam, InitialName = "Kuhfort".ToClassicalName() };
    public static Stop Kuhfortdamm { get; } = new() { City = Potsdam, InitialName = "Kuhfortdamm".ToClassicalName() };
    public static Stop KunersdorferStr { get; } = new() { City = Potsdam, InitialName = "Kunersdorfer Str.".ToClassicalName() };
    public static Stop Küsselstr { get; } = new() { City = Potsdam, InitialName = "Küsselstr.".ToClassicalName() };
    public static Stop Landesumweltamt { get; } = new() { City = Potsdam, InitialName = "Landesumweltamt".ToClassicalName() };

    public static Stop BerlinLandschaftsfriedhofGatow { get; } =
        new() { InitialName = "Landschaftsfriedhof Gatow".ToClassicalName(), City = Berlin };

    public static Stop LangeBrücke { get; } = new() { City = Potsdam, InitialName = "Lange Brücke".ToClassicalName() };

    public static Stop LanghansstrGroßeWeinmeisterstr { get; } = new()
        { City = Potsdam, InitialName = "Langhansstr./Große Weinmeisterstr.".ToClassicalName() };

    public static Stop TöplitzLeesterStr { get; } = new() { InitialName = "Leester Str.".ToClassicalName(), City = Töplitz };

    public static Stop LerchensteigKleingartenanlage { get; } =
        new() { City = Potsdam, InitialName = "Lerchensteig/Kleingartenanlage".ToClassicalName() };

    public static Stop LindstedterChaussee { get; } = new() { City = Potsdam, InitialName = "Lindstedter Chaussee".ToClassicalName() };
    public static Stop LeonardoDaVinciStr { get; } = new() { City = Potsdam, InitialName = "Leonardo-da-Vinci-Str.".ToClassicalName() };
    public static Stop Luftschiffhafen { get; } = new() { City = Potsdam, InitialName = "Luftschiffhafen".ToClassicalName() };

    public static Stop LuisenplatzNordParkSanssouci { get; } =
        new() { City = Potsdam, InitialName = "Luisenplatz-Nord/Park Sanssouci".ToClassicalName() };

    public static Stop LuisenplatzOstParkSanssouci { get; } =
        new() { City = Potsdam, InitialName = "Luisenplatz-Ost/Park Sanssouci".ToClassicalName() };

    public static Stop LuisenplatzSüdParkSanssouci { get; } =
        new() { City = Potsdam, InitialName = "Luisenplatz-Süd/Park Sanssouci".ToClassicalName() };

    public static Stop MagnusZellerPlatz { get; } = new() { City = Potsdam, InitialName = "Magnus-Zeller-Platz".ToClassicalName() };
    public static Stop Mangerstr { get; } = new() { City = Potsdam, InitialName = "Mangerstr.".ToClassicalName() };
    public static Stop MarieJuchaczStr { get; } = new() { City = Potsdam, InitialName = "Marie-Juchacz-Str.".ToClassicalName() };
    public static Stop Mauerstr { get; } = new() { City = Potsdam, InitialName = "Mauerstr.".ToClassicalName() };
    public static Stop MaxBornStr { get; } = new() { City = Potsdam, InitialName = "Max-Born-Str.".ToClassicalName() };
    public static Stop Mehlbeerenweg { get; } = new() { City = Potsdam, InitialName = "Mehlbeerenweg".ToClassicalName() };
    public static Stop BerlinMelanchtonplatz { get; } = new() { InitialName = "Melanchtonplatz".ToClassicalName(), City = Berlin };
    public static Stop BerlinMetzerStr { get; } = new() { InitialName = "Metzer Str.".ToClassicalName(), City = Berlin };

    public static Stop MichendorferChausseeFriedhof { get; } =
        new() { City = Potsdam, InitialName = "Michendorfer Chaussee/Friedhof".ToClassicalName() };

    public static Stop Naturkundemuseum { get; } = new() { City = Potsdam, InitialName = "Naturkundemuseum".ToClassicalName() };
    public static Stop NauenerTor { get; } = new() { City = Potsdam, InitialName = "Nauener Tor".ToClassicalName() };
    public static Stop Nesselgrund { get; } = new() { City = Potsdam, InitialName = "Nesselgrund".ToClassicalName() };
    public static Stop NeuesPalais { get; } = new() { City = Potsdam, InitialName = "Neues Palais".ToClassicalName() };
    public static Stop BerlinNeukladowerAllee { get; } = new() { InitialName = "Neukladower Allee".ToClassicalName(), City = Berlin };
    public static Stop BerlinGutsparkNeukladow { get; } = new() { InitialName = "Gutspark Neukladow".ToClassicalName(), City = Berlin };
    public static Stop Orangerie { get; } = new() { City = Potsdam, InitialName = "Orangerie".ToClassicalName() };
    public static Stop Paaren { get; } = new() { City = Potsdam, InitialName = "Paaren".ToClassicalName() };
    public static Stop BerlinParnemannweg { get; } = new() { InitialName = "Parnemannweg".ToClassicalName(), City = Berlin };
    public static Stop Persiusstr { get; } = new() { City = Potsdam, InitialName = "Persiusstr.".ToClassicalName() };
    public static Stop Plantagenstr { get; } = new() { City = Potsdam, InitialName = "Plantagenstr.".ToClassicalName() };
    public static Stop Plantagenweg { get; } = new() { City = Potsdam, InitialName = "Plantagenweg".ToClassicalName() };

    public static Stop PlatzDerEinheitBildungsforum { get; } =
        new() { City = Potsdam, InitialName = "Platz der Einheit/Bildungsforum".ToClassicalName() };

    public static Stop PlatzDerEinheitNord { get; } = new() { City = Potsdam, InitialName = "Platz der Einheit/Nord".ToClassicalName() };
    public static Stop PlatzDerEinheitOst { get; } = new() { City = Potsdam, InitialName = "Platz der Einheit/Ost".ToClassicalName() };
    public static Stop PlatzDerEinheitWest { get; } = new() { City = Potsdam, InitialName = "Platz der Einheit/West".ToClassicalName() };
    public static Stop Priesterweg { get; } = new() { City = Potsdam, InitialName = "Priesterweg".ToClassicalName() };
    public static Stop Puschkinallee { get; } = new() { City = Potsdam, InitialName = "Puschkinallee".ToClassicalName() };
    public static Stop Rathaus { get; } = new() { City = Potsdam, InitialName = "Rathaus".ToClassicalName() };
    public static Stop RathausBabelsberg { get; } = new() { City = Potsdam, InitialName = "Rathaus Babelsberg".ToClassicalName() };
    public static Stop ReiterwegAlleestr { get; } = new() { City = Potsdam, InitialName = "Reiterweg/Alleestr.".ToClassicalName() };
    public static Stop ReiterwegJägerallee { get; } = new() { City = Potsdam, InitialName = "Reiterweg/Jägerallee".ToClassicalName() };
    public static Stop Ribbeckstr { get; } = new() { City = Potsdam, InitialName = "Ribbeckstr.".ToClassicalName() };

    public static Stop BerlinRitterfelddammPotsdamerChaussee { get; } =
        new() { InitialName = "Ritterfelddamm/Potsdamer Chaussee".ToClassicalName(), City = Berlin };

    public static Stop BerlinRodensteinstr { get; } = new() { InitialName = "Rodensteinstr.".ToClassicalName(), City = Berlin };
    public static Stop RobertBaberskeStr { get; } = new() { City = Potsdam, InitialName = "Robert-Baberske-Str.".ToClassicalName() };

    public static Stop Römerschanze { get; } = new()
    {
        City = Potsdam, InitialName = "Römerschanze".ToClassicalName(), NameChanges = [(new DateOnly(2025, 8, 4), "Insel Neu Fahrland".ToClassicalName())]
    };
    public static Stop RoteKaserne { get; } = new() { City = Potsdam, InitialName = "Rote Kaserne".ToClassicalName() };
    public static Stop Rotkehlchenweg { get; } = new() { City = Potsdam, InitialName = "Rotkehlchenweg".ToClassicalName() };
    public static Stop Rückerstr { get; } = new() { City = Potsdam, InitialName = "Rückerstr.".ToClassicalName() };
    public static Stop Ruinenbergstr { get; } = new() { City = Potsdam, InitialName = "Ruinenbergstr.".ToClassicalName() };

    public static Stop SBabelsbergLutherplatz { get; } =
        new() { City = Potsdam, InitialName = "S\u00a0Babelsberg/Lutherplatz".ToClassicalName() };

    public static Stop SBabelsbergSchulstr { get; } =
        new() { City = Potsdam, InitialName = "S\u00a0Babelsberg/Schulstr.".ToClassicalName() };

    public static Stop SBabelsbergWattstr { get; } =
        new() { City = Potsdam, InitialName = "S\u00a0Babelsberg/Wattstr.".ToClassicalName() };

    public static Stop SHauptbahnhof { get; } = new() { City = Potsdam, InitialName = "S\u00a0Hauptbahnhof".ToClassicalName() };

    public static Stop SHauptbahnhofFriedrichEngelsStr { get; } =
        new() { City = Potsdam, InitialName = "S\u00a0Hauptbahnhof/Friedrich-Engels-Str.".ToClassicalName() };

    public static Stop SHauptbahnhofNordIlb { get; } =
        new() { City = Potsdam, InitialName = "S\u00a0Hauptbahnhof/Nord ILB".ToClassicalName() };

    public static Stop BerlinSuRathausSpandau { get; } =
        new() { InitialName = "S+U\u00a0Rathaus Spandau".ToClassicalName(), City = Berlin };

    public static Stop SacrowParetzerKanal { get; } = new() { City = Potsdam, InitialName = "Sacrow-Paretzer-Kanal".ToClassicalName() };

    public static Stop SacrowerAlleeRichardWagnerStr { get; } =
        new() { City = Potsdam, InitialName = "Sacrower Allee/Richard-Wagner-Str".ToClassicalName() };

    public static Stop SacrowerSee { get; } = new() { City = Potsdam, InitialName = "Sacrower See".ToClassicalName() };
    public static Stop Satzkorn { get; } = new() { City = Potsdam, InitialName = "Satzkorn".ToClassicalName() };

    public static Stop SchiffbauergasseBerlinerStr { get; } =
        new() { City = Potsdam, InitialName = "Schiffbauergasse/Berliner Str.".ToClassicalName() };

    public static Stop SchiffbauergasseUferweg { get; } =
        new() { City = Potsdam, InitialName = "Schiffbauergasse/Uferweg".ToClassicalName() };

    public static Stop Schilfhof { get; } = new() { City = Potsdam, InitialName = "Schilfhof".ToClassicalName() };

    public static Stop SchillerplatzSchafgraben { get; } =
        new() { City = Potsdam, InitialName = "Schillerplatz/Schafgraben".ToClassicalName() };

    public static Stop Schlaatzstr { get; } = new() { City = Potsdam, InitialName = "Schlaatzstr.".ToClassicalName() };
    public static Stop SchlänitzseeWeg { get; } = new() { City = Potsdam, InitialName = "Schlänitzseer Weg".ToClassicalName() };

    public static Stop SchlegelstrPappelallee { get; } =
        new() { City = Potsdam, InitialName = "Schlegelstr./Pappelallee".ToClassicalName() };

    public static Stop SchlossCecilienhof { get; } = new() { City = Potsdam, InitialName = "Schloss Cecilienhof".ToClassicalName() };
    public static Stop SchlossMarquardt { get; } = new() { City = Potsdam, InitialName = "Schloss Marquardt".ToClassicalName() };
    public static Stop SchlossCharlottenhof { get; } = new() { City = Potsdam, InitialName = "Schloss Charlottenhof".ToClassicalName() };
    public static Stop SchlossSacrow { get; } = new() { City = Potsdam, InitialName = "Schloss Sacrow".ToClassicalName() };
    public static Stop SchlossSanssouci { get; } = new() { City = Potsdam, InitialName = "Schloss Sanssouci".ToClassicalName() };
    public static Stop SchlossSanssouciBornstedterStr { get; } = new() { City = Potsdam, InitialName = "Schloss Sanssouci/Bornstedter Str.".ToClassicalName() };
    public static Stop Katharinenholzstr { get; } = new() { City = Potsdam, InitialName = "Katharinenholzstr.".ToClassicalName() };
    public static Stop Schlossstr { get; } = new() { City = Potsdam, InitialName = "Schlossstr.".ToClassicalName() };
    public static Stop SchlüterstrForststr { get; } = new() { City = Potsdam, InitialName = "Schlüterstr./Forststr.".ToClassicalName() };
    public static Stop Schneiderremise { get; } = new() { City = Potsdam, InitialName = "Schneiderremise".ToClassicalName() };
    public static Stop SchuleFahrland { get; } = new() { City = Potsdam, InitialName = "Schule Fahrland".ToClassicalName() };
    public static Stop SchuleMarquardt { get; } = new() { City = Potsdam, InitialName = "Schule Marquardt".ToClassicalName() };
    public static Stop Sonnenlandstr { get; } = new() { City = Potsdam, InitialName = "Sonnenlandstr.".ToClassicalName() };
    public static Stop Spindelstr { get; } = new() { City = Potsdam, InitialName = "Spindelstr.".ToClassicalName() };
    public static Stop Sporthalle { get; } = new() { City = Potsdam, InitialName = "Sporthalle".ToClassicalName() };
    public static Stop TöplitzSportplatz { get; } = new() { InitialName = "Sportplatz".ToClassicalName(), City = Töplitz };
    public static Stop SportplatzBornim { get; } = new() { City = Potsdam, InitialName = "Sportplatz Bornim".ToClassicalName() };

    public static Stop StudentenwohnheimEiche { get; } =
        new() { City = Potsdam, InitialName = "Studentenwohnheim Eiche".ToClassicalName() };

    public static Stop Telegrafenberg { get; } = new() { City = Potsdam, InitialName = "Telegrafenberg".ToClassicalName() };
    public static Stop BerlinTemmeweg { get; } = new() { InitialName = "Temmeweg".ToClassicalName(), City = Berlin };
    public static Stop TemplinerEck { get; } = new() { City = Potsdam, InitialName = "Templiner Eck".ToClassicalName() };
    public static Stop Thaerstr { get; } = new() { City = Potsdam, InitialName = "Thaerstr.".ToClassicalName() };
    public static Stop TheodorFontaneStr { get; } = new() { City = Potsdam, InitialName = "Theodor-Fontane-Str.".ToClassicalName() };
    public static Stop Tornowstr { get; } = new() { City = Potsdam, InitialName = "Tornowstr.".ToClassicalName() };
    public static Stop Turmstr { get; } = new() { City = Potsdam, InitialName = "Turmstr.".ToClassicalName() };
    public static Stop TüvAkademie { get; } = new() { City = Potsdam, InitialName = "TÜV-Akademie".ToClassicalName() };
    public static Stop Übergang { get; } = new() { City = Potsdam, InitialName = "Übergang".ToClassicalName() };
    public static Stop UnderDenEichen { get; } = new() { City = Potsdam, InitialName = "Under den Eichen".ToClassicalName() };
    public static Stop ErichArendtStr { get; } = new() { City = Potsdam, InitialName = "Erich-Arendt-Str.".ToClassicalName() };
    public static Stop Volkspark { get; } = new() { City = Potsdam, InitialName = "Volkspark".ToClassicalName() };

    public static Stop WaldsiedlungGroßGlienicke { get; } =
        new() { City = Potsdam, InitialName = "Waldsiedlung Groß Glienicke".ToClassicalName() };

    public static Stop WaldstrHorstweg { get; } = new() { City = Potsdam, InitialName = "Waldstr./Horstweg".ToClassicalName() };
    public static Stop WasserwerkWildpark { get; } = new() { City = Potsdam, InitialName = "Wasserwerk Wildpark".ToClassicalName() };
    public static Stop NeuTöplitzWeinbergstr { get; } = new() { InitialName = "Weinbergstr.".ToClassicalName(), City = NeuTöplitz };
    public static Stop Weinmeisterweg { get; } = new() { City = Potsdam, InitialName = "Weinmeisterweg".ToClassicalName() };
    public static Stop BerlinWeinmeisterhornweg { get; } = new() { InitialName = "Weinmeisterhornweg".ToClassicalName(), City = Berlin };
    public static Stop Weinmeisterstr { get; } = new() { City = Potsdam, InitialName = "Weinmeisterstr.".ToClassicalName() };
    public static Stop WeißerSee { get; } = new() { City = Potsdam, InitialName = "Weißer See".ToClassicalName() };
    public static Stop NeuTöplitzWendeplatz { get; } = new() { InitialName = "Wendeplatz".ToClassicalName(), City = NeuTöplitz };

    public static Stop WerderscherDammForststr { get; } =
        new() { City = Potsdam, InitialName = "Werderscher Damm/Forststr.".ToClassicalName() };

    public static Stop WiesenstrLottePulewkaStr { get; } =
        new() { City = Potsdam, InitialName = "Wiesenstr./Lotte-Pulewka-Str.".ToClassicalName() };

    public static Stop ScienceParkWest { get; } = new() { City = Potsdam, InitialName = "Science Park West".ToClassicalName() };
    public static Stop WublitzstrAmBahnhof { get; } = new() { City = Potsdam, InitialName = "Wublitzstr./Am Bahnhof".ToClassicalName() };
    public static Stop Zedlitzberg { get; } = new() { City = Potsdam, InitialName = "Zedlitzberg".ToClassicalName() };
    public static Stop BerlinZiegelhof { get; } = new() { InitialName = "Ziegelhof".ToClassicalName(), City = Berlin };

    public static Stop ZumBahnhofPirschheide { get; } =
        new() { City = Potsdam, InitialName = "Zum Bahnhof Pirschheide".ToClassicalName() };

    public static Stop ZumGroßenHerzberg { get; } = new() { City = Potsdam, InitialName = "Zum Großen Herzberg".ToClassicalName() };
    public static Stop ZumKahleberg { get; } = new() { City = Potsdam, InitialName = "Zum Kahleberg".ToClassicalName() };
    public static Stop ZumTelegrafenberg { get; } = new() { City = Potsdam, InitialName = "Zum Telegrafenberg".ToClassicalName() };
    public static Stop TöplitzZurAltenFähre { get; } = new() { InitialName = "Zur alten Fähre".ToClassicalName(), City = Töplitz };
    public static Stop Moosgarten { get; } = new() { City = Potsdam, InitialName = "Moosgarten".ToClassicalName() };
    public static Stop DorfstrKönigsweg { get; } = new() { City = Potsdam, InitialName = "Dorfstr./Königsweg".ToClassicalName(), NameChanges = [(new DateOnly(2024, 12, 15), "Satzkorn/Dorfstr.".ToClassicalName())]};
    public static Stop TemplinerStr { get; } = new() { City = Potsdam, InitialName = "Templiner Str.".ToClassicalName() };
    public static Stop Tierheim { get; } = new() { City = Potsdam, InitialName = "Tierheim".ToClassicalName() };
    public static Stop BerlinSteinstücken { get; } = new() { InitialName = "Steinstücken".ToClassicalName(), City = Berlin };
    public static Stop BerlinStahnsdorferBrücke { get; } = new() { InitialName = "Stahnsdorfer Brücke".ToClassicalName(), City = Berlin };
    public static Stop Wiesenpark { get; } = new() { City = Potsdam, InitialName = "Wiesenpark".ToClassicalName() };
    public static Stop Sternwarte { get; } = new() { City = Potsdam, InitialName = "Sternwarte".ToClassicalName() };
    public static Stop SchlossBabelsberg { get; } = new() { City = Potsdam, InitialName = "Schloss Babelsberg".ToClassicalName() };

    public static Stop KarlMarxStrBehringstr { get; } =
        new() { City = Potsdam, InitialName = "Karl-Marx-Str./Behringstr.".ToClassicalName() };

    public static Stop HermannMaaßStr { get; } = new() { City = Potsdam, InitialName = "Hermann-Maaß-Str.".ToClassicalName() };
    public static Stop Scheffelstr { get; } = new() { City = Potsdam, InitialName = "Scheffelstr.".ToClassicalName() };
    public static Stop Goetheplatz { get; } = new() { City = Potsdam, InitialName = "Goetheplatz".ToClassicalName() };

    public static Stop RotdornwegStahnsdorferStr { get; } =
        new() { City = Potsdam, InitialName = "Rotdornweg/Stahnsdorfer Str.".ToClassicalName() };

    public static Stop Lindenpark { get; } = new() { City = Potsdam, InitialName = "Lindenpark".ToClassicalName() };

    public static Stop StahnsdorferStrAugustBebelStr { get; } = new()
        { City = Potsdam, InitialName = "Stahnsdorfer Str./August-Bebel-Str.".ToClassicalName() };

    public static Stop SGriebnitzsee { get; } = new() { City = Potsdam, InitialName = "S Griebnitzsee Bhf/Süd".ToClassicalName() };

    public static Stop HeinrichVonKleistStr { get; } =
        new() { City = Potsdam, InitialName = "Heinrich-von-Kleist-Str.".ToClassicalName() };

    public static Stop AmFindlingWilliFrohweinPlatz { get; } =
        new() { City = Potsdam, InitialName = "Am Findling/Willi-Frohwein-Platz".ToClassicalName() };

    public static Stop Eichenweg { get; } = new() { City = Potsdam, InitialName = "Eichenweg".ToClassicalName() };
    public static Stop KleineStr { get; } = new() { City = Potsdam, InitialName = "Kleine Str.".ToClassicalName() };
    public static Stop Filmpark { get; } = new() { City = Potsdam, InitialName = "Filmpark".ToClassicalName() };

    public static Stop BahnhofMedienstadtBabelsberg { get; } =
        new() { City = Potsdam, InitialName = "Bahnhof Medienstadt Babelsberg".ToClassicalName() };

    public static Stop Katjes { get; } = new() { City = Potsdam, InitialName = "Katjes".ToClassicalName() };
    public static Stop BetriebshofViP { get; } = new() { City = Potsdam, InitialName = "Betriebshof ViP".ToClassicalName() };
    public static Stop SternCenterNuthestr { get; } = new() { City = Potsdam, InitialName = "Stern-Center/Nuthestr.".ToClassicalName() };
    public static Stop OttoHahnRing { get; } = new() { City = Potsdam, InitialName = "Otto-Hahn-Ring".ToClassicalName() };
    public static Stop Gerlachstr { get; } = new() { City = Potsdam, InitialName = "Gerlachstr.".ToClassicalName() };

    public static Stop SternCenterGerlachstr { get; } =
        new() { City = Potsdam, InitialName = "Stern-Center/Gerlachstr.".ToClassicalName() };

    public static Stop Kreuzstr { get; } = new() { City = Potsdam, InitialName = "Kreuzstr.".ToClassicalName() };
    public static Stop Freiligrathstr { get; } = new() { City = Potsdam, InitialName = "Freiligrathstr.".ToClassicalName() };
    public static Stop OttoErichStr { get; } = new() { City = Potsdam, InitialName = "Otto-Erich-Str.".ToClassicalName() };

    public static Stop HiroshimaNagasakiPlatz { get; } =
        new() { City = Potsdam, InitialName = "Hiroshima-Nagasaki-Platz".ToClassicalName() };

    public static Stop RoteKreuzStr { get; } = new() { City = Potsdam, InitialName = "Rote-Kreuz-Str.".ToClassicalName() };
    public static Stop AmGehölz { get; } = new() { City = Potsdam, InitialName = "Am Gehölz".ToClassicalName() };
    public static Stop InDerAue { get; } = new() { City = Potsdam, InitialName = "In der Aue".ToClassicalName() };
    public static Stop HubertusdammSteinstr { get; } = new() { City = Potsdam, InitialName = "Hubertusdamm/Steinstr.".ToClassicalName() };
    public static Stop Stadtwerke { get; } = new() { City = Potsdam, InitialName = "Stadtwerke".ToClassicalName() };
    public static Stop Jagdhausstr { get; } = new() { City = Potsdam, InitialName = "Jagdhausstr.".ToClassicalName() };
    public static Stop Chopinstr { get; } = new() { City = Potsdam, InitialName = "Chopinstr.".ToClassicalName() };

    public static Stop NeuendorferStrMendelssohnBartholdyStr { get; } = new()
        { City = Potsdam, InitialName = "Neuendorfer Str./Mendelssohn-Bartholdy-Str.".ToClassicalName() };

    public static Stop Lilienthalstr { get; } = new() { City = Potsdam, InitialName = "Lilienthalstr.".ToClassicalName() };

    public static Stop KonradWolfAlleeSternstr { get; } =
        new() { City = Potsdam, InitialName = "Konrad-Wolf-Allee/Sternstr.".ToClassicalName() };

    public static Stop StudioBabelsberg { get; } = new() { City = Potsdam, InitialName = "Studio Babelsberg".ToClassicalName() };
    public static Stop Gutsstr { get; } = new() { City = Potsdam, InitialName = "Gutsstr.".ToClassicalName() };
    public static Stop HermannStruveStr { get; } = new() { City = Potsdam, InitialName = "Hermann-Struve-Str.".ToClassicalName() };

    public static Stop BergholzRehbrückeVerdistr { get; } =
        new() { InitialName = "Verdistr.".ToClassicalName(), City = BergholzRehbrücke };

    public static Stop AnDerBrauerei { get; } = new() { City = Potsdam, InitialName = "An der Brauerei".ToClassicalName() };
    public static Stop ZumHeizwerk { get; } = new() { City = Potsdam, InitialName = "Zum Heizwerk".ToClassicalName() };

    public static Stop DrewitzerStrAmBuchhorst { get; } =
        new() { City = Potsdam, InitialName = "Drewitzer Str./Am Buchhorst".ToClassicalName() };

    public static Stop TrebbinerStr { get; } = new() { City = Potsdam, InitialName = "Trebbiner Str.".ToClassicalName() };
    public static Stop DrewitzOrt { get; } = new() { City = Potsdam, InitialName = "Drewitz-Ort".ToClassicalName() };

    public static Stop ClaraSchumannStrTrebbinerStr { get; } =
        new() { City = Potsdam, InitialName = "Clara-Schumann-Str./Trebbiner Str.".ToClassicalName() };

    public static Stop BerlinGlienickerLake { get; } = new() { City = Berlin, InitialName = "Glienicker Lake".ToClassicalName() };
    public static Stop BerlinSchlossGlienicke { get; } = new() { City = Berlin, InitialName = "Schloss Glienicke".ToClassicalName() };
    public static Stop BerlinNikolskoerWeg { get; } = new() { City = Berlin, InitialName = "Nikolskoer Weg".ToClassicalName() };
    public static Stop BerlinSchäferberg { get; } = new() { City = Berlin, InitialName = "Schäferberg".ToClassicalName() };
    public static Stop BerlinFriedenstr { get; } = new() { City = Berlin, InitialName = "Friedenstr.".ToClassicalName() };
    public static Stop BerlinSchuchardtweg { get; } = new() { City = Berlin, InitialName = "Schuchardtweg".ToClassicalName() };
    public static Stop BerlinRathausWannsee { get; } = new() { City = Berlin, InitialName = "Rathaus Wannsee".ToClassicalName() };

    public static Stop BerlinPfaueninselchausseeKönigstr { get; } =
        new() { City = Berlin, InitialName = "Pfaueninselchaussee/Königstr.".ToClassicalName() };

    public static Stop BerlinWernerstr { get; } = new() { City = Berlin, InitialName = "Wernerstr.".ToClassicalName() };
    public static Stop BerlinAmKleinenWannsee { get; } = new() { City = Berlin, InitialName = "Am Kleinen Wannsee".ToClassicalName() };
    public static Stop BerlinWannseebrücke { get; } = new() { City = Berlin, InitialName = "Wannseebrücke".ToClassicalName() };
    public static Stop BerlinSWannsee { get; } = new() { City = Berlin, InitialName = "S Wannsee".ToClassicalName() };
    public static Stop BerlinTillmannsweg { get; } = new() { City = Berlin, InitialName = "Tillmannsweg".ToClassicalName() };
    public static Stop BerlinAmSandwerer { get; } = new() { City = Berlin, InitialName = "Am Sandwerder".ToClassicalName() };

    public static Stop BerlinWasserwerkBeelitzhof { get; } =
        new() { City = Berlin, InitialName = "Wasserwerk Beelitzhof".ToClassicalName() };

    public static Stop BerlinBadeweg { get; } = new() { City = Berlin, InitialName = "Badeweg".ToClassicalName() };
    public static Stop BerlinWannseebadweg { get; } = new() { City = Berlin, InitialName = "Wannseebadweg".ToClassicalName() };
    public static Stop BerlinSNikolassee { get; } = new() { City = Berlin, InitialName = "S Nikolassee".ToClassicalName() };
    public static Stop KietzerStr { get; } = new() { City = Potsdam, InitialName = "Kietzer Str.".ToClassicalName() };
    public static Stop MarquardterStr { get; } = new() { City = Potsdam, InitialName = "Marquardter Str.".ToClassicalName() };
    public static Stop KrampnitzerTor { get; } = new() { City = Potsdam, InitialName = "Krampnitzer Tor".ToClassicalName() };
    public static Stop KrampnitzMitte { get; } = new() { City = Potsdam, InitialName = "Krampnitz-Mitte".ToClassicalName() };
    public static Stop ElstalBahnhof { get; } = new() { City = Elstal, InitialName = "Bahnhof".ToClassicalName() };
    public static Stop ElstalEduardScheveAllee { get; } = new() { City = Elstal, InitialName = "Eduard-Scheve-Allee".ToClassicalName() };
    public static Stop ElstalUnterDenKiefern { get; } = new() { City = Elstal, InitialName = "Unter den Kiefern".ToClassicalName() };
    public static Stop ElstalAhornweg { get; } = new() { City = Elstal, InitialName = "Ahornweg".ToClassicalName() };
    public static Stop ElstalBreiteStr { get; } = new() { City = Elstal, InitialName = "Breite Str.".ToClassicalName() };
    public static Stop ElstalPuschkinstrSchule { get; } = new() { City = Elstal, InitialName = "Puschkinstr./Schule".ToClassicalName() };
    public static Stop ElstalDesignerOutlet { get; } = new() { City = Elstal, InitialName = "Designer-Outlet".ToClassicalName() };
    public static Stop ElstalOlympischesDorf { get; } = new() { City = Elstal, InitialName = "Olympisches Dorf".ToClassicalName() };
    public static Stop ElstalEulenspiegelsiedlung { get; } = new() { City = Elstal, InitialName = "Eulenspiegelsiedlung".ToClassicalName() };
    public static Stop ElstalRadelandberg { get; } = new() { City = Elstal, InitialName = "Radelandberg".ToClassicalName() };
    public static Stop ElstalSportplatz { get; } = new() { City = Elstal, InitialName = "Sportplatz".ToClassicalName() };
    public static Stop ElstalFeuerwehr { get; } = new() { City = Elstal, InitialName = "Feuerwehr".ToClassicalName() };
    public static Stop ElstalSchulzentrum { get; } = new() { City = Elstal, InitialName = "Schulzentrum".ToClassicalName() };
    public static Stop PriortAmObstgarten { get; } = new() { City = Priort, InitialName = "Am Obstgarten".ToClassicalName() };
    public static Stop PriortBahnhof { get; } = new() { City = Priort, InitialName = "Bahnhof".ToClassicalName() };
    public static Stop PriortAltesDorf { get; } = new() { City = Priort, InitialName = "Altes Dorf".ToClassicalName() };
    public static Stop WustermarkSchule { get; } = new() { City = Wustermark, InitialName = "Schule".ToClassicalName() };
    public static Stop WustermarkBerlinerStr { get; } = new() { City = Wustermark, InitialName = "Berliner Str.".ToClassicalName() };
    public static Stop WustermarkMittelallee { get; } = new() { City = Wustermark, InitialName = "Mittelallee".ToClassicalName() };
    public static Stop WustermarkBrunnenplatz { get; } = new() { City = Wustermark, InitialName = "Brunnenplatz".ToClassicalName() };
    public static Stop Dyrotz { get; } = new() { City = DyrotzCity, InitialName = new Stop.CityName() };
    public static Stop BuchowKarpzow { get; } = new() { City = BuchowKarpzowCity, InitialName = new Stop.CityName() };
    public static Stop HoppenradeAusbau { get; } = new() { City = Hoppenrade, InitialName = "Ausbau".ToClassicalName() };
    public static Stop HoppenradeWernitzerWeg { get; } = new() { City = Hoppenrade, InitialName = "Wernitzer Weg".ToClassicalName() };
    public static Stop HoppenradeKnoblaucherWeg { get; } = new() { City = Hoppenrade, InitialName = "Knoblaucher Weg".ToClassicalName() };
}

file static class StopNameExtension {
    extension(string name)
    {
        public Stop.IName ToClassicalName() => new Stop.ClassicName { Name = name };
    }
}
