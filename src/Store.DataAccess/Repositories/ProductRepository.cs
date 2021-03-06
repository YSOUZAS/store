using Microsoft.EntityFrameworkCore;
using Store.Data.Models;
using Store.DataAccess.Context;
using Store.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.DataAccess.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(StoreContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Product>> GetProductsBySupplier(Guid supplierId)
        {
            return await Find(p => p.SupplierId == supplierId);
        }

        public async Task<IEnumerable<Product>> GetProductsWithSuppliers()
        {
            return await db.AsNoTracking()
                           .Include(p => p.Supplier)
                           .ToListAsync();
        }

        public async Task<Product> GetProductWithSupplier(Guid id)
        {
            return await db.AsNoTracking()
                           .Include(p => p.Supplier)
                           .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
