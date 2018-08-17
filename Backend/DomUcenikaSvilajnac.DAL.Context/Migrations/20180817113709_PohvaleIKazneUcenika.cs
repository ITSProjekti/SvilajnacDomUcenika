using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class PohvaleIKazneUcenika : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Kazne",
                table: "Ucenici",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pohvale",
                table: "Ucenici",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kazne",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "Pohvale",
                table: "Ucenici");
        }
    }
}
