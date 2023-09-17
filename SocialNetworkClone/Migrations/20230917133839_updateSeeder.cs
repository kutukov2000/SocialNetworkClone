using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SocialNetworkClone.Migrations
{
    /// <inheritdoc />
    public partial class updateSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageLink", "TextContent" },
                values: new object[] { "https://images.unsplash.com/photo-1531564701487-f238224b7ce3?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8M3x8cG9zdHxlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60", "Це пост користувача 1" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageLink", "TextContent" },
                values: new object[] { "https://images.unsplash.com/photo-1518495973542-4542c06a5843?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8cG9zdHxlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60", "Це пост користувача 2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { "Артур", "Кутуков", new DateTime(2023, 9, 17, 16, 38, 39, 378, DateTimeKind.Local).AddTicks(1484) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { "Дмитро", "Довжаниця", new DateTime(2023, 9, 17, 16, 38, 39, 378, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthdayDate", "Email", "FirstName", "LastName", "NickName", "Password", "RegistrationDate" },
                values: new object[,]
                {
                    { 3, new DateTime(1985, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3@example.com", "Микола", "Панченко", "user3", "hashed_password3", new DateTime(2023, 9, 17, 16, 38, 39, 378, DateTimeKind.Local).AddTicks(1614) },
                    { 4, new DateTime(1992, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4@example.com", "Дарина", "Мищук", "user4", "hashed_password4", new DateTime(2023, 9, 17, 16, 38, 39, 378, DateTimeKind.Local).AddTicks(1620) },
                    { 5, new DateTime(1988, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "user5@example.com", "Петро", "Павлов", "user5", "hashed_password5", new DateTime(2023, 9, 17, 16, 38, 39, 378, DateTimeKind.Local).AddTicks(1626) }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "ImageLink", "TextContent", "UserId" },
                values: new object[,]
                {
                    { 3, "https://images.unsplash.com/photo-1528717663417-3742fee05a29?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTR8fHBvc3R8ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=500&q=60", "Це пост користувача 3", 3 },
                    { 4, "https://images.unsplash.com/photo-1487700160041-babef9c3cb55?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MjB8fHBvc3R8ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=500&q=60", "Це пост користувача 4", 4 },
                    { 5, "https://images.unsplash.com/photo-1619211142200-0d30ded30ca8?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MjN8fHBvc3R8ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=500&q=60", "Це пост користувача 5", 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageLink", "TextContent" },
                values: new object[] { "image1.jpg", "Це перший пост користувача 1" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageLink", "TextContent" },
                values: new object[] { "image2.jpg", "Це перший пост користувача 2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { "Ім'я1", "Прізвище1", new DateTime(2023, 9, 17, 15, 55, 28, 483, DateTimeKind.Local).AddTicks(7999) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { "Ім'я2", "Прізвище2", new DateTime(2023, 9, 17, 15, 55, 28, 483, DateTimeKind.Local).AddTicks(8177) });
        }
    }
}
