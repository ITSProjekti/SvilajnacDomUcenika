using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class RazredUcenika : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RazredId",
                table: "Ucenici",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Razredi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrojRazreda = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Razredi", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ucenici_RazredId",
                table: "Ucenici",
                column: "RazredId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ucenici_Razredi_RazredId",
                table: "Ucenici",
                column: "RazredId",
                principalTable: "Razredi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.Sql("insert into Razredi (BrojRazreda) values" +
                "('I'), " +
                "('II'), " +
                "('III'), " +
                "('IV')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ucenici_Razredi_RazredId",
                table: "Ucenici");

            migrationBuilder.DropTable(
                name: "Razredi");

            migrationBuilder.DropIndex(
                name: "IX_Ucenici_RazredId",
                table: "Ucenici");

            migrationBuilder.DropColumn(
                name: "RazredId",
                table: "Ucenici");
        }
    }
}
