using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantBookingSystem_V1._0._0.Migrations
{
    public partial class restaurant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RestaurantId",
                table: "Staff",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RestaurantId",
                table: "Members",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<DateTime>(nullable: false),
                    Duration = table.Column<TimeSpan>(nullable: false),
                    ReservationSource = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationId);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Available = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sittings",
                columns: table => new
                {
                    SittingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Special = table.Column<bool>(nullable: false),
                    SittingDuration = table.Column<TimeSpan>(nullable: false),
                    FullyBooked = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sittings", x => x.SittingId);
                });

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    AreaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaName = table.Column<string>(nullable: true),
                    FullyBooked = table.Column<bool>(nullable: false),
                    RestaurantId = table.Column<int>(nullable: true),
                    SittingId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.AreaId);
                    table.ForeignKey(
                        name: "FK_Areas_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Areas_Sittings_SittingId",
                        column: x => x.SittingId,
                        principalTable: "Sittings",
                        principalColumn: "SittingId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    TableId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Booked = table.Column<bool>(nullable: false),
                    Seats = table.Column<int>(nullable: false),
                    AreaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.TableId);
                    table.ForeignKey(
                        name: "FK_Tables_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "AreaId",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Staff_RestaurantId",
                table: "Staff",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Members_RestaurantId",
                table: "Members",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Areas_RestaurantId",
                table: "Areas",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Areas_SittingId",
                table: "Areas",
                column: "SittingId");

            migrationBuilder.CreateIndex(
                name: "IX_Tables_AreaId",
                table: "Tables",
                column: "AreaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Restaurants_RestaurantId",
                table: "Members",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Restaurants_RestaurantId",
                table: "Staff",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Restaurants_RestaurantId",
                table: "Members");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Restaurants_RestaurantId",
                table: "Staff");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Sittings");

            migrationBuilder.DropIndex(
                name: "IX_Staff_RestaurantId",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Members_RestaurantId",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "RestaurantId",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "RestaurantId",
                table: "Members");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoB",
                value: new DateTime(2020, 10, 9, 21, 0, 53, 481, DateTimeKind.Local).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "DoB",
                value: new DateTime(2020, 10, 9, 21, 0, 53, 483, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3,
                column: "DoB",
                value: new DateTime(2020, 10, 9, 21, 0, 53, 483, DateTimeKind.Local).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2020, 10, 9, 21, 0, 53, 483, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2020, 10, 9, 21, 0, 53, 483, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2020, 10, 9, 21, 0, 53, 483, DateTimeKind.Local).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2020, 10, 9, 21, 0, 53, 483, DateTimeKind.Local).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2020, 10, 9, 21, 0, 53, 483, DateTimeKind.Local).AddTicks(5898));
        }
    }
}
