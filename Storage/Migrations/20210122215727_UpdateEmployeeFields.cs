using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Storage.Migrations
{
    public partial class UpdateEmployeeFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReasonOfEndWork",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "StartWorkSODate",
                table: "Employees",
                newName: "QualificationUpdateDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "CertificationTerm",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ContractDate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "JoinServiceDate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CertificationTerm",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ContractDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "JoinServiceDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "QualificationUpdateDate",
                table: "Employees",
                newName: "StartWorkSODate");

            migrationBuilder.AddColumn<string>(
                name: "ReasonOfEndWork",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
