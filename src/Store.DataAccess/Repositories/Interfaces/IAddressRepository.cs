using Store.Data.Models;
using System;
using System.Threading.Tasks;

namespace Store.DataAccess.Repositories.Interfaces
{
    public interface IAddressRepository : IRepository<Address>
    {
        Task<Address> GetAddressBySupplier(Guid supplierId);
    }
}