using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recipe_API.DTO;
using Recipe_API.Models;
using Recipe_API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipe_API.Controllers
{
    [Route("api/recipe")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly RecipeService _recipeService;

        public RecipeController(RecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Recipes>> GetAllRecipes()
        {
            return _recipeService.GetAll().ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<RecipeDetailsDto> GetRecipe(int id)
        {
            var recipe = _recipeService.GetDetailsById(id);

            if (recipe == null)
            {
                return NotFound();
            }

            return recipe;
        }

        [HttpDelete("{id}")]
        public ActionResult<Recipes> DeleteRecipe(int id)
        {
            Recipes recipe = _recipeService.GetById(id);

            if (recipe == null)
            {
                return NotFound();
            }

            _recipeService.Delete(recipe);

            return NoContent();
        }

        [HttpGet("search")]
        public ActionResult<IEnumerable<Recipes>> Search([FromQuery] RecipeSearchOptions searchOptions)
        {
            return _recipeService.Search(searchOptions).ToList();
        }        
    }
}
