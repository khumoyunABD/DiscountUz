using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiscountUzWeb.Migrations
{
    /// <inheritdoc />
    public partial class changedFavItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Like",
                table: "FavItems");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Like",
                table: "FavItems",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
