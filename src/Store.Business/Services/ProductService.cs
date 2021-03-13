using AutoMapper;
using Store.Business.Interfaces;
using Store.Business.ViewModels;
using Store.Data.Models;
using Store.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Business.Services
{
    public class ProductService : Service<ProductViewModel, Product>, IProductService
    {
        protected readonly IProductRepository repository;

        public ProductService(IProductRepository repository, IMapper mapper) : base(repository, mapper)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<ProductViewModel>> GetProductsBySupplier(Guid supplierId)
        {
            return _mapper.Map<IEnumerable<ProductViewModel>>(await repository.GetProductsBySupplier(supplierId));
        }

        public async Task<IEnumerable<ProductViewModel>> GetProductsWithSupplier()
        {
            return _mapper.Map<IEnumerable<ProductViewModel>>(await repository.GetProductsWithSupplier());
        }

        public async Task<ProductViewModel> GetProductWithSupplier(Guid id)
        {
            return _mapper.Map<ProductViewModel>(await repository.GetProductWithSupplier(id));
        }
    }
}
