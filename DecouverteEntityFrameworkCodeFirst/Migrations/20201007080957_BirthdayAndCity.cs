using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace DecouverteEntityFrameworkCodeFirst.Migrations
{
    public partial class BirthdayAndCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDay",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Customers",
                maxLength: 30,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDay",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Customers");
        }
    }
}
