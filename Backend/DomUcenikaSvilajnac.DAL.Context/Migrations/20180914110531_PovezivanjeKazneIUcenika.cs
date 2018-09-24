using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class PovezivanjeKazneIUcenika : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BodoviKazne",
                table: "Kazne",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UcenikId",
                table: "Kazne",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Kazne_UcenikId",
                table: "Kazne",
                column: "UcenikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kazne_Ucenici_UcenikId",
                table: "Kazne",
                column: "UcenikId",
                principalTable: "Ucenici",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kazne_Ucenici_UcenikId",
                table: "Kazne");

            migrationBuilder.DropIndex(
                name: "IX_Kazne_UcenikId",
                table: "Kazne");

            migrationBuilder.DropColumn(
                name: "BodoviKazne",
                table: "Kazne");

            migrationBuilder.DropColumn(
                name: "UcenikId",
                table: "Kazne");
        }
    }
}
