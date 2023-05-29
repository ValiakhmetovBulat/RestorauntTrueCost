using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RestorauntTrueCost.Server.Migrations
{
    /// <inheritdoc />
    public partial class addedcarts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderToPositions_Carts_CartId",
                table: "OrderToPositions");

            migrationBuilder.DropIndex(
                name: "IX_OrderToPositions_CartId",
                table: "OrderToPositions");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "OrderToPositions");

            migrationBuilder.DropColumn(
                name: "IsClosed",
                table: "Carts");

            migrationBuilder.CreateTable(
                name: "CartToPositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CartId = table.Column<int>(type: "integer", nullable: false),
                    PositionId = table.Column<int>(type: "integer", nullable: false),
                    MenuPositionId = table.Column<int>(type: "integer", nullable: true),
                    Count = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartToPositions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartToPositions_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartToPositions_MenuPositions_MenuPositionId",
                        column: x => x.MenuPositionId,
                        principalTable: "MenuPositions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartToPositions_CartId",
                table: "CartToPositions",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartToPositions_MenuPositionId",
                table: "CartToPositions",
                column: "MenuPositionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartToPositions");

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "OrderToPositions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsClosed",
                table: "Carts",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_OrderToPositions_CartId",
                table: "OrderToPositions",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderToPositions_Carts_CartId",
                table: "OrderToPositions",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
