using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class PrethodneSkoleUcenika : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostanskiBrojevi_Opstine_OpstinaId",
                table: "PostanskiBrojevi");

            migrationBuilder.AlterColumn<int>(
                name: "OpstinaId",
                table: "PostanskiBrojevi",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "PrethodneSkole",
                columns: table => new
                {
                    PrethodnaSkolaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivPrethodneSkole = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrethodneSkole", x => x.PrethodnaSkolaId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PostanskiBrojevi_Opstine_OpstinaId",
                table: "PostanskiBrojevi",
                column: "OpstinaId",
                principalTable: "Opstine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostanskiBrojevi_Opstine_OpstinaId",
                table: "PostanskiBrojevi");

            migrationBuilder.DropTable(
                name: "PrethodneSkole");

            migrationBuilder.AlterColumn<int>(
                name: "OpstinaId",
                table: "PostanskiBrojevi",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_PostanskiBrojevi_Opstine_OpstinaId",
                table: "PostanskiBrojevi",
                column: "OpstinaId",
                principalTable: "Opstine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
