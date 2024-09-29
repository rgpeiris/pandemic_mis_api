using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.OrganizationManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldsToPandemicContactsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PandemicContacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 28, 17, 17, 39, 884, DateTimeKind.Local).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 28, 17, 17, 39, 884, DateTimeKind.Local).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "PandemicContacts",
                keyColumn: "PandemicContactId",
                keyValue: 1,
                columns: new[] { "CheckInTime", "CheckOutTime", "CreatedBy", "CreatedDate" },
                values: new object[] { new DateTime(2024, 1, 28, 17, 17, 39, 884, DateTimeKind.Local).AddTicks(3032), new DateTime(2024, 1, 28, 17, 17, 39, 884, DateTimeKind.Local).AddTicks(3033), "ad_rpeiris", new DateTime(2024, 1, 28, 17, 17, 39, 884, DateTimeKind.Local).AddTicks(3034) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PandemicContacts");

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 25, 13, 18, 54, 530, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 25, 13, 18, 54, 530, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "PandemicContacts",
                keyColumn: "PandemicContactId",
                keyValue: 1,
                columns: new[] { "CheckInTime", "CheckOutTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 18, 54, 530, DateTimeKind.Local).AddTicks(118), new DateTime(2024, 1, 25, 13, 18, 54, 530, DateTimeKind.Local).AddTicks(119), new DateTime(2024, 1, 25, 13, 18, 54, 530, DateTimeKind.Local).AddTicks(120) });
        }
    }
}
