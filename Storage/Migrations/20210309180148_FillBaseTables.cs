using Microsoft.EntityFrameworkCore.Migrations;

namespace Storage.Migrations
{
    public partial class FillBaseTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                "Ranks",
                new string[]
                {
                    "Name"
                },
                new string[]
                {
                    "nvarchar(max)"
                },
                new object[,]
                {
                    {"Младший лейтенант юстиции" },
                    {"Лейтенант юстиции" },
                    {"Старший лейтенант юстиции" },
                    {"Капитан юстиции" },
                    {"Майор юстиции" },
                    {"Подполковник юстиции" },
                    {"Полковник юстиции" }
                }
               );

            migrationBuilder.InsertData(
                "Positions",
                new string[]
                {
                    "Name"
                },
                new string[]
                {
                    "nvarchar(max)"
                },
                new object[,]
                {
                    {"Начальник отдела" },
                    {"Заместитель начальника отдела" },
                    {"Начальник отдела в главном управлении" },
                    {"Начальник отдела в управлении" },
                    {"Ведущий советник" },
                    {"Советник" },
                    {"Главный консультант" },
                    {"Консультант" }
                }
               );

            migrationBuilder.InsertData(
                "PreventiveMeasures",
                new string[]
                {
                    "Measure"
                },
                new string[]
                {
                    "nvarchar(max)"
                },
                new object[,]
                {
                    {"Подписка о невыезде" },
                    {"Личное поручительство" },
                    {"Наблюдение командования воинской части" },
                    {"Присмотр за несовершеннолетним обвиняемым" },
                    {"Запрет определенных действий" },
                    {"Залог" },
                    {"Домашний арест" },
                    {"Заключение под стражу" }
                }
               );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE * FROM dbo.Ranks WHERE Name <> 'admin'");
            migrationBuilder.Sql("DELETE * FROM dbo.Positions WHERE Name <> 'admin'");
            migrationBuilder.Sql("DELETE * FROM dbo.PreventiveMeasures");
        }
    }
}
