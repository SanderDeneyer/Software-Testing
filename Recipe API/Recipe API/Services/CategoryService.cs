using Recipe_API.Data;
using Recipe_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipe_API.Services
{
    public class CategoryService
    {
        private readonly ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categories> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Categories GetById(int id)
        {
            return _context.Categories.FirstOrDefault(x => x.Id == id);
        }

        public Categories GetByName(string name)
        {
            return _context.Categories.FirstOrDefault(x => x.Name == name);
        }

        public Categories Create(Categories category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();

            return category;
        }

        public void Delete(Categories category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }
    }
}
