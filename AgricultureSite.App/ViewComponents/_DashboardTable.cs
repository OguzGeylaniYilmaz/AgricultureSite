using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureSite.App.ViewComponents
{
    public class _DashboardTable : ViewComponent
    {
        private readonly IContactService _contactService;

        public _DashboardTable(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _contactService.GetAll();
            return View(values);
        }
    }
}
