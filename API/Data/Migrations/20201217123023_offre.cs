using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class offre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StatutJuridique",
                table: "Users",
                newName: "LegalStatus");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Users",
                newName: "Ago");

            migrationBuilder.RenameColumn(
                name: "Activite",
                table: "Users",
                newName: "Activity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LegalStatus",
                table: "Users",
                newName: "StatutJuridique");

            migrationBuilder.RenameColumn(
                name: "Ago",
                table: "Users",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "Activity",
                table: "Users",
                newName: "Activite");
        }
    }
}
