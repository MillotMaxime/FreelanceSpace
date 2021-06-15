using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class modifSalaryAndPenalty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offre_Salary_Salaryid",
                table: "Offre");

            migrationBuilder.DropForeignKey(
                name: "FK_Salary_TimeLimit_TimeLimit",
                table: "Salary");

            migrationBuilder.DropForeignKey(
                name: "FK_SalaryPenalty_TimeLimit_TimeLimit",
                table: "SalaryPenalty");

            migrationBuilder.DropIndex(
                name: "IX_Salary_TimeLimit",
                table: "Salary");

            migrationBuilder.DropColumn(
                name: "TimeLimit",
                table: "Salary");

            migrationBuilder.RenameColumn(
                name: "TypeTaux",
                table: "Time",
                newName: "TypeTime");

            migrationBuilder.RenameColumn(
                name: "TimeLimit",
                table: "SalaryPenalty",
                newName: "TauxHorraireId");

            migrationBuilder.RenameIndex(
                name: "IX_SalaryPenalty_TimeLimit",
                table: "SalaryPenalty",
                newName: "IX_SalaryPenalty_TauxHorraireId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Salary",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Salaryid",
                table: "Offre",
                newName: "SalaryId");

            migrationBuilder.RenameIndex(
                name: "IX_Offre_Salaryid",
                table: "Offre",
                newName: "IX_Offre_SalaryId");

            migrationBuilder.AddColumn<int>(
                name: "TotalAmount",
                table: "Salary",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Offre_Salary_SalaryId",
                table: "Offre",
                column: "SalaryId",
                principalTable: "Salary",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalaryPenalty_TimeLimit_TauxHorraireId",
                table: "SalaryPenalty",
                column: "TauxHorraireId",
                principalTable: "TimeLimit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offre_Salary_SalaryId",
                table: "Offre");

            migrationBuilder.DropForeignKey(
                name: "FK_SalaryPenalty_TimeLimit_TauxHorraireId",
                table: "SalaryPenalty");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "Salary");

            migrationBuilder.RenameColumn(
                name: "TypeTime",
                table: "Time",
                newName: "TypeTaux");

            migrationBuilder.RenameColumn(
                name: "TauxHorraireId",
                table: "SalaryPenalty",
                newName: "TimeLimit");

            migrationBuilder.RenameIndex(
                name: "IX_SalaryPenalty_TauxHorraireId",
                table: "SalaryPenalty",
                newName: "IX_SalaryPenalty_TimeLimit");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Salary",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "SalaryId",
                table: "Offre",
                newName: "Salaryid");

            migrationBuilder.RenameIndex(
                name: "IX_Offre_SalaryId",
                table: "Offre",
                newName: "IX_Offre_Salaryid");

            migrationBuilder.AddColumn<int>(
                name: "TimeLimit",
                table: "Salary",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Salary_TimeLimit",
                table: "Salary",
                column: "TimeLimit");

            migrationBuilder.AddForeignKey(
                name: "FK_Offre_Salary_Salaryid",
                table: "Offre",
                column: "Salaryid",
                principalTable: "Salary",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Salary_TimeLimit_TimeLimit",
                table: "Salary",
                column: "TimeLimit",
                principalTable: "TimeLimit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalaryPenalty_TimeLimit_TimeLimit",
                table: "SalaryPenalty",
                column: "TimeLimit",
                principalTable: "TimeLimit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
