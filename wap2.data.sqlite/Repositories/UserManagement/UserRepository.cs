using intCoders.data.common.Repositories;
using Microsoft.EntityFrameworkCore;
using wap2.data.models.Modules.UserManagement;

namespace wap2.data.sqlite.Repositories.UserManagement
{
    public class UserRepository : SqLiteRepository<User>
    {
        public UserRepository(DbContext context) : base(context) { }
    }
}
