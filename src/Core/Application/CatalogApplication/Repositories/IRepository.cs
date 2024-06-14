using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Repositories
{
    public interface IRepository<T> where T : class, IEntity ,new()
    {
        IEnumerable<T> GetAll();
        T Find(int id);
    }
}
