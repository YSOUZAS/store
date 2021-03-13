using Store.Business.Interfaces;
using Store.Business.ViewModels;

namespace Store.App.Controllers
{
    public class SuppliersController : BaseController<SupplierViewModel>
    {
        private readonly ISupplierService _service;

        public SuppliersController(ISupplierService service) : base(service)
        {
            _service = service;
        }

    }
}
