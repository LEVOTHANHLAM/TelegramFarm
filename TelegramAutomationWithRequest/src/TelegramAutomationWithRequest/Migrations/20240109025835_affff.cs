using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TelegramAutomationWithRequest.Migrations
{
    /// <inheritdoc />
    public partial class affff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cookie",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserAgent",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cookie",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "UserAgent",
                table: "Accounts");
        }
    }
}
