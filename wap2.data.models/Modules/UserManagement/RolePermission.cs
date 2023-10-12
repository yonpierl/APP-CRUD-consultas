using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wap2.data.models.Modules.UserManagement
{
    public class RolePermission
    {
        public long Id { get; set; }
        public int PermissionId { get; set; }
        public Guid RoleId { get; set; }

        public Permission Permission { get; set; }
        public Role Role { get; set; }
    }
}
