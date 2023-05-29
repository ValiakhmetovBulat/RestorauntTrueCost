using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RestorauntTrueCost.Server.Migrations
{
    /// <inheritdoc />
    public partial class removedorderstotablesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TableOrders_OrdersToTables_OrdersToTablesId",
                table: "TableOrders");

            migrationBuilder.DropTable(
                name: "OrdersToTables");

            migrationBuilder.RenameColumn(
                name: "OrdersToTablesId",
                table: "TableOrders",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_TableOrders_OrdersToTablesId",
                table: "TableOrders",
                newName: "IX_TableOrders_OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_TableOrders_Orders_OrderId",
                table: "TableOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TableOrders_Orders_OrderId",
                table: "TableOrders");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "TableOrders",
                newName: "OrdersToTablesId");

            migrationBuilder.RenameIndex(
                name: "IX_TableOrders_OrderId",
                table: "TableOrders",
                newName: "IX_TableOrders_OrdersToTablesId");

            migrationBuilder.CreateTable(
                name: "OrdersToTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersToTables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdersToTables_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrdersToTables_OrderId",
                table: "OrdersToTables",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_TableOrders_OrdersToTables_OrdersToTablesId",
                table: "TableOrders",
                column: "OrdersToTablesId",
                principalTable: "OrdersToTables",
                principalColumn: "Id");
        }
    }
}
