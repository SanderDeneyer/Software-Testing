using Microsoft.EntityFrameworkCore;
using Recipe_API.Data;
using Recipe_API.DTO;
using Recipe_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipe_API.Services
{
    public class RecipeService
    {
        private readonly ApplicationDbContext _context;
        private readonly CategoryService _categoryService;

        public RecipeService(ApplicationDbContext context)
        {
            _context = context;
        }        

        public IEnumerable<Recipes> GetAll()
        {
            return _context.Recipes.ToList();
        }

        public Recipes GetById(int id)
        {     
            return _context.Recipes.FirstOrDefault(x => x.Id == id);
        }

        public RecipeDetailsDto GetDetailsById(int id)
        {
            Recipes recipe = _context.Recipes.Where(x => x.Id == id).FirstOrDefault();
            List<Ingredient> ingredients = _context.Ingredients.Where(x => x.RecipeId == recipe.Id).ToList();
            RecipeDetailsDto recipeDetails = new RecipeDetailsDto();

            recipeDetails.Id = recipe.Id;
            recipeDetails.Title = recipe.Title;
            recipeDetails.Time = recipe.Time;
            recipeDetails.Dificulty = (int)recipe.Dificulty;
            recipeDetails.Category = _context.Categories.FirstOrDefault(x => x.Id == recipe.CategoryId).Name;
            recipeDetails.ingredients = ingredients;

            return recipeDetails;
        }

        public Recipes Create(Recipes recipe)
        {
            _context.Recipes.Add(recipe);
            _context.SaveChanges();

            return recipe;
        }

        public void Delete(Recipes recipe)
        {
            _context.Recipes.Remove(recipe);
            _context.SaveChanges();
        }

        public IEnumerable<Recipes> Search(RecipeSearchOptions searchOptions)
        {
            var recipes = _context.Recipes.AsQueryable();

            if(!string.IsNullOrEmpty(searchOptions.titel))
            {
                recipes = recipes.Where(x => x.Title.Contains(searchOptions.titel));
            }

            if (searchOptions.time != null)
            {
                recipes = recipes.Where(x => x.Time <= searchOptions.time);
            }

            if (searchOptions.categories != null)
            {
                recipes = recipes.Where(x => searchOptions.categories.Contains(x.CategoryId));
            }

            if(searchOptions.difficulty != null)
            {
                recipes = recipes.Where(x => (int)x.Dificulty <= searchOptions.difficulty);
            }

            return recipes.ToList();
        }
    }
}
