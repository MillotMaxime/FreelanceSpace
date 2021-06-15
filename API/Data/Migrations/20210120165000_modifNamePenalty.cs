using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class modifNamePenalty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offre_SalaryPenalty_Penaltyid",
                table: "Offre");

            migrationBuilder.DropForeignKey(
                name: "FK_SalaryPenalty_TimeLimit_TauxHorraireId",
                table: "SalaryPenalty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalaryPenalty",
                table: "SalaryPenalty");

            migrationBuilder.RenameTable(
                name: "SalaryPenalty",
                newName: "Penalty");

            migrationBuilder.RenameIndex(
                name: "IX_SalaryPenalty_TauxHorraireId",
                table: "Penalty",
                newName: "IX_Penalty_TauxHorraireId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Penalty",
                table: "Penalty",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Offre_Penalty_Penaltyid",
                table: "Offre",
                column: "Penaltyid",
                principalTable: "Penalty",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Penalty_TimeLimit_TauxHorraireId",
                table: "Penalty",
                column: "TauxHorraireId",
                principalTable: "TimeLimit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offre_Penalty_Penaltyid",
                table: "Offre");

            migrationBuilder.DropForeignKey(
                name: "FK_Penalty_TimeLimit_TauxHorraireId",
                table: "Penalty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Penalty",
                table: "Penalty");

            migrationBuilder.RenameTable(
                name: "Penalty",
                newName: "SalaryPenalty");

            migrationBuilder.RenameIndex(
                name: "IX_Penalty_TauxHorraireId",
                table: "SalaryPenalty",
                newName: "IX_SalaryPenalty_TauxHorraireId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalaryPenalty",
                table: "SalaryPenalty",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Offre_SalaryPenalty_Penaltyid",
                table: "Offre",
                column: "Penaltyid",
                principalTable: "SalaryPenalty",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalaryPenalty_TimeLimit_TauxHorraireId",
                table: "SalaryPenalty",
                column: "TauxHorraireId",
                principalTable: "TimeLimit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
