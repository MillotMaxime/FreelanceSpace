using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class yearExperiencePrograminLanguage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offre_Penalty_Penaltyid",
                table: "Offre");

            migrationBuilder.DropIndex(
                name: "IX_Offre_Penaltyid",
                table: "Offre");

            migrationBuilder.DropColumn(
                name: "Penaltyid",
                table: "Offre");

            migrationBuilder.AddColumn<int>(
                name: "YearExperience",
                table: "OffreLanguagesComputer",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YearExperience",
                table: "OffreLanguagesComputer");

            migrationBuilder.AddColumn<int>(
                name: "Penaltyid",
                table: "Offre",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Offre_Penaltyid",
                table: "Offre",
                column: "Penaltyid");

            migrationBuilder.AddForeignKey(
                name: "FK_Offre_Penalty_Penaltyid",
                table: "Offre",
                column: "Penaltyid",
                principalTable: "Penalty",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
