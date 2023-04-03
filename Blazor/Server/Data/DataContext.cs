namespace Blazor.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }

        //一个数据表Table的上下文
        public DbSet<Product> Products { get; set; }
    }
}
