using AutoMapper;
using Store.Business.Interfaces;
using Store.Business.ViewModels;
using Store.Data.Models;
using Store.DataAccess.Repositories.Interfaces;
using System;
using System.Threading.Tasks;

namespace Store.Business.Services
{
    public class AddressService : Service<AddressViewModel, Address>, IAddressService
    {
        protected readonly IAddressRepository repository;

        public AddressService(IAddressRepository repository, IMapper mapper) : base(repository, mapper)
        {
            this.repository = repository;
        }

        public async Task<AddressViewModel> GetAddressBySupplier(Guid supplierId)
        {
            return _mapper.Map<AddressViewModel>(await repository.GetAddressBySupplier(supplierId));
        }
    }
}
