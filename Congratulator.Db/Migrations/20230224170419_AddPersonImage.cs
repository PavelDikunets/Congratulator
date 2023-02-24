using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Congratulator.Db.Migrations
{
    /// <inheritdoc />
    public partial class AddPersonImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageOfPersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Persons_ImageOfPersonId",
                        column: x => x.ImageOfPersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "ImageOfPersonId", "ImagePath" },
                values: new object[,]
                {
                    { 1, 1, "/images/avatars/default.jpg" },
                    { 2, 2, "/images/avatars/default.jpg" },
                    { 3, 3, "/images/avatars/default.jpg" },
                    { 4, 4, "/images/avatars/default.jpg" },
                    { 5, 5, "/images/avatars/default.jpg" },
                    { 6, 6, "/images/avatars/default.jpg" },
                    { 7, 7, "/images/avatars/default.jpg" },
                    { 8, 8, "/images/avatars/default.jpg" },
                    { 9, 9, "/images/avatars/default.jpg" },
                    { 10, 10, "/images/avatars/default.jpg" },
                    { 11, 11, "/images/avatars/default.jpg" },
                    { 12, 12, "/images/avatars/default.jpg" },
                    { 13, 13, "/images/avatars/default.jpg" },
                    { 14, 14, "/images/avatars/default.jpg" },
                    { 15, 15, "/images/avatars/default.jpg" },
                    { 16, 16, "/images/avatars/default.jpg" },
                    { 17, 17, "/images/avatars/default.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_ImageOfPersonId",
                table: "Images",
                column: "ImageOfPersonId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
