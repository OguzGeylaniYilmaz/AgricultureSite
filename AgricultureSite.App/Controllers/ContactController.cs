using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgricultureSite.App.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var messageList = _contactService.GetAll();
            return View(messageList);
        }

        public IActionResult MessageDetails(int id)
        {
            var messageId = _contactService.GetById(id);
            return View(messageId);
        }

        public IActionResult DeleteMessage(int id)
        {
            var messageId = _contactService.GetById(id);
            _contactService.Delete(messageId);
            return RedirectToAction("Index");
        }
    }
}
