using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class SpajanjeBrojevaSaOpstinom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostanskiBrojevi_Opstine_OpstinaId",
                table: "PostanskiBrojevi");

            migrationBuilder.AlterColumn<int>(
                name: "OpstinaId",
                table: "PostanskiBrojevi",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_PostanskiBrojevi_Opstine_OpstinaId",
                table: "PostanskiBrojevi",
                column: "OpstinaId",
                principalTable: "Opstine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostanskiBrojevi_Opstine_OpstinaId",
                table: "PostanskiBrojevi");

            migrationBuilder.AlterColumn<int>(
                name: "OpstinaId",
                table: "PostanskiBrojevi",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PostanskiBrojevi_Opstine_OpstinaId",
                table: "PostanskiBrojevi",
                column: "OpstinaId",
                principalTable: "Opstine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
