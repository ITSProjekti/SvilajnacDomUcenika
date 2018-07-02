using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class DrzavaUcenika : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DrzavaRodjenjaId",
                table: "Ucenici",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ucenici_DrzavaRodjenjaId",
                table: "Ucenici",
                column: "DrzavaRodjenjaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ucenici_Drzave_DrzavaRodjenjaId",
                table: "Ucenici",
                column: "DrzavaRodjenjaId",
                principalTable: "Drzave",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ucenici_Drzave_DrzavaRodjenjaId",
                table: "Ucenici");

            migrationBuilder.DropIndex(
                name: "IX_Ucenici_DrzavaRodjenjaId",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "DrzavaRodjenjaId",
                table: "Ucenici");
        }
    }
}
