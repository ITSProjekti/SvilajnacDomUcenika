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
   "('Ada'), ('Aleksandrovac'), ('Aleksinac'), ('Alibunar'), ('Apatin'), ('Aranđelovac'), ('Arilje')," +
   "('Babušnica'), ('Bajina Bašta'), ('Barajevo'), ('Batočina'), ('Bač'), ('Bačka Palanka'), ('Bačka Topola')," +
   "('Bački Petrovac'), ('Bela Palanka'), ('Bela Crkva'),('Beočin'), ('Bečej'),('Blace'),('Bogatić')," +
   "('Bojnik'), ('Boljevac'), ('Bor'), ('Bosilegrad'),('Brus'), ('Bujanovac'), ('Valjevo')," +
   " ('Varvarin'), ('Velika Plana'), ('Veliko Gradište'), ('Vitina'), ('Vladimirci'), ('Vladičin Han')," +
   " ('Vlasotince'), ('Voždovac'), ('Vranje'), ('Vračar'), ('Vrbas'), ('Vrnjačka Banja'), ('Vršac')," +
   " ('Vučitrn'), ('Gadžin Han'), ('Glogovac'), ('Gnjilane'), ('Golubac'), ('Gora'), ('Gornji Milanovac')," +
   " ('Grocka'), ('Despotovac'), ('Dečani'), ('Dimitrovgrad'), ('Doljevac'), ('Đakovica'), ('Žabalj')," +
   " ('Žabari'), ('Žagubica'), ('Žitište'), ('Žitorađa'), ('Zaječar'), ('Zvezdara'), ('Zvečan')," +
   " ('Zemun'), ('Zrenjanin'), ('Zubin Potok '), ('Ivanjica'), ('Inđija'), ('Irig'), ('Istok')," +
   " ('Jagodina'), ('Kanjiža'), ('Kačanik'), ('Kikinda'), ('Kladovo'), ('Klina'), ('Knić')," +
   " ('Knjaževac'), ('Kovačica'), ('Kovin'), ('Kosjerić'), ('Kosovo Polje'), ('Kosovska Kamenica'), ('Kosovska Mitrovica')," +
   " ('Koceljeva'), ('Kragujevac'), ('Kraljevo'), ('Krupanj'), ('Kruševac'), ('Kula'), ('Kuršumlija')," +
   " ('Kučevo'), ('Lazarevac'), ('Lajkovac'), ('Lapovo'), ('Lebane'), ('Leposavić'), ('Leskovac'), " +
   " ('Lipljan'), ('Loznica'), ('Lučani'), ('Ljig'), ('Ljubovija'), ('Majdanpek')," +
   " ('Mali Zvornik'), ('Mali Iđoš'), ('Malo Crniće'), ('Medveđa'), ('Mediana'), ('Merošina')," +
   " ('Mionica'), ('Mladenovac'), ('Negotin'), ('Niška Banja'), ('Nova Varoš'), ('Nova Crnja'), ('Novi Beograd')," +
   " ('Novi Bečej'), ('Novi Kneževac'), ('Novi Pazar'), ('Novi Sad'), ('Novo Brdo'), ('Obilić'), ('Obrenovac')," +
   " ('Opovo'), ('Orahovac'), ('Osečina'), ('Odžaci'), ('Palilula'), ('Palilula (Niš) '), ('Pantelej')," +
   " ('Pančevo '), ('Paraćin'), ('Petrovaradin'), ('Petrovac na Mlavi'), ('Peć'), ('Pećinci'), ('Pirot'), ('Plandište')," +
   " ('Podujevo'), ('Požarevac'), ('Požega'), ('Preševo'), ('Priboj na Limu'), ('Prizren'), ('Prijepolje')," +
   " ('Priština'), ('Prokuplje'), ('Ražanj'), ('Rakovica'), ('Rača'), ('Raška'), ('Rekovac')," +
   " ('Ruma'), ('Savski venac'), ('Svilajnac'), ('Svrljig'), ('Senta'), ('Sečanj'), ('Sjenica')," +
   " ('Smederevo'), ('Smederevska Palanka'), ('Sokobanja'), ('Sombor'), ('Sopot'), ('Srbica'), ('Srbobran')," +
   " ('Sremska Mitrovica'), ('Sremski Karlovci'), ('Stara Pazova'), ('Stari grad'), ('Stragari'), ('Subotica'), ('Suva Reka')," +
   " ('Surdulica'), ('Surčin'), ('Temerin'), ('Titel'), ('Topola'), ('Trgovište'), ('Trstenik')," +
   " ('Tutin'), ('Ćićevac'), ('Ćuprija'), ('Ub'), ('Užice'), ('Uroševac'), ('Crveni krst')," +
   " ('Crna Trava'), ('Čajetina'),('Čačak'), ('Čoka'), ('Čukarica'), ('Šabac'), ('Šid')," +
   " ('Štimlje'), ('Štrpce'); ");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
