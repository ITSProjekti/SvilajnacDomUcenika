using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class PolSaUcenikom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PolId",
                table: "Ucenici",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ucenici_PolId",
                table: "Ucenici",
                column: "PolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ucenici_Polovi_PolId",
                table: "Ucenici",
                column: "PolId",
                principalTable: "Polovi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ucenici_Polovi_PolId",
                table: "Ucenici");

            migrationBuilder.DropIndex(
                name: "IX_Ucenici_PolId",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "PolId",
                table: "Ucenici");
        }
    }
}
