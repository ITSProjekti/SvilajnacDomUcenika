using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class SpajanjeRoditeljaIUcenika : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UcenikId",
                table: "Roditelji",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Roditelji_UcenikId",
                table: "Roditelji",
                column: "UcenikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Roditelji_Ucenici_UcenikId",
                table: "Roditelji",
                column: "UcenikId",
                principalTable: "Ucenici",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roditelji_Ucenici_UcenikId",
                table: "Roditelji");

            migrationBuilder.DropIndex(
                name: "IX_Roditelji_UcenikId",
                table: "Roditelji");

            migrationBuilder.DropColumn(
                name: "UcenikId",
                table: "Roditelji");
        }
    }
}
