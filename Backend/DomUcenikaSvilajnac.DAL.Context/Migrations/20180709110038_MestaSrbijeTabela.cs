using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class MestaSrbijeTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mesta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivMesta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesta", x => x.Id);
                });
            migrationBuilder.Sql(
                "insert into Mesta(NazivMesta) values " +
                "('Ada')," +
                "('Adaševci')," +
                "('Adebilić')," +
                "('Adorjan Kanjiža')," +
                "('Adrani Kraljevo')," +
                "('Adrovac Rača')," +
                "('Azanja Smederevska Palanka')," +
                "('Azbresnica Merošina')," +
                "('Ajvalija Priština')," +
                "('Ajkobila Priština')," +
                "('Ajnovce Kosovska Kamenica')," +
                "('Akmačići Nova Varoš')," +
                "('Alabak Podujevo')," +
                "('Alabana Blace')," +
                "('Alagina Reka Peć')," +
                "('Alakince Surdulica')," +
                "('Aldina Reka Knjaževac')," +
                "('Aldinac Knjaževac')," +
                "('Aleksa Šantić Sombor')," +
                "('Aleksandrovac Aleksandrovac')," +
                "('Aleksandrovac Babušnica')," +
                "('Aleksandrovac Vranje')," +
                "('Aleksandrovac Žabari')," +
                "('Aleksandrovac Negotin')," +
                "('Aleksandrovo Merošina')," +
                "('Aleksandrovo Nova Crnja')," +
                "('Aleksinac Aleksinac')," +
                "('Aleksinački Bujmir Aleksina')," +
                "('Aleksinački Rudnik Aleksina')," +
                "('Aleksine Vlasotince')," +
                "('Alibunar Alibunar')," +
                "('Aliveroviće Sjenica')," +
                "('Aliđerce Preševo')," +
                "('Alin Potok Čajetina')," +
                "('Aluloviće Novi Pazar')," +
                "('Aljinovići Prijepolje')," +
                "('Aljudovo Malo Crniće')," +
                "('Amajić Mali Zvornik')," +
                "('Amerić Beograd – Mladenovac')," +
                "('Amzići Nova Varoš')," +
                "('Androvac Lipljan')," +
                "('Apatin Apatin')," +
                "('Aradac Zrenjanin')," +
                "('Aranđelovac Aranđelovac')," +
                "('Arapovac Beograd – Lazareva')," +
                "('Arapoviće Tutin')," +
                "('Arbanasce Merošina')," +
                "('Arbanaška Prokuplje')," +
                "('Ariljača Kosovo Polje')," +
                "('Arilje Arilje')," +
                "('Arnajevo Beograd – Barajevo')," +
                "('Asanovac Žitorađa')," +
                "('Atenica Čačak')," +
                "('Atmađa Prizren')," +
                "('Adžine Livade Kragujevac')," +
                "('Ašanja Pećinci')," +
                "('Ba Ljig')," +
                "('Babaj Boks Đakovica')," +
                "('Babajić Ljig')," +
                "('Babaloć Dečani')," +
                "('Babe Beograd – Sopot')," +
                "('Babin Kal Bela Palanka')," +
                "('Babin Mostbilić')," +
                "('Babin Potok Prokuplje')," +
                "('Babina Luka Valjevo')," +
                "('Babina Poljana Trgovište')," +
                "('Babina Poljana Vranjska Ban')," +
                "('Babiće Zubin Potok')," +
                "('Babiće Peć')," +
                "('Babica Kuršumlija')," +
                "('Babičko Leskovac')," +
                "('Babljak Uroševac')," +
                "('Babotinac Prokuplje')," +
                "('Babudovica Zubin Potok')," +
                "('')," +
                "('Babušnica Babušnica')," +
                "('Bavanište Kovin')," +
                "('Bagačiće Sjenica')," +
                "('Bagrdan Jagodina')," +
                "('Bagremovo Bačka Topola')," +
                "('Badanj Raška')," +
                "('Badince Leskovac')," +
                "('Badljevica Smederevo')," +
                "('Badnjevac Batočina')," +
                "('Badnjevac Žitorađa')," +
                "('Badovac Priština')," +
                "('Badovinci Bogatić')," +
                "('Bazovik Pirot')," +
                "('Bajgora Kosovska Mitrovica')," +
                "('Bajevac Lajkovac')," +
                "('Bajevica Novi Pazar')," +
                "('Bajina Bašta Bajina Bašta')," +
                "('Bajinci Crna Trava')," +
                "('Bajmok Subotica')," +
                "('Bajčetina Knić')," +
                "('Bajčina Podujevo')," +
                "('Bajčince Prokuplje')," +
                "('Bajša Bačka Topola')," +
                "('Bakionica Požega')," +
                "('Baks Srbica')," +
                "('Bakšijabilić')," +
                "('Balaban Priština')," +
                "('Balajnac Despotovac')," +
                "('Balajnac Merošina')," +
                "('Balanovac Knjaževac')," +
                "('Balance Vitina')," +
                "('Balinac Knjaževac')," +
                "('Balinovac Prokuplje')," +
                "('Balinović Valjevo')," +
                "('Balinovce Vladičin Han')," +
                "('Balince Vučitrn')," +
                "('Balince Klina')," +
                "('Balić Uroševac')," +
                "('Balići Prijepolje')," +
                "('Baličevac Merošina')," +
                "('Balovac Podujevo')," +
                "('Balosave Knić')," +
                "('Balta Berilovac Knjaževac')," +
                "('Baluga (Ljubićska) Čačak')," +
                "('Baluga (Trnavska) Čačak')," +
                "('Balčak Prokuplje')," +
                "('Baljevac Beograd –brenovac')," +
                "('Baljevac Raška')," +
                "('Baljen Tutin')," +
                "('Baljkovac Kragujevac')," +
                "('Banatska Dubica Sečanj')," +
                "('Banatska Palanka Bela Crkva')," +
                "('Banatska Subotica Bela Crkv')," +
                "('Banatska Topola Kikinda')," +
                "('Banatski Brestovac Pančevo')," +
                "('Banatski Dvor Žitište')," +
                "('Banatski Despotovac Zrenjan')," +
                "('Banatski Karlovac Alibunar')," +
                "('Banatski Monoštor Čoka')," +
                "('Banatski Sokolac Plandište')," +
                "('Banatsko Aranđelovo Novi Kn')," +
                "('Banatsko Veliko Selo Kikind')," +
                "('Banatsko Višnjićevo Žitište')," +
                "('Banatsko Karađorđevo Žitišt')," +
                "('Banatsko Novo Selo Pančevo')," +
                "('Bandulić Lipljan')," +
                "('Baničina Smederevska Palank')," +
                "('Bankovac Aleksinac')," +
                "('Bankovci Crna Trava')," +
                "('Banov Do Zvečan')," +
                "('Banovo Polje Bogatić')," +
                "('Banoštor Beočin')," +
                "('Banski Dol Dimitrovgrad')," +
                "('Bancarevo Niš – Niška Banja')," +
                "('Banja Aranđelovac')," +
                "('Banja Novi Pazar')," +
                "('Banja Priboj')," +
                "('Banja Istok')," +
                "('Banja Srbica')," +
                "('Banja Suva Reka')," +
                "('Banja Koviljača Loznica')," +
                "('Banjani Ub')," +
                "('Banje Zubin Potok')," +
                "('Banjevac Krupanj')," +
                "('Banjica Čačak')," +
                "('Banjicalogovac')," +
                "('Banjica Istok')," +
                "('Banjica Kačanik')," +
                "('Banjica Lipljan')," +
                "('Banjska Vučitrn')," +
                "('Banjska Zvečan')," +
                "('Banjska Reka Zvečan')," +
                "('Banjskirešac Knjaževac')," +
                "('Banjski Suvi Do Zvečan')," +
                "('Bapsko Polje Kraljevo')," +
                "('Baraina Podujevo')," +
                "('Barajevo Beograd – Barajevo')," +
                "('Baraljevac Bujanovac')," +
                "('Barandapovo')," +
                "('Barane Peć')," +
                "('Barbarušince Vranje')," +
                "('Barbatovac Blace')," +
                "('Barbace Trgovište')," +
                "('Bardonić Đakovica')," +
                "('Bardosan Đakovica')," +
                "('Bare Despotovac')," +
                "('Bare Knić')," +
                "('Bare Kraljevo')," +
                "('Bare Novi Pazar')," +
                "('Bare Požarevac')," +
                "('Bare Prijepolje')," +
                "('Bare Rekovac')," +
                "('Bare Sjenica')," +
                "('Bare Leposavić')," +
                "('Bare Kosovska Mitrovica')," +
                "('Barelić Vranje')," +
                "('Barzilovica Beograd – Lazar')," +
                "('Bariljevo Priština')," +
                "('Barice Plandište')," +
                "('Barič Beograd –brenovac')," +
                "('Baričolubac')," +
                "('Barje Bosilegrad')," +
                "('Barje Dimitrovgrad')," +
                "('Barje Leskovac')," +
                "('Barje Čiflik Pirot')," +
                "('Barlovo Kuršumlija')," +
                "('Baroševac Beograd – Lazarev')," +
                "('Basara Pirot')," +
                "('Bastavsečina')," +
                "('Bataire Kosovska Mitrovica')," +
                "('Batalage Koceljeva')," +
                "('Batinac Ćuprija')," +
                "('Batkovići Priboj')," +
                "('Batlava Podujevo')," +
                "('Batnjik Novi Pazar')," +
                "('Batovac Požarevac')," +
                "('Batote Brus')," +
                "('Batočina Batočina')," +
                "('Batrage Tutin')," +
                "('Batrovci Šid')," +
                "('Batulovce Vlasotince')," +
                "('Batuse Kosovo Polje')," +
                "('Batuša Malo Crniće')," +
                "('Batuša Đakovica')," +
                "('Batušinac Merošina')," +
                "('Baćevac Beograd – Barajevo')," +
                "('Baćica Tutin')," +
                "('Baćoglava Kuršumlija')," +
                "('Bace Prokuplje')," +
                "('Bacijevce Surdulica')," +
                "('Bač Bač')," +
                "('Bačvište Vladičin Han')," +
                "('Bačevina Lebane')," +
                "('Bačevica Boljevac')," +
                "('Bačevo Dimitrovgrad')," +
                "('Bačevci Bajina Bašta')," +
                "('Bačevci Valjevo')," +
                "('Bačija Sjenica')," +
                "('Bačina Varvarin')," +
                "('Bačinac Smederevska Palanka')," +
                "('Bačinci Šid')," +
                "('Bačkaora')," +
                "('Bačka Palanka Bačka Palanka')," +
                "('Bačka Topola Bačka Topola')," +
                "('Bački Breg Sombor')," +
                "('Bački Brestovacdžaci')," +
                "('Bački Vinogradi Subotica')," +
                "('Bačkiračacdžaci')," +
                "('Bački Jarak Temerin')," +
                "('Bački Monoštor Sombor')," +
                "('Bački Petrovac Bački Petrov')," +
                "('Bački Sokolac Bačka Topola')," +
                "('Bačkoradište Bečej')," +
                "('Bačko Dobro Polje Vrbas')," +
                "('Bačko Dušanovo Subotica')," +
                "('Bačko Novo Selo Bač')," +
                "('Bačko Petrovo Selo Bečej')," +
                "('Bašaid Kikinda')," +
                "('Bašin Smederevska Palanka')," +
                "('Baščeluci Loznica')," +
                "('Begaljica Beograd –rocka')," +
                "('Begeč Novi Sad')," +
                "('Begov Lukavac Istok')," +
                "('Begovo Brdo Kruševac')," +
                "('Begunce Vitina')," +
                "('Bedina Varoš Ivanjica')," +
                "('Bežište Bela Palanka')," +
                "('Bezdan Sombor')," +
                "('Bekova Novi Pazar')," +
                "('Bela Pirot')," +
                "('Bela Voda Kruševac')," +
                "('Bela Voda Prokuplje')," +
                "('Bela Palanka Bela Palanka')," +
                "('Bela Reka Šabac')," +
                "('Bela Stena Raška')," +
                "('Bela Crkva Krupanj')," +
                "('Bela Crkva Bela Crkva')," +
                "('Bela Crkvarahovac')," +
                "('Belaje Dečani')," +
                "('Belanica Suva Reka')," +
                "('Belanovica Ljig')," +
                "('Belanovce Vladičin Han')," +
                "('Belanovce Leskovac')," +
                "('Belasica Kruševac')," +
                "('Bele Vode Novi Pazar')," +
                "('Beleg Dečani')," +
                "('Belegiš Stara Pazova')," +
                "('Beleš Dimitrovgrad')," +
                "('Beli Breg Aleksinac')," +
                "('Beli Breg Vranje')," +
                "('Beli Kamen Lučani')," +
                "('Beli Kamen Prokuplje')," +
                "('Beli Potok Beograd – Voždov')," +
                "('Beli Potok Knjaževac')," +
                "('Beli Potok Leskovac')," +
                "('Beli Potok Sokobanja')," +
                "('Belince Štimlje')," +
                "('Belić Valjevo')," +
                "('Belica Jagodina')," +
                "('Belica Istok')," +
                "('Beliševo Vladičin Han')," +
                "('Belo Blato Zrenjanin')," +
                "('Belo Brdo Leposavić')," +
                "('Belo Polje Beograd –brenova')," +
                "('Belo Polje Brus')," +
                "('Belo Poljeornji Milanovac')," +
                "('Belo Polje Kuršumlija')," +
                "('Belo Polje Raška')," +
                "('Belo Polje Surdulica')," +
                "('Belo Polje Istok')," +
                "('Belo Polje Peć')," +
                "('Belo Polje Podujevo')," +
                "('Belobrod Prizren')," +
                "('Belogoš Prokuplje')," +
                "('Belograce Kačanik')," +
                "('Beloinje Svrljig')," +
                "('Beloljin Prokuplje')," +
                "('Belosavci Topola')," +
                "('Belotinac Doljevac')," +
                "('Belotić Bogatić')," +
                "('Belotić Vladimirci')," +
                "('Belotićsečina')," +
                "('Beloševac Valjevo')," +
                "('Belut Bosilegrad')," +
                "('Beluće Beograd – Mladenovac')," +
                "('Beluće Leposavić')," +
                "('Belušić Rekovac')," +
                "('Belja Aleksinac')," +
                "('Beljajka Despotovac')," +
                "('Beljevac Beograd – Mladenov')," +
                "('Beljin Vladimirci')," +
                "('Beljina Beograd – Barajevo')," +
                "('Beljina Čačak')," +
                "('Benčuk Vučitrn')," +
                "('Beograd (Voždovac) Beograd')," +
                "('Beograd (Vračar) Beograd –')," +
                "('Beograd (Zvezdara) Beograd')," +
                "('Beograd (Zemun) Beograd – Z')," +
                "('Beograd (Novi Beograd) Beog')," +
                "('Beograd (Palilula) Beograd')," +
                "('Beograd (Rakovica) Beograd')," +
                "('Beograd (Savski venac) Beog')," +
                "('Beograd (Starirad) Beograd')," +
                "('Beograd (Čukarica) Beograd')," +
                "('Beomužević Valjevo')," +
                "('Beoci Raška')," +
                "('Beočin Beočin')," +
                "('Beočić Rekovac')," +
                "('Beranje Požarevac')," +
                "('Berbatovo Niš – Palilula')," +
                "('Berberište Leposavić')," +
                "('Berduj Babušnica')," +
                "('Berevce Štrpce')," +
                "('Berivojce Kosovska Kamenica')," +
                "('Berilovac Pirot')," +
                "('Berilje Prokuplje')," +
                "('Berin Izvor Babušnica')," +
                "('Berišalogovac')," +
                "('Berjak Đakovica')," +
                "('Berkasovo Šid')," +
                "('Berkovac Mionica')," +
                "('Berkovo Klina')," +
                "('Berlovine Ljubovija')," +
                "('Berovica Pirot')," +
                "('Berčevac Preševo')," +
                "('Berčinac Niš – Crveni krst')," +
                "('Berčinovac Knjaževac')," +
                "('Beršićiornji Milanovac')," +
                "('Beserovina Bajina Bašta')," +
                "('Besinje Priština')," +
                "('Bec Đakovica')," +
                "('Bečanj Čačak')," +
                "('Bečevica Knić')," +
                "('Bečej Bečej')," +
                "('Bečić Vučitrn')," +
                "('Bečmen Beograd – Surčin')," +
                "('Bešenovački Prnjavor Sremsk')," +
                "('Bešenovo Sremska Mitrovica')," +
                "('Beška Inđija')," +
                "('Bzenice Aleksandrovac')," +
                "('Bzovik Kraljevo')," +
                "('Biba Uroševac')," +
                "('Bivoljak Vučitrn')," +
                "('Bivolje Kruševac')," +
                "('Bigrenica Ćuprija')," +
                "('Bikinjeolubac')," +
                "('Bikić Do Šid')," +
                "('Bikovo Subotica')," +
                "('Bilincenjilane')," +
                "('Bilo Dimitrovgrad')," +
                "('Biluša Prizren')," +
                "('Biljanovac Raška')," +
                "('Biljača Bujanovac')," +
                "('Biljeg Merošina')," +
                "('Binač Vitina')," +
                "('Bingula Šid')," +
                "('Biniće Raška')," +
                "('Binovac Smederevo')," +
                "('Binovce Surdulica')," +
                "('Bioska Užice')," +
                "('Biohane Tutin')," +
                "('Bioc Sjenica')," +
                "('Biočin Raška')," +
                "('Biskupići Prijepolje')," +
                "('Biskuplje Velikoradište')," +
                "('Bistar Bosilegrad')," +
                "('Bistražin Đakovica')," +
                "('Bistrica Beograd – Lazareva')," +
                "('Bistrica Leskovac')," +
                "('Bistrica Nova Varoš')," +
                "('Bistrica Petrova na Mlavi')," +
                "('Bistrica Crna Trava')," +
                "('Bistrica Leposavić')," +
                "('Bitvrđa Surdulica')," +
                "('Biča Klina')," +
                "('Bičevac Kačanik')," +
                "('Bjelahova Prijepolje')," +
                "('Bjeloperica Kosjerić')," +
                "('Bjelotići Užice')," +
                "('Bjeluša Arilje')," +
                "('Blagaje Peć')," +
                "('Blagojev Kamen Kučevo')," +
                "('Blaževo Brus')," +
                "('Blaznava Topola')," +
                "('Blato Pirot')," +
                "('Blato Sjenica')," +
                "('Blato Kosovska Kamenica')," +
                "('Blato Podujevo')," +
                "('Blaca Tutin')," +
                "('Blace Blace')," +
                "('Blace Suva Reka')," +
                "('Blendija Sokobanja')," +
                "('Bliznak Žagubica')," +
                "('Blizonje Valjevo')," +
                "('Bljač Prizren')," +
                "('Bob Kačanik')," +
                "('Bobište Leskovac')," +
                "('Bobova Valjevo')," +
                "('Bobovac Klina')," +
                "('Bobovik Vladimirci')," +
                "('Bobovište Aleksinac')," +
                "('Bobovo Svilajnac')," +
                "('Bobote Aleksandrovac')," +
                "('Bovan Aleksinac')," +
                "('Bovan Kruševac')," +
                "('Bovanj Tutin')," +
                "('Bogava Despotovac')," +
                "('Bogalinac Rekovac')," +
                "('Bogaraš Bačka Topola')," +
                "('Bogaraš Senta')," +
                "('Bogatić Bogatić')," +
                "('Bogatić Valjevo')," +
                "('Bogdanicaornji Milanovac')," +
                "('Bogdanovac Babušnica')," +
                "('Bogdanovac Bujanovac')," +
                "('Bogdanovica Ub')," +
                "('Bogdanje Trstenik')," +
                "('Bogdinac Sokobanja')," +
                "('Boge Peć')," +
                "('Bogiše Brus')," +
                "('Bogovađa Lajkovac')," +
                "('Bogovina Boljevac')," +
                "('Bogojevići Arilje')," +
                "('Bogojevodžaci')," +
                "('Bogojevce Leskovac')," +
                "('Bogosavac Šabac')," +
                "('Bogoševo Vladičin Han')," +
                "('Bogoštica Krupanj')," +
                "('Bogujevac Kuršumlija')," +
                "('Bogujevac Prokuplje')," +
                "('Bogunovac Medveđa')," +
                "('Boguti Sjenica')," +
                "('Bogutovac Kraljevo')," +
                "('Bođani Bač')," +
                "('Boždarevac Beograd – Baraje')," +
                "('Boževac Malo Crniće')," +
                "('Boževce Kosovska Kamenica')," +
                "('Božetići Nova Varoš')," +
                "('Božinovac Knjaževac')," +
                "('Božinjevac Bujanovac')," +
                "('Božica Surdulica')," +
                "('Božov Potok Sjenica')," +
                "('Božurevac Trstenik')," +
                "('Božurnja Topola')," +
                "('Bozoljin Brus')," +
                "('Bojanići Kraljevo')," +
                "('Bojin Del Vranje')," +
                "('Bojince Kruševac')," +
                "('Bojić Šabac')," +
                "('Bojišina Leskovac')," +
                "('Bojnik Bojnik')," +
                "('Bojnoviće Zubin Potok')," +
                "('Bostane Novo Brdo')," +
                "('Bosut Sremska Mitrovica')," +
                "('Bosuta Aranđelovac')," +
                "('Bosce Kosovska Kamenica')," +
                "('Botoš Zrenjanin')," +
                "('Botunja Brus')," +
                "('Botunje Kragujevac')," +
                "('Boturići Aleksandrovac')," +
                "('Boturovina Novi Pazar')," +
                "('Boće Raška')," +
                "('Boćevica Leskovac')," +
                "('Bočar Novi Bečej')," +
                "('Bošljane Vučitrn')," +
                "('Bošnjak Petrova na Mlavi')," +
                "('Bošnjane Varvarin')," +
                "('Bošnjane Paraćin')," +
                "('Bošnjane Rača')," +
                "('Bošnjanović Ljig')," +
                "('Bošnjace Lebane')," +
                "('Brabonjić Kosovska Mitrovic')," +
                "('Bradarac Aleksinac')," +
                "('Bradarac Požarevac')," +
                "('Bradaš Podujevo')," +
                "('Bradić Loznica')," +
                "('Braina Podujevo')," +
                "('Brajićiornji Milanovac')," +
                "('Brajkovac Beograd – Lazarev')," +
                "('Brajkovac Kruševac')," +
                "('Brajkovac Prijepolje')," +
                "('Brajkovići Kosjerić')," +
                "('Brajnovac Rekovac')," +
                "('Braljina Ražanj')," +
                "('Braljina Ćićevac')," +
                "('Brangović Valjevo')," +
                "('Branešci Čajetina')," +
                "('Braničevoolubac')," +
                "('Brankovina Valjevo')," +
                "('Brankovci Bosilegrad')," +
                "('Brančić Ljig')," +
                "('Brasaljcenjilane')," +
                "('Brasina Mali Zvornik')," +
                "('Bratačićsečina')," +
                "('Bratilovce Kosovska Kamenic')," +
                "('Bratinac Požarevac')," +
                "('Bratići Aleksandrovac')," +
                "('Bratiševac Babušnica')," +
                "('Bratljevo Ivanjica')," +
                "('Bratmilovce Leskovac')," +
                "('Bratoselce Bujanovac')," +
                "('Bratotinrahovac')," +
                "('Braćak Tutin')," +
                "('Braćevac Negotin')," +
                "('Braćevci Dimitrovgrad')," +
                "('Brvenik Raška')," +
                "('Brvenik Naselje Raška')," +
                "('Brvenica Raška')," +
                "('Brvine Prijepolje')," +
                "('Brgule Ub')," +
                "('Brgulice Beograd –brenovac')," +
                "('Brdarica Koceljeva')," +
                "('Brdo Nova Varoš')," +
                "('Brđani Brus')," +
                "('Brđaniornji Milanovac')," +
                "('Brđani Novi Pazar')," +
                "('Brebevnica Dimitrovgrad')," +
                "('Brevnik Podujevo')," +
                "('Bregovi Tutin')," +
                "('Bregovina Prokuplje')," +
                "('Brežane Požarevac')," +
                "('Brežani Blace')," +
                "('Brežanik Peć')," +
                "('Brežđe Mionica')," +
                "('Breza Sjenica')," +
                "('Brezjak Loznica')," +
                "('Breznaornji Milanovac')," +
                "('Brezna Kraljevo')," +
                "('Brezna Priboj')," +
                "('Brezna Prizren')," +
                "('Breznica Bujanovac')," +
                "('Breznica Žagubica')," +
                "('Breznicabilić')," +
                "('Brezova Ivanjica')," +
                "('Brezova Kraljevo')," +
                "('Brezovac Aranđelovac')," +
                "('Brezovica Vlasotince')," +
                "('Brezovicaornji Milanovac')," +
                "('Brezovica Trstenik')," +
                "('Brezovica Ub')," +
                "('Brezovica Čačak')," +
                "('Brezovica Štrpce')," +
                "('Brezovice Valjevo')," +
                "('Brezovice Krupanj')," +
                "('Brejanovce Leskovac')," +
                "('Brekovac Đakovica')," +
                "('Brekovo Arilje')," +
                "('Brenica Niš – Pantelej')," +
                "('Bresje Jagodina')," +
                "('Bresje Svilajnac')," +
                "('Bresje Kosovo Polje')," +
                "('Bresnik Kraljevo')," +
                "('Bresnik Prokuplje')," +
                "('Bresnica Bosilegrad')," +
                "('Bresnica Vranje')," +
                "('Bresnica Koceljeva')," +
                "('Bresnica Čačak')," +
                "('Bresnica Zvečan')," +
                "('Bresničić Prokuplje')," +
                "('Bresno Polje Trstenik')," +
                "('Brest Merošina')," +
                "('Brestač Pećinci')," +
                "('Brestov Dol Babušnica')," +
                "('Brestovac Bojnik')," +
                "('Brestovac Bor')," +
                "('Brestovac Knić')," +
                "('Brestovac Leskovac')," +
                "('Brestovac Negotin')," +
                "('Brestovacrahovac')," +
                "('Brestovik Beograd –rocka')," +
                "('Brestovik Peć')," +
                "('Brestovo Vladičin Han')," +
                "('Brestovo Despotovac')," +
                "('Brestovo Novi Pazar')," +
                "('Brece Podujevo')," +
                "('Brza Leskovac')," +
                "('Brza Palanka Kladovo')," +
                "('Brzan Batočina')," +
                "('Brzance Leposavić')," +
                "('Brzeće Brus')," +
                "('Brzi Brod Niš – Medijana')," +
                "('Brzohode Žabari')," +
                "('Bričevlje Leskovac')," +
                "('Brlog Pirot')," +
                "('Brniševo Tutin')," +
                "('Brnjak Zubin Potok')," +
                "('Brnjare Bujanovac')," +
                "('Brnjac Loznica')," +
                "('Brnjačarahovac')," +
                "('Brnjicaolubac')," +
                "('Brnjica Knić')," +
                "('Brnjica Sjenica')," +
                "('Brovina Đakovica')," +
                "('Brović Beograd –brenovac')," +
                "('Brod Crna Trava')," +
                "('Brod Štrpce')," +
                "('Brodora')," +
                "('Brodarevo Prijepolje')," +
                "('Brodica Kučevo')," +
                "('Brodosavce Prizren')," +
                "('Brolić Peć')," +
                "('Broćna Srbica')," +
                "('Brus Brus')," +
                "('Brus Lipljan')," +
                "('Brusnik Zaječar')," +
                "('Brusnik Ivanjica')," +
                "('Brusnik Vučitrn')," +
                "('Brusnicaornji Milanovac')," +
                "('Brut Prizren')," +
                "('Brštica Krupanj')," +
                "('Buar Užice')," +
                "('Bubanj Niš – Palilula')," +
                "('Bube Zubin Potok')," +
                "('Bublica Prokuplje')," +
                "('Bubljerahovac')," +
                "('Bubušinac Požarevac')," +
                "('Buvce Lebane')," +
                "('Budakovo Suva Reka')," +
                "('Budilovina Brus')," +
                "('Budisava Novi Sad')," +
                "('Budisavci Klina')," +
                "('Budišić Mali Zvornik')," +
                "('Budoželja Ivanjica')," +
                "('Buđanovci Ruma')," +
                "('Buđevo Sjenica')," +
                "('Buzec Prizren')," +
                "('Buzovik Vitina')," +
                "('Bujanovac Bujanovac')," +
                "('Bujance Lipljan')," +
                "('Bujačić Valjevo')," +
                "('Bujić Preševo')," +
                "('Bujkovac Vranjska Banja')," +
                "('Bujkoviće Tutin')," +
                "('Bukarevac Preševo')," +
                "('Bukovalava Leskovac')," +
                "('Bukovac Despotovac')," +
                "('Bukovac Mionica')," +
                "('Bukovac Preševo')," +
                "('Bukovac Petrovaradin')," +
                "('Bukovik Aranđelovac')," +
                "('Bukovik Nova Varoš')," +
                "('Bukovik Prijepolje')," +
                "('Bukoviknjilane')," +
                "('Bukovica Ivanjica')," +
                "('Bukovica Kraljevo')," +
                "('Bukovica Kruševac')," +
                "('Bukovica Lipljan')," +
                "('Bukovska Kučevo')," +
                "('Bukovče Negotin')," +
                "('Bukovče Jagodina')," +
                "('Bukor Šabac')," +
                "('Bukorovac Kragujevac')," +
                "('Bukoš Vučitrn')," +
                "('Bukoš Suva Reka')," +
                "('Bukuloram Prokuplje')," +
                "('Bukurovac Bela Palanka')," +
                "('Bulatovac Prokuplje')," +
                "('Bulinovac Knjaževac')," +
                "('Buljane Paraćin')," +
                "('Buljesovce Vranje')," +
                "('Bumbarevo Brdo Knić')," +
                "('Bunar Jagodina')," +
                "('Bunuški Čifluk Leskovac')," +
                "('Burađa Nova Varoš')," +
                "('Burdimo Svrljig')," +
                "('Burincenjilane')," +
                "('Burince Podujevo')," +
                "('Burlate Zubin Potok')," +
                "('Burnik Uroševac')," +
                "('Burovac Petrova na Mlavi')," +
                "('Burovo Beograd – Lazarevac')," +
                "('Busenje Sečanj')," +
                "('Busilovac Paraćin')," +
                "('Businje Priština')," +
                "('Busovata Kosovska Kamenica')," +
                "('Busur Petrova na Mlavi')," +
                "('Buceljevo Bosilegrad')," +
                "('Buci Kruševac')," +
                "('Buča Prizren')," +
                "('Bučane Peć')," +
                "('Bučince Prokuplje')," +
                "('Bučić Merošina')," +
                "('Bučje Bor')," +
                "('Bučje Knjaževac')," +
                "('Bučje Priboj')," +
                "('Bučje Trstenik')," +
                "('Bučum Svrljig')," +
                "('Bušince Kosovska Kamenica')," +
                "('Buštranje Bujanovac')," +
                "('Buštranje Vranje')," +
                "('Buštranje Preševo')," +
                "('Vava Babušnica')," +
                "('Vaganeš Kosovska Kamenica')," +
                "('Vaganica Kosovska Mitrovica')," +
                "('Vajska Bač')," +
                "('Vajuga Kladovo')," +
                "('Vakup Aleksinac')," +
                "('Valakonje Boljevac')," +
                "('Valač Zvečan')," +
                "('Valevac Knjaževac')," +
                "('Valniš Babušnica')," +
                "('Valjevo Valjevo')," +
                "('Vapa Sjenica')," +
                "('Vapa Čačak')," +
                "('Varadin Medveđa')," +
                "('Varvarin Varvarin')," +
                "('Varvarin (selo) Varvarin')," +
                "('Varda Kosjerić')," +
                "('Varevo Novi Pazar')," +
                "('Varevo Raška')," +
                "('Varigovce Lipljan')," +
                "('Varna Šabac')," +
                "('Varniceornji Milanovac')," +
                "('Varoš Ražanj')," +
                "('Varoš Svrljig')," +
                "('Varoš Selo Uroševac')," +
                "('Vasilj Knjaževac')," +
                "('Vasiljevac Kuršumlija')," +
                "('Vasiljevići Ivanjica')," +
                "('Vasiljevologovac')," +
                "('Vata Kačanik')," +
                "('Vatin Vršac')," +
                "('Vašica Šid')," +
                "('Vever Novi Pazar')," +
                "('Vezičevo Petrova na Mlavi')," +
                "('Vele Polje Niš – Crveni krs')," +
                "('Velebit Kanjiža')," +
                "('Veleža Prizren')," +
                "('Velekincenjilane')," +
                "('Velerečornji Milanovac')," +
                "('Velesnica Kladovo')," +
                "('Velika Biljanica Leskovac')," +
                "('Velika Braina Medveđa')," +
                "('Velika Bresnica Kučevo')," +
                "('Velika Vrbica Kladovo')," +
                "('Velika Vrbnica Aleksandrova')," +
                "('Velikarabovnica Brus')," +
                "('Velikarabovnica Leskovac')," +
                "('Velikareda Plandište')," +
                "('Velika Dobranja Lipljan')," +
                "('Velika Drenova Trstenik')," +
                "('Velika Ivanča Beograd – Mla')," +
                "('Velika Jablanica Peć')," +
                "('Velika Jasikova Zaječar')," +
                "('Velika Ježevica Požega')," +
                "('Velika Kaludra Zubin Potok')," +
                "('Velika Kamenica Kladovo')," +
                "('Velika Kopašnica Leskovac')," +
                "('Velika Krsna Beograd – Mlad')," +
                "('Velika Krušarahovac')," +
                "('Velika Kruševica Kruševac')," +
                "('Velika Kruševica Rekovac')," +
                "('Velika Lomnica Kruševac')," +
                "('Velika Lukanja Pirot')," +
                "('Velika Marišta Mionica')," +
                "('Velika Moštanica Beograd –')," +
                "('Velika Plana Velika Plana')," +
                "('Velika Plana Prokuplje')," +
                "('Velika Reka Mali Zvornik')," +
                "('Velika Reka Vučitrn')," +
                "('Velika Reka Podujevo')," +
                "('Velika Remeta Irig')," +
                "('Velika Sejanica Leskovac')," +
                "('Velika Slatina Kosovo Polje')," +
                "('Velika Sugubina Kragujevac')," +
                "('Velika Hočarahovac')," +
                "('Velike Pčelice Kragujevac')," +
                "('Veliki Alaš Lipljan')," +
                "('Veliki Belaćevac Kosovo Pol')," +
                "('Veliki Borak Beograd – Bara')," +
                "('Veliki Vrtopadžin Han')," +
                "('Velikiaj Plandište')," +
                "('Velikioden Vitina')," +
                "('Veliki Drenovac Aleksinac')," +
                "('Veliki Đurđevik Klina')," +
                "('Veliki Izvor Zaječar')," +
                "('Veliki Jasenovac Zaječar')," +
                "('Veliki Jovanovac Pirot')," +
                "('Veliki Kičić Kosovska Mitro')," +
                "('Veliki Krčimiradžin Han')," +
                "('Veliki Kupci Kruševac')," +
                "('Veliki Popovac Petrova na M')," +
                "('Veliki Popović Despotovac')," +
                "('Veliki Radinci Sremska Mitr')," +
                "('Veliki Suvodol Pirot')," +
                "('Veliki Trnovac Bujanovac')," +
                "('Veliki Crljeni Beograd – La')," +
                "('Veliki Šenj Kragujevac')," +
                "('Veliki Šiljegovac Kruševac')," +
                "('Veliki Štupelj Peć')," +
                "('Veliko Bonjince Babušnica')," +
                "('Veliko Vojlovce Lebane')," +
                "('Velikoolovode Kruševac')," +
                "('Velikoradište Velikoradište')," +
                "('Veliko Kruševo Klina')," +
                "('Veliko Krušince Kruševac')," +
                "('Veliko Krčmare Rača')," +
                "('Veliko Laole Petrova na Mla')," +
                "('Velikorašje Velika Plana')," +
                "('Veliko Polje Beograd –breno')," +
                "('Veliko Pupavce Kuršumlija')," +
                "('Veliko Ribare Lipljan')," +
                "('Veliko Ropotovo Kosovska Ka')," +
                "('Veliko Rudare Zvečan')," +
                "('Veliko Selo Beograd – Palil')," +
                "('Veliko Selo Loznica')," +
                "('Veliko Selo Malo Crniće')," +
                "('Veliko Selo Pirot')," +
                "('Veliko Središte Vršac')," +
                "('Veliko Trnjane Leskovac')," +
                "('Veliko Crniće Malo Crniće')," +
                "('Veliševac Ljig')," +
                "('Veluće Trstenik')," +
                "('Veljalava Aleksandrovac')," +
                "('Velje Polje Tutin')," +
                "('Veljeglava Kosovska Kamenic')," +
                "('Velji Breg Zubin Potok')," +
                "('Veljkovo Negotin')," +
                "('Venčane Aranđelovac')," +
                "('Venčac Aleksandrovac')," +
                "('Verzar Dimitrovgrad')," +
                "('Verić Istok')," +
                "('Vesekovce Vučitrn')," +
                "('Veselinovac Valjevo')," +
                "('Veseniće Tutin')," +
                "('Veskoviće Sjenica')," +
                "('Veta Bela Palanka')," +
                "('Veternik Novi Sad')," +
                "('Vigošte Arilje')," +
                "('Vidanje Klina')," +
                "('Vidova Čačak')," +
                "('Vidovac Knjaževac')," +
                "('Vidovača Prokuplje')," +
                "('Vidovo Novi Pazar')," +
                "('Vidomirić Kosovska Mitrovic')," +
                "('Vidrovac Negotin')," +
                "('Vidušić Kosovska Mitrovica')," +
                "('Vizić Bačka Palanka')," +
                "('Vilandricaadžin Han')," +
                "('Vilište Zvečan')," +
                "('Vilovi Nova Varoš')," +
                "('Vilovo Titel')," +
                "('Viljance Vučitrn')," +
                "('Vilje Kolo Leskovac')," +
                "('Viljuša Čačak')," +
                "('Vina Knjaževac')," +
                "('Vina Leskovac')," +
                "('Vinarce Leskovac')," +
                "('Vinicka Prijepolje')," +
                "('Vinorača Jagodina')," +
                "('Vinciolubac')," +
                "('Vinča Beograd –rocka')," +
                "('Vinča Topola')," +
                "('Vinjište Kragujevac')," +
                "('Vionica Ivanjica')," +
                "('Virine Ćuprija')," +
                "('Virovac Mionica')," +
                "('Virovo Arilje')," +
                "('Visibaba Požega')," +
                "('Visoka Arilje')," +
                "('Visoka Kuršumlija')," +
                "('Visočka Sjenica')," +
                "('Visočka Ržana Pirot')," +
                "('Visočkidorovci Dimitrovgrad')," +
                "('Vitak Srbica')," +
                "('Vitakova Zubin Potok')," +
                "('Vitanovac Bela Palanka')," +
                "('Vitanovac Kraljevo')," +
                "('Vitanovac Kruševac')," +
                "('Vitanoviće Leposavić')," +
                "('Vitance Despotovac')," +
                "('Vitasi Užice')," +
                "('Viteževo Žabari')," +
                "('Vitina Vitina')," +
                "('Vitkovac Aleksinac')," +
                "('Vitkovac Knjaževac')," +
                "('Vitkovac Kraljevo')," +
                "('Vitkoviće Novi Pazar')," +
                "('Vitkovo Aleksandrovac')," +
                "('Vitovnica Petrova na Mlavi')," +
                "('Vitojevci Ruma')," +
                "('Vitomirica Peć')," +
                "('Vitoše Brus')," +
                "('Vitoševac Ražanj')," +
                "('Viča Lučani')," +
                "('Viča Prokuplje')," +
                "('Viča Štrpce')," +
                "('Više Selo Blace')," +
                "('Viševac Rača')," +
                "('Viševce Vranje')," +
                "('Višesava Bajina Bašta')," +
                "('Višnjeva Sjenica')," +
                "('Višnjevac Subotica')," +
                "('Višnjićevo Šid')," +
                "('Višnjice Sjenica')," +
                "('Vladimirovac Alibunar')," +
                "('Vladimirci Vladimirci')," +
                "('Vladičin Han Vladičin Han')," +
                "('Vladovonjilane')," +
                "('Vladovce Trgovište')," +
                "('Vlajkovac Vršac')," +
                "('Vlajkovci Brus')," +
                "('Vlakča Kragujevac')," +
                "('Vlaole Majdanpek')," +
                "('Vlasanica Vladimirci')," +
                "('Vlase Vranje')," +
                "('Vlase Leskovac')," +
                "('Vlasi Pirot')," +
                "('Vlasinakruglica Surdulica')," +
                "('Vlasina Rid Surdulica')," +
                "('Vlasina Stojkovićeva Surdulica')," +
                "('Vlasovo Prokuplje')," +
                "('Vlasotince Vlasotince')," +
                "('Vlasteljice Lučani')," +
                "('Vlahinja Kuršumlija')," +
                "('Vlahinje Kosovska Mitrovica')," +
                "('Vlahovo Žitorađa')," +
                "('Vlahovo Svrljig')," +
                "('Vlaška Beograd – Mladenovac')," +
                "('Vlaška Ćuprija')," +
                "('Vlaški Do Žabari')," +
                "('Vlaški Do Smederevska Palanka')," +
                "('Vlaški Drenovac Klina')," +
                "('Vlaško Polje Knjaževac')," +
                "('Vlašnja Prizren')," +
                "('Vlašticanjilane')," +
                "('Vlaščić Valjevo')," +
                "('Vlkovija Dimitrovgrad')," +
                "('Vogance Bujanovac')," +
                "('Voganj Ruma')," +
                "('Vogačica Lipljan')," +
                "('Vogovo Đakovica')," +
                "('Vodanj Smederevo')," +
                "('Vodice Prokuplje')," +
                "('Vodice Smederevska Palanka')," +
                "('Vojvoda Zimonić Kanjiža')," +
                "('Vojvoda Stepa Nova Crnja')," +
                "('Vojvodinci Vršac')," +
                "('Vojilovoolubac')," +
                "('Vojinovac Rača')," +
                "('Vojinovce Štimlje')," +
                "('Vojka Stara Pazova')," +
                "('Vojkoviće Novi Pazar')," +
                "('Vojkovci Topola')," +
                "('Vojmilovići Raška')," +
                "('Vojmisliće Zubin Potok')," +
                "('Vojnegovac Pirot')," +
                "('Vojnik Despotovac')," +
                "('Vojniće Novi Pazar')," +
                "('Vojnici Babušnica')," +
                "('Vojska Svilajnac')," +
                "('Vokša Dečani')," +
                "('Voluja Kučevo')," +
                "('Volujak Klina')," +
                "('Volujac Užice')," +
                "('Volujac Šabac')," +
                "('Voljavče Jagodina')," +
                "('Voljevci Mali Zvornik')," +
                "('Voljčince Žitorađa')," +
                "('Voćnjak Loznica')," +
                "('Voćnjak Srbica')," +
                "('Vošanovac Petrova na Mlavi')," +
                "('Vragovac Peć')"); 
				
				 migrationBuilder.Sql(
                "insert into Mesta(NazivMesta) values " +
                "('Vragolija Kosovo Polje')," +
                "('Vragočanica Valjevo')," +
                "('Vražogrnac Zaječar')," +
                "('Vražogrnci Aleksandrovac')," +
                "('Vrandol Bela Palanka')," +
                "('Vrane Arilje')," +
                "('Vraneša Nova Varoš')," +
                "('Vraneši Vrnjačka Banja')," +
                "('Vrani Do Priština')," +
                "('Vranić Beograd – Barajevo')," +
                "('Vranić Đakovica')," +
                "('Vranić Suva Reka')," +
                "('Vranići Čačak')," +
                "('Vranište Pirot')," +
                "('Vraništeora')," +
                "('Vranovac Jagodina')," +
                "('Vranovac Peć')," +
                "('Vranovina Novi Pazar')," +
                "('Vranovo Smederevo')," +
                "('Vranštica Aleksandrovac')," +
                "('Vranjakrahovac')," +
                "('Vranjani Požega')," +
                "('Vranje Vranje')," +
                "('Vranjska Banja Vranjska Banja')," +
                "('Vrapce Medveđa')," +
                "('Vrapci Sjenica')," +
                "('Vrapča Dimitrovgrad')," +
                "('Vrapče Tutin')," +
                "('Vrapčićnjilane')," +
                "('Vratare Kruševac')," +
                "('Vratarnica Zaječar')," +
                "('Vratna Negotin')," +
                "('Vraćevšnicaornji Milanovac')," +
                "('Vračevaj Bela Crkva')," +
                "('Vračević Lajkovac')," +
                "('Vračevo Leposavić')," +
                "('Vrba Kraljevo')," +
                "('Vrba Jagodina')," +
                "('Vrba Tutin')," +
                "('Vrba Zubin Potok')," +
                "('Vrban Bujanovac')," +
                "('Vrban Vitina')," +
                "('Vrbas Vrbas')," +
                "('Vrbeta Knić')," +
                "('Vrbeštica Štrpce')," +
                "('Vrbić Krupanj')," +
                "('Vrbica Aranđelovac')," +
                "('Vrbica Zaječar')," +
                "('Vrbica Čoka')," +
                "('Vrbicanjilane')," +
                "('Vrbičane Prizren')," +
                "('Vrbnica Aleksandrovac')," +
                "('Vrbnica Malo Crniće')," +
                "('Vrbnica Sjenica')," +
                "('Vrbnica Prizren')," +
                "('Vrbnica Kosovska Mitrovica')," +
                "('Vrbovac Blace')," +
                "('Vrbovac Boljevac')," +
                "('Vrbovac Smederevo')," +
                "('Vrbovac Sokobanja')," +
                "('Vrbovac Vitina')," +
                "('Vrbovaclogovac')," +
                "('Vrbovno Beograd – Lazarevac')," +
                "('Vrbovo Vladičin Han')," +
                "('Vrbovo Prijepolje')," +
                "('Vrgudinac Bela Palanka')," +
                "('Vrdila Kraljevo')," +
                "('Vrdnik Irig')," +
                "('Vrelo Aleksinac')," +
                "('Vrelo Babušnica')," +
                "('Vrelo Kuršumlija')," +
                "('Vrelo Ub')," +
                "('Vrelo Niš – Pantelej')," +
                "('Vrelo Istok')," +
                "('Vrelo Lipljan')," +
                "('Vreoci Beograd – Lazarevac')," +
                "('Vrlane Svilajnac')," +
                "('Vrmbaje Ivanjica')," +
                "('Vrmnica Klina')," +
                "('Vrmdža Sokobanja')," +
                "('Vrnavokolo Vitina')," +
                "('Vrnez Vitina')," +
                "('Vrnica Vučitrn')," +
                "('Vrnčaniornji Milanovac')," +
                "('Vrnčani Čačak')," +
                "('Vrnjačka Banja Vrnjačka Banja')," +
                "('Vrnjci Vrnjačka Banja')," +
                "('Vrsjenice Sjenica')," +
                "('Vrtiglav Mionica')," +
                "('Vrtine Raška')," +
                "('Vrtište Niš – Crveni krst')," +
                "('Vrtovac Knjaževac')," +
                "('Vrtogoš Vranje')," +
                "('Vrtolnica Kačanik')," +
                "('Vrćenovica Aleksinac')," +
                "('Vrutci Užice')," +
                "('Vrućevce Kosovska Kamenica')," +
                "('Vrh Kraljevo')," +
                "('Vrhovine Ub')," +
                "('Vrhpolje Ljubovija')," +
                "('Vrčin Beograd –rocka')," +
                "('Vršac Vršac')," +
                "('Vršački Ritovi Vršac')," +
                "('Vrševac Kuršumlija')," +
                "('Vrševce Lipljan')," +
                "('Vrševce Suva Reka')," +
                "('Vujanovo Bojnik')," +
                "('Vujetinci Čačak')," +
                "('Vujinovača Valjevo')," +
                "('Vukanja Aleksinac')," +
                "('Vukašinovac Aleksinac')," +
                "('Vukićevica Beograd –brenovac')," +
                "('Vukmanovac Rekovac')," +
                "('Vukmanovo Niš – Palilula')," +
                "('Vukovac Žagubica')," +
                "('Vuković Kučevo')," +
                "('Vukojevac Kuršumlija')," +
                "('Vukojeviće Zubin Potok')," +
                "('Vukona Ub')," +
                "('Vukosavljeviće Zubin Potok')," +
                "('Vukosavci Aranđelovac')," +
                "('Vukošić Vladimirci')," +
                "('Vukušica Vrnjačka Banja')," +
                "('Vus Crna Trava')," +
                "('Vuča Leposavić')," +
                "('Vučadelce Surdulica')," +
                "('Vučak Ivanjica')," +
                "('Vučak Kruševac')," +
                "('Vučak Smederevo')," +
                "('Vučaklogovac')," +
                "('Vučevica Vladimirci')," +
                "('Vuči Del Babušnica')," +
                "('Vučiniće Novi Pazar')," +
                "('Vučitrn Vučitrn')," +
                "('Vučić Rača')," +
                "('Vučja Lokva Novi Pazar')," +
                "('Vučje Leskovac')," +
                "('Vučkovica Knić')," +
                "('Vučkovica Lučani')," +
                "('Gabrica Kačanik')," +
                "('Gabrovac Niš – Palilula')," +
                "('Gabrovnica Knjaževac')," +
                "('Gavez Kruševac')," +
                "('Gagince Leskovac')," +
                "('Gaglovo Kruševac')," +
                "('Gadišnjilane')," +
                "('Gazdare Medveđa')," +
                "('Gazivode Zubin Potok')," +
                "('Gaj Kovin')," +
                "('Gajdobra Bačka Palanka')," +
                "('Gajre Kačanik')," +
                "('Gakovo Sombor')," +
                "('Galibabinac Svrljig')," +
                "('Galica Vučitrn')," +
                "('Galović Koceljeva')," +
                "('Galovići Kosjerić')," +
                "('Gamzigrad Zaječar')," +
                "('Garaši Aranđelovac')," +
                "('Gardinovci Titel')," +
                "('Gareadžin Han')," +
                "('Gare Preševo')," +
                "('Garevina Aleksandrovac')," +
                "('Garevo Velikoradište')," +
                "('Gari Kruševac')," +
                "('Garinje Vladičin Han')," +
                "('Gatnje Uroševac')," +
                "('Gadžin Hanadžin Han')," +
                "('Gvozdac Bajina Bašta')," +
                "('Gvozdenović Ub')," +
                "('Geglja Lebane')," +
                "('Geljance Suva Reka')," +
                "('Gedžarahovac')," +
                "('Gibarac Šid')," +
                "('Glavinci Jagodina')," +
                "('Glavica Paraćin')," +
                "('Glavica Lipljan')," +
                "('Glavičica Peć')," +
                "('Glavnik Podujevo')," +
                "('Glavotina Vučitrn')," +
                "('Gladno Selologovac')," +
                "('Glanica Lipljan')," +
                "('Glasovik Prokuplje')," +
                "('Glašince Žitorađa')," +
                "('Gledić Kraljevo')," +
                "('Gleđica Ivanjica')," +
                "('Glibovac Smederevska Palanka')," +
                "('Globare Kruševac')," +
                "('Globarelogovac')," +
                "('Globoder Kruševac')," +
                "('Globočica Kačanik')," +
                "('Globočicaora')," +
                "('Glogovac Bela Palanka')," +
                "('Glogovac Bogatić')," +
                "('Glogovac Knjaževac')," +
                "('Glogovac Jagodina')," +
                "('Glogovaclogovac')," +
                "('Glogovik Tutin')," +
                "('Glogovica Aleksinac')," +
                "('Glogovica Zaječar')," +
                "('Glogovica Priština')," +
                "('Glogovce Kosovska Kamenica')," +
                "('Glogovce Lipljan')," +
                "('Glogonj Pančevo')," +
                "('Glođane Dečani')," +
                "('Glođane Peć')," +
                "('Gložan Bački Petrovac')," +
                "('Gložane Vlasotince')," +
                "('Gložane Svilajnac')," +
                "('Gložje Bosilegrad')," +
                "('Glumač Požega')," +
                "('Gluhavica Tutin')," +
                "('Glušci Bogatić')," +
                "('Gmince Kosovska Kamenica')," +
                "('Gnila Tutin')," +
                "('Gnježdane Leposavić')," +
                "('Gnjilan Pirot')," +
                "('Gnjilanenjilane')," +
                "('Gnjilica Raška')," +
                "('Gogolovce Kosovska Kamenica')," +
                "('Godancelogovac')," +
                "('Godačica Kraljevo')," +
                "('Goden Đakovica')," +
                "('Godečevo Kosjerić')," +
                "('Godišnjak Podujevo')," +
                "('Godljevo Kosjerić')," +
                "('Godovik Požega')," +
                "('Godovo Tutin')," +
                "('Gojakovići Prijepolje')," +
                "('Gojbulja Vučitrn')," +
                "('Gojin Dol Dimitrovgrad')," +
                "('Gojinovac Prokuplje')," +
                "('Gojmanovac Svrljig')," +
                "('Gojnaoraornji Milanovac')," +
                "('Gokčanica Kraljevo')," +
                "('Golalava Valjevo')," +
                "('Golema Njiva Leskovac')," +
                "('Golemi Dol Preševo')," +
                "('Golemo Selo Vranje')," +
                "('Goleš Bosilegrad')," +
                "('Goleško Vrelo Lipljan')," +
                "('Golešnica Aleksinac')," +
                "('Goli Rid Lebane')," +
                "('Golice Novi Pazar')," +
                "('Golobok Smederevska Palanka')," +
                "('Golovo Čajetina')," +
                "('Goločevac Trgovište')," +
                "('Goločelo Koceljeva')," +
                "('Goločelo Kragujevac')," +
                "('Goluban Sjenica')," +
                "('Golubacolubac')," +
                "('Golubac Mionica')," +
                "('Golubinci Stara Pazova')," +
                "('Golubinje Majdanpek')," +
                "('Golubovac Paraćin')," +
                "('Golubovac Trstenik')," +
                "('Golubovac Klina')," +
                "('Goraždevac Peć')," +
                "('Gorance Kačanik')," +
                "('Goračevorahovac')," +
                "('Goračići Lučani')," +
                "('Gorina Leskovac')," +
                "('Gorić Valjevo')," +
                "('Gorićrahovac')," +
                "('Goričani Čačak')," +
                "('Gorjani Užice')," +
                "('Gornovac Trgovište')," +
                "('Gornja Badanja Loznica')," +
                "('Gornja Bejašnica Prokuplje')," +
                "('Gornja Bela Reka Zaječar')," +
                "('Gornja Bela Reka Nova Varoš')," +
                "('Gornja Bitinja Štrpce')," +
                "('Gornja Borina Loznica')," +
                "('Gornja Bresnica Prokuplje')," +
                "('Gornja Brnjica Priština')," +
                "('Gornja Budrika Vitina')," +
                "('Gornja Bukovica Valjevo')," +
                "('Gornja Bunuša Leskovac')," +
                "('Gornja Vranjska Šabac')," +
                "('Gornja Vrbavaornji Milanovac')," +
                "('Gornja Vrežina Niš – Pantelej')," +
                "('Gornjalama Bela Palanka')," +
                "('Gornjaorevnica Čačak')," +
                "('Gornjarabovica Valjevo')," +
                "('Gornjarlica Kačanik')," +
                "('Gornjaušterica Lipljan')," +
                "('Gornja Dobrinja Požega')," +
                "('Gornja Draguša Blace')," +
                "('Gornja Držina Pirot')," +
                "('Gornja Dubnica Vučitrn')," +
                "('Gornja Dubnica Podujevo')," +
                "('Gornja Zleginja Aleksandrovac')," +
                "('Gornja Jajina Leskovac')," +
                "('Gornja Jošanica Blace')," +
                "('Gornja Kamenica Knjaževac')," +
                "('Gornja Klina Srbica')," +
                "('Gornja Koviljača Loznica')," +
                "('Gornja Koznica Surdulica')," +
                "('Gornja Konjuša Prokuplje')," +
                "('Gornja Koreticalogovac')," +
                "('Gornja Koritnica Bela Palanka')," +
                "('Gornja Kravarica Lučani')," +
                "('Gornja Krušica Suva Reka')," +
                "('Gornja Kupinovica Leskovac')," +
                "('Gornja Lapaštica Medveđa')," +
                "('Gornja Lapaštica Podujevo')," +
                "('Gornja Lisina Bosilegrad')," +
                "('Gornja Lokošnica Leskovac')," +
                "('Gornja Lomnica Vlasotince')," +
                "('Gornja Lopušnja Vlasotince')," +
                "('Gornja Luka Dečani')," +
                "('Gornja Ljubata Bosilegrad')," +
                "('Gornja Ljuboviđa Ljubovija')," +
                "('Gornja Mikuljana Kuršumlija')," +
                "('Gornja Mutnica Paraćin')," +
                "('Gornja Nevlja Dimitrovgrad')," +
                "('Gornjamašnica Trstenik')," +
                "('Gornjarovica Ljubovija')," +
                "('Gornjatulja Vranje')," +
                "('Gornja Pakaštica Podujevo')," +
                "('Gornja Peščanica Aleksinac')," +
                "('Gornja Pološnica Kosjerić')," +
                "('Gornja Rapčaora')," +
                "('Gornja Rasovača Merošina')," +
                "('Gornja Rečica Prokuplje')," +
                "('Gornja Ržana Bosilegrad')," +
                "('Gornja Rogatica Bačka Topola')," +
                "('Gornja Sabanta Kragujevac')," +
                "('Gornja Sipulja Loznica')," +
                "('Gornja Slatina Leskovac')," +
                "('Gornja Slatina Vitina')," +
                "('Gornja Sokolovica Knjaževac')," +
                "('Gornja Srbica Prizren')," +
                "('Gornja Stražava Prokuplje')," +
                "('Gornja Stubla Vitina')," +
                "('Gornja Studena Niš – Niška Banja')," +
                "('Gornja Sudimlja Vučitrn')," +
                "('Gornja Toponica Prokuplje')," +
                "('Gornja Toponica Niš – Crveni krst')," +
                "('Gornja Trepča Čačak')," +
                "('Gornja Trešnjevica Aranđelovac')," +
                "('Gornja Trešnjica Ljubovija')," +
                "('Gornja Trnava Prokuplje')," +
                "('Gornja Trnava Topola')," +
                "('Gornja Trnava Niš – Crveni krst')," +
                "('Gornja Trnica Trgovište')," +
                "('Gornja Tušimlja Novi Pazar')," +
                "('Gornja Fušticalogovac')," +
                "('Gornja Crnišava Trstenik')," +
                "('Gornja Crnućaornji Milanovac')," +
                "('Gornja Šatornja Topola')," +
                "('Gornja Šipašnica Kosovska Kamenica')," +
                "('Gornja Šušaja Preševo')," +
                "('Gornjane Bor')," +
                "('Gornje Babine Prijepolje')," +
                "('Gornje Brijanje Bojnik')," +
                "('Gornje Varage Zubin Potok')," +
                "('Gornje Vidovo Paraćin')," +
                "('Gornje Vinarce Kosovska Mitrovica')," +
                "('Gornje Vlaseadžin Han')," +
                "('Gornje Vranovce Lebane')," +
                "('Gornjeadimlje Lipljan')," +
                "('Gornjeare Crna Trava')," +
                "('Gornjeodance Štimlje')," +
                "('Gornjeoračiće Prijepolje')," +
                "('Gornjerbice Kragujevac')," +
                "('Gornjergure Blace')," +
                "('Gornje Dobrevo Kosovo Polje')," +
                "('Gornje Dragovljeadžin Han')," +
                "('Gornje Žabare Kosovska Mitrovica')," +
                "('Gornje Žapsko Vranje')," +
                "('Gornje Zuniče Knjaževac')," +
                "('Gornje Jabukovo Vladičin Han')," +
                "('Gornje Jarušice Kragujevac')," +
                "('Gornje Karačevo Kosovska Kamenica')," +
                "('Gornje Komarice Kragujevac')," +
                "('Gornje Konjuvce Bojnik')," +
                "('Gornje Kordince Prokuplje')," +
                "('Gornje Korminjane Kosovska Kamenica')," +
                "('Gornje Košlje Ljubovija')," +
                "('Gornje Krajince Leskovac')," +
                "('Gornje Krnjino Babušnica')," +
                "('Gornje Kuscenjilane')," +
                "('Gornje Leviće Brus')," +
                "('Gornje Leskovice Valjevo')," +
                "('Gornje Lopiže Sjenica')," +
                "('Gornje Ljubinje Prizren')," +
                "('Gornje Ljupče Podujevo')," +
                "('Gornje Međurovo Niš – Palilula')," +
                "('Gornje Nedeljice Loznica')," +
                "('Gornje Nerodimlje Uroševac')," +
                "('Gornje Novo Selo Đakovica')," +
                "('Gornjebrinjelogovac')," +
                "('Gornje Potočanerahovac')," +
                "('Gornje Prekaze Srbica')," +
                "('Gornje Punoševce Vranje')," +
                "('Gornje Rataje Aleksandrovac')," +
                "('Gornje Rašane Kosovska Mitrovica')," +
                "('Gornje Romanovce Surdulica')," +
                "('Gornje Svarče Blace')," +
                "('Gornje Selo Prizren')," +
                "('Gornje Sinkovce Leskovac')," +
                "('Gornje Slakovcenjilane')," +
                "('Gornje Stanovce Vučitrn')," +
                "('Gornje Stopanje Leskovac')," +
                "('Gornje Suhotno Aleksinac')," +
                "('Gornje Tlamino Bosilegrad')," +
                "('Gornje Točane Kuršumlija')," +
                "('Gornje Trebešinje Vranje')," +
                "('Gornje Trnjane Leskovac')," +
                "('Gornje Trudovo Nova Varoš')," +
                "('Gornje Crnatovo Žitorađa')," +
                "('Gornje Crniljevosečina')," +
                "('Gornje Šlje Jagodina')," +
                "('Gornji Adrovac Aleksinac')," +
                "('Gornji Banjaniornji Milanovac')," +
                "('Gornji Barbešadžin Han')," +
                "('Gornji Branetićiornji Milanovac')," +
                "('Gornji Breg Senta')," +
                "('Gornji Bunibrod Leskovac')," +
                "('Gornji Bučumet Medveđa')," +
                "('Gornji Vratari Aleksandrovac')," +
                "('Gornjiajtan Medveđa')," +
                "('Gornjirabovacbilić')," +
                "('Gornji Dejan Vlasotince')," +
                "('Gornji Dobrić Loznica')," +
                "('Gornji Drenovac Žitorađa')," +
                "('Gornji Dubac Lučani')," +
                "('Gornji Dubič Trstenik')," +
                "('Gornji Dušnikadžin Han')," +
                "('Gornji Zabeljlogovac')," +
                "('Gornji Jasenovik Zubin Potok')," +
                "('Gornji Katun Varvarin')," +
                "('Gornji Kozji Dol Trgovište')," +
                "('Gornji Komren Niš – Crveni krst')," +
                "('Gornji Krivodol Dimitrovgrad')," +
                "('Gornji Krnjin Leposavić')," +
                "('Gornji Krstacora')," +
                "('Gornji Krupac Aleksinac')," +
                "('Gornji Krčin Varvarin')," +
                "('Gornji Lajkovac Mionica')," +
                "('Gornji Livočnjilane')," +
                "('Gornji Lipovac Brus')," +
                "('Gornji Ljubeš Aleksinac')," +
                "('Gornji Makrešnjilane')," +
                "('Gornji Matejevac Niš – Pantelej')," +
                "('Gornji Milanovacornji Milanovac')," +
                "('Gornji Mušić Mionica')," +
                "('Gornji Neradovac Vranje')," +
                "('Gornjibilić Srbica')," +
                "('Gornjirah Vlasotince')," +
                "('Gornji Petrič Klina')," +
                "('Gornji Prisjan Vlasotince')," +
                "('Gornji Ratiš Dečani')," +
                "('Gornji Račnik Jagodina')," +
                "('Gornji Ribnik Trstenik')," +
                "('Gornji Rinj Bela Palanka')," +
                "('Gornji Svračak Vučitrn')," +
                "('Gornji Sibovac Podujevo')," +
                "('Gornji Stajevac Trgovište')," +
                "('Gornji Statovac Prokuplje')," +
                "('Gornji Stepoš Kruševac')," +
                "('Gornji Stranjani Prijepolje')," +
                "('Gornji Streoc Dečani')," +
                "('Gornji Striževac Babušnica')," +
                "('Gornji Strmac Zubin Potok')," +
                "('Gornji Stupanj Aleksandrovac')," +
                "('Gornji Suvi Do Kosovska Mitrovica')," +
                "('Gornji Tavankut Subotica')," +
                "('Gornji Crniš Tutin')," +
                "('Gornji Crnobreg Dečani')," +
                "('Gorobilje Požega')," +
                "('Gorovič Topola')," +
                "('Gorožup Prizren')," +
                "('Gorčince Babušnica')," +
                "('Gospođince Preševo')," +
                "('Gospođinci Žabalj')," +
                "('Gostilje Čajetina')," +
                "('Gostinica Užice')," +
                "('Gostiradiće Raška')," +
                "('Gostun Prijepolje')," +
                "('Gostuša Pirot')," +
                "('Gotovuša Štrpce')," +
                "('Goč Vrnjačka Banja')," +
                "('Goševo Novi Pazar')," +
                "('Goševo Sjenica')," +
                "('Grab Lučani')," +
                "('Grabanica Klina')," +
                "('Grabac Klina')," +
                "('Grabovac Beograd –brenovac')," +
                "('Grabovac Knić')," +
                "('Grabovac Prokuplje')," +
                "('Grabovac Svilajnac')," +
                "('Grabovac Trstenik')," +
                "('Grabovac Peć')," +
                "('Grabovac Zvečan')," +
                "('Grabovicaornji Milanovac')," +
                "('Grabovica Despotovac')," +
                "('Grabovica Kladovo')," +
                "('Grabovica Sjenica')," +
                "('Grabovnica Kuršumlija')," +
                "('Grabovo Ražanj')," +
                "('Grabovo Beočin')," +
                "('Grabovci Ruma')," +
                "('Grad Brus')," +
                "('Grad Stalać Ćićevac')," +
                "('Gradac Batočina')," +
                "('Gradac Brus')," +
                "('Gradac Ivanjica')," +
                "('Gradac Raška')," +
                "('Gradac Sjenica')," +
                "('Gradac Tutin')," +
                "('Gradašnica Leskovac')," +
                "('Gradašnica Pirot')," +
                "('Gradinje Dimitrovgrad')," +
                "('Gradicalogovac')," +
                "('Gradište Bela Palanka')," +
                "('Gradište Vlasotince')," +
                "('Gradište Knjaževac')," +
                "('Gradište Merošina')," +
                "('Gradište Pirot')," +
                "('Gradnja Vranje')," +
                "('Gradojević Koceljeva')," +
                "('Gradska Crna Trava')," +
                "('Gradskovo Zaječar')," +
                "('Građanoviće Novi Pazar')," +
                "('Građenik Kosovska Kamenica')," +
                "('Graždanik Prizren')," +
                "('Grajevce Leskovac')," +
                "('Gramada Bujanovac')," +
                "('Gramađe Vladičin Han')," +
                "('Gramočelj Dečani')," +
                "('Granica Bojnik')," +
                "('Granice Beograd – Mladenovac')," +
                "('Graničane Leposavić')," +
                "('Graovo Leskovac')," +
                "('Grapa Dimitrovgrad')," +
                "('Grace Vučitrn')," +
                "('Gračane Novi Pazar')," +
                "('Gračanica Ljubovija')," +
                "('Gračanica Prijepolje')," +
                "('Gračanica Priština')," +
                "('Gračac Vrnjačka Banja')," +
                "('Graševci Brus')," +
                "('Graštica Priština')," +
                "('Grbavce Medveđa')," +
                "('Grbavče Svrljig')," +
                "('Grgaje Sjenica')," +
                "('Grgetek Irig')," +
                "('Grgoc Đakovica')," +
                "('Grgurevci Sremska Mitrovica')," +
                "('Grgurovce Lebane')," +
                "('Grdanica Leskovac')," +
                "('Grdelica (varoš) Leskovac')," +
                "('Grdelica (selo) Leskovac')," +
                "('Grdica Kraljevo')," +
                "('Grdovac Podujevo')," +
                "('Grdovići Arilje')," +
                "('Grebenac Bela Crkva')," +
                "('Grebnik Klina')," +
                "('Grebno Uroševac')," +
                "('Grevci Kruševac')," +
                "('Gredetin Aleksinac')," +
                "('Grezna Knjaževac')," +
                "('Grejač Aleksinac')," +
                "('Grejkovce Suva Reka')," +
                "('Grejčevce Suva Reka')," +
                "('Grivac Knić')," +
                "('Grivska Arilje')," +
                "('Grižani Zvečan')," +
                "('Grizime Kosovska Kamenica')," +
                "('Grkaje Leposavić')," +
                "('Grkinjaadžin Han')," +
                "('Grkljane Kruševac')," +
                "('Grlica Uroševac')," +
                "('Grlište Zaječar')," +
                "('Grljan Zaječar')," +
                "('Grmovo Vitina')," +
                "('Grnčar Babušnica')," +
                "('Grnčar Vitina')," +
                "('Grnčara Loznica')," +
                "('Grnčare Prizren')," +
                "('Grobnice Prijepolje')," +
                "('Groznatovci Surdulica')," +
                "('Grocka Beograd –rocka')," +
                "('Grošnica Kragujevac')," +
                "('Grubetiće Novi Pazar')," +
                "('Grudaš Žitorađa')," +
                "('Gruža Knić')," +
                "('Grujinci Bosilegrad')," +
                "('Grušić Šabac')," +
                "('Grčak Aleksandrovac')," +
                "('Grčac Smederevska Palanka')," +
                "('Grčina Đakovica')," +
                "('Grčić Ljubovija')," +
                "('Gubavce Medveđa')," +
                "('Guberevac Beograd – Sopot')," +
                "('Guberevac Knić')," +
                "('Guberevac Leskovac')," +
                "('Guberevci Lučani')," +
                "('Gubetin Prokuplje')," +
                "('Gubin Do Užice')," +
                "('Guvnište Leposavić')," +
                "('Guvno Selo Lipljan')," +
                "('Gugalj Požega')," +
                "('Gudurica Vršac')," +
                "('Gujiće Tutin')," +
                "('Gukoš Ljig')," +
                "('Gulenovci Dimitrovgrad')," +
                "('Gulijan Svrljig')," +
                "('Gulije Leposavić')," +
                "('Gumerište Vranje')," +
                "('Gumnište Vučitrn')," +
                "('Gumništenjilane')," +
                "('Gunaroš Bačka Topola')," +
                "('Guncat Suva Reka')," +
                "('Guncati Beograd – Barajevo')," +
                "('Guncati Knić')," +
                "('Gunjacisečina')," +
                "('Gunjevac Ub')," +
                "('Gunjetina Vlasotince')," +
                "('Gunjica Mionica')," +
                "('Gurgutovo Medveđa')," +
                "('Gurdijelje Tutin')," +
                "('Guriševci Topola')," +
                "('Guska Đakovica')," +
                "('Guceviće Tutin')," +
                "('Guča (varošica) Lučani')," +
                "('Guča (selo) Lučani')," +
                "('Gušavac Kosovska Mitrovica')," +
                "('Guševac Svrljig')," +
                "('Gušica Vitina')," +
                "('Dabinovac Kuršumlija')," +
                "('Dabiševac Priština')," +
                "('Davidovac Vranje')," +
                "('Davidovac Kladovo')," +
                "('Davidovac Paraćin')," +
                "('Davidovac Svrljig')," +
                "('Davidovicaornji Milanovac')," +
                "('Davidovce Štimlje')," +
                "('Dadince Vlasotince')," +
                "('Daždince Kosovska Kamenica')," +
                "('Dajići Ivanjica')," +
                "('Dajkovce Kosovska Kamenica')," +
                "('Dalašaj Đakovica')," +
                "('Damjane Đakovica')," +
                "('Dankoviće Kuršumlija')," +
                "('Danjanerahovac')," +
                "('Danjino Selo Surdulica')," +
                "('Darkovce Crna Trava')," +
                "('Darosava Aranđelovac')," +
                "('Dašinovac Dečani')," +
                "('Dašnica Aleksandrovac')," +
                "('Dašnica Aleksinac')," +
                "('Dvorane Kruševac')," +
                "('Dvorane Suva Reka')," +
                "('Dvorica Ćuprija')," +
                "('Dvorišteolubac')," +
                "('Dvorište Despotovac')," +
                "('Dvorište Šabac')," +
                "('Dvorište Podujevo')," +
                "('Dvorska Krupanj')," +
                "('Debelde Vitina')," +
                "('Debeli Lug Žitorađa')," +
                "('Debeli Lug Majdanpek')," +
                "('Debelica Knjaževac')," +
                "('Debelja Nova Varoš')," +
                "('Debeljača Kovačica')," +
                "('Debrc Vladimirci')," +
                "('Deva Đakovica')," +
                "('Devaja Vitina')," +
                "('Devet Jugovića Priština')," +
                "('Devetak Štimlje')," +
                "('Deveti maj Niš – Palilula')," +
                "('Devići Ivanjica')," +
                "('Devreč Tutin')," +
                "('Devča Merošina')," +
                "('Degrmen Kuršumlija')," +
                "('Degurić Valjevo')," +
                "('Dedaj Prizren')," +
                "('Dedevci Kraljevo')," +
                "('Dedina Kruševac')," +
                "('Dedina Bara Leskovac')," +
                "('Dedinac Kuršumlija')," +
                "('Dedinje Kosovska Mitrovica')," +
                "('Deževa Novi Pazar')," +
                "('Deič Klina')," +
                "('Dejanovac Knjaževac')," +
                "('Dejance Trgovište')," +
                "('Dekutince Vladičin Han')," +
                "('Deliblato Kovin')," +
                "('Deligrad Aleksinac')," +
                "('Delimeđe Tutin')," +
                "('Delovce Suva Reka')," +
                "('Deonica Jagodina')," +
                "('Depce Preševo')," +
                "('Deretin Ivanjica')," +
                "('Deronjedžaci')," +
                "('Desetak Leposavić')," +
                "('Desivojce Kosovska Kamenica')," +
                "('Desimirovac Kragujevac')," +
                "('Desine Velikoradište')," +
                "('Desić Šabac')," +
                "('Despotovac Despotovac')," +
                "('Despotovo Bačka Palanka')," +
                "('Detane Tutin')," +
                "('Deč Pećinci')," +
                "('Dečane Dečani')," +
                "('Dešilovo Merošina')," +
                "('Dešiška Kuršumlija')," +
                "('Divljaka Lipljan')," +
                "('Divljana Bela Palanka')," +
                "('Divostin Kragujevac')," +
                "('Divoš Sremska Mitrovica')," +
                "('Divci Valjevo')," +
                "('Divci Prijepolje')," +
                "('Divčibare Valjevo')," +
                "('Dikava Surdulica')," +
                "('Dikanceora')," +
                "('Dimitrovgrad Dimitrovgrad')," +
                "('Dimce Kačanik')," +
                "('Dići Ljig')," +
                "('Dljin Lučani')," +
                "('Dobanovci Beograd – Surčin')," +
                "('Doblibare Đakovica')," +
                "('Dobraolubac')," +
                "('Dobra Voda Bojnik')," +
                "('Dobra Voda Jagodina')," +
                "('Dobra Voda Klina')," +
                "('Dobra Luka Vučitrn')," +
                "('Dobrava Leposavić')," +
                "('Dobrača Kragujevac')," +
                "('Dobrače Arilje')," +
                "('Dobrejance Vranje')," +
                "('Dobri Do Ivanjica')," +
                "('Dobri Do Kuršumlija')," +
                "('Dobri Do Pirot')," +
                "('Dobri Do Smederevo')," +
                "('Dobri Do Peć')," +
                "('Dobri Do Podujevo')," +
                "('Dobri Dol Klina')," +
                "('Dobri Dolrahovac')," +
                "('Dobri Dub Tutin')," +
                "('Dobri Dub Kosovo Polje')," +
                "('Dobrilovići Priboj')," +
                "('Dobrinci Ruma')," +
                "('Dobrinje Tutin')," +
                "('Dobrić Šabac')," +
                "('Dobrić Đakovica')," +
                "('Dobrica Alibunar')," +
                "('Dobričevo Bela Crkva')," +
                "('Dobrnje Petrova na Mlavi')," +
                "('Dobro Polje Boljevac')," +
                "('Dobro Polje Crna Trava')," +
                "('Dobroviš Vlasotince')," +
                "('Dobrovodica Batočina')," +
                "('Dobrodeljane Suva Reka')," +
                "('Dobrodo Užice')," +
                "('Dobrodol Irig')," +
                "('Dobroljubci Aleksandrovac')," +
                "('Dobromir Kruševac')," +
                "('Dobroselica Rekovac')," +
                "('Dobroselica Čajetina')," +
                "('Dobrosin Bujanovac')," +
                "('Dobrotin Bajina Bašta')," +
                "('Dobrotin Leskovac')," +
                "('Dobrotin Lipljan')," +
                "('Dobrotin Podujevo')," +
                "('Dobrotić Prokuplje')," +
                "('Dobroš Đakovica')," +
                "('Dobroševaclogovac')," +
                "('Dobroševina Zubin Potok')," +
                "('Dobrujevac Aleksinac')," +
                "('Dobrujevac Boljevac')," +
                "('Dobruša Istok')," +
                "('Dobrušte Prizren')," +
                "('Dobrčanenjilane')," +
                "('Doganica Bosilegrad')," +
                "('Doganović Kačanik')," +
                "('Doganjevo Uroševac')," +
                "('Dojinoviće Novi Pazar')," +
                "('Dojkinci Pirot')," +
                "('Dojnice Prizren')," +
                "('Dokmir Ub')," +
                "('Dol Babušnica')," +
                "('Dolac Kraljevo')," +
                "('Dolac Novi Pazar')," +
                "('Dolac Klina')," +
                "('Dolac (naselje) Bela Palanka')," +
                "('Dolac (selo) Bela Palanka')," +
                "('Doline Kanjiža')," +
                "('Doliće Sjenica')," +
                "('Dolovo Tutin')," +
                "('Dolovo Pančevo')," +
                "('Dolovo Klina')," +
                "('Dolj Đakovica')," +
                "('Doljak Vučitrn')," +
                "('Doljane Kruševac')," +
                "('Doljane Zvečan')," +
                "('Doljani Novi Pazar')," +
                "('Doljašnica Velikoradište')," +
                "('Doljevac Doljevac')," +
                "('Domaneklogovac')," +
                "('Domanekrahovac')," +
                "('Domiševina Brus')," +
                "('Domorovce Kosovska Kamenica')," +
                "('Donja Badanja Loznica')," +
                "('Donja Bejašnica Prokuplje')," +
                "('Donja Bela Reka Bor')," +
                "('Donja Bela Reka Nova Varoš')," +
                "('Donja Bitinja Štrpce')," +
                "('Donja Borina Mali Zvornik')," +
                "('Donja Bresnica Prokuplje')," +
                "('Donja Brnjica Priština')," +
                "('Donja Budriganjilane')," +
                "('Donja Bukovica Valjevo')," +
                "('Donja Bunuša Leskovac')," +
                "('Donja Vrbavaornji Milanovac')," +
                "('Donja Vrežina Niš – Pantelej')," +
                "('Donjalama Bela Palanka')," +
                "('Donjaorevnica Čačak')," +
                "('Donjaušterica Lipljan')," +
                "('Donja Dobrinja Požega')," +
                "('Donja Draguša Blace')," +
                "('Donja Dubnica Vučitrn')," +
                "('Donja Dubnica Podujevo')," +
                "('Donja Zleginja Aleksandrovac')," +
                "('Donja Jajina Leskovac')," +
                "('Donja Jošanica Blace')," +
                "('Donja Kamenica Knjaževac')," +
                "('Donja Klina Srbica')," +
                "('Donja Konjuša Prokuplje')," +
                "('Donja Koreticalogovac')," +
                "('Donja Koritnica Bela Palanka')," +
                "('Donja Kravarica Lučani')," +
                "('Donja Kruševicaolubac')," +
                "('Donja Krušica Suva Reka')," +
                "('Donja Kupinovica Leskovac')," +
                "('Donja Lapaštica Medveđa')," +
                "('Donja Lapaštica Podujevo')," +
                "('Donja Livadica Velika Plana')," +
                "('Donja Lisina Bosilegrad')," +
                "('Donja Lokošnica Leskovac')," +
                "('Donja Lomnica Vlasotince')," +
                "('Donja Lopušnja Vlasotince')," +
                "('Donja Luka Dečani')," +
                "('Donja Ljubata Bosilegrad')," +
                "('Donja Ljuboviđa Ljubovija')," +
                "('Donja Mikuljana Kuršumlija')," +
                "('Donja Mutnica Paraćin')," +
                "('Donja Nevlja Dimitrovgrad')," +
                "('Donjamašnica Trstenik')," +
                "('Donjarovica Ljubovija')," +
                "('Donjatulja Vranje')," +
                "('Donja Pakaštica Podujevo')," +
                "('Donja Peščanica Aleksinac')," +
                "('Donja Pološnica Kosjerić')," +
                "('Donja Rapčaora')," +
                "('Donja Rasovača Merošina')," +
                "('Donja Rača Rača')," +
                "('Donja Rašica Blace')," +
                "('Donja Rečica Prokuplje')," +
                "('Donja Ržana Bosilegrad')," +
                "('Donja Sabanta Kragujevac')," +
                "('Donja Sipulja Loznica')," +
                "('Donja Slatina Leskovac')," +
                "('Donja Slatina Vitina')," +
                "('Donja Sokolovica Knjaževac')," +
                "('Donja Srbica Prizren')," +
                "('Donja Stražava Prokuplje')," +
                "('Donja Stubla Vitina')," +
                "('Donja Studena Niš – Niška Banja')," +
                "('Donja Sudimlja Vučitrn')," +
                "('Donja Toponica Prokuplje')," +
                "('Donja Toponica Niš – Crveni krst')," +
                "('Donja Trepča Čačak')," +
                "('Donja Trešnjevica Topola')," +
                "('Donja Trešnjica Mali Zvornik')," +
                "('Donja Trnava Prokuplje')," +
                "('Donja Trnava Topola')," +
                "('Donja Trnava Niš – Crveni krst')," +
                "('Donja Trnica Trgovište')," +
                "('Donja Fušticalogovac')," +
                "('Donja Crnišava Trstenik')," +
                "('Donja Crnućaornji Milanovac')," +
                "('Donja Šatornja Topola')," +
                "('Donja Šipašnica Kosovska Kamenica')," +
                "('Donja Šušaja Preševo')," +
                "('Donje Babine Prijepolje')," +
                "('Donje Brijanje Leskovac')," +
                "('Donje Varage Zubin Potok')," +
                "('Donje Vidovo Paraćin')," +
                "('Donje Vinarce Kosovska Mitrovica')," +
                "('Donje Vlase Niš – Palilula')," +
                "('Donje Vranovce Lebane')," +
                "('Donjeadimlje Lipljan')," +
                "('Donjeare Vlasotince')," +
                "('Donjeodance Štimlje')," +
                "('Donjeoračiće Sjenica')," +
                "('Donjerbice Kragujevac')," +
                "('Donjergure Blace')," +
                "('Donje Dobrevo Kosovo Polje')," +
                "('Donje Dragovljeadžin Han')," +
                "('Donje Žabare Kosovska Mitrovica')," +
                "('Donje Žapsko Vranje')," +
                "('Donje Zuniče Knjaževac')," +
                "('Donje Isevo Leposavić')," +
                "('Donje Jabukovo Vladičin Han')," +
                "('Donje Jarušice Rača')," +
                "('Donje Karačevo Kosovska Kamenica')," +
                "('Donje Komarice Kragujevac')," +
                "('Donje Konjuvce Bojnik')," +
                "('Donje Kordince Prokuplje')," +
                "('Donje Korminjane Kosovska Kamenica')," +
                "('Donje Krajince Leskovac')," +
                "('Donje Krnjino Babušnica')," +
                "('Donje Leviće Brus')," +
                "('Donje Leskovice Valjevo')," +
                "('Donje Lopiže Sjenica')," +
                "('Donje Ljubinje Prizren')," +
                "('Donje Ljupče Podujevo')," +
                "('Donje Međurovo Niš – Palilula')," +
                "('Donje Nedeljice Loznica')," +
                "('Donje Nerodimlje Uroševac')," +
                "('Donje Novo Selo Bujanovac')," +
                "('Donje Novo Selo Đakovica')," +
                "('Donjebrinje Srbica')," +
                "('Donje Potočanerahovac')," +
                "('Donje Prekaze Srbica')," +
                "('Donje Punoševce Vranje')," +
                "('Donje Ramnjane Vitina')," +
                "('Donje Rataje Aleksandrovac')," +
                "('Donje Rašane Kosovska Mitrovica')," +
                "('Donje Romanovce Surdulica')," +
                "('Donje Svarče Blace')," +
                "('Donje Sinkovce Leskovac')," +
                "('Donje Slakovcenjilane')," +
                "('Donje Stanovce Vučitrn')," +
                "('Donje Stopanje Leskovac')," +
                "('Donje Suhotno Aleksinac')," +
                "('Donje Tlamino Bosilegrad')," +
                "('Donje Točane Kuršumlija')," +
                "('Donje Trebešinje Vranje')," +
                "('Donje Trnjane Leskovac')," +
                "('Donje Crnatovo Žitorađa')," +
                "('Donje Crniljevo Koceljeva')," +
                "('Donje Šlje Jagodina')," +
                "('Donji Adrovac Aleksinac')," +
                "('Donji Banjani Ljig')," +
                "('Donji Barbešadžin Han')," +
                "('Donji Biteš Đakovica')," +
                "('Donji Branetićiornji Milanovac')," +
                "('Donji Bunibrod Leskovac')," +
                "('Donji Bučumet Medveđa')," +
                "('Donji Vratari Aleksandrovac')," +
                "('Donjiajtan Medveđa')," +
                "('Donjirabovac Kosovo Polje')," +
                "('Donji Dejan Vlasotince')," +
                "('Donji Dobrić Loznica')," +
                "('Donji Drenovac Žitorađa')," +
                "('Donji Dubac Lučani')," +
                "('Donji Dubič Trstenik')," +
                "('Donji Dušnikadžin Han')," +
                "('Donji Zabeljlogovac')," +
                "('Donji Istok Istok')," +
                "('Donji Jasenovik Zubin Potok')," +
                "('Donji Katun Varvarin')," +
                "('Donji Kozji Dol Trgovište')," +
                "('Donji Komren Niš – Crveni krst')," +
                "('Donji Krivodol Dimitrovgrad')," +
                "('Donji Krnjin Leposavić')," +
                "('Donji Krstacora')," +
                "('Donji Krupac Aleksinac')," +
                "('Donji Krčin Varvarin')," +
                "('Donji Lajkovac Lajkovac')," +
                "('Donji Livočnjilane')," +
                "('Donji Lipovac Brus')," +
                "('Donji Ljubeš Aleksinac')," +
                "('Donji Makrešnjilane')," +
                "('Donji Matejevac Niš – Pantelej')," +
                "('Donji Milanovac Majdanpek')," +
                "('Donji Mušić Mionica')," +
                "('Donji Neradovac Vranje')," +
                "('Donjibilić Srbica')," +
                "('Donji Petrič Klina')," +
                "('Donji Petrovci Ruma')," +
                "('Donji Prisjan Vlasotince')," +
                "('Donji Ratiš Dečani')," +
                "('Donji Račnik Jagodina')," +
                "('Donji Ribnik Trstenik')," +
                "('Donji Rinj Bela Palanka')," +
                "('Donji Svračak Vučitrn')," +
                "('Donji Sibovac Podujevo')," +
                "('Donji Stajevac Trgovište')," +
                "('Donji Statovac Prokuplje')," +
                "('Donji Stepoš Kruševac')," +
                "('Donji Stranjani Prijepolje')," +
                "('Donji Streoc Dečani')," +
                "('Donji Striževac Babušnica')");
                  migrationBuilder.Sql(
                "insert into Mesta(NazivMesta) values " +
                "('Donji Stupanj Aleksandrovac')," +
                "('Donji Suvi Do Kosovska Mitrovica')," +
                "('Donji Tavankut Subotica')," +
                "('Donji Tovarnik Pećinci')," +
                "('Donji Crnobreg Dečani')," +
                "('Doroslovo Sombor')," +
                "('Doševac Srbica')," +
                "('Draga Tutin')," +
                "('Dragaljice Zubin Potok')," +
                "('Draganacnjilane')," +
                "('Draganići Raška')," +
                "('Dragašora')," +
                "('Dragi Deo Prokuplje')," +
                "('Dragijevicasečina')," +
                "('Draginac Babušnica')," +
                "('Draginac Loznica')," +
                "('Draginje Koceljeva')," +
                "('Draglica Nova Varoš')," +
                "('Dragobiljerahovac')," +
                "('Dragobraća Kragujevac')," +
                "('Dragobužde Vranje')," +
                "('Dragovac Bojnik')," +
                "('Dragovac Požarevac')," +
                "('Dragovac Priština')," +
                "('Dragovita Dimitrovgrad')," +
                "('Dragovo Rekovac')," +
                "('Dragodolsečina')," +
                "('Dragojevac Arilje')," +
                "('Dragojevac Vladimirci')," +
                "('Dragojloviće Sjenica')," +
                "('Dragoljornji Milanovac')," +
                "('Dragoljevac Istok')," +
                "('Dragosinjci Kraljevo')," +
                "('Dragocvet Jagodina')," +
                "('Dragočevo Novi Pazar')," +
                "('Dragoševac Jagodina')," +
                "('Dragušica Knić')," +
                "('Dražanj Beograd –rocka')," +
                "('Draževac Aleksinac')," +
                "('Draževac Beograd –brenovac')," +
                "('Draževiće Sjenica')," +
                "('Draževići Nova Varoš')," +
                "('Draževo Bela Palanka')," +
                "('Dražiniće Kraljevo')," +
                "('Dražinovići Požega')," +
                "('Dražmirovac Jagodina')," +
                "('Drainoviće Zubin Potok')," +
                "('Drajinac Svrljig')," +
                "('Drajinci Surdulica')," +
                "('Drajkovce Štrpce')," +
                "('Drajčići Prizren')," +
                "('Draksin Bajina Bašta')," +
                "('Drakčići Kraljevo')," +
                "('Dramiće Novi Pazar')," +
                "('Dramnjak Uroševac')," +
                "('Drača Kragujevac')," +
                "('Dračić Valjevo')," +
                "('Draškovac Leskovac')," +
                "('Drvare Vučitrn')," +
                "('Drvnik Knjaževac')," +
                "('Drvodelj Lebane')," +
                "('Drvodelja Leskovac')," +
                "('Drežnik Užice')," +
                "('Drežnica Bujanovac')," +
                "('Drelje Peć')," +
                "('Dren Beograd – Lazarevac')," +
                "('Dren Beograd –brenovac')," +
                "('Dren Zubin Potok')," +
                "('Dren Leposavić')," +
                "('Drenova Brus')," +
                "('Drenovaornji Milanovac')," +
                "('Drenova Prijepolje')," +
                "('Drenova Čajetina')," +
                "('Drenovalava Kačanik')," +
                "('Drenovac Vranje')," +
                "('Drenovac Knjaževac')," +
                "('Drenovac Kragujevac')," +
                "('Drenovac Paraćin')," +
                "('Drenovac Prokuplje')," +
                "('Drenovac Šabac')," +
                "('Drenovac Dečani')," +
                "('Drenovac Klina')," +
                "('Drenovacrahovac')," +
                "('Drenovac Priština')," +
                "('Drenovce Kosovska Kamenica')," +
                "('Drenovci Kosjerić')," +
                "('Drenovčić Klina')," +
                "('Drence Medveđa')," +
                "('Drenča Aleksandrovac')," +
                "('Drenje Istok')," +
                "('Drečinovac Knjaževac')," +
                "('Drešnica Blace')," +
                "('Držanovac Žitorađa')," +
                "('Držina Pirot')," +
                "('Drijetanj Užice')," +
                "('Drlače Ljubovija')," +
                "('Drlupa Beograd – Sopot')," +
                "('Drlupa Kraljevo')," +
                "('Drmanovići Nova Varoš')," +
                "('Drmno Požarevac')," +
                "('Drobeš Vitina')," +
                "('Drobnjak Kačanik')," +
                "('Drsnik Klina')," +
                "('Drtevci Brus')," +
                "('Drćevac Leskovac')," +
                "('Drugovac Smederevo')," +
                "('Družetić Koceljeva')," +
                "('Družetićiornji Milanovac')," +
                "('Družiniće Sjenica')," +
                "('Dub Bajina Bašta')," +
                "('Dublje Bogatić')," +
                "('Dublje Svilajnac')," +
                "('Dublje Trstenik')," +
                "('Dubnica Vranje')," +
                "('Dubnica Kosjerić')," +
                "('Dubnica Svilajnac')," +
                "('Dubnica Sjenica')," +
                "('Dubovac Kovin')," +
                "('Dubovac Vučitrn')," +
                "('Dubovik Dečani')," +
                "('Dubovo Žitorađa')," +
                "('Dubovo Tutin')," +
                "('Dubovo Peć')," +
                "('Duboka Kučevo')," +
                "('Duboka Jagodina')," +
                "('Duboka Leposavić')," +
                "('Duboko Ljubovija')," +
                "('Duboko Užice')," +
                "('Dubona Beograd – Mladenovac')," +
                "('Dubočak Peć')," +
                "('Dubočane Zaječar')," +
                "('Dubočka Petrova na Mlavi')," +
                "('Dubrava Bojnik')," +
                "('Dubrava Ivanjica')," +
                "('Dubrava Knić')," +
                "('Dubrava Kuršumlija')," +
                "('Dubrava Dečani')," +
                "('Dubrava Istok')," +
                "('Dubrava Kačanik')," +
                "('Dubrava Suva Reka')," +
                "('Dubravica Požarevac')," +
                "('Duvanište Šabac')," +
                "('Duga Štimlje')," +
                "('Duga Luka Vranjska Banja')," +
                "('Duga Poljanaadžin Han')," +
                "('Duga Poljana Sjenica')," +
                "('Duganjive Peć')," +
                "('Dugi Del Surdulica')," +
                "('Dugo Polje Sokobanja')," +
                "('Dugojnica Surdulica')," +
                "('Dugonjive Klina')," +
                "('Dudovica Beograd – Lazarevac')," +
                "('Dudulajce Merošina')," +
                "('Dužine Plandište')," +
                "('Dužnje Đakovica')," +
                "('Duz Podujevo')," +
                "('Dujak Đakovica')," +
                "('Dujke Sjenica')," +
                "('Dukat Bosilegrad')," +
                "('Dukatadžin Han')," +
                "('Dulan Vranje')," +
                "('Dulebe Tutin')," +
                "('Dulene Kragujevac')," +
                "('Dulje Suva Reka')," +
                "('Dumbija Trgovište')," +
                "('Dumoš Podujevo')," +
                "('Dunavac Beograd – Palilula')," +
                "('Dunavonjilane')," +
                "('Dunišiće Sjenica')," +
                "('Dupeljevo Vranje')," +
                "('Dupljaj Valjevo')," +
                "('Dupljaja Bela Crkva')," +
                "('Dupljane Vladičin Han')," +
                "('Dupljane Negotin')," +
                "('Dupci Brus')," +
                "('Dura Kačanik')," +
                "('Dučalovići Lučani')," +
                "('Dučevac Babušnica')," +
                "('Dučina Beograd – Sopot')," +
                "('Dučić Mionica')," +
                "('Duš Klina')," +
                "('Dušanovac Negotin')," +
                "('Dušanovo Leskovac')," +
                "('Dušanovo Prizren')," +
                "('Dušević Klina')," +
                "('Duškovci Požega')," +
                "('Dušmanićolubac')," +
                "('Dušmanići Prijepolje')," +
                "('Đake Kuršumlija')," +
                "('Đakovica Đakovica')," +
                "('Đakovo Kraljevo')," +
                "('Đakus Žitorađa')," +
                "('Đala Novi Kneževac')," +
                "('Đelekare Vitina')," +
                "('Đeneral Janković Kačanik')," +
                "('Đerađ Lučani')," +
                "('Đerekare Brus')," +
                "('Đerekare Tutin')," +
                "('Đerekarce Trgovište')," +
                "('Đinđuša Bojnik')," +
                "('Đinovce Suva Reka')," +
                "('Đonaj Prizren')," +
                "('Đorđevac Bujanovac')," +
                "('Đocaj Dečani')," +
                "('Đulekare Medveđa')," +
                "('Đunis Kruševac')," +
                "('Đurakovac Istok')," +
                "('Đurakovo Velikoradište')," +
                "('Đurašići Prijepolje')," +
                "('Đurđev Dol Kačanik')," +
                "('Đurđevac Mionica')," +
                "('Đurđevo Rača')," +
                "('Đurđevo Žabalj')," +
                "('Đurđin Subotica')," +
                "('Đurevac Blace')," +
                "('Đurinac Svilajnac')," +
                "('Đurinac Svrljig')," +
                "('Đurinci Beograd – Sopot')," +
                "('Đuriselo Kragujevac')," +
                "('Đuriševce Kosovska Kamenica')," +
                "('Đurkovce Štimlje')," +
                "('Đurovac Prokuplje')," +
                "('Đušnica Prokuplje')," +
                "('Eleza Kačanik')," +
                "('Elemir Zrenjanin')," +
                "('Ence Kosovo Polje')," +
                "('Ervenice Tutin')," +
                "('Erdevik Šid')," +
                "('Erdeč Kragujevac')," +
                "('Ereč Đakovica')," +
                "('Erčege Ivanjica')," +
                "('Ečka Zrenjanin')," +
                "('Žabalj Žabalj')," +
                "('Žabar Šabac')," +
                "('Žabare Kruševac')," +
                "('Žabare Topola')," +
                "('Žabari Valjevo')," +
                "('Žabari Žabari')," +
                "('Žabelj Đakovica')," +
                "('Žabljane Leskovac')," +
                "('Žabren Sjenica')," +
                "('Žagubica Žagubica')," +
                "('Žaža Zvečan')," +
                "('Žakovo Istok')," +
                "('Žalica Kuršumlija')," +
                "('Žaočani Čačak')," +
                "('Žarevo Brus')," +
                "('Žarevo Zubin Potok')," +
                "('Žarkovac Ruma')," +
                "('Žač Istok')," +
                "('Žbevac Bujanovac')," +
                "('Ždeglovo Lebane')," +
                "('Ždrelo Petrova na Mlavi')," +
                "('Ždrelo Đakovica')," +
                "('Žegovacnjilane')," +
                "('Žegovačka Vrbicanjilane')," +
                "('Žegranjilane')," +
                "('Žegrova Kuršumlija')," +
                "('Željevo Svrljig')," +
                "('Željine Čajetina')," +
                "('Željuša Dimitrovgrad')," +
                "('Žeravino Bosilegrad')," +
                "('Žerađe Raška')," +
                "('Žerovnica Zvečan')," +
                "('Živinice Priboj')," +
                "('Živinjane Prizren')," +
                "('Živica Lučani')," +
                "('Živica Požarevac')," +
                "('Živkovac Beograd –rocka')," +
                "('Živkovo Leskovac')," +
                "('Živkovci Ljig')," +
                "('Židilje Despotovac')," +
                "('Žižavica Leskovac')," +
                "('Žilivoda Vučitrn')," +
                "('Žilinci Brus')," +
                "('Žiljci Brus')," +
                "('Žirovnica Batočina')," +
                "('Žirče Tutin')," +
                "('Žitinje Vitina')," +
                "('Žitinje Podujevo')," +
                "('Žitište Žitište')," +
                "('Žitkovac Aleksinac')," +
                "('Žitkovac Zvečan')," +
                "('Žitkovicaolubac')," +
                "('Žitni Potok Prokuplje')," +
                "('Žitniće Sjenica')," +
                "('Žitorađa Žitorađa')," +
                "('Žitorađe Vladičin Han')," +
                "('Žiča Kraljevo')," +
                "('Žlne Knjaževac')," +
                "('Žub Đakovica')," +
                "('Žuželjica Bujanovac')," +
                "('Žuja Kosovska Kamenica')," +
                "('Žujince Preševo')," +
                "('Žukovac Knjaževac')," +
                "('Žunje Brus')," +
                "('Žunje Knić')," +
                "('Žunjeviće Novi Pazar')," +
                "('Župa Tutin')," +
                "('Županjac Beograd – Lazarevac')," +
                "('Županjevac Rekovac')," +
                "('Žur Prizren')," +
                "('Žutice Raška')," +
                "('Žuč Kuršumlija')," +
                "('Žuče Tutin')," +
                "('Žučkovac Sokobanja')," +
                "('Zablaće Čačak')," +
                "('Zablaće Šabac')," +
                "('Zablaće Istok')," +
                "('Zabojnica Knić')," +
                "('Zabrdica Valjevo')," +
                "('Zabrdnji Toci Prijepolje')," +
                "('Zabrđe Novi Pazar')," +
                "('Zabrđe Petrova na Mlavi')," +
                "('Zabrđe Priboj')," +
                "('Zabrđe Sjenica')," +
                "('Zabrđe Klina')," +
                "('Zabrđe Leposavić')," +
                "('Zabrđe Kosovska Mitrovica')," +
                "('Zabrega Malo Crniće')," +
                "('Zabrega Paraćin')," +
                "('Zabrežje Beograd –brenovac')," +
                "('Zabrnjica Priboj')," +
                "('Zavidince Babušnica')," +
                "('Zavinograđe Prijepolje')," +
                "('Zavlaka Krupanj')," +
                "('Zavrata Leposavić')," +
                "('Zagajica Vršac')," +
                "('Zaglavak Bajina Bašta')," +
                "('Zagorica Topola')," +
                "('Zagorje Vučitrn')," +
                "('Zagradina Priboj')," +
                "('Zagrađeornji Milanovac')," +
                "('Zagrađe Zaječar')," +
                "('Zagrađe Kuršumlija')," +
                "('Zagrađe Zubin Potok')," +
                "('Zagrmlje Peć')," +
                "('Zagužane Leskovac')," +
                "('Zagužanje Surdulica')," +
                "('Zagulj Zubin Potok')," +
                "('Zajača Loznica')," +
                "('Zaječar Zaječar')," +
                "('Zaječiće Sjenica')," +
                "('Zajmovo Klina')," +
                "('Zajčevce Kosovska Kamenica')," +
                "('Zaklopača Beograd –rocka')," +
                "('Zaklopača Kraljevo')," +
                "('Zakut Podujevo')," +
                "('Zakuta Kraljevo')," +
                "('Zalogovac Varvarin')," +
                "('Zalug Prijepolje')," +
                "('Zalužnje Leskovac')," +
                "('Zamčanje Kraljevo')," +
                "('Zaovine Bajina Bašta')," +
                "('Zaostro Priboj')," +
                "('Zapadni Mojstir Tutin')," +
                "('Zaplužje Prizren')," +
                "('Zarbince Bujanovac')," +
                "('Zarevo Raška')," +
                "('Zarožje Bajina Bašta')," +
                "('Zarube Valjevo')," +
                "('Zasavica I Sremska Mitrovica')," +
                "('Zasavica II Sremska Mitrovica')," +
                "('Zasad Kraljevo')," +
                "('Zasela Kosovska Mitrovica')," +
                "('Zaselje Požega')," +
                "('Zaskovci Pirot')," +
                "('Zaskok Uroševac')," +
                "('Zastup Prijepolje')," +
                "('Zatonje Velikoradište')," +
                "('Zatrićrahovac')," +
                "('Zaugline Bajina Bašta')," +
                "('Zahać Peć')," +
                "('Zahumsko Sjenica')," +
                "('Zbojštica Užice')," +
                "('Zborce Štimlje')," +
                "('Zvezd Vladimirci')," +
                "('Zvezdan Zaječar')," +
                "('Zvečan Zvečan')," +
                "('Zvečka Beograd –brenovac')," +
                "('Zvizdar Ub')," +
                "('Zvijezd Prijepolje')," +
                "('Zvonce Babušnica')," +
                "('Zgatar Prizren')," +
                "('Zdravinje Kruševac')," +
                "('Zdravinje Prokuplje')," +
                "('Zdravčići Požega')," +
                "('Zebince Vladičin Han')," +
                "('Zebince Novo Brdo')," +
                "('Zebica Kruševac')," +
                "('Zebica Kuršumlija')," +
                "('Zelenik Kučevo')," +
                "('Zeletovo Bojnik')," +
                "('Zemanica Leposavić')," +
                "('Zeoke Beograd – Lazarevac')," +
                "('Zeoke Lučani')," +
                "('Zečeviće Zubin Potok')," +
                "('Zijača Kosovska Mitrovica')," +
                "('Zjumpoljski Prizren')," +
                "('Zjum Has Prizren')," +
                "('Zladovac Žitorađa')," +
                "('Zladovce Trgovište')," +
                "('Zlakusa Užice')," +
                "('Zlata Prokuplje')," +
                "('Zlatance Crna Trava')," +
                "('Zlatare Novi Pazar')," +
                "('Zlatare Priština')," +
                "('Zlatare Uroševac')," +
                "('Zlatari Brus')," +
                "('Zlatarić Valjevo')," +
                "('Zlatibor Čajetina')," +
                "('Zlatićevo Vlasotince')," +
                "('Zlatovo Despotovac')," +
                "('Zlatokop Vranje')," +
                "('Zli Dol Bosilegrad')," +
                "('Zli Potokora')," +
                "('Zlodol Bajina Bašta')," +
                "('Zlokućane Leskovac')," +
                "('Zlokućane Klina')," +
                "('Zlokućane Lipljan')," +
                "('Zlopek Peć')," +
                "('Zlot Bor')," +
                "('Zloćudovo Leskovac')," +
                "('Zmajevo Vrbas')," +
                "('Zminjak Šabac')," +
                "('Zobnatica Bačka Topola')," +
                "('Zojić Prizren')," +
                "('Zoljevo Leskovac')," +
                "('Zorovac Bojnik')," +
                "('Zorunovac Knjaževac')," +
                "('Zočišterahovac')," +
                "('Zrenjanin Zrenjanin')," +
                "('Zrzerahovac')," +
                "('Zrze Prizren')," +
                "('Zrnosek Leposavić')," +
                "('Zubetinac Knjaževac')," +
                "('Zubin Potok Zubin Potok')," +
                "('Zubovac Kruševac')," +
                "('Zukve Koceljeva')," +
                "('Zulfaj Đakovica')," +
                "('Zupče Zubin Potok')," +
                "('Zuce Beograd – Voždovac')," +
                "('Ibarsko Postenje Leposavić')," +
                "('Ivaja Kačanik')," +
                "('Ivan Kula Kuršumlija')," +
                "('Ivankovac Ćuprija')," +
                "('Ivanovo Pančevo')," +
                "('Ivanovci Ljig')," +
                "('Ivanča Novi Pazar')," +
                "('Ivanje Bojnik')," +
                "('Ivanje Prijepolje')," +
                "('Ivanjica Ivanjica')," +
                "('Ivezići Prijepolje')," +
                "('Ivkovački Prnjavor Jagodina')," +
                "('Iglarevo Klina')," +
                "('Igrište Kuršumlija')," +
                "('Igrište Leskovac')," +
                "('Igroš Brus')," +
                "('Idvor Kovačica')," +
                "('Iđoš Kikinda')," +
                "('Ižance Štrpce')," +
                "('Izatovci Dimitrovgrad')," +
                "('Izbenica Varvarin')," +
                "('Izbica Srbica')," +
                "('Izbice Novi Pazar')," +
                "('Izbičanj Prijepolje')," +
                "('Izbište Vršac')," +
                "('Izvarica Žagubica')," +
                "('Izvor Babušnica')," +
                "('Izvor Bosilegrad')," +
                "('Izvor Žitorađa')," +
                "('Izvor Paraćin')," +
                "('Izvor Pirot')," +
                "('Izvor Svrljig')," +
                "('Izvor Novo Brdo')," +
                "('Izvori Zvečan')," +
                "('Izrok Tutin')," +
                "('Izumno Vranjska Banja')," +
                "('Ilandža Alibunar')," +
                "('Ilino Boljevac')," +
                "('Ilince Preševo')," +
                "('Ilinci Šid')," +
                "('Inatovcenjilane')," +
                "('Inđija Inđija')," +
                "('Inovo Knjaževac')," +
                "('Irig Irig')," +
                "('Iričići Brus')," +
                "('Isakovo Ćuprija')," +
                "('Iskrovci Dimitrovgrad')," +
                "('Istinić Dečani')," +
                "('Istok Istok')," +
                "('Istočni Mojstir Tutin')," +
                "('Jablanica Boljevac')," +
                "('Jablanica Bujanovac')," +
                "('Jablanicaornji Milanovac')," +
                "('Jablanica Kruševac')," +
                "('Jablanica Novi Pazar')," +
                "('Jablanica Tutin')," +
                "('Jablanica Čajetina')," +
                "('Jablanica Đakovica')," +
                "('Jablanica Peć')," +
                "('Jablanica Prizren')," +
                "('Jablanka Vršac')," +
                "('Jabuka Prijepolje')," +
                "('Jabuka Pančevo')," +
                "('Jabuka Zubin Potok')," +
                "('Jabukovac Negotin')," +
                "('Jabukovik Crna Trava')," +
                "('Jabučevo Prokuplje')," +
                "('Jabučje Kragujevac')," +
                "('Jabučje Lajkovac')," +
                "('Javor Novi Pazar')," +
                "('Javor Suva Reka')," +
                "('Javorje Vlasotince')," +
                "('Javorska Ravnaora Ivanjica')," +
                "('Jagličjeadžin Han')," +
                "('Jagnjenica Zubin Potok')," +
                "('Jagnjilo Beograd – Mladenovac')," +
                "('Jagnjilo Vladičin Han')," +
                "('Jagoda Klina')," +
                "('Jagodina Jagodina')," +
                "('Jagoštica Bajina Bašta')," +
                "('Jadranska Lešnica Loznica')," +
                "('Jažince Štrpce')," +
                "('Jazak Irig')," +
                "('Jazovik Valjevo')," +
                "('Jazovnik Vladimirci')," +
                "('Jazovo Čoka')," +
                "('Jajčić Ljig')," +
                "('Jakalj Bajina Bašta')," +
                "('Jakovac Knjaževac')," +
                "('Jakovlje Aleksinac')," +
                "('Jakovljevo Vlasotince')," +
                "('Jakovo Beograd – Surčin')," +
                "('Jalbotina Pirot')," +
                "('Jalovik Vladimirci')," +
                "('Jalovik Izvor Knjaževac')," +
                "('Jamena Šid')," +
                "('Jankov Most Zrenjanin')," +
                "('Jankov Potok Zvečan')," +
                "('Janoš Đakovica')," +
                "('Janošik Alibunar')," +
                "('Janča Novi Pazar')," +
                "('Jančići Čačak')," +
                "('Jančišterahovac')," +
                "('Janja Knjaževac')," +
                "('Janjevo Lipljan')," +
                "('Jarak Sremska Mitrovica')," +
                "('Jarebice Loznica')," +
                "('Jarebice Tutin')," +
                "('Jarešnik Bosilegrad')," +
                "('Jarinje Leposavić')," +
                "('Jarkovac Sečanj')," +
                "('Jarkovci Inđija')," +
                "('Jarmenovci Topola')," +
                "('Jarsenovo Leskovac')," +
                "('Jarčujak Kraljevo')," +
                "('Jasenak Beograd –brenovac')," +
                "('Jasenica Valjevo')," +
                "('Jasenica Žitorađa')," +
                "('Jasenica Negotin')," +
                "('Jasenov Del Babušnica')," +
                "('Jasenovik Niš – Pantelej')," +
                "('Jasenovik Novo Brdo')," +
                "('Jasenovo Despotovac')," +
                "('Jasenovo Nova Varoš')," +
                "('Jasenovo Bela Crkva')," +
                "('Jasenje Aleksinac')," +
                "('Jasika Kruševac')," +
                "('Jasikovica Trstenik')," +
                "('Jasikovo Majdanpek')," +
                "('Jasić Dečani')," +
                "('Jastrebac Bujanovac')," +
                "('Jastrebac Vladičin Han')," +
                "('Jastrebac Vlasotince')," +
                "('Jahoc Đakovica')," +
                "('Jaša Tomić Sečanj')," +
                "('Jašunja Leskovac')," +
                "('Jevik Sjenica')," +
                "('Jevremovac Šabac')," +
                "('Ježevica Čačak')," +
                "('Jezgroviće Tutin')," +
                "('Jezdina Čačak')," +
                "('Jezero Despotovac')," +
                "('Jezero Sjenica')," +
                "('Jezero Sokobanja')," +
                "('Jezero Vučitrn')," +
                "('Jezerce Uroševac')," +
                "('Jelav Loznica')," +
                "('Jelakce Leposavić')," +
                "('Jelakci Aleksandrovac')," +
                "('Jelača Priboj')," +
                "('Jelašnica Zaječar')," +
                "('Jelašnica Knjaževac')," +
                "('Jelašnica Leskovac')," +
                "('Jelašnica Surdulica')," +
                "('Jelašnica Niš – Niška Banja')," +
                "('Jelen Do Požega')," +
                "('Jelenac Topola')," +
                "('Jelenča Šabac')," +
                "('Jeliće Tutin')," +
                "('Jelovac Despotovac')," +
                "('Jelovac Klina')," +
                "('Jelovik Aranđelovac')," +
                "('Jelovik Bajina Bašta')," +
                "('Jelovica Pirot')," +
                "('Jerli Prelez Uroševac')," +
                "('Jerli Sadovina Vitina')," +
                "('Jerli Talinovac Uroševac')," +
                "('Jermenovci Plandište')," +
                "('Ješkovo Prizren')," +
                "('Jova Novi Pazar')," +
                "('Jovanovac Kragujevac')," +
                "('Jovanovac Merošina')," +
                "('Jovanovce Crna Trava')," +
                "('Jovanja Valjevo')," +
                "('Jovac Vladičin Han')," +
                "('Jovac Ćuprija')," +
                "('Jovine Livade Prokuplje')," +
                "('Jovićrahovac')," +
                "('Jošanica Žagubica')," +
                "('Jošanica Sokobanja')," +
                "('Jošanica Klina')," +
                "('Jošanica Leposavić')," +
                "('Jošanica Peć')," +
                "('Jošanička Banja Raška')," +
                "('Jošanički Prnjavor Jagodina')," +
                "('Joševa Valjevo')," +
                "('Joševa Loznica')," +
                "('Joševa Ub')," +
                "('Joševik Zvečan')," +
                "('Jošje Kruševac')," +
                "('Jug Bogdanovac Merošina')," +
                "('Jugovac Prokuplje')," +
                "('Jugovići Loznica')," +
                "('Južni Kočarnik Tutin')," +
                "('Junake Zubin Potok')," +
                "('Junik Dečani')," +
                "('Junkovac Beograd – Lazarevac')," +
                "('Junkovac Topola')," +
                "('Junčevići Prijepolje')," +
                "('Kabaš Vitina')," +
                "('Kabaš Prizren')," +
                "('Kabaš Has Prizren')," +
                "('Kavadar Rekovac')," +
                "('Kavilo Bačka Topola')," +
                "('Kadina Luka Ljig')," +
                "('Kaznoviće Raška')," +
                "('Kajkovo Leposavić')," +
                "('Kajtasovo Bela Crkva')," +
                "('Kalabovce Surdulica')," +
                "('Kalanjevci Ljig')," +
                "('Kalafati Priboj')," +
                "('Kalenić Ub')," +
                "('Kalenići Požega')," +
                "('Kalenićki Prnjavor Rekovac')," +
                "('Kalenovac Jagodina')," +
                "('Kaletinacadžin Han')," +
                "('Kalimanićiornji Milanovac')," +
                "('Kalimance Vladičin Han')," +
                "('Kalinovac Ub')," +
                "('Kalipolje Sjenica')," +
                "('Kaličane Istok')," +
                "('Kaličina Knjaževac')," +
                "('Kalište Malo Crniće')," +
                "('Kalna Knjaževac')," +
                "('Kalna Crna Trava')," +
                "('Kalovo Trgovište')," +
                "('Kaludra Prokuplje')," +
                "('Kaludra Rekovac')," +
                "('Kaluđerevo Babušnica')," +
                "('Kaluđerica Beograd –rocka')," +
                "('Kaluđerovići Priboj')," +
                "('Kaluđerovo Bela Crkva')," +
                "('Kaluđerce Leskovac')," +
                "('Kaljatica Podujevo')," +
                "('Kambelevac Babušnica')," +
                "('Kamenalava Uroševac')," +
                "('Kamenaora Prijepolje')," +
                "('Kamenare Kruševac')," +
                "('Kamendol Beograd –rocka')," +
                "('Kamenica Aleksinac')," +
                "('Kamenica Bojnik')," +
                "('Kamenica Valjevo')," +
                "('Kamenicaornji Milanovac')," +
                "('Kamenica Dimitrovgrad')," +
                "('Kamenica Koceljeva')," +
                "('Kamenica Kragujevac')," +
                "('Kamenica Kraljevo')," +
                "('Kamenica Loznica')," +
                "('Kamenica Užice')," +
                "('Kamenica Niš – Pantelej')," +
                "('Kamenica Leposavić')," +
                "('Kamenica Zvečan')," +
                "('Kamenovo Petrova na Mlavi')," +
                "('Kamenjani Kraljevo')," +
                "('Kamenjača Trstenik')," +
                "('Kamešnica Sjenica')," +
                "('Kamijevo Velikoradište')," +
                "('Kamik Pirot')," +
                "('Kandalica Knjaževac')," +
                "('Kanjevina Sjenica')," +
                "('Kanjiža Kanjiža')," +
                "('Kaona Vladimirci')," +
                "('Kaona Kučevo')," +
                "('Kaona Lučani')," +
                "('Kaonik Kruševac')," +
                "('Kapit Medveđa')," +
                "('Kapidžija Kruševac')," +
                "('Kapra Prizren')," +
                "('Karavukovodžaci')," +
                "('Karadak Raška')," +
                "('Karadnik Bujanovac')," +
                "('Karađorđevac Leskovac')," +
                "('Karađorđevo Bačka Palanka')," +
                "('Karađorđevo Bačka Topola')," +
                "('Karajukića Bunari Sjenica')," +
                "('Karamanica Bosilegrad')," +
                "('Karan Užice')," +
                "('Karanovac Varvarin')," +
                "('Karaula Prijepolje')," +
                "('Karače Vučitrn')," +
                "('Karačica Štimlje')," +
                "('Karašinđerđ Prizren')," +
                "('Karbulovo Negotin')," +
                "('Kare Žitorađa')," +
                "('Karlovčić Pećinci')," +
                "('Karoševina Prijepolje')," +
                "('Kasidol Požarevac')," +
                "('Kasidoli Priboj')," +
                "('Kastrat Kuršumlija')," +
                "('Katići Ivanjica')," +
                "('Katrga Čačak')," +
                "('Katun Aleksinac')," +
                "('Katun Vranje')," +
                "('Kać Novi Sad')," +
                "('Kaćevo Prijepolje')," +
                "('Kacabać Bojnik')," +
                "('Kacapun Vladičin Han')," +
                "('Kačandol Kosovska Mitrovica')," +
                "('Kačanik Kačanik')," +
                "('Kačapor Blace')," +
                "('Kačarevo Pančevo')," +
                "('Kačer Užice')," +
                "('Kačibeg Podujevo')," +
                "('Kačikol Priština')," +
                "('Kačulice Čačak')," +
                "('Kašalj Novi Pazar')," +
                "('Kaševar Blace')," +
                "('Kašica Istok')," +
                "('Kašice Prijepolje')," +
                "('Kaštavar Leskovac')," +
                "('Kevi Senta')," +
                "('Kelebija Subotica')," +
                "('Keserovina Užice')," +
                "('Kijevac Babušnica')," +
                "('Kijevac Surdulica')," +
                "('Kijevo Batočina')," +
                "('Kijevo Klina')," +
                "('Kijevce Zubin Potok')," +
                "('Kijevci Sjenica')," +
                "('Kijevčiće Leposavić')," +
                "('Kikinda Kikinda')," +
                "('Kikojevac Knić')," +
                "('Kisač Novi Sad')," +
                "('Kisela Banja Podujevo')," +
                "('Kisiljevo Velikoradište')," +
                "('Kišna Rekalogovac')," +
                "('Kišno Poljenjilane')," +
                "('Kladernica Srbica')," +
                "('Kladnica Sjenica')," +
                "('Kladovo Kladovo')," +
                "('Kladurovo Petrova na Mlavi')," +
                "('Kladušnica Kladovo')," +
                "('Klajić Lebane')," +
                "('Klanica Valjevo')," +
                "('Klatičevoornji Milanovac')," +
                "('Klačevica Paraćin')," +
                "('Klašnić Mionica')," +
                "('Klašnjice Vranje')," +
                "('Klek Zrenjanin')," +
                "('Klekova Ivanjica')," +
                "('Klenak Ruma')," +
                "('Klenike Bujanovac')," +
                "('Klenovac Zaječar')," +
                "('Klenovnik Kostolac')," +
                "('Klenje Bela Palanka')," +
                "('Klenje Bogatić')," +
                "('Klenjeolubac')," +
                "('Klečka Lipljan')," +
                "('Klečke Zubin Potok')," +
                "('Klina Klina')," +
                "('Klinavac Klina')," +
                "('Klinovac Bujanovac')," +
                "('Klinci Valjevo')," +
                "('Klinčina Peć')," +
                "('Klisura Bela Palanka')," +
                "('Klisura Doljevac')," +
                "('Klisura Surdulica')," +
                "('Klisurica Prokuplje')," +
                "('Klisurica Vranjska Banja')," +
                "('Kličevac Požarevac')," +
                "('Klobukar Novo Brdo')," +
                "('Kloka Topola')," +
                "('Klokot Vitina')," +
                "('Klokočevac Majdanpek')," +
                "('Klupci Loznica')," +
                "('Kljajićevo Sombor')," +
                "('Ključ Mionica')," +
                "('Kmetovcenjilane')," +
                "('Kneževac Knić')," +
                "('Kneževac Sjenica')," +
                "('Kneževo Brus')," +
                "('Knežica Doljevac')," +
                "('Knežica Petrova na Mlavi')," +
                "('Knez Selo Niš – Pantelej')," +
                "('Knić Knić')," +
                "('Knićanin Zrenjanin')," +
                "('Knjaževac Knjaževac')," +
                "('Kobanja Prizren')," +
                "('Kobiljalava Zubin Potok')," +
                "('Kobilje Brus')," +
                "('Kobilje Kruševac')," +
                "('Kobilje Malo Crniće')," +
                "('Kobišnica Negotin')," +
                "('Kovanica Ćuprija')," +
                "('Kovanluk Kraljevo')," +
                "('Kovanluk Merošina')," +
                "('Kovače Zubin Potok')," +
                "('Kovačeva Bara Leskovac')," +
                "('Kovačevac Beograd – Mladenovac')," +
                "('Kovačevac Prijepolje')," +
                "('Kovačevac Jagodina')," +
                "('Kovačevac Kačanik')," +
                "('Kovačevo Novi Pazar')," +
                "('Kovači Kraljevo')," +
                "('Kovači Raška')," +
                "('Kovači Tutin')," +
                "('Kovačica Kovačica')," +
                "('Kovačica Kosovska Mitrovica')," +
                "('Kovačice Valjevo')," +
                "('Kovizle Brus')," +
                "('Kovilovo Beograd – Palilula')," +
                "('Kovilovo Negotin')," +
                "('Kovilj Novi Sad')," +
                "('Kovilje Ivanjica')," +
                "('Kovin Kovin')," +
                "('Kovioci Brus')," +
                "('Kovrage Istok')," +
                "('Kodralija Dečani')," +
                "('Kodralija Đakovica')," +
                "('Koželj Knjaževac')," +
                "('Kožetin Aleksandrovac')," +
                "('Kožince Prokuplje')," +
                "('Kožica Srbica')," +
                "('Kožlje Novi Pazar')," +
                "('Kožuar Ub')," +
                "('Kozare Leskovac')," +
                "('Kozarevo Zubin Potok')," +
                "('Kozarica Vladimirci')," +
                "('Kozelj Ljig')," +
                "('Kozilo Vlasotince')," +
                "('Kozja Bela Palanka')," +
                "('Kozjak Loznica')," +
                "('Kozličić Valjevo')," +
                "('Koznik Sjenica')," +
                "('Koznikrahovac')," +
                "('Koznica Aleksandrovac')," +
                "('Koznica Vladičin Han')," +
                "('Kojlovica Priština')," +
                "('Kojuš Prizren')," +
                "('Kokošiće Sjenica')," +
                "('Kolare Jagodina')," +
                "('Kolari Smederevo')," +
                "('Kolić Priština')," +
                "('Kolo Vučitrn')," +
                "('Kololeč Kosovska Kamenica')," +
                "('Kolunica Surdulica')," +
                "('Kolut Sombor')," +
                "('Komadine Ivanjica')," +
                "('Komanice Mionica')," +
                "('Komarane Rekovac')," +
                "('Komarani Nova Varoš')," +
                "('Komarica Vlasotince')," +
                "('Komirićsečina')," +
                "('Komorane Kruševac')," +
                "('Komoranelogovac')," +
                "('Konak Sečanj')," +
                "('Konarevo Kraljevo')," +
                "('Konatice Beograd –brenovac')," +
                "('Koniče Tutin')," +
                "('Konopnica Vlasotince')," +
                "('Končarevo Jagodina')," +
                "('Končić Prokuplje')," +
                "('Končulj Bujanovac')," +
                "('Kondželj Prokuplje')," +
                "('Konjarnik Žitorađa')," +
                "('Konjevići Čačak')," +
                "('Konjino Lebane')," +
                "('Konjicsečina')," +
                "('Konjska Reka Bajina Bašta')," +
                "('Konjsko Lipljan')," +
                "('Konjuva Kuršumlija')," +
                "('Konjuh Kruševac')," +
                "('Konjuh Lipljan')," +
                "('Konjuša Knić')," +
                "('Konjušasečina')," +
                "('Konjuševac Podujevo')," +
                "('Kopajkošara Svrljig')," +
                "('Kopanjane Vranje')," +
                "('Kopaonik Raška')," +
                "('Kopiloviće Zubin Potok')," +
                "('Kopitarce Vladičin Han')," +
                "('Kopljare Aranđelovac')," +
                "('Koporiće Leposavić')," +
                "('Kopriva Kosovska Mitrovica')," +
                "('Koprivna Prijepolje')," +
                "('Koprivnica Aleksinac')," +
                "('Koprivnicaadžin Han')," +
                "('Koprivnica Zaječar')," +
                "('Koprivnica Novi Pazar')," +
                "('Koprivnica Kosovska Kamenica')," +
                "('Koprivštica Pirot')," +
                "('Koraćevac Leskovac')," +
                "('Koraćica Beograd – Mladenovac')," +
                "('Korbevac Vranjska Banja')," +
                "('Korbovo Kladovo')," +
                "('Korbul Vranjska Banja')," +
                "('Korbulić Kačanik')," +
                "('Korenita Loznica')," +
                "('Korenica Đakovica')," +
                "('Koretin Kosovska Kamenica')," +
                "('Koretištenjilane')," +
                "('Korilje Zvečan')," +
                "('Koritnik Ivanjica')," +
                "('Koritnjak Niš – Niška Banja')," +
                "('Koriša Prizren')," +
                "('Korlaće Raška')," +
                "('Korman Aleksinac')," +
                "('Korman Kragujevac')," +
                "('Korman Šabac')," +
                "('Kosančić Bojnik')," +
                "('Kosančić Vrbas')," +
                "('Kosatica Prijepolje')," +
                "('Kosin Uroševac')," +
                "('Kosjerić (varoš) Kosjerić')," +
                "('Kosjerić (selo) Kosjerić')," +
                "('Kosmača Kuršumlija')," +
                "('Kosmovac Bela Palanka')," +
                "('Kosovica Ivanjica')," +
                "('Kosovo Polje Kosovo Polje')," +
                "('Kosovska Kamenica Kosovska Kamenica')," +
                "('Kosovska Mitrovica Kosovska Mitrovica')," +
                "('Kosovce Prizren')," +
                "('Kostadinovac Merošina')," +
                "('Kostadince Kosovska Kamenica')," +
                "('Kostajnik Krupanj')," +
                "('Kostenica Prokuplje')," +
                "('Kostin Potok Leposavić')," +
                "('Kostojevići Bajina Bašta')," +
                "('Kostol Kladovo')," +
                "('Kostolac Kostolac')," +
                "('Kostomlatica Vladičin Han')," +
                "('Kostroševci Surdulica')," +
                "('Kostrc Srbica')," +
                "('Kostrce Suva Reka')," +
                "('Kostur Pirot')," +
                "('Kosurić Peć')," +
                "('Kosuriće Novi Pazar')," +
                "('Kotešica Valjevo')," +
                "('Kotlina Kačanik')," +
                "('Kotore Srbica')," +
                "('Kotradić Peć')," +
                "('Kotraža Kragujevac')," +
                "('Kotraža Lučani')," +
                "('Kotroman Užice')," +
                "('Koćura Vranje')," +
                "('Koceljeva Koceljeva')," +
                "('Kočane Doljevac')," +
                "('Kočetin Žabari')," +
                "('Kočine Brus')," +
                "('Kočino Selo Jagodina')," +
                "('Koš Istok')," +
                "('Košare Đakovica')," +
                "('Košare Uroševac')," +
                "('Košarno Bujanovac')," +
                "('Koševi Kruševac')," +
                "('Koševine Prijepolje')," +
                "('Koštanjevo Štrpce')," +
                "('Koštunićiornji Milanovac')," +
                "('Košutane Peć')," +
                "('Košutica Leposavić')," +
                "('Košutovo Leposavić')," +
                "('Košutovo Kosovska Mitrovica')," +
                "('Kpuz Klina')," +
                "('Kravaricanjilane')," +
                "('Kraviće Raška')," +
                "('Kravlje Niš – Crveni krst')," +
                "('Kravlji Do Malo Crniće')," +
                "('Kravoserija Suva Reka')");
                  migrationBuilder.Sql(
                "insert into Mesta(NazivMesta) values " +
                "('Kragujevac Kragujevac')," +
                "('Krajinoviće Sjenica')," +
                "('Krajišnik Sečanj')," +
                "('Krajišnici Loznica')," +
                "('Krajište Lipljan')," +
                "('Krajk Prizren')," +
                "('Krajkovac Merošina')," +
                "('Krajkovologovac')," +
                "('Krajmirovce Lipljan')," +
                "('Krajnidel Kosovska Kamenica')," +
                "('Kraljane Đakovica')," +
                "('Kraljevo Aleksinac')," +
                "('Kraljevo Kraljevo')," +
                "('Kraljevci Ruma')," +
                "('Kramovikrahovac')," +
                "('Krasava Krupanj')," +
                "('Krasalić Srbica')," +
                "('Krasmirovac Srbica')," +
                "('Krastavčeadžin Han')," +
                "('Kratovo Priboj')," +
                "('Krvavica Kruševac')," +
                "('Krvavci Užice')," +
                "('Krvije Petrova na Mlavi')," +
                "('Krežbinac Paraćin')," +
                "('Kremenata Kosovska Kamenica')," +
                "('Kremenica Bela Palanka')," +
                "('Kremiće Raška')," +
                "('Kremna Užice')," +
                "('Krenta Knjaževac')," +
                "('Krepoljin Žagubica')," +
                "('Kržava Krupanj')," +
                "('Kržince Vladičin Han')," +
                "('Kriva Reka Brus')," +
                "('Kriva Rekaornji Milanovac')," +
                "('Kriva Reka Čajetina')," +
                "('Kriva Feja Vranjska Banja')," +
                "('Krivaja Blace')," +
                "('Krivaja Sjenica')," +
                "('Krivaja Šabac')," +
                "('Krivaja Bačka Topola')," +
                "('Krivačaolubac')," +
                "('Krivača Lebane')," +
                "('Krivača Lučani')," +
                "('Krivelj Bor')," +
                "('Krivenik Kačanik')," +
                "('Krivi Vir Boljevac')," +
                "('Krivi Del Crna Trava')," +
                "('Kriljevo Kosovska Kamenica')," +
                "('Krligate Zubin Potok')," +
                "('Krnić Vladimirci')," +
                "('Krnule Vladimirci')," +
                "('Krnja Jela Sjenica')," +
                "('Krnjača Priboj')," +
                "('Krnjevo Velika Plana')," +
                "('Krnješevci Stara Pazova')," +
                "('Krnjirad Prokuplje')," +
                "('Krnjina Istok')," +
                "('Krnjince Klina')," +
                "('Krpejce Leskovac')," +
                "('Krpimej Podujevo')," +
                "('Krstac Lučani')," +
                "('Krstac Sjenica')," +
                "('Krstićevo Crna Trava')," +
                "('Krstovac Peć')," +
                "('Krtinska Beograd –brenovac')," +
                "('Krtok Kuršumlija')," +
                "('Krće Sjenica')," +
                "('Krćevac Topola')," +
                "('Krupaja Žagubica')," +
                "('Krupanj Krupanj')," +
                "('Krupac Bela Palanka')," +
                "('Krupac Pirot')," +
                "('Krušar Ćuprija')," +
                "('Kruševalava Vranje')," +
                "('Kruševac Kruševac')," +
                "('Kruševacbilić')," +
                "('Kruševac Peć')," +
                "('Kruševac Srbica')," +
                "('Kruševica Beograd – Lazarevac')," +
                "('Kruševica Vlasotince')," +
                "('Kruševica Prokuplje')," +
                "('Kruševica Raška')," +
                "('Kruševica Podujevo')," +
                "('Kruševo Novi Pazar')," +
                "('Kruševo Prijepolje')," +
                "('Kruševo Leposavić')," +
                "('Kruševoora')," +
                "('Krušedol Prnjavor Irig')," +
                "('Krušedol Selo Irig')," +
                "('Krušje Aleksinac')," +
                "('Krušce Niš – Palilula')," +
                "('Kruščić Kula')," +
                "('Kruščica Arilje')," +
                "('Kruščica Bela Crkva')," +
                "('Kruščica Leposavić')," +
                "('Krčedin Inđija')," +
                "('Krčmar Mionica')," +
                "('Krčmare Kuršumlija')," +
                "('Kršanje Užice')," +
                "('Krševica Bujanovac')," +
                "('Kršnalava Ub')," +
                "('Kudrešolubac')," +
                "('Kuzmin Sremska Mitrovica')," +
                "('Kuzmin Kosovo Polje')," +
                "('Kuzmičevo Novi Pazar')," +
                "('Kujavica Vladimirci')," +
                "('Kukavica Vladičin Han')," +
                "('Kukavica Vlasotince')," +
                "('Kukavica Priština')," +
                "('Kukići Čačak')," +
                "('Kuklibeg Prizren')," +
                "('Kukljin Kruševac')," +
                "('Kukovce Prizren')," +
                "('Kukujevci Šid')," +
                "('Kukulovce Leskovac')," +
                "('Kukuljaneora')," +
                "('Kukurovići Priboj')," +
                "('Kula Malo Crniće')," +
                "('Kula Kula')," +
                "('Kula Zvečan')," +
                "('Kulina Aleksinac')," +
                "('Kulinovci Čačak')," +
                "('Kulič Smederevo')," +
                "('Kulpin Bački Petrovac')," +
                "('Kumane Velikoradište')," +
                "('Kumane Novi Bečej')," +
                "('Kumanica Ivanjica')," +
                "('Kumanovo Pirot')," +
                "('Kumarevo Leskovac')," +
                "('Kumarevo Vranjska Banja')," +
                "('Kunice Valjevo')," +
                "('Kunovik Vučitrn')," +
                "('Kunovica Niš – Niška Banja')," +
                "('Kunovo Vladičin Han')," +
                "('Kupinik Plandište')," +
                "('Kupinince Vranje')," +
                "('Kupinovac Svilajnac')," +
                "('Kupinovo Kuršumlija')," +
                "('Kupinovo Pećinci')," +
                "('Kupuzište Kladovo')," +
                "('Kupusina Velika Plana')," +
                "('Kupusina Apatin')," +
                "('Kurbalija Preševo')," +
                "('Kurilovo Vučitrn')," +
                "('Kurići Raška')," +
                "('Kurjače Velikoradište')," +
                "('Kuršumlija Kuršumlija')," +
                "('Kuršumlijska Banja Kuršumlija')," +
                "('Kusa Vrana Dimitrovgrad')," +
                "('Kusadak Smederevska Palanka')," +
                "('Kusar Đakovica')," +
                "('Kusić Bela Crkva')," +
                "('Kusiće Velikoradište')," +
                "('Kusovac Knić')," +
                "('Kutleš Leskovac')," +
                "('Kutlovac Blace')," +
                "('Kutlovac Kosovska Mitrovica')," +
                "('Kutlovo Kragujevac')," +
                "('Kutlovo Kuršumlija')," +
                "('Kutnje Leposavić')," +
                "('Kućane Raška')," +
                "('Kućani Nova Varoš')," +
                "('Kućica Srbica')," +
                "('Kućište Peć')," +
                "('Kucura Vrbas')," +
                "('Kučajna Kučevo')," +
                "('Kučevo Kučevo')," +
                "('Kučin Prijepolje')," +
                "('Kuševac Đakovica')," +
                "('Kušiljevo Svilajnac')," +
                "('Kušići Ivanjica')," +
                "('Kušnin Prizren')," +
                "('Kuštendil Prizren')," +
                "('Kuštilj Vršac')," +
                "('Kuštica Bujanovac')," +
                "('Labljane Novo Brdo')," +
                "('Labljane Peć')," +
                "('Labukovo Svrljig')," +
                "('Labučevorahovac')," +
                "('Ladovac Podujevo')," +
                "('Ladovica Vlasotince')," +
                "('Ladrovac Suva Reka')," +
                "('Ladrović Suva Reka')," +
                "('Lađevci Kraljevo')," +
                "('Laz Belopać Peć')," +
                "('Lazarevac Beograd – Lazarevac')," +
                "('Lazarevac Blace')," +
                "('Lazarevac Kruševac')," +
                "('Lazarevo Zrenjanin')," +
                "('Lazarevobilić')," +
                "('Lazarevo Selo Niš – Niška Banja')," +
                "('Lazarica Kruševac')," +
                "('Lazac Kraljevo')," +
                "('Lazine Leposavić')," +
                "('Laznica Žagubica')," +
                "('Lajkovac (varoš) Lajkovac')," +
                "('Lajkovac (selo) Lajkovac')," +
                "('Laletić Lipljan')," +
                "('Lalinac Svrljig')," +
                "('Lalinac Niš – Palilula')," +
                "('Lalinovac Lebane')," +
                "('Lalince Vranje')," +
                "('Lalinci Ljig')," +
                "('Lalićdžaci')," +
                "('Landovica Prizren')," +
                "('Landol Smederevo')," +
                "('Lanište Bela Palanka')," +
                "('Lanište Kačanik')," +
                "('Lanište Štimlje')," +
                "('Laplje Selo Priština')," +
                "('Lapovo (varošica) Lapovo')," +
                "('Lapovo (selo) Lapovo')," +
                "('Lapotince Bojnik')," +
                "('Lapušniklogovac')," +
                "('Lasovo Zaječar')," +
                "('Latvica Arilje')," +
                "('Latkovac Aleksandrovac')," +
                "('Latković Ljig')," +
                "('Laćarak Sremska Mitrovica')," +
                "('Laćisled Aleksandrovac')," +
                "('Laudonovac Plandište')," +
                "('Lauša Podujevo')," +
                "('Lauša Srbica')," +
                "('Laškobare Uroševac')," +
                "('Lebane Lebane')," +
                "('Lebane Priština')," +
                "('Lebet Vladičin Han')," +
                "('Lebina Paraćin')," +
                "('Leva Reka Vranjska Banja')," +
                "('Levići Trstenik')," +
                "('Levovik Sokobanja')," +
                "('Levosoje Bujanovac')," +
                "('Ledenik Zubin Potok')," +
                "('Ledinci Petrovaradin')," +
                "('Ležimir Sremska Mitrovica')," +
                "('Lez Prizren')," +
                "('Lelić Valjevo')," +
                "('Lelići Užice')," +
                "('Lenovac Zaječar')," +
                "('Leović Ljubovija')," +
                "('Leočina Srbica')," +
                "('Lepaja Merošina')," +
                "('Lepena Knjaževac')," +
                "('Lepenac Brus')," +
                "('Lepenica Vladičin Han')," +
                "('Lepina Lipljan')," +
                "('Lepojević Rekovac')," +
                "('Leposavić Leposavić')," +
                "('Lepčince Vranje')," +
                "('Lesenovci Aleksandrovac')," +
                "('Leskova Tutin')," +
                "('Leskova Bara Surdulica')," +
                "('Leskovac Beograd – Lazarevac')," +
                "('Leskovac Zaječar')," +
                "('Leskovac Knić')," +
                "('Leskovac Leskovac')," +
                "('Leskovac Petrova na Mlavi')," +
                "('Leskovac Klina')," +
                "('Leskovac Prizren')," +
                "('Leskovik Bela Palanka')," +
                "('Leskovik Niš – Crveni krst')," +
                "('Leskovica Aleksandrovac')," +
                "('Leskovica Babušnica')," +
                "('Leskovo Majdanpek')," +
                "('Leskovčićbilić')," +
                "('Lesnica Trgovište')," +
                "('Letance Podujevo')," +
                "('Letnica Vitina')," +
                "('Letovica Bujanovac')," +
                "('Letovište Vladičin Han')," +
                "('Leušićiornji Milanovac')," +
                "('Lece Medveđa')," +
                "('Leča Novi Pazar')," +
                "('Lešak Leposavić')," +
                "('Lešane Suva Reka')," +
                "('Leševo Kraljevo')," +
                "('Lešje Paraćin')," +
                "('Lešnica Loznica')," +
                "('Leštane Beograd –rocka')," +
                "('Leštaneora')," +
                "('Livadica Podujevo')," +
                "('Livađe Brus')," +
                "('Livađe Lipljan')," +
                "('Lijeva Reka Sjenica')," +
                "('Likovac Srbica')," +
                "('Likodra Krupanj')," +
                "('Likošanelogovac')," +
                "('Linovo Babušnica')," +
                "('Lipa Peć')," +
                "('Lipa Zvečan')," +
                "('Lipar Kula')," +
                "('Lipe Žagubica')," +
                "('Lipe Smederevo')," +
                "('Lipenović Krupanj')," +
                "('Lipica Tutin')," +
                "('Lipljan Lipljan')," +
                "('Liplje Ljig')," +
                "('Lipnica Knić')," +
                "('Lipnica Loznica')," +
                "('Lipnica Čačak')," +
                "('Lipnički Šor Loznica')," +
                "('Lipova Vrnjačka Banja')," +
                "('Lipovac Aleksinac')," +
                "('Lipovacornji Milanovac')," +
                "('Lipovac Kruševac')," +
                "('Lipovac Ražanj')," +
                "('Lipovac Topola')," +
                "('Lipovac Vranjska Banja')," +
                "('Lipovac Đakovica')," +
                "('Lipovica Vlasotince')," +
                "('Lipovica Despotovac')," +
                "('Lipovica Lebane')," +
                "('Lipovica Leskovac')," +
                "('Lipovicanjilane')," +
                "('Lipovica Lipljan')," +
                "('Lipovica Zvečan')," +
                "('Lipolist Šabac')," +
                "('Lis Lučani')," +
                "('Lisa Ivanjica')," +
                "('Lisina Raška')," +
                "('Lisica Kosovska Mitrovica')," +
                "('Lisice Lučani')," +
                "('Liso Polje Ub')," +
                "('Lisović Beograd – Barajevo')," +
                "('Lisocka Kosovska Kamenica')," +
                "('Ličin Dol Leskovac')," +
                "('Ličjeadžin Han')," +
                "('Loboder Trstenik')," +
                "('Lovac Zvečan')," +
                "('Lovćenac Mali Iđoš')," +
                "('Lovcenjilane')," +
                "('Lovci Kruševac')," +
                "('Lovci Jagodina')," +
                "('Lođa Peć')," +
                "('Ložane Peć')," +
                "('Lozan Svrljig')," +
                "('Lozane Bojnik')," +
                "('Lozanjornji Milanovac')," +
                "('Lozica Klina')," +
                "('Lozište Zvečan')," +
                "('Lozna Trstenik')," +
                "('Loznac Aleksinac')," +
                "('Loznica Valjevo')," +
                "('Loznica Loznica')," +
                "('Loznica Čačak')," +
                "('Lozničko Polje Loznica')," +
                "('Lozno Kraljevo')," +
                "('Lozno Leposavić')," +
                "('Lozovik Velika Plana')," +
                "('Lozovik Jagodina')," +
                "('Lojanice Vladimirci')," +
                "('Lok Titel')," +
                "('Lokva Knjaževac')," +
                "('Lokva Zvečan')," +
                "('Lokve Alibunar')," +
                "('Lokvica Prizren')," +
                "('Lomnica Despotovac')," +
                "('Lomnica Rekovac')," +
                "('Lončanik Ub')," +
                "('Lonjin Ljubovija')," +
                "('Lopardince Bujanovac')," +
                "('Lopatanjsečina')," +
                "('Lopatnica Kraljevo')," +
                "('Lopaš Požega')," +
                "('Lopaš Trstenik')," +
                "('Lopužnje Novi Pazar')," +
                "('Lopušnik Petrova na Mlavi')," +
                "('Loret Požega')," +
                "('Loćane Dečani')," +
                "('Loćika Aleksinac')," +
                "('Loćika Rekovac')," +
                "('Ločevciornji Milanovac')," +
                "('Lubnica Zaječar')," +
                "('Lug Bajina Bašta')," +
                "('Lug Beočin')," +
                "('Lug Lipljan')," +
                "('Lug Podujevo')," +
                "('Lug Dubnica Vučitrn')," +
                "('Lugavčina Smederevo')," +
                "('Lugađija Đakovica')," +
                "('Lugađija Peć')," +
                "('Lugare Lebane')," +
                "('Lugadžija Lipljan')," +
                "('Lugovo Istok')," +
                "('Lužane Aleksinac')," +
                "('Lužane Podujevo')," +
                "('Lužnica Suva Reka')," +
                "('Lužnice Kragujevac')," +
                "('Luka Bor')," +
                "('Lukavac Valjevo')," +
                "('Lukavac Kruševac')," +
                "('Lukavica Beograd – Lazarevac')," +
                "('Lukavica Dimitrovgrad')," +
                "('Lukavica Tutin')," +
                "('Lukar Jagodina')," +
                "('Lukare Novi Pazar')," +
                "('Lukare Priština')," +
                "('Lukarskooševo Novi Pazar')," +
                "('Lukarce Bujanovac')," +
                "('Luke Ivanjica')," +
                "('Lukino Selo Zrenjanin')," +
                "('Lukićevo Zrenjanin')," +
                "('Lukovica Svilajnac')," +
                "('Lukovo Boljevac')," +
                "('Lukovo Vranje')," +
                "('Lukovo Kuršumlija')," +
                "('Lukovo Raška')," +
                "('Lukovo Svrljig')," +
                "('Lukomir Žitorađa')," +
                "('Lukocrevo Novi Pazar')," +
                "('Lunjevac Smederevo')," +
                "('Lunjevicaornji Milanovac')," +
                "('Lučane Bujanovac')," +
                "('Lučani (varošica) Lučani')," +
                "('Lučani (selo) Lučani')," +
                "('Lučina Ćićevac')," +
                "('Lučica Požarevac')," +
                "('Lučice Prijepolje')," +
                "('Lučka Reka Zubin Potok')," +
                "('Ljajčić Kosovska Kamenica')," +
                "('Ljanik Preševo')," +
                "('Ljevajaornji Milanovac')," +
                "('Ljevoša Peć')," +
                "('Ljepojevići Nova Varoš')," +
                "('Lješane Peć')," +
                "('Lješnica Kučevo')," +
                "('Lještansko Bajina Bašta')," +
                "('Lještar Kosovska Kamenica')," +
                "('Ljig Ljig')," +
                "('Ljiljance Bujanovac')," +
                "('Ljuba Šid')," +
                "('Ljubava Kruševac')," +
                "('Ljubanje Užice')," +
                "('Ljubatovica Bela Palanka')," +
                "('Ljubenić Peć')," +
                "('Ljuberađa Babušnica')," +
                "('Ljubiždarahovac')," +
                "('Ljubižda Prizren')," +
                "('Ljubižda Has Prizren')," +
                "('Ljubinić Beograd –brenovac')," +
                "('Ljubinci Aleksandrovac')," +
                "('Ljubinje Velikoradište')," +
                "('Ljubić Knić')," +
                "('Ljubić Čačak')," +
                "('Ljubičevac Kladovo')," +
                "('Ljubičevac Kragujevac')," +
                "('Ljubičevo Prizren')," +
                "('Ljubiš Čajetina')," +
                "('Ljubište Vitina')," +
                "('Ljubovac Srbica')," +
                "('Ljubovija Ljubovija')," +
                "('Ljubovišteora')," +
                "('Ljubovo Istok')," +
                "('Ljubožda Istok')," +
                "('Ljubuša Dečani')," +
                "('Ljugbunar Đakovica')," +
                "('Ljukinaj Prizren')," +
                "('Ljukovo Inđija')," +
                "('Ljuljaci Knić')," +
                "('Ljumbarda Dečani')," +
                "('Ljupten Aleksinac')," +
                "('Ljutaje Sjenica')," +
                "('Ljutež Vladičin Han')," +
                "('Ljutice Koceljeva')," +
                "('Ljutice Požega')," +
                "('Ljutova Kuršumlija')," +
                "('Ljutovnicaornji Milanovac')," +
                "('Ljutovo Subotica')," +
                "('Ljutoglav Prizren')," +
                "('Ljutoglava Peć')," +
                "('Ljuša Kuršumlija')," +
                "('Ljušta Kosovska Mitrovica')," +
                "('Mavrić Vučitrn')," +
                "('Magaš Bojnik')," +
                "('Maglić Bački Petrovac')," +
                "('Maglič Kraljevo')," +
                "('Magovo Kuršumlija')," +
                "('Magura Lipljan')," +
                "('Mađare Preševo')," +
                "('Mađarerahovac')," +
                "('Mađare Kosovska Mitrovica')," +
                "('Mađer Požega')," +
                "('Mađere Prokuplje')," +
                "('Mađere Ražanj')," +
                "('Mažić Kosovska Mitrovica')," +
                "('Mažići Priboj')," +
                "('Mazap Podujevo')," +
                "('Mazarać Vladičin Han')," +
                "('Mazgitbilić')," +
                "('Mazgoš Dimitrovgrad')," +
                "('Maznik Dečani')," +
                "('Mazrek Prizren')," +
                "('Majance Podujevo')," +
                "('Majdanornji Milanovac')," +
                "('Majdan Novi Kneževac')," +
                "('Majdanpek Majdanpek')," +
                "('Majdevo Kruševac')," +
                "('Majdevo Leposavić')," +
                "('Majilovac Velikoradište')," +
                "('Majinović Valjevo')," +
                "('Majkovac Bojnik')," +
                "('Majur Jagodina')," +
                "('Majur Šabac')," +
                "('Makvište Despotovac')," +
                "('Makovac Priština')," +
                "('Makovište Kosjerić')," +
                "('Makrešane Kruševac')," +
                "('Makrmalj Srbica')," +
                "('Makce Velikoradište')," +
                "('Mala Biljanica Leskovac')," +
                "('Mala Bosna Subotica')," +
                "('Mala Braina Medveđa')," +
                "('Mala Bresnica Kučevo')," +
                "('Mala Vranjska Šabac')," +
                "('Mala Vrbica Beograd – Mladenovac')," +
                "('Mala Vrbica Kladovo')," +
                "('Mala Vrbica Kragujevac')," +
                "('Mala Vrbnica Brus')," +
                "('Mala Vrbnica Kruševac')," +
                "('Malarabovnica Brus')," +
                "('Malarabovnica Leskovac')," +
                "('Mala Dobranja Lipljan')," +
                "('Mala Draguša Blace')," +
                "('Mala Drenova Trstenik')," +
                "('Mala Ivanča Beograd – Sopot')," +
                "('Mala Jablanica Peć')," +
                "('Mala Jasikova Zaječar')," +
                "('Mala Ježevica Požega')," +
                "('Mala Kaludra Zubin Potok')," +
                "('Mala Kamenica Negotin')," +
                "('Mala Kopašnica Leskovac')," +
                "('Mala Kosanica Kuršumlija')," +
                "('Mala Krsna Smederevo')," +
                "('Mala Kruša Prizren')," +
                "('Mala Kruševica Varvarin')," +
                "('Mala Moštanica Beograd –brenovac')," +
                "('Mala Plana Prokuplje')," +
                "('Mala Plana Smederevska Palanka')," +
                "('Mala Reka Bajina Bašta')," +
                "('Mala Reka Kruševac')," +
                "('Mala Reka Trgovište')," +
                "('Mala Remeta Irig')," +
                "('Mala Slatina Kosovo Polje')," +
                "('Mala Sugubina Trstenik')," +
                "('Mala Hočarahovac')," +
                "('Malajnica Negotin')," +
                "('Male Pijace Kanjiža')," +
                "('Maletina Ražanj')," +
                "('Maleševoolubac')," +
                "('Maleševo Rekovac')," +
                "('Mali Alaš Lipljan')," +
                "('Mali Belaćevac Kosovo Polje')," +
                "('Mali Beograd Bačka Topola')," +
                "('Mali Borak Lajkovac')," +
                "('Mali Bošnjak Koceljeva')," +
                "('Mali Vranovac Dečani')," +
                "('Mali Vrtopadžin Han')," +
                "('Maliodennjilane')," +
                "('Mali Drenovac Aleksinac')," +
                "('Mali Đurđevik Klina')," +
                "('Mali Žam Vršac')," +
                "('Mali Zvečan Zvečan')," +
                "('Mali Zvornik Mali Zvornik')," +
                "('Mali Iđoš Mali Iđoš')," +
                "('Mali Izvor Boljevac')," +
                "('Mali Izvor Zaječar')," +
                "('Mali Jasenovac Zaječar')," +
                "('Mali Jovanovac Pirot')," +
                "('Mali Krčimiradžin Han')," +
                "('Mali Kupci Kruševac')," +
                "('Mali Miraševac Rača')," +
                "('Mali Pesak Kanjiža')," +
                "('Mali Požarevac Beograd – Sopot')," +
                "('Mali Popović Jagodina')," +
                "('Mali Radinci Ruma')," +
                "('Mali Suvodol Pirot')," +
                "('Mali Trnovac Bujanovac')," +
                "('Mali Crljeni Beograd – Lazarevac')," +
                "('Mali Šenj Kragujevac')," +
                "('Mali Šiljegovac Kruševac')," +
                "('Mali Štupelj Peć')," +
                "('Mališevonjilane')," +
                "('Mališevorahovac')," +
                "('Malo Bavanište Kovin')," +
                "('Malo Bonjince Babušnica')," +
                "('Malo Vojlovce Lebane')," +
                "('Maloolovode Kruševac')," +
                "('Maloradište Malo Crniće')," +
                "('Maloracko Lipljan')," +
                "('Malo Dubovo Istok')," +
                "('Malo Kičiće Kosovska Mitrovica')," +
                "('Malo Kruševo Klina')," +
                "('Malo Krušince Kruševac')," +
                "('Malo Krčmare Rača')," +
                "('Malo Laole Petrova na Mlavi')," +
                "('Malorašje Smederevo')," +
                "('Malo Ribare Lipljan')," +
                "('Malo Ropotovo Kosovska Kamenica')," +
                "('Malo Rudare Zvečan')," +
                "('Malo Središte Vršac')," +
                "('Malo Crniće Malo Crniće')," +
                "('Malopoljce Štimlje')," +
                "('Malošište Doljevac')," +
                "('Malča Niš – Pantelej')," +
                "('Maljević Mionica')," +
                "('Maljeviće Peć')," +
                "('Maljurevac Požarevac')," +
                "('Mamuša Prizren')," +
                "('Mana Ivanjica')," +
                "('Manajle Vladičin Han')," +
                "('Manastir Niš – Niška Banja')," +
                "('Manastirica Kladovo')," +
                "('Manastirica Petrova na Mlavi')," +
                "('Manastirica Prizren')," +
                "('Manastirce Uroševac')," +
                "('Manđelos Sremska Mitrovica')," +
                "('Manić Beograd – Barajevo')," +
                "('Manišince Novo Brdo')," +
                "('Manojlica Svrljig')," +
                "('Manojlovce Leskovac')," +
                "('Manojlovci Topola')," +
                "('Manjak Vladičin Han')," +
                "('Manjinac Knjaževac')," +
                "('Maovi Šabac')," +
                "('Maradik Inđija')," +
                "('Margance Vranje')," +
                "('Margance Trgovište')," +
                "('Margita Plandište')," +
                "('Marevce Lipljan')," +
                "('Marevce Priština')," +
                "('Marenovo Varvarin')," +
                "('Marina Srbica')," +
                "('Marina Kutinaadžin Han')," +
                "('Marinovac Zaječar')," +
                "('Maričiće Kuršumlija')," +
                "('Markova Crkva Lajkovac')," +
                "('Markovac Beograd – Mladenovac')," +
                "('Markovac Velika Plana')," +
                "('Markovac Vršac')," +
                "('Markoviće Kuršumlija')," +
                "('Markovićevo Plandište')," +
                "('Markovica Lučani')," +
                "('Marmule Đakovica')," +
                "('Marovac Medveđa')," +
                "('Marovce Kosovska Kamenica')," +
                "('Martinci Sremska Mitrovica')," +
                "('Martonoš Kanjiža')," +
                "('Maršić Kragujevac')," +
                "('Maskar Topola')," +
                "('Maskare Varvarin')," +
                "('Maskova Ivanjica')," +
                "('Masloševo Kragujevac')," +
                "('Masurovac Babušnica')," +
                "('Masurica Surdulica')," +
                "('Matarova Kuršumlija')," +
                "('Mataruge Kraljevo')," +
                "('Mataruge Prijepolje')," +
                "('Mataruška Banja Kraljevo')," +
                "('Matijevac Vladimirci')," +
                "('Matica Zvečan')," +
                "('Matičane Priština')," +
                "('Maćedonce Medveđa')," +
                "('Maćedonce (Retkocersko) Medveđa')," +
                "('Maćija Ražanj')," +
                "('Mačvanska Mitrovica Sremska Mitrovica')," +
                "('Mačvanski Pričinović Šabac')," +
                "('Mačevac Svilajnac')," +
                "('Mačina Prokuplje')," +
                "('Mačitevo Suva Reka')," +
                "('Mačja Stena Kuršumlija')," +
                "('Mačkat Čajetina')," +
                "('Mačkatica Surdulica')," +
                "('Mačkovac Kruševac')," +
                "('Mačkovac Kuršumlija')," +
                "('Mašoviće Sjenica')," +
                "('Medare Sjenica')," +
                "('Medveđa Despotovac')," +
                "('Medveđa Medveđa')," +
                "('Medveđa Trstenik')," +
                "('Medveđica Žagubica')," +
                "('Medvece Lipljan')," +
                "('Medvece Prizren')," +
                "('Medevce Medveđa')," +
                "('Medovine Ivanjica')," +
                "('Medojevac Jagodina')," +
                "('Medoševac Beograd – Lazarevac')," +
                "('Medoševac Niš – Crveni krst')," +
                "('Medregovac Podujevo')," +
                "('Međa Leskovac')," +
                "('Međa Žitište')," +
                "('Međani Prijepolje')," +
                "('Međeđi Potok Zubin Potok')," +
                "('Međuvršje Čačak')," +
                "('Međugor Sjenica')," +
                "('Međulužje Beograd – Mladenovac')," +
                "('Međureč Jagodina')," +
                "('Međurečje Ivanjica')," +
                "('Međurečje Kraljevo')," +
                "('Međuhana Blace')," +
                "('Mezgraja Babušnica')," +
                "('Mezgraja Niš – Crveni krst')," +
                "('Mezdraja Trgovište')," +
                "('Mejarize Đakovica')," +
                "('Meki Do Zvečan')," +
                "('Mekiniće Leposavić')," +
                "('Mekiš Doljevac')," +
                "('Melaje Tutin')," +
                "('Melenci Zrenjanin')," +
                "('Melnica Petrova na Mlavi')," +
                "('Melovo Leskovac')," +
                "('Meljak Beograd – Barajevo')," +
                "('Meljanica Kraljevo')," +
                "('Meljenica Kosovska Mitrovica')," +
                "('Merdare Kuršumlija')," +
                "('Merdare Podujevo')," +
                "('Merovac Prokuplje')," +
                "('Merošina Merošina')," +
                "('Merćez Kuršumlija')," +
                "('Merdželat Svrljig')," +
                "('Mesarci Vladimirci')," +
                "('Mesić Vršac')," +
                "('Metikoš Kraljevo')," +
                "('Metković Bogatić')," +
                "('Metlić Šabac')," +
                "('Metovnica Bor')," +
                "('Metohija Podujevo')," +
                "('Metriš Zaječar')," +
                "('Meća Đakovica')," +
                "('Mehane Kuršumlija')," +
                "('Mehovine Vladimirci')," +
                "('Mečji Do Svrljig')," +
                "('Mečkovac Vranje')," +
                "('Meševo Kruševac')," +
                "('Mešina Kosovska Kamenica')," +
                "('Miganovce Kosovska Kamenica')," +
                "('Mijajlica Bojnik')," +
                "('Mijajlovac Trstenik')," +
                "('Mijak Vitina')," +
                "('Mijakovce Vranje')," +
                "('Mijalić Vučitrn')," +
                "('Mijani Prijepolje')," +
                "('Mijatovac Ćuprija')," +
                "('Mijači Valjevo')," +
                "('Mijovce Vranje')," +
                "('Mijoska Prijepolje')," +
                "('Mikulovac Prokuplje')," +
                "('Mikušnica Srbica')," +
                "('Milavac Ljig')," +
                "('Milavčići Kraljevo')," +
                "('Milakovac Kraljevo')," +
                "('Milakovići Prijepolje')," +
                "('Milanovac Žagubica')," +
                "('Milanovac Peć')," +
                "('Milanovićrahovac')," +
                "('Milanovo Vranje')," +
                "('Milanovo Leskovac')," +
                "('Milatkoviće Raška')," +
                "('Milatovac Batočina')," +
                "('Milatovac Žagubica')," +
                "('Milatovići Lučani')," +
                "('Milevci Bosilegrad')," +
                "('Milentija Brus')," +
                "('Miletićevo Plandište')," +
                "('Mileševo Prijepolje')," +
                "('Mileševo Bečej')," +
                "('Miliva Despotovac')," +
                "('Milivojce Vranje')," +
                "('Miliješ Priboj')," +
                "('Milina Loznica')," +
                "('Miliće Kraljevo')," +
                "('Milićevo Selo Požega')," +
                "('Milićevci Čačak')," +
                "('Milići Sjenica')," +
                "('Miličinica Valjevo')," +
                "('Milojkovac Pirot')," +
                "('Milorci Ub')," +
                "('Miločaj Kraljevo')," +
                "('Milošev Do Prijepolje')," +
                "('Miloševac Velika Plana')," +
                "('Miloševac Šabac')," +
                "('Miloševo Negotin')," +
                "('Miloševo Jagodina')," +
                "('Miloševobilić')," +
                "('Milutinovac Kladovo')," +
                "('Milutovac Trstenik')," +
                "('Milušinac Sokobanja')," +
                "('Miljaj Prizren')," +
                "('Miljevićolubac')," +
                "('Miljevići Prijepolje')," +
                "('Miljkovacadžin Han')," +
                "('Miljkovac Knjaževac')," +
                "('Miljkovac Niš – Crveni krst')," +
                "('Miljkovica Prokuplje')," +
                "('Minićevo Knjaževac')," +
                "('Miokoviće Leposavić')," +
                "('Miokovci Čačak')," +
                "('Miokus Šabac')," +
                "('Mioliće Leposavić')," +
                "('Mionica Kosjerić')," +
                "('Mionica (varošica) Mionica')," +
                "('Mionica (selo) Mionica')," +
                "('Miranovac Bela Palanka')," +
                "('Miranovačka Kula Bela Palanka')," +
                "('Miratovac Preševo')," +
                "('Miraševac Rača')," +
                "('Mirena Lipljan')," +
                "('Mirijevo Žabari')," +
                "('Mirilovac Paraćin')," +
                "('Mirkovci Pirot')," +
                "('Mirnica Kuršumlija')," +
                "('Mirovac Podujevo')," +
                "('Mirovo Boljevac')," +
                "('Mironić Kragujevac')," +
                "('Mirosavlje Uroševac')," +
                "('Mirosaljci Arilje')," +
                "('Mirosaljci Beograd – Lazarevac')," +
                "('Miroč Majdanpek')," +
                "('Miroče Vučitrn')," +
                "('Miroševce Leskovac')," +
                "('Mirušarahovac')," +
                "('Misača Aranđelovac')," +
                "('Mislođin Beograd –brenovac')," +
                "('Mitrova Tutin')," +
                "('Mićunovo Bačka Topola')," +
                "('Mihajlovac Negotin')," +
                "('Mihajlovac Smederevo')," +
                "('Mihajlovo Zrenjanin')," +
                "('Mišar Šabac')," +
                "('Mišević Jagodina')," +
                "('Miševići Nova Varoš')," +
                "('Mišićevo Subotica')," +
                "('Mišljenovac Kučevo')," +
                "('Miščiće Novi Pazar')," +
                "('Mladenovac (varoš) Beograd – Mladenovac')," +
                "('Mladenovac (selo) Beograd – Mladenovac')," +
                "('Mladenovo Bačka Palanka')," +
                "('Mlanča Kraljevo')," +
                "('Mlačište Crna Trava')," +
                "('Mlekominci Bosilegrad')," +
                "('Mlečane Klina')," +
                "('Mlikeora')," +
                "('Movljane Suva Reka')," +
                "('Mogila Vitina')," +
                "('Moglica Đakovica')," +
                "('Modra Stena Babušnica')," +
                "('Modrica Kruševac')," +
                "('Mozgovo Aleksinac')," +
                "('Mozgovonjilane')," +
                "('Mojinci Dimitrovgrad')," +
                "('Mojković Krupanj')," +
                "('Mojsinje Ćićevac')," +
                "('Mojsinje Čačak')," +
                "('Mojstir Istok')," +
                "('Moklište Bela Palanka')," +
                "('Mokra Bela Palanka')," +
                "('Mokraora Užice')," +
                "('Mokranje Negotin')," +
                "('Mokrin Kikinda')," +
                "('Mol Ada')," +
                "('Molić Đakovica')," +
                "('Molovin Šid')," +
                "('Moravac Aleksinac')," +
                "('Moravski Bujmir Aleksinac')," +
                "('Moravci Ljig')," +
                "('Moralijarahovac')," +
                "('Morani Tutin')," +
                "('Morina Đakovica')," +
                "('Morović Šid')," +
                "('Mosna Majdanpek')," +
                "('Motrić Rekovac')," +
                "('Močare Kosovska Kamenica')," +
                "('Močioci Ivanjica')," +
                "('Mošnica Leposavić')," +
                "('Mošorin Titel')," +
                "('Moštanica Vranje')," +
                "('Mramor Niš – Palilula')," +
                "('Mramor Priština')," +
                "('Mramorak Kovin')," +
                "('Mramorac Smederevska Palanka')," +
                "('Mramorski Potok Niš – Palilula')," +
                "('Mramorsko Brdo Merošina')," +
                "('Mrasorrahovac')," +
                "('Mratišić Mionica')," +
                "('Mrveš Bojnik')," +
                "('Mrđenovac Šabac')," +
                "('Mrzenica Ćićevac')," +
                "('Mrkovica Leskovac')," +
                "('Mrkonje Medveđa')," +
                "('Mrljak Prokuplje')," +
                "('Mrmoš Aleksandrovac')," +
                "('Mrovska Vladimirci')," +
                "('Mrsać Kraljevo')," +
                "('Mrtvica Vladičin Han')," +
                "('Mrča Kuršumlija')," +
                "('Mrčajevci Čačak')," +
                "('Mrčić Valjevo')," +
                "('Mrčići Kosjerić')," +
                "('Mrčkovacolubac')," +
                "('Mrčkovina Prijepolje')," +
                "('Mršelj Prokuplje')," +
                "('Mršelji Požega')," +
                "('Mršinci Čačak')," +
                "('Mrštane Leskovac')," +
                "('Mudrakovac Kruševac')," +
                "('Muževine Istok')," +
                "('Mužinac Sokobanja')," +
                "('Mužičane Štimlje')," +
                "('Muzaće Blace')," +
                "('Mur Novi Pazar')," +
                "('Muradem Prizren')," +
                "('Murga Srbica')," +
                "('Murgaš Ub')," +
                "('Murgula Podujevo')," +
                "('Mure Raška')," +
                "('Musina Reka Kraljevo')," +
                "('Mustapić Kučevo')," +
                "('Musulj Bosilegrad')," +
                "('Mutanjornji Milanovac')," +
                "('Muhadžer Babuš Lipljan')," +
                "('Muhadžer Prelez Uroševac')," +
                "('Muhadžer Talinovac Uroševac')," +
                "('Muhovac Bujanovac')," +
                "('Muhovo Novi Pazar')," +
                "('Muhovce Uroševac')," +
                "('Mučibaba Knjaževac')," +
                "('Mučibabanjilane')," +
                "('Mučivrce Kosovska Kamenica')," +
                "('Mušvete Čajetina')," +
                "('Mušići Kosjerić')," +
                "('Muškovina Prijepolje')," +
                "('Mušnikovo Prizren')," +
                "('Mušutište Suva Reka')," +
                "('Naboje Tutin')," +
                "('Nabrđe Požarevac')," +
                "('Nabrđe Peć')," +
                "('Navalin Leskovac')," +
                "('Naglavci Klina')," +
                "('Nadalj Srbobran')," +
                "('Nadrlje Rekovac')," +
                "('Nadumce Tutin')," +
                "('Nazarica Bosilegrad')," +
                "('Nakarade Kosovo Polje')," +
                "('Naklo Peć')," +
                "('Nakovo Kikinda')," +
                "('Nakrivanj Leskovac')," +
                "('Nakučaniornji Milanovac')," +
                "('Nakučani Šabac')," +
                "('Namga Tutin')," +
                "('Nanomir Mionica')," +
                "('Nastavce Vranje')," +
                "('Natalinci Topola')," +
                "('Naupare Kruševac')," +
                "('Našec Prizren')," +
                "('Našpalerahovac')," +
                "('Našuškovica Babušnica')," +
                "('Nebregošte Prizren')," +
                "('Nevada Kuršumlija')," +
                "('Nevadeornji Milanovac')," +
                "('Nevoljane Vučitrn')," +
                "('Negbina Nova Varoš')," +
                "('Negovac Bujanovac')," +
                "('Negosavlje Medveđa')," +
                "('Negotin Negotin')," +
                "('Negotinac Novi Pazar')," +
                "('Negrišori Lučani')," +
                "('Negrovcelogovac')," +
                "('Nedakovac Vučitrn')," +
                "('Nekovcelogovac')," +
                "('Nekodim Uroševac')," +
                "('Nemenikuće Beograd – Sopot')," +
                "('Nepolje Peć')," +
                "('Neprebište Suva Reka')," +
                "('Nepričava Lajkovac')," +
                "('Neradin Irig')," +
                "('Neresnica Kučevo')," +
                "('Nesalce Bujanovac')," +
                "('Nesvrta Leskovac')," +
                "('Nesvrta Vranjska Banja')," +
                "('Nećavce Kačanik')," +
                "('Neuzina Sečanj')," +
                "('Nec Đakovica')," +
                "('Neštin Bačka Palanka')," +
                "('Nivokaz Đakovica')," +
                "('Nika Kačanik')," +
                "('Nikinci Ruma')," +
                "('Nikovce Kačanik')," +
                "('Nikojevići Užice')," +
                "('Nikola Tesla Niš – Niška Banja')," +
                "('Nikolinac Sokobanja')," +
                "('Nikolinci Alibunar')," +
                "('Nikoličevo Zaječar')," +
                "('Nikšić Batočina')," +
                "('Niš (Medijana) Niš – Medijana')," +
                "('Niš (Palilula) Niš – Palilula')," +
                "('Niš (Pantelej) Niš – Pantelej')," +
                "('Niš (Crveni krst) Niš – Crveni krst')," +
                "('Niševac Svrljig')," +
                "('Niševce Priština')," +
                "('Niška Banja Niš – Niška Banja')");
                  migrationBuilder.Sql(
                "insert into Mesta(NazivMesta) values " +
                "('Nišor Pirot')," +
                "('Nišor Suva Reka')," +
                "('Njegoševo Bačka Topola')," +
                "('Nova Božurna Prokuplje')," +
                "('Nova Brezovica Vranje')," +
                "('Nova Varoš Nova Varoš')," +
                "('Novaajdobra Bačka Palanka')," +
                "('Nova Pazova Stara Pazova')," +
                "('Nova Topola Lebane')," +
                "('Nova Crvenka Kula')," +
                "('Nova Crnja Nova Crnja')," +
                "('Nova Šumadija Prizren')," +
                "('Novake Prizren')," +
                "('Novaci Aleksandrovac')," +
                "('Novaci Ub')," +
                "('Novi Banovci Stara Pazova')," +
                "('Novi Bečej Novi Bečej')," +
                "('Novi Bračin Ražanj')," +
                "('Novi Verić Istok')," +
                "('Novilog Trgovište')," +
                "('Novi Đurovac Prokuplje')," +
                "('Novi Žednik Subotica')," +
                "('Novi Zavoj Pirot')," +
                "('Novi Itebej Žitište')," +
                "('Novi Karlovci Inđija')," +
                "('Novi Kneževac Novi Kneževac')," +
                "('Novi Kozarci Kikinda')," +
                "('Novi Kozjak Alibunar')," +
                "('Novi Milanovac Kragujevac')," +
                "('Novi Miraš Uroševac')," +
                "('Novi Pazar Novi Pazar')," +
                "('Novi Raušić Peć')," +
                "('Novi Sad Novi Sad')," +
                "('Novi Sip Kladovo')," +
                "('Novi Slankamen Inđija')," +
                "('Novo Brdo Novo Brdo')," +
                "('Novo Korito Knjaževac')," +
                "('Novo Lanište Jagodina')," +
                "('Novo Miloševo Novi Bečej')," +
                "('Novo Momčilovo Žitorađa')," +
                "('Novorahovo Bačka Topola')," +
                "('Novo Rujce Lipljan')," +
                "('Novo Selo Bela Palanka')," +
                "('Novo Selo Bujanovac')," +
                "('Novo Selo Velika Plana')," +
                "('Novo Selo Vladimirci')," +
                "('Novo Selo Vrnjačka Banja')," +
                "('Novo Seloadžin Han')," +
                "('Novo Selo Kuršumlija')," +
                "('Novo Selo Lebane')," +
                "('Novo Selo Leskovac')," +
                "('Novo Selo Loznica')," +
                "('Novo Selo Prokuplje')," +
                "('Novo Selo Raška')," +
                "('Novo Selo Sokobanja')," +
                "('Novo Selo Surdulica')," +
                "('Novo Selo Trgovište')," +
                "('Novo Selo Kanjiža')," +
                "('Novo Selo Vitina')," +
                "('Novo Selo Kosovska Kamenica')," +
                "('Novo Selo Peć')," +
                "('Novo Selo Prizren')," +
                "('Novo Selo Srbica')," +
                "('Novo Selo Begovo Vučitrn')," +
                "('Novo Selo Mađunsko Vučitrn')," +
                "('Novo Čikatovologovac')," +
                "('Nogavacrahovac')," +
                "('Nozrina Aleksinac')," +
                "('Nomanica Leskovac')," +
                "('Norča Preševo')," +
                "('Nosaljenjilane')," +
                "('Nosoljin Raška')," +
                "('Noćaj Sremska Mitrovica')," +
                "('Noćaje Tutin')," +
                "('Obajgora Bajina Bašta')," +
                "('Obilić Bojnik')," +
                "('Obilićbilić')," +
                "('Oblačina Merošina')," +
                "('Oblička Sena Vranje')," +
                "('Obornjača Ada')," +
                "('Obornjača Bačka Topola')," +
                "('Obradovce Crna Trava')," +
                "('Obražda Bojnik')," +
                "('Obrandža Podujevo')," +
                "('Obrva Kraljevo')," +
                "('Obrež Varvarin')," +
                "('Obrež Pećinci')," +
                "('Obrenovac Beograd –brenovac')," +
                "('Obrenovac Pirot')," +
                "('Obrovac Bačka Palanka')," +
                "('Obrtince Prokuplje')," +
                "('Ovsinjinacadžin Han')," +
                "('Ovsište Topola')," +
                "('Ovča Beograd – Palilula')," +
                "('Ovčar Banja Čačak')," +
                "('Ovčare Kosovska Mitrovica')," +
                "('Ovčarevo Srbica')," +
                "('Ovčinja Bajina Bašta')," +
                "('Ogar Pećinci')," +
                "('Oglađenovac Valjevo')," +
                "('Ogošte Kosovska Kamenica')," +
                "('Odanovce Kosovska Kamenica')," +
                "('Odevce Kosovska Kamenica')," +
                "('Odojeviće Novi Pazar')," +
                "('Ozremornji Milanovac')," +
                "('Ozrim Peć')," +
                "('Ojkovica Nova Varoš')," +
                "('Oklap Lipljan')," +
                "('Oklace Zubin Potok')," +
                "('Okletac Bajina Bašta')," +
                "('Okolište Svrljig')," +
                "('Okose Novi Pazar')," +
                "('Okosnica Lipljan')," +
                "('Okraštica Vučitrn')," +
                "('Okruglica Svrljig')," +
                "('Okruglica Trstenik')," +
                "('Omoljica Pančevo')," +
                "('Opaljenik Ivanjica')," +
                "('Oparić Rekovac')," +
                "('Oplanić Knić')," +
                "('Oplanići Kraljevo')," +
                "('Opovopovo')," +
                "('Opornica Kragujevac')," +
                "('Opterušarahovac')," +
                "('Orane Bojnik')," +
                "('Oraovac Prijepolje')," +
                "('Oraovica Preševo')," +
                "('Oraovica Kosovska Kamenica')," +
                "('Oraovica Zvečan')," +
                "('Oraovica (kodrdelice) Leskovac')," +
                "('Oraovica (kod Crkovnice) Leskovac')," +
                "('Orahovacrahovac')," +
                "('Orahovo Raška')," +
                "('Orahovo Kosovska Mitrovica')," +
                "('Orašac Aranđelovac')," +
                "('Orašac Beograd –brenovac')," +
                "('Orašac Leskovac')," +
                "('Orašac Prijepolje')," +
                "('Orašac Šabac')," +
                "('Oraše Tutin')," +
                "('Orašje Varvarin')," +
                "('Orašje Vlasotince')," +
                "('Oreovac Bela Palanka')," +
                "('Oreovac Niš – Pantelej')," +
                "('Oreovica Žabari')," +
                "('Oreovica Pirot')," +
                "('Orešac Knjaževac')," +
                "('Orešac Vršac')," +
                "('Oreškovica Petrova na Mlavi')," +
                "('Orid Šabac')," +
                "('Orlane Podujevo')," +
                "('Orlatelogovac')," +
                "('Orlovat Zrenjanin')," +
                "('Orlovac Kuršumlija')," +
                "('Orlović Priština')," +
                "('Orlja Pirot')," +
                "('Orljalava Kraljevo')," +
                "('Orljane Doljevac')," +
                "('Orlje Tutin')," +
                "('Orljevo Petrova na Mlavi')," +
                "('Orno Brdo Istok')," +
                "('Orovička Planina Ljubovija')," +
                "('Orom Kanjiža')," +
                "('Oruglica Leskovac')," +
                "('Orčušaora')," +
                "('Osanica Žagubica')," +
                "('Osaonica Novi Pazar')," +
                "('Osaonica Trstenik')," +
                "('Osek Paša Đakovica')," +
                "('Osek Hilja Đakovica')," +
                "('Osečenica Mionica')," +
                "('Osečina (varošica)sečina')," +
                "('Osečina (selo)sečina')," +
                "('Osipaonica Smederevo')," +
                "('Osladić Valjevo')," +
                "('Oslare Bujanovac')," +
                "('Osmakova Pirot')," +
                "('Osnić Boljevac')," +
                "('Osojane Istok')," +
                "('Osoje Novi Pazar')," +
                "('Osoje Prijepolje')," +
                "('Osoje Peć')," +
                "('Osonica Ivanjica')," +
                "('Osreci Brus')," +
                "('Ostatovica Babušnica')," +
                "('Ostojićevo Čoka')," +
                "('Ostra Čačak')," +
                "('Ostralava Vranje')," +
                "('Ostraće Leposavić')," +
                "('Ostrikovac Ćuprija')," +
                "('Ostrovica Vladičin Han')," +
                "('Ostrovica Tutin')," +
                "('Ostrovica Niš – Niška Banja')," +
                "('Ostrovo Velikoradište')," +
                "('Ostrovo Kostolac')," +
                "('Ostrozub Crna Trava')," +
                "('Ostrozubrahovac')," +
                "('Ostružanjsečina')," +
                "('Ostružnica Beograd – Čukarica')," +
                "('Ostrc Vlasotince')," +
                "('Otanj Požega')," +
                "('Otroci Vrnjačka Banja')," +
                "('Oholje Novi Pazar')," +
                "('Očage Bogatić')," +
                "('Odžaci Trstenik')," +
                "('Odžacidžaci')," +
                "('Ošljane Knjaževac')," +
                "('Ošljane Vučitrn')," +
                "('Oštra Stijena Prijepolje')," +
                "('Oštrelj Bor')," +
                "('Pavaštica Kuršumlija')," +
                "('Pavlica Raška')," +
                "('Pavličina Crna Trava')," +
                "('Pavliš Vršac')," +
                "('Pavlovac Vranje')," +
                "('Pavlovac Topola')," +
                "('Pavlovci Ruma')," +
                "('Pavlje Novi Pazar')," +
                "('Pagarušarahovac')," +
                "('Padalište Srbica')," +
                "('Padež Kruševac')," +
                "('Padež Leskovac')," +
                "('Padej Čoka')," +
                "('Padina Merošina')," +
                "('Padina Kovačica')," +
                "('Padine Zubin Potok')," +
                "('Padinska Skela Beograd – Palilula')," +
                "('Pajazitovo Kragujevac')," +
                "('Pajež Bela Palanka')," +
                "('Pajkovac Varvarin')," +
                "('Pajsak Trstenik')," +
                "('Pajsijević Knić')," +
                "('Pakašnica Kruševac')," +
                "('Pakleštica Pirot')," +
                "('Paklje Valjevo')," +
                "('Pakovraće Čačak')," +
                "('Palatna Podujevo')," +
                "('Paležnica Ljig')," +
                "('Palivodenica Kačanik')," +
                "('Paligrace Niš – Crveni krst')," +
                "('Palikuća Leskovac')," +
                "('Palilula Svrljig')," +
                "('Palić Subotica')," +
                "('Palojce Leskovac')," +
                "('Palja Surdulica')," +
                "('Paljabarda Đakovica')," +
                "('Paljane Ćuprija')," +
                "('Paljevo Tutin')," +
                "('Paljevštica Brus')," +
                "('Paljina Niš – Crveni krst')," +
                "('Paljuvi Ub')," +
                "('Pambukovica Ub')," +
                "('Panevlje Vranjska Banja')," +
                "('Pankovo Petrova na Mlavi')," +
                "('Panojeviće Raška')," +
                "('Panonija Bačka Topola')," +
                "('Pantina Vučitrn')," +
                "('Pančevo Pančevo')," +
                "('Pančelo Kosovska Kamenica')," +
                "('Panjak Užice')," +
                "('Panjevac Aleksandrovac')," +
                "('Panjevac Despotovac')," +
                "('Papaz Suva Reka')," +
                "('Papaz Uroševac')," +
                "('Papić Dečani')," +
                "('Papiće Sjenica')," +
                "('Papratište Požega')," +
                "('Papratna Knjaževac')," +
                "('Papraćane Dečani')," +
                "('Parage Bačka Palanka')," +
                "('Parada Kuršumlija')," +
                "('Paralovo Bosilegrad')," +
                "('Paralovo Novi Pazar')," +
                "('Paralovonjilane')," +
                "('Paramun Kosjerić')," +
                "('Paraćin Paraćin')," +
                "('Pardik Ražanj')," +
                "('Parmenac Čačak')," +
                "('Parta Vršac')," +
                "('Partešnjilane')," +
                "('Parunovac Kruševac')," +
                "('Paruce Zubin Potok')," +
                "('Parcane Varvarin')," +
                "('Parcani Beograd – Sopot')," +
                "('Parčin Aleksandrovac')," +
                "('Pasi Poljana Niš – Palilula')," +
                "('Pasjak Kruševac')," +
                "('Pasjaknjilane')," +
                "('Pasjanenjilane')," +
                "('Pasjač Pirot')," +
                "('Pasjača Prokuplje')," +
                "('Pasjača Niš – Pantelej')," +
                "('Pasji Potok Novi Pazar')," +
                "('Paskašija Dimitrovgrad')," +
                "('Paskovac Loznica')," +
                "('Pasoma Vučitrn')," +
                "('Paune Valjevo')," +
                "('Pacaj Đakovica')," +
                "('Pačarađa Kuršumlija')," +
                "('Pačir Bačka Topola')," +
                "('Pašinac Prokuplje')," +
                "('Pašino Selo Peć')," +
                "('Paštrić Mionica')," +
                "('Pear Užice')," +
                "('Pejinović Vladimirci')," +
                "('Pejkovac Žitorađa')," +
                "('Pekčanica Kraljevo')," +
                "('Penduha Podujevo')," +
                "('Pepelj Bajina Bašta')," +
                "('Pepeljevac Kruševac')," +
                "('Pepeljevac Kuršumlija')," +
                "('Pepeljevac Lajkovac')," +
                "('Pepiće Peć')," +
                "('Perane Podujevo')," +
                "('Periš Svrljig')," +
                "('Perlez Zrenjanin')," +
                "('Pertate Lebane')," +
                "('Perunika Kuršumlija')," +
                "('Perutina Doljevac')," +
                "('Perućac Bajina Bašta')," +
                "('Pestiš Prokuplje')," +
                "('Pestovo Vučitrn')," +
                "('Petačinci Dimitrovgrad')," +
                "('Peterlaš Dimitrovgrad')," +
                "('Petina Kruševac')," +
                "('Petka Beograd – Lazarevac')," +
                "('Petka Kostolac')," +
                "('Petkovićrahovac')," +
                "('Petkovica Šabac')," +
                "('Petlovača Šabac')," +
                "('Petnica Valjevo')," +
                "('Petnica Čačak')," +
                "('Petraštica Štimlje')," +
                "('Petrijevo Smederevo')," +
                "('Petrilje Medveđa')," +
                "('Petrovaradin Petrovaradin')," +
                "('Petrovac Lebane')," +
                "('Petrovac Leskovac')," +
                "('Petrovac Pirot')," +
                "('Petrovac Prokuplje')," +
                "('Petrovac Trgovište')," +
                "('Petrovac na Mlavi Petrova na Mlavi')," +
                "('Petrović Štimlje')," +
                "('Petrovo Štimlje')," +
                "('Petrovo Polje Sjenica')," +
                "('Petrovo Selo Kladovo')," +
                "('Petrovo Selo Prizren')," +
                "('Petrovce Kosovska Kamenica')," +
                "('Petrovčić Beograd – Surčin')," +
                "('Petropolje Kraljevo')," +
                "('Petruša Knjaževac')," +
                "('Petrušan Đakovica')," +
                "('Peć Peć')," +
                "('Pećane Suva Reka')," +
                "('Pećani Beograd – Čukarica')," +
                "('Pećinci Pećinci')," +
                "('Peckasečina')," +
                "('Pečanica Velikoradište')," +
                "('Pečeno Preševo')," +
                "('Pečenog Kraljevo')," +
                "('Pečenjevce Leskovac')," +
                "('Pivnice Bačka Palanka')," +
                "('Pidićnjilane')," +
                "('Pilareta Novi Pazar')," +
                "('Pilatovići Požega')," +
                "('Pilica Bajina Bašta')," +
                "('Pinosava Beograd – Voždovac')," +
                "('Pirane Prizren')," +
                "('Pirkovac Svrljig')," +
                "('Piroman Beograd –brenovac')," +
                "('Pirot Pirot')," +
                "('Pirče Kosovska Mitrovica')," +
                "('Piskalje Prokuplje')," +
                "('Piskanja Raška')," +
                "('Piskopovce Tutin')," +
                "('Piskupovo Leskovac')," +
                "('Pištane Peć')," +
                "('Plava Prizren')," +
                "('Plavkovo Raška')," +
                "('Plavljane Peć')," +
                "('Plavna Negotin')," +
                "('Plavna Bač')," +
                "('Plavce Bojnik')," +
                "('Plažane Despotovac')," +
                "('Plajnik Prizren')," +
                "('Plakaonica Leposavić')," +
                "('Plana Kraljevo')," +
                "('Plana Paraćin')," +
                "('Plana Sjenica')," +
                "('Plandište Plandište')," +
                "('Planeja Prizren')," +
                "('Planina Krupanj')," +
                "('Planinica Dimitrovgrad')," +
                "('Planinica Zaječar')," +
                "('Planinica Mionica')," +
                "('Planinica Pirot')," +
                "('Planinica Trstenik')," +
                "('Planinica Leposavić')," +
                "('Planjane Prizren')," +
                "('Plaskovac Topola')," +
                "('Platičevo Ruma')," +
                "('Plašće Priboj')," +
                "('Plemetinabilić')," +
                "('Plenibabe Tutin')," +
                "('Pleš Aleksandrovac')," +
                "('Plešin Raška')," +
                "('Plešina Uroševac')," +
                "('Plitković Lipljan')," +
                "('Ploča Aleksandrovac')," +
                "('Ploča Bosilegrad')," +
                "('Ploča Loznica')," +
                "('Pločica Kovin')," +
                "('Pločice Klina')," +
                "('Pločnik Prokuplje')," +
                "('Pločnik Ćićevac')," +
                "('Plužacsečina')," +
                "('Plužina Svrljig')," +
                "('Plužina Srbica')," +
                "('Pljakovo Kuršumlija')," +
                "('Pljančor Đakovica')," +
                "('Pljačkovica Vranje')," +
                "('Pobeda Bačka Topola')," +
                "('Pobrđe Novi Pazar')," +
                "('Pobrđe Raška')," +
                "('Pobrđe Dečani')," +
                "('Poganovo Dimitrovgrad')," +
                "('Pogled Arilje')," +
                "('Pograđe Klina')," +
                "('Poda Sjenica')," +
                "('Podvis Knjaževac')," +
                "('Podvrška Kladovo')," +
                "('Podgorac Boljevac')," +
                "('Podgorac Ražanj')," +
                "('Podgorce Vitina')," +
                "('Podgrađenjilane')," +
                "('Podina Žitorađa')," +
                "('Podlokanj Novi Kneževac')," +
                "('Podnemić Ljubovija')," +
                "('Podrimce Leskovac')," +
                "('Podujevo Podujevo')," +
                "('Podunavci Vrnjačka Banja')," +
                "('Požar Dečani')," +
                "('Požaranje Vitina')," +
                "('Požarevac Požarevac')," +
                "('Požega Novi Pazar')," +
                "('Požega Požega')," +
                "('Požegrmac Priboj')," +
                "('Požeženo Velikoradište')," +
                "('Požežina Novi Pazar')," +
                "('Pozlata Kruševac')," +
                "('Pojate Ćićevac')," +
                "('Pojatište Uroševac')," +
                "('Pokleklogovac')," +
                "('Pokrvenik Raška')," +
                "('Pokrvenik Tutin')," +
                "('Pokrevenik Pirot')," +
                "('Polatna Žabari')," +
                "('Polička Kosovska Kamenica')," +
                "('Polokce Novi Pazar')," +
                "('Polom Vladičin Han')," +
                "('Polomornji Milanovac')," +
                "('Polužalogovac')," +
                "('Polužarahovac')," +
                "('Polumir Kraljevo')," +
                "('Poljana Požarevac')," +
                "('Poljane Beograd –brenovac')," +
                "('Poljane Istok')," +
                "('Poljanice Ljig')," +
                "('Poljance Srbica')," +
                "('Poljaci Kruševac')," +
                "('Poljna Trstenik')," +
                "('Poljska Ržana Pirot')," +
                "('Pomazatin Kosovo Polje')," +
                "('Pomijača Loznica')," +
                "('Ponešnjilane')," +
                "('Ponikveolubac')," +
                "('Ponikovica Užice')," +
                "('Ponor Knjaževac')," +
                "('Ponor Pirot')," +
                "('Ponorac Sjenica')," +
                "('Ponoracrahovac')," +
                "('Ponoševac Đakovica')," +
                "('Popadić Mionica')," +
                "('Pope Novi Pazar')," +
                "('Pope Tutin')," +
                "('Popina Trstenik')," +
                "('Popinci Pećinci')," +
                "('Popiće Tutin')," +
                "('Popova Blace')," +
                "('Popovac Velikoradište')," +
                "('Popovac Paraćin')," +
                "('Popovac Niš – Crveni krst')," +
                "('Popovac Đakovica')," +
                "('Popović Beograd – Sopot')," +
                "('Popović Rača')," +
                "('Popovići Kraljevo')," +
                "('Popovica Negotin')," +
                "('Popovljane Suva Reka')," +
                "('Popovnjak Despotovac')," +
                "('Popovo Podujevo')," +
                "('Popovce Lebane')," +
                "('Popovce Leposavić')," +
                "('Popovci Aleksandrovac')," +
                "('Popučke Valjevo')," +
                "('Popšica Svrljig')," +
                "('Porodin Aleksinac')," +
                "('Porodin Žabari')," +
                "('Poroštica Lebane')," +
                "('Poroštica Medveđa')," +
                "('Poružnica Sokobanja')," +
                "('Poskurice Kragujevac')," +
                "('Poslište Prizren')," +
                "('Poslon Ražanj')," +
                "('Postenje Ljubovija')," +
                "('Postenje Novi Pazar')," +
                "('Potkomlje Leposavić')," +
                "('Potkrš Prijepolje')," +
                "('Potok Prijepolje')," +
                "('Potok Podujevo')," +
                "('Potočanje Užice')," +
                "('Potočac Paraćin')," +
                "('Potočić Prokuplje')," +
                "('Potpeće Užice')," +
                "('Potporanj Vršac')," +
                "('Potreb Tutin')," +
                "('Potrkanje Knjaževac')," +
                "('Poturovce Lipljan')," +
                "('Pousko Prizren')," +
                "('Pocerski Metković Šabac')," +
                "('Pocerski Pričinović Šabac')," +
                "('Pocesje Raška')," +
                "('Počekovina Trstenik')," +
                "('Počešće Peć')," +
                "('Pravoševo Prijepolje')," +
                "('Pralja Sjenica')," +
                "('Pranjaniornji Milanovac')," +
                "('Pranjci Prijepolje')," +
                "('Praskovče Ražanj')," +
                "('Prahovo Negotin')," +
                "('Prača Dimitrovgrad')," +
                "('Prva Kutina Niš – Niška Banja')," +
                "('Prvi Tunel Kosovska Mitrovica')," +
                "('Prvonek Vranjska Banja')," +
                "('Prebreza Blace')," +
                "('Prevalac Vranjska Banja')," +
                "('Prevetica Kuršumlija')," +
                "('Prevešt Rekovac')," +
                "('Prevlak Zubin Potok')," +
                "('Predvorica Šabac')," +
                "('Predejane (varoš) Leskovac')," +
                "('Predejane (selo) Leskovac')," +
                "('Predole Kraljevo')," +
                "('Prekadin Prokuplje')," +
                "('Prekale Istok')," +
                "('Prekašnica Prokuplje')," +
                "('Prekovce Novo Brdo')," +
                "('Prekodolce Vladičin Han')," +
                "('Prekoluka Dečani')," +
                "('Prekonoga Svrljig')," +
                "('Prekonozi Aleksinac')," +
                "('Prekopeča Kragujevac')," +
                "('Prekopuce Prokuplje')," +
                "('Prekopčelica Lebane')," +
                "('Prekorađa Kuršumlija')," +
                "('Prelez Zubin Potok')," +
                "('Prelovac Srbica')," +
                "('Preljina Čačak')," +
                "('Premeća Čačak')," +
                "('Preobraženje Vranje')," +
                "('Preoce Priština')," +
                "('Prepolac Podujevo')," +
                "('Preseka Babušnica')," +
                "('Preseka Ivanjica')," +
                "('Preseka Zubin Potok')," +
                "('Presečina Leskovac')," +
                "('Preslap Crna Trava')," +
                "('Pretežana Blace')," +
                "('Pretina Bujanovac')," +
                "('Pretoke Knić')," +
                "('Pretrešnja Blace')," +
                "('Pretrkovac Ražanj')," +
                "('Preševo Preševo')," +
                "('Pržojne Vlasotince')," +
                "('Pribovce Bujanovac')," +
                "('Priboj Vladičin Han')," +
                "('Priboj Leskovac')," +
                "('Priboj Priboj')," +
                "('Pribojskaoleša Priboj')," +
                "('Pribojske Čelice Priboj')," +
                "('Privinalava Šid')," +
                "('Prigoda Istok')," +
                "('Prigrevica Apatin')," +
                "('Pridvorica Blace')," +
                "('Pridvorica Bojnik')," +
                "('Pridvorica Lajkovac')," +
                "('Pridvorica Čačak')," +
                "('Pridvorica Zubin Potok')," +
                "('Pridvorica Leposavić')," +
                "('Pridvorice Smederevska Palanka')," +
                "('Pridoli Bajina Bašta')," +
                "('Prizren Prizren')," +
                "('Prijanovići Požega')," +
                "('Prijevor Čačak')," +
                "('Prijezdić Valjevo')," +
                "('Prijepolje Prijepolje')," +
                "('Prilep Dečani')," +
                "('Prilepac Vlasotince')," +
                "('Prilepnicanjilane')," +
                "('Prilike Ivanjica')," +
                "('Prilipac Požega')," +
                "('Prilužje Vučitrn')," +
                "('Prisjan Pirot')," +
                "('Prislonica Čačak')," +
                "('Pričevac Knjaževac')," +
                "('Pričević Valjevo')," +
                "('Priština Priština')," +
                "('Prkosava Beograd – Lazarevac')," +
                "('Prlita Zaječar')," +
                "('Prnjavor Batočina')," +
                "('Prnjavorornji Milanovac')," +
                "('Prnjavor Trstenik')," +
                "('Prnjavor Šabac')," +
                "('Provaljenik Babušnica')," +
                "('Provo Vladimirci')," +
                "('Progar Beograd – Surčin')," +
                "('Progorelica Kraljevo')," +
                "('Progoreoci Aranđelovac')," +
                "('Prokuplje Prokuplje')," +
                "('Prolesje Trgovište')," +
                "('Prolom Kuršumlija')," +
                "('Propaštica Priština')," +
                "('Prosek Niš – Niška Banja')," +
                "('Protopopinci Dimitrovgrad')," +
                "('Proštinac Svilajnac')," +
                "('Prćenova Novi Pazar')," +
                "('Prćilovica Aleksinac')," +
                "('Prugovac Aleksinac')," +
                "('Prugovac Priština')," +
                "('Prugovo Požarevac')," +
                "('Pružanj Tutin')," +
                "('Pružatovac Beograd – Mladenovac')," +
                "('Prhovo Pećinci')," +
                "('Prčevo Klina')," +
                "('Pudarci Beograd –rocka')," +
                "('Pukovac Doljevac')," +
                "('Pusta Tušimlja Novi Pazar')," +
                "('Pustenik Kačanik')," +
                "('Pusto Selorahovac')," +
                "('Pusto Šilovo Medveđa')," +
                "('Pustovlah Novi Pazar')," +
                "('Putinci Ruma')," +
                "('Putnikovo Kovačica')," +
                "('Puhovac Aleksandrovac')," +
                "('Puhovo Lučani')," +
                "('Pšanik Lučani')," +
                "('Rabas Valjevo')," +
                "('Rabe Novi Kneževac')," +
                "('Rabenovac Rekovac')," +
                "('Rabovce Lipljan')," +
                "('Rabrovac Beograd – Mladenovac')," +
                "('Rabrovo Kučevo')," +
                "('Ravanica Kraljevo')," +
                "('Ravna Knjaževac')," +
                "('Ravna Banja Medveđa')," +
                "('Ravnaora Vlasotince')," +
                "('Ravnaora Ivanjica')," +
                "('Ravna Dubravaadžin Han')," +
                "('Ravna Reka Vladičin Han')," +
                "('Ravna Reka Despotovac')," +
                "('Ravnaja Krupanj')," +
                "('Ravni Brus')," +
                "('Ravni Užice')," +
                "('Ravni Del Vlasotince')," +
                "('Ravni Del Leskovac')," +
                "('Ravni Do Niš – Niška Banja')," +
                "('Ravni Topolovac Žitište')," +
                "('Ravni Šort Kuršumlija')," +
                "('Ravnište Brus')," +
                "('Ravnište Kučevo')," +
                "('Ravnište Vitina')," +
                "('Ravno Bučje Bujanovac')," +
                "('Ravno Bučje Knjaževac')," +
                "('Ravno Selo Vrbas')," +
                "('Ravnje Valjevo')," +
                "('Ravnje Sremska Mitrovica')," +
                "('Ragodeš Pirot')," +
                "('Radavac Peć')," +
                "('Radalj Mali Zvornik')," +
                "('Radaljevo Ivanjica')," +
                "('Radaljica Novi Pazar')," +
                "('Radanovci Kosjerić')," +
                "('Radevo Lipljan')," +
                "('Radevce Aleksinac')," +
                "('Radevce Lebane')," +
                "('Radejna Dimitrovgrad')," +
                "('Radenka Kučevo')," +
                "('Radenkovac Sokobanja')," +
                "('Radenković Sremska Mitrovica')," +
                "('Radešaora')," +
                "('Radivojce Vitina')," +
                "('Radijevići Nova Varoš')," +
                "('Radikina Bara Niš – Niška Banja')," +
                "('Radinac Smederevo')," +
                "('Radinovac Lebane')," +
                "('Radinjince Babušnica')," +
                "('Radičevac Knjaževac')," +
                "('Radičević Bečej')," +
                "('Radičevci Bosilegrad')," +
                "('Radiševo Srbica')," +
                "('Radljevo Ub')," +
                "('Radmanovo Brus')," +
                "('Radmilović Knić')," +
                "('Radmirovac Svrljig')," +
                "('Radobić Mionica')," +
                "('Radobuđa Arilje')," +
                "('Radovanje Velika Plana')," +
                "('Radovašnica Šabac')," +
                "('Radovnica Trgovište')," +
                "('Radovci Požega')," +
                "('Radoinja Nova Varoš')," +
                "('Radojevo Nova Crnja')," +
                "('Radonjić Đakovica')," +
                "('Radonjica Leskovac')," +
                "('Radosin Babušnica')," +
                "('Radosterahovac')," +
                "('Radoševac Babušnica')," +
                "('Radoševacolubac')," +
                "('Radoševac Priština')," +
                "('Radoševo Arilje')," +
                "('Radošin Svilajnac')," +
                "('Radošiće Raška')," +
                "('Radujevac Negotin')," +
                "('Radujevac Podujevo')," +
                "('Radulovac Klina')," +
                "('Radunje Brus')," +
                "('Raduhovce Tutin')," +
                "('Raduša Užice')," +
                "('Raduša Tutin')," +
                "('Raduša Ub')," +
                "('Rađevo Selo Valjevo')," +
                "('Ražanj Ražanj')," +
                "('Raždaginja Sjenica')," +
                "('Razbojna Brus')," +
                "('Razgojna Leskovac')," +
                "('Rajanovce Kosovska Kamenica')," +
                "('Rajac Negotin')," +
                "('Rajac Čačak')," +
                "('Rajetiće Novi Pazar')," +
                "('Rajinac Trstenik')," +
                "('Rajince Preševo')," +
                "('Rajkinac Jagodina')," +
                "('Rajkovac Beograd – Mladenovac')," +
                "('Rajkovac Topola')," +
                "('Rajković Mionica')," +
                "('Rajkoviće Novi Pazar')," +
                "('Rajno Polje Leskovac')," +
                "('Rajčevce Trgovište')," +
                "('Rajčetine Crna Trava')," +
                "('Rajčilovci Bosilegrad')," +
                "('Rajčinoviće Novi Pazar')," +
                "('Rajčinovićka Trnava Novi Pazar')," +
                "('Raka Uroševac')," +
                "('Rakari Mionica')," +
                "('Rakinac Velika Plana')," +
                "('Rakinica Podujevo')," +
                "('Rakita Babušnica')," +
                "('Rakitnica Srbica')," +
                "('Rakitovo Jagodina')," +
                "('Raklja Aleksandrovac')," +
                "('Rakov Dol Babušnica')," +
                "('Rakova Čačak')," +
                "('Rakova Bara Kučevo')," +
                "('Rakovac Bujanovac')," +
                "('Rakovac Novi Pazar')," +
                "('Rakovac Raška')," +
                "('Rakovac Beočin')," +
                "('Rakovina Đakovica')," +
                "('Rakovica Čajetina')," +
                "('Rakoc Đakovica')," +
                "('Rakoš Istok')," +
                "('Ralja Beograd – Sopot')," +
                "('Ralja Smederevo')," +
                "('Raljin Babušnica')," +
                "('Ram Velikoradište')," +
                "('Ramaća Kragujevac')," +
                "('Ramoc Đakovica')," +
                "('Ramoševo Tutin')," +
                "('Ranatovce Preševo')," +
                "('Randubrava Prizren')," +
                "('Ranilović Aranđelovac')," +
                "('Ranilug Kosovska Kamenica')," +
                "('Rankova Reka Prokuplje')," +
                "('Ranovac Petrova na Mlavi')," +
                "('Ranutovac Vranje')," +
                "('Rance Štimlje')," +
                "('Rančiće Zubin Potok')," +
                "('Raskovobilić')," +
                "('Rasna Požega')," +
                "('Rasnica Pirot')," +
                "('Rasno Prijepolje')," +
                "('Rasno Sjenica')," +
                "('Raspoganče Sjenica')," +
                "('Rast Novi Pazar')," +
                "('Rastavica Dečani')," +
                "('Rastelica Kuršumlija')," +
                "('Rastenoviće Sjenica')," +
                "('Rastina Sombor')," +
                "('Rastište Bajina Bašta')," +
                "('Rastovnica Prokuplje')," +
                "('Rataje Vranje')," +
                "('Ratajska Prijepolje')," +
                "('Ratare Paraćin')," +
                "('Ratari Beograd –brenovac')," +
                "('Ratari Smederevska Palanka')," +
                "('Ratina Kraljevo')," +
                "('Ratkovac Lajkovac')," +
                "('Ratkovacrahovac')," +
                "('Ratković Rekovac')," +
                "('Ratkovodžaci')," +
                "('Rautovo Niš – Niška Banja')," +
                "('Raušić Peć')," +
                "('Rafuna Lebane')," +
                "('Rahovica Uroševac')," +
                "('Racaj Đakovica')," +
                "('Rača Bajina Bašta')," +
                "('Rača Kuršumlija')," +
                "('Rača Priboj')," +
                "('Rača Rača')," +
                "('Rača Đakovica')," +
                "('Račak Štimlje')," +
                "('Rašanac Petrova na Mlavi')," +
                "('Raševica Paraćin')," +
                "('Rašince Štimlje')," +
                "('Rašić Peć')," +
                "('Rašica Blace')," +
                "('Raška Raška')," +
                "('Rašković Knić')," +
                "('Raškoviće Sjenica')," +
                "('Raškoc Đakovica')," +
                "('Raštane Suva Reka')," +
                "('Rvati Beograd –brenovac')," +
                "('Rvati Raška')," +
                "('Rvatska Leposavić')," +
                "('Rgaje Prokuplje')," +
                "('Rgotina Zaječar')," +
                "('Rgošte Knjaževac')," +
                "('Rdovo Vladičin Han')," +
                "('Rđavica Surdulica')," +
                "('Rebelj Valjevo')," +
                "('Revuće Podujevo')," +
                "('Režance Kačanik')," +
                "('Reževiće Tutin')," +
                "('Rezala Zubin Potok')," +
                "('Rezala Srbica')," +
                "('Reka Kladovo')," +
                "('Reka Kraljevo')," +
                "('Reka Kačanik')," +
                "('Reka Kosovska Mitrovica')," +
                "('Rekovac Rekovac')," +
                "('Reljan Preševo')," +
                "('Reljinac Prokuplje')," +
                "('Reljinciornji Milanovac')," +
                "('Renovac Klina')," +
                "('Rence Prizren')," +
                "('Repa Podujevo')," +
                "('Repince Vladičin Han')," +
                "('Repište Vladičin Han')," +
                "('Repušnica Knjaževac')," +
                "('Resavica Despotovac')," +
                "('Resavica (selo) Despotovac')," +
                "('Resen Bosilegrad')," +
                "('Resinac Prokuplje')," +
                "('Resnik Babušnica')," +
                "('Resnik Kragujevac')," +
                "('Resnik Sokobanja')," +
                "('Resnik Vučitrn')," +
                "('Resnik Klina')," +
                "('Restelicaora')," +
                "('Retimljerahovac')," +
                "('Retkocer Medveđa')," +
                "('Rečane Prizren')," +
                "('Rečane Suva Reka')," +
                "('Rečica Bojnik')," +
                "('Rečica Žitorađa')," +
                "('Rečica Kladovo')," +
                "('Rečica Požarevac')," +
                "('Rečica Podujevo')," +
                "('Rečice Požega')," +
                "('Rečka Negotin')," +
                "('Ržana Kosovska Mitrovica')," +
                "('Ržanica Aleksandrovac')," +
                "('Rznić Dečani')," +
                "('Ribare Žagubica')," +
                "('Ribare Kruševac')," +
                "('Ribare Jagodina')," +
                "('Ribare Svrljig')," +
                "('Ribari Brus')," +
                "('Ribari Šabac')," +
                "('Ribariće Tutin')," +
                "('Ribarice Loznica')," +
                "('Ribarska Banja Kruševac')," +
                "('Ribarci Bosilegrad')," +
                "('Ribaševina Užice')," +
                "('Ribince Vranje')," +
                "('Ribnik Jagodina')," +
                "('Ribnik Vitina')," +
                "('Ribnica Kraljevo')," +
                "('Rivica Irig')," +
                "('Riđage Čačak')," +
                "('Riđake Vladimirci')," +
                "('Riđevštica Trstenik')," +
                "('Riđica Sombor')," +
                "('Rikačevo Bosilegrad')," +
                "('Riljac Trstenik')," +
                "('Rimanište Priština')," +
                "('Ripaj Madanaj Đakovica')," +
                "('Ripanj Beograd – Voždovac')," +
                "('Ristovac Vranje')," +
                "('Ritiševo Vršac')," +
                "('Ritopek Beograd –rocka')," +
                "('Ritošići Priboj')," +
                "('Rlica Kruševac')," +
                "('Roanda Svilajnac')," +
                "('Robaje Mionica')," +
                "('Robovac Kosovska Kamenica')," +
                "('Rovine Ivanjica')," +
                "('Rovni Valjevo')," +
                "('Rogavčina Aleksandrovac')," +
                "('Rogača Beograd – Sopot')," +
                "('Rogača Lučani')," +
                "('Rogačica Bajina Bašta')," +
                "('Rogačica Kosovska Kamenica')," +
                "('Roge Požega')," +
                "('Rogljevo Negotin')," +
                "('Rogovo Đakovica')," +
                "('Rogojevac Kragujevac')," +
                "('Rodelj Leposavić')," +
                "('Rožanstvo Čajetina')," +
                "('Rožanci Beograd – Barajevo')," +
                "('Roždace Vranje')," +
                "('Rožina Merošina')," +
                "('Rokci Aleksandrovac')," +
                "('Rokci Ivanjica')," +
                "('Romaja Prizren')," +
                "('Romune Peć')," +
                "('Ropica Vučitrn')," +
                "('Ropočevo Beograd – Sopot')," +
                "('Rosići Kosjerić')," +
                "('Rosica Kruševac')," +
                "('Rosomač Pirot')," +
                "('Rosulje Peć')," +
                "('Roćevac Svilajnac')," +
                "('Roćevići Kraljevo')," +
                "('Rošci Čačak')," +
                "('Rsavci Vrnjačka Banja')," +
                "('Rsovac Aleksinac')," +
                "('Rsovci Pirot')," +
                "('Rtanj Boljevac')," +
                "('Rtari Lučani')," +
                "('Rti Lučani')," +
                "('Rtkovo Kladovo')," +
                "('Rubribreza Lajkovac')," +
                "('Ruda Bukva Kosjerić')," +
                "('Rudare Kuršumlija')," +
                "('Rudare Leskovac')," +
                "('Rudenice Aleksandrovac')," +
                "('Rudine Čajetina')," +
                "('Rudine Zvečan')," +
                "('Rudinje Pirot')," +
                "('Rudice Klina')," +
                "('Rudnalava Majdanpek')," +
                "('Rudnikornji Milanovac')," +
                "('Rudnik Srbica')," +
                "('Rudnik Kosovobilić')," +
                "('Rudnica Raška')," +
                "('Rudnica Tutin')," +
                "('Rudno Kraljevo')," +
                "('Rudnjak Kraljevo')," +
                "('Rudovci Beograd – Lazarevac')," +
                "('Ruđa Tutin')," +
                "('Ruđinci Vrnjačka Banja')," +
                "('Ružić Vladičin Han')," +
                "('Rujevac Ljubovija')," +
                "('Rujevica Sokobanja')," +
                "('Rujišnik Trstenik')," +
                "('Rujište Boljevac')," +
                "('Rujište Ražanj')," +
                "('Rujište Zubin Potok')," +
                "('Rujkovac Medveđa')," +
                "('Rujnik Niš – Crveni krst')," +
                "('Ruklada Ub')," +
                "('Ruma Ruma')," +
                "('Rumenka Novi Sad')," +
                "('Rumska Šabac')," +
                "('Runjani Loznica')," +
                "('Runjevo Kačanik')," +
                "('Rupeljevo Požega')," +
                "('Ruplje Crna Trava')," +
                "('Rusinovce Lipljan')");
                  migrationBuilder.Sql(
                "insert into Mesta(NazivMesta) values " +
                "('Ruski Krstur Kula')," +
                "('Rusko Selo Kikinda')," +
                "('Rusna Doljevac')," +
                "('Rusce Bujanovac')," +
                "('Rusce Vranje')," +
                "('Rutevac Aleksinac')," +
                "('Rutoši Nova Varoš')," +
                "('Ruhot Peć')," +
                "('Rucka Beograd – Čukarica')," +
                "('Rucmance Leposavić')," +
                "('Ručićiornji Milanovac')," +
                "('Rušanj Beograd – Čukarica')," +
                "('Savinac Bojnik')," +
                "('Savinac Boljevac')," +
                "('Savino Selo Vrbas')," +
                "('Savković Ljubovija')," +
                "('Savovo Kraljevo')," +
                "('Savrovo Suva Reka')," +
                "('Sagonjevo Kuršumlija')," +
                "('Sazlija Uroševac')," +
                "('Sainovina Čajetina')," +
                "('Sajan Kikinda')," +
                "('Sakar Mali Zvornik')," +
                "('Sakulepovo')," +
                "('Sakulja Beograd – Lazarevac')," +
                "('Salakovac Malo Crniće')," +
                "('Salaš Zaječar')," +
                "('Salaš Noćajski Sremska Mitrovica')," +
                "('Salaš Crnobarski Bogatić')," +
                "('Samaila Kraljevo')," +
                "('Samarinovac Žitorađa')," +
                "('Samarinovac Negotin')," +
                "('Samarnica Vlasotince')," +
                "('Samodraža Suva Reka')," +
                "('Samodreža Vučitrn')," +
                "('Samokovo Kuršumlija')," +
                "('Samoljica Bujanovac')," +
                "('Samoš Kovačica')," +
                "('Sanad Čoka')," +
                "('Sandalj Valjevo')," +
                "('Sanković Mionica')," +
                "('Sanovacrahovac')," +
                "('Saparnjilane')," +
                "('Saranovo Rača')," +
                "('Saraorci Smederevo')," +
                "('Sarošrahovac')," +
                "('Sastav Reka Crna Trava')," +
                "('Saš Tutin')," +
                "('Sveta Petka Bujanovac')," +
                "('Svetićevo Bačka Topola')," +
                "('Svetlić Topola')," +
                "('Svetlje Podujevo')," +
                "('Svetozar Miletić Sombor')," +
                "('Sveštica Ivanjica')," +
                "('Svilajnac Svilajnac')," +
                "('Svileuva Koceljeva')," +
                "('Svilojevo Apatin')," +
                "('Sviloš Beočin')," +
                "('Svinjare Kosovska Mitrovica')," +
                "('Svinjarevo Žabari')," +
                "('Svinjarica Lebane')," +
                "('Svinjište Kuršumlija')," +
                "('Svinjište Preševo')," +
                "('Svirce Leskovac')," +
                "('Svirce Medveđa')," +
                "('Svirce Kosovska Kamenica')," +
                "('Svođe Vlasotince')," +
                "('Svojnovo Paraćin')," +
                "('Svračkovo Požega')," +
                "('Svračkovciornji Milanovac')," +
                "('Svrke Peć')," +
                "('Svrljig Svrljig')," +
                "('Svrljiška Topla Knjaževac')," +
                "('Svrhe Klina')," +
                "('Svrčina Uroševac')," +
                "('Sebevranje Vranjska Banja')," +
                "('Sebečevac Kruševac')," +
                "('Sebečevo Novi Pazar')," +
                "('Sebimilje Raška')," +
                "('Sebrat Bujanovac')," +
                "('Severni Kočarnik Tutin')," +
                "('Severovo Arilje')," +
                "('Sevojno Užice')," +
                "('Sevce Štrpce')," +
                "('Sedlare Svilajnac')," +
                "('Sedlare Kosovska Kamenica')," +
                "('Sedlare Lipljan')," +
                "('Sedlari Valjevo')," +
                "('Sedobro Prijepolje')," +
                "('Sezemče Kruševac')," +
                "('Sejace Bujanovac')," +
                "('Sekirača Kuršumlija')," +
                "('Sekicol Lebane')," +
                "('Sekurič Rekovac')," +
                "('Selanac Ljubovija')," +
                "('Selačka Zaječar')," +
                "('Selevac Smederevska Palanka')," +
                "('Selenča Bač')," +
                "('Seleuš Alibunar')," +
                "('Selište Žagubica')," +
                "('Selište Kuršumlija')," +
                "('Selište Prokuplje')," +
                "('Selište Trstenik')," +
                "('Selo Kostolac Kostolac')," +
                "('Selova Kuršumlija')," +
                "('Selogražde Suva Reka')," +
                "('Seljane Prijepolje')," +
                "('Seljance Kosovska Mitrovica')," +
                "('Seljašnica Prijepolje')," +
                "('Semanje Kačanik')," +
                "('Semegnjevo Čajetina')," +
                "('Semedražornji Milanovac')," +
                "('Semeteš Raška')," +
                "('Semetište Suva Reka')," +
                "('Semčeadžin Han')," +
                "('Sena Kučevo')," +
                "('Senaja Beograd – Mladenovac')," +
                "('Sendo Zvečan')," +
                "('Senik Suva Reka')," +
                "('Seništa Nova Varoš')," +
                "('Senokos Dimitrovgrad')," +
                "('Senta Senta')," +
                "('Senje Ćuprija')," +
                "('Senjski Rudnik Despotovac')," +
                "('Seone Smederevo')," +
                "('Seoce Kuršumlija')," +
                "('Seoce Leposavić')," +
                "('Sepci Rača')," +
                "('Sesalac Sokobanja')," +
                "('Sefer Preševo')," +
                "('Sefkerinpovo')," +
                "('Seča Reka Kosjerić')," +
                "('Sečanica Niš – Crveni krst')," +
                "('Sečanj Sečanj')," +
                "('Sečište Kačanik')," +
                "('Sibač Pećinci')," +
                "('Sibnica Beograd – Sopot')," +
                "('Sibnica Blace')," +
                "('Sibnica Žabari')," +
                "('Sibnica Kraljevo')," +
                "('Sibnica Rekovac')," +
                "('Sibovacbilić')," +
                "('Sivac Kula')," +
                "('Sivčina Ivanjica')," +
                "('Siga Peć')," +
                "('Sige Žagubica')," +
                "('Siget Novi Kneževac')," +
                "('Sijarina Medveđa')," +
                "('Sijarinska Banja Medveđa')," +
                "('Sijerač Bajina Bašta')," +
                "('Sikirica Paraćin')," +
                "('Sikirje Vranje')," +
                "('Sikole Negotin')," +
                "('Silbaš Bačka Palanka')," +
                "('Siljevica Rekovac')," +
                "('Siljevica Podujevo')," +
                "('Simino Brdo Loznica')," +
                "('Simićevo Žabari')," +
                "('Sinaje Istok')," +
                "('Sinošević Šabac')," +
                "('Sinoševićiornji Milanovac')," +
                "('Sinjalava Pirot')," +
                "('Sinjac Bela Palanka')," +
                "('Sinji Vir Paraćin')," +
                "('Siokovac Jagodina')," +
                "('Sipić Rača')," +
                "('Sirakovo Velikoradište')," +
                "('Sirdijasečina')," +
                "('Sirig Temerin')," +
                "('Sirogojno Čajetina')," +
                "('Sirča Kraljevo')," +
                "('Sisevac Paraćin')," +
                "('Sitarice Valjevo')," +
                "('Sitniče Novi Pazar')," +
                "('Sićevo Niš – Niška Banja')," +
                "('Sićevo Klina')," +
                "('Sićevo Priština')," +
                "('Sjeverin Priboj')," +
                "('Sjenica Sjenica')," +
                "('Skadarsečina')," +
                "('Skakavci Kosjerić')," +
                "('Skela Beograd –brenovac')," +
                "('Skivjane Đakovica')," +
                "('Skobalj Lajkovac')," +
                "('Skobalj Smederevo')," +
                "('Skokuće Prijepolje')," +
                "('Skorenovac Kovin')," +
                "('Skorica Ražanj')," +
                "('Skorobište Prizren')," +
                "('Skorošnik Klina')," +
                "('Skočna Vučitrn')," +
                "('Skradnik Sjenica')," +
                "('Skrađani Šabac')," +
                "('Skrapež Vlasotince')," +
                "('Skrvenica Dimitrovgrad')," +
                "('Skržuti Užice')," +
                "('Skrobnica Knjaževac')," +
                "('Skrovna Vučitrn')," +
                "('Skukovo Novi Pazar')," +
                "('Skulanevo Lipljan')," +
                "('Skupljen Vladimirci')," +
                "('Slavinja Pirot')," +
                "('Slavkovica Ljig')," +
                "('Slavnik Bojnik')," +
                "('Slavujevac Preševo')," +
                "('Slavujevce Leskovac')," +
                "('Sladaja Despotovac')," +
                "('Sladinacolubac')," +
                "('Slakovce Vučitrn')," +
                "('Slankamenački Vinogradi Inđija')," +
                "('Slanci Beograd – Palilula')," +
                "('Slapužane Suva Reka')," +
                "('Slatina Beograd – Sopot')," +
                "('Slatina Bor')," +
                "('Slatina Knjaževac')," +
                "('Slatina Kruševac')," +
                "('Slatina Leskovac')," +
                "('Slatina Loznica')," +
                "('Slatina Negotin')," +
                "('Slatina Novi Pazar')," +
                "('Slatina Prijepolje')," +
                "('Slatina Jagodina')," +
                "('Slatina Ub')," +
                "('Slatina Čačak')," +
                "('Slatina Šabac')," +
                "('Slatina Vučitrn')," +
                "('Slatina Kačanik')," +
                "('Slatina Leposavić')," +
                "('Slatina Podujevo')," +
                "('Slepčević Šabac')," +
                "('Slivje Svrljig')," +
                "('Slivnica Dimitrovgrad')," +
                "('Slivnica Vranjska Banja')," +
                "('Slivovo Priština')," +
                "('Slivovo Uroševac')," +
                "('Slišane Lebane')," +
                "('Slovac Lajkovac')," +
                "('Slovinje Lipljan')," +
                "('Slubicanjilane')," +
                "('Slup Dečani')," +
                "('Smać Đakovica')," +
                "('Smać Prizren')," +
                "('Smederevo Smederevo')," +
                "('Smederevska Palanka Smederevska Palanka')," +
                "('Smedovac Negotin')," +
                "('Smilov Laz Novi Pazar')," +
                "('Smilovac Ražanj')," +
                "('Smilovci Dimitrovgrad')," +
                "('Smiljevac Ivanjica')," +
                "('Smiljević Vranje')," +
                "('Smira Vitina')," +
                "('Smoluća Tutin')," +
                "('Smoluša Lipljan')," +
                "('Smoljinac Malo Crniće')," +
                "('Smonica Đakovica')," +
                "('Smrdan Leskovac')," +
                "('Smrdan Prokuplje')," +
                "('Smrekovnica Vučitrn')," +
                "('Snegotinolubac')," +
                "('Sovač Valjevo')," +
                "('Sovljak Bogatić')," +
                "('Sovljak Ub')," +
                "('Soderce Vranje')," +
                "('Sojevo Uroševac')," +
                "('Sokobanja Sokobanja')," +
                "('Sokolac Ljubovija')," +
                "('Sokolići Čačak')," +
                "('Sokolovo Beograd – Lazarevac')," +
                "('Solačka Sena Vladičin Han')," +
                "('Solotuša Bajina Bašta')," +
                "('Sombor Sombor')," +
                "('Sonta Apatin')," +
                "('Sopina Suva Reka')," +
                "('Sopnićrahovac')," +
                "('Sopot Beograd – Sopot')," +
                "('Sopot Pirot')," +
                "('Sopot Đakovica')," +
                "('Sopotnicaadžin Han')," +
                "('Sopotnica Prijepolje')," +
                "('Sopotnica Kačanik')," +
                "('Sot Šid')," +
                "('Sofalija Priština')," +
                "('Softović Uroševac')," +
                "('Sočanica Leposavić')," +
                "('Sočica Vršac')," +
                "('Sočice Priboj')," +
                "('Spance Kuršumlija')," +
                "('Spančevac Bujanovac')," +
                "('Sponce Medveđa')," +
                "('Srbica Srbica')," +
                "('Srbobran Srbobran')," +
                "('Srbobran Istok')," +
                "('Srbovac Zvečan')," +
                "('Srbovo Negotin')," +
                "('Srednja Dobrinja Požega')," +
                "('Srednja Klina Srbica')," +
                "('Srednja Tušimlja Novi Pazar')," +
                "('Srednjevo Velikoradište')," +
                "('Srednji Bučumet Medveđa')," +
                "('Srednji Del Vranje')," +
                "('Srednji Salaš Bačka Topola')," +
                "('Srednji Statovac Prokuplje')," +
                "('Sredor Vlasotince')," +
                "('Sredska Prizren')," +
                "('Srezovac Aleksinac')," +
                "('Srezojevciornji Milanovac')," +
                "('Sremska Kamenica Petrovaradin')," +
                "('Sremska Mitrovica Sremska Mitrovica')," +
                "('Sremska Rača Sremska Mitrovica')," +
                "('Sremski Karlovci Sremski Karlovci')," +
                "('Sremski Mihaljevci Pećinci')," +
                "('Sremčica Beograd – Čukarica')," +
                "('Srećkovac Pirot')," +
                "('Srndalje Kruševac')," +
                "('Srneći Dol Vladičin Han')," +
                "('Srnje Kruševac')," +
                "('Srpska Kuća Bujanovac')," +
                "('Srpska Crnja Nova Crnja')," +
                "('Srpski Babuš Uroševac')," +
                "('Srpski Itebej Žitište')," +
                "('Srpski Krstur Novi Kneževac')," +
                "('Srpski Miletićdžaci')," +
                "('Srpce Kučevo')," +
                "('Stave Krupanj')," +
                "('Stagovo Kačanik')," +
                "('Stajićevo Zrenjanin')," +
                "('Stajkovce Vlasotince')," +
                "('Stajkovce Surdulica')," +
                "('Stalać Ćićevac')," +
                "('Stamnica Petrova na Mlavi')," +
                "('Stanevce Preševo')," +
                "('Stanina Reka Valjevo')," +
                "('Staničenje Pirot')," +
                "('Stanišinci Vrnjačka Banja')," +
                "('Stanišić Sombor')," +
                "('Stanišornjilane')," +
                "('Stankovcelogovac')," +
                "('Stanuloviće Brus')," +
                "('Stance Vranje')," +
                "('Stanci Aleksinac')," +
                "('Stanci Kruševac')," +
                "('Stanča Kraljevo')," +
                "('Stančićnjilane')," +
                "('Stančići Čačak')," +
                "('Stanjevo Aleksandrovac')," +
                "('Stanjinac Knjaževac')," +
                "('Stapar Valjevo')," +
                "('Stapar Sombor')," +
                "('Stapari Užice')," +
                "('Stara Banja Medveđa')," +
                "('Stara Bingula Sremska Mitrovica')," +
                "('Stara Božurna Žitorađa')," +
                "('Stara Brezovica Vranje')," +
                "('Stara Vučina Suva Reka')," +
                "('Stara Moravica Bačka Topola')," +
                "('Stara Pazova Stara Pazova')," +
                "('Starac Bujanovac')," +
                "('Stari Banovci Stara Pazova')," +
                "('Stari Bračin Ražanj')," +
                "('Starilog Vranjska Banja')," +
                "('Stari Đurovac Prokuplje')," +
                "('Stari Žednik Subotica')," +
                "('Stari Kačanik Kačanik')," +
                "('Stari Ledinci Petrovaradin')," +
                "('Stari Lec Plandište')," +
                "('Stari Miraš Uroševac')," +
                "('Stari Slankamen Inđija')," +
                "('Stari Trg (rud.naselje) Kosovska Mitrovica')," +
                "('Stari Trg (selo) Kosovska Mitrovica')," +
                "('Stari Trstenik Trstenik')," +
                "('Staroracko Lipljan')," +
                "('Staro Korito Knjaževac')," +
                "('Staro Lanište Jagodina')," +
                "('Staro Momčilovo Žitorađa')," +
                "('Staro Rujce Lipljan')," +
                "('Staro Selo Velika Plana')," +
                "('Staro Selo Prokuplje')," +
                "('Staro Selo Jagodina')," +
                "('Staro Selo Uroševac')," +
                "('Staro Čikatovologovac')," +
                "('Starodvorane Istok')," +
                "('Starci Aleksandrovac')," +
                "('Starčeviće Tutin')," +
                "('Starčevo Petrova na Mlavi')," +
                "('Starčevo Pančevo')," +
                "('Stejanovci Ruma')," +
                "('Stenjevac Despotovac')," +
                "('Stepanovićevo Novi Sad')," +
                "('Stepanje Lajkovac')," +
                "('Stepojevac Beograd – Lazarevac')," +
                "('Sterijino Ada')," +
                "('Stogazovac Knjaževac')," +
                "('Stojačak Smederevska Palanka')," +
                "('Stojići Kosjerić')," +
                "('Stojković Uroševac')," +
                "('Stojnik Aranđelovac')," +
                "('Stojnik Beograd – Sopot')," +
                "('Stol Babušnica')," +
                "('Stopanja Trstenik')," +
                "('Stragari Kragujevac')," +
                "('Stragari Trstenik')," +
                "('Stradovo Novi Pazar')," +
                "('Straža Loznica')," +
                "('Straža Vršac')," +
                "('Stražanjilane')," +
                "('Straža Kačanik')," +
                "('Strajiniće Sjenica')," +
                "('Strana Kosovska Mitrovica')," +
                "('Stranjevo Vlasotince')," +
                "('Strezimirovci Surdulica')," +
                "('Strezovce Preševo')," +
                "('Strezovce Kosovska Kamenica')," +
                "('Strelac Babušnica')," +
                "('Strelica Kosovska Kamenica')," +
                "('Strešak Vranje')," +
                "('Striža Paraćin')," +
                "('Strižilo Jagodina')," +
                "('Strmac Priboj')," +
                "('Strmac Užice')," +
                "('Strmenica Aleksandrovac')," +
                "('Strmnaora Valjevo')," +
                "('Strmovo Bajina Bašta')," +
                "('Strmovo Beograd – Lazarevac')," +
                "('Strmovo Lajkovac')," +
                "('Strmosten Despotovac')," +
                "('Strovce Vučitrn')," +
                "('Strojinci Brus')," +
                "('Strojkovce Leskovac')," +
                "('Stropsko Vranje')," +
                "('Struganik Mionica')," +
                "('Struganica Vranje')," +
                "('Stružje Prizren')," +
                "('Strumce Tutin')," +
                "('Stubal Aleksandrovac')," +
                "('Stubal Blace')," +
                "('Stubal Vladičin Han')," +
                "('Stubal Kraljevo')," +
                "('Stubica Beograd – Lazarevac')," +
                "('Stubica Paraćin')," +
                "('Stubla Bojnik')," +
                "('Stubla Medveđa')," +
                "('Stubla Đakovica')," +
                "('Stublenica Ub')," +
                "('Stublina Aleksinac')," +
                "('Stublinanjilane')," +
                "('Stubline Beograd –brenovac')," +
                "('Stublica Trstenik')," +
                "('Stublo Čajetina')," +
                "('Stubo Valjevo')," +
                "('Studena Babušnica')," +
                "('Studena Vranje')," +
                "('Studenac Žitorađa')," +
                "('Studenica Istok')," +
                "('Studenčane Suva Reka')," +
                "('Stup Sjenica')," +
                "('Stup Klina')," +
                "('Stupnica Leskovac')," +
                "('Stupnica Loznica')," +
                "('Stupčevići Arilje')," +
                "('Subjel Kosjerić')," +
                "('Subotinac Aleksinac')," +
                "('Subotica Aleksandrovac')," +
                "('Subotica Koceljeva')," +
                "('Subotica Svilajnac')," +
                "('Subotica Subotica')," +
                "('Subotište Pećinci')," +
                "('Suva Morava Vladičin Han')," +
                "('Suva Reka Suva Reka')," +
                "('Suvaja Blace')," +
                "('Suvaja Varvarin')," +
                "('Suvaja Kruševac')," +
                "('Suvi Do Blace')," +
                "('Suvi Do Žagubica')," +
                "('Suvi Do Tutin')," +
                "('Suvi Do Niš – Palilula')," +
                "('Suvi Do Lipljan')," +
                "('Suvi Dol Vranje')," +
                "('Suvi Lukavac Istok')," +
                "('Suvorlo Istok')," +
                "('Suvorlo Srbica')," +
                "('Suvo Selo Vladimirci')," +
                "('Suvodanje Valjevo')," +
                "('Suvodol Smederevo')," +
                "('Suvojnica Surdulica')," +
                "('Sugubine Sjenica')," +
                "('Sudimlja Brus')," +
                "('Sudsko Selo Novi Pazar')," +
                "('Sukovo Pirot')," +
                "('Sumorovac Knić')," +
                "('Sumrakovac Boljevac')," +
                "('Supnje Raška')," +
                "('Supovac Niš – Crveni krst')," +
                "('Supska Ćuprija')," +
                "('Suračevo Babušnica')," +
                "('Surduk Stara Pazova')," +
                "('Surdul Vranje')," +
                "('Surdula Podujevo')," +
                "('Surdulica Surdulica')," +
                "('Surkiš Podujevo')," +
                "('Surlica Trgovište')," +
                "('Surčin Beograd – Surčin')," +
                "('Susek Beočin')," +
                "('Sutjeska Sečanj')," +
                "('Suharno Bujanovac')," +
                "('Suhi Dol Surdulica')," +
                "('Suševlje Leskovac')," +
                "('Sušiće Štrpce')," +
                "('Sušica Valjevo')," +
                "('Sušica Kruševac')," +
                "('Sušica Sjenica')," +
                "('Sušica Istok')," +
                "('Sušica Priština')," +
                "('Tabakovac Zaječar')," +
                "('Tabanovac Petrova na Mlavi')," +
                "('Tabanović Mionica')," +
                "('Tabanović Šabac')," +
                "('Tabanovići Požega')," +
                "('Tavnik Kraljevo')," +
                "('Tadenje Kraljevo')," +
                "('Takovoornji Milanovac')," +
                "('Takovo Ub')," +
                "('Tamnič Negotin')," +
                "('Tamnjanica Bela Palanka')," +
                "('Tanda Bor')," +
                "('Tankosić Uroševac')," +
                "('Taor Valjevo')," +
                "('Taradža Vučitrn')," +
                "('Taraš Zrenjanin')," +
                "('Taskovićiadžin Han')," +
                "('Tatrasnica Knjaževac')," +
                "('Tačevac Kuršumlija')," +
                "('Taševo Prijepolje')," +
                "('Tvrdići Požega')," +
                "('Tvrdojevac Ub')," +
                "('Tvrđan Leposavić')," +
                "('Tegovište Vladičin Han')," +
                "('Tegošnica Vlasotince')," +
                "('Tekeriš Loznica')," +
                "('Tekija Kladovo')," +
                "('Tekija Kruševac')," +
                "('Tekija Paraćin')," +
                "('Telečka Sombor')," +
                "('Telovac Bela Palanka')," +
                "('Temerin Temerin')," +
                "('Temska Pirot')," +
                "('Teneš Do Priština')," +
                "('Tenkovo Novi Pazar')," +
                "('Teočinornji Milanovac')," +
                "('Tepeče Kraljevo')," +
                "('Tesovište Vranje')," +
                "('Teća Lipljan')," +
                "('Tečić Rekovac')," +
                "('Tešica Aleksinac')," +
                "('Tibužde Vranje')," +
                "('Tijanje Lučani')," +
                "('Tijovac Kuršumlija')," +
                "('Tijovac Svrljig')," +
                "('Tikva Nova Varoš')," +
                "('Tiodže Raška')," +
                "('Tirince Kosovska Kamenica')," +
                "('Tisovica Nova Varoš')," +
                "('Titel Titel')," +
                "('Tićevac Žabari')," +
                "('Tica Srbica')," +
                "('Tmava Kuršumlija')," +
                "('Toba Nova Crnja')," +
                "('Tobolac Trstenik')," +
                "('Tovariševo Bačka Palanka')," +
                "('Tovrljane Prokuplje')," +
                "('Togočevce Lebane')," +
                "('Todorin Do Mionica')," +
                "('Todorovce Leskovac')," +
                "('Tolisavac Krupanj')," +
                "('Tolić Mionica')," +
                "('Tolišnica Kraljevo')," +
                "('Toljevac Varvarin')," +
                "('Tomance Istok')," +
                "('Tomance Kosovska Kamenica')," +
                "('Tomanj Krupanj')," +
                "('Tomaševac Zrenjanin')," +
                "('Tometino Polje Požega')," +
                "('Tomislavci Bačka Topola')," +
                "('Topilo Štimlje')," +
                "('Topla Bor')," +
                "('Toplac Vranjska Banja')," +
                "('Topli Do Pirot')," +
                "('Topli Do Surdulica')," +
                "('Topli Dol Surdulica')," +
                "('Topličane Lipljan')," +
                "('Topličane Suva Reka')," +
                "('Topola Jagodina')," +
                "('Topola (varošica) Topola')," +
                "('Topola (selo) Topola')," +
                "('Topolnica Majdanpek')," +
                "('Topolovnik Velikoradište')," +
                "('Toponica Bela Palanka')," +
                "('Toponicaadžin Han')," +
                "('Toponica Žitorađa')," +
                "('Toponica Knić')," +
                "('Toponica Malo Crniće')," +
                "('Toponica Kosovska Kamenica')," +
                "('Torak Žitište')," +
                "('Torda Žitište')," +
                "('Torina Lipljan')," +
                "('Tornik Ljubovija')," +
                "('Tornjoš Senta')," +
                "('Totovo Selo Kanjiža')," +
                "('Točilovo Tutin')," +
                "('Trakanić Đakovica')," +
                "('Trbovce Lipljan')," +
                "('Trbosilje Loznica')," +
                "('Trbunje Blace')," +
                "('Trbuhovac Istok')," +
                "('Trbušani Čačak')," +
                "('Trbušac Vladimirci')," +
                "('Trbušnica Beograd – Lazarevac')," +
                "('Trbušnica Loznica')," +
                "('Trgovište Knjaževac')," +
                "('Trgovište Kraljevo')," +
                "('Trgovište Sokobanja')," +
                "('Trgovište Trgovište')," +
                "('Trdevaclogovac')," +
                "('Trebinje Kuršumlija')," +
                "('Trebiće Leposavić')," +
                "('Trebović Peć')," +
                "('Trebotin Kruševac')," +
                "('Trejak Bujanovac')," +
                "('Trepetinca Prizren')," +
                "('Trećak Kuršumlija')," +
                "('Trešnjevak Kragujevac')," +
                "('Trešnjevac Kanjiža')," +
                "('Trešnjevica Arilje')," +
                "('Trešnjevica Paraćin')," +
                "('Trešnjevica Sjenica')," +
                "('Tržac Aleksandrovac')," +
                "('Tribrode Velikoradište')," +
                "('Trijebine Sjenica')," +
                "('Trikose Leposavić')," +
                "('Tripkova Čajetina')," +
                "('Trlabuć Vučitrn')," +
                "('Trlić Ub')," +
                "('Trmbas Kragujevac')," +
                "('Trmka Kuršumlija')," +
                "('Trmčare Kruševac')," +
                "('Trn Kuršumlija')," +
                "('Trn Uroševac')," +
                "('Trnava Novi Pazar')," +
                "('Trnava Preševo')," +
                "('Trnava Raška')," +
                "('Trnava Jagodina')," +
                "('Trnava Užice')," +
                "('Trnava Čajetina')," +
                "('Trnava Čačak')," +
                "('Trnava Podujevo')," +
                "('Trnavac Zaječar')," +
                "('Trnavica Podujevo')," +
                "('Trnavce Srbica')," +
                "('Trnavci Aleksandrovac')," +
                "('Trnićevce Novo Brdo')," +
                "('Trnovac Knjaževac')," +
                "('Trnovi Laz Prokuplje')," +
                "('Trnovče Velika Plana')," +
                "('Trnovče Petrova na Mlavi')," +
                "('Trnskidorovci Dimitrovgrad')," +
                "('Trnjana Pirot')," +
                "('Trnjane Aleksinac')," +
                "('Trnjane Negotin')," +
                "('Trnjane Požarevac')," +
                "('Trnjaci Ub')," +
                "('Trnje Suva Reka')," +
                "('Troponje Svilajnac')," +
                "('Troskač Surdulica')," +
                "('Trpeza Vitina')," +
                "('Trpezalogovac')," +
                "('Trpeze Kuršumlija')," +
                "('Trska Rača')," +
                "('Trstena Vranje')," +
                "('Trstena Kosovska Kamenica')," +
                "('Trstena Kosovska Mitrovica')," +
                "('Trstenik Trstenik')," +
                "('Trstenik Vitina')," +
                "('Trsteniklogovac')," +
                "('Trstenik Peć')," +
                "('Trstenica Beograd –brenovac')," +
                "('Trubarevac Sokobanja')," +
                "('Trubarevo Ćićevac')," +
                "('Trudeljornji Milanovac')," +
                "('Trudna Priština')," +
                "('Trudovo Nova Varoš')," +
                "('Trupale Niš – Crveni krst')," +
                "('Trućevac Despotovac')," +
                "('Tršanovci Brus')," +
                "('Tršić Loznica')," +
                "('Tubići Kosjerić')," +
                "('Tubravić Valjevo')," +
                "('Tuđevce Kosovska Kamenica')," +
                "('Tuđinsečina')," +
                "('Tuzinje Sjenica')," +
                "('Tulare Medveđa')," +
                "('Tulare Prokuplje')," +
                "('Tulari Ub')," +
                "('Tulež Aranđelovac')," +
                "('Tuleš Aleksandrovac')," +
                "('Tulovo Leskovac')," +
                "('Tumba Vranje')," +
                "('Tumičina Suva Reka')," +
                "('Tunovo Novi Pazar')," +
                "('Tupale Medveđa')," +
                "('Tupalovce Leskovac')," +
                "('Tupanci Valjevo')," +
                "('Tupec Prizren')," +
                "('Turekovac Leskovac')," +
                "('Turija Bujanovac')," +
                "('Turija Kučevo')," +
                "('Turija Srbobran')," +
                "('Turićevac Srbica')," +
                "('Turica Lučani')," +
                "('Turjakrahovac')," +
                "('Turjak Peć')," +
                "('Turjane Bojnik')," +
                "('Turučica Podujevo')," +
                "('Tutin Tutin')," +
                "('Tutiće Sjenica')," +
                "('Tučep Istok')," +
                "('Tučkovo Požega')," +
                "('Tušilje Srbica')," +
                "('Tušiće Zubin Potok')," +
                "('Ćelijeadžin Han')," +
                "('Ćelije Kruševac')," +
                "('Ćelije Lajkovac')," +
                "('Ćenovac Lebane')," +
                "('Ćerim Đakovica')," +
                "('Ćešanoviće Zubin Potok')," +
                "('Ćirez Srbica')," +
                "('Ćirikovac Požarevac')," +
                "('Ćirkoviće Leposavić')," +
                "('Ćićevac Ćićevac')," +
                "('Ćićina Aleksinac')," +
                "('Ćovdin Petrova na Mlavi')," +
                "('Ćukovac Bojnik')," +
                "('Ćukovac Vranje')," +
                "('Ćukovac Prokuplje')," +
                "('Ćukovine Koceljeva')," +
                "('Ćulije Tutin')," +
                "('Ćuprija Ćuprija')," +
                "('Ćurkovica Vranje')," +
                "('Ćurkovica Surdulica')," +
                "('Ćurlina Doljevac')," +
                "('Ćuška Peć')," +
                "('Ćuštica Knjaževac')," +
                "('Ub Ub')," +
                "('Uvac Sjenica')," +
                "('Ugao Sjenica')," +
                "('Ugljarenjilane')," +
                "('Ugljare Zubin Potok')," +
                "('Ugljare Kosovo Polje')," +
                "('Ugljarevac Kragujevac')," +
                "('Ugljarevo Trstenik')," +
                "('Ugrinovci Beograd – Zemun')," +
                "('Ugrinovciornji Milanovac')," +
                "('Udovice Smederevo')," +
                "('Užice Užice')," +
                "('Uzveće Bogatić')," +
                "('Uzdin Kovačica')," +
                "('Uzići Požega')," +
                "('Uzovnica Ljubovija')," +
                "('Uzovo Bujanovac')," +
                "('Ujz Đakovica')," +
                "('Ukča Istok')," +
                "('Ulije Leposavić')," +
                "('Uljma Vršac')," +
                "('Umka Beograd – Čukarica')," +
                "('Umčari Beograd –rocka')," +
                "('Urvič Vladičin Han')," +
                "('Urmanica Vranje')," +
                "('Urovica Negotin')," +
                "('Urovci Beograd –brenovac')," +
                "('Uroševac Uroševac')," +
                "('Ursule Rekovac')," +
                "('Ursule Sjenica')," +
                "('Usijeolubac')," +
                "('Utrine Ada')," +
                "('Ušak Sjenica')," +
                "('Uševce Vranje')," +
                "('Ušće Beograd –brenovac')," +
                "('Ušće Kraljevo')," +
                "('Farkaždin Zrenjanin')," +
                "('Feketić Mali Iđoš')," +
                "('Fijulj Sjenica')," +
                "('Filipovići Loznica')," +
                "('Filić Novi Kneževac')," +
                "('Firaja Đakovica')," +
                "('Firaja Štrpce')," +
                "('Firza Đakovica')," +
                "('Firićeja Kosovska Kamenica')," +
                "('Futog Novi Sad')," +
                "('Hajdukovo Subotica')," +
                "('Hajdučica Plandište')," +
                "('Halovo Zaječar')," +
                "('Hamidijabilić')," +
                "('Hadžovići Peć')," +
                "('Hercegovačkaoleša Priboj')," +
                "('Hercegovo Vučitrn')," +
                "('Hetin Žitište')," +
                "('Hisardžik Prijepolje')," +
                "('Horgoš Kanjiža')," +
                "('Hotkovo Novi Pazar')," +
                "('Hoča Zagradska Prizren')," +
                "('Hrta Prijepolje')," +
                "('Hrtica Podujevo')," +
                "('Hrtkovci Ruma')," +
                "('Huljaj Dečani')," +
                "('Hum Niš – Crveni krst')," +
                "('Cakanovac Preševo')," +
                "('Caparić Ljubovija')," +
                "('Caparce Prizren')," +
                "('Carevac Velikoradište')," +
                "('Carevce Kosovska Kamenica')," +
                "('Carinasečina')," +
                "('Caričina Sjenica')," +
                "('Cvetanovac Ljig')," +
                "('Cvetke Kraljevo')," +
                "('Cvetovac Beograd – Lazarevac')," +
                "('Cvetojevac Kragujevac')," +
                "('Cvetulja Krupanj')," +
                "('Cekavica Lebane')," +
                "('Celinarahovac')," +
                "('Ceranja Leposavić')," +
                "('Cerev Del Pirot')," +
                "('Cerevajka Preševo')," +
                "('Ceremošnja Kučevo')," +
                "('Cerje Bajina Bašta')," +
                "('Cerje Kraljevo')," +
                "('Cerje Niš – Pantelej')," +
                "('Cernica Varvarin')," +
                "('Cernicanjilane')," +
                "('Cerova Arilje')," +
                "('Cerovaornji Milanovac')," +
                "('Cerova Krupanj')," +
                "('Cerova Kruševac')," +
                "('Cerova Pirot')," +
                "('Cerovac Kragujevac')," +
                "('Cerovac Smederevska Palanka')," +
                "('Cerovac Šabac')," +
                "('Cerovik Klina')," +
                "('Cerovica Kučevo')," +
                "('Cerovica Sokobanja')," +
                "('Cerovo Ražanj')," +
                "('Cetanoviće Sjenica')," +
                "('Cecelija Vučitrn')," +
                "('Cikot Rekovac')," +
                "('Cikote Kosjerić')," +
                "('Cikote Loznica')," +
                "('Cokoviće Novi Pazar')," +
                "('Crvena Jabuka Babušnica')," +
                "('Crvena Jabuka Ub')," +
                "('Crvena Reka Bela Palanka')," +
                "('Crvena Crkva Bela Crkva')," +
                "('Crveni Leposavić')," +
                "('Crveni Breg Bela Palanka')," +
                "('Crveni Breg Leskovac')," +
                "('Crvenirad Trgovište')," +
                "('Crvenka Kula')," +
                "('Crvenčevo Pirot')," +
                "('Crvenje Knjaževac')," +
                "('Crvica Bajina Bašta')," +
                "('Crvsko Sjenica')," +
                "('Crepaja Kovačica')," +
                "('Crepulja Zubin Potok')," +
                "('Crkvena Vodicabilić')," +
                "('Crkvenac Svilajnac')," +
                "('Crkveni Toci Prijepolje')," +
                "('Crkvina Kruševac')," +
                "('Crkvine Beograd – Mladenovac')," +
                "('Crkvine Tutin')," +
                "('Crkvica Bojnik')," +
                "('Crkovnica Leskovac')," +
                "('Crkolez Istok')," +
                "('Crljenac Malo Crniće')," +
                "('Crmljane Đakovica')," +
                "('Crna Bara Aleksinac')," +
                "('Crna Bara Bogatić')," +
                "('Crna Bara Vlasotince')," +
                "('Crna Bara Čoka')," +
                "('Crnalava Raška')," +
                "('Crna Reka Trgovište')," +
                "('Crna Trava Crna Trava')," +
                "('Crnajka Majdanpek')," +
                "('Crnatovo Vlasotince')," +
                "('Crnatovo Leposavić')," +
                "('Crni Breg Lipljan')," +
                "('Crni Vrh Knjaževac')," +
                "('Crni Vrh Medveđa')," +
                "('Crni Vrh Vranjska Banja')," +
                "('Crni Vrh Peć')," +
                "('Crni Kao Batočina')," +
                "('Crni Kao Ražanj')," +
                "('Crni Lug Vranje')," +
                "('Crni Lug Istok')," +
                "('Crni Lug Klina')," +
                "('Crnilo Uroševac')," +
                "('Crnovranarahovac')," +
                "('Crnovce Trgovište')," +
                "('Crnoklište Pirot')," +
                "('Crnoljevica Svrljig')," +
                "('Crnoljevo Štimlje')," +
                "('Crnomasnica Negotin')," +
                "('Crnotince Preševo')," +
                "('Crnoštica Bosilegrad')," +
                "('Crnugovići Priboj')," +
                "('Crnuzi Priboj')," +
                "('Crnce Istok')," +
                "('Crnča Ljubovija')," +
                "('Crnče Bela Palanka')," +
                "('Crnče Jagodina')," +
                "('Crcavac Leskovac')," +
                "('Crčevo Sjenica')," +
                "('Culine Mali Zvornik')," +
                "('Culjković Šabac')," +
                "('Čabić Klina')," +
                "('Čabra Zubin Potok')," +
                "('Čaglavica Priština')," +
                "('Čagrovacadžin Han')," +
                "('Čadinje Prijepolje')," +
                "('Čairi Trstenik')," +
                "('Čajdrak Suva Reka')," +
                "('Čajetina Čajetina')," +
                "('Čalma Sremska Mitrovica')," +
                "('Čamurlija Niš – Crveni krst')," +
                "('Čantavir Subotica')," +
                "('Čapljinac Doljevac')," +
                "('Čar Bujanovac')," +
                "('Čarakovce Kosovska Kamenica')," +
                "('Čarovina Tutin')," +
                "('Čauševići Prijepolje')," +
                "('Čačak Čačak')," +
                "('Čašić Dolac Novi Pazar')," +
                "('Čedovo Sjenica')," +
                "('Čekmin Leskovac')," +
                "('Čelarevo Bačka Palanka')," +
                "('Čeliknjilane')," +
                "('Čelice Nova Varoš')," +
                "('Čelopek Lipljan')," +
                "('Čelopek Peć')," +
                "('Čenej Novi Sad')," +
                "('Čenta Zrenjanin')," +
                "('Čepure Paraćin')," +
                "('Čerević Beočin')," +
                "('Čerkez Sadovina Vitina')," +
                "('Českovo Klina')," +
                "('Česta Aleksinac')," +
                "('Čestelin Vranje')," +
                "('Čestereg Žitište')," +
                "('Čestin Knić')," +
                "('Čestobrodica Požega')," +
                "('Četereže Žabari')," +
                "('Čečevo Zubin Potok')," +
                "('Čečina Doljevac')," +
                "('Čečina Ivanjica')," +
                "('Češko Selo Bela Crkva')," +
                "('Češljeva Bara Velikoradište')," +
                "('Čibukovac Kraljevo')," +
                "('Čibutkovica Beograd – Lazarevac')," +
                "('Činiglavci Pirot')," +
                "('Čipalje Sjenica')," +
                "('Čitak Srbica')," +
                "('Čitluk Kruševac')," +
                "('Čitluk Ljubovija')," +
                "('Čitluk Mali Zvornik')," +
                "('Čitluk Priboj')," +
                "('Čitluk Sjenica')," +
                "('Čitluk Sokobanja')," +
                "('Čitluk Zubin Potok')," +
                "('Čiflak Vitina')," +
                "('Čiflakrahovac')," +
                "('Čiflik Bela Palanka')," +
                "('Čifluk Razgojnski Leskovac')," +
                "('Čmanjke Tutin')," +
                "('Čoka Čoka')," +
                "('Čokešina Loznica')," +
                "('Čokonjar Zaječar')," +
                "('Čokot Niš – Palilula')," +
                "('Čokotar Brus')," +
                "('Čokotin Medveđa')," +
                "('Čonoplja Sombor')," +
                "('Čortanovci Inđija')," +
                "('Čubra Negotin')," +
                "('Čubrelj Srbica')," +
                "('Čubura Merošina')," +
                "('Čubura Ražanj')," +
                "('Čuka Crna Trava')," +
                "('Čukarka Preševo')," +
                "('Čukljenik Leskovac')," +
                "('Čukljenik Niš – Niška Banja')," +
                "('Čukojevac Kraljevo')," +
                "('Čukote Tutin')," +
                "('Čukurovac Aleksinac')," +
                "('Čumić Kragujevac')," +
                "('Čungula Blace')");
                migrationBuilder.Sql(
                "insert into Mesta(NazivMesta) values " +
                "('Čungur Peć')," +
                "('Čupevo Klina')," +
                "('Čupevorahovac')," +
                "('Čurug Žabalj')," +
                "('Čučale Blace')," +
                "('Čučuge Ub')," +
                "('Čučuljaga Lipljan')," +
                "('Džep Vladičin Han')," +
                "('Džepnica Blace')," +
                "('Džigolj Prokuplje')," +
                "('Džurovo Prijepolje')," +
                "('Šabac Šabac')," +
                "('Šavac Paraćin')," +
                "('Šavrane Kruševac')," +
                "('Šavci Novi Pazar')," +
                "('Šainovac Doljevac')," +
                "('Šainovac Leskovac')," +
                "('Šaić Kosovska Kamenica')," +
                "('Šajinovac Prizren')," +
                "('Šajince Trgovište')," +
                "('Šajkaš Titel')," +
                "('Šajkovac Podujevo')," +
                "('Šakovica Podujevo')," +
                "('Šalinac Smederevo')," +
                "('Šaludovac Paraćin')," +
                "('Šalce Vučitrn')," +
                "('Šaljinovica Istok')," +
                "('Šaljska Bistrica Leposavić')," +
                "('Šanac Kruševac')," +
                "('Šantarovac Jagodina')," +
                "('Šapine Malo Crniće')," +
                "('Šaprance Trgovište')," +
                "('Šaptelj Dečani')," +
                "('Šaraniornji Milanovac')," +
                "('Šarban Priština')," +
                "('Šarbane Ub')," +
                "('Šarbanovac Bor')," +
                "('Šarbanovac Knjaževac')," +
                "('Šarbanovac Sokobanja')," +
                "('Šare Sjenica')," +
                "('Šarenik Ivanjica')," +
                "('Šarkamen Negotin')," +
                "('Šarlinac Doljevac')," +
                "('Šarlince Leskovac')," +
                "('Šaronje Novi Pazar')," +
                "('Šaronje Tutin')," +
                "('Šarce Lebane')," +
                "('Šatra Kuršumlija')," +
                "('Šatrinci Irig')," +
                "('Šašare Vitina')," +
                "('Šašilovac Kruševac')," +
                "('Šašinci Sremska Mitrovica')," +
                "('Šaškovac Priština')," +
                "('Šebetadžin Han')," +
                "('Ševarice Šabac')," +
                "('Ševica Kučevo')," +
                "('Ševiš Prokuplje')," +
                "('Ševrljuge Kosjerić')," +
                "('Šepšin Beograd – Mladenovac')," +
                "('Šeremet Đakovica')," +
                "('Šestiabar Knjaževac')," +
                "('Šetka Ražanj')," +
                "('Šetonje Petrova na Mlavi')," +
                "('Šid Šid')," +
                "('Šilovo Lebane')," +
                "('Šilovonjilane')," +
                "('Šilopajornji Milanovac')," +
                "('Šiljakovac Beograd – Barajevo')," +
                "('Šiljomana Blace')," +
                "('Šimanovci Pećinci')," +
                "('Šipačina Raška')," +
                "('Šipikovo Zaječar')," +
                "('Šipitulabilić')," +
                "('Šipova Zubin Potok')," +
                "('Šipolje Kosovska Mitrovica')," +
                "('Šipče Tutin')," +
                "('Široka Planina Trgovište')," +
                "('Široke Njive Prokuplje')," +
                "('Šišave Vlasotince')," +
                "('Šišarka Lipljan')," +
                "('Šišatovac Sremska Mitrovica')," +
                "('Šišince Leskovac')," +
                "('Šišman Đakovica')," +
                "('Šišmanovac Prokuplje')," +
                "('Škoza Prizren')," +
                "('Škrelje Peć')," +
                "('Šljivar Zaječar')," +
                "('Šljivica Rekovac')," +
                "('Šljivova Krupanj')," +
                "('Šljivovac Kragujevac')," +
                "('Šljivovac Malo Crniće')," +
                "('Šljivovik Bela Palanka')," +
                "('Šljivovik Svrljig')," +
                "('Šljivovica Čajetina')," +
                "('Šljivovica Vučitrn')," +
                "('Šljivovo Aleksandrovac')," +
                "('Šogolj Kruševac')," +
                "('Šopić Beograd – Lazarevac')," +
                "('Šošiće Brus')," +
                "('Špaj Bela Palanka')," +
                "('Špiljani Tutin')," +
                "('Špinadija Prizren')," +
                "('Štava Kuršumlija')," +
                "('Štavalj Sjenica')," +
                "('Štavica Ljig')," +
                "('Štedim Podujevo')," +
                "('Štimlje Štimlje')," +
                "('Šina Knjaževac')," +
                "('Štitar Šabac')," +
                "('Štitarac Knjaževac')," +
                "('Štitare Kruševac')," +
                "('Štitare Novi Pazar')," +
                "('Štitarica Vučitrn')," +
                "('Štitkovo Nova Varoš')," +
                "('Štrbac Knjaževac')," +
                "('Štrbovac Babušnica')," +
                "('Štrbulovologovac')," +
                "('Štrpce Štrpce')," +
                "('Štubik Negotin')," +
                "('Štulac Vrnjačka Banja')," +
                "('Štulac Lebane')," +
                "('Štuoce Zubin Potok')," +
                "('Štupelj Klina')," +
                "('Štuticalogovac')," +
                "('Šuvajićolubac')," +
                "('Šugrin Pirot')," +
                "('Šuljam Sremska Mitrovica')," +
                "('Šuljkovac Jagodina')," +
                "('Šuman Topla Knjaževac')," +
                "('Šumane Lebane')," +
                "('Šumarak Kovin')," +
                "('Šumarice Kraljevo')," +
                "('Šumata Trnica Trgovište')," +
                "('Šume Ivanjica')," +
                "('Šume Topola')," +
                "('Šupkovac Kosovska Mitrovica')," +
                "('Šupljak Subotica')," +
                "('Šurić Aleksinac')," +
                "('Šurice Loznica')," +
                "('Šurjan Sečanj')," +
                "('Šurlanenjilane')," +
                "('Šutci Ljig')," +
                "('Šušara Vršac')," +
                "('Šušeoka Mionica')," +
                "('Šušnjar Beograd – Lazarevac')," +
                "('Šušure Sjenica')");




        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mesta");
        }
    }
}
