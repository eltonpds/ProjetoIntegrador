using Microsoft.EntityFrameworkCore.Migrations;

namespace CarteiraVacinaDigital.Repository.Migrations
{
    public partial class Atualizandoentidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacients_Logs_LogId",
                table: "Pacients");

            migrationBuilder.DropForeignKey(
                name: "FK_Responsibles_Pacients_PacientId",
                table: "Responsibles");

            migrationBuilder.DropIndex(
                name: "IX_Responsibles_PacientId",
                table: "Responsibles");

            migrationBuilder.DropColumn(
                name: "PacientId",
                table: "Responsibles");

            migrationBuilder.AlterColumn<int>(
                name: "LogId",
                table: "Pacients",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ResponsibleId",
                table: "Pacients",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pacients_ResponsibleId",
                table: "Pacients",
                column: "ResponsibleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pacients_Logs_LogId",
                table: "Pacients",
                column: "LogId",
                principalTable: "Logs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacients_Responsibles_ResponsibleId",
                table: "Pacients",
                column: "ResponsibleId",
                principalTable: "Responsibles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacients_Logs_LogId",
                table: "Pacients");

            migrationBuilder.DropForeignKey(
                name: "FK_Pacients_Responsibles_ResponsibleId",
                table: "Pacients");

            migrationBuilder.DropIndex(
                name: "IX_Pacients_ResponsibleId",
                table: "Pacients");

            migrationBuilder.DropColumn(
                name: "ResponsibleId",
                table: "Pacients");

            migrationBuilder.AddColumn<int>(
                name: "PacientId",
                table: "Responsibles",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LogId",
                table: "Pacients",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Responsibles_PacientId",
                table: "Responsibles",
                column: "PacientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pacients_Logs_LogId",
                table: "Pacients",
                column: "LogId",
                principalTable: "Logs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Responsibles_Pacients_PacientId",
                table: "Responsibles",
                column: "PacientId",
                principalTable: "Pacients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
