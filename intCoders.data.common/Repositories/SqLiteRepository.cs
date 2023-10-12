using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace intCoders.data.common.Repositories
{
    public abstract class SqLiteRepository<T> : IRepository<T> where T : class
    {
        protected DbContext Context;

        protected SqLiteRepository(DbContext context)
        {
            Context = context;
        }

        public IQueryable<T> GetAll()
        {
            return Context.Set<T>();
        }

        public async Task<T?> GetItem(Guid id)
        {
            return await Context.FindAsync<T>(id);
        }

        public async Task<EntityEntry<T>> SaveItem(T item)
        {
            return await Context.AddAsync(item);
        }

        public async Task<EntityEntry<T>> DeleteItem(Guid id)
        {
            var item = await GetItem(id);
            return item == null ? throw new ArgumentNullException(nameof(item)) : Context.Remove(item);
        }
    }
}