using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace intCoders.data.common.Repositories
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        Task<T?> GetItem(Guid id);
        Task<EntityEntry<T>> SaveItem(T item);
        Task<EntityEntry<T>> DeleteItem(Guid id);
    }

}
