using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Storage.Migrations
{
    public partial class UpdateEmployeeRankAndPosition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndWorkDate",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "Rank",
                table: "EmployeeRanks",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Position",
                table: "EmployeePositions",
                newName: "Name");

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderDate",
                table: "EmployeeRanks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "OrderNumber",
                table: "EmployeeRanks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RankTerm",
                table: "EmployeeRanks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "AppointmentDate",
                table: "EmployeePositions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderDate",
                table: "EmployeePositions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "OrderNumber",
                table: "EmployeePositions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderDate",
                table: "EmployeeRanks");

            migrationBuilder.DropColumn(
                name: "OrderNumber",
                table: "EmployeeRanks");

            migrationBuilder.DropColumn(
                name: "RankTerm",
                table: "EmployeeRanks");

            migrationBuilder.DropColumn(
                name: "AppointmentDate",
                table: "EmployeePositions");

            migrationBuilder.DropColumn(
                name: "OrderDate",
                table: "EmployeePositions");

            migrationBuilder.DropColumn(
                name: "OrderNumber",
                table: "EmployeePositions");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "EmployeeRanks",
                newName: "Rank");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "EmployeePositions",
                newName: "Position");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndWorkDate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
