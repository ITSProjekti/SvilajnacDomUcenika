using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class StepenStrucneSpreme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StepeniStrucneSpreme",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Opis = table.Column<string>(nullable: true),
                    Stepen = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StepeniStrucneSpreme", x => x.Id);
                });

            migrationBuilder.Sql("insert into StepeniStrucneSpreme (Stepen, Opis) values " +
                "('I stepen', N'Niži razredi osnovne škole')," +
                "('II stepen', N'Viši razredi osnovne škole')," +
                "('III stepen', N'Trogodišnja zanatska škola')," +
                "('IV stepen', N'Četvorogodišnja stručna škola')," +
                "('V stepen', N'Četvorogodišnja zanatska škola')," +
                "('VI-1 stepen', N'Dvogodišnja viša škola')," +
                "('VI-2 stepen', N'Trogodišnje strukovne studije')," +
                "('VI-2 stepen', N'Trogodišnje akademske studije')," +
                "('VII-1 stepen', N'Četvorogodišnje osnovne studije')," +
                "('VII-1 stepen', N'Šestogodišnje osnovne studije medicine ili veterine')," +
                "('VII-2 stepen', N'Petogodišnje ili četvorogodišnje osnovne studije + jednogodišnje specijalističke studije (pre 2005.god.)')," +
                "('VII-2 stepen', N'Magistratura (magistar nauka, MR)')," +
                "('VIII stepen', N'Doktorat (doktor nauka, DR)')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StepeniStrucneSpreme");
        }
    }
}
