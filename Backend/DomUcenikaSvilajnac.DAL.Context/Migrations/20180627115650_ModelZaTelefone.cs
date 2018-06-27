using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class ModelZaTelefone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TelefonId",
                table: "Ucenici",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BrojeviTelefona",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Kucni = table.Column<string>(nullable: true),
                    Mobilni = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrojeviTelefona", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ucenici_TelefonId",
                table: "Ucenici",
                column: "TelefonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ucenici_BrojeviTelefona_TelefonId",
                table: "Ucenici",
                column: "TelefonId",
                principalTable: "BrojeviTelefona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ucenici_BrojeviTelefona_TelefonId",
                table: "Ucenici");

            migrationBuilder.DropTable(
                name: "BrojeviTelefona");

            migrationBuilder.DropIndex(
                name: "IX_Ucenici_TelefonId",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "TelefonId",
                table: "Ucenici");
        }
    }
}
