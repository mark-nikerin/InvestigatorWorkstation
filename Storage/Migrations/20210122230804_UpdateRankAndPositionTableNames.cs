using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Storage.Migrations
{
    public partial class UpdateRankAndPositionTableNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmployeePositions_PositionId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmployeeRanks_RankId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeRanks",
                table: "EmployeeRanks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeePositions",
                table: "EmployeePositions");

            migrationBuilder.RenameTable(
                name: "EmployeeRanks",
                newName: "Ranks");

            migrationBuilder.RenameTable(
                name: "EmployeePositions",
                newName: "Positions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ranks",
                table: "Ranks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Positions",
                table: "Positions",
                column: "Id");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Positions_PositionId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Ranks_RankId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ranks",
                table: "Ranks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Positions",
                table: "Positions");

            migrationBuilder.RenameTable(
                name: "Ranks",
                newName: "EmployeeRanks");

            migrationBuilder.RenameTable(
                name: "Positions",
                newName: "EmployeePositions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeRanks",
                table: "EmployeeRanks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeePositions",
                table: "EmployeePositions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmployeePositions_PositionId",
                table: "Employees",
                column: "PositionId",
                principalTable: "EmployeePositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmployeeRanks_RankId",
                table: "Employees",
                column: "RankId",
                principalTable: "EmployeeRanks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
