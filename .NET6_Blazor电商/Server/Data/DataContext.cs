using Blazor.Shared;
using Microsoft.EntityFrameworkCore;

namespace Blazor.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "SandBox",
                    Url = "sandboxs"
                },
                new Category
                {
                    Id = 2,
                    Name = "Simulation",
                    Url = "simulations"
                },
                new Category
                {
                    Id = 3,
                    Name = "Survival",
                    Url = "survivals"
                },
                new Category
                {
                    Id = 4,
                    Name = "RPG",
                    Url = "RPGs"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Don't Starve",
                    Description = "Don't Starve is a survival video game developed by the Canadian indie video game developer Klei Entertainment.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Don%27t_Starve_cover.jpg",
                    Price = 9.9m,
                    CategoryId = 3,
                },
                new Product
                {
                    Id = 2,
                    Title = "Stardew Valley",
                    Description = "Stardew Valley is a simulation role-playing video game developed by Eric 'ConcernedApe' Barone.",
                    ImageUrl = "https://thumbnails.pcgamingwiki.com/1/1b/Stardew_Valley_cover.png/300px-Stardew_Valley_cover.png",
                    Price = 9.9m,
                    CategoryId = 2,
                },
                new Product
                {
                    Id = 3,
                    Title = "Minecraft",
                    Description = "Minecraft is a sandbox game developed by Mojang Studios.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/51/Minecraft_cover.png",
                    Price = 9.9m,
                    CategoryId = 1,
                },
                new Product
                {
                    Id = 4,
                    Title = "Sims4",
                    Description = "A variety of Sims are yours to personalize, each with distinct appearances, dynamic personalities, and inspiring aspirations.",
                    ImageUrl = "https://m.media-amazon.com/images/I/71otyq1xFNL._AC_SY500_.jpg",
                    Price = 9.9m,
                    CategoryId = 2,
                },
                new Product
                {
                    Id = 5,
                    Title = "Civilization6",
                    Description = "Originally created by legendary game designer Sid Meier, Civilization is a turn-based strategy game in which you attempt to build an empire to stand the test of time. Explore a new land, research technology, conquer your enemies, and go head-to-head with history’s most renowned leaders as you attempt to build the greatest civilization the world has ever known.",
                    ImageUrl = "https://image.api.playstation.com/vulcan/img/cfn/11307KFcs3gBlcheONy-ZOYZ5kplFnq5jXinUSI8HkCc8P2gdI1_32JrKJ-vxns32LjXBcQteG2EOwuzWS_KXqE5VCYFmS4Z.png",
                    Price = 9.9m,
                    CategoryId = 2,
                },
                new Product
                {
                    Id = 6,
                    Title = "The Elder Scrolls 5: Skyrim",
                    Description = "Bethesda Game Studios' blockbuster open-world RPG puts players on the precipice of determining the future of Skyrim as the Empire waits for the prophesized Dragonborn to come; a hero born with the power of The Voice, and the only one who can stand amongst the dragons.",
                    ImageUrl = "https://assets-prd.ignimgs.com/2021/08/19/elder-scrolls-skyrim-button-2017-1629409446732.jpg",
                    Price = 9.9m,
                    CategoryId = 4,
                }
            );
        }

        //一个数据表Table的上下文
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
