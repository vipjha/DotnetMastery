using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPiPractices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _category;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _category = categoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            ///CategoryRepository categoryRepository = new CategoryRepository();
            ///
            List<Category> categories =  _category.GetCategories();
            return Ok(categories);
        }

       
    }
}
