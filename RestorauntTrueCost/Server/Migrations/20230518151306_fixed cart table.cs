using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestorauntTrueCost.Server.Migrations
{
    /// <inheritdoc />
    public partial class fixedcarttable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartToPositions_MenuPositions_MenuPositionId",
                table: "CartToPositions");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "CartToPositions");

            migrationBuilder.AlterColumn<int>(
                name: "MenuPositionId",
                table: "CartToPositions",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CartToPositions_MenuPositions_MenuPositionId",
                table: "CartToPositions",
                column: "MenuPositionId",
                principalTable: "MenuPositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartToPositions_MenuPositions_MenuPositionId",
                table: "CartToPositions");

            migrationBuilder.AlterColumn<int>(
                name: "MenuPositionId",
                table: "CartToPositions",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "CartToPositions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_CartToPositions_MenuPositions_MenuPositionId",
                table: "CartToPositions",
                column: "MenuPositionId",
                principalTable: "MenuPositions",
                principalColumn: "Id");
        }
    }
}
