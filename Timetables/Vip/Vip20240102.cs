using Timetables.Models;

namespace Timetables.Vip;

public class Vip20240102 : IHistoryEntry
{
    public DateOnly EffectiveDate { get; } = new(2024, 1, 2);

    private static class Stops
    {
        private const string Berlin = "Berlin";

        public static Stop AbzweigBetriebshofViP { get; } = new()
            { Name = "Abzweig Betriebshof ViP", Positions = ["Norden", "Süden"] };

        public static Stop AbzweigNachEiche { get; } = new()
        {
            Name = "Abzweig nach Eiche",
            Positions = ["Amundsenstr.", "Maulbeerallee", "Kaiser-Friedrich-Str.", "Am Neuen Palais"]
        };

        public static Stop AbzweigNachNedlitz { get; } = new()
        {
            Name = "Abzweig nach Nedlitz",
            Positions = ["Rückertstr.", "Max-Eyth-Allee", "Lerchensteig"]
        };

        public static Stop AltNowawes { get; } = new()
            { Name = "Alt Nowawes", Positions = ["Tram Norden", "Tram Süden", "Bus Norden", "Bus Süden"] };

        public static Stop AltGolm { get; } = new() { Name = "Alt-Golm", Positions = ["Wendeschleife"] };

        public static Stop BerlinAltKladow { get; } = new()
            { Name = "Alt-Kladow", City = Berlin, Positions = ["Ri. Sacrow", "Ri. Berlin"] };

        public static Stop AlterMarktLandtag { get; } = new()
            { Name = "Alter Markt/Landtag", Positions = ["Ri. S\u00a0Hauptbahnhof", "Ri. Platz der Einheit"] };

        public static Stop AlterTornow { get; } = new()
            { Name = "Alter Tornow", Positions = ["Ri. S\u00a0Hauptbahnhof", "Ri. Hermannswerder", "Ri. Caputh"] };

        public static Stop AmAltenMörtelwerk { get; } = new() { Name = "Am Alten Mörtelwerk" };
        public static Stop AmAnger { get; } = new() { Name = "Am Anger" };
        public static Stop AmFenn { get; } = new() { Name = "Am Fenn" };
        public static Stop RoteKaserneNedlitzerStr { get; } = new() { Name = "Rote Kaserne/Nedlitzer Str." };
        public static Stop AmGrünenWeg { get; } = new() { Name = "Am Grünen Weg" };
        public static Stop AmHämphorn { get; } = new() { Name = "Am Hämphorn" };
        public static Stop AmHavelblich { get; } = new() { Name = "Am Havelblick" };
        public static Stop AmHirtengraben { get; } = new() { Name = "Am Hirtengraben" };
        public static Stop AmKüssel { get; } = new() { Name = "Am Küssel" };
        public static Stop AmMoosfenn { get; } = new() { Name = "Am Moosfenn" };

        public static Stop AmNeuenGartenGroßeWeinmeisterstr { get; } =
            new() { Name = "Am Neuen Garten/Große Weinmeisterstr." };

        public static Stop BerlinAmOmnibusbahnhof { get; } = new() { Name = "Am Omnibusbahnhof", City = Berlin };
        public static Stop AmPark { get; } = new() { Name = "Am Park" };
        public static Stop AmSchlahn { get; } = new() { Name = "Am Schlahn" };
        public static Stop AmSchragen { get; } = new() { Name = "Am Schragen" };
        public static Stop AmUpstall { get; } = new() { Name = "Am Upstall" };
        public static Stop AmUrnenfeld { get; } = new() { Name = "Am Urnenfeld" };
        public static Stop AmWald { get; } = new() { Name = "Am Wald" };
        public static Stop AmundsenstrNedlitzerStr { get; } = new() { Name = "Amundsenstr./Nedlitzer Str." };
        public static Stop AmundsenstrPotsdamerStr { get; } = new() { Name = "Amundsenstr./Potsdamer Str." };
        public static Stop AnDerWindmühle { get; } = new() { Name = "An der Windmühle" };
        public static Stop Anhaltstr { get; } = new() { Name = "Anhaltstr." };
        public static Stop AufDemKiewitt { get; } = new() { Name = "Auf dem Kiewitt" };
        public static Stop BerlinAußenweg { get; } = new() { Name = "Außenweg", City = Berlin };
        public static Stop BahnhofCharlottenhof { get; } = new() { Name = "Bahnhof Charlottenhof" };

        public static Stop BahnhofCharlottenhofGeschwisterSchollStr { get; } =
            new() { Name = "Bahnhof Charlottenhof/Geschwister-Scholl-Str." };

        public static Stop BahnhofGolm { get; } = new() { Name = "Bahnhof Golm" };
        public static Stop ScienceParkUniversität { get; } = new() { Name = "Science Park/Universität" };
        public static Stop BahnhofMarquardt { get; } = new() { Name = "Bahnhof Marquardt" };
        public static Stop BahnhofParkSanssouci { get; } = new() { Name = "Bahnhof Park Sanssouci" };
        public static Stop BahnhofPirschheide { get; } = new() { Name = "Bahnhof Pirschheide" };
        public static Stop BahnhofRehbrücke { get; } = new() { Name = "Bahnhof Rehbrücke" };
        public static Stop Bassewitz { get; } = new() { Name = "Bassewitz" };
        public static Stop Bassinplatz { get; } = new() { Name = "Bassinplatz" };
        public static Stop Baumschulenweg { get; } = new() { Name = "Baumschulenweg" };
        public static Stop BayrischesHaus { get; } = new() { Name = "Bayrisches Haus" };
        public static Stop BirkenstrAlleestr { get; } = new() { Name = "Birkenstr./Alleestr." };
        public static Stop Birkenweg { get; } = new() { Name = "Birkenweg" };
        public static Stop Bisamkiez { get; } = new() { Name = "Bisamkiez" };
        public static Stop BrandenburgerStr { get; } = new() { Name = "Brandenburger Str." };
        public static Stop Brentanoweg { get; } = new() { Name = "Brentanoweg" };

        public static Stop BerlinBrunsbüttlerDammRuhlebenerStr { get; } =
            new() { Name = "Brunsbüttler Damm/Ruhlebener Str.", City = Berlin };

        public static Stop Bullenwinkel { get; } = new() { Name = "Bullenwinkel" };
        public static Stop BurgstrKlinikum { get; } = new() { Name = "Burgstr./Klinikum" };
        public static Stop CampusFachhochschule { get; } = new() { Name = "Campus Fachhochschule" };
        public static Stop CampusJungfernsee { get; } = new() { Name = "Campus Jungfernsee" };

        public static Stop CampusJungfernseeNedlitzerStr { get; } =
            new() { Name = "Campus Jungfernsee/Nedlitzer Str." };

        public static Stop CampusUniversitätAbrahamGeigerKolleg { get; } =
            new() { Name = "Campus Universität/Abraham-Geiger-Kolleg" };

        public static Stop DeutscherWetterdienst { get; } = new() { Name = "Deutscher Wetterdienst" };
        public static Stop Dortustr { get; } = new() { Name = "Dortustr." };
        public static Stop Drachenhaus { get; } = new() { Name = "Drachenhaus" };
        public static Stop DrewitzerStrErichWeinertStr { get; } = new() { Name = "Drewitzer Str./Erich-Weinert-Str." };
        public static Stop Ecksteinweg { get; } = new() { Name = "Ecksteinweg" };

        public static Stop EduardClaudiusStrDrewitzerStr { get; } =
            new() { Name = "Eduard-Claudius-Str./Drewitzer-Str." };

        public static Stop EduardClaudiusStrHeinrichMannAllee { get; } =
            new() { Name = "Eduard-Claudius-Str./Heinrich-Mann-Allee" };

        public static Stop Ehrenpfortenbergstr { get; } = new() { Name = "Ehrenpfortenbergstr." };
        public static Stop Eichenring { get; } = new() { Name = "Eichenring" };
        public static Stop Eisbergstücke { get; } = new() { Name = "Eisbergstücke" };
        public static Stop EisenbahnbrückeMarquardt { get; } = new() { Name = "Eisenbahnbrücke Marquardt" };
        public static Stop FahrländerSee { get; } = new() { Name = "Fahrländer See" };
        public static Stop Fährweg { get; } = new() { Name = "Fährweg" };
        public static Stop Falkenhorst { get; } = new() { Name = "Falkenhorst" };
        public static Stop Feuerbachstr { get; } = new() { Name = "Feuerbachstr." };
        public static Stop Finkenweg { get; } = new() { Name = "Finkenweg" };
        public static Stop BerlinFinnenhausSiedlung { get; } = new() { Name = "Finnenhaus-Siedlung", City = Berlin };
        public static Stop Florastr { get; } = new() { Name = "Florastr." };
        public static Stop Fontanestr { get; } = new() { Name = "Fontanestr." };
        public static Stop ForsthausTemplin { get; } = new() { Name = "Forsthaus Templin" };
        public static Stop Friedenskirche { get; } = new() { Name = "Friedenskirche" };
        public static Stop Friedhöfe { get; } = new() { Name = "Friedhöfe" };
        public static Stop FriedrichGüntherPark { get; } = new() { Name = "Friedrich-Günther-Park" };
        public static Stop FriedrichWolfStr { get; } = new() { Name = "Friedrich-Wolf-Str." };
        public static Stop Gaußstr { get; } = new() { Name = "Gaußstr." };
        public static Stop Geiselberg { get; } = new() { Name = "Geiselberg" };
        public static Stop GlienickerBrücke { get; } = new() { Name = "Glienicker Brücke" };
        public static Stop Glumestr { get; } = new() { Name = "Glumestr." };
        public static Stop GolmerFichten { get; } = new() { Name = "Golmer Fichten" };
        public static Stop BerlinGößweinsteinerGang { get; } = new() { Name = "Gößweinsteiner Gang", City = Berlin };
        public static Stop HannesMeyerStr { get; } = new() { Name = "Hannes-Meyer-Str." };
        public static Stop HansAlbersStr { get; } = new() { Name = "Hans-Albers-Str." };
        public static Stop Hebbelstr { get; } = new() { Name = "Hebbelstr." };
        public static Stop Hechtsprung { get; } = new() { Name = "Hechtsprung" };
        public static Stop BerlinHeerstrWilhelmstr { get; } = new() { Name = "Heerstr./Wilhelmstr.", City = Berlin };
        public static Stop Heineberg { get; } = new() { Name = "Heineberg" };
        public static Stop HeinrichHeineWeg { get; } = new() { Name = "Heinrich-Heine-Weg" };
        public static Stop Hermannswerder { get; } = new() { Name = "Hermannswerder" };
        public static Stop HoffbauerStiftung { get; } = new() { Name = "Hoffbauer-Stiftung" };
        public static Stop Höhenstr { get; } = new() { Name = "Höhenstr." };
        public static Stop HorstwegGroßbeerenstr { get; } = new() { Name = "Horstweg/Großbeerenstr." };
        public static Stop Holzmarktstr { get; } = new() { Name = "Holzmarktstr." };
        public static Stop Hugstr { get; } = new() { Name = "Hugstr." };
        public static Stop KircheBornim { get; } = new() { Name = "Kirche Bornim" };
        public static Stop HumboldtringLottePulewkaStr { get; } = new() { Name = "Humboldtring/Lotte-Pulewka-Str." };
        public static Stop HumboldtringNuthestr { get; } = new() { Name = "Humboldtring/Nuthestr." };
        public static Stop ImBogenForststr { get; } = new() { Name = "Im Bogen/Forststr." };
        public static Stop ImBogenZeppelinstr { get; } = new() { Name = "Im Bogen/Zeppelinstr." };
        public static Stop ImWinkel { get; } = new() { Name = "Im Winkel" };
        public static Stop InstitutFürAgrartechnik { get; } = new() { Name = "Institut für Agrartechnik" };
        public static Stop JägertorJustizzentrum { get; } = new() { Name = "Jägertor/Justizzentrum" };
        public static Stop JohanBoumanPlatz { get; } = new() { Name = "Johan-Bouman-Platz" };
        public static Stop JohannesKeplerPlatz { get; } = new() { Name = "Johannes-Kepler-Platz" };
        public static Stop KaiserFriedrichStrPolizei { get; } = new() { Name = "Kaiser-Friedrich-Str./Polizei" };
        public static Stop Kaiserplatz { get; } = new() { Name = "Kaiserplatz" };
        public static Stop BerlinKarolinenhöhe { get; } = new() { Name = "Karolinenhöhe", City = Berlin};
        public static Stop BerlinKaserneHottengrund { get; } = new() { Name = "Kaserne Hottengrund", City = Berlin};
        public static Stop KastanienalleeZeppelinstr { get; } = new() { Name = "Kastanienallee/Zeppelinstr." };
        public static Stop KetzinerStrKönigsweg { get; } = new() { Name = "Ketziner Str./Königsweg" };
        public static Stop Kienheide { get; } = new() { Name = "Kienheide" };
        public static Stop Kienhorststr { get; } = new() { Name = "Kienhorststr." };
        public static Stop Kieskutenberg { get; } = new() { Name = "Kieskutenberg" };
        public static Stop KircheGolm { get; } = new() { Name = "Kirche Golm" };
        public static Stop KircheGroßGlienicke { get; } = new() { Name = "Kirche Groß Glienicke" };
        public static Stop KircheKartzow { get; } = new() { Name = "Kirche Kartzow" };
        public static Stop KircheUetz { get; } = new() { Name = "Kirche Uetz" };
        public static Stop Kirschallee { get; } = new() { Name = "Kirschallee" };
        public static Stop KläranlagePotsdamNord { get; } = new() { Name = "Kläranlage Potsdam-Nord" };
        public static Stop KleineWeinmeisterstr { get; } = new() { Name = "Kleine Weinmeisterstr." };
        public static Stop Klinikum { get; } = new() { Name = "Klinikum" };
        public static Stop Krampnitzsee { get; } = new() { Name = "Krampnitzsee" };
        public static Stop Kuhfort { get; } = new() { Name = "Kuhfort" };
        public static Stop Kuhfortdamm { get; } = new() { Name = "Kuhfortdamm" };
        public static Stop KunersdorferStr { get; } = new() { Name = "Kunersdorfer Str." };
        public static Stop Küsselstr { get; } = new() { Name = "Küsselstr." };
        public static Stop Landesumweltamt { get; } = new() { Name = "Landesumweltamt" };
        public static Stop BerlinLandschaftsfriedhofGatow { get; } = new() { Name = "Landschaftsfriedhof Gatow", City = Berlin};
        public static Stop LangeBrücke { get; } = new() { Name = "Lange Brücke" };
        public static Stop LanghansstrGroßeWeinmeisterstr { get; } = new() { Name = "Langhansstr./Große Weinmeisterstr." };
        public static Stop LerchensteigKleingartenanlage { get; } = new() { Name = "Lerchensteig/Kleingartenanlage" };
        public static Stop LindstedterChaussee { get; } = new() { Name = "Lindstedter Chaussee" };
        public static Stop LeonardoDaVinciStr { get; } = new() { Name = "Leonardo-da-Vinci-Str." };
        public static Stop Luftschiffhafen { get; } = new() { Name = "Luftschiffhafen" };
        public static Stop LuisenplatzNordParkSanssouci { get; } = new() { Name = "Luisenplatz-Nord/Park Sanssouci" };
        public static Stop LuisenplatzOstParkSanssouci { get; } = new() { Name = "Luisenplatz-Ost/Park Sanssouci" };
        public static Stop LuisenplatzSüdParkSanssouci { get; } = new() { Name = "Luisenplatz-Süd/Park Sanssouci" };
        public static Stop MagnusZellerPlatz { get; } = new() { Name = "Magnus-Zeller-Platz" };
        public static Stop Mangerstr { get; } = new() { Name = "Mangerstr." };
        public static Stop MarieJuchaczStr { get; } = new() { Name = "Marie-Juchacz-Str." };
        public static Stop Mauerstr { get; } = new() { Name = "Mauerstr." };
        public static Stop MaxBornStr { get; } = new() { Name = "Max-Born-Str." };
        public static Stop Mehlbeerenweg { get; } = new() { Name = "Mehlbeerenweg" };
        public static Stop BerlinMelanchtonplatz { get; } = new() { Name = "Melanchtonplatz", City = Berlin};
        public static Stop BerlinMetzerStr { get; } = new() { Name = "Metzer Str.", City = Berlin};
        public static Stop MichendorferChausseeFriedhof { get; } = new() { Name = "Michendorfer Chaussee/Friedhof" };
        public static Stop Naturkundemuseum { get; } = new() { Name = "Naturkundemuseum" };
        public static Stop NauenerTor { get; } = new() { Name = "Nauener Tor" };
        public static Stop Nesselgrund { get; } = new() { Name = "Nesselgrund" };
        public static Stop NeuesPalais { get; } = new() { Name = "Neues Palais" };
        public static Stop BerlinNeukladowerAllee { get; } = new() { Name = "Neukladower Allee", City = Berlin};
        public static Stop BerlinGutsparkNeukladow { get; } = new() { Name = "Gutspark Neukladow", City = Berlin};
        public static Stop Orangerie { get; } = new() { Name = "Orangerie" };
        public static Stop Paaren { get; } = new() { Name = "Paaren" };
        public static Stop BerlinParnemannweg { get; } = new() { Name = "Parnemannweg", City = Berlin};
        public static Stop Persiusstr { get; } = new() { Name = "Persiusstr." };
        public static Stop Plantagenstr { get; } = new() { Name = "Plantagenstr." };
        public static Stop Plantagenweg { get; } = new() { Name = "Plantagenweg" };
        public static Stop PlatzDerEinheitBildungsforum { get; } = new() { Name = "Platz der Einheit/Bildungsforum" };
        public static Stop PlatzDerEinheitNord { get; } = new() { Name = "Platz der Einheit/Nord" };
        public static Stop PlatzDerEinheitOst { get; } = new() { Name = "Platz der Einheit/Ost" };
        public static Stop PlatzDerEinheitWest { get; } = new() { Name = "Platz der Einheit/West" };
        public static Stop Priesterweg { get; } = new() { Name = "Priesterweg" };
        public static Stop Puschkinallee { get; } = new() { Name = "Puschkinallee" };
        public static Stop Rathaus { get; } = new() { Name = "Rathaus" };
        public static Stop RathausBabelsberg { get; } = new() { Name = "Rathaus Babelsberg" };
        public static Stop ReiterwegAlleestr { get; } = new() { Name = "Reiterweg/Alleestr." };
        public static Stop ReiterwegJägerallee { get; } = new() { Name = "Reiterweg/Jägerallee" };
        public static Stop Ribbeckstr { get; } = new() { Name = "Ribbeckstr." };
        public static Stop BerlinRitterfelddammPotsdamerChaussee { get; } = new() { Name = "Ritterfelddamm/Potsdamer Chaussee", City = Berlin};
        public static Stop BerlinRodensteinstr { get; } = new() { Name = "Rodensteinstr.", City = Berlin};
        public static Stop RobertBaberskeStr { get; } = new() { Name = "Robert-Baberske-Str." };
        public static Stop Römerschanze { get; } = new() { Name = "Römerschanze" };
        public static Stop RoteKaserne { get; } = new() { Name = "Rote Kaserne" };
        public static Stop Rotkehlchenweg { get; } = new() { Name = "Rotkehlchenweg" };
        public static Stop Rückerstr { get; } = new() { Name = "Rückerstr." };
        public static Stop Ruinenbergstr { get; } = new() { Name = "Ruinenbergstr." };
        public static Stop SBabelsbergLutherplatz { get; } = new() { Name = "S\u00a0Babelsberg/Lutherplatz" };
        public static Stop SBabelsbergSchulplatz { get; } = new() { Name = "S\u00a0Babelsberg/Schulplatz" };
        public static Stop SBabelsbergWattstr { get; } = new() { Name = "S\u00a0Babelsberg/Wattstr." };
        public static Stop SHauptbahnhof { get; } = new() { Name = "S\u00a0Hauptbahnhof" };
        public static Stop SHauptbahnhofFriedrichEngelsStr { get; } = new() { Name = "S\u00a0Hauptbahnhof/Friedrich-Engels-Str." };
        public static Stop SHauptbahnhofNordIlb { get; } = new() { Name = "S\u00a0Hauptbahnhof/Nord ILB" };
        public static Stop BerlinSuRathausSpandau { get; } = new() { Name = "S+U\u00a0Rathaus Spandau", City = Berlin};
        public static Stop SacrowParetzerKanal { get; } = new() { Name = "Sacrow-Paretzer-Kanal" };
        public static Stop SacrowerAlleeRichardWagnerStr { get; } = new() { Name = "Sacrower Allee/Richard-Wagner-Str" };
        public static Stop SacrowerSee { get; } = new() { Name = "Sacrower See" };
        public static Stop Satzkorn { get; } = new() { Name = "Satzkorn" };
        public static Stop SchiffbauergasseBerlinerStr { get; } = new() { Name = "Schiffbauergasse/Berliner Str." };
        public static Stop SchiffbauergasseUferweg { get; } = new() { Name = "Schiffbauergasse/Uferweg" };
        public static Stop Schilfhof { get; } = new() { Name = "Schilfhof" };
        public static Stop SchillerplatzSchafgraben { get; } = new() { Name = "Schillerplatz/Schafgraben" };
        public static Stop Schlaatzstr { get; } = new() { Name = "Schlaatzstr." };
        public static Stop SchlänitzseeWeg { get; } = new() { Name = "Schlänitzsee Weg" };
        public static Stop SchlegelstrPappelallee { get; } = new() { Name = "Schlegelstr./Pappelallee" };
        public static Stop SchlossCecilienhof { get; } = new() { Name = "Schloss Cecilienhof" };
        public static Stop SchlossMarquardt { get; } = new() { Name = "Schloss Marquardt" };
        public static Stop SchlossCharlottenhof { get; } = new() { Name = "Schloss Charlottenhof" };
        public static Stop SchlossSacrow { get; } = new() { Name = "Schloss Sacrow" };
        public static Stop SchlossSanssouci { get; } = new() { Name = "Schloss Sanssouci" };
        public static Stop Katharinenholzstr { get; } = new() { Name = "Katharinenholzstr." };
        public static Stop Schlossstr { get; } = new() { Name = "Schlossstr." };
        public static Stop SchlüterstrForststr { get; } = new() { Name = "Schlüterstr./Forststr." };
        public static Stop Schneiderremise { get; } = new() { Name = "Schneiderremise" };
        public static Stop SchuleFahrland { get; } = new() { Name = "Schule Fahrland" };
        public static Stop SchuleMarquardt { get; } = new() { Name = "Schule Marquardt" };
        public static Stop Sonnenlandstr { get; } = new() { Name = "Sonnenlandstr." };
        public static Stop Sporthalle { get; } = new() { Name = "Sporthalle" };
        public static Stop SportplatzBornim { get; } = new() { Name = "Sportplatz Bornim" };
        public static Stop StudentenwohnheimEiche { get; } = new() { Name = "Studentenwohnheim Eiche" };
        public static Stop Telegrafenberg { get; } = new() { Name = "Telegrafenberg" };
        public static Stop BerlinTemmeweg { get; } = new() { Name = "Temmeweg", City = Berlin};
        public static Stop TemplinerEck { get; } = new() { Name = "Templiner Eck"};
        public static Stop Thaerstr { get; } = new() { Name = "Thaerstr."};
        public static Stop TheodorFontaneStr { get; } = new() { Name = "Theodor-Fontane-Str."};
        public static Stop Tornowstr { get; } = new() { Name = "Tornowstr."};
        public static Stop Turmstr { get; } = new() { Name = "Turmstr."};
        public static Stop TüvAkademie { get; } = new() { Name = "TÜV-Akademie"};
        public static Stop Übergang { get; } = new() { Name = "Übergang"};
        public static Stop UnderDenEichen { get; } = new() { Name = "Under den Eichen"};
        public static Stop ErichArendtStr { get; } = new() { Name = "Erich-Arendt-Str."};
        public static Stop Volkspark { get; } = new() { Name = "Volkspark"};
        public static Stop WaldsiedlungGroßGlienicke { get; } = new() { Name = "Waldsiedlung Groß Glienicke"};
        public static Stop WaldstrHorstweg { get; } = new() { Name = "Waldstr./Horstweg"};
        public static Stop WasserwerkWildpark { get; } = new() { Name = "Wasserwerk Wildpark"};
        public static Stop Weinmeisterweg { get; } = new() { Name = "Weinmeisterweg"};
        public static Stop BerlinWeinmeisterhornweg { get; } = new() { Name = "Weinmeisterhornweg", City = Berlin};
        public static Stop Weinmeisterstr { get; } = new() { Name = "Weinmeisterstr."};
        public static Stop WeißerSee { get; } = new() { Name = "Weißer See"};
        public static Stop WerderscherDammForststr { get; } = new() { Name = "Werderscher Damm/Forststr."};
        public static Stop WiesenstrLottePulewkaStr { get; } = new() { Name = "Wiesenstr./Lotte-Pulewka-Str."};
        public static Stop ScienceParkWest { get; } = new() { Name = "Science Park West"};
        public static Stop WublitzstrAmBahnhof { get; } = new() { Name = "Wublitzstr./Am Bahnhof"};
        public static Stop Zedlitzberg { get; } = new() { Name = "Zedlitzberg"};
        public static Stop BerlinZiegelhof { get; } = new() { Name = "Ziegelhof", City = Berlin};
        public static Stop ZumBahnhofPirschheide { get; } = new() { Name = "Zum Bahnhof Pirschheide"};
        public static Stop ZumGroßenHerzberg { get; } = new() { Name = "Zum Großen Herzberg"};
        public static Stop ZumKahleberg { get; } = new() { Name = "Zum Kahleberg"};
        public static Stop ZumTelegrafenberg { get; } = new() { Name = "Zum Telegrafenberg"};
        public static Stop Moosgarten { get; } = new() { Name = "Moosgarten"};
        public static Stop DorfstrKönigsweg { get; } = new() { Name = "Dorfstr./Königsweg"};
        public static Stop TemplinerStr { get; } = new() { Name = "Templiner Str."};
        public static Stop Tierheim { get; } = new() { Name = "Tierheim"};
        public static Stop BerlinSteinstücken { get; } = new() { Name = "Steinstücken", City = Berlin};
        public static Stop BerlinStahnsdorferBrücke { get; } = new() { Name = "Stahnsdorfer Brücke", City = Berlin};
    }

    private static TimeSpan M0 { get; } = TimeSpan.FromMinutes(0);
    private static TimeSpan M1 { get; } = TimeSpan.FromMinutes(1);
    private static TimeSpan M2 { get; } = TimeSpan.FromMinutes(2);
    private static TimeSpan M3 { get; } = TimeSpan.FromMinutes(3);
    private static TimeSpan M4 { get; } = TimeSpan.FromMinutes(4);
    private static TimeSpan M10 { get; } = TimeSpan.FromMinutes(10);
    private static TimeSpan M20 { get; } = TimeSpan.FromMinutes(20);
    private static TimeSpan M60 { get; } = TimeSpan.FromMinutes(60);

    public Line[] Lines { get; } =
    [
        new Line
        {
            Name = "91",
            TransportationType = TransportationType.Tram,
            MainRouteIndices = [0, 3],
            OverviewRouteIndices = [0, 3],
            // NotableStops = [
            //     Stops.BahnhofPirschheide,
            //     Stops.KastanienalleeZeppelinstr,
            //     Stops.BahnhofCharlottenhof,
            //     Stops.LuisenplatzSüdParkSanssouci,
            //     Stops.PlatzDerEinheitWest,
            //     Stops.SHauptbahnhof,
            //     Stops.WaldstrHorstweg,
            //     Stops.FriedrichWolfStr,
            //     Stops.BahnhofRehbrücke
            // ],
            Routes = [
                new Line.Route
                {
                    StopPositions = [
                        Stops.BahnhofPirschheide,
                        Stops.Luftschiffhafen,
                        Stops.ImBogenZeppelinstr,
                        Stops.KastanienalleeZeppelinstr,
                        Stops.SchillerplatzSchafgraben,
                        Stops.BahnhofCharlottenhof,
                        Stops.AufDemKiewitt,
                        Stops.Feuerbachstr,
                        Stops.LuisenplatzSüdParkSanssouci,
                        Stops.Dortustr,
                        Stops.PlatzDerEinheitWest,
                        Stops.AlterMarktLandtag,
                        Stops.LangeBrücke,
                        Stops.SHauptbahnhof,
                        Stops.Friedhöfe,
                        Stops.Sporthalle,
                        Stops.KunersdorferStr,
                        Stops.WaldstrHorstweg,
                        Stops.EduardClaudiusStrHeinrichMannAllee,
                        Stops.ZumKahleberg,
                        Stops.FriedrichWolfStr,
                        Stops.AmMoosfenn,
                        Stops.BahnhofRehbrücke
                    ],
                    TimeProfiles = [
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M1, M1, M2, M1, M1, M1, M1, M1, M2, M1, M1, M3, M2, M1, M1, M1, M1, M1, M1, M1, M2]
                        },
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M1, M1, M2, M1, M1, M1, M1, M1, M3, M1, M1, M3, M2, M1, M1, M1, M1, M1, M1, M1, M2]
                        },
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M1, M1, M2, M1, M1, M1, M2, M1, M3, M1, M1, M3, M2, M1, M1, M1, M1, M1, M1, M1, M2]
                        },
                    ],
                    CommonStopIndex = 10
                },
                new Line.Route
                {
                    StopPositions = [
                        Stops.PlatzDerEinheitNord,
                        Stops.PlatzDerEinheitWest,
                        Stops.AlterMarktLandtag,
                        Stops.LangeBrücke,
                        Stops.SHauptbahnhof,
                        Stops.Friedhöfe,
                        Stops.Sporthalle,
                        Stops.KunersdorferStr,
                        Stops.WaldstrHorstweg,
                        Stops.EduardClaudiusStrHeinrichMannAllee,
                        Stops.ZumKahleberg,
                        Stops.FriedrichWolfStr,
                        Stops.AmMoosfenn,
                        Stops.BahnhofRehbrücke
                    ],
                    TimeProfiles = [
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M1, M1, M3, M2, M1, M1, M1, M1, M1, M1, M1, M2]
                        },
                    ],
                    CommonStopIndex = 0
                },
                new Line.Route
                {
                    StopPositions = [
                        Stops.BahnhofPirschheide,
                        Stops.Luftschiffhafen,
                        Stops.ImBogenZeppelinstr,
                        Stops.KastanienalleeZeppelinstr,
                        Stops.SchillerplatzSchafgraben,
                        Stops.BahnhofCharlottenhof,
                        Stops.AufDemKiewitt,
                        Stops.Feuerbachstr,
                        Stops.LuisenplatzSüdParkSanssouci,
                        Stops.Dortustr,
                        Stops.PlatzDerEinheitWest,
                        Stops.AlterMarktLandtag,
                        Stops.LangeBrücke,
                        Stops.SHauptbahnhof,
                        Stops.Friedhöfe,
                        Stops.Sporthalle,
                        Stops.KunersdorferStr,
                        Stops.WaldstrHorstweg,
                        Stops.MagnusZellerPlatz,
                        Stops.Bisamkiez
                    ],
                    TimeProfiles = [
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M1, M1, M2, M1, M1, M1, M1, M1, M2, M1, M1, M3, M2, M1, M1, M1, M2, M2]
                        },
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M1, M1, M2, M1, M1, M1, M1, M1, M3, M1, M1, M3, M2, M1, M1, M1, M2, M2]
                        },
                    ],
                    CommonStopIndex = 10
                },
                new Line.Route
                {
                    StopPositions = [
                        Stops.BahnhofRehbrücke,
                        Stops.AmMoosfenn,
                        Stops.FriedrichWolfStr,
                        Stops.ZumKahleberg,
                        Stops.EduardClaudiusStrHeinrichMannAllee,
                        Stops.WaldstrHorstweg,
                        Stops.KunersdorferStr,
                        Stops.Sporthalle,
                        Stops.Friedhöfe,
                        Stops.SHauptbahnhof,
                        Stops.LangeBrücke,
                        Stops.AlterMarktLandtag,
                        Stops.PlatzDerEinheitWest,
                        Stops.Dortustr,
                        Stops.LuisenplatzSüdParkSanssouci,
                        Stops.Feuerbachstr,
                        Stops.AufDemKiewitt,
                        Stops.BahnhofCharlottenhofGeschwisterSchollStr,
                        Stops.SchlossCharlottenhof,
                        Stops.KastanienalleeZeppelinstr,
                        Stops.ImBogenZeppelinstr,
                        Stops.Luftschiffhafen,
                        Stops.BahnhofPirschheide
                    ],
                    TimeProfiles = [
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M0, M1, M1, M1, M2, M1, M0, M1, M4, M1, M1, M3, M1, M1, M1, M1, M1, M2, M1, M2, M1, M3]
                        },
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M0, M1, M1, M1, M2, M1, M0, M1, M4, M1, M1, M3, M1, M1, M2, M1, M1, M2, M1, M2, M1, M3]
                        }
                    ],
                    CommonStopIndex = 0
                },
                new Line.Route
                {
                    StopPositions = [
                        Stops.BahnhofRehbrücke,
                        Stops.AmMoosfenn,
                        Stops.FriedrichWolfStr,
                        Stops.ZumKahleberg,
                        Stops.EduardClaudiusStrHeinrichMannAllee,
                        Stops.MagnusZellerPlatz,
                        Stops.Bisamkiez,
                    ],
                    TimeProfiles = [
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M0, M1, M1, M1, M3, M2]
                        }
                    ],
                    CommonStopIndex = 0
                },
                new Line.Route
                {
                    StopPositions = [
                        Stops.Bisamkiez,
                        Stops.MagnusZellerPlatz,
                        Stops.WaldstrHorstweg,
                        Stops.KunersdorferStr,
                        Stops.Sporthalle,
                        Stops.Friedhöfe,
                        Stops.SHauptbahnhof,
                        Stops.LangeBrücke,
                        Stops.AlterMarktLandtag,
                        Stops.PlatzDerEinheitWest,
                        Stops.Dortustr,
                        Stops.LuisenplatzSüdParkSanssouci,
                        Stops.Feuerbachstr,
                        Stops.AufDemKiewitt,
                        Stops.BahnhofCharlottenhofGeschwisterSchollStr,
                        Stops.SchlossCharlottenhof,
                        Stops.KastanienalleeZeppelinstr,
                        Stops.ImBogenZeppelinstr,
                        Stops.Luftschiffhafen,
                        Stops.BahnhofPirschheide
                    ],
                    TimeProfiles = [
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M2, M1, M0, M1, M4, M1, M1, M3, M1, M1, M1, M1, M1, M2, M1, M2, M1, M3]
                        },
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M2, M1, M0, M1, M4, M1, M1, M3, M1, M1, M2, M1, M1, M2, M1, M2, M1, M3]
                        }
                    ],
                    CommonStopIndex = 0
                },
                new Line.Route
                {
                    StopPositions = [
                        Stops.Bisamkiez,
                        Stops.MagnusZellerPlatz,
                        Stops.WaldstrHorstweg,
                        Stops.KunersdorferStr,
                        Stops.Sporthalle,
                        Stops.Friedhöfe,
                        Stops.SHauptbahnhof,
                        Stops.LangeBrücke,
                        Stops.AlterMarktLandtag,
                        Stops.PlatzDerEinheitBildungsforum,
                        Stops.PlatzDerEinheitNord
                    ],
                    TimeProfiles = [
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M2, M1, M0, M1, M4, M1, M1, M2, M1]
                        }
                    ],
                    CommonStopIndex = 0
                },
            ],
            TripsCreate = [
                ..new Line.TripCreate
                {
                    RouteIndex = 1,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Weekday | DaysOfOperation.Saturday,
                    StartTime = new TimeOnly(4, 43)
                }.AlsoEvery(M20, 2),
                new Line.TripCreate
                {
                    RouteIndex = 1,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Holiday,
                    StartTime = new TimeOnly(8, 8)
                },
                ..new Line.TripCreate
                {
                    RouteIndex = 1,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Sunday,
                    StartTime = new TimeOnly(6, 43)
                }.AlsoEvery(M20, 2),
                ..new Line.TripCreate
                {
                    RouteIndex = 0,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(5, 12)
                }.AlsoEvery(M20, 3),
                ..new Line.TripCreate
                {
                    RouteIndex = 0,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(6, 11)
                }.AlsoEvery(M20, 3),
                ..new Line.TripCreate
                {
                    RouteIndex = 0,
                    TimeProfileIndex = 2,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(7, 10)
                }.AlsoEvery(M20, 4),
                ..new Line.TripCreate
                {
                    RouteIndex = 0,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(8, 31)
                }.AlsoEvery(M20, new TimeOnly(14, 11)),
                ..new Line.TripCreate
                {
                    RouteIndex = 0,
                    TimeProfileIndex = 2,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(14, 30)
                }.AlsoEvery(M20, new TimeOnly(16, 10)),
                ..new Line.TripCreate
                {
                    RouteIndex = 0,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(16, 31)
                }.AlsoEvery(M20, new TimeOnly(19, 51)),
                ..new Line.TripCreate
                {
                    RouteIndex = 0,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(19, 58)
                }.AlsoEvery(M20, new TimeOnly(0, 58)),
                new Line.TripCreate
                {
                    RouteIndex = 2,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(17, 36)
                },
                new Line.TripCreate
                {
                    RouteIndex = 2,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(20, 28)
                },
                ..new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(5, 7)
                }.AlsoEvery(M20, 3),
                ..new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(6, 7)
                }.AlsoEvery(M20, new TimeOnly(19, 47)),
                ..new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(20, 0)
                }.AlsoEvery(M20, new TimeOnly(0, 20)),
                new Line.TripCreate
                {
                    RouteIndex = 4,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(0, 58)
                },
                ..new Line.TripCreate
                {
                    RouteIndex = 5,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Weekday | DaysOfOperation.Saturday,
                    StartTime = new TimeOnly(4, 29)
                }.AlsoEvery(M20, 2),
                new Line.TripCreate
                {
                    RouteIndex = 5,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(6, 25)
                },
                ..new Line.TripCreate
                {
                    RouteIndex = 6,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(4, 25)
                }.AlsoEvery(M20, 2),
                new Line.TripCreate
                {
                    RouteIndex = 6,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Holiday,
                    StartTime = new TimeOnly(7, 52)
                },
                ..new Line.TripCreate
                {
                    RouteIndex = 0,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Saturday,
                    StartTime = new TimeOnly(5, 12)
                }.AlsoEvery(M20, new TimeOnly(6, 52)),
                ..new Line.TripCreate
                {
                    RouteIndex = 0,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Weekend,
                    StartTime = new TimeOnly(7, 12)
                }.AlsoEvery(M20, new TimeOnly(9, 52)),
                ..new Line.TripCreate
                {
                    RouteIndex = 0,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Weekend,
                    StartTime = new TimeOnly(10, 11)
                }.AlsoEvery(M20, new TimeOnly(19, 51)),
                ..new Line.TripCreate
                {
                    RouteIndex = 6,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Saturday,
                    StartTime = new TimeOnly(4, 26)
                }.AlsoEvery(M20, 2),
                ..new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Saturday,
                    StartTime = new TimeOnly(5, 7)
                }.AlsoEvery(M20, new TimeOnly(6, 47)),
                ..new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Weekend,
                    StartTime = new TimeOnly(7, 7)
                }.AlsoEvery(M20, new TimeOnly(10, 7)),
                ..new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Weekend,
                    StartTime = new TimeOnly(10, 27)
                }.AlsoEvery(M20, new TimeOnly(19, 47)),
                ..new Line.TripCreate
                {
                    RouteIndex = 6,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Sunday,
                    StartTime = new TimeOnly(6, 26)
                }.AlsoEvery(M20, 2),
                ..new Line.TripCreate
                {
                    RouteIndex = 5,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Sunday,
                    StartTime = new TimeOnly(6, 29)
                }.AlsoEvery(M20, 2),
            ]
        },
        new Line
        {
            Name = "92",
            TransportationType = TransportationType.Tram,
            MainRouteIndices = [0, 1, 2, 3, 6, 7, 8, 9],
            OverviewRouteIndices = [0, 6],
            Routes = [
                new Line.Route
                {
                    StopPositions = [
                        Stops.Kirschallee,
                        Stops.JohanBoumanPlatz,
                        Stops.HannesMeyerStr,
                        Stops.CampusFachhochschule,
                        Stops.AmSchragen,
                        Stops.Puschkinallee,
                        Stops.ReiterwegAlleestr,
                        Stops.Rathaus,
                        Stops.NauenerTor,
                        Stops.BrandenburgerStr,
                        Stops.PlatzDerEinheitWest,
                        Stops.AlterMarktLandtag,
                        Stops.LangeBrücke,
                        Stops.SHauptbahnhof,
                        Stops.Friedhöfe,
                        Stops.Sporthalle,
                        Stops.KunersdorferStr,
                        Stops.WaldstrHorstweg,
                        Stops.MagnusZellerPlatz,
                        Stops.Bisamkiez,
                        Stops.AbzweigBetriebshofViP,
                        Stops.Turmstr,
                        Stops.JohannesKeplerPlatz,
                        Stops.MaxBornStr,
                        Stops.Gaußstr,
                        Stops.HansAlbersStr,
                        Stops.RobertBaberskeStr,
                        Stops.Priesterweg,
                        Stops.AmHirtengraben,
                        Stops.MarieJuchaczStr
                    ],
                    TimeProfiles = [
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M1, M3, M1, M1, M1, M1, M1, M1, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2, M2, M1, M2, M1, M2, M1, M1, M1, M1, M2]
                        },
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M1, M2, M1, M1, M1, M1, M1, M1, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2, M2, M1, M2, M1, M1, M1, M1, M1, M1, M2]
                        },
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M1, M2, M1, M1, M1, M1, M1, M1, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2, M2, M1, M2, M1, M2, M1, M1, M1, M1, M2]
                        },
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M0, M2, M1, M1, M1, M1, M1, M2, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2, M1, M1, M2, M1, M1, M1, M1, M1, M1, M2]
                        },
                    ],
                    CommonStopIndex = 4,
                },
                new Line.Route
                {
                    StopPositions = [
                        Stops.Kirschallee,
                        Stops.JohanBoumanPlatz,
                        Stops.HannesMeyerStr,
                        Stops.CampusFachhochschule,
                        Stops.AmSchragen,
                        Stops.Puschkinallee,
                        Stops.ReiterwegAlleestr,
                        Stops.Rathaus,
                        Stops.NauenerTor,
                        Stops.BrandenburgerStr,
                        Stops.PlatzDerEinheitWest,
                        Stops.AlterMarktLandtag,
                        Stops.LangeBrücke,
                        Stops.SHauptbahnhof,
                        Stops.Friedhöfe,
                        Stops.Sporthalle,
                        Stops.KunersdorferStr,
                        Stops.WaldstrHorstweg,
                        Stops.MagnusZellerPlatz,
                        Stops.Bisamkiez,
                        Stops.AbzweigBetriebshofViP,
                        Stops.Turmstr,
                        Stops.JohannesKeplerPlatz,
                        Stops.MaxBornStr,
                        Stops.Gaußstr
                    ],
                    TimeProfiles = [
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M1, M3, M1, M1, M1, M1, M1, M1, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2, M2, M1, M2, M1, M2]
                        },
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M1, M2, M1, M1, M1, M1, M1, M1, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2, M2, M1, M2, M1, M1]
                        },
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M1, M2, M1, M1, M1, M1, M1, M1, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2, M2, M1, M2, M1, M2]
                        },
                    ],
                    CommonStopIndex = 4,
                },
                new Line.Route
                {
                    StopPositions = [
                        Stops.Kirschallee,
                        Stops.JohanBoumanPlatz,
                        Stops.HannesMeyerStr,
                        Stops.CampusFachhochschule,
                        Stops.AmSchragen,
                        Stops.Puschkinallee,
                        Stops.ReiterwegAlleestr,
                        Stops.Rathaus,
                        Stops.NauenerTor,
                        Stops.BrandenburgerStr,
                        Stops.PlatzDerEinheitWest,
                        Stops.AlterMarktLandtag,
                        Stops.LangeBrücke,
                        Stops.SHauptbahnhof,
                        Stops.Friedhöfe,
                        Stops.Sporthalle,
                        Stops.KunersdorferStr,
                        Stops.WaldstrHorstweg,
                        Stops.MagnusZellerPlatz,
                        Stops.Bisamkiez,
                    ],
                    TimeProfiles = [
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M1, M3, M1, M1, M1, M1, M1, M1, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2]
                        },
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M1, M2, M1, M1, M1, M1, M1, M1, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2]
                        },
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M0, M2, M1, M1, M1, M1, M1, M2, M2, M1, M1, M3, M2, M1, M1, M1, M1, M2]
                        },
                    ],
                    CommonStopIndex = 4,
                },
                new Line.Route
                {
                    StopPositions = [
                        Stops.Kirschallee,
                        Stops.JohanBoumanPlatz,
                        Stops.HannesMeyerStr,
                        Stops.CampusFachhochschule,
                        Stops.AmSchragen,
                        Stops.Puschkinallee,
                        Stops.ReiterwegAlleestr,
                        Stops.Rathaus,
                        Stops.NauenerTor,
                        Stops.BrandenburgerStr,
                        Stops.PlatzDerEinheitWest,
                        Stops.AlterMarktLandtag,
                        Stops.LangeBrücke,
                        Stops.SHauptbahnhofFriedrichEngelsStr
                    ],
                    TimeProfiles = [
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M1, M3, M1, M1, M1, M1, M1, M1, M2, M1, M1, M4]
                        },
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M1, M2, M1, M1, M1, M1, M1, M1, M2, M1, M1, M4]
                        },
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M0, M2, M1, M1, M1, M1, M1, M2, M2, M1, M1, M4]
                        },
                    ],
                    CommonStopIndex = 4,
                },
                new Line.Route
                {
                    StopPositions = [
                        Stops.Kirschallee,
                        Stops.JohanBoumanPlatz,
                        Stops.HannesMeyerStr,
                        Stops.CampusFachhochschule,
                        Stops.AmSchragen,
                        Stops.Puschkinallee,
                        Stops.ReiterwegAlleestr,
                        Stops.Rathaus,
                        Stops.NauenerTor,
                        Stops.BrandenburgerStr,
                        Stops.PlatzDerEinheitWest,
                        Stops.PlatzDerEinheitBildungsforum
                    ],
                    TimeProfiles = [
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M1, M2, M1, M1, M1, M1, M1, M1, M2, M1]
                        },
                    ],
                    CommonStopIndex = 4,
                },
                new Line.Route
                {
                    StopPositions = [
                        Stops.AbzweigBetriebshofViP,
                        Stops.Turmstr,
                        Stops.JohannesKeplerPlatz,
                        Stops.MaxBornStr,
                        Stops.Gaußstr
                    ],
                    TimeProfiles = [
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M2, M1, M2]
                        },
                    ],
                    CommonStopIndex = 0,
                },
                new Line.Route
                {
                    StopPositions = [
                        Stops.MarieJuchaczStr,
                        Stops.AmHirtengraben,
                        Stops.Priesterweg,
                        Stops.RobertBaberskeStr,
                        Stops.HansAlbersStr,
                        Stops.Gaußstr,
                        Stops.MaxBornStr,
                        Stops.JohannesKeplerPlatz,
                        Stops.Turmstr,
                        Stops.AbzweigBetriebshofViP,
                        Stops.Bisamkiez,
                        Stops.MagnusZellerPlatz,
                        Stops.WaldstrHorstweg,
                        Stops.KunersdorferStr,
                        Stops.Sporthalle,
                        Stops.Friedhöfe,
                        Stops.SHauptbahnhof,
                        Stops.LangeBrücke,
                        Stops.AlterMarktLandtag,
                        Stops.PlatzDerEinheitWest,
                        Stops.BrandenburgerStr,
                        Stops.NauenerTor,
                        Stops.Rathaus,
                        Stops.ReiterwegAlleestr,
                        Stops.Puschkinallee,
                        Stops.AmSchragen,
                        Stops.CampusFachhochschule,
                        Stops.HannesMeyerStr,
                        Stops.JohanBoumanPlatz,
                        Stops.Kirschallee
                    ],
                    TimeProfiles = [
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M0, M1, M1, M1, M2, M1, M2, M0, M2, M2, M1, M2, M1, M0, M1, M4, M1, M1, M3, M1, M1, M1, M0, M2, M2, M1, M2, M1, M1]
                        }
                    ],
                    CommonStopIndex = 0
                },
                new Line.Route
                {
                    StopPositions = [
                        Stops.Gaußstr,
                        Stops.MaxBornStr,
                        Stops.JohannesKeplerPlatz,
                        Stops.Turmstr,
                        Stops.AbzweigBetriebshofViP,
                        Stops.Bisamkiez,
                        Stops.MagnusZellerPlatz,
                        Stops.WaldstrHorstweg,
                        Stops.KunersdorferStr,
                        Stops.Sporthalle,
                        Stops.Friedhöfe,
                        Stops.SHauptbahnhof,
                        Stops.LangeBrücke,
                        Stops.AlterMarktLandtag,
                        Stops.PlatzDerEinheitWest,
                        Stops.BrandenburgerStr,
                        Stops.NauenerTor,
                        Stops.Rathaus,
                        Stops.ReiterwegAlleestr,
                        Stops.Puschkinallee,
                        Stops.AmSchragen,
                        Stops.CampusFachhochschule,
                        Stops.HannesMeyerStr,
                        Stops.JohanBoumanPlatz,
                        Stops.Kirschallee
                    ],
                    TimeProfiles = [
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M2, M0, M2, M2, M1, M2, M1, M0, M1, M4, M1, M1, M3, M1, M1, M1, M0, M2, M2, M1, M2, M1, M1]
                        }
                    ],
                    CommonStopIndex = 0
                },
                new Line.Route
                {
                    StopPositions = [
                        Stops.Bisamkiez,
                        Stops.MagnusZellerPlatz,
                        Stops.WaldstrHorstweg,
                        Stops.KunersdorferStr,
                        Stops.Sporthalle,
                        Stops.Friedhöfe,
                        Stops.SHauptbahnhof,
                        Stops.LangeBrücke,
                        Stops.AlterMarktLandtag,
                        Stops.PlatzDerEinheitWest,
                        Stops.BrandenburgerStr,
                        Stops.NauenerTor,
                        Stops.Rathaus,
                        Stops.ReiterwegAlleestr,
                        Stops.Puschkinallee,
                        Stops.AmSchragen,
                        Stops.CampusFachhochschule,
                        Stops.HannesMeyerStr,
                        Stops.JohanBoumanPlatz,
                        Stops.Kirschallee
                    ],
                    TimeProfiles = [
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M2, M1, M0, M1, M4, M1, M1, M3, M1, M1, M1, M0, M2, M2, M1, M2, M1, M1]
                        }
                    ],
                    CommonStopIndex = 0
                },
                new Line.Route
                {
                    StopPositions = [
                        Stops.SHauptbahnhof,
                        Stops.LangeBrücke,
                        Stops.AlterMarktLandtag,
                        Stops.PlatzDerEinheitWest,
                        Stops.BrandenburgerStr,
                        Stops.NauenerTor,
                        Stops.Rathaus,
                        Stops.ReiterwegAlleestr,
                        Stops.Puschkinallee,
                        Stops.AmSchragen,
                        Stops.CampusFachhochschule,
                        Stops.HannesMeyerStr,
                        Stops.JohanBoumanPlatz,
                        Stops.Kirschallee
                    ],
                    TimeProfiles = [
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M1, M3, M1, M1, M1, M0, M2, M2, M1, M2, M1, M1]
                        }
                    ],
                    CommonStopIndex = 0
                },
                new Line.Route
                {
                    StopPositions = [
                        Stops.PlatzDerEinheitNord,
                        Stops.BrandenburgerStr,
                        Stops.NauenerTor,
                        Stops.Rathaus,
                        Stops.ReiterwegAlleestr,
                        Stops.Puschkinallee,
                        Stops.AmSchragen,
                        Stops.CampusFachhochschule,
                        Stops.HannesMeyerStr,
                        Stops.JohanBoumanPlatz,
                        Stops.Kirschallee
                    ],
                    TimeProfiles = [
                        new Line.Route.TimeProfile
                        {
                            StopDistances = [M1, M1, M1, M0, M2, M2, M1, M2, M1, M1]
                        }
                    ],
                    CommonStopIndex = 0
                }
            ],
            TripsCreate = [
                ..new Line.TripCreate
                {
                    RouteIndex = 0,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(7, 9)
                }.AlsoEvery(M60, 2),
                new Line.TripCreate
                {
                    RouteIndex = 1,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(5, 50)
                },
                ..new Line.TripCreate
                {
                    RouteIndex = 1,
                    TimeProfileIndex = 2,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(6, 10)
                }.AlsoEvery(M20, 2),
                ..new Line.TripCreate
                {
                    RouteIndex = 1,
                    TimeProfileIndex = 2,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(6, 40)
                }.AlsoEvery(M10, 2),
                new Line.TripCreate
                {
                    RouteIndex = 1,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(6, 59)
                },
                ..new Line.TripCreate
                {
                    RouteIndex = 1,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(7, 29)
                }.AlsoEvery(M20, 2),
                ..new Line.TripCreate
                {
                    RouteIndex = 1,
                    TimeProfileIndex = 2,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(12, 50)
                }.AlsoEvery(M20, new TimeOnly(14, 10)),
                ..new Line.TripCreate
                {
                    RouteIndex = 1,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(14, 29)
                }.AlsoEvery(M10, 2),
                ..new Line.TripCreate
                {
                    RouteIndex = 1,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(14, 49)
                }.AlsoEvery(M20, new TimeOnly(16, 9)),
                ..new Line.TripCreate
                {
                    RouteIndex = 1,
                    TimeProfileIndex = 2,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(16, 30)
                }.AlsoEvery(M20, 2),
                ..new Line.TripCreate
                {
                    RouteIndex = 2,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(7, 19)
                }.AlsoEvery(M20, new TimeOnly(8, 19)),
                ..new Line.TripCreate
                {
                    RouteIndex = 2,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(8, 30)
                }.AlsoEvery(M20, new TimeOnly(12, 30)),
                ..new Line.TripCreate
                {
                    RouteIndex = 2,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(13, 0)
                }.AlsoEvery(M20, new TimeOnly(14, 20)),
                ..new Line.TripCreate
                {
                    RouteIndex = 2,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(14, 59)
                }.AlsoEvery(M20, new TimeOnly(16, 19)),
                new Line.TripCreate
                {
                    RouteIndex = 2,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(16, 40)
                },
                ..new Line.TripCreate
                {
                    RouteIndex = 2,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(17, 0)
                }.AlsoEvery(M10, new TimeOnly(17, 50)),
                new Line.TripCreate
                {
                    RouteIndex = 2,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(18, 10)
                },
                ..new Line.TripCreate
                {
                    RouteIndex = 2,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(18, 40)
                }.AlsoEvery(M20, 2),
                ..new Line.TripCreate
                {
                    RouteIndex = 2,
                    TimeProfileIndex = 2,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(0, 31)
                }.AlsoEvery(M20, 3),
                ..new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(4, 50)
                }.AlsoEvery(M20, 3),
                ..new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(8, 40)
                }.AlsoEvery(M20, new TimeOnly(12, 40)),
                new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(18, 0)
                },
                new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(18, 20)
                },
                new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(18, 30)
                },
                new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(18, 50)
                },
                new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(19, 10)
                },
                ..new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 2,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(19, 31)
                }.AlsoEvery(M20, new TimeOnly(20, 11)),
                ..new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 2,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(20, 31)
                }.AlsoEvery(M20, new TimeOnly(0, 11)),
                new Line.TripCreate
                {
                    RouteIndex = 4,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(12, 47)
                },
                new Line.TripCreate
                {
                    RouteIndex = 5,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(6, 47)
                },
                ..new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Holiday,
                    StartTime = new TimeOnly(4, 50)
                }.AlsoEvery(M20, new TimeOnly(6, 50)),
                new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Holiday,
                    StartTime = new TimeOnly(6, 40)
                },
                ..new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Holiday,
                    StartTime = new TimeOnly(6, 59)
                }.AlsoEvery(M10, new TimeOnly(7, 39)),
                ..new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Holiday,
                    StartTime = new TimeOnly(7, 59)
                }.AlsoEvery(M20, 2),
                ..new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Holiday,
                    StartTime = new TimeOnly(8, 40)
                }.AlsoEvery(M20, new TimeOnly(14, 20)),
                ..new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Holiday,
                    StartTime = new TimeOnly(14, 39)
                }.AlsoEvery(M20, new TimeOnly(16, 19)),
                ..new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Holiday,
                    StartTime = new TimeOnly(16, 40)
                }.AlsoEvery(M20, new TimeOnly(17, 40)),
                ..new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Holiday,
                    StartTime = new TimeOnly(18, 0)
                }.AlsoEvery(M10, new TimeOnly(18, 50)),
                ..new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Holiday,
                    StartTime = new TimeOnly(19, 10)
                }.AlsoEvery(M10, 2),
                ..new Line.TripCreate
                {
                    RouteIndex = 2,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Holiday,
                    StartTime = new TimeOnly(7, 49)
                }.AlsoEvery(M20, 2),
                ..new Line.TripCreate
                {
                    RouteIndex = 2,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Holiday,
                    StartTime = new TimeOnly(8, 30)
                }.AlsoEvery(M20, new TimeOnly(14, 10)),
                ..new Line.TripCreate
                {
                    RouteIndex = 2,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Holiday,
                    StartTime = new TimeOnly(14, 29)
                }.AlsoEvery(M20, new TimeOnly(16, 09)),
                ..new Line.TripCreate
                {
                    RouteIndex = 2,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Holiday,
                    StartTime = new TimeOnly(16, 30)
                }.AlsoEvery(M20, new TimeOnly(17, 50)),
                new Line.TripCreate
                {
                    RouteIndex = 2,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Holiday,
                    StartTime = new TimeOnly(19, 0)
                },
                ..new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Saturday,
                    StartTime = new TimeOnly(4, 55)
                }.AlsoEvery(M20, new TimeOnly(6, 55)),
                ..new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Weekend,
                    StartTime = new TimeOnly(7, 15)
                }.AlsoEvery(M20, new TimeOnly(7, 55)),
                ..new Line.TripCreate
                {
                    RouteIndex = 0,
                    TimeProfileIndex = 1,
                    DaysOfOperation = DaysOfOperation.Weekend,
                    StartTime = new TimeOnly(8, 15)
                }.AlsoEvery(M20, new TimeOnly(9, 55)),
                ..new Line.TripCreate
                {
                    RouteIndex = 0,
                    TimeProfileIndex = 2,
                    DaysOfOperation = DaysOfOperation.Weekend,
                    StartTime = new TimeOnly(10, 15)
                }.AlsoEvery(M20, new TimeOnly(19, 35)),
                new Line.TripCreate
                {
                    RouteIndex = 3,
                    TimeProfileIndex = 2,
                    DaysOfOperation = DaysOfOperation.Weekend,
                    StartTime = new TimeOnly(19, 53)
                },
                ..new Line.TripCreate
                {
                    RouteIndex = 0,
                    TimeProfileIndex = 3,
                    DaysOfOperation = DaysOfOperation.Weekend,
                    StartTime = new TimeOnly(20, 8)
                }.AlsoEvery(M20, 2),
                new Line.TripCreate
                {
                    RouteIndex = 6,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(7, 56)
                },
                new Line.TripCreate
                {
                    RouteIndex = 6,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(13, 16)
                },
                new Line.TripCreate
                {
                    RouteIndex = 6,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(7, 56)
                },
                ..new Line.TripCreate
                {
                    RouteIndex = 6,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Weekend,
                    StartTime = new TimeOnly(8, 51)
                }.AlsoEvery(M20, new TimeOnly(19, 11)),
                ..new Line.TripCreate
                {
                    RouteIndex = 6,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Weekend,
                    StartTime = new TimeOnly(19, 39)
                }.AlsoEvery(M20, 3),
                ..new Line.TripCreate
                {
                    RouteIndex = 7,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(6, 41)
                }.AlsoEvery(M10, new TimeOnly(7, 41)),
                ..new Line.TripCreate
                {
                    RouteIndex = 7,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(8, 21)
                }.AlsoEvery(M20, new TimeOnly(8, 41)),
                ..new Line.TripCreate
                {
                    RouteIndex = 7,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(13, 41)
                }.AlsoEvery(M20, new TimeOnly(17, 41)),
                new Line.TripCreate
                {
                    RouteIndex = 7,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(15, 11)
                },
                ..new Line.TripCreate
                {
                    RouteIndex = 8,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(4, 8)
                }.AlsoEvery(M20, 3),
                ..new Line.TripCreate
                {
                    RouteIndex = 8,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(6, 8)
                }.AlsoEvery(M10, new TimeOnly(6, 38)),
                ..new Line.TripCreate
                {
                    RouteIndex = 8,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(7, 58)
                }.AlsoEvery(M20, 3),
                ..new Line.TripCreate
                {
                    RouteIndex = 8,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(9, 8)
                }.AlsoEvery(M20, new TimeOnly(13, 8)),
                ..new Line.TripCreate
                {
                    RouteIndex = 8,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(13, 18)
                }.AlsoEvery(M20, new TimeOnly(14, 58)),
                ..new Line.TripCreate
                {
                    RouteIndex = 8,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(15, 38)
                }.AlsoEvery(M20, new TimeOnly(17, 58)),
                new Line.TripCreate
                {
                    RouteIndex = 8,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(18, 8)
                },
                new Line.TripCreate
                {
                    RouteIndex = 8,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(18, 28)
                },
                ..new Line.TripCreate
                {
                    RouteIndex = 8,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Holiday,
                    StartTime = new TimeOnly(5, 58)
                }.AlsoEvery(M20, new TimeOnly(6, 38)),
                ..new Line.TripCreate
                {
                    RouteIndex = 8,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Holiday,
                    StartTime = new TimeOnly(8, 8)
                }.AlsoEvery(M20, new TimeOnly(18, 8)),
                ..new Line.TripCreate
                {
                    RouteIndex = 8,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Saturday,
                    StartTime = new TimeOnly(4, 23)
                }.AlsoEvery(M20, new TimeOnly(5, 23)),
                new Line.TripCreate
                {
                    RouteIndex = 8,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Saturday,
                    StartTime = new TimeOnly(5, 26)
                },
                new Line.TripCreate
                {
                    RouteIndex = 8,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Saturday,
                    StartTime = new TimeOnly(8, 23)
                },
                ..new Line.TripCreate
                {
                    RouteIndex = 8,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Sunday,
                    StartTime = new TimeOnly(6, 43)
                }.AlsoEvery(M20, 2),
                new Line.TripCreate
                {
                    RouteIndex = 8,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Sunday,
                    StartTime = new TimeOnly(7, 26)
                },
                new Line.TripCreate
                {
                    RouteIndex = 8,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Weekend,
                    StartTime = new TimeOnly(8, 43)
                },
                new Line.TripCreate
                {
                    RouteIndex = 8,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Weekend,
                    StartTime = new TimeOnly(19, 37)
                },
                ..new Line.TripCreate
                {
                    RouteIndex = 9,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(4, 57)
                }.AlsoEvery(M20, new TimeOnly(6, 17)),
                ..new Line.TripCreate
                {
                    RouteIndex = 9,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(9, 7)
                }.AlsoEvery(M20, new TimeOnly(13, 7)),
                ..new Line.TripCreate
                {
                    RouteIndex = 9,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(18, 27)
                }.AlsoEvery(M20, 2),
                ..new Line.TripCreate
                {
                    RouteIndex = 9,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Weekday,
                    StartTime = new TimeOnly(18, 57)
                }.AlsoEvery(M20, new TimeOnly(20, 37)),
                ..new Line.TripCreate
                {
                    RouteIndex = 9,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Daily,
                    StartTime = new TimeOnly(20, 57)
                }.AlsoEvery(M20, new TimeOnly(0, 37)),
                ..new Line.TripCreate
                {
                    RouteIndex = 9,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Holiday,
                    StartTime = new TimeOnly(5, 17)
                }.AlsoEvery(M20, new TimeOnly(7, 57)),
                ..new Line.TripCreate
                {
                    RouteIndex = 9,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Holiday,
                    StartTime = new TimeOnly(7, 7)
                }.AlsoEvery(M20, new TimeOnly(18, 7)),
                ..new Line.TripCreate
                {
                    RouteIndex = 9,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Holiday,
                    StartTime = new TimeOnly(18, 27)
                }.AlsoEvery(M10, new TimeOnly(18, 47)),
                ..new Line.TripCreate
                {
                    RouteIndex = 9,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Saturday,
                    StartTime = new TimeOnly(5, 52)
                }.AlsoEvery(M20, new TimeOnly(7, 12)),
                ..new Line.TripCreate
                {
                    RouteIndex = 9,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Weekend,
                    StartTime = new TimeOnly(7, 32)
                }.AlsoEvery(M20, new TimeOnly(8, 12)),
                new Line.TripCreate
                {
                    RouteIndex = 9,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.Sunday,
                    StartTime = new TimeOnly(8, 32)
                },
                new Line.TripCreate
                {
                    RouteIndex = 10,
                    TimeProfileIndex = 0,
                    DaysOfOperation = DaysOfOperation.School,
                    StartTime = new TimeOnly(8, 59)
                },
            ]
        }
    ];

    public static IHistoryEntry Entry { get; } = new Vip20240102();
}
