using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solid.Data.Migrations
{
    public partial class chnagebuyerseller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProductList_BuyerId",
                table: "ProductList");

            migrationBuilder.DropIndex(
                name: "IX_ProductList_SellerId",
                table: "ProductList");

            migrationBuilder.CreateIndex(
                name: "IX_ProductList_BuyerId",
                table: "ProductList",
                column: "BuyerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductList_SellerId",
                table: "ProductList",
                column: "SellerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProductList_BuyerId",
                table: "ProductList");

            migrationBuilder.DropIndex(
                name: "IX_ProductList_SellerId",
                table: "ProductList");

            migrationBuilder.CreateIndex(
                name: "IX_ProductList_BuyerId",
                table: "ProductList",
                column: "BuyerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductList_SellerId",
                table: "ProductList",
                column: "SellerId",
                unique: true);
        }
    }
}
