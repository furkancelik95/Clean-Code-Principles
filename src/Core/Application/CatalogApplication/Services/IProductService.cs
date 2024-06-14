using Catalog.Application.Features.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDisplayResponse>> GetProductsForDisplayAsync();
    }
}
