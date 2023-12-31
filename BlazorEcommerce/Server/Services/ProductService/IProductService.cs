﻿using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync(int? categoryId);
        Task<ServiceResponse<Product>> GetProductAsync(int productId);
    }
}
