using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AgricultureSite.App.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly IContactService _contactService;

        public HomeController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }
        
        [HttpPost]
        public IActionResult SendMessage(Contact contact)
        {
            contact.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            _contactService.Insert(contact);
            return RedirectToAction("Index","Home");
        }

        public PartialViewResult Scripts()
        {
            return PartialView();
        }
    }
}
