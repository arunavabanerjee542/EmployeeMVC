using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagementMVC.Migrations
{
    public partial class AddEmployeeDataNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "id", "Department", "name" },
                values: new object[] { 9, 0, "Annnapurna" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 9);
        }
    }
}
