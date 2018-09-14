using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class KaznaUcenika : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KaznaId",
                table: "Ucenici",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Kazne",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Opis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kazne", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ucenici_KaznaId",
                table: "Ucenici",
                column: "KaznaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ucenici_Kazne_KaznaId",
                table: "Ucenici",
                column: "KaznaId",
                principalTable: "Kazne",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ucenici_Kazne_KaznaId",
                table: "Ucenici");

            migrationBuilder.DropTable(
                name: "Kazne");

            migrationBuilder.DropIndex(
                name: "IX_Ucenici_KaznaId",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "KaznaId",
                table: "Ucenici");
        }
    }
}
