using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class SpajanjeUcenikaIMestaDvaPuta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MestoPrebivalistaId",
                table: "Ucenici",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MestoRodjenjaId",
                table: "Ucenici",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ucenici_MestoPrebivalistaId",
                table: "Ucenici",
                column: "MestoPrebivalistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ucenici_MestoRodjenjaId",
                table: "Ucenici",
                column: "MestoRodjenjaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ucenici_Mesta_MestoPrebivalistaId",
                table: "Ucenici",
                column: "MestoPrebivalistaId",
                principalTable: "Mesta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ucenici_Mesta_MestoRodjenjaId",
                table: "Ucenici",
                column: "MestoRodjenjaId",
                principalTable: "Mesta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ucenici_Mesta_MestoPrebivalistaId",
                table: "Ucenici");

            migrationBuilder.DropForeignKey(
                name: "FK_Ucenici_Mesta_MestoRodjenjaId",
                table: "Ucenici");

            migrationBuilder.DropIndex(
                name: "IX_Ucenici_MestoPrebivalistaId",
                table: "Ucenici");

            migrationBuilder.DropIndex(
                name: "IX_Ucenici_MestoRodjenjaId",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "MestoPrebivalistaId",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "MestoRodjenjaId",
                table: "Ucenici");
        }
    }
}
