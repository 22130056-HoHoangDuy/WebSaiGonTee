using Microsoft.EntityFrameworkCore;
using SaiGonTee_Ecom.Models;
using System.Drawing;
using System.Reflection;
using Color = SaiGonTee_Ecom.Models.Color;
using Size = SaiGonTee_Ecom.Models.Size;

namespace SaiGonTee_Ecom.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<ShippingCompany> ShippingCompanies { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
    }

}
