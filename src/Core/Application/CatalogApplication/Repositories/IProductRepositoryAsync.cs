using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Repositories
{
    public interface IProductRepositoryAsync : IRepositoryAsync<Product>
    {
        public Task<IEnumerable<Product>> SearchByName();
    }
}
