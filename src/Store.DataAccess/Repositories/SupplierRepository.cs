using Microsoft.EntityFrameworkCore;
using Store.Data.Models;
using Store.DataAccess.Context;
using Store.DataAccess.Repositories.Interfaces;
using System;
using System.Threading.Tasks;

namespace Store.DataAccess.Repositories
{
    public class SupplierRepository : Repository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(StoreContext context) : base(context)
        {
        }

        public async Task<Supplier> GetSupplierAddress(Guid id)
        {
            return await db.AsNoTracking()
                           .Include(s => s.Address)
                           .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<Supplier> GetSupplierProductsAddress(Guid id)
        {
            return await db.AsNoTracking()
                           .Include(s => s.Address)
                           .Include(s => s.Products)
                           .FirstOrDefaultAsync(s => s.Id == id);
        }
    }
}
