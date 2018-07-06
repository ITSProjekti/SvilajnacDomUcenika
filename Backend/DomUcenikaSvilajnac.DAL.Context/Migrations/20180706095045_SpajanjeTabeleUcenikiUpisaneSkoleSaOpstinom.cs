using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class SpajanjeTabeleUcenikiUpisaneSkoleSaOpstinom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OpstinaId",
                table: "SrednjeSkole",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SrednjeSkole_OpstinaId",
                table: "SrednjeSkole",
                column: "OpstinaId");

            migrationBuilder.AddForeignKey(
                name: "FK_SrednjeSkole_Opstine_OpstinaId",
                table: "SrednjeSkole",
                column: "OpstinaId",
                principalTable: "Opstine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SrednjeSkole_Opstine_OpstinaId",
                table: "SrednjeSkole");

            migrationBuilder.DropIndex(
                name: "IX_SrednjeSkole_OpstinaId",
                table: "SrednjeSkole");

            migrationBuilder.DropColumn(
                name: "OpstinaId",
                table: "SrednjeSkole");
        }
    }
}
