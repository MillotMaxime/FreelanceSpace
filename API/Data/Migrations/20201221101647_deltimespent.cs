using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class deltimespent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salary_TimeLimit_recurenceId",
                table: "Salary");

            migrationBuilder.DropForeignKey(
                name: "FK_SalaryPenalty_TimeLimit_recurenceId",
                table: "SalaryPenalty");

            migrationBuilder.DropColumn(
                name: "TimeSpent",
                table: "Terms");

            migrationBuilder.RenameColumn(
                name: "recurenceId",
                table: "SalaryPenalty",
                newName: "RecurenceId");

            migrationBuilder.RenameColumn(
                name: "montant",
                table: "SalaryPenalty",
                newName: "Montant");

            migrationBuilder.RenameIndex(
                name: "IX_SalaryPenalty_recurenceId",
                table: "SalaryPenalty",
                newName: "IX_SalaryPenalty_RecurenceId");

            migrationBuilder.RenameColumn(
                name: "recurenceId",
                table: "Salary",
                newName: "RecurenceId");

            migrationBuilder.RenameColumn(
                name: "montant",
                table: "Salary",
                newName: "Montant");

            migrationBuilder.RenameIndex(
                name: "IX_Salary_recurenceId",
                table: "Salary",
                newName: "IX_Salary_RecurenceId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Begin",
                table: "Terms",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salary_TimeLimit_RecurenceId",
                table: "Salary");

            migrationBuilder.DropForeignKey(
                name: "FK_SalaryPenalty_TimeLimit_RecurenceId",
                table: "SalaryPenalty");

            migrationBuilder.RenameColumn(
                name: "RecurenceId",
                table: "SalaryPenalty",
                newName: "recurenceId");

            migrationBuilder.RenameColumn(
                name: "Montant",
                table: "SalaryPenalty",
                newName: "montant");

            migrationBuilder.RenameIndex(
                name: "IX_SalaryPenalty_RecurenceId",
                table: "SalaryPenalty",
                newName: "IX_SalaryPenalty_recurenceId");

            migrationBuilder.RenameColumn(
                name: "RecurenceId",
                table: "Salary",
                newName: "recurenceId");

            migrationBuilder.RenameColumn(
                name: "Montant",
                table: "Salary",
                newName: "montant");

            migrationBuilder.RenameIndex(
                name: "IX_Salary_RecurenceId",
                table: "Salary",
                newName: "IX_Salary_recurenceId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Begin",
                table: "Terms",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeSpent",
                table: "Terms",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Salary_TimeLimit_recurenceId",
                table: "Salary",
                column: "recurenceId",
                principalTable: "TimeLimit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalaryPenalty_TimeLimit_recurenceId",
                table: "SalaryPenalty",
                column: "recurenceId",
                principalTable: "TimeLimit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
