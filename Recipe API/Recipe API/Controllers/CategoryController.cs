using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recipe_API.Models;
using Recipe_API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipe_API.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryService _categoryService;

        public CategoryController(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("")]
        public ActionResult<IEnumerable<Categories>> GetAllRecipes()
        {
            return _categoryService.GetAll().ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Categories> GetRecipe(int id)
        {
            var recipe = _categoryService.GetById(id);

            if (recipe == null)
            {
                return NotFound();
            }

            return recipe;
        }

        [HttpPost("")]
        public ActionResult<Categories> CreateCategory(Categories category)
        {
            Categories created = _categoryService.Create(category);

            return CreatedAtAction(nameof(GetRecipe), new { id = created.Id }, created);
        }

        [HttpDelete("{id}")]
        public ActionResult<Categories> DeleteCategory(int id)
        {
            Categories category = _categoryService.GetById(id);

            if(category == null)
            {
                return NotFound();
            }

            _categoryService.Delete(category);

            return NoContent();
        }
    }
}
