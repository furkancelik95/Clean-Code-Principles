using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Repositories
{
    public interface IRepositoryAsync<T> where T : class, IEntity, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> FindAsync(int id);
    }
}
