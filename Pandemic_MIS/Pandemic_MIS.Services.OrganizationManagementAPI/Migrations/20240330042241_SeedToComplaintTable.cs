using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.OrganizationManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedToComplaintTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Complaints",
                columns: new[] { "ComplaintId", "ComplaintDescription", "ComplaintTitle", "CreatedBy", "CreatedDate" },
                values: new object[] { 1, "Complaint 1 Description", "Complaint 1", "au_nipunsala", new DateTime(2024, 3, 30, 9, 52, 40, 606, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 30, 9, 52, 40, 606, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 30, 9, 52, 40, 606, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "PandemicContacts",
                keyColumn: "PandemicContactId",
                keyValue: 1,
                columns: new[] { "CheckInTime", "CheckOutTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 3, 30, 9, 52, 40, 606, DateTimeKind.Local).AddTicks(8706), new DateTime(2024, 3, 30, 9, 52, 40, 606, DateTimeKind.Local).AddTicks(8707), new DateTime(2024, 3, 30, 9, 52, 40, 606, DateTimeKind.Local).AddTicks(8708) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Complaints",
                keyColumn: "ComplaintId",
                keyValue: 1);

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
    }
}
