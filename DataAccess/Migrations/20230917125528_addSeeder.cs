using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Users",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "TextContent",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ImageLink",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthdayDate", "Email", "FirstName", "LastName", "NickName", "Password", "RegistrationDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@example.com", "Ім'я1", "Прізвище1", "user1", "hashed_password1", new DateTime(2023, 9, 17, 15, 55, 28, 483, DateTimeKind.Local).AddTicks(7999) },
                    { 2, new DateTime(1995, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@example.com", "Ім'я2", "Прізвище2", "user2", "hashed_password2", new DateTime(2023, 9, 17, 15, 55, 28, 483, DateTimeKind.Local).AddTicks(8177) }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "ImageLink", "TextContent", "UserId" },
                values: new object[,]
                {
                    { 1, "image1.jpg", "Це перший пост користувача 1", 1 },
                    { 2, "image2.jpg", "Це перший пост користувача 2", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "id");

            migrationBuilder.AlterColumn<int>(
                name: "TextContent",
                table: "Posts",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ImageLink",
                table: "Posts",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
