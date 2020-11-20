using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Storage.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Complicities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complicities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CriminalCaseAuthorities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriminalCaseAuthorities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CriminalCaseDecisions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Decision = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriminalCaseDecisions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CriminalStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriminalStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeePositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeRanks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rank = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeRanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InspectionMaterialDecisions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Decision = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspectionMaterialDecisions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Qualifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartWorkDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndWorkDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartWorkSODate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReasonOfEndWork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RankId = table.Column<int>(type: "int", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_EmployeePositions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "EmployeePositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_EmployeeRanks_RankId",
                        column: x => x.RankId,
                        principalTable: "EmployeeRanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CriminalCases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InitiationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QualificationId = table.Column<int>(type: "int", nullable: false),
                    CriminalCaseAuthorityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriminalCases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CriminalCases_CriminalCaseAuthorities_CriminalCaseAuthorityId",
                        column: x => x.CriminalCaseAuthorityId,
                        principalTable: "CriminalCaseAuthorities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CriminalCases_Qualifications_QualificationId",
                        column: x => x.QualificationId,
                        principalTable: "Qualifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CriminalStatusHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChangeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QualificationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriminalStatusHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CriminalStatusHistories_Qualifications_QualificationId",
                        column: x => x.QualificationId,
                        principalTable: "Qualifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InspectionMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InspectionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QualificationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspectionMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InspectionMaterials_Qualifications_QualificationId",
                        column: x => x.QualificationId,
                        principalTable: "Qualifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrimeReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistratinAuthority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    QualificationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrimeReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CrimeReports_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CrimeReports_Qualifications_QualificationId",
                        column: x => x.QualificationId,
                        principalTable: "Qualifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreventiveMeasureDecisions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DecisionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreventiveMeasureDecisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreventiveMeasureDecisions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CriminalCaseMovements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DecisionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    DecisionId = table.Column<int>(type: "int", nullable: false),
                    CriminalCaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriminalCaseMovements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CriminalCaseMovements_CriminalCaseDecisions_DecisionId",
                        column: x => x.DecisionId,
                        principalTable: "CriminalCaseDecisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CriminalCaseMovements_CriminalCases_CriminalCaseId",
                        column: x => x.CriminalCaseId,
                        principalTable: "CriminalCases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CriminalCaseMovements_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criminals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Citizenship = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaceOfRegistration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActualResidence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyComposition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Education = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MilitaryAccounting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasCriminalRecords = table.Column<bool>(type: "bit", nullable: false),
                    CriminalRecordsInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CriminalCaseId = table.Column<int>(type: "int", nullable: false),
                    CriminalStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criminals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criminals_CriminalCases_CriminalCaseId",
                        column: x => x.CriminalCaseId,
                        principalTable: "CriminalCases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Criminals_CriminalStatuses_CriminalStatusId",
                        column: x => x.CriminalStatusId,
                        principalTable: "CriminalStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvestigationPeriodExtensions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DecisionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CriminalCaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvestigationPeriodExtensions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvestigationPeriodExtensions_CriminalCases_CriminalCaseId",
                        column: x => x.CriminalCaseId,
                        principalTable: "CriminalCases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InspectionMaterialMovements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DecisionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    InspectionMaterialId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspectionMaterialMovements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InspectionMaterialMovements_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InspectionMaterialMovements_InspectionMaterials_InspectionMaterialId",
                        column: x => x.InspectionMaterialId,
                        principalTable: "InspectionMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InspectionPeriodExtensions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DecisionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InspectionMaterialId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspectionPeriodExtensions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InspectionPeriodExtensions_InspectionMaterials_InspectionMaterialId",
                        column: x => x.InspectionMaterialId,
                        principalTable: "InspectionMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreventiveMeasures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Measure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreventiveMeasureDecisionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreventiveMeasures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreventiveMeasures_PreventiveMeasureDecisions_PreventiveMeasureDecisionId",
                        column: x => x.PreventiveMeasureDecisionId,
                        principalTable: "PreventiveMeasureDecisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CrimeReports_EmployeeId",
                table: "CrimeReports",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CrimeReports_QualificationId",
                table: "CrimeReports",
                column: "QualificationId");

            migrationBuilder.CreateIndex(
                name: "IX_CriminalCaseMovements_CriminalCaseId",
                table: "CriminalCaseMovements",
                column: "CriminalCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_CriminalCaseMovements_DecisionId",
                table: "CriminalCaseMovements",
                column: "DecisionId");

            migrationBuilder.CreateIndex(
                name: "IX_CriminalCaseMovements_EmployeeId",
                table: "CriminalCaseMovements",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CriminalCases_CriminalCaseAuthorityId",
                table: "CriminalCases",
                column: "CriminalCaseAuthorityId");

            migrationBuilder.CreateIndex(
                name: "IX_CriminalCases_QualificationId",
                table: "CriminalCases",
                column: "QualificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Criminals_CriminalCaseId",
                table: "Criminals",
                column: "CriminalCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Criminals_CriminalStatusId",
                table: "Criminals",
                column: "CriminalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CriminalStatusHistories_QualificationId",
                table: "CriminalStatusHistories",
                column: "QualificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PositionId",
                table: "Employees",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RankId",
                table: "Employees",
                column: "RankId");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionMaterialMovements_EmployeeId",
                table: "InspectionMaterialMovements",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionMaterialMovements_InspectionMaterialId",
                table: "InspectionMaterialMovements",
                column: "InspectionMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionMaterials_QualificationId",
                table: "InspectionMaterials",
                column: "QualificationId");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionPeriodExtensions_InspectionMaterialId",
                table: "InspectionPeriodExtensions",
                column: "InspectionMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_InvestigationPeriodExtensions_CriminalCaseId",
                table: "InvestigationPeriodExtensions",
                column: "CriminalCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_PreventiveMeasureDecisions_EmployeeId",
                table: "PreventiveMeasureDecisions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PreventiveMeasures_PreventiveMeasureDecisionId",
                table: "PreventiveMeasures",
                column: "PreventiveMeasureDecisionId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Complicities");

            migrationBuilder.DropTable(
                name: "CrimeReports");

            migrationBuilder.DropTable(
                name: "CriminalCaseMovements");

            migrationBuilder.DropTable(
                name: "Criminals");

            migrationBuilder.DropTable(
                name: "CriminalStatusHistories");

            migrationBuilder.DropTable(
                name: "InspectionMaterialDecisions");

            migrationBuilder.DropTable(
                name: "InspectionMaterialMovements");

            migrationBuilder.DropTable(
                name: "InspectionPeriodExtensions");

            migrationBuilder.DropTable(
                name: "InvestigationPeriodExtensions");

            migrationBuilder.DropTable(
                name: "PreventiveMeasures");

            migrationBuilder.DropTable(
                name: "CriminalCaseDecisions");

            migrationBuilder.DropTable(
                name: "CriminalStatuses");

            migrationBuilder.DropTable(
                name: "InspectionMaterials");

            migrationBuilder.DropTable(
                name: "CriminalCases");

            migrationBuilder.DropTable(
                name: "PreventiveMeasureDecisions");

            migrationBuilder.DropTable(
                name: "CriminalCaseAuthorities");

            migrationBuilder.DropTable(
                name: "Qualifications");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "EmployeePositions");

            migrationBuilder.DropTable(
                name: "EmployeeRanks");
        }
    }
}
