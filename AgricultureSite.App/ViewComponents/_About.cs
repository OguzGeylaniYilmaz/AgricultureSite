using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureSite.App.ViewComponents
{
    public class _About : ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _About(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        {
            var aboutInfo = _aboutService.GetAll();
            return View(aboutInfo);
        }
    }
}
