using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class SrednjaSkolaUcenika : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UpisanaSkolaId",
                table: "Ucenici",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ucenici_UpisanaSkolaId",
                table: "Ucenici",
                column: "UpisanaSkolaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ucenici_SrednjeSkole_UpisanaSkolaId",
                table: "Ucenici",
                column: "UpisanaSkolaId",
                principalTable: "SrednjeSkole",
                principalColumn: "Id");
             //   onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ucenici_SrednjeSkole_UpisanaSkolaId",
                table: "Ucenici");

            migrationBuilder.DropIndex(
                name: "IX_Ucenici_UpisanaSkolaId",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "UpisanaSkolaId",
                table: "Ucenici");
        }
    }
}
