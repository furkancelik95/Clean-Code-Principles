using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Data
{
    public class CatalogDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public CatalogDBContext(DbContextOptions<CatalogDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Ürün A",
                Price = 1,
                Description = "Test",
                ImageUrl = "test"
            }, new Product
            {
                Id = 2,
                Name = "Ürün B",
                Price = 1,
                Description = "Test",
                ImageUrl = "test"
            }, new Product
            {
                Id = 3,
                Name = "Ürün C",
                Price = 1,
                Description = "Test",
                ImageUrl = "test"
            });

        }
    }
}
