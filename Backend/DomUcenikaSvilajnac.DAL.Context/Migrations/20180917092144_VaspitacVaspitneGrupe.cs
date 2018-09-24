using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class VaspitacVaspitneGrupe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VaspitacId",
                table: "VaspitneGrupe",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_VaspitneGrupe_VaspitacId",
                table: "VaspitneGrupe",
                column: "VaspitacId");

            migrationBuilder.AddForeignKey(
                name: "FK_VaspitneGrupe_Vaspitaci_VaspitacId",
                table: "VaspitneGrupe",
                column: "VaspitacId",
                principalTable: "Vaspitaci",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VaspitneGrupe_Vaspitaci_VaspitacId",
                table: "VaspitneGrupe");

            migrationBuilder.DropIndex(
                name: "IX_VaspitneGrupe_VaspitacId",
                table: "VaspitneGrupe");

            migrationBuilder.DropColumn(
                name: "VaspitacId",
                table: "VaspitneGrupe");
        }
    }
}
