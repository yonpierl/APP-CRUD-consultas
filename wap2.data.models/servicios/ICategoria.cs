using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wap2.data.models.Modules.Products;

namespace wap2.data.models.servicios
{
    public interface ICategoria
    {
        Task<bool> UpdateCategoriaAsync(Category category);

        Task<bool> AddCategoryAsync(Category category);

        Task<bool> DeleteCategoriaAsync(Guid Id);

        Task<Category> GetCategoria(Guid Id);

        Task<IEnumerable<Category>> GetAllCategorias();

    }
}
