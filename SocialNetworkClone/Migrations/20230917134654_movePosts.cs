using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialNetworkClone.Migrations
{
    /// <inheritdoc />
    public partial class movePosts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TextContent", "UserId" },
                values: new object[] { "Це пост користувача 5", 5 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TextContent", "UserId" },
                values: new object[] { "Це пост користувача 5", 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2023, 9, 17, 16, 46, 54, 813, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2023, 9, 17, 16, 46, 54, 813, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2023, 9, 17, 16, 46, 54, 813, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2023, 9, 17, 16, 46, 54, 813, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2023, 9, 17, 16, 46, 54, 813, DateTimeKind.Local).AddTicks(8147));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TextContent", "UserId" },
                values: new object[] { "Це пост користувача 1", 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TextContent", "UserId" },
                values: new object[] { "Це пост користувача 2", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2023, 9, 17, 16, 38, 39, 378, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2023, 9, 17, 16, 38, 39, 378, DateTimeKind.Local).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2023, 9, 17, 16, 38, 39, 378, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2023, 9, 17, 16, 38, 39, 378, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2023, 9, 17, 16, 38, 39, 378, DateTimeKind.Local).AddTicks(1626));
        }
    }
}
