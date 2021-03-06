using Microsoft.EntityFrameworkCore;
using Store.Data.Models;
using Store.DataAccess.Context;
using Store.DataAccess.Repositories.Interfaces;
using System;
using System.Threading.Tasks;

namespace Store.DataAccess.Repositories
{
    public class AddressesRepository : Repository<Address>, IAddressRepository
    {
        public AddressesRepository(StoreContext context) : base(context)
        {
        }

        public async Task<Address> GetAddressBySupplier(Guid supplierId)
        {
            return await db.AsNoTracking()
                           .Include(s => s.Supplier)
                           .FirstOrDefaultAsync(s => s.SupplierId == supplierId);
        }
    }
}
