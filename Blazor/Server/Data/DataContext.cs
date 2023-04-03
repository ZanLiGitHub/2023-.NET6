namespace Blazor.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Don't Starve",
                    Description = "Don't Starve is a survival video game developed by the Canadian indie video game developer Klei Entertainment.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Don%27t_Starve_cover.jpg",
                    Price = 9.9m
                },
                new Product
                {
                    Id = 2,
                    Title = "Stardew Valley",
                    Description = "Stardew Valley is a simulation role-playing video game developed by Eric 'ConcernedApe' Barone.",
                    ImageUrl = "https://thumbnails.pcgamingwiki.com/1/1b/Stardew_Valley_cover.png/300px-Stardew_Valley_cover.png",
                    Price = 9.9m
                },
                new Product
                {
                    Id = 3,
                    Title = "Minecraft",
                    Description = "Minecraft is a sandbox game developed by Mojang Studios.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/51/Minecraft_cover.png",
                    Price = 9.9m
                }
            );
        }

        //一个数据表Table的上下文
        public DbSet<Product> Products { get; set; }
    }
}
