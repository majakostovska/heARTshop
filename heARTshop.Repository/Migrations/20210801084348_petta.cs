using Microsoft.EntityFrameworkCore.Migrations;

namespace heARTshop.Repository.Migrations
{
    public partial class petta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInOrder_Order_OrderId",
                table: "ProductInOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInOrder_Products_ProductId",
                table: "ProductInOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInShoppingCarts",
                table: "ProductInShoppingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInOrder",
                table: "ProductInOrder");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInShoppingCarts",
                table: "ProductInShoppingCarts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInOrder",
                table: "ProductInOrder",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInShoppingCarts_ProductId",
                table: "ProductInShoppingCarts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInOrder_ProductId",
                table: "ProductInOrder",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInOrder_Products_OrderId",
                table: "ProductInOrder",
                column: "OrderId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInOrder_Order_ProductId",
                table: "ProductInOrder",
                column: "ProductId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInOrder_Products_OrderId",
                table: "ProductInOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInOrder_Order_ProductId",
                table: "ProductInOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInShoppingCarts",
                table: "ProductInShoppingCarts");

            migrationBuilder.DropIndex(
                name: "IX_ProductInShoppingCarts_ProductId",
                table: "ProductInShoppingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInOrder",
                table: "ProductInOrder");

            migrationBuilder.DropIndex(
                name: "IX_ProductInOrder_ProductId",
                table: "ProductInOrder");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInShoppingCarts",
                table: "ProductInShoppingCarts",
                columns: new[] { "ProductId", "ShoppingCartId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInOrder",
                table: "ProductInOrder",
                columns: new[] { "ProductId", "OrderId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInOrder_Order_OrderId",
                table: "ProductInOrder",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInOrder_Products_ProductId",
                table: "ProductInOrder",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
