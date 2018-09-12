using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class DrzavaiKontinenti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DrzavaKontinent",
                columns: table => new
                {
                    DrzavaId = table.Column<int>(nullable: false),
                    KontinentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrzavaKontinent", x => new { x.DrzavaId, x.KontinentId });
                    table.ForeignKey(
                        name: "FK_DrzavaKontinent_Drzave_DrzavaId",
                        column: x => x.DrzavaId,
                        principalTable: "Drzave",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DrzavaKontinent_Kontinenti_KontinentId",
                        column: x => x.KontinentId,
                        principalTable: "Kontinenti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DrzavaKontinent_KontinentId",
                table: "DrzavaKontinent",
                column: "KontinentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DrzavaKontinent");
        }
    }
}
