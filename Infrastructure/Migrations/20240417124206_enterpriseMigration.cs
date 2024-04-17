using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class enterpriseMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PromotionEnterprise_Enterprises_EnterpriseId",
                table: "PromotionEnterprise");

            migrationBuilder.DropForeignKey(
                name: "FK_PromotionEnterprise_Promotion_PromotionId",
                table: "PromotionEnterprise");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PromotionEnterprise",
                table: "PromotionEnterprise");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Promotion",
                table: "Promotion");

            migrationBuilder.RenameTable(
                name: "PromotionEnterprise",
                newName: "PromotionEnterprises");

            migrationBuilder.RenameTable(
                name: "Promotion",
                newName: "Promotions");

            migrationBuilder.RenameIndex(
                name: "IX_PromotionEnterprise_EnterpriseId",
                table: "PromotionEnterprises",
                newName: "IX_PromotionEnterprises_EnterpriseId");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Promotions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PromotionEnterprises",
                table: "PromotionEnterprises",
                columns: new[] { "PromotionId", "EnterpriseId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Promotions",
                table: "Promotions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PromotionEnterprises_Enterprises_EnterpriseId",
                table: "PromotionEnterprises",
                column: "EnterpriseId",
                principalTable: "Enterprises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PromotionEnterprises_Promotions_PromotionId",
                table: "PromotionEnterprises",
                column: "PromotionId",
                principalTable: "Promotions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PromotionEnterprises_Enterprises_EnterpriseId",
                table: "PromotionEnterprises");

            migrationBuilder.DropForeignKey(
                name: "FK_PromotionEnterprises_Promotions_PromotionId",
                table: "PromotionEnterprises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Promotions",
                table: "Promotions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PromotionEnterprises",
                table: "PromotionEnterprises");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Promotions");

            migrationBuilder.RenameTable(
                name: "Promotions",
                newName: "Promotion");

            migrationBuilder.RenameTable(
                name: "PromotionEnterprises",
                newName: "PromotionEnterprise");

            migrationBuilder.RenameIndex(
                name: "IX_PromotionEnterprises_EnterpriseId",
                table: "PromotionEnterprise",
                newName: "IX_PromotionEnterprise_EnterpriseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Promotion",
                table: "Promotion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PromotionEnterprise",
                table: "PromotionEnterprise",
                columns: new[] { "PromotionId", "EnterpriseId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PromotionEnterprise_Enterprises_EnterpriseId",
                table: "PromotionEnterprise",
                column: "EnterpriseId",
                principalTable: "Enterprises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PromotionEnterprise_Promotion_PromotionId",
                table: "PromotionEnterprise",
                column: "PromotionId",
                principalTable: "Promotion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
