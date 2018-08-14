using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class SpajanjeUcenikaSaTipomPorodice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipPorodiceId",
                table: "Ucenici",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ucenici_TipPorodiceId",
                table: "Ucenici",
                column: "TipPorodiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ucenici_TipoviPorodice_TipPorodiceId",
                table: "Ucenici",
                column: "TipPorodiceId",
                principalTable: "TipoviPorodice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ucenici_TipoviPorodice_TipPorodiceId",
                table: "Ucenici");

            migrationBuilder.DropIndex(
                name: "IX_Ucenici_TipPorodiceId",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "TipPorodiceId",
                table: "Ucenici");
        }
    }
}
