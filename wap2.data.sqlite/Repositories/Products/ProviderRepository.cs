using intCoders.data.common.Repositories;
using Microsoft.EntityFrameworkCore;
using wap2.data.models.Modules.Products;

namespace wap2.data.sqlite.Repositories.Products;

public class ProviderRepository : SqLiteRepository<Provider>
{
    public ProviderRepository(DbContext context) : base(context){}
}