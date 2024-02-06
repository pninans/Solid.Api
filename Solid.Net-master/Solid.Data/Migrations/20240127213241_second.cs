using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solid.Data.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuyerList_SellerList_SellerId",
                table: "BuyerList");

            migrationBuilder.DropIndex(
                name: "IX_BuyerList_SellerId",
                table: "BuyerList");

            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "BuyerList");

            migrationBuilder.AddColumn<int>(
                name: "BuyerId",
                table: "ProductList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductList_BuyerId",
                table: "ProductList",
                column: "BuyerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductList_BuyerList_BuyerId",
                table: "ProductList",
                column: "BuyerId",
                principalTable: "BuyerList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductList_BuyerList_BuyerId",
                table: "ProductList");

            migrationBuilder.DropIndex(
                name: "IX_ProductList_BuyerId",
                table: "ProductList");

            migrationBuilder.DropColumn(
                name: "BuyerId",
                table: "ProductList");

            migrationBuilder.AddColumn<int>(
                name: "SellerId",
                table: "BuyerList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BuyerList_SellerId",
                table: "BuyerList",
                column: "SellerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BuyerList_SellerList_SellerId",
                table: "BuyerList",
                column: "SellerId",
                principalTable: "SellerList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
