using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RestorauntTrueCost.Server.Migrations
{
    /// <inheritdoc />
    public partial class orderperiods : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderPeriodId",
                table: "TableOrders",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrderPeriods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    From = table.Column<string>(type: "text", nullable: false),
                    To = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPeriods", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TableOrders_OrderPeriodId",
                table: "TableOrders",
                column: "OrderPeriodId");

            migrationBuilder.AddForeignKey(
                name: "FK_TableOrders_OrderPeriods_OrderPeriodId",
                table: "TableOrders",
                column: "OrderPeriodId",
                principalTable: "OrderPeriods",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TableOrders_OrderPeriods_OrderPeriodId",
                table: "TableOrders");

            migrationBuilder.DropTable(
                name: "OrderPeriods");

            migrationBuilder.DropIndex(
                name: "IX_TableOrders_OrderPeriodId",
                table: "TableOrders");

            migrationBuilder.DropColumn(
                name: "OrderPeriodId",
                table: "TableOrders");
        }
    }
}
