using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Store.Business.ViewModels;

namespace Store.App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Store.Business.ViewModels.ProductViewModel> ProductViewModel { get; set; }
        public DbSet<Store.Business.ViewModels.AddressViewModel> AddressViewModel { get; set; }
    }
}
