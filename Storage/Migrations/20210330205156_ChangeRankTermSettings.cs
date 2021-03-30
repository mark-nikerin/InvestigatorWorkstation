using Microsoft.EntityFrameworkCore.Migrations;

namespace Storage.Migrations
{
    public partial class ChangeRankTermSettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RankTerm",
                table: "EmployeeRankHistories");

            migrationBuilder.AddColumn<int>(
                name: "Term",
                table: "Ranks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Term",
                table: "Ranks");

            migrationBuilder.AddColumn<int>(
                name: "RankTerm",
                table: "EmployeeRankHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
