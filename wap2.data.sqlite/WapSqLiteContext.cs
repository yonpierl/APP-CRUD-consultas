using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using wap2.data.models.Modules.Config;
using wap2.data.models.Modules.Customers;
using wap2.data.models.Modules.Products;
using wap2.data.models.Modules.UserManagement;
using wap2.data.models.Modules.Vehicles;
using wap2.data.sqlite.Models.UserManagment;
using static System.Net.Mime.MediaTypeNames;

namespace wap2.data.sqlite
{
    public class WapSqLiteContext : DbContext
    {
        public string DbPath { get; }
        public WapSqLiteContext()
        {

            var folder = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            
            DbPath = System.IO.Path.Join(folder, "wap2.db");
        }
        public WapSqLiteContext(DbContextOptions<WapSqLiteContext> options) : base(options) { }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Segment> Segment { get; set; }
        public virtual DbSet<Company> Companies { get; set; }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductOEMCode> ProductOemCodes { get; set; }
        public virtual DbSet<ProductExchangeCode> ProductExchangeCodes { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<ProductCar> ProductCars { get; set; }

        public virtual DbSet<Car> Cars { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath};");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            UserBuilder.OnModelCreating(modelBuilder);
            RolePermissionBuilder.OnModelCreating(modelBuilder);

            base.OnModelCreating(modelBuilder);
            
        }
    }
}
