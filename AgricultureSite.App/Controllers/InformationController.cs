using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgricultureSite.App.Controllers
{
    public class InformationController : Controller
    {
        private readonly IInformationService _informationService;

        public InformationController(IInformationService informationService)
        {
            _informationService = informationService;
        }

        public IActionResult Index()
        {
            var values = _informationService.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddInformation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddInformation(Information information)
        {
            _informationService.Insert(information);
            //information.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            information.Status = true;
            return RedirectToAction("Index");
        }

        public IActionResult DeleteInformation(int id)
        {
            var deletedId = _informationService.GetById(id);
            _informationService.Delete(deletedId);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditInformation(int id)
        {
            var editedId = _informationService.GetById(id);
            return View(editedId);
        }

        [HttpPost]
        public IActionResult EditInformation(Information information)
        {
            //information.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            information.Status = true;
            _informationService.Update(information);
            return RedirectToAction("Index");
        }

        public IActionResult ActiveStatus(int id)
        {
            _informationService.ChangeStatusToTrue(id);
            return RedirectToAction("Index");
        }
        public IActionResult PassiveStatus(int id)
        {
            _informationService.ChangeStatusToFalse(id);
            return RedirectToAction("Index");
        }
    }
}
