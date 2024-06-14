using Catalog.Application.Features.Responses;
using Catalog.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepositoryAsync _productAsync;

        public ProductService(IProductRepositoryAsync productAsync)
        {
            _productAsync = productAsync;
        }

        public async Task<IEnumerable<ProductDisplayResponse>> GetProductsForDisplayAsync()
        {
            var products = await _productAsync.GetAllAsync();
            return products.Select(p=> new ProductDisplayResponse
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                ImageUrl = p.ImageUrl
            });

        }
    }
}
