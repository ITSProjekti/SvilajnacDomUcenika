using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class PohvaleIKazneUcenika : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Kazne",
                table: "Ucenici",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pohvale",
                table: "Ucenici",
                nullable: true);


            migrationBuilder.Sql("insert into TipoviPorodice (NazivTipaPorodice) values " +
                          "(N'Kompletna')," +
                          "(N'Bez majke')," +
                          "(N'Bez oca')," +
                          "(N'Bez oba roditelja')," +
                          "(N'Roditelji razvedeni')");

            migrationBuilder.Sql("insert into BrojeviTelefona (Kucni, Mobilni) values ('01123485', '06x124598')");


            migrationBuilder.Sql("Insert into Ucenici (DatumRodjenja, Ime, JMBG, OpstinaId, Prezime, DrzavaRodjenjaId, " +
                               "OpstinaPrebivalistaId, PolId, TelefonId, Adresa, VremeUpisa, PostanskiBrojId, PrethodnaSkolaId, " +
                               "UpisanaSkolaId, MestoPrebivalistaId, MestoRodjenjaId, MestoZavrseneSkoleId, SmerId, RazredId, PrethodniUspeh, Slika, TipPorodiceId, Kazne, Pohvale) " +
                               "values " +
                               "('4-4-2010 12:00:00 AM', 'Pera', '1234567890123', 151, 'Perić', 151, 151, 1, (select top 1 Id from BrojeviTelefona)," +
                               " 'Atlantida 15', '4-4-2010 12:00:00 AM', 151, 151, 151, 151, 151, 151, 4, 1, 5, 'slika', 1, 'Kazna', 'Pohvala')");



            migrationBuilder.Sql("insert into Roditelji (Ime, Prezime, UcenikId, BrojTelefona, StepenObrazovanjaId) " +
                                "values ('ImeO', 'PrezimeO', (select top 1 Id from Ucenici), '06x165584', 8) ," +
                                "('ImeM', 'PrezimeM', (select top 1 Id from Ucenici), '06x46864', 7)");
        }

        

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kazne",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "Pohvale",
                table: "Ucenici");
        }
    }
}
