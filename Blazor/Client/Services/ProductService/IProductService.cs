namespace Blazor.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }

        Task GetProduct();
        Task<ServiceResponse<Product>> GetProduct(int Id);
    }
}
