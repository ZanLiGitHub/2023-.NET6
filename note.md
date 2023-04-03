# Blazor 笔记

## 数据库
- 添加Connection String:  
```
在appsettings.json中添加:
"ConnectionStrings": {
    "DefaultConnection": "server=(localdb)\MSSQLLocalDB; 
                          database=blazor;
                          trusted_connection=true",
}
```
- 床架Model
```
1. 在Shared Project中创建类Product.cs
2. public class Product
   {
       //标准类成员
       public int Id { get; set; }

       //
       public string Title { get; set; } = string.Empty;

       //指定小数点
       [Column(TypeName = "decimal(18,2)")]
       public decimal Price { get; set; }
   }
```
- Entity Framework:  
```
1. 安装entity framework：`dotnet tool install --global dotnet-ef`
2. 安装Microsoft.EntityFrameworkCore
3. 安装Microsoft.EntityFrameworkCore.Design
4. 安装Microsoft.EntityFrameworkCore.SqlServer
5. 在Project的.csproj文件中查看安装的Package
6. 在Project的Program.cs中添加 global using Microsoft.EntityFrameworkCore;
7. 在Project中创建 Data/DataContext.cs 存储数据库上下文
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
8. 在Project的Program.cs中添加 
   using Blazor.Server.Data;
   builder.Services.AddDbContext<DataContext>(options =>
   {
      options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
   });

```
- Data Migration:
```
添加迁移：dotnet ef migrations add CreateInitial
删除迁移：dotnet ef migrations remove
更新数据库：dotnet ef database update
```
	

## Package Manger Console
- 打开Console: 
```
View -> Other Windows -> Package Manager Console
```
- 指令:  
```
切换路径：cd Blazor
列出子目录：ls
安装： dotnet tool install --global dotnet-ef
卸载： dotnet tool uninstall --global dotnet-ef
清空窗口：cls
```


## C# 快捷键
- 代码模板:
构造器：`ctor` + <kbd>TAB</kbd>键两次
类成员：`prop` + <kbd>TAB</kbd>键两次


## VS2022 快捷键
- <kbd>Ctrl</kbd>+<kbd>K</kbd> 组合:  
注释: <kbd>Ctrl</kbd>+<kbd>C</kbd>  
取消注释: <kbd>Ctrl</kbd>+<kbd>U</kbd>  
格式化: <kbd>Ctrl</kbd>+<kbd>D</kbd>