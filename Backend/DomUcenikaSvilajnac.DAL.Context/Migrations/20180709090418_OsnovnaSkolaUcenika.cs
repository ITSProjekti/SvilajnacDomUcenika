using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class OsnovnaSkolaUcenika : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PrethodnaSkolaId",
                table: "Ucenici",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ucenici_PrethodnaSkolaId",
                table: "Ucenici",
                column: "PrethodnaSkolaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ucenici_OsnovneSkole_PrethodnaSkolaId",
                table: "Ucenici",
                column: "PrethodnaSkolaId",
                principalTable: "OsnovneSkole",
                principalColumn: "PrethodnaSkolaId");
             //   onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ucenici_OsnovneSkole_PrethodnaSkolaId",
                table: "Ucenici");

            migrationBuilder.DropIndex(
                name: "IX_Ucenici_PrethodnaSkolaId",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "PrethodnaSkolaId",
                table: "Ucenici");
        }
    }
}
