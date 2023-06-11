using BikeStoresApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BikecycleApi.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class CategoryController : ControllerBase
    {
        private static List<Category> categories = new List<Category>
        {
            _categoryService = categoryService;
        }
        [HttpGet("GetAll")]
        public ActionResult<List<Category>> Get()
        {
            return Ok(_categoryService.GetCategories());
        }
        [HttpGet("{Id}")]
        public ActionResult<Category> GetById(long id)
        {
            return Ok(_categoryService.GetCategoryById(id));
        }
        [HttpPost]
        public ActionResult<Category> AddCategory(Category newCategory)
        {
            return Ok(_categoryService.AddCategory(newCategory));
        }
    }
}
