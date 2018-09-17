using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class SpajanjeVaspitneGrupeSaUcenikom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VaspitnaGrupaId",
                table: "Ucenici",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ucenici_VaspitnaGrupaId",
                table: "Ucenici",
                column: "VaspitnaGrupaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ucenici_VaspitneGrupe_VaspitnaGrupaId",
                table: "Ucenici",
                column: "VaspitnaGrupaId",
                principalTable: "VaspitneGrupe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ucenici_VaspitneGrupe_VaspitnaGrupaId",
                table: "Ucenici");

            migrationBuilder.DropIndex(
                name: "IX_Ucenici_VaspitnaGrupaId",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "VaspitnaGrupaId",
                table: "Ucenici");
        }
    }
}
