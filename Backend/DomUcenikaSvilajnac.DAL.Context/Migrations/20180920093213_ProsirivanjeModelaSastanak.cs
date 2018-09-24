using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class ProsirivanjeModelaSastanak : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BrojPrisutnihUcenika",
                table: "Sastanci",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UkupanBrojPrisutnihUcenika",
                table: "Sastanci",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrojPrisutnihUcenika",
                table: "Sastanci");

            migrationBuilder.DropColumn(
                name: "UkupanBrojPrisutnihUcenika",
                table: "Sastanci");
        }
    }
}
