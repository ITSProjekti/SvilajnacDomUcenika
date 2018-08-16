using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class StarateljiRoditelja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staratelji",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staratelji", x => x.Id);
                });

            migrationBuilder.Sql("insert into BrojeviTelefona (Kucni, Mobilni) values ('01123485', '06x124598')");

            migrationBuilder.Sql("Insert into Ucenici (DatumRodjenja, Ime, JMBG, OpstinaId, Prezime, DrzavaRodjenjaId, " +
                               "OpstinaPrebivalistaId, PolId, TelefonId, Adresa, VremeUpisa, PostanskiBrojId, PrethodnaSkolaId, " +
                               "UpisanaSkolaId, MestoPrebivalistaId, MestoRodjenjaId, MestoZavrseneSkoleId, SmerId, RazredId, PrethodniUspeh, Slika, TipPorodiceId) " +
                               "values " +
                               "('4-4-2010 12:00:00 AM', 'Pera', '1234567890123', 151, 'Perić', 151, 151, 1, (select top 1 Id from BrojeviTelefona)," +
                               " 'Atlanitda 15', '4-4-2010 12:00:00 AM', 151, 151, 151, 151, 151, 151, 4, 1, 5, 11001110, 1)");

            migrationBuilder.Sql("insert into Roditelji (Ime, Prezime, UcenikId, BrojTelefona, StepenObrazovanjaId) " +
                                "values ('ImeO', 'PrezimeO', (select top 1 Id from Ucenici), '06x165584', 8) ," +
                                "('ImeM', 'PrezimeM', (select top 1 Id from Ucenici), '06x46864', 7)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staratelji");
        }
    }
}
