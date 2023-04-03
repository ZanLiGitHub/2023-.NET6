# Blazor �ʼ�

## ���ݿ�
- ���Connection String:  
```
��appsettings.json�����:
"ConnectionStrings": {
    //�����ַ�������server����������database���ݿ�����trusted_connection�Ƿ�ȫ
    "DefaultConnection": "server=(localdb)\MSSQLLocalDB; 
                          database=blazor;
                          trusted_connection=true",
}
```
- ����Model
```
1. ��Shared Project�д�����Product.cs
2. public class Product
   {
       //��׼���Ա
       public int Id { get; set; }

       //
       public string Title { get; set; } = string.Empty;

       //ָ��С����
       [Column(TypeName = "decimal(18,2)")]
       public decimal Price { get; set; }
   }
```
- Entity Framework:  
```C#
1. ��װentity framework��`dotnet tool install --global dotnet-ef`
2. ��װMicrosoft.EntityFrameworkCore
3. ��װMicrosoft.EntityFrameworkCore.Design
4. ��װMicrosoft.EntityFrameworkCore.SqlServer
5. ��Project��.csproj�ļ��в鿴��װ��Package
6. ��Project��Program.cs����� global using Microsoft.EntityFrameworkCore;
7. ��Project�д��� Data/DataContext.cs �洢���ݿ�������
   namespace Blazor.Server.Data
   {
        public class DataContext : DbContext
        {
            public DataContext(DbContextOptions<DataContext> options) : base(options) 
            {
            
            }

            //һ�����ݱ�Table��������
            public DbSet<Product> Products { get; set; }
        }
    }
8. ��Project��Program.cs����� 
   using Blazor.Server.Data;
   builder.Services.AddDbContext<DataContext>(options =>
   {
      options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
   });

```
- Data Migration:
```
���Ǩ�ƣ�dotnet ef migrations add CreateInitial
ɾ��Ǩ�ƣ�dotnet ef migrations remove
�������ݿ⣺dotnet ef database update
```
	

## Package Manger Console
- �򿪣�
```
View -> Other Windows -> Package Manager Console
```
- ָ��:  
```
�л�·����cd Blazor
�г���Ŀ¼��ls
��װ�� dotnet tool install --global dotnet-ef
ж�أ� dotnet tool uninstall --global dotnet-ef
��մ��ڣ�cls
```


## C# ��ݼ�
- ����ģ��:  
��������`ctor` + <kbd>TAB</kbd>������  
���Ա��`prop` + <kbd>TAB</kbd>������ 


## VS2022 ��ݼ�
- <kbd>Ctrl</kbd>+<kbd>K</kbd> ���:  
ע�ͣ�<kbd>Ctrl</kbd>+<kbd>C</kbd>  
ȡ��ע�ͣ�<kbd>Ctrl</kbd>+<kbd>U</kbd>  
��ʽ����<kbd>Ctrl</kbd>+<kbd>D</kbd>