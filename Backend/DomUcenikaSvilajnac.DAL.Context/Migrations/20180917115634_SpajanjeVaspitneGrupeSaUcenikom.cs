using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class SpajanjeVaspitneGrupeSaUcenikom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VaspitnaGrupaId",
                table: "Ucenici",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ucenici_VaspitnaGrupaId",
                table: "Ucenici",
                column: "VaspitnaGrupaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ucenici_VaspitneGrupe_VaspitnaGrupaId",
                table: "Ucenici",
                column: "VaspitnaGrupaId",
                principalTable: "VaspitneGrupe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            //migrationBuilder.Sql("insert into TipoviPorodice (NazivTipaPorodice) values " +
            //             "(N'Kompletna')," +
            //             "(N'Bez majke')," +
            //             "(N'Bez oca')," +
            //             "(N'Bez oba roditelja')," +
            //             "(N'Roditelji razvedeni')");

            //migrationBuilder.Sql("insert into BrojeviTelefona (Kucni, Mobilni) values ('01123485', '06x124598')");

            //migrationBuilder.Sql("insert into Vaspitaci (BrojTelefona, Ime, Prezime, Slika) values ('123456789', 'VaspitacIme', 'VaspitacPrezime', 'slika')");

            //migrationBuilder.Sql("insert into VaspitneGrupe (Naziv, VaspitacId) values ('VaspitnaGrupa', (select top 1 Id from Vaspitaci))");

            //migrationBuilder.Sql("insert into Ucenici (DatumRodjenja, Ime, JMBG, OpstinaId, Prezime, DrzavaRodjenjaId, " +
            //                  "OpstinaPrebivalistaId, PolId, TelefonId, Adresa, VremeUpisa, PostanskiBrojId, PrethodnaSkolaId, " +
            //                  "UpisanaSkolaId, MestoPrebivalistaId, MestoRodjenjaId, MestoZavrseneSkoleId, SmerId, RazredId, PrethodniUspeh, MaterijalniPrihodi, Slika, TipPorodiceId, VaspitnaGrupaId) " +
            //                  "values " +
            //                  "('4-4-2010 12:00:00 AM', 'Pera', '1234567890123', 151, 'Perić', 151, 151, 1, (select top 1 Id from BrojeviTelefona)," +
            //                  " 'Atlantida 15', '4-4-2010 12:00:00 AM', 151, 151, 151, 151, 151, 151, 4, 1, 5, 10000, 'slika', (select top 1 Id from TipoviPorodice), (select top 1 Id from VaspitneGrupe))");

            //migrationBuilder.Sql("insert into Roditelji (Ime, Prezime, UcenikId, BrojTelefona, StepenObrazovanjaId) " +
            //                   "values ('ImeO', 'PrezimeO', (select top 1 Id from Ucenici), '06x165584', 8) ," +
            //                   "('ImeM', 'PrezimeM', (select top 1 Id from Ucenici), '06x46864', 7)");

            //migrationBuilder.Sql("insert into Kazne (Opis, BodoviKazne, UcenikId) values ('Izbacen sa casa', 3, (select top 1 Id from Ucenici) )");

            //migrationBuilder.Sql("insert into Pohvale (Opis, UcenikId, BodoviPohvale) values ('Ističe se', (select top 1 Id from Ucenici), 5)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ucenici_VaspitneGrupe_VaspitnaGrupaId",
                table: "Ucenici");

            migrationBuilder.DropIndex(
                name: "IX_Ucenici_VaspitnaGrupaId",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "VaspitnaGrupaId",
                table: "Ucenici");
        }
    }
}
