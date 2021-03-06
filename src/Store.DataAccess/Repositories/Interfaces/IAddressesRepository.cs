using Store.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.DataAccess.Repositories.Interfaces
{
    interface IAddressesRepository : IRepository<Address>
    {
        Task<IEnumerable<Address>> GetAddressBySupplier(Guid supplierId);
    }
}