using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioTracker.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddPortfolioOwner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Portfolios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_OwnerId_Name",
                table: "Portfolios",
                columns: new[] { "OwnerId", "Name" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_Users_OwnerId",
                table: "Portfolios",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_Users_OwnerId",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_OwnerId_Name",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Portfolios");
        }
    }
}
