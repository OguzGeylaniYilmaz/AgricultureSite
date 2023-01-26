using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureSite.App.ViewComponents
{
    public class _TopAddress : ViewComponent
    {
        private readonly IAddressService _addressService;

        public _TopAddress(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public IViewComponentResult Invoke()
        {
            var addressInfo = _addressService.GetAll();
            return View(addressInfo);
        }
    }
}
