using Microsoft.EntityFrameworkCore.Migrations;

namespace Storage.Migrations
{
    public partial class RemoveQualifications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CrimeReports_Qualifications_QualificationId",
                table: "CrimeReports");

            migrationBuilder.DropForeignKey(
                name: "FK_CriminalCases_Qualifications_QualificationId",
                table: "CriminalCases");

            migrationBuilder.DropForeignKey(
                name: "FK_CriminalStatusHistories_Qualifications_QualificationId",
                table: "CriminalStatusHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_InspectionMaterials_Qualifications_QualificationId",
                table: "InspectionMaterials");

            migrationBuilder.DropTable(
                name: "Qualifications");

            migrationBuilder.DropIndex(
                name: "IX_InspectionMaterials_QualificationId",
                table: "InspectionMaterials");

            migrationBuilder.DropIndex(
                name: "IX_CriminalStatusHistories_QualificationId",
                table: "CriminalStatusHistories");

            migrationBuilder.DropIndex(
                name: "IX_CriminalCases_QualificationId",
                table: "CriminalCases");

            migrationBuilder.DropIndex(
                name: "IX_CrimeReports_QualificationId",
                table: "CrimeReports");

            migrationBuilder.DropColumn(
                name: "QualificationId",
                table: "InspectionMaterials");

            migrationBuilder.DropColumn(
                name: "QualificationId",
                table: "CriminalStatusHistories");

            migrationBuilder.DropColumn(
                name: "QualificationId",
                table: "CriminalCases");

            migrationBuilder.DropColumn(
                name: "QualificationId",
                table: "CrimeReports");

            migrationBuilder.AddColumn<string>(
                name: "Qualification",
                table: "InspectionMaterials",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Qualification",
                table: "CriminalStatusHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Qualification",
                table: "CriminalCases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Qualification",
                table: "CrimeReports",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Qualification",
                table: "InspectionMaterials");

            migrationBuilder.DropColumn(
                name: "Qualification",
                table: "CriminalStatusHistories");

            migrationBuilder.DropColumn(
                name: "Qualification",
                table: "CriminalCases");

            migrationBuilder.DropColumn(
                name: "Qualification",
                table: "CrimeReports");

            migrationBuilder.AddColumn<int>(
                name: "QualificationId",
                table: "InspectionMaterials",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QualificationId",
                table: "CriminalStatusHistories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QualificationId",
                table: "CriminalCases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QualificationId",
                table: "CrimeReports",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_InspectionMaterials_QualificationId",
                table: "InspectionMaterials",
                column: "QualificationId");

            migrationBuilder.CreateIndex(
                name: "IX_CriminalStatusHistories_QualificationId",
                table: "CriminalStatusHistories",
                column: "QualificationId");

            migrationBuilder.CreateIndex(
                name: "IX_CriminalCases_QualificationId",
                table: "CriminalCases",
                column: "QualificationId");

            migrationBuilder.CreateIndex(
                name: "IX_CrimeReports_QualificationId",
                table: "CrimeReports",
                column: "QualificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_CrimeReports_Qualifications_QualificationId",
                table: "CrimeReports",
                column: "QualificationId",
                principalTable: "Qualifications",
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
                name: "FK_CriminalStatusHistories_Qualifications_QualificationId",
                table: "CriminalStatusHistories",
                column: "QualificationId",
                principalTable: "Qualifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_InspectionMaterials_Qualifications_QualificationId",
                table: "InspectionMaterials",
                column: "QualificationId",
                principalTable: "Qualifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
