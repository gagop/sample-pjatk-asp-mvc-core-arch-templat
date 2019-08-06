using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PjatkArchExample.Persistance.Repositories
{
    //Przykład implementacji wzorca Repository. Jest to bazowe repozytorium.
    //Możemy po nim dziedziczyć i tworzyć bardziej wyspecjalizowane repozytoria.
    public class BaseRepository<T> : IDisposable
                                     where T : class, IDisposable
    {
        private readonly DbContext _dbContext;

        public BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> Find(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public IEnumerable<T> Get(Func<T, bool> wherePredicate)
        {
            return _dbContext.Set<T>().Where(wherePredicate).ToList();
        }

        public async Task Add(T newElement)
        {
            await _dbContext.Set<T>().AddAsync(newElement);
        }

        public void Remove(T elementToRemove)
        {
            _dbContext.Set<T>().Attach(elementToRemove);
            _dbContext.Entry(elementToRemove).State = EntityState.Deleted;
        }

        public async void Save()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            if (_dbContext != null)
                _dbContext.Dispose();
        }
    }
}
