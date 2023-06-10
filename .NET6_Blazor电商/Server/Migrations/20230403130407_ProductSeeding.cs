using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blazor.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Don't Starve is a survival video game developed by the Canadian indie video game developer Klei Entertainment.", "https://upload.wikimedia.org/wikipedia/en/d/d2/Don%27t_Starve_cover.jpg", 9.9m, "Don't Starve" },
                    { 2, "Stardew Valley is a simulation role-playing video game developed by Eric 'ConcernedApe' Barone.", "https://thumbnails.pcgamingwiki.com/1/1b/Stardew_Valley_cover.png/300px-Stardew_Valley_cover.png", 9.9m, "Stardew Valley" },
                    { 3, "Minecraft is a sandbox game developed by Mojang Studios.", "https://upload.wikimedia.org/wikipedia/en/5/51/Minecraft_cover.png", 9.9m, "Minecraft" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
