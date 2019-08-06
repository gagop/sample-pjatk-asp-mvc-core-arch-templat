using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PjatkArchExample.Domain.Interfaces.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> Find(int id);
        IEnumerable<T> Get(Func<T, bool> wherePredicate);
        Task Add(T newElement);
        void Remove(T elementToRemove);
        void Save();
    }
}
