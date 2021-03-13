using Store.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.DataAccess.Repositories.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductsBySupplier(Guid supplierId);
        Task<IEnumerable<Product>> GetProductsWithSupplier();
        Task<Product> GetProductWithSupplier(Guid id);
    }
}