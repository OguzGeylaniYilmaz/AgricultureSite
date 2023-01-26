using AgricultureSite.App.Models;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgricultureSite.App.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IService _service;

        public ServiceController(IService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var services = _service.GetAll();
            return View(services);
        }

        [HttpGet]
        public IActionResult AddService()
        {
            return View(new AddServiceViewModel());
        }

        [HttpPost]
        public IActionResult AddService(AddServiceViewModel model)
        {
            if (ModelState.IsValid)
            {
                _service.Insert(new Service()
                {
                    Title = model.Title,
                    Description = model.Description,
                    Image = model.Image
                }); 
                return RedirectToAction("Index");
            }
            return View(model);          
        }

        public IActionResult DeleteService(int id)
        {
            var deletedServiceId = _service.GetById(id);
            _service.Delete(deletedServiceId);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditService(int id)
        {
            var serviceId = _service.GetById(id);
            return View(serviceId);
        }

        [HttpPost]
        public IActionResult EditService(Service service)
        {
            _service.Insert(service);
            return RedirectToAction("Index");
        }
    }
}
