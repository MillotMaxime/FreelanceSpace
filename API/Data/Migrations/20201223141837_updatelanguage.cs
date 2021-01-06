using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class updatelanguage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OffreLanguagesComputer_Computer_ComputerLanguageId",
                table: "OffreLanguagesComputer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Computer",
                table: "Computer");

            migrationBuilder.RenameTable(
                name: "Computer",
                newName: "ComputerLanguage");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComputerLanguage",
                table: "ComputerLanguage",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OffreLanguagesComputer_ComputerLanguage_ComputerLanguageId",
                table: "OffreLanguagesComputer",
                column: "ComputerLanguageId",
                principalTable: "ComputerLanguage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OffreLanguagesComputer_ComputerLanguage_ComputerLanguageId",
                table: "OffreLanguagesComputer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComputerLanguage",
                table: "ComputerLanguage");

            migrationBuilder.RenameTable(
                name: "ComputerLanguage",
                newName: "Computer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Computer",
                table: "Computer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OffreLanguagesComputer_Computer_ComputerLanguageId",
                table: "OffreLanguagesComputer",
                column: "ComputerLanguageId",
                principalTable: "Computer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
