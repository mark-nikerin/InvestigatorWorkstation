using Microsoft.EntityFrameworkCore.Migrations;

namespace Storage.Migrations
{
    public partial class SetupOnDeleteBehavior : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CrimeReports_Employees_EmployeeId",
                table: "CrimeReports");

            migrationBuilder.DropForeignKey(
                name: "FK_CrimeReports_Qualifications_QualificationId",
                table: "CrimeReports");

            migrationBuilder.DropForeignKey(
                name: "FK_CriminalCaseMovements_CriminalCaseDecisions_DecisionId",
                table: "CriminalCaseMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_CriminalCaseMovements_CriminalCases_CriminalCaseId",
                table: "CriminalCaseMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_CriminalCaseMovements_Employees_EmployeeId",
                table: "CriminalCaseMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_CriminalCases_CriminalCaseAuthorities_CriminalCaseAuthorityId",
                table: "CriminalCases");

            migrationBuilder.DropForeignKey(
                name: "FK_CriminalCases_Qualifications_QualificationId",
                table: "CriminalCases");

            migrationBuilder.DropForeignKey(
                name: "FK_Criminals_CriminalStatuses_CriminalStatusId",
                table: "Criminals");

            migrationBuilder.DropForeignKey(
                name: "FK_CriminalStatusHistories_ComplicityTypes_ComplicityTypeId",
                table: "CriminalStatusHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_CriminalStatusHistories_Criminals_CriminalId",
                table: "CriminalStatusHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_CriminalStatusHistories_CriminalStatuses_CriminalStatusId",
                table: "CriminalStatusHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_CriminalStatusHistories_Qualifications_QualificationId",
                table: "CriminalStatusHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePositionHistories_Employees_EmployeeId",
                table: "EmployeePositionHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeRankHistories_Employees_EmployeeId",
                table: "EmployeeRankHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Positions_PositionId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Ranks_RankId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_InspectionMaterialMovements_Employees_EmployeeId",
                table: "InspectionMaterialMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_InspectionMaterialMovements_InspectionMaterialDecisions_InspectionMaterialDecisionId",
                table: "InspectionMaterialMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_InspectionMaterials_Qualifications_QualificationId",
                table: "InspectionMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_PreventiveMeasureDecisions_Employees_EmployeeId",
                table: "PreventiveMeasureDecisions");

            migrationBuilder.DropForeignKey(
                name: "FK_PreventiveMeasureDecisions_PreventiveMeasures_PreventiveMeasureId",
                table: "PreventiveMeasureDecisions");

            migrationBuilder.AlterColumn<int>(
                name: "PreventiveMeasureId",
                table: "PreventiveMeasureDecisions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "PreventiveMeasureDecisions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "QualificationId",
                table: "InspectionMaterials",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "InspectionMaterialDecisionId",
                table: "InspectionMaterialMovements",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "InspectionMaterialMovements",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RankId",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PositionId",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "QualificationId",
                table: "CriminalStatusHistories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CriminalStatusId",
                table: "CriminalStatusHistories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ComplicityTypeId",
                table: "CriminalStatusHistories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CriminalStatusId",
                table: "Criminals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "QualificationId",
                table: "CriminalCases",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CriminalCaseAuthorityId",
                table: "CriminalCases",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "CriminalCaseMovements",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DecisionId",
                table: "CriminalCaseMovements",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "QualificationId",
                table: "CrimeReports",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "CrimeReports",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CrimeReports_Employees_EmployeeId",
                table: "CrimeReports",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_CrimeReports_Qualifications_QualificationId",
                table: "CrimeReports",
                column: "QualificationId",
                principalTable: "Qualifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_CriminalCaseMovements_CriminalCaseDecisions_DecisionId",
                table: "CriminalCaseMovements",
                column: "DecisionId",
                principalTable: "CriminalCaseDecisions",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_CriminalCaseMovements_CriminalCases_CriminalCaseId",
                table: "CriminalCaseMovements",
                column: "CriminalCaseId",
                principalTable: "CriminalCases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CriminalCaseMovements_Employees_EmployeeId",
                table: "CriminalCaseMovements",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_CriminalCases_CriminalCaseAuthorities_CriminalCaseAuthorityId",
                table: "CriminalCases",
                column: "CriminalCaseAuthorityId",
                principalTable: "CriminalCaseAuthorities",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_CriminalCases_Qualifications_QualificationId",
                table: "CriminalCases",
                column: "QualificationId",
                principalTable: "Qualifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Criminals_CriminalStatuses_CriminalStatusId",
                table: "Criminals",
                column: "CriminalStatusId",
                principalTable: "CriminalStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_CriminalStatusHistories_ComplicityTypes_ComplicityTypeId",
                table: "CriminalStatusHistories",
                column: "ComplicityTypeId",
                principalTable: "ComplicityTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_CriminalStatusHistories_Criminals_CriminalId",
                table: "CriminalStatusHistories",
                column: "CriminalId",
                principalTable: "Criminals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CriminalStatusHistories_CriminalStatuses_CriminalStatusId",
                table: "CriminalStatusHistories",
                column: "CriminalStatusId",
                principalTable: "CriminalStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_CriminalStatusHistories_Qualifications_QualificationId",
                table: "CriminalStatusHistories",
                column: "QualificationId",
                principalTable: "Qualifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePositionHistories_Employees_EmployeeId",
                table: "EmployeePositionHistories",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeRankHistories_Employees_EmployeeId",
                table: "EmployeeRankHistories",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Positions_PositionId",
                table: "Employees",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Ranks_RankId",
                table: "Employees",
                column: "RankId",
                principalTable: "Ranks",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_InspectionMaterialMovements_Employees_EmployeeId",
                table: "InspectionMaterialMovements",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_InspectionMaterialMovements_InspectionMaterialDecisions_InspectionMaterialDecisionId",
                table: "InspectionMaterialMovements",
                column: "InspectionMaterialDecisionId",
                principalTable: "InspectionMaterialDecisions",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_InspectionMaterials_Qualifications_QualificationId",
                table: "InspectionMaterials",
                column: "QualificationId",
                principalTable: "Qualifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_PreventiveMeasureDecisions_Employees_EmployeeId",
                table: "PreventiveMeasureDecisions",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_PreventiveMeasureDecisions_PreventiveMeasures_PreventiveMeasureId",
                table: "PreventiveMeasureDecisions",
                column: "PreventiveMeasureId",
                principalTable: "PreventiveMeasures",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CrimeReports_Employees_EmployeeId",
                table: "CrimeReports");

            migrationBuilder.DropForeignKey(
                name: "FK_CrimeReports_Qualifications_QualificationId",
                table: "CrimeReports");

            migrationBuilder.DropForeignKey(
                name: "FK_CriminalCaseMovements_CriminalCaseDecisions_DecisionId",
                table: "CriminalCaseMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_CriminalCaseMovements_CriminalCases_CriminalCaseId",
                table: "CriminalCaseMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_CriminalCaseMovements_Employees_EmployeeId",
                table: "CriminalCaseMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_CriminalCases_CriminalCaseAuthorities_CriminalCaseAuthorityId",
                table: "CriminalCases");

            migrationBuilder.DropForeignKey(
                name: "FK_CriminalCases_Qualifications_QualificationId",
                table: "CriminalCases");

            migrationBuilder.DropForeignKey(
                name: "FK_Criminals_CriminalStatuses_CriminalStatusId",
                table: "Criminals");

            migrationBuilder.DropForeignKey(
                name: "FK_CriminalStatusHistories_ComplicityTypes_ComplicityTypeId",
                table: "CriminalStatusHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_CriminalStatusHistories_Criminals_CriminalId",
                table: "CriminalStatusHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_CriminalStatusHistories_CriminalStatuses_CriminalStatusId",
                table: "CriminalStatusHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_CriminalStatusHistories_Qualifications_QualificationId",
                table: "CriminalStatusHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePositionHistories_Employees_EmployeeId",
                table: "EmployeePositionHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeRankHistories_Employees_EmployeeId",
                table: "EmployeeRankHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Positions_PositionId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Ranks_RankId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_InspectionMaterialMovements_Employees_EmployeeId",
                table: "InspectionMaterialMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_InspectionMaterialMovements_InspectionMaterialDecisions_InspectionMaterialDecisionId",
                table: "InspectionMaterialMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_InspectionMaterials_Qualifications_QualificationId",
                table: "InspectionMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_PreventiveMeasureDecisions_Employees_EmployeeId",
                table: "PreventiveMeasureDecisions");

            migrationBuilder.DropForeignKey(
                name: "FK_PreventiveMeasureDecisions_PreventiveMeasures_PreventiveMeasureId",
                table: "PreventiveMeasureDecisions");

            migrationBuilder.AlterColumn<int>(
                name: "PreventiveMeasureId",
                table: "PreventiveMeasureDecisions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "PreventiveMeasureDecisions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "QualificationId",
                table: "InspectionMaterials",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InspectionMaterialDecisionId",
                table: "InspectionMaterialMovements",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "InspectionMaterialMovements",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RankId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PositionId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "QualificationId",
                table: "CriminalStatusHistories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CriminalStatusId",
                table: "CriminalStatusHistories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ComplicityTypeId",
                table: "CriminalStatusHistories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CriminalStatusId",
                table: "Criminals",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "QualificationId",
                table: "CriminalCases",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CriminalCaseAuthorityId",
                table: "CriminalCases",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "CriminalCaseMovements",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DecisionId",
                table: "CriminalCaseMovements",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "QualificationId",
                table: "CrimeReports",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "CrimeReports",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CrimeReports_Employees_EmployeeId",
                table: "CrimeReports",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CrimeReports_Qualifications_QualificationId",
                table: "CrimeReports",
                column: "QualificationId",
                principalTable: "Qualifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CriminalCaseMovements_CriminalCaseDecisions_DecisionId",
                table: "CriminalCaseMovements",
                column: "DecisionId",
                principalTable: "CriminalCaseDecisions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CriminalCaseMovements_CriminalCases_CriminalCaseId",
                table: "CriminalCaseMovements",
                column: "CriminalCaseId",
                principalTable: "CriminalCases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CriminalCaseMovements_Employees_EmployeeId",
                table: "CriminalCaseMovements",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CriminalCases_CriminalCaseAuthorities_CriminalCaseAuthorityId",
                table: "CriminalCases",
                column: "CriminalCaseAuthorityId",
                principalTable: "CriminalCaseAuthorities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CriminalCases_Qualifications_QualificationId",
                table: "CriminalCases",
                column: "QualificationId",
                principalTable: "Qualifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Criminals_CriminalStatuses_CriminalStatusId",
                table: "Criminals",
                column: "CriminalStatusId",
                principalTable: "CriminalStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CriminalStatusHistories_ComplicityTypes_ComplicityTypeId",
                table: "CriminalStatusHistories",
                column: "ComplicityTypeId",
                principalTable: "ComplicityTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CriminalStatusHistories_Criminals_CriminalId",
                table: "CriminalStatusHistories",
                column: "CriminalId",
                principalTable: "Criminals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CriminalStatusHistories_CriminalStatuses_CriminalStatusId",
                table: "CriminalStatusHistories",
                column: "CriminalStatusId",
                principalTable: "CriminalStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CriminalStatusHistories_Qualifications_QualificationId",
                table: "CriminalStatusHistories",
                column: "QualificationId",
                principalTable: "Qualifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePositionHistories_Employees_EmployeeId",
                table: "EmployeePositionHistories",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeRankHistories_Employees_EmployeeId",
                table: "EmployeeRankHistories",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Positions_PositionId",
                table: "Employees",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Ranks_RankId",
                table: "Employees",
                column: "RankId",
                principalTable: "Ranks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InspectionMaterialMovements_Employees_EmployeeId",
                table: "InspectionMaterialMovements",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InspectionMaterialMovements_InspectionMaterialDecisions_InspectionMaterialDecisionId",
                table: "InspectionMaterialMovements",
                column: "InspectionMaterialDecisionId",
                principalTable: "InspectionMaterialDecisions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InspectionMaterials_Qualifications_QualificationId",
                table: "InspectionMaterials",
                column: "QualificationId",
                principalTable: "Qualifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PreventiveMeasureDecisions_Employees_EmployeeId",
                table: "PreventiveMeasureDecisions",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PreventiveMeasureDecisions_PreventiveMeasures_PreventiveMeasureId",
                table: "PreventiveMeasureDecisions",
                column: "PreventiveMeasureId",
                principalTable: "PreventiveMeasures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
