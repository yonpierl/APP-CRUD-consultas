using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wap2.data.models.Modules.UserManagement
{
    public class Permission
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Label { get; set; }

        public ICollection<RolePermission> RolePermissions { get; set; }
    }
}
