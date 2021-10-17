using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarteiraVacinaDigital.Repository.Migrations
{
    public partial class MapeadoasentidadesCampanhaCalendarioPostoSaudeLogeResponsavel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ScheduleId",
                table: "Pacients",
                newName: "LogId");

            migrationBuilder.AddColumn<int>(
                name: "CampaignId",
                table: "Vaccines",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LogId",
                table: "Vaccines",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LogId",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Calender",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Information = table.Column<string>(nullable: true),
                    VaccineId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calender", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calender_Vaccines_VaccineId",
                        column: x => x.VaccineId,
                        principalTable: "Vaccines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Campaign",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CampaignName = table.Column<string>(nullable: true),
                    Information = table.Column<string>(nullable: true),
                    VaccineId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaign", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPacient = table.Column<int>(nullable: false),
                    IdVaccine = table.Column<int>(nullable: false),
                    IdEmployee = table.Column<int>(nullable: false),
                    IdHealthPost = table.Column<int>(nullable: false),
                    VaccineDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Responsibles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ResponsibleID = table.Column<int>(nullable: false),
                    ChildrenID = table.Column<int>(nullable: false),
                    PacientId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsibles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Responsibles_Pacients_PacientId",
                        column: x => x.PacientId,
                        principalTable: "Pacients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HealthPosts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HealthUnit = table.Column<string>(nullable: false),
                    SanitaryDistrict = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    LogsID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthPosts_Logs_LogsID",
                        column: x => x.LogsID,
                        principalTable: "Logs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VaccineHealthPosts",
                columns: table => new
                {
                    VaccineID = table.Column<int>(nullable: false),
                    HealthPostID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccineHealthPosts", x => new { x.VaccineID, x.HealthPostID });
                    table.ForeignKey(
                        name: "FK_VaccineHealthPosts_HealthPosts_HealthPostID",
                        column: x => x.HealthPostID,
                        principalTable: "HealthPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VaccineHealthPosts_Vaccines_VaccineID",
                        column: x => x.VaccineID,
                        principalTable: "Vaccines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vaccines_CampaignId",
                table: "Vaccines",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_Vaccines_LogId",
                table: "Vaccines",
                column: "LogId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacients_LogId",
                table: "Pacients",
                column: "LogId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_LogId",
                table: "Employees",
                column: "LogId");

            migrationBuilder.CreateIndex(
                name: "IX_Calender_VaccineId",
                table: "Calender",
                column: "VaccineId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthPosts_LogsID",
                table: "HealthPosts",
                column: "LogsID");

            migrationBuilder.CreateIndex(
                name: "IX_Responsibles_PacientId",
                table: "Responsibles",
                column: "PacientId");

            migrationBuilder.CreateIndex(
                name: "IX_VaccineHealthPosts_HealthPostID",
                table: "VaccineHealthPosts",
                column: "HealthPostID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Logs_LogId",
                table: "Employees",
                column: "LogId",
                principalTable: "Logs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacients_Logs_LogId",
                table: "Pacients",
                column: "LogId",
                principalTable: "Logs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vaccines_Campaign_CampaignId",
                table: "Vaccines",
                column: "CampaignId",
                principalTable: "Campaign",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vaccines_Logs_LogId",
                table: "Vaccines",
                column: "LogId",
                principalTable: "Logs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Logs_LogId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Pacients_Logs_LogId",
                table: "Pacients");

            migrationBuilder.DropForeignKey(
                name: "FK_Vaccines_Campaign_CampaignId",
                table: "Vaccines");

            migrationBuilder.DropForeignKey(
                name: "FK_Vaccines_Logs_LogId",
                table: "Vaccines");

            migrationBuilder.DropTable(
                name: "Calender");

            migrationBuilder.DropTable(
                name: "Campaign");

            migrationBuilder.DropTable(
                name: "Responsibles");

            migrationBuilder.DropTable(
                name: "VaccineHealthPosts");

            migrationBuilder.DropTable(
                name: "HealthPosts");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_Vaccines_CampaignId",
                table: "Vaccines");

            migrationBuilder.DropIndex(
                name: "IX_Vaccines_LogId",
                table: "Vaccines");

            migrationBuilder.DropIndex(
                name: "IX_Pacients_LogId",
                table: "Pacients");

            migrationBuilder.DropIndex(
                name: "IX_Employees_LogId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CampaignId",
                table: "Vaccines");

            migrationBuilder.DropColumn(
                name: "LogId",
                table: "Vaccines");

            migrationBuilder.DropColumn(
                name: "LogId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "LogId",
                table: "Pacients",
                newName: "ScheduleId");
        }
    }
}
