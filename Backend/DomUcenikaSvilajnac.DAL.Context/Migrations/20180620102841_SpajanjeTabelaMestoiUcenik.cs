using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class SpajanjeTabelaMestoiUcenik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MestoId",
                table: "Ucenici",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ucenici_MestoId",
                table: "Ucenici",
                column: "MestoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ucenici_Mesta_MestoId",
                table: "Ucenici",
                column: "MestoId",
                principalTable: "Mesta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ucenici_Mesta_MestoId",
                table: "Ucenici");

            migrationBuilder.DropIndex(
                name: "IX_Ucenici_MestoId",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "MestoId",
                table: "Ucenici");
        }
    }
}
