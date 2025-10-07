using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartOfficeAI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class seedDataRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2025, 10, 7, 6, 39, 54, 481, DateTimeKind.Utc).AddTicks(6310), "موظف عادي - Access: Tabs 1-4, 6 (Email management + personal productivity)", false, "Regular Employee", null },
                    { new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2025, 10, 7, 6, 39, 54, 481, DateTimeKind.Utc).AddTicks(6331), "موارد بشرية - Access: Tabs 1-6 (Full platform: Email + CV screening & recruitment)", false, "HR / Talent Acquisition", null },
                    { new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2025, 10, 7, 6, 39, 54, 481, DateTimeKind.Utc).AddTicks(6336), "موظف الاتصالات الإدارية - Access: Tabs 1-4, 6, 7 (Document Processing)", false, "Administrative Communications Officer", null },
                    { new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2025, 10, 7, 6, 39, 54, 481, DateTimeKind.Utc).AddTicks(6341), "مدير النظام - Full system access and management", false, "Admin", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));
        }
    }
}
