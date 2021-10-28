using Microsoft.AspNetCore.Mvc;
using Recipe_API.Models;
using Recipe_API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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

        [HttpGet]
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

        [HttpPost]
        public ActionResult<Ingredient> CreateIngredient(Ingredient ingredient)
        {
            Ingredient created = _ingredientService.Create(ingredient);

            return CreatedAtAction(nameof(GetIngredient), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
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
    }
}
