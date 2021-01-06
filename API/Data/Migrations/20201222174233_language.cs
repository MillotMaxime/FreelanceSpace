using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class language : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComputerLanguage",
                table: "Offre");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Offre");

            migrationBuilder.CreateTable(
                name: "Computer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Speak",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Translate = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speak", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OffreLanguagesComputer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OffreId = table.Column<int>(type: "INTEGER", nullable: true),
                    ComputerLanguageId = table.Column<int>(type: "INTEGER", nullable: true),
                    Favoris = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OffreLanguagesComputer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OffreLanguagesComputer_Computer_ComputerLanguageId",
                        column: x => x.ComputerLanguageId,
                        principalTable: "Computer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OffreLanguagesComputer_Offre_OffreId",
                        column: x => x.OffreId,
                        principalTable: "Offre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OffreLanguagesSpeak",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OffreId = table.Column<int>(type: "INTEGER", nullable: true),
                    SpeakId = table.Column<int>(type: "INTEGER", nullable: true),
                    Favoris = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OffreLanguagesSpeak", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OffreLanguagesSpeak_Offre_OffreId",
                        column: x => x.OffreId,
                        principalTable: "Offre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OffreLanguagesSpeak_Speak_SpeakId",
                        column: x => x.SpeakId,
                        principalTable: "Speak",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OffreLanguagesComputer_ComputerLanguageId",
                table: "OffreLanguagesComputer",
                column: "ComputerLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_OffreLanguagesComputer_OffreId",
                table: "OffreLanguagesComputer",
                column: "OffreId");

            migrationBuilder.CreateIndex(
                name: "IX_OffreLanguagesSpeak_OffreId",
                table: "OffreLanguagesSpeak",
                column: "OffreId");

            migrationBuilder.CreateIndex(
                name: "IX_OffreLanguagesSpeak_SpeakId",
                table: "OffreLanguagesSpeak",
                column: "SpeakId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OffreLanguagesComputer");

            migrationBuilder.DropTable(
                name: "OffreLanguagesSpeak");

            migrationBuilder.DropTable(
                name: "Computer");

            migrationBuilder.DropTable(
                name: "Speak");

            migrationBuilder.AddColumn<string>(
                name: "ComputerLanguage",
                table: "Offre",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Offre",
                type: "TEXT",
                nullable: true);
        }
    }
}
