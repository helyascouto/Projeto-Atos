using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestãoClinica.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Telephone = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameExams = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NameCompany = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CNPJ = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_Address_Id",
                        column: x => x.Id,
                        principalTable: "Address",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CRM = table.Column<long>(type: "bigint", nullable: true),
                    CPF = table.Column<long>(type: "bigint", nullable: false),
                    FistName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DateBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctor_Address_Id",
                        column: x => x.Id,
                        principalTable: "Address",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HealthPlan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthPlan_Company_Id",
                        column: x => x.Id,
                        principalTable: "Company",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CPF = table.Column<long>(type: "bigint", nullable: false),
                    FistName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DateBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdHealthPlan = table.Column<int>(type: "int", nullable: false),
                    IdCompany = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Address_Id",
                        column: x => x.Id,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Patients_Company_IdCompany",
                        column: x => x.IdCompany,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patients_HealthPlan_IdHealthPlan",
                        column: x => x.IdHealthPlan,
                        principalTable: "HealthPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PeriodicConsultation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPatient = table.Column<int>(type: "int", nullable: false),
                    IdDoctor = table.Column<int>(type: "int", nullable: false),
                    IdCompany = table.Column<int>(type: "int", nullable: false),
                    IdExams = table.Column<int>(type: "int", nullable: false),
                    DateQuery = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodicConsultation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PeriodicConsultation_Company_IdCompany",
                        column: x => x.IdCompany,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeriodicConsultation_Doctor_IdDoctor",
                        column: x => x.IdDoctor,
                        principalTable: "Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeriodicConsultation_Exams_IdExams",
                        column: x => x.IdExams,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeriodicConsultation_Patients_IdPatient",
                        column: x => x.IdPatient,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ListExams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: true),
                    ExamsId = table.Column<int>(type: "int", nullable: true),
                    PeriodicConsultationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListExams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListExams_Exams_ExamsId",
                        column: x => x.ExamsId,
                        principalTable: "Exams",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ListExams_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ListExams_PeriodicConsultation_PeriodicConsultationId",
                        column: x => x.PeriodicConsultationId,
                        principalTable: "PeriodicConsultation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListExams_ExamsId",
                table: "ListExams",
                column: "ExamsId");

            migrationBuilder.CreateIndex(
                name: "IX_ListExams_PatientId",
                table: "ListExams",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_ListExams_PeriodicConsultationId",
                table: "ListExams",
                column: "PeriodicConsultationId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_IdCompany",
                table: "Patients",
                column: "IdCompany");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_IdHealthPlan",
                table: "Patients",
                column: "IdHealthPlan");

            migrationBuilder.CreateIndex(
                name: "IX_PeriodicConsultation_IdCompany",
                table: "PeriodicConsultation",
                column: "IdCompany");

            migrationBuilder.CreateIndex(
                name: "IX_PeriodicConsultation_IdDoctor",
                table: "PeriodicConsultation",
                column: "IdDoctor");

            migrationBuilder.CreateIndex(
                name: "IX_PeriodicConsultation_IdExams",
                table: "PeriodicConsultation",
                column: "IdExams");

            migrationBuilder.CreateIndex(
                name: "IX_PeriodicConsultation_IdPatient",
                table: "PeriodicConsultation",
                column: "IdPatient");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListExams");

            migrationBuilder.DropTable(
                name: "PeriodicConsultation");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "HealthPlan");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
