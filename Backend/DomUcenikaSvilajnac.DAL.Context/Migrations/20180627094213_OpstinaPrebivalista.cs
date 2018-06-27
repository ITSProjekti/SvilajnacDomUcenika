using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class OpstinaPrebivalista : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ucenici_Opstine_OpstinaId",
                table: "Ucenici");

            migrationBuilder.AlterColumn<int>(
                name: "OpstinaId",
                table: "Ucenici",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "OpstinaPrebivalistaId",
                table: "Ucenici",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ucenici_OpstinaPrebivalistaId",
                table: "Ucenici",
                column: "OpstinaPrebivalistaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ucenici_Opstine_OpstinaId",
                table: "Ucenici",
                column: "OpstinaId",
                principalTable: "Opstine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ucenici_Opstine_OpstinaPrebivalistaId",
                table: "Ucenici",
                column: "OpstinaPrebivalistaId",
                principalTable: "Opstine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ucenici_Opstine_OpstinaId",
                table: "Ucenici");

            migrationBuilder.DropForeignKey(
                name: "FK_Ucenici_Opstine_OpstinaPrebivalistaId",
                table: "Ucenici");

            migrationBuilder.DropIndex(
                name: "IX_Ucenici_OpstinaPrebivalistaId",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "OpstinaPrebivalistaId",
                table: "Ucenici");

            migrationBuilder.AlterColumn<int>(
                name: "OpstinaId",
                table: "Ucenici",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ucenici_Opstine_OpstinaId",
                table: "Ucenici",
                column: "OpstinaId",
                principalTable: "Opstine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
