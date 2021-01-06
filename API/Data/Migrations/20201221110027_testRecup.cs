using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class testRecup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offre_Users_CreatorId",
                table: "Offre");

            migrationBuilder.DropForeignKey(
                name: "FK_Salary_TimeLimit_RecurenceId",
                table: "Salary");

            migrationBuilder.DropForeignKey(
                name: "FK_SalaryPenalty_TimeLimit_RecurenceId",
                table: "SalaryPenalty");

            migrationBuilder.DropForeignKey(
                name: "FK_Terms_TimeLimit_EndId",
                table: "Terms");

            migrationBuilder.RenameColumn(
                name: "EndId",
                table: "Terms",
                newName: "TimeLimit");

            migrationBuilder.RenameIndex(
                name: "IX_Terms_EndId",
                table: "Terms",
                newName: "IX_Terms_TimeLimit");

            migrationBuilder.RenameColumn(
                name: "RecurenceId",
                table: "SalaryPenalty",
                newName: "TimeLimit");

            migrationBuilder.RenameIndex(
                name: "IX_SalaryPenalty_RecurenceId",
                table: "SalaryPenalty",
                newName: "IX_SalaryPenalty_TimeLimit");

            migrationBuilder.RenameColumn(
                name: "RecurenceId",
                table: "Salary",
                newName: "TimeLimit");

            migrationBuilder.RenameIndex(
                name: "IX_Salary_RecurenceId",
                table: "Salary",
                newName: "IX_Salary_TimeLimit");

            migrationBuilder.RenameColumn(
                name: "CreatorId",
                table: "Offre",
                newName: "Buisness");

            migrationBuilder.RenameIndex(
                name: "IX_Offre_CreatorId",
                table: "Offre",
                newName: "IX_Offre_Buisness");

            migrationBuilder.AddForeignKey(
                name: "FK_Offre_Users_Buisness",
                table: "Offre",
                column: "Buisness",
                principalTable: "Users",
                principalColumn: "Id",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Terms_TimeLimit_TimeLimit",
                table: "Terms",
                column: "TimeLimit",
                principalTable: "TimeLimit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offre_Users_Buisness",
                table: "Offre");

            migrationBuilder.DropForeignKey(
                name: "FK_Salary_TimeLimit_TimeLimit",
                table: "Salary");

            migrationBuilder.DropForeignKey(
                name: "FK_SalaryPenalty_TimeLimit_TimeLimit",
                table: "SalaryPenalty");

            migrationBuilder.DropForeignKey(
                name: "FK_Terms_TimeLimit_TimeLimit",
                table: "Terms");

            migrationBuilder.RenameColumn(
                name: "TimeLimit",
                table: "Terms",
                newName: "EndId");

            migrationBuilder.RenameIndex(
                name: "IX_Terms_TimeLimit",
                table: "Terms",
                newName: "IX_Terms_EndId");

            migrationBuilder.RenameColumn(
                name: "TimeLimit",
                table: "SalaryPenalty",
                newName: "RecurenceId");

            migrationBuilder.RenameIndex(
                name: "IX_SalaryPenalty_TimeLimit",
                table: "SalaryPenalty",
                newName: "IX_SalaryPenalty_RecurenceId");

            migrationBuilder.RenameColumn(
                name: "TimeLimit",
                table: "Salary",
                newName: "RecurenceId");

            migrationBuilder.RenameIndex(
                name: "IX_Salary_TimeLimit",
                table: "Salary",
                newName: "IX_Salary_RecurenceId");

            migrationBuilder.RenameColumn(
                name: "Buisness",
                table: "Offre",
                newName: "CreatorId");

            migrationBuilder.RenameIndex(
                name: "IX_Offre_Buisness",
                table: "Offre",
                newName: "IX_Offre_CreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Offre_Users_CreatorId",
                table: "Offre",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Salary_TimeLimit_RecurenceId",
                table: "Salary",
                column: "RecurenceId",
                principalTable: "TimeLimit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalaryPenalty_TimeLimit_RecurenceId",
                table: "SalaryPenalty",
                column: "RecurenceId",
                principalTable: "TimeLimit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Terms_TimeLimit_EndId",
                table: "Terms",
                column: "EndId",
                principalTable: "TimeLimit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
