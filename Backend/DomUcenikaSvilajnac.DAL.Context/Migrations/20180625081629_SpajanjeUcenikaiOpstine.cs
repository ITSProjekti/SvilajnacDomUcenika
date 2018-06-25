using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class SpajanjeUcenikaiOpstine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OpstinaId",
                table: "Ucenici",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ucenici_OpstinaId",
                table: "Ucenici",
                column: "OpstinaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ucenici_Opstine_OpstinaId",
                table: "Ucenici",
                column: "OpstinaId",
                principalTable: "Opstine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ucenici_Opstine_OpstinaId",
                table: "Ucenici");

            migrationBuilder.DropIndex(
                name: "IX_Ucenici_OpstinaId",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "OpstinaId",
                table: "Ucenici");
        }
    }
}
