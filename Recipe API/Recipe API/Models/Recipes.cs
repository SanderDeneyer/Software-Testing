using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipe_API.Models
{
    public class Recipes
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Time { get; set; }

        public Dificulty Dificulty { get; set; }

        public int CategoryId { get; set; }

    }

    public enum Dificulty
    {
        Easy, Intermediate, Advanced
    }
}
