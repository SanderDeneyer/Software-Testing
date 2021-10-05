using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipe_API.Models
{
    public class Ingredient
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Quantity { get; set; }

        public string Unit { get; set; }

        public int RecipeId { get; set; }
    }
}
