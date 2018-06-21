using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class SpajanjeTabelaMestoiUcenik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MestoId",
                table: "Ucenici",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ucenici_MestoId",
                table: "Ucenici",
                column: "MestoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ucenici_Mesta_MestoId",
                table: "Ucenici",
                column: "MestoId",
                principalTable: "Mesta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.Sql("insert into Mesta (Naziv) values " +
                "('Beograd'), ('Čačak'), ('Jagodina'),  " +
                "('Kikinda'), ('Kragujevac'), ('Kraljevo'), " +
                "('Kruševac'), ('Leskovac'), ('Loznica'), " +
                "('Niš'), ('Novi Pazar'), ('Novi Sad')," +
                "('Pančevo'), ('Pirot'), ('Požarevac'), " +
                "('Priština'), ('Šabac'), ('Smederevo')," +
                "('Sombor'), ('Sremska Mitrovica'), ('Subotica'), " +
                "('Užice'), ('Valjevo'), ('Vranje'), " +
                "('Vršac'), ('Zaječar'), ('Zrenjanin')");

            //migrationBuilder.Sql("insert into Ucenici (Ime, Prezime, JMBG, Pol, DatumRodjenja, MestoId) values" +
            //    "('Marko','Marakovic','1234567890123', 'Muski', '5.5.2005', (select top 1 Id from Mesta))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ucenici_Mesta_MestoId",
                table: "Ucenici");

            migrationBuilder.DropIndex(
                name: "IX_Ucenici_MestoId",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "MestoId",
                table: "Ucenici");

            migrationBuilder.Sql("delete from Mesta where Naziv in ('Beograd', 'Čačak', 'Jagodina'," +
                "'Kikinda', 'Kragujevac', 'Kraljevo'," +
                "'Kruševac', 'Leskovac', 'Loznica'," +
                "'Niš', 'Novi Pazar', 'Novi Sad'," +
                "'Pančevo', 'Pirot', 'Požarevac'," +
                "'Priština', 'Šabac', 'Smederevo'," +
                "'Sombor', 'Sremska Mitrovica', 'Subotica'," +
                "'Užice', 'Valjevo', 'Vranje'," +
                "'Vršac', 'Zaječar', 'Zrenjanin')");

            migrationBuilder.Sql("DBCC CHECKIDENT ('[Mesta]', RESEED, 0)");

            migrationBuilder.Sql("delete from Ucenici");

            migrationBuilder.Sql("DBCC CHECKIDENT ('[Ucenici]', RESEED, 0)");
        }
    }
}
