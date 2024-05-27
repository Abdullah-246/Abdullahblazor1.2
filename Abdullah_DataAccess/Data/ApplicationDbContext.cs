using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tangy_DataAccess;

namespace Abdullah_DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public virtual DbSet<ProductPrice1> ProductPrices { get; set; } = default;

        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = default;
        public virtual DbSet<OrderHeader> OrderHeaders { get; set; } = default;
        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; } = default;

    }
}
