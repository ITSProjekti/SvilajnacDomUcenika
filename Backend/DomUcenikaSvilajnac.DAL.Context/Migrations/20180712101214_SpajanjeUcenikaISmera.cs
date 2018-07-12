using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class SpajanjeUcenikaISmera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SmerId",
                table: "Ucenici",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ucenici_SmerId",
                table: "Ucenici",
                column: "SmerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ucenici_Smerovi_SmerId",
                table: "Ucenici",
                column: "SmerId",
                principalTable: "Smerovi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ucenici_Smerovi_SmerId",
                table: "Ucenici");

            migrationBuilder.DropIndex(
                name: "IX_Ucenici_SmerId",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "SmerId",
                table: "Ucenici");
        }
    }
}
