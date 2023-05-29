using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RestorauntTrueCost.Server.Migrations
{
    /// <inheritdoc />
    public partial class changedcartlogic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartToPositions_Carts_CartId",
                table: "CartToPositions");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.RenameColumn(
                name: "CartId",
                table: "CartToPositions",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_CartToPositions_CartId",
                table: "CartToPositions",
                newName: "IX_CartToPositions_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartToPositions_Users_UserId",
                table: "CartToPositions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartToPositions_Users_UserId",
                table: "CartToPositions");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "CartToPositions",
                newName: "CartId");

            migrationBuilder.RenameIndex(
                name: "IX_CartToPositions_UserId",
                table: "CartToPositions",
                newName: "IX_CartToPositions_CartId");

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartToPositions_Carts_CartId",
                table: "CartToPositions",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
