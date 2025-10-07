using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartOfficeAI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "EmailMessages");

            migrationBuilder.AddColumn<Guid>(
                name: "EmailClassificationId",
                table: "EmailMessages",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EmailClassification",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailClassification", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 14, 0, 49, 784, DateTimeKind.Utc).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 14, 0, 49, 784, DateTimeKind.Utc).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 14, 0, 49, 784, DateTimeKind.Utc).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 14, 0, 49, 784, DateTimeKind.Utc).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("1d8239c9-76a4-4f73-a49e-087799cfd506"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 14, 0, 49, 786, DateTimeKind.Utc).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("23db5a92-63f0-4f42-b5e0-64e6b1a52e6f"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 14, 0, 49, 786, DateTimeKind.Utc).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("6c0e4a4b-1cf8-4626-9358-4cf0ee1a5a36"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 14, 0, 49, 786, DateTimeKind.Utc).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("6f67e59c-04b5-4584-8a6d-b8cb3ac92f29"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 14, 0, 49, 786, DateTimeKind.Utc).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("cbdc2d0f-0d5e-4f1c-9b89-1a9d6c2a3e41"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 14, 0, 49, 786, DateTimeKind.Utc).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("e3b6d8a2-faf8-4c82-912f-4420b4cf29a3"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 14, 0, 49, 786, DateTimeKind.Utc).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("ff4978e1-dc02-4cc0-bb27-8783c5a6a1c1"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 14, 0, 49, 786, DateTimeKind.Utc).AddTicks(2931));

            migrationBuilder.CreateIndex(
                name: "IX_EmailMessages_EmailClassificationId",
                table: "EmailMessages",
                column: "EmailClassificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmailMessages_EmailClassification_EmailClassificationId",
                table: "EmailMessages",
                column: "EmailClassificationId",
                principalTable: "EmailClassification",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmailMessages_EmailClassification_EmailClassificationId",
                table: "EmailMessages");

            migrationBuilder.DropTable(
                name: "EmailClassification");

            migrationBuilder.DropIndex(
                name: "IX_EmailMessages_EmailClassificationId",
                table: "EmailMessages");

            migrationBuilder.DropColumn(
                name: "EmailClassificationId",
                table: "EmailMessages");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "EmailMessages",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("1d8239c9-76a4-4f73-a49e-087799cfd506"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 11, 46, 17, 623, DateTimeKind.Utc).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("23db5a92-63f0-4f42-b5e0-64e6b1a52e6f"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 11, 46, 17, 623, DateTimeKind.Utc).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("6c0e4a4b-1cf8-4626-9358-4cf0ee1a5a36"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 11, 46, 17, 623, DateTimeKind.Utc).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("6f67e59c-04b5-4584-8a6d-b8cb3ac92f29"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 11, 46, 17, 623, DateTimeKind.Utc).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("cbdc2d0f-0d5e-4f1c-9b89-1a9d6c2a3e41"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 11, 46, 17, 623, DateTimeKind.Utc).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("e3b6d8a2-faf8-4c82-912f-4420b4cf29a3"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 11, 46, 17, 623, DateTimeKind.Utc).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("ff4978e1-dc02-4cc0-bb27-8783c5a6a1c1"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 11, 46, 17, 623, DateTimeKind.Utc).AddTicks(6697));
        }
    }
}
