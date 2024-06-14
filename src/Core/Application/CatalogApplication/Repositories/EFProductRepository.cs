using Catalog.Data;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Repositories
{
    public class EFProductRepository : IProductRepositoryAsync
    {
        private readonly CatalogDBContext catalogDbContext;

        public EFProductRepository(CatalogDBContext catalogDbContext)
        {
            this.catalogDbContext = catalogDbContext;
        }

        public async Task<Product> FindAsync(int id)
        {
            return await catalogDbContext.Products.SingleOrDefaultAsync(s => s.Id == id);
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await catalogDbContext.Products.ToListAsync();
        }

        public async Task<IEnumerable<Product>> SearchByName(string name)
        {
            return await catalogDbContext.Products.Where(s => s.Name.Contains(name)).ToListAsync();
        }

        public Task<IEnumerable<Product>> SearchByName()
        {
            throw new NotImplementedException();
        }
    }
}
