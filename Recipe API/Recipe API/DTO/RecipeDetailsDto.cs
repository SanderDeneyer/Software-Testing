using Recipe_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipe_API.DTO
{
    public class RecipeDetailsDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Time { get; set; }

        public int Dificulty { get; set; }

        public String Category { get; set; }

        public List<Ingredient> ingredients { get; set; }
    }
}
