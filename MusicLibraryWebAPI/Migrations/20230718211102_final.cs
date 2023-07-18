using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MusicLibraryWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Album", "Artist", "Genre", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 28, "Sea Change", "Hello Moto", "Crunk", new DateTime(2023, 7, 18, 15, 11, 2, 651, DateTimeKind.Local).AddTicks(9780), "Across The Way" },
                    { 25, "World's Apart", "Journey", "rock", new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), "Promise Broken" },
                    { 27, "Sea Change", "Beck", "Alternative", new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), "Paper Tiger" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
