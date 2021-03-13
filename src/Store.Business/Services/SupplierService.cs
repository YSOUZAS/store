using AutoMapper;
using Store.Business.Interfaces;
using Store.Business.ViewModels;
using Store.Data.Models;
using Store.DataAccess.Repositories.Interfaces;
using System;
using System.Threading.Tasks;

namespace Store.Business.Services
{
    public class SupplierService : Service<SupplierViewModel, Supplier>, ISupplierService
    {
        protected readonly ISupplierRepository repository;

        public SupplierService(ISupplierRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public async Task<SupplierViewModel> GetSupplierAddress(Guid id)
        {
            return _mapper.Map<SupplierViewModel>(await repository.GetSupplierAddress(id));
        }

        public async Task<SupplierViewModel> GetSupplierProductsAddress(Guid id)
        {
            return _mapper.Map<SupplierViewModel>(await repository.GetSupplierProductsAddress(id));
        }
    }
}
