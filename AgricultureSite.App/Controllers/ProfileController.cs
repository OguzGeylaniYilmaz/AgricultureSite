using AgricultureSite.App.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgricultureSite.App.Controllers
{
    public class ProfileController : Controller
    {

        private readonly UserManager<IdentityUser> _userManager;

        public ProfileController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var info = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel model = new();
            model.Mail = info.Email;
            model.Phone = info.PhoneNumber;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel userModel)
        {
            var userInfo = await _userManager.FindByNameAsync(User.Identity.Name);
            if (userModel.Password == userModel.ConfirmPassword)
            {
                userInfo.Email = userModel.Mail;
                userInfo.PhoneNumber = userModel.Phone;
                userInfo.PasswordHash = _userManager.PasswordHasher.HashPassword(userInfo, userModel.Password);
                var result = await _userManager.UpdateAsync(userInfo);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
    }
}
