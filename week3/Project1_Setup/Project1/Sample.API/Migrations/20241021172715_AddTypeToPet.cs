using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sample.API.Migrations
{
    /// <inheritdoc />
    public partial class AddTypeToPet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Pets");
        }
    }
}
