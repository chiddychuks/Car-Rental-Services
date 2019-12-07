using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Web.Data.Migrations
{
    public partial class AddedTimestamps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Cars",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "RegNumber",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateBooked",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "Bookings",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "RegNumber",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "DateBooked",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Bookings");
        }
    }
}
