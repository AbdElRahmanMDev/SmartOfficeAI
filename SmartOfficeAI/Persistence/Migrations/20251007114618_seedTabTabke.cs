using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartOfficeAI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class seedTabTabke : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 11, 46, 17, 621, DateTimeKind.Utc).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 11, 46, 17, 621, DateTimeKind.Utc).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 11, 46, 17, 621, DateTimeKind.Utc).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 11, 46, 17, 621, DateTimeKind.Utc).AddTicks(7919));

            migrationBuilder.InsertData(
                table: "Tabs",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Purpose", "TabDescription", "TabNameAR", "TabNameEN", "UpdatedDate", "VisibleTo" },
                values: new object[,]
                {
                    { new Guid("1d8239c9-76a4-4f73-a49e-087799cfd506"), new DateTime(2025, 10, 7, 11, 46, 17, 623, DateTimeKind.Utc).AddTicks(6706), false, "Official correspondence automation", "", "إدارة المعاملات", "Document Workflow", null, "Admin Comms only" },
                    { new Guid("23db5a92-63f0-4f42-b5e0-64e6b1a52e6f"), new DateTime(2025, 10, 7, 11, 46, 17, 623, DateTimeKind.Utc).AddTicks(6692), false, "AI-powered file management", "", "المرفقات والأرشفة", "Attachments", null, "All users" },
                    { new Guid("6c0e4a4b-1cf8-4626-9358-4cf0ee1a5a36"), new DateTime(2025, 10, 7, 11, 46, 17, 623, DateTimeKind.Utc).AddTicks(6701), false, "Performance metrics & insights", "", "التقارير والإحصائيات", "Analytics & Reports", null, "All users (role-specific)" },
                    { new Guid("6f67e59c-04b5-4584-8a6d-b8cb3ac92f29"), new DateTime(2025, 10, 7, 11, 46, 17, 623, DateTimeKind.Utc).AddTicks(6667), false, "Smart email management", "", "صندوق الوارد", "Inbox", null, "All users" },
                    { new Guid("cbdc2d0f-0d5e-4f1c-9b89-1a9d6c2a3e41"), new DateTime(2025, 10, 7, 11, 46, 17, 623, DateTimeKind.Utc).AddTicks(6652), false, "User persona & preferences", "", "الملف الشخصي", "Profile", null, "All users" },
                    { new Guid("e3b6d8a2-faf8-4c82-912f-4420b4cf29a3"), new DateTime(2025, 10, 7, 11, 46, 17, 623, DateTimeKind.Utc).AddTicks(6673), false, "Draft, analyze, rephrase emails", "", "مساحة العمل", "Playground", null, "All users" },
                    { new Guid("ff4978e1-dc02-4cc0-bb27-8783c5a6a1c1"), new DateTime(2025, 10, 7, 11, 46, 17, 623, DateTimeKind.Utc).AddTicks(6697), false, "CV screening & candidate ranking", "", "قاعدة المواهب", "Talent Database", null, "HR only" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("1d8239c9-76a4-4f73-a49e-087799cfd506"));

            migrationBuilder.DeleteData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("23db5a92-63f0-4f42-b5e0-64e6b1a52e6f"));

            migrationBuilder.DeleteData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("6c0e4a4b-1cf8-4626-9358-4cf0ee1a5a36"));

            migrationBuilder.DeleteData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("6f67e59c-04b5-4584-8a6d-b8cb3ac92f29"));

            migrationBuilder.DeleteData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("cbdc2d0f-0d5e-4f1c-9b89-1a9d6c2a3e41"));

            migrationBuilder.DeleteData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("e3b6d8a2-faf8-4c82-912f-4420b4cf29a3"));

            migrationBuilder.DeleteData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("ff4978e1-dc02-4cc0-bb27-8783c5a6a1c1"));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 6, 39, 54, 481, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 6, 39, 54, 481, DateTimeKind.Utc).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 6, 39, 54, 481, DateTimeKind.Utc).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 6, 39, 54, 481, DateTimeKind.Utc).AddTicks(6341));
        }
    }
}
