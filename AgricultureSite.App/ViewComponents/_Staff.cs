using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureSite.App.ViewComponents
{
    public class _Staff : ViewComponent
    {
        private readonly IStaffService _staffService;

        public _Staff(IStaffService staffService)
        {
            _staffService = staffService;
        }

        public IViewComponentResult Invoke()
        {
            var staffList = _staffService.GetAll();
            return View(staffList);
        }
    }
}
