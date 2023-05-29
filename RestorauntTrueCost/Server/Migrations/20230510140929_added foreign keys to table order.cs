using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestorauntTrueCost.Server.Migrations
{
    /// <inheritdoc />
    public partial class addedforeignkeystotableorder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TableOrders_OrderPeriods_OrderPeriodId",
                table: "TableOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_TableOrders_Orders_OrderId",
                table: "TableOrders");

            migrationBuilder.AlterColumn<int>(
                name: "OrderPeriodId",
                table: "TableOrders",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "TableOrders",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TableOrders_OrderPeriods_OrderPeriodId",
                table: "TableOrders",
                column: "OrderPeriodId",
                principalTable: "OrderPeriods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TableOrders_Orders_OrderId",
                table: "TableOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TableOrders_OrderPeriods_OrderPeriodId",
                table: "TableOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_TableOrders_Orders_OrderId",
                table: "TableOrders");

            migrationBuilder.AlterColumn<int>(
                name: "OrderPeriodId",
                table: "TableOrders",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "TableOrders",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_TableOrders_OrderPeriods_OrderPeriodId",
                table: "TableOrders",
                column: "OrderPeriodId",
                principalTable: "OrderPeriods",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TableOrders_Orders_OrderId",
                table: "TableOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
