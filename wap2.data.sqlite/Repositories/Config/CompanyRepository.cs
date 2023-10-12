using intCoders.data.common.Repositories;
using Microsoft.EntityFrameworkCore;
using wap2.data.models.Modules.Config;

namespace wap2.data.sqlite.Repositories.Config;

public class CompanyRepository : SqLiteRepository<Company>
{
    public CompanyRepository(DbContext context) : base(context)
    {
    }
}