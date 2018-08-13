using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class MestoZavrseneSkole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MestoZavrseneSkoleId",
                table: "Ucenici",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ucenici_MestoZavrseneSkoleId",
                table: "Ucenici",
                column: "MestoZavrseneSkoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ucenici_Mesta_MestoZavrseneSkoleId",
                table: "Ucenici",
                column: "MestoZavrseneSkoleId",
                principalTable: "Mesta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ucenici_Mesta_MestoZavrseneSkoleId",
                table: "Ucenici");

            migrationBuilder.DropIndex(
                name: "IX_Ucenici_MestoZavrseneSkoleId",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "MestoZavrseneSkoleId",
                table: "Ucenici");
        }
    }
}
