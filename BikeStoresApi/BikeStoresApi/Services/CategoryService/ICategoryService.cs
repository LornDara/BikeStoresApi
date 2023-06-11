using BikeStoresApi.Models;

namespace BikeStoresApi.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        Category GetCategoryById(long id);
        List<Category> AddCategory(Category newCategory);
    }
}
