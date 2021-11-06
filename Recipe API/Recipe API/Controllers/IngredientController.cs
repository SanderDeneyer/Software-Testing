using Microsoft.AspNetCore.Mvc;
using Recipe_API.Models;
using Recipe_API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Recipe_API.Controllers
{
    [Route("api/ingredient")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private readonly IngredientService _ingredientService;

        public IngredientController(IngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }

        [HttpGet("")]
        public ActionResult<IEnumerable<Ingredient>> GetAllIngredients()
        {
            return _ingredientService.GetAll().ToList();
        }
        
        [HttpGet("{id}")]
        public ActionResult<Ingredient> GetIngredient(int id)
        {
            var ingredient = _ingredientService.GetById(id);

            if (ingredient == null)
            {
                return NotFound();
            }

            return ingredient;
        }

        [HttpPost("")]
        public ActionResult<Ingredient> CreateIngredient(Ingredient ingredient)
        {
            Ingredient created = _ingredientService.Create(ingredient);

            return CreatedAtAction(nameof(GetIngredient), new { id = created.Id }, created);
        }        

        [HttpDelete("{id}")]
        public ActionResult<Ingredient> DeleteIngredient(int id)
        {
            Ingredient ingredient = _ingredientService.GetById(id);

            if (ingredient == null)
            {
                return NotFound();
            }

            _ingredientService.Delete(ingredient);

            return NoContent();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateRecipe(int id, Ingredient updated)
        {
            if (id != updated.RecipeId)
            {
                return BadRequest();
            }
            Ingredient ingredient = _ingredientService.Update(id, updated);
            if (ingredient == null)
            {
                return NotFound();
            }

            return CreatedAtAction(nameof(GetIngredient), new { id = ingredient.Id }, ingredient);
        }
    }
}
