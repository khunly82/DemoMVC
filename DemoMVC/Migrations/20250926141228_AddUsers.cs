using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DemoMVC.Migrations
{
    /// <inheritdoc />
    public partial class AddUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "UserRole", "Username" },
                values: new object[,]
                {
                    { 1, "550e8400-e29b-41d4-a716-446655440000u5einAERS8EItqIy+rH5gVUhekOJY/cfs5aaPtoL0Zm4OqSbAYHhA7xi7nHs3eS5AGsSfQGzhfiF41g/+hQjBg==", 0, "Khun" },
                    { 2, "3f2504e0-4f89-11d3-9a0c-0305e82c3301lPBxNGlo/GMo/wuKODnhTYhppwkSWYlup+uPl9DqOF2+DGqCMhoNeGDIyO9QnxqlPbrob5TvYKYuzpQtn9KRgg==", 1, "Yass" },
                    { 3, "9a3b1c6d-7f9e-4a2f-b8e7-123456789abc7dZfR3gYtqSZsF5uZoO9PjxIfdnvuUNRrsZmy2RzJP5sYQKRPW6Uw7WgPPx1PrIes/dOmiJrnPhZhutrtA6KFA==", 2, "Laur" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Password",
                table: "Users",
                type: "varbinary(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
