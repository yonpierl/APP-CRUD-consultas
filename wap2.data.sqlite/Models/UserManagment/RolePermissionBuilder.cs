﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wap2.data.sqlite.Models.UserManagment
{
    public static class RolePermissionBuilder
    {
        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<models.Modules.UserManagement.RolePermission>(e =>
            {
                e.HasKey(f => f.Id);
                e.HasOne(f => f.Permission)
                    .WithMany(f => f.RolePermissions)
                    .HasForeignKey(f => f.PermissionId);

                e.HasOne(f => f.Role)
                    .WithMany(f => f.RolePermissions)
                    .HasForeignKey(f => f.RoleId);
            });
        }
    }
}
