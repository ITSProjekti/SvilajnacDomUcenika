using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class RemovingMestoAtributeFromUcenik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MestoPrebivalista",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "MestoRodjenja",
                table: "Ucenici");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MestoPrebivalista",
                table: "Ucenici",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MestoRodjenja",
                table: "Ucenici",
                nullable: true);
        }
    }
}
