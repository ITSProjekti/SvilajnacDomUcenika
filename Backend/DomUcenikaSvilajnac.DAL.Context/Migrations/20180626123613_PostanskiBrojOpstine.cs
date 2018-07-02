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

            migrationBuilder.Sql("update Opstine set PostanskiBroj = 31203 where NazivOpstine = 'Ada'" +
              "update Opstine set PostanskiBroj = 37230 where NazivOpstine = 'Aleksandrovac'" +
              "update Opstine set PostanskiBroj = 18220 where NazivOpstine = 'Aleksinac'" +
              "update Opstine set PostanskiBroj = 26310 where NazivOpstine = 'Alibunar'" +
              "update Opstine set PostanskiBroj = 25260 where NazivOpstine = 'Apatin'" +
              "update Opstine set PostanskiBroj = 34300 where NazivOpstine = 'Aranđelovac'" +
              "update Opstine set PostanskiBroj = 31230 where NazivOpstine = 'Arilje'" +
              "update Opstine set PostanskiBroj = 18330 where NazivOpstine = 'Babušnica'" +
              "update Opstine set PostanskiBroj = 31250 where NazivOpstine = 'Bajina Bašta'" +
              "update Opstine set PostanskiBroj = 11460 where NazivOpstine = 'Barajevo'" +
              "update Opstine set PostanskiBroj = 34227 where NazivOpstine = 'Batočina'" +
              "update Opstine set PostanskiBroj = 21420 where NazivOpstine = 'Bač'" +
              "update Opstine set PostanskiBroj = 21401 where NazivOpstine = 'Bačka Palanka'" +
              "update Opstine set PostanskiBroj = 24300 where NazivOpstine = 'Bačka Topola'" +
              "update Opstine set PostanskiBroj = 21470 where NazivOpstine = 'Bački Petrovac'" +
              "update Opstine set PostanskiBroj = 18310 where NazivOpstine = 'Bela Palanka' " +
              "update Opstine set PostanskiBroj = 26340 where NazivOpstine = 'Bela Crkva'" +
              "update Opstine set PostanskiBroj = 21300 where NazivOpstine = 'Beočin'" +
              "update Opstine set PostanskiBroj = 21220 where NazivOpstine = 'Bečej'" +
              "update Opstine set PostanskiBroj = 18420 where NazivOpstine = 'Blace'" +
              "update Opstine set PostanskiBroj = 15350 where NazivOpstine = 'Bogatić'" +
              "update Opstine set PostanskiBroj = 16205 where NazivOpstine = 'Bojnik'" +
              "update Opstine set PostanskiBroj = 19370 where NazivOpstine = 'Boljevac'" +
              "update Opstine set PostanskiBroj = 19218 where NazivOpstine = 'Bor'" +
              "update Opstine set PostanskiBroj = 17540 where NazivOpstine = 'Bosilegrad'" +
              "update Opstine set PostanskiBroj = 37220 where NazivOpstine = 'Brus'" +
              "update Opstine set PostanskiBroj = 17520 where NazivOpstine = 'Bujanovac'" +
              "update Opstine set PostanskiBroj = 14000 where NazivOpstine = 'Valjevo'" +
              "update Opstine set PostanskiBroj = 37260 where NazivOpstine = 'Varvarin'" +
              "update Opstine set PostanskiBroj = 11320 where NazivOpstine = 'Velika Plana'" +
              "update Opstine set PostanskiBroj = 12220 where NazivOpstine = 'Veliko Gradište'" +
              "update Opstine set PostanskiBroj = 61000 where NazivOpstine = 'Vitina'" +
              "update Opstine set PostanskiBroj = 15225 where NazivOpstine = 'Vladimirci'" +
              "update Opstine set PostanskiBroj = 17510 where NazivOpstine = 'Vladičin Han'" +
              "update Opstine set PostanskiBroj = 16210 where NazivOpstine = 'Vlasotince'" +
              "update Opstine set PostanskiBroj = 11010 where NazivOpstine = 'Voždovac'" +
              "update Opstine set PostanskiBroj = 17500 where NazivOpstine = 'Vranje'" +
              "update Opstine set PostanskiBroj = 11110 where NazivOpstine = 'Vračar'" +
              "update Opstine set PostanskiBroj = 21460 where NazivOpstine = 'Vrbas'" +
              "update Opstine set PostanskiBroj = 36210 where NazivOpstine = 'Vrnjačka Banja'" +
              "update Opstine set PostanskiBroj = 26300 where NazivOpstine = 'Vršac'" +
              "update Opstine set PostanskiBroj = 42000 where NazivOpstine = 'Vučitrn'" +
              "update Opstine set PostanskiBroj = 18240 where NazivOpstine = 'Gadžin Han'" +
              "update Opstine set PostanskiBroj = 35222 where NazivOpstine = 'Glogovac'" +
              "update Opstine set PostanskiBroj = 18309 where NazivOpstine = 'Gnjilane'" +
              "update Opstine set PostanskiBroj = 12223 where NazivOpstine = 'Golubac'" +
              "update Opstine set PostanskiBroj = 38420 where NazivOpstine = 'Gora'" +
              "update Opstine set PostanskiBroj = 32300 where NazivOpstine = 'Gornji Milanovac'" +
              "update Opstine set PostanskiBroj = 11306 where NazivOpstine = 'Grocka'" +
              "update Opstine set PostanskiBroj = 35213 where NazivOpstine = 'Despotovac'" +
              "update Opstine set PostanskiBroj = 51000 where NazivOpstine = 'Dečani'" +
              "update Opstine set PostanskiBroj = 18320 where NazivOpstine = 'Dimitrovgrad'" +
              "update Opstine set PostanskiBroj = 18410 where NazivOpstine = 'Doljevac'" +
              "update Opstine set PostanskiBroj = 50000 where NazivOpstine = 'Đakovica'" +
              "update Opstine set PostanskiBroj = 21230 where NazivOpstine = 'Žabalj'" +
              "update Opstine set PostanskiBroj = 12374 where NazivOpstine = 'Žabari'" +
              "update Opstine set PostanskiBroj = 12320 where NazivOpstine = 'Žagubica'" +
              "update Opstine set PostanskiBroj = 23210 where NazivOpstine = 'Žitište'" +
              "update Opstine set PostanskiBroj = 18412 where NazivOpstine = 'Žitorađa'" +
              "update Opstine set PostanskiBroj = 19000 where NazivOpstine = 'Zaječar'" +
              "update Opstine set PostanskiBroj = 11050 where NazivOpstine = 'Zvezdara'" +
              "update Opstine set PostanskiBroj = 38227 where NazivOpstine = 'Zvečan'" +
              "update Opstine set PostanskiBroj = 11080 where NazivOpstine = 'Zemun'" +
              "update Opstine set PostanskiBroj = 23000 where NazivOpstine = 'Zrenjanin'" +
              "update Opstine set PostanskiBroj = 38228 where NazivOpstine = 'Zubin Potok'" +
              "update Opstine set PostanskiBroj = 32250 where NazivOpstine = 'Ivanjica'" +
              "update Opstine set PostanskiBroj = 22320 where NazivOpstine = 'Inđija'" +
              "update Opstine set PostanskiBroj = 22406 where NazivOpstine = 'Irig'" +
              "update Opstine set PostanskiBroj = 31010 where NazivOpstine = 'Istok'" +
              "update Opstine set PostanskiBroj = 35000 where NazivOpstine = 'Jagodina'" +
              "update Opstine set PostanskiBroj = 24420 where NazivOpstine = 'Kanjiža'" +
              "update Opstine set PostanskiBroj = 71000 where NazivOpstine = 'Kačanik'" +
              "update Opstine set PostanskiBroj = 23300 where NazivOpstine = 'Kikinda'" +
              "update Opstine set PostanskiBroj = 19320 where NazivOpstine = 'Kladovo'" +
              "update Opstine set PostanskiBroj = 32000 where NazivOpstine = 'Klina'" +
              "update Opstine set PostanskiBroj = 34240 where NazivOpstine = 'Knić'" +
              "update Opstine set PostanskiBroj = 19350 where NazivOpstine = 'Knjaževac'" +
              "update Opstine set PostanskiBroj = 26210 where NazivOpstine = 'Kovačica'" +
              "update Opstine set PostanskiBroj = 26220 where NazivOpstine = 'Kovin'" +
              "update Opstine set PostanskiBroj = 31260 where NazivOpstine = 'Kosjerić'" +
              "update Opstine set PostanskiBroj = 38210 where NazivOpstine = 'Kosovo Polje'" +
              "update Opstine set PostanskiBroj = 38260 where NazivOpstine = 'Kosovska Kamenica'" +
              "update Opstine set PostanskiBroj = 40000 where NazivOpstine = 'Kosovska Mitrovica'" +
              "update Opstine set PostanskiBroj = 15220 where NazivOpstine = 'Koceljeva'" +
              "update Opstine set PostanskiBroj = 34000 where NazivOpstine = 'Kragujevac'" +
              "update Opstine set PostanskiBroj = 36000 where NazivOpstine = 'Kraljevo'" +
              "update Opstine set PostanskiBroj = 15314 where NazivOpstine = 'Krupanj'" +
              "update Opstine set PostanskiBroj = 37000 where NazivOpstine = 'Kruševac'" +
              "update Opstine set PostanskiBroj = 25230 where NazivOpstine = 'Kula'" +
              "update Opstine set PostanskiBroj = 18430 where NazivOpstine = 'Kuršumlija'" +
              "update Opstine set PostanskiBroj = 12240 where NazivOpstine = 'Kučevo'" +
              "update Opstine set PostanskiBroj = 11550 where NazivOpstine = 'Lazarevac'" +
              "update Opstine set PostanskiBroj = 14224 where NazivOpstine = 'Lajkovac'" +
              "update Opstine set PostanskiBroj = 34221 where NazivOpstine = 'Lapovo'" +
              "update Opstine set PostanskiBroj = 16230 where NazivOpstine = 'Lebane'" +
              "update Opstine set PostanskiBroj = 38218 where NazivOpstine = 'Leposavić'" +
              "update Opstine set PostanskiBroj = 16000 where NazivOpstine = 'Leskovac'" +
              "update Opstine set PostanskiBroj = 14000 where NazivOpstine = 'Lipljan'" +
              "update Opstine set PostanskiBroj = 15300 where NazivOpstine = 'Loznica'" +
              "update Opstine set PostanskiBroj = 32240 where NazivOpstine = 'Lučani'" +
              "update Opstine set PostanskiBroj = 14240 where NazivOpstine = 'Ljig'" +
              "update Opstine set PostanskiBroj = 15320 where NazivOpstine = 'Ljubovija'" +
              "update Opstine set PostanskiBroj = 19250 where NazivOpstine = 'Majdanpek'" +
              "update Opstine set PostanskiBroj = 15318 where NazivOpstine = 'Mali Zvornik'" +
              "update Opstine set PostanskiBroj = 24321 where NazivOpstine = 'Mali Iđoš'" +
              "update Opstine set PostanskiBroj = 12311 where NazivOpstine = 'Malo Crniće'" +
              "update Opstine set PostanskiBroj = 16240 where NazivOpstine = 'Medveđa'" +
              "update Opstine set PostanskiBroj = 18106 where NazivOpstine = 'Mediana'" +
              "update Opstine set PostanskiBroj = 18252 where NazivOpstine = 'Merošina'" +
              "update Opstine set PostanskiBroj = 14242 where NazivOpstine = 'Mionica'" +
              "update Opstine set PostanskiBroj = 11400 where NazivOpstine = 'Mladenovac'" +
              "update Opstine set PostanskiBroj = 19300 where NazivOpstine = 'Negotin'" +
              "update Opstine set PostanskiBroj = 18205 where NazivOpstine = 'Niška Banja'" +
              "update Opstine set PostanskiBroj = 31320 where NazivOpstine = 'Nova Varoš'" +
              "update Opstine set PostanskiBroj = 23218 where NazivOpstine = 'Nova Crnja'" +
              "update Opstine set PostanskiBroj = 11070 where NazivOpstine = 'Novi Beograd'" +
              "update Opstine set PostanskiBroj = 23272 where NazivOpstine = 'Novi Bečej'" +
              "update Opstine set PostanskiBroj = 23330 where NazivOpstine = 'Novi Kneževac'" +
              "update Opstine set PostanskiBroj = 36300 where NazivOpstine = 'Novi Pazar'" +
              "update Opstine set PostanskiBroj = 21000 where NazivOpstine = 'Novi Sad'" +
              "update Opstine set PostanskiBroj = 38255 where NazivOpstine = 'Novo Brdo'" +
              "update Opstine set PostanskiBroj = 15000 where NazivOpstine = 'Obilić'" +
              "update Opstine set PostanskiBroj = 11500 where NazivOpstine = 'Obrenovac'" +
              "update Opstine set PostanskiBroj = 26204 where NazivOpstine = 'Opovo'" +
              "update Opstine set PostanskiBroj = 38430 where NazivOpstine = 'Orahovac'" +
              "update Opstine set PostanskiBroj = 14253 where NazivOpstine = 'Osečina'" +
              "update Opstine set PostanskiBroj = 25250 where NazivOpstine = 'Odžaci'" +
              "update Opstine set PostanskiBroj = 11060 where NazivOpstine = 'Palilula'" +
              "update Opstine set PostanskiBroj = 18363 where NazivOpstine = 'Palilula (Niš)'" +
              "update Opstine set PostanskiBroj = 18204 where NazivOpstine = 'Pantelej'" +
              "update Opstine set PostanskiBroj = 26000 where NazivOpstine = 'Pančevo'" +
              "update Opstine set PostanskiBroj = 35250 where NazivOpstine = 'Paraćin'" +
              "update Opstine set PostanskiBroj = 21131 where NazivOpstine = 'Petrovaradin'" +
              "update Opstine set PostanskiBroj = 12300 where NazivOpstine = 'Petrovac na Mlavi'" +
              "update Opstine set PostanskiBroj = 30000 where NazivOpstine = 'Peć'" +
              "update Opstine set PostanskiBroj = 22410 where NazivOpstine = 'Pećinci'" +
              "update Opstine set PostanskiBroj = 18300 where NazivOpstine = 'Pirot'" +
              "update Opstine set PostanskiBroj = 26360 where NazivOpstine = 'Plandište'" +
              "update Opstine set PostanskiBroj = 11000 where NazivOpstine = 'Podujevo'" +
              "update Opstine set PostanskiBroj = 12000 where NazivOpstine = 'Požarevac'" +
              "update Opstine set PostanskiBroj = 31210 where NazivOpstine = 'Požega'" +
              "update Opstine set PostanskiBroj = 17523 where NazivOpstine = 'Preševo'" +
              "update Opstine set PostanskiBroj = 31330 where NazivOpstine = 'Priboj na Limu'" +
              "update Opstine set PostanskiBroj = 20000 where NazivOpstine = 'Prizren'" +
              "update Opstine set PostanskiBroj = 31300 where NazivOpstine = 'Prijepolje'" +
              "update Opstine set PostanskiBroj = 10000 where NazivOpstine = 'Priština'" +
              "update Opstine set PostanskiBroj = 18400 where NazivOpstine = 'Prokuplje'" +
              "update Opstine set PostanskiBroj = 37215 where NazivOpstine = 'Ražanj'" +
              "update Opstine set PostanskiBroj = 11090 where NazivOpstine = 'Rakovica'" +
              "update Opstine set PostanskiBroj = 18440 where NazivOpstine = 'Rača'" +
              "update Opstine set PostanskiBroj = 36350 where NazivOpstine = 'Raška'" +
              "update Opstine set PostanskiBroj = 35260 where NazivOpstine = 'Rekovac'" +
              "update Opstine set PostanskiBroj = 22400 where NazivOpstine = 'Ruma'" +
              "update Opstine set PostanskiBroj = 11000 where NazivOpstine = 'Savski venac'" +
              "update Opstine set PostanskiBroj = 35210 where NazivOpstine = 'Svilajnac'" +
              "update Opstine set PostanskiBroj = 18360 where NazivOpstine = 'Svrljig'" +
              "update Opstine set PostanskiBroj = 24400 where NazivOpstine = 'Senta'" +
              "update Opstine set PostanskiBroj = 23240 where NazivOpstine = 'Sečanj'" +
              "update Opstine set PostanskiBroj = 36310 where NazivOpstine = 'Sjenica'" +
              "update Opstine set PostanskiBroj = 11300 where NazivOpstine = 'Smederevo'" +
              "update Opstine set PostanskiBroj = 11420 where NazivOpstine = 'Smederevska Palanka'" +
              "update Opstine set PostanskiBroj = 18230 where NazivOpstine = 'Sokobanja'" +
              "update Opstine set PostanskiBroj = 25000 where NazivOpstine = 'Sombor'" +
              "update Opstine set PostanskiBroj = 11450 where NazivOpstine = 'Sopot'" +
              "update Opstine set PostanskiBroj = 41000 where NazivOpstine = 'Srbica'" +
              "update Opstine set PostanskiBroj = 21480 where NazivOpstine = 'Srbobran'" +
              "update Opstine set PostanskiBroj = 22000 where NazivOpstine = 'Sremska Mitrovica'" +
              "update Opstine set PostanskiBroj = 21205 where NazivOpstine = 'Sremski Karlovci'" +
              "update Opstine set PostanskiBroj = 22300 where NazivOpstine = 'Stara Pazova'" +
              "update Opstine set PostanskiBroj = 11003 where NazivOpstine = 'Stari grad'" +
              "update Opstine set PostanskiBroj = 34323 where NazivOpstine = 'Stragari'" +
              "update Opstine set PostanskiBroj = 24000 where NazivOpstine = 'Subotica'" +
              "update Opstine set PostanskiBroj = 23050 where NazivOpstine = 'Suva Reka'" +
              "update Opstine set PostanskiBroj = 17530 where NazivOpstine = 'Surdulica'" +
              "update Opstine set PostanskiBroj = 11271 where NazivOpstine = 'Surčin'" +
              "update Opstine set PostanskiBroj = 21235 where NazivOpstine = 'Temerin'" +
              "update Opstine set PostanskiBroj = 21240 where NazivOpstine = 'Titel'" +
              "update Opstine set PostanskiBroj = 34310 where NazivOpstine = 'Topola'" +
              "update Opstine set PostanskiBroj = 17525 where NazivOpstine = 'Trgovište'" +
              "update Opstine set PostanskiBroj = 37240 where NazivOpstine = 'Trstenik'" +
              "update Opstine set PostanskiBroj = 36320 where NazivOpstine = 'Tutin'" +
              "update Opstine set PostanskiBroj = 37210 where NazivOpstine = 'Ćićevac'" +
              "update Opstine set PostanskiBroj = 35230 where NazivOpstine = 'Ćuprija'" +
              "update Opstine set PostanskiBroj = 14210 where NazivOpstine = 'Ub'" +
              "update Opstine set PostanskiBroj = 31000 where NazivOpstine = 'Užice'" +
              "update Opstine set PostanskiBroj = 70000 where NazivOpstine = 'Uroševac'" +
              "update Opstine set PostanskiBroj = 18000 where NazivOpstine = 'Crveni krst'" +
              "update Opstine set PostanskiBroj = 16215 where NazivOpstine = 'Crna Trava'" +
              "update Opstine set PostanskiBroj = 31310 where NazivOpstine = 'Čajetina'" +
              "update Opstine set PostanskiBroj = 32000 where NazivOpstine = 'Čačak'" +
              "update Opstine set PostanskiBroj = 23320 where NazivOpstine = 'Čoka'" +
              "update Opstine set PostanskiBroj = 11030 where NazivOpstine = 'Čukarica'" +
              "update Opstine set PostanskiBroj = 15000 where NazivOpstine = 'Šabac'" +
              "update Opstine set PostanskiBroj = 22240 where NazivOpstine = 'Šid'" +
              "update Opstine set PostanskiBroj = 72000 where NazivOpstine = 'Štimlje'" +
              "update Opstine set PostanskiBroj = 38236 where NazivOpstine = 'Štrpce'");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostanskiBroj",
                table: "Opstine");
        }
    }
}
