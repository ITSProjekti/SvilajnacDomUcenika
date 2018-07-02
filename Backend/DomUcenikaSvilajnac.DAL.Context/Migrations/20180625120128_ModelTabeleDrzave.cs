using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    public partial class ModelTabeleDrzave : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drzave",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivDrzave = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzave", x => x.Id);
                });

            migrationBuilder.Sql("insert into Drzave (NazivDrzave) values ('Avganistan'), ('Azerbejdžan'), ('Albanija'), " +
                "('Alžir'), ('Angola'), ('Andora'), ('Antigva i Barbuda'), ('Argentina'), ('Australija'), ('Austrija')," +
                "('Bangladeš'), ('Barbados'), ('Bahami'), ('Bahrein'), ('Belgija'), ('Belize'), ('Belorusija'), ('Benin'), " +
                "('Bolivija'), ('Bosna i Hercegovina'), ('Bocvana'), ('Brazil'), ('Brunej'), ('Bugarska'), ('Burkina Faso'), " +
                "('Burundi'), ('Butan'), ('Vanuatu'), ('Venecuela'), ('Vijetnam'), ('Gabon'), ('Gambija'), ('Gana'), ('Gvajana'), " +
                "('Gvatemala'), ('Gvineja'), ('Gvineja Bisao'),  ('Grenada'), ('Gruzija'), ('Grčka'), ('Danska'), ('Dominika'), " +
                "('Dominikanska Republika'), ('Egipat'), ('Ekvador'), ('Ekvatorijalna Gvineja'), ('Eritreja'), ('Estonija'), " +
                "('Etiopija'), ('Zambija'), ('Zelenortska Ostrva'),('Zimbabve'), ('Izrael'), ('Indija'), ('Indonezija'), ('Irak'), " +
                "('Iran'), ('Irska'), ('Island'), ('Istočni Timor'), ('Italija'), ('Jamajka'), ('Japan'), ('Jemen'), ('Jermenija')," +
                "('Jordan'), ('Južna Krojea'), ('Južni Sudan'), ('Južnoafrička Republika'), ('Kazahstan'), ('Kambodža'), ('Kamerun')," +
                "('Kanada'), ('Katar'), ('Kenija'), ('Kina'), ('Kipar'), ('Kirgistan'), ('Kiribati'), ('Kolumbija'), ('DR Konogo'), ('Kongo')," +
                "('Komori'), ('Kostarika'), ('Kuba'), ('Kuvajt'), ('Laos'), ('Lesoto'), ('Letonija'), ('Liban'), ('Liberija'), ('Libija'), " +
                "('Litvanija'), ('Lihtenštajn'), ('Luksemburg'), ('Madagaskar'), ('Mađarska'), ('Makedonija'), ('Malavi'), ('Maldivi'), ('Malezija'), " +
                "('Mali'), ('Malta'), ('Maroko'), ('Maršalska Ostrva'), ('Mauritanija'), ('Mauricijus'), ('Meksiko'), ('Mikronezija'), ('Mjanmar'), " +
                "('Mozambik'), ('Moldavija'), ('Monako'), ('Mongolija'), ('Namibija'), ('Nauru'), ('Nemačka'), ('Nepal'), ('Niger'), ('Nigerija'), " +
                "('Nikaragva'), ('Novi Zeland'), ('Norveška'), ('Obala Slonovače'), ('Oman'), ('Pakistan'), ('Palau'), ('Panama'), " +
                "('Papua Nova Gvineja'), ('Paragvaj'), ('Peru'), ('Poljska'), ('Portugalija'), ('Ruanda'), ('Rumunija'), ('Rusija'), " +
                "('Salvador'), ('Samoa'), ('San Marino'), ('Sao Tome i Prinsipe'), ('Saudijska Arabija'), ('Svaziland'), ('Sveta Lucija'), " +
                "('Sveti Vinsent i Grenadini'), ('Sent Kits i Nevis'), ('Severna Koreja'), ('Sejšeli'), ('Senegal'), ('Sijera Leone'), " +
                "('Singapur'), ('Sirija'), ('Sjedinjene Američke Države'), ('Slovačka'), ('Slovenija'), ('Solomonska Ostrva'), ('Somalija'), " +
                "('Srbija'), ('Sudan'), ('Surinam'), ('Tajland'), ('Tanzanija'), ('Tadžikistan'), ('Togo'), ('Tonga'), ('Trinidad i Tobago'), " +
                "('Tuvalu'), ('Tunis'), ('Turkmenistan'), ('Turska'), ('Uganda'), ('Uzbekistan'), ('Ujedinjeni Arapski Emirati'), ('Ujedinjeno Kraljevstvo')," +
                "('Ukrajina'), ('Urugvaj'), ('Filipini'), ('Finska'), ('Fidži'), ('Francuska'), ('Haiti'), ('Holandija'), ('Honduras'), ('Hrvatska'), " +
                "('Centralnoafrička Republika'), ('Crna Gora'), ('Čad'), ('Češka'), ('Čile'), ('Džibuti'), ('Švajcarska'), ('Švedska'), ('Španija'), " +
                "('Šri Lanka'), ('Vatikan'), ('Palestina')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drzave");
        }
    }
}
