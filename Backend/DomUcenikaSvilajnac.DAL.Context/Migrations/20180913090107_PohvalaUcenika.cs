using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class PohvalaUcenika : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PohvalaId",
                table: "Ucenici",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Pohvale",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Opis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pohvale", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ucenici_PohvalaId",
                table: "Ucenici",
                column: "PohvalaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ucenici_Pohvale_PohvalaId",
                table: "Ucenici",
                column: "PohvalaId",
                principalTable: "Pohvale",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ucenici_Pohvale_PohvalaId",
                table: "Ucenici");

            migrationBuilder.DropTable(
                name: "Pohvale");

            migrationBuilder.DropIndex(
                name: "IX_Ucenici_PohvalaId",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "PohvalaId",
                table: "Ucenici");
        }
    }
}
