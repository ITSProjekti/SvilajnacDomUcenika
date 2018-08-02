using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class StrucnaSpremaRoditeljaIBrojTelefona : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BrojTelefona",
                table: "Roditelji",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StepenObrazovanjaId",
                table: "Roditelji",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Roditelji_StepenObrazovanjaId",
                table: "Roditelji",
                column: "StepenObrazovanjaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Roditelji_StepeniStrucneSpreme_StepenObrazovanjaId",
                table: "Roditelji",
                column: "StepenObrazovanjaId",
                principalTable: "StepeniStrucneSpreme",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roditelji_StepeniStrucneSpreme_StepenObrazovanjaId",
                table: "Roditelji");

            migrationBuilder.DropIndex(
                name: "IX_Roditelji_StepenObrazovanjaId",
                table: "Roditelji");

            migrationBuilder.DropColumn(
                name: "BrojTelefona",
                table: "Roditelji");

            migrationBuilder.DropColumn(
                name: "StepenObrazovanjaId",
                table: "Roditelji");
        }
    }
}
