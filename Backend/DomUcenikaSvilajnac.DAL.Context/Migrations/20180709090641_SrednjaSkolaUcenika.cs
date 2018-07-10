using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class SrednjaSkolaUcenika : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UpisanaSkolaId",
                table: "Ucenici",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ucenici_UpisanaSkolaId",
                table: "Ucenici",
                column: "UpisanaSkolaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ucenici_SrednjeSkole_UpisanaSkolaId",
                table: "Ucenici",
                column: "UpisanaSkolaId",
                principalTable: "SrednjeSkole",
                principalColumn: "Id");
            //   onDelete: ReferentialAction.Cascade);

            migrationBuilder.Sql("insert into SrednjeSkole (NazivSrednjeSkole, OpstinaId) values " +
                 "('Tehnicka škola - Ada', (select Id from Opstine where NazivOpstine = 'Ada'))," +
                 "('Srednja škola - \"Sveti Trifun\"', (select Id from Opstine where NazivOpstine = 'Aleksandrovac'))," +
               "('Poljoprivredna škola - \"Šumatovac\"', (select Id from Opstine where NazivOpstine = 'Aleksinac'))," +
               "('Tehnicka škola - \"Prota Stevan Dimitrijevic\"', (select Id from Opstine where NazivOpstine = 'Aleksinac'))," +
               "('Aleksinacka Gimanzija', (select Id from Opstine where NazivOpstine = 'Aleksinac'))," +
               "('Gimnazija - \"Nikola Tesla\"', (select Id from Opstine where NazivOpstine = 'Apatin'))," +
               "('Tehnicka škola - Apatin', (select Id from Opstine where NazivOpstine = 'Apatin'))," +
               "('Srednja gradevinska i drvopreradivacka strucna škola - Apatin', (select Id from Opstine where NazivOpstine = 'Apatin'))," +
               "('Ekonomsko – ugostiteljska škola - \"Slobodan Minic\"', (select Id from Opstine where NazivOpstine = 'Aranđelovac'))," +
               "('Ekonomsko ugostiteljska škola \"Slobodan Minic\"', (select Id from Opstine where NazivOpstine = 'Aranđelovac'))," +
               "('Gimnazija \"Miloš Savkovic\"', (select Id from Opstine where NazivOpstine = 'Aranđelovac'))," +
               "('Tehnicka škola \"Mileta Nikolic\"', (select Id from Opstine where NazivOpstine = 'Aranđelovac'))," +
               "('Srednja škola \"Sveti Ahilije\"', (select Id from Opstine where NazivOpstine = 'Arilje'))," +
               "('Tehnicka škola - Babušnica', (select Id from Opstine where NazivOpstine = 'Babušnica'))," +
               "('Gimnazija \"Vuk Karadžic\"', (select Id from Opstine where NazivOpstine = 'Babušnica'))," +
               "('Poljoprivredna škola - Bac', (select Id from Opstine where NazivOpstine = 'Bač'))," +
               "('Srednja strucna škola \"Dr Radivoj Uvalic\"', (select Id from Opstine where NazivOpstine = 'Bačka Palanka'))," +
               "('Gimnazija \"20. oktobar\"', (select Id from Opstine where NazivOpstine = 'Bačka Palanka'))," +
               "('Tehnicka škola \"9. maj\"', (select Id from Opstine where NazivOpstine = 'Bačka Palanka'))," +
               "('Srednja tehnicka škola \"Šinkovic Jožef\"', (select Id from Opstine where NazivOpstine = 'Bačka Topola'))," +
               "('Poljoprivredna škola - Backa Topola', (select Id from Opstine where NazivOpstine = 'Bačka Topola'))," +
               "('Gimnazija i ekonomska škola \"Dositej Obradovic\"', (select Id from Opstine where NazivOpstine = 'Bačka Topola'))," +
               "('Gimnazija \"Jan Kolar\"', (select Id from Opstine where NazivOpstine = 'Bački Petrovac'))," +
               "('Tehnicka škola - Bajina Bašta', (select Id from Opstine where NazivOpstine = 'Bajina Bašta'))," +
               "('Gimnazija \"Josif Pancic\"', (select Id from Opstine where NazivOpstine = 'Bajina Bašta'))," +
               "('Srednja škola \"Nikola Tesla\"', (select Id from Opstine where NazivOpstine = 'Batočina'))," +
               "('Tehnicka škola - Becej', (select Id from Opstine where NazivOpstine = 'Bečej'))," +
               "('Gimnazija - Becej', (select Id from Opstine where NazivOpstine = 'Bečej'))," +
               "('Ekonomsko - trgovinska škola - Becej', (select Id from Opstine where NazivOpstine = 'Bečej'))," +
               "('Škola za osnovno i srednje obrazovanje \"Bratstvo\"', (select Id from Opstine where NazivOpstine = 'Bečej'))," +
               "('Belocrkvanska gimnazija i ekonomska škola', (select Id from Opstine where NazivOpstine = 'Bela Crkva'))," +
               "('Tehnicka škola \"Sava Muncan\"', (select Id from Opstine where NazivOpstine = 'Bela Crkva'))," +
               "('Srednja škola \"Niketa Remezijanski\"', (select Id from Opstine where NazivOpstine = 'Bela Palanka'))," +
               "('Srednja škola - Barajevo', (select Id from Opstine where NazivOpstine = 'Barajevo'))," +
               "('XIII beogradska gimnazija', (select Id from Opstine where NazivOpstine = 'Čukarica'))," +
               "('Hemijsko-prehrambena tehnološka škola', (select Id from Opstine where NazivOpstine = 'Čukarica'))," +
               "('Tehnicka škola (Železnik)', (select Id from Opstine where NazivOpstine = 'Čukarica'))," +
               "('Muzicka škola \"Vatroslav Lisinski\"', (select Id from Opstine where NazivOpstine = 'Čukarica'))," +
               "('Škola za osnovno i srednje obrazovanje \"Sveti Sava\"', (select Id from Opstine where NazivOpstine = 'Čukarica'))," +
               "('Srednja škola - Grocka', (select Id from Opstine where NazivOpstine = 'Grocka'))," +
               "('Muzicka škola \"Marko Tajcevic\"', (select Id from Opstine where NazivOpstine = 'Lazarevac'))," +
               "('Tehnicka škola \"Kolubara\"', (select Id from Opstine where NazivOpstine = 'Lazarevac'))," +
               "('Gimnazija - Lazarevac', (select Id from Opstine where NazivOpstine = 'Lazarevac'))," +
               "('Tehnicka škola - Mladenovac', (select Id from Opstine where NazivOpstine = 'Mladenovac'))," +
               "('Gimnazija - Mladenovac', (select Id from Opstine where NazivOpstine = 'Mladenovac'))," +
               "('Tehnicka škola - Novi Beograd', (select Id from Opstine where NazivOpstine = 'Novi Beograd'))," +
               "('Tehnicka škola \"Zmaj\"', (select Id from Opstine where NazivOpstine = 'Novi Beograd'))," +
               "('Srednja turisticka škola - Novi Beograd', (select Id from Opstine where NazivOpstine = 'Novi Beograd'))," +
               "('IX gimnazija \"Mihailo Petrovic Alas\"', (select Id from Opstine where NazivOpstine = 'Novi Beograd'))," +
               "('X gimnazija \"Mihajlo Pupin\"', (select Id from Opstine where NazivOpstine = 'Novi Beograd'))," +
               "('Graficka škola - Novi Beograd', (select Id from Opstine where NazivOpstine = 'Novi Beograd'))," +
               "('Tehnicka škola - Obrenovac', (select Id from Opstine where NazivOpstine = 'Obrenovac'))," +
               "('Poljoprivredno-hemijska škola - Obrenovac', (select Id from Opstine where NazivOpstine = 'Obrenovac'))," +
               "('Gimnazija Obrenovac', (select Id from Opstine where NazivOpstine = 'Obrenovac'))," +
               "('Železnicka tehnicka škola - Palilula', (select Id from Opstine where NazivOpstine = 'Palilula'))," +
               "('Srednja tehnicka PTT škola', (select Id from Opstine where NazivOpstine = 'Palilula'))," +
               "('V beogradska gimnazija', (select Id from Opstine where NazivOpstine = 'Palilula'))," +
               "('Elektrotehnicka škola \"Rade Koncar\"', (select Id from Opstine where NazivOpstine = 'Palilula'))," +
               "('Poljoprivredna škola PKB', (select Id from Opstine where NazivOpstine = 'Palilula'))," +
               "('Gimnazija “Patrijarh Pavle\"', (select Id from Opstine where NazivOpstine = 'Rakovica'))," +
               "('Muzicka škola \"Davorin Jenko\"', (select Id from Opstine where NazivOpstine = 'Rakovica'))," +
               "('Mašinska škola \"Radoje Dakic\"', (select Id from Opstine where NazivOpstine = 'Rakovica'))," +
               "('Srednja zanatska škola - Rakovica', (select Id from Opstine where NazivOpstine = 'Rakovica'))," +
               "('Peta ekonomska škola \"Rakovica\"', (select Id from Opstine where NazivOpstine = 'Rakovica'))," +
               "('Škola za dizajn - Savski venac', (select Id from Opstine where NazivOpstine = 'Savski Venac'))," +
               "('Škola za brodarstvo, brodogradnju i hidrogradnju', (select Id from Opstine where NazivOpstine = 'Savski Venac'))," +
               "('Gimnazija \"Sveti Sava\"', (select Id from Opstine where NazivOpstine = 'Savski Venac'))," +
               "('Medicinska škola \"Beograd\"', (select Id from Opstine where NazivOpstine = 'Savski Venac'))," +
               "('IV beogradska gimnazija', (select Id from Opstine where NazivOpstine = 'Savski Venac'))," +
               "('Filološka gimnazija', (select Id from Opstine where NazivOpstine = 'Savski Venac'))," +
               "('Ugostiteljsko-turisticka škola - Savski venac', (select Id from Opstine where NazivOpstine = 'Savski Venac'))," +
               "('Škola za oštecene sluhom-nagluve \"Stefan Decanski\"', (select Id from Opstine where NazivOpstine = 'Savski Venac'))," +
               "('Vojna gimnazija', (select Id from Opstine where NazivOpstine = 'Savski Venac'))," +
               "('Mašinska škola \"Kosmaj\"', (select Id from Opstine where NazivOpstine = 'Sopot'))," +
               "('Ekonomsko-trgovinska škola', (select Id from Opstine where NazivOpstine = 'Sopot'))," +
               "('I beogradska gimnazija', (select Id from Opstine where NazivOpstine = 'Stari grad'))," +
               "('Sportska gimnazija', (select Id from Opstine where NazivOpstine = 'Stari grad'))," +
               "('Prva ekonomska škola', (select Id from Opstine where NazivOpstine = 'Stari grad'))," +
               "('Tehnicka škola \"Drvo Art\"', (select Id from Opstine where NazivOpstine = 'Stari grad'))," +
               "('Vazduhoplovna akademija', (select Id from Opstine where NazivOpstine = 'Stari grad'))," +
               "('Muzicka škola \"Mokranjac\"', (select Id from Opstine where NazivOpstine = 'Stari grad'))," +
               "('Trgovacka škola - Stari grad', (select Id from Opstine where NazivOpstine = 'Stari grad'))," +
               "('Muzicka škola \"Dr Vojislav Vuckovic\"', (select Id from Opstine where NazivOpstine = 'Stari grad'))," +
               "('Matematicka gimnazija', (select Id from Opstine where NazivOpstine = 'Stari grad'))," +
               "('Pravno-poslovna škola - Stari grad', (select Id from Opstine where NazivOpstine = 'Stari grad'))," +
               "('Elektrotehnicka škola \"Nikola Tesla\"', (select Id from Opstine where NazivOpstine = 'Stari grad'))," +
               "('Baletska škola \"Lujo Davico\"', (select Id from Opstine where NazivOpstine = 'Stari grad'))," +
               "('Elektrotehnicka škola \"Stari Grad\"', (select Id from Opstine where NazivOpstine = 'Stari grad'))," +
               "('Škola za osnovno i srednje obrazovanje \"Vožd\"', (select Id from Opstine where NazivOpstine = 'Voždovac'))," +
               "('Škola za negu lepote', (select Id from Opstine where NazivOpstine = 'Voždovac'))," +
               "('Tehnicka škola za dizajn kože', (select Id from Opstine where NazivOpstine = 'Voždovac'))," +
               "('Geološka i hidrometeorološka škola \"Milutin Milankovic\"', (select Id from Opstine where NazivOpstine = 'Voždovac'))," +
               "('Druga ekonomska škola', (select Id from Opstine where NazivOpstine = 'Voždovac'))," +
               "('Škola za dizajn tekstila', (select Id from Opstine where NazivOpstine = 'Voždovac'))," +
               "('Osma beogradska gimnazija', (select Id from Opstine where NazivOpstine = 'Voždovac'))," +
               "('XII beogradska gimnazija', (select Id from Opstine where NazivOpstine = 'Voždovac'))," +
               "('III beogradska gimnazija', (select Id from Opstine where NazivOpstine = 'Vračar'))," +
               "('XIV beogradska gimnazija', (select Id from Opstine where NazivOpstine = 'Vračar'))," +
               "('Muzicka škola \"Josif Marinkovic\"', (select Id from Opstine where NazivOpstine = 'Vračar'))," +
               "('Tehnicka škola GSP', (select Id from Opstine where NazivOpstine = 'Vračar'))," +
               "('Muzicka škola \"Stankovic\"', (select Id from Opstine where NazivOpstine = 'Vračar'))," +
               "('Muzicka škola \"Josip Slavenski\"', (select Id from Opstine where NazivOpstine = 'Vračar'))," +
               "('Arhitektonska tehnicka škola - Vracar', (select Id from Opstine where NazivOpstine = 'Vračar'))," +
               "('Škola za ucenike oštecenog vida \"Veljko Ramadanovic\"', (select Id from Opstine where NazivOpstine = 'Zemun'))," +
               "('Muzicka škola \"Kosta Manojlovic\"', (select Id from Opstine where NazivOpstine = 'Zemun'))," +
               "('Pravno-birotehnicka škola \"Dimitrije Davidovic\"', (select Id from Opstine where NazivOpstine = 'Zemun'))," +
               "('Saobracajno-tehnicka škola', (select Id from Opstine where NazivOpstine = 'Zemun'))," +
               "('Elektrotehnicka škola \"Zemun\"', (select Id from Opstine where NazivOpstine = 'Zemun'))," +
               "('Zemunska gimnazija', (select Id from Opstine where NazivOpstine = 'Zemun'))," +
               "('Medicinska škola \"Nadežda Petrovic\"', (select Id from Opstine where NazivOpstine = 'Zemun'))," +
               "('PoPolitehnika – Škola za nove tehnologije', (select Id from Opstine where NazivOpstine = 'Zemun'))," +
               "('Gradevinska tehnicka škola “Branko Žeželj\"', (select Id from Opstine where NazivOpstine = 'Zvezdara'))," +
               "('Medicinska škola - Zvezdara', (select Id from Opstine where NazivOpstine = 'Zvezdara'))," +
               "('VI beogradska gimnazija', (select Id from Opstine where NazivOpstine = 'Zvezdara'))," +
               "('VII beogradska gimnazija', (select Id from Opstine where NazivOpstine = 'Zvezdara'))," +
               "('\"Tehnoart Beograd\" škola za mašinstvo i umetnicke zanate', (select Id from Opstine where NazivOpstine = 'Zvezdara'))," +
               "('Gradevinska škola - Zvezdara', (select Id from Opstine where NazivOpstine = 'Zvezdara'))," +
               "('Farmaceutsko - fizioterapeutska škola - Zvezdara', (select Id from Opstine where NazivOpstine = 'Zvezdara'))," +
               "('Geodetska tehnicka škola - Zvezdara', (select Id from Opstine where NazivOpstine = 'Zvezdara'))," +
               "('Zubotehnicka škola - Zvezdara', (select Id from Opstine where NazivOpstine = 'Zvezdara'))," +
               "('Srednja škola - Blace', (select Id from Opstine where NazivOpstine = 'Blace'))," +
               "('Macvanska srednja škola', (select Id from Opstine where NazivOpstine = 'Bogatić'))," +
               "('Tehnicka škola \"Boško Krstic\"', (select Id from Opstine where NazivOpstine = 'Bojnik'))," +
               "('Srednja škola \"Nikola Tesla\" - Boljevac', (select Id from Opstine where NazivOpstine = 'Boljevac'))," +
               "('Škola za osnovno i srednje obrazovanje \"Vidovdan\"', (select Id from Opstine where NazivOpstine = 'Bor'))," +
               "('Gimnazija \"Bora Stankovic\"', (select Id from Opstine where NazivOpstine = 'Bor'))," +
               "('Tehnicka škola - Bor', (select Id from Opstine where NazivOpstine = 'Bor'))," +
               "('Ekonomsko - trgovinska škola - Bor', (select Id from Opstine where NazivOpstine = 'Bor'))," +
               "('Mašinsko-elektrotehnicka škola - Bor', (select Id from Opstine where NazivOpstine = 'Bor'))," +
               "('Gimnazija - Bosilegrad', (select Id from Opstine where NazivOpstine = 'Bosilegrad'))," +
               "('Srednja škola - Brus', (select Id from Opstine where NazivOpstine = 'Brus'))," +
               "('Srednja škola \"Sveti Sava\" - Bujanovac', (select Id from Opstine where NazivOpstine = 'Bujanovac'))," +
               "('Srednja strucna škola - Crvenka', (select Id from Opstine where NazivOpstine = 'Crvenka'))," +
               "('Tehnicka škola \"Milentije Popovic\"', (select Id from Opstine where NazivOpstine = 'Crna Trava'))," +
               "('Mašinsko-saobracajna škola - Cacak', (select Id from Opstine where NazivOpstine = 'Čačak'))," +
               "('Škola za osnovno i srednje obrazovanje \"1. oktobar\"', (select Id from Opstine where NazivOpstine = 'Čačak'))," +
               "('Muzicka škola \"Dr Vojislav Vuckovic\"', (select Id from Opstine where NazivOpstine = 'Čačak'))," +
               "('Tehnicka škola - Cacak', (select Id from Opstine where NazivOpstine = 'Čačak'))," +
               "('Prehrambeno - ugostiteljska škola - Cacak', (select Id from Opstine where NazivOpstine = 'Čačak'))," +
               "('Medicinska škola - Cacak', (select Id from Opstine where NazivOpstine = 'Čačak'))," +
               "('Ekonomska škola - Cacak', (select Id from Opstine where NazivOpstine = 'Čačak'))," +
               "('Gimnazija - Cacak', (select Id from Opstine where NazivOpstine = 'Čačak'))," +
               "('Ugostiteljsko - turisticka škola - Cajetina', (select Id from Opstine where NazivOpstine = 'Čajetina'))," +
               "('Hemijsko - prehrambena srednja škola - Coka', (select Id from Opstine where NazivOpstine = 'Čoka'))," +
               "('Ekonomsko - trgovinska škola Kruševac', (select Id from Opstine where NazivOpstine = 'Ćićevac'))," +
               "('Škola za muzicke talente - Cuprija', (select Id from Opstine where NazivOpstine = 'Ćuprija'))," +
               "('Medicinska škola \"Danilo Dimitrijevic\"', (select Id from Opstine where NazivOpstine = 'Ćuprija'))," +
               "('Tehnicka škola - Cuprija', (select Id from Opstine where NazivOpstine = 'Ćuprija'))," +
               "('Gimnazija - Cuprija', (select Id from Opstine where NazivOpstine = 'Ćuprija'))," +
               "('Tehnicka škola - Despotovac', (select Id from Opstine where NazivOpstine = 'Despotovac'))," +
               "('Gimnazija \"Sveti Kirilo i Metodije\"', (select Id from Opstine where NazivOpstine = 'Dimitrovgrad'))," +
               "('Ekonomska škola Niš', (select Id from Opstine where NazivOpstine = 'Doljevac'))," +
               "('Ekonomsko - trgovinska škola - Dragas', (select Id from Opstine where NazivOpstine = 'Dragaš'))," +
               "('Ekonomska škola - Goraždevac', (select Id from Opstine where NazivOpstine = 'Goraždevac'))," +
               "('Gimnazija - Goraždevac', (select Id from Opstine where NazivOpstine = 'Goraždevac'))," +
               "('Tehnicka škola \"Dragi Popovic\"', (select Id from Opstine where NazivOpstine = 'Gornje Kušće'))," +
               "('Tehnicka škola \"Jovan Žujovic\"', (select Id from Opstine where NazivOpstine = 'Gornji Milanovac'))," +
               "('Ekonomsko - trgovacka škola \"Knjaz Miloš\"', (select Id from Opstine where NazivOpstine = 'Gornji Milanovac'))," +
               "('Gimnazija \"Takovski ustanak\"', (select Id from Opstine where NazivOpstine = 'Gornji Milanovac'))," +
               "('Srednja škola - Grdelica', 97)," +
               "('Srednja škola \"Dragacevo\"', 100)," +
               "('PTehnicka škola \"Mihajlo Pupin\" - Indija', (select Id from Opstine where NazivOpstine = 'Inđija'))," +
               "('Gimnazija - Indija', (select Id from Opstine where NazivOpstine = 'Inđija'))," +
               "('Srednja škola \"Dr Ðorde Natoševic\"', (select Id from Opstine where NazivOpstine = 'Inđija'))," +
               "('Srednja strucna škola \"Borislav Mihajlovic Mihiz\"', (select Id from Opstine where NazivOpstine = 'Irig'))," +
               "('Tehnicka škola - Ivanjica', (select Id from Opstine where NazivOpstine = 'Ivanjica'))," +
               "('Gimnazija - Ivanjica', (select Id from Opstine where NazivOpstine = 'Ivanjica'))," +
               "('Škola \"11. maj\" - Jagodina', (select Id from Opstine where NazivOpstine = 'Jagodina'))," +
               "('Ekonomsko - trgovinska škola \"Slavka Ðurdevic\"', (select Id from Opstine where NazivOpstine = 'Jagodina'))," +
               "('Prva tehnicka škola - Jagodina', (select Id from Opstine where NazivOpstine = 'Jagodina'))," +
               "('Elektrotehnicka i gradevinska škola \"Nikola Tesla\" - Jagodina', (select Id from Opstine where NazivOpstine = 'Jagodina'))," +
               "('Gimnazija \"Svetozar Markovic\" - Jagodina', (select Id from Opstine where NazivOpstine = 'Jagodina'))," +
               "('Poljoprivredno - tehnicki srednjoškolski centar \"Besedeš Jožef\"', (select Id from Opstine where NazivOpstine = 'Kanjiža'))," +
               "('Gimnazija \"Dušan Vasiljev\"', (select Id from Opstine where NazivOpstine = 'Kikinda'))," +
               "('Tehnicka škola - Kikinda', (select Id from Opstine where NazivOpstine = 'Kikinda'))," +
               "('Srednja strucna škola \"Miloš Crnjanski\" - Kikinda', (select Id from Opstine where NazivOpstine = 'Kikinda'))," +
               "('Ekonomsko - trgovinska škola - Kikinda', (select Id from Opstine where NazivOpstine = 'Kikinda'))," +
               "('Srednja škola \"Sveti Sava\" - Kladovo', (select Id from Opstine where NazivOpstine = 'Kladovo'))," +
               "('Tehnicka škola - Kladovo', (select Id from Opstine where NazivOpstine = 'Kladovo'))," +
               "('Srednja škola - Knic', (select Id from Opstine where NazivOpstine = 'Knić'))," +
               "('Tehnicka škola - Knjaževac', (select Id from Opstine where NazivOpstine = 'Knjaževac'))," +
               "('Knjaževacka gimnazija', (select Id from Opstine where NazivOpstine = 'Knjaževac'))," +
               "('Srednja škola - Koceljeva', (select Id from Opstine where NazivOpstine = 'Koceljeva'))," +
               "('Tehnicka škola - Kosjeric', (select Id from Opstine where NazivOpstine = 'Kosjerić'))," +
               "('Tehnicka škola - Kosovska Kamenica', (select Id from Opstine where NazivOpstine = 'Kosovska Kamenica'))," +
               "('Gimnazija - Kosovska Kamenica', (select Id from Opstine where NazivOpstine = 'Kosovska Kamenica'))," +
               "('Škola za osnovno i srednje obrazovanje \"Kosovski Božur\"', (select Id from Opstine where NazivOpstine = 'Kosovska Mitrovica'))," +
               "('Muzicka škola \"Miodrag Vasiljevic\"', (select Id from Opstine where NazivOpstine = 'Kosovska Mitrovica'))," +
               "('Ekonomsko - trgovinska škola - Kosovska Mitrovica', (select Id from Opstine where NazivOpstine = 'Kosovska Mitrovica'))," +
               "('Medicinska škola - Kosovska Mitrovica', (select Id from Opstine where NazivOpstine = 'Kosovska Mitrovica'))," +
               "('Tehnicka škola \"Mihailo Petrovic Alas\"', (select Id from Opstine where NazivOpstine = 'Kosovska Mitrovica'))," +
               "('Gimnazija - Kosovska Mitrovica', (select Id from Opstine where NazivOpstine = 'Kosovska Mitrovica'))," +
               "('Gimnazija i tehnicka škola - Kosovska Mitrovica', (select Id from Opstine where NazivOpstine = 'Kosovska Mitrovica'))," +
               "('Gimnazija \"Mihajlo Pupin\" - Kovacica', (select Id from Opstine where NazivOpstine = 'Kovačica'))," +
               "('Srednja strucna škola \"Vasa Pelagic\" - Kovin', (select Id from Opstine where NazivOpstine = 'Kovin'))," +
               "('Gimnazija i ekonomska škola \"Branko Radicevic\" - Kovin', (select Id from Opstine where NazivOpstine = 'Kovin'))," +
               "('Škola za osnovno i srednje obrazovanje \"Vukašin Markovic\"', (select Id from Opstine where NazivOpstine = 'Kragujevac'))," +
               "('Škola za ucenike oštecenog sluha - Kragujevac', (select Id from Opstine where NazivOpstine = 'Kragujevac'))," +
               "('Muzicka škola \"Dr Miloje Milojevic\"', (select Id from Opstine where NazivOpstine = 'Kragujevac'))," +
               "('Politehnicka škola - Kragujevac', (select Id from Opstine where NazivOpstine = 'Kragujevac'))," +
               "('Trgovinsko - ugostiteljska škola \"Toza Dragovic\"', (select Id from Opstine where NazivOpstine = 'Kragujevac'))," +
               "('Prva tehnicka škola - Kragujevac', (select Id from Opstine where NazivOpstine = 'Kragujevac'))," +
               "('Druga tehnicka škola - Kragujevac', (select Id from Opstine where NazivOpstine = 'Kragujevac'))," +
               "('Prva kragujevacka gimnazija', (select Id from Opstine where NazivOpstine = 'Kragujevac'))," +
               "('Druga kragujevacka gimnazija', (select Id from Opstine where NazivOpstine = 'Kragujevac'))," +
               "('Medicinska škola \"Sestre Ninkovic\"', (select Id from Opstine where NazivOpstine = 'Kragujevac'))," +
               "('Ekonomska škola - Kragujevac', (select Id from Opstine where NazivOpstine = 'Kragujevac'))," +
               "('Škola za osnovno i srednje obrazovanje \"Ivo Lola Ribar\" - Kraljevo', (select Id from Opstine where NazivOpstine = 'Kraljevo'))," +
               "('Muzicka škola \"Stevan Mokranjac\" - Kraljevo', (select Id from Opstine where NazivOpstine = 'Kraljevo'))," +
               "('Gimnazija - Kraljevo', (select Id from Opstine where NazivOpstine = 'Kraljevo'))," +
               "('Poljoprivredno - hemijska škola \"Dr Ðorde Radic\"', (select Id from Opstine where NazivOpstine = 'Kraljevo'))," +
               "('Medicinska škola - Kraljevo', (select Id from Opstine where NazivOpstine = 'Kraljevo'))," +
               "('Ekonomsko - trgovinska škola - Kraljevo', (select Id from Opstine where NazivOpstine = 'Kraljevo'))," +
               "('Šumarska škola - Kraljevo', (select Id from Opstine where NazivOpstine = 'Kraljevo'))," +
               "('Elektro - saobracajna škola \"Nikola Tesla\" - Kraljevo', (select Id from Opstine where NazivOpstine = 'Kraljevo'))," +
               "('Mašinska tehnicka škola \"14. oktobar\" - Kraljevo', (select Id from Opstine where NazivOpstine = 'Kraljevo'))," +
               "('Srednja škola - Krupanj', (select Id from Opstine where NazivOpstine = 'Krupanj'))," +
               "('Škola za osnovno i srednje obrazovanje \"Veselin Nikolic\"', (select Id from Opstine where NazivOpstine = 'Kruševac'))," +
               "('Hemijsko - tehnološka škola - Krušavac', (select Id from Opstine where NazivOpstine = 'Kruševac'))," +
               "('Muzicka škola \"Stevan Hristic\"', (select Id from Opstine where NazivOpstine = 'Kruševac'))," +
               "('Medicinska škola - Kruševac', (select Id from Opstine where NazivOpstine = 'Kruševac'))," +
               "('Prva tehnicka škola - Krušavac', (select Id from Opstine where NazivOpstine = 'Kruševac'))," +
               "('Ekonomsko - trgovinska škola - Krušavac', (select Id from Opstine where NazivOpstine = 'Kruševac'))," +
               "('Gimnazija - Krušavac', (select Id from Opstine where NazivOpstine = 'Kruševac'))," +
               "('Politehnicka škola “Milutin Milankovic\" - Krušavac', (select Id from Opstine where NazivOpstine = 'Kruševac'))," +
               "('Ekonomsko-trgovinska i mašinska škola - Kucevo', (select Id from Opstine where NazivOpstine = 'Kučevo'))," +
               "('Srednja tehnicka škola \"Mihajlo Pupin\" - Kula', (select Id from Opstine where NazivOpstine = 'Kula'))," +
               "('Ekonomsko - trgovinska škola - Kula', (select Id from Opstine where NazivOpstine = 'Kula'))," +
               "('Gimnazija - Kuršumlija', (select Id from Opstine where NazivOpstine = 'Kuršumlija'))," +
               "('Ekonomska škola - Kuršumlija', (select Id from Opstine where NazivOpstine = 'Kuršumlija'))," +
               "('Gimnazija - Kuršumlija', (select Id from Opstine where NazivOpstine = 'Kuršumlija'))," +
               "('Tehnicka škola “Ðuro Ðakovic\"', (select Id from Opstine where NazivOpstine = 'Kuršumlija'))," +
               "('Tehnicka škola sa domom ucenika \"Nikola Tesla\" - Kostolac', (select Id from Opstine where NazivOpstine = 'Kostolac'))," +
               "('Srednja škola \"17. septembar\" - Lajkovac', (select Id from Opstine where NazivOpstine = 'Lajkovac'))," +
               "('Srednja škola - Lapovo', (select Id from Opstine where NazivOpstine = 'Lapovo'))," +
               "('Srednja škola \"Vožd Karadorde\" - Lebane', (select Id from Opstine where NazivOpstine = 'Lebane'))," +
               "('Gimnazija - Lebane', (select Id from Opstine where NazivOpstine = 'Lebane'))," +
               "('Srednja škola \"Nikola Tesla\" - Leposavic', (select Id from Opstine where NazivOpstine = 'Leposavić'))," +
               "('Poljoprivredna škola Priština - Lešak', 96)," +
               "('Medicinska škola - Leskovac', (select Id from Opstine where NazivOpstine = 'Leskovac'))," +
               "('Muzicka škola \"Stanislav Binicki\"', (select Id from Opstine where NazivOpstine = 'Leskovac'))," +
               "('Škola za tekstil i dizajn - Leskovac', (select Id from Opstine where NazivOpstine = 'Leskovac'))," +
               "('Trgovinsko - ugostiteljska škola - Leskovac', (select Id from Opstine where NazivOpstine = 'Leskovac'))," +
               "('Škola za osnovno i srednje obrazovanje \"11. oktobar\" - Leskovac', (select Id from Opstine where NazivOpstine = 'Leskovac'))," +
               "('Tehnicka škola \"Rade Metalac', (select Id from Opstine where NazivOpstine = 'Leskovac'))," +
               "('Poljoprivredna škola - Leskovac', (select Id from Opstine where NazivOpstine = 'Leskovac'))," +
               "('Hemijsko - tehnološka škola \"Božidar Ðordevic Kukar\"', (select Id from Opstine where NazivOpstine = 'Leskovac'))," +
               "('Gimnazija - Leskovac', (select Id from Opstine where NazivOpstine = 'Leskovac'))," +
               "('Srednja škola \"Vuk Karadžic\" - Ljubovija', (select Id from Opstine where NazivOpstine = 'Ljubovija'))," +
               "('Srednja škola \"Sveti Sava\" - Loznica', (select Id from Opstine where NazivOpstine = 'Loznica'))," +
               "('Tehnicka škola - Loznica', (select Id from Opstine where NazivOpstine = 'Loznica'))," +
               "('Gimnazija \"Vuk Karadžic\" - Loznica', (select Id from Opstine where NazivOpstine = 'Loznica'))," +
               "('Srednja ekonomska škola - Loznica', (select Id from Opstine where NazivOpstine = 'Loznica'))," +
               "('Gimnazija \"Mile Arsenijevic Bandera\"', (select Id from Opstine where NazivOpstine = 'Majdanpek'))," +
               "('Tehnicka škola - Majdanpek', (select Id from Opstine where NazivOpstine = 'Majdanpek'))," +
               "('Srednja škola - Mali Zvornik', (select Id from Opstine where NazivOpstine = 'Mali Zvornik'))," +
               "('Gimnazija \"Vuk Karadžic\" - Loznica', (select Id from Opstine where NazivOpstine = 'Loznica'))," +
               "('Gimnazija \"Vuk Karadžic\" - Loznica', (select Id from Opstine where NazivOpstine = 'Loznica'))," +
               "('Srednja škola – Žitorada', (select id from Opstine where NazivOpstine = 'Žitorada'))," +
               "('Tehnicka škola - Žagubica', (select id from Opstine where NazivOpstine = 'Žagubica'))," +
               "('Srednja škola \"22. oktobar\" - Žabalj', (select id from Opstine where NazivOpstine = 'Žabalj'))," +
               "('Srednja škola – Zvecan', (select id from Opstine where NazivOpstine = 'Zvečan'))," +
               "('Srednja škola \"Grigorije Božovic\" - Zubin Potok', (select id from Opstine where NazivOpstine = 'Zubin Potok '))," +
               "('Hemijsko-prehrambena i tekstilna škola \"Uroš Predic\" - Zrenjanin', (select id from Opstine where NazivOpstine = 'Zrenjanin'))," +
               "('Osnovna i srednja škola \"9. maj\" - Zrenjanin', (select id from Opstine where NazivOpstine = 'Zrenjanin'))," +
               "('Tehnicka škola - Zrenjanin', (select id from Opstine where NazivOpstine = 'Zrenjanin'))," +
               "('Zrenjaninska gimnazija', (select id from Opstine where NazivOpstine = 'Zrenjanin'))," +
               "('Poljoprivredna škola - Zrenjanin', (select id from Opstine where NazivOpstine = 'Zrenjanin'))," +
               "('Medicinska škola - Zrenjanin', (select id from Opstine where NazivOpstine = 'Zrenjanin'))," +
               "('Elektrotehnicka i gradevinska škola \"Nikola Tesla\" - Zrenjanin', (select id from Opstine where NazivOpstine = 'Zrenjanin'))," +
               "('Ekonomsko-trgovinska škola \"Jovan Trajkovic\" - Zrenjanin', (select id from Opstine where NazivOpstine = 'Zrenjanin'))," +
               "('Muzicka škola \"Josif Marinkovic\" - Zrenjanin', (select id from Opstine where NazivOpstine = 'Zrenjanin'))," +
               "('Škola za osnovno i srednje obrazovanje \"Jelena Majstorovic\" Zaječar', (select id from Opstine where NazivOpstine = 'Zaječar'))," +
               "('Medicinska škola - Zaječar', (select id from Opstine where NazivOpstine = 'Zaječar'))," +
               "('Ekonomsko-trgovinska škola - Zaječar', (select id from Opstine where NazivOpstine = 'Zaječar'))," +
               "('Tehnicka škola - Zaječar', (select id from Opstine where NazivOpstine = 'Zaječar'))," +
               "('Gimnazija - Zaječar', (select id from Opstine where NazivOpstine = 'Zaječar'))," +
               "('Medicinska škola - Veliko Ropotovo', 82)," +
               "('Srednja škola \"Svetozar Krstic Toza\" - Leskovac', 97)," +
               "('Školski centar \"Nikola Tesla\" - Vršac', (select id from Opstine where NazivOpstine = 'Vršac'))," +
               "('Poljoprivredna škola \"Vršac\"', (select id from Opstine where NazivOpstine = 'Vršac'))," +
               "('Hemijsko-medicinska škola - Vršac', (select id from Opstine where NazivOpstine = 'Vršac'))," +
               "('Gimnazija \"Borislav Petrov Braca\" - Vršac', (select id from Opstine where NazivOpstine = 'Vršac'))," +
               "('Škola za osnovno i srednje obrazovanje \"Jelena Varjaški\" - Vršac', (select id from Opstine where NazivOpstine = 'Vršac'))," +
               "('Muzicka škola \"Josif Marinkovic\" - Vršac', (select id from Opstine where NazivOpstine = 'Vršac'))," +
               "('Ugostiteljsko-turisticka škola sa domom ucenika - Vrnjacka Banja', (select id from Opstine where NazivOpstine = 'Vrnjačka Banja'))," +
               "('Gimnazija - Vrnjacka Banja', (select id from Opstine where NazivOpstine = 'Vrnjačka Banja'))," +
               "('Tehnicka škola - Vrbovac', 160)," +
               "('Gimnazija \"Žarko Zrenjanin\" - Vrbas', (select id from Opstine where NazivOpstine = 'Vrbas'))," +
               "('Srednja strucna škola \"4. juli\" - Vrbas', (select id from Opstine where NazivOpstine = 'Vrbas'))," +
               "('Muzicka škola \"Stevan Mokranjac\" - Vranje', (select id from Opstine where NazivOpstine = 'Vranje'))," +
               "('Škola za osnovno i srednje obrazovanje \"Vule Antic\" - Vranje', (select id from Opstine where NazivOpstine = 'Vranje'))," +
               "('Tehnicka škola - Vranje', (select id from Opstine where NazivOpstine = 'Vranje'))," +
               "('Srednja poljoprivredno-veterinarska škola \"Stevan Sindelic\" - Vranje', (select id from Opstine where NazivOpstine = 'Vranje'))," +
               "('Medicinska škola \"Dr Izabel Emsli Haton\" - Vranje', (select id from Opstine where NazivOpstine = 'Vranje'))," +
               "('Hemijsko-tehnološka škola - Vranje', (select id from Opstine where NazivOpstine = 'Vranje'))," +
               "('Gimnazija \"Bora Stankovic\" - Vranje', (select id from Opstine where NazivOpstine = 'Vranje'))," +
               "('Ekonomsko-trgovinska škola - Vranje', (select id from Opstine where NazivOpstine = 'Vranje'))," +
               "('Tehnicka škola - Vlasotince', (select id from Opstine where NazivOpstine = 'Vlasotince'))," +
               "('Gimnazija \"Stevan Jakovljevic\" - Vlasotince', (select id from Opstine where NazivOpstine = 'Vlasotince'))," +
               "('Posavotamnavska srednja škola - Vladimirci', (select id from Opstine where NazivOpstine = 'Vladimirci'))," +
               "('Tehnicka škola - Vladicin Han', 34)," +
               "('Gimnazija \"Jovan Skerlic\"- Vladicin Han', 34)," +
               "('Srednja škola - Veliko Gradište', (select id from Opstine where NazivOpstine = 'Veliko Gradište'))," +
               "('Tehnicka škola \"Nikola Tesla\" - Velika Plana', (select id from Opstine where NazivOpstine = 'Velika Plana'))," +
               "('Gimnazija - Velika Plana', (select id from Opstine where NazivOpstine = 'Velika Plana'))," +
               "('Ekonomsko-ugostiteljska škola \"Vuk Karadžic\" - Velika Plana', (select id from Opstine where NazivOpstine = 'Velika Plana'))," +
               "('Srednja škola - Varvarin', (select id from Opstine where NazivOpstine = 'Varvarin'))," +
               "('Valjevska gimnazija', (select id from Opstine where NazivOpstine = 'Valjevo'))," +
               "('Tehnicka škola - Valjevo', (select id from Opstine where NazivOpstine = 'Valjevo'))," +
               "('Medicinska škola \"Dr Miša Pantic\" - Valjevo', (select id from Opstine where NazivOpstine = 'Valjevo'))," +
               "('Muzicka škola \"Živorad Grbic - Valjevo\"', (select id from Opstine where NazivOpstine = 'Valjevo'))," +
               "('Poljoprivredna škola - Valjevo', (select id from Opstine where NazivOpstine = 'Valjevo'))," +
               "('Ekonomska škola - Valjevo', (select id from Opstine where NazivOpstine = 'Valjevo'))," +
               "('Muzicka škola \"Vojislav-Lale Stefanovic\" - Valjevo', (select id from Opstine where NazivOpstine = 'Valjevo'))," +
               "('Tehnicka škola - Užice', (select id from Opstine where NazivOpstine = 'Užice'))," +
               "('Tehnicka škola \"Radoje Ljubicic\" - Užice', (select id from Opstine where NazivOpstine = 'Užice'))," +
               "('Umetnicka škola - Užice', (select id from Opstine where NazivOpstine = 'Užice'))," +
               "('Užicka gimnazija - Užice', (select id from Opstine where NazivOpstine = 'Užice'))," +
               "('Ekonomska škola - Užice', (select id from Opstine where NazivOpstine = 'Užice'))," +
               "('Medicinska škola - Užice', (select id from Opstine where NazivOpstine = 'Užice'))," +
               "('Gimnazija \"Branislav Petronijevic - Ub\"', (select id from Opstine where NazivOpstine = 'Ub'))," +
               "('Tehnicka škola \"Ub\"', (select id from Opstine where NazivOpstine = 'Ub'))," +
               "('Tehnicka škola - Tutin', (select id from Opstine where NazivOpstine = 'Tutin'))," +
               "('Gimnazija - Tutin', (select id from Opstine where NazivOpstine = 'Tutin'))," +
               "('Tehnicka škola - Trstenik', (select id from Opstine where NazivOpstine = 'Trstenik'))," +
               "('Gimnazija \"Vuk Karadžic\" - Trstenik', (select id from Opstine where NazivOpstine = 'Trstenik'))," +
               "('Srednja strucna škola \"Milutin Bojic\" - Trgovište', (select id from Opstine where NazivOpstine = 'Trgovište'))," +
               "('Srednja škola \"Kralj Petar I\" - Topola', (select id from Opstine where NazivOpstine = 'Topola'))," +
               "('Srednja tehnicka škola \"Mileva Maric\" - Titel', (select id from Opstine where NazivOpstine = 'Titel'))," +
               "('Srednja škola \"Dr Lukijan Mušicki\" - Temerin', (select id from Opstine where NazivOpstine = 'Temerin'))," +
               "('Ekonomsko-trgovinska škola - Štrpce', (select id from Opstine where NazivOpstine = 'Štrpce'))," +
               "('Gimnazija - Šilovo', 45)," +
               "('Tehnicka škola \"Nikola Tesla\" - Šid', (select id from Opstine where NazivOpstine = 'Šid'))," +
               "('Gimnazija \"Sava Šumanovic\" - Šid', (select id from Opstine where NazivOpstine = 'Šid'))," +
               "('Strucna hemijska i tekstilna škola - Šabac', (select id from Opstine where NazivOpstine = 'Šabac'))," +
               "('Muzicka škola \"Mihailo Vukdragovic\" - Šabac', (select id from Opstine where NazivOpstine = 'Šabac'))," +
               "('Škola primenjenih umetnosti - Šabac', (select id from Opstine where NazivOpstine = 'Šabac'))," +
               "('Medicinska škola \"Dr Andra Jovanovic\" - Šabac', (select id from Opstine where NazivOpstine = 'Šabac'))," +
               "('Srednja poljoprivredna škola - Šabac', (select id from Opstine where NazivOpstine = 'Šabac'))," +
               "('Ekonomska škola “Stana Milanovic\" - Šabac', (select id from Opstine where NazivOpstine = 'Šabac'))," +
               "('Šabacka gimnazija', (select id from Opstine where NazivOpstine = 'Šabac'))," +
               "('Tehnicka škola - Šabac', (select id from Opstine where NazivOpstine = 'Šabac'))," +
               "('Strucna škola \"Dušan Trivunac Dragoš\" - Svrljig', (select id from Opstine where NazivOpstine = 'Svrljig'))," +
               "('Poljoprivredno-veterinarska škola sa domom ucenika - Svilajnac', (select id from Opstine where NazivOpstine = 'Svilajnac'))," +
               "('Srednja škola \"Svilajnac\"', (select id from Opstine where NazivOpstine = 'Svilajnac'))," +
               "('Poljoprivredno-šumarska škola \"Josif Pancic\" - Surdulica', (select id from Opstine where NazivOpstine = 'Surdulica'))," +
               "('Tehnicka škola \"Nikola Tesla\" - Surdulica', (select id from Opstine where NazivOpstine = 'Surdulica'))," +
               "('Gimnazija \"Svetozar Markovic\" - Surdulica', (select id from Opstine where NazivOpstine = 'Surdulica'))," +
               "('Školski centar sa domom ucenika \"Dositej Obradovic\" - Subotica', (select id from Opstine where NazivOpstine = 'Subotica'))," +
               "('Muzicka škola - Subotica', (select id from Opstine where NazivOpstine = 'Subotica'))," +
               "('Osnovna i srednja škola \"Žarko Zrenjanin\" - Subotica', (select id from Opstine where NazivOpstine = 'Subotica'))," +
               "('Srednja medicinska škola - Subotica', (select id from Opstine where NazivOpstine = 'Subotica'))," +
               "('Politehnicka škola - Subotica', (select id from Opstine where NazivOpstine = 'Subotica'))," +
               "('Hemijsko-tehnološka škola - Subotica', (select id from Opstine where NazivOpstine = 'Subotica'))," +
               "('Gimnazija \"Svetozar Markovic\" - Subotica', (select id from Opstine where NazivOpstine = 'Subotica'))," +
               "('Gimnazija za talentovane ucenike \"Deže Kostolanji\" - Subotica', (select id from Opstine where NazivOpstine = 'Subotica'))," +
               "('Ekonomska škola \"Bosa Milicevic\" - Subotica', (select id from Opstine where NazivOpstine = 'Subotica'))," +
               "('Tehnicka škola \"Ivan Saric\" - Subotica', (select id from Opstine where NazivOpstine = 'Subotica'))," +
               "('Ekonomsko-trgovinska škola \"Vuk Karadžic\" - Stara Pazova', (select id from Opstine where NazivOpstine = 'Stara Pazova'))," +
               "('Tehnicka škola - Stara Pazova', (select id from Opstine where NazivOpstine = 'Stara Pazova'))," +
               "('Gimnazija \"Branko Radicevic\" - Stara Pazova', (select id from Opstine where NazivOpstine = 'Stara Pazova'))," +
               "('Škola za osnovno i srednje obrazovanje \"Anton Skala\" - Stara Pazova', (select id from Opstine where NazivOpstine = 'Stara Pazova'))," +
               "('Srednja škola \"Ðura Jakšic\" - Nova Crnja', 115)," +
               "('Karlovacka gimnazija - Sremski Karlovci', (select id from Opstine where NazivOpstine = 'Sremski Karlovci'))," +
               "('Ekonomska škola \"9. maj\" - Sremska Mitrovica', (select id from Opstine where NazivOpstine = 'Sremska Mitrovica'))," +
               "('Mitrovacka gimnazija - Sremska Mitrovica', (select id from Opstine where NazivOpstine = 'Sremska Mitrovica'))," +
               "('Srednja tehnicka škola \"Nikola Tesla\" - Sremska Mitrovica', (select id from Opstine where NazivOpstine = 'Sremska Mitrovica'))," +
               "('Medicinska škola \"Draginja Nikšic\" - Sremska Mitrovica', (select id from Opstine where NazivOpstine = 'Sremska Mitrovica'))," +
               "('Škola za osnovno i srednje obrazovanje \"Radivoj Popovic\" - Sremska Mitrovica', (select id from Opstine where NazivOpstine = 'Sremska Mitrovica'))," +
               "('Prehrambeno-šumarska i hemijska škola - Sremska Mitrovica', (select id from Opstine where NazivOpstine = 'Sremska Mitrovica'))," +
               "('Muzicka škola \"Petar Krancevic\" - Sremska Mitrovica', (select id from Opstine where NazivOpstine = 'Sremska Mitrovica'))," +
               "('Gimnazija i ekonomska škola \"Svetozar Miletic\" - Srbobran', (select id from Opstine where NazivOpstine = 'Srbobran'))," +
               "('Škola za osnovno i srednje obrazovanje sa domom \"Vuk Karadžic\" - Sombor', (select id from Opstine where NazivOpstine = 'Sombor'))," +
               "('Muzicka škola \"Petar Konjovic\" - Sombor', (select id from Opstine where NazivOpstine = 'Sombor'))," +
               "('Srednja škola \"Sveti Sava\" - Sombor', (select id from Opstine where NazivOpstine = 'Sombor'))," +
               "('Gimnazija \"Veljko Petrovic\" - Sombor', (select id from Opstine where NazivOpstine = 'Sombor'))," +
               "('Srednja poljoprivredno-prehrambena škola - Sombor', (select id from Opstine where NazivOpstine = 'Sombor'))," +
               "('Srednja medicinska škola \"Dr Ružica Rip\" - Sombor', (select id from Opstine where NazivOpstine = 'Sombor'))," +
               "('Srednja tehnicka škola - Sombor', (select id from Opstine where NazivOpstine = 'Sombor'))," +
               "('Srednja ekonomska škola - Sombor', (select id from Opstine where NazivOpstine = 'Sombor'))," +
               "('Srednja škola \"Branislav Nušic\" - Sokobanja', (select id from Opstine where NazivOpstine = 'Sokobanja'))," +
               "('Mašinsko-elektrotehnicka škola \"Goša\" - Smederevska Palanka', (select id from Opstine where NazivOpstine = 'Smederevska Palanka'))," +
               "('Srednja škola \"Žikica Damjanovic\" - Smederevska Palanka', (select id from Opstine where NazivOpstine = 'Smederevska Palanka'))," +
               "('Palanacka gimnazija', (select id from Opstine where NazivOpstine = 'Smederevska Palanka'))," +
               "('Tekstilno-tehnološka i poljoprivredna škola \"Despot Ðurad\" - Smederevo', (select id from Opstine where NazivOpstine = 'Smederevo'))," +
               "('Muzicka škola \"Kosta Manojlovic\" - Smederevo', (select id from Opstine where NazivOpstine = 'Smederevo'))," +
               "('Ekonomsko-trgovinska škola - Smederevo', (select id from Opstine where NazivOpstine = 'Smederevo'))," +
               "('Tehnicka škola - Smederevo', (select id from Opstine where NazivOpstine = 'Smederevo'))," +
               "('Gimnazija - Smederevo', (select id from Opstine where NazivOpstine = 'Smederevo'))," +
               "('Tehnicko-poljoprivredna škola - Sjenica', (select id from Opstine where NazivOpstine = 'Sjenica'))," +
               "('Gimnazija \"Jezdimir Lovic\" - Sjenica', (select id from Opstine where NazivOpstine = 'Sjenica'))," +
               "('Sencanska gimnazija - Senta', (select id from Opstine where NazivOpstine = 'Senta'))," +
               "('Srednja medicinska škola - Senta', (select id from Opstine where NazivOpstine = 'Senta'))," +
               "('Gimnazija sa domom ucenika za talentovane ucenike \"Boljai\" - Senta', (select id from Opstine where NazivOpstine = 'Senta'))," +
               "('Ekonomsko-trgovinska škola - Senta', (select id from Opstine where NazivOpstine = 'Senta'))," +
               "('Srednja škola \"Vuk Karadžic\" - Secanj', (select id from Opstine where NazivOpstine = 'Sečanj'))," +
               "('Srednja škola sa domom ucenika “Petro Kuzmjak\" - Ruski Krstur', 89)," +
               "('Gimnazija \"Stevan Puzic\" - Ruma', (select id from Opstine where NazivOpstine = 'Ruma'))," +
               "('Srednja strucna škola \"Branko Radicevic\" - Ruma', (select id from Opstine where NazivOpstine = 'Ruma'))," +
               "('Srednja poljoprivredno-prehrambena škola \"Stevan Petrovic Brile\" - Ruma', (select id from Opstine where NazivOpstine = 'Ruma'))," +
               "('Srednja tehnicka škola \"Milenko Brzak-Uca\" - Ruma', (select id from Opstine where NazivOpstine = 'Ruma'))," +
               "('Poljoprivedno-veterinarska škola - Rekovac', (select id from Opstine where NazivOpstine = 'Rekovac'))," +
               "('Srednja škola “Kraljica Jelena\" - Raška', (select id from Opstine where NazivOpstine = 'Raška'))," +
               "('Gimnazija - Raška', (select id from Opstine where NazivOpstine = 'Raška'))," +
               "('Ekonomsko-trgovinska škola Gnjilane – Ranilug', 82)," +
               "('Srednja škola \"Ðura Jakšic\" - Raca', (select id from Opstine where NazivOpstine = 'Rača'))," +
               "('Poljoprivredna škola \"Radoš Jovanovic Selja\" - Prokuplje', (select id from Opstine where NazivOpstine = 'Prokuplje'))," +
               "('Medicinska škola \"Dr Aleksa Savic\" - Prokuplje', (select id from Opstine where NazivOpstine = 'Prokuplje'))," +
               "('Tehnicka škola \"15. maj\" - Prokuplje', (select id from Opstine where NazivOpstine = 'Prokuplje'))," +
               "('Gimnazija - Prokuplje', (select id from Opstine where NazivOpstine = 'Prokuplje'))," +
               "('Ekonomsko-trgovinska škola – Laplje selo (izmeštena iz Prištine)', (select id from Opstine where NazivOpstine = 'Priština'))," +
               "('Gimnazija – Laplje selo (izmeštena iz Prištine)', (select id from Opstine where NazivOpstine = 'Priština'))," +
               "('Gradevinsko-saobracajna škola – Gracanica (izmeštena iz Prištine)', (select id from Opstine where NazivOpstine = 'Priština'))," +
               "('Medicinska škola – Gracanica (izmeštena iz Prištine)', (select id from Opstine where NazivOpstine = 'Priština'))," +
               "('Mašinska škola – Preoce (izmeštena iz Prištine)', (select id from Opstine where NazivOpstine = 'Priština'))," +
               "('Elektrotehnicka škola “Mihajlo Pupin\" – Sušica (izmeštena iz Prištine)', (select id from Opstine where NazivOpstine = 'Priština'))," +
               "('Muzicka škola “Stevan Mokranjac\" – Gracanica (izmeštena iz Prištine)', (select id from Opstine where NazivOpstine = 'Priština'))," +
               "('Tehnicka škola \"Nikola Tesla\" - Prilužje', 42)," +
               "('Tehnicka škola - Prijepolje', (select id from Opstine where NazivOpstine = 'Prijepolje'))," +
               "('Prijepoljska gimnazija', (select id from Opstine where NazivOpstine = 'Prijepolje'))," +
               "('Ekonomsko-trgovinska škola - Prijepolje', (select id from Opstine where NazivOpstine = 'Prijepolje'))," +
               "('Mašinsko-elektrotehnicka škola - Priboj', (select id from Opstine where NazivOpstine = 'Priboj na Limu'))," +
               "('Gimnazija - Priboj', (select id from Opstine where NazivOpstine = 'Priboj na Limu'))," +
               "('Srednja tehnicka škola \"Preševo\"', (select id from Opstine where NazivOpstine = 'Preševo'))," +
               "('Gimnazija \"Skenderbeu\" - Preševo', (select id from Opstine where NazivOpstine = 'Preševo'))," +
               "('Poljoprivredna škola sa domom ucenika \"Dr Ljubo Micic\" - Požega', (select id from Opstine where NazivOpstine = 'Požega'))," +
               "('Tehnicka škola - Požega', (select id from Opstine where NazivOpstine = 'Požega'))," +
               "('Gimnazija \"Sveti Sava\" - Požega', (select id from Opstine where NazivOpstine = 'Požega'))," +
               "('Škola za osnovno i srednje muzicko obrazovanje \"Stevan Mokranjac\" - Požarevac', (select id from Opstine where NazivOpstine = 'Požarevac'))," +
               "('Politehnicka škola - Požarevac', (select id from Opstine where NazivOpstine = 'Požarevac'))," +
               "('Ekonomsko-trgovinska škola - Požarevac', (select id from Opstine where NazivOpstine = 'Požarevac'))," +
               "('Poljoprivredna škola sa domom ucenika \"Sonja Marinkovic\" - Požarevac', (select id from Opstine where NazivOpstine = 'Požarevac'))," +
               "('Medicinska škola - Požarevac', (select id from Opstine where NazivOpstine = 'Požarevac'))," +
               "('Požarevacka gimnazija', (select id from Opstine where NazivOpstine = 'Požarevac'))," +
               "('Škola za osnovno i srednje obrazovanje \"Mladost\" - Pirot', (select id from Opstine where NazivOpstine = 'Pirot'))," +
               "('Mlekarska škola sa domom ucenika \"Dr Obren Pejic\" - Pirot', (select id from Opstine where NazivOpstine = 'Pirot'))," +
               "('Tehnicka škola - Pirot', (select id from Opstine where NazivOpstine = 'Pirot'))," +
               "('Srednja strucna škola - Pirot', (select id from Opstine where NazivOpstine = 'Pirot'))," +
               "('Ekonomska škola - Pirot', (select id from Opstine where NazivOpstine = 'Pirot'))," +
               "('Gimnazija - Pirot', (select id from Opstine where NazivOpstine = 'Pirot'))," +
               "('Srednja škola \"Mladost\" - Petrovac', (select id from Opstine where NazivOpstine = 'Bački Petrovac'))," +
               "('Tehnicka škola \"Milenko Verkic Neša\" - Pecinci', (select id from Opstine where NazivOpstine = 'Pećinci'))," +
               "('Tehnološka škola - Paracin', (select id from Opstine where NazivOpstine = 'Paraćin'))," +
               "('Ekonomsko-trgovinska škola - Paracin', (select id from Opstine where NazivOpstine = 'Paraćin'))," +
               "('Mašinsko-elektrotehnicka škola - Paracin', (select id from Opstine where NazivOpstine = 'Paraćin'))," +
               "('Gimnazija - Paracin', (select id from Opstine where NazivOpstine = 'Paraćin'))," +
               "('Mašinska škola \"Pancevo\"', (select id from Opstine where NazivOpstine = 'Pančevo'))," +
               "('Poljoprivredna škola \"Josif Pancic\"', (select id from Opstine where NazivOpstine = 'Pančevo'))," +
               "('Medicinska škola \"Stevica Jovanovic\" - Pancevo', (select id from Opstine where NazivOpstine = 'Pančevo'))," +
               "('Tehnicka škola \"23. maj\" - Pancevo', (select id from Opstine where NazivOpstine = 'Pančevo'))," +
               "('Gimnazija \"Uroš Predic\" - Pancevo', (select id from Opstine where NazivOpstine = 'Pančevo'))," +
               "('Elektrotehnicka škola \"Nikola Tesla\" - Pancevo', (select id from Opstine where NazivOpstine = 'Pančevo'))," +
               "('Ekonomsko-trgovinska škola \"Paja Marganovic\" - Pancevo', (select id from Opstine where NazivOpstine = 'Pančevo'))," +
               "('Muzicka škola \"Jovan Bandur\" - Pancevo', (select id from Opstine where NazivOpstine = 'Pančevo'))," +
               "('Baletska škola \"Dimitrije Parlic\" - Pancevo', (select id from Opstine where NazivOpstine = 'Pančevo'))," +
               "('Škola za osnovno i srednje obrazovanje \"Mara Mandic\" - Pancevo', (select id from Opstine where NazivOpstine = 'Pančevo'))," +
               "('Ekonomska škola \"Valjevo\" - Osecina', (select id from Opstine where NazivOpstine = 'Osečina'))," +
               "('Gimnazija - Orahovac', (select id from Opstine where NazivOpstine = 'Orahovac'))," +
               "('Tehnicka škola - Odžaci', (select id from Opstine where NazivOpstine = 'Odžaci'))," +
               "('Gimnazija i ekonomska škola \"Jovan Jovanovic Zmaj\" - Odžaci', (select id from Opstine where NazivOpstine = 'Odžaci'))," +
               "('Gimnazija \"Jovan Jovanovic Zmaj\" - Novi Sad', (select id from Opstine where NazivOpstine = 'Novi Sad'))," +
               "('Gimnazija \"Svetozar Markovic\" - Novi Sad', (select id from Opstine where NazivOpstine = 'Novi Sad'))," +
               "('Gimnazija \"Isidora Sekulic\" - Novi Sad', (select id from Opstine where NazivOpstine = 'Novi Sad'))," +
               "('Gimnazija \"Laza Kostic\" - Novi Sad', (select id from Opstine where NazivOpstine = 'Novi Sad'))," +
               "('Srednja škola \"Svetozar Miletic\" - Novi Sad', (select id from Opstine where NazivOpstine = 'Novi Sad'))," +
               "('Medicinska škola \"7. april\" - Novi Sad', (select id from Opstine where NazivOpstine = 'Novi Sad'))," +
               "('Poljoprivredna škola sa domom ucenika (Futog) - Novi Sad', (select id from Opstine where NazivOpstine = 'Novi Sad'))," +
               "('Srednja mašinska škola - Novi Sad', (select id from Opstine where NazivOpstine = 'Novi Sad'))," +
               "('Elektrotehnica škola \"Mihajlo Pupin\" - Novi Sad', (select id from Opstine where NazivOpstine = 'Novi Sad'))," +
               "('Tehnicka škola \"Pavle Savic\" - Novi Sad', (select id from Opstine where NazivOpstine = 'Novi Sad'))," +
               "('Tehnicka škola \"Mileva Maric-Ajnštajn\" - Novi Sad', (select id from Opstine where NazivOpstine = 'Novi Sad'))," +
               "('Saobracajna škola \"Pinki\" - Novi Sad', (select id from Opstine where NazivOpstine = 'Novi Sad'))," +
               "('Muzicka škola \"Isidor Bajic\" - Novi Sad', (select id from Opstine where NazivOpstine = 'Novi Sad'))," +
               "('Baletska škola - Novi Sad', (select id from Opstine where NazivOpstine = 'Novi Sad'))," +
               "('Škola za dizajn \"Bogdan Šuput\" - Novi Sad', (select id from Opstine where NazivOpstine = 'Novi Sad'))," +
               "('Škola za osnovno i srednje obrazovanje \"Milan Petrovic\" Novi Sad', (select id from Opstine where NazivOpstine = 'Novi Sad'))," +
               "('Medicinska škola - Novi Pazar', (select id from Opstine where NazivOpstine = 'Novi Pazar'))," +
               "('Škola za dizajn tekstila i kože - Novi Pazar', (select id from Opstine where NazivOpstine = 'Novi Pazar'))," +
               "('Ugostiteljsko-turisticka škola - Novi Pazar', (select id from Opstine where NazivOpstine = 'Novi Pazar'))," +
               "('Tehnicka škola - Novi Pazar', (select id from Opstine where NazivOpstine = 'Novi Pazar'))," +
               "('Ekonomsko-trgovinska škola - Novi Pazar', (select id from Opstine where NazivOpstine = 'Novi Pazar'))," +
               "('Gimnazija - Novi Pazar', (select id from Opstine where NazivOpstine = 'Novi Pazar'))," + 
               "('Gimnazija - Novi Kneževac', (select id from Opstine where NazivOpstine = 'Novi Kneževac'))," +
               "('Srednja škola \"Dositej Obradovic\" - Novi Kneževac', (select id from Opstine where NazivOpstine = 'Novi Kneževac'))," +
               "('Srednja škola - Novi Becej', (select id from Opstine where NazivOpstine = 'Novi Bečej'))," +
               "('Tehnicka škola - Nova Varoš', (select id from Opstine where NazivOpstine = 'Nova Varoš'))," +
               "('Gimnazija \"Pivo Karamatijevic\" - Nova Varoš', (select id from Opstine where NazivOpstine = 'Nova Varoš'))," +
               "('Prva niška gimnazija \"Stevan Sremac\" - Niš', (select id from Opstine where NazivOpstine = 'Palilula (Niš)'))," +
               "('Gimnazija \"Bora Stankovic\" - Niš', (select id from Opstine where NazivOpstine = 'Palilula (Niš)'))," +
               "('Gimnazija \"Svetozar Markovic\" - Niš', (select id from Opstine where NazivOpstine = 'Palilula (Niš)'))," +
               "('Gimnazija \"9. maj\" - Niš', (select id from Opstine where NazivOpstine = 'Palilula (Niš)'))," +
               "('Ekonomska škola - Niš', (select id from Opstine where NazivOpstine = 'Palilula (Niš)'))," +
               "('Pravno-poslovna škola - Niš', (select id from Opstine where NazivOpstine = 'Palilula (Niš)'))," +
               "('Trgovinska škola - Niš', (select id from Opstine where NazivOpstine = 'Palilula (Niš)'))," +
               "('Ugostiteljsko-turisticka škola - Niš', (select id from Opstine where NazivOpstine = 'Palilula (Niš)'))," +
               "('Medicinska škola \"Dr Milenko Hadžic\" - Niš', (select id from Opstine where NazivOpstine = 'Palilula (Niš)'))," +
               "('Prva tehnicka škola “Milutin Milankovic\" - Niš', (select id from Opstine where NazivOpstine = 'Palilula (Niš)'))," +
               "('Tehnicka škola \"12. februar\" - Niš', (select id from Opstine where NazivOpstine = 'Palilula (Niš)'))," +
               "('Mašinska škola - Niš', (select id from Opstine where NazivOpstine = 'Palilula (Niš)'))," +
               "('Elektrotehnicka škola \"Nikola Tesla\" - Niš', (select id from Opstine where NazivOpstine = 'Palilula (Niš)'))," +
               "('Elektrotehnicka škola \"Mija Stanimirovic\" - Niš', (select id from Opstine where NazivOpstine = 'Palilula (Niš)'))," +
               "('Gradevinska tehnicka škola \"Neimar\" - Niš', (select id from Opstine where NazivOpstine = 'Palilula (Niš)'))," +
               "('Prehrambeno-hemijska škola - Niš', (select id from Opstine where NazivOpstine = 'Palilula (Niš)'))," +
               "('Škola mode i lepote - Niš', (select id from Opstine where NazivOpstine = 'Palilula (Niš)'))," +
               "('Umetnicka škola - Niš', (select id from Opstine where NazivOpstine = 'Palilula (Niš)'))," +
               "('Muzicka škola - Niš', (select id from Opstine where NazivOpstine = 'Palilula (Niš)'))," +
               "('Škola za osnovno i srednje obrazovanje \"14. oktobar\" - Niš', (select id from Opstine where NazivOpstine = 'Palilula (Niš)'))," +
               "('Specijalna škola sa domom ucenika \"Bubanj\" - Niš', (select id from Opstine where NazivOpstine = 'Palilula (Niš)')), " +
               "('Umetnicka škola \"Stevan Mokranjac\" - Negotin', (select id from Opstine where NazivOpstine = 'Negotin'))," +
               "('Poljoprivredna škola sa domom ucenika \"Rajko Bosnic\" - Negotin', (select id from Opstine where NazivOpstine = 'Negotin'))," +
               "('Tehnicka škola - Negotin', (select id from Opstine where NazivOpstine = 'Negotin'))," +
               "('Negotinska gimnazija - Negotin', (select id from Opstine where NazivOpstine = 'Negotin'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ucenici_SrednjeSkole_UpisanaSkolaId",
                table: "Ucenici");

            migrationBuilder.DropIndex(
                name: "IX_Ucenici_UpisanaSkolaId",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "UpisanaSkolaId",
                table: "Ucenici");
        }
    }
}
