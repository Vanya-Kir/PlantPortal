using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlantPortal.Migrations
{
    /// <inheritdoc />
    public partial class secontMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4f1364d7-cca9-41f4-b523-7f01e5f95c6a", null, "admin", "admin" },
                    { "b3de3ad6-3974-431a-abf3-346718ad18a9", null, "user", "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f1364d7-cca9-41f4-b523-7f01e5f95c6a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3de3ad6-3974-431a-abf3-346718ad18a9");
        }
    }
}
