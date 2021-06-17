using Microsoft.EntityFrameworkCore.Migrations;

namespace CarteiraVacinaDigital.Repository.Migrations
{
    public partial class EdicaoTabelaPaciente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Pacients",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cep",
                table: "Pacients",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Pacients",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "Pacients",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Pacients");

            migrationBuilder.DropColumn(
                name: "Cep",
                table: "Pacients");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Pacients");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Pacients");
        }
    }
}
