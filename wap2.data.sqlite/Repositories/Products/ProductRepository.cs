using intCoders.data.common.Repositories;
using Microsoft.EntityFrameworkCore;
using wap2.data.models.Modules.Products;

namespace wap2.data.sqlite.Repositories.Products;

public class ProductRepository : SqLiteRepository<Product>
{
    public ProductRepository(DbContext context) : base (context){}   
}