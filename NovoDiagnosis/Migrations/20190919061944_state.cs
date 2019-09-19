using Microsoft.EntityFrameworkCore.Migrations;

namespace NovoDiagnosis.Migrations
{
    public partial class state : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiagnosisDetails_States_StateId",
                table: "DiagnosisDetails");

            migrationBuilder.DropIndex(
                name: "IX_DiagnosisDetails_StateId",
                table: "DiagnosisDetails");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "DiagnosisDetails");

            migrationBuilder.AlterColumn<string>(
                name: "AppointmentTime",
                table: "DiagnosisDetails",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "AppointmentDate",
                table: "DiagnosisDetails",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "DiagnosisDetails",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "DiagnosisDetails");

            migrationBuilder.AlterColumn<string>(
                name: "AppointmentTime",
                table: "DiagnosisDetails",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AppointmentDate",
                table: "DiagnosisDetails",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StateId",
                table: "DiagnosisDetails",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosisDetails_StateId",
                table: "DiagnosisDetails",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_DiagnosisDetails_States_StateId",
                table: "DiagnosisDetails",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
