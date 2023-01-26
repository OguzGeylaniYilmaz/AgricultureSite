using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureSite.App.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        public IActionResult Index()
        {
            var adminList = _adminService.GetAll();
            return View(adminList);
        }
        
        [HttpGet]
        public IActionResult AddAdmin()
        {
            return View();
        } 
        
        [HttpPost]
        public IActionResult AddAdmin(Admin admin)
        {
            _adminService.Insert(admin);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditAdmin(int id)
        {
            var adminId = _adminService.GetById(id);
            return View(adminId);
        }

        [HttpPost]
        public IActionResult EditAdmin(Admin admin)
        {
            _adminService.Update(admin);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAdmin(int id)
        {
            var valueId = _adminService.GetById(id);
            _adminService.Delete(valueId);
            return RedirectToAction("Index");
        }
    }
}
