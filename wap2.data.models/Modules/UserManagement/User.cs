using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wap2.data.models.Modules.UserManagement
{
    public class User : intCoders.Common.Models.User
    {
        public Guid RoleId { get; set; }
        public Role Role { get; set; } = null!;


    }
}
