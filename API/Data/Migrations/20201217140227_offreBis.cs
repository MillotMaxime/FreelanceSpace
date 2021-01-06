using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class offreBis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimeLimit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<int>(type: "INTEGER", nullable: false),
                    TypeTime = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeLimit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Salary",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    montant = table.Column<int>(type: "INTEGER", nullable: false),
                    recurenceId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salary", x => x.id);
                    table.ForeignKey(
                        name: "FK_Salary_TimeLimit_recurenceId",
                        column: x => x.recurenceId,
                        principalTable: "TimeLimit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalaryPenalty",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    montant = table.Column<int>(type: "INTEGER", nullable: false),
                    recurenceId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryPenalty", x => x.id);
                    table.ForeignKey(
                        name: "FK_SalaryPenalty_TimeLimit_recurenceId",
                        column: x => x.recurenceId,
                        principalTable: "TimeLimit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Terms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Begin = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndId = table.Column<int>(type: "INTEGER", nullable: true),
                    TimeSpent = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Terms_TimeLimit_EndId",
                        column: x => x.EndId,
                        principalTable: "TimeLimit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Offre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatorId = table.Column<int>(type: "INTEGER", nullable: true),
                    Create = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Salaryid = table.Column<int>(type: "INTEGER", nullable: true),
                    Penaltyid = table.Column<int>(type: "INTEGER", nullable: true),
                    TermsId = table.Column<int>(type: "INTEGER", nullable: true),
                    BusinessValidation = table.Column<bool>(type: "INTEGER", nullable: false),
                    FreelanceValidation = table.Column<bool>(type: "INTEGER", nullable: false),
                    ComputerLanguage = table.Column<string>(type: "TEXT", nullable: true),
                    Language = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offre_Salary_Salaryid",
                        column: x => x.Salaryid,
                        principalTable: "Salary",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Offre_SalaryPenalty_Penaltyid",
                        column: x => x.Penaltyid,
                        principalTable: "SalaryPenalty",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Offre_Terms_TermsId",
                        column: x => x.TermsId,
                        principalTable: "Terms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Offre_Users_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Offre_CreatorId",
                table: "Offre",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Offre_Penaltyid",
                table: "Offre",
                column: "Penaltyid");

            migrationBuilder.CreateIndex(
                name: "IX_Offre_Salaryid",
                table: "Offre",
                column: "Salaryid");

            migrationBuilder.CreateIndex(
                name: "IX_Offre_TermsId",
                table: "Offre",
                column: "TermsId");

            migrationBuilder.CreateIndex(
                name: "IX_Salary_recurenceId",
                table: "Salary",
                column: "recurenceId");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryPenalty_recurenceId",
                table: "SalaryPenalty",
                column: "recurenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Terms_EndId",
                table: "Terms",
                column: "EndId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offre");

            migrationBuilder.DropTable(
                name: "Salary");

            migrationBuilder.DropTable(
                name: "SalaryPenalty");

            migrationBuilder.DropTable(
                name: "Terms");

            migrationBuilder.DropTable(
                name: "TimeLimit");
        }
    }
}
