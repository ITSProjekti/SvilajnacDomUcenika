using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class SlikaUcenikaIOstaliAtributi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaterijalniPrihodi",
                table: "Ucenici",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Slika",
                table: "Ucenici",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipPorodiceId",
                table: "Ucenici",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Staratelji",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    UcenikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staratelji", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staratelji_Ucenici_UcenikId",
                        column: x => x.UcenikId,
                        principalTable: "Ucenici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TipoviPorodice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivTipaPorodice = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoviPorodice", x => x.Id);
                });


            migrationBuilder.Sql("insert into TipoviPorodice (NazivTipaPorodice) values " +
                          "(N'Kompletna')," +
                          "(N'Bez majke')," +
                          "(N'Bez oca')," +
                          "(N'Bez oba roditelja')," +
                          "(N'Roditelji razvedeni')");

            migrationBuilder.Sql("insert into BrojeviTelefona (Kucni, Mobilni) values ('01123485', '06x124598')");


            migrationBuilder.Sql("Insert into Ucenici (DatumRodjenja, Ime, JMBG, OpstinaId, Prezime, DrzavaRodjenjaId, " +
                               "OpstinaPrebivalistaId, PolId, TelefonId, Adresa, VremeUpisa, PostanskiBrojId, PrethodnaSkolaId, " +
                               "UpisanaSkolaId, MestoPrebivalistaId, MestoRodjenjaId, MestoZavrseneSkoleId, SmerId, RazredId, PrethodniUspeh, Slika, TipPorodiceId) " +
                               "values " +
                               "('4-4-2010 12:00:00 AM', 'Pera', '1234567890123', 151, 'Perić', 151, 151, 1, (select top 1 Id from BrojeviTelefona)," +
                               " 'Atlanitda 15', '4-4-2010 12:00:00 AM', 151, 151, 151, 151, 151, 151, 4, 1, 5, 'slika', 1)");



            migrationBuilder.Sql("insert into Roditelji (Ime, Prezime, UcenikId, BrojTelefona, StepenObrazovanjaId) " +
                                "values ('ImeO', 'PrezimeO', (select top 1 Id from Ucenici), '06x165584', 8) ," +
                                "('ImeM', 'PrezimeM', (select top 1 Id from Ucenici), '06x46864', 7)");


            

            

            


            migrationBuilder.CreateIndex(
                name: "IX_Ucenici_TipPorodiceId",
                table: "Ucenici",
                column: "TipPorodiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Staratelji_UcenikId",
                table: "Staratelji",
                column: "UcenikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ucenici_TipoviPorodice_TipPorodiceId",
                table: "Ucenici",
                column: "TipPorodiceId",
                principalTable: "TipoviPorodice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ucenici_TipoviPorodice_TipPorodiceId",
                table: "Ucenici");

            migrationBuilder.DropTable(
                name: "Staratelji");

            migrationBuilder.DropTable(
                name: "TipoviPorodice");

            migrationBuilder.DropIndex(
                name: "IX_Ucenici_TipPorodiceId",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "MaterijalniPrihodi",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "Slika",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "TipPorodiceId",
                table: "Ucenici");
        }
    }
}
