using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class modifOffreVariable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "But",
                table: "Offre",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionFreelance",
                table: "Offre",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeOffer",
                table: "Offre",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "But",
                table: "Offre");

            migrationBuilder.DropColumn(
                name: "DescriptionFreelance",
                table: "Offre");

            migrationBuilder.DropColumn(
                name: "TypeOffer",
                table: "Offre");
        }
    }
}
