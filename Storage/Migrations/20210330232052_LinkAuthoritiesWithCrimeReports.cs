using Microsoft.EntityFrameworkCore.Migrations;

namespace Storage.Migrations
{
    public partial class LinkAuthoritiesWithCrimeReports : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegistrationAuthority",
                table: "CrimeReports");

            migrationBuilder.AddColumn<int>(
                name: "AuthorityId",
                table: "CrimeReports",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CrimeReports_AuthorityId",
                table: "CrimeReports",
                column: "AuthorityId");

            migrationBuilder.AddForeignKey(
                name: "FK_CrimeReports_Authorities_AuthorityId",
                table: "CrimeReports",
                column: "AuthorityId",
                principalTable: "Authorities",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CrimeReports_Authorities_AuthorityId",
                table: "CrimeReports");

            migrationBuilder.DropIndex(
                name: "IX_CrimeReports_AuthorityId",
                table: "CrimeReports");

            migrationBuilder.DropColumn(
                name: "AuthorityId",
                table: "CrimeReports");

            migrationBuilder.AddColumn<string>(
                name: "RegistrationAuthority",
                table: "CrimeReports",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
