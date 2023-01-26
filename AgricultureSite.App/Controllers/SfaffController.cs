using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureSite.App.Controllers
{
    public class SfaffController : Controller
    {
        private readonly IStaffService _staffService;

        public SfaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        public IActionResult Index()
        {
            var staffList = _staffService.GetAll();
            return View(staffList);
        }

        [HttpGet]
        public IActionResult AddStaff()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            StaffValidator validator = new();
            ValidationResult result = validator.Validate(staff);
            if (result.IsValid)
            {
                _staffService.Insert(staff);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();       
        }

        public IActionResult DeleteStaff(int id)
        {
            var deletedId = _staffService.GetById(id);
            return View(deletedId);
        }

        [HttpGet]
        public IActionResult EditStaff(int id)
        {
            var staffId = _staffService.GetById(id);
            return View(staffId);
        }
 
        [HttpPost]
        public IActionResult EditStaff(Staff staff)
        {
            StaffValidator validator = new();
            ValidationResult result = validator.Validate(staff);
            if (result.IsValid)
            {
                _staffService.Update(staff);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
