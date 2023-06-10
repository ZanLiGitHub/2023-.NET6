using Blazor.Server.Data;
using Blazor.Shared;
using Microsoft.EntityFrameworkCore;

namespace Blazor.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context; 
        }

        public async Task<ServiceResponse<List<Product>>> GetProductAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int Id)
        {
            var response = new ServiceResponse<Product>
            {
                Data = await _context.Products.FindAsync(Id)
            };

            if(response.Data == null) 
            { 
                response.Success = false;
                response.Message = "Product does not exist";
            }

            return response;
        }
    }
}
