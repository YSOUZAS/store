using Microsoft.Extensions.DependencyInjection;
using System;

namespace Store.Business
{
    public static class ServicesExtensions
    {
        public static void ConfigureAutoMapper(this IServiceCollection services, Type startup)
        {
            services.AddAutoMapper(startup);
        }
    }
}