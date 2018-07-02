using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class SpajanjaPostanskogBrojaSaUcenikom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PostanskiBrojId",
                table: "Ucenici",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ucenici_PostanskiBrojId",
                table: "Ucenici",
                column: "PostanskiBrojId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ucenici_PostanskiBrojevi_PostanskiBrojId",
                table: "Ucenici",
                column: "PostanskiBrojId",
                principalTable: "PostanskiBrojevi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ucenici_PostanskiBrojevi_PostanskiBrojId",
                table: "Ucenici");

            migrationBuilder.DropIndex(
                name: "IX_Ucenici_PostanskiBrojId",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "PostanskiBrojId",
                table: "Ucenici");
        }
    }
}
