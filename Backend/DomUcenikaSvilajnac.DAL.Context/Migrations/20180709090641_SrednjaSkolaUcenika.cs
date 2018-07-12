using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomučenikaSvilajnac.DAL.Context.Migrations
{
    public partial class SrednjaSkolaučenika : Migration
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
                 "(N'Tehnička škola - Ada', (select Id from Opstine where NazivOpstine = N'Ada'))," +
                 "(N'Srednja škola - \"Sveti Trifun\"', (select Id from Opstine where NazivOpstine = N'Aleksandrovac'))," +
               "(N'Poljoprivredna škola - \"Šumatovac\"', (select Id from Opstine where NazivOpstine = N'Aleksinac'))," +
               "(N'Tehnička škola - \"Prota Stevan Dimitrijević\"', (select Id from Opstine where NazivOpstine = N'Aleksinac'))," +
               "(N'Aleksinacka Gimanzija', (select Id from Opstine where NazivOpstine = N'Aleksinac'))," +
               "(N'Gimnazija - \"Nikola Tesla\"', (select Id from Opstine where NazivOpstine = N'Apatin'))," +
               "(N'Tehnička škola - Apatin', (select Id from Opstine where NazivOpstine = N'Apatin'))," +
               "(N'Srednja gradevinska i drvopreradivacka stručna škola - Apatin', (select Id from Opstine where NazivOpstine = N'Apatin'))," +
               "(N'Ekonomsko – ugostiteljska škola - \"Slobodan Minic\"', (select Id from Opstine where NazivOpstine = N'Aranđelovac'))," +
               "(N'Ekonomsko ugostiteljska škola \"Slobodan Minic\"', (select Id from Opstine where NazivOpstine = N'Aranđelovac'))," +
               "(N'Gimnazija \"Miloš Savkovic\"', (select Id from Opstine where NazivOpstine = N'Aranđelovac'))," +
               "(N'Tehnička škola \"Mileta Nikolic\"', (select Id from Opstine where NazivOpstine = N'Aranđelovac'))," +
               "(N'Srednja škola \"Sveti Ahilije\"', (select Id from Opstine where NazivOpstine = N'Arilje'))," +
               "(N'Tehnička škola - Babušnica', (select Id from Opstine where NazivOpstine = N'Babušnica'))," +
               "(N'Gimnazija \"Vuk Karadžic\"', (select Id from Opstine where NazivOpstine = N'Babušnica'))," +
               "(N'Poljoprivredna škola - Bac', (select Id from Opstine where NazivOpstine = N'Bač'))," +
               "(N'Srednja stručna škola \"Dr Radivoj Uvalic\"', (select Id from Opstine where NazivOpstine = N'Bačka Palanka'))," +
               "(N'Gimnazija \"20. oktobar\"', (select Id from Opstine where NazivOpstine = N'Bačka Palanka'))," +
               "(N'Tehnička škola \"9. maj\"', (select Id from Opstine where NazivOpstine = N'Bačka Palanka'))," +
               "(N'Srednja tehnička škola \"Šinkovic Jožef\"', (select Id from Opstine where NazivOpstine = N'Bačka Topola'))," +
               "(N'Poljoprivredna škola - Backa Topola', (select Id from Opstine where NazivOpstine = N'Bačka Topola'))," +
               "(N'Gimnazija i ekonomska škola \"Dositej Obradovic\"', (select Id from Opstine where NazivOpstine = N'Bačka Topola'))," +
               "(N'Gimnazija \"Jan Kolar\"', (select Id from Opstine where NazivOpstine = N'Bački Petrovac'))," +
               "(N'Tehnička škola - Bajina Bašta', (select Id from Opstine where NazivOpstine = N'Bajina Bašta'))," +
               "(N'Gimnazija \"Josif Pancic\"', (select Id from Opstine where NazivOpstine = N'Bajina Bašta'))," +
               "(N'Srednja škola \"Nikola Tesla\"', (select Id from Opstine where NazivOpstine = N'Batočina'))," +
               "(N'Tehnička škola - Becej', (select Id from Opstine where NazivOpstine = N'Bečej'))," +
               "(N'Gimnazija - Becej', (select Id from Opstine where NazivOpstine = N'Bečej'))," +
               "(N'Ekonomsko - trgovinska škola - Becej', (select Id from Opstine where NazivOpstine = N'Bečej'))," +
               "(N'Škola za osnovno i srednje obrazovanje \"Bratstvo\"', (select Id from Opstine where NazivOpstine = N'Bečej'))," +
               "(N'Belocrkvanska gimnazija i ekonomska škola', (select Id from Opstine where NazivOpstine = N'Bela Crkva'))," +
               "(N'Tehnička škola \"Sava Muncan\"', (select Id from Opstine where NazivOpstine = N'Bela Crkva'))," +  //-as
               "(N'Srednja škola \"Niketa Remezijanski\"', (select Id from Opstine where NazivOpstine = N'Bela Palanka'))," +
               "(N'Srednja škola - Barajevo', (select Id from Opstine where NazivOpstine = N'Barajevo'))," +
               "(N'XIII beogradska gimnazija', (select Id from Opstine where NazivOpstine = N'Čukarica'))," +
               "(N'Hemijsko-prehrambena tehnološka škola', (select Id from Opstine where NazivOpstine = N'Čukarica'))," +
               "(N'Tehnička škola (Železnik)', (select Id from Opstine where NazivOpstine = N'Čukarica'))," +
               "(N'Muzička škola \"Vatroslav Lisinski\"', (select Id from Opstine where NazivOpstine = N'Čukarica'))," +
               "(N'Škola za osnovno i srednje obrazovanje \"Sveti Sava\"', (select Id from Opstine where NazivOpstine = N'Čukarica'))," +
               "(N'Srednja škola - Grocka', (select Id from Opstine where NazivOpstine = N'Grocka'))," +
               "(N'Muzička škola \"Marko Tajcevic\"', (select Id from Opstine where NazivOpstine = N'Lazarevac'))," +
               "(N'Tehnička škola \"Kolubara\"', (select Id from Opstine where NazivOpstine = N'Lazarevac'))," +
               "(N'Gimnazija - Lazarevac', (select Id from Opstine where NazivOpstine = N'Lazarevac'))," +
               "(N'Tehnička škola - Mladenovac', (select Id from Opstine where NazivOpstine = N'Mladenovac'))," +
               "(N'Gimnazija - Mladenovac', (select Id from Opstine where NazivOpstine = N'Mladenovac'))," +
               "(N'Tehnička škola - Novi Beograd', (select Id from Opstine where NazivOpstine = N'Novi Beograd'))," +
               "(N'Tehnička škola \"Zmaj\"', (select Id from Opstine where NazivOpstine = N'Novi Beograd'))," +
               "(N'Srednja turistička škola - Novi Beograd', (select Id from Opstine where NazivOpstine = N'Novi Beograd'))," +
               "(N'IX gimnazija \"Mihailo Petrović Alas\"', (select Id from Opstine where NazivOpstine = N'Novi Beograd'))," +
               "(N'X gimnazija \"Mihajlo Pupin\"', (select Id from Opstine where NazivOpstine = N'Novi Beograd'))," +
               "(N'Grafička škola - Novi Beograd', (select Id from Opstine where NazivOpstine = N'Novi Beograd'))," +
               "(N'Tehnička škola - Obrenovac', (select Id from Opstine where NazivOpstine = N'Obrenovac'))," +
               "(N'Poljoprivredno-hemijska škola - Obrenovac', (select Id from Opstine where NazivOpstine = N'Obrenovac'))," +
               "(N'Gimnazija Obrenovac', (select Id from Opstine where NazivOpstine = N'Obrenovac'))," +
               "(N'Železnička tehnička škola - Palilula', (select Id from Opstine where NazivOpstine = N'Palilula'))," +
               "(N'Srednja tehnička PTT škola', (select Id from Opstine where NazivOpstine = N'Palilula'))," +
               "(N'V beogradska gimnazija', (select Id from Opstine where NazivOpstine = N'Palilula'))," +
               "(N'Elektrotehnička škola \"Rade Koncar\"', (select Id from Opstine where NazivOpstine = N'Palilula'))," +
               "(N'Poljoprivredna škola PKB', (select Id from Opstine where NazivOpstine = N'Palilula'))," +
               "(N'Gimnazija “Patrijarh Pavle\"', (select Id from Opstine where NazivOpstine = N'Rakovica'))," +
               "(N'Muzička škola \"Davorin Jenko\"', (select Id from Opstine where NazivOpstine = N'Rakovica'))," +
               "(N'Mašinska škola \"Radoje Dakic\"', (select Id from Opstine where NazivOpstine = N'Rakovica'))," +
               "(N'Srednja zanatska škola - Rakovica', (select Id from Opstine where NazivOpstine = N'Rakovica'))," +
               "(N'Peta ekonomska škola \"Rakovica\"', (select Id from Opstine where NazivOpstine = N'Rakovica'))," +
               "(N'Škola za dizajn - Savski venac', (select Id from Opstine where NazivOpstine = N'Savski Venac'))," +
               "(N'Škola za brodarstvo, brodogradnju i hidrogradnju', (select Id from Opstine where NazivOpstine = N'Savski Venac'))," +
               "(N'Gimnazija \"Sveti Sava\"', (select Id from Opstine where NazivOpstine = N'Savski Venac'))," +
               "(N'Medicinska škola \"Beograd\"', (select Id from Opstine where NazivOpstine = N'Savski Venac'))," +
               "(N'IV beogradska gimnazija', (select Id from Opstine where NazivOpstine = N'Savski Venac'))," +
               "(N'Filološka gimnazija', (select Id from Opstine where NazivOpstine = N'Savski Venac'))," +
               "(N'Ugostiteljsko-turistička škola - Savski venac', (select Id from Opstine where NazivOpstine = N'Savski Venac'))," +
               "(N'Škola za oštecene sluhom-nagluve \"Stefan Decanski\"', (select Id from Opstine where NazivOpstine = N'Savski Venac'))," +
               "(N'Vojna gimnazija', (select Id from Opstine where NazivOpstine = N'Savski Venac'))," +
               "(N'Mašinska škola \"Kosmaj\"', (select Id from Opstine where NazivOpstine = N'Sopot'))," +
               "(N'Ekonomsko-trgovinska škola', (select Id from Opstine where NazivOpstine = N'Sopot'))," +
               "(N'I beogradska gimnazija', (select Id from Opstine where NazivOpstine = N'Stari grad'))," +
               "(N'Sportska gimnazija', (select Id from Opstine where NazivOpstine = N'Stari grad'))," +
               "(N'Prva ekonomska škola', (select Id from Opstine where NazivOpstine = N'Stari grad'))," +
               "(N'Tehnička škola \"Drvo Art\"', (select Id from Opstine where NazivOpstine = N'Stari grad'))," +
               "(N'Vazduhoplovna akademija', (select Id from Opstine where NazivOpstine = N'Stari grad'))," +
               "(N'Muzička škola \"Mokranjac\"', (select Id from Opstine where NazivOpstine = N'Stari grad'))," +
               "(N'Trgovačka škola - Stari grad', (select Id from Opstine where NazivOpstine = N'Stari grad'))," +
               "(N'Muzička škola \"Dr Vojislav Vučković\"', (select Id from Opstine where NazivOpstine = N'Stari grad'))," +
               "(N'Matematička gimnazija', (select Id from Opstine where NazivOpstine = N'Stari grad'))," +
               "(N'Pravno-poslovna škola - Stari grad', (select Id from Opstine where NazivOpstine = N'Stari grad'))," +
               "(N'Elektrotehnička škola \"Nikola Tesla\"', (select Id from Opstine where NazivOpstine = N'Stari grad'))," +
               "(N'Baletska škola \"Lujo Davico\"', (select Id from Opstine where NazivOpstine = N'Stari grad'))," +
               "(N'Elektrotehnička škola \"Stari Grad\"', (select Id from Opstine where NazivOpstine = N'Stari grad'))," +
               "(N'Škola za osnovno i srednje obrazovanje \"Vožd\"', (select Id from Opstine where NazivOpstine = N'Voždovac'))," +
               "(N'Škola za negu lepote', (select Id from Opstine where NazivOpstine = N'Voždovac'))," +
               "(N'Tehnička škola za dizajn kože', (select Id from Opstine where NazivOpstine = N'Voždovac'))," +
               "(N'Geološka i hidrometeorološka škola \"Milutin Milankovic\"', (select Id from Opstine where NazivOpstine = N'Voždovac'))," +
               "(N'Druga ekonomska škola', (select Id from Opstine where NazivOpstine = N'Voždovac'))," +
               "(N'Škola za dizajn tekstila', (select Id from Opstine where NazivOpstine = N'Voždovac'))," +
               "(N'Osma beogradska gimnazija', (select Id from Opstine where NazivOpstine = N'Voždovac'))," +
               "(N'XII beogradska gimnazija', (select Id from Opstine where NazivOpstine = N'Voždovac'))," +
               "(N'III beogradska gimnazija', (select Id from Opstine where NazivOpstine = N'Vračar'))," +
               "(N'XIV beogradska gimnazija', (select Id from Opstine where NazivOpstine = N'Vračar'))," +
               "(N'Muzička škola \"Josif Marinkovic\"', (select Id from Opstine where NazivOpstine = N'Vračar'))," +
               "(N'Tehnička škola GSP', (select Id from Opstine where NazivOpstine = N'Vračar'))," +
               "(N'Muzička škola \"Stanković\"', (select Id from Opstine where NazivOpstine = N'Vračar'))," +
               "(N'Muzička škola \"Josip Slavenski\"', (select Id from Opstine where NazivOpstine = N'Vračar'))," +
               "(N'Arhitektonska tehnička škola - Vracar', (select Id from Opstine where NazivOpstine = N'Vračar'))," +
               "(N'Škola za ucenike oštecenog vida \"Veljko Ramadanovic\"', (select Id from Opstine where NazivOpstine = N'Zemun'))," +
               "(N'Muzička škola \"Kosta Manojlovic\"', (select Id from Opstine where NazivOpstine = N'Zemun'))," +
               "(N'Pravno-birotehnička škola \"Dimitrije Davidovic\"', (select Id from Opstine where NazivOpstine = N'Zemun'))," +
               "(N'Saobracajno-tehnička škola', (select Id from Opstine where NazivOpstine = N'Zemun'))," +
               "(N'Elektrotehnička škola \"Zemun\"', (select Id from Opstine where NazivOpstine = N'Zemun'))," +
               "(N'Zemunska gimnazija', (select Id from Opstine where NazivOpstine = N'Zemun'))," +
               "(N'Medicinska škola \"Nadežda Petrović\"', (select Id from Opstine where NazivOpstine = N'Zemun'))," +
               "(N'PoPolitehnika – Škola za nove tehnologije', (select Id from Opstine where NazivOpstine = N'Zemun'))," +
               "(N'Građevinska tehnička škola “Branko Žeželj\"', (select Id from Opstine where NazivOpstine = N'Zvezdara'))," +
               "(N'Medicinska škola - Zvezdara', (select Id from Opstine where NazivOpstine = N'Zvezdara'))," +
               "(N'VI beogradska gimnazija', (select Id from Opstine where NazivOpstine = N'Zvezdara'))," +
               "(N'VII beogradska gimnazija', (select Id from Opstine where NazivOpstine = N'Zvezdara'))," +
               "(N'\"Tehnoart Beograd\" škola za mašinstvo i umetnicke zanate', (select Id from Opstine where NazivOpstine = N'Zvezdara'))," +
               "(N'Građevinska škola - Zvezdara', (select Id from Opstine where NazivOpstine = N'Zvezdara'))," +
               "(N'Farmaceutsko - fizioterapeutska škola - Zvezdara', (select Id from Opstine where NazivOpstine = N'Zvezdara'))," +
               "(N'Geodetska tehnička škola - Zvezdara', (select Id from Opstine where NazivOpstine = N'Zvezdara'))," +
               "(N'Zubotehnička škola - Zvezdara', (select Id from Opstine where NazivOpstine = N'Zvezdara'))," +
               "(N'Srednja škola - Blace', (select Id from Opstine where NazivOpstine = N'Blace'))," +
               "(N'Mačvanska srednja škola', (select Id from Opstine where NazivOpstine = N'Bogatić'))," +
               "(N'Tehnička škola \"Boško Krstic\"', (select Id from Opstine where NazivOpstine = N'Bojnik'))," +
               "(N'Srednja škola \"Nikola Tesla\" - Boljevac', (select Id from Opstine where NazivOpstine = N'Boljevac'))," +
               "(N'Škola za osnovno i srednje obrazovanje \"Vidovdan\"', (select Id from Opstine where NazivOpstine = N'Bor'))," +
               "(N'Gimnazija \"Bora Stanković\"', (select Id from Opstine where NazivOpstine = N'Bor'))," +
               "(N'Tehnička škola - Bor', (select Id from Opstine where NazivOpstine = N'Bor'))," +
               "(N'Ekonomsko - trgovinska škola - Bor', (select Id from Opstine where NazivOpstine = N'Bor'))," +
               "(N'Mašinsko-elektrotehnička škola - Bor', (select Id from Opstine where NazivOpstine = N'Bor'))," +
               "(N'Gimnazija - Bosilegrad', (select Id from Opstine where NazivOpstine = N'Bosilegrad'))," +
               "(N'Srednja škola - Brus', (select Id from Opstine where NazivOpstine = N'Brus'))," +
               "(N'Srednja škola \"Sveti Sava\" - Bujanovac', (select Id from Opstine where NazivOpstine = N'Bujanovac'))," +
               "(N'Srednja stručna škola - Crvenka', (select Id from Opstine where NazivOpstine = N'Crvenka'))," +
               "(N'Tehnička škola \"Milentije Popovic\"', (select Id from Opstine where NazivOpstine = N'Crna Trava'))," +
               "(N'Mašinsko-saobraćajna škola - Čačak', (select Id from Opstine where NazivOpstine = N'Čačak'))," +
               "(N'Škola za osnovno i srednje obrazovanje \"1. oktobar\"', (select Id from Opstine where NazivOpstine = N'Čačak'))," +
               "(N'Muzička škola \"Dr Vojislav Vučković\"', (select Id from Opstine where NazivOpstine = N'Čačak'))," +
               "(N'Tehnička škola - Čačak', (select Id from Opstine where NazivOpstine = N'Čačak'))," +
               "(N'Prehrambeno - ugostiteljska škola - Čačak', (select Id from Opstine where NazivOpstine = N'Čačak'))," +
               "(N'Medicinska škola - Čačak', (select Id from Opstine where NazivOpstine = N'Čačak'))," +
               "(N'Ekonomska škola - Čačak', (select Id from Opstine where NazivOpstine = N'Čačak'))," +
               "(N'Gimnazija - Čačak', (select Id from Opstine where NazivOpstine = N'Čačak'))," +
               "(N'Ugostiteljsko - turistička škola - Čajetina', (select Id from Opstine where NazivOpstine = N'Čajetina'))," +
               "(N'Hemijsko - prehrambena srednja škola - Čoka', (select Id from Opstine where NazivOpstine = N'Čoka'))," +
               "(N'Ekonomsko - trgovinska škola Kruševac', (select Id from Opstine where NazivOpstine = N'Ćićevac'))," +
               "(N'Škola za muzičke talente - Ćuprija', (select Id from Opstine where NazivOpstine = N'Ćuprija'))," +
               "(N'Medicinska škola \"Danilo Dimitrijević\"', (select Id from Opstine where NazivOpstine = N'Ćuprija'))," +
               "(N'Tehnička škola - Ćuprija', (select Id from Opstine where NazivOpstine = N'Ćuprija'))," +
               "(N'Gimnazija - Ćuprija', (select Id from Opstine where NazivOpstine = N'Ćuprija'))," +
               "(N'Tehnička škola - Despotovac', (select Id from Opstine where NazivOpstine = N'Despotovac'))," +
               "(N'Gimnazija \"Sveti Kirilo i Metodije\"', (select Id from Opstine where NazivOpstine = N'Dimitrovgrad'))," +
               "(N'Ekonomska škola Niš', (select Id from Opstine where NazivOpstine = N'Doljevac'))," +
               "(N'Ekonomsko - trgovinska škola - Dragaš', (select Id from Opstine where NazivOpstine = N'Dragaš'))," +
               "(N'Ekonomska škola - Goraždevac', (select Id from Opstine where NazivOpstine = N'Goraždevac'))," +
               "(N'Gimnazija - Goraždevac', (select Id from Opstine where NazivOpstine = N'Goraždevac'))," +
               "(N'Tehnička škola \"Dragi Popovic\"', (select Id from Opstine where NazivOpstine = N'Gornje Kušće'))," +
               "(N'Tehnička škola \"Jovan Žujovic\"', (select Id from Opstine where NazivOpstine = N'Gornji Milanovac'))," +
               "(N'Ekonomsko - trgovacka škola \"Knjaz Miloš\"', (select Id from Opstine where NazivOpstine = N'Gornji Milanovac'))," +
               "(N'Gimnazija \"Takovski ustanak\"', (select Id from Opstine where NazivOpstine = N'Gornji Milanovac'))," +
               "(N'Srednja škola - Grdelica', 97)," +
               "(N'Srednja škola \"Dragacevo\"', 100)," +
               "(N'Ptehnička škola \"Mihajlo Pupin\" - Inđija', (select Id from Opstine where NazivOpstine = N'Inđija'))," +
               "(N'Gimnazija - Inđija', (select Id from Opstine where NazivOpstine = N'Inđija'))," +
               "(N'Srednja škola \"Dr Ðorde Natošević\"', (select Id from Opstine where NazivOpstine = N'Inđija'))," +
               "(N'Srednja stručna škola \"Borislav Mihajlović Mihiz\"', (select Id from Opstine where NazivOpstine = N'Irig'))," +
               "(N'Tehnička škola - Ivanjica', (select Id from Opstine where NazivOpstine = N'Ivanjica'))," +
               "(N'Gimnazija - Ivanjica', (select Id from Opstine where NazivOpstine = N'Ivanjica'))," +
               "(N'Škola \"11. maj\" - Jagodina', (select Id from Opstine where NazivOpstine = N'Jagodina'))," +
               "(N'Ekonomsko - trgovinska škola \"Slavka Ðurdević\"', (select Id from Opstine where NazivOpstine = N'Jagodina'))," +
               "(N'Prva tehnička škola - Jagodina', (select Id from Opstine where NazivOpstine = N'Jagodina'))," +
               "(N'Elektrotehnička i gradevinska škola \"Nikola Tesla\" - Jagodina', (select Id from Opstine where NazivOpstine = N'Jagodina'))," +
               "(N'Gimnazija \"Svetozar Marković\" - Jagodina', (select Id from Opstine where NazivOpstine = N'Jagodina'))," +
               "(N'Poljoprivredno - tehnički srednjoškolski centar \"Besedeš Jožef\"', (select Id from Opstine where NazivOpstine = N'Kanjiža'))," +
               "(N'Gimnazija \"Dušan Vasiljev\"', (select Id from Opstine where NazivOpstine = N'Kikinda'))," +
               "(N'Tehnička škola - Kikinda', (select Id from Opstine where NazivOpstine = N'Kikinda'))," +
               "(N'Srednja stručna škola \"Miloš Crnjanski\" - Kikinda', (select Id from Opstine where NazivOpstine = N'Kikinda'))," +
               "(N'Ekonomsko - trgovinska škola - Kikinda', (select Id from Opstine where NazivOpstine = N'Kikinda'))," +
               "(N'Srednja škola \"Sveti Sava\" - Kladovo', (select Id from Opstine where NazivOpstine = N'Kladovo'))," +
               "(N'Tehnička škola - Kladovo', (select Id from Opstine where NazivOpstine = N'Kladovo'))," +
               "(N'Srednja škola - Knić', (select Id from Opstine where NazivOpstine = N'Knić'))," +
               "(N'Tehnička škola - Knjaževac', (select Id from Opstine where NazivOpstine = N'Knjaževac'))," +
               "(N'Knjaževacka gimnazija', (select Id from Opstine where NazivOpstine = N'Knjaževac'))," +
               "(N'Srednja škola - Koceljeva', (select Id from Opstine where NazivOpstine = N'Koceljeva'))," +
               "(N'Tehnička škola - Kosjerić', (select Id from Opstine where NazivOpstine = N'Kosjerić'))," +
               "(N'Tehnička škola - Kosovska Kamenica', (select Id from Opstine where NazivOpstine = N'Kosovska Kamenica'))," +
               "(N'Gimnazija - Kosovska Kamenica', (select Id from Opstine where NazivOpstine = N'Kosovska Kamenica'))," +
               "(N'Škola za osnovno i srednje obrazovanje \"Kosovski Božur\"', (select Id from Opstine where NazivOpstine = N'Kosovska Mitrovica'))," +
               "(N'Muzička škola \"Miodrag Vasiljević\"', (select Id from Opstine where NazivOpstine = N'Kosovska Mitrovica'))," +
               "(N'Ekonomsko - trgovinska škola - Kosovska Mitrovica', (select Id from Opstine where NazivOpstine = N'Kosovska Mitrovica'))," +
               "(N'Medicinska škola - Kosovska Mitrovica', (select Id from Opstine where NazivOpstine = N'Kosovska Mitrovica'))," +
               "(N'Tehnička škola \"Mihailo Petrović Alas\"', (select Id from Opstine where NazivOpstine = N'Kosovska Mitrovica'))," +
               "(N'Gimnazija - Kosovska Mitrovica', (select Id from Opstine where NazivOpstine = N'Kosovska Mitrovica'))," +
               "(N'Gimnazija i tehnička škola - Kosovska Mitrovica', (select Id from Opstine where NazivOpstine = N'Kosovska Mitrovica'))," +
               "(N'Gimnazija \"Mihajlo Pupin\" - Kovacica', (select Id from Opstine where NazivOpstine = N'Kovačica'))," +
               "(N'Srednja stručna škola \"Vasa Pelagic\" - Kovin', (select Id from Opstine where NazivOpstine = N'Kovin'))," +
               "(N'Gimnazija i ekonomska škola \"Branko Radicevic\" - Kovin', (select Id from Opstine where NazivOpstine = N'Kovin'))," +
               "(N'Škola za osnovno i srednje obrazovanje \"Vukašin Marković\"', (select Id from Opstine where NazivOpstine = N'Kragujevac'))," +
               "(N'Škola za ucenike oštecenog sluha - Kragujevac', (select Id from Opstine where NazivOpstine = N'Kragujevac'))," +
               "(N'Muzička škola \"Dr Miloje Milojevic\"', (select Id from Opstine where NazivOpstine = N'Kragujevac'))," +
               "(N'Politehnička škola - Kragujevac', (select Id from Opstine where NazivOpstine = N'Kragujevac'))," +
               "(N'Trgovinsko - ugostiteljska škola \"Toza Dragovic\"', (select Id from Opstine where NazivOpstine = N'Kragujevac'))," +
               "(N'Prva tehnička škola - Kragujevac', (select Id from Opstine where NazivOpstine = N'Kragujevac'))," +
               "(N'Druga tehnička škola - Kragujevac', (select Id from Opstine where NazivOpstine = N'Kragujevac'))," +
               "(N'Prva kragujevacka gimnazija', (select Id from Opstine where NazivOpstine = N'Kragujevac'))," +
               "(N'Druga kragujevacka gimnazija', (select Id from Opstine where NazivOpstine = N'Kragujevac'))," +
               "(N'Medicinska škola \"Sestre Ninkovic\"', (select Id from Opstine where NazivOpstine = N'Kragujevac'))," +
               "(N'Ekonomska škola - Kragujevac', (select Id from Opstine where NazivOpstine = N'Kragujevac'))," +
               "(N'Škola za osnovno i srednje obrazovanje \"Ivo Lola Ribar\" - Kraljevo', (select Id from Opstine where NazivOpstine = N'Kraljevo'))," +
               "(N'Muzička škola \"Stevan Mokranjac\" - Kraljevo', (select Id from Opstine where NazivOpstine = N'Kraljevo'))," +
               "(N'Gimnazija - Kraljevo', (select Id from Opstine where NazivOpstine = N'Kraljevo'))," +
               "(N'Poljoprivredno - hemijska škola \"Dr Ðorde Radic\"', (select Id from Opstine where NazivOpstine = N'Kraljevo'))," +
               "(N'Medicinska škola - Kraljevo', (select Id from Opstine where NazivOpstine = N'Kraljevo'))," +
               "(N'Ekonomsko - trgovinska škola - Kraljevo', (select Id from Opstine where NazivOpstine = N'Kraljevo'))," +
               "(N'Šumarska škola - Kraljevo', (select Id from Opstine where NazivOpstine = N'Kraljevo'))," +
               "(N'Elektro - saobraćajna škola \"Nikola Tesla\" - Kraljevo', (select Id from Opstine where NazivOpstine = N'Kraljevo'))," +
               "(N'Mašinska tehnička škola \"14. oktobar\" - Kraljevo', (select Id from Opstine where NazivOpstine = N'Kraljevo'))," +
               "(N'Srednja škola - Krupanj', (select Id from Opstine where NazivOpstine = N'Krupanj'))," +
               "(N'Škola za osnovno i srednje obrazovanje \"Veselin Nikolic\"', (select Id from Opstine where NazivOpstine = N'Kruševac'))," +
               "(N'Hemijsko - tehnološka škola - Krušavac', (select Id from Opstine where NazivOpstine = N'Kruševac'))," +
               "(N'Muzička škola \"Stevan Hristic\"', (select Id from Opstine where NazivOpstine = N'Kruševac'))," +
               "(N'Medicinska škola - Kruševac', (select Id from Opstine where NazivOpstine = N'Kruševac'))," +
               "(N'Prva tehnička škola - Krušavac', (select Id from Opstine where NazivOpstine = N'Kruševac'))," +
               "(N'Ekonomsko - trgovinska škola - Krušavac', (select Id from Opstine where NazivOpstine = N'Kruševac'))," +
               "(N'Gimnazija - Krušavac', (select Id from Opstine where NazivOpstine = N'Kruševac'))," +
               "(N'Politehnička škola “Milutin Milankovic\" - Krušavac', (select Id from Opstine where NazivOpstine = N'Kruševac'))," +
               "(N'Ekonomsko-trgovinska i mašinska škola - Kučevo', (select Id from Opstine where NazivOpstine = N'Kučevo'))," +
               "(N'Srednja tehnička škola \"Mihajlo Pupin\" - Kula', (select Id from Opstine where NazivOpstine = N'Kula'))," +
               "(N'Ekonomsko - trgovinska škola - Kula', (select Id from Opstine where NazivOpstine = N'Kula'))," +
               "(N'Gimnazija - Kuršumlija', (select Id from Opstine where NazivOpstine = N'Kuršumlija'))," +
               "(N'Ekonomska škola - Kuršumlija', (select Id from Opstine where NazivOpstine = N'Kuršumlija'))," +
               "(N'Gimnazija - Kuršumlija', (select Id from Opstine where NazivOpstine = N'Kuršumlija'))," +
               "(N'Tehnička škola “Ðuro Ðaković\"', (select Id from Opstine where NazivOpstine = N'Kuršumlija'))," +
               "(N'Tehnička škola sa domom učenika \"Nikola Tesla\" - Kostolac', (select Id from Opstine where NazivOpstine = N'Kostolac'))," +
               "(N'Srednja škola \"17. septembar\" - Lajkovac', (select Id from Opstine where NazivOpstine = N'Lajkovac'))," +
               "(N'Srednja škola - Lapovo', (select Id from Opstine where NazivOpstine = N'Lapovo'))," +
               "(N'Srednja škola \"Vožd Karadorde\" - Lebane', (select Id from Opstine where NazivOpstine = N'Lebane'))," +
               "(N'Gimnazija - Lebane', (select Id from Opstine where NazivOpstine = N'Lebane'))," +
               "(N'Srednja škola \"Nikola Tesla\" - Leposavic', (select Id from Opstine where NazivOpstine = N'Leposavić'))," +
               "(N'Poljoprivredna škola Priština - Lešak', 96)," +
                "(N'Medicinska škola - Leskovac', (select Id from Opstine where NazivOpstine = N'Leskovac'))," +
                "(N'Muzička škola \"Stanislav Binicki\"', (select Id from Opstine where NazivOpstine = N'Leskovac'))," +
                "(N'Škola za tekstil i dizajn - Leskovac', (select Id from Opstine where NazivOpstine = N'Leskovac'))," +
                "(N'Trgovinsko - ugostiteljska škola - Leskovac', (select Id from Opstine where NazivOpstine = N'Leskovac'))," +
                "(N'Škola za osnovno i srednje obrazovanje \"11. oktobar\" - Leskovac', (select Id from Opstine where NazivOpstine = N'Leskovac'))," +
                "(N'Tehnička škola \"Rade Metalac', (select Id from Opstine where NazivOpstine = N'Leskovac'))," +
               "(N'Poljoprivredna škola - Leskovac', (select Id from Opstine where NazivOpstine = N'Leskovac'))," +
               "(N'Hemijsko - tehnološka škola \"Božidar Ðordevic Kukar\"', (select Id from Opstine where NazivOpstine = N'Leskovac'))," +
               "(N'Gimnazija - Leskovac', (select Id from Opstine where NazivOpstine = N'Leskovac'))," +
               "(N'Srednja škola \"Vuk Karadžic\" - Ljubovija', (select Id from Opstine where NazivOpstine = N'Ljubovija'))," +
               "(N'Srednja škola \"Sveti Sava\" - Loznica', (select Id from Opstine where NazivOpstine = N'Loznica'))," +
               "(N'Tehnička škola - Loznica', (select Id from Opstine where NazivOpstine = N'Loznica'))," +
               "(N'Gimnazija \"Vuk Karadžic\" - Loznica', (select Id from Opstine where NazivOpstine = N'Loznica'))," +
               "(N'Srednja ekonomska škola - Loznica', (select Id from Opstine where NazivOpstine = N'Loznica'))," +
               "(N'Gimnazija \"Mile Arsenijevic Bandera\"', (select Id from Opstine where NazivOpstine = N'Majdanpek'))," +
               "(N'Tehnička škola - Majdanpek', (select Id from Opstine where NazivOpstine = N'Majdanpek'))," +
               "(N'Srednja škola - Mali Zvornik', (select Id from Opstine where NazivOpstine = N'Mali Zvornik'))," +
               "(N'Gimnazija \"Vuk Karadžic\" - Loznica', (select Id from Opstine where NazivOpstine = N'Loznica'))," +
               "(N'Gimnazija \"Vuk Karadžic\" - Loznica', (select Id from Opstine where NazivOpstine = N'Loznica'))," +
               "(N'Srednja škola – Žitorada', (select id from Opstine where NazivOpstine = N'Žitorađa'))," +
               "(N'Tehnička škola - Žagubica', (select id from Opstine where NazivOpstine = N'Žagubica'))," +
               "(N'Srednja škola \"22. oktobar\" - Žabalj', (select id from Opstine where NazivOpstine = N'Žabalj'))," +
               "(N'Srednja škola – Zvecan', (select id from Opstine where NazivOpstine = N'Zvečan'))," +
               "(N'Srednja škola \"Grigorije Božovic\" - Zubin Potok', (select id from Opstine where NazivOpstine = N'Zubin Potok '))," +
               "(N'Hemijsko-prehrambena i tekstilna škola \"Uroš Predic\" - Zrenjanin', (select id from Opstine where NazivOpstine = N'Zrenjanin'))," +
               "(N'Osnovna i srednja škola \"9. maj\" - Zrenjanin', (select id from Opstine where NazivOpstine = N'Zrenjanin'))," +
               "(N'Tehnička škola - Zrenjanin', (select id from Opstine where NazivOpstine = N'Zrenjanin'))," +
               "(N'Zrenjaninska gimnazija', (select id from Opstine where NazivOpstine = N'Zrenjanin'))," +
               "(N'Poljoprivredna škola - Zrenjanin', (select id from Opstine where NazivOpstine = N'Zrenjanin'))," +
               "(N'Medicinska škola - Zrenjanin', (select id from Opstine where NazivOpstine = N'Zrenjanin'))," +
               "(N'Elektrotehnička i gradevinska škola \"Nikola Tesla\" - Zrenjanin', (select id from Opstine where NazivOpstine = N'Zrenjanin'))," +
               "(N'Ekonomsko-trgovinska škola \"Jovan Trajkovic\" - Zrenjanin', (select id from Opstine where NazivOpstine = N'Zrenjanin'))," +
               "(N'Muzička škola \"Josif Marinkovic\" - Zrenjanin', (select id from Opstine where NazivOpstine = N'Zrenjanin'))," +
               "(N'Škola za osnovno i srednje obrazovanje \"Jelena Majstorovic\" Zaječar', (select id from Opstine where NazivOpstine = N'Zaječar'))," +
               "(N'Medicinska škola - Zaječar', (select id from Opstine where NazivOpstine = N'Zaječar'))," +
               "(N'Ekonomsko-trgovinska škola - Zaječar', (select id from Opstine where NazivOpstine = N'Zaječar'))," +
               "(N'Tehnička škola - Zaječar', (select id from Opstine where NazivOpstine = N'Zaječar'))," +
               "(N'Gimnazija - Zaječar', (select id from Opstine where NazivOpstine = N'Zaječar'))," +
               "(N'Medicinska škola - Veliko Ropotovo', 82)," +
               "(N'Srednja škola \"Svetozar Krstic Toza\" - Leskovac', 97)," +
               "(N'Školski centar \"Nikola Tesla\" - Vršac', (select id from Opstine where NazivOpstine = N'Vršac'))," +
               "(N'Poljoprivredna škola \"Vršac\"', (select id from Opstine where NazivOpstine = N'Vršac'))," +
               "(N'Hemijsko-medicinska škola - Vršac', (select id from Opstine where NazivOpstine = N'Vršac'))," +
               "(N'Gimnazija \"Borislav Petrov Braca\" - Vršac', (select id from Opstine where NazivOpstine = N'Vršac'))," +
               "(N'Škola za osnovno i srednje obrazovanje \"Jelena Varjaški\" - Vršac', (select id from Opstine where NazivOpstine = N'Vršac'))," +
               "(N'Muzička škola \"Josif Marinkovic\" - Vršac', (select id from Opstine where NazivOpstine = N'Vršac'))," +
               "(N'Ugostiteljsko-turistička škola sa domom učenika - Vrnjacka Banja', (select id from Opstine where NazivOpstine = N'Vrnjačka Banja'))," +
               "(N'Gimnazija - Vrnjacka Banja', (select id from Opstine where NazivOpstine = N'Vrnjačka Banja'))," +
               "(N'Tehnička škola - Vrbovac', 160)," +
               "(N'Gimnazija \"Žarko Zrenjanin\" - Vrbas', (select id from Opstine where NazivOpstine = N'Vrbas'))," +
               "(N'Srednja stručna škola \"4. juli\" - Vrbas', (select id from Opstine where NazivOpstine = N'Vrbas'))," +
               "(N'Muzička škola \"Stevan Mokranjac\" - Vranje', (select id from Opstine where NazivOpstine = N'Vranje'))," +
               "(N'Škola za osnovno i srednje obrazovanje \"Vule Antic\" - Vranje', (select id from Opstine where NazivOpstine = N'Vranje'))," +
               "(N'Tehnička škola - Vranje', (select id from Opstine where NazivOpstine = N'Vranje'))," +
               "(N'Srednja poljoprivredno-veterinarska škola \"Stevan Sinđelić\" - Vranje', (select id from Opstine where NazivOpstine = N'Vranje'))," +
               "(N'Medicinska škola \"Dr Izabel Emsli Haton\" - Vranje', (select id from Opstine where NazivOpstine = N'Vranje'))," +
               "(N'Hemijsko-tehnološka škola - Vranje', (select id from Opstine where NazivOpstine = N'Vranje'))," +
               "(N'Gimnazija \"Bora Stanković\" - Vranje', (select id from Opstine where NazivOpstine = N'Vranje'))," +
               "(N'Ekonomsko-trgovinska škola - Vranje', (select id from Opstine where NazivOpstine = N'Vranje'))," +
               "(N'Tehnička škola - Vlasotince', (select id from Opstine where NazivOpstine = N'Vlasotince'))," +
               "(N'Gimnazija \"Stevan Jakovljevic\" - Vlasotince', (select id from Opstine where NazivOpstine = N'Vlasotince'))," +
               "(N'Posavotamnavska srednja škola - Vladimirci', (select id from Opstine where NazivOpstine = N'Vladimirci'))," +
               "(N'Tehnička škola - Vladicin Han', 34)," +
               "(N'Gimnazija \"Jovan Skerlic\"- Vladicin Han', 34)," +
               "(N'Srednja škola - Veliko Gradište', (select id from Opstine where NazivOpstine = N'Veliko Gradište'))," +
               "(N'Tehnička škola \"Nikola Tesla\" - Velika Plana', (select id from Opstine where NazivOpstine = N'Velika Plana'))," +
               "(N'Gimnazija - Velika Plana', (select id from Opstine where NazivOpstine = N'Velika Plana'))," +
               "(N'Ekonomsko-ugostiteljska škola \"Vuk Karadžic\" - Velika Plana', (select id from Opstine where NazivOpstine = N'Velika Plana'))," +
               "(N'Srednja škola - Varvarin', (select id from Opstine where NazivOpstine = N'Varvarin'))," +
               "(N'Valjevska gimnazija', (select id from Opstine where NazivOpstine = N'Valjevo'))," +
               "(N'Tehnička škola - Valjevo', (select id from Opstine where NazivOpstine = N'Valjevo'))," +
               "(N'Medicinska škola \"Dr Miša Pantic\" - Valjevo', (select id from Opstine where NazivOpstine = N'Valjevo'))," +
               "(N'Muzička škola \"Živorad Grbic - Valjevo\"', (select id from Opstine where NazivOpstine = N'Valjevo'))," +
               "(N'Poljoprivredna škola - Valjevo', (select id from Opstine where NazivOpstine = N'Valjevo'))," +
               "(N'Ekonomska škola - Valjevo', (select id from Opstine where NazivOpstine = N'Valjevo'))," +
               "(N'Muzička škola \"Vojislav-Lale Stefanovic\" - Valjevo', (select id from Opstine where NazivOpstine = N'Valjevo'))," +
               "(N'Tehnička škola - Užice', (select id from Opstine where NazivOpstine = N'Užice'))," +
               "(N'Tehnička škola \"Radoje Ljubicic\" - Užice', (select id from Opstine where NazivOpstine = N'Užice'))," +
               "(N'Umetnička škola - Užice', (select id from Opstine where NazivOpstine = N'Užice'))," +
               "(N'Užička gimnazija - Užice', (select id from Opstine where NazivOpstine = N'Užice'))," +
               "(N'Ekonomska škola - Užice', (select id from Opstine where NazivOpstine = N'Užice'))," +
               "(N'Medicinska škola - Užice', (select id from Opstine where NazivOpstine = N'Užice'))," +
               "(N'Gimnazija \"Branislav Petronijevic - Ub\"', (select id from Opstine where NazivOpstine = N'Ub'))," +
               "(N'Tehnička škola \"Ub\"', (select id from Opstine where NazivOpstine = N'Ub'))," +
               "(N'Tehnička škola - Tutin', (select id from Opstine where NazivOpstine = N'Tutin'))," +
               "(N'Gimnazija - Tutin', (select id from Opstine where NazivOpstine = N'Tutin'))," +
               "(N'Tehnička škola - Trstenik', (select id from Opstine where NazivOpstine = N'Trstenik'))," +
               "(N'Gimnazija \"Vuk Karadžic\" - Trstenik', (select id from Opstine where NazivOpstine = N'Trstenik'))," +
               "(N'Srednja stručna škola \"Milutin Bojic\" - Trgovište', (select id from Opstine where NazivOpstine = N'Trgovište'))," +
               "(N'Srednja škola \"Kralj Petar I\" - Topola', (select id from Opstine where NazivOpstine = N'Topola'))," +
               "(N'Srednja tehnička škola \"Mileva Maric\" - Titel', (select id from Opstine where NazivOpstine = N'Titel'))," +
               "(N'Srednja škola \"Dr Lukijan Mušicki\" - Temerin', (select id from Opstine where NazivOpstine = N'Temerin'))," +
               "(N'Ekonomsko-trgovinska škola - Štrpce', (select id from Opstine where NazivOpstine = N'Štrpce'))," +
               "(N'Gimnazija - Šilovo', 45)," +
               "(N'Tehnička škola \"Nikola Tesla\" - Šid', (select id from Opstine where NazivOpstine = N'Šid'))," +
               "(N'Gimnazija \"Sava Šumanovic\" - Šid', (select id from Opstine where NazivOpstine = N'Šid'))," +
               "(N'Stručna hemijska i tekstilna škola - Šabac', (select id from Opstine where NazivOpstine = N'Šabac'))," +
               "(N'Muzička škola \"Mihailo Vukdragovic\" - Šabac', (select id from Opstine where NazivOpstine = N'Šabac'))," +
               "(N'Škola primenjenih umetnosti - Šabac', (select id from Opstine where NazivOpstine = N'Šabac'))," +
               "(N'Medicinska škola \"Dr Andra Jovanovic\" - Šabac', (select id from Opstine where NazivOpstine = N'Šabac'))," +
               "(N'Srednja poljoprivredna škola - Šabac', (select id from Opstine where NazivOpstine = N'Šabac'))," +
               "(N'Ekonomska škola \"Stana Milanovic\" - Šabac', (select id from Opstine where NazivOpstine = N'Šabac'))," +
               "(N'Šabačka gimnazija', (select id from Opstine where NazivOpstine = N'Šabac'))," +
               "(N'Tehnička škola - Šabac', (select id from Opstine where NazivOpstine = N'Šabac'))," +
               "(N'Srednja škola \"Hiljadu trista kaplara\" – Ljig',(select id from Opstine where NazivOpstine = N'Ljig'))," +
               "(N'stručna škola \"Dušan Trivunac Dragoš\" - Svrljig', (select id from Opstine where NazivOpstine = N'Svrljig'))," +
               "(N'Poljoprivredno-veterinarska škola sa domom učenika - Svilajnac', (select id from Opstine where NazivOpstine = N'Svilajnac'))," +
               "(N'Srednja škola \"Svilajnac\"', (select id from Opstine where NazivOpstine = N'Svilajnac'))," +
               "(N'Poljoprivredno-šumarska škola \"Josif Pancic\" - Surdulica', (select id from Opstine where NazivOpstine = N'Surdulica'))," +
               "(N'Tehnika škola \"Nikola Tesla\" - Surdulica', (select id from Opstine where NazivOpstine = N'Surdulica'))," +
               "(N'Gimnazija \"Svetozar Marković\" - Surdulica', (select id from Opstine where NazivOpstine = N'Surdulica'))," +
               "(N'Školski centar sa domom učenika \"Dositej Obradovic\" - Subotica', (select id from Opstine where NazivOpstine = N'Subotica'))," +
               "(N'Muzička škola - Subotica', (select id from Opstine where NazivOpstine = N'Subotica'))," +
               "(N'Osnovna i srednja škola \"Žarko Zrenjanin\" - Subotica', (select id from Opstine where NazivOpstine = N'Subotica'))," +
               "(N'Srednja medicinska škola - Subotica', (select id from Opstine where NazivOpstine = N'Subotica'))," +
               "(N'Politehnička škola - Subotica', (select id from Opstine where NazivOpstine = N'Subotica'))," +
               "(N'Hemijsko-tehnološka škola - Subotica', (select id from Opstine where NazivOpstine = N'Subotica'))," +
               "(N'Gimnazija \"Svetozar Marković\" - Subotica', (select id from Opstine where NazivOpstine = N'Subotica'))," +
               "(N'Gimnazija za talentovane ucenike \"Deže Kostolanji\" - Subotica', (select id from Opstine where NazivOpstine = N'Subotica'))," +
               "(N'Ekonomska škola \"Bosa Milicevic\" - Subotica', (select id from Opstine where NazivOpstine = N'Subotica'))," +
               "(N'Tehnička škola \"Ivan Saric\" - Subotica', (select id from Opstine where NazivOpstine = N'Subotica'))," +
               "(N'Ekonomsko-trgovinska škola \"Vuk Karadžic\" - Stara Pazova', (select id from Opstine where NazivOpstine = N'Stara Pazova'))," +
               "(N'Tehnička škola - Stara Pazova', (select id from Opstine where NazivOpstine = N'Stara Pazova'))," +
               "(N'Gimnazija \"Branko Radicevic\" - Stara Pazova', (select id from Opstine where NazivOpstine = N'Stara Pazova'))," +
               "(N'Škola za osnovno i srednje obrazovanje \"Anton Skala\" - Stara Pazova', (select id from Opstine where NazivOpstine = N'Stara Pazova'))," +
               "(N'Srednja škola \"Ðura Jakšic\" - Nova Crnja', 115)," +
               "(N'Karlovacka gimnazija - Sremski Karlovci', (select id from Opstine where NazivOpstine = N'Sremski Karlovci'))," +
               "(N'Ekonomska škola \"9. maj\" - Sremska Mitrovica', (select id from Opstine where NazivOpstine = N'Sremska Mitrovica'))," +
               "(N'Mitrovacka gimnazija - Sremska Mitrovica', (select id from Opstine where NazivOpstine = N'Sremska Mitrovica'))," +
               "(N'Srednja tehnička škola \"Nikola Tesla\" - Sremska Mitrovica', (select id from Opstine where NazivOpstine = N'Sremska Mitrovica'))," +
               "(N'Medicinska škola \"Draginja Nikšic\" - Sremska Mitrovica', (select id from Opstine where NazivOpstine = N'Sremska Mitrovica'))," +
               "(N'Škola za osnovno i srednje obrazovanje \"Radivoj Popovic\" - Sremska Mitrovica', (select id from Opstine where NazivOpstine = N'Sremska Mitrovica'))," +
               "(N'Prehrambeno-šumarska i hemijska škola - Sremska Mitrovica', (select id from Opstine where NazivOpstine = N'Sremska Mitrovica'))," +
               "(N'Muzička škola \"Petar Krancevic\" - Sremska Mitrovica', (select id from Opstine where NazivOpstine = N'Sremska Mitrovica'))," +
               "(N'Gimnazija i ekonomska škola \"Svetozar Miletic\" - Srbobran', (select id from Opstine where NazivOpstine = N'Srbobran'))," +
               "(N'Škola za osnovno i srednje obrazovanje sa domom \"Vuk Karadžic\" - Sombor', (select id from Opstine where NazivOpstine = N'Sombor'))," +
               "(N'Muzička škola \"Petar Konjovic\" - Sombor', (select id from Opstine where NazivOpstine = N'Sombor'))," +
               "(N'Srednja škola \"Sveti Sava\" - Sombor', (select id from Opstine where NazivOpstine = N'Sombor'))," +
               "(N'Gimnazija \"Veljko Petrović\" - Sombor', (select id from Opstine where NazivOpstine = N'Sombor'))," +
               "(N'Srednja poljoprivredno-prehrambena škola - Sombor', (select id from Opstine where NazivOpstine = N'Sombor'))," +
               "(N'Srednja medicinska škola \"Dr Ružica Rip\" - Sombor', (select id from Opstine where NazivOpstine = N'Sombor'))," +
               "(N'Srednja tehnička škola - Sombor', (select id from Opstine where NazivOpstine = N'Sombor'))," +
               "(N'Srednja ekonomska škola - Sombor', (select id from Opstine where NazivOpstine = N'Sombor'))," +
               "(N'Srednja škola \"Branislav Nušic\" - Sokobanja', (select id from Opstine where NazivOpstine = N'Sokobanja'))," +
               "(N'Mašinsko-elektrotehnička škola \"Goša\" - Smederevska Palanka', (select id from Opstine where NazivOpstine = N'Smederevska Palanka'))," +
               "(N'Srednja škola \"Žikica Damjanovic\" - Smederevska Palanka', (select id from Opstine where NazivOpstine = N'Smederevska Palanka'))," +
               "(N'Palanacka gimnazija', (select id from Opstine where NazivOpstine = N'Smederevska Palanka'))," +
               "(N'Tekstilno-tehnološka i poljoprivredna škola \"Despot Ðurad\" - Smederevo', (select id from Opstine where NazivOpstine = N'Smederevo'))," +
               "(N'Muzička škola \"Kosta Manojlovic\" - Smederevo', (select id from Opstine where NazivOpstine = N'Smederevo'))," +
               "(N'Ekonomsko-trgovinska škola - Smederevo', (select id from Opstine where NazivOpstine = N'Smederevo'))," +
               "(N'Tehnička škola - Smederevo', (select id from Opstine where NazivOpstine = N'Smederevo'))," +
               "(N'Gimnazija - Smederevo', (select id from Opstine where NazivOpstine = N'Smederevo'))," +
               "(N'Tehnicko-poljoprivredna škola - Sjenica', (select id from Opstine where NazivOpstine = N'Sjenica'))," +
               "(N'Gimnazija \"Jezdimir Lovic\" - Sjenica', (select id from Opstine where NazivOpstine = N'Sjenica'))," +
               "(N'Senčanska gimnazija - Senta', (select id from Opstine where NazivOpstine = N'Senta'))," +
               "(N'Srednja medicinska škola - Senta', (select id from Opstine where NazivOpstine = N'Senta'))," +
               "(N'Gimnazija sa domom učenika za talentovane ucenike \"Boljai\" - Senta', (select id from Opstine where NazivOpstine = N'Senta'))," +
               "(N'Ekonomsko-trgovinska škola - Senta', (select id from Opstine where NazivOpstine = N'Senta'))," +
               "(N'Srednja škola \"Vuk Karadžic\" - Secanj', (select id from Opstine where NazivOpstine = N'Sečanj'))," +
               "(N'Srednja škola sa domom učenika “Petro Kuzmjak\" - Ruski Krstur', 89)," +
               "(N'Gimnazija \"Stevan Puzic\" - Ruma', (select id from Opstine where NazivOpstine = N'Ruma'))," +
               "(N'Srednja stručna škola \"Branko Radicevic\" - Ruma', (select id from Opstine where NazivOpstine = N'Ruma'))," +
               "(N'Srednja poljoprivredno-prehrambena škola \"Stevan Petrović Brile\" - Ruma', (select id from Opstine where NazivOpstine = N'Ruma'))," +
               "(N'Srednja tehnička škola \"Milenko Brzak-Uca\" - Ruma', (select id from Opstine where NazivOpstine = N'Ruma'))," +
               "(N'Poljoprivedno-veterinarska škola - Rekovac', (select id from Opstine where NazivOpstine = N'Rekovac'))," +
               "(N'Srednja škola “Kraljica Jelena\" - Raška', (select id from Opstine where NazivOpstine = N'Raška'))," +
               "(N'Gimnazija - Raška', (select id from Opstine where NazivOpstine = N'Raška'))," +
               "(N'Ekonomsko-trgovinska škola Gnjilane – Ranilug', 82)," +
               "(N'Srednja škola \"Ðura Jakšic\" - Raca', (select id from Opstine where NazivOpstine = N'Rača'))," +
               "(N'Poljoprivredna škola \"Radoš Jovanovic Selja\" - Prokuplje', (select id from Opstine where NazivOpstine = N'Prokuplje'))," +
               "(N'Medicinska škola \"Dr Aleksa Savic\" - Prokuplje', (select id from Opstine where NazivOpstine = N'Prokuplje'))," +
               "(N'Tehnička škola \"15. maj\" - Prokuplje', (select id from Opstine where NazivOpstine = N'Prokuplje'))," +
               "(N'Gimnazija - Prokuplje', (select id from Opstine where NazivOpstine = N'Prokuplje'))," +
               "(N'Ekonomsko-trgovinska škola – Laplje selo (izmeštena iz Prištine)', (select id from Opstine where NazivOpstine = N'Priština'))," +
               "(N'Gimnazija – Laplje selo (izmeštena iz Prištine)', (select id from Opstine where NazivOpstine = N'Priština'))," +
               "(N'Gradevinsko-saobraćajna škola – Gracanica (izmeštena iz Prištine)', (select id from Opstine where NazivOpstine = N'Priština'))," +
               "(N'Medicinska škola – Gracanica (izmeštena iz Prištine)', (select id from Opstine where NazivOpstine = N'Priština'))," +
               "(N'Mašinska škola – Preoce (izmeštena iz Prištine)', (select id from Opstine where NazivOpstine = N'Priština'))," +
               "(N'Elektrotehnička škola “Mihajlo Pupin\" – Sušica (izmeštena iz Prištine)', (select id from Opstine where NazivOpstine = N'Priština'))," +
               "(N'Muzička škola “Stevan Mokranjac\" – Gracanica (izmeštena iz Prištine)', (select id from Opstine where NazivOpstine = N'Priština'))," +
               "(N'Tehnička škola \"Nikola Tesla\" - Prilužje', 42)," +
               "(N'Tehnička škola - Prijepolje', (select id from Opstine where NazivOpstine = N'Prijepolje'))," +
               "(N'Prijepoljska gimnazija', (select id from Opstine where NazivOpstine = N'Prijepolje'))," +
               "(N'Ekonomsko-trgovinska škola - Prijepolje', (select id from Opstine where NazivOpstine = N'Prijepolje'))," +
               "(N'Mašinsko-elektrotehnička škola - Priboj', (select id from Opstine where NazivOpstine = N'Priboj na Limu'))," +
               "(N'Gimnazija - Priboj', (select id from Opstine where NazivOpstine = N'Priboj na Limu'))," +
               "(N'Srednja tehnička škola \"Preševo\"', (select id from Opstine where NazivOpstine = N'Preševo'))," +
               "(N'Gimnazija \"Skenderbeu\" - Preševo', (select id from Opstine where NazivOpstine = N'Preševo'))," +
               "(N'Poljoprivredna škola sa domom učenika \"Dr Ljubo Micic\" - Požega', (select id from Opstine where NazivOpstine = N'Požega'))," +
               "(N'Tehnička škola - Požega', (select id from Opstine where NazivOpstine = N'Požega'))," +
               "(N'Gimnazija \"Sveti Sava\" - Požega', (select id from Opstine where NazivOpstine = N'Požega'))," +
               "(N'Škola za osnovno i srednje muzicko obrazovanje \"Stevan Mokranjac\" - Požarevac', (select id from Opstine where NazivOpstine = N'Požarevac'))," +
               "(N'Politehnička škola - Požarevac', (select id from Opstine where NazivOpstine = N'Požarevac'))," +
               "(N'Ekonomsko-trgovinska škola - Požarevac', (select id from Opstine where NazivOpstine = N'Požarevac'))," +
               "(N'Poljoprivredna škola sa domom učenika \"Sonja Marinkovic\" - Požarevac', (select id from Opstine where NazivOpstine = N'Požarevac'))," +
               "(N'Medicinska škola - Požarevac', (select id from Opstine where NazivOpstine = N'Požarevac'))," +
               "(N'Požarevačka gimnazija', (select id from Opstine where NazivOpstine = N'Požarevac'))," +
               "(N'Škola za osnovno i srednje obrazovanje \"Mladost\" - Pirot', (select id from Opstine where NazivOpstine = N'Pirot'))," +
               "(N'Mlekarska škola sa domom učenika \"Dr Obren Pejic\" - Pirot', (select id from Opstine where NazivOpstine = N'Pirot'))," +
               "(N'Tehnička škola - Pirot', (select id from Opstine where NazivOpstine = N'Pirot'))," +
               "(N'Srednja stručna škola - Pirot', (select id from Opstine where NazivOpstine = N'Pirot'))," +
               "(N'Ekonomska škola - Pirot', (select id from Opstine where NazivOpstine = N'Pirot'))," +
               "(N'Gimnazija - Pirot', (select id from Opstine where NazivOpstine = N'Pirot'))," +
               "(N'Srednja škola \"Mladost\" - Petrovac', (select id from Opstine where NazivOpstine = N'Bački Petrovac'))," +
               "(N'Tehnička škola \"Milenko Verkic Neša\" - Pecinci', (select id from Opstine where NazivOpstine = N'Pećinci'))," +
               "(N'Tehnološka škola - Paracin', (select id from Opstine where NazivOpstine = N'Paraćin'))," +
               "(N'Ekonomsko-trgovinska škola - Paracin', (select id from Opstine where NazivOpstine = N'Paraćin'))," +
               "(N'Mašinsko-elektrotehnička škola - Paracin', (select id from Opstine where NazivOpstine = N'Paraćin'))," +
               "(N'Gimnazija - Paracin', (select id from Opstine where NazivOpstine = N'Paraćin'))," +
               "(N'Mašinska škola \"Pancevo\"', (select id from Opstine where NazivOpstine = N'Pančevo'))," +
               "(N'Poljoprivredna škola \"Josif Pancic\"', (select id from Opstine where NazivOpstine = N'Pančevo'))," +
               "(N'Medicinska škola \"Stevica Jovanovic\" - Pancevo', (select id from Opstine where NazivOpstine = N'Pančevo'))," +
               "(N'Tehnička škola \"23. maj\" - Pancevo', (select id from Opstine where NazivOpstine = N'Pančevo'))," +
               "(N'Gimnazija \"Uroš Predic\" - Pancevo', (select id from Opstine where NazivOpstine = N'Pančevo'))," +
               "(N'Elektrotehnička škola \"Nikola Tesla\" - Pancevo', (select id from Opstine where NazivOpstine = N'Pančevo'))," +
               "(N'Ekonomsko-trgovinska škola \"Paja Marganovic\" - Pancevo', (select id from Opstine where NazivOpstine = N'Pančevo'))," +
               "(N'Muzička škola \"Jovan Bandur\" - Pancevo', (select id from Opstine where NazivOpstine = N'Pančevo'))," +
               "(N'Baletska škola \"Dimitrije Parlic\" - Pancevo', (select id from Opstine where NazivOpstine = N'Pančevo'))," +
               "(N'Škola za osnovno i srednje obrazovanje \"Mara Mandic\" - Pancevo', (select id from Opstine where NazivOpstine = N'Pančevo'))," +
               "(N'Ekonomska škola \"Valjevo\" - Osecina', (select id from Opstine where NazivOpstine = N'Osečina'))," +
               "(N'Gimnazija - Orahovac', (select id from Opstine where NazivOpstine = N'Orahovac'))," +
               "(N'Tehnička škola - Odžaci', (select id from Opstine where NazivOpstine = N'Odžaci'))," +
               "(N'Gimnazija i ekonomska škola \"Jovan Jovanovic Zmaj\" - Odžaci', (select id from Opstine where NazivOpstine = N'Odžaci'))," +
               "(N'Gimnazija \"Jovan Jovanovic Zmaj\" - Novi Sad', (select id from Opstine where NazivOpstine = N'Novi Sad'))," +
               "(N'Gimnazija \"Svetozar Marković\" - Novi Sad', (select id from Opstine where NazivOpstine = N'Novi Sad'))," +
               "(N'Gimnazija \"Isidora Sekulic\" - Novi Sad', (select id from Opstine where NazivOpstine = N'Novi Sad'))," +
               "(N'Gimnazija \"Laza Kostic\" - Novi Sad', (select id from Opstine where NazivOpstine = N'Novi Sad'))," +
               "(N'Srednja škola \"Svetozar Miletic\" - Novi Sad', (select id from Opstine where NazivOpstine = N'Novi Sad'))," +
               "(N'Medicinska škola \"7. april\" - Novi Sad', (select id from Opstine where NazivOpstine = N'Novi Sad'))," +
               "(N'Poljoprivredna škola sa domom učenika (Futog) - Novi Sad', (select id from Opstine where NazivOpstine = N'Novi Sad'))," +
               "(N'Srednja mašinska škola - Novi Sad', (select id from Opstine where NazivOpstine = N'Novi Sad'))," +
               "(N'Elektrotehnica škola \"Mihajlo Pupin\" - Novi Sad', (select id from Opstine where NazivOpstine = N'Novi Sad'))," +
               "(N'Tehnička škola \"Pavle Savic\" - Novi Sad', (select id from Opstine where NazivOpstine = N'Novi Sad'))," +
               "(N'Tehnička škola \"Mileva Maric-Ajnštajn\" - Novi Sad', (select id from Opstine where NazivOpstine = N'Novi Sad'))," +
               "(N'Saobraćajna škola \"Pinki\" - Novi Sad', (select id from Opstine where NazivOpstine = N'Novi Sad'))," +
               "(N'Muzička škola \"Isidor Bajic\" - Novi Sad', (select id from Opstine where NazivOpstine = N'Novi Sad'))," +
               "(N'Baletska škola - Novi Sad', (select id from Opstine where NazivOpstine = N'Novi Sad'))," +
               "(N'Škola za dizajn \"Bogdan Šuput\" - Novi Sad', (select id from Opstine where NazivOpstine = N'Novi Sad'))," +
               "(N'Škola za osnovno i srednje obrazovanje \"Milan Petrović\" Novi Sad', (select id from Opstine where NazivOpstine = N'Novi Sad'))," +
               "(N'Medicinska škola - Novi Pazar', (select id from Opstine where NazivOpstine = N'Novi Pazar'))," +
               "(N'Škola za dizajn tekstila i kože - Novi Pazar', (select id from Opstine where NazivOpstine = N'Novi Pazar'))," +
               "(N'Ugostiteljsko-turistička škola - Novi Pazar', (select id from Opstine where NazivOpstine = N'Novi Pazar'))," +
               "(N'Tehnička škola - Novi Pazar', (select id from Opstine where NazivOpstine = N'Novi Pazar'))," +
               "(N'Ekonomsko-trgovinska škola - Novi Pazar', (select id from Opstine where NazivOpstine = N'Novi Pazar'))," +
               "(N'Gimnazija - Novi Pazar', (select id from Opstine where NazivOpstine = N'Novi Pazar'))," +
               "(N'Gimnazija - Novi Kneževac', (select id from Opstine where NazivOpstine = N'Novi Kneževac'))," +
               "(N'Srednja škola \"Dositej Obradovic\" - Novi Kneževac', (select id from Opstine where NazivOpstine = N'Novi Kneževac'))," +
               "(N'Srednja škola - Novi Becej', (select id from Opstine where NazivOpstine = N'Novi Bečej'))," +
               "(N'Tehnička škola - Nova Varoš', (select id from Opstine where NazivOpstine = N'Nova Varoš'))," +
               "(N'Gimnazija \"Pivo Karamatijevic\" - Nova Varoš', (select id from Opstine where NazivOpstine = N'Nova Varoš'))," +
               "(N'Prva niška gimnazija \"Stevan Sremac\" - Niš', (select id from Opstine where NazivOpstine = N'Palilula (Niš)'))," +
               "(N'Gimnazija \"Bora Stanković\" - Niš', (select id from Opstine where NazivOpstine = N'Palilula (Niš)'))," +
               "(N'Gimnazija \"Svetozar Marković\" - Niš', (select id from Opstine where NazivOpstine = N'Palilula (Niš)'))," +
               "(N'Gimnazija \"9. maj\" - Niš', (select id from Opstine where NazivOpstine = N'Palilula (Niš)'))," +
               "(N'Ekonomska škola - Niš', (select id from Opstine where NazivOpstine = N'Palilula (Niš)'))," +
               "(N'Pravno-poslovna škola - Niš', (select id from Opstine where NazivOpstine = N'Palilula (Niš)'))," +
               "(N'Trgovinska škola - Niš', (select id from Opstine where NazivOpstine = N'Palilula (Niš)'))," +
               "(N'Ugostiteljsko-turistička škola - Niš', (select id from Opstine where NazivOpstine = N'Palilula (Niš)'))," +
               "(N'Medicinska škola \"Dr Milenko Hadžic\" - Niš', (select id from Opstine where NazivOpstine = N'Palilula (Niš)'))," +
               "(N'Prva tehnička škola “Milutin Milankovic\" - Niš', (select id from Opstine where NazivOpstine = N'Palilula (Niš)'))," +
               "(N'Tehnička škola \"12. februar\" - Niš', (select id from Opstine where NazivOpstine = N'Palilula (Niš)'))," +
               "(N'Mašinska škola - Niš', (select id from Opstine where NazivOpstine = N'Palilula (Niš)'))," +
               "(N'Elektrotehnička škola \"Nikola Tesla\" - Niš', (select id from Opstine where NazivOpstine = N'Palilula (Niš)'))," +
               "(N'Elektrotehnička škola \"Mija Stanimirovic\" - Niš', (select id from Opstine where NazivOpstine = N'Palilula (Niš)'))," +
               "(N'Građevinska tehnička škola \"Neimar\" - Niš', (select id from Opstine where NazivOpstine = N'Palilula (Niš)'))," +
               "(N'Prehrambeno-hemijska škola - Niš', (select id from Opstine where NazivOpstine = N'Palilula (Niš)'))," +
               "(N'Škola mode i lepote - Niš', (select id from Opstine where NazivOpstine = N'Palilula (Niš)'))," +
               "(N'Umetnička škola - Niš', (select id from Opstine where NazivOpstine = N'Palilula (Niš)'))," +
               "(N'Muzička škola - Niš', (select id from Opstine where NazivOpstine = N'Palilula (Niš)'))," +
               "(N'Škola za osnovno i srednje obrazovanje \"14. oktobar\" - Niš', (select id from Opstine where NazivOpstine = N'Palilula (Niš)'))," +
               "(N'Specijalna škola sa domom učenika \"Bubanj\" - Niš', (select id from Opstine where NazivOpstine = N'Palilula (Niš)')), " +
               "(N'Umetnička škola \"Stevan Mokranjac\" - Negotin', (select id from Opstine where NazivOpstine = N'Negotin'))," +
               "(N'Poljoprivredna škola sa domom učenika \"Rajko Bosnic\" - Negotin', (select id from Opstine where NazivOpstine = N'Negotin'))," +
               "(N'Tehnička škola - Negotin', (select id from Opstine where NazivOpstine = N'Negotin'))," +
               "(N'Negotinska gimnazija - Negotin', (select id from Opstine where NazivOpstine = N'Negotin'))");
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
