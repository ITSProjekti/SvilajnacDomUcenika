using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class PovezivanjePohvaleIUcenika : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UcenikId",
                table: "Pohvale",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pohvale_UcenikId",
                table: "Pohvale",
                column: "UcenikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pohvale_Ucenici_UcenikId",
                table: "Pohvale",
                column: "UcenikId",
                principalTable: "Ucenici",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pohvale_Ucenici_UcenikId",
                table: "Pohvale");

            migrationBuilder.DropIndex(
                name: "IX_Pohvale_UcenikId",
                table: "Pohvale");

            migrationBuilder.DropColumn(
                name: "UcenikId",
                table: "Pohvale");
        }
    }
}
