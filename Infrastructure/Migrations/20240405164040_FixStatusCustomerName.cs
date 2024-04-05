using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixStatusCustomerName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          
          

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Customers",
                newName: "CustomerStatus");

            migrationBuilder.AddColumn<DateTime>(
                name: "Birth",
                table: "Customers",
                type: "timestamp with time zone",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birth",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "CustomerStatus",
                table: "Customers",
                newName: "Estado");

            migrationBuilder.AddColumn<string>(
                name: "Balance",
                table: "Banks",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Customer",
                table: "Banks",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "Banks",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
