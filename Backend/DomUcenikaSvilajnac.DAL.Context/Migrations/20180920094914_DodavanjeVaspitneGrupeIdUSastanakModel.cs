using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class DodavanjeVaspitneGrupeIdUSastanakModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VaspitnaGrupaId",
                table: "Sastanci",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sastanci_VaspitnaGrupaId",
                table: "Sastanci",
                column: "VaspitnaGrupaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sastanci_VaspitneGrupe_VaspitnaGrupaId",
                table: "Sastanci",
                column: "VaspitnaGrupaId",
                principalTable: "VaspitneGrupe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sastanci_VaspitneGrupe_VaspitnaGrupaId",
                table: "Sastanci");

            migrationBuilder.DropIndex(
                name: "IX_Sastanci_VaspitnaGrupaId",
                table: "Sastanci");

            migrationBuilder.DropColumn(
                name: "VaspitnaGrupaId",
                table: "Sastanci");
        }
    }
}
