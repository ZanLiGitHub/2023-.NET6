namespace BlazorEcommerce.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _datacontext;

        public CategoryService(DataContext dataContext)
        {
            _datacontext = dataContext;
        }

        public async Task<ServiceResponse<List<Category>>> GetCategoriesAsync()
        {
            var categories = await _datacontext.Categories.ToListAsync();

            return new ServiceResponse<List<Category>>
            {
                Data = categories
            };
        }
    }
}
