using Store.Business.Interfaces;
using Store.Business.ViewModels;

namespace Store.App.Controllers
{
    public class AddressesController : BaseController<AddressViewModel>
    {
        private readonly IAddressService _service;

        public AddressesController(IAddressService service) : base(service)
        {
            _service = service;
        }

    }
}