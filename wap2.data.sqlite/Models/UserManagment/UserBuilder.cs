using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wap2.data.sqlite.Models.UserManagment
{
    public static class UserBuilder
    {
        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<models.Modules.UserManagement.User>(e =>
            {
                e.HasKey(f => f.Id);
                e.HasOne(f => f.Role)
                    .WithMany(f => f.Users)
                    .HasForeignKey(f => f.RoleId);
            });
        }
    }
}
