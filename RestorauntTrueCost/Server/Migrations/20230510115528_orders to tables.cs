using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestorauntTrueCost.Server.Migrations
{
    /// <inheritdoc />
    public partial class orderstotables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdersToTables_TableOrders_TableOrderId",
                table: "OrdersToTables");

            migrationBuilder.DropIndex(
                name: "IX_OrdersToTables_TableOrderId",
                table: "OrdersToTables");

            migrationBuilder.DropColumn(
                name: "TableOrderId",
                table: "OrdersToTables");

            migrationBuilder.AddColumn<int>(
                name: "OrdersToTablesId",
                table: "TableOrders",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TableOrders_OrdersToTablesId",
                table: "TableOrders",
                column: "OrdersToTablesId");

            migrationBuilder.AddForeignKey(
                name: "FK_TableOrders_OrdersToTables_OrdersToTablesId",
                table: "TableOrders",
                column: "OrdersToTablesId",
                principalTable: "OrdersToTables",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TableOrders_OrdersToTables_OrdersToTablesId",
                table: "TableOrders");

            migrationBuilder.DropIndex(
                name: "IX_TableOrders_OrdersToTablesId",
                table: "TableOrders");

            migrationBuilder.DropColumn(
                name: "OrdersToTablesId",
                table: "TableOrders");

            migrationBuilder.AddColumn<int>(
                name: "TableOrderId",
                table: "OrdersToTables",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrdersToTables_TableOrderId",
                table: "OrdersToTables",
                column: "TableOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersToTables_TableOrders_TableOrderId",
                table: "OrdersToTables",
                column: "TableOrderId",
                principalTable: "TableOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
