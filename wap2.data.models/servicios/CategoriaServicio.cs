using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wap2.data.models.Modules.Products;

namespace wap2.data.models.servicios
{
    public class CategoriaServicio : ICategoria
    {
        public SQLiteAsyncConnection _database;

        public CategoriaServicio(string DbPath) 
        {
            _database = new SQLiteAsyncConnection(DbPath);
            
            
        }
        public async Task<bool> UpdateCategoriaAsync(Category category)
        {
            if (category.Id == Guid.Empty)
            {
                await _database.UpdateAsync(category);
            }
            else
            {
                await _database.InsertAsync(category);
            }
            return await Task.FromResult(true);
        }

        public async Task<bool> AddCategoryAsync(Category Category)
        {
            Category.Id = Guid.NewGuid();
            await _database.InsertAsync(Category);
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteCategoriaAsync(Guid Id)
        {
            await _database.DeleteAsync<Category>(Id);
            return await Task.FromResult(true);
        }

        public async Task<Category> GetCategoria(Guid Id)
        {
              throw new NotImplementedException();
        }

        public async Task<IEnumerable<Category>> GetAllCategorias()
        {
            throw new NotImplementedException();
        }
    }
}
