using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Store.DataAccess.Context;
using Store.DataAccess.Repositories;
using Store.DataAccess.Repositories.Interfaces;

namespace Store.DataAccess.Extensions
{
    public static class ServicesExtensions
    {
        public static void AddStoreContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<StoreContext>(options =>
                   options.UseSqlServer(
                       configuration.GetConnectionString("DefaultConnection")));
        }

        public static void RegisterStoreContext(this IServiceCollection services)
        {
            services.AddScoped<StoreContext>();
        }

        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IAddressRepository, AddressesRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();
        }
    }
}
