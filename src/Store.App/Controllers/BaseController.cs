using Microsoft.AspNetCore.Mvc;
using Store.Business.Interfaces;
using Store.Business.ViewModels;
using System;
using System.Threading.Tasks;

namespace Store.App.Controllers
{
    public abstract class BaseController<TEntityViewModel> : Controller where TEntityViewModel : BaseViewModel
    {
        private readonly IService<TEntityViewModel> _service;

        protected BaseController(IService<TEntityViewModel> service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> Index()
        {
            return View(await _service.GetAll());
        }

        public virtual async Task<IActionResult> Details(Guid id)
        {
            var viewModel = await _service.GetById(id);

            if (viewModel == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }

        public virtual async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual async Task<IActionResult> Create(TEntityViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            await _service.Add(viewModel);
            return RedirectToAction(nameof(Index));
        }

        public virtual async Task<IActionResult> Edit(Guid id)
        {
            var viewModel = await _service.GetById(id);

            if (viewModel == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual async Task<IActionResult> Edit(Guid id, TEntityViewModel viewModel)
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

        public virtual async Task<IActionResult> Delete(Guid id)
        {
            var viewModel = await _service.GetById(id);

            if (viewModel == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public virtual async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var viewModel = await _service.GetById(id);

            if (viewModel == null)
            {
                return NotFound();
            }

            await _service.Remove(id);

            return RedirectToAction(nameof(Index));
        }

    }
}
