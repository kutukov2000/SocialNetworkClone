using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddAvatarImageUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AvatarImageUrl",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarImageUrl", "RegistrationDate" },
                values: new object[] { null, new DateTime(2023, 10, 1, 17, 29, 31, 225, DateTimeKind.Local).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarImageUrl", "RegistrationDate" },
                values: new object[] { null, new DateTime(2023, 10, 1, 17, 29, 31, 225, DateTimeKind.Local).AddTicks(6882) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarImageUrl", "RegistrationDate" },
                values: new object[] { null, new DateTime(2023, 10, 1, 17, 29, 31, 225, DateTimeKind.Local).AddTicks(6896) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarImageUrl", "RegistrationDate" },
                values: new object[] { null, new DateTime(2023, 10, 1, 17, 29, 31, 225, DateTimeKind.Local).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarImageUrl", "RegistrationDate" },
                values: new object[] { null, new DateTime(2023, 10, 1, 17, 29, 31, 225, DateTimeKind.Local).AddTicks(6915) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvatarImageUrl",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2023, 10, 1, 17, 26, 56, 57, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2023, 10, 1, 17, 26, 56, 57, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2023, 10, 1, 17, 26, 56, 57, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2023, 10, 1, 17, 26, 56, 57, DateTimeKind.Local).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2023, 10, 1, 17, 26, 56, 57, DateTimeKind.Local).AddTicks(7867));
        }
    }
}
