﻿namespace Blazor.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category> Categories { get; set; }

        Task GetCategory();

    }
}
