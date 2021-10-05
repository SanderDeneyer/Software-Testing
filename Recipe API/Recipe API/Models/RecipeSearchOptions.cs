using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipe_API.Models
{
    public class RecipeSearchOptions
    {
        public string titel { get; set; }

        public int? time { get; set; }

        public int? difficulty { get; set; }

        public List<int> categories { get; set; }
    }


}
