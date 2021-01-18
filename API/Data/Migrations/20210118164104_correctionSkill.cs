using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class correctionSkill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OffreLanguagesComputer_ComputerLanguage_ComputerLanguageId",
                table: "OffreLanguagesComputer");

            migrationBuilder.DropForeignKey(
                name: "FK_OffreLanguagesSpeak_LanguageSpeak_SpeakId",
                table: "OffreLanguagesSpeak");

            migrationBuilder.DropForeignKey(
                name: "FK_Terms_TimeLimit_TimeLimit",
                table: "Terms");

            migrationBuilder.DropTable(
                name: "LanguageSpeak");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComputerLanguage",
                table: "ComputerLanguage");

            migrationBuilder.DropColumn(
                name: "Montant",
                table: "SalaryPenalty");

            migrationBuilder.DropColumn(
                name: "Montant",
                table: "Salary");

            migrationBuilder.RenameTable(
                name: "ComputerLanguage",
                newName: "ProgramingLanguage");

            migrationBuilder.RenameColumn(
                name: "TypeTime",
                table: "TimeLimit",
                newName: "Valeur");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "TimeLimit",
                newName: "TypeTaux");

            migrationBuilder.RenameColumn(
                name: "TimeLimit",
                table: "Terms",
                newName: "Time");

            migrationBuilder.RenameIndex(
                name: "IX_Terms_TimeLimit",
                table: "Terms",
                newName: "IX_Terms_Time");

            migrationBuilder.RenameColumn(
                name: "SpeakId",
                table: "OffreLanguagesSpeak",
                newName: "LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_OffreLanguagesSpeak_SpeakId",
                table: "OffreLanguagesSpeak",
                newName: "IX_OffreLanguagesSpeak_LanguageId");

            migrationBuilder.RenameColumn(
                name: "ComputerLanguageId",
                table: "OffreLanguagesComputer",
                newName: "ProgramingLanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_OffreLanguagesComputer_ComputerLanguageId",
                table: "OffreLanguagesComputer",
                newName: "IX_OffreLanguagesComputer_ProgramingLanguageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProgramingLanguage",
                table: "ProgramingLanguage",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Time",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Valeur = table.Column<int>(type: "INTEGER", nullable: false),
                    TypeTaux = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Time", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_OffreLanguagesComputer_ProgramingLanguage_ProgramingLanguageId",
                table: "OffreLanguagesComputer",
                column: "ProgramingLanguageId",
                principalTable: "ProgramingLanguage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OffreLanguagesSpeak_Language_LanguageId",
                table: "OffreLanguagesSpeak",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Terms_Time_Time",
                table: "Terms",
                column: "Time",
                principalTable: "Time",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OffreLanguagesComputer_ProgramingLanguage_ProgramingLanguageId",
                table: "OffreLanguagesComputer");

            migrationBuilder.DropForeignKey(
                name: "FK_OffreLanguagesSpeak_Language_LanguageId",
                table: "OffreLanguagesSpeak");

            migrationBuilder.DropForeignKey(
                name: "FK_Terms_Time_Time",
                table: "Terms");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "Time");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProgramingLanguage",
                table: "ProgramingLanguage");

            migrationBuilder.RenameTable(
                name: "ProgramingLanguage",
                newName: "ComputerLanguage");

            migrationBuilder.RenameColumn(
                name: "Valeur",
                table: "TimeLimit",
                newName: "TypeTime");

            migrationBuilder.RenameColumn(
                name: "TypeTaux",
                table: "TimeLimit",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Terms",
                newName: "TimeLimit");

            migrationBuilder.RenameIndex(
                name: "IX_Terms_Time",
                table: "Terms",
                newName: "IX_Terms_TimeLimit");

            migrationBuilder.RenameColumn(
                name: "LanguageId",
                table: "OffreLanguagesSpeak",
                newName: "SpeakId");

            migrationBuilder.RenameIndex(
                name: "IX_OffreLanguagesSpeak_LanguageId",
                table: "OffreLanguagesSpeak",
                newName: "IX_OffreLanguagesSpeak_SpeakId");

            migrationBuilder.RenameColumn(
                name: "ProgramingLanguageId",
                table: "OffreLanguagesComputer",
                newName: "ComputerLanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_OffreLanguagesComputer_ProgramingLanguageId",
                table: "OffreLanguagesComputer",
                newName: "IX_OffreLanguagesComputer_ComputerLanguageId");

            migrationBuilder.AddColumn<int>(
                name: "Montant",
                table: "SalaryPenalty",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Montant",
                table: "Salary",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComputerLanguage",
                table: "ComputerLanguage",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "LanguageSpeak",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageSpeak", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_OffreLanguagesComputer_ComputerLanguage_ComputerLanguageId",
                table: "OffreLanguagesComputer",
                column: "ComputerLanguageId",
                principalTable: "ComputerLanguage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OffreLanguagesSpeak_LanguageSpeak_SpeakId",
                table: "OffreLanguagesSpeak",
                column: "SpeakId",
                principalTable: "LanguageSpeak",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Terms_TimeLimit_TimeLimit",
                table: "Terms",
                column: "TimeLimit",
                principalTable: "TimeLimit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
