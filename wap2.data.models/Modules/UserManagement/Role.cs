using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using intCoders.Common.Models;

namespace wap2.data.models.Modules.UserManagement
{
    public class Role : BaseModel
    {
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }

        public ICollection<RolePermission> RolePermissions { get; set; }
    }
}
