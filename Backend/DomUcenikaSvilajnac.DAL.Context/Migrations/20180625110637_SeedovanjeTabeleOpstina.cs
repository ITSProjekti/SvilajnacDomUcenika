using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class SeedovanjeTabeleOpstina : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Opstine (NazivOpstine) values " +
    "(N'Ada'), (N'Aleksandrovac'), (N'Aleksinac'), (N'Alibunar'), (N'Apatin'), (N'Aranđelovac'), (N'Arilje')," +
    "(N'Babušnica'), (N'Bajina Bašta'), (N'Barajevo'), (N'Batočina'), (N'Bač'), (N'Bačka Palanka'), (N'Bačka Topola')," +
    "(N'Bački Petrovac'), (N'Bela Palanka'), (N'Bela Crkva'),(N'Beočin'), (N'Bečej'),(N'Blace'),(N'Bogatić')," +
    "(N'Bojnik'), (N'Boljevac'), (N'Bor'), (N'Bosilegrad'),(N'Brus'), (N'Bujanovac'), (N'Valjevo')," +
    " (N'Varvarin'), (N'Velika Plana'), (N'Veliko Gradište'), (N'Vitina'), (N'Vladimirci'), (N'Vladičin Han')," +
    " (N'Vlasotince'), (N'Voždovac'), (N'Vranje'), (N'Vračar'), (N'Vrbas'), (N'Vrnjačka Banja'), (N'Vršac')," +
    " (N'Vučitrn'), (N'Gadžin Han'), (N'Glogovac'), (N'Gnjilane'), (N'Golubac'), (N'Gora'), (N'Goraždevac'), (N'Gornji Milanovac')," +
    " (N'Grocka'), (N'Gračanica'), (N'Gornje Kušće'), (N'Despotovac'), (N'Dečani'), (N'Dragaš'), (N'Dimitrovgrad'), (N'Doljevac'), (N'Đakovica'), (N'Žabalj')," +
    " (N'Žabari'), (N'Žagubica'), (N'Žitište'), (N'Žitorađa'), (N'Zaječar'), (N'Zvezdara'), (N'Zvečan')," +
    " (N'Zemun'), (N'Zrenjanin'), (N'Zubin Potok'), (N'Ivanjica'), (N'Inđija'), (N'Irig'), (N'Istok')," +
    " (N'Jagodina'), (N'Kanjiža'), (N'Kačanik'), (N'Kikinda'), (N'Kladovo'), (N'Klina'), (N'Knić')," +
    " (N'Knjaževac'), (N'Kovačica'), (N'Kovin'), (N'Kosjerić'), (N'Kostolac'), (N'Kosovo Polje'), (N'Kosovska Kamenica'), (N'Kosovska Mitrovica')," +
    " (N'Koceljeva'), (N'Kragujevac'), (N'Kraljevo'), (N'Krupanj'), (N'Kruševac'), (N'Kula'), (N'Kuršumlija')," +
    " (N'Kučevo'), (N'Lazarevac'), (N'Lajkovac'), (N'Lapovo'), (N'Lebane'), (N'Leposavić'), (N'Leskovac'), " +
    " (N'Lipljan'), (N'Loznica'), (N'Lučani'), (N'Ljig'), (N'Ljubovija'), (N'Majdanpek')," +
    " (N'Mali Zvornik'), (N'Mali Iđoš'), (N'Malo Crniće'), (N'Medveđa'), (N'Mediana'), (N'Merošina')," +
    " (N'Mionica'), (N'Mladenovac'), (N'Negotin'), (N'Niška Banja'), (N'Nova Varoš'), (N'Nova Crnja'), (N'Novi Beograd')," +
    " (N'Novi Bečej'), (N'Novi Kneževac'), (N'Novi Pazar'), (N'Novi Sad'), (N'Novo Brdo'), (N'Obilić'), (N'Obrenovac')," +
    " (N'Opovo'), (N'Orahovac'), (N'Osečina'), (N'Odžaci'), (N'Palilula'), (N'Palilula (Niš)'), (N'Pantelej')," +
    " (N'Pančevo'), (N'Paraćin'), (N'Petrovaradin'), (N'Petrovac na Mlavi'), (N'Peć'), (N'Pećinci'), (N'Pirot'), (N'Plandište')," +
    " (N'Podujevo'), (N'Požarevac'), (N'Požega'), (N'Preševo'), (N'Priboj na Limu'), (N'Prizren'), (N'Prijepolje')," +
    " (N'Priština'), (N'Prokuplje'), (N'Ražanj'), (N'Rakovica'), (N'Rača'), (N'Raška'), (N'Rekovac')," +
    " (N'Ruma'), (N'Savski Venac'), (N'Svilajnac'), (N'Svrljig'), (N'Senta'), (N'Sečanj'), (N'Sjenica')," +
    " (N'Smederevo'), (N'Smederevska Palanka'), (N'Sokobanja'), (N'Sombor'), (N'Sopot'), (N'Srbica'), (N'Srbobran')," +
    " (N'Sremska Mitrovica'), (N'Sremski Karlovci'), (N'Stara Pazova'), (N'Stari grad'), (N'Stragari'), (N'Subotica'), (N'Suva Reka')," +
    " (N'Surdulica'), (N'Surčin'), (N'Temerin'), (N'Titel'), (N'Topola'), (N'Trgovište'), (N'Trstenik')," +
    " (N'Tutin'), (N'Ćićevac'), (N'Ćuprija'), (N'Ub'), (N'Užice'), (N'Uroševac'), (N'Crveni Krst')," +
    " (N'Crna Trava'), (N'Crvenka'), (N'Čajetina'),(N'Čačak'), (N'Čoka'), (N'Čukarica'), (N'Šabac'), (N'Šid')," +
    " (N'Štimlje'), (N'Štrpce'); ");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
