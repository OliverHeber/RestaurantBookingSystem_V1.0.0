using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantBookingSystem_V1._0._0.Migrations
{
    public partial class rename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoB",
                value: new DateTime(2020, 10, 15, 10, 13, 14, 993, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "DoB",
                value: new DateTime(2020, 10, 15, 10, 13, 14, 995, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3,
                column: "DoB",
                value: new DateTime(2020, 10, 15, 10, 13, 14, 995, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2020, 10, 15, 10, 13, 14, 995, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2020, 10, 15, 10, 13, 14, 995, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2020, 10, 15, 10, 13, 14, 995, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2020, 10, 15, 10, 13, 14, 995, DateTimeKind.Local).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2020, 10, 15, 10, 13, 14, 995, DateTimeKind.Local).AddTicks(9941));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoB",
                value: new DateTime(2020, 10, 9, 22, 6, 4, 480, DateTimeKind.Local).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "DoB",
                value: new DateTime(2020, 10, 9, 22, 6, 4, 483, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3,
                column: "DoB",
                value: new DateTime(2020, 10, 9, 22, 6, 4, 483, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2020, 10, 9, 22, 6, 4, 483, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2020, 10, 9, 22, 6, 4, 483, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2020, 10, 9, 22, 6, 4, 483, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2020, 10, 9, 22, 6, 4, 483, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2020, 10, 9, 22, 6, 4, 483, DateTimeKind.Local).AddTicks(8772));
        }
    }
}
