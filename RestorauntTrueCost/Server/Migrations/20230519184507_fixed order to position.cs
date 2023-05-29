using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestorauntTrueCost.Server.Migrations
{
    /// <inheritdoc />
    public partial class fixedordertoposition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderToPositions_MenuPositions_MenuPositionId",
                table: "OrderToPositions");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "OrderToPositions");

            migrationBuilder.AlterColumn<int>(
                name: "MenuPositionId",
                table: "OrderToPositions",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderToPositions_MenuPositions_MenuPositionId",
                table: "OrderToPositions",
                column: "MenuPositionId",
                principalTable: "MenuPositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderToPositions_MenuPositions_MenuPositionId",
                table: "OrderToPositions");

            migrationBuilder.AlterColumn<int>(
                name: "MenuPositionId",
                table: "OrderToPositions",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "OrderToPositions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderToPositions_MenuPositions_MenuPositionId",
                table: "OrderToPositions",
                column: "MenuPositionId",
                principalTable: "MenuPositions",
                principalColumn: "Id");
        }
    }
}
