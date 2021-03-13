using Store.Business.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Business.Interfaces
{
    public interface IProductService : IService<ProductViewModel>
    {
        Task<IEnumerable<ProductViewModel>> GetProductsBySupplier(Guid supplierId);
        Task<IEnumerable<ProductViewModel>> GetProductsWithSupplier();
        Task<ProductViewModel> GetProductWithSupplier(Guid id);
    }
}
