using Store.Data.Models;
using System;
using System.Threading.Tasks;

namespace Store.DataAccess.Repositories.Interfaces
{
    public interface ISupplierRepository : IRepository<Supplier>
    {
        Task<Supplier> GetSupplierAddress(Guid id);
        Task<Supplier> GetSupplierProductsAddress(Guid id);
    }
}
