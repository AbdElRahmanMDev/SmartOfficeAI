using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartOfficeAI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddNewRealtionShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "JobDescriptionId",
                table: "Candidates",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 14, 16, 4, 236, DateTimeKind.Utc).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 14, 16, 4, 236, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 14, 16, 4, 236, DateTimeKind.Utc).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 14, 16, 4, 236, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("1d8239c9-76a4-4f73-a49e-087799cfd506"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 14, 16, 4, 238, DateTimeKind.Utc).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("23db5a92-63f0-4f42-b5e0-64e6b1a52e6f"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 14, 16, 4, 238, DateTimeKind.Utc).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("6c0e4a4b-1cf8-4626-9358-4cf0ee1a5a36"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 14, 16, 4, 238, DateTimeKind.Utc).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("6f67e59c-04b5-4584-8a6d-b8cb3ac92f29"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 14, 16, 4, 238, DateTimeKind.Utc).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("cbdc2d0f-0d5e-4f1c-9b89-1a9d6c2a3e41"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 14, 16, 4, 238, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("e3b6d8a2-faf8-4c82-912f-4420b4cf29a3"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 14, 16, 4, 238, DateTimeKind.Utc).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Tabs",
                keyColumn: "Id",
                keyValue: new Guid("ff4978e1-dc02-4cc0-bb27-8783c5a6a1c1"),
                column: "CreatedDate",
                value: new DateTime(2025, 10, 7, 14, 16, 4, 238, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_JobDescriptionId",
                table: "Candidates",
                column: "JobDescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_JobDescriptions_JobDescriptionId",
                table: "Candidates",
                column: "JobDescriptionId",
                principalTable: "JobDescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_JobDescriptions_JobDescriptionId",
                table: "Candidates");

            migrationBuilder.DropIndex(
                name: "IX_Candidates_JobDescriptionId",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "JobDescriptionId",
                table: "Candidates");

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
        }
    }
}
