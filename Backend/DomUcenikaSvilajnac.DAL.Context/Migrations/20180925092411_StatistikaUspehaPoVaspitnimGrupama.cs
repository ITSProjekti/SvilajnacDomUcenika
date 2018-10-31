using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class StatistikaUspehaPoVaspitnimGrupama : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "UspehVaspitneGrupe",
                table: "Statistike",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "VaspitnaGrupaId",
                table: "Statistike",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Statistike_VaspitnaGrupaId",
                table: "Statistike",
                column: "VaspitnaGrupaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Statistike_VaspitneGrupe_VaspitnaGrupaId",
                table: "Statistike",
                column: "VaspitnaGrupaId",
                principalTable: "VaspitneGrupe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Statistike_VaspitneGrupe_VaspitnaGrupaId",
                table: "Statistike");

            migrationBuilder.DropIndex(
                name: "IX_Statistike_VaspitnaGrupaId",
                table: "Statistike");

            migrationBuilder.DropColumn(
                name: "UspehVaspitneGrupe",
                table: "Statistike");

            migrationBuilder.DropColumn(
                name: "VaspitnaGrupaId",
                table: "Statistike");
        }
    }
}
