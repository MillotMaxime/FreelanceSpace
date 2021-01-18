using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class updateAllChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Translate",
                table: "LanguageSpeak");

            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameBusiness",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Siret",
                table: "Users",
                type: "INTEGER",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Login",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NameBusiness",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Siret",
                table: "Users");

            migrationBuilder.AddColumn<bool>(
                name: "Translate",
                table: "LanguageSpeak",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
