using Microsoft.EntityFrameworkCore;
using Store.Data.Models;

namespace Store.DataAccess.Context
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
