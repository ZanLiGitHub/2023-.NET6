using Microsoft.AspNetCore.Mvc;

namespace Blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProduct()
        {
            var result = await _productService.GetProductAsync();
            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetProduct(int Id)
        {
            var result = await _productService.GetProductAsync(Id);
            return Ok(result);
        }
    }
}
