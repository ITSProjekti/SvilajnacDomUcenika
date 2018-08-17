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
