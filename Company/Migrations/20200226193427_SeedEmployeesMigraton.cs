using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Migrations
{
    public partial class SeedEmployeesMigraton : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Email", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, 1, "adam123@gmail.com", "Adam", "Jackson" },
                    { 2, 2, "ann765@gmail.com", "Ann", "Ornah" },
                    { 3, 0, "noah7654@gmail.com", "Noah", "Ming" },
                    { 4, 1, "steven6543@gmail.com", "Steven", "Sparrow" },
                    { 5, 2, "michael5432@gmail.com", "Michael", "Anthony" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
