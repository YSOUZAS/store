using Store.Business.ViewModels;
using System;
using System.Threading.Tasks;

namespace Store.Business.Interfaces
{
    public interface IAddressService : IService<AddressViewModel>
    {
        Task<AddressViewModel> GetAddressBySupplier(Guid supplierId);
    }
}
