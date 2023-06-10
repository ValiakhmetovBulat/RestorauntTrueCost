using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestorauntTrueCost.Server.Migrations
{
    /// <inheritdoc />
    public partial class addedorderlogic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdersToTables_Tables_TableId",
                table: "OrdersToTables");

            migrationBuilder.DropIndex(
                name: "IX_OrdersToTables_TableId",
                table: "OrdersToTables");

            migrationBuilder.DropColumn(
                name: "TableId",
                table: "OrdersToTables");

            migrationBuilder.DropColumn(
                name: "OrderedDate",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "ReserveCost",
                table: "Tables",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TableOrderId",
                table: "OrdersToTables",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "OrdersToPositions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalSum",
                table: "Orders",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdersToTables_TableOrders_TableOrderId",
                table: "OrdersToTables");

            migrationBuilder.DropIndex(
                name: "IX_OrdersToTables_TableOrderId",
                table: "OrdersToTables");

            migrationBuilder.DropColumn(
                name: "ReserveCost",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "TableOrderId",
                table: "OrdersToTables");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "OrdersToPositions");

            migrationBuilder.DropColumn(
                name: "TotalSum",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "TableId",
                table: "OrdersToTables",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderedDate",
                table: "Orders",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_OrdersToTables_TableId",
                table: "OrdersToTables",
                column: "TableId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersToTables_Tables_TableId",
                table: "OrdersToTables",
                column: "TableId",
                principalTable: "Tables",
                principalColumn: "Id");
        }
    }
}
