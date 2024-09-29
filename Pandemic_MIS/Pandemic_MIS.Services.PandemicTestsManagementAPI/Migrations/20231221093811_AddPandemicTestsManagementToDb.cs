using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PandemicTestsManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddPandemicTestsManagementToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PandemicTestResults",
                columns: table => new
                {
                    PandemicTestResultId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NICNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MOHArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GramaNiladhariArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerialNumber = table.Column<int>(type: "int", nullable: false),
                    TestCentreId = table.Column<int>(type: "int", nullable: false),
                    DateOfPandemicTest = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TestResult = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestResultSummary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PandemicTestResults", x => x.PandemicTestResultId);
                });

            migrationBuilder.CreateTable(
                name: "PandemicTests",
                columns: table => new
                {
                    PandemicTestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PandemicTests", x => x.PandemicTestId);
                });

            migrationBuilder.CreateTable(
                name: "ScheduledTestCentres",
                columns: table => new
                {
                    ScheduledTestCentreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestCentreId = table.Column<int>(type: "int", nullable: false),
                    DateScheduled = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeScheduled = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvailableCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduledTestCentres", x => x.ScheduledTestCentreId);
                });

            migrationBuilder.CreateTable(
                name: "TestCentres",
                columns: table => new
                {
                    TestCentreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CentreName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestCentres", x => x.TestCentreId);
                });

            migrationBuilder.CreateTable(
                name: "TestsAppointments",
                columns: table => new
                {
                    TestsAppointmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NICNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestCentreId = table.Column<int>(type: "int", nullable: false),
                    DateScheduled = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeScheduled = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestsAppointments", x => x.TestsAppointmentId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PandemicTestResults");

            migrationBuilder.DropTable(
                name: "PandemicTests");

            migrationBuilder.DropTable(
                name: "ScheduledTestCentres");

            migrationBuilder.DropTable(
                name: "TestCentres");

            migrationBuilder.DropTable(
                name: "TestsAppointments");
        }
    }
}
