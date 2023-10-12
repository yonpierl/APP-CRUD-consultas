using intCoders.data.common.Repositories;
using Microsoft.EntityFrameworkCore;

namespace wap2.data.sqlite.Repositories.Customer;

public class CustomerRepository: SqLiteRepository<models.Modules.Customers.Customer>
{
    public CustomerRepository(DbContext context) : base(context) { }
}