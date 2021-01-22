using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Storage.Migrations
{
    public partial class AddAppointmentDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
               name: "AppointmentDate",
               table: "Ranks",
               type: "datetime2",
               nullable: false,
               defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
              name: "AppointmentDate",
              table: "Ranks");
        }
    }
}
