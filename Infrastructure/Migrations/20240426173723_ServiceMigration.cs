using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ServiceMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ServicePayments",
                table: "ServicePayments");

            migrationBuilder.RenameColumn(
                name: "PaymentDate",
                table: "ServicePayments",
                newName: "DepositDateTime");

            migrationBuilder.RenameColumn(
                name: "DebitAccountId",
                table: "ServicePayments",
                newName: "ServiceId");

            migrationBuilder.AlterColumn<string>(
                name: "DocumentNumber",
                table: "ServicePayments",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ServicePayments",
                type: "character varying(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "ServicePayments",
                type: "numeric(20,5)",
                precision: 20,
                scale: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AddPrimaryKey(
                name: "Payment_pkey",
                table: "ServicePayments",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Service_pkey", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServicePayments_ServiceId",
                table: "ServicePayments",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServicePayments_Services_ServiceId",
                table: "ServicePayments",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServicePayments_Services_ServiceId",
                table: "ServicePayments");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropPrimaryKey(
                name: "Payment_pkey",
                table: "ServicePayments");

            migrationBuilder.DropIndex(
                name: "IX_ServicePayments_ServiceId",
                table: "ServicePayments");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "ServicePayments",
                newName: "DebitAccountId");

            migrationBuilder.RenameColumn(
                name: "DepositDateTime",
                table: "ServicePayments",
                newName: "PaymentDate");

            migrationBuilder.AlterColumn<string>(
                name: "DocumentNumber",
                table: "ServicePayments",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ServicePayments",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "ServicePayments",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(20,5)",
                oldPrecision: 20,
                oldScale: 5);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServicePayments",
                table: "ServicePayments",
                column: "Id");
        }
    }
}
