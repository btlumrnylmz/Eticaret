using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eticaret.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewsConfigurationDesc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "News",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Contacts",
                newName: "CreateDate");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "News",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(750)",
                oldMaxLength: 750,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "IsActive", "UserGuid" },
                values: new object[] { new DateTime(2025, 5, 6, 23, 18, 17, 744, DateTimeKind.Local).AddTicks(6728), false, new Guid("880293c3-f79b-4bb7-a2d8-e6079f354f18") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 5, 6, 23, 18, 17, 752, DateTimeKind.Local).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 5, 6, 23, 18, 17, 752, DateTimeKind.Local).AddTicks(8087));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "News",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Contacts",
                newName: "CreateDate");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "News",
                type: "nvarchar(750)",
                maxLength: 750,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "IsActive", "UserGuid" },
                values: new object[] { new DateTime(2025, 4, 25, 17, 16, 29, 517, DateTimeKind.Local).AddTicks(3872), true, new Guid("a08400de-7df3-452a-a950-1ea4a83eb7ca") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 4, 25, 17, 16, 29, 522, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 4, 25, 17, 16, 29, 522, DateTimeKind.Local).AddTicks(8743));
        }
    }
}
