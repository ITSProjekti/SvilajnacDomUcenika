using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class PrvaMigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Opstine",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivOpstine = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opstine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ucenici",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatumRodjenja = table.Column<DateTime>(nullable: false),
                    Ime = table.Column<string>(maxLength: 50, nullable: false),
                    JMBG = table.Column<string>(maxLength: 13, nullable: false),
                    OpstinaId = table.Column<int>(nullable: false),
                    Pol = table.Column<string>(nullable: false),
                    Prezime = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ucenici", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ucenici_Opstine_OpstinaId",
                        column: x => x.OpstinaId,
                        principalTable: "Opstine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ucenici_OpstinaId",
                table: "Ucenici",
                column: "OpstinaId");

        }

               

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ucenici");

            migrationBuilder.DropTable(
                name: "Opstine");
        }
    }
}
