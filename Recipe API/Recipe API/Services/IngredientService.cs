﻿using Recipe_API.Data;
using Recipe_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipe_API.Services
{
    public class IngredientService
    {
        private readonly ApplicationDbContext _context;
        private readonly RecipeService _recipeService;

        public IngredientService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Ingredient> GetAll()
        {
            return _context.Ingredients.ToList();
        }

        public Ingredient GetById(int id)
        {
            return _context.Ingredients.FirstOrDefault(x => x.Id == id);
        }
        
        public Ingredient Create(Ingredient ingredient)
        {
            _context.Ingredients.Add(ingredient);
            _context.SaveChanges();

            return ingredient;
        }

        public Ingredient Update(int id, Ingredient ingredient)
        {
            Ingredient toUpdate = _context.Ingredients.Find(id);
            if (toUpdate == null)
            {
                return null;
            }
            toUpdate.Name = ingredient.Name;
            toUpdate.Quantity = ingredient.Quantity ;
            toUpdate.RecipeId = ingredient.RecipeId;
            toUpdate.Unit = ingredient.Unit;
            _context.SaveChanges();
            return toUpdate;
        }

        public void Delete(Ingredient ingredient)
        {
            _context.Ingredients.Remove(ingredient);
            _context.SaveChanges();
        }        
    }
}

