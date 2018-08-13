using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class SpajanjeOpstineiSrednjeSkole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PrethodneSkole",
                table: "PrethodneSkole");

            migrationBuilder.RenameTable(
                name: "PrethodneSkole",
                newName: "OsnovneSkole");

            migrationBuilder.AddColumn<int>(
                name: "OpstinaId",
                table: "OsnovneSkole",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OsnovneSkole",
                table: "OsnovneSkole",
                column: "PrethodnaSkolaId");

            migrationBuilder.CreateIndex(
                name: "IX_OsnovneSkole_OpstinaId",
                table: "OsnovneSkole",
                column: "OpstinaId");

            migrationBuilder.AddForeignKey(
                name: "FK_OsnovneSkole_Opstine_OpstinaId",
                table: "OsnovneSkole",
                column: "OpstinaId",
                principalTable: "Opstine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OsnovneSkole_Opstine_OpstinaId",
                table: "OsnovneSkole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OsnovneSkole",
                table: "OsnovneSkole");

            migrationBuilder.DropIndex(
                name: "IX_OsnovneSkole_OpstinaId",
                table: "OsnovneSkole");

            migrationBuilder.DropColumn(
                name: "OpstinaId",
                table: "OsnovneSkole");

            migrationBuilder.RenameTable(
                name: "OsnovneSkole",
                newName: "PrethodneSkole");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrethodneSkole",
                table: "PrethodneSkole",
                column: "PrethodnaSkolaId");
        }
    }
}
