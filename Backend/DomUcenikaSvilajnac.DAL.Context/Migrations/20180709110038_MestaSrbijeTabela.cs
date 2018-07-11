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
                "(N'Ada')," +
                "(N'Adaševci')," +
                "(N'Adebilić')," +
                "(N'Adorjan Kanjiža')," +
                "(N'Adrani Kraljevo')," +
                "(N'Adrovac Rača')," +
                "(N'Azanja Smederevska Palanka')," +
                "(N'Azbresnica Merošina')," +
                "(N'Ajvalija Priština')," +
                "(N'Ajkobila Priština')," +
                "(N'Ajnovce Kosovska Kamenica')," +
                "(N'Akmačići Nova Varoš')," +
                "(N'Alabak Podujevo')," +
                "(N'Alabana Blace')," +
                "(N'Alagina Reka Peć')," +
                "(N'Alakince Surdulica')," +
                "(N'Aldina Reka Knjaževac')," +
                "(N'Aldinac Knjaževac')," +
                "(N'Aleksa Šantić Sombor')," +
                "(N'Aleksandrovac Aleksandrovac')," +
                "(N'Aleksandrovac Babušnica')," +
                "(N'Aleksandrovac Vranje')," +
                "(N'Aleksandrovac Žabari')," +
                "(N'Aleksandrovac Negotin')," +
                "(N'Aleksandrovo Merošina')," +
                "(N'Aleksandrovo Nova Crnja')," +
                "(N'Aleksinac Aleksinac')," +
                "(N'Aleksinački Bujmir Aleksina')," +
                "(N'Aleksinački Rudnik Aleksina')," +
                "(N'Aleksine Vlasotince')," +
                "(N'Alibunar Alibunar')," +
                "(N'Aliveroviće Sjenica')," +
                "(N'Aliđerce Preševo')," +
                "(N'Alin Potok Čajetina')," +
                "(N'Aluloviće Novi Pazar')," +
                "(N'Aljinovići Prijepolje')," +
                "(N'Aljudovo Malo Crniće')," +
                "(N'Amajić Mali Zvornik')," +
                "(N'Amerić Beograd – Mladenovac')," +
                "(N'Amzići Nova Varoš')," +
                "(N'Androvac Lipljan')," +
                "(N'Apatin Apatin')," +
                "(N'Aradac Zrenjanin')," +
                "(N'Aranđelovac Aranđelovac')," +
                "(N'Arapovac Beograd – Lazareva')," +
                "(N'Arapoviće Tutin')," +
                "(N'Arbanasce Merošina')," +
                "(N'Arbanaška Prokuplje')," +
                "(N'Ariljača Kosovo Polje')," +
                "(N'Arilje Arilje')," +
                "(N'Arnajevo Beograd – Barajevo')," +
                "(N'Asanovac Žitorađa')," +
                "(N'Atenica Čačak')," +
                "(N'Atmađa Prizren')," +
                "(N'Adžine Livade Kragujevac')," +
                "(N'Ašanja Pećinci')," +
                "(N'Ba Ljig')," +
                "(N'Babaj Boks Đakovica')," +
                "(N'Babajić Ljig')," +
                "(N'Babaloć Dečani')," +
                "(N'Babe Beograd – Sopot')," +
                "(N'Babin Kal Bela Palanka')," +
                "(N'Babin Mostbilić')," +
                "(N'Babin Potok Prokuplje')," +
                "(N'Babina Luka Valjevo')," +
                "(N'Babina Poljana Trgovište')," +
                "(N'Babina Poljana Vranjska Ban')," +
                "(N'Babiće Zubin Potok')," +
                "(N'Babiće Peć')," +
                "(N'Babica Kuršumlija')," +
                "(N'Babičko Leskovac')," +
                "(N'Babljak Uroševac')," +
                "(N'Babotinac Prokuplje')," +
                "(N'Babudovica Zubin Potok')," +
                "(N'')," +
                "(N'Babušnica Babušnica')," +
                "(N'Bavanište Kovin')," +
                "(N'Bagačiće Sjenica')," +
                "(N'Bagrdan Jagodina')," +
                "(N'Bagremovo Bačka Topola')," +
                "(N'Badanj Raška')," +
                "(N'Badince Leskovac')," +
                "(N'Badljevica Smederevo')," +
                "(N'Badnjevac Batočina')," +
                "(N'Badnjevac Žitorađa')," +
                "(N'Badovac Priština')," +
                "(N'Badovinci Bogatić')," +
                "(N'Bazovik Pirot')," +
                "(N'Bajgora Kosovska Mitrovica')," +
                "(N'Bajevac Lajkovac')," +
                "(N'Bajevica Novi Pazar')," +
                "(N'Bajina Bašta Bajina Bašta')," +
                "(N'Bajinci Crna Trava')," +
                "(N'Bajmok Subotica')," +
                "(N'Bajčetina Knić')," +
                "(N'Bajčina Podujevo')," +
                "(N'Bajčince Prokuplje')," +
                "(N'Bajša Bačka Topola')," +
                "(N'Bakionica Požega')," +
                "(N'Baks Srbica')," +
                "(N'Bakšijabilić')," +
                "(N'Balaban Priština')," +
                "(N'Balajnac Despotovac')," +
                "(N'Balajnac Merošina')," +
                "(N'Balanovac Knjaževac')," +
                "(N'Balance Vitina')," +
                "(N'Balinac Knjaževac')," +
                "(N'Balinovac Prokuplje')," +
                "(N'Balinović Valjevo')," +
                "(N'Balinovce Vladičin Han')," +
                "(N'Balince Vučitrn')," +
                "(N'Balince Klina')," +
                "(N'Balić Uroševac')," +
                "(N'Balići Prijepolje')," +
                "(N'Baličevac Merošina')," +
                "(N'Balovac Podujevo')," +
                "(N'Balosave Knić')," +
                "(N'Balta Berilovac Knjaževac')," +
                "(N'Baluga (Ljubićska) Čačak')," +
                "(N'Baluga (Trnavska) Čačak')," +
                "(N'Balčak Prokuplje')," +
                "(N'Baljevac Beograd –brenovac')," +
                "(N'Baljevac Raška')," +
                "(N'Baljen Tutin')," +
                "(N'Baljkovac Kragujevac')," +
                "(N'Banatska Dubica Sečanj')," +
                "(N'Banatska Palanka Bela Crkva')," +
                "(N'Banatska Subotica Bela Crkv')," +
                "(N'Banatska Topola Kikinda')," +
                "(N'Banatski Brestovac Pančevo')," +
                "(N'Banatski Dvor Žitište')," +
                "(N'Banatski Despotovac Zrenjan')," +
                "(N'Banatski Karlovac Alibunar')," +
                "(N'Banatski Monoštor Čoka')," +
                "(N'Banatski Sokolac Plandište')," +
                "(N'Banatsko Aranđelovo Novi Kn')," +
                "(N'Banatsko Veliko Selo Kikind')," +
                "(N'Banatsko Višnjićevo Žitište')," +
                "(N'Banatsko Karađorđevo Žitišt')," +
                "(N'Banatsko Novo Selo Pančevo')," +
                "(N'Bandulić Lipljan')," +
                "(N'Baničina Smederevska Palank')," +
                "(N'Bankovac Aleksinac')," +
                "(N'Bankovci Crna Trava')," +
                "(N'Banov Do Zvečan')," +
                "(N'Banovo Polje Bogatić')," +
                "(N'Banoštor Beočin')," +
                "(N'Banski Dol Dimitrovgrad')," +
                "(N'Bancarevo Niš – Niška Banja')," +
                "(N'Banja Aranđelovac')," +
                "(N'Banja Novi Pazar')," +
                "(N'Banja Priboj')," +
                "(N'Banja Istok')," +
                "(N'Banja Srbica')," +
                "(N'Banja Suva Reka')," +
                "(N'Banja Koviljača Loznica')," +
                "(N'Banjani Ub')," +
                "(N'Banje Zubin Potok')," +
                "(N'Banjevac Krupanj')," +
                "(N'Banjica Čačak')," +
                "(N'Banjicalogovac')," +
                "(N'Banjica Istok')," +
                "(N'Banjica Kačanik')," +
                "(N'Banjica Lipljan')," +
                "(N'Banjska Vučitrn')," +
                "(N'Banjska Zvečan')," +
                "(N'Banjska Reka Zvečan')," +
                "(N'Banjskirešac Knjaževac')," +
                "(N'Banjski Suvi Do Zvečan')," +
                "(N'Bapsko Polje Kraljevo')," +
                "(N'Baraina Podujevo')," +
                "(N'Barajevo Beograd – Barajevo')," +
                "(N'Baraljevac Bujanovac')," +
                "(N'Barandapovo')," +
                "(N'Barane Peć')," +
                "(N'Barbarušince Vranje')," +
                "(N'Barbatovac Blace')," +
                "(N'BarBače Trgovište')," +
                "(N'Bardonić Đakovica')," +
                "(N'Bardosan Đakovica')," +
                "(N'Bare Despotovac')," +
                "(N'Bare Knić')," +
                "(N'Bare Kraljevo')," +
                "(N'Bare Novi Pazar')," +
                "(N'Bare Požarevac')," +
                "(N'Bare Prijepolje')," +
                "(N'Bare Rekovac')," +
                "(N'Bare Sjenica')," +
                "(N'Bare Leposavić')," +
                "(N'Bare Kosovska Mitrovica')," +
                "(N'Barelić Vranje')," +
                "(N'Barzilovica Beograd – Lazar')," +
                "(N'Bariljevo Priština')," +
                "(N'Barice Plandište')," +
                "(N'Barič Beograd –brenovac')," +
                "(N'BaričoluBač')," +
                "(N'Barje Bosilegrad')," +
                "(N'Barje Dimitrovgrad')," +
                "(N'Barje Leskovac')," +
                "(N'Barje Čiflik Pirot')," +
                "(N'Barlovo Kuršumlija')," +
                "(N'Baroševac Beograd – Lazarev')," +
                "(N'Basara Pirot')," +
                "(N'Bastavsečina')," +
                "(N'Bataire Kosovska Mitrovica')," +
                "(N'Batalage Koceljeva')," +
                "(N'Batinac Ćuprija')," +
                "(N'Batkovići Priboj')," +
                "(N'Batlava Podujevo')," +
                "(N'Batnjik Novi Pazar')," +
                "(N'Batovac Požarevac')," +
                "(N'Batote Brus')," +
                "(N'Batočina Batočina')," +
                "(N'Batrage Tutin')," +
                "(N'Batrovci Šid')," +
                "(N'Batulovce Vlasotince')," +
                "(N'Batuse Kosovo Polje')," +
                "(N'Batuša Malo Crniće')," +
                "(N'Batuša Đakovica')," +
                "(N'Batušinac Merošina')," +
                "(N'Baćevac Beograd – Barajevo')," +
                "(N'Baćica Tutin')," +
                "(N'Baćoglava Kuršumlija')," +
                "(N'Bače Prokuplje')," +
                "(N'Bačijevce Surdulica')," +
                "(N'Bač Bač')," +
                "(N'Bačvište Vladičin Han')," +
                "(N'Bačevina Lebane')," +
                "(N'Bačevica Boljevac')," +
                "(N'Bačevo Dimitrovgrad')," +
                "(N'Bačevci Bajina Bašta')," +
                "(N'Bačevci Valjevo')," +
                "(N'Bačija Sjenica')," +
                "(N'Bačina Varvarin')," +
                "(N'Bačinac Smederevska Palanka')," +
                "(N'Bačinci Šid')," +
                "(N'Bačkaora')," +
                "(N'Bačka Palanka Bačka Palanka')," +
                "(N'Bačka Topola Bačka Topola')," +
                "(N'Bački Breg Sombor')," +
                "(N'Bački Brestovacdžaci')," +
                "(N'Bački Vinogradi Subotica')," +
                "(N'Bačkiračacdžaci')," +
                "(N'Bački Jarak Temerin')," +
                "(N'Bački Monoštor Sombor')," +
                "(N'Bački Petrovac Bački Petrov')," +
                "(N'Bački Sokolac Bačka Topola')," +
                "(N'Bačkoradište Bečej')," +
                "(N'Bačko Dobro Polje Vrbas')," +
                "(N'Bačko Dušanovo Subotica')," +
                "(N'Bačko Novo Selo Bač')," +
                "(N'Bačko Petrovo Selo Bečej')," +
                "(N'Bašaid Kikinda')," +
                "(N'Bašin Smederevska Palanka')," +
                "(N'Baščeluci Loznica')," +
                "(N'Begaljica Beograd –rocka')," +
                "(N'Begeč Novi Sad')," +
                "(N'Begov Lukavac Istok')," +
                "(N'Begovo Brdo Kruševac')," +
                "(N'Begunce Vitina')," +
                "(N'Bedina Varoš Ivanjica')," +
                "(N'Bežište Bela Palanka')," +
                "(N'Bezdan Sombor')," +
                "(N'Bekova Novi Pazar')," +
                "(N'Bela Pirot')," +
                "(N'Bela Voda Kruševac')," +
                "(N'Bela Voda Prokuplje')," +
                "(N'Bela Palanka Bela Palanka')," +
                "(N'Bela Reka ŠaBač')," +
                "(N'Bela Stena Raška')," +
                "(N'Bela Crkva Krupanj')," +
                "(N'Bela Crkva Bela Crkva')," +
                "(N'Bela Crkvarahovac')," +
                "(N'Belaje Dečani')," +
                "(N'Belanica Suva Reka')," +
                "(N'Belanovica Ljig')," +
                "(N'Belanovce Vladičin Han')," +
                "(N'Belanovce Leskovac')," +
                "(N'Belasica Kruševac')," +
                "(N'Bele Vode Novi Pazar')," +
                "(N'Beleg Dečani')," +
                "(N'Belegiš Stara Pazova')," +
                "(N'Beleš Dimitrovgrad')," +
                "(N'Beli Breg Aleksinac')," +
                "(N'Beli Breg Vranje')," +
                "(N'Beli Kamen Lučani')," +
                "(N'Beli Kamen Prokuplje')," +
                "(N'Beli Potok Beograd – Voždov')," +
                "(N'Beli Potok Knjaževac')," +
                "(N'Beli Potok Leskovac')," +
                "(N'Beli Potok Sokobanja')," +
                "(N'Belince Štimlje')," +
                "(N'Belić Valjevo')," +
                "(N'Belica Jagodina')," +
                "(N'Belica Istok')," +
                "(N'Beliševo Vladičin Han')," +
                "(N'Belo Blato Zrenjanin')," +
                "(N'Belo Brdo Leposavić')," +
                "(N'Belo Polje Beograd –brenova')," +
                "(N'Belo Polje Brus')," +
                "(N'Belo Poljeornji Milanovac')," +
                "(N'Belo Polje Kuršumlija')," +
                "(N'Belo Polje Raška')," +
                "(N'Belo Polje Surdulica')," +
                "(N'Belo Polje Istok')," +
                "(N'Belo Polje Peć')," +
                "(N'Belo Polje Podujevo')," +
                "(N'Belobrod Prizren')," +
                "(N'Belogoš Prokuplje')," +
                "(N'Belograce Kačanik')," +
                "(N'Beloinje Svrljig')," +
                "(N'Beloljin Prokuplje')," +
                "(N'Belosavci Topola')," +
                "(N'Belotinac Doljevac')," +
                "(N'Belotić Bogatić')," +
                "(N'Belotić Vladimirci')," +
                "(N'Belotićsečina')," +
                "(N'Beloševac Valjevo')," +
                "(N'Belut Bosilegrad')," +
                "(N'Beluće Beograd – Mladenovac')," +
                "(N'Beluće Leposavić')," +
                "(N'Belušić Rekovac')," +
                "(N'Belja Aleksinac')," +
                "(N'Beljajka Despotovac')," +
                "(N'Beljevac Beograd – Mladenov')," +
                "(N'Beljin Vladimirci')," +
                "(N'Beljina Beograd – Barajevo')," +
                "(N'Beljina Čačak')," +
                "(N'Benčuk Vučitrn')," +
                "(N'Beograd (Voždovac) Beograd')," +
                "(N'Beograd (Vračar) Beograd –')," +
                "(N'Beograd (Zvezdara) Beograd')," +
                "(N'Beograd (Zemun) Beograd – Z')," +
                "(N'Beograd (Novi Beograd) Beog')," +
                "(N'Beograd (Palilula) Beograd')," +
                "(N'Beograd (Rakovica) Beograd')," +
                "(N'Beograd (Savski venac) Beog')," +
                "(N'Beograd (Starirad) Beograd')," +
                "(N'Beograd (Čukarica) Beograd')," +
                "(N'Beomužević Valjevo')," +
                "(N'Beoci Raška')," +
                "(N'Beočin')," +
                "(N'Beočić Rekovac')," +
                "(N'Beranje Požarevac')," +
                "(N'Berbatovo Niš – Palilula')," +
                "(N'Berberište Leposavić')," +
                "(N'Berduj Babušnica')," +
                "(N'Berevce Štrpce')," +
                "(N'Berivojce Kosovska Kamenica')," +
                "(N'Berilovac Pirot')," +
                "(N'Berilje Prokuplje')," +
                "(N'Berin Izvor Babušnica')," +
                "(N'Berišalogovac')," +
                "(N'Berjak Đakovica')," +
                "(N'Berkasovo Šid')," +
                "(N'Berkovac Mionica')," +
                "(N'Berkovo Klina')," +
                "(N'Berlovine Ljubovija')," +
                "(N'Berovica Pirot')," +
                "(N'Berčevac Preševo')," +
                "(N'Berčinac Niš – Crveni krst')," +
                "(N'Berčinovac Knjaževac')," +
                "(N'Beršićiornji Milanovac')," +
                "(N'Beserovina Bajina Bašta')," +
                "(N'Besinje Priština')," +
                "(N'Bec Đakovica')," +
                "(N'Bečanj Čačak')," +
                "(N'Bečevica Knić')," +
                "(N'Bečej Bečej')," +
                "(N'Bečić Vučitrn')," +
                "(N'Bečmen Beograd – Surčin')," +
                "(N'Bešenovački Prnjavor Sremsk')," +
                "(N'Bešenovo Sremska Mitrovica')," +
                "(N'Beška Inđija')," +
                "(N'Bzenice Aleksandrovac')," +
                "(N'Bzovik Kraljevo')," +
                "(N'Biba Uroševac')," +
                "(N'Bivoljak Vučitrn')," +
                "(N'Bivolje Kruševac')," +
                "(N'Bigrenica Ćuprija')," +
                "(N'BikinjeoluBač')," +
                "(N'Bikić Do Šid')," +
                "(N'Bikovo Subotica')," +
                "(N'Bilincenjilane')," +
                "(N'Bilo Dimitrovgrad')," +
                "(N'Biluša Prizren')," +
                "(N'Biljanovac Raška')," +
                "(N'Biljača Bujanovac')," +
                "(N'Biljeg Merošina')," +
                "(N'Binač Vitina')," +
                "(N'Bingula Šid')," +
                "(N'Biniće Raška')," +
                "(N'Binovac Smederevo')," +
                "(N'Binovce Surdulica')," +
                "(N'Bioska Užice')," +
                "(N'Biohane Tutin')," +
                "(N'Bioc Sjenica')," +
                "(N'Biočin Raška')," +
                "(N'Biskupići Prijepolje')," +
                "(N'Biskuplje Velikoradište')," +
                "(N'Bistar Bosilegrad')," +
                "(N'Bistražin Đakovica')," +
                "(N'Bistrica Beograd – Lazareva')," +
                "(N'Bistrica Leskovac')," +
                "(N'Bistrica Nova Varoš')," +
                "(N'Bistrica Petrova na Mlavi')," +
                "(N'Bistrica Crna Trava')," +
                "(N'Bistrica Leposavić')," +
                "(N'Bitvrđa Surdulica')," +
                "(N'Biča Klina')," +
                "(N'Bičevac Kačanik')," +
                "(N'Bjelahova Prijepolje')," +
                "(N'Bjeloperica Kosjerić')," +
                "(N'Bjelotići Užice')," +
                "(N'Bjeluša Arilje')," +
                "(N'Blagaje Peć')," +
                "(N'Blagojev Kamen Kučevo')," +
                "(N'Blaževo Brus')," +
                "(N'Blaznava Topola')," +
                "(N'Blato Pirot')," +
                "(N'Blato Sjenica')," +
                "(N'Blato Kosovska Kamenica')," +
                "(N'Blato Podujevo')," +
                "(N'Blaca Tutin')," +
                "(N'Blace Blace')," +
                "(N'Blace Suva Reka')," +
                "(N'Blendija Sokobanja')," +
                "(N'Bliznak Žagubica')," +
                "(N'Blizonje Valjevo')," +
                "(N'Bljač Prizren')," +
                "(N'Bob Kačanik')," +
                "(N'Bobište Leskovac')," +
                "(N'Bobova Valjevo')," +
                "(N'Bobovac Klina')," +
                "(N'Bobovik Vladimirci')," +
                "(N'Bobovište Aleksinac')," +
                "(N'Bobovo Svilajnac')," +
                "(N'Bobote Aleksandrovac')," +
                "(N'Bovan Aleksinac')," +
                "(N'Bovan Kruševac')," +
                "(N'Bovanj Tutin')," +
                "(N'Bogava Despotovac')," +
                "(N'Bogalinac Rekovac')," +
                "(N'Bogaraš Bačka Topola')," +
                "(N'Bogaraš Senta')," +
                "(N'Bogatić Bogatić')," +
                "(N'Bogatić Valjevo')," +
                "(N'Bogdanicaornji Milanovac')," +
                "(N'Bogdanovac Babušnica')," +
                "(N'Bogdanovac Bujanovac')," +
                "(N'Bogdanovica Ub')," +
                "(N'Bogdanje Trstenik')," +
                "(N'Bogdinac Sokobanja')," +
                "(N'Boge Peć')," +
                "(N'Bogiše Brus')," +
                "(N'Bogovađa Lajkovac')," +
                "(N'Bogovina Boljevac')," +
                "(N'Bogojevići Arilje')," +
                "(N'Bogojevodžaci')," +
                "(N'Bogojevce Leskovac')," +
                "(N'Bogosavac ŠaBač')," +
                "(N'Bogoševo Vladičin Han')," +
                "(N'Bogoštica Krupanj')," +
                "(N'Bogujevac Kuršumlija')," +
                "(N'Bogujevac Prokuplje')," +
                "(N'Bogunovac Medveđa')," +
                "(N'Boguti Sjenica')," +
                "(N'Bogutovac Kraljevo')," +
                "(N'Bođani Bač')," +
                "(N'Boždarevac Beograd – Baraje')," +
                "(N'Boževac Malo Crniće')," +
                "(N'Boževce Kosovska Kamenica')," +
                "(N'Božetići Nova Varoš')," +
                "(N'Božinovac Knjaževac')," +
                "(N'Božinjevac Bujanovac')," +
                "(N'Božica Surdulica')," +
                "(N'Božov Potok Sjenica')," +
                "(N'Božurevac Trstenik')," +
                "(N'Božurnja Topola')," +
                "(N'Bozoljin Brus')," +
                "(N'Bojanići Kraljevo')," +
                "(N'Bojin Del Vranje')," +
                "(N'Bojince Kruševac')," +
                "(N'Bojić ŠaBač')," +
                "(N'Bojišina Leskovac')," +
                "(N'Bojnik Bojnik')," +
                "(N'Bojnoviće Zubin Potok')," +
                "(N'Bostane Novo Brdo')," +
                "(N'Bosut Sremska Mitrovica')," +
                "(N'Bosuta Aranđelovac')," +
                "(N'Bosce Kosovska Kamenica')," +
                "(N'Botoš Zrenjanin')," +
                "(N'Botunja Brus')," +
                "(N'Botunje Kragujevac')," +
                "(N'Boturići Aleksandrovac')," +
                "(N'Boturovina Novi Pazar')," +
                "(N'Boće Raška')," +
                "(N'Boćevica Leskovac')," +
                "(N'Bočar Novi Bečej')," +
                "(N'Bošljane Vučitrn')," +
                "(N'Bošnjak Petrova na Mlavi')," +
                "(N'Bošnjane Varvarin')," +
                "(N'Bošnjane Paraćin')," +
                "(N'Bošnjane Rača')," +
                "(N'Bošnjanović Ljig')," +
                "(N'Bošnjace Lebane')," +
                "(N'Brabonjić Kosovska Mitrovic')," +
                "(N'Bradarac Aleksinac')," +
                "(N'Bradarac Požarevac')," +
                "(N'Bradaš Podujevo')," +
                "(N'Bradić Loznica')," +
                "(N'Braina Podujevo')," +
                "(N'Brajićiornji Milanovac')," +
                "(N'Brajkovac Beograd – Lazarev')," +
                "(N'Brajkovac Kruševac')," +
                "(N'Brajkovac Prijepolje')," +
                "(N'Brajkovići Kosjerić')," +
                "(N'Brajnovac Rekovac')," +
                "(N'Braljina Ražanj')," +
                "(N'Braljina Ćićevac')," +
                "(N'Brangović Valjevo')," +
                "(N'Branešci Čajetina')," +
                "(N'BraničevooluBač')," +
                "(N'Brankovina Valjevo')," +
                "(N'Brankovci Bosilegrad')," +
                "(N'Brančić Ljig')," +
                "(N'Brasaljcenjilane')," +
                "(N'Brasina Mali Zvornik')," +
                "(N'Bratačićsečina')," +
                "(N'Bratilovce Kosovska Kamenic')," +
                "(N'Bratinac Požarevac')," +
                "(N'Bratići Aleksandrovac')," +
                "(N'Bratiševac Babušnica')," +
                "(N'Bratljevo Ivanjica')," +
                "(N'Bratmilovce Leskovac')," +
                "(N'Bratoselce Bujanovac')," +
                "(N'Bratotinrahovac')," +
                "(N'Braćak Tutin')," +
                "(N'Braćevac Negotin')," +
                "(N'Braćevci Dimitrovgrad')," +
                "(N'Brvenik Raška')," +
                "(N'Brvenik Naselje Raška')," +
                "(N'Brvenica Raška')," +
                "(N'Brvine Prijepolje')," +
                "(N'Brgule Ub')," +
                "(N'Brgulice Beograd –brenovac')," +
                "(N'Brdarica Koceljeva')," +
                "(N'Brdo Nova Varoš')," +
                "(N'Brđani Brus')," +
                "(N'Brđaniornji Milanovac')," +
                "(N'Brđani Novi Pazar')," +
                "(N'Brebevnica Dimitrovgrad')," +
                "(N'Brevnik Podujevo')," +
                "(N'Bregovi Tutin')," +
                "(N'Bregovina Prokuplje')," +
                "(N'Brežane Požarevac')," +
                "(N'Brežani Blace')," +
                "(N'Brežanik Peć')," +
                "(N'Brežđe Mionica')," +
                "(N'Breza Sjenica')," +
                "(N'Brezjak Loznica')," +
                "(N'Breznaornji Milanovac')," +
                "(N'Brezna Kraljevo')," +
                "(N'Brezna Priboj')," +
                "(N'Brezna Prizren')," +
                "(N'Breznica Bujanovac')," +
                "(N'Breznica Žagubica')," +
                "(N'Breznicabilić')," +
                "(N'Brezova Ivanjica')," +
                "(N'Brezova Kraljevo')," +
                "(N'Brezovac Aranđelovac')," +
                "(N'Brezovica Vlasotince')," +
                "(N'Brezovicaornji Milanovac')," +
                "(N'Brezovica Trstenik')," +
                "(N'Brezovica Ub')," +
                "(N'Brezovica Čačak')," +
                "(N'Brezovica Štrpce')," +
                "(N'Brezovice Valjevo')," +
                "(N'Brezovice Krupanj')," +
                "(N'Brejanovce Leskovac')," +
                "(N'Brekovac Đakovica')," +
                "(N'Brekovo Arilje')," +
                "(N'Brenica Niš – Pantelej')," +
                "(N'Bresje Jagodina')," +
                "(N'Bresje Svilajnac')," +
                "(N'Bresje Kosovo Polje')," +
                "(N'Bresnik Kraljevo')," +
                "(N'Bresnik Prokuplje')," +
                "(N'Bresnica Bosilegrad')," +
                "(N'Bresnica Vranje')," +
                "(N'Bresnica Koceljeva')," +
                "(N'Bresnica Čačak')," +
                "(N'Bresnica Zvečan')," +
                "(N'Bresničić Prokuplje')," +
                "(N'Bresno Polje Trstenik')," +
                "(N'Brest Merošina')," +
                "(N'Brestač Pećinci')," +
                "(N'Brestov Dol Babušnica')," +
                "(N'Brestovac Bojnik')," +
                "(N'Brestovac Bor')," +
                "(N'Brestovac Knić')," +
                "(N'Brestovac Leskovac')," +
                "(N'Brestovac Negotin')," +
                "(N'Brestovacrahovac')," +
                "(N'Brestovik Beograd –rocka')," +
                "(N'Brestovik Peć')," +
                "(N'Brestovo Vladičin Han')," +
                "(N'Brestovo Despotovac')," +
                "(N'Brestovo Novi Pazar')," +
                "(N'Brece Podujevo')," +
                "(N'Brza Leskovac')," +
                "(N'Brza Palanka Kladovo')," +
                "(N'Brzan Batočina')," +
                "(N'Brzance Leposavić')," +
                "(N'Brzeće Brus')," +
                "(N'Brzi Brod Niš – Medijana')," +
                "(N'Brzohode Žabari')," +
                "(N'Bričevlje Leskovac')," +
                "(N'Brlog Pirot')," +
                "(N'Brniševo Tutin')," +
                "(N'Brnjak Zubin Potok')," +
                "(N'Brnjare Bujanovac')," +
                "(N'Brnjac Loznica')," +
                "(N'Brnjačarahovac')," +
                "(N'BrnjicaoluBač')," +
                "(N'Brnjica Knić')," +
                "(N'Brnjica Sjenica')," +
                "(N'Brovina Đakovica')," +
                "(N'Brović Beograd –brenovac')," +
                "(N'Brod Crna Trava')," +
                "(N'Brod Štrpce')," +
                "(N'Brodora')," +
                "(N'Brodarevo Prijepolje')," +
                "(N'Brodica Kučevo')," +
                "(N'Brodosavce Prizren')," +
                "(N'Brolić Peć')," +
                "(N'Broćna Srbica')," +
                "(N'Brus Brus')," +
                "(N'Brus Lipljan')," +
                "(N'Brusnik Zaječar')," +
                "(N'Brusnik Ivanjica')," +
                "(N'Brusnik Vučitrn')," +
                "(N'Brusnicaornji Milanovac')," +
                "(N'Brut Prizren')," +
                "(N'Brštica Krupanj')," +
                "(N'Buar Užice')," +
                "(N'Bubanj Niš – Palilula')," +
                "(N'Bube Zubin Potok')," +
                "(N'Bublica Prokuplje')," +
                "(N'Bubljerahovac')," +
                "(N'Bubušinac Požarevac')," +
                "(N'Buvce Lebane')," +
                "(N'Budakovo Suva Reka')," +
                "(N'Budilovina Brus')," +
                "(N'Budisava Novi Sad')," +
                "(N'Budisavci Klina')," +
                "(N'Budišić Mali Zvornik')," +
                "(N'Budoželja Ivanjica')," +
                "(N'Buđanovci Ruma')," +
                "(N'Buđevo Sjenica')," +
                "(N'Buzec Prizren')," +
                "(N'Buzovik Vitina')," +
                "(N'Bujanovac Bujanovac')," +
                "(N'Bujance Lipljan')," +
                "(N'Bujačić Valjevo')," +
                "(N'Bujić Preševo')," +
                "(N'Bujkovac Vranjska Banja')," +
                "(N'Bujkoviće Tutin')," +
                "(N'Bukarevac Preševo')," +
                "(N'Bukovalava Leskovac')," +
                "(N'Bukovac Despotovac')," +
                "(N'Bukovac Mionica')," +
                "(N'Bukovac Preševo')," +
                "(N'Bukovac Petrovaradin')," +
                "(N'Bukovik Aranđelovac')," +
                "(N'Bukovik Nova Varoš')," +
                "(N'Bukovik Prijepolje')," +
                "(N'Bukoviknjilane')," +
                "(N'Bukovica Ivanjica')," +
                "(N'Bukovica Kraljevo')," +
                "(N'Bukovica Kruševac')," +
                "(N'Bukovica Lipljan')," +
                "(N'Bukovska Kučevo')," +
                "(N'Bukovče Negotin')," +
                "(N'Bukovče Jagodina')," +
                "(N'Bukor ŠaBač')," +
                "(N'Bukorovac Kragujevac')," +
                "(N'Bukoš Vučitrn')," +
                "(N'Bukoš Suva Reka')," +
                "(N'Bukuloram Prokuplje')," +
                "(N'Bukurovac Bela Palanka')," +
                "(N'Bulatovac Prokuplje')," +
                "(N'Bulinovac Knjaževac')," +
                "(N'Buljane Paraćin')," +
                "(N'Buljesovce Vranje')," +
                "(N'Bumbarevo Brdo Knić')," +
                "(N'Bunar Jagodina')," +
                "(N'Bunuški Čifluk Leskovac')," +
                "(N'Burađa Nova Varoš')," +
                "(N'Burdimo Svrljig')," +
                "(N'Burincenjilane')," +
                "(N'Burince Podujevo')," +
                "(N'Burlate Zubin Potok')," +
                "(N'Burnik Uroševac')," +
                "(N'Burovac Petrova na Mlavi')," +
                "(N'Burovo Beograd – Lazarevac')," +
                "(N'Busenje Sečanj')," +
                "(N'Busilovac Paraćin')," +
                "(N'Businje Priština')," +
                "(N'Busovata Kosovska Kamenica')," +
                "(N'Busur Petrova na Mlavi')," +
                "(N'Buceljevo Bosilegrad')," +
                "(N'Buci Kruševac')," +
                "(N'Buča Prizren')," +
                "(N'Bučane Peć')," +
                "(N'Bučince Prokuplje')," +
                "(N'Bučić Merošina')," +
                "(N'Bučje Bor')," +
                "(N'Bučje Knjaževac')," +
                "(N'Bučje Priboj')," +
                "(N'Bučje Trstenik')," +
                "(N'Bučum Svrljig')," +
                "(N'Bušince Kosovska Kamenica')," +
                "(N'Buštranje Bujanovac')," +
                "(N'Buštranje Vranje')," +
                "(N'Buštranje Preševo')," +
                "(N'Vava Babušnica')," +
                "(N'Vaganeš Kosovska Kamenica')," +
                "(N'Vaganica Kosovska Mitrovica')," +
                "(N'Vajska Bač')," +
                "(N'Vajuga Kladovo')," +
                "(N'Vakup Aleksinac')," +
                "(N'Valakonje Boljevac')," +
                "(N'Valač Zvečan')," +
                "(N'Valevac Knjaževac')," +
                "(N'Valniš Babušnica')," +
                "(N'Valjevo Valjevo')," +
                "(N'Vapa Sjenica')," +
                "(N'Vapa Čačak')," +
                "(N'Varadin Medveđa')," +
                "(N'Varvarin Varvarin')," +
                "(N'Varvarin (selo) Varvarin')," +
                "(N'Varda Kosjerić')," +
                "(N'Varevo Novi Pazar')," +
                "(N'Varevo Raška')," +
                "(N'Varigovce Lipljan')," +
                "(N'Varna ŠaBač')," +
                "(N'Varniceornji Milanovac')," +
                "(N'Varoš Ražanj')," +
                "(N'Varoš Svrljig')," +
                "(N'Varoš Selo Uroševac')," +
                "(N'Vasilj Knjaževac')," +
                "(N'Vasiljevac Kuršumlija')," +
                "(N'Vasiljevići Ivanjica')," +
                "(N'Vasiljevologovac')," +
                "(N'Vata Kačanik')," +
                "(N'Vatin Vršac')," +
                "(N'Vašica Šid')," +
                "(N'Vever Novi Pazar')," +
                "(N'Vezičevo Petrova na Mlavi')," +
                "(N'Vele Polje Niš – Crveni krs')," +
                "(N'Velebit Kanjiža')," +
                "(N'Veleža Prizren')," +
                "(N'Velekincenjilane')," +
                "(N'Velerečornji Milanovac')," +
                "(N'Velesnica Kladovo')," +
                "(N'Velika Biljanica Leskovac')," +
                "(N'Velika Braina Medveđa')," +
                "(N'Velika Bresnica Kučevo')," +
                "(N'Velika Vrbica Kladovo')," +
                "(N'Velika Vrbnica Aleksandrova')," +
                "(N'Velikarabovnica Brus')," +
                "(N'Velikarabovnica Leskovac')," +
                "(N'Velikareda Plandište')," +
                "(N'Velika Dobranja Lipljan')," +
                "(N'Velika Drenova Trstenik')," +
                "(N'Velika Ivanča Beograd – Mla')," +
                "(N'Velika Jablanica Peć')," +
                "(N'Velika Jasikova Zaječar')," +
                "(N'Velika Ježevica Požega')," +
                "(N'Velika Kaludra Zubin Potok')," +
                "(N'Velika Kamenica Kladovo')," +
                "(N'Velika Kopašnica Leskovac')," +
                "(N'Velika Krsna Beograd – Mlad')," +
                "(N'Velika Krušarahovac')," +
                "(N'Velika Kruševica Kruševac')," +
                "(N'Velika Kruševica Rekovac')," +
                "(N'Velika Lomnica Kruševac')," +
                "(N'Velika Lukanja Pirot')," +
                "(N'Velika Marišta Mionica')," +
                "(N'Velika Moštanica Beograd –')," +
                "(N'Velika Plana Velika Plana')," +
                "(N'Velika Plana Prokuplje')," +
                "(N'Velika Reka Mali Zvornik')," +
                "(N'Velika Reka Vučitrn')," +
                "(N'Velika Reka Podujevo')," +
                "(N'Velika Remeta Irig')," +
                "(N'Velika Sejanica Leskovac')," +
                "(N'Velika Slatina Kosovo Polje')," +
                "(N'Velika Sugubina Kragujevac')," +
                "(N'Velika Hočarahovac')," +
                "(N'Velike Pčelice Kragujevac')," +
                "(N'Veliki Alaš Lipljan')," +
                "(N'Veliki Belaćevac Kosovo Pol')," +
                "(N'Veliki Borak Beograd – Bara')," +
                "(N'Veliki Vrtopadžin Han')," +
                "(N'Velikiaj Plandište')," +
                "(N'Velikioden Vitina')," +
                "(N'Veliki Drenovac Aleksinac')," +
                "(N'Veliki Đurđevik Klina')," +
                "(N'Veliki Izvor Zaječar')," +
                "(N'Veliki Jasenovac Zaječar')," +
                "(N'Veliki Jovanovac Pirot')," +
                "(N'Veliki Kičić Kosovska Mitro')," +
                "(N'Veliki Krčimiradžin Han')," +
                "(N'Veliki Kupci Kruševac')," +
                "(N'Veliki Popovac Petrova na M')," +
                "(N'Veliki Popović Despotovac')," +
                "(N'Veliki Radinci Sremska Mitr')," +
                "(N'Veliki Suvodol Pirot')," +
                "(N'Veliki Trnovac Bujanovac')," +
                "(N'Veliki Crljeni Beograd – La')," +
                "(N'Veliki Šenj Kragujevac')," +
                "(N'Veliki Šiljegovac Kruševac')," +
                "(N'Veliki Štupelj Peć')," +
                "(N'Veliko Bonjince Babušnica')," +
                "(N'Veliko Vojlovce Lebane')," +
                "(N'Velikoolovode Kruševac')," +
                "(N'Velikoradište Velikoradište')," +
                "(N'Veliko Kruševo Klina')," +
                "(N'Veliko Krušince Kruševac')," +
                "(N'Veliko Krčmare Rača')," +
                "(N'Veliko Laole Petrova na Mla')," +
                "(N'Velikorašje Velika Plana')," +
                "(N'Veliko Polje Beograd –breno')," +
                "(N'Veliko Pupavce Kuršumlija')," +
                "(N'Veliko Ribare Lipljan')," +
                "(N'Veliko Ropotovo Kosovska Ka')," +
                "(N'Veliko Rudare Zvečan')," +
                "(N'Veliko Selo Beograd – Palil')," +
                "(N'Veliko Selo Loznica')," +
                "(N'Veliko Selo Malo Crniće')," +
                "(N'Veliko Selo Pirot')," +
                "(N'Veliko Središte Vršac')," +
                "(N'Veliko Trnjane Leskovac')," +
                "(N'Veliko Crniće Malo Crniće')," +
                "(N'Veliševac Ljig')," +
                "(N'Veluće Trstenik')," +
                "(N'Veljalava Aleksandrovac')," +
                "(N'Velje Polje Tutin')," +
                "(N'Veljeglava Kosovska Kamenic')," +
                "(N'Velji Breg Zubin Potok')," +
                "(N'Veljkovo Negotin')," +
                "(N'Venčane Aranđelovac')," +
                "(N'Venčac Aleksandrovac')," +
                "(N'Verzar Dimitrovgrad')," +
                "(N'Verić Istok')," +
                "(N'Vesekovce Vučitrn')," +
                "(N'Veselinovac Valjevo')," +
                "(N'Veseniće Tutin')," +
                "(N'Veskoviće Sjenica')," +
                "(N'Veta Bela Palanka')," +
                "(N'Veternik Novi Sad')," +
                "(N'Vigošte Arilje')," +
                "(N'Vidanje Klina')," +
                "(N'Vidova Čačak')," +
                "(N'Vidovac Knjaževac')," +
                "(N'Vidovača Prokuplje')," +
                "(N'Vidovo Novi Pazar')," +
                "(N'Vidomirić Kosovska Mitrovic')," +
                "(N'Vidrovac Negotin')," +
                "(N'Vidušić Kosovska Mitrovica')," +
                "(N'Vizić Bačka Palanka')," +
                "(N'Vilandricaadžin Han')," +
                "(N'Vilište Zvečan')," +
                "(N'Vilovi Nova Varoš')," +
                "(N'Vilovo Titel')," +
                "(N'Viljance Vučitrn')," +
                "(N'Vilje Kolo Leskovac')," +
                "(N'Viljuša Čačak')," +
                "(N'Vina Knjaževac')," +
                "(N'Vina Leskovac')," +
                "(N'Vinarce Leskovac')," +
                "(N'Vinicka Prijepolje')," +
                "(N'Vinorača Jagodina')," +
                "(N'VincioluBač')," +
                "(N'Vinča Beograd –rocka')," +
                "(N'Vinča Topola')," +
                "(N'Vinjište Kragujevac')," +
                "(N'Vionica Ivanjica')," +
                "(N'Virine Ćuprija')," +
                "(N'Virovac Mionica')," +
                "(N'Virovo Arilje')," +
                "(N'Visibaba Požega')," +
                "(N'Visoka Arilje')," +
                "(N'Visoka Kuršumlija')," +
                "(N'Visočka Sjenica')," +
                "(N'Visočka Ržana Pirot')," +
                "(N'Visočkidorovci Dimitrovgrad')," +
                "(N'Vitak Srbica')," +
                "(N'Vitakova Zubin Potok')," +
                "(N'Vitanovac Bela Palanka')," +
                "(N'Vitanovac Kraljevo')," +
                "(N'Vitanovac Kruševac')," +
                "(N'Vitanoviće Leposavić')," +
                "(N'Vitance Despotovac')," +
                "(N'Vitasi Užice')," +
                "(N'Viteževo Žabari')," +
                "(N'Vitina Vitina')," +
                "(N'Vitkovac Aleksinac')," +
                "(N'Vitkovac Knjaževac')," +
                "(N'Vitkovac Kraljevo')," +
                "(N'Vitkoviće Novi Pazar')," +
                "(N'Vitkovo Aleksandrovac')," +
                "(N'Vitovnica Petrova na Mlavi')," +
                "(N'Vitojevci Ruma')," +
                "(N'Vitomirica Peć')," +
                "(N'Vitoše Brus')," +
                "(N'Vitoševac Ražanj')," +
                "(N'Viča Lučani')," +
                "(N'Viča Prokuplje')," +
                "(N'Viča Štrpce')," +
                "(N'Više Selo Blace')," +
                "(N'Viševac Rača')," +
                "(N'Viševce Vranje')," +
                "(N'Višesava Bajina Bašta')," +
                "(N'Višnjeva Sjenica')," +
                "(N'Višnjevac Subotica')," +
                "(N'Višnjićevo Šid')," +
                "(N'Višnjice Sjenica')," +
                "(N'Vladimirovac Alibunar')," +
                "(N'Vladimirci Vladimirci')," +
                "(N'Vladičin Han Vladičin Han')," +
                "(N'Vladovonjilane')," +
                "(N'Vladovce Trgovište')," +
                "(N'Vlajkovac Vršac')," +
                "(N'Vlajkovci Brus')," +
                "(N'Vlakča Kragujevac')," +
                "(N'Vlaole Majdanpek')," +
                "(N'Vlasanica Vladimirci')," +
                "(N'Vlase Vranje')," +
                "(N'Vlase Leskovac')," +
                "(N'Vlasi Pirot')," +
                "(N'Vlasinakruglica Surdulica')," +
                "(N'Vlasina Rid Surdulica')," +
                "(N'Vlasina Stojkovićeva Surdulica')," +
                "(N'Vlasovo Prokuplje')," +
                "(N'Vlasotince Vlasotince')," +
                "(N'Vlasteljice Lučani')," +
                "(N'Vlahinja Kuršumlija')," +
                "(N'Vlahinje Kosovska Mitrovica')," +
                "(N'Vlahovo Žitorađa')," +
                "(N'Vlahovo Svrljig')," +
                "(N'Vlaška Beograd – Mladenovac')," +
                "(N'Vlaška Ćuprija')," +
                "(N'Vlaški Do Žabari')," +
                "(N'Vlaški Do Smederevska Palanka')," +
                "(N'Vlaški Drenovac Klina')," +
                "(N'Vlaško Polje Knjaževac')," +
                "(N'Vlašnja Prizren')," +
                "(N'Vlašticanjilane')," +
                "(N'Vlaščić Valjevo')," +
                "(N'Vlkovija Dimitrovgrad')," +
                "(N'Vogance Bujanovac')," +
                "(N'Voganj Ruma')," +
                "(N'Vogačica Lipljan')," +
                "(N'Vogovo Đakovica')," +
                "(N'Vodanj Smederevo')," +
                "(N'Vodice Prokuplje')," +
                "(N'Vodice Smederevska Palanka')," +
                "(N'Vojvoda Zimonić Kanjiža')," +
                "(N'Vojvoda Stepa Nova Crnja')," +
                "(N'Vojvodinci Vršac')," +
                "(N'VojilovooluBač')," +
                "(N'Vojinovac Rača')," +
                "(N'Vojinovce Štimlje')," +
                "(N'Vojka Stara Pazova')," +
                "(N'Vojkoviće Novi Pazar')," +
                "(N'Vojkovci Topola')," +
                "(N'Vojmilovići Raška')," +
                "(N'Vojmisliće Zubin Potok')," +
                "(N'Vojnegovac Pirot')," +
                "(N'Vojnik Despotovac')," +
                "(N'Vojniće Novi Pazar')," +
                "(N'Vojnici Babušnica')," +
                "(N'Vojska Svilajnac')," +
                "(N'Vokša Dečani')," +
                "(N'Voluja Kučevo')," +
                "(N'Volujak Klina')," +
                "(N'Volujac Užice')," +
                "(N'Volujac ŠaBač')," +
                "(N'Voljavče Jagodina')," +
                "(N'Voljevci Mali Zvornik')," +
                "(N'Voljčince Žitorađa')," +
                "(N'Voćnjak Loznica')," +
                "(N'Voćnjak Srbica')," +
                "(N'Vošanovac Petrova na Mlavi')," +
                "(N'Vragovac Peć')"); 
				
				 migrationBuilder.Sql(
                "insert into Mesta(NazivMesta) values " +
                "(N'Vragolija Kosovo Polje')," +
                "(N'Vragočanica Valjevo')," +
                "(N'Vražogrnac Zaječar')," +
                "(N'Vražogrnci Aleksandrovac')," +
                "(N'Vrandol Bela Palanka')," +
                "(N'Vrane Arilje')," +
                "(N'Vraneša Nova Varoš')," +
                "(N'Vraneši Vrnjačka Banja')," +
                "(N'Vrani Do Priština')," +
                "(N'Vranić Beograd – Barajevo')," +
                "(N'Vranić Đakovica')," +
                "(N'Vranić Suva Reka')," +
                "(N'Vranići Čačak')," +
                "(N'Vranište Pirot')," +
                "(N'Vraništeora')," +
                "(N'Vranovac Jagodina')," +
                "(N'Vranovac Peć')," +
                "(N'Vranovina Novi Pazar')," +
                "(N'Vranovo Smederevo')," +
                "(N'Vranštica Aleksandrovac')," +
                "(N'Vranjakrahovac')," +
                "(N'Vranjani Požega')," +
                "(N'Vranje Vranje')," +
                "(N'Vranjska Banja Vranjska Banja')," +
                "(N'Vrapce Medveđa')," +
                "(N'Vrapci Sjenica')," +
                "(N'Vrapča Dimitrovgrad')," +
                "(N'Vrapče Tutin')," +
                "(N'Vrapčićnjilane')," +
                "(N'Vratare Kruševac')," +
                "(N'Vratarnica Zaječar')," +
                "(N'Vratna Negotin')," +
                "(N'Vraćevšnicaornji Milanovac')," +
                "(N'Vračevaj Bela Crkva')," +
                "(N'Vračević Lajkovac')," +
                "(N'Vračevo Leposavić')," +
                "(N'Vrba Kraljevo')," +
                "(N'Vrba Jagodina')," +
                "(N'Vrba Tutin')," +
                "(N'Vrba Zubin Potok')," +
                "(N'Vrban Bujanovac')," +
                "(N'Vrban Vitina')," +
                "(N'Vrbas Vrbas')," +
                "(N'Vrbeta Knić')," +
                "(N'Vrbeštica Štrpce')," +
                "(N'Vrbić Krupanj')," +
                "(N'Vrbica Aranđelovac')," +
                "(N'Vrbica Zaječar')," +
                "(N'Vrbica Čoka')," +
                "(N'Vrbicanjilane')," +
                "(N'Vrbičane Prizren')," +
                "(N'Vrbnica Aleksandrovac')," +
                "(N'Vrbnica Malo Crniće')," +
                "(N'Vrbnica Sjenica')," +
                "(N'Vrbnica Prizren')," +
                "(N'Vrbnica Kosovska Mitrovica')," +
                "(N'Vrbovac Blace')," +
                "(N'Vrbovac Boljevac')," +
                "(N'Vrbovac Smederevo')," +
                "(N'Vrbovac Sokobanja')," +
                "(N'Vrbovac Vitina')," +
                "(N'Vrbovaclogovac')," +
                "(N'Vrbovno Beograd – Lazarevac')," +
                "(N'Vrbovo Vladičin Han')," +
                "(N'Vrbovo Prijepolje')," +
                "(N'Vrgudinac Bela Palanka')," +
                "(N'Vrdila Kraljevo')," +
                "(N'Vrdnik Irig')," +
                "(N'Vrelo Aleksinac')," +
                "(N'Vrelo Babušnica')," +
                "(N'Vrelo Kuršumlija')," +
                "(N'Vrelo Ub')," +
                "(N'Vrelo Niš – Pantelej')," +
                "(N'Vrelo Istok')," +
                "(N'Vrelo Lipljan')," +
                "(N'Vreoci Beograd – Lazarevac')," +
                "(N'Vrlane Svilajnac')," +
                "(N'Vrmbaje Ivanjica')," +
                "(N'Vrmnica Klina')," +
                "(N'Vrmdža Sokobanja')," +
                "(N'Vrnavokolo Vitina')," +
                "(N'Vrnez Vitina')," +
                "(N'Vrnica Vučitrn')," +
                "(N'Vrnčaniornji Milanovac')," +
                "(N'Vrnčani Čačak')," +
                "(N'Vrnjačka Banja Vrnjačka Banja')," +
                "(N'Vrnjci Vrnjačka Banja')," +
                "(N'Vrsjenice Sjenica')," +
                "(N'Vrtiglav Mionica')," +
                "(N'Vrtine Raška')," +
                "(N'Vrtište Niš – Crveni krst')," +
                "(N'Vrtovac Knjaževac')," +
                "(N'Vrtogoš Vranje')," +
                "(N'Vrtolnica Kačanik')," +
                "(N'Vrćenovica Aleksinac')," +
                "(N'Vrutci Užice')," +
                "(N'Vrućevce Kosovska Kamenica')," +
                "(N'Vrh Kraljevo')," +
                "(N'Vrhovine Ub')," +
                "(N'Vrhpolje Ljubovija')," +
                "(N'Vrčin Beograd –rocka')," +
                "(N'Vršac Vršac')," +
                "(N'Vršački Ritovi Vršac')," +
                "(N'Vrševac Kuršumlija')," +
                "(N'Vrševce Lipljan')," +
                "(N'Vrševce Suva Reka')," +
                "(N'Vujanovo Bojnik')," +
                "(N'Vujetinci Čačak')," +
                "(N'Vujinovača Valjevo')," +
                "(N'Vukanja Aleksinac')," +
                "(N'Vukašinovac Aleksinac')," +
                "(N'Vukićevica Beograd –brenovac')," +
                "(N'Vukmanovac Rekovac')," +
                "(N'Vukmanovo Niš – Palilula')," +
                "(N'Vukovac Žagubica')," +
                "(N'Vuković Kučevo')," +
                "(N'Vukojevac Kuršumlija')," +
                "(N'Vukojeviće Zubin Potok')," +
                "(N'Vukona Ub')," +
                "(N'Vukosavljeviće Zubin Potok')," +
                "(N'Vukosavci Aranđelovac')," +
                "(N'Vukošić Vladimirci')," +
                "(N'Vukušica Vrnjačka Banja')," +
                "(N'Vus Crna Trava')," +
                "(N'Vuča Leposavić')," +
                "(N'Vučadelce Surdulica')," +
                "(N'Vučak Ivanjica')," +
                "(N'Vučak Kruševac')," +
                "(N'Vučak Smederevo')," +
                "(N'Vučaklogovac')," +
                "(N'Vučevica Vladimirci')," +
                "(N'Vuči Del Babušnica')," +
                "(N'Vučiniće Novi Pazar')," +
                "(N'Vučitrn Vučitrn')," +
                "(N'Vučić Rača')," +
                "(N'Vučja Lokva Novi Pazar')," +
                "(N'Vučje Leskovac')," +
                "(N'Vučkovica Knić')," +
                "(N'Vučkovica Lučani')," +
                "(N'Gabrica Kačanik')," +
                "(N'Gabrovac Niš – Palilula')," +
                "(N'Gabrovnica Knjaževac')," +
                "(N'Gavez Kruševac')," +
                "(N'Gagince Leskovac')," +
                "(N'Gaglovo Kruševac')," +
                "(N'Gadišnjilane')," +
                "(N'Gazdare Medveđa')," +
                "(N'Gazivode Zubin Potok')," +
                "(N'Gaj Kovin')," +
                "(N'Gajdobra Bačka Palanka')," +
                "(N'Gajre Kačanik')," +
                "(N'Gakovo Sombor')," +
                "(N'Galibabinac Svrljig')," +
                "(N'Galica Vučitrn')," +
                "(N'Galović Koceljeva')," +
                "(N'Galovići Kosjerić')," +
                "(N'Gamzigrad Zaječar')," +
                "(N'Garaši Aranđelovac')," +
                "(N'Gardinovci Titel')," +
                "(N'Gareadžin Han')," +
                "(N'Gare Preševo')," +
                "(N'Garevina Aleksandrovac')," +
                "(N'Garevo Velikoradište')," +
                "(N'Gari Kruševac')," +
                "(N'Garinje Vladičin Han')," +
                "(N'Gatnje Uroševac')," +
                "(N'Gadžin Hanadžin Han')," +
                "(N'Gvozdac Bajina Bašta')," +
                "(N'Gvozdenović Ub')," +
                "(N'Geglja Lebane')," +
                "(N'Geljance Suva Reka')," +
                "(N'Gedžarahovac')," +
                "(N'Gibarac Šid')," +
                "(N'Glavinci Jagodina')," +
                "(N'Glavica Paraćin')," +
                "(N'Glavica Lipljan')," +
                "(N'Glavičica Peć')," +
                "(N'Glavnik Podujevo')," +
                "(N'Glavotina Vučitrn')," +
                "(N'Gladno Selologovac')," +
                "(N'Glanica Lipljan')," +
                "(N'Glasovik Prokuplje')," +
                "(N'Glašince Žitorađa')," +
                "(N'Gledić Kraljevo')," +
                "(N'Gleđica Ivanjica')," +
                "(N'Glibovac Smederevska Palanka')," +
                "(N'Globare Kruševac')," +
                "(N'Globarelogovac')," +
                "(N'Globoder Kruševac')," +
                "(N'Globočica Kačanik')," +
                "(N'Globočicaora')," +
                "(N'Glogovac Bela Palanka')," +
                "(N'Glogovac Bogatić')," +
                "(N'Glogovac Knjaževac')," +
                "(N'Glogovac Jagodina')," +
                "(N'Glogovaclogovac')," +
                "(N'Glogovik Tutin')," +
                "(N'Glogovica Aleksinac')," +
                "(N'Glogovica Zaječar')," +
                "(N'Glogovica Priština')," +
                "(N'Glogovce Kosovska Kamenica')," +
                "(N'Glogovce Lipljan')," +
                "(N'Glogonj Pančevo')," +
                "(N'Glođane Dečani')," +
                "(N'Glođane Peć')," +
                "(N'Gložan Bački Petrovac')," +
                "(N'Gložane Vlasotince')," +
                "(N'Gložane Svilajnac')," +
                "(N'Gložje Bosilegrad')," +
                "(N'Glumač Požega')," +
                "(N'Gluhavica Tutin')," +
                "(N'Glušci Bogatić')," +
                "(N'Gmince Kosovska Kamenica')," +
                "(N'Gnila Tutin')," +
                "(N'Gnježdane Leposavić')," +
                "(N'Gnjilan Pirot')," +
                "(N'Gnjilanenjilane')," +
                "(N'Gnjilica Raška')," +
                "(N'Gogolovce Kosovska Kamenica')," +
                "(N'Godancelogovac')," +
                "(N'Godačica Kraljevo')," +
                "(N'Goden Đakovica')," +
                "(N'Godečevo Kosjerić')," +
                "(N'Godišnjak Podujevo')," +
                "(N'Godljevo Kosjerić')," +
                "(N'Godovik Požega')," +
                "(N'Godovo Tutin')," +
                "(N'Gojakovići Prijepolje')," +
                "(N'Gojbulja Vučitrn')," +
                "(N'Gojin Dol Dimitrovgrad')," +
                "(N'Gojinovac Prokuplje')," +
                "(N'Gojmanovac Svrljig')," +
                "(N'Gojnaoraornji Milanovac')," +
                "(N'Gokčanica Kraljevo')," +
                "(N'Golalava Valjevo')," +
                "(N'Golema Njiva Leskovac')," +
                "(N'Golemi Dol Preševo')," +
                "(N'Golemo Selo Vranje')," +
                "(N'Goleš Bosilegrad')," +
                "(N'Goleško Vrelo Lipljan')," +
                "(N'Golešnica Aleksinac')," +
                "(N'Goli Rid Lebane')," +
                "(N'Golice Novi Pazar')," +
                "(N'Golobok Smederevska Palanka')," +
                "(N'Golovo Čajetina')," +
                "(N'Goločevac Trgovište')," +
                "(N'Goločelo Koceljeva')," +
                "(N'Goločelo Kragujevac')," +
                "(N'Goluban Sjenica')," +
                "(N'GoluBačoluBač')," +
                "(N'GoluBač Mionica')," +
                "(N'Golubinci Stara Pazova')," +
                "(N'Golubinje Majdanpek')," +
                "(N'Golubovac Paraćin')," +
                "(N'Golubovac Trstenik')," +
                "(N'Golubovac Klina')," +
                "(N'Goraždevac Peć')," +
                "(N'Gorance Kačanik')," +
                "(N'Goračevorahovac')," +
                "(N'Goračići Lučani')," +
                "(N'Gorina Leskovac')," +
                "(N'Gorić Valjevo')," +
                "(N'Gorićrahovac')," +
                "(N'Goričani Čačak')," +
                "(N'Gorjani Užice')," +
                "(N'Gornovac Trgovište')," +
                "(N'Gornja Badanja Loznica')," +
                "(N'Gornja Bejašnica Prokuplje')," +
                "(N'Gornja Bela Reka Zaječar')," +
                "(N'Gornja Bela Reka Nova Varoš')," +
                "(N'Gornja Bitinja Štrpce')," +
                "(N'Gornja Borina Loznica')," +
                "(N'Gornja Bresnica Prokuplje')," +
                "(N'Gornja Brnjica Priština')," +
                "(N'Gornja Budrika Vitina')," +
                "(N'Gornja Bukovica Valjevo')," +
                "(N'Gornja Bunuša Leskovac')," +
                "(N'Gornja Vranjska ŠaBač')," +
                "(N'Gornja Vrbavaornji Milanovac')," +
                "(N'Gornja Vrežina Niš – Pantelej')," +
                "(N'Gornjalama Bela Palanka')," +
                "(N'Gornjaorevnica Čačak')," +
                "(N'Gornjarabovica Valjevo')," +
                "(N'Gornjarlica Kačanik')," +
                "(N'Gornjaušterica Lipljan')," +
                "(N'Gornja Dobrinja Požega')," +
                "(N'Gornja Draguša Blace')," +
                "(N'Gornja Držina Pirot')," +
                "(N'Gornja Dubnica Vučitrn')," +
                "(N'Gornja Dubnica Podujevo')," +
                "(N'Gornja Zleginja Aleksandrovac')," +
                "(N'Gornja Jajina Leskovac')," +
                "(N'Gornja Jošanica Blace')," +
                "(N'Gornja Kamenica Knjaževac')," +
                "(N'Gornja Klina Srbica')," +
                "(N'Gornja Koviljača Loznica')," +
                "(N'Gornja Koznica Surdulica')," +
                "(N'Gornja Konjuša Prokuplje')," +
                "(N'Gornja Koreticalogovac')," +
                "(N'Gornja Koritnica Bela Palanka')," +
                "(N'Gornja Kravarica Lučani')," +
                "(N'Gornja Krušica Suva Reka')," +
                "(N'Gornja Kupinovica Leskovac')," +
                "(N'Gornja Lapaštica Medveđa')," +
                "(N'Gornja Lapaštica Podujevo')," +
                "(N'Gornja Lisina Bosilegrad')," +
                "(N'Gornja Lokošnica Leskovac')," +
                "(N'Gornja Lomnica Vlasotince')," +
                "(N'Gornja Lopušnja Vlasotince')," +
                "(N'Gornja Luka Dečani')," +
                "(N'Gornja Ljubata Bosilegrad')," +
                "(N'Gornja Ljuboviđa Ljubovija')," +
                "(N'Gornja Mikuljana Kuršumlija')," +
                "(N'Gornja Mutnica Paraćin')," +
                "(N'Gornja Nevlja Dimitrovgrad')," +
                "(N'Gornjamašnica Trstenik')," +
                "(N'Gornjarovica Ljubovija')," +
                "(N'Gornjatulja Vranje')," +
                "(N'Gornja Pakaštica Podujevo')," +
                "(N'Gornja Peščanica Aleksinac')," +
                "(N'Gornja Pološnica Kosjerić')," +
                "(N'Gornja Rapčaora')," +
                "(N'Gornja Rasovača Merošina')," +
                "(N'Gornja Rečica Prokuplje')," +
                "(N'Gornja Ržana Bosilegrad')," +
                "(N'Gornja Rogatica Bačka Topola')," +
                "(N'Gornja Sabanta Kragujevac')," +
                "(N'Gornja Sipulja Loznica')," +
                "(N'Gornja Slatina Leskovac')," +
                "(N'Gornja Slatina Vitina')," +
                "(N'Gornja Sokolovica Knjaževac')," +
                "(N'Gornja Srbica Prizren')," +
                "(N'Gornja Stražava Prokuplje')," +
                "(N'Gornja Stubla Vitina')," +
                "(N'Gornja Studena Niš – Niška Banja')," +
                "(N'Gornja Sudimlja Vučitrn')," +
                "(N'Gornja Toponica Prokuplje')," +
                "(N'Gornja Toponica Niš – Crveni krst')," +
                "(N'Gornja Trepča Čačak')," +
                "(N'Gornja Trešnjevica Aranđelovac')," +
                "(N'Gornja Trešnjica Ljubovija')," +
                "(N'Gornja Trnava Prokuplje')," +
                "(N'Gornja Trnava Topola')," +
                "(N'Gornja Trnava Niš – Crveni krst')," +
                "(N'Gornja Trnica Trgovište')," +
                "(N'Gornja Tušimlja Novi Pazar')," +
                "(N'Gornja Fušticalogovac')," +
                "(N'Gornja Crnišava Trstenik')," +
                "(N'Gornja Crnućaornji Milanovac')," +
                "(N'Gornja Šatornja Topola')," +
                "(N'Gornja Šipašnica Kosovska Kamenica')," +
                "(N'Gornja Šušaja Preševo')," +
                "(N'Gornjane Bor')," +
                "(N'Gornje Babine Prijepolje')," +
                "(N'Gornje Brijanje Bojnik')," +
                "(N'Gornje Varage Zubin Potok')," +
                "(N'Gornje Vidovo Paraćin')," +
                "(N'Gornje Vinarce Kosovska Mitrovica')," +
                "(N'Gornje Vlaseadžin Han')," +
                "(N'Gornje Vranovce Lebane')," +
                "(N'Gornjeadimlje Lipljan')," +
                "(N'Gornjeare Crna Trava')," +
                "(N'Gornjeodance Štimlje')," +
                "(N'Gornjeoračiće Prijepolje')," +
                "(N'Gornjerbice Kragujevac')," +
                "(N'Gornjergure Blace')," +
                "(N'Gornje Dobrevo Kosovo Polje')," +
                "(N'Gornje Dragovljeadžin Han')," +
                "(N'Gornje Žabare Kosovska Mitrovica')," +
                "(N'Gornje Žapsko Vranje')," +
                "(N'Gornje Zuniče Knjaževac')," +
                "(N'Gornje Jabukovo Vladičin Han')," +
                "(N'Gornje Jarušice Kragujevac')," +
                "(N'Gornje Karačevo Kosovska Kamenica')," +
                "(N'Gornje Komarice Kragujevac')," +
                "(N'Gornje Konjuvce Bojnik')," +
                "(N'Gornje Kordince Prokuplje')," +
                "(N'Gornje Korminjane Kosovska Kamenica')," +
                "(N'Gornje Košlje Ljubovija')," +
                "(N'Gornje Krajince Leskovac')," +
                "(N'Gornje Krnjino Babušnica')," +
                "(N'Gornje Kuscenjilane')," +
                "(N'Gornje Leviće Brus')," +
                "(N'Gornje Leskovice Valjevo')," +
                "(N'Gornje Lopiže Sjenica')," +
                "(N'Gornje Ljubinje Prizren')," +
                "(N'Gornje Ljupče Podujevo')," +
                "(N'Gornje Međurovo Niš – Palilula')," +
                "(N'Gornje Nedeljice Loznica')," +
                "(N'Gornje Nerodimlje Uroševac')," +
                "(N'Gornje Novo Selo Đakovica')," +
                "(N'Gornjebrinjelogovac')," +
                "(N'Gornje Potočanerahovac')," +
                "(N'Gornje Prekaze Srbica')," +
                "(N'Gornje Punoševce Vranje')," +
                "(N'Gornje Rataje Aleksandrovac')," +
                "(N'Gornje Rašane Kosovska Mitrovica')," +
                "(N'Gornje Romanovce Surdulica')," +
                "(N'Gornje Svarče Blace')," +
                "(N'Gornje Selo Prizren')," +
                "(N'Gornje Sinkovce Leskovac')," +
                "(N'Gornje Slakovcenjilane')," +
                "(N'Gornje Stanovce Vučitrn')," +
                "(N'Gornje Stopanje Leskovac')," +
                "(N'Gornje Suhotno Aleksinac')," +
                "(N'Gornje Tlamino Bosilegrad')," +
                "(N'Gornje Točane Kuršumlija')," +
                "(N'Gornje Trebešinje Vranje')," +
                "(N'Gornje Trnjane Leskovac')," +
                "(N'Gornje Trudovo Nova Varoš')," +
                "(N'Gornje Crnatovo Žitorađa')," +
                "(N'Gornje Crniljevosečina')," +
                "(N'Gornje Šlje Jagodina')," +
                "(N'Gornji Adrovac Aleksinac')," +
                "(N'Gornji Banjaniornji Milanovac')," +
                "(N'Gornji Barbešadžin Han')," +
                "(N'Gornji Branetićiornji Milanovac')," +
                "(N'Gornji Breg Senta')," +
                "(N'Gornji Bunibrod Leskovac')," +
                "(N'Gornji Bučumet Medveđa')," +
                "(N'Gornji Vratari Aleksandrovac')," +
                "(N'Gornjiajtan Medveđa')," +
                "(N'Gornjirabovacbilić')," +
                "(N'Gornji Dejan Vlasotince')," +
                "(N'Gornji Dobrić Loznica')," +
                "(N'Gornji Drenovac Žitorađa')," +
                "(N'Gornji DuBač Lučani')," +
                "(N'Gornji Dubič Trstenik')," +
                "(N'Gornji Dušnikadžin Han')," +
                "(N'Gornji Zabeljlogovac')," +
                "(N'Gornji Jasenovik Zubin Potok')," +
                "(N'Gornji Katun Varvarin')," +
                "(N'Gornji Kozji Dol Trgovište')," +
                "(N'Gornji Komren Niš – Crveni krst')," +
                "(N'Gornji Krivodol Dimitrovgrad')," +
                "(N'Gornji Krnjin Leposavić')," +
                "(N'Gornji Krstacora')," +
                "(N'Gornji Krupac Aleksinac')," +
                "(N'Gornji Krčin Varvarin')," +
                "(N'Gornji Lajkovac Mionica')," +
                "(N'Gornji Livočnjilane')," +
                "(N'Gornji Lipovac Brus')," +
                "(N'Gornji Ljubeš Aleksinac')," +
                "(N'Gornji Makrešnjilane')," +
                "(N'Gornji Matejevac Niš – Pantelej')," +
                "(N'Gornji Milanovacornji Milanovac')," +
                "(N'Gornji Mušić Mionica')," +
                "(N'Gornji Neradovac Vranje')," +
                "(N'Gornjibilić Srbica')," +
                "(N'Gornjirah Vlasotince')," +
                "(N'Gornji Petrič Klina')," +
                "(N'Gornji Prisjan Vlasotince')," +
                "(N'Gornji Ratiš Dečani')," +
                "(N'Gornji Račnik Jagodina')," +
                "(N'Gornji Ribnik Trstenik')," +
                "(N'Gornji Rinj Bela Palanka')," +
                "(N'Gornji Svračak Vučitrn')," +
                "(N'Gornji Sibovac Podujevo')," +
                "(N'Gornji Stajevac Trgovište')," +
                "(N'Gornji Statovac Prokuplje')," +
                "(N'Gornji Stepoš Kruševac')," +
                "(N'Gornji Stranjani Prijepolje')," +
                "(N'Gornji Streoc Dečani')," +
                "(N'Gornji Striževac Babušnica')," +
                "(N'Gornji Strmac Zubin Potok')," +
                "(N'Gornji Stupanj Aleksandrovac')," +
                "(N'Gornji Suvi Do Kosovska Mitrovica')," +
                "(N'Gornji Tavankut Subotica')," +
                "(N'Gornji Crniš Tutin')," +
                "(N'Gornji Crnobreg Dečani')," +
                "(N'Gorobilje Požega')," +
                "(N'Gorovič Topola')," +
                "(N'Gorožup Prizren')," +
                "(N'Gorčince Babušnica')," +
                "(N'Gospođince Preševo')," +
                "(N'Gospođinci Žabalj')," +
                "(N'Gostilje Čajetina')," +
                "(N'Gostinica Užice')," +
                "(N'Gostiradiće Raška')," +
                "(N'Gostun Prijepolje')," +
                "(N'Gostuša Pirot')," +
                "(N'Gotovuša Štrpce')," +
                "(N'Goč Vrnjačka Banja')," +
                "(N'Goševo Novi Pazar')," +
                "(N'Goševo Sjenica')," +
                "(N'Grab Lučani')," +
                "(N'Grabanica Klina')," +
                "(N'GraBač Klina')," +
                "(N'Grabovac Beograd –brenovac')," +
                "(N'Grabovac Knić')," +
                "(N'Grabovac Prokuplje')," +
                "(N'Grabovac Svilajnac')," +
                "(N'Grabovac Trstenik')," +
                "(N'Grabovac Peć')," +
                "(N'Grabovac Zvečan')," +
                "(N'Grabovicaornji Milanovac')," +
                "(N'Grabovica Despotovac')," +
                "(N'Grabovica Kladovo')," +
                "(N'Grabovica Sjenica')," +
                "(N'Grabovnica Kuršumlija')," +
                "(N'Grabovo Ražanj')," +
                "(N'Grabovo Beočin')," +
                "(N'Grabovci Ruma')," +
                "(N'Grad Brus')," +
                "(N'Grad Stalać Ćićevac')," +
                "(N'Gradac Batočina')," +
                "(N'Gradac Brus')," +
                "(N'Gradac Ivanjica')," +
                "(N'Gradac Raška')," +
                "(N'Gradac Sjenica')," +
                "(N'Gradac Tutin')," +
                "(N'Gradašnica Leskovac')," +
                "(N'Gradašnica Pirot')," +
                "(N'Gradinje Dimitrovgrad')," +
                "(N'Gradicalogovac')," +
                "(N'Gradište Bela Palanka')," +
                "(N'Gradište Vlasotince')," +
                "(N'Gradište Knjaževac')," +
                "(N'Gradište Merošina')," +
                "(N'Gradište Pirot')," +
                "(N'Gradnja Vranje')," +
                "(N'Gradojević Koceljeva')," +
                "(N'Gradska Crna Trava')," +
                "(N'Gradskovo Zaječar')," +
                "(N'Građanoviće Novi Pazar')," +
                "(N'Građenik Kosovska Kamenica')," +
                "(N'Graždanik Prizren')," +
                "(N'Grajevce Leskovac')," +
                "(N'Gramada Bujanovac')," +
                "(N'Gramađe Vladičin Han')," +
                "(N'Gramočelj Dečani')," +
                "(N'Granica Bojnik')," +
                "(N'Granice Beograd – Mladenovac')," +
                "(N'Graničane Leposavić')," +
                "(N'Graovo Leskovac')," +
                "(N'Grapa Dimitrovgrad')," +
                "(N'Grace Vučitrn')," +
                "(N'Gračane Novi Pazar')," +
                "(N'Gračanica Ljubovija')," +
                "(N'Gračanica Prijepolje')," +
                "(N'Gračanica Priština')," +
                "(N'Gračac Vrnjačka Banja')," +
                "(N'Graševci Brus')," +
                "(N'Graštica Priština')," +
                "(N'Grbavce Medveđa')," +
                "(N'Grbavče Svrljig')," +
                "(N'Grgaje Sjenica')," +
                "(N'Grgetek Irig')," +
                "(N'Grgoc Đakovica')," +
                "(N'Grgurevci Sremska Mitrovica')," +
                "(N'Grgurovce Lebane')," +
                "(N'Grdanica Leskovac')," +
                "(N'Grdelica (varoš) Leskovac')," +
                "(N'Grdelica (selo) Leskovac')," +
                "(N'Grdica Kraljevo')," +
                "(N'Grdovac Podujevo')," +
                "(N'Grdovići Arilje')," +
                "(N'Grebenac Bela Crkva')," +
                "(N'Grebnik Klina')," +
                "(N'Grebno Uroševac')," +
                "(N'Grevci Kruševac')," +
                "(N'Gredetin Aleksinac')," +
                "(N'Grezna Knjaževac')," +
                "(N'Grejač Aleksinac')," +
                "(N'Grejkovce Suva Reka')," +
                "(N'Grejčevce Suva Reka')," +
                "(N'Grivac Knić')," +
                "(N'Grivska Arilje')," +
                "(N'Grižani Zvečan')," +
                "(N'Grizime Kosovska Kamenica')," +
                "(N'Grkaje Leposavić')," +
                "(N'Grkinjaadžin Han')," +
                "(N'Grkljane Kruševac')," +
                "(N'Grlica Uroševac')," +
                "(N'Grlište Zaječar')," +
                "(N'Grljan Zaječar')," +
                "(N'Grmovo Vitina')," +
                "(N'Grnčar Babušnica')," +
                "(N'Grnčar Vitina')," +
                "(N'Grnčara Loznica')," +
                "(N'Grnčare Prizren')," +
                "(N'Grobnice Prijepolje')," +
                "(N'Groznatovci Surdulica')," +
                "(N'Grocka Beograd –rocka')," +
                "(N'Grošnica Kragujevac')," +
                "(N'Grubetiće Novi Pazar')," +
                "(N'Grudaš Žitorađa')," +
                "(N'Gruža Knić')," +
                "(N'Grujinci Bosilegrad')," +
                "(N'Grušić ŠaBač')," +
                "(N'Grčak Aleksandrovac')," +
                "(N'Grčac Smederevska Palanka')," +
                "(N'Grčina Đakovica')," +
                "(N'Grčić Ljubovija')," +
                "(N'Gubavce Medveđa')," +
                "(N'Guberevac Beograd – Sopot')," +
                "(N'Guberevac Knić')," +
                "(N'Guberevac Leskovac')," +
                "(N'Guberevci Lučani')," +
                "(N'Gubetin Prokuplje')," +
                "(N'Gubin Do Užice')," +
                "(N'Guvnište Leposavić')," +
                "(N'Guvno Selo Lipljan')," +
                "(N'Gugalj Požega')," +
                "(N'Gudurica Vršac')," +
                "(N'Gujiće Tutin')," +
                "(N'Gukoš Ljig')," +
                "(N'Gulenovci Dimitrovgrad')," +
                "(N'Gulijan Svrljig')," +
                "(N'Gulije Leposavić')," +
                "(N'Gumerište Vranje')," +
                "(N'Gumnište Vučitrn')," +
                "(N'Gumništenjilane')," +
                "(N'Gunaroš Bačka Topola')," +
                "(N'Guncat Suva Reka')," +
                "(N'Guncati Beograd – Barajevo')," +
                "(N'Guncati Knić')," +
                "(N'Gunjacisečina')," +
                "(N'Gunjevac Ub')," +
                "(N'Gunjetina Vlasotince')," +
                "(N'Gunjica Mionica')," +
                "(N'Gurgutovo Medveđa')," +
                "(N'Gurdijelje Tutin')," +
                "(N'Guriševci Topola')," +
                "(N'Guska Đakovica')," +
                "(N'Guceviće Tutin')," +
                "(N'Guča (varošica) Lučani')," +
                "(N'Guča (selo) Lučani')," +
                "(N'Gušavac Kosovska Mitrovica')," +
                "(N'Guševac Svrljig')," +
                "(N'Gušica Vitina')," +
                "(N'Dabinovac Kuršumlija')," +
                "(N'Dabiševac Priština')," +
                "(N'Davidovac Vranje')," +
                "(N'Davidovac Kladovo')," +
                "(N'Davidovac Paraćin')," +
                "(N'Davidovac Svrljig')," +
                "(N'Davidovicaornji Milanovac')," +
                "(N'Davidovce Štimlje')," +
                "(N'Dadince Vlasotince')," +
                "(N'Daždince Kosovska Kamenica')," +
                "(N'Dajići Ivanjica')," +
                "(N'Dajkovce Kosovska Kamenica')," +
                "(N'Dalašaj Đakovica')," +
                "(N'Damjane Đakovica')," +
                "(N'Dankoviće Kuršumlija')," +
                "(N'Danjanerahovac')," +
                "(N'Danjino Selo Surdulica')," +
                "(N'Darkovce Crna Trava')," +
                "(N'Darosava Aranđelovac')," +
                "(N'Dašinovac Dečani')," +
                "(N'Dašnica Aleksandrovac')," +
                "(N'Dašnica Aleksinac')," +
                "(N'Dvorane Kruševac')," +
                "(N'Dvorane Suva Reka')," +
                "(N'Dvorica Ćuprija')," +
                "(N'DvorišteoluBač')," +
                "(N'Dvorište Despotovac')," +
                "(N'Dvorište ŠaBač')," +
                "(N'Dvorište Podujevo')," +
                "(N'Dvorska Krupanj')," +
                "(N'Debelde Vitina')," +
                "(N'Debeli Lug Žitorađa')," +
                "(N'Debeli Lug Majdanpek')," +
                "(N'Debelica Knjaževac')," +
                "(N'Debelja Nova Varoš')," +
                "(N'Debeljača Kovačica')," +
                "(N'Debrc Vladimirci')," +
                "(N'Deva Đakovica')," +
                "(N'Devaja Vitina')," +
                "(N'Devet Jugovića Priština')," +
                "(N'Devetak Štimlje')," +
                "(N'Deveti maj Niš – Palilula')," +
                "(N'Devići Ivanjica')," +
                "(N'Devreč Tutin')," +
                "(N'Devča Merošina')," +
                "(N'Degrmen Kuršumlija')," +
                "(N'Degurić Valjevo')," +
                "(N'Dedaj Prizren')," +
                "(N'Dedevci Kraljevo')," +
                "(N'Dedina Kruševac')," +
                "(N'Dedina Bara Leskovac')," +
                "(N'Dedinac Kuršumlija')," +
                "(N'Dedinje Kosovska Mitrovica')," +
                "(N'Deževa Novi Pazar')," +
                "(N'Deič Klina')," +
                "(N'Dejanovac Knjaževac')," +
                "(N'Dejance Trgovište')," +
                "(N'Dekutince Vladičin Han')," +
                "(N'Deliblato Kovin')," +
                "(N'Deligrad Aleksinac')," +
                "(N'Delimeđe Tutin')," +
                "(N'Delovce Suva Reka')," +
                "(N'Deonica Jagodina')," +
                "(N'Depce Preševo')," +
                "(N'Deretin Ivanjica')," +
                "(N'Deronjedžaci')," +
                "(N'Desetak Leposavić')," +
                "(N'Desivojce Kosovska Kamenica')," +
                "(N'Desimirovac Kragujevac')," +
                "(N'Desine Velikoradište')," +
                "(N'Desić ŠaBač')," +
                "(N'Despotovac Despotovac')," +
                "(N'Despotovo Bačka Palanka')," +
                "(N'Detane Tutin')," +
                "(N'Deč Pećinci')," +
                "(N'Dečane Dečani')," +
                "(N'Dešilovo Merošina')," +
                "(N'Dešiška Kuršumlija')," +
                "(N'Divljaka Lipljan')," +
                "(N'Divljana Bela Palanka')," +
                "(N'Divostin Kragujevac')," +
                "(N'Divoš Sremska Mitrovica')," +
                "(N'Divci Valjevo')," +
                "(N'Divci Prijepolje')," +
                "(N'Divčibare Valjevo')," +
                "(N'Dikava Surdulica')," +
                "(N'Dikanceora')," +
                "(N'Dimitrovgrad Dimitrovgrad')," +
                "(N'Dimce Kačanik')," +
                "(N'Dići Ljig')," +
                "(N'Dljin Lučani')," +
                "(N'Dobanovci Beograd – Surčin')," +
                "(N'Doblibare Đakovica')," +
                "(N'DobraoluBač')," +
                "(N'Dobra Voda Bojnik')," +
                "(N'Dobra Voda Jagodina')," +
                "(N'Dobra Voda Klina')," +
                "(N'Dobra Luka Vučitrn')," +
                "(N'Dobrava Leposavić')," +
                "(N'Dobrača Kragujevac')," +
                "(N'Dobrače Arilje')," +
                "(N'Dobrejance Vranje')," +
                "(N'Dobri Do Ivanjica')," +
                "(N'Dobri Do Kuršumlija')," +
                "(N'Dobri Do Pirot')," +
                "(N'Dobri Do Smederevo')," +
                "(N'Dobri Do Peć')," +
                "(N'Dobri Do Podujevo')," +
                "(N'Dobri Dol Klina')," +
                "(N'Dobri Dolrahovac')," +
                "(N'Dobri Dub Tutin')," +
                "(N'Dobri Dub Kosovo Polje')," +
                "(N'Dobrilovići Priboj')," +
                "(N'Dobrinci Ruma')," +
                "(N'Dobrinje Tutin')," +
                "(N'Dobrić ŠaBač')," +
                "(N'Dobrić Đakovica')," +
                "(N'Dobrica Alibunar')," +
                "(N'Dobričevo Bela Crkva')," +
                "(N'Dobrnje Petrova na Mlavi')," +
                "(N'Dobro Polje Boljevac')," +
                "(N'Dobro Polje Crna Trava')," +
                "(N'Dobroviš Vlasotince')," +
                "(N'Dobrovodica Batočina')," +
                "(N'Dobrodeljane Suva Reka')," +
                "(N'Dobrodo Užice')," +
                "(N'Dobrodol Irig')," +
                "(N'Dobroljubci Aleksandrovac')," +
                "(N'Dobromir Kruševac')," +
                "(N'Dobroselica Rekovac')," +
                "(N'Dobroselica Čajetina')," +
                "(N'Dobrosin Bujanovac')," +
                "(N'Dobrotin Bajina Bašta')," +
                "(N'Dobrotin Leskovac')," +
                "(N'Dobrotin Lipljan')," +
                "(N'Dobrotin Podujevo')," +
                "(N'Dobrotić Prokuplje')," +
                "(N'Dobroš Đakovica')," +
                "(N'Dobroševaclogovac')," +
                "(N'Dobroševina Zubin Potok')," +
                "(N'Dobrujevac Aleksinac')," +
                "(N'Dobrujevac Boljevac')," +
                "(N'Dobruša Istok')," +
                "(N'Dobrušte Prizren')," +
                "(N'Dobrčanenjilane')," +
                "(N'Doganica Bosilegrad')," +
                "(N'Doganović Kačanik')," +
                "(N'Doganjevo Uroševac')," +
                "(N'Dojinoviće Novi Pazar')," +
                "(N'Dojkinci Pirot')," +
                "(N'Dojnice Prizren')," +
                "(N'Dokmir Ub')," +
                "(N'Dol Babušnica')," +
                "(N'Dolac Kraljevo')," +
                "(N'Dolac Novi Pazar')," +
                "(N'Dolac Klina')," +
                "(N'Dolac (naselje) Bela Palanka')," +
                "(N'Dolac (selo) Bela Palanka')," +
                "(N'Doline Kanjiža')," +
                "(N'Doliće Sjenica')," +
                "(N'Dolovo Tutin')," +
                "(N'Dolovo Pančevo')," +
                "(N'Dolovo Klina')," +
                "(N'Dolj Đakovica')," +
                "(N'Doljak Vučitrn')," +
                "(N'Doljane Kruševac')," +
                "(N'Doljane Zvečan')," +
                "(N'Doljani Novi Pazar')," +
                "(N'Doljašnica Velikoradište')," +
                "(N'Doljevac Doljevac')," +
                "(N'Domaneklogovac')," +
                "(N'Domanekrahovac')," +
                "(N'Domiševina Brus')," +
                "(N'Domorovce Kosovska Kamenica')," +
                "(N'Donja Badanja Loznica')," +
                "(N'Donja Bejašnica Prokuplje')," +
                "(N'Donja Bela Reka Bor')," +
                "(N'Donja Bela Reka Nova Varoš')," +
                "(N'Donja Bitinja Štrpce')," +
                "(N'Donja Borina Mali Zvornik')," +
                "(N'Donja Bresnica Prokuplje')," +
                "(N'Donja Brnjica Priština')," +
                "(N'Donja Budriganjilane')," +
                "(N'Donja Bukovica Valjevo')," +
                "(N'Donja Bunuša Leskovac')," +
                "(N'Donja Vrbavaornji Milanovac')," +
                "(N'Donja Vrežina Niš – Pantelej')," +
                "(N'Donjalama Bela Palanka')," +
                "(N'Donjaorevnica Čačak')," +
                "(N'Donjaušterica Lipljan')," +
                "(N'Donja Dobrinja Požega')," +
                "(N'Donja Draguša Blace')," +
                "(N'Donja Dubnica Vučitrn')," +
                "(N'Donja Dubnica Podujevo')," +
                "(N'Donja Zleginja Aleksandrovac')," +
                "(N'Donja Jajina Leskovac')," +
                "(N'Donja Jošanica Blace')," +
                "(N'Donja Kamenica Knjaževac')," +
                "(N'Donja Klina Srbica')," +
                "(N'Donja Konjuša Prokuplje')," +
                "(N'Donja Koreticalogovac')," +
                "(N'Donja Koritnica Bela Palanka')," +
                "(N'Donja Kravarica Lučani')," +
                "(N'Donja KruševicaoluBač')," +
                "(N'Donja Krušica Suva Reka')," +
                "(N'Donja Kupinovica Leskovac')," +
                "(N'Donja Lapaštica Medveđa')," +
                "(N'Donja Lapaštica Podujevo')," +
                "(N'Donja Livadica Velika Plana')," +
                "(N'Donja Lisina Bosilegrad')," +
                "(N'Donja Lokošnica Leskovac')," +
                "(N'Donja Lomnica Vlasotince')," +
                "(N'Donja Lopušnja Vlasotince')," +
                "(N'Donja Luka Dečani')," +
                "(N'Donja Ljubata Bosilegrad')," +
                "(N'Donja Ljuboviđa Ljubovija')," +
                "(N'Donja Mikuljana Kuršumlija')," +
                "(N'Donja Mutnica Paraćin')," +
                "(N'Donja Nevlja Dimitrovgrad')," +
                "(N'Donjamašnica Trstenik')," +
                "(N'Donjarovica Ljubovija')," +
                "(N'Donjatulja Vranje')," +
                "(N'Donja Pakaštica Podujevo')," +
                "(N'Donja Peščanica Aleksinac')," +
                "(N'Donja Pološnica Kosjerić')," +
                "(N'Donja Rapčaora')," +
                "(N'Donja Rasovača Merošina')," +
                "(N'Donja Rača Rača')," +
                "(N'Donja Rašica Blace')," +
                "(N'Donja Rečica Prokuplje')," +
                "(N'Donja Ržana Bosilegrad')," +
                "(N'Donja Sabanta Kragujevac')," +
                "(N'Donja Sipulja Loznica')," +
                "(N'Donja Slatina Leskovac')," +
                "(N'Donja Slatina Vitina')," +
                "(N'Donja Sokolovica Knjaževac')," +
                "(N'Donja Srbica Prizren')," +
                "(N'Donja Stražava Prokuplje')," +
                "(N'Donja Stubla Vitina')," +
                "(N'Donja Studena Niš – Niška Banja')," +
                "(N'Donja Sudimlja Vučitrn')," +
                "(N'Donja Toponica Prokuplje')," +
                "(N'Donja Toponica Niš – Crveni krst')," +
                "(N'Donja Trepča Čačak')," +
                "(N'Donja Trešnjevica Topola')," +
                "(N'Donja Trešnjica Mali Zvornik')," +
                "(N'Donja Trnava Prokuplje')," +
                "(N'Donja Trnava Topola')," +
                "(N'Donja Trnava Niš – Crveni krst')," +
                "(N'Donja Trnica Trgovište')," +
                "(N'Donja Fušticalogovac')," +
                "(N'Donja Crnišava Trstenik')," +
                "(N'Donja Crnućaornji Milanovac')," +
                "(N'Donja Šatornja Topola')," +
                "(N'Donja Šipašnica Kosovska Kamenica')," +
                "(N'Donja Šušaja Preševo')," +
                "(N'Donje Babine Prijepolje')," +
                "(N'Donje Brijanje Leskovac')," +
                "(N'Donje Varage Zubin Potok')," +
                "(N'Donje Vidovo Paraćin')," +
                "(N'Donje Vinarce Kosovska Mitrovica')," +
                "(N'Donje Vlase Niš – Palilula')," +
                "(N'Donje Vranovce Lebane')," +
                "(N'Donjeadimlje Lipljan')," +
                "(N'Donjeare Vlasotince')," +
                "(N'Donjeodance Štimlje')," +
                "(N'Donjeoračiće Sjenica')," +
                "(N'Donjerbice Kragujevac')," +
                "(N'Donjergure Blace')," +
                "(N'Donje Dobrevo Kosovo Polje')," +
                "(N'Donje Dragovljeadžin Han')," +
                "(N'Donje Žabare Kosovska Mitrovica')," +
                "(N'Donje Žapsko Vranje')," +
                "(N'Donje Zuniče Knjaževac')," +
                "(N'Donje Isevo Leposavić')," +
                "(N'Donje Jabukovo Vladičin Han')," +
                "(N'Donje Jarušice Rača')," +
                "(N'Donje Karačevo Kosovska Kamenica')," +
                "(N'Donje Komarice Kragujevac')," +
                "(N'Donje Konjuvce Bojnik')," +
                "(N'Donje Kordince Prokuplje')," +
                "(N'Donje Korminjane Kosovska Kamenica')," +
                "(N'Donje Krajince Leskovac')," +
                "(N'Donje Krnjino Babušnica')," +
                "(N'Donje Leviće Brus')," +
                "(N'Donje Leskovice Valjevo')," +
                "(N'Donje Lopiže Sjenica')," +
                "(N'Donje Ljubinje Prizren')," +
                "(N'Donje Ljupče Podujevo')," +
                "(N'Donje Međurovo Niš – Palilula')," +
                "(N'Donje Nedeljice Loznica')," +
                "(N'Donje Nerodimlje Uroševac')," +
                "(N'Donje Novo Selo Bujanovac')," +
                "(N'Donje Novo Selo Đakovica')," +
                "(N'Donjebrinje Srbica')," +
                "(N'Donje Potočanerahovac')," +
                "(N'Donje Prekaze Srbica')," +
                "(N'Donje Punoševce Vranje')," +
                "(N'Donje Ramnjane Vitina')," +
                "(N'Donje Rataje Aleksandrovac')," +
                "(N'Donje Rašane Kosovska Mitrovica')," +
                "(N'Donje Romanovce Surdulica')," +
                "(N'Donje Svarče Blace')," +
                "(N'Donje Sinkovce Leskovac')," +
                "(N'Donje Slakovcenjilane')," +
                "(N'Donje Stanovce Vučitrn')," +
                "(N'Donje Stopanje Leskovac')," +
                "(N'Donje Suhotno Aleksinac')," +
                "(N'Donje Tlamino Bosilegrad')," +
                "(N'Donje Točane Kuršumlija')," +
                "(N'Donje Trebešinje Vranje')," +
                "(N'Donje Trnjane Leskovac')," +
                "(N'Donje Crnatovo Žitorađa')," +
                "(N'Donje Crniljevo Koceljeva')," +
                "(N'Donje Šlje Jagodina')," +
                "(N'Donji Adrovac Aleksinac')," +
                "(N'Donji Banjani Ljig')," +
                "(N'Donji Barbešadžin Han')," +
                "(N'Donji Biteš Đakovica')," +
                "(N'Donji Branetićiornji Milanovac')," +
                "(N'Donji Bunibrod Leskovac')," +
                "(N'Donji Bučumet Medveđa')," +
                "(N'Donji Vratari Aleksandrovac')," +
                "(N'Donjiajtan Medveđa')," +
                "(N'Donjirabovac Kosovo Polje')," +
                "(N'Donji Dejan Vlasotince')," +
                "(N'Donji Dobrić Loznica')," +
                "(N'Donji Drenovac Žitorađa')," +
                "(N'Donji DuBač Lučani')," +
                "(N'Donji Dubič Trstenik')," +
                "(N'Donji Dušnikadžin Han')," +
                "(N'Donji Zabeljlogovac')," +
                "(N'Donji Istok Istok')," +
                "(N'Donji Jasenovik Zubin Potok')," +
                "(N'Donji Katun Varvarin')," +
                "(N'Donji Kozji Dol Trgovište')," +
                "(N'Donji Komren Niš – Crveni krst')," +
                "(N'Donji Krivodol Dimitrovgrad')," +
                "(N'Donji Krnjin Leposavić')," +
                "(N'Donji Krstacora')," +
                "(N'Donji Krupac Aleksinac')," +
                "(N'Donji Krčin Varvarin')," +
                "(N'Donji Lajkovac Lajkovac')," +
                "(N'Donji Livočnjilane')," +
                "(N'Donji Lipovac Brus')," +
                "(N'Donji Ljubeš Aleksinac')," +
                "(N'Donji Makrešnjilane')," +
                "(N'Donji Matejevac Niš – Pantelej')," +
                "(N'Donji Milanovac Majdanpek')," +
                "(N'Donji Mušić Mionica')," +
                "(N'Donji Neradovac Vranje')," +
                "(N'Donjibilić Srbica')," +
                "(N'Donji Petrič Klina')," +
                "(N'Donji Petrovci Ruma')," +
                "(N'Donji Prisjan Vlasotince')," +
                "(N'Donji Ratiš Dečani')," +
                "(N'Donji Račnik Jagodina')," +
                "(N'Donji Ribnik Trstenik')," +
                "(N'Donji Rinj Bela Palanka')," +
                "(N'Donji Svračak Vučitrn')," +
                "(N'Donji Sibovac Podujevo')," +
                "(N'Donji Stajevac Trgovište')," +
                "(N'Donji Statovac Prokuplje')," +
                "(N'Donji Stepoš Kruševac')," +
                "(N'Donji Stranjani Prijepolje')," +
                "(N'Donji Streoc Dečani')," +
                "(N'Donji Striževac Babušnica')");
                  migrationBuilder.Sql(
                "insert into Mesta(NazivMesta) values " +
                "(N'Donji Stupanj Aleksandrovac')," +
                "(N'Donji Suvi Do Kosovska Mitrovica')," +
                "(N'Donji Tavankut Subotica')," +
                "(N'Donji Tovarnik Pećinci')," +
                "(N'Donji Crnobreg Dečani')," +
                "(N'Doroslovo Sombor')," +
                "(N'Doševac Srbica')," +
                "(N'Draga Tutin')," +
                "(N'Dragaljice Zubin Potok')," +
                "(N'Draganacnjilane')," +
                "(N'Draganići Raška')," +
                "(N'Dragašora')," +
                "(N'Dragi Deo Prokuplje')," +
                "(N'Dragijevicasečina')," +
                "(N'Draginac Babušnica')," +
                "(N'Draginac Loznica')," +
                "(N'Draginje Koceljeva')," +
                "(N'Draglica Nova Varoš')," +
                "(N'Dragobiljerahovac')," +
                "(N'Dragobraća Kragujevac')," +
                "(N'Dragobužde Vranje')," +
                "(N'Dragovac Bojnik')," +
                "(N'Dragovac Požarevac')," +
                "(N'Dragovac Priština')," +
                "(N'Dragovita Dimitrovgrad')," +
                "(N'Dragovo Rekovac')," +
                "(N'Dragodolsečina')," +
                "(N'Dragojevac Arilje')," +
                "(N'Dragojevac Vladimirci')," +
                "(N'Dragojloviće Sjenica')," +
                "(N'Dragoljornji Milanovac')," +
                "(N'Dragoljevac Istok')," +
                "(N'Dragosinjci Kraljevo')," +
                "(N'Dragocvet Jagodina')," +
                "(N'Dragočevo Novi Pazar')," +
                "(N'Dragoševac Jagodina')," +
                "(N'Dragušica Knić')," +
                "(N'Dražanj Beograd –rocka')," +
                "(N'Draževac Aleksinac')," +
                "(N'Draževac Beograd –brenovac')," +
                "(N'Draževiće Sjenica')," +
                "(N'Draževići Nova Varoš')," +
                "(N'Draževo Bela Palanka')," +
                "(N'Dražiniće Kraljevo')," +
                "(N'Dražinovići Požega')," +
                "(N'Dražmirovac Jagodina')," +
                "(N'Drainoviće Zubin Potok')," +
                "(N'Drajinac Svrljig')," +
                "(N'Drajinci Surdulica')," +
                "(N'Drajkovce Štrpce')," +
                "(N'Drajčići Prizren')," +
                "(N'Draksin Bajina Bašta')," +
                "(N'Drakčići Kraljevo')," +
                "(N'Dramiće Novi Pazar')," +
                "(N'Dramnjak Uroševac')," +
                "(N'Drača Kragujevac')," +
                "(N'Dračić Valjevo')," +
                "(N'Draškovac Leskovac')," +
                "(N'Drvare Vučitrn')," +
                "(N'Drvnik Knjaževac')," +
                "(N'Drvodelj Lebane')," +
                "(N'Drvodelja Leskovac')," +
                "(N'Drežnik Užice')," +
                "(N'Drežnica Bujanovac')," +
                "(N'Drelje Peć')," +
                "(N'Dren Beograd – Lazarevac')," +
                "(N'Dren Beograd –brenovac')," +
                "(N'Dren Zubin Potok')," +
                "(N'Dren Leposavić')," +
                "(N'Drenova Brus')," +
                "(N'Drenovaornji Milanovac')," +
                "(N'Drenova Prijepolje')," +
                "(N'Drenova Čajetina')," +
                "(N'Drenovalava Kačanik')," +
                "(N'Drenovac Vranje')," +
                "(N'Drenovac Knjaževac')," +
                "(N'Drenovac Kragujevac')," +
                "(N'Drenovac Paraćin')," +
                "(N'Drenovac Prokuplje')," +
                "(N'Drenovac ŠaBač')," +
                "(N'Drenovac Dečani')," +
                "(N'Drenovac Klina')," +
                "(N'Drenovacrahovac')," +
                "(N'Drenovac Priština')," +
                "(N'Drenovce Kosovska Kamenica')," +
                "(N'Drenovci Kosjerić')," +
                "(N'Drenovčić Klina')," +
                "(N'Drence Medveđa')," +
                "(N'Drenča Aleksandrovac')," +
                "(N'Drenje Istok')," +
                "(N'Drečinovac Knjaževac')," +
                "(N'Drešnica Blace')," +
                "(N'Držanovac Žitorađa')," +
                "(N'Držina Pirot')," +
                "(N'Drijetanj Užice')," +
                "(N'Drlače Ljubovija')," +
                "(N'Drlupa Beograd – Sopot')," +
                "(N'Drlupa Kraljevo')," +
                "(N'Drmanovići Nova Varoš')," +
                "(N'Drmno Požarevac')," +
                "(N'Drobeš Vitina')," +
                "(N'Drobnjak Kačanik')," +
                "(N'Drsnik Klina')," +
                "(N'Drtevci Brus')," +
                "(N'Drćevac Leskovac')," +
                "(N'Drugovac Smederevo')," +
                "(N'Družetić Koceljeva')," +
                "(N'Družetićiornji Milanovac')," +
                "(N'Družiniće Sjenica')," +
                "(N'Dub Bajina Bašta')," +
                "(N'Dublje Bogatić')," +
                "(N'Dublje Svilajnac')," +
                "(N'Dublje Trstenik')," +
                "(N'Dubnica Vranje')," +
                "(N'Dubnica Kosjerić')," +
                "(N'Dubnica Svilajnac')," +
                "(N'Dubnica Sjenica')," +
                "(N'Dubovac Kovin')," +
                "(N'Dubovac Vučitrn')," +
                "(N'Dubovik Dečani')," +
                "(N'Dubovo Žitorađa')," +
                "(N'Dubovo Tutin')," +
                "(N'Dubovo Peć')," +
                "(N'Duboka Kučevo')," +
                "(N'Duboka Jagodina')," +
                "(N'Duboka Leposavić')," +
                "(N'Duboko Ljubovija')," +
                "(N'Duboko Užice')," +
                "(N'Dubona Beograd – Mladenovac')," +
                "(N'Dubočak Peć')," +
                "(N'Dubočane Zaječar')," +
                "(N'Dubočka Petrova na Mlavi')," +
                "(N'Dubrava Bojnik')," +
                "(N'Dubrava Ivanjica')," +
                "(N'Dubrava Knić')," +
                "(N'Dubrava Kuršumlija')," +
                "(N'Dubrava Dečani')," +
                "(N'Dubrava Istok')," +
                "(N'Dubrava Kačanik')," +
                "(N'Dubrava Suva Reka')," +
                "(N'Dubravica Požarevac')," +
                "(N'Duvanište ŠaBač')," +
                "(N'Duga Štimlje')," +
                "(N'Duga Luka Vranjska Banja')," +
                "(N'Duga Poljanaadžin Han')," +
                "(N'Duga Poljana Sjenica')," +
                "(N'Duganjive Peć')," +
                "(N'Dugi Del Surdulica')," +
                "(N'Dugo Polje Sokobanja')," +
                "(N'Dugojnica Surdulica')," +
                "(N'Dugonjive Klina')," +
                "(N'Dudovica Beograd – Lazarevac')," +
                "(N'Dudulajce Merošina')," +
                "(N'Dužine Plandište')," +
                "(N'Dužnje Đakovica')," +
                "(N'Duz Podujevo')," +
                "(N'Dujak Đakovica')," +
                "(N'Dujke Sjenica')," +
                "(N'Dukat Bosilegrad')," +
                "(N'Dukatadžin Han')," +
                "(N'Dulan Vranje')," +
                "(N'Dulebe Tutin')," +
                "(N'Dulene Kragujevac')," +
                "(N'Dulje Suva Reka')," +
                "(N'Dumbija Trgovište')," +
                "(N'Dumoš Podujevo')," +
                "(N'Dunavac Beograd – Palilula')," +
                "(N'Dunavonjilane')," +
                "(N'Dunišiće Sjenica')," +
                "(N'Dupeljevo Vranje')," +
                "(N'Dupljaj Valjevo')," +
                "(N'Dupljaja Bela Crkva')," +
                "(N'Dupljane Vladičin Han')," +
                "(N'Dupljane Negotin')," +
                "(N'Dupci Brus')," +
                "(N'Dura Kačanik')," +
                "(N'Dučalovići Lučani')," +
                "(N'Dučevac Babušnica')," +
                "(N'Dučina Beograd – Sopot')," +
                "(N'Dučić Mionica')," +
                "(N'Duš Klina')," +
                "(N'Dušanovac Negotin')," +
                "(N'Dušanovo Leskovac')," +
                "(N'Dušanovo Prizren')," +
                "(N'Dušević Klina')," +
                "(N'Duškovci Požega')," +
                "(N'DušmanićoluBač')," +
                "(N'Dušmanići Prijepolje')," +
                "(N'Đake Kuršumlija')," +
                "(N'Đakovica Đakovica')," +
                "(N'Đakovo Kraljevo')," +
                "(N'Đakus Žitorađa')," +
                "(N'Đala Novi Kneževac')," +
                "(N'Đelekare Vitina')," +
                "(N'Đeneral Janković Kačanik')," +
                "(N'Đerađ Lučani')," +
                "(N'Đerekare Brus')," +
                "(N'Đerekare Tutin')," +
                "(N'Đerekarce Trgovište')," +
                "(N'Đinđuša Bojnik')," +
                "(N'Đinovce Suva Reka')," +
                "(N'Đonaj Prizren')," +
                "(N'Đorđevac Bujanovac')," +
                "(N'Đocaj Dečani')," +
                "(N'Đulekare Medveđa')," +
                "(N'Đunis Kruševac')," +
                "(N'Đurakovac Istok')," +
                "(N'Đurakovo Velikoradište')," +
                "(N'Đurašići Prijepolje')," +
                "(N'Đurđev Dol Kačanik')," +
                "(N'Đurđevac Mionica')," +
                "(N'Đurđevo Rača')," +
                "(N'Đurđevo Žabalj')," +
                "(N'Đurđin Subotica')," +
                "(N'Đurevac Blace')," +
                "(N'Đurinac Svilajnac')," +
                "(N'Đurinac Svrljig')," +
                "(N'Đurinci Beograd – Sopot')," +
                "(N'Đuriselo Kragujevac')," +
                "(N'Đuriševce Kosovska Kamenica')," +
                "(N'Đurkovce Štimlje')," +
                "(N'Đurovac Prokuplje')," +
                "(N'Đušnica Prokuplje')," +
                "(N'Eleza Kačanik')," +
                "(N'Elemir Zrenjanin')," +
                "(N'Ence Kosovo Polje')," +
                "(N'Ervenice Tutin')," +
                "(N'Erdevik Šid')," +
                "(N'Erdeč Kragujevac')," +
                "(N'Ereč Đakovica')," +
                "(N'Erčege Ivanjica')," +
                "(N'Ečka Zrenjanin')," +
                "(N'Žabalj Žabalj')," +
                "(N'Žabar ŠaBač')," +
                "(N'Žabare Kruševac')," +
                "(N'Žabare Topola')," +
                "(N'Žabari Valjevo')," +
                "(N'Žabari Žabari')," +
                "(N'Žabelj Đakovica')," +
                "(N'Žabljane Leskovac')," +
                "(N'Žabren Sjenica')," +
                "(N'Žagubica Žagubica')," +
                "(N'Žaža Zvečan')," +
                "(N'Žakovo Istok')," +
                "(N'Žalica Kuršumlija')," +
                "(N'Žaočani Čačak')," +
                "(N'Žarevo Brus')," +
                "(N'Žarevo Zubin Potok')," +
                "(N'Žarkovac Ruma')," +
                "(N'Žač Istok')," +
                "(N'Žbevac Bujanovac')," +
                "(N'Ždeglovo Lebane')," +
                "(N'Ždrelo Petrova na Mlavi')," +
                "(N'Ždrelo Đakovica')," +
                "(N'Žegovacnjilane')," +
                "(N'Žegovačka Vrbicanjilane')," +
                "(N'Žegranjilane')," +
                "(N'Žegrova Kuršumlija')," +
                "(N'Željevo Svrljig')," +
                "(N'Željine Čajetina')," +
                "(N'Željuša Dimitrovgrad')," +
                "(N'Žeravino Bosilegrad')," +
                "(N'Žerađe Raška')," +
                "(N'Žerovnica Zvečan')," +
                "(N'Živinice Priboj')," +
                "(N'Živinjane Prizren')," +
                "(N'Živica Lučani')," +
                "(N'Živica Požarevac')," +
                "(N'Živkovac Beograd –rocka')," +
                "(N'Živkovo Leskovac')," +
                "(N'Živkovci Ljig')," +
                "(N'Židilje Despotovac')," +
                "(N'Žižavica Leskovac')," +
                "(N'Žilivoda Vučitrn')," +
                "(N'Žilinci Brus')," +
                "(N'Žiljci Brus')," +
                "(N'Žirovnica Batočina')," +
                "(N'Žirče Tutin')," +
                "(N'Žitinje Vitina')," +
                "(N'Žitinje Podujevo')," +
                "(N'Žitište Žitište')," +
                "(N'Žitkovac Aleksinac')," +
                "(N'Žitkovac Zvečan')," +
                "(N'ŽitkovicaoluBač')," +
                "(N'Žitni Potok Prokuplje')," +
                "(N'Žitniće Sjenica')," +
                "(N'Žitorađa Žitorađa')," +
                "(N'Žitorađe Vladičin Han')," +
                "(N'Žiča Kraljevo')," +
                "(N'Žlne Knjaževac')," +
                "(N'Žub Đakovica')," +
                "(N'Žuželjica Bujanovac')," +
                "(N'Žuja Kosovska Kamenica')," +
                "(N'Žujince Preševo')," +
                "(N'Žukovac Knjaževac')," +
                "(N'Žunje Brus')," +
                "(N'Žunje Knić')," +
                "(N'Žunjeviće Novi Pazar')," +
                "(N'Župa Tutin')," +
                "(N'Županjac Beograd – Lazarevac')," +
                "(N'Županjevac Rekovac')," +
                "(N'Žur Prizren')," +
                "(N'Žutice Raška')," +
                "(N'Žuč Kuršumlija')," +
                "(N'Žuče Tutin')," +
                "(N'Žučkovac Sokobanja')," +
                "(N'Zablaće Čačak')," +
                "(N'Zablaće ŠaBač')," +
                "(N'Zablaće Istok')," +
                "(N'Zabojnica Knić')," +
                "(N'Zabrdica Valjevo')," +
                "(N'Zabrdnji Toci Prijepolje')," +
                "(N'Zabrđe Novi Pazar')," +
                "(N'Zabrđe Petrova na Mlavi')," +
                "(N'Zabrđe Priboj')," +
                "(N'Zabrđe Sjenica')," +
                "(N'Zabrđe Klina')," +
                "(N'Zabrđe Leposavić')," +
                "(N'Zabrđe Kosovska Mitrovica')," +
                "(N'Zabrega Malo Crniće')," +
                "(N'Zabrega Paraćin')," +
                "(N'Zabrežje Beograd –brenovac')," +
                "(N'Zabrnjica Priboj')," +
                "(N'Zavidince Babušnica')," +
                "(N'Zavinograđe Prijepolje')," +
                "(N'Zavlaka Krupanj')," +
                "(N'Zavrata Leposavić')," +
                "(N'Zagajica Vršac')," +
                "(N'Zaglavak Bajina Bašta')," +
                "(N'Zagorica Topola')," +
                "(N'Zagorje Vučitrn')," +
                "(N'Zagradina Priboj')," +
                "(N'Zagrađeornji Milanovac')," +
                "(N'Zagrađe Zaječar')," +
                "(N'Zagrađe Kuršumlija')," +
                "(N'Zagrađe Zubin Potok')," +
                "(N'Zagrmlje Peć')," +
                "(N'Zagužane Leskovac')," +
                "(N'Zagužanje Surdulica')," +
                "(N'Zagulj Zubin Potok')," +
                "(N'Zajača Loznica')," +
                "(N'Zaječar Zaječar')," +
                "(N'Zaječiće Sjenica')," +
                "(N'Zajmovo Klina')," +
                "(N'Zajčevce Kosovska Kamenica')," +
                "(N'Zaklopača Beograd –rocka')," +
                "(N'Zaklopača Kraljevo')," +
                "(N'Zakut Podujevo')," +
                "(N'Zakuta Kraljevo')," +
                "(N'Zalogovac Varvarin')," +
                "(N'Zalug Prijepolje')," +
                "(N'Zalužnje Leskovac')," +
                "(N'Zamčanje Kraljevo')," +
                "(N'Zaovine Bajina Bašta')," +
                "(N'Zaostro Priboj')," +
                "(N'Zapadni Mojstir Tutin')," +
                "(N'Zaplužje Prizren')," +
                "(N'Zarbince Bujanovac')," +
                "(N'Zarevo Raška')," +
                "(N'Zarožje Bajina Bašta')," +
                "(N'Zarube Valjevo')," +
                "(N'Zasavica I Sremska Mitrovica')," +
                "(N'Zasavica II Sremska Mitrovica')," +
                "(N'Zasad Kraljevo')," +
                "(N'Zasela Kosovska Mitrovica')," +
                "(N'Zaselje Požega')," +
                "(N'Zaskovci Pirot')," +
                "(N'Zaskok Uroševac')," +
                "(N'Zastup Prijepolje')," +
                "(N'Zatonje Velikoradište')," +
                "(N'Zatrićrahovac')," +
                "(N'Zaugline Bajina Bašta')," +
                "(N'Zahać Peć')," +
                "(N'Zahumsko Sjenica')," +
                "(N'Zbojštica Užice')," +
                "(N'Zborce Štimlje')," +
                "(N'Zvezd Vladimirci')," +
                "(N'Zvezdan Zaječar')," +
                "(N'Zvečan Zvečan')," +
                "(N'Zvečka Beograd –brenovac')," +
                "(N'Zvizdar Ub')," +
                "(N'Zvijezd Prijepolje')," +
                "(N'Zvonce Babušnica')," +
                "(N'Zgatar Prizren')," +
                "(N'Zdravinje Kruševac')," +
                "(N'Zdravinje Prokuplje')," +
                "(N'Zdravčići Požega')," +
                "(N'Zebince Vladičin Han')," +
                "(N'Zebince Novo Brdo')," +
                "(N'Zebica Kruševac')," +
                "(N'Zebica Kuršumlija')," +
                "(N'Zelenik Kučevo')," +
                "(N'Zeletovo Bojnik')," +
                "(N'Zemanica Leposavić')," +
                "(N'Zeoke Beograd – Lazarevac')," +
                "(N'Zeoke Lučani')," +
                "(N'Zečeviće Zubin Potok')," +
                "(N'Zijača Kosovska Mitrovica')," +
                "(N'Zjumpoljski Prizren')," +
                "(N'Zjum Has Prizren')," +
                "(N'Zladovac Žitorađa')," +
                "(N'Zladovce Trgovište')," +
                "(N'Zlakusa Užice')," +
                "(N'Zlata Prokuplje')," +
                "(N'Zlatance Crna Trava')," +
                "(N'Zlatare Novi Pazar')," +
                "(N'Zlatare Priština')," +
                "(N'Zlatare Uroševac')," +
                "(N'Zlatari Brus')," +
                "(N'Zlatarić Valjevo')," +
                "(N'Zlatibor Čajetina')," +
                "(N'Zlatićevo Vlasotince')," +
                "(N'Zlatovo Despotovac')," +
                "(N'Zlatokop Vranje')," +
                "(N'Zli Dol Bosilegrad')," +
                "(N'Zli Potokora')," +
                "(N'Zlodol Bajina Bašta')," +
                "(N'Zlokućane Leskovac')," +
                "(N'Zlokućane Klina')," +
                "(N'Zlokućane Lipljan')," +
                "(N'Zlopek Peć')," +
                "(N'Zlot Bor')," +
                "(N'Zloćudovo Leskovac')," +
                "(N'Zmajevo Vrbas')," +
                "(N'Zminjak ŠaBač')," +
                "(N'Zobnatica Bačka Topola')," +
                "(N'Zojić Prizren')," +
                "(N'Zoljevo Leskovac')," +
                "(N'Zorovac Bojnik')," +
                "(N'Zorunovac Knjaževac')," +
                "(N'Zočišterahovac')," +
                "(N'Zrenjanin Zrenjanin')," +
                "(N'Zrzerahovac')," +
                "(N'Zrze Prizren')," +
                "(N'Zrnosek Leposavić')," +
                "(N'Zubetinac Knjaževac')," +
                "(N'Zubin Potok Zubin Potok')," +
                "(N'Zubovac Kruševac')," +
                "(N'Zukve Koceljeva')," +
                "(N'Zulfaj Đakovica')," +
                "(N'Zupče Zubin Potok')," +
                "(N'Zuce Beograd – Voždovac')," +
                "(N'Ibarsko Postenje Leposavić')," +
                "(N'Ivaja Kačanik')," +
                "(N'Ivan Kula Kuršumlija')," +
                "(N'Ivankovac Ćuprija')," +
                "(N'Ivanovo Pančevo')," +
                "(N'Ivanovci Ljig')," +
                "(N'Ivanča Novi Pazar')," +
                "(N'Ivanje Bojnik')," +
                "(N'Ivanje Prijepolje')," +
                "(N'Ivanjica Ivanjica')," +
                "(N'Ivezići Prijepolje')," +
                "(N'Ivkovački Prnjavor Jagodina')," +
                "(N'Iglarevo Klina')," +
                "(N'Igrište Kuršumlija')," +
                "(N'Igrište Leskovac')," +
                "(N'Igroš Brus')," +
                "(N'Idvor Kovačica')," +
                "(N'Iđoš Kikinda')," +
                "(N'Ižance Štrpce')," +
                "(N'Izatovci Dimitrovgrad')," +
                "(N'Izbenica Varvarin')," +
                "(N'Izbica Srbica')," +
                "(N'Izbice Novi Pazar')," +
                "(N'Izbičanj Prijepolje')," +
                "(N'Izbište Vršac')," +
                "(N'Izvarica Žagubica')," +
                "(N'Izvor Babušnica')," +
                "(N'Izvor Bosilegrad')," +
                "(N'Izvor Žitorađa')," +
                "(N'Izvor Paraćin')," +
                "(N'Izvor Pirot')," +
                "(N'Izvor Svrljig')," +
                "(N'Izvor Novo Brdo')," +
                "(N'Izvori Zvečan')," +
                "(N'Izrok Tutin')," +
                "(N'Izumno Vranjska Banja')," +
                "(N'Ilandža Alibunar')," +
                "(N'Ilino Boljevac')," +
                "(N'Ilince Preševo')," +
                "(N'Ilinci Šid')," +
                "(N'Inatovcenjilane')," +
                "(N'Inđija Inđija')," +
                "(N'Inovo Knjaževac')," +
                "(N'Irig Irig')," +
                "(N'Iričići Brus')," +
                "(N'Isakovo Ćuprija')," +
                "(N'Iskrovci Dimitrovgrad')," +
                "(N'Istinić Dečani')," +
                "(N'Istok Istok')," +
                "(N'Istočni Mojstir Tutin')," +
                "(N'Jablanica Boljevac')," +
                "(N'Jablanica Bujanovac')," +
                "(N'Jablanicaornji Milanovac')," +
                "(N'Jablanica Kruševac')," +
                "(N'Jablanica Novi Pazar')," +
                "(N'Jablanica Tutin')," +
                "(N'Jablanica Čajetina')," +
                "(N'Jablanica Đakovica')," +
                "(N'Jablanica Peć')," +
                "(N'Jablanica Prizren')," +
                "(N'Jablanka Vršac')," +
                "(N'Jabuka Prijepolje')," +
                "(N'Jabuka Pančevo')," +
                "(N'Jabuka Zubin Potok')," +
                "(N'Jabukovac Negotin')," +
                "(N'Jabukovik Crna Trava')," +
                "(N'Jabučevo Prokuplje')," +
                "(N'Jabučje Kragujevac')," +
                "(N'Jabučje Lajkovac')," +
                "(N'Javor Novi Pazar')," +
                "(N'Javor Suva Reka')," +
                "(N'Javorje Vlasotince')," +
                "(N'Javorska Ravnaora Ivanjica')," +
                "(N'Jagličjeadžin Han')," +
                "(N'Jagnjenica Zubin Potok')," +
                "(N'Jagnjilo Beograd – Mladenovac')," +
                "(N'Jagnjilo Vladičin Han')," +
                "(N'Jagoda Klina')," +
                "(N'Jagodina Jagodina')," +
                "(N'Jagoštica Bajina Bašta')," +
                "(N'Jadranska Lešnica Loznica')," +
                "(N'Jažince Štrpce')," +
                "(N'Jazak Irig')," +
                "(N'Jazovik Valjevo')," +
                "(N'Jazovnik Vladimirci')," +
                "(N'Jazovo Čoka')," +
                "(N'Jajčić Ljig')," +
                "(N'Jakalj Bajina Bašta')," +
                "(N'Jakovac Knjaževac')," +
                "(N'Jakovlje Aleksinac')," +
                "(N'Jakovljevo Vlasotince')," +
                "(N'Jakovo Beograd – Surčin')," +
                "(N'Jalbotina Pirot')," +
                "(N'Jalovik Vladimirci')," +
                "(N'Jalovik Izvor Knjaževac')," +
                "(N'Jamena Šid')," +
                "(N'Jankov Most Zrenjanin')," +
                "(N'Jankov Potok Zvečan')," +
                "(N'Janoš Đakovica')," +
                "(N'Janošik Alibunar')," +
                "(N'Janča Novi Pazar')," +
                "(N'Jančići Čačak')," +
                "(N'Jančišterahovac')," +
                "(N'Janja Knjaževac')," +
                "(N'Janjevo Lipljan')," +
                "(N'Jarak Sremska Mitrovica')," +
                "(N'Jarebice Loznica')," +
                "(N'Jarebice Tutin')," +
                "(N'Jarešnik Bosilegrad')," +
                "(N'Jarinje Leposavić')," +
                "(N'Jarkovac Sečanj')," +
                "(N'Jarkovci Inđija')," +
                "(N'Jarmenovci Topola')," +
                "(N'Jarsenovo Leskovac')," +
                "(N'Jarčujak Kraljevo')," +
                "(N'Jasenak Beograd –brenovac')," +
                "(N'Jasenica Valjevo')," +
                "(N'Jasenica Žitorađa')," +
                "(N'Jasenica Negotin')," +
                "(N'Jasenov Del Babušnica')," +
                "(N'Jasenovik Niš – Pantelej')," +
                "(N'Jasenovik Novo Brdo')," +
                "(N'Jasenovo Despotovac')," +
                "(N'Jasenovo Nova Varoš')," +
                "(N'Jasenovo Bela Crkva')," +
                "(N'Jasenje Aleksinac')," +
                "(N'Jasika Kruševac')," +
                "(N'Jasikovica Trstenik')," +
                "(N'Jasikovo Majdanpek')," +
                "(N'Jasić Dečani')," +
                "(N'JastreBač Bujanovac')," +
                "(N'JastreBač Vladičin Han')," +
                "(N'JastreBač Vlasotince')," +
                "(N'Jahoc Đakovica')," +
                "(N'Jaša Tomić Sečanj')," +
                "(N'Jašunja Leskovac')," +
                "(N'Jevik Sjenica')," +
                "(N'Jevremovac ŠaBač')," +
                "(N'Ježevica Čačak')," +
                "(N'Jezgroviće Tutin')," +
                "(N'Jezdina Čačak')," +
                "(N'Jezero Despotovac')," +
                "(N'Jezero Sjenica')," +
                "(N'Jezero Sokobanja')," +
                "(N'Jezero Vučitrn')," +
                "(N'Jezerce Uroševac')," +
                "(N'Jelav Loznica')," +
                "(N'Jelakce Leposavić')," +
                "(N'Jelakci Aleksandrovac')," +
                "(N'Jelača Priboj')," +
                "(N'Jelašnica Zaječar')," +
                "(N'Jelašnica Knjaževac')," +
                "(N'Jelašnica Leskovac')," +
                "(N'Jelašnica Surdulica')," +
                "(N'Jelašnica Niš – Niška Banja')," +
                "(N'Jelen Do Požega')," +
                "(N'Jelenac Topola')," +
                "(N'Jelenča ŠaBač')," +
                "(N'Jeliće Tutin')," +
                "(N'Jelovac Despotovac')," +
                "(N'Jelovac Klina')," +
                "(N'Jelovik Aranđelovac')," +
                "(N'Jelovik Bajina Bašta')," +
                "(N'Jelovica Pirot')," +
                "(N'Jerli Prelez Uroševac')," +
                "(N'Jerli Sadovina Vitina')," +
                "(N'Jerli Talinovac Uroševac')," +
                "(N'Jermenovci Plandište')," +
                "(N'Ješkovo Prizren')," +
                "(N'Jova Novi Pazar')," +
                "(N'Jovanovac Kragujevac')," +
                "(N'Jovanovac Merošina')," +
                "(N'Jovanovce Crna Trava')," +
                "(N'Jovanja Valjevo')," +
                "(N'Jovac Vladičin Han')," +
                "(N'Jovac Ćuprija')," +
                "(N'Jovine Livade Prokuplje')," +
                "(N'Jovićrahovac')," +
                "(N'Jošanica Žagubica')," +
                "(N'Jošanica Sokobanja')," +
                "(N'Jošanica Klina')," +
                "(N'Jošanica Leposavić')," +
                "(N'Jošanica Peć')," +
                "(N'Jošanička Banja Raška')," +
                "(N'Jošanički Prnjavor Jagodina')," +
                "(N'Joševa Valjevo')," +
                "(N'Joševa Loznica')," +
                "(N'Joševa Ub')," +
                "(N'Joševik Zvečan')," +
                "(N'Jošje Kruševac')," +
                "(N'Jug Bogdanovac Merošina')," +
                "(N'Jugovac Prokuplje')," +
                "(N'Jugovići Loznica')," +
                "(N'Južni Kočarnik Tutin')," +
                "(N'Junake Zubin Potok')," +
                "(N'Junik Dečani')," +
                "(N'Junkovac Beograd – Lazarevac')," +
                "(N'Junkovac Topola')," +
                "(N'Junčevići Prijepolje')," +
                "(N'Kabaš Vitina')," +
                "(N'Kabaš Prizren')," +
                "(N'Kabaš Has Prizren')," +
                "(N'Kavadar Rekovac')," +
                "(N'Kavilo Bačka Topola')," +
                "(N'Kadina Luka Ljig')," +
                "(N'Kaznoviće Raška')," +
                "(N'Kajkovo Leposavić')," +
                "(N'Kajtasovo Bela Crkva')," +
                "(N'Kalabovce Surdulica')," +
                "(N'Kalanjevci Ljig')," +
                "(N'Kalafati Priboj')," +
                "(N'Kalenić Ub')," +
                "(N'Kalenići Požega')," +
                "(N'Kalenićki Prnjavor Rekovac')," +
                "(N'Kalenovac Jagodina')," +
                "(N'Kaletinacadžin Han')," +
                "(N'Kalimanićiornji Milanovac')," +
                "(N'Kalimance Vladičin Han')," +
                "(N'Kalinovac Ub')," +
                "(N'Kalipolje Sjenica')," +
                "(N'Kaličane Istok')," +
                "(N'Kaličina Knjaževac')," +
                "(N'Kalište Malo Crniće')," +
                "(N'Kalna Knjaževac')," +
                "(N'Kalna Crna Trava')," +
                "(N'Kalovo Trgovište')," +
                "(N'Kaludra Prokuplje')," +
                "(N'Kaludra Rekovac')," +
                "(N'Kaluđerevo Babušnica')," +
                "(N'Kaluđerica Beograd –rocka')," +
                "(N'Kaluđerovići Priboj')," +
                "(N'Kaluđerovo Bela Crkva')," +
                "(N'Kaluđerce Leskovac')," +
                "(N'Kaljatica Podujevo')," +
                "(N'Kambelevac Babušnica')," +
                "(N'Kamenalava Uroševac')," +
                "(N'Kamenaora Prijepolje')," +
                "(N'Kamenare Kruševac')," +
                "(N'Kamendol Beograd –rocka')," +
                "(N'Kamenica Aleksinac')," +
                "(N'Kamenica Bojnik')," +
                "(N'Kamenica Valjevo')," +
                "(N'Kamenicaornji Milanovac')," +
                "(N'Kamenica Dimitrovgrad')," +
                "(N'Kamenica Koceljeva')," +
                "(N'Kamenica Kragujevac')," +
                "(N'Kamenica Kraljevo')," +
                "(N'Kamenica Loznica')," +
                "(N'Kamenica Užice')," +
                "(N'Kamenica Niš – Pantelej')," +
                "(N'Kamenica Leposavić')," +
                "(N'Kamenica Zvečan')," +
                "(N'Kamenovo Petrova na Mlavi')," +
                "(N'Kamenjani Kraljevo')," +
                "(N'Kamenjača Trstenik')," +
                "(N'Kamešnica Sjenica')," +
                "(N'Kamijevo Velikoradište')," +
                "(N'Kamik Pirot')," +
                "(N'Kandalica Knjaževac')," +
                "(N'Kanjevina Sjenica')," +
                "(N'Kanjiža Kanjiža')," +
                "(N'Kaona Vladimirci')," +
                "(N'Kaona Kučevo')," +
                "(N'Kaona Lučani')," +
                "(N'Kaonik Kruševac')," +
                "(N'Kapit Medveđa')," +
                "(N'Kapidžija Kruševac')," +
                "(N'Kapra Prizren')," +
                "(N'Karavukovodžaci')," +
                "(N'Karadak Raška')," +
                "(N'Karadnik Bujanovac')," +
                "(N'Karađorđevac Leskovac')," +
                "(N'Karađorđevo Bačka Palanka')," +
                "(N'Karađorđevo Bačka Topola')," +
                "(N'Karajukića Bunari Sjenica')," +
                "(N'Karamanica Bosilegrad')," +
                "(N'Karan Užice')," +
                "(N'Karanovac Varvarin')," +
                "(N'Karaula Prijepolje')," +
                "(N'Karače Vučitrn')," +
                "(N'Karačica Štimlje')," +
                "(N'Karašinđerđ Prizren')," +
                "(N'Karbulovo Negotin')," +
                "(N'Kare Žitorađa')," +
                "(N'Karlovčić Pećinci')," +
                "(N'Karoševina Prijepolje')," +
                "(N'Kasidol Požarevac')," +
                "(N'Kasidoli Priboj')," +
                "(N'Kastrat Kuršumlija')," +
                "(N'Katići Ivanjica')," +
                "(N'Katrga Čačak')," +
                "(N'Katun Aleksinac')," +
                "(N'Katun Vranje')," +
                "(N'Kać Novi Sad')," +
                "(N'Kaćevo Prijepolje')," +
                "(N'Kacabać Bojnik')," +
                "(N'Kacapun Vladičin Han')," +
                "(N'Kačandol Kosovska Mitrovica')," +
                "(N'Kačanik Kačanik')," +
                "(N'Kačapor Blace')," +
                "(N'Kačarevo Pančevo')," +
                "(N'Kačer Užice')," +
                "(N'Kačibeg Podujevo')," +
                "(N'Kačikol Priština')," +
                "(N'Kačulice Čačak')," +
                "(N'Kašalj Novi Pazar')," +
                "(N'Kaševar Blace')," +
                "(N'Kašica Istok')," +
                "(N'Kašice Prijepolje')," +
                "(N'Kaštavar Leskovac')," +
                "(N'Kevi Senta')," +
                "(N'Kelebija Subotica')," +
                "(N'Keserovina Užice')," +
                "(N'Kijevac Babušnica')," +
                "(N'Kijevac Surdulica')," +
                "(N'Kijevo Batočina')," +
                "(N'Kijevo Klina')," +
                "(N'Kijevce Zubin Potok')," +
                "(N'Kijevci Sjenica')," +
                "(N'Kijevčiće Leposavić')," +
                "(N'Kikinda Kikinda')," +
                "(N'Kikojevac Knić')," +
                "(N'Kisač Novi Sad')," +
                "(N'Kisela Banja Podujevo')," +
                "(N'Kisiljevo Velikoradište')," +
                "(N'Kišna Rekalogovac')," +
                "(N'Kišno Poljenjilane')," +
                "(N'Kladernica Srbica')," +
                "(N'Kladnica Sjenica')," +
                "(N'Kladovo Kladovo')," +
                "(N'Kladurovo Petrova na Mlavi')," +
                "(N'Kladušnica Kladovo')," +
                "(N'Klajić Lebane')," +
                "(N'Klanica Valjevo')," +
                "(N'Klatičevoornji Milanovac')," +
                "(N'Klačevica Paraćin')," +
                "(N'Klašnić Mionica')," +
                "(N'Klašnjice Vranje')," +
                "(N'Klek Zrenjanin')," +
                "(N'Klekova Ivanjica')," +
                "(N'Klenak Ruma')," +
                "(N'Klenike Bujanovac')," +
                "(N'Klenovac Zaječar')," +
                "(N'Klenovnik Kostolac')," +
                "(N'Klenje Bela Palanka')," +
                "(N'Klenje Bogatić')," +
                "(N'KlenjeoluBač')," +
                "(N'Klečka Lipljan')," +
                "(N'Klečke Zubin Potok')," +
                "(N'Klina Klina')," +
                "(N'Klinavac Klina')," +
                "(N'Klinovac Bujanovac')," +
                "(N'Klinci Valjevo')," +
                "(N'Klinčina Peć')," +
                "(N'Klisura Bela Palanka')," +
                "(N'Klisura Doljevac')," +
                "(N'Klisura Surdulica')," +
                "(N'Klisurica Prokuplje')," +
                "(N'Klisurica Vranjska Banja')," +
                "(N'Kličevac Požarevac')," +
                "(N'Klobukar Novo Brdo')," +
                "(N'Kloka Topola')," +
                "(N'Klokot Vitina')," +
                "(N'Klokočevac Majdanpek')," +
                "(N'Klupci Loznica')," +
                "(N'Kljajićevo Sombor')," +
                "(N'Ključ Mionica')," +
                "(N'Kmetovcenjilane')," +
                "(N'Kneževac Knić')," +
                "(N'Kneževac Sjenica')," +
                "(N'Kneževo Brus')," +
                "(N'Knežica Doljevac')," +
                "(N'Knežica Petrova na Mlavi')," +
                "(N'Knez Selo Niš – Pantelej')," +
                "(N'Knić Knić')," +
                "(N'Knićanin Zrenjanin')," +
                "(N'Knjaževac Knjaževac')," +
                "(N'Kobanja Prizren')," +
                "(N'Kobiljalava Zubin Potok')," +
                "(N'Kobilje Brus')," +
                "(N'Kobilje Kruševac')," +
                "(N'Kobilje Malo Crniće')," +
                "(N'Kobišnica Negotin')," +
                "(N'Kovanica Ćuprija')," +
                "(N'Kovanluk Kraljevo')," +
                "(N'Kovanluk Merošina')," +
                "(N'Kovače Zubin Potok')," +
                "(N'Kovačeva Bara Leskovac')," +
                "(N'Kovačevac Beograd – Mladenovac')," +
                "(N'Kovačevac Prijepolje')," +
                "(N'Kovačevac Jagodina')," +
                "(N'Kovačevac Kačanik')," +
                "(N'Kovačevo Novi Pazar')," +
                "(N'Kovači Kraljevo')," +
                "(N'Kovači Raška')," +
                "(N'Kovači Tutin')," +
                "(N'Kovačica Kovačica')," +
                "(N'Kovačica Kosovska Mitrovica')," +
                "(N'Kovačice Valjevo')," +
                "(N'Kovizle Brus')," +
                "(N'Kovilovo Beograd – Palilula')," +
                "(N'Kovilovo Negotin')," +
                "(N'Kovilj Novi Sad')," +
                "(N'Kovilje Ivanjica')," +
                "(N'Kovin Kovin')," +
                "(N'Kovioci Brus')," +
                "(N'Kovrage Istok')," +
                "(N'Kodralija Dečani')," +
                "(N'Kodralija Đakovica')," +
                "(N'Koželj Knjaževac')," +
                "(N'Kožetin Aleksandrovac')," +
                "(N'Kožince Prokuplje')," +
                "(N'Kožica Srbica')," +
                "(N'Kožlje Novi Pazar')," +
                "(N'Kožuar Ub')," +
                "(N'Kozare Leskovac')," +
                "(N'Kozarevo Zubin Potok')," +
                "(N'Kozarica Vladimirci')," +
                "(N'Kozelj Ljig')," +
                "(N'Kozilo Vlasotince')," +
                "(N'Kozja Bela Palanka')," +
                "(N'Kozjak Loznica')," +
                "(N'Kozličić Valjevo')," +
                "(N'Koznik Sjenica')," +
                "(N'Koznikrahovac')," +
                "(N'Koznica Aleksandrovac')," +
                "(N'Koznica Vladičin Han')," +
                "(N'Kojlovica Priština')," +
                "(N'Kojuš Prizren')," +
                "(N'Kokošiće Sjenica')," +
                "(N'Kolare Jagodina')," +
                "(N'Kolari Smederevo')," +
                "(N'Kolić Priština')," +
                "(N'Kolo Vučitrn')," +
                "(N'Kololeč Kosovska Kamenica')," +
                "(N'Kolunica Surdulica')," +
                "(N'Kolut Sombor')," +
                "(N'Komadine Ivanjica')," +
                "(N'Komanice Mionica')," +
                "(N'Komarane Rekovac')," +
                "(N'Komarani Nova Varoš')," +
                "(N'Komarica Vlasotince')," +
                "(N'Komirićsečina')," +
                "(N'Komorane Kruševac')," +
                "(N'Komoranelogovac')," +
                "(N'Konak Sečanj')," +
                "(N'Konarevo Kraljevo')," +
                "(N'Konatice Beograd –brenovac')," +
                "(N'Koniče Tutin')," +
                "(N'Konopnica Vlasotince')," +
                "(N'Končarevo Jagodina')," +
                "(N'Končić Prokuplje')," +
                "(N'Končulj Bujanovac')," +
                "(N'Kondželj Prokuplje')," +
                "(N'Konjarnik Žitorađa')," +
                "(N'Konjevići Čačak')," +
                "(N'Konjino Lebane')," +
                "(N'Konjicsečina')," +
                "(N'Konjska Reka Bajina Bašta')," +
                "(N'Konjsko Lipljan')," +
                "(N'Konjuva Kuršumlija')," +
                "(N'Konjuh Kruševac')," +
                "(N'Konjuh Lipljan')," +
                "(N'Konjuša Knić')," +
                "(N'Konjušasečina')," +
                "(N'Konjuševac Podujevo')," +
                "(N'Kopajkošara Svrljig')," +
                "(N'Kopanjane Vranje')," +
                "(N'Kopaonik Raška')," +
                "(N'Kopiloviće Zubin Potok')," +
                "(N'Kopitarce Vladičin Han')," +
                "(N'Kopljare Aranđelovac')," +
                "(N'Koporiće Leposavić')," +
                "(N'Kopriva Kosovska Mitrovica')," +
                "(N'Koprivna Prijepolje')," +
                "(N'Koprivnica Aleksinac')," +
                "(N'Koprivnicaadžin Han')," +
                "(N'Koprivnica Zaječar')," +
                "(N'Koprivnica Novi Pazar')," +
                "(N'Koprivnica Kosovska Kamenica')," +
                "(N'Koprivštica Pirot')," +
                "(N'Koraćevac Leskovac')," +
                "(N'Koraćica Beograd – Mladenovac')," +
                "(N'Korbevac Vranjska Banja')," +
                "(N'Korbovo Kladovo')," +
                "(N'Korbul Vranjska Banja')," +
                "(N'Korbulić Kačanik')," +
                "(N'Korenita Loznica')," +
                "(N'Korenica Đakovica')," +
                "(N'Koretin Kosovska Kamenica')," +
                "(N'Koretištenjilane')," +
                "(N'Korilje Zvečan')," +
                "(N'Koritnik Ivanjica')," +
                "(N'Koritnjak Niš – Niška Banja')," +
                "(N'Koriša Prizren')," +
                "(N'Korlaće Raška')," +
                "(N'Korman Aleksinac')," +
                "(N'Korman Kragujevac')," +
                "(N'Korman ŠaBač')," +
                "(N'Kosančić Bojnik')," +
                "(N'Kosančić Vrbas')," +
                "(N'Kosatica Prijepolje')," +
                "(N'Kosin Uroševac')," +
                "(N'Kosjerić (varoš) Kosjerić')," +
                "(N'Kosjerić (selo) Kosjerić')," +
                "(N'Kosmača Kuršumlija')," +
                "(N'Kosmovac Bela Palanka')," +
                "(N'Kosovica Ivanjica')," +
                "(N'Kosovo Polje Kosovo Polje')," +
                "(N'Kosovska Kamenica Kosovska Kamenica')," +
                "(N'Kosovska Mitrovica Kosovska Mitrovica')," +
                "(N'Kosovce Prizren')," +
                "(N'Kostadinovac Merošina')," +
                "(N'Kostadince Kosovska Kamenica')," +
                "(N'Kostajnik Krupanj')," +
                "(N'Kostenica Prokuplje')," +
                "(N'Kostin Potok Leposavić')," +
                "(N'Kostojevići Bajina Bašta')," +
                "(N'Kostol Kladovo')," +
                "(N'Kostolac Kostolac')," +
                "(N'Kostomlatica Vladičin Han')," +
                "(N'Kostroševci Surdulica')," +
                "(N'Kostrc Srbica')," +
                "(N'Kostrce Suva Reka')," +
                "(N'Kostur Pirot')," +
                "(N'Kosurić Peć')," +
                "(N'Kosuriće Novi Pazar')," +
                "(N'Kotešica Valjevo')," +
                "(N'Kotlina Kačanik')," +
                "(N'Kotore Srbica')," +
                "(N'Kotradić Peć')," +
                "(N'Kotraža Kragujevac')," +
                "(N'Kotraža Lučani')," +
                "(N'Kotroman Užice')," +
                "(N'Koćura Vranje')," +
                "(N'Koceljeva Koceljeva')," +
                "(N'Kočane Doljevac')," +
                "(N'Kočetin Žabari')," +
                "(N'Kočine Brus')," +
                "(N'Kočino Selo Jagodina')," +
                "(N'Koš Istok')," +
                "(N'Košare Đakovica')," +
                "(N'Košare Uroševac')," +
                "(N'Košarno Bujanovac')," +
                "(N'Koševi Kruševac')," +
                "(N'Koševine Prijepolje')," +
                "(N'Koštanjevo Štrpce')," +
                "(N'Koštunićiornji Milanovac')," +
                "(N'Košutane Peć')," +
                "(N'Košutica Leposavić')," +
                "(N'Košutovo Leposavić')," +
                "(N'Košutovo Kosovska Mitrovica')," +
                "(N'Kpuz Klina')," +
                "(N'Kravaricanjilane')," +
                "(N'Kraviće Raška')," +
                "(N'Kravlje Niš – Crveni krst')," +
                "(N'Kravlji Do Malo Crniće')," +
                "(N'Kravoserija Suva Reka')");
                  migrationBuilder.Sql(
                "insert into Mesta(NazivMesta) values " +
                "(N'Kragujevac Kragujevac')," +
                "(N'Krajinoviće Sjenica')," +
                "(N'Krajišnik Sečanj')," +
                "(N'Krajišnici Loznica')," +
                "(N'Krajište Lipljan')," +
                "(N'Krajk Prizren')," +
                "(N'Krajkovac Merošina')," +
                "(N'Krajkovologovac')," +
                "(N'Krajmirovce Lipljan')," +
                "(N'Krajnidel Kosovska Kamenica')," +
                "(N'Kraljane Đakovica')," +
                "(N'Kraljevo Aleksinac')," +
                "(N'Kraljevo Kraljevo')," +
                "(N'Kraljevci Ruma')," +
                "(N'Kramovikrahovac')," +
                "(N'Krasava Krupanj')," +
                "(N'Krasalić Srbica')," +
                "(N'Krasmirovac Srbica')," +
                "(N'Krastavčeadžin Han')," +
                "(N'Kratovo Priboj')," +
                "(N'Krvavica Kruševac')," +
                "(N'Krvavci Užice')," +
                "(N'Krvije Petrova na Mlavi')," +
                "(N'Krežbinac Paraćin')," +
                "(N'Kremenata Kosovska Kamenica')," +
                "(N'Kremenica Bela Palanka')," +
                "(N'Kremiće Raška')," +
                "(N'Kremna Užice')," +
                "(N'Krenta Knjaževac')," +
                "(N'Krepoljin Žagubica')," +
                "(N'Kržava Krupanj')," +
                "(N'Kržince Vladičin Han')," +
                "(N'Kriva Reka Brus')," +
                "(N'Kriva Rekaornji Milanovac')," +
                "(N'Kriva Reka Čajetina')," +
                "(N'Kriva Feja Vranjska Banja')," +
                "(N'Krivaja Blace')," +
                "(N'Krivaja Sjenica')," +
                "(N'Krivaja ŠaBač')," +
                "(N'Krivaja Bačka Topola')," +
                "(N'KrivačaoluBač')," +
                "(N'Krivača Lebane')," +
                "(N'Krivača Lučani')," +
                "(N'Krivelj Bor')," +
                "(N'Krivenik Kačanik')," +
                "(N'Krivi Vir Boljevac')," +
                "(N'Krivi Del Crna Trava')," +
                "(N'Kriljevo Kosovska Kamenica')," +
                "(N'Krligate Zubin Potok')," +
                "(N'Krnić Vladimirci')," +
                "(N'Krnule Vladimirci')," +
                "(N'Krnja Jela Sjenica')," +
                "(N'Krnjača Priboj')," +
                "(N'Krnjevo Velika Plana')," +
                "(N'Krnješevci Stara Pazova')," +
                "(N'Krnjirad Prokuplje')," +
                "(N'Krnjina Istok')," +
                "(N'Krnjince Klina')," +
                "(N'Krpejce Leskovac')," +
                "(N'Krpimej Podujevo')," +
                "(N'Krstac Lučani')," +
                "(N'Krstac Sjenica')," +
                "(N'Krstićevo Crna Trava')," +
                "(N'Krstovac Peć')," +
                "(N'Krtinska Beograd –brenovac')," +
                "(N'Krtok Kuršumlija')," +
                "(N'Krće Sjenica')," +
                "(N'Krćevac Topola')," +
                "(N'Krupaja Žagubica')," +
                "(N'Krupanj Krupanj')," +
                "(N'Krupac Bela Palanka')," +
                "(N'Krupac Pirot')," +
                "(N'Krušar Ćuprija')," +
                "(N'Kruševalava Vranje')," +
                "(N'Kruševac Kruševac')," +
                "(N'Kruševacbilić')," +
                "(N'Kruševac Peć')," +
                "(N'Kruševac Srbica')," +
                "(N'Kruševica Beograd – Lazarevac')," +
                "(N'Kruševica Vlasotince')," +
                "(N'Kruševica Prokuplje')," +
                "(N'Kruševica Raška')," +
                "(N'Kruševica Podujevo')," +
                "(N'Kruševo Novi Pazar')," +
                "(N'Kruševo Prijepolje')," +
                "(N'Kruševo Leposavić')," +
                "(N'Kruševoora')," +
                "(N'Krušedol Prnjavor Irig')," +
                "(N'Krušedol Selo Irig')," +
                "(N'Krušje Aleksinac')," +
                "(N'Krušce Niš – Palilula')," +
                "(N'Kruščić Kula')," +
                "(N'Kruščica Arilje')," +
                "(N'Kruščica Bela Crkva')," +
                "(N'Kruščica Leposavić')," +
                "(N'Krčedin Inđija')," +
                "(N'Krčmar Mionica')," +
                "(N'Krčmare Kuršumlija')," +
                "(N'Kršanje Užice')," +
                "(N'Krševica Bujanovac')," +
                "(N'Kršnalava Ub')," +
                "(N'KudrešoluBač')," +
                "(N'Kuzmin Sremska Mitrovica')," +
                "(N'Kuzmin Kosovo Polje')," +
                "(N'Kuzmičevo Novi Pazar')," +
                "(N'Kujavica Vladimirci')," +
                "(N'Kukavica Vladičin Han')," +
                "(N'Kukavica Vlasotince')," +
                "(N'Kukavica Priština')," +
                "(N'Kukići Čačak')," +
                "(N'Kuklibeg Prizren')," +
                "(N'Kukljin Kruševac')," +
                "(N'Kukovce Prizren')," +
                "(N'Kukujevci Šid')," +
                "(N'Kukulovce Leskovac')," +
                "(N'Kukuljaneora')," +
                "(N'Kukurovići Priboj')," +
                "(N'Kula Malo Crniće')," +
                "(N'Kula Kula')," +
                "(N'Kula Zvečan')," +
                "(N'Kulina Aleksinac')," +
                "(N'Kulinovci Čačak')," +
                "(N'Kulič Smederevo')," +
                "(N'Kulpin Bački Petrovac')," +
                "(N'Kumane Velikoradište')," +
                "(N'Kumane Novi Bečej')," +
                "(N'Kumanica Ivanjica')," +
                "(N'Kumanovo Pirot')," +
                "(N'Kumarevo Leskovac')," +
                "(N'Kumarevo Vranjska Banja')," +
                "(N'Kunice Valjevo')," +
                "(N'Kunovik Vučitrn')," +
                "(N'Kunovica Niš – Niška Banja')," +
                "(N'Kunovo Vladičin Han')," +
                "(N'Kupinik Plandište')," +
                "(N'Kupinince Vranje')," +
                "(N'Kupinovac Svilajnac')," +
                "(N'Kupinovo Kuršumlija')," +
                "(N'Kupinovo Pećinci')," +
                "(N'Kupuzište Kladovo')," +
                "(N'Kupusina Velika Plana')," +
                "(N'Kupusina Apatin')," +
                "(N'Kurbalija Preševo')," +
                "(N'Kurilovo Vučitrn')," +
                "(N'Kurići Raška')," +
                "(N'Kurjače Velikoradište')," +
                "(N'Kuršumlija Kuršumlija')," +
                "(N'Kuršumlijska Banja Kuršumlija')," +
                "(N'Kusa Vrana Dimitrovgrad')," +
                "(N'Kusadak Smederevska Palanka')," +
                "(N'Kusar Đakovica')," +
                "(N'Kusić Bela Crkva')," +
                "(N'Kusiće Velikoradište')," +
                "(N'Kusovac Knić')," +
                "(N'Kutleš Leskovac')," +
                "(N'Kutlovac Blace')," +
                "(N'Kutlovac Kosovska Mitrovica')," +
                "(N'Kutlovo Kragujevac')," +
                "(N'Kutlovo Kuršumlija')," +
                "(N'Kutnje Leposavić')," +
                "(N'Kućane Raška')," +
                "(N'Kućani Nova Varoš')," +
                "(N'Kućica Srbica')," +
                "(N'Kućište Peć')," +
                "(N'Kucura Vrbas')," +
                "(N'Kučajna Kučevo')," +
                "(N'Kučevo Kučevo')," +
                "(N'Kučin Prijepolje')," +
                "(N'Kuševac Đakovica')," +
                "(N'Kušiljevo Svilajnac')," +
                "(N'Kušići Ivanjica')," +
                "(N'Kušnin Prizren')," +
                "(N'Kuštendil Prizren')," +
                "(N'Kuštilj Vršac')," +
                "(N'Kuštica Bujanovac')," +
                "(N'Labljane Novo Brdo')," +
                "(N'Labljane Peć')," +
                "(N'Labukovo Svrljig')," +
                "(N'Labučevorahovac')," +
                "(N'Ladovac Podujevo')," +
                "(N'Ladovica Vlasotince')," +
                "(N'Ladrovac Suva Reka')," +
                "(N'Ladrović Suva Reka')," +
                "(N'Lađevci Kraljevo')," +
                "(N'Laz Belopać Peć')," +
                "(N'Lazarevac Beograd – Lazarevac')," +
                "(N'Lazarevac Blace')," +
                "(N'Lazarevac Kruševac')," +
                "(N'Lazarevo Zrenjanin')," +
                "(N'Lazarevobilić')," +
                "(N'Lazarevo Selo Niš – Niška Banja')," +
                "(N'Lazarica Kruševac')," +
                "(N'Lazac Kraljevo')," +
                "(N'Lazine Leposavić')," +
                "(N'Laznica Žagubica')," +
                "(N'Lajkovac (varoš) Lajkovac')," +
                "(N'Lajkovac (selo) Lajkovac')," +
                "(N'Laletić Lipljan')," +
                "(N'Lalinac Svrljig')," +
                "(N'Lalinac Niš – Palilula')," +
                "(N'Lalinovac Lebane')," +
                "(N'Lalince Vranje')," +
                "(N'Lalinci Ljig')," +
                "(N'Lalićdžaci')," +
                "(N'Landovica Prizren')," +
                "(N'Landol Smederevo')," +
                "(N'Lanište Bela Palanka')," +
                "(N'Lanište Kačanik')," +
                "(N'Lanište Štimlje')," +
                "(N'Laplje Selo Priština')," +
                "(N'Lapovo (varošica) Lapovo')," +
                "(N'Lapovo (selo) Lapovo')," +
                "(N'Lapotince Bojnik')," +
                "(N'Lapušniklogovac')," +
                "(N'Lasovo Zaječar')," +
                "(N'Latvica Arilje')," +
                "(N'Latkovac Aleksandrovac')," +
                "(N'Latković Ljig')," +
                "(N'Laćarak Sremska Mitrovica')," +
                "(N'Laćisled Aleksandrovac')," +
                "(N'Laudonovac Plandište')," +
                "(N'Lauša Podujevo')," +
                "(N'Lauša Srbica')," +
                "(N'Laškobare Uroševac')," +
                "(N'Lebane Lebane')," +
                "(N'Lebane Priština')," +
                "(N'Lebet Vladičin Han')," +
                "(N'Lebina Paraćin')," +
                "(N'Leva Reka Vranjska Banja')," +
                "(N'Levići Trstenik')," +
                "(N'Levovik Sokobanja')," +
                "(N'Levosoje Bujanovac')," +
                "(N'Ledenik Zubin Potok')," +
                "(N'Ledinci Petrovaradin')," +
                "(N'Ležimir Sremska Mitrovica')," +
                "(N'Lez Prizren')," +
                "(N'Lelić Valjevo')," +
                "(N'Lelići Užice')," +
                "(N'Lenovac Zaječar')," +
                "(N'Leović Ljubovija')," +
                "(N'Leočina Srbica')," +
                "(N'Lepaja Merošina')," +
                "(N'Lepena Knjaževac')," +
                "(N'Lepenac Brus')," +
                "(N'Lepenica Vladičin Han')," +
                "(N'Lepina Lipljan')," +
                "(N'Lepojević Rekovac')," +
                "(N'Leposavić Leposavić')," +
                "(N'Lepčince Vranje')," +
                "(N'Lesenovci Aleksandrovac')," +
                "(N'Leskova Tutin')," +
                "(N'Leskova Bara Surdulica')," +
                "(N'Leskovac Beograd – Lazarevac')," +
                "(N'Leskovac Zaječar')," +
                "(N'Leskovac Knić')," +
                "(N'Leskovac Leskovac')," +
                "(N'Leskovac Petrova na Mlavi')," +
                "(N'Leskovac Klina')," +
                "(N'Leskovac Prizren')," +
                "(N'Leskovik Bela Palanka')," +
                "(N'Leskovik Niš – Crveni krst')," +
                "(N'Leskovica Aleksandrovac')," +
                "(N'Leskovica Babušnica')," +
                "(N'Leskovo Majdanpek')," +
                "(N'Leskovčićbilić')," +
                "(N'Lesnica Trgovište')," +
                "(N'Letance Podujevo')," +
                "(N'Letnica Vitina')," +
                "(N'Letovica Bujanovac')," +
                "(N'Letovište Vladičin Han')," +
                "(N'Leušićiornji Milanovac')," +
                "(N'Lece Medveđa')," +
                "(N'Leča Novi Pazar')," +
                "(N'Lešak Leposavić')," +
                "(N'Lešane Suva Reka')," +
                "(N'Leševo Kraljevo')," +
                "(N'Lešje Paraćin')," +
                "(N'Lešnica Loznica')," +
                "(N'Leštane Beograd –rocka')," +
                "(N'Leštaneora')," +
                "(N'Livadica Podujevo')," +
                "(N'Livađe Brus')," +
                "(N'Livađe Lipljan')," +
                "(N'Lijeva Reka Sjenica')," +
                "(N'Likovac Srbica')," +
                "(N'Likodra Krupanj')," +
                "(N'Likošanelogovac')," +
                "(N'Linovo Babušnica')," +
                "(N'Lipa Peć')," +
                "(N'Lipa Zvečan')," +
                "(N'Lipar Kula')," +
                "(N'Lipe Žagubica')," +
                "(N'Lipe Smederevo')," +
                "(N'Lipenović Krupanj')," +
                "(N'Lipica Tutin')," +
                "(N'Lipljan Lipljan')," +
                "(N'Liplje Ljig')," +
                "(N'Lipnica Knić')," +
                "(N'Lipnica Loznica')," +
                "(N'Lipnica Čačak')," +
                "(N'Lipnički Šor Loznica')," +
                "(N'Lipova Vrnjačka Banja')," +
                "(N'Lipovac Aleksinac')," +
                "(N'Lipovacornji Milanovac')," +
                "(N'Lipovac Kruševac')," +
                "(N'Lipovac Ražanj')," +
                "(N'Lipovac Topola')," +
                "(N'Lipovac Vranjska Banja')," +
                "(N'Lipovac Đakovica')," +
                "(N'Lipovica Vlasotince')," +
                "(N'Lipovica Despotovac')," +
                "(N'Lipovica Lebane')," +
                "(N'Lipovica Leskovac')," +
                "(N'Lipovicanjilane')," +
                "(N'Lipovica Lipljan')," +
                "(N'Lipovica Zvečan')," +
                "(N'Lipolist ŠaBač')," +
                "(N'Lis Lučani')," +
                "(N'Lisa Ivanjica')," +
                "(N'Lisina Raška')," +
                "(N'Lisica Kosovska Mitrovica')," +
                "(N'Lisice Lučani')," +
                "(N'Liso Polje Ub')," +
                "(N'Lisović Beograd – Barajevo')," +
                "(N'Lisocka Kosovska Kamenica')," +
                "(N'Ličin Dol Leskovac')," +
                "(N'Ličjeadžin Han')," +
                "(N'Loboder Trstenik')," +
                "(N'Lovac Zvečan')," +
                "(N'Lovćenac Mali Iđoš')," +
                "(N'Lovcenjilane')," +
                "(N'Lovci Kruševac')," +
                "(N'Lovci Jagodina')," +
                "(N'Lođa Peć')," +
                "(N'Ložane Peć')," +
                "(N'Lozan Svrljig')," +
                "(N'Lozane Bojnik')," +
                "(N'Lozanjornji Milanovac')," +
                "(N'Lozica Klina')," +
                "(N'Lozište Zvečan')," +
                "(N'Lozna Trstenik')," +
                "(N'Loznac Aleksinac')," +
                "(N'Loznica Valjevo')," +
                "(N'Loznica Loznica')," +
                "(N'Loznica Čačak')," +
                "(N'Lozničko Polje Loznica')," +
                "(N'Lozno Kraljevo')," +
                "(N'Lozno Leposavić')," +
                "(N'Lozovik Velika Plana')," +
                "(N'Lozovik Jagodina')," +
                "(N'Lojanice Vladimirci')," +
                "(N'Lok Titel')," +
                "(N'Lokva Knjaževac')," +
                "(N'Lokva Zvečan')," +
                "(N'Lokve Alibunar')," +
                "(N'Lokvica Prizren')," +
                "(N'Lomnica Despotovac')," +
                "(N'Lomnica Rekovac')," +
                "(N'Lončanik Ub')," +
                "(N'Lonjin Ljubovija')," +
                "(N'Lopardince Bujanovac')," +
                "(N'Lopatanjsečina')," +
                "(N'Lopatnica Kraljevo')," +
                "(N'Lopaš Požega')," +
                "(N'Lopaš Trstenik')," +
                "(N'Lopužnje Novi Pazar')," +
                "(N'Lopušnik Petrova na Mlavi')," +
                "(N'Loret Požega')," +
                "(N'Loćane Dečani')," +
                "(N'Loćika Aleksinac')," +
                "(N'Loćika Rekovac')," +
                "(N'Ločevciornji Milanovac')," +
                "(N'Lubnica Zaječar')," +
                "(N'Lug Bajina Bašta')," +
                "(N'Lug Beočin')," +
                "(N'Lug Lipljan')," +
                "(N'Lug Podujevo')," +
                "(N'Lug Dubnica Vučitrn')," +
                "(N'Lugavčina Smederevo')," +
                "(N'Lugađija Đakovica')," +
                "(N'Lugađija Peć')," +
                "(N'Lugare Lebane')," +
                "(N'Lugadžija Lipljan')," +
                "(N'Lugovo Istok')," +
                "(N'Lužane Aleksinac')," +
                "(N'Lužane Podujevo')," +
                "(N'Lužnica Suva Reka')," +
                "(N'Lužnice Kragujevac')," +
                "(N'Luka Bor')," +
                "(N'Lukavac Valjevo')," +
                "(N'Lukavac Kruševac')," +
                "(N'Lukavica Beograd – Lazarevac')," +
                "(N'Lukavica Dimitrovgrad')," +
                "(N'Lukavica Tutin')," +
                "(N'Lukar Jagodina')," +
                "(N'Lukare Novi Pazar')," +
                "(N'Lukare Priština')," +
                "(N'Lukarskooševo Novi Pazar')," +
                "(N'Lukarce Bujanovac')," +
                "(N'Luke Ivanjica')," +
                "(N'Lukino Selo Zrenjanin')," +
                "(N'Lukićevo Zrenjanin')," +
                "(N'Lukovica Svilajnac')," +
                "(N'Lukovo Boljevac')," +
                "(N'Lukovo Vranje')," +
                "(N'Lukovo Kuršumlija')," +
                "(N'Lukovo Raška')," +
                "(N'Lukovo Svrljig')," +
                "(N'Lukomir Žitorađa')," +
                "(N'Lukocrevo Novi Pazar')," +
                "(N'Lunjevac Smederevo')," +
                "(N'Lunjevicaornji Milanovac')," +
                "(N'Lučane Bujanovac')," +
                "(N'Lučani (varošica) Lučani')," +
                "(N'Lučani (selo) Lučani')," +
                "(N'Lučina Ćićevac')," +
                "(N'Lučica Požarevac')," +
                "(N'Lučice Prijepolje')," +
                "(N'Lučka Reka Zubin Potok')," +
                "(N'Ljajčić Kosovska Kamenica')," +
                "(N'Ljanik Preševo')," +
                "(N'Ljevajaornji Milanovac')," +
                "(N'Ljevoša Peć')," +
                "(N'Ljepojevići Nova Varoš')," +
                "(N'Lješane Peć')," +
                "(N'Lješnica Kučevo')," +
                "(N'Lještansko Bajina Bašta')," +
                "(N'Lještar Kosovska Kamenica')," +
                "(N'Ljig Ljig')," +
                "(N'Ljiljance Bujanovac')," +
                "(N'Ljuba Šid')," +
                "(N'Ljubava Kruševac')," +
                "(N'Ljubanje Užice')," +
                "(N'Ljubatovica Bela Palanka')," +
                "(N'Ljubenić Peć')," +
                "(N'Ljuberađa Babušnica')," +
                "(N'Ljubiždarahovac')," +
                "(N'Ljubižda Prizren')," +
                "(N'Ljubižda Has Prizren')," +
                "(N'Ljubinić Beograd –brenovac')," +
                "(N'Ljubinci Aleksandrovac')," +
                "(N'Ljubinje Velikoradište')," +
                "(N'Ljubić Knić')," +
                "(N'Ljubić Čačak')," +
                "(N'Ljubičevac Kladovo')," +
                "(N'Ljubičevac Kragujevac')," +
                "(N'Ljubičevo Prizren')," +
                "(N'Ljubiš Čajetina')," +
                "(N'Ljubište Vitina')," +
                "(N'Ljubovac Srbica')," +
                "(N'Ljubovija Ljubovija')," +
                "(N'Ljubovišteora')," +
                "(N'Ljubovo Istok')," +
                "(N'Ljubožda Istok')," +
                "(N'Ljubuša Dečani')," +
                "(N'Ljugbunar Đakovica')," +
                "(N'Ljukinaj Prizren')," +
                "(N'Ljukovo Inđija')," +
                "(N'Ljuljaci Knić')," +
                "(N'Ljumbarda Dečani')," +
                "(N'Ljupten Aleksinac')," +
                "(N'Ljutaje Sjenica')," +
                "(N'Ljutež Vladičin Han')," +
                "(N'Ljutice Koceljeva')," +
                "(N'Ljutice Požega')," +
                "(N'Ljutova Kuršumlija')," +
                "(N'Ljutovnicaornji Milanovac')," +
                "(N'Ljutovo Subotica')," +
                "(N'Ljutoglav Prizren')," +
                "(N'Ljutoglava Peć')," +
                "(N'Ljuša Kuršumlija')," +
                "(N'Ljušta Kosovska Mitrovica')," +
                "(N'Mavrić Vučitrn')," +
                "(N'Magaš Bojnik')," +
                "(N'Maglić Bački Petrovac')," +
                "(N'Maglič Kraljevo')," +
                "(N'Magovo Kuršumlija')," +
                "(N'Magura Lipljan')," +
                "(N'Mađare Preševo')," +
                "(N'Mađarerahovac')," +
                "(N'Mađare Kosovska Mitrovica')," +
                "(N'Mađer Požega')," +
                "(N'Mađere Prokuplje')," +
                "(N'Mađere Ražanj')," +
                "(N'Mažić Kosovska Mitrovica')," +
                "(N'Mažići Priboj')," +
                "(N'Mazap Podujevo')," +
                "(N'Mazarać Vladičin Han')," +
                "(N'Mazgitbilić')," +
                "(N'Mazgoš Dimitrovgrad')," +
                "(N'Maznik Dečani')," +
                "(N'Mazrek Prizren')," +
                "(N'Majance Podujevo')," +
                "(N'Majdanornji Milanovac')," +
                "(N'Majdan Novi Kneževac')," +
                "(N'Majdanpek Majdanpek')," +
                "(N'Majdevo Kruševac')," +
                "(N'Majdevo Leposavić')," +
                "(N'Majilovac Velikoradište')," +
                "(N'Majinović Valjevo')," +
                "(N'Majkovac Bojnik')," +
                "(N'Majur Jagodina')," +
                "(N'Majur ŠaBač')," +
                "(N'Makvište Despotovac')," +
                "(N'Makovac Priština')," +
                "(N'Makovište Kosjerić')," +
                "(N'Makrešane Kruševac')," +
                "(N'Makrmalj Srbica')," +
                "(N'Makce Velikoradište')," +
                "(N'Mala Biljanica Leskovac')," +
                "(N'Mala Bosna Subotica')," +
                "(N'Mala Braina Medveđa')," +
                "(N'Mala Bresnica Kučevo')," +
                "(N'Mala Vranjska ŠaBač')," +
                "(N'Mala Vrbica Beograd – Mladenovac')," +
                "(N'Mala Vrbica Kladovo')," +
                "(N'Mala Vrbica Kragujevac')," +
                "(N'Mala Vrbnica Brus')," +
                "(N'Mala Vrbnica Kruševac')," +
                "(N'Malarabovnica Brus')," +
                "(N'Malarabovnica Leskovac')," +
                "(N'Mala Dobranja Lipljan')," +
                "(N'Mala Draguša Blace')," +
                "(N'Mala Drenova Trstenik')," +
                "(N'Mala Ivanča Beograd – Sopot')," +
                "(N'Mala Jablanica Peć')," +
                "(N'Mala Jasikova Zaječar')," +
                "(N'Mala Ježevica Požega')," +
                "(N'Mala Kaludra Zubin Potok')," +
                "(N'Mala Kamenica Negotin')," +
                "(N'Mala Kopašnica Leskovac')," +
                "(N'Mala Kosanica Kuršumlija')," +
                "(N'Mala Krsna Smederevo')," +
                "(N'Mala Kruša Prizren')," +
                "(N'Mala Kruševica Varvarin')," +
                "(N'Mala Moštanica Beograd –brenovac')," +
                "(N'Mala Plana Prokuplje')," +
                "(N'Mala Plana Smederevska Palanka')," +
                "(N'Mala Reka Bajina Bašta')," +
                "(N'Mala Reka Kruševac')," +
                "(N'Mala Reka Trgovište')," +
                "(N'Mala Remeta Irig')," +
                "(N'Mala Slatina Kosovo Polje')," +
                "(N'Mala Sugubina Trstenik')," +
                "(N'Mala Hočarahovac')," +
                "(N'Malajnica Negotin')," +
                "(N'Male Pijace Kanjiža')," +
                "(N'Maletina Ražanj')," +
                "(N'MaleševooluBač')," +
                "(N'Maleševo Rekovac')," +
                "(N'Mali Alaš Lipljan')," +
                "(N'Mali Belaćevac Kosovo Polje')," +
                "(N'Mali Beograd Bačka Topola')," +
                "(N'Mali Borak Lajkovac')," +
                "(N'Mali Bošnjak Koceljeva')," +
                "(N'Mali Vranovac Dečani')," +
                "(N'Mali Vrtopadžin Han')," +
                "(N'Maliodennjilane')," +
                "(N'Mali Drenovac Aleksinac')," +
                "(N'Mali Đurđevik Klina')," +
                "(N'Mali Žam Vršac')," +
                "(N'Mali Zvečan Zvečan')," +
                "(N'Mali Zvornik Mali Zvornik')," +
                "(N'Mali Iđoš Mali Iđoš')," +
                "(N'Mali Izvor Boljevac')," +
                "(N'Mali Izvor Zaječar')," +
                "(N'Mali Jasenovac Zaječar')," +
                "(N'Mali Jovanovac Pirot')," +
                "(N'Mali Krčimiradžin Han')," +
                "(N'Mali Kupci Kruševac')," +
                "(N'Mali Miraševac Rača')," +
                "(N'Mali Pesak Kanjiža')," +
                "(N'Mali Požarevac Beograd – Sopot')," +
                "(N'Mali Popović Jagodina')," +
                "(N'Mali Radinci Ruma')," +
                "(N'Mali Suvodol Pirot')," +
                "(N'Mali Trnovac Bujanovac')," +
                "(N'Mali Crljeni Beograd – Lazarevac')," +
                "(N'Mali Šenj Kragujevac')," +
                "(N'Mali Šiljegovac Kruševac')," +
                "(N'Mali Štupelj Peć')," +
                "(N'Mališevonjilane')," +
                "(N'Mališevorahovac')," +
                "(N'Malo Bavanište Kovin')," +
                "(N'Malo Bonjince Babušnica')," +
                "(N'Malo Vojlovce Lebane')," +
                "(N'Maloolovode Kruševac')," +
                "(N'Maloradište Malo Crniće')," +
                "(N'Maloracko Lipljan')," +
                "(N'Malo Dubovo Istok')," +
                "(N'Malo Kičiće Kosovska Mitrovica')," +
                "(N'Malo Kruševo Klina')," +
                "(N'Malo Krušince Kruševac')," +
                "(N'Malo Krčmare Rača')," +
                "(N'Malo Laole Petrova na Mlavi')," +
                "(N'Malorašje Smederevo')," +
                "(N'Malo Ribare Lipljan')," +
                "(N'Malo Ropotovo Kosovska Kamenica')," +
                "(N'Malo Rudare Zvečan')," +
                "(N'Malo Središte Vršac')," +
                "(N'Malo Crniće Malo Crniće')," +
                "(N'Malopoljce Štimlje')," +
                "(N'Malošište Doljevac')," +
                "(N'Malča Niš – Pantelej')," +
                "(N'Maljević Mionica')," +
                "(N'Maljeviće Peć')," +
                "(N'Maljurevac Požarevac')," +
                "(N'Mamuša Prizren')," +
                "(N'Mana Ivanjica')," +
                "(N'Manajle Vladičin Han')," +
                "(N'Manastir Niš – Niška Banja')," +
                "(N'Manastirica Kladovo')," +
                "(N'Manastirica Petrova na Mlavi')," +
                "(N'Manastirica Prizren')," +
                "(N'Manastirce Uroševac')," +
                "(N'Manđelos Sremska Mitrovica')," +
                "(N'Manić Beograd – Barajevo')," +
                "(N'Manišince Novo Brdo')," +
                "(N'Manojlica Svrljig')," +
                "(N'Manojlovce Leskovac')," +
                "(N'Manojlovci Topola')," +
                "(N'Manjak Vladičin Han')," +
                "(N'Manjinac Knjaževac')," +
                "(N'Maovi ŠaBač')," +
                "(N'Maradik Inđija')," +
                "(N'Margance Vranje')," +
                "(N'Margance Trgovište')," +
                "(N'Margita Plandište')," +
                "(N'Marevce Lipljan')," +
                "(N'Marevce Priština')," +
                "(N'Marenovo Varvarin')," +
                "(N'Marina Srbica')," +
                "(N'Marina Kutinaadžin Han')," +
                "(N'Marinovac Zaječar')," +
                "(N'Maričiće Kuršumlija')," +
                "(N'Markova Crkva Lajkovac')," +
                "(N'Markovac Beograd – Mladenovac')," +
                "(N'Markovac Velika Plana')," +
                "(N'Markovac Vršac')," +
                "(N'Markoviće Kuršumlija')," +
                "(N'Markovićevo Plandište')," +
                "(N'Markovica Lučani')," +
                "(N'Marmule Đakovica')," +
                "(N'Marovac Medveđa')," +
                "(N'Marovce Kosovska Kamenica')," +
                "(N'Martinci Sremska Mitrovica')," +
                "(N'Martonoš Kanjiža')," +
                "(N'Maršić Kragujevac')," +
                "(N'Maskar Topola')," +
                "(N'Maskare Varvarin')," +
                "(N'Maskova Ivanjica')," +
                "(N'Masloševo Kragujevac')," +
                "(N'Masurovac Babušnica')," +
                "(N'Masurica Surdulica')," +
                "(N'Matarova Kuršumlija')," +
                "(N'Mataruge Kraljevo')," +
                "(N'Mataruge Prijepolje')," +
                "(N'Mataruška Banja Kraljevo')," +
                "(N'Matijevac Vladimirci')," +
                "(N'Matica Zvečan')," +
                "(N'Matičane Priština')," +
                "(N'Maćedonce Medveđa')," +
                "(N'Maćedonce (Retkocersko) Medveđa')," +
                "(N'Maćija Ražanj')," +
                "(N'Mačvanska Mitrovica Sremska Mitrovica')," +
                "(N'Mačvanski Pričinović ŠaBač')," +
                "(N'Mačevac Svilajnac')," +
                "(N'Mačina Prokuplje')," +
                "(N'Mačitevo Suva Reka')," +
                "(N'Mačja Stena Kuršumlija')," +
                "(N'Mačkat Čajetina')," +
                "(N'Mačkatica Surdulica')," +
                "(N'Mačkovac Kruševac')," +
                "(N'Mačkovac Kuršumlija')," +
                "(N'Mašoviće Sjenica')," +
                "(N'Medare Sjenica')," +
                "(N'Medveđa Despotovac')," +
                "(N'Medveđa Medveđa')," +
                "(N'Medveđa Trstenik')," +
                "(N'Medveđica Žagubica')," +
                "(N'Medvece Lipljan')," +
                "(N'Medvece Prizren')," +
                "(N'Medevce Medveđa')," +
                "(N'Medovine Ivanjica')," +
                "(N'Medojevac Jagodina')," +
                "(N'Medoševac Beograd – Lazarevac')," +
                "(N'Medoševac Niš – Crveni krst')," +
                "(N'Medregovac Podujevo')," +
                "(N'Međa Leskovac')," +
                "(N'Međa Žitište')," +
                "(N'Međani Prijepolje')," +
                "(N'Međeđi Potok Zubin Potok')," +
                "(N'Međuvršje Čačak')," +
                "(N'Međugor Sjenica')," +
                "(N'Međulužje Beograd – Mladenovac')," +
                "(N'Međureč Jagodina')," +
                "(N'Međurečje Ivanjica')," +
                "(N'Međurečje Kraljevo')," +
                "(N'Međuhana Blace')," +
                "(N'Mezgraja Babušnica')," +
                "(N'Mezgraja Niš – Crveni krst')," +
                "(N'Mezdraja Trgovište')," +
                "(N'Mejarize Đakovica')," +
                "(N'Meki Do Zvečan')," +
                "(N'Mekiniće Leposavić')," +
                "(N'Mekiš Doljevac')," +
                "(N'Melaje Tutin')," +
                "(N'Melenci Zrenjanin')," +
                "(N'Melnica Petrova na Mlavi')," +
                "(N'Melovo Leskovac')," +
                "(N'Meljak Beograd – Barajevo')," +
                "(N'Meljanica Kraljevo')," +
                "(N'Meljenica Kosovska Mitrovica')," +
                "(N'Merdare Kuršumlija')," +
                "(N'Merdare Podujevo')," +
                "(N'Merovac Prokuplje')," +
                "(N'Merošina Merošina')," +
                "(N'Merćez Kuršumlija')," +
                "(N'Merdželat Svrljig')," +
                "(N'Mesarci Vladimirci')," +
                "(N'Mesić Vršac')," +
                "(N'Metikoš Kraljevo')," +
                "(N'Metković Bogatić')," +
                "(N'Metlić ŠaBač')," +
                "(N'Metovnica Bor')," +
                "(N'Metohija Podujevo')," +
                "(N'Metriš Zaječar')," +
                "(N'Meća Đakovica')," +
                "(N'Mehane Kuršumlija')," +
                "(N'Mehovine Vladimirci')," +
                "(N'Mečji Do Svrljig')," +
                "(N'Mečkovac Vranje')," +
                "(N'Meševo Kruševac')," +
                "(N'Mešina Kosovska Kamenica')," +
                "(N'Miganovce Kosovska Kamenica')," +
                "(N'Mijajlica Bojnik')," +
                "(N'Mijajlovac Trstenik')," +
                "(N'Mijak Vitina')," +
                "(N'Mijakovce Vranje')," +
                "(N'Mijalić Vučitrn')," +
                "(N'Mijani Prijepolje')," +
                "(N'Mijatovac Ćuprija')," +
                "(N'Mijači Valjevo')," +
                "(N'Mijovce Vranje')," +
                "(N'Mijoska Prijepolje')," +
                "(N'Mikulovac Prokuplje')," +
                "(N'Mikušnica Srbica')," +
                "(N'Milavac Ljig')," +
                "(N'Milavčići Kraljevo')," +
                "(N'Milakovac Kraljevo')," +
                "(N'Milakovići Prijepolje')," +
                "(N'Milanovac Žagubica')," +
                "(N'Milanovac Peć')," +
                "(N'Milanovićrahovac')," +
                "(N'Milanovo Vranje')," +
                "(N'Milanovo Leskovac')," +
                "(N'Milatkoviće Raška')," +
                "(N'Milatovac Batočina')," +
                "(N'Milatovac Žagubica')," +
                "(N'Milatovići Lučani')," +
                "(N'Milevci Bosilegrad')," +
                "(N'Milentija Brus')," +
                "(N'Miletićevo Plandište')," +
                "(N'Mileševo Prijepolje')," +
                "(N'Mileševo Bečej')," +
                "(N'Miliva Despotovac')," +
                "(N'Milivojce Vranje')," +
                "(N'Miliješ Priboj')," +
                "(N'Milina Loznica')," +
                "(N'Miliće Kraljevo')," +
                "(N'Milićevo Selo Požega')," +
                "(N'Milićevci Čačak')," +
                "(N'Milići Sjenica')," +
                "(N'Miličinica Valjevo')," +
                "(N'Milojkovac Pirot')," +
                "(N'Milorci Ub')," +
                "(N'Miločaj Kraljevo')," +
                "(N'Milošev Do Prijepolje')," +
                "(N'Miloševac Velika Plana')," +
                "(N'Miloševac ŠaBač')," +
                "(N'Miloševo Negotin')," +
                "(N'Miloševo Jagodina')," +
                "(N'Miloševobilić')," +
                "(N'Milutinovac Kladovo')," +
                "(N'Milutovac Trstenik')," +
                "(N'Milušinac Sokobanja')," +
                "(N'Miljaj Prizren')," +
                "(N'MiljevićoluBač')," +
                "(N'Miljevići Prijepolje')," +
                "(N'Miljkovacadžin Han')," +
                "(N'Miljkovac Knjaževac')," +
                "(N'Miljkovac Niš – Crveni krst')," +
                "(N'Miljkovica Prokuplje')," +
                "(N'Minićevo Knjaževac')," +
                "(N'Miokoviće Leposavić')," +
                "(N'Miokovci Čačak')," +
                "(N'Miokus ŠaBač')," +
                "(N'Mioliće Leposavić')," +
                "(N'Mionica Kosjerić')," +
                "(N'Mionica (varošica) Mionica')," +
                "(N'Mionica (selo) Mionica')," +
                "(N'Miranovac Bela Palanka')," +
                "(N'Miranovačka Kula Bela Palanka')," +
                "(N'Miratovac Preševo')," +
                "(N'Miraševac Rača')," +
                "(N'Mirena Lipljan')," +
                "(N'Mirijevo Žabari')," +
                "(N'Mirilovac Paraćin')," +
                "(N'Mirkovci Pirot')," +
                "(N'Mirnica Kuršumlija')," +
                "(N'Mirovac Podujevo')," +
                "(N'Mirovo Boljevac')," +
                "(N'Mironić Kragujevac')," +
                "(N'Mirosavlje Uroševac')," +
                "(N'Mirosaljci Arilje')," +
                "(N'Mirosaljci Beograd – Lazarevac')," +
                "(N'Miroč Majdanpek')," +
                "(N'Miroče Vučitrn')," +
                "(N'Miroševce Leskovac')," +
                "(N'Mirušarahovac')," +
                "(N'Misača Aranđelovac')," +
                "(N'Mislođin Beograd –brenovac')," +
                "(N'Mitrova Tutin')," +
                "(N'Mićunovo Bačka Topola')," +
                "(N'Mihajlovac Negotin')," +
                "(N'Mihajlovac Smederevo')," +
                "(N'Mihajlovo Zrenjanin')," +
                "(N'Mišar ŠaBač')," +
                "(N'Mišević Jagodina')," +
                "(N'Miševići Nova Varoš')," +
                "(N'Mišićevo Subotica')," +
                "(N'Mišljenovac Kučevo')," +
                "(N'Miščiće Novi Pazar')," +
                "(N'Mladenovac (varoš) Beograd – Mladenovac')," +
                "(N'Mladenovac (selo) Beograd – Mladenovac')," +
                "(N'Mladenovo Bačka Palanka')," +
                "(N'Mlanča Kraljevo')," +
                "(N'Mlačište Crna Trava')," +
                "(N'Mlekominci Bosilegrad')," +
                "(N'Mlečane Klina')," +
                "(N'Mlikeora')," +
                "(N'Movljane Suva Reka')," +
                "(N'Mogila Vitina')," +
                "(N'Moglica Đakovica')," +
                "(N'Modra Stena Babušnica')," +
                "(N'Modrica Kruševac')," +
                "(N'Mozgovo Aleksinac')," +
                "(N'Mozgovonjilane')," +
                "(N'Mojinci Dimitrovgrad')," +
                "(N'Mojković Krupanj')," +
                "(N'Mojsinje Ćićevac')," +
                "(N'Mojsinje Čačak')," +
                "(N'Mojstir Istok')," +
                "(N'Moklište Bela Palanka')," +
                "(N'Mokra Bela Palanka')," +
                "(N'Mokraora Užice')," +
                "(N'Mokranje Negotin')," +
                "(N'Mokrin Kikinda')," +
                "(N'Mol Ada')," +
                "(N'Molić Đakovica')," +
                "(N'Molovin Šid')," +
                "(N'Moravac Aleksinac')," +
                "(N'Moravski Bujmir Aleksinac')," +
                "(N'Moravci Ljig')," +
                "(N'Moralijarahovac')," +
                "(N'Morani Tutin')," +
                "(N'Morina Đakovica')," +
                "(N'Morović Šid')," +
                "(N'Mosna Majdanpek')," +
                "(N'Motrić Rekovac')," +
                "(N'Močare Kosovska Kamenica')," +
                "(N'Močioci Ivanjica')," +
                "(N'Mošnica Leposavić')," +
                "(N'Mošorin Titel')," +
                "(N'Moštanica Vranje')," +
                "(N'Mramor Niš – Palilula')," +
                "(N'Mramor Priština')," +
                "(N'Mramorak Kovin')," +
                "(N'Mramorac Smederevska Palanka')," +
                "(N'Mramorski Potok Niš – Palilula')," +
                "(N'Mramorsko Brdo Merošina')," +
                "(N'Mrasorrahovac')," +
                "(N'Mratišić Mionica')," +
                "(N'Mrveš Bojnik')," +
                "(N'Mrđenovac ŠaBač')," +
                "(N'Mrzenica Ćićevac')," +
                "(N'Mrkovica Leskovac')," +
                "(N'Mrkonje Medveđa')," +
                "(N'Mrljak Prokuplje')," +
                "(N'Mrmoš Aleksandrovac')," +
                "(N'Mrovska Vladimirci')," +
                "(N'Mrsać Kraljevo')," +
                "(N'Mrtvica Vladičin Han')," +
                "(N'Mrča Kuršumlija')," +
                "(N'Mrčajevci Čačak')," +
                "(N'Mrčić Valjevo')," +
                "(N'Mrčići Kosjerić')," +
                "(N'MrčkovacoluBač')," +
                "(N'Mrčkovina Prijepolje')," +
                "(N'Mršelj Prokuplje')," +
                "(N'Mršelji Požega')," +
                "(N'Mršinci Čačak')," +
                "(N'Mrštane Leskovac')," +
                "(N'Mudrakovac Kruševac')," +
                "(N'Muževine Istok')," +
                "(N'Mužinac Sokobanja')," +
                "(N'Mužičane Štimlje')," +
                "(N'Muzaće Blace')," +
                "(N'Mur Novi Pazar')," +
                "(N'Muradem Prizren')," +
                "(N'Murga Srbica')," +
                "(N'Murgaš Ub')," +
                "(N'Murgula Podujevo')," +
                "(N'Mure Raška')," +
                "(N'Musina Reka Kraljevo')," +
                "(N'Mustapić Kučevo')," +
                "(N'Musulj Bosilegrad')," +
                "(N'Mutanjornji Milanovac')," +
                "(N'Muhadžer Babuš Lipljan')," +
                "(N'Muhadžer Prelez Uroševac')," +
                "(N'Muhadžer Talinovac Uroševac')," +
                "(N'Muhovac Bujanovac')," +
                "(N'Muhovo Novi Pazar')," +
                "(N'Muhovce Uroševac')," +
                "(N'Mučibaba Knjaževac')," +
                "(N'Mučibabanjilane')," +
                "(N'Mučivrce Kosovska Kamenica')," +
                "(N'Mušvete Čajetina')," +
                "(N'Mušići Kosjerić')," +
                "(N'Muškovina Prijepolje')," +
                "(N'Mušnikovo Prizren')," +
                "(N'Mušutište Suva Reka')," +
                "(N'Naboje Tutin')," +
                "(N'Nabrđe Požarevac')," +
                "(N'Nabrđe Peć')," +
                "(N'Navalin Leskovac')," +
                "(N'Naglavci Klina')," +
                "(N'Nadalj Srbobran')," +
                "(N'Nadrlje Rekovac')," +
                "(N'Nadumce Tutin')," +
                "(N'Nazarica Bosilegrad')," +
                "(N'Nakarade Kosovo Polje')," +
                "(N'Naklo Peć')," +
                "(N'Nakovo Kikinda')," +
                "(N'Nakrivanj Leskovac')," +
                "(N'Nakučaniornji Milanovac')," +
                "(N'Nakučani ŠaBač')," +
                "(N'Namga Tutin')," +
                "(N'Nanomir Mionica')," +
                "(N'Nastavce Vranje')," +
                "(N'Natalinci Topola')," +
                "(N'Naupare Kruševac')," +
                "(N'Našec Prizren')," +
                "(N'Našpalerahovac')," +
                "(N'Našuškovica Babušnica')," +
                "(N'Nebregošte Prizren')," +
                "(N'Nevada Kuršumlija')," +
                "(N'Nevadeornji Milanovac')," +
                "(N'Nevoljane Vučitrn')," +
                "(N'Negbina Nova Varoš')," +
                "(N'Negovac Bujanovac')," +
                "(N'Negosavlje Medveđa')," +
                "(N'Negotin Negotin')," +
                "(N'Negotinac Novi Pazar')," +
                "(N'Negrišori Lučani')," +
                "(N'Negrovcelogovac')," +
                "(N'Nedakovac Vučitrn')," +
                "(N'Nekovcelogovac')," +
                "(N'Nekodim Uroševac')," +
                "(N'Nemenikuće Beograd – Sopot')," +
                "(N'Nepolje Peć')," +
                "(N'Neprebište Suva Reka')," +
                "(N'Nepričava Lajkovac')," +
                "(N'Neradin Irig')," +
                "(N'Neresnica Kučevo')," +
                "(N'Nesalce Bujanovac')," +
                "(N'Nesvrta Leskovac')," +
                "(N'Nesvrta Vranjska Banja')," +
                "(N'Nećavce Kačanik')," +
                "(N'Neuzina Sečanj')," +
                "(N'Nec Đakovica')," +
                "(N'Neštin Bačka Palanka')," +
                "(N'Nivokaz Đakovica')," +
                "(N'Nika Kačanik')," +
                "(N'Nikinci Ruma')," +
                "(N'Nikovce Kačanik')," +
                "(N'Nikojevići Užice')," +
                "(N'Nikola Tesla Niš – Niška Banja')," +
                "(N'Nikolinac Sokobanja')," +
                "(N'Nikolinci Alibunar')," +
                "(N'Nikoličevo Zaječar')," +
                "(N'Nikšić Batočina')," +
                "(N'Niš (Medijana) Niš – Medijana')," +
                "(N'Niš (Palilula) Niš – Palilula')," +
                "(N'Niš (Pantelej) Niš – Pantelej')," +
                "(N'Niš (Crveni krst) Niš – Crveni krst')," +
                "(N'Niševac Svrljig')," +
                "(N'Niševce Priština')," +
                "(N'Niška Banja Niš – Niška Banja')");
                  migrationBuilder.Sql(
                "insert into Mesta(NazivMesta) values " +
                "(N'Nišor Pirot')," +
                "(N'Nišor Suva Reka')," +
                "(N'Njegoševo Bačka Topola')," +
                "(N'Nova Božurna Prokuplje')," +
                "(N'Nova Brezovica Vranje')," +
                "(N'Nova Varoš Nova Varoš')," +
                "(N'Novaajdobra Bačka Palanka')," +
                "(N'Nova Pazova Stara Pazova')," +
                "(N'Nova Topola Lebane')," +
                "(N'Nova Crvenka Kula')," +
                "(N'Nova Crnja Nova Crnja')," +
                "(N'Nova Šumadija Prizren')," +
                "(N'Novake Prizren')," +
                "(N'Novaci Aleksandrovac')," +
                "(N'Novaci Ub')," +
                "(N'Novi Banovci Stara Pazova')," +
                "(N'Novi Bečej Novi Bečej')," +
                "(N'Novi Bračin Ražanj')," +
                "(N'Novi Verić Istok')," +
                "(N'Novilog Trgovište')," +
                "(N'Novi Đurovac Prokuplje')," +
                "(N'Novi Žednik Subotica')," +
                "(N'Novi Zavoj Pirot')," +
                "(N'Novi Itebej Žitište')," +
                "(N'Novi Karlovci Inđija')," +
                "(N'Novi Kneževac Novi Kneževac')," +
                "(N'Novi Kozarci Kikinda')," +
                "(N'Novi Kozjak Alibunar')," +
                "(N'Novi Milanovac Kragujevac')," +
                "(N'Novi Miraš Uroševac')," +
                "(N'Novi Pazar Novi Pazar')," +
                "(N'Novi Raušić Peć')," +
                "(N'Novi Sad Novi Sad')," +
                "(N'Novi Sip Kladovo')," +
                "(N'Novi Slankamen Inđija')," +
                "(N'Novo Brdo Novo Brdo')," +
                "(N'Novo Korito Knjaževac')," +
                "(N'Novo Lanište Jagodina')," +
                "(N'Novo Miloševo Novi Bečej')," +
                "(N'Novo Momčilovo Žitorađa')," +
                "(N'Novorahovo Bačka Topola')," +
                "(N'Novo Rujce Lipljan')," +
                "(N'Novo Selo Bela Palanka')," +
                "(N'Novo Selo Bujanovac')," +
                "(N'Novo Selo Velika Plana')," +
                "(N'Novo Selo Vladimirci')," +
                "(N'Novo Selo Vrnjačka Banja')," +
                "(N'Novo Seloadžin Han')," +
                "(N'Novo Selo Kuršumlija')," +
                "(N'Novo Selo Lebane')," +
                "(N'Novo Selo Leskovac')," +
                "(N'Novo Selo Loznica')," +
                "(N'Novo Selo Prokuplje')," +
                "(N'Novo Selo Raška')," +
                "(N'Novo Selo Sokobanja')," +
                "(N'Novo Selo Surdulica')," +
                "(N'Novo Selo Trgovište')," +
                "(N'Novo Selo Kanjiža')," +
                "(N'Novo Selo Vitina')," +
                "(N'Novo Selo Kosovska Kamenica')," +
                "(N'Novo Selo Peć')," +
                "(N'Novo Selo Prizren')," +
                "(N'Novo Selo Srbica')," +
                "(N'Novo Selo Begovo Vučitrn')," +
                "(N'Novo Selo Mađunsko Vučitrn')," +
                "(N'Novo Čikatovologovac')," +
                "(N'Nogavacrahovac')," +
                "(N'Nozrina Aleksinac')," +
                "(N'Nomanica Leskovac')," +
                "(N'Norča Preševo')," +
                "(N'Nosaljenjilane')," +
                "(N'Nosoljin Raška')," +
                "(N'Noćaj Sremska Mitrovica')," +
                "(N'Noćaje Tutin')," +
                "(N'Obajgora Bajina Bašta')," +
                "(N'Obilić Bojnik')," +
                "(N'Obilićbilić')," +
                "(N'Oblačina Merošina')," +
                "(N'Oblička Sena Vranje')," +
                "(N'Obornjača Ada')," +
                "(N'Obornjača Bačka Topola')," +
                "(N'Obradovce Crna Trava')," +
                "(N'Obražda Bojnik')," +
                "(N'Obrandža Podujevo')," +
                "(N'Obrva Kraljevo')," +
                "(N'Obrež Varvarin')," +
                "(N'Obrež Pećinci')," +
                "(N'Obrenovac Beograd –brenovac')," +
                "(N'Obrenovac Pirot')," +
                "(N'Obrovac Bačka Palanka')," +
                "(N'Obrtince Prokuplje')," +
                "(N'Ovsinjinacadžin Han')," +
                "(N'Ovsište Topola')," +
                "(N'Ovča Beograd – Palilula')," +
                "(N'Ovčar Banja Čačak')," +
                "(N'Ovčare Kosovska Mitrovica')," +
                "(N'Ovčarevo Srbica')," +
                "(N'Ovčinja Bajina Bašta')," +
                "(N'Ogar Pećinci')," +
                "(N'Oglađenovac Valjevo')," +
                "(N'Ogošte Kosovska Kamenica')," +
                "(N'Odanovce Kosovska Kamenica')," +
                "(N'Odevce Kosovska Kamenica')," +
                "(N'Odojeviće Novi Pazar')," +
                "(N'Ozremornji Milanovac')," +
                "(N'Ozrim Peć')," +
                "(N'Ojkovica Nova Varoš')," +
                "(N'Oklap Lipljan')," +
                "(N'Oklace Zubin Potok')," +
                "(N'Okletac Bajina Bašta')," +
                "(N'Okolište Svrljig')," +
                "(N'Okose Novi Pazar')," +
                "(N'Okosnica Lipljan')," +
                "(N'Okraštica Vučitrn')," +
                "(N'Okruglica Svrljig')," +
                "(N'Okruglica Trstenik')," +
                "(N'Omoljica Pančevo')," +
                "(N'Opaljenik Ivanjica')," +
                "(N'Oparić Rekovac')," +
                "(N'Oplanić Knić')," +
                "(N'Oplanići Kraljevo')," +
                "(N'Opovopovo')," +
                "(N'Opornica Kragujevac')," +
                "(N'Opterušarahovac')," +
                "(N'Orane Bojnik')," +
                "(N'Oraovac Prijepolje')," +
                "(N'Oraovica Preševo')," +
                "(N'Oraovica Kosovska Kamenica')," +
                "(N'Oraovica Zvečan')," +
                "(N'Oraovica (kodrdelice) Leskovac')," +
                "(N'Oraovica (kod Crkovnice) Leskovac')," +
                "(N'Orahovacrahovac')," +
                "(N'Orahovo Raška')," +
                "(N'Orahovo Kosovska Mitrovica')," +
                "(N'Orašac Aranđelovac')," +
                "(N'Orašac Beograd –brenovac')," +
                "(N'Orašac Leskovac')," +
                "(N'Orašac Prijepolje')," +
                "(N'Orašac ŠaBač')," +
                "(N'Oraše Tutin')," +
                "(N'Orašje Varvarin')," +
                "(N'Orašje Vlasotince')," +
                "(N'Oreovac Bela Palanka')," +
                "(N'Oreovac Niš – Pantelej')," +
                "(N'Oreovica Žabari')," +
                "(N'Oreovica Pirot')," +
                "(N'Orešac Knjaževac')," +
                "(N'Orešac Vršac')," +
                "(N'Oreškovica Petrova na Mlavi')," +
                "(N'Orid ŠaBač')," +
                "(N'Orlane Podujevo')," +
                "(N'Orlatelogovac')," +
                "(N'Orlovat Zrenjanin')," +
                "(N'Orlovac Kuršumlija')," +
                "(N'Orlović Priština')," +
                "(N'Orlja Pirot')," +
                "(N'Orljalava Kraljevo')," +
                "(N'Orljane Doljevac')," +
                "(N'Orlje Tutin')," +
                "(N'Orljevo Petrova na Mlavi')," +
                "(N'Orno Brdo Istok')," +
                "(N'Orovička Planina Ljubovija')," +
                "(N'Orom Kanjiža')," +
                "(N'Oruglica Leskovac')," +
                "(N'Orčušaora')," +
                "(N'Osanica Žagubica')," +
                "(N'Osaonica Novi Pazar')," +
                "(N'Osaonica Trstenik')," +
                "(N'Osek Paša Đakovica')," +
                "(N'Osek Hilja Đakovica')," +
                "(N'Osečenica Mionica')," +
                "(N'Osečina (varošica)sečina')," +
                "(N'Osečina (selo)sečina')," +
                "(N'Osipaonica Smederevo')," +
                "(N'Osladić Valjevo')," +
                "(N'Oslare Bujanovac')," +
                "(N'Osmakova Pirot')," +
                "(N'Osnić Boljevac')," +
                "(N'Osojane Istok')," +
                "(N'Osoje Novi Pazar')," +
                "(N'Osoje Prijepolje')," +
                "(N'Osoje Peć')," +
                "(N'Osonica Ivanjica')," +
                "(N'Osreci Brus')," +
                "(N'Ostatovica Babušnica')," +
                "(N'Ostojićevo Čoka')," +
                "(N'Ostra Čačak')," +
                "(N'Ostralava Vranje')," +
                "(N'Ostraće Leposavić')," +
                "(N'Ostrikovac Ćuprija')," +
                "(N'Ostrovica Vladičin Han')," +
                "(N'Ostrovica Tutin')," +
                "(N'Ostrovica Niš – Niška Banja')," +
                "(N'Ostrovo Velikoradište')," +
                "(N'Ostrovo Kostolac')," +
                "(N'Ostrozub Crna Trava')," +
                "(N'Ostrozubrahovac')," +
                "(N'Ostružanjsečina')," +
                "(N'Ostružnica Beograd – Čukarica')," +
                "(N'Ostrc Vlasotince')," +
                "(N'Otanj Požega')," +
                "(N'Otroci Vrnjačka Banja')," +
                "(N'Oholje Novi Pazar')," +
                "(N'Očage Bogatić')," +
                "(N'Odžaci Trstenik')," +
                "(N'Odžacidžaci')," +
                "(N'Ošljane Knjaževac')," +
                "(N'Ošljane Vučitrn')," +
                "(N'Oštra Stijena Prijepolje')," +
                "(N'Oštrelj Bor')," +
                "(N'Pavaštica Kuršumlija')," +
                "(N'Pavlica Raška')," +
                "(N'Pavličina Crna Trava')," +
                "(N'Pavliš Vršac')," +
                "(N'Pavlovac Vranje')," +
                "(N'Pavlovac Topola')," +
                "(N'Pavlovci Ruma')," +
                "(N'Pavlje Novi Pazar')," +
                "(N'Pagarušarahovac')," +
                "(N'Padalište Srbica')," +
                "(N'Padež Kruševac')," +
                "(N'Padež Leskovac')," +
                "(N'Padej Čoka')," +
                "(N'Padina Merošina')," +
                "(N'Padina Kovačica')," +
                "(N'Padine Zubin Potok')," +
                "(N'Padinska Skela Beograd – Palilula')," +
                "(N'Pajazitovo Kragujevac')," +
                "(N'Pajež Bela Palanka')," +
                "(N'Pajkovac Varvarin')," +
                "(N'Pajsak Trstenik')," +
                "(N'Pajsijević Knić')," +
                "(N'Pakašnica Kruševac')," +
                "(N'Pakleštica Pirot')," +
                "(N'Paklje Valjevo')," +
                "(N'Pakovraće Čačak')," +
                "(N'Palatna Podujevo')," +
                "(N'Paležnica Ljig')," +
                "(N'Palivodenica Kačanik')," +
                "(N'Paligrace Niš – Crveni krst')," +
                "(N'Palikuća Leskovac')," +
                "(N'Palilula Svrljig')," +
                "(N'Palić Subotica')," +
                "(N'Palojce Leskovac')," +
                "(N'Palja Surdulica')," +
                "(N'Paljabarda Đakovica')," +
                "(N'Paljane Ćuprija')," +
                "(N'Paljevo Tutin')," +
                "(N'Paljevštica Brus')," +
                "(N'Paljina Niš – Crveni krst')," +
                "(N'Paljuvi Ub')," +
                "(N'Pambukovica Ub')," +
                "(N'Panevlje Vranjska Banja')," +
                "(N'Pankovo Petrova na Mlavi')," +
                "(N'Panojeviće Raška')," +
                "(N'Panonija Bačka Topola')," +
                "(N'Pantina Vučitrn')," +
                "(N'Pančevo Pančevo')," +
                "(N'Pančelo Kosovska Kamenica')," +
                "(N'Panjak Užice')," +
                "(N'Panjevac Aleksandrovac')," +
                "(N'Panjevac Despotovac')," +
                "(N'Papaz Suva Reka')," +
                "(N'Papaz Uroševac')," +
                "(N'Papić Dečani')," +
                "(N'Papiće Sjenica')," +
                "(N'Papratište Požega')," +
                "(N'Papratna Knjaževac')," +
                "(N'Papraćane Dečani')," +
                "(N'Parage Bačka Palanka')," +
                "(N'Parada Kuršumlija')," +
                "(N'Paralovo Bosilegrad')," +
                "(N'Paralovo Novi Pazar')," +
                "(N'Paralovonjilane')," +
                "(N'Paramun Kosjerić')," +
                "(N'Paraćin Paraćin')," +
                "(N'Pardik Ražanj')," +
                "(N'Parmenac Čačak')," +
                "(N'Parta Vršac')," +
                "(N'Partešnjilane')," +
                "(N'Parunovac Kruševac')," +
                "(N'Paruce Zubin Potok')," +
                "(N'Parcane Varvarin')," +
                "(N'Parcani Beograd – Sopot')," +
                "(N'Parčin Aleksandrovac')," +
                "(N'Pasi Poljana Niš – Palilula')," +
                "(N'Pasjak Kruševac')," +
                "(N'Pasjaknjilane')," +
                "(N'Pasjanenjilane')," +
                "(N'Pasjač Pirot')," +
                "(N'Pasjača Prokuplje')," +
                "(N'Pasjača Niš – Pantelej')," +
                "(N'Pasji Potok Novi Pazar')," +
                "(N'Paskašija Dimitrovgrad')," +
                "(N'Paskovac Loznica')," +
                "(N'Pasoma Vučitrn')," +
                "(N'Paune Valjevo')," +
                "(N'Pacaj Đakovica')," +
                "(N'Pačarađa Kuršumlija')," +
                "(N'Pačir Bačka Topola')," +
                "(N'Pašinac Prokuplje')," +
                "(N'Pašino Selo Peć')," +
                "(N'Paštrić Mionica')," +
                "(N'Pear Užice')," +
                "(N'Pejinović Vladimirci')," +
                "(N'Pejkovac Žitorađa')," +
                "(N'Pekčanica Kraljevo')," +
                "(N'Penduha Podujevo')," +
                "(N'Pepelj Bajina Bašta')," +
                "(N'Pepeljevac Kruševac')," +
                "(N'Pepeljevac Kuršumlija')," +
                "(N'Pepeljevac Lajkovac')," +
                "(N'Pepiće Peć')," +
                "(N'Perane Podujevo')," +
                "(N'Periš Svrljig')," +
                "(N'Perlez Zrenjanin')," +
                "(N'Pertate Lebane')," +
                "(N'Perunika Kuršumlija')," +
                "(N'Perutina Doljevac')," +
                "(N'Perućac Bajina Bašta')," +
                "(N'Pestiš Prokuplje')," +
                "(N'Pestovo Vučitrn')," +
                "(N'Petačinci Dimitrovgrad')," +
                "(N'Peterlaš Dimitrovgrad')," +
                "(N'Petina Kruševac')," +
                "(N'Petka Beograd – Lazarevac')," +
                "(N'Petka Kostolac')," +
                "(N'Petkovićrahovac')," +
                "(N'Petkovica ŠaBač')," +
                "(N'Petlovača ŠaBač')," +
                "(N'Petnica Valjevo')," +
                "(N'Petnica Čačak')," +
                "(N'Petraštica Štimlje')," +
                "(N'Petrijevo Smederevo')," +
                "(N'Petrilje Medveđa')," +
                "(N'Petrovaradin Petrovaradin')," +
                "(N'Petrovac Lebane')," +
                "(N'Petrovac Leskovac')," +
                "(N'Petrovac Pirot')," +
                "(N'Petrovac Prokuplje')," +
                "(N'Petrovac Trgovište')," +
                "(N'Petrovac na Mlavi Petrova na Mlavi')," +
                "(N'Petrović Štimlje')," +
                "(N'Petrovo Štimlje')," +
                "(N'Petrovo Polje Sjenica')," +
                "(N'Petrovo Selo Kladovo')," +
                "(N'Petrovo Selo Prizren')," +
                "(N'Petrovce Kosovska Kamenica')," +
                "(N'Petrovčić Beograd – Surčin')," +
                "(N'Petropolje Kraljevo')," +
                "(N'Petruša Knjaževac')," +
                "(N'Petrušan Đakovica')," +
                "(N'Peć Peć')," +
                "(N'Pećane Suva Reka')," +
                "(N'Pećani Beograd – Čukarica')," +
                "(N'Pećinci Pećinci')," +
                "(N'Peckasečina')," +
                "(N'Pečanica Velikoradište')," +
                "(N'Pečeno Preševo')," +
                "(N'Pečenog Kraljevo')," +
                "(N'Pečenjevce Leskovac')," +
                "(N'Pivnice Bačka Palanka')," +
                "(N'Pidićnjilane')," +
                "(N'Pilareta Novi Pazar')," +
                "(N'Pilatovići Požega')," +
                "(N'Pilica Bajina Bašta')," +
                "(N'Pinosava Beograd – Voždovac')," +
                "(N'Pirane Prizren')," +
                "(N'Pirkovac Svrljig')," +
                "(N'Piroman Beograd –brenovac')," +
                "(N'Pirot Pirot')," +
                "(N'Pirče Kosovska Mitrovica')," +
                "(N'Piskalje Prokuplje')," +
                "(N'Piskanja Raška')," +
                "(N'Piskopovce Tutin')," +
                "(N'Piskupovo Leskovac')," +
                "(N'Pištane Peć')," +
                "(N'Plava Prizren')," +
                "(N'Plavkovo Raška')," +
                "(N'Plavljane Peć')," +
                "(N'Plavna Negotin')," +
                "(N'Plavna Bač')," +
                "(N'Plavce Bojnik')," +
                "(N'Plažane Despotovac')," +
                "(N'Plajnik Prizren')," +
                "(N'Plakaonica Leposavić')," +
                "(N'Plana Kraljevo')," +
                "(N'Plana Paraćin')," +
                "(N'Plana Sjenica')," +
                "(N'Plandište Plandište')," +
                "(N'Planeja Prizren')," +
                "(N'Planina Krupanj')," +
                "(N'Planinica Dimitrovgrad')," +
                "(N'Planinica Zaječar')," +
                "(N'Planinica Mionica')," +
                "(N'Planinica Pirot')," +
                "(N'Planinica Trstenik')," +
                "(N'Planinica Leposavić')," +
                "(N'Planjane Prizren')," +
                "(N'Plaskovac Topola')," +
                "(N'Platičevo Ruma')," +
                "(N'Plašće Priboj')," +
                "(N'Plemetinabilić')," +
                "(N'Plenibabe Tutin')," +
                "(N'Pleš Aleksandrovac')," +
                "(N'Plešin Raška')," +
                "(N'Plešina Uroševac')," +
                "(N'Plitković Lipljan')," +
                "(N'Ploča Aleksandrovac')," +
                "(N'Ploča Bosilegrad')," +
                "(N'Ploča Loznica')," +
                "(N'Pločica Kovin')," +
                "(N'Pločice Klina')," +
                "(N'Pločnik Prokuplje')," +
                "(N'Pločnik Ćićevac')," +
                "(N'Plužacsečina')," +
                "(N'Plužina Svrljig')," +
                "(N'Plužina Srbica')," +
                "(N'Pljakovo Kuršumlija')," +
                "(N'Pljančor Đakovica')," +
                "(N'Pljačkovica Vranje')," +
                "(N'Pobeda Bačka Topola')," +
                "(N'Pobrđe Novi Pazar')," +
                "(N'Pobrđe Raška')," +
                "(N'Pobrđe Dečani')," +
                "(N'Poganovo Dimitrovgrad')," +
                "(N'Pogled Arilje')," +
                "(N'Pograđe Klina')," +
                "(N'Poda Sjenica')," +
                "(N'Podvis Knjaževac')," +
                "(N'Podvrška Kladovo')," +
                "(N'Podgorac Boljevac')," +
                "(N'Podgorac Ražanj')," +
                "(N'Podgorce Vitina')," +
                "(N'Podgrađenjilane')," +
                "(N'Podina Žitorađa')," +
                "(N'Podlokanj Novi Kneževac')," +
                "(N'Podnemić Ljubovija')," +
                "(N'Podrimce Leskovac')," +
                "(N'Podujevo Podujevo')," +
                "(N'Podunavci Vrnjačka Banja')," +
                "(N'Požar Dečani')," +
                "(N'Požaranje Vitina')," +
                "(N'Požarevac Požarevac')," +
                "(N'Požega Novi Pazar')," +
                "(N'Požega Požega')," +
                "(N'Požegrmac Priboj')," +
                "(N'Požeženo Velikoradište')," +
                "(N'Požežina Novi Pazar')," +
                "(N'Pozlata Kruševac')," +
                "(N'Pojate Ćićevac')," +
                "(N'Pojatište Uroševac')," +
                "(N'Pokleklogovac')," +
                "(N'Pokrvenik Raška')," +
                "(N'Pokrvenik Tutin')," +
                "(N'Pokrevenik Pirot')," +
                "(N'Polatna Žabari')," +
                "(N'Polička Kosovska Kamenica')," +
                "(N'Polokce Novi Pazar')," +
                "(N'Polom Vladičin Han')," +
                "(N'Polomornji Milanovac')," +
                "(N'Polužalogovac')," +
                "(N'Polužarahovac')," +
                "(N'Polumir Kraljevo')," +
                "(N'Poljana Požarevac')," +
                "(N'Poljane Beograd –brenovac')," +
                "(N'Poljane Istok')," +
                "(N'Poljanice Ljig')," +
                "(N'Poljance Srbica')," +
                "(N'Poljaci Kruševac')," +
                "(N'Poljna Trstenik')," +
                "(N'Poljska Ržana Pirot')," +
                "(N'Pomazatin Kosovo Polje')," +
                "(N'Pomijača Loznica')," +
                "(N'Ponešnjilane')," +
                "(N'PonikveoluBač')," +
                "(N'Ponikovica Užice')," +
                "(N'Ponor Knjaževac')," +
                "(N'Ponor Pirot')," +
                "(N'Ponorac Sjenica')," +
                "(N'Ponoracrahovac')," +
                "(N'Ponoševac Đakovica')," +
                "(N'Popadić Mionica')," +
                "(N'Pope Novi Pazar')," +
                "(N'Pope Tutin')," +
                "(N'Popina Trstenik')," +
                "(N'Popinci Pećinci')," +
                "(N'Popiće Tutin')," +
                "(N'Popova Blace')," +
                "(N'Popovac Velikoradište')," +
                "(N'Popovac Paraćin')," +
                "(N'Popovac Niš – Crveni krst')," +
                "(N'Popovac Đakovica')," +
                "(N'Popović Beograd – Sopot')," +
                "(N'Popović Rača')," +
                "(N'Popovići Kraljevo')," +
                "(N'Popovica Negotin')," +
                "(N'Popovljane Suva Reka')," +
                "(N'Popovnjak Despotovac')," +
                "(N'Popovo Podujevo')," +
                "(N'Popovce Lebane')," +
                "(N'Popovce Leposavić')," +
                "(N'Popovci Aleksandrovac')," +
                "(N'Popučke Valjevo')," +
                "(N'Popšica Svrljig')," +
                "(N'Porodin Aleksinac')," +
                "(N'Porodin Žabari')," +
                "(N'Poroštica Lebane')," +
                "(N'Poroštica Medveđa')," +
                "(N'Poružnica Sokobanja')," +
                "(N'Poskurice Kragujevac')," +
                "(N'Poslište Prizren')," +
                "(N'Poslon Ražanj')," +
                "(N'Postenje Ljubovija')," +
                "(N'Postenje Novi Pazar')," +
                "(N'Potkomlje Leposavić')," +
                "(N'Potkrš Prijepolje')," +
                "(N'Potok Prijepolje')," +
                "(N'Potok Podujevo')," +
                "(N'Potočanje Užice')," +
                "(N'Potočac Paraćin')," +
                "(N'Potočić Prokuplje')," +
                "(N'Potpeće Užice')," +
                "(N'Potporanj Vršac')," +
                "(N'Potreb Tutin')," +
                "(N'Potrkanje Knjaževac')," +
                "(N'Poturovce Lipljan')," +
                "(N'Pousko Prizren')," +
                "(N'Pocerski Metković ŠaBač')," +
                "(N'Pocerski Pričinović ŠaBač')," +
                "(N'Pocesje Raška')," +
                "(N'Počekovina Trstenik')," +
                "(N'Počešće Peć')," +
                "(N'Pravoševo Prijepolje')," +
                "(N'Pralja Sjenica')," +
                "(N'Pranjaniornji Milanovac')," +
                "(N'Pranjci Prijepolje')," +
                "(N'Praskovče Ražanj')," +
                "(N'Prahovo Negotin')," +
                "(N'Prača Dimitrovgrad')," +
                "(N'Prva Kutina Niš – Niška Banja')," +
                "(N'Prvi Tunel Kosovska Mitrovica')," +
                "(N'Prvonek Vranjska Banja')," +
                "(N'Prebreza Blace')," +
                "(N'Prevalac Vranjska Banja')," +
                "(N'Prevetica Kuršumlija')," +
                "(N'Prevešt Rekovac')," +
                "(N'Prevlak Zubin Potok')," +
                "(N'Predvorica ŠaBač')," +
                "(N'Predejane (varoš) Leskovac')," +
                "(N'Predejane (selo) Leskovac')," +
                "(N'Predole Kraljevo')," +
                "(N'Prekadin Prokuplje')," +
                "(N'Prekale Istok')," +
                "(N'Prekašnica Prokuplje')," +
                "(N'Prekovce Novo Brdo')," +
                "(N'Prekodolce Vladičin Han')," +
                "(N'Prekoluka Dečani')," +
                "(N'Prekonoga Svrljig')," +
                "(N'Prekonozi Aleksinac')," +
                "(N'Prekopeča Kragujevac')," +
                "(N'Prekopuce Prokuplje')," +
                "(N'Prekopčelica Lebane')," +
                "(N'Prekorađa Kuršumlija')," +
                "(N'Prelez Zubin Potok')," +
                "(N'Prelovac Srbica')," +
                "(N'Preljina Čačak')," +
                "(N'Premeća Čačak')," +
                "(N'Preobraženje Vranje')," +
                "(N'Preoce Priština')," +
                "(N'Prepolac Podujevo')," +
                "(N'Preseka Babušnica')," +
                "(N'Preseka Ivanjica')," +
                "(N'Preseka Zubin Potok')," +
                "(N'Presečina Leskovac')," +
                "(N'Preslap Crna Trava')," +
                "(N'Pretežana Blace')," +
                "(N'Pretina Bujanovac')," +
                "(N'Pretoke Knić')," +
                "(N'Pretrešnja Blace')," +
                "(N'Pretrkovac Ražanj')," +
                "(N'Preševo Preševo')," +
                "(N'Pržojne Vlasotince')," +
                "(N'Pribovce Bujanovac')," +
                "(N'Priboj Vladičin Han')," +
                "(N'Priboj Leskovac')," +
                "(N'Priboj Priboj')," +
                "(N'Pribojskaoleša Priboj')," +
                "(N'Pribojske Čelice Priboj')," +
                "(N'Privinalava Šid')," +
                "(N'Prigoda Istok')," +
                "(N'Prigrevica Apatin')," +
                "(N'Pridvorica Blace')," +
                "(N'Pridvorica Bojnik')," +
                "(N'Pridvorica Lajkovac')," +
                "(N'Pridvorica Čačak')," +
                "(N'Pridvorica Zubin Potok')," +
                "(N'Pridvorica Leposavić')," +
                "(N'Pridvorice Smederevska Palanka')," +
                "(N'Pridoli Bajina Bašta')," +
                "(N'Prizren Prizren')," +
                "(N'Prijanovići Požega')," +
                "(N'Prijevor Čačak')," +
                "(N'Prijezdić Valjevo')," +
                "(N'Prijepolje Prijepolje')," +
                "(N'Prilep Dečani')," +
                "(N'Prilepac Vlasotince')," +
                "(N'Prilepnicanjilane')," +
                "(N'Prilike Ivanjica')," +
                "(N'Prilipac Požega')," +
                "(N'Prilužje Vučitrn')," +
                "(N'Prisjan Pirot')," +
                "(N'Prislonica Čačak')," +
                "(N'Pričevac Knjaževac')," +
                "(N'Pričević Valjevo')," +
                "(N'Priština Priština')," +
                "(N'Prkosava Beograd – Lazarevac')," +
                "(N'Prlita Zaječar')," +
                "(N'Prnjavor Batočina')," +
                "(N'Prnjavorornji Milanovac')," +
                "(N'Prnjavor Trstenik')," +
                "(N'Prnjavor ŠaBač')," +
                "(N'Provaljenik Babušnica')," +
                "(N'Provo Vladimirci')," +
                "(N'Progar Beograd – Surčin')," +
                "(N'Progorelica Kraljevo')," +
                "(N'Progoreoci Aranđelovac')," +
                "(N'Prokuplje Prokuplje')," +
                "(N'Prolesje Trgovište')," +
                "(N'Prolom Kuršumlija')," +
                "(N'Propaštica Priština')," +
                "(N'Prosek Niš – Niška Banja')," +
                "(N'Protopopinci Dimitrovgrad')," +
                "(N'Proštinac Svilajnac')," +
                "(N'Prćenova Novi Pazar')," +
                "(N'Prćilovica Aleksinac')," +
                "(N'Prugovac Aleksinac')," +
                "(N'Prugovac Priština')," +
                "(N'Prugovo Požarevac')," +
                "(N'Pružanj Tutin')," +
                "(N'Pružatovac Beograd – Mladenovac')," +
                "(N'Prhovo Pećinci')," +
                "(N'Prčevo Klina')," +
                "(N'Pudarci Beograd –rocka')," +
                "(N'Pukovac Doljevac')," +
                "(N'Pusta Tušimlja Novi Pazar')," +
                "(N'Pustenik Kačanik')," +
                "(N'Pusto Selorahovac')," +
                "(N'Pusto Šilovo Medveđa')," +
                "(N'Pustovlah Novi Pazar')," +
                "(N'Putinci Ruma')," +
                "(N'Putnikovo Kovačica')," +
                "(N'Puhovac Aleksandrovac')," +
                "(N'Puhovo Lučani')," +
                "(N'Pšanik Lučani')," +
                "(N'Rabas Valjevo')," +
                "(N'Rabe Novi Kneževac')," +
                "(N'Rabenovac Rekovac')," +
                "(N'Rabovce Lipljan')," +
                "(N'Rabrovac Beograd – Mladenovac')," +
                "(N'Rabrovo Kučevo')," +
                "(N'Ravanica Kraljevo')," +
                "(N'Ravna Knjaževac')," +
                "(N'Ravna Banja Medveđa')," +
                "(N'Ravnaora Vlasotince')," +
                "(N'Ravnaora Ivanjica')," +
                "(N'Ravna Dubravaadžin Han')," +
                "(N'Ravna Reka Vladičin Han')," +
                "(N'Ravna Reka Despotovac')," +
                "(N'Ravnaja Krupanj')," +
                "(N'Ravni Brus')," +
                "(N'Ravni Užice')," +
                "(N'Ravni Del Vlasotince')," +
                "(N'Ravni Del Leskovac')," +
                "(N'Ravni Do Niš – Niška Banja')," +
                "(N'Ravni Topolovac Žitište')," +
                "(N'Ravni Šort Kuršumlija')," +
                "(N'Ravnište Brus')," +
                "(N'Ravnište Kučevo')," +
                "(N'Ravnište Vitina')," +
                "(N'Ravno Bučje Bujanovac')," +
                "(N'Ravno Bučje Knjaževac')," +
                "(N'Ravno Selo Vrbas')," +
                "(N'Ravnje Valjevo')," +
                "(N'Ravnje Sremska Mitrovica')," +
                "(N'Ragodeš Pirot')," +
                "(N'Radavac Peć')," +
                "(N'Radalj Mali Zvornik')," +
                "(N'Radaljevo Ivanjica')," +
                "(N'Radaljica Novi Pazar')," +
                "(N'Radanovci Kosjerić')," +
                "(N'Radevo Lipljan')," +
                "(N'Radevce Aleksinac')," +
                "(N'Radevce Lebane')," +
                "(N'Radejna Dimitrovgrad')," +
                "(N'Radenka Kučevo')," +
                "(N'Radenkovac Sokobanja')," +
                "(N'Radenković Sremska Mitrovica')," +
                "(N'Radešaora')," +
                "(N'Radivojce Vitina')," +
                "(N'Radijevići Nova Varoš')," +
                "(N'Radikina Bara Niš – Niška Banja')," +
                "(N'Radinac Smederevo')," +
                "(N'Radinovac Lebane')," +
                "(N'Radinjince Babušnica')," +
                "(N'Radičevac Knjaževac')," +
                "(N'Radičević Bečej')," +
                "(N'Radičevci Bosilegrad')," +
                "(N'Radiševo Srbica')," +
                "(N'Radljevo Ub')," +
                "(N'Radmanovo Brus')," +
                "(N'Radmilović Knić')," +
                "(N'Radmirovac Svrljig')," +
                "(N'Radobić Mionica')," +
                "(N'Radobuđa Arilje')," +
                "(N'Radovanje Velika Plana')," +
                "(N'Radovašnica ŠaBač')," +
                "(N'Radovnica Trgovište')," +
                "(N'Radovci Požega')," +
                "(N'Radoinja Nova Varoš')," +
                "(N'Radojevo Nova Crnja')," +
                "(N'Radonjić Đakovica')," +
                "(N'Radonjica Leskovac')," +
                "(N'Radosin Babušnica')," +
                "(N'Radosterahovac')," +
                "(N'Radoševac Babušnica')," +
                "(N'RadoševacoluBač')," +
                "(N'Radoševac Priština')," +
                "(N'Radoševo Arilje')," +
                "(N'Radošin Svilajnac')," +
                "(N'Radošiće Raška')," +
                "(N'Radujevac Negotin')," +
                "(N'Radujevac Podujevo')," +
                "(N'Radulovac Klina')," +
                "(N'Radunje Brus')," +
                "(N'Raduhovce Tutin')," +
                "(N'Raduša Užice')," +
                "(N'Raduša Tutin')," +
                "(N'Raduša Ub')," +
                "(N'Rađevo Selo Valjevo')," +
                "(N'Ražanj Ražanj')," +
                "(N'Raždaginja Sjenica')," +
                "(N'Razbojna Brus')," +
                "(N'Razgojna Leskovac')," +
                "(N'Rajanovce Kosovska Kamenica')," +
                "(N'Rajac Negotin')," +
                "(N'Rajac Čačak')," +
                "(N'Rajetiće Novi Pazar')," +
                "(N'Rajinac Trstenik')," +
                "(N'Rajince Preševo')," +
                "(N'Rajkinac Jagodina')," +
                "(N'Rajkovac Beograd – Mladenovac')," +
                "(N'Rajkovac Topola')," +
                "(N'Rajković Mionica')," +
                "(N'Rajkoviće Novi Pazar')," +
                "(N'Rajno Polje Leskovac')," +
                "(N'Rajčevce Trgovište')," +
                "(N'Rajčetine Crna Trava')," +
                "(N'Rajčilovci Bosilegrad')," +
                "(N'Rajčinoviće Novi Pazar')," +
                "(N'Rajčinovićka Trnava Novi Pazar')," +
                "(N'Raka Uroševac')," +
                "(N'Rakari Mionica')," +
                "(N'Rakinac Velika Plana')," +
                "(N'Rakinica Podujevo')," +
                "(N'Rakita Babušnica')," +
                "(N'Rakitnica Srbica')," +
                "(N'Rakitovo Jagodina')," +
                "(N'Raklja Aleksandrovac')," +
                "(N'Rakov Dol Babušnica')," +
                "(N'Rakova Čačak')," +
                "(N'Rakova Bara Kučevo')," +
                "(N'Rakovac Bujanovac')," +
                "(N'Rakovac Novi Pazar')," +
                "(N'Rakovac Raška')," +
                "(N'Rakovac Beočin')," +
                "(N'Rakovina Đakovica')," +
                "(N'Rakovica Čajetina')," +
                "(N'Rakoc Đakovica')," +
                "(N'Rakoš Istok')," +
                "(N'Ralja Beograd – Sopot')," +
                "(N'Ralja Smederevo')," +
                "(N'Raljin Babušnica')," +
                "(N'Ram Velikoradište')," +
                "(N'Ramaća Kragujevac')," +
                "(N'Ramoc Đakovica')," +
                "(N'Ramoševo Tutin')," +
                "(N'Ranatovce Preševo')," +
                "(N'Randubrava Prizren')," +
                "(N'Ranilović Aranđelovac')," +
                "(N'Ranilug Kosovska Kamenica')," +
                "(N'Rankova Reka Prokuplje')," +
                "(N'Ranovac Petrova na Mlavi')," +
                "(N'Ranutovac Vranje')," +
                "(N'Rance Štimlje')," +
                "(N'Rančiće Zubin Potok')," +
                "(N'Raskovobilić')," +
                "(N'Rasna Požega')," +
                "(N'Rasnica Pirot')," +
                "(N'Rasno Prijepolje')," +
                "(N'Rasno Sjenica')," +
                "(N'Raspoganče Sjenica')," +
                "(N'Rast Novi Pazar')," +
                "(N'Rastavica Dečani')," +
                "(N'Rastelica Kuršumlija')," +
                "(N'Rastenoviće Sjenica')," +
                "(N'Rastina Sombor')," +
                "(N'Rastište Bajina Bašta')," +
                "(N'Rastovnica Prokuplje')," +
                "(N'Rataje Vranje')," +
                "(N'Ratajska Prijepolje')," +
                "(N'Ratare Paraćin')," +
                "(N'Ratari Beograd –brenovac')," +
                "(N'Ratari Smederevska Palanka')," +
                "(N'Ratina Kraljevo')," +
                "(N'Ratkovac Lajkovac')," +
                "(N'Ratkovacrahovac')," +
                "(N'Ratković Rekovac')," +
                "(N'Ratkovodžaci')," +
                "(N'Rautovo Niš – Niška Banja')," +
                "(N'Raušić Peć')," +
                "(N'Rafuna Lebane')," +
                "(N'Rahovica Uroševac')," +
                "(N'Racaj Đakovica')," +
                "(N'Rača Bajina Bašta')," +
                "(N'Rača Kuršumlija')," +
                "(N'Rača Priboj')," +
                "(N'Rača Rača')," +
                "(N'Rača Đakovica')," +
                "(N'Račak Štimlje')," +
                "(N'Rašanac Petrova na Mlavi')," +
                "(N'Raševica Paraćin')," +
                "(N'Rašince Štimlje')," +
                "(N'Rašić Peć')," +
                "(N'Rašica Blace')," +
                "(N'Raška Raška')," +
                "(N'Rašković Knić')," +
                "(N'Raškoviće Sjenica')," +
                "(N'Raškoc Đakovica')," +
                "(N'Raštane Suva Reka')," +
                "(N'Rvati Beograd –brenovac')," +
                "(N'Rvati Raška')," +
                "(N'Rvatska Leposavić')," +
                "(N'Rgaje Prokuplje')," +
                "(N'Rgotina Zaječar')," +
                "(N'Rgošte Knjaževac')," +
                "(N'Rdovo Vladičin Han')," +
                "(N'Rđavica Surdulica')," +
                "(N'Rebelj Valjevo')," +
                "(N'Revuće Podujevo')," +
                "(N'Režance Kačanik')," +
                "(N'Reževiće Tutin')," +
                "(N'Rezala Zubin Potok')," +
                "(N'Rezala Srbica')," +
                "(N'Reka Kladovo')," +
                "(N'Reka Kraljevo')," +
                "(N'Reka Kačanik')," +
                "(N'Reka Kosovska Mitrovica')," +
                "(N'Rekovac Rekovac')," +
                "(N'Reljan Preševo')," +
                "(N'Reljinac Prokuplje')," +
                "(N'Reljinciornji Milanovac')," +
                "(N'Renovac Klina')," +
                "(N'Rence Prizren')," +
                "(N'Repa Podujevo')," +
                "(N'Repince Vladičin Han')," +
                "(N'Repište Vladičin Han')," +
                "(N'Repušnica Knjaževac')," +
                "(N'Resavica Despotovac')," +
                "(N'Resavica (selo) Despotovac')," +
                "(N'Resen Bosilegrad')," +
                "(N'Resinac Prokuplje')," +
                "(N'Resnik Babušnica')," +
                "(N'Resnik Kragujevac')," +
                "(N'Resnik Sokobanja')," +
                "(N'Resnik Vučitrn')," +
                "(N'Resnik Klina')," +
                "(N'Restelicaora')," +
                "(N'Retimljerahovac')," +
                "(N'Retkocer Medveđa')," +
                "(N'Rečane Prizren')," +
                "(N'Rečane Suva Reka')," +
                "(N'Rečica Bojnik')," +
                "(N'Rečica Žitorađa')," +
                "(N'Rečica Kladovo')," +
                "(N'Rečica Požarevac')," +
                "(N'Rečica Podujevo')," +
                "(N'Rečice Požega')," +
                "(N'Rečka Negotin')," +
                "(N'Ržana Kosovska Mitrovica')," +
                "(N'Ržanica Aleksandrovac')," +
                "(N'Rznić Dečani')," +
                "(N'Ribare Žagubica')," +
                "(N'Ribare Kruševac')," +
                "(N'Ribare Jagodina')," +
                "(N'Ribare Svrljig')," +
                "(N'Ribari Brus')," +
                "(N'Ribari ŠaBač')," +
                "(N'Ribariće Tutin')," +
                "(N'Ribarice Loznica')," +
                "(N'Ribarska Banja Kruševac')," +
                "(N'Ribarci Bosilegrad')," +
                "(N'Ribaševina Užice')," +
                "(N'Ribince Vranje')," +
                "(N'Ribnik Jagodina')," +
                "(N'Ribnik Vitina')," +
                "(N'Ribnica Kraljevo')," +
                "(N'Rivica Irig')," +
                "(N'Riđage Čačak')," +
                "(N'Riđake Vladimirci')," +
                "(N'Riđevštica Trstenik')," +
                "(N'Riđica Sombor')," +
                "(N'Rikačevo Bosilegrad')," +
                "(N'Riljac Trstenik')," +
                "(N'Rimanište Priština')," +
                "(N'Ripaj Madanaj Đakovica')," +
                "(N'Ripanj Beograd – Voždovac')," +
                "(N'Ristovac Vranje')," +
                "(N'Ritiševo Vršac')," +
                "(N'Ritopek Beograd –rocka')," +
                "(N'Ritošići Priboj')," +
                "(N'Rlica Kruševac')," +
                "(N'Roanda Svilajnac')," +
                "(N'Robaje Mionica')," +
                "(N'Robovac Kosovska Kamenica')," +
                "(N'Rovine Ivanjica')," +
                "(N'Rovni Valjevo')," +
                "(N'Rogavčina Aleksandrovac')," +
                "(N'Rogača Beograd – Sopot')," +
                "(N'Rogača Lučani')," +
                "(N'Rogačica Bajina Bašta')," +
                "(N'Rogačica Kosovska Kamenica')," +
                "(N'Roge Požega')," +
                "(N'Rogljevo Negotin')," +
                "(N'Rogovo Đakovica')," +
                "(N'Rogojevac Kragujevac')," +
                "(N'Rodelj Leposavić')," +
                "(N'Rožanstvo Čajetina')," +
                "(N'Rožanci Beograd – Barajevo')," +
                "(N'Roždace Vranje')," +
                "(N'Rožina Merošina')," +
                "(N'Rokci Aleksandrovac')," +
                "(N'Rokci Ivanjica')," +
                "(N'Romaja Prizren')," +
                "(N'Romune Peć')," +
                "(N'Ropica Vučitrn')," +
                "(N'Ropočevo Beograd – Sopot')," +
                "(N'Rosići Kosjerić')," +
                "(N'Rosica Kruševac')," +
                "(N'Rosomač Pirot')," +
                "(N'Rosulje Peć')," +
                "(N'Roćevac Svilajnac')," +
                "(N'Roćevići Kraljevo')," +
                "(N'Rošci Čačak')," +
                "(N'Rsavci Vrnjačka Banja')," +
                "(N'Rsovac Aleksinac')," +
                "(N'Rsovci Pirot')," +
                "(N'Rtanj Boljevac')," +
                "(N'Rtari Lučani')," +
                "(N'Rti Lučani')," +
                "(N'Rtkovo Kladovo')," +
                "(N'Rubribreza Lajkovac')," +
                "(N'Ruda Bukva Kosjerić')," +
                "(N'Rudare Kuršumlija')," +
                "(N'Rudare Leskovac')," +
                "(N'Rudenice Aleksandrovac')," +
                "(N'Rudine Čajetina')," +
                "(N'Rudine Zvečan')," +
                "(N'Rudinje Pirot')," +
                "(N'Rudice Klina')," +
                "(N'Rudnalava Majdanpek')," +
                "(N'Rudnikornji Milanovac')," +
                "(N'Rudnik Srbica')," +
                "(N'Rudnik Kosovobilić')," +
                "(N'Rudnica Raška')," +
                "(N'Rudnica Tutin')," +
                "(N'Rudno Kraljevo')," +
                "(N'Rudnjak Kraljevo')," +
                "(N'Rudovci Beograd – Lazarevac')," +
                "(N'Ruđa Tutin')," +
                "(N'Ruđinci Vrnjačka Banja')," +
                "(N'Ružić Vladičin Han')," +
                "(N'Rujevac Ljubovija')," +
                "(N'Rujevica Sokobanja')," +
                "(N'Rujišnik Trstenik')," +
                "(N'Rujište Boljevac')," +
                "(N'Rujište Ražanj')," +
                "(N'Rujište Zubin Potok')," +
                "(N'Rujkovac Medveđa')," +
                "(N'Rujnik Niš – Crveni krst')," +
                "(N'Ruklada Ub')," +
                "(N'Ruma Ruma')," +
                "(N'Rumenka Novi Sad')," +
                "(N'Rumska ŠaBač')," +
                "(N'Runjani Loznica')," +
                "(N'Runjevo Kačanik')," +
                "(N'Rupeljevo Požega')," +
                "(N'Ruplje Crna Trava')," +
                "(N'Rusinovce Lipljan')");
                  migrationBuilder.Sql(
                "insert into Mesta(NazivMesta) values " +
                "(N'Ruski Krstur Kula')," +
                "(N'Rusko Selo Kikinda')," +
                "(N'Rusna Doljevac')," +
                "(N'Rusce Bujanovac')," +
                "(N'Rusce Vranje')," +
                "(N'Rutevac Aleksinac')," +
                "(N'Rutoši Nova Varoš')," +
                "(N'Ruhot Peć')," +
                "(N'Rucka Beograd – Čukarica')," +
                "(N'Rucmance Leposavić')," +
                "(N'Ručićiornji Milanovac')," +
                "(N'Rušanj Beograd – Čukarica')," +
                "(N'Savinac Bojnik')," +
                "(N'Savinac Boljevac')," +
                "(N'Savino Selo Vrbas')," +
                "(N'Savković Ljubovija')," +
                "(N'Savovo Kraljevo')," +
                "(N'Savrovo Suva Reka')," +
                "(N'Sagonjevo Kuršumlija')," +
                "(N'Sazlija Uroševac')," +
                "(N'Sainovina Čajetina')," +
                "(N'Sajan Kikinda')," +
                "(N'Sakar Mali Zvornik')," +
                "(N'Sakulepovo')," +
                "(N'Sakulja Beograd – Lazarevac')," +
                "(N'Salakovac Malo Crniće')," +
                "(N'Salaš Zaječar')," +
                "(N'Salaš Noćajski Sremska Mitrovica')," +
                "(N'Salaš Crnobarski Bogatić')," +
                "(N'Samaila Kraljevo')," +
                "(N'Samarinovac Žitorađa')," +
                "(N'Samarinovac Negotin')," +
                "(N'Samarnica Vlasotince')," +
                "(N'Samodraža Suva Reka')," +
                "(N'Samodreža Vučitrn')," +
                "(N'Samokovo Kuršumlija')," +
                "(N'Samoljica Bujanovac')," +
                "(N'Samoš Kovačica')," +
                "(N'Sanad Čoka')," +
                "(N'Sandalj Valjevo')," +
                "(N'Sanković Mionica')," +
                "(N'Sanovacrahovac')," +
                "(N'Saparnjilane')," +
                "(N'Saranovo Rača')," +
                "(N'Saraorci Smederevo')," +
                "(N'Sarošrahovac')," +
                "(N'Sastav Reka Crna Trava')," +
                "(N'Saš Tutin')," +
                "(N'Sveta Petka Bujanovac')," +
                "(N'Svetićevo Bačka Topola')," +
                "(N'Svetlić Topola')," +
                "(N'Svetlje Podujevo')," +
                "(N'Svetozar Miletić Sombor')," +
                "(N'Sveštica Ivanjica')," +
                "(N'Svilajnac Svilajnac')," +
                "(N'Svileuva Koceljeva')," +
                "(N'Svilojevo Apatin')," +
                "(N'Sviloš Beočin')," +
                "(N'Svinjare Kosovska Mitrovica')," +
                "(N'Svinjarevo Žabari')," +
                "(N'Svinjarica Lebane')," +
                "(N'Svinjište Kuršumlija')," +
                "(N'Svinjište Preševo')," +
                "(N'Svirce Leskovac')," +
                "(N'Svirce Medveđa')," +
                "(N'Svirce Kosovska Kamenica')," +
                "(N'Svođe Vlasotince')," +
                "(N'Svojnovo Paraćin')," +
                "(N'Svračkovo Požega')," +
                "(N'Svračkovciornji Milanovac')," +
                "(N'Svrke Peć')," +
                "(N'Svrljig Svrljig')," +
                "(N'Svrljiška Topla Knjaževac')," +
                "(N'Svrhe Klina')," +
                "(N'Svrčina Uroševac')," +
                "(N'Sebevranje Vranjska Banja')," +
                "(N'Sebečevac Kruševac')," +
                "(N'Sebečevo Novi Pazar')," +
                "(N'Sebimilje Raška')," +
                "(N'Sebrat Bujanovac')," +
                "(N'Severni Kočarnik Tutin')," +
                "(N'Severovo Arilje')," +
                "(N'Sevojno Užice')," +
                "(N'Sevce Štrpce')," +
                "(N'Sedlare Svilajnac')," +
                "(N'Sedlare Kosovska Kamenica')," +
                "(N'Sedlare Lipljan')," +
                "(N'Sedlari Valjevo')," +
                "(N'Sedobro Prijepolje')," +
                "(N'Sezemče Kruševac')," +
                "(N'Sejace Bujanovac')," +
                "(N'Sekirača Kuršumlija')," +
                "(N'Sekicol Lebane')," +
                "(N'Sekurič Rekovac')," +
                "(N'Selanac Ljubovija')," +
                "(N'Selačka Zaječar')," +
                "(N'Selevac Smederevska Palanka')," +
                "(N'Selenča Bač')," +
                "(N'Seleuš Alibunar')," +
                "(N'Selište Žagubica')," +
                "(N'Selište Kuršumlija')," +
                "(N'Selište Prokuplje')," +
                "(N'Selište Trstenik')," +
                "(N'Selo Kostolac Kostolac')," +
                "(N'Selova Kuršumlija')," +
                "(N'Selogražde Suva Reka')," +
                "(N'Seljane Prijepolje')," +
                "(N'Seljance Kosovska Mitrovica')," +
                "(N'Seljašnica Prijepolje')," +
                "(N'Semanje Kačanik')," +
                "(N'Semegnjevo Čajetina')," +
                "(N'Semedražornji Milanovac')," +
                "(N'Semeteš Raška')," +
                "(N'Semetište Suva Reka')," +
                "(N'Semčeadžin Han')," +
                "(N'Sena Kučevo')," +
                "(N'Senaja Beograd – Mladenovac')," +
                "(N'Sendo Zvečan')," +
                "(N'Senik Suva Reka')," +
                "(N'Seništa Nova Varoš')," +
                "(N'Senokos Dimitrovgrad')," +
                "(N'Senta Senta')," +
                "(N'Senje Ćuprija')," +
                "(N'Senjski Rudnik Despotovac')," +
                "(N'Seone Smederevo')," +
                "(N'Seoce Kuršumlija')," +
                "(N'Seoce Leposavić')," +
                "(N'Sepci Rača')," +
                "(N'Sesalac Sokobanja')," +
                "(N'Sefer Preševo')," +
                "(N'Sefkerinpovo')," +
                "(N'Seča Reka Kosjerić')," +
                "(N'Sečanica Niš – Crveni krst')," +
                "(N'Sečanj Sečanj')," +
                "(N'Sečište Kačanik')," +
                "(N'Sibač Pećinci')," +
                "(N'Sibnica Beograd – Sopot')," +
                "(N'Sibnica Blace')," +
                "(N'Sibnica Žabari')," +
                "(N'Sibnica Kraljevo')," +
                "(N'Sibnica Rekovac')," +
                "(N'Sibovacbilić')," +
                "(N'Sivac Kula')," +
                "(N'Sivčina Ivanjica')," +
                "(N'Siga Peć')," +
                "(N'Sige Žagubica')," +
                "(N'Siget Novi Kneževac')," +
                "(N'Sijarina Medveđa')," +
                "(N'Sijarinska Banja Medveđa')," +
                "(N'Sijerač Bajina Bašta')," +
                "(N'Sikirica Paraćin')," +
                "(N'Sikirje Vranje')," +
                "(N'Sikole Negotin')," +
                "(N'Silbaš Bačka Palanka')," +
                "(N'Siljevica Rekovac')," +
                "(N'Siljevica Podujevo')," +
                "(N'Simino Brdo Loznica')," +
                "(N'Simićevo Žabari')," +
                "(N'Sinaje Istok')," +
                "(N'Sinošević ŠaBač')," +
                "(N'Sinoševićiornji Milanovac')," +
                "(N'Sinjalava Pirot')," +
                "(N'Sinjac Bela Palanka')," +
                "(N'Sinji Vir Paraćin')," +
                "(N'Siokovac Jagodina')," +
                "(N'Sipić Rača')," +
                "(N'Sirakovo Velikoradište')," +
                "(N'Sirdijasečina')," +
                "(N'Sirig Temerin')," +
                "(N'Sirogojno Čajetina')," +
                "(N'Sirča Kraljevo')," +
                "(N'Sisevac Paraćin')," +
                "(N'Sitarice Valjevo')," +
                "(N'Sitniče Novi Pazar')," +
                "(N'Sićevo Niš – Niška Banja')," +
                "(N'Sićevo Klina')," +
                "(N'Sićevo Priština')," +
                "(N'Sjeverin Priboj')," +
                "(N'Sjenica Sjenica')," +
                "(N'Skadarsečina')," +
                "(N'Skakavci Kosjerić')," +
                "(N'Skela Beograd –brenovac')," +
                "(N'Skivjane Đakovica')," +
                "(N'Skobalj Lajkovac')," +
                "(N'Skobalj Smederevo')," +
                "(N'Skokuće Prijepolje')," +
                "(N'Skorenovac Kovin')," +
                "(N'Skorica Ražanj')," +
                "(N'Skorobište Prizren')," +
                "(N'Skorošnik Klina')," +
                "(N'Skočna Vučitrn')," +
                "(N'Skradnik Sjenica')," +
                "(N'Skrađani ŠaBač')," +
                "(N'Skrapež Vlasotince')," +
                "(N'Skrvenica Dimitrovgrad')," +
                "(N'Skržuti Užice')," +
                "(N'Skrobnica Knjaževac')," +
                "(N'Skrovna Vučitrn')," +
                "(N'Skukovo Novi Pazar')," +
                "(N'Skulanevo Lipljan')," +
                "(N'Skupljen Vladimirci')," +
                "(N'Slavinja Pirot')," +
                "(N'Slavkovica Ljig')," +
                "(N'Slavnik Bojnik')," +
                "(N'Slavujevac Preševo')," +
                "(N'Slavujevce Leskovac')," +
                "(N'Sladaja Despotovac')," +
                "(N'SladinacoluBač')," +
                "(N'Slakovce Vučitrn')," +
                "(N'Slankamenački Vinogradi Inđija')," +
                "(N'Slanci Beograd – Palilula')," +
                "(N'Slapužane Suva Reka')," +
                "(N'Slatina Beograd – Sopot')," +
                "(N'Slatina Bor')," +
                "(N'Slatina Knjaževac')," +
                "(N'Slatina Kruševac')," +
                "(N'Slatina Leskovac')," +
                "(N'Slatina Loznica')," +
                "(N'Slatina Negotin')," +
                "(N'Slatina Novi Pazar')," +
                "(N'Slatina Prijepolje')," +
                "(N'Slatina Jagodina')," +
                "(N'Slatina Ub')," +
                "(N'Slatina Čačak')," +
                "(N'Slatina ŠaBač')," +
                "(N'Slatina Vučitrn')," +
                "(N'Slatina Kačanik')," +
                "(N'Slatina Leposavić')," +
                "(N'Slatina Podujevo')," +
                "(N'Slepčević ŠaBač')," +
                "(N'Slivje Svrljig')," +
                "(N'Slivnica Dimitrovgrad')," +
                "(N'Slivnica Vranjska Banja')," +
                "(N'Slivovo Priština')," +
                "(N'Slivovo Uroševac')," +
                "(N'Slišane Lebane')," +
                "(N'Slovac Lajkovac')," +
                "(N'Slovinje Lipljan')," +
                "(N'Slubicanjilane')," +
                "(N'Slup Dečani')," +
                "(N'Smać Đakovica')," +
                "(N'Smać Prizren')," +
                "(N'Smederevo Smederevo')," +
                "(N'Smederevska Palanka Smederevska Palanka')," +
                "(N'Smedovac Negotin')," +
                "(N'Smilov Laz Novi Pazar')," +
                "(N'Smilovac Ražanj')," +
                "(N'Smilovci Dimitrovgrad')," +
                "(N'Smiljevac Ivanjica')," +
                "(N'Smiljević Vranje')," +
                "(N'Smira Vitina')," +
                "(N'Smoluća Tutin')," +
                "(N'Smoluša Lipljan')," +
                "(N'Smoljinac Malo Crniće')," +
                "(N'Smonica Đakovica')," +
                "(N'Smrdan Leskovac')," +
                "(N'Smrdan Prokuplje')," +
                "(N'Smrekovnica Vučitrn')," +
                "(N'SnegotinoluBač')," +
                "(N'Sovač Valjevo')," +
                "(N'Sovljak Bogatić')," +
                "(N'Sovljak Ub')," +
                "(N'Soderce Vranje')," +
                "(N'Sojevo Uroševac')," +
                "(N'Sokobanja Sokobanja')," +
                "(N'Sokolac Ljubovija')," +
                "(N'Sokolići Čačak')," +
                "(N'Sokolovo Beograd – Lazarevac')," +
                "(N'Solačka Sena Vladičin Han')," +
                "(N'Solotuša Bajina Bašta')," +
                "(N'Sombor Sombor')," +
                "(N'Sonta Apatin')," +
                "(N'Sopina Suva Reka')," +
                "(N'Sopnićrahovac')," +
                "(N'Sopot Beograd – Sopot')," +
                "(N'Sopot Pirot')," +
                "(N'Sopot Đakovica')," +
                "(N'Sopotnicaadžin Han')," +
                "(N'Sopotnica Prijepolje')," +
                "(N'Sopotnica Kačanik')," +
                "(N'Sot Šid')," +
                "(N'Sofalija Priština')," +
                "(N'Softović Uroševac')," +
                "(N'Sočanica Leposavić')," +
                "(N'Sočica Vršac')," +
                "(N'Sočice Priboj')," +
                "(N'Spance Kuršumlija')," +
                "(N'Spančevac Bujanovac')," +
                "(N'Sponce Medveđa')," +
                "(N'Srbica Srbica')," +
                "(N'Srbobran Srbobran')," +
                "(N'Srbobran Istok')," +
                "(N'Srbovac Zvečan')," +
                "(N'Srbovo Negotin')," +
                "(N'Srednja Dobrinja Požega')," +
                "(N'Srednja Klina Srbica')," +
                "(N'Srednja Tušimlja Novi Pazar')," +
                "(N'Srednjevo Velikoradište')," +
                "(N'Srednji Bučumet Medveđa')," +
                "(N'Srednji Del Vranje')," +
                "(N'Srednji Salaš Bačka Topola')," +
                "(N'Srednji Statovac Prokuplje')," +
                "(N'Sredor Vlasotince')," +
                "(N'Sredska Prizren')," +
                "(N'Srezovac Aleksinac')," +
                "(N'Srezojevciornji Milanovac')," +
                "(N'Sremska Kamenica Petrovaradin')," +
                "(N'Sremska Mitrovica Sremska Mitrovica')," +
                "(N'Sremska Rača Sremska Mitrovica')," +
                "(N'Sremski Karlovci Sremski Karlovci')," +
                "(N'Sremski Mihaljevci Pećinci')," +
                "(N'Sremčica Beograd – Čukarica')," +
                "(N'Srećkovac Pirot')," +
                "(N'Srndalje Kruševac')," +
                "(N'Srneći Dol Vladičin Han')," +
                "(N'Srnje Kruševac')," +
                "(N'Srpska Kuća Bujanovac')," +
                "(N'Srpska Crnja Nova Crnja')," +
                "(N'Srpski Babuš Uroševac')," +
                "(N'Srpski Itebej Žitište')," +
                "(N'Srpski Krstur Novi Kneževac')," +
                "(N'Srpski Miletićdžaci')," +
                "(N'Srpce Kučevo')," +
                "(N'Stave Krupanj')," +
                "(N'Stagovo Kačanik')," +
                "(N'Stajićevo Zrenjanin')," +
                "(N'Stajkovce Vlasotince')," +
                "(N'Stajkovce Surdulica')," +
                "(N'Stalać Ćićevac')," +
                "(N'Stamnica Petrova na Mlavi')," +
                "(N'Stanevce Preševo')," +
                "(N'Stanina Reka Valjevo')," +
                "(N'Staničenje Pirot')," +
                "(N'Stanišinci Vrnjačka Banja')," +
                "(N'Stanišić Sombor')," +
                "(N'Stanišornjilane')," +
                "(N'Stankovcelogovac')," +
                "(N'Stanuloviće Brus')," +
                "(N'Stance Vranje')," +
                "(N'Stanci Aleksinac')," +
                "(N'Stanci Kruševac')," +
                "(N'Stanča Kraljevo')," +
                "(N'Stančićnjilane')," +
                "(N'Stančići Čačak')," +
                "(N'Stanjevo Aleksandrovac')," +
                "(N'Stanjinac Knjaževac')," +
                "(N'Stapar Valjevo')," +
                "(N'Stapar Sombor')," +
                "(N'Stapari Užice')," +
                "(N'Stara Banja Medveđa')," +
                "(N'Stara Bingula Sremska Mitrovica')," +
                "(N'Stara Božurna Žitorađa')," +
                "(N'Stara Brezovica Vranje')," +
                "(N'Stara Vučina Suva Reka')," +
                "(N'Stara Moravica Bačka Topola')," +
                "(N'Stara Pazova Stara Pazova')," +
                "(N'Starac Bujanovac')," +
                "(N'Stari Banovci Stara Pazova')," +
                "(N'Stari Bračin Ražanj')," +
                "(N'Starilog Vranjska Banja')," +
                "(N'Stari Đurovac Prokuplje')," +
                "(N'Stari Žednik Subotica')," +
                "(N'Stari Kačanik Kačanik')," +
                "(N'Stari Ledinci Petrovaradin')," +
                "(N'Stari Lec Plandište')," +
                "(N'Stari Miraš Uroševac')," +
                "(N'Stari Slankamen Inđija')," +
                "(N'Stari Trg (rud.naselje) Kosovska Mitrovica')," +
                "(N'Stari Trg (selo) Kosovska Mitrovica')," +
                "(N'Stari Trstenik Trstenik')," +
                "(N'Staroracko Lipljan')," +
                "(N'Staro Korito Knjaževac')," +
                "(N'Staro Lanište Jagodina')," +
                "(N'Staro Momčilovo Žitorađa')," +
                "(N'Staro Rujce Lipljan')," +
                "(N'Staro Selo Velika Plana')," +
                "(N'Staro Selo Prokuplje')," +
                "(N'Staro Selo Jagodina')," +
                "(N'Staro Selo Uroševac')," +
                "(N'Staro Čikatovologovac')," +
                "(N'Starodvorane Istok')," +
                "(N'Starci Aleksandrovac')," +
                "(N'Starčeviće Tutin')," +
                "(N'Starčevo Petrova na Mlavi')," +
                "(N'Starčevo Pančevo')," +
                "(N'Stejanovci Ruma')," +
                "(N'Stenjevac Despotovac')," +
                "(N'Stepanovićevo Novi Sad')," +
                "(N'Stepanje Lajkovac')," +
                "(N'Stepojevac Beograd – Lazarevac')," +
                "(N'Sterijino Ada')," +
                "(N'Stogazovac Knjaževac')," +
                "(N'Stojačak Smederevska Palanka')," +
                "(N'Stojići Kosjerić')," +
                "(N'Stojković Uroševac')," +
                "(N'Stojnik Aranđelovac')," +
                "(N'Stojnik Beograd – Sopot')," +
                "(N'Stol Babušnica')," +
                "(N'Stopanja Trstenik')," +
                "(N'Stragari Kragujevac')," +
                "(N'Stragari Trstenik')," +
                "(N'Stradovo Novi Pazar')," +
                "(N'Straža Loznica')," +
                "(N'Straža Vršac')," +
                "(N'Stražanjilane')," +
                "(N'Straža Kačanik')," +
                "(N'Strajiniće Sjenica')," +
                "(N'Strana Kosovska Mitrovica')," +
                "(N'Stranjevo Vlasotince')," +
                "(N'Strezimirovci Surdulica')," +
                "(N'Strezovce Preševo')," +
                "(N'Strezovce Kosovska Kamenica')," +
                "(N'Strelac Babušnica')," +
                "(N'Strelica Kosovska Kamenica')," +
                "(N'Strešak Vranje')," +
                "(N'Striža Paraćin')," +
                "(N'Strižilo Jagodina')," +
                "(N'Strmac Priboj')," +
                "(N'Strmac Užice')," +
                "(N'Strmenica Aleksandrovac')," +
                "(N'Strmnaora Valjevo')," +
                "(N'Strmovo Bajina Bašta')," +
                "(N'Strmovo Beograd – Lazarevac')," +
                "(N'Strmovo Lajkovac')," +
                "(N'Strmosten Despotovac')," +
                "(N'Strovce Vučitrn')," +
                "(N'Strojinci Brus')," +
                "(N'Strojkovce Leskovac')," +
                "(N'Stropsko Vranje')," +
                "(N'Struganik Mionica')," +
                "(N'Struganica Vranje')," +
                "(N'Stružje Prizren')," +
                "(N'Strumce Tutin')," +
                "(N'Stubal Aleksandrovac')," +
                "(N'Stubal Blace')," +
                "(N'Stubal Vladičin Han')," +
                "(N'Stubal Kraljevo')," +
                "(N'Stubica Beograd – Lazarevac')," +
                "(N'Stubica Paraćin')," +
                "(N'Stubla Bojnik')," +
                "(N'Stubla Medveđa')," +
                "(N'Stubla Đakovica')," +
                "(N'Stublenica Ub')," +
                "(N'Stublina Aleksinac')," +
                "(N'Stublinanjilane')," +
                "(N'Stubline Beograd –brenovac')," +
                "(N'Stublica Trstenik')," +
                "(N'Stublo Čajetina')," +
                "(N'Stubo Valjevo')," +
                "(N'Studena Babušnica')," +
                "(N'Studena Vranje')," +
                "(N'Studenac Žitorađa')," +
                "(N'Studenica Istok')," +
                "(N'Studenčane Suva Reka')," +
                "(N'Stup Sjenica')," +
                "(N'Stup Klina')," +
                "(N'Stupnica Leskovac')," +
                "(N'Stupnica Loznica')," +
                "(N'Stupčevići Arilje')," +
                "(N'Subjel Kosjerić')," +
                "(N'Subotinac Aleksinac')," +
                "(N'Subotica Aleksandrovac')," +
                "(N'Subotica Koceljeva')," +
                "(N'Subotica Svilajnac')," +
                "(N'Subotica Subotica')," +
                "(N'Subotište Pećinci')," +
                "(N'Suva Morava Vladičin Han')," +
                "(N'Suva Reka Suva Reka')," +
                "(N'Suvaja Blace')," +
                "(N'Suvaja Varvarin')," +
                "(N'Suvaja Kruševac')," +
                "(N'Suvi Do Blace')," +
                "(N'Suvi Do Žagubica')," +
                "(N'Suvi Do Tutin')," +
                "(N'Suvi Do Niš – Palilula')," +
                "(N'Suvi Do Lipljan')," +
                "(N'Suvi Dol Vranje')," +
                "(N'Suvi Lukavac Istok')," +
                "(N'Suvorlo Istok')," +
                "(N'Suvorlo Srbica')," +
                "(N'Suvo Selo Vladimirci')," +
                "(N'Suvodanje Valjevo')," +
                "(N'Suvodol Smederevo')," +
                "(N'Suvojnica Surdulica')," +
                "(N'Sugubine Sjenica')," +
                "(N'Sudimlja Brus')," +
                "(N'Sudsko Selo Novi Pazar')," +
                "(N'Sukovo Pirot')," +
                "(N'Sumorovac Knić')," +
                "(N'Sumrakovac Boljevac')," +
                "(N'Supnje Raška')," +
                "(N'Supovac Niš – Crveni krst')," +
                "(N'Supska Ćuprija')," +
                "(N'Suračevo Babušnica')," +
                "(N'Surduk Stara Pazova')," +
                "(N'Surdul Vranje')," +
                "(N'Surdula Podujevo')," +
                "(N'Surdulica Surdulica')," +
                "(N'Surkiš Podujevo')," +
                "(N'Surlica Trgovište')," +
                "(N'Surčin Beograd – Surčin')," +
                "(N'Susek Beočin')," +
                "(N'Sutjeska Sečanj')," +
                "(N'Suharno Bujanovac')," +
                "(N'Suhi Dol Surdulica')," +
                "(N'Suševlje Leskovac')," +
                "(N'Sušiće Štrpce')," +
                "(N'Sušica Valjevo')," +
                "(N'Sušica Kruševac')," +
                "(N'Sušica Sjenica')," +
                "(N'Sušica Istok')," +
                "(N'Sušica Priština')," +
                "(N'Tabakovac Zaječar')," +
                "(N'Tabanovac Petrova na Mlavi')," +
                "(N'Tabanović Mionica')," +
                "(N'Tabanović ŠaBač')," +
                "(N'Tabanovići Požega')," +
                "(N'Tavnik Kraljevo')," +
                "(N'Tadenje Kraljevo')," +
                "(N'Takovoornji Milanovac')," +
                "(N'Takovo Ub')," +
                "(N'Tamnič Negotin')," +
                "(N'Tamnjanica Bela Palanka')," +
                "(N'Tanda Bor')," +
                "(N'Tankosić Uroševac')," +
                "(N'Taor Valjevo')," +
                "(N'Taradža Vučitrn')," +
                "(N'Taraš Zrenjanin')," +
                "(N'Taskovićiadžin Han')," +
                "(N'Tatrasnica Knjaževac')," +
                "(N'Tačevac Kuršumlija')," +
                "(N'Taševo Prijepolje')," +
                "(N'Tvrdići Požega')," +
                "(N'Tvrdojevac Ub')," +
                "(N'Tvrđan Leposavić')," +
                "(N'Tegovište Vladičin Han')," +
                "(N'Tegošnica Vlasotince')," +
                "(N'Tekeriš Loznica')," +
                "(N'Tekija Kladovo')," +
                "(N'Tekija Kruševac')," +
                "(N'Tekija Paraćin')," +
                "(N'Telečka Sombor')," +
                "(N'Telovac Bela Palanka')," +
                "(N'Temerin Temerin')," +
                "(N'Temska Pirot')," +
                "(N'Teneš Do Priština')," +
                "(N'Tenkovo Novi Pazar')," +
                "(N'Teočinornji Milanovac')," +
                "(N'Tepeče Kraljevo')," +
                "(N'Tesovište Vranje')," +
                "(N'Teća Lipljan')," +
                "(N'Tečić Rekovac')," +
                "(N'Tešica Aleksinac')," +
                "(N'Tibužde Vranje')," +
                "(N'Tijanje Lučani')," +
                "(N'Tijovac Kuršumlija')," +
                "(N'Tijovac Svrljig')," +
                "(N'Tikva Nova Varoš')," +
                "(N'Tiodže Raška')," +
                "(N'Tirince Kosovska Kamenica')," +
                "(N'Tisovica Nova Varoš')," +
                "(N'Titel Titel')," +
                "(N'Tićevac Žabari')," +
                "(N'Tica Srbica')," +
                "(N'Tmava Kuršumlija')," +
                "(N'Toba Nova Crnja')," +
                "(N'Tobolac Trstenik')," +
                "(N'Tovariševo Bačka Palanka')," +
                "(N'Tovrljane Prokuplje')," +
                "(N'Togočevce Lebane')," +
                "(N'Todorin Do Mionica')," +
                "(N'Todorovce Leskovac')," +
                "(N'Tolisavac Krupanj')," +
                "(N'Tolić Mionica')," +
                "(N'Tolišnica Kraljevo')," +
                "(N'Toljevac Varvarin')," +
                "(N'Tomance Istok')," +
                "(N'Tomance Kosovska Kamenica')," +
                "(N'Tomanj Krupanj')," +
                "(N'Tomaševac Zrenjanin')," +
                "(N'Tometino Polje Požega')," +
                "(N'Tomislavci Bačka Topola')," +
                "(N'Topilo Štimlje')," +
                "(N'Topla Bor')," +
                "(N'Toplac Vranjska Banja')," +
                "(N'Topli Do Pirot')," +
                "(N'Topli Do Surdulica')," +
                "(N'Topli Dol Surdulica')," +
                "(N'Topličane Lipljan')," +
                "(N'Topličane Suva Reka')," +
                "(N'Topola Jagodina')," +
                "(N'Topola (varošica) Topola')," +
                "(N'Topola (selo) Topola')," +
                "(N'Topolnica Majdanpek')," +
                "(N'Topolovnik Velikoradište')," +
                "(N'Toponica Bela Palanka')," +
                "(N'Toponicaadžin Han')," +
                "(N'Toponica Žitorađa')," +
                "(N'Toponica Knić')," +
                "(N'Toponica Malo Crniće')," +
                "(N'Toponica Kosovska Kamenica')," +
                "(N'Torak Žitište')," +
                "(N'Torda Žitište')," +
                "(N'Torina Lipljan')," +
                "(N'Tornik Ljubovija')," +
                "(N'Tornjoš Senta')," +
                "(N'Totovo Selo Kanjiža')," +
                "(N'Točilovo Tutin')," +
                "(N'Trakanić Đakovica')," +
                "(N'Trbovce Lipljan')," +
                "(N'Trbosilje Loznica')," +
                "(N'Trbunje Blace')," +
                "(N'Trbuhovac Istok')," +
                "(N'Trbušani Čačak')," +
                "(N'Trbušac Vladimirci')," +
                "(N'Trbušnica Beograd – Lazarevac')," +
                "(N'Trbušnica Loznica')," +
                "(N'Trgovište Knjaževac')," +
                "(N'Trgovište Kraljevo')," +
                "(N'Trgovište Sokobanja')," +
                "(N'Trgovište Trgovište')," +
                "(N'Trdevaclogovac')," +
                "(N'Trebinje Kuršumlija')," +
                "(N'Trebiće Leposavić')," +
                "(N'Trebović Peć')," +
                "(N'Trebotin Kruševac')," +
                "(N'Trejak Bujanovac')," +
                "(N'Trepetinca Prizren')," +
                "(N'Trećak Kuršumlija')," +
                "(N'Trešnjevak Kragujevac')," +
                "(N'Trešnjevac Kanjiža')," +
                "(N'Trešnjevica Arilje')," +
                "(N'Trešnjevica Paraćin')," +
                "(N'Trešnjevica Sjenica')," +
                "(N'Tržac Aleksandrovac')," +
                "(N'Tribrode Velikoradište')," +
                "(N'Trijebine Sjenica')," +
                "(N'Trikose Leposavić')," +
                "(N'Tripkova Čajetina')," +
                "(N'Trlabuć Vučitrn')," +
                "(N'Trlić Ub')," +
                "(N'Trmbas Kragujevac')," +
                "(N'Trmka Kuršumlija')," +
                "(N'Trmčare Kruševac')," +
                "(N'Trn Kuršumlija')," +
                "(N'Trn Uroševac')," +
                "(N'Trnava Novi Pazar')," +
                "(N'Trnava Preševo')," +
                "(N'Trnava Raška')," +
                "(N'Trnava Jagodina')," +
                "(N'Trnava Užice')," +
                "(N'Trnava Čajetina')," +
                "(N'Trnava Čačak')," +
                "(N'Trnava Podujevo')," +
                "(N'Trnavac Zaječar')," +
                "(N'Trnavica Podujevo')," +
                "(N'Trnavce Srbica')," +
                "(N'Trnavci Aleksandrovac')," +
                "(N'Trnićevce Novo Brdo')," +
                "(N'Trnovac Knjaževac')," +
                "(N'Trnovi Laz Prokuplje')," +
                "(N'Trnovče Velika Plana')," +
                "(N'Trnovče Petrova na Mlavi')," +
                "(N'Trnskidorovci Dimitrovgrad')," +
                "(N'Trnjana Pirot')," +
                "(N'Trnjane Aleksinac')," +
                "(N'Trnjane Negotin')," +
                "(N'Trnjane Požarevac')," +
                "(N'Trnjaci Ub')," +
                "(N'Trnje Suva Reka')," +
                "(N'Troponje Svilajnac')," +
                "(N'Troskač Surdulica')," +
                "(N'Trpeza Vitina')," +
                "(N'Trpezalogovac')," +
                "(N'Trpeze Kuršumlija')," +
                "(N'Trska Rača')," +
                "(N'Trstena Vranje')," +
                "(N'Trstena Kosovska Kamenica')," +
                "(N'Trstena Kosovska Mitrovica')," +
                "(N'Trstenik Trstenik')," +
                "(N'Trstenik Vitina')," +
                "(N'Trsteniklogovac')," +
                "(N'Trstenik Peć')," +
                "(N'Trstenica Beograd –brenovac')," +
                "(N'Trubarevac Sokobanja')," +
                "(N'Trubarevo Ćićevac')," +
                "(N'Trudeljornji Milanovac')," +
                "(N'Trudna Priština')," +
                "(N'Trudovo Nova Varoš')," +
                "(N'Trupale Niš – Crveni krst')," +
                "(N'Trućevac Despotovac')," +
                "(N'Tršanovci Brus')," +
                "(N'Tršić Loznica')," +
                "(N'Tubići Kosjerić')," +
                "(N'Tubravić Valjevo')," +
                "(N'Tuđevce Kosovska Kamenica')," +
                "(N'Tuđinsečina')," +
                "(N'Tuzinje Sjenica')," +
                "(N'Tulare Medveđa')," +
                "(N'Tulare Prokuplje')," +
                "(N'Tulari Ub')," +
                "(N'Tulež Aranđelovac')," +
                "(N'Tuleš Aleksandrovac')," +
                "(N'Tulovo Leskovac')," +
                "(N'Tumba Vranje')," +
                "(N'Tumičina Suva Reka')," +
                "(N'Tunovo Novi Pazar')," +
                "(N'Tupale Medveđa')," +
                "(N'Tupalovce Leskovac')," +
                "(N'Tupanci Valjevo')," +
                "(N'Tupec Prizren')," +
                "(N'Turekovac Leskovac')," +
                "(N'Turija Bujanovac')," +
                "(N'Turija Kučevo')," +
                "(N'Turija Srbobran')," +
                "(N'Turićevac Srbica')," +
                "(N'Turica Lučani')," +
                "(N'Turjakrahovac')," +
                "(N'Turjak Peć')," +
                "(N'Turjane Bojnik')," +
                "(N'Turučica Podujevo')," +
                "(N'Tutin Tutin')," +
                "(N'Tutiće Sjenica')," +
                "(N'Tučep Istok')," +
                "(N'Tučkovo Požega')," +
                "(N'Tušilje Srbica')," +
                "(N'Tušiće Zubin Potok')," +
                "(N'Ćelijeadžin Han')," +
                "(N'Ćelije Kruševac')," +
                "(N'Ćelije Lajkovac')," +
                "(N'Ćenovac Lebane')," +
                "(N'Ćerim Đakovica')," +
                "(N'Ćešanoviće Zubin Potok')," +
                "(N'Ćirez Srbica')," +
                "(N'Ćirikovac Požarevac')," +
                "(N'Ćirkoviće Leposavić')," +
                "(N'Ćićevac Ćićevac')," +
                "(N'Ćićina Aleksinac')," +
                "(N'Ćovdin Petrova na Mlavi')," +
                "(N'Ćukovac Bojnik')," +
                "(N'Ćukovac Vranje')," +
                "(N'Ćukovac Prokuplje')," +
                "(N'Ćukovine Koceljeva')," +
                "(N'Ćulije Tutin')," +
                "(N'Ćuprija Ćuprija')," +
                "(N'Ćurkovica Vranje')," +
                "(N'Ćurkovica Surdulica')," +
                "(N'Ćurlina Doljevac')," +
                "(N'Ćuška Peć')," +
                "(N'Ćuštica Knjaževac')," +
                "(N'Ub Ub')," +
                "(N'Uvac Sjenica')," +
                "(N'Ugao Sjenica')," +
                "(N'Ugljarenjilane')," +
                "(N'Ugljare Zubin Potok')," +
                "(N'Ugljare Kosovo Polje')," +
                "(N'Ugljarevac Kragujevac')," +
                "(N'Ugljarevo Trstenik')," +
                "(N'Ugrinovci Beograd – Zemun')," +
                "(N'Ugrinovciornji Milanovac')," +
                "(N'Udovice Smederevo')," +
                "(N'Užice Užice')," +
                "(N'Uzveće Bogatić')," +
                "(N'Uzdin Kovačica')," +
                "(N'Uzići Požega')," +
                "(N'Uzovnica Ljubovija')," +
                "(N'Uzovo Bujanovac')," +
                "(N'Ujz Đakovica')," +
                "(N'Ukča Istok')," +
                "(N'Ulije Leposavić')," +
                "(N'Uljma Vršac')," +
                "(N'Umka Beograd – Čukarica')," +
                "(N'Umčari Beograd –rocka')," +
                "(N'Urvič Vladičin Han')," +
                "(N'Urmanica Vranje')," +
                "(N'Urovica Negotin')," +
                "(N'Urovci Beograd –brenovac')," +
                "(N'Uroševac Uroševac')," +
                "(N'Ursule Rekovac')," +
                "(N'Ursule Sjenica')," +
                "(N'UsijeoluBač')," +
                "(N'Utrine Ada')," +
                "(N'Ušak Sjenica')," +
                "(N'Uševce Vranje')," +
                "(N'Ušće Beograd –brenovac')," +
                "(N'Ušće Kraljevo')," +
                "(N'Farkaždin Zrenjanin')," +
                "(N'Feketić Mali Iđoš')," +
                "(N'Fijulj Sjenica')," +
                "(N'Filipovići Loznica')," +
                "(N'Filić Novi Kneževac')," +
                "(N'Firaja Đakovica')," +
                "(N'Firaja Štrpce')," +
                "(N'Firza Đakovica')," +
                "(N'Firićeja Kosovska Kamenica')," +
                "(N'Futog Novi Sad')," +
                "(N'Hajdukovo Subotica')," +
                "(N'Hajdučica Plandište')," +
                "(N'Halovo Zaječar')," +
                "(N'Hamidijabilić')," +
                "(N'Hadžovići Peć')," +
                "(N'Hercegovačkaoleša Priboj')," +
                "(N'Hercegovo Vučitrn')," +
                "(N'Hetin Žitište')," +
                "(N'Hisardžik Prijepolje')," +
                "(N'Horgoš Kanjiža')," +
                "(N'Hotkovo Novi Pazar')," +
                "(N'Hoča Zagradska Prizren')," +
                "(N'Hrta Prijepolje')," +
                "(N'Hrtica Podujevo')," +
                "(N'Hrtkovci Ruma')," +
                "(N'Huljaj Dečani')," +
                "(N'Hum Niš – Crveni krst')," +
                "(N'Cakanovac Preševo')," +
                "(N'Caparić Ljubovija')," +
                "(N'Caparce Prizren')," +
                "(N'Carevac Velikoradište')," +
                "(N'Carevce Kosovska Kamenica')," +
                "(N'Carinasečina')," +
                "(N'Caričina Sjenica')," +
                "(N'Cvetanovac Ljig')," +
                "(N'Cvetke Kraljevo')," +
                "(N'Cvetovac Beograd – Lazarevac')," +
                "(N'Cvetojevac Kragujevac')," +
                "(N'Cvetulja Krupanj')," +
                "(N'Cekavica Lebane')," +
                "(N'Celinarahovac')," +
                "(N'Ceranja Leposavić')," +
                "(N'Cerev Del Pirot')," +
                "(N'Cerevajka Preševo')," +
                "(N'Ceremošnja Kučevo')," +
                "(N'Cerje Bajina Bašta')," +
                "(N'Cerje Kraljevo')," +
                "(N'Cerje Niš – Pantelej')," +
                "(N'Cernica Varvarin')," +
                "(N'Cernicanjilane')," +
                "(N'Cerova Arilje')," +
                "(N'Cerovaornji Milanovac')," +
                "(N'Cerova Krupanj')," +
                "(N'Cerova Kruševac')," +
                "(N'Cerova Pirot')," +
                "(N'Cerovac Kragujevac')," +
                "(N'Cerovac Smederevska Palanka')," +
                "(N'Cerovac ŠaBač')," +
                "(N'Cerovik Klina')," +
                "(N'Cerovica Kučevo')," +
                "(N'Cerovica Sokobanja')," +
                "(N'Cerovo Ražanj')," +
                "(N'Cetanoviće Sjenica')," +
                "(N'Cecelija Vučitrn')," +
                "(N'Cikot Rekovac')," +
                "(N'Cikote Kosjerić')," +
                "(N'Cikote Loznica')," +
                "(N'Cokoviće Novi Pazar')," +
                "(N'Crvena Jabuka Babušnica')," +
                "(N'Crvena Jabuka Ub')," +
                "(N'Crvena Reka Bela Palanka')," +
                "(N'Crvena Crkva Bela Crkva')," +
                "(N'Crveni Leposavić')," +
                "(N'Crveni Breg Bela Palanka')," +
                "(N'Crveni Breg Leskovac')," +
                "(N'Crvenirad Trgovište')," +
                "(N'Crvenka Kula')," +
                "(N'Crvenčevo Pirot')," +
                "(N'Crvenje Knjaževac')," +
                "(N'Crvica Bajina Bašta')," +
                "(N'Crvsko Sjenica')," +
                "(N'Crepaja Kovačica')," +
                "(N'Crepulja Zubin Potok')," +
                "(N'Crkvena Vodicabilić')," +
                "(N'Crkvenac Svilajnac')," +
                "(N'Crkveni Toci Prijepolje')," +
                "(N'Crkvina Kruševac')," +
                "(N'Crkvine Beograd – Mladenovac')," +
                "(N'Crkvine Tutin')," +
                "(N'Crkvica Bojnik')," +
                "(N'Crkovnica Leskovac')," +
                "(N'Crkolez Istok')," +
                "(N'Crljenac Malo Crniće')," +
                "(N'Crmljane Đakovica')," +
                "(N'Crna Bara Aleksinac')," +
                "(N'Crna Bara Bogatić')," +
                "(N'Crna Bara Vlasotince')," +
                "(N'Crna Bara Čoka')," +
                "(N'Crnalava Raška')," +
                "(N'Crna Reka Trgovište')," +
                "(N'Crna Trava Crna Trava')," +
                "(N'Crnajka Majdanpek')," +
                "(N'Crnatovo Vlasotince')," +
                "(N'Crnatovo Leposavić')," +
                "(N'Crni Breg Lipljan')," +
                "(N'Crni Vrh Knjaževac')," +
                "(N'Crni Vrh Medveđa')," +
                "(N'Crni Vrh Vranjska Banja')," +
                "(N'Crni Vrh Peć')," +
                "(N'Crni Kao Batočina')," +
                "(N'Crni Kao Ražanj')," +
                "(N'Crni Lug Vranje')," +
                "(N'Crni Lug Istok')," +
                "(N'Crni Lug Klina')," +
                "(N'Crnilo Uroševac')," +
                "(N'Crnovranarahovac')," +
                "(N'Crnovce Trgovište')," +
                "(N'Crnoklište Pirot')," +
                "(N'Crnoljevica Svrljig')," +
                "(N'Crnoljevo Štimlje')," +
                "(N'Crnomasnica Negotin')," +
                "(N'Crnotince Preševo')," +
                "(N'Crnoštica Bosilegrad')," +
                "(N'Crnugovići Priboj')," +
                "(N'Crnuzi Priboj')," +
                "(N'Crnce Istok')," +
                "(N'Crnča Ljubovija')," +
                "(N'Crnče Bela Palanka')," +
                "(N'Crnče Jagodina')," +
                "(N'Crcavac Leskovac')," +
                "(N'Crčevo Sjenica')," +
                "(N'Culine Mali Zvornik')," +
                "(N'Culjković ŠaBač')," +
                "(N'Čabić Klina')," +
                "(N'Čabra Zubin Potok')," +
                "(N'Čaglavica Priština')," +
                "(N'Čagrovacadžin Han')," +
                "(N'Čadinje Prijepolje')," +
                "(N'Čairi Trstenik')," +
                "(N'Čajdrak Suva Reka')," +
                "(N'Čajetina Čajetina')," +
                "(N'Čalma Sremska Mitrovica')," +
                "(N'Čamurlija Niš – Crveni krst')," +
                "(N'Čantavir Subotica')," +
                "(N'Čapljinac Doljevac')," +
                "(N'Čar Bujanovac')," +
                "(N'Čarakovce Kosovska Kamenica')," +
                "(N'Čarovina Tutin')," +
                "(N'Čauševići Prijepolje')," +
                "(N'Čačak Čačak')," +
                "(N'Čašić Dolac Novi Pazar')," +
                "(N'Čedovo Sjenica')," +
                "(N'Čekmin Leskovac')," +
                "(N'Čelarevo Bačka Palanka')," +
                "(N'Čeliknjilane')," +
                "(N'Čelice Nova Varoš')," +
                "(N'Čelopek Lipljan')," +
                "(N'Čelopek Peć')," +
                "(N'Čenej Novi Sad')," +
                "(N'Čenta Zrenjanin')," +
                "(N'Čepure Paraćin')," +
                "(N'Čerević Beočin')," +
                "(N'Čerkez Sadovina Vitina')," +
                "(N'Českovo Klina')," +
                "(N'Česta Aleksinac')," +
                "(N'Čestelin Vranje')," +
                "(N'Čestereg Žitište')," +
                "(N'Čestin Knić')," +
                "(N'Čestobrodica Požega')," +
                "(N'Četereže Žabari')," +
                "(N'Čečevo Zubin Potok')," +
                "(N'Čečina Doljevac')," +
                "(N'Čečina Ivanjica')," +
                "(N'Češko Selo Bela Crkva')," +
                "(N'Češljeva Bara Velikoradište')," +
                "(N'Čibukovac Kraljevo')," +
                "(N'Čibutkovica Beograd – Lazarevac')," +
                "(N'Činiglavci Pirot')," +
                "(N'Čipalje Sjenica')," +
                "(N'Čitak Srbica')," +
                "(N'Čitluk Kruševac')," +
                "(N'Čitluk Ljubovija')," +
                "(N'Čitluk Mali Zvornik')," +
                "(N'Čitluk Priboj')," +
                "(N'Čitluk Sjenica')," +
                "(N'Čitluk Sokobanja')," +
                "(N'Čitluk Zubin Potok')," +
                "(N'Čiflak Vitina')," +
                "(N'Čiflakrahovac')," +
                "(N'Čiflik Bela Palanka')," +
                "(N'Čifluk Razgojnski Leskovac')," +
                "(N'Čmanjke Tutin')," +
                "(N'Čoka Čoka')," +
                "(N'Čokešina Loznica')," +
                "(N'Čokonjar Zaječar')," +
                "(N'Čokot Niš – Palilula')," +
                "(N'Čokotar Brus')," +
                "(N'Čokotin Medveđa')," +
                "(N'Čonoplja Sombor')," +
                "(N'Čortanovci Inđija')," +
                "(N'Čubra Negotin')," +
                "(N'Čubrelj Srbica')," +
                "(N'Čubura Merošina')," +
                "(N'Čubura Ražanj')," +
                "(N'Čuka Crna Trava')," +
                "(N'Čukarka Preševo')," +
                "(N'Čukljenik Leskovac')," +
                "(N'Čukljenik Niš – Niška Banja')," +
                "(N'Čukojevac Kraljevo')," +
                "(N'Čukote Tutin')," +
                "(N'Čukurovac Aleksinac')," +
                "(N'Čumić Kragujevac')," +
                "(N'Čungula Blace')");
                migrationBuilder.Sql(
                "insert into Mesta(NazivMesta) values " +
                "(N'Čungur Peć')," +
                "(N'Čupevo Klina')," +
                "(N'Čupevorahovac')," +
                "(N'Čurug Žabalj')," +
                "(N'Čučale Blace')," +
                "(N'Čučuge Ub')," +
                "(N'Čučuljaga Lipljan')," +
                "(N'Džep Vladičin Han')," +
                "(N'Džepnica Blace')," +
                "(N'Džigolj Prokuplje')," +
                "(N'Džurovo Prijepolje')," +
                "(N'ŠaBač ŠaBač')," +
                "(N'Šavac Paraćin')," +
                "(N'Šavrane Kruševac')," +
                "(N'Šavci Novi Pazar')," +
                "(N'Šainovac Doljevac')," +
                "(N'Šainovac Leskovac')," +
                "(N'Šaić Kosovska Kamenica')," +
                "(N'Šajinovac Prizren')," +
                "(N'Šajince Trgovište')," +
                "(N'Šajkaš Titel')," +
                "(N'Šajkovac Podujevo')," +
                "(N'Šakovica Podujevo')," +
                "(N'Šalinac Smederevo')," +
                "(N'Šaludovac Paraćin')," +
                "(N'Šalce Vučitrn')," +
                "(N'Šaljinovica Istok')," +
                "(N'Šaljska Bistrica Leposavić')," +
                "(N'Šanac Kruševac')," +
                "(N'Šantarovac Jagodina')," +
                "(N'Šapine Malo Crniće')," +
                "(N'Šaprance Trgovište')," +
                "(N'Šaptelj Dečani')," +
                "(N'Šaraniornji Milanovac')," +
                "(N'Šarban Priština')," +
                "(N'Šarbane Ub')," +
                "(N'Šarbanovac Bor')," +
                "(N'Šarbanovac Knjaževac')," +
                "(N'Šarbanovac Sokobanja')," +
                "(N'Šare Sjenica')," +
                "(N'Šarenik Ivanjica')," +
                "(N'Šarkamen Negotin')," +
                "(N'Šarlinac Doljevac')," +
                "(N'Šarlince Leskovac')," +
                "(N'Šaronje Novi Pazar')," +
                "(N'Šaronje Tutin')," +
                "(N'Šarce Lebane')," +
                "(N'Šatra Kuršumlija')," +
                "(N'Šatrinci Irig')," +
                "(N'Šašare Vitina')," +
                "(N'Šašilovac Kruševac')," +
                "(N'Šašinci Sremska Mitrovica')," +
                "(N'Šaškovac Priština')," +
                "(N'Šebetadžin Han')," +
                "(N'Ševarice ŠaBač')," +
                "(N'Ševica Kučevo')," +
                "(N'Ševiš Prokuplje')," +
                "(N'Ševrljuge Kosjerić')," +
                "(N'Šepšin Beograd – Mladenovac')," +
                "(N'Šeremet Đakovica')," +
                "(N'Šestiabar Knjaževac')," +
                "(N'Šetka Ražanj')," +
                "(N'Šetonje Petrova na Mlavi')," +
                "(N'Šid Šid')," +
                "(N'Šilovo Lebane')," +
                "(N'Šilovonjilane')," +
                "(N'Šilopajornji Milanovac')," +
                "(N'Šiljakovac Beograd – Barajevo')," +
                "(N'Šiljomana Blace')," +
                "(N'Šimanovci Pećinci')," +
                "(N'Šipačina Raška')," +
                "(N'Šipikovo Zaječar')," +
                "(N'Šipitulabilić')," +
                "(N'Šipova Zubin Potok')," +
                "(N'Šipolje Kosovska Mitrovica')," +
                "(N'Šipče Tutin')," +
                "(N'Široka Planina Trgovište')," +
                "(N'Široke Njive Prokuplje')," +
                "(N'Šišave Vlasotince')," +
                "(N'Šišarka Lipljan')," +
                "(N'Šišatovac Sremska Mitrovica')," +
                "(N'Šišince Leskovac')," +
                "(N'Šišman Đakovica')," +
                "(N'Šišmanovac Prokuplje')," +
                "(N'Škoza Prizren')," +
                "(N'Škrelje Peć')," +
                "(N'Šljivar Zaječar')," +
                "(N'Šljivica Rekovac')," +
                "(N'Šljivova Krupanj')," +
                "(N'Šljivovac Kragujevac')," +
                "(N'Šljivovac Malo Crniće')," +
                "(N'Šljivovik Bela Palanka')," +
                "(N'Šljivovik Svrljig')," +
                "(N'Šljivovica Čajetina')," +
                "(N'Šljivovica Vučitrn')," +
                "(N'Šljivovo Aleksandrovac')," +
                "(N'Šogolj Kruševac')," +
                "(N'Šopić Beograd – Lazarevac')," +
                "(N'Šošiće Brus')," +
                "(N'Špaj Bela Palanka')," +
                "(N'Špiljani Tutin')," +
                "(N'Špinadija Prizren')," +
                "(N'Štava Kuršumlija')," +
                "(N'Štavalj Sjenica')," +
                "(N'Štavica Ljig')," +
                "(N'Štedim Podujevo')," +
                "(N'Štimlje Štimlje')," +
                "(N'Šina Knjaževac')," +
                "(N'Štitar ŠaBač')," +
                "(N'Štitarac Knjaževac')," +
                "(N'Štitare Kruševac')," +
                "(N'Štitare Novi Pazar')," +
                "(N'Štitarica Vučitrn')," +
                "(N'Štitkovo Nova Varoš')," +
                "(N'ŠtrBač Knjaževac')," +
                "(N'Štrbovac Babušnica')," +
                "(N'Štrbulovologovac')," +
                "(N'Štrpce Štrpce')," +
                "(N'Štubik Negotin')," +
                "(N'Štulac Vrnjačka Banja')," +
                "(N'Štulac Lebane')," +
                "(N'Štuoce Zubin Potok')," +
                "(N'Štupelj Klina')," +
                "(N'Štuticalogovac')," +
                "(N'ŠuvajićoluBač')," +
                "(N'Šugrin Pirot')," +
                "(N'Šuljam Sremska Mitrovica')," +
                "(N'Šuljkovac Jagodina')," +
                "(N'Šuman Topla Knjaževac')," +
                "(N'Šumane Lebane')," +
                "(N'Šumarak Kovin')," +
                "(N'Šumarice Kraljevo')," +
                "(N'Šumata Trnica Trgovište')," +
                "(N'Šume Ivanjica')," +
                "(N'Šume Topola')," +
                "(N'Šupkovac Kosovska Mitrovica')," +
                "(N'Šupljak Subotica')," +
                "(N'Šurić Aleksinac')," +
                "(N'Šurice Loznica')," +
                "(N'Šurjan Sečanj')," +
                "(N'Šurlanenjilane')," +
                "(N'Šutci Ljig')," +
                "(N'Šušara Vršac')," +
                "(N'Šušeoka Mionica')," +
                "(N'Šušnjar Beograd – Lazarevac')," +
                "(N'Šušure Sjenica')");




        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mesta");
        }
    }
}
