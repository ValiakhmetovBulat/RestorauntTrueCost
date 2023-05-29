using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestorauntTrueCost.Server.Migrations
{
    /// <inheritdoc />
    public partial class changedorderperiodlogic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "From",
                table: "OrderPeriods");

            migrationBuilder.RenameColumn(
                name: "To",
                table: "OrderPeriods",
                newName: "FromTo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FromTo",
                table: "OrderPeriods",
                newName: "To");

            migrationBuilder.AddColumn<string>(
                name: "From",
                table: "OrderPeriods",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
