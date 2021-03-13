using Microsoft.Extensions.DependencyInjection;
using Store.Business.Interfaces;
using Store.Business.Services;
using System;

namespace Store.Business.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureAutoMapper(this IServiceCollection services, Type startup)
        {
            services.AddAutoMapper(startup);
        }

        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<ISupplierService, SupplierService>();
        }
    }
}