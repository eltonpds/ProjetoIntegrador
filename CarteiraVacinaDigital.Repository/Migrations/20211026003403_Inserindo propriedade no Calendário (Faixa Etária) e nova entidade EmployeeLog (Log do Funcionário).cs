using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarteiraVacinaDigital.Repository.Migrations
{
    public partial class InserindopropriedadenoCalendárioFaixaEtáriaenovaentidadeEmployeeLogLogdoFuncionário : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    ChildrenID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsibles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Cpf = table.Column<string>(nullable: false),
                    Coren = table.Column<string>(nullable: false),
                    Adress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<int>(nullable: false),
                    Cep = table.Column<string>(nullable: true),
                    Office = table.Column<int>(nullable: false),
                    LogId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Logs_LogId",
                        column: x => x.LogId,
                        principalTable: "Logs",
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
                name: "Pacients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    CartaoSus = table.Column<string>(nullable: true),
                    MotherName = table.Column<string>(nullable: true),
                    FatherName = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<int>(nullable: false),
                    Cep = table.Column<string>(nullable: true),
                    LogId = table.Column<int>(nullable: true),
                    ResponsibleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacients_Logs_LogId",
                        column: x => x.LogId,
                        principalTable: "Logs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pacients_Responsibles_ResponsibleId",
                        column: x => x.ResponsibleId,
                        principalTable: "Responsibles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmployeeID = table.Column<int>(nullable: false),
                    Information = table.Column<string>(nullable: true),
                    Action = table.Column<int>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeLogs_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vaccines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FactoryName = table.Column<string>(nullable: true),
                    VaccineName = table.Column<string>(nullable: true),
                    ManufacturingDate = table.Column<DateTime>(nullable: false),
                    Validate = table.Column<DateTime>(nullable: false),
                    Lote = table.Column<string>(nullable: true),
                    LogsId = table.Column<int>(nullable: true),
                    CalenderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vaccines_Logs_LogsId",
                        column: x => x.LogsId,
                        principalTable: "Logs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Calenders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Information = table.Column<string>(nullable: false),
                    AgeGroup = table.Column<string>(nullable: false),
                    VaccineId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calenders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calenders_Vaccines_VaccineId",
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
                    CampaignName = table.Column<string>(nullable: false),
                    Information = table.Column<string>(nullable: false),
                    VaccineId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaign", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Campaign_Vaccines_VaccineId",
                        column: x => x.VaccineId,
                        principalTable: "Vaccines",
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
                name: "IX_Calenders_VaccineId",
                table: "Calenders",
                column: "VaccineId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Campaign_VaccineId",
                table: "Campaign",
                column: "VaccineId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLogs_EmployeeID",
                table: "EmployeeLogs",
                column: "EmployeeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_LogId",
                table: "Employees",
                column: "LogId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthPosts_LogsID",
                table: "HealthPosts",
                column: "LogsID");

            migrationBuilder.CreateIndex(
                name: "IX_Pacients_LogId",
                table: "Pacients",
                column: "LogId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacients_ResponsibleId",
                table: "Pacients",
                column: "ResponsibleId");

            migrationBuilder.CreateIndex(
                name: "IX_VaccineHealthPosts_HealthPostID",
                table: "VaccineHealthPosts",
                column: "HealthPostID");

            migrationBuilder.CreateIndex(
                name: "IX_Vaccines_CalenderId",
                table: "Vaccines",
                column: "CalenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Vaccines_LogsId",
                table: "Vaccines",
                column: "LogsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vaccines_Calenders_CalenderId",
                table: "Vaccines",
                column: "CalenderId",
                principalTable: "Calenders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calenders_Vaccines_VaccineId",
                table: "Calenders");

            migrationBuilder.DropTable(
                name: "Campaign");

            migrationBuilder.DropTable(
                name: "EmployeeLogs");

            migrationBuilder.DropTable(
                name: "Pacients");

            migrationBuilder.DropTable(
                name: "VaccineHealthPosts");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Responsibles");

            migrationBuilder.DropTable(
                name: "HealthPosts");

            migrationBuilder.DropTable(
                name: "Vaccines");

            migrationBuilder.DropTable(
                name: "Calenders");

            migrationBuilder.DropTable(
                name: "Logs");
        }
    }
}
