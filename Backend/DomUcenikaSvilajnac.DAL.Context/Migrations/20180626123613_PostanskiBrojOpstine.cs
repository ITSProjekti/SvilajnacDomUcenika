using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class PostanskiBrojOpstine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PostanskiBroj",
                table: "Opstine",
                nullable: true);

            migrationBuilder.Sql("update Opstine set PostanskiBroj = 31203 where NazivOpstine = N'Ada'" +
              "update Opstine set PostanskiBroj = 37230 where NazivOpstine = N'Aleksandrovac'" +
              "update Opstine set PostanskiBroj = 18220 where NazivOpstine = N'Aleksinac'" +
              "update Opstine set PostanskiBroj = 26310 where NazivOpstine = N'Alibunar'" +
              "update Opstine set PostanskiBroj = 25260 where NazivOpstine = N'Apatin'" +
              "update Opstine set PostanskiBroj = 34300 where NazivOpstine = N'Aranđelovac'" +
              "update Opstine set PostanskiBroj = 31230 where NazivOpstine = N'Arilje'" +
              "update Opstine set PostanskiBroj = 18330 where NazivOpstine = N'Babušnica'" +
              "update Opstine set PostanskiBroj = 31250 where NazivOpstine = N'Bajina Bašta'" +
              "update Opstine set PostanskiBroj = 11460 where NazivOpstine = N'Barajevo'" +
              "update Opstine set PostanskiBroj = 34227 where NazivOpstine = N'Batočina'" +
              "update Opstine set PostanskiBroj = 21420 where NazivOpstine = N'Bač'" +
              "update Opstine set PostanskiBroj = 21401 where NazivOpstine = N'Bačka Palanka'" +
              "update Opstine set PostanskiBroj = 24300 where NazivOpstine = N'Bačka Topola'" +
              "update Opstine set PostanskiBroj = 21470 where NazivOpstine = N'Bački Petrovac'" +
              "update Opstine set PostanskiBroj = 18310 where NazivOpstine = N'Bela Palanka' " +
              "update Opstine set PostanskiBroj = 26340 where NazivOpstine = N'Bela Crkva'" +
              "update Opstine set PostanskiBroj = 21300 where NazivOpstine = N'Beočin'" +
              "update Opstine set PostanskiBroj = 21220 where NazivOpstine = N'Bečej'" +
              "update Opstine set PostanskiBroj = 18420 where NazivOpstine = N'Blace'" +
              "update Opstine set PostanskiBroj = 15350 where NazivOpstine = N'Bogatić'" +
              "update Opstine set PostanskiBroj = 16205 where NazivOpstine = N'Bojnik'" +
              "update Opstine set PostanskiBroj = 19370 where NazivOpstine = N'Boljevac'" +
              "update Opstine set PostanskiBroj = 19218 where NazivOpstine = N'Bor'" +
              "update Opstine set PostanskiBroj = 17540 where NazivOpstine = N'Bosilegrad'" +
              "update Opstine set PostanskiBroj = 37220 where NazivOpstine = N'Brus'" +
              "update Opstine set PostanskiBroj = 17520 where NazivOpstine = N'Bujanovac'" +
              "update Opstine set PostanskiBroj = 14000 where NazivOpstine = N'Valjevo'" +
              "update Opstine set PostanskiBroj = 37260 where NazivOpstine = N'Varvarin'" +
              "update Opstine set PostanskiBroj = 11320 where NazivOpstine = N'Velika Plana'" +
              "update Opstine set PostanskiBroj = 12220 where NazivOpstine = N'Veliko Gradište'" +
              "update Opstine set PostanskiBroj = 61000 where NazivOpstine = N'Vitina'" +
              "update Opstine set PostanskiBroj = 15225 where NazivOpstine = N'Vladimirci'" +
              "update Opstine set PostanskiBroj = 17510 where NazivOpstine = N'Vladičin Han'" +
              "update Opstine set PostanskiBroj = 16210 where NazivOpstine = N'Vlasotince'" +
              "update Opstine set PostanskiBroj = 11010 where NazivOpstine = N'Voždovac'" +
              "update Opstine set PostanskiBroj = 17500 where NazivOpstine = N'Vranje'" +
              "update Opstine set PostanskiBroj = 11110 where NazivOpstine = N'Vračar'" +
              "update Opstine set PostanskiBroj = 21460 where NazivOpstine = N'Vrbas'" +
              "update Opstine set PostanskiBroj = 36210 where NazivOpstine = N'Vrnjačka Banja'" +
              "update Opstine set PostanskiBroj = 26300 where NazivOpstine = N'Vršac'" +
              "update Opstine set PostanskiBroj = 42000 where NazivOpstine = N'Vučitrn'" +
              "update Opstine set PostanskiBroj = 18240 where NazivOpstine = N'Gadžin Han'" +
              "update Opstine set PostanskiBroj = 35222 where NazivOpstine = N'Glogovac'" +
              "update Opstine set PostanskiBroj = 18309 where NazivOpstine = N'Gnjilane'" +
              "update Opstine set PostanskiBroj = 12223 where NazivOpstine = N'GoluBač'" +
              "update Opstine set PostanskiBroj = 38420 where NazivOpstine = N'Gora'" +
              "update Opstine set PostanskiBroj = 32300 where NazivOpstine = N'Gornji Milanovac'" +
              "update Opstine set PostanskiBroj = 11306 where NazivOpstine = N'Grocka'" +
              "update Opstine set PostanskiBroj = 35213 where NazivOpstine = N'Despotovac'" +
              "update Opstine set PostanskiBroj = 51000 where NazivOpstine = N'Dečani'" +
              "update Opstine set PostanskiBroj = 18320 where NazivOpstine = N'Dimitrovgrad'" +
              "update Opstine set PostanskiBroj = 18410 where NazivOpstine = N'Doljevac'" +
              "update Opstine set PostanskiBroj = 50000 where NazivOpstine = N'Đakovica'" +
              "update Opstine set PostanskiBroj = 21230 where NazivOpstine = N'Žabalj'" +
              "update Opstine set PostanskiBroj = 12374 where NazivOpstine = N'Žabari'" +
              "update Opstine set PostanskiBroj = 12320 where NazivOpstine = N'Žagubica'" +
              "update Opstine set PostanskiBroj = 23210 where NazivOpstine = N'Žitište'" +
              "update Opstine set PostanskiBroj = 18412 where NazivOpstine = N'Žitorađa'" +
              "update Opstine set PostanskiBroj = 19000 where NazivOpstine = N'Zaječar'" +
              "update Opstine set PostanskiBroj = 11050 where NazivOpstine = N'Zvezdara'" +
              "update Opstine set PostanskiBroj = 38227 where NazivOpstine = N'Zvečan'" +
              "update Opstine set PostanskiBroj = 11080 where NazivOpstine = N'Zemun'" +
              "update Opstine set PostanskiBroj = 23000 where NazivOpstine = N'Zrenjanin'" +
              "update Opstine set PostanskiBroj = 38228 where NazivOpstine = N'Zubin Potok'" +
              "update Opstine set PostanskiBroj = 32250 where NazivOpstine = N'Ivanjica'" +
              "update Opstine set PostanskiBroj = 22320 where NazivOpstine = N'Inđija'" +
              "update Opstine set PostanskiBroj = 22406 where NazivOpstine = N'Irig'" +
              "update Opstine set PostanskiBroj = 31010 where NazivOpstine = N'Istok'" +
              "update Opstine set PostanskiBroj = 35000 where NazivOpstine = N'Jagodina'" +
              "update Opstine set PostanskiBroj = 24420 where NazivOpstine = N'Kanjiža'" +
              "update Opstine set PostanskiBroj = 71000 where NazivOpstine = N'Kačanik'" +
              "update Opstine set PostanskiBroj = 23300 where NazivOpstine = N'Kikinda'" +
              "update Opstine set PostanskiBroj = 19320 where NazivOpstine = N'Kladovo'" +
              "update Opstine set PostanskiBroj = 32000 where NazivOpstine = N'Klina'" +
              "update Opstine set PostanskiBroj = 34240 where NazivOpstine = N'Knić'" +
              "update Opstine set PostanskiBroj = 19350 where NazivOpstine = N'Knjaževac'" +
              "update Opstine set PostanskiBroj = 26210 where NazivOpstine = N'Kovačica'" +
              "update Opstine set PostanskiBroj = 26220 where NazivOpstine = N'Kovin'" +
              "update Opstine set PostanskiBroj = 31260 where NazivOpstine = N'Kosjerić'" +
              "update Opstine set PostanskiBroj = 38210 where NazivOpstine = N'Kosovo Polje'" +
              "update Opstine set PostanskiBroj = 38260 where NazivOpstine = N'Kosovska Kamenica'" +
              "update Opstine set PostanskiBroj = 40000 where NazivOpstine = N'Kosovska Mitrovica'" +
              "update Opstine set PostanskiBroj = 15220 where NazivOpstine = N'Koceljeva'" +
              "update Opstine set PostanskiBroj = 34000 where NazivOpstine = N'Kragujevac'" +
              "update Opstine set PostanskiBroj = 36000 where NazivOpstine = N'Kraljevo'" +
              "update Opstine set PostanskiBroj = 15314 where NazivOpstine = N'Krupanj'" +
              "update Opstine set PostanskiBroj = 37000 where NazivOpstine = N'Kruševac'" +
              "update Opstine set PostanskiBroj = 25230 where NazivOpstine = N'Kula'" +
              "update Opstine set PostanskiBroj = 18430 where NazivOpstine = N'Kuršumlija'" +
              "update Opstine set PostanskiBroj = 12240 where NazivOpstine = N'Kučevo'" +
              "update Opstine set PostanskiBroj = 11550 where NazivOpstine = N'Lazarevac'" +
              "update Opstine set PostanskiBroj = 14224 where NazivOpstine = N'Lajkovac'" +
              "update Opstine set PostanskiBroj = 34221 where NazivOpstine = N'Lapovo'" +
              "update Opstine set PostanskiBroj = 16230 where NazivOpstine = N'Lebane'" +
              "update Opstine set PostanskiBroj = 38218 where NazivOpstine = N'Leposavić'" +
              "update Opstine set PostanskiBroj = 16000 where NazivOpstine = N'Leskovac'" +
              "update Opstine set PostanskiBroj = 14000 where NazivOpstine = N'Lipljan'" +
              "update Opstine set PostanskiBroj = 15300 where NazivOpstine = N'Loznica'" +
              "update Opstine set PostanskiBroj = 32240 where NazivOpstine = N'Lučani'" +
              "update Opstine set PostanskiBroj = 14240 where NazivOpstine = N'Ljig'" +
              "update Opstine set PostanskiBroj = 15320 where NazivOpstine = N'Ljubovija'" +
              "update Opstine set PostanskiBroj = 19250 where NazivOpstine = N'Majdanpek'" +
              "update Opstine set PostanskiBroj = 15318 where NazivOpstine = N'Mali Zvornik'" +
              "update Opstine set PostanskiBroj = 24321 where NazivOpstine = N'Mali Iđoš'" +
              "update Opstine set PostanskiBroj = 12311 where NazivOpstine = N'Malo Crniće'" +
              "update Opstine set PostanskiBroj = 16240 where NazivOpstine = N'Medveđa'" +
              "update Opstine set PostanskiBroj = 18106 where NazivOpstine = N'Mediana'" +
              "update Opstine set PostanskiBroj = 18252 where NazivOpstine = N'Merošina'" +
              "update Opstine set PostanskiBroj = 14242 where NazivOpstine = N'Mionica'" +
              "update Opstine set PostanskiBroj = 11400 where NazivOpstine = N'Mladenovac'" +
              "update Opstine set PostanskiBroj = 19300 where NazivOpstine = N'Negotin'" +
              "update Opstine set PostanskiBroj = 18205 where NazivOpstine = N'Niška Banja'" +
              "update Opstine set PostanskiBroj = 31320 where NazivOpstine = N'Nova Varoš'" +
              "update Opstine set PostanskiBroj = 23218 where NazivOpstine = N'Nova Crnja'" +
              "update Opstine set PostanskiBroj = 11070 where NazivOpstine = N'Novi Beograd'" +
              "update Opstine set PostanskiBroj = 23272 where NazivOpstine = N'Novi Bečej'" +
              "update Opstine set PostanskiBroj = 23330 where NazivOpstine = N'Novi Kneževac'" +
              "update Opstine set PostanskiBroj = 36300 where NazivOpstine = N'Novi Pazar'" +
              "update Opstine set PostanskiBroj = 21000 where NazivOpstine = N'Novi Sad'" +
              "update Opstine set PostanskiBroj = 38255 where NazivOpstine = N'Novo Brdo'" +
              "update Opstine set PostanskiBroj = 15000 where NazivOpstine = N'Obilić'" +
              "update Opstine set PostanskiBroj = 11500 where NazivOpstine = N'Obrenovac'" +
              "update Opstine set PostanskiBroj = 26204 where NazivOpstine = N'Opovo'" +
              "update Opstine set PostanskiBroj = 38430 where NazivOpstine = N'Orahovac'" +
              "update Opstine set PostanskiBroj = 14253 where NazivOpstine = N'Osečina'" +
              "update Opstine set PostanskiBroj = 25250 where NazivOpstine = N'Odžaci'" +
              "update Opstine set PostanskiBroj = 11060 where NazivOpstine = N'Palilula'" +
              "update Opstine set PostanskiBroj = 18363 where NazivOpstine = N'Palilula (Niš)'" +
              "update Opstine set PostanskiBroj = 18204 where NazivOpstine = N'Pantelej'" +
              "update Opstine set PostanskiBroj = 26000 where NazivOpstine = N'Pančevo'" +
              "update Opstine set PostanskiBroj = 35250 where NazivOpstine = N'Paraćin'" +
              "update Opstine set PostanskiBroj = 21131 where NazivOpstine = N'Petrovaradin'" +
              "update Opstine set PostanskiBroj = 12300 where NazivOpstine = N'Petrovac na Mlavi'" +
              "update Opstine set PostanskiBroj = 30000 where NazivOpstine = N'Peć'" +
              "update Opstine set PostanskiBroj = 22410 where NazivOpstine = N'Pećinci'" +
              "update Opstine set PostanskiBroj = 18300 where NazivOpstine = N'Pirot'" +
              "update Opstine set PostanskiBroj = 26360 where NazivOpstine = N'Plandište'" +
              "update Opstine set PostanskiBroj = 11000 where NazivOpstine = N'Podujevo'" +
              "update Opstine set PostanskiBroj = 12000 where NazivOpstine = N'Požarevac'" +
              "update Opstine set PostanskiBroj = 31210 where NazivOpstine = N'Požega'" +
              "update Opstine set PostanskiBroj = 17523 where NazivOpstine = N'Preševo'" +
              "update Opstine set PostanskiBroj = 31330 where NazivOpstine = N'Priboj na Limu'" +
              "update Opstine set PostanskiBroj = 20000 where NazivOpstine = N'Prizren'" +
              "update Opstine set PostanskiBroj = 31300 where NazivOpstine = N'Prijepolje'" +
              "update Opstine set PostanskiBroj = 10000 where NazivOpstine = N'Priština'" +
              "update Opstine set PostanskiBroj = 18400 where NazivOpstine = N'Prokuplje'" +
              "update Opstine set PostanskiBroj = 37215 where NazivOpstine = N'Ražanj'" +
              "update Opstine set PostanskiBroj = 11090 where NazivOpstine = N'Rakovica'" +
              "update Opstine set PostanskiBroj = 18440 where NazivOpstine = N'Rača'" +
              "update Opstine set PostanskiBroj = 36350 where NazivOpstine = N'Raška'" +
              "update Opstine set PostanskiBroj = 35260 where NazivOpstine = N'Rekovac'" +
              "update Opstine set PostanskiBroj = 22400 where NazivOpstine = N'Ruma'" +
              "update Opstine set PostanskiBroj = 11000 where NazivOpstine = N'Savski Venac'" +
              "update Opstine set PostanskiBroj = 35210 where NazivOpstine = N'Svilajnac'" +
              "update Opstine set PostanskiBroj = 18360 where NazivOpstine = N'Svrljig'" +
              "update Opstine set PostanskiBroj = 24400 where NazivOpstine = N'Senta'" +
              "update Opstine set PostanskiBroj = 23240 where NazivOpstine = N'Sečanj'" +
              "update Opstine set PostanskiBroj = 36310 where NazivOpstine = N'Sjenica'" +
              "update Opstine set PostanskiBroj = 11300 where NazivOpstine = N'Smederevo'" +
              "update Opstine set PostanskiBroj = 11420 where NazivOpstine = N'Smederevska Palanka'" +
              "update Opstine set PostanskiBroj = 18230 where NazivOpstine = N'Sokobanja'" +
              "update Opstine set PostanskiBroj = 25000 where NazivOpstine = N'Sombor'" +
              "update Opstine set PostanskiBroj = 11450 where NazivOpstine = N'Sopot'" +
              "update Opstine set PostanskiBroj = 41000 where NazivOpstine = N'Srbica'" +
              "update Opstine set PostanskiBroj = 21480 where NazivOpstine = N'Srbobran'" +
              "update Opstine set PostanskiBroj = 22000 where NazivOpstine = N'Sremska Mitrovica'" +
              "update Opstine set PostanskiBroj = 21205 where NazivOpstine = N'Sremski Karlovci'" +
              "update Opstine set PostanskiBroj = 22300 where NazivOpstine = N'Stara Pazova'" +
              "update Opstine set PostanskiBroj = 11003 where NazivOpstine = N'Stari grad'" +
              "update Opstine set PostanskiBroj = 34323 where NazivOpstine = N'Stragari'" +
              "update Opstine set PostanskiBroj = 24000 where NazivOpstine = N'Subotica'" +
              "update Opstine set PostanskiBroj = 23050 where NazivOpstine = N'Suva Reka'" +
              "update Opstine set PostanskiBroj = 17530 where NazivOpstine = N'Surdulica'" +
              "update Opstine set PostanskiBroj = 11271 where NazivOpstine = N'Surčin'" +
              "update Opstine set PostanskiBroj = 21235 where NazivOpstine = N'Temerin'" +
              "update Opstine set PostanskiBroj = 21240 where NazivOpstine = N'Titel'" +
              "update Opstine set PostanskiBroj = 34310 where NazivOpstine = N'Topola'" +
              "update Opstine set PostanskiBroj = 17525 where NazivOpstine = N'Trgovište'" +
              "update Opstine set PostanskiBroj = 37240 where NazivOpstine = N'Trstenik'" +
              "update Opstine set PostanskiBroj = 36320 where NazivOpstine = N'Tutin'" +
              "update Opstine set PostanskiBroj = 37210 where NazivOpstine = N'Ćićevac'" +
              "update Opstine set PostanskiBroj = 35230 where NazivOpstine = N'Ćuprija'" +
              "update Opstine set PostanskiBroj = 14210 where NazivOpstine = N'Ub'" +
              "update Opstine set PostanskiBroj = 31000 where NazivOpstine = N'Užice'" +
              "update Opstine set PostanskiBroj = 70000 where NazivOpstine = N'Uroševac'" +
              "update Opstine set PostanskiBroj = 18000 where NazivOpstine = N'Crveni krst'" +
              "update Opstine set PostanskiBroj = 16215 where NazivOpstine = N'Crna Trava'" +
              "update Opstine set PostanskiBroj = 31310 where NazivOpstine = N'Čajetina'" +
              "update Opstine set PostanskiBroj = 32000 where NazivOpstine = N'Čačak'" +
              "update Opstine set PostanskiBroj = 23320 where NazivOpstine = N'Čoka'" +
              "update Opstine set PostanskiBroj = 11030 where NazivOpstine = N'Čukarica'" +
              "update Opstine set PostanskiBroj = 15000 where NazivOpstine = N'Šabac'" +
              "update Opstine set PostanskiBroj = 22240 where NazivOpstine = N'Šid'" +
              "update Opstine set PostanskiBroj = 72000 where NazivOpstine = N'Štimlje'" +
              "update Opstine set PostanskiBroj = 38236 where NazivOpstine = N'Štrpce'");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostanskiBroj",
                table: "Opstine");
        }
    }
}
