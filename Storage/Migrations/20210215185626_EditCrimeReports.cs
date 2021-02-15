using Microsoft.EntityFrameworkCore.Migrations;

namespace Storage.Migrations
{
    public partial class EditCrimeReports : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RegistratinAuthority",
                table: "CrimeReports",
                newName: "RegistrationNumber");

            migrationBuilder.AddColumn<string>(
                name: "RegistrationAuthority",
                table: "CrimeReports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegistrationBookNumber",
                table: "CrimeReports",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegistrationAuthority",
                table: "CrimeReports");

            migrationBuilder.DropColumn(
                name: "RegistrationBookNumber",
                table: "CrimeReports");

            migrationBuilder.RenameColumn(
                name: "RegistrationNumber",
                table: "CrimeReports",
                newName: "RegistratinAuthority");
        }
    }
}
