# Blazor Note

## Database

- Add Connection Strings: *Server/appsettings.json*:
```
"ConnectionStrings": {
    "DefaultConnection": "server=(localdb)\MSSQLLocalDB; 
                          database=blazor;
                          trusted_connection=true",
}
```

- Add Models: *Shared/Product.cs*
```
public class Product
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }
}
```

- Use Entity Framework:  
```
1. Install "Entity Framework Tool"：`dotnet tool install --global dotnet-ef`
2. Install "Microsoft.EntityFrameworkCore"
3. Install "Microsoft.EntityFrameworkCore.Design"
4. Install "Microsoft.EntityFrameworkCore.SqlServer"
5. Server/Program.cs: global using Microsoft.EntityFrameworkCore;
```

- Data Migration Commands:
```
Add migration：dotnet ef migrations add CreateInitial
Remove migration：dotnet ef migrations remove
Update database：dotnet ef database update
```

- Use Data Context
1. *Server/Data/DataContext.cs*
```
namespace Blazor.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }

        //A table in database
        public DbSet<Product> Products { get; set; }
    }
}
```

2. *Server/Program.cs*
```
global using Blazor.Server.Data;
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});  
```

- Use Controller and Service
1. **
2. *Server/Controllers/ProductController.cs*
```
namespace Blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //use datacontext
        private readonly DataContext _dataContext;
           
        public ProductController(DataContext context)
        {
            _dataContext = context;
        }

        //end point
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            var product = await _dataContext.Products.ToListAsync();
            return Ok(product);
        }
    }
}
```


## Package Manger Console

- Open Console: 
```
View -> Other Windows -> Package Manager Console
```

- Commands:  
```
change patj：cd Blazor
list：ls
install packages： dotnet tool install --global dotnet-ef
uninstall packages： dotnet tool uninstall --global dotnet-ef
clear window：cls
```


## C# Shortcuts
- Code Template:
Constructor：`ctor` + <kbd>TAB</kbd> *2   
Class Properties：`prop` + <kbd>TAB</kbd> *2


## VS2022 Shortcuts
- Start with <kbd>Ctrl</kbd>+<kbd>K</kbd> :  
Comment: <kbd>Ctrl</kbd>+<kbd>C</kbd>  
Cancel Comment: <kbd>Ctrl</kbd>+<kbd>U</kbd>  
Fomat: <kbd>Ctrl</kbd>+<kbd>D</kbd>

- Start with <kdb>Ctrl</kdb>+<kbd>0</kbd> :  
Git Repository Window: <kbd>Ctrl</kbd>+<kbd>R</kbd>  
Git Change Window: <kbd>Ctrl</kbd>+<kbd>D</kbd>