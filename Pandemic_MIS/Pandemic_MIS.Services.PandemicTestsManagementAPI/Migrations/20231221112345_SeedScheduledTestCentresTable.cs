using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PandemicTestsManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedScheduledTestCentresTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ScheduledTestCentres",
                columns: new[] { "ScheduledTestCentreId", "AvailableCapacity", "DateScheduled", "TestCentreId", "TimeScheduled" },
                values: new object[] { 1, 300, new DateTime(2023, 12, 21, 16, 53, 45, 3, DateTimeKind.Local).AddTicks(4870), 1, "Forenoon" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ScheduledTestCentres",
                keyColumn: "ScheduledTestCentreId",
                keyValue: 1);
        }
    }
}
