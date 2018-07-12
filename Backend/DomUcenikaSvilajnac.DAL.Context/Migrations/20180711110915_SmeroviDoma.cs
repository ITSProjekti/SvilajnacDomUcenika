using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class SmeroviDoma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Smerovi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivSmera = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Smerovi", x => x.Id);
                });
            migrationBuilder.Sql("insert into Smerovi (NazivSmera) values " +
               "('Veterinarski tehničar')," +
               "('Poljoprivredni tehničar')," +
               "('Mesar')," +
               "('Prehrambeni tehničar')," +
               "('Tehničar hortikulture')," +
               "('Rukovalac - mehaničar poljoprivredne tehnike')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Smerovi");
        }
    }
}
