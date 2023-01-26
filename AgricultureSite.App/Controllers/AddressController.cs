using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgricultureSite.App.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public IActionResult Index()
        {
            var address = _addressService.GetAll();
            return View(address);
        }

        [HttpGet]
        public IActionResult EditAddress(int id)
        {
            var addressId = _addressService.GetById(id);
            return View(addressId);
        }

        [HttpPost]
        public IActionResult EditAddress(Address address)
        {

            _addressService.Update(address);
            return RedirectToAction("Index");
        }

    }
}

