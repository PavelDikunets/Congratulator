using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Congratulator.Db.Migrations
{
    /// <inheritdoc />
    public partial class AddTestPersons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Persons",
                newName: "SocialStatus");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Persons",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "BirthDate", "FirstName", "LastName", "SocialStatus" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "TestUser1", "testUser1", 1 },
                    { 2, new DateTime(1987, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "TestUser2", "testUser2", 2 },
                    { 3, new DateTime(1989, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "TestUser3", "testUser3", 0 },
                    { 4, new DateTime(1997, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "TestUser4", "testUser4", 2 },
                    { 5, new DateTime(1999, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "TestUser5", "testUser5", 1 },
                    { 6, new DateTime(1991, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "TestUser6", "testUser6", 0 },
                    { 7, new DateTime(2000, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "TestUser7", "testUser7", 1 },
                    { 8, new DateTime(1985, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "TestUser8", "testUser8", 2 },
                    { 9, new DateTime(1995, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "TestUser9", "testUser9", 1 },
                    { 10, new DateTime(1986, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "TestUser10", "testUser10", 1 },
                    { 11, new DateTime(2001, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "TestUser11", "testUser11", 0 },
                    { 12, new DateTime(1985, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "TestUser12", "testUser12", 1 },
                    { 13, new DateTime(2003, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "TestUser13", "testUser13", 2 },
                    { 14, new DateTime(1992, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "TestUser14", "testUser14", 0 },
                    { 15, new DateTime(1992, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "TestUser15", "testUser15", 1 },
                    { 16, new DateTime(1983, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "TestUser16", "testUser16", 2 },
                    { 17, new DateTime(1997, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "TestUser17", "testUser17", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.RenameColumn(
                name: "SocialStatus",
                table: "Persons",
                newName: "Status");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Persons",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");
        }
    }
}
