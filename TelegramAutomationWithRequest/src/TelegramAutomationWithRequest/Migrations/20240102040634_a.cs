using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TelegramAutomationWithRequest.Migrations
{
    /// <inheritdoc />
    public partial class a : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RecoveryEmail",
                table: "Accounts",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Accounts",
                newName: "Session");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Accounts",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "DateCreate",
                table: "Accounts",
                newName: "Note");

            migrationBuilder.RenameColumn(
                name: "Backup",
                table: "Accounts",
                newName: "FullName");

            migrationBuilder.AddColumn<string>(
                name: "AppHash",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppId",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppHash",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "AppId",
                table: "Accounts");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Accounts",
                newName: "RecoveryEmail");

            migrationBuilder.RenameColumn(
                name: "Session",
                table: "Accounts",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Accounts",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "Note",
                table: "Accounts",
                newName: "DateCreate");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Accounts",
                newName: "Backup");
        }
    }
}
