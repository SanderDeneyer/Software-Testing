using Microsoft.EntityFrameworkCore;
using Recipe_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipe_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>().HasData(
                new Categories() { Id = 1, Name = "Soepen" },
                new Categories() { Id = 2, Name = "Vegetarisch" },
                new Categories() { Id = 3, Name = "Voorgerecht" },
                new Categories() { Id = 4, Name = "Hoofdgerecht" },
                new Categories() { Id = 5, Name = "Dessert" }
                );            
        }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipes> Recipes { get; set; }
    }
}
