using Store.Business.ViewModels;
using System;
using System.Threading.Tasks;

namespace Store.Business.Interfaces
{
    public interface ISupplierService : IService<SupplierViewModel>
    {
        Task<SupplierViewModel> GetSupplierAddress(Guid id);
        Task<SupplierViewModel> GetSupplierProductsAddress(Guid id);
    }
}
