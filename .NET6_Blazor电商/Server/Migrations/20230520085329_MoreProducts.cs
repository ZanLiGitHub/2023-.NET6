using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blazor.Server.Migrations
{
    /// <inheritdoc />
    public partial class MoreProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { 4, "RPG", "RPGs" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 4, 2, "A variety of Sims are yours to personalize, each with distinct appearances, dynamic personalities, and inspiring aspirations.", "https://m.media-amazon.com/images/I/71otyq1xFNL._AC_SY500_.jpg", 9.9m, "Sims4" },
                    { 5, 2, "Originally created by legendary game designer Sid Meier, Civilization is a turn-based strategy game in which you attempt to build an empire to stand the test of time. Explore a new land, research technology, conquer your enemies, and go head-to-head with history’s most renowned leaders as you attempt to build the greatest civilization the world has ever known.", "https://image.api.playstation.com/vulcan/img/cfn/11307KFcs3gBlcheONy-ZOYZ5kplFnq5jXinUSI8HkCc8P2gdI1_32JrKJ-vxns32LjXBcQteG2EOwuzWS_KXqE5VCYFmS4Z.png", 9.9m, "Civilization6" },
                    { 6, 4, "Bethesda Game Studios' blockbuster open-world RPG puts players on the precipice of determining the future of Skyrim as the Empire waits for the prophesized Dragonborn to come; a hero born with the power of The Voice, and the only one who can stand amongst the dragons.", "https://assets-prd.ignimgs.com/2021/08/19/elder-scrolls-skyrim-button-2017-1629409446732.jpg", 9.9m, "The Elder Scrolls 5: Skyrim" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
