using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class PovezivanjeUcenikaSaStarateljom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UcenikId",
                table: "Staratelji",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Staratelji_UcenikId",
                table: "Staratelji",
                column: "UcenikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staratelji_Ucenici_UcenikId",
                table: "Staratelji",
                column: "UcenikId",
                principalTable: "Ucenici",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staratelji_Ucenici_UcenikId",
                table: "Staratelji");

            migrationBuilder.DropIndex(
                name: "IX_Staratelji_UcenikId",
                table: "Staratelji");

            migrationBuilder.DropColumn(
                name: "UcenikId",
                table: "Staratelji");
        }
    }
}
