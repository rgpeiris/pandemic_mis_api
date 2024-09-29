using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.OrganizationManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddComplaintTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Complaints",
                columns: table => new
                {
                    ComplaintId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComplaintTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComplaintDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaints", x => x.ComplaintId);
                });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 30, 9, 48, 18, 14, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 30, 9, 48, 18, 14, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "PandemicContacts",
                keyColumn: "PandemicContactId",
                keyValue: 1,
                columns: new[] { "CheckInTime", "CheckOutTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 3, 30, 9, 48, 18, 14, DateTimeKind.Local).AddTicks(5054), new DateTime(2024, 3, 30, 9, 48, 18, 14, DateTimeKind.Local).AddTicks(5054), new DateTime(2024, 3, 30, 9, 48, 18, 14, DateTimeKind.Local).AddTicks(5055) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Complaints");

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 28, 17, 21, 57, 861, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 28, 17, 21, 57, 861, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "PandemicContacts",
                keyColumn: "PandemicContactId",
                keyValue: 1,
                columns: new[] { "CheckInTime", "CheckOutTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 1, 28, 17, 21, 57, 861, DateTimeKind.Local).AddTicks(1106), new DateTime(2024, 1, 28, 17, 21, 57, 861, DateTimeKind.Local).AddTicks(1107), new DateTime(2024, 1, 28, 17, 21, 57, 861, DateTimeKind.Local).AddTicks(1108) });
        }
    }
}
