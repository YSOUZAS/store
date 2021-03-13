using Microsoft.AspNetCore.Mvc;
using Store.Business.Interfaces;
using Store.Business.ViewModels;
using System;
using System.Threading.Tasks;

namespace Store.App.Controllers
{
    public class ProductsController : BaseController<ProductViewModel>
    {
        private readonly IProductService _service;
        private readonly ISupplierService _supplierService;

        public ProductsController(IProductService service, ISupplierService supplierService) : base(service)
        {
            _service = service;
            _supplierService = supplierService;
        }

        public override async Task<IActionResult> Index()
        {
            return View(await _service.GetProductsWithSupplier());
        }

        public override async Task<IActionResult> Create()
        {
            var viewModel = new ProductViewModel { Suppliers = await _supplierService.GetAll() };

            return View(viewModel);
        }

        public override async Task<IActionResult> Edit(Guid id)
        {
            var viewModel = await _service.GetById(id);

            if (viewModel == null)
            {
                return NotFound();
            }

            viewModel.Suppliers = await _supplierService.GetAll();

            return View(viewModel);
        }

    }
}



