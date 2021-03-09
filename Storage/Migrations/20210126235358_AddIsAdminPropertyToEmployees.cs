﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Storage.Migrations
{
    public partial class AddIsAdminPropertyToEmployees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        { 
            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.Sql(@" 
INSERT INTO [dbo].[Positions] VALUES ('admin', GETDATE(), GETDATE(), 0)

INSERT INTO [dbo].[Ranks] VALUES ('admin', GETDATE(), 0, 0, GETDATE())

DECLARE @adminPositionId INT, @adminRankId INT, @adminId INT;

SELECT @adminRankId = (SELECT TOP(1) Id FROM [dbo].[Ranks] WHERE Name = 'admin')

SELECT @adminPositionId = (SELECT TOP(1) Id FROM [dbo].Positions WHERE Name = 'admin')

INSERT INTO [dbo].[Employees] VALUES (N'Администратор', N'Администратор', N'Администратор', GETDATE(), GETDATE(), GETDATE(), @adminRankId, @adminPositionId, 'admin','admin', GETDATE(), GETDATE(), GETDATE(), 0, 1);

SELECT @adminId = (SELECT TOP(1) Id FROM [dbo].[Employees] e WHERE Login = 'admin')

INSERT INTO [dbo].[EmployeeRankHistories] (AppointmentDate, OrderDate, OrderNumber, RankTerm, RankId, EmployeeId) VALUES (GETDATE(), GETDATE(), 0, 100, @adminRankId, @adminId);

INSERT INTO [dbo].[EmployeePositionHistories] (AppointmentDate, OrderDate, OrderNumber, PositionId, EmployeeId) VALUES (GETDATE(), GETDATE(), 0, @adminPositionId, @adminId);
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Employees");
        }
    }
}
