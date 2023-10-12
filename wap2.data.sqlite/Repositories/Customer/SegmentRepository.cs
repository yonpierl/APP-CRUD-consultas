using intCoders.data.common.Repositories;
using Microsoft.EntityFrameworkCore;
using wap2.data.models.Modules.Customers;

namespace wap2.data.sqlite.Repositories.Customer;

public class SegmentRepository : SqLiteRepository<Segment>
{
    public SegmentRepository(DbContext context) : base(context){}
}