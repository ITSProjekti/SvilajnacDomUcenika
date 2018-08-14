using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class TipPorodice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoviPorodice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivTipaPorodice = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoviPorodice", x => x.Id);
                });
            migrationBuilder.Sql("insert into TipoviPorodice (NazivTipaPorodice) values " +
                          "(N'Kompletna')," +
                          "(N'Bez majke')," +
                          "(N'Bez oca')," +
                          "(N'Bez oba roditelja')," +
                          "(N'Roditelji razvedeni')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TipoviPorodice");
        }
    }
}
