using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class PovezivanjeStatusaPrijaveSaUcenikom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusPrijaveId",
                table: "Ucenici",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ucenici_StatusPrijaveId",
                table: "Ucenici",
                column: "StatusPrijaveId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ucenici_StatusiPrijave_StatusPrijaveId",
                table: "Ucenici",
                column: "StatusPrijaveId",
                principalTable: "StatusiPrijave",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ucenici_StatusiPrijave_StatusPrijaveId",
                table: "Ucenici");

            migrationBuilder.DropIndex(
                name: "IX_Ucenici_StatusPrijaveId",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "StatusPrijaveId",
                table: "Ucenici");
        }
    }
}
