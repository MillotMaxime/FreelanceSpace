using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class updateSpeak : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OffreLanguagesSpeak_Speak_SpeakId",
                table: "OffreLanguagesSpeak");

            migrationBuilder.DropTable(
                name: "Speak");

            migrationBuilder.CreateTable(
                name: "LanguageSpeak",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Translate = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageSpeak", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_OffreLanguagesSpeak_LanguageSpeak_SpeakId",
                table: "OffreLanguagesSpeak",
                column: "SpeakId",
                principalTable: "LanguageSpeak",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OffreLanguagesSpeak_LanguageSpeak_SpeakId",
                table: "OffreLanguagesSpeak");

            migrationBuilder.DropTable(
                name: "LanguageSpeak");

            migrationBuilder.CreateTable(
                name: "Speak",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Translate = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speak", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_OffreLanguagesSpeak_Speak_SpeakId",
                table: "OffreLanguagesSpeak",
                column: "SpeakId",
                principalTable: "Speak",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
