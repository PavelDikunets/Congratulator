using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Congratulator.Db.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTypeToDateTimeForBirthdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SocialStatus",
                table: "Persons",
                newName: "Status");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Persons",
                type: "date",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Persons",
                newName: "SocialStatus");

            migrationBuilder.AlterColumn<string>(
                name: "BirthDate",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);
        }
    }
}
