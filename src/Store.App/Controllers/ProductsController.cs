using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Business.Interfaces;
using Store.Business.ViewModels;
using System;
using System.IO;
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
            var viewModel = await _service.GetProductWithSupplier(id);

            if (viewModel == null)
            {
                return NotFound();
            }

            viewModel.Suppliers = await _supplierService.GetAll();

            return View(viewModel);
        }

        public override async Task<IActionResult> Edit(Guid id, ProductViewModel viewModel)
        {
            if (id != viewModel.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            await _service.Update(viewModel);

            return RedirectToAction(nameof(Index));
        }
        public override async Task<IActionResult> Create(ProductViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var imgPrefix = $"{Guid.NewGuid()}_{DateTime.Now.ToFileTimeUtc()}_";


            if (!await UploadImage(viewModel.UploadImage, imgPrefix))
            {
                return View(viewModel);
            }

            viewModel.Image = imgPrefix + viewModel.UploadImage.FileName;

            await _service.Add(viewModel);
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> UploadImage(IFormFile file, string imagePrefix)
        {
            if (file.Length <= 0) return false;

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", imagePrefix + file.FileName);

            if (System.IO.File.Exists(path))
            {
                ModelState.AddModelError(string.Empty, "Already Exist a file with this name");
                return false;
            }

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return true;
        }

    }
}



