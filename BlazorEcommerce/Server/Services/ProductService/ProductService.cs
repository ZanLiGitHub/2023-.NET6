﻿using BlazorEcommerce.Server.Data;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync(int? categoryId)
        {
            var response = new ServiceResponse<List<Product>>
            { 
                Data = await _context.Products.Where(p => p.CategoryId == categoryId).ToListAsync()
            }; 

            return response;
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var response = new ServiceResponse<Product>();
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                response.Success = false;
                response.Message = "Sorry, but this product does not exist.";
            }
            else
            {
                response.Data = product;
            }

            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsByCategory(int categoryId)
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.Where(p => p.CategoryId == categoryId).ToListAsync()
            };

            return response;
        }
    }
}
