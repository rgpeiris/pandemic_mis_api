using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.OrganizationManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDataTypeInPandemicContactsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "PandemicContacts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Organizations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 18, 54, 530, DateTimeKind.Local).AddTicks(57), "0112637483" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 18, 54, 530, DateTimeKind.Local).AddTicks(99), "0112637487" });

            migrationBuilder.UpdateData(
                table: "PandemicContacts",
                keyColumn: "PandemicContactId",
                keyValue: 1,
                columns: new[] { "CheckInTime", "CheckOutTime", "CreatedDate", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 18, 54, 530, DateTimeKind.Local).AddTicks(118), new DateTime(2024, 1, 25, 13, 18, 54, 530, DateTimeKind.Local).AddTicks(119), new DateTime(2024, 1, 25, 13, 18, 54, 530, DateTimeKind.Local).AddTicks(120), "0778364772" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "PandemicContacts",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Organizations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 10, 45, 602, DateTimeKind.Local).AddTicks(6701), 112637483 });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 10, 45, 602, DateTimeKind.Local).AddTicks(6823), 112637487 });

            migrationBuilder.UpdateData(
                table: "PandemicContacts",
                keyColumn: "PandemicContactId",
                keyValue: 1,
                columns: new[] { "CheckInTime", "CheckOutTime", "CreatedDate", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 10, 45, 602, DateTimeKind.Local).AddTicks(6849), new DateTime(2024, 1, 25, 13, 10, 45, 602, DateTimeKind.Local).AddTicks(6849), new DateTime(2024, 1, 25, 13, 10, 45, 602, DateTimeKind.Local).AddTicks(6851), 778364772 });
        }
    }
}
