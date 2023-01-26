using Microsoft.AspNetCore.Mvc;

namespace AgricultureSite.App.ViewComponents
{
    public class _DashboardNavbar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
