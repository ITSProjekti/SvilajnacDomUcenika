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
                "(N'Adorjan')," +
                "(N'Adrani')," +
                "(N'Adrovac')," +
                "(N'Azanja')," +
                "(N'Azbresnica')," +
                "(N'Ajvalija')," +
                "(N'Ajkobila')," +
                "(N'Ajnovce')," +
                "(N'Akmačići')," +
                "(N'Alabak')," +
                "(N'Alabana')," +
                "(N'Alagina')," +
                "(N'Alakince')," +
                "(N'Aldina')," +
                "(N'Aldinac')," +
                "(N'Aleksa Šantić')," +
                "(N'Aleksandrovac')," +
                "(N'Aleksandrovo')," +
                "(N'Aleksinac')," +
                "(N'Aleksinački Bujmir')," +
                "(N'Aleksinački Rudnik')," +
                "(N'Aleksine')," +
                "(N'Alibunar')," +
                "(N'Aliveroviće')," +
                "(N'Aliđerce')," +
                "(N'Alin Potok')," +
                "(N'Aluloviće')," +
                "(N'Aljinovići')," +
                "(N'Aljudovo')," +
                "(N'Amajić')," +
                "(N'Amerić')," +
                "(N'Amzići')," +
                "(N'Androvac')," +
                "(N'Apatin')," +
                "(N'Aradac')," +
                "(N'Aranđelovac')," +
                "(N'Arapovac')," +
                "(N'Arapoviće')," +
                "(N'Arbanasce')," +
                "(N'Arbanaška')," +
                "(N'Ariljača')," +
                "(N'Arilje')," +
                "(N'Arnajevo')," +
                "(N'Asanovac')," +
                "(N'Atenica')," +
                "(N'Atmađa')," +
                "(N'Adžine Livade')," +
                "(N'Ašanja')," +
                "(N'Ba')," +
                "(N'Babaj Boks')," +
                "(N'Babajić')," +
                "(N'Babaloć')," +
                "(N'Babe')," +
                "(N'Babin Kal')," +
                "(N'Babin Most')," +
                "(N'Babin Potok')," +
                "(N'Babina Luka')," +
                "(N'Babina Poljana')," +
                "(N'Babiće')," +
                "(N'Babica')," +
                "(N'Babičko')," +
                "(N'Babljak')," +
                "(N'Babotinac')," +
                "(N'Babudovica')," +
                "(N'Babušnica')," +
                "(N'Bavanište')," +
                "(N'Bagačiće')," +
                "(N'Bagrdan')," +
                "(N'Bagremovo')," +
                "(N'Badanj')," +
                "(N'Badince')," +
                "(N'Badljevica')," +
                "(N'Badnjevac')," +
                "(N'Badovac')," +
                "(N'Badovinci')," +
                "(N'Bazovik')," +
                "(N'Bajgora')," +
                "(N'Bajevac')," +
                "(N'Bajevica')," +
                "(N'Bajina Bašta')," +
                "(N'Bajinci')," +
                "(N'Bajmok')," +
                "(N'Bajčetina')," +
                "(N'Bajčina')," +
                "(N'Bajčince')," +
                "(N'Bajša')," +
                "(N'Bakionica')," +
                "(N'Baks')," +
                "(N'Bakšija')," +
                "(N'Balaban')," +
                "(N'Balajnac')," +
                "(N'Balanovac')," +
                "(N'Balance')," +
                "(N'Balinac')," +
                "(N'Balinovac')," +
                "(N'Balinović')," +
                "(N'Balinovce')," +
                "(N'Balince')," +
                "(N'Balići')," +
                "(N'Baličevac')," +
                "(N'Balovac')," +
                "(N'Balosave')," +
                "(N'Balta')," +
                "(N'Baluga')," +
                "(N'Balčak')," +
                "(N'Baljevac')," +
                "(N'Baljen')," +
                "(N'Baljkovac')," +
                "(N'Banatska Dubica')," +
                "(N'Banatska Palanka')," +
                "(N'Banatska')," +
                "(N'Banatska')," +
                "(N'Banatski Brestovac')," +
                "(N'Banatski Dvor')," +
                "(N'Banatski')," +
                "(N'Banatski')," +
                "(N'Banatski')," +
                "(N'Banatski Sokolac')," +
                "(N'Banatsko Aranđelovo')," +
                "(N'Banatsko Veliko Selo')," +
                "(N'Banatsko Višnjićevo')," +
                "(N'Banatsko Karađorđevo')," +
                "(N'Banatsko Novo Selo')," +
                "(N'Bandulić')," +
                "(N'Baničina')," +
                "(N'Bankovac')," +
                "(N'Bankovci')," +
                "(N'Banov Do')," +
                "(N'Banovo Polje')," +
                "(N'Banoštor')," +
                "(N'Banski Dol')," +
                "(N'Bancarevo')," +
                "(N'Banja')," +
                "(N'Banjevac')," +
                "(N'Banjica')," +
                "(N'Banjska')," +
                "(N'Banjska')," +
                "(N'Banjski Suvi Do')," +
                "(N'Bapsko Polje')," +
                "(N'Baraina')," +
                "(N'Barajevo')," +
                "(N'Baraljevac')," +
                "(N'Barandapovo')," +
                "(N'Barane')," +
                "(N'Barbarušince')," +
                "(N'Barbatovac')," +
                "(N'Barbace')," +
                "(N'Bardonić')," +
                "(N'Bardosan')," +
                "(N'Bare')," +
                "(N'Barelić')," +
                "(N'Barzilovica')," +
                "(N'Bariljevo')," +
                "(N'Barice')," +
                "(N'Barič')," +
                "(N'Barje')," +
                "(N'Barlovo')," +
                "(N'Baroševac')," +
                "(N'Basara')," +
                "(N'Bastav')," +
                "(N'Bataire')," +
                "(N'Batalage')," +
                "(N'Batinac')," +
                "(N'Batkovići')," +
                "(N'Batlava')," +
                "(N'Batnjik')," +
                "(N'Batovac')," +
                "(N'Batote')," +
                "(N'Batočina')," +
                "(N'Batrage')," +
                "(N'Batrovci')," +
                "(N'Batulovce')," +
                "(N'Batuse')," +
                "(N'Batuša')," +
                "(N'Batušinac')," +
                "(N'Baćevac')," +
                "(N'Baćica')," +
                "(N'Baćoglava')," +
                "(N'Bače')," +
                "(N'Bačijevce')," +
                "(N'Bač')," +
                "(N'Bačvište')," +
                "(N'Bačevina')," +
                "(N'Bačevica')," +
                "(N'Bačevo')," +
                "(N'Bačevci')," +
                "(N'Bačija')," +
                "(N'Bačina')," +
                "(N'Bačinac')," +
                "(N'Bačinci')," +
                "(N'Bačkaora')," +
                "(N'Bačka Palanka')," +
                "(N'Bačka')," +
                "(N'Bački Breg')," +
                "(N'Bački Brestovac')," +
                "(N'Bački Vinogradi')," +
                "(N'Bački Gračac')," +
                "(N'Bački Jarak')," +
                "(N'Bački')," +
                "(N'Bački')," +
                "(N'Bački Sokolac')," +
                "(N'Bačko Gradište')," +
                "(N'Bačko Dobro Polje')," +
                "(N'Bačko Dušanovo')," +
                "(N'Bačko Novo Selo')," +
                "(N'Bačko Petrovo Selo')," +
                "(N'Bašaid')," +
                "(N'Bašin')," +
                "(N'Baščeluci')," +
                "(N'Begaljica')," +
                "(N'Begeč')," +
                "(N'Begov Lukavac')," +
                "(N'Begovo Brdo')," +
                "(N'Begunce')," +
                "(N'Bedina Varoš')," +
                "(N'Bežište')," +
                "(N'Bezdan')," +
                "(N'Bekova')," +
                "(N'Bela Voda')," +
                "(N'Bela Palanka')," +
                "(N'Bela')," +
                "(N'Bela Stena')," +
                "(N'Bela Crkva')," +
                "(N'Belaje')," +
                "(N'Belanica')," +
                "(N'Belanovica')," +
                "(N'Belanovce')," +
                "(N'Belasica')," +
                "(N'Bele Vode')," +
                "(N'Beleg')," +
                "(N'Belegiš')," +
                "(N'Beleš')," +
                "(N'Beli Breg')," +
                "(N'Beli Kamen')," +
                "(N'Beli Potok')," +
                "(N'Belince')," +
                "(N'Belić')," +
                "(N'Belica')," +
                "(N'Beliševo')," +
                "(N'Belo Blato')," +
                "(N'Belo Brdo')," +
                "(N'Belo Polje')," +
                "(N'Belobrod')," +
                "(N'Belogoš')," +
                "(N'Belograce')," +
                "(N'Beloinje')," +
                "(N'Beloljin')," +
                "(N'Belosavci')," +
                "(N'Belotinac')," +
                "(N'Belotić')," +
                "(N'Beloševac')," +
                "(N'Belut')," +
                "(N'Beluće')," +
                "(N'Belušić')," +
                "(N'Belja')," +
                "(N'Beljajka')," +
                "(N'Beljevac')," +
                "(N'Beljina')," +
                "(N'Benčuk')," +
                "(N'Voždovac')," +
                "(N'Vračar')," +
                "(N'Zvezdara')," +
                "(N'Zemun')," +
                "(N'Novi Beograd')," +
                "(N'Palilula')," +
                "(N'Rakovica')," +
                "(N'Savski Venac')," +
                "(N'Stari Grad')," +
                "(N'Čukarica')," +
                "(N'Beomužević')," +
                "(N'Beoci')," +
                "(N'Beočin')," +
                "(N'Beočić')," +
                "(N'Beranje')," +
                "(N'Berbatovo')," +
                "(N'Berberište')," +
                "(N'Berduj')," +
                "(N'Berevce')," +
                "(N'Berivojce')," +
                "(N'Berilovac')," +
                "(N'Berilje')," +
                "(N'Berin Izvor')," +
                "(N'Berjak')," +
                "(N'Berkasovo')," +
                "(N'Berkovac')," +
                "(N'Berkovo')," +
                "(N'Berlovine')," +
                "(N'Berovica')," +
                "(N'Berčevac')," +
                "(N'Berčinac')," +
                "(N'Berčinovac')," +
                "(N'Beršićiornji')," +
                "(N'Beserovina')," +
                "(N'Besinje')," +
                "(N'Bečanj')," +
                "(N'Bečevica')," +
                "(N'Bečej')," +
                "(N'Bečmen')," +
                "(N'Bešenovački')," +
                "(N'Bešenovo')," +
                "(N'Beška')," +
                "(N'Bzenice')," +
                "(N'Bzovik')," +
                "(N'Bivoljak')," +
                "(N'Bivolje')," +
                "(N'Bigrenica')," +
                "(N'Bikić Do')," +
                "(N'Bikovo')," +
                "(N'Bilince')," +
                "(N'Biluša')," +
                "(N'Biljanovac')," +
                "(N'Biljača')," +
                "(N'Biljeg')," +
                "(N'Binač')," +
                "(N'Bingula')," +
                "(N'Biniće')," +
                "(N'Binovac')," +
                "(N'Binovce')," +
                "(N'Bioska')," +
                "(N'Biohane')," +
                "(N'Bioc')," +
                "(N'Biočin')," +
                "(N'Biskupići')," +
                "(N'Biskuplje')," +
                "(N'Bistar')," +
                "(N'Bistražin')," +
                "(N'Bistrica')," +
                "(N'Bitvrđa')," +
                "(N'Biča')," +
                "(N'Bičevac')," +
                "(N'Bjelahova')," +
                "(N'Bjeloperica')," +
                "(N'Bjelotići')," +
                "(N'Bjeluša')," +
                "(N'Blagaje')," +
                "(N'Blagojev')," +
                "(N'Blaževo')," +
                "(N'Blaznava')," +
                "(N'Blato')," +
                "(N'Blace')," +
                "(N'Blendija')," +
                "(N'Bliznak')," +
                "(N'Blizonje')," +
                "(N'Bljač')," +
                "(N'Bob')," +
                "(N'Bobište')," +
                "(N'Bobova')," +
                "(N'Bobovac')," +
                "(N'Bobovik')," +
                "(N'Bobovište')," +
                "(N'Bobovo')," +
                "(N'Bobote')," +
                "(N'Bovan')," +
                "(N'Bovanj')," +
                "(N'Bogava')," +
                "(N'Bogalinac')," +
                "(N'Bogaraš')," +
                "(N'Bogatić')," +
                "(N'Bogdanica')," +
                "(N'Bogdanovac')," +
                "(N'Bogdanje')," +
                "(N'Bogdinac')," +
                "(N'Boge')," +
                "(N'Bogiše')," +
                "(N'Bogovađa')," +
                "(N'Bogovina')," +
                "(N'Bogojevići')," +
                "(N'Bogojevo')," +
                "(N'Bogojevce')," +
                "(N'Bogosavac')," +
                "(N'Bogoševo')," +
                "(N'Bogoštica')," +
                "(N'Bogujevac')," +
                "(N'Bogunovac')," +
                "(N'Boguti')," +
                "(N'Bogutovac')," +
                "(N'Bođani')," +
                "(N'Boždarevac')," +
                "(N'Boževac')," +
                "(N'Boževce')," +
                "(N'Božetići')," +
                "(N'Božinovac')," +
                "(N'Božinjevac')," +
                "(N'Božica')," +
                "(N'Božov Potok')," +
                "(N'Božurevac')," +
                "(N'Božurnja')," +
                "(N'Bozoljin')," +
                "(N'Bojanići')," +
                "(N'Bojin Del')," +
                "(N'Bojince')," +
                "(N'Bojić')," +
                "(N'Bojišina')," +
                "(N'Bojnik')," +
                "(N'Bojnoviće')," +
                "(N'Bostane')," +
                "(N'Bosut')," +
                "(N'Bosce')," +
                "(N'Botoš')," +
                "(N'Botunja')," +
                "(N'Botunje')," +
                "(N'Boturići')," +
                "(N'Boturovina')," +
                "(N'Boće')," +
                "(N'Boćevica')," +
                "(N'Bočar')," +
                "(N'Bošljane')," +
                "(N'Bošnjak')," +
                "(N'Bošnjane')," +
                "(N'Bošnjanović')," +
                "(N'Bošnjace')," +
                "(N'Brabonjić')," +
                "(N'Bradarac')," +
                "(N'Bradaš')," +
                "(N'Bradić')," +
                "(N'Braina')," +
                "(N'Brajići')," +
                "(N'Brajkovac')," +
                "(N'Brajkovići')," +
                "(N'Brajnovac')," +
                "(N'Braljina')," +
                "(N'Brangović')," +
                "(N'Branešci')," +
                "(N'Braničevo')," +
                "(N'Brankovina')," +
                "(N'Brankovci')," +
                "(N'Brančić')," +
                "(N'Brasaljce')," +
                "(N'Brasina')," +
                "(N'Bratačić')," +
                "(N'Bratilovce')," +
                "(N'Bratinac')," +
                "(N'Bratići')," +
                "(N'Bratiševac')," +
                "(N'Bratljevo')," +
                "(N'Bratmilovce')," +
                "(N'Bratoselce')," +
                "(N'Bratotin')," +
                "(N'Braćak')," +
                "(N'Braćevac')," +
                "(N'Braćevci')," +
                "(N'Brvenik')," +
                "(N'Brvenica')," +
                "(N'Brvine')," +
                "(N'Brgule')," +
                "(N'Brgulice')," +
                "(N'Brdarica')," +
                "(N'Brdo')," +
                "(N'Brđani')," +
                "(N'Brebevnica')," +
                "(N'Brevnik')," +
                "(N'Bregovi')," +
                "(N'Bregovina')," +
                "(N'Brežane')," +
                "(N'Brežani')," +
                "(N'Brežanik')," +
                "(N'Brežđe')," +
                "(N'Breza')," +
                "(N'Brezjak')," +
                "(N'Brezna')," +
                "(N'Breznica')," +
                "(N'Brezova')," +
                "(N'Brezovac')," +
                "(N'Brezovice')," +
                "(N'Brejanovce')," +
                "(N'Brekovac')," +
                "(N'Brekovo')," +
                "(N'Brenica')," +
                "(N'Bresje')," +
                "(N'Bresnik')," +
                "(N'Bresnica')," +
                "(N'Bresničić')," +
                "(N'Bresno Polje')," +
                "(N'Brest')," +
                "(N'Brestač')," +
                "(N'Brestov Dol')," +
                "(N'Brestovac')," +
                "(N'Brestovik')," +
                "(N'Brestovo')," +
                "(N'Brece')," +
                "(N'Brza')," +
                "(N'Brzan')," +
                "(N'Brzance')," +
                "(N'Brzeće')," +
                "(N'Brzi Brod')," +
                "(N'Brzohode')," +
                "(N'Bričevlje')," +
                "(N'Brlog')," +
                "(N'Brniševo')," +
                "(N'Brnjak')," +
                "(N'Brnjare')," +
                "(N'Brnjac')," +
                "(N'Brnjica')," +
                "(N'Brovina')," +
                "(N'Brović')," +
                "(N'Brod')," +
                "(N'Brodarevo')," +
                "(N'Brodica')," +
                "(N'Brodosavce')," +
                "(N'Brolić')," +
                "(N'Broćna')," +
                "(N'Brus')," +
                "(N'Brusnik')," +
                "(N'Brusnica')," +
                "(N'Brut')," +
                "(N'Brštica')," +
                "(N'Buar')," +
                "(N'Bubanj')," +
                "(N'Bube')," +
                "(N'Bublica')," +
                "(N'Bublje')," +
                "(N'Bubušinac')," +
                "(N'Buvce')," +
                "(N'Budakovo')," +
                "(N'Budilovina')," +
                "(N'Budisava')," +
                "(N'Budisavci')," +
                "(N'Budišić')," +
                "(N'Budoželja')," +
                "(N'Buđanovci')," +
                "(N'Buđevo')," +
                "(N'Buzec')," +
                "(N'Buzovik')," +
                "(N'Bujanovac')," +
                "(N'Bujance')," +
                "(N'Bujačić')," +
                "(N'Bujić')," +
                "(N'Bujkovac')," +
                "(N'Bujkoviće')," +
                "(N'Bukarevac')," +
                "(N'Bukovalava')," +
                "(N'Bukovac')," +
                "(N'Bukovik')," +
                "(N'Bukovica')," +
                "(N'Bukovska')," +
                "(N'Bukovče')," +
                "(N'Bukor')," +
                "(N'Bukorovac')," +
                "(N'Bukoš')," +
                "(N'Bukuloram')," +
                "(N'Bukurovac')," +
                "(N'Bulatovac')," +
                "(N'Bulinovac')," +
                "(N'Buljane')," +
                "(N'Buljesovce')," +
                "(N'Bumbarevo Brdo')," +
                "(N'Bunar')," +
                "(N'Bunuški Čifluk')," +
                "(N'Burađa')," +
                "(N'Burdimo')," +
                "(N'Burince')," +
                "(N'Burlate')," +
                "(N'Burnik')," +
                "(N'Burovac')," +
                "(N'Burovo')," +
                "(N'Busenje')," +
                "(N'Busilovac')," +
                "(N'Businje')," +
                "(N'Busovata')," +
                "(N'Busur')," +
                "(N'Buceljevo')," +
                "(N'Buci')," +
                "(N'Buča')," +
                "(N'Bučane')," +
                "(N'Bučince')," +
                "(N'Bučić')," +
                "(N'Bučje')," +
                "(N'Bučum')," +
                "(N'Bušince')," +
                "(N'Buštranje')," +
                "(N'Vava')," +
                "(N'Vaganeš')," +
                "(N'Vaganica')," +
                "(N'Vajska')," +
                "(N'Vajuga')," +
                "(N'Vakup')," +
                "(N'Valakonje')," +
                "(N'Valač')," +
                "(N'Valevac')," +
                "(N'Valniš')," +
                "(N'Valjevo')," +
                "(N'Vapa')," +
                "(N'Varadin')," +
                "(N'Varvarin')," +
                "(N'Varda')," +
                "(N'Varevo')," +
                "(N'Varigovce')," +
                "(N'Varna')," +
                "(N'Varnice')," +
                "(N'Varoš')," +
                "(N'Vasilj')," +
                "(N'Vasiljevac')," +
                "(N'Vasiljevići')," +
                "(N'Vasiljevo')," +
                "(N'Vata')," +
                "(N'Vatin')," +
                "(N'Vašica')," +
                "(N'Vever')," +
                "(N'Vezičevo')," +
                "(N'Vele Polje')," +
                "(N'Velebit')," +
                "(N'Veleža')," +
                "(N'Velekince')," +
                "(N'Velereč')," +
                "(N'Velesnica')," +
                "(N'Velika Biljanica')," +
                "(N'Velika Braina')," +
                "(N'Velika Bresnica')," +
                "(N'Velika Vrbica')," +
                "(N'Velika Vrbnica')," +
                "(N'Velika Grabovnica')," +
                "(N'Velika Greda')," +
                "(N'Velika Dobranja')," +
                "(N'Velika Drenova')," +
                "(N'Velika Ivanča')," +
                "(N'Velika Jablanica')," +
                "(N'Velika Jasikova')," +
                "(N'Velika Ježevica')," +
                "(N'Velika Kaludra')," +
                "(N'Velika Kamenica')," +
                "(N'Velika Kopašnica')," +
                "(N'Velika Krsnad')," +
                "(N'Velika Kruša')," +
                "(N'Velika Kruševica')," +
                "(N'Velika Lomnica')," +
                "(N'Velika Lukanja')," +
                "(N'Velika Marišta')," +
                "(N'Velika Moštanica')," +
                "(N'Velika Plana')," +
                "(N'Velika Remeta')," +
                "(N'Velika Sejanica')," +
                "(N'Velika Slatina')," +
                "(N'Velika Sugubina')," +
                "(N'Velika Hoča')," +
                "(N'Velike Pčelice')," +
                "(N'Veliki Alaš')," +
                "(N'Veliki Belaćevac')," +
                "(N'Veliki Buk')," +
                "(N'Veliki Vrtop')," +
                "(N'Veliki Drenovac')," +
                "(N'Veliki Đurđevik')," +
                "(N'Veliki Izvor')," +
                "(N'Veliki Jasenovac')," +
                "(N'Veliki Jovanovac')," +
                "(N'Veliki Kičić')," +
                "(N'Veliki Krčimir')," +
                "(N'Veliki Kupci')," +
                "(N'Veliki Popovac')," +
                "(N'Veliki Popović')," +
                "(N'Veliki Radinci')," +
                "(N'Veliki Suvodol')," +
                "(N'Veliki Trnovac')," +
                "(N'Veliki Crljeni')," +
                "(N'Veliki Šenj')," +
                "(N'Veliki Šiljegovac')," +
                "(N'Veliki Štupelj')," +
                "(N'Veliko Bonjince')," +
                "(N'Veliko Vojlovce')," +
                "(N'Veliko Golovode')," +
                "(N'Veliko Gradište')," +
                "(N'Veliko Kruševo')," +
                "(N'Veliko Krušince')," +
                "(N'Veliko Krčmare')," +
                "(N'Veliko Laolela')," +
                "(N'Veliko Orašje')," +
                "(N'Veliko Poljebreno')," +
                "(N'Veliko Pupavce')," +
                "(N'Veliko Ribare')," +
                "(N'Veliko Ropotovo')," +
                "(N'Veliko Rudare')," +
                "(N'Veliko Selo')," +
                "(N'Veliko Selo')," +
                "(N'Veliko Središte')," +
                "(N'Veliko Trnjane')," +
                "(N'Veliko Crniće')," +
                "(N'Veliševac')," +
                "(N'Veluće')," +
                "(N'Veljalava')," +
                "(N'Velje Polje')," +
                "(N'Veljeglava')," +
                "(N'Velji Breg')," +
                "(N'Veljkovo')," +
                "(N'Venčane')," +
                "(N'Venčac')," +
                "(N'Verzar')," +
                "(N'Verić')," +
                "(N'Vesekovce')," +
                "(N'Veselinovac')," +
                "(N'Veseniće')," +
                "(N'Veskoviće')," +
                "(N'Veta')," +
                "(N'Veternik')," +
                "(N'Vigošte')," +
                "(N'Vidanje')," +
                "(N'Vidova')," +
                "(N'Vidovac')," +
                "(N'Vidovača')," +
                "(N'Vidovo')," +
                "(N'Vidomirić')," +
                "(N'Vidrovac')," +
                "(N'Vidušić')," +
                "(N'Vizić')," +
                "(N'Vilandrica')," +
                "(N'Vilište')," +
                "(N'Vilovi')," +
                "(N'Vilovo Titel')," +
                "(N'Viljance')," +
                "(N'Vilje Kolo')," +
                "(N'Viljuša')," +
                "(N'Vina')," +
                "(N'Vina')," +
                "(N'Vinarce')," +
                "(N'Vinicka')," +
                "(N'Vinorača')," +
                "(N'Vinci')," +
                "(N'Vinča')," +
                "(N'Vinjište')," +
                "(N'Vionica')," +
                "(N'Virine')," +
                "(N'Virovac')," +
                "(N'Virovo')," +
                "(N'Visibaba')," +
                "(N'Visoka')," +
                "(N'Visočka')," +
                "(N'Visočka Ržana')," +
                "(N'Visočki Odorovci')," +
                "(N'Vitak')," +
                "(N'Vitakova')," +
                "(N'Vitanovac')," +
                "(N'Vitanoviće')," +
                "(N'Vitance')," +
                "(N'Vitasi')," +
                "(N'Viteževo')," +
                "(N'Vitina')," +
                "(N'Vitkovac')," +
                "(N'Vitkoviće')," +
                "(N'Vitkovo')," +
                "(N'Vitovnica')," +
                "(N'Vitojevci')," +
                "(N'Vitomirica')," +
                "(N'Vitoše')," +
                "(N'Vitoševac')," +
                "(N'Viča')," +
                "(N'Više Selo')," +
                "(N'Viševac')," +
                "(N'Viševce')," +
                "(N'Višesava')," +
                "(N'Višnjeva')," +
                "(N'Višnjevac')," +
                "(N'Višnjićevo')," +
                "(N'Višnjice')," +
                "(N'Vladimirovac')," +
                "(N'Vladimirci')," +
                "(N'Vladičin Han')," +
                "(N'Vladovo')," +
                "(N'Vladovce')," +
                "(N'Vlajkovac')," +
                "(N'Vlajkovci')," +
                "(N'Vlakča')," +
                "(N'Vlaole')," +
                "(N'Vlasanica')," +
                "(N'Vlase')," +
                "(N'Vlasi')," +
                "(N'Vlasina Okruglica')," +
                "(N'Vlasina Rid')," +
                "(N'Vlasina Stojkovićeva')," +
                "(N'Vlasovo')," +
                "(N'Vlasotince')," +
                "(N'Vlasteljice')," +
                "(N'Vlahinja')," +
                "(N'Vlahinje')," +
                "(N'Vlahovo')," +
                "(N'Vlahovo')," +
                "(N'Vlaška')," +
                "(N'Vlaška')," +
                "(N'Vlaški Do')," +
                "(N'Vlaški Drenovac')," +
                "(N'Vlaško Polje')," +
                "(N'Vlašnja')," +
                "(N'Vlaštica')," +
                "(N'Vlaščić')," +
                "(N'Vlkovija')," +
                "(N'Vogance')," +
                "(N'Voganj')," +
                "(N'Vogačica')," +
                "(N'Vogovo')," +
                "(N'Vodanj')," +
                "(N'Vodice')," +
                "(N'Vojvoda Zimonić')," +
                "(N'Vojvoda Stepa')," +
                "(N'Vojvodinci')," +
                "(N'Vojilovo')," +
                "(N'Vojinovac')," +
                "(N'Vojinovce')," +
                "(N'Vojka')," +
                "(N'Vojkoviće')," +
                "(N'Vojkovci')," +
                "(N'Vojmilovići')," +
                "(N'Vojmisliće')," +
                "(N'Vojnegovac')," +
                "(N'Vojnik')," +
                "(N'Vojniće')," +
                "(N'Vojnici')," +
                "(N'Vojska')," +
                "(N'Vokša')," +
                "(N'Voluja')," +
                "(N'Volujak')," +
                "(N'Volujac')," +
                "(N'Voljavče')," +
                "(N'Voljevci')," +
                "(N'Voljčince')," +
                "(N'Voćnjak')," +
                "(N'Vošanovac')," +
                "(N'Vragovac')"); 
				
				 migrationBuilder.Sql(
                "insert into Mesta(NazivMesta) values " +
                "(N'Vragolija')," +
                "(N'Vragočanica')," +
                "(N'Vražogrnac')," +
                "(N'Vražogrnci')," +
                "(N'Vrandol')," +
                "(N'Vrane')," +
                "(N'Vraneša')," +
                "(N'Vraneši')," +
                "(N'Vrani Do')," +
                "(N'Vranićjevo')," +
                "(N'Vranić')," +
                "(N'Vranići')," +
                "(N'Vranište')," +
                "(N'Vraništeora')," +
                "(N'Vranovac')," +
                "(N'Vranovina')," +
                "(N'Vranovo')," +
                "(N'Vranštica')," +
                "(N'Vranjak')," +
                "(N'Vranjani')," +
                "(N'Vranje')," +
                "(N'Vranjska Banja')," +
                "(N'Vrapce')," +
                "(N'Vrapci')," +
                "(N'Vrapča')," +
                "(N'Vrapče')," +
                "(N'Vrapčić')," +
                "(N'Vratare')," +
                "(N'Vratarnica')," +
                "(N'Vratna')," +
                "(N'Vraćevšnica')," +
                "(N'Vračevaj')," +
                "(N'Vračević')," +
                "(N'Vračevo')," +
                "(N'Vrba')," +
                "(N'Vrba')," +
                "(N'Vrban')," +
                "(N'Vrbas')," +
                "(N'Vrbeta')," +
                "(N'Vrbeštica')," +
                "(N'Vrbić')," +
                "(N'Vrbica')," +
                "(N'Vrbičane')," +
                "(N'Vrbnica')," +
                "(N'Vrbovac')," +
                "(N'Vrbovno')," +
                "(N'Vrbovo')," +
                "(N'Vrgudinac')," +
                "(N'Vrdila')," +
                "(N'Vrdnik')," +
                "(N'Vrelo')," +
                "(N'Vreoci')," +
                "(N'Vrlane')," +
                "(N'Vrmbaje')," +
                "(N'Vrmnica')," +
                "(N'Vrmdža')," +
                "(N'Vrnavokolo')," +
                "(N'Vrnez')," +
                "(N'Vrnica')," +
                "(N'Vrnčani')," +
                "(N'Vrnčani')," +
                "(N'Vrnjačka Banja')," +
                "(N'Vrnjci')," +
                "(N'Vrsjenice')," +
                "(N'Vrtiglav')," +
                "(N'Vrtine')," +
                "(N'Vrtište')," +
                "(N'Vrtovac')," +
                "(N'Vrtogoš')," +
                "(N'Vrtolnica')," +
                "(N'Vrćenovica')," +
                "(N'Vrutci')," +
                "(N'Vrućevce')," +
                "(N'Vrh')," +
                "(N'Vrhovine')," +
                "(N'Vrhpolje')," +
                "(N'Vrčin')," +
                "(N'Vršac')," +
                "(N'Vršački Ritovi')," +
                "(N'Vrševac')," +
                "(N'Vrševce')," +
                "(N'Vujanovo')," +
                "(N'Vujetinci')," +
                "(N'Vujinovača')," +
                "(N'Vukanja')," +
                "(N'Vukašinovac')," +
                "(N'Vukićevica')," +
                "(N'Vukmanovac')," +
                "(N'Vukmanovo')," +
                "(N'Vukovac')," +
                "(N'Vuković')," +
                "(N'Vukojevac')," +
                "(N'Vukojeviće')," +
                "(N'Vukona')," +
                "(N'Vukosavljeviće')," +
                "(N'Vukosavci')," +
                "(N'Vukošić')," +
                "(N'Vukušica')," +
                "(N'Vus')," +
                "(N'Vuča')," +
                "(N'Vučadelce')," +
                "(N'Vučak')," +
                "(N'Vučevica')," +
                "(N'Vuči Del')," +
                "(N'Vučiniće')," +
                "(N'Vučitrn')," +
                "(N'Vučić')," +
                "(N'Vučja Lokva')," +
                "(N'Vučje')," +
                "(N'Vučkovica')," +
                "(N'Gabrica')," +
                "(N'Gabrovac')," +
                "(N'Gabrovnica')," +
                "(N'Gavez')," +
                "(N'Gagince')," +
                "(N'Gaglovo')," +
                "(N'Gadiš')," +
                "(N'Gazdare')," +
                "(N'Gazivode')," +
                "(N'Gaj Kovin')," +
                "(N'Gajdobra')," +
                "(N'Gajre')," +
                "(N'Gakovo')," +
                "(N'Galibabinac')," +
                "(N'Galica')," +
                "(N'Galović Koceljeva')," +
                "(N'Galovići')," +
                "(N'Gamzigrad')," +
                "(N'Garaši')," +
                "(N'Gardinovci')," +
                "(N'Gare')," +
                "(N'Garevina')," +
                "(N'Garevo')," +
                "(N'Gari')," +
                "(N'Garinje')," +
                "(N'Gatnje')," +
                "(N'Gvozdac')," +
                "(N'Gvozdenović')," +
                "(N'Geglja')," +
                "(N'Geljance')," +
                "(N'Gedža')," +
                "(N'Gibarac')," +
                "(N'Glavinci')," +
                "(N'Glavica')," +
                "(N'Glavica')," +
                "(N'Glavičica')," +
                "(N'Glavnik')," +
                "(N'Glavotina')," +
                "(N'Gladno Selo')," +
                "(N'Glanica')," +
                "(N'Glasovik')," +
                "(N'Glašince')," +
                "(N'Gledić')," +
                "(N'Gleđica')," +
                "(N'Glibovac')," +
                "(N'Globare')," +
                "(N'Globare')," +
                "(N'Globoder')," +
                "(N'Globočica')," +
                "(N'Globočicaora')," +
                "(N'Glogovik')," +
                "(N'Glogovica')," +
                "(N'Glogovce')," +
                "(N'Glogonj')," +
                "(N'Glođane')," +
                "(N'Gložan')," +
                "(N'Gložane')," +
                "(N'Gložje')," +
                "(N'Glumač')," +
                "(N'Gluhavica')," +
                "(N'Glušci')," +
                "(N'Gmince')," +
                "(N'Gnila')," +
                "(N'Gnježdane')," +
                "(N'Gnjilan')," +
                "(N'Gnjilica')," +
                "(N'Gogolovce')," +
                "(N'Godance')," +
                "(N'Godačica')," +
                "(N'Goden')," +
                "(N'Godečevo')," +
                "(N'Godišnjak')," +
                "(N'Godljevo')," +
                "(N'Godovik')," +
                "(N'Godovo')," +
                "(N'Gojakovići')," +
                "(N'Gojbulja')," +
                "(N'Gojin Dol')," +
                "(N'Gojinovac')," +
                "(N'Gojmanovac')," +
                "(N'Gojnaora')," +
                "(N'Gokčanica')," +
                "(N'Golalava')," +
                "(N'Golema Njiva')," +
                "(N'Golemi Dol')," +
                "(N'Golemo Selo')," +
                "(N'Goleš')," +
                "(N'Goleško Vrelo')," +
                "(N'Golešnica')," +
                "(N'Goli Rid')," +
                "(N'Golice')," +
                "(N'Golobok')," +
                "(N'Golovo')," +
                "(N'Goločevac')," +
                "(N'Goločelo Koceljeva')," +
                "(N'Goločelo')," +
                "(N'Goluban')," +
                "(N'Golubinci')," +
                "(N'Golubinje')," +
                "(N'Golubovac')," +
                "(N'Goraždevac')," +
                "(N'Gorance')," +
                "(N'Goračevo')," +
                "(N'Goračići')," +
                "(N'Gorina')," +
                "(N'Gorić')," +
                "(N'Gorić')," +
                "(N'Goričani')," +
                "(N'Gorjani')," +
                "(N'Gornovac')," +
                "(N'Gornja Badanja')," +
                "(N'Gornja Bejašnica')," +
                "(N'Gornja Bela')," +
                "(N'Gornja Bela')," +
                "(N'Gornja Bitinja')," +
                "(N'Gornjaina')," +
                "(N'Gornja Bresnica')," +
                "(N'Gornja Brnjica')," +
                "(N'Gornja Budrika')," +
                "(N'Gornja Bukovica')," +
                "(N'Gornja Bunuša')," +
                "(N'Gornja Vranjska')," +
                "(N'Gornja Vrbava')," +
                "(N'Gornja Vrežina')," +
                "(N'Gornja Lama')," +
                "(N'Gornjao Gorevnica')," +
                "(N'Gornja Grabovica')," +
                "(N'Gornja Gušterica')," +
                "(N'Gornja Dobrinja')," +
                "(N'Gornja Draguša')," +
                "(N'Gornja Držina')," +
                "(N'Gornja')," +
                "(N'Gornja Zleginja')," +
                "(N'Gornja Jajina')," +
                "(N'Gornja Jošanica')," +
                "(N'Gornja Kamenica')," +
                "(N'Gornja Koviljača')," +
                "(N'Gornja Koznica')," +
                "(N'Gornja Konjuša')," +
                "(N'Gornja Koretica')," +
                "(N'Gornja Koritnica')," +
                "(N'Gornja Kravarica')," +
                "(N'Gornja Krušica')," +
                "(N'Gornja Kupinovica')," +
                "(N'Gornja Lapaštica')," +
                "(N'Gornja Lapaštica')," +
                "(N'Gornja Lisina')," +
                "(N'Gornja Lokošnica')," +
                "(N'Gornja Lomnica')," +
                "(N'Gornja Lopušnja')," +
                "(N'Gornja Luka')," +
                "(N'Gornja Ljubata')," +
                "(N'Gornja Ljuboviđa')," +
                "(N'Gornja Mikuljana')," +
                "(N'Gornja Mutnica')," +
                "(N'Gornja Nevlja')," +
                "(N'Mašnica')," +
                "(N'Gornja Orovica')," +
                "(N'Tulje')," +
                "(N'Gornja Pakaštica')," +
                "(N'Gornja Peščanica')," +
                "(N'Gornja Pološnica')," +
                "(N'Gornja Rapčaora')," +
                "(N'Gornja Rasovača')," +
                "(N'Gornja Rečica')," +
                "(N'Gornja Ržana')," +
                "(N'Gornja Rogatica')," +
                "(N'Gornja Sabanta')," +
                "(N'Gornja Sipulja')," +
                "(N'Gornja Slatina')," +
                "(N'Gornja Slatina')," +
                "(N'Gornja Sokolovica')," +
                "(N'Gornja Stražava')," +
                "(N'Gornja Stubla')," +
                "(N'Gornja Studena')," +
                "(N'Gornja Sudimlja')," +
                "(N'Gornja Toponica')," +
                "(N'Gornja Toponica')," +
                "(N'Gornja Trepča')," +
                "(N'Gornja Trešnjevica')," +
                "(N'Gornja Trešnjica')," +
                "(N'Gornja Trnava')," +
                "(N'Gornja Trnica')," +
                "(N'Gornja Tušimlja')," +
                "(N'Gornja Fuštica')," +
                "(N'Gornja Crnišava')," +
                "(N'Gornja Crnuća')," +
                "(N'Gornja Šatornja')," +
                "(N'Gornja Šipašnica')," +
                "(N'Gornja Šušaja')," +
                "(N'Gornjane')," +
                "(N'Gornje Babine')," +
                "(N'Gornje Brijanje')," +
                "(N'Gornje Varage')," +
                "(N'Gornje Vidovo')," +
                "(N'Gornje Vinarce')," +
                "(N'Gornje Vlase')," +
                "(N'Gornje Vranovce')," +
                "(N'Gornje Nerodimlje')," +
                "(N'Gornje Gare')," +
                "(N'Gornje Godance')," +
                "(N'Gornje Goračiće')," +
                "(N'Gornje Grbice')," +
                "(N'Gornje Grgure')," +
                "(N'Gornje Dobrevo')," +
                "(N'Gornje Dragovlje')," +
                "(N'Gornje Žabare')," +
                "(N'Gornje Žapsko')," +
                "(N'Gornje Zuniče')," +
                "(N'Gornje Jabukovo')," +
                "(N'Gornje Jarušice')," +
                "(N'Gornje Karačevo')," +
                "(N'Gornje Komarice')," +
                "(N'Gornje Konjuvce')," +
                "(N'Gornje Kordince')," +
                "(N'Gornje Korminjane')," +
                "(N'Gornje Košlje')," +
                "(N'Gornje Krajince')," +
                "(N'Gornje Krnjino')," +
                "(N'Gornje Kusce')," +
                "(N'Gornje Leviće')," +
                "(N'Gornje Leskovice')," +
                "(N'Gornje Lopiže')," +
                "(N'Gornje Ljubinje')," +
                "(N'Gornje Ljupče')," +
                "(N'Gornje Međurovo')," +
                "(N'Gornje Nedeljice')," +
                "(N'Gornje Nerodimlje')," +
                "(N'Gornje Novo Selo')," +
                "(N'Gornje Brijanje')," +
                "(N'Gornje Potočane')," +
                "(N'Gornje Prekaze')," +
                "(N'Gornje Punoševce')," +
                "(N'Gornje Rataje')," +
                "(N'Gornje Rašane')," +
                "(N'Gornje Romanovce')," +
                "(N'Gornje Svarče')," +
                "(N'Gornje Selo')," +
                "(N'Gornje Sinkovce')," +
                "(N'Gornje Slakovce')," +
                "(N'Gornje Stanovce')," +
                "(N'Gornje Stopanje')," +
                "(N'Gornje Suhotno')," +
                "(N'Gornje Tlamino')," +
                "(N'Gornje Točane')," +
                "(N'Gornje Trebešinje')," +
                "(N'Gornje Trnjane')," +
                "(N'Gornje Trudovo')," +
                "(N'Gornje Crnatovo')," +
                "(N'Gornje Crniljevosečina')," +
                "(N'Gornji Adrovac')," +
                "(N'Gornji Banjani')," +
                "(N'Gornji Barbeš')," +
                "(N'Gornji Branetići')," +
                "(N'Gornji Breg')," +
                "(N'Gornji Bunibrod')," +
                "(N'Gornji Bučumet')," +
                "(N'Gornji Vratari')," +
                "(N'Gornji Gajtan')," +
                "(N'Gornji Grabovac')," +
                "(N'Gornji Dejan')," +
                "(N'Gornji Dobrić')," +
                "(N'Gornji Drenovac')," +
                "(N'Gornji Dubac')," +
                "(N'Gornji Dubič')," +
                "(N'Gornji Dušnik')," +
                "(N'Gornji Zabelj')," +
                "(N'Gornji Jasenovik')," +
                "(N'Gornji Katun')," +
                "(N'Gornji Kozji Dol')," +
                "(N'Gornji Komren')," +
                "(N'Gornji Krivodol')," +
                "(N'Gornji Krnjin')," +
                "(N'Gornji Krstacora')," +
                "(N'Gornji Krupac')," +
                "(N'Gornji Krčin')," +
                "(N'Gornji Lajkovac')," +
                "(N'Gornji Livoč')," +
                "(N'Gornji Lipovac')," +
                "(N'Gornji Ljubeš')," +
                "(N'Gornji Makreš')," +
                "(N'Gornji Matejevac')," +
                "(N'Gornji Mušić')," +
                "(N'Gornji Neradovac')," +
                "(N'Gornji Obilić')," +
                "(N'Gornji Grad')," +
                "(N'Gornji Petrič')," +
                "(N'Gornji Prisjan')," +
                "(N'Gornji Ratiš')," +
                "(N'Gornji Račnik')," +
                "(N'Gornji Ribnik')," +
                "(N'Gornji Rinj')," +
                "(N'Gornji Svračak')," +
                "(N'Gornji Sibovac')," +
                "(N'Gornji Stajevac')," +
                "(N'Gornji Statovac')," +
                "(N'Gornji Stepoš')," +
                "(N'Gornji Stranjani')," +
                "(N'Gornji Streoc')," +
                "(N'Gornji Striževac')," +
                "(N'Gornji Strmac')," +
                "(N'Gornji Stupanj')," +
                "(N'Gornji Suvi Do')," +
                "(N'Gornji Tavankut')," +
                "(N'Gornji Crniš')," +
                "(N'Gornji Crnobreg')," +
                "(N'Gorobilje')," +
                "(N'Gorovič')," +
                "(N'Gorožup')," +
                "(N'Gorčince')," +
                "(N'Gospođince')," +
                "(N'Gospođinci')," +
                "(N'Gostilje')," +
                "(N'Gostinica')," +
                "(N'Gostiradiće')," +
                "(N'Gostun')," +
                "(N'Gostuša')," +
                "(N'Gotovuša')," +
                "(N'Goč')," +
                "(N'Goševo')," +
                "(N'Grab')," +
                "(N'Grabanica')," +
                "(N'Grabac')," +
                "(N'Grabovac')," +
                "(N'Grabovica')," +
                "(N'Grabovnica')," +
                "(N'Grabovo')," +   
                "(N'Grabovci')," +
                "(N'Grad')," +
                "(N'Grad Stalać')," +
                "(N'Gradac')," +
                "(N'Gradašnica')," +
                "(N'Gradinje')," +
                "(N'Gradica')," +
                "(N'Gradište')," +
                "(N'Gradnja')," +
                "(N'Gradojević')," +
                "(N'Gradska')," +
                "(N'Gradskovo')," +
                "(N'Građanoviće')," +
                "(N'Građenik')," +
                "(N'Graždanik')," +
                "(N'Grajevce')," +
                "(N'Gramada')," +
                "(N'Gramađe')," +
                "(N'Gramočelj')," +
                "(N'Granica')," +
                "(N'Granice')," +
                "(N'Graničane')," +
                "(N'Graovo')," +
                "(N'Grapa')," +
                "(N'Grace')," +
                "(N'Gračane')," +
                "(N'Gračanica')," +
                "(N'Gračac')," +
                "(N'Graševci')," +
                "(N'Graštica')," +
                "(N'Grbavce')," +
                "(N'Grbavče')," +
                "(N'Grgaje')," +
                "(N'Grgetek')," +
                "(N'Grgoc')," +
                "(N'Grgurevci')," +
                "(N'Grgurovce')," +
                "(N'Grdanica')," +
                "(N'Grdelica')," +
                "(N'Grdica')," +
                "(N'Grdovac')," +
                "(N'Grdovići')," +
                "(N'Grebenac')," +
                "(N'Grebnik')," +
                "(N'Grebno')," +
                "(N'Grevci')," +
                "(N'Gredetin')," +
                "(N'Grezna')," +
                "(N'Grejač')," +
                "(N'Grejkovce')," +
                "(N'Grejčevce')," +
                "(N'Grivac')," +
                "(N'Grivska')," +
                "(N'Grižani')," +
                "(N'Grizime')," +
                "(N'Grkaje')," +
                "(N'Grkinja')," +
                "(N'Grkljane')," +
                "(N'Grlica')," +
                "(N'Grlište')," +
                "(N'Grljan')," +
                "(N'Grmovo')," +
                "(N'Grnčar')," +
                "(N'Grnčar')," +
                "(N'Grnčara')," +
                "(N'Grnčare')," +
                "(N'Grobnice')," +
                "(N'Groznatovci')," +
                "(N'Grocka')," +
                "(N'Grošnica')," +
                "(N'Grubetiće')," +
                "(N'Grudaš')," +
                "(N'Gruža')," +
                "(N'Grujinci')," +
                "(N'Grušić')," +
                "(N'Grčak')," +
                "(N'Grčac')," +
                "(N'Grčina')," +
                "(N'Grčić')," +
                "(N'Gubavce')," +
                "(N'Guberevac')," +
                "(N'Gubetin')," +
                "(N'Gubin Do')," +
                "(N'Guvnište')," +
                "(N'Guvno Selo')," +
                "(N'Gugalj')," +
                "(N'Gudurica')," +
                "(N'Gujiće')," +
                "(N'Gukoš')," +
                "(N'Gulenovci')," +
                "(N'Gulijan')," +
                "(N'Gulije')," +
                "(N'Gumerište')," +
                "(N'Gumnište')," +
                "(N'Gunaroš')," +
                "(N'Guncat')," +
                "(N'Guncatijevo')," +
                "(N'Guncati')," +
                "(N'Gunjaci')," +
                "(N'Gunjevac')," +
                "(N'Gunjetina')," +
                "(N'Gunjica')," +
                "(N'Gurgutovo')," +
                "(N'Gurdijelje')," +
                "(N'Guriševci')," +
                "(N'Guska')," +
                "(N'Guceviće')," +
                "(N'Guča')," +
                "(N'Gušavac')," +
                "(N'Gušica')," +
                "(N'Dabinovac')," +
                "(N'Dabiševac')," +
                "(N'Davidovac')," +
                "(N'Davidovica')," +
                "(N'Davidovce')," +
                "(N'Dadince')," +
                "(N'Daždince')," +
                "(N'Dajići')," +
                "(N'Dajkovce')," +
                "(N'Dalašaj')," +
                "(N'Damjane')," +
                "(N'Dankoviće')," +
                "(N'Danjane')," +
                "(N'Danjino Selo')," +
                "(N'Darkovce')," +
                "(N'Darosava')," +
                "(N'Dašinovac')," +
                "(N'Dašnica')," +
                "(N'Dvorane')," +
                "(N'Dvorica')," +
                "(N'Dvorište')," +
                "(N'Dvorska')," +
                "(N'Debelde')," +
                "(N'Debeli Lug')," +
                "(N'Debelica')," +
                "(N'Debelja')," +
                "(N'Debeljača')," +
                "(N'Debrc')," +
                "(N'Deva')," +
                "(N'Devaja')," +
                "(N'Devet Jugovića')," +
                "(N'Devetak')," +
                "(N'Deveti maj')," +
                "(N'Devići')," +
                "(N'Devreč')," +
                "(N'Devča')," +
                "(N'Degrmen')," +
                "(N'Degurić')," +
                "(N'Dedaj')," +
                "(N'Dedevci')," +
                "(N'Dedina')," +
                "(N'Dedinac')," +
                "(N'Dedinje')," +
                "(N'Deževa')," +
                "(N'Deič')," +
                "(N'Dejanovac')," +
                "(N'Dejance')," +
                "(N'Dekutince')," +
                "(N'Deliblato')," +
                "(N'Deligrad')," +
                "(N'Delimeđe')," +
                "(N'Delovce')," +
                "(N'Deonica')," +
                "(N'Depce')," +
                "(N'Deretin')," +
                "(N'Deronjedžaci')," +
                "(N'Desetak')," +
                "(N'Desivojce')," +
                "(N'Desimirovac')," +
                "(N'Desine')," +
                "(N'Desić')," +
                "(N'Despotovac')," +
                "(N'Despotovo')," +
                "(N'Detane')," +
                "(N'Dečinci')," +
                "(N'Dečane')," +
                "(N'Dešilovo')," +
                "(N'Dešiška')," +
                "(N'Divljaka')," +
                "(N'Divljana')," +
                "(N'Divostin')," +
                "(N'Divoš')," +
                "(N'Divci')," +
                "(N'Divčibare')," +
                "(N'Dikava')," +
                "(N'Dikanceora')," +
                "(N'Dimitrovgrad')," +
                "(N'Dimce')," +
                "(N'Dići')," +
                "(N'Dljin')," +
                "(N'Dobanovci')," +
                "(N'Doblibare')," +
                "(N'Dobra')," +
                "(N'Dobra Voda')," +
                "(N'Dobra Luka')," +
                "(N'Dobrava')," +
                "(N'Dobrača')," +
                "(N'Dobrejance')," +
                "(N'Dobri Do')," +
                "(N'Dobri Dol')," +
                "(N'Dobri Dub')," +
                "(N'Dobri Dub')," +
                "(N'Dobrilovići')," +
                "(N'Dobrinci')," +
                "(N'Dobrinje')," +
                "(N'Dobrić')," +
                "(N'Dobrica')," +
                "(N'Dobričevo')," +
                "(N'Dobrnje')," +
                "(N'Dobro Polje')," +
                "(N'Dobroviš')," +
                "(N'Dobrovodica')," +
                "(N'Dobrodeljane')," +
                "(N'Dobrodo')," +
                "(N'Dobrodol')," +
                "(N'Dobroljubci')," +
                "(N'Dobromir')," +
                "(N'Dobroselica')," +
                "(N'Dobrosin')," +
                "(N'Dobrotić')," +
                "(N'Dobroš')," +
                "(N'Dobroševac')," +
                "(N'Dobroševina')," +
                "(N'Dobrujevac')," +
                "(N'Dobruša')," +
                "(N'Dobrušte')," +
                "(N'Dobrčane')," +
                "(N'Doganica')," +
                "(N'Doganović')," +
                "(N'Doganjevo')," +
                "(N'Dojinoviće')," +
                "(N'Dojkinci')," +
                "(N'Dojnice')," +
                "(N'Dokmir')," +
                "(N'Dol')," +
                "(N'Dolac')," +
                "(N'Doline')," +
                "(N'Doliće')," +
                "(N'Dolovo')," +
                "(N'Dolj')," +
                "(N'Doljak')," +
                "(N'Doljane')," +
                "(N'Doljani')," +
                "(N'Doljašnica')," +
                "(N'Doljevac')," +
                "(N'Domanek')," +
                "(N'Domiševina')," +
                "(N'Domorovce')," +
                "(N'Donja Badanja')," +
                "(N'Donja Bejašnica')," +
                "(N'Donja Bela')," +
                "(N'Donja Bitinja')," +
                "(N'Donja Bresnica')," +
                "(N'Donja Brnjica')," +
                "(N'Donja Budriga')," +
                "(N'Donja Bukovica')," +
                "(N'Donja Bunuša')," +
                "(N'Donja Vrbava')," +
                "(N'Donja Vrežina')," +
                "(N'Donja Gorevnica')," +
                "(N'Donja Gušterica')," +
                "(N'Donja Dobrinja')," +
                "(N'Donja Draguša')," +
                "(N'Donja Zleginja')," +
                "(N'Donja Jajina')," +
                "(N'Donja Jošanica')," +
                "(N'Donja Kamenica')," +
                "(N'Donja Konjuša')," +
                "(N'Donja Koretica')," +
                "(N'Donja Koritnica')," +
                "(N'Donja Kravarica')," +
                "(N'Donja Kruševica')," +
                "(N'Donja Krušica')," +
                "(N'Donja Kupinovica')," +
                "(N'Donja Lapaštica')," +
                "(N'Donja Lapaštica')," +
                "(N'Donja Livadica')," +
                "(N'Donja Lisina')," +
                "(N'Donja Lokošnica')," +
                "(N'Donja Lomnica')," +
                "(N'Donja Lopušnja')," +
                "(N'Donja Luka')," +
                "(N'Donja Ljubata')," +
                "(N'Donja Ljuboviđa')," +
                "(N'Donja Mikuljana')," +
                "(N'Donja Mutnica')," +
                "(N'Donja Nevlja')," +
                "(N'Donja Grabovica')," +
                "(N'Donja Pakaštica')," +
                "(N'Donja Peščanica')," +
                "(N'Donja Pološnica')," +
                "(N'Donja Rapčaora')," +
                "(N'Donja Rasovača')," +
                "(N'Donja Rašica')," +
                "(N'Donja Rečica')," +
                "(N'Donja Ržana')," +
                "(N'Donja Sabanta')," +
                "(N'Donja Sipulja')," +
                "(N'Donja Slatina')," +
                "(N'Donja Slatina')," +
                "(N'Donja Sokolovica')," +
                "(N'Donja Stražava')," +
                "(N'Donja Stubla')," +
                "(N'Donja Studena')," +
                "(N'Donja Sudimlja')," +
                "(N'Donja Toponica')," +
                "(N'Donja Toponica')," +
                "(N'Donja Trepča')," +
                "(N'Donja Trešnjevica')," +
                "(N'Donja Trešnjica')," +
                "(N'Donja Trnava')," +
                "(N'Donja Trnica')," +
                "(N'Donja Fuštica')," +
                "(N'Donja Crnišava')," +
                "(N'Donja Crnuća')," +
                "(N'Donja Šatornja')," +
                "(N'Donja Šipašnica')," +
                "(N'Donja Šušaja')," +
                "(N'Donje Babine')," +
                "(N'Donje Brijanje')," +
                "(N'Donje Varage')," +
                "(N'Donje Vidovo')," +
                "(N'Donje Vinarce')," +
                "(N'Donje Vlase')," +
                "(N'Donje Vranovce')," +
                "(N'Donje Nerodimlje')," +
                "(N'Donje Gare')," +
                "(N'Donje Godance')," +
                "(N'Donje Goračiće')," +
                "(N'Donje Grbice')," +
                "(N'Donje Grgure')," +
                "(N'Donje Dobrevo')," +
                "(N'Donje Dragovlje')," +
                "(N'Donje Žabare')," +
                "(N'Donje Žapsko')," +
                "(N'Donje Zuniče')," +
                "(N'Donje Isevo')," +
                "(N'Donje Jabukovo')," +
                "(N'Donje Jarušice')," +
                "(N'Donje Karačevo')," +
                "(N'Donje Komarice')," +
                "(N'Donje Konjuvce')," +
                "(N'Donje Kordince')," +
                "(N'Donje Korminjane')," +
                "(N'Donje Krajince')," +
                "(N'Donje Krnjino')," +
                "(N'Donje Leviće')," +
                "(N'Donje Leskovice')," +
                "(N'Donje Lopiže')," +
                "(N'Donje Ljubinje')," +
                "(N'Donje Ljupče')," +
                "(N'Donje Međurovo')," +
                "(N'Donje Nedeljice')," +
                "(N'Donje Nerodimlje')," +
                "(N'Donje Novo Selo')," +
                "(N'Donje Brijanje')," +
                "(N'Donje Potočane')," +
                "(N'Donje Prekaze')," +
                "(N'Donje Punoševce')," +
                "(N'Donje Ramnjane')," +
                "(N'Donje Rataje')," +
                "(N'Donje Rašane')," +
                "(N'Donje Romanovce')," +
                "(N'Donje Svarče')," +
                "(N'Donje Sinkovce')," +
                "(N'Donje Slakovce')," +
                "(N'Donje Stanovce')," +
                "(N'Donje Stopanje')," +
                "(N'Donje Suhotno')," +
                "(N'Donje Tlamino')," +
                "(N'Donje Točane')," +
                "(N'Donje Trebešinje')," +
                "(N'Donje Trnjane')," +
                "(N'Donje Crnatovo')," +
                "(N'Donje Crniljevo')," +
                "(N'Donji Adrovac')," +
                "(N'Donji Banjani')," +
                "(N'Donji Barbeš')," +
                "(N'Donji Biteš')," +
                "(N'Donji Branetići')," +
                "(N'Donji Bunibrod')," +
                "(N'Donji Bučumet')," +
                "(N'Donji Vratari')," +
                "(N'Donji Gajtan')," +
                "(N'Donji Grabovac')," +
                "(N'Donji Dejan')," +
                "(N'Donji Dobrić')," +
                "(N'Donji Drenovac')," +
                "(N'Donji DuBač')," +
                "(N'Donji Dubič')," +
                "(N'Donji Dušnik')," +
                "(N'Donji Zabelj')," +
                "(N'Donji Jasenovik')," +
                "(N'Donji Katun')," +
                "(N'Donji Kozji Dol')," +
                "(N'Donji Komren')," +
                "(N'Donji Krivodol')," +
                "(N'Donji Krnjin')," +
                "(N'Donji Krstacora')," +
                "(N'Donji Krupac')," +
                "(N'Donji Krčin')," +
                "(N'Donji Livoč')," +
                "(N'Donji Lipovac')," +
                "(N'Donji Ljubeš')," +
                "(N'Donji Makreš')," +
                "(N'Donji Matejevac')," +
                "(N'Donji Milanovac')," +
                "(N'Donji Mušić')," +
                "(N'Donji Neradovac')," +
                "(N'Donji Obilić')," +
                "(N'Donji Petrič')," +
                "(N'Donji Petrovci')," +
                "(N'Donji Prisjan')," +
                "(N'Donji Ratiš')," +
                "(N'Donji Račnik')," +
                "(N'Donji Ribnik')," +
                "(N'Donji Rinj')," +
                "(N'Donji Svračak')," +
                "(N'Donji Sibovac')," +
                "(N'Donji Stajevac')," +
                "(N'Donji Statovac')," +
                "(N'Donji Stepoš')," +
                "(N'Donji Stranjani')," +
                "(N'Donji Streoc')," +
                "(N'Donji Striževac')");
                  migrationBuilder.Sql(
                "insert into Mesta(NazivMesta) values " +
                "(N'Donji Stupanj')," +
                "(N'Donji Suvi Do')," +
                "(N'Donji Tavankut')," +
                "(N'Donji Tovarnikinci')," +
                "(N'Donji Crnobreg')," +
                "(N'Doroslovo')," +
                "(N'Doševac')," +
                "(N'Draga')," +
                "(N'Dragaljice')," +
                "(N'Draganac')," +
                "(N'Draganići')," +
                "(N'Dragašora')," +
                "(N'Dragi Deo')," +
                "(N'Dragijevica')," +
                "(N'Draginac')," +
                "(N'Draginje')," +
                "(N'Draglica')," +
                "(N'Dragobilje')," +
                "(N'Dragobraća')," +
                "(N'Dragobužde')," +
                "(N'Dragovac')," +
                "(N'Dragovita')," +
                "(N'Dragovo')," +
                "(N'Dragodol')," +
                "(N'Dragojevac')," +
                "(N'Dragojevac')," +
                "(N'Dragojloviće')," +
                "(N'Dragolj')," +
                "(N'Dragoljevac')," +
                "(N'Dragosinjci')," +
                "(N'Dragocvet')," +
                "(N'Dragočevo')," +
                "(N'Dragoševac')," +
                "(N'Dragušica')," +
                "(N'Dražanj')," +
                "(N'Draževac')," +
                "(N'Draževac')," +
                "(N'Draževiće')," +
                "(N'Draževići')," +
                "(N'Draževo')," +
                "(N'Dražiniće')," +
                "(N'Dražinovići')," +
                "(N'Dražmirovac')," +
                "(N'Drainoviće')," +
                "(N'Drajinac')," +
                "(N'Drajinci')," +
                "(N'Drajkovce')," +
                "(N'Drajčići')," +
                "(N'Draksin')," +
                "(N'Drakčići')," +
                "(N'Dramiće')," +
                "(N'Dramnjak')," +
                "(N'Drača')," +
                "(N'Dračić')," +
                "(N'Draškovac')," +
                "(N'Drvare')," +
                "(N'Drvnik')," +
                "(N'Drvodelj')," +
                "(N'Drvodelja')," +
                "(N'Drežnik')," +
                "(N'Drežnica')," +
                "(N'Drelje')," +
                "(N'Dren')," +
                "(N'Drenova')," +
                "(N'Drenovalava')," +
                "(N'Drenovac')," +
                "(N'Drenovce')," +
                "(N'Drenovci')," +
                "(N'Drenovčić')," +
                "(N'Drence')," +
                "(N'Drenča')," +
                "(N'Drenje')," +
                "(N'Drečinovac')," +
                "(N'Drešnica')," +
                "(N'Držanovac')," +
                "(N'Držina')," +
                "(N'Drijetanj')," +
                "(N'Drlače')," +
                "(N'Drlupa')," +
                "(N'Drlupa')," +
                "(N'Drmanovići')," +
                "(N'Drmno')," +
                "(N'Drobeš')," +
                "(N'Drobnjak')," +
                "(N'Drsnik')," +
                "(N'Drtevci')," +
                "(N'Drćevac')," +
                "(N'Drugovac')," +
                "(N'Družetić Koceljeva')," +
                "(N'Družetići')," +
                "(N'Družiniće')," +
                "(N'Dub')," +
                "(N'Dublje')," +
                "(N'Dubnica')," +
                "(N'Dubovac')," +
                "(N'Dubovo')," +
                "(N'Duboka')," +
                "(N'Duboko')," +
                "(N'Dubona')," +
                "(N'Dubočak')," +
                "(N'Dubočane')," +
                "(N'Dubočka')," +
                "(N'Dubrava')," +
                "(N'Dubravica')," +
                "(N'Duvanište')," +
                "(N'Duga')," +
                "(N'Duga Luka')," +
                "(N'Duga Poljana')," +
                "(N'Duga Poljana')," +
                "(N'Duganjive')," +
                "(N'Dugi Del')," +
                "(N'Dugo Polje')," +
                "(N'Dugojnica')," +
                "(N'Dugonjive')," +
                "(N'Dudovica')," +
                "(N'Dudulajce')," +
                "(N'Dužine')," +
                "(N'Dužnje')," +
                "(N'Duz')," +
                "(N'Dujak')," +
                "(N'Dujke')," +
                "(N'Dukat')," +
                "(N'Dulan')," +
                "(N'Dulebe')," +
                "(N'Dulene')," +
                "(N'Dulje')," +
                "(N'Dumbija')," +
                "(N'Dumoš')," +
                "(N'Dunavac')," +
                "(N'Dunavo')," +
                "(N'Dunišiće')," +
                "(N'Dupeljevo')," +
                "(N'Dupljaj')," +
                "(N'Dupljaja')," +
                "(N'Dupljane')," +
                "(N'Dupci')," +
                "(N'Dura')," +
                "(N'Dučalovići')," +
                "(N'Dučevac')," +
                "(N'Dučina')," +
                "(N'Dučić')," +
                "(N'Duš')," +
                "(N'Dušanovac')," +
                "(N'Dušanovo')," +
                "(N'Dušević')," +
                "(N'Duškovci')," +
                "(N'Dušmanić')," +
                "(N'Dušmanići')," +
                "(N'Đake')," +
                "(N'Đakovica')," +
                "(N'Đakovo')," +
                "(N'Đakus')," +
                "(N'Đala')," +
                "(N'Đelekare')," +
                "(N'Đeneral Janković')," +
                "(N'Đerađ')," +
                "(N'Đerekare')," +
                "(N'Đerekarce')," +
                "(N'Đinđuša')," +
                "(N'Đinovce')," +
                "(N'Đonaj')," +
                "(N'Đorđevac')," +
                "(N'Đocaj')," +
                "(N'Đulekare')," +
                "(N'Đunis')," +
                "(N'Đurakovac')," +
                "(N'Đurakovo')," +
                "(N'Đurašići')," +
                "(N'Đurđev Dol')," +
                "(N'Đurđevac')," +
                "(N'Đurđevo')," +
                "(N'Đurđevo Žabalj')," +
                "(N'Đurđin')," +
                "(N'Đurevac')," +
                "(N'Đurinac')," +
                "(N'Đurinci')," +
                "(N'Đuriselo')," +
                "(N'Đuriševce')," +
                "(N'Đurkovce')," +
                "(N'Đurovac')," +
                "(N'Đušnica')," +
                "(N'Eleza')," +
                "(N'Elemir')," +
                "(N'Ence')," +
                "(N'Ervenice')," +
                "(N'Erdevik')," +
                "(N'Erdeč')," +
                "(N'Ereč')," +
                "(N'Erčege')," +
                "(N'Ečka')," +
                "(N'Žabalj')," +
                "(N'Žabar')," +
                "(N'Žabare')," +
                "(N'Žabari')," +
                "(N'Žabelj')," +
                "(N'Žabljane')," +
                "(N'Žabren')," +
                "(N'Žagubica')," +
                "(N'Žaža')," +
                "(N'Žakovo')," +
                "(N'Žalica')," +
                "(N'Žaočani')," +
                "(N'Žarevo')," +
                "(N'Žarevo')," +
                "(N'Žarkovac')," +
                "(N'Žač')," +
                "(N'Žbevac')," +
                "(N'Ždeglovo')," +
                "(N'Ždrelo')," +
                "(N'Ždrelo')," +
                "(N'Žegovac')," +
                "(N'Žegovačka Vrbica')," +
                "(N'Žegra')," +
                "(N'Žegrova')," +
                "(N'Željevo')," +
                "(N'Željine')," +
                "(N'Željuša')," +
                "(N'Žeravino')," +
                "(N'Žerađe')," +
                "(N'Žerovnica')," +
                "(N'Živinice')," +
                "(N'Živinjane')," +
                "(N'Živica')," +
                "(N'Živica')," +
                "(N'Živkovac')," +
                "(N'Živkovo')," +
                "(N'Živkovci')," +
                "(N'Židilje')," +
                "(N'Žižavica')," +
                "(N'Žilivoda')," +
                "(N'Žilinci')," +
                "(N'Žiljci')," +
                "(N'Žirovnica')," +
                "(N'Žirče')," +
                "(N'Žitinje')," +
                "(N'Žitinje')," +
                "(N'Žitište')," +
                "(N'Žitkovac')," +
                "(N'Žitkovac')," +
                "(N'Žitkovica')," +
                "(N'Žitni Potok')," +
                "(N'Žitniće')," +
                "(N'Žitorađa')," +
                "(N'Žitorađe')," +
                "(N'Žiča')," +
                "(N'Žlne')," +
                "(N'Žub')," +
                "(N'Žuželjica')," +
                "(N'Žuja')," +
                "(N'Žujince')," +
                "(N'Žukovac')," +
                "(N'Žunje')," +
                "(N'Žunje')," +
                "(N'Žunjeviće')," +
                "(N'Župa')," +
                "(N'Županjac')," +
                "(N'Županjevac')," +
                "(N'Žur')," +
                "(N'Žutice')," +
                "(N'Žuč')," +
                "(N'Žuče')," +
                "(N'Žučkovac')," +
                "(N'Zablaće')," +
                "(N'Zabojnica')," +
                "(N'Zabrdica')," +
                "(N'Zabrdnji Toci')," +
                "(N'Zabrđe')," +
                "(N'Zabrega')," +
                "(N'Zabrežje')," +
                "(N'Zabrnjica')," +
                "(N'Zavidince')," +
                "(N'Zavinograđe')," +
                "(N'Zavlaka')," +
                "(N'Zavrata')," +
                "(N'Zagajica')," +
                "(N'Zaglavak')," +
                "(N'Zagorica')," +
                "(N'Zagorje')," +
                "(N'Zagradina')," +
                "(N'Zagrađe')," +
                "(N'Zagrmlje')," +
                "(N'Zagužane')," +
                "(N'Zagužanje')," +
                "(N'Zagulj')," +
                "(N'Zajača')," +
                "(N'Zaječar')," +
                "(N'Zaječiće')," +
                "(N'Zajmovo')," +
                "(N'Zajčevce')," +
                "(N'Zaklopača')," +
                "(N'Zaklopača')," +
                "(N'Zakut')," +
                "(N'Zakuta')," +
                "(N'Zalug')," +
                "(N'Zalužnje')," +
                "(N'Zamčanje')," +
                "(N'Zaovine')," +
                "(N'Zaostro')," +
                "(N'Zapadni Mojstir')," +
                "(N'Zaplužje')," +
                "(N'Zarbince')," +
                "(N'Zarevo')," +
                "(N'Zarožje')," +
                "(N'Zarube')," +
                "(N'Zasavica I')," +
                "(N'Zasavica II')," +
                "(N'Zasad')," +
                "(N'Zasela')," +
                "(N'Zaselje')," +
                "(N'Zaskovci')," +
                "(N'Zaskok')," +
                "(N'Zastup')," +
                "(N'Zatonje')," +
                "(N'Zatrić')," +
                "(N'Zaugline')," +
                "(N'Zahać')," +
                "(N'Zahumsko')," +
                "(N'Zbojštica')," +
                "(N'Zborce')," +
                "(N'Zvezd')," +
                "(N'Zvezdan')," +
                "(N'Zvečan')," +
                "(N'Zvečka')," +
                "(N'Zvizdar')," +
                "(N'Zvijezd')," +
                "(N'Zvonce')," +
                "(N'Zgatar')," +
                "(N'Zdravinje')," +
                "(N'Zdravčići')," +
                "(N'Zebince')," +
                "(N'Zebica')," +
                "(N'Zelenik')," +
                "(N'Zeletovo')," +
                "(N'Zemanica')," +
                "(N'Zeoke')," +
                "(N'Zečeviće')," +
                "(N'Zijača')," +
                "(N'Zjumpoljski')," +
                "(N'Zjum Has')," +
                "(N'Zladovac')," +
                "(N'Zladovce')," +
                "(N'Zlakusa')," +
                "(N'Zlata')," +
                "(N'Zlatance')," +
                "(N'Zlatare')," +
                "(N'Zlatari')," +
                "(N'Zlatarić')," +
                "(N'Zlatibor')," +
                "(N'Zlatićevo')," +
                "(N'Zlatovo')," +
                "(N'Zlatokop')," +
                "(N'Zli Dol')," +
                "(N'Zli Potokora')," +
                "(N'Zlodol')," +
                "(N'Zlokućane')," +
                "(N'Zlopek')," +
                "(N'Zlot')," +
                "(N'Zloćudovo')," +
                "(N'Zmajevo Vrbas')," +
                "(N'Zminjak')," +
                "(N'Zobnatica')," +
                "(N'Zojić')," +
                "(N'Zoljevo')," +
                "(N'Zorovac')," +
                "(N'Zorunovac')," +
                "(N'Zočište')," +
                "(N'Zrenjanin')," +
                "(N'Zrze')," +
                "(N'Zrnosek')," +
                "(N'Zubetinac')," +
                "(N'Zubin Potok')," +
                "(N'Zubovac')," +
                "(N'Zukve Koceljeva')," +
                "(N'Zulfaj')," +
                "(N'Zupče')," +
                "(N'Zuce')," +
                "(N'Ibarsko Postenje')," +
                "(N'Ivaja')," +
                "(N'Ivan Kula')," +
                "(N'Ivankovac')," +
                "(N'Ivanovo')," +
                "(N'Ivanovci')," +
                "(N'Ivanča')," +
                "(N'Ivanje')," +
                "(N'Ivanjica')," +
                "(N'Ivezići')," +
                "(N'Ivkovački Prnjavor')," +
                "(N'Iglarevo')," +
                "(N'Igrište')," +
                "(N'Igrište')," +
                "(N'Igroš')," +
                "(N'Idvor')," +
                "(N'Iđoš')," +
                "(N'Ižance')," +
                "(N'Izatovci')," +
                "(N'Izbenica')," +
                "(N'Izbica')," +
                "(N'Izbice')," +
                "(N'Izbičanj')," +
                "(N'Izbište')," +
                "(N'Izvarica')," +
                "(N'Izvor')," +
                "(N'Izvori')," +
                "(N'Izrok')," +
                "(N'Izumno')," +
                "(N'Ilandža')," +
                "(N'Ilino')," +
                "(N'Ilince')," +
                "(N'Ilinci')," +
                "(N'Inatovce')," +
                "(N'Inđija')," +
                "(N'Inovo')," +
                "(N'Irig')," +
                "(N'Iričići')," +
                "(N'Isakovo')," +
                "(N'Iskrovci')," +
                "(N'Istinić')," +
                "(N'Istok')," +
                "(N'Istočni Mojstir')," +
                "(N'Jablanica')," +
                "(N'Jablanka')," +
                "(N'Jabuka')," +
                "(N'Jabukovac')," +
                "(N'Jabukovik')," +
                "(N'Jabučevo')," +
                "(N'Jabučje')," +
                "(N'Javor')," +
                "(N'Javor')," +
                "(N'Javorje')," +
                "(N'Javorska Ravna Gora')," +
                "(N'Jagličje')," +
                "(N'Jagnjenica')," +
                "(N'Jagnjilo')," +
                "(N'Jagoda')," +
                "(N'Jagodina')," +
                "(N'Jagoštica')," +
                "(N'Jadranska Lešnica')," +
                "(N'Jažince')," +
                "(N'Jazak')," +
                "(N'Jazovik')," +
                "(N'Jazovnik')," +
                "(N'Jazovo')," +
                "(N'Jajčić')," +
                "(N'Jakalj')," +
                "(N'Jakovac')," +
                "(N'Jakovlje')," +
                "(N'Jakovljevo')," +
                "(N'Jakovo')," +
                "(N'Jalbotina')," +
                "(N'Jalovik')," +
                "(N'Jalovik Izvor')," +
                "(N'Jamena')," +
                "(N'Jankov Most')," +
                "(N'Jankov Potok')," +
                "(N'Janoš')," +
                "(N'Janošik')," +
                "(N'Janča')," +
                "(N'Jančići')," +
                "(N'Jančište')," +
                "(N'Janja')," +
                "(N'Janjevo')," +
                "(N'Jarak')," +
                "(N'Jarebice')," +
                "(N'Jarešnik')," +
                "(N'Jarinje')," +
                "(N'Jarkovac')," +
                "(N'Jarkovci')," +
                "(N'Jarmenovci')," +
                "(N'Jarsenovo')," +
                "(N'Jarčujak')," +
                "(N'Jasenak')," +
                "(N'Jasenica')," +
                "(N'Jasenov Del')," +
                "(N'Jasenovik')," +
                "(N'Jasenovik')," +
                "(N'Jasenovo')," +
                "(N'Jasenje')," +
                "(N'Jasika')," +
                "(N'Jasikovica')," +
                "(N'Jasikovo')," +
                "(N'Jasić')," +
                "(N'Jastreba')," +
                "(N'Jahoc')," +
                "(N'Jaša Tomić')," +
                "(N'Jašunja')," +
                "(N'Jevik')," +
                "(N'Jevremovac')," +
                "(N'Ježevica')," +
                "(N'Jezgroviće')," +
                "(N'Jezdina')," +
                "(N'Jezero')," +
                "(N'Jezerce')," +
                "(N'Jelav')," +
                "(N'Jelakce')," +
                "(N'Jelakci')," +
                "(N'Jelača')," +
                "(N'Jelašnica')," +
                "(N'Jelen Do')," +
                "(N'Jelenac')," +
                "(N'Jelenča')," +
                "(N'Jeliće')," +
                "(N'Jelovac')," +
                "(N'Jelovik')," +
                "(N'Jelovica')," +
                "(N'Jerli Prelez')," +
                "(N'Jerli Sadovina')," +
                "(N'Jerli Talinovac')," +
                "(N'Jermenovci')," +
                "(N'Ješkovo')," +
                "(N'Jova')," +
                "(N'Jovanovac')," +
                "(N'Jovanovce')," +
                "(N'Jovanja')," +
                "(N'Jovac')," +
                "(N'Jovine Livade')," +
                "(N'Jović')," +
                "(N'Jošanica')," +
                "(N'Jošanička Banja')," +
                "(N'Jošanički Prnjavor')," +
                "(N'Joševa')," +
                "(N'Joševik')," +
                "(N'Jošje')," +
                "(N'Jug Bogdanovac')," +
                "(N'Jugovac')," +
                "(N'Jugovići')," +
                "(N'Južni')," +
                "(N'Junake')," +
                "(N'Junik')," +
                "(N'Junkovac')," +
                "(N'Junčevići')," +
                "(N'Kabaš')," +
                "(N'Kabaš')," +
                "(N'Kabaš Has')," +
                "(N'Kavadar')," +
                "(N'Kavilo')," +
                "(N'Kadina Luka')," +
                "(N'Kaznoviće')," +
                "(N'Kajkovo')," +
                "(N'Kajtasovo')," +
                "(N'Kalabovce')," +
                "(N'Kalanjevci')," +
                "(N'Kalafati')," +
                "(N'Kalenić')," +
                "(N'Kalenići')," +
                "(N'Kalenićki Prnjavor')," +
                "(N'Kalenovac')," +
                "(N'Kaletinac')," +
                "(N'Kalimanići')," +
                "(N'Kalimance')," +
                "(N'Kalinovac')," +
                "(N'Kalipolje')," +
                "(N'Kaličane')," +
                "(N'Kaličina')," +
                "(N'Kalište')," +
                "(N'Kalna')," +
                "(N'Kalovo')," +
                "(N'Kaludra')," +
                "(N'Kaluđerevo')," +
                "(N'Kaluđerica')," +
                "(N'Kaluđerovići')," +
                "(N'Kaluđerovo')," +
                "(N'Kaluđerce')," +
                "(N'Kaljatica')," +
                "(N'Kambelevac')," +
                "(N'Kamenalava')," +
                "(N'Kamena Gora')," +
                "(N'Kamenare')," +
                "(N'Kamendol')," +
                "(N'Kamenica')," +
                "(N'Kamenovo')," +
                "(N'Kamenjani')," +
                "(N'Kamenjača')," +
                "(N'Kamešnica')," +
                "(N'Kamijevo')," +
                "(N'Kamik')," +
                "(N'Kandalica')," +
                "(N'Kanjevina')," +
                "(N'Kanjiža')," +
                "(N'Kaona')," +
                "(N'Kaonik')," +
                "(N'Kapit')," +
                "(N'Kapidžija')," +
                "(N'Kapra')," +
                "(N'Karavukovodžaci')," +
                "(N'Karadak')," +
                "(N'Karadnik')," +
                "(N'Karađorđevac')," +
                "(N'Karađorđevo')," +
                "(N'Karajukića Bunari')," +
                "(N'Karamanica')," +
                "(N'Karan')," +
                "(N'Karanovac')," +
                "(N'Karaula')," +
                "(N'Karače')," +
                "(N'Karačica')," +
                "(N'Karašinđerđ')," +
                "(N'Karbulovo')," +
                "(N'Kare')," +
                "(N'Karlovčićinci')," +
                "(N'Karoševina')," +
                "(N'Kasidol')," +
                "(N'Kasidoli')," +
                "(N'Kastrat')," +
                "(N'Katići')," +
                "(N'Katrga')," +
                "(N'Katun')," +
                "(N'Katun')," +
                "(N'Kać')," +
                "(N'Kaćevo')," +
                "(N'Kacabać')," +
                "(N'Kacapun')," +
                "(N'Kačandol')," +
                "(N'Kačanik')," +
                "(N'Kačapor')," +
                "(N'Kačarevo')," +
                "(N'Kačer')," +
                "(N'Kačibeg')," +
                "(N'Kačikol')," +
                "(N'Kačulice')," +
                "(N'Kašalj')," +
                "(N'Kaševar')," +
                "(N'Kašica')," +
                "(N'Kašice')," +
                "(N'Kaštavar')," +
                "(N'Kevi')," +
                "(N'Kelebija')," +
                "(N'Keserovina')," +
                "(N'Kijevac')," +
                "(N'Kijevo')," +
                "(N'Kijevce')," +
                "(N'Kijevci')," +
                "(N'Kijevčiće')," +
                "(N'Kikinda')," +
                "(N'Kikojevac')," +
                "(N'Kisač')," +
                "(N'Kisela Banja')," +
                "(N'Kisiljevo')," +
                "(N'Kišna')," +
                "(N'Kišno Polje')," +
                "(N'Kladernica')," +
                "(N'Kladnica')," +
                "(N'Kladovo')," +
                "(N'Kladurovo')," +
                "(N'Kladušnica')," +
                "(N'Klajić')," +
                "(N'Klanica')," +
                "(N'Klatičevo')," +
                "(N'Klačevica')," +
                "(N'Klašnić')," +
                "(N'Klašnjice')," +
                "(N'Klek')," +
                "(N'Klekova')," +
                "(N'Klenak')," +
                "(N'Klenike')," +
                "(N'Klenovac')," +
                "(N'Klenovnik')," +
                "(N'Klenje')," +
                "(N'Klečka')," +
                "(N'Klečke')," +
                "(N'Klina')," +
                "(N'Klinavac')," +
                "(N'Klinci')," +
                "(N'Klinčina')," +
                "(N'Klisura')," +
                "(N'Klisurica')," +
                "(N'Kličevac')," +
                "(N'Klobukar')," +
                "(N'Kloka')," +
                "(N'Klokot')," +
                "(N'Klokočevac')," +
                "(N'Klupci')," +
                "(N'Kljajićevo')," +
                "(N'Ključ')," +
                "(N'Kmetovce')," +
                "(N'Kneževac')," +
                "(N'Kneževo')," +
                "(N'Knežica Doljevac')," +
                "(N'Knežica')," +
                "(N'Knez')," +
                "(N'Knić')," +
                "(N'Knićanin')," +
                "(N'Knjaževac')," +
                "(N'Kobanja')," +
                "(N'Kobiljalava')," +
                "(N'Kobilje')," +
                "(N'Kobišnica')," +
                "(N'Kovanica')," +
                "(N'Kovanluk')," +
                "(N'Kovače')," +
                "(N'Kovačeva')," +
                "(N'Kovačevac')," +
                "(N'Kovačevo')," +
                "(N'Kovači')," +
                "(N'Kovačica')," +
                "(N'Kovačice')," +
                "(N'Kovizle')," +
                "(N'Kovilovoula')," +
                "(N'Kovilovo')," +
                "(N'Kovilj')," +
                "(N'Kovilje')," +
                "(N'Kovin')," +
                "(N'Kovioci')," +
                "(N'Kovrage')," +
                "(N'Kodralija')," +
                "(N'Koželj')," +
                "(N'Kožetin')," +
                "(N'Kožince')," +
                "(N'Kožica')," +
                "(N'Kožlje')," +
                "(N'Kožuar')," +
                "(N'Kozare')," +
                "(N'Kozarevo')," +
                "(N'Kozarica')," +
                "(N'Kozelj')," +
                "(N'Kozilo')," +
                "(N'Kozja')," +
                "(N'Kozjak')," +
                "(N'Kozličić')," +
                "(N'Koznik')," +
                "(N'Koznica')," +
                "(N'Koznica')," +
                "(N'Kojlovica')," +
                "(N'Kojuš')," +
                "(N'Kokošiće')," +
                "(N'Kolare')," +
                "(N'Kolari')," +
                "(N'Kolić')," +
                "(N'Kolo')," +
                "(N'Kololeč')," +
                "(N'Kolunica')," +
                "(N'Kolut')," +
                "(N'Komadine')," +
                "(N'Komanice')," +
                "(N'Komarane')," +
                "(N'Komarani')," +
                "(N'Komarica')," +
                "(N'Komirićsečina')," +
                "(N'Komorane')," +
                "(N'Konak')," +
                "(N'Konarevo')," +
                "(N'Konatice')," +
                "(N'Koniče')," +
                "(N'Konopnica')," +
                "(N'Končarevo')," +
                "(N'Končić')," +
                "(N'Končulj')," +
                "(N'Kondželj')," +
                "(N'Konjarnik')," +
                "(N'Konjevići')," +
                "(N'Konjino')," +
                "(N'Konjicsečina')," +
                "(N'Konjska')," +
                "(N'Konjsko')," +
                "(N'Konjuva')," +
                "(N'Konjuh')," +
                "(N'Konjušasečina')," +
                "(N'Konjuševac')," +
                "(N'Kopajkošara')," +
                "(N'Kopanjane')," +
                "(N'Kopaonik')," +
                "(N'Kopiloviće')," +
                "(N'Kopitarce')," +
                "(N'Kopljare')," +
                "(N'Koporiće')," +
                "(N'Kopriva')," +
                "(N'Koprivna')," +
                "(N'Koprivnica')," +
                "(N'Koprivštica')," +
                "(N'Koraćevac')," +
                "(N'Koraćica')," +
                "(N'Korbevac')," +
                "(N'Korbovo')," +
                "(N'Korbul')," +
                "(N'Korbulić')," +
                "(N'Korenita')," +
                "(N'Korenica')," +
                "(N'Koretin')," +
                "(N'Koretište')," +
                "(N'Korilje')," +
                "(N'Koritnik')," +
                "(N'Koritnjak')," +
                "(N'Koriša')," +
                "(N'Korlaće')," +
                "(N'Korman')," +
                "(N'Kosančić')," +
                "(N'Kosatica')," +
                "(N'Kosin')," +
                "(N'Kosjerić')," +
                "(N'Kosmača')," +
                "(N'Kosmovac')," +
                "(N'Kosovica')," +
                "(N'Kosovo Polje')," +
                "(N'Kosovska Kamenica')," +
                "(N'Kosovska Mitrovica')," +
                "(N'Kosovce')," +
                "(N'Kostadinovac')," +
                "(N'Kostadince')," +
                "(N'Kostajnik')," +
                "(N'Kostenica')," +
                "(N'Kostin Potok')," +
                "(N'Kostojevići')," +
                "(N'Kostol')," +
                "(N'Kostolac')," +
                "(N'Kostomlatica')," +
                "(N'Kostroševci')," +
                "(N'Kostrc')," +
                "(N'Kostrce')," +
                "(N'Kostur')," +
                "(N'Kosurić')," +
                "(N'Kosuriće')," +
                "(N'Kotešica')," +
                "(N'Kotlina')," +
                "(N'Kotore')," +
                "(N'Kotradić')," +
                "(N'Kotraža')," +
                "(N'Kotroman')," +
                "(N'Koćura')," +
                "(N'Koceljeva')," +
                "(N'Kočane')," +
                "(N'Kočetin')," +
                "(N'Kočine')," +
                "(N'Kočino Selo')," +
                "(N'Koš')," +
                "(N'Košare')," +
                "(N'Košarno')," +
                "(N'Koševi')," +
                "(N'Koševine')," +
                "(N'Koštanjevo')," +
                "(N'Koštunići')," +
                "(N'Košutane')," +
                "(N'Košutica')," +
                "(N'Košutovo')," +
                "(N'Kpuz')," +
                "(N'Kravarica')," +
                "(N'Kraviće')," +
                "(N'Kravlje')," +
                "(N'Kravlji Do')," +
                "(N'Kravoserija')");
                  migrationBuilder.Sql(
                "insert into Mesta(NazivMesta) values " +
                "(N'Kragujevac')," +
                "(N'Krajinoviće')," +
                "(N'Krajišnik')," +
                "(N'Krajišnici')," +
                "(N'Krajište')," +
                "(N'Krajk')," +
                "(N'Krajkovac')," +
                "(N'Krajkovo')," +
                "(N'Krajmirovce')," +
                "(N'Krajnidel')," +
                "(N'Kraljane')," +
                "(N'Kraljevci')," +
                "(N'Kramovik')," +
                "(N'Krasava')," +
                "(N'Krasalić')," +
                "(N'Krasmirovac')," +
                "(N'Krastavče')," +
                "(N'Kratovo')," +
                "(N'Krvavica')," +
                "(N'Krvavci')," +
                "(N'Krvije')," +
                "(N'Krežbinac')," +
                "(N'Kremenata')," +
                "(N'Kremenica')," +
                "(N'Kremiće')," +
                "(N'Kremna')," +
                "(N'Krenta')," +
                "(N'Krepoljin')," +
                "(N'Kržava')," +
                "(N'Kržince')," +
                "(N'Kriva')," +
                "(N'Kriva Feja')," +
                "(N'Krivaja')," +
                "(N'Krivača')," +
                "(N'Krivelj')," +
                "(N'Krivenik')," +
                "(N'Krivi Vir')," +
                "(N'Krivi Del')," +
                "(N'Kriljevo')," +
                "(N'Krligate')," +
                "(N'Krnić')," +
                "(N'Krnule')," +
                "(N'Krnja Jela')," +
                "(N'Krnjača')," +
                "(N'Krnjevo')," +
                "(N'Krnješevci')," +
                "(N'Krnjirad')," +
                "(N'Krnjina')," +
                "(N'Krnjince')," +
                "(N'Krpejce')," +
                "(N'Krpimej')," +
                "(N'Krstac')," +
                "(N'Krstićevo')," +
                "(N'Krstovac')," +
                "(N'Krtinska')," +
                "(N'Krtok')," +
                "(N'Krće')," +
                "(N'Krćevac')," +
                "(N'Krupaja')," +
                "(N'Krupanj')," +
                "(N'Krupac')," +
                "(N'Krupac')," +
                "(N'Krušar')," +
                "(N'Kruševalava')," +
                "(N'Kruševac')," +
                "(N'Kruševica')," +
                "(N'Kruševo')," +
                "(N'Krušedol')," +
                "(N'Krušje')," +
                "(N'Krušce')," +
                "(N'Kruščić Kula')," +
                "(N'Kruščica')," +
                "(N'Krčedin')," +
                "(N'Krčmar')," +
                "(N'Krčmare')," +
                "(N'Kršanje')," +
                "(N'Krševica')," +
                "(N'Kršnalava')," +
                "(N'Kudreš')," +
                "(N'Kuzmin')," +
                "(N'Kuzmičevo')," +
                "(N'Kujavica')," +
                "(N'Kukavica')," +
                "(N'Kukići')," +
                "(N'Kuklibeg')," +
                "(N'Kukljin')," +
                "(N'Kukovce')," +
                "(N'Kukujevci')," +
                "(N'Kukulovce')," +
                "(N'Kukuljaneora')," +
                "(N'Kukurovići')," +
                "(N'Kula')," +
                "(N'Kulina')," +
                "(N'Kulinovci')," +
                "(N'Kulič')," +
                "(N'Kulpin')," +
                "(N'Kumane')," +
                "(N'Kumanica')," +
                "(N'Kumanovo')," +
                "(N'Kunice')," +
                "(N'Kunovik')," +
                "(N'Kunovica')," +
                "(N'Kunovo')," +
                "(N'Kupinik')," +
                "(N'Kupinince')," +
                "(N'Kupinovac')," +
                "(N'Kupinovo')," +
                "(N'Kupinovoinci')," +
                "(N'Kupuzište')," +
                "(N'Kupusina')," +
                "(N'Kurbalija')," +
                "(N'Kurilovo')," +
                "(N'Kurići')," +
                "(N'Kurjače')," +
                "(N'Kuršumlija')," +
                "(N'Kuršumlijska Banja')," +
                "(N'Kusa Vrana')," +
                "(N'Kusadak')," +
                "(N'Kusar')," +
                "(N'Kusić')," +
                "(N'Kusiće')," +
                "(N'Kusovac')," +
                "(N'Kutleš')," +
                "(N'Kutlovac')," +
                "(N'Kutlovo')," +
                "(N'Kutnje')," +
                "(N'Kućane')," +
                "(N'Kućani')," +
                "(N'Kućica')," +
                "(N'Kućište')," +
                "(N'Kucura Vrbas')," +
                "(N'Kučajna')," +
                "(N'Kučevo')," +
                "(N'Kučin')," +
                "(N'Kuševac')," +
                "(N'Kušiljevo')," +
                "(N'Kušići')," +
                "(N'Kušnin')," +
                "(N'Kuštendil')," +
                "(N'Kuštilj')," +
                "(N'Kuštica')," +
                "(N'Labljane')," +
                "(N'Labukovo')," +
                "(N'Labučevo')," +
                "(N'Ladovac')," +
                "(N'Ladovica')," +
                "(N'Ladrovac')," +
                "(N'Ladrović')," +
                "(N'Lađevci')," +
                "(N'Laz Belopać')," +
                "(N'Lazarevac')," +
                "(N'Lazarevo')," +
                "(N'Lazarevo Selo')," +
                "(N'Lazarica')," +
                "(N'Lazac')," +
                "(N'Lazine')," +
                "(N'Laznica')," +
                "(N'Lajkovac')," +
                "(N'Laletić')," +
                "(N'Lalinac')," +
                "(N'Lalinovac')," +
                "(N'Lalince')," +
                "(N'Lalinci')," +
                "(N'Lalićdžaci')," +
                "(N'Landovica')," +
                "(N'Landol')," +
                "(N'Lanište')," +
                "(N'Lanište')," +
                "(N'Lanište')," +
                "(N'Laplje Selo')," +
                "(N'Lapovo')," +
                "(N'Lapotince')," +
                "(N'Lapušnik')," +
                "(N'Lasovo')," +
                "(N'Latvica')," +
                "(N'Latkovac')," +
                "(N'Latković')," +
                "(N'Laćarak')," +
                "(N'Laćisled')," +
                "(N'Laudonovac')," +
                "(N'Lauša')," +
                "(N'Laškobare')," +
                "(N'Lebane')," +
                "(N'Lebane')," +
                "(N'Lebet')," +
                "(N'Lebina')," +
                "(N'Leva')," +
                "(N'Levići')," +
                "(N'Levovik')," +
                "(N'Levosoje')," +
                "(N'Ledenik')," +
                "(N'Ledinci')," +
                "(N'Ležimir')," +
                "(N'Lez')," +
                "(N'Lelić')," +
                "(N'Lelići')," +
                "(N'Lenovac')," +
                "(N'Leović')," +
                "(N'Leočina')," +
                "(N'Lepaja')," +
                "(N'Lepena')," +
                "(N'Lepenac')," +
                "(N'Lepenica')," +
                "(N'Lepina')," +
                "(N'Lepojević')," +
                "(N'Leposavić')," +
                "(N'Lepčince')," +
                "(N'Lesenovci')," +
                "(N'Leskovac')," +
                "(N'Leskovik')," +
                "(N'Leskovica')," +
                "(N'Leskovo')," +
                "(N'Leskovčić')," +
                "(N'Lesnica')," +
                "(N'Letance')," +
                "(N'Letnica')," +
                "(N'Letovica')," +
                "(N'Letovište')," +
                "(N'Leušići')," +
                "(N'Lece')," +
                "(N'Leča')," +
                "(N'Lešak')," +
                "(N'Lešane')," +
                "(N'Leševo')," +
                "(N'Lešje')," +
                "(N'Lešnica')," +
                "(N'Leštane')," +
                "(N'Leštaneora')," +
                "(N'Livadica')," +
                "(N'Livađe')," +
                "(N'Lijeva')," +
                "(N'Likovac')," +
                "(N'Likodra')," +
                "(N'Likošane')," +
                "(N'Linovo')," +
                "(N'Lipa')," +
                "(N'Lipar')," +
                "(N'Lipe')," +
                "(N'Lipenović')," +
                "(N'Lipica')," +
                "(N'Lipljan')," +
                "(N'Liplje')," +
                "(N'Lipnica')," +
                "(N'Lipnica')," +
                "(N'Lipnica')," +
                "(N'Lipnički Šor')," +
                "(N'Lipova')," +
                "(N'Lipovac')," +
                "(N'Lipovac')," +
                "(N'Lipovica')," +
                "(N'Lipolist')," +
                "(N'Lis')," +
                "(N'Lisa')," +
                "(N'Lisina')," +
                "(N'Lisica')," +
                "(N'Lisice')," +
                "(N'Liso Polje')," +
                "(N'Lisovićjevo')," +
                "(N'Lisocka')," +
                "(N'Ličin Dol')," +
                "(N'Ličje')," +
                "(N'Loboder')," +
                "(N'Lovac')," +
                "(N'Lovćenac')," +
                "(N'Lovce')," +
                "(N'Lovci')," +
                "(N'Lođa')," +
                "(N'Ložane')," +
                "(N'Lozan')," +
                "(N'Lozane')," +
                "(N'Lozanj')," +
                "(N'Lozica')," +
                "(N'Lozište')," +
                "(N'Lozna')," +
                "(N'Loznac')," +
                "(N'Loznica')," +
                "(N'Lozničko Polje')," +
                "(N'Lozno')," +
                "(N'Lozovik')," +
                "(N'Lojanice')," +
                "(N'Lok')," +
                "(N'Lokva')," +
                "(N'Lokvica')," +
                "(N'Lomnica')," +
                "(N'Lončanik')," +
                "(N'Lonjin')," +
                "(N'Lopardince')," +
                "(N'Lopatanj')," +
                "(N'Lopatnica')," +
                "(N'Lopaš')," +
                "(N'Lopužnje')," +
                "(N'Lopušnik')," +
                "(N'Loret')," +
                "(N'Loćane')," +
                "(N'Loćika')," +
                "(N'Ločevci')," +
                "(N'Lubnica')," +
                "(N'Lug')," +
                "(N'Lug Dubnica')," +
                "(N'Lugavčina')," +
                "(N'Lugađija')," +
                "(N'Lugare')," +
                "(N'Lugadžija')," +
                "(N'Lugovo')," +
                "(N'Lužane')," +
                "(N'Lužane')," +
                "(N'Lužnica')," +
                "(N'Lužnice')," +
                "(N'Luka')," +
                "(N'Lukavac')," +
                "(N'Lukavica')," +
                "(N'Lukar')," +
                "(N'Lukare')," +
                "(N'Lukarce')," +
                "(N'Luke')," +
                "(N'Lukino Selo')," +
                "(N'Lukićevo')," +
                "(N'Lukovica')," +
                "(N'Lukovo')," +
                "(N'Lukomir')," +
                "(N'Lukocrevo')," +
                "(N'Lunjevac')," +
                "(N'Lunjevica')," +
                "(N'Lučane')," +
                "(N'Lučani')," +
                "(N'Lučina')," +
                "(N'Lučica')," +
                "(N'Lučice')," +
                "(N'Lučka Reka')," +
                "(N'Ljajčić')," +
                "(N'Ljanik')," +
                "(N'Ljevaja')," +
                "(N'Ljevoša')," +
                "(N'Ljepojevići')," +
                "(N'Lješane')," +
                "(N'Lješnica')," +
                "(N'Lještansko')," +
                "(N'Lještar')," +
                "(N'Ljig')," +
                "(N'Ljiljance')," +
                "(N'Ljuba')," +
                "(N'Ljubava')," +
                "(N'Ljubanje')," +
                "(N'Ljubatovica')," +
                "(N'Ljubenić')," +
                "(N'Ljuberađa')," +
                "(N'Ljubižda')," +
                "(N'Ljubinić')," +
                "(N'Ljubinci')," +
                "(N'Ljubinje')," +
                "(N'Ljubić')," +
                "(N'Ljubičevac')," +
                "(N'Ljubičevo')," +
                "(N'Ljubiš')," +
                "(N'Ljubište')," +
                "(N'Ljubovac')," +
                "(N'Ljubovija')," +
                "(N'Ljubovo')," +
                "(N'Ljubožda')," +
                "(N'Ljubuša')," +
                "(N'Ljugbunar')," +
                "(N'Ljukinaj')," +
                "(N'Ljukovo')," +
                "(N'Ljuljaci')," +
                "(N'Ljumbarda')," +
                "(N'Ljupten')," +
                "(N'Ljutaje')," +
                "(N'Ljutež')," +
                "(N'Ljutice')," +
                "(N'Ljutova')," +
                "(N'Ljutovnica')," +
                "(N'Ljutovo')," +
                "(N'Ljutoglav')," +
                "(N'Ljutoglava')," +
                "(N'Ljuša')," +
                "(N'Ljušta ')," +
                "(N'Mavrić')," +
                "(N'Magaš')," +
                "(N'Maglić')," +
                "(N'Maglič')," +
                "(N'Magovo')," +
                "(N'Magura')," +
                "(N'Mađare')," +
                "(N'Mađer')," +
                "(N'Mađere')," +
                "(N'Mažić ')," +
                "(N'Mažići')," +
                "(N'Mazap')," +
                "(N'Mazarać')," +
                "(N'Mazgit')," +
                "(N'Mazgoš')," +
                "(N'Maznik')," +
                "(N'Mazrek')," +
                "(N'Majance')," +
                "(N'Majdan')," +
                "(N'Majdanpek')," +
                "(N'Majdevo')," +
                "(N'Majilovac')," +
                "(N'Majinović')," +
                "(N'Majkovac')," +
                "(N'Majur')," +
                "(N'Makvište')," +
                "(N'Makovac')," +
                "(N'Makovište')," +
                "(N'Makrešane')," +
                "(N'Makrmalj')," +
                "(N'Makce')," +
                "(N'Mala Biljanica')," +
                "(N'Mala Bosna')," +
                "(N'Mala Braina')," +
                "(N'Mala Bresnica')," +
                "(N'Mala Vranjska ')," +
                "(N'Mala Vrbica')," +
                "(N'Mala Vrbnica')," +
                "(N'Mala Grabovnica')," +
                "(N'Mala Dobranja')," +
                "(N'Mala Draguša')," +
                "(N'Mala Drenova')," +
                "(N'Mala Ivanča')," +
                "(N'Mala Jablanica')," +
                "(N'Mala Jasikova')," +
                "(N'Mala Ježevica')," +
                "(N'Mala Kaludra')," +
                "(N'Mala Kamenica')," +
                "(N'Mala Kopašnica')," +
                "(N'Mala Kosanica')," +
                "(N'Mala Krsna')," +
                "(N'Mala Kruša')," +
                "(N'Mala Kruševica')," +
                "(N'Mala Moštanica')," +
                "(N'Mala Plana')," +
                "(N'Mala Reka')," +
                "(N'Mala Remeta')," +
                "(N'Mala Slatina')," +
                "(N'Mala Sugubina')," +
                "(N'Mala Hoča')," +
                "(N'Malajnica')," +
                "(N'Male Pijace')," +
                "(N'Maletina')," +
                "(N'Maleševo')," +
                "(N'Maleševo')," +
                "(N'Mali Alaš')," +
                "(N'Mali Belaćevac')," +
                "(N'Mali Beograd')," +
                "(N'Maliak')," +
                "(N'Mali Bošnjak')," +
                "(N'Mali Vranovac')," +
                "(N'Mali Vrtop')," +
                "(N'Mali Drenovac')," +
                "(N'Mali Đurđevik')," +
                "(N'Mali Žam')," +
                "(N'Mali Zvornik')," +
                "(N'Mali Iđoš')," +
                "(N'Mali Izvor')," +
                "(N'Mali Jasenovac')," +
                "(N'Mali Jovanovac')," +
                "(N'Mali Krčimir')," +
                "(N'Mali Kupci')," +
                "(N'Mali Miraševac')," +
                "(N'Mali Pesak')," +
                "(N'Mali')," +
                "(N'Mali Popović')," +
                "(N'Mali Radinci')," +
                "(N'Mali Suvodol')," +
                "(N'Mali Trnovac')," +
                "(N'Mali Crljeni')," +
                "(N'Mali Šenj')," +
                "(N'Mali Šiljegovac')," +
                "(N'Mali Štupelj')," +
                "(N'Mališevo')," +
                "(N'Malo Bavanište')," +
                "(N'Malo Bonjince')," +
                "(N'Malo Vojlovce')," +
                "(N'Malo Golovode')," +
                "(N'Maloradište')," +
                "(N'Maloracko')," +
                "(N'Malo Dubovo')," +
                "(N'Malo Kičiće ')," +
                "(N'Malo Kruševo')," +
                "(N'Malo Krušince')," +
                "(N'Malo Krčmare')," +
                "(N'Malo Laole')," +
                "(N'Malo Orašje')," +
                "(N'Malo Ribare')," +
                "(N'Malo Ropotovo')," +
                "(N'Malo Rudare')," +
                "(N'Malo Središte')," +
                "(N'Malo Crniće')," +
                "(N'Malopoljce')," +
                "(N'Malošište')," +
                "(N'Malča')," +
                "(N'Maljević')," +
                "(N'Maljeviće')," +
                "(N'Maljurevac')," +
                "(N'Mamuša')," +
                "(N'Mana')," +
                "(N'Manajle')," +
                "(N'Manastir')," +
                "(N'Manastirica')," +
                "(N'Manastirce')," +
                "(N'Manđelos')," +
                "(N'Manić')," +
                "(N'Manišince')," +
                "(N'Manojlica')," +
                "(N'Manojlovce')," +
                "(N'Manojlovci')," +
                "(N'Manjak')," +
                "(N'Manjinac')," +
                "(N'Maovi')," +
                "(N'Maradik')," +
                "(N'Margance')," +
                "(N'Margita')," +
                "(N'Marevce')," +
                "(N'Marevce')," +
                "(N'Marenovo')," +
                "(N'Marina')," +
                "(N'Marina Kutina')," +
                "(N'Marinovac')," +
                "(N'Maričiće')," +
                "(N'Markova Crkva')," +
                "(N'Markovac')," +
                "(N'Markoviće')," +
                "(N'Markovićevo')," +
                "(N'Markovica')," +
                "(N'Marmule')," +
                "(N'Marovac')," +
                "(N'Marovce')," +
                "(N'Martinci')," +
                "(N'Martonoš')," +
                "(N'Maršić')," +
                "(N'Maskar')," +
                "(N'Maskare')," +
                "(N'Maskova')," +
                "(N'Masloševo')," +
                "(N'Masurovac')," +
                "(N'Masurica')," +
                "(N'Matarova')," +
                "(N'Mataruge')," +
                "(N'Mataruška Banja')," +
                "(N'Matijevac')," +
                "(N'Matica')," +
                "(N'Matičane')," +
                "(N'Maćedonce')," +
                "(N'Maćija')," +
                "(N'Mačvanska Mitrovica')," +
                "(N'Mačvanski Pričinović')," +
                "(N'Mačevac')," +
                "(N'Mačina')," +
                "(N'Mačitevo')," +
                "(N'Mačja Stena')," +
                "(N'Mačkat')," +
                "(N'Mačkatica')," +
                "(N'Mačkovac')," +
                "(N'Mašoviće')," +
                "(N'Medare')," +
                "(N'Medveđa')," +
                "(N'Medveđica')," +
                "(N'Medvece')," +
                "(N'Medevce')," +
                "(N'Medovine')," +
                "(N'Medojevac')," +
                "(N'Medoševac')," +
                "(N'Medregovac')," +
                "(N'Međa')," +
                "(N'Međa')," +
                "(N'Međani')," +
                "(N'Međeđi Potok')," +
                "(N'Međuvršje')," +
                "(N'Međugor')," +
                "(N'Međulužje')," +
                "(N'Međureč')," +
                "(N'Međurečje')," +
                "(N'Međuhana')," +
                "(N'Mezgraja')," +
                "(N'Mezdraja')," +
                "(N'Mejarize')," +
                "(N'Meki Do')," +
                "(N'Mekiniće')," +
                "(N'Mekiš')," +
                "(N'Melaje')," +
                "(N'Melenci')," +
                "(N'Melnica')," +
                "(N'Melovo')," +
                "(N'Meljak')," +
                "(N'Meljanica')," +
                "(N'Merdare')," +
                "(N'Merovac')," +
                "(N'Merošina')," +
                "(N'Merćez')," +
                "(N'Merdželat')," +
                "(N'Mesarci')," +
                "(N'Mesić')," +
                "(N'Metikoš')," +
                "(N'Metković')," +
                "(N'Metlić')," +
                "(N'Metovnica')," +
                "(N'Metohija')," +
                "(N'Metriš')," +
                "(N'Meća')," +
                "(N'Mehane')," +
                "(N'Mehovine')," +
                "(N'Mečji Do')," +
                "(N'Mečkovac')," +
                "(N'Meševo')," +
                "(N'Mešina')," +
                "(N'Miganovce')," +
                "(N'Mijajlica')," +
                "(N'Mijajlovac')," +
                "(N'Mijak')," +
                "(N'Mijakovce')," +
                "(N'Mijalić')," +
                "(N'Mijani')," +
                "(N'Mijatovac')," +
                "(N'Mijači')," +
                "(N'Mijovce')," +
                "(N'Mijoska')," +
                "(N'Mikulovac')," +
                "(N'Mikušnica')," +
                "(N'Milavac')," +
                "(N'Milavčići')," +
                "(N'Milakovac')," +
                "(N'Milakovići')," +
                "(N'Milanovac')," +
                "(N'Milanović')," +
                "(N'Milanovo')," +
                "(N'Milatkoviće')," +
                "(N'Milatovac')," +
                "(N'Milatovići')," +
                "(N'Milevci')," +
                "(N'Milentija')," +
                "(N'Miletićevo')," +
                "(N'Mileševo')," +
                "(N'Miliva')," +
                "(N'Milivojce')," +
                "(N'Miliješ')," +
                "(N'Milina')," +
                "(N'Miliće')," +
                "(N'Milićevo Selo')," +
                "(N'Milićevci')," +
                "(N'Milići')," +
                "(N'Miličinica')," +
                "(N'Milojkovac')," +
                "(N'Milorci')," +
                "(N'Miločaj')," +
                "(N'Milošev Do')," +
                "(N'Miloševac')," +
                "(N'Milutinovac')," +
                "(N'Milutovac')," +
                "(N'Milušinac')," +
                "(N'Miljaj')," +
                "(N'Miljević')," +
                "(N'Miljevići')," +
                "(N'Miljkovac')," +
                "(N'Miljkovica')," +
                "(N'Minićevo')," +
                "(N'Miokoviće')," +
                "(N'Miokovci')," +
                "(N'Miokus')," +
                "(N'Mioliće')," +
                "(N'Mionica')," +
                "(N'Miranovac')," +
                "(N'Miranovačka')," +
                "(N'Miratovac')," +
                "(N'Miraševac')," +
                "(N'Mirena')," +
                "(N'Mirijevo')," +
                "(N'Mirilovac')," +
                "(N'Mirkovci')," +
                "(N'Mirnica')," +
                "(N'Mirovac')," +
                "(N'Mirovo')," +
                "(N'Mironić')," +
                "(N'Mirosavlje')," +
                "(N'Mirosaljci')," +
                "(N'Miroč')," +
                "(N'Miroče')," +
                "(N'Miroševce')," +
                "(N'Miruša')," +
                "(N'Misača')," +
                "(N'Mislođin')," +
                "(N'Mitrova')," +
                "(N'Mićunovo')," +
                "(N'Mihajlovac')," +
                "(N'Mihajlovo')," +
                "(N'Mišar')," +
                "(N'Mišević')," +
                "(N'Miševići')," +
                "(N'Mišićevo')," +
                "(N'Mišljenovac')," +
                "(N'Miščiće')," +
                "(N'Mladenovac')," +
                "(N'Mladenovo')," +
                "(N'Mlanča')," +
                "(N'Mlačište')," +
                "(N'Mlekominci')," +
                "(N'Mlečane')," +
                "(N'Mlikeora')," +
                "(N'Movljane')," +
                "(N'Mogila')," +
                "(N'Moglica')," +
                "(N'Modra Stena')," +
                "(N'Modrica')," +
                "(N'Mozgovo')," +
                "(N'Mojinci')," +
                "(N'Mojković')," +
                "(N'Mojsinje')," +
                "(N'Mojstir')," +
                "(N'Moklište')," +
                "(N'Mokra')," +
                "(N'Mokra Gora')," +
                "(N'Mokranje')," +
                "(N'Mokrin')," +
                "(N'Mol Ada')," +
                "(N'Molić')," +
                "(N'Molovin')," +
                "(N'Moravac')," +
                "(N'Moravski Bujmir')," +
                "(N'Moravci')," +
                "(N'Moralija')," +
                "(N'Morani')," +
                "(N'Morina')," +
                "(N'Morović')," +
                "(N'Mosna')," +
                "(N'Motrić')," +
                "(N'Močare')," +
                "(N'Močioci')," +
                "(N'Mošnica')," +
                "(N'Mošorin')," +
                "(N'Moštanica')," +
                "(N'Mramor')," +
                "(N'Mramorak')," +
                "(N'Mramorac')," +
                "(N'Mramorski Potok')," +
                "(N'Mramorsko Brdo')," +
                "(N'Mrasor')," +
                "(N'Mratišić')," +
                "(N'Mrveš')," +
                "(N'Mrđenovac')," +
                "(N'Mrzenica')," +
                "(N'Mrkovica')," +
                "(N'Mrkonje')," +
                "(N'Mrljak')," +
                "(N'Mrmoš')," +
                "(N'Mrovska')," +
                "(N'Mrsać')," +
                "(N'Mrtvica')," +
                "(N'Mrča')," +
                "(N'Mrčajevci')," +
                "(N'Mrčić')," +
                "(N'Mrčići')," +
                "(N'Mrčkovac')," +
                "(N'Mrčkovina')," +
                "(N'Mršelj')," +
                "(N'Mršelji')," +
                "(N'Mršinci')," +
                "(N'Mrštane')," +
                "(N'Mudrakovac')," +
                "(N'Muževine')," +
                "(N'Mužinac')," +
                "(N'Mužičane')," +
                "(N'Muzaće')," +
                "(N'Mur')," +
                "(N'Muradem')," +
                "(N'Murga')," +
                "(N'Murgaš')," +
                "(N'Murgula')," +
                "(N'Mure')," +
                "(N'Musina Reka')," +
                "(N'Mustapić')," +
                "(N'Musulj')," +
                "(N'Mutanj')," +
                "(N'Muhadžer')," +
                "(N'Muhadžer Prelez')," +
                "(N'Muhadžer')," +
                "(N'Muhovac')," +
                "(N'Muhovo')," +
                "(N'Muhovce')," +
                "(N'Mučibaba')," +
                "(N'Mučivrce')," +
                "(N'Mušvete')," +
                "(N'Mušići')," +
                "(N'Muškovina')," +
                "(N'Mušnikovo')," +
                "(N'Mušutište')," +
                "(N'Naboje')," +
                "(N'Nabrđe')," +
                "(N'Navalin')," +
                "(N'Naglavci')," +
                "(N'Nadalj Srbobran')," +
                "(N'Nadrlje')," +
                "(N'Nadumce')," +
                "(N'Nazarica')," +
                "(N'Nakarade')," +
                "(N'Naklo')," +
                "(N'Nakovo')," +
                "(N'Nakrivanj')," +
                "(N'Nakučani')," +
                "(N'Namga')," +
                "(N'Nanomir')," +
                "(N'Nastavce')," +
                "(N'Natalinci')," +
                "(N'Naupare')," +
                "(N'Našec')," +
                "(N'Našpale')," +
                "(N'Našuškovica')," +
                "(N'Nebregošte')," +
                "(N'Nevada')," +
                "(N'Nevade')," +
                "(N'Nevoljane')," +
                "(N'Negbina')," +
                "(N'Negovac')," +
                "(N'Negosavlje')," +
                "(N'Negotin')," +
                "(N'Negotinac')," +
                "(N'Negrišori')," +
                "(N'Negrovce')," +
                "(N'Nedakovac')," +
                "(N'Nekovce')," +
                "(N'Nekodim')," +
                "(N'Nemenikuće')," +
                "(N'Nepolje')," +
                "(N'Neprebište')," +
                "(N'Nepričava')," +
                "(N'Neradin')," +
                "(N'Neresnica')," +
                "(N'Nesalce')," +
                "(N'Nesvrta')," +
                "(N'Nesvrtaja')," +
                "(N'Nećavce')," +
                "(N'Neuzina')," +
                "(N'Nec')," +
                "(N'Neštin')," +
                "(N'Nivokaz')," +
                "(N'Nika')," +
                "(N'Nikinci')," +
                "(N'Nikovce')," +
                "(N'Nikojevići')," +
                "(N'Nikola Tesla')," +
                "(N'Nikolinac')," +
                "(N'Nikolinci')," +
                "(N'Nikoličevo')," +
                "(N'Nikšić')," +
                "(N'Niš')," +
                "(N'Niševac')," +
                "(N'Niševce')," +
                "(N'Niška Banja')");
            migrationBuilder.Sql(
          "insert into Mesta(NazivMesta) values " +
          "(N'Nišor')," +
          "(N'Njegoševo')," +
          "(N'Nova Božurna')," +
          "(N'Nova Brezovica')," +
          "(N'Nova Varoš')," +
          "(N'Nova Gajdobra')," +
          "(N'Nova Pazova')," +
          "(N'Nova')," +
          "(N'Nova Crvenka')," +
          "(N'Nova Crnja')," +
          "(N'Nova Šumadija')," +
          "(N'Novake')," +
          "(N'Novaci')," +
          "(N'Novi Banovci')," +
          "(N'Novi Bečej')," +
          "(N'Novi Bračin')," +
          "(N'Novi Verić')," +
          "(N'Novilog')," +
          "(N'Novi Đurovac')," +
          "(N'Novi Žednik')," +
          "(N'Novi Zavoj')," +
          "(N'Novi Itebej')," +
          "(N'Novi Karlovci')," +
          "(N'Novi Kneževac')," +
          "(N'Novi Kozarci')," +
          "(N'Novi Kozjak')," +
          "(N'Novi Milanovac')," +
          "(N'Novi Miraš')," +
          "(N'Novi Pazar')," +
          "(N'Novi Raušić')," +
          "(N'Novi Sad')," +
          "(N'Novi Sip')," +
          "(N'Novi Slankamen')," +
          "(N'Novo Brdo')," +
          "(N'Novo Korito')," +
          "(N'Novo Lanište')," +
          "(N'Novo Miloševo')," +
          "(N'Novo Momčilovo')," +
          "(N'Novorahovo')," +
          "(N'Novo Rujce')," +
          "(N'Novo Selo')," +
          "(N'Novo Selo Begovo')," +
          "(N'Novo Selo Mađunsko')," +
          "(N'Novo Čikatovo')," +
          "(N'Nogavac')," +
          "(N'Nozrina')," +
          "(N'Nomanica')," +
          "(N'Norča')," +
          "(N'Nosalje')," +
          "(N'Nosoljin')," +
          "(N'Noćaj')," +
          "(N'Noćaje')," +
          "(N'Obajgora')," +
          "(N'Oblačina')," +
          "(N'Oblička Sena')," +
          "(N'Obornjača Ada')," +
          "(N'Obornjača')," +
          "(N'Obradovce')," +
          "(N'Obražda')," +
          "(N'Obrandža')," +
          "(N'Obrva')," +
          "(N'Obrež')," +
          "(N'Obrežinci')," +
          "(N'Obrenovac')," +
          "(N'Obrovac')," +
          "(N'Obrtince')," +
          "(N'Ovsinjinac')," +
          "(N'Ovsište')," +
          "(N'Ovča')," +
          "(N'Ovčar Banja')," +
          "(N'Ovčare')," +
          "(N'Ovčarevo')," +
          "(N'Ovčinja')," +
          "(N'Ogarinci')," +
          "(N'Oglađenovac')," +
          "(N'Ogošte')," +
          "(N'Odanovce')," +
          "(N'Odevce')," +
          "(N'Odojeviće')," +
          "(N'Ozrem')," +
          "(N'Ozrim')," +
          "(N'Ojkovica')," +
          "(N'Oklap')," +
          "(N'Oklace')," +
          "(N'Okletac')," +
          "(N'Okolište')," +
          "(N'Okose')," +
          "(N'Okosnica')," +
          "(N'Okraštica')," +
          "(N'Okruglica')," +
          "(N'Omoljica')," +
          "(N'Opaljenik')," +
          "(N'Oparić')," +
          "(N'Oplanić')," +
          "(N'Oplanići')," +
          "(N'Opovopovo')," +
          "(N'Opornica')," +
          "(N'Opteruša')," +
          "(N'Orane')," +
          "(N'Oraovac')," +
          "(N'Oraovica')," +
          "(N'Orahovo')," +
          "(N'Orašac')," +
          "(N'Oraše')," +
          "(N'Orašje')," +
          "(N'Oreovac')," +
          "(N'Oreovica')," +
          "(N'Orešac')," +
          "(N'Oreškovica')," +
          "(N'Orid ')," +
          "(N'Orlane')," +
          "(N'Orlate')," +
          "(N'Orlovat')," +
          "(N'Orlovac')," +
          "(N'Orlović')," +
          "(N'Orlja')," +
          "(N'Orljalava')," +
          "(N'Orljane')," +
          "(N'Orlje')," +
          "(N'Orljevo')," +
          "(N'Orno Brdo')," +
          "(N'Orovička Planina')," +
          "(N'Orom')," +
          "(N'Oruglica')," +
          "(N'Orčušaora')," +
          "(N'Osanica')," +
          "(N'Osaonica')," +
          "(N'Osek Paša')," +
          "(N'Osek Hilja')," +
          "(N'Osečenica')," +
          "(N'Osipaonica')," +
          "(N'Osladić')," +
          "(N'Oslare')," +
          "(N'Osmakova')," +
          "(N'Osnić')," +
          "(N'Osojane')," +
          "(N'Osoje')," +
          "(N'Osonica')," +
          "(N'Osreci')," +
          "(N'Ostatovica')," +
          "(N'Ostojićevo')," +
          "(N'Ostra')," +
          "(N'Ostralava')," +
          "(N'Ostraće')," +
          "(N'Ostrikovac')," +
          "(N'Ostrovica')," +
          "(N'Ostrovo')," +
          "(N'Ostrozub')," +
          "(N'Ostružanj')," +
          "(N'Ostružnica')," +
          "(N'Ostrc')," +
          "(N'Otanj')," +
          "(N'Otroci')," +
          "(N'Oholje')," +
          "(N'Očage')," +
          "(N'Ošljane')," +
          "(N'Oštra Stijena')," +
          "(N'Oštrelj')," +
          "(N'Pavaštica')," +
          "(N'Pavlica')," +
          "(N'Pavličina')," +
          "(N'Pavliš')," +
          "(N'Pavlovac')," +
          "(N'Pavlovci')," +
          "(N'Pavlje')," +
          "(N'Pagaruša')," +
          "(N'Padalište')," +
          "(N'Padež')," +
          "(N'Padej')," +
          "(N'Padina')," +
          "(N'Padine')," +
          "(N'Padinska Skela')," +
          "(N'Pajazitovo')," +
          "(N'Pajež')," +
          "(N'Pajkovac')," +
          "(N'Pajsak')," +
          "(N'Pajsijević')," +
          "(N'Pakašnica')," +
          "(N'Pakleštica')," +
          "(N'Paklje')," +
          "(N'Pakovraće')," +
          "(N'Palatna')," +
          "(N'Paležnica')," +
          "(N'Palivodenica')," +
          "(N'Paligrace')," +
          "(N'Palikuća')," +
          "(N'Palilula')," +
          "(N'Palić')," +
          "(N'Palojce')," +
          "(N'Palja')," +
          "(N'Paljabarda')," +
          "(N'Paljane')," +
          "(N'Paljevo')," +
          "(N'Paljevštica')," +
          "(N'Paljina')," +
          "(N'Paljuvi')," +
          "(N'Pambukovica')," +
          "(N'Panevljeja')," +
          "(N'Pankovo')," +
          "(N'Panojeviće')," +
          "(N'Panonija')," +
          "(N'Pantina')," +
          "(N'Pančevo')," +
          "(N'Pančelo')," +
          "(N'Panjak')," +
          "(N'Panjevac')," +
          "(N'Papaz')," +
          "(N'Papić')," +
          "(N'Papiće')," +
          "(N'Papratište')," +
          "(N'Papratna')," +
          "(N'Papraćane')," +
          "(N'Parage')," +
          "(N'Parada')," +
          "(N'Paralovo')," +
          "(N'Paramun')," +
          "(N'Paraćin')," +
          "(N'Pardik')," +
          "(N'Parmenac')," +
          "(N'Parta')," +
          "(N'Parteš')," +
          "(N'Parunovac')," +
          "(N'Paruce')," +
          "(N'Parcane')," +
          "(N'Parcani')," +
          "(N'Parčin')," +
          "(N'Pasi Poljana')," +
          "(N'Pasjak')," +
          "(N'Pasjane')," +
          "(N'Pasjač')," +
          "(N'Pasjača')," +
          "(N'Pasji Potok')," +
          "(N'Paskašija')," +
          "(N'Paskovac')," +
          "(N'Pasoma')," +
          "(N'Paune')," +
          "(N'Pacaj')," +
          "(N'Pačarađa')," +
          "(N'Pačir')," +
          "(N'Pašinac')," +
          "(N'Pašino Selo')," +
          "(N'Paštrić')," +
          "(N'Pear')," +
          "(N'Pejinović')," +
          "(N'Pejkovac')," +
          "(N'Pekčanica')," +
          "(N'Penduha')," +
          "(N'Pepelj')," +
          "(N'Pepeljevac')," +
          "(N'Pepiće')," +
          "(N'Perane')," +
          "(N'Periš')," +
          "(N'Perlez')," +
          "(N'Pertate')," +
          "(N'Perunika')," +
          "(N'Perutina')," +
          "(N'Perućac')," +
          "(N'Pestiš')," +
          "(N'Pestovo')," +
          "(N'Petačinci')," +
          "(N'Peterlaš')," +
          "(N'Petina')," +
          "(N'Petka')," +
          "(N'Petković')," +
          "(N'Petkovica')," +
          "(N'Petlovača')," +
          "(N'Petnica')," +
          "(N'Petraštica')," +
          "(N'Petrijevo')," +
          "(N'Petrilje')," +
          "(N'Petrovaradin')," +
          "(N'Petrovac')," +
          "(N'Petrovac na Mlavi')," +
          "(N'Petrović')," +
          "(N'Petrovo')," +
          "(N'Petrovo Polje')," +
          "(N'Petrovo Selo')," +
          "(N'Petrovce')," +
          "(N'Petrovčić')," +
          "(N'Petropolje')," +
          "(N'Petruša')," +
          "(N'Petrušan')," +
          "(N'Peć')," +
          "(N'Pećane')," +
          "(N'Pećani')," +
          "(N'Pećinci')," +
          "(N'Pecka')," +
          "(N'Pečanica')," +
          "(N'Pečeno')," +
          "(N'Pečenog')," +
          "(N'Pečenjevce')," +
          "(N'Pivnice')," +
          "(N'Pidić')," +
          "(N'Pilareta')," +
          "(N'Pilatovići')," +
          "(N'Pilica')," +
          "(N'Pinosavaac')," +
          "(N'Pirane')," +
          "(N'Pirkovac')," +
          "(N'Piroman')," +
          "(N'Pirot')," +
          "(N'Pirče ')," +
          "(N'Piskalje')," +
          "(N'Piskanja')," +
          "(N'Piskopovce')," +
          "(N'Piskupovo')," +
          "(N'Pištane')," +
          "(N'Plava')," +
          "(N'Plavkovo')," +
          "(N'Plavljane')," +
          "(N'Plavna')," +
          "(N'Plavce')," +
          "(N'Plažane')," +
          "(N'Plajnik')," +
          "(N'Plakaonica')," +
          "(N'Plana')," +
          "(N'Plandište')," +
          "(N'Planeja')," +
          "(N'Planina')," +
          "(N'Planinica')," +
          "(N'Planjane')," +
          "(N'Plaskovac')," +
          "(N'Platičevo')," +
          "(N'Plašće')," +
          "(N'Plemetina')," +
          "(N'Plenibabe')," +
          "(N'Pleš')," +
          "(N'Plešin')," +
          "(N'Plešina')," +
          "(N'Plitković')," +
          "(N'Ploča')," +
          "(N'Pločica')," +
          "(N'Pločice')," +
          "(N'Pločnik')," +
          "(N'Plužac')," +
          "(N'Plužina')," +
          "(N'Pljakovo')," +
          "(N'Pljančor')," +
          "(N'Pljačkovica')," +
          "(N'Pobeda')," +
          "(N'Pobrđe')," +
          "(N'Poganovo')," +
          "(N'Pogled')," +
          "(N'Pograđe')," +
          "(N'Poda')," +
          "(N'Podvis')," +
          "(N'Podvrška')," +
          "(N'Podgorac')," +
          "(N'Podgorce')," +
          "(N'Podgrađe')," +
          "(N'Podina')," +
          "(N'Podlokanj')," +
          "(N'Podnemić')," +
          "(N'Podrimce')," +
          "(N'Podujevo')," +
          "(N'Podunavci')," +
          "(N'Požar')," +
          "(N'Požaranje')," +
          "(N'Požarevac')," +
          "(N'Požega')," +
          "(N'Požegrmac')," +
          "(N'Požeženo')," +
          "(N'Požežina')," +
          "(N'Pozlata')," +
          "(N'Pojate')," +
          "(N'Pojatište')," +
          "(N'Poklek')," +
          "(N'Pokrvenik')," +
          "(N'Pokrevenik')," +
          "(N'Polatna')," +
          "(N'Polička')," +
          "(N'Polokce')," +
          "(N'Polom')," +
          "(N'Poluža')," +
          "(N'Polumir')," +
          "(N'Poljana')," +
          "(N'Poljane')," +
          "(N'Poljanice')," +
          "(N'Poljance')," +
          "(N'Poljaci')," +
          "(N'Poljna')," +
          "(N'Poljska Ržana')," +
          "(N'Pomazatin')," +
          "(N'Pomijača')," +
          "(N'Poneš')," +
          "(N'Ponikve')," +
          "(N'Ponikovica')," +
          "(N'Ponor')," +
          "(N'Ponorac')," +
          "(N'Ponoševac')," +
          "(N'Popadić')," +
          "(N'Pope')," +
          "(N'Popina')," +
          "(N'Popinci')," +
          "(N'Popiće')," +
          "(N'Popova')," +
          "(N'Popovac')," +
          "(N'Popović')," +
          "(N'Popovići')," +
          "(N'Popovica')," +
          "(N'Popovljane')," +
          "(N'Popovnjak')," +
          "(N'Popovo')," +
          "(N'Popovce')," +
          "(N'Popovci')," +
          "(N'Popučke')," +
          "(N'Popšica')," +
          "(N'Porodin')," +
          "(N'Poroštica')," +
          "(N'Poružnica')," +
          "(N'Poskurice')," +
          "(N'Poslište')," +
          "(N'Poslon')," +
          "(N'Postenje')," +
          "(N'Potkomlje')," +
          "(N'Potkrš')," +
          "(N'Potok')," +
          "(N'Potočanje')," +
          "(N'Potočac')," +
          "(N'Potočić')," +
          "(N'Potpeće')," +
          "(N'Potporanj')," +
          "(N'Potreb')," +
          "(N'Potrkanje')," +
          "(N'Poturovce')," +
          "(N'Pousko')," +
          "(N'Pocerski Metković')," +
          "(N'Pocerski Pričinović')," +
          "(N'Pocesje')," +
          "(N'Počekovina')," +
          "(N'Počešće')," +
          "(N'Pravoševo')," +
          "(N'Pralja')," +
          "(N'Pranjani')," +
          "(N'Pranjci')," +
          "(N'Praskovče')," +
          "(N'Prahovo')," +
          "(N'Prača')," +
          "(N'Prva Kutina')," +
          "(N'Prvi Tunel ')," +
          "(N'Prvonekja')," +
          "(N'Prebreza')," +
          "(N'Prevalacja')," +
          "(N'Prevetica')," +
          "(N'Prevešt')," +
          "(N'Prevlak')," +
          "(N'Predvorica')," +
          "(N'Predejane')," +
          "(N'Predole')," +
          "(N'Prekadin')," +
          "(N'Prekale')," +
          "(N'Prekašnica')," +
          "(N'Prekovce')," +
          "(N'Prekodolce')," +
          "(N'Prekoluka')," +
          "(N'Prekonoga')," +
          "(N'Prekonozi')," +
          "(N'Prekopeča')," +
          "(N'Prekopuce')," +
          "(N'Prekopčelica')," +
          "(N'Prekorađa')," +
          "(N'Prelez')," +
          "(N'Prelovac')," +
          "(N'Preljina')," +
          "(N'Premeća')," +
          "(N'Preobraženje')," +
          "(N'Preoce')," +
          "(N'Prepolac')," +
          "(N'Preseka')," +
          "(N'Pre')," +
          "(N'Preslap')," +
          "(N'Pretežana')," +
          "(N'Pretina')," +
          "(N'Pretoke')," +
          "(N'Pretrešnja')," +
          "(N'Pretrkovac')," +
          "(N'Preševo')," +
          "(N'Pržojne')," +
          "(N'Pribovce')," +
          "(N'Priboj')," +
          "(N'Pribojska')," +
          "(N'Pribojske Čelice')," +
          "(N'Privinalava')," +
          "(N'Prigoda')," +
          "(N'Prigrevica')," +
          "(N'Pridvorice')," +
          "(N'Pridoli')," +
          "(N'Prizren')," +
          "(N'Prijanovići')," +
          "(N'Prijevor')," +
          "(N'Prijezdić')," +
          "(N'Prijepolje')," +
          "(N'Prilep')," +
          "(N'Prilepac')," +
          "(N'Prilepnica')," +
          "(N'Prilike')," +
          "(N'Prilipac')," +
          "(N'Prilužje')," +
          "(N'Prisjan')," +
          "(N'Prislonica')," +
          "(N'Pričevac')," +
          "(N'Pričević')," +
          "(N'Priština')," +
          "(N'Prkosava')," +
          "(N'Prlita')," +
          "(N'Prnjavor')," +
          "(N'Provaljenik')," +
          "(N'Provo')," +
          "(N'Progar')," +
          "(N'Progorelica')," +
          "(N'Progoreoci')," +
          "(N'Prokuplje')," +
          "(N'Prolesje')," +
          "(N'Prolom')," +
          "(N'Propaštica')," +
          "(N'Prosek')," +
          "(N'Protopopinci')," +
          "(N'Proštinac')," +
          "(N'Prćenova')," +
          "(N'Prćilovica')," +
          "(N'Prugovac')," +
          "(N'Prugovo')," +
          "(N'Pružanj')," +
          "(N'Pružatovac')," +
          "(N'Prhovoinci')," +
          "(N'Prčevo')," +
          "(N'Pudarci')," +
          "(N'Pukovac')," +
          "(N'Pusta Tušimlja')," +
          "(N'Pustenik')," +
          "(N'Pusto Selo')," +
          "(N'Pusto Šilovo')," +
          "(N'Pustovlah')," +
          "(N'Putinci')," +
          "(N'Putnikovo')," +
          "(N'Puhovac')," +
          "(N'Puhovo')," +
          "(N'Pšanik')," +
          "(N'Rabas')," +
          "(N'Rabe')," +
          "(N'Rabenovac')," +
          "(N'Rabovce')," +
          "(N'Rabrovac')," +
          "(N'Rabrovo')," +
          "(N'Ravanica')," +
          "(N'Ravna')," +
          "(N'Ravna Banja')," +
          "(N'Ravnaora')," +
          "(N'Ravna Dubrava')," +
          "(N'Ravna Reka')," +
          "(N'Ravnaja')," +
          "(N'Ravni')," +
          "(N'Ravni Del')," +
          "(N'Ravni Do')," +
          "(N'Ravni Topolovac')," +
          "(N'Ravni Šort')," +
          "(N'Ravnište')," +
          "(N'Ravno Bučje')," +
          "(N'Ravno Selo')," +
          "(N'Ravnje')," +
          "(N'Ragodeš')," +
          "(N'Radavac')," +
          "(N'Radalj')," +
          "(N'Radaljevo')," +
          "(N'Radaljica')," +
          "(N'Radanovci')," +
          "(N'Radevo')," +
          "(N'Radevce')," +
          "(N'Radejna')," +
          "(N'Radenka')," +
          "(N'Radenkovac')," +
          "(N'Radenković')," +
          "(N'Radešaora')," +
          "(N'Radivojce')," +
          "(N'Radijevići')," +
          "(N'Radikina Bara')," +
          "(N'Radinac')," +
          "(N'Radinovac')," +
          "(N'Radinjince')," +
          "(N'Radičevac')," +
          "(N'Radičević')," +
          "(N'Radičevci')," +
          "(N'Radiševo')," +
          "(N'Radljevo')," +
          "(N'Radmanovo')," +
          "(N'Radmilović')," +
          "(N'Radmirovac')," +
          "(N'Radobić')," +
          "(N'Radobuđa')," +
          "(N'Radovanje')," +
          "(N'Radovašnica ')," +
          "(N'Radovnica')," +
          "(N'Radovci')," +
          "(N'Radoinja')," +
          "(N'Radojevo')," +
          "(N'Radonjić')," +
          "(N'Radonjica')," +
          "(N'Radosin')," +
          "(N'Radoste')," +
          "(N'Radoševac')," +
          "(N'Radoševac')," +
          "(N'Radoševac')," +
          "(N'Radoševo')," +
          "(N'Radošin')," +
          "(N'Radošiće')," +
          "(N'Radujevac')," +
          "(N'Radulovac')," +
          "(N'Radunje')," +
          "(N'Raduhovce')," +
          "(N'Raduša')," +
          "(N'Rađevo Selo')," +
          "(N'Ražanj')," +
          "(N'Raždaginja')," +
          "(N'Razbojna')," +
          "(N'Razgojna')," +
          "(N'Rajanovce')," +
          "(N'Rajac')," +
          "(N'Rajetiće')," +
          "(N'Rajinac')," +
          "(N'Rajince')," +
          "(N'Rajkinac')," +
          "(N'Rajkovac')," +
          "(N'Rajković')," +
          "(N'Rajkoviće')," +
          "(N'Rajno Polje')," +
          "(N'Rajčevce')," +
          "(N'Rajčetine')," +
          "(N'Rajčilovci')," +
          "(N'Rajčinoviće')," +
          "(N'Rajčinovićka Trnava')," +
          "(N'Raka')," +
          "(N'Rakari')," +
          "(N'Rakinac')," +
          "(N'Rakinica')," +
          "(N'Rakita')," +
          "(N'Rakitnica')," +
          "(N'Rakitovo')," +
          "(N'Raklja')," +
          "(N'Rakov Dol')," +
          "(N'Rakova')," +
          "(N'Rakova Bara')," +
          "(N'Rakovac')," +
          "(N'Rakovina')," +
          "(N'Rakovica')," +
          "(N'Rakoc')," +
          "(N'Rakoš')," +
          "(N'Ralja')," +
          "(N'Raljin')," +
          "(N'Ram')," +
          "(N'Ramaća')," +
          "(N'Ramoc')," +
          "(N'Ramoševo')," +
          "(N'Ranatovce')," +
          "(N'Randubrava')," +
          "(N'Ranilović')," +
          "(N'Ranilug')," +
          "(N'Rankova Reka')," +
          "(N'Ranovac')," +
          "(N'Ranutovac')," +
          "(N'Rance')," +
          "(N'Rančiće')," +
          "(N'Raskovo')," +
          "(N'Rasna')," +
          "(N'Rasnica')," +
          "(N'Rasno')," +
          "(N'Raspoganče')," +
          "(N'Rast')," +
          "(N'Rastavica')," +
          "(N'Rastelica')," +
          "(N'Rastenoviće')," +
          "(N'Rastina')," +
          "(N'Rastište')," +
          "(N'Rastovnica')," +
          "(N'Rataje')," +
          "(N'Ratajska')," +
          "(N'Ratare')," +
          "(N'Ratari')," +
          "(N'Ratina')," +
          "(N'Ratkovac')," +
          "(N'Ratković')," +
          "(N'Ratkovo')," +
          "(N'Rautovo')," +
          "(N'Raušić')," +
          "(N'Rafuna')," +
          "(N'Rahovica')," +
          "(N'Racaj')," +
          "(N'Rača')," +
          "(N'Račak')," +
          "(N'Rašanac')," +
          "(N'Raševica')," +
          "(N'Rašince')," +
          "(N'Rašić')," +
          "(N'Rašica')," +
          "(N'Raška')," +
          "(N'Rašković')," +
          "(N'Raškoviće')," +
          "(N'Raškoc')," +
          "(N'Raštane')," +
          "(N'Rvati')," +
          "(N'Rvatska')," +
          "(N'Rgaje')," +
          "(N'Rgotina')," +
          "(N'Rgošte')," +
          "(N'Rdovo')," +
          "(N'Rđavica')," +
          "(N'Rebelj')," +
          "(N'Revuće')," +
          "(N'Režance')," +
          "(N'Reževiće')," +
          "(N'Rezala')," +
          "(N'Reka')," +
          "(N'Rekovac')," +
          "(N'Reljan')," +
          "(N'Reljinac')," +
          "(N'Reljinci')," +
          "(N'Renovac')," +
          "(N'Rence')," +
          "(N'Repa')," +
          "(N'Repince')," +
          "(N'Repište')," +
          "(N'Repušnica')," +
          "(N'Resavica')," +
          "(N'Resavica (selo)')," +
          "(N'Resen')," +
          "(N'Resinac')," +
          "(N'Resnik')," +
          "(N'Restelica Gora')," +
          "(N'Retimlje')," +
          "(N'Retkocer')," +
          "(N'Rečane')," +
          "(N'Rečica')," +
          "(N'Rečice')," +
          "(N'Rečka')," +
          "(N'Ržana ')," +
          "(N'Ržanica')," +
          "(N'Rznić')," +
          "(N'Ribare')," +
          "(N'Ribari')," +
          "(N'Ribariće')," +
          "(N'Ribarice')," +
          "(N'Ribarska Banja')," +
          "(N'Ribarci')," +
          "(N'Ribaševina')," +
          "(N'Ribince')," +
          "(N'Ribnik')," +
          "(N'Ribnica')," +
          "(N'Rivica')," +
          "(N'Riđage')," +
          "(N'Riđake')," +
          "(N'Riđevštica')," +
          "(N'Riđica')," +
          "(N'Rikačevo')," +
          "(N'Riljac')," +
          "(N'Rimanište')," +
          "(N'Ripaj')," +
          "(N'Ripanjac')," +
          "(N'Ristovac')," +
          "(N'Ritiševo')," +
          "(N'Ritopek')," +
          "(N'Ritošići')," +
          "(N'Rlica')," +
          "(N'Roanda')," +
          "(N'Robaje')," +
          "(N'Robovac')," +
          "(N'Rovine')," +
          "(N'Rovni')," +
          "(N'Rogavčina')," +
          "(N'Rogača')," +
          "(N'Rogačica')," +
          "(N'Roge')," +
          "(N'Rogljevo')," +
          "(N'Rogovo')," +
          "(N'Rogojevac')," +
          "(N'Rodelj')," +
          "(N'Rožanstvo')," +
          "(N'Rožanci')," +
          "(N'Roždace')," +
          "(N'Rožina')," +
          "(N'Rokci')," +
          "(N'Romaja')," +
          "(N'Romune')," +
          "(N'Ropica')," +
          "(N'Ropočevo')," +
          "(N'Rosići')," +
          "(N'Rosica')," +
          "(N'Rosomač')," +
          "(N'Rosulje')," +
          "(N'Roćevac')," +
          "(N'Roćevići')," +
          "(N'Rošci')," +
          "(N'Rsavci')," +
          "(N'Rsovac')," +
          "(N'Rsovci')," +
          "(N'Rtanj')," +
          "(N'Rtari')," +
          "(N'Rti')," +
          "(N'Rtkovo')," +
          "(N'Rubribreza')," +
          "(N'Ruda Bukva')," +
          "(N'Rudare')," +
          "(N'Rudenice')," +
          "(N'Rudine')," +
          "(N'Rudinje')," +
          "(N'Rudice')," +
          "(N'Rudnalava')," +
          "(N'Rudnik')," +
          "(N'Rudnica')," +
          "(N'Rudno')," +
          "(N'Rudnjak')," +
          "(N'Rudovci')," +
          "(N'Ruđa')," +
          "(N'Ruđinci')," +
          "(N'Ružić')," +
          "(N'Rujevac')," +
          "(N'Rujevica')," +
          "(N'Rujišnik')," +
          "(N'Rujište')," +
          "(N'Rujkovac')," +
          "(N'Rujnik')," +
          "(N'Ruklada')," +
          "(N'Ruma')," +
          "(N'Rumenka')," +
          "(N'Rumska ')," +
          "(N'Runjani')," +
          "(N'Runjevo')," +
          "(N'Rupeljevo')," +
          "(N'Ruplje')," +
          "(N'Rusinovce')");
            migrationBuilder.Sql(
          "insert into Mesta(NazivMesta) values " +
          "(N'Ruski Krstur')," +
          "(N'Rusko Selo')," +
          "(N'Rusna')," +
          "(N'Rusce')," +
          "(N'Rutevac')," +
          "(N'Rutoši')," +
          "(N'Ruhot')," +
          "(N'Rucka')," +
          "(N'Rucmance')," +
          "(N'Ručići')," +
          "(N'Rušanj')," +
          "(N'Savinac')," +
          "(N'Savino Selo Vrbas')," +
          "(N'Savković')," +
          "(N'Savovo')," +
          "(N'Savrovo')," +
          "(N'Sagonjevo')," +
          "(N'Sazlija')," +
          "(N'Sainovina')," +
          "(N'Sajan')," +
          "(N'Sakar')," +
          "(N'Sakulepovo')," +
          "(N'Sakulja')," +
          "(N'Salakovac')," +
          "(N'Salaš')," +
          "(N'Salaš Noćajski')," +
          "(N'Salaš Crnobarski')," +
          "(N'Samaila')," +
          "(N'Samarinovac')," +
          "(N'Samarnica')," +
          "(N'Samodraža')," +
          "(N'Samodreža')," +
          "(N'Samokovo')," +
          "(N'Samoljica')," +
          "(N'Samoš')," +
          "(N'Sanad')," +
          "(N'Sandalj')," +
          "(N'Sanković')," +
          "(N'Sanovac')," +
          "(N'Sapar')," +
          "(N'Saranovo')," +
          "(N'Saraorci')," +
          "(N'Saroš')," +
          "(N'Sastav Reka')," +
          "(N'Saš')," +
          "(N'Sveta Petka')," +
          "(N'Svetićevo')," +
          "(N'Svetlić')," +
          "(N'Svetlje')," +
          "(N'Svetozar Miletić')," +
          "(N'Sveštica')," +
          "(N'Svilajnac')," +
          "(N'Svileuva')," +
          "(N'Svilojevo')," +
          "(N'Sviloš')," +
          "(N'Svinjare')," +
          "(N'Svinjarevo')," +
          "(N'Svinjarica')," +
          "(N'Svinjište')," +
          "(N'Svirce')," +
          "(N'Svođe')," +
          "(N'Svojnovo')," +
          "(N'Svračkovo')," +
          "(N'Svračkovci')," +
          "(N'Svrke')," +
          "(N'Svrljig')," +
          "(N'Svrljiška Topla')," +
          "(N'Svrhe')," +
          "(N'Svrčina')," +
          "(N'Sebečevac')," +
          "(N'Sebečevo')," +
          "(N'Sebimilje')," +
          "(N'Sebrat')," +
          "(N'Severni Kočarnik')," +
          "(N'Severovo')," +
          "(N'Sevojno')," +
          "(N'Sevce')," +
          "(N'Sedlare')," +
          "(N'Sedlari')," +
          "(N'Sedobro')," +
          "(N'Sezemče')," +
          "(N'Sejace')," +
          "(N'Sekirača')," +
          "(N'Sekicol')," +
          "(N'Sekurič')," +
          "(N'Selanac')," +
          "(N'Selačka')," +
          "(N'Selevac')," +
          "(N'Selenča')," +
          "(N'Seleuš')," +
          "(N'Selište')," +
          "(N'Selo')," +
          "(N'Selova')," +
          "(N'Selogražde')," +
          "(N'Seljane')," +
          "(N'Seljance ')," +
          "(N'Seljašnica')," +
          "(N'Semanje')," +
          "(N'Semegnjevo')," +
          "(N'Semedraž')," +
          "(N'Semeteš')," +
          "(N'Semetište')," +
          "(N'Semče')," +
          "(N'Sena')," +
          "(N'Senaja')," +
          "(N'Sendo')," +
          "(N'Senik')," +
          "(N'Seništa')," +
          "(N'Senokos')," +
          "(N'Senta')," +
          "(N'Senje')," +
          "(N'Senjski Rudnik')," +
          "(N'Seone')," +
          "(N'Seoce')," +
          "(N'Sepci')," +
          "(N'Sesalac')," +
          "(N'Sefer')," +
          "(N'Sefkerinpovo')," +
          "(N'Seča Reka')," +
          "(N'Sečanica')," +
          "(N'Sečanj')," +
          "(N'Sečište')," +
          "(N'Sibačinci')," +
          "(N'Sibnica')," +
          "(N'Sibovac')," +
          "(N'Sivac')," +
          "(N'Sivčina')," +
          "(N'Siga')," +
          "(N'Sige')," +
          "(N'Siget')," +
          "(N'Sijarina')," +
          "(N'Sijarinska Banja')," +
          "(N'Sijerač')," +
          "(N'Sikirica')," +
          "(N'Sikirje')," +
          "(N'Sikole')," +
          "(N'Silbaš')," +
          "(N'Siljevica')," +
          "(N'Simino Brdo')," +
          "(N'Simićevo')," +
          "(N'Sinaje')," +
          "(N'Sinošević ')," +
          "(N'Sinoševići')," +
          "(N'Sinjalava')," +
          "(N'Sinjac')," +
          "(N'Sinji Vir')," +
          "(N'Siokovac')," +
          "(N'Sipić')," +
          "(N'Sirakovo')," +
          "(N'Sirdija')," +
          "(N'Sirig')," +
          "(N'Sirogojno')," +
          "(N'Sirča')," +
          "(N'Sisevac')," +
          "(N'Sitarice')," +
          "(N'Sitniče')," +
          "(N'Sićevo')," +
          "(N'Sjeverin')," +
          "(N'Sjenica')," +
          "(N'Skadar')," +
          "(N'Skakavci')," +
          "(N'Skela')," +
          "(N'Skivjane')," +
          "(N'Skobalj')," +
          "(N'Skokuće')," +
          "(N'Skorenovac')," +
          "(N'Skorica')," +
          "(N'Skorobište')," +
          "(N'Skorošnik')," +
          "(N'Skočna')," +
          "(N'Skradnik')," +
          "(N'Skrađani ')," +
          "(N'Skrapež')," +
          "(N'Skrvenica')," +
          "(N'Skržuti')," +
          "(N'Skrobnica')," +
          "(N'Skrovna')," +
          "(N'Skukovo')," +
          "(N'Skulanevo')," +
          "(N'Skupljen')," +
          "(N'Slavinja')," +
          "(N'Slavkovica')," +
          "(N'Slavnik')," +
          "(N'Slavujevac')," +
          "(N'Slavujevce')," +
          "(N'Sladaja')," +
          "(N'Sladinac')," +
          "(N'Slakovce')," +
          "(N'Slankamenački Vinogradi')," +
          "(N'Slanci')," +
          "(N'Slapužane')," +
          "(N'Slatina')," +
          "(N'Slepčević')," +
          "(N'Slivje')," +
          "(N'Slivnica')," +
          "(N'Slivovo')," +
          "(N'Slišane')," +
          "(N'Slovac')," +
          "(N'Slovinje')," +
          "(N'Slubica')," +
          "(N'Slup')," +
          "(N'Smać')," +
          "(N'Smederevo')," +
          "(N'Smederevska Palanka')," +
          "(N'Smedovac')," +
          "(N'Smilov Laz')," +
          "(N'Smilovac')," +
          "(N'Smilovci')," +
          "(N'Smiljevac')," +
          "(N'Smiljević')," +
          "(N'Smira')," +
          "(N'Smoluća')," +
          "(N'Smoluša')," +
          "(N'Smoljinac')," +
          "(N'Smonica')," +
          "(N'Smrdan')," +
          "(N'Smrekovnica')," +
          "(N'Snegotin')," +
          "(N'Sovač')," +
          "(N'Sovljak')," +
          "(N'Soderce')," +
          "(N'Sojevo')," +
          "(N'Sokobanja')," +
          "(N'Sokolac')," +
          "(N'Sokolići')," +
          "(N'Sokolovo')," +
          "(N'Solačka Sena')," +
          "(N'Solotuša')," +
          "(N'Sombor')," +
          "(N'Sonta')," +
          "(N'Sopina')," +
          "(N'Sopnić')," +
          "(N'Sopot')," +
          "(N'Sopotnica')," +
          "(N'Sot')," +
          "(N'Sofalija')," +
          "(N'Softović')," +
          "(N'Sočanica')," +
          "(N'Sočica')," +
          "(N'Sočice')," +
          "(N'Spance')," +
          "(N'Spančevac')," +
          "(N'Sponce')," +
          "(N'Srbica')," +
          "(N'Srbobran')," +
          "(N'Srbovac')," +
          "(N'Srbovo')," +
          "(N'Srednja Dobrinja')," +
          "(N'Srednja')," +
          "(N'Srednja Tušimlja')," +
          "(N'Srednjevo')," +
          "(N'Srednji Bučumet')," +
          "(N'Srednji Del')," +
          "(N'Srednji Salaš')," +
          "(N'Srednji Statovac')," +
          "(N'Sredor')," +
          "(N'Sredska')," +
          "(N'Srezovac')," +
          "(N'Srezojevci')," +
          "(N'Sremska Kamenica')," +
          "(N'Sremska Mitrovica')," +
          "(N'Sremska')," +
          "(N'Sremski Karlovci')," +
          "(N'Sremski Mihaljevci')," +
          "(N'Sremčica')," +
          "(N'Srećkovac')," +
          "(N'Srndalje')," +
          "(N'Srneći Dol')," +
          "(N'Srnje')," +
          "(N'Srpska Kuća')," +
          "(N'Srpska Crnja')," +
          "(N'Srpski')," +
          "(N'Srpski Itebej')," +
          "(N'Srpski Krstur')," +
          "(N'Srpski Miletić')," +
          "(N'Srpce')," +
          "(N'Stave')," +
          "(N'Stagovo')," +
          "(N'Stajićevo')," +
          "(N'Stajkovce')," +
          "(N'Stalać')," +
          "(N'Stamnica')," +
          "(N'Stanevce')," +
          "(N'Stanina Reka')," +
          "(N'Staničenje')," +
          "(N'Stanišinci')," +
          "(N'Stanišić')," +
          "(N'Stanišor')," +
          "(N'Stankovce')," +
          "(N'Stanuloviće')," +
          "(N'Stance')," +
          "(N'Stanci')," +
          "(N'Stanča')," +
          "(N'Stančić')," +
          "(N'Stančići')," +
          "(N'Stanjevo')," +
          "(N'Stanjinac')," +
          "(N'Stapar')," +
          "(N'Stapari')," +
          "(N'Stara Banja')," +
          "(N'Stara Bingula')," +
          "(N'Stara Božurna')," +
          "(N'Stara Brezovica')," +
          "(N'Stara Vučina')," +
          "(N'Stara Moravica')," +
          "(N'Stara Pazova')," +
          "(N'Starac')," +
          "(N'Stari Banovci')," +
          "(N'Stari Bračin')," +
          "(N'Starilog')," +
          "(N'Stari Đurovac')," +
          "(N'Stari Žednik')," +
          "(N'Stari')," +
          "(N'Stari Ledinci')," +
          "(N'Stari Lec ')," +
          "(N'Stari Miraš')," +
          "(N'Stari Slankamen')," +
          "(N'Stari Trg (rud.naselje)')," +
          "(N'Stari')," +
          "(N'Staroracko')," +
          "(N'Staro Korito')," +
          "(N'Staro Lanište')," +
          "(N'Staro Momčilovo')," +
          "(N'Staro Rujce')," +
          "(N'Staro Selo')," +
          "(N'Staro')," +
          "(N'Starodvorane')," +
          "(N'Starci')," +
          "(N'Starčeviće')," +
          "(N'Starčevo')," +
          "(N'Stejanovci')," +
          "(N'Stenjevac')," +
          "(N'Stepanovićevo')," +
          "(N'Stepanje')," +
          "(N'Stepojevac')," +
          "(N'Sterijino')," +
          "(N'Stogazovac')," +
          "(N'Stojačak')," +
          "(N'Stojići')," +
          "(N'Stojković')," +
          "(N'Stojnik')," +
          "(N'Stol')," +
          "(N'Stopanja')," +
          "(N'Stragari')," +
          "(N'Stradovo')," +
          "(N'Straža')," +
          "(N'Strajiniće')," +
          "(N'Strana')," +
          "(N'Stranjevo')," +
          "(N'Strezimirovci')," +
          "(N'Strezovce')," +
          "(N'Strelac')," +
          "(N'Strelica')," +
          "(N'Strešak')," +
          "(N'Striža')," +
          "(N'Strižilo')," +
          "(N'Strmac')," +
          "(N'Strmenica')," +
          "(N'Strmnaora')," +
          "(N'Strmovo')," +
          "(N'Strmosten')," +
          "(N'Strovce')," +
          "(N'Strojinci')," +
          "(N'Strojkovce')," +
          "(N'Stropsko')," +
          "(N'Struganik')," +
          "(N'Struganica')," +
          "(N'Stružje')," +
          "(N'Strumce')," +
          "(N'Stubal')," +
          "(N'Stubica')," +
          "(N'Stubla')," +
          "(N'Stublenica')," +
          "(N'Stublina')," +
          "(N'Stubline')," +
          "(N'Stublica')," +
          "(N'Stublo')," +
          "(N'Stubo')," +
          "(N'Studena')," +
          "(N'Studenac')," +
          "(N'Studenica')," +
          "(N'Studenčane')," +
          "(N'Stup')," +
          "(N'Stupnica')," +
          "(N'Stupčevići')," +
          "(N'Subjel')," +
          "(N'Subotinac')," +
          "(N'Subotica')," +
          "(N'Subotište')," +
          "(N'Suva Morava')," +
          "(N'Suva Reka')," +
          "(N'Suvaja')," +
          "(N'Suvi Do')," +
          "(N'Suvi Dol')," +
          "(N'Suvi Lukavac')," +
          "(N'Suvorlo')," +
          "(N'Suvo Selo')," +
          "(N'Suvodanje')," +
          "(N'Suvodol')," +
          "(N'Suvojnica')," +
          "(N'Sugubine')," +
          "(N'Sudimlja')," +
          "(N'Sudsko Selo')," +
          "(N'Sukovo')," +
          "(N'Sumorovac')," +
          "(N'Sumrakovac')," +
          "(N'Supnje')," +
          "(N'Supovac')," +
          "(N'Supska')," +
          "(N'Suračevo')," +
          "(N'Surduk')," +
          "(N'Surdul')," +
          "(N'Surdula')," +
          "(N'Surdulica')," +
          "(N'Surkiš')," +
          "(N'Surlica')," +
          "(N'Surčin')," +
          "(N'Susek')," +
          "(N'Sutjeska')," +
          "(N'Suharno')," +
          "(N'Suhi Dol')," +
          "(N'Suševlje')," +
          "(N'Sušiće')," +
          "(N'Sušica')," +
          "(N'Tabakovac')," +
          "(N'Tabanović')," +
          "(N'Tabanovići')," +
          "(N'Tavnik')," +
          "(N'Tadenje')," +
          "(N'Takovo')," +
          "(N'Tamnič')," +
          "(N'Tamnjanica')," +
          "(N'Tanda')," +
          "(N'Tankosić')," +
          "(N'Taor')," +
          "(N'Taradža')," +
          "(N'Taraš')," +
          "(N'Taskovići')," +
          "(N'Tatrasnica')," +
          "(N'Tačevac')," +
          "(N'Taševo')," +
          "(N'Tvrdići')," +
          "(N'Tvrdojevac')," +
          "(N'Tvrđan')," +
          "(N'Tegovište')," +
          "(N'Tegošnica')," +
          "(N'Tekeriš')," +
          "(N'Tekija')," +
          "(N'Telečka')," +
          "(N'Telovac')," +
          "(N'Temerin')," +
          "(N'Temska')," +
          "(N'Teneš Do')," +
          "(N'Tenkovo')," +
          "(N'Teočinornji')," +
          "(N'Tepeče')," +
          "(N'Tesovište')," +
          "(N'Teća')," +
          "(N'Tečić')," +
          "(N'Tešica')," +
          "(N'Tibužde')," +
          "(N'Tijanje')," +
          "(N'Tijovac')," +
          "(N'Tikva')," +
          "(N'Tiodže')," +
          "(N'Tirince')," +
          "(N'Tisovica')," +
          "(N'Titel')," +
          "(N'Tićevac')," +
          "(N'Tica')," +
          "(N'Tmava')," +
          "(N'Toba')," +
          "(N'Tobolac')," +
          "(N'Tovariševo')," +
          "(N'Tovrljane')," +
          "(N'Togočevce')," +
          "(N'Todorin Do')," +
          "(N'Todorovce')," +
          "(N'Tolisavac')," +
          "(N'Tolić')," +
          "(N'Tolišnica')," +
          "(N'Toljevac')," +
          "(N'Tomance')," +
          "(N'Tomanj')," +
          "(N'Tomaševac')," +
          "(N'Tometino Polje')," +
          "(N'Tomislavci')," +
          "(N'Topilo')," +
          "(N'Topla')," +
          "(N'Toplac')," +
          "(N'Topli Do')," +
          "(N'Topli Dol')," +
          "(N'Topličane')," +
          "(N'Topola')," +
          "(N'Topolnica')," +
          "(N'Topolovnik')," +
          "(N'Toponica')," +
          "(N'Torak')," +
          "(N'Torina')," +
          "(N'Tornik')," +
          "(N'Tornjoš')," +
          "(N'Totovo Selo')," +
          "(N'Točilovo')," +
          "(N'Trakanić')," +
          "(N'Trbovce')," +
          "(N'Trbosilje')," +
          "(N'Trbunje')," +
          "(N'Trbuhovac')," +
          "(N'Trbušani')," +
          "(N'Trbušac')," +
          "(N'Trbušnica')," +
          "(N'Trgovište')," +
          "(N'Trdevac')," +
          "(N'Trebinje')," +
          "(N'Trebiće')," +
          "(N'Trebović')," +
          "(N'Trebotin')," +
          "(N'Trejak')," +
          "(N'Trepetinca')," +
          "(N'Trećak')," +
          "(N'Trešnjevak')," +
          "(N'Trešnjevac')," +
          "(N'Trešnjevica')," +
          "(N'Tržac')," +
          "(N'Tribrode')," +
          "(N'Trijebine')," +
          "(N'Trikose')," +
          "(N'Tripkova')," +
          "(N'Trlabuć')," +
          "(N'Trlić')," +
          "(N'Trmbas')," +
          "(N'Trmka')," +
          "(N'Trmčare')," +
          "(N'Trn')," +
          "(N'Trnava')," +
          "(N'Trnavac')," +
          "(N'Trnavica')," +
          "(N'Trnavce')," +
          "(N'Trnavci')," +
          "(N'Trnićevce')," +
          "(N'Trnovac')," +
          "(N'Trnovi Laz')," +
          "(N'Trnovče')," +
          "(N'Trnski dorovci')," +
          "(N'Trnjana')," +
          "(N'Trnjaci')," +
          "(N'Trnje')," +
          "(N'Troponje')," +
          "(N'Troskač')," +
          "(N'Trpeza')," +
          "(N'Trpeze')," +
          "(N'Trska')," +
          "(N'Trstena')," +
          "(N'Trstenik')," +
          "(N'Trstenica')," +
          "(N'Trubarevac')," +
          "(N'Trubarevo')," +
          "(N'Trudelj')," +
          "(N'Trudna')," +
          "(N'Trudovo')," +
          "(N'Trupale')," +
          "(N'Trućevac')," +
          "(N'Tršanovci')," +
          "(N'Tršić')," +
          "(N'Tubići')," +
          "(N'Tubravić')," +
          "(N'Tuđevce')," +
          "(N'Tuđin')," +
          "(N'Tuzinje')," +
          "(N'Tulare')," +
          "(N'Tulari')," +
          "(N'Tulež')," +
          "(N'Tuleš')," +
          "(N'Tulovo')," +
          "(N'Tumba')," +
          "(N'Tumičina')," +
          "(N'Tunovo')," +
          "(N'Tupale')," +
          "(N'Tupalovce')," +
          "(N'Tupanci')," +
          "(N'Tupec')," +
          "(N'Turekovac')," +
          "(N'Turija')," +
          "(N'Turićevac')," +
          "(N'Turica')," +
          "(N'Turjak')," +
          "(N'Turjane')," +
          "(N'Turučica')," +
          "(N'Tutin')," +
          "(N'Tutiće')," +
          "(N'Tučep')," +
          "(N'Tučkovo')," +
          "(N'Tušilje')," +
          "(N'Tušiće')," +
          "(N'Ćelije')," +
          "(N'Ćenovac')," +
          "(N'Ćerim')," +
          "(N'Ćešanoviće')," +
          "(N'Ćirez')," +
          "(N'Ćirikovac')," +
          "(N'Ćirkoviće')," +
          "(N'Ćićevac')," +
          "(N'Ćićina')," +
          "(N'Ćovdin')," +
          "(N'Ćukovac')," +
          "(N'Ćukovine')," +
          "(N'Ćulije')," +
          "(N'Ćuprija')," +
          "(N'Ćurkovica')," +
          "(N'Ćurlina')," +
          "(N'Ćuška')," +
          "(N'Ćuštica')," +
          "(N'Ub')," +
          "(N'Uvac')," +
          "(N'Ugao')," +
          "(N'Ugljare')," +
          "(N'Ugljarevac')," +
          "(N'Ugljarevo')," +
          "(N'Ugrinovci')," +
          "(N'Udovice')," +
          "(N'Užice')," +
          "(N'Uzveće')," +
          "(N'Uzdin')," +
          "(N'Uzići')," +
          "(N'Uzovnica')," +
          "(N'Uzovo')," +
          "(N'Ujz')," +
          "(N'Ukča')," +
          "(N'Ulije')," +
          "(N'Uljma')," +
          "(N'Umka')," +
          "(N'Umčari')," +
          "(N'Urvič')," +
          "(N'Urmanica')," +
          "(N'Urovica')," +
          "(N'Urovci')," +
          "(N'Uroševac')," +
          "(N'Ursule')," +
          "(N'Usije')," +
          "(N'Utrine')," +
          "(N'Ušak')," +
          "(N'Uševce')," +
          "(N'Ušće')," +
          "(N'Farkaždin')," +
          "(N'Feketić')," +
          "(N'Fijulj')," +
          "(N'Filipovići')," +
          "(N'Filić')," +
          "(N'Firaja')," +
          "(N'Firza')," +
          "(N'Firićeja')," +
          "(N'Futog')," +
          "(N'Hajdukovo')," +
          "(N'Hajdučica')," +
          "(N'Halovo')," +
          "(N'Hamidija')," +
          "(N'Hadžovići')," +
          "(N'Hercegovo')," +
          "(N'Hetin')," +
          "(N'Hisardžik')," +
          "(N'Horgoš')," +
          "(N'Hotkovo')," +
          "(N'Hoča')," +
          "(N'Hrta')," +
          "(N'Hrtica')," +
          "(N'Hrtkovci')," +
          "(N'Huljaj')," +
          "(N'Hum')," +
          "(N'Cakanovac')," +
          "(N'Caparić')," +
          "(N'Caparce')," +
          "(N'Carevac')," +
          "(N'Carevce')," +
          "(N'Carina')," +
          "(N'Caričina')," +
          "(N'Cvetanovac')," +
          "(N'Cvetke')," +
          "(N'Cvetovac')," +
          "(N'Cvetojevac')," +
          "(N'Cvetulja')," +
          "(N'Cekavica')," +
          "(N'Celina')," +
          "(N'Ceranja')," +
          "(N'Cerev Del')," +
          "(N'Cerevajka')," +
          "(N'Ceremošnja')," +
          "(N'Cerje')," +
          "(N'Cernica')," +
          "(N'Cerovaornji')," +
          "(N'Cerova')," +
          "(N'Cerovac')," +
          "(N'Cerovik')," +
          "(N'Cerovica')," +
          "(N'Cerovo')," +
          "(N'Cetanoviće')," +
          "(N'Cecelija')," +
          "(N'Cikot')," +
          "(N'Cikote')," +
          "(N'Cokoviće')," +
          "(N'Crvena Jabuka')," +
          "(N'Crvena Reka')," +
          "(N'Crvena Crkva')," +
          "(N'Crveni')," +
          "(N'Crveni Breg')," +
          "(N'Crvenirad')," +
          "(N'Crvenka')," +
          "(N'Crvenčevo')," +
          "(N'Crvenje')," +
          "(N'Crvica')," +
          "(N'Crvsko')," +
          "(N'Crepaja')," +
          "(N'Crepulja')," +
          "(N'Crkvena')," +
          "(N'Crkvenac')," +
          "(N'Crkveni Toci')," +
          "(N'Crkvina')," +
          "(N'Crkvine')," +
          "(N'Crkvica')," +
          "(N'Crkovnica')," +
          "(N'Crkolez')," +
          "(N'Crljenac')," +
          "(N'Crmljane')," +
          "(N'Crna Bara')," +
          "(N'Crnalava')," +
          "(N'Crna Reka')," +
          "(N'Crna Trava')," +
          "(N'Crnajka')," +
          "(N'Crnatovo')," +
          "(N'Crni Breg')," +
          "(N'Crni Vrh')," +
          "(N'Crni Kao')," +
          "(N'Crni Lug')," +
          "(N'Crnilo')," +
          "(N'Crnovrana')," +
          "(N'Crnovce')," +
          "(N'Crnoklište')," +
          "(N'Crnoljevica')," +
          "(N'Crnoljevo')," +
          "(N'Crnomasnica')," +
          "(N'Crnotince')," +
          "(N'Crnoštica')," +
          "(N'Crnugovići')," +
          "(N'Crnuzi')," +
          "(N'Crnce')," +
          "(N'Crnča')," +
          "(N'Crnče')," +
          "(N'Crcavac')," +
          "(N'Crčevo')," +
          "(N'Culine')," +
          "(N'Culjković')," +
          "(N'Čabić')," +
          "(N'Čabra')," +
          "(N'Čaglavica')," +
          "(N'Čagrovac')," +
          "(N'Čadinje')," +
          "(N'Čairi')," +
          "(N'Čajdrak')," +
          "(N'Čajetina')," +
          "(N'Čalma')," +
          "(N'Čamurlija')," +
          "(N'Čantavir')," +
          "(N'Čapljinac')," +
          "(N'Čar')," +
          "(N'Čarakovce')," +
          "(N'Čarovina')," +
          "(N'Čauševići')," +
          "(N'Čačak')," +
          "(N'Čašić Dolac')," +
          "(N'Čedovo')," +
          "(N'Čekmin')," +
          "(N'Čelarevo')," +
          "(N'Čelik')," +
          "(N'Čelice')," +
          "(N'Čelopek')," +
          "(N'Čenej')," +
          "(N'Čenta')," +
          "(N'Čepure')," +
          "(N'Čerević')," +
          "(N'Čerkez')," +
          "(N'Českovo')," +
          "(N'Česta')," +
          "(N'Čestelin')," +
          "(N'Čestereg')," +
          "(N'Čestin')," +
          "(N'Čestobrodica')," +
          "(N'Četereže')," +
          "(N'Čečevo')," +
          "(N'Čečina')," +
          "(N'Češko Selo')," +
          "(N'Češljeva Bara')," +
          "(N'Čibukovac')," +
          "(N'Čibutkovica')," +
          "(N'Činiglavci')," +
          "(N'Čipalje')," +
          "(N'Čitak')," +
          "(N'Čitluk')," +
          "(N'Čiflak')," +
          "(N'Čiflik')," +
          "(N'Čifluk Razgojnski')," +
          "(N'Čmanjke')," +
          "(N'Čoka')," +
          "(N'Čokešina')," +
          "(N'Čokonjar')," +
          "(N'Čokot')," +
          "(N'Čokotar')," +
          "(N'Čokotin')," +
          "(N'Čonoplja')," +
          "(N'Čortanovci')," +
          "(N'Čubra')," +
          "(N'Čubrelj')," +
          "(N'Čubura')," +
          "(N'Čuka')," +
          "(N'Čukarka')," +
          "(N'Čukljenik')," +
          "(N'Čukojevac')," +
          "(N'Čukote')," +
          "(N'Čukurovac')," +
          "(N'Čumić')," +
          "(N'Čungula')");
            migrationBuilder.Sql(
            "insert into Mesta(NazivMesta) values " +
            "(N'Čungur')," +
            "(N'Čupevo')," +
            "(N'Čupev')," +
            "(N'Čurug')," +
            "(N'Čučale')," +
            "(N'Čučuge')," +
            "(N'Čučuljaga')," +
            "(N'Džep')," +
            "(N'Džepnica')," +
            "(N'Džigolj')," +
            "(N'Džurovo')," +
            "(N'Šabac')," +
            "(N'Šavac')," +
            "(N'Šavrane')," +
            "(N'Šavci')," +
            "(N'Šainovac')," +
            "(N'Šaić')," +
            "(N'Šajinovac')," +
            "(N'Šajince')," +
            "(N'Šajkaš')," +
            "(N'Šajkovac')," +
            "(N'Šakovica')," +
            "(N'Šalinac')," +
            "(N'Šaludovac')," +
            "(N'Šalce')," +
            "(N'Šaljinovica')," +
            "(N'Šaljska Bistrica')," +
            "(N'Šanac')," +
            "(N'Šantarovac')," +
            "(N'Šapine')," +
            "(N'Šaprance')," +
            "(N'Šaptelj')," +
            "(N'Šaraniornji')," +
            "(N'Šarban')," +
            "(N'Šarbane')," +
            "(N'Šarbanovac')," +
            "(N'Šare')," +
            "(N'Šarenik')," +
            "(N'Šarkamen')," +
            "(N'Šarlinac')," +
            "(N'Šarlince')," +
            "(N'Šaronje')," +
            "(N'Šarce')," +
            "(N'Šatra')," +
            "(N'Šatrinci')," +
            "(N'Šašare')," +
            "(N'Šašilovac')," +
            "(N'Šašinci')," +
            "(N'Šaškovac')," +
            "(N'Šebet')," +
            "(N'Ševarice')," +
            "(N'Ševica')," +
            "(N'Ševiš')," +
            "(N'Ševrljuge')," +
            "(N'Šepšin')," +
            "(N'Šeremet')," +
            "(N'Šestiabar')," +
            "(N'Šetka')," +
            "(N'Šetonje')," +
            "(N'Šid')," +
            "(N'Šilovo')," +
            "(N'Šilopajornji')," +
            "(N'Šiljakovac')," +
            "(N'Šiljomana')," +
            "(N'Šimanovci')," +
            "(N'Šipačina')," +
            "(N'Šipikovo')," +
            "(N'Šipitula')," +
            "(N'Šipova')," +
            "(N'Šipolje')," +
            "(N'Šipče')," +
            "(N'Široka Planina')," +
            "(N'Široke Njive')," +
            "(N'Šišave')," +
            "(N'Šišarka')," +
            "(N'Šišatovac')," +
            "(N'Šišince')," +
            "(N'Šišman')," +
            "(N'Šišmanovac')," +
            "(N'Škoza')," +
            "(N'Škrelje')," +
            "(N'Šljivar')," +
            "(N'Šljivica')," +
            "(N'Šljivova')," +
            "(N'Šljivovac')," +
            "(N'Šljivovik')," +
            "(N'Šljivovica')," +
            "(N'Šljivovo')," +
            "(N'Šogolj')," +
            "(N'Šopić')," +
            "(N'Šošiće')," +
            "(N'Špaj')," +
            "(N'Špiljani')," +
            "(N'Špinadija')," +
            "(N'Štava')," +
            "(N'Štavalj')," +
            "(N'Štavica')," +
            "(N'Štedim')," +
            "(N'Štimlje')," +
            "(N'Šina')," +
            "(N'Štitar')," +
            "(N'Štitare')," +
            "(N'Štitarica')," +
            "(N'Štitkovo')," +
            "(N'Štrbac')," +
            "(N'Štrbovac')," +
            "(N'Štrbulovo')," +
            "(N'Štrpce')," +
            "(N'Štubik')," +
            "(N'Štulac')," +
            "(N'Štuoce')," +
            "(N'Štupelj')," +
            "(N'Štutica')," +
            "(N'Šuvajić')," +
            "(N'Šugrin')," +
            "(N'Šuljam')," +
            "(N'Šuljkovac')," +
            "(N'Šuman Topla')," +
            "(N'Šumane')," +
            "(N'Šumarak')," +
            "(N'Šumarice')," +
            "(N'Šumata')," +
            "(N'Šume')," +
            "(N'Šupkovac')," +
            "(N'Šupljak')," +
            "(N'Šurić')," +
            "(N'Šurice')," +
            "(N'Šurjan')," +
            "(N'Šurlane')," +
            "(N'Šutci')," +
            "(N'Šušara')," +
            "(N'Šušeoka')," +
            "(N'Šušnjar')," +
            "(N'Šušure')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mesta");
        }
    }
}
