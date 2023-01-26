using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AgricultureSite.App.ViewComponents
{
    public class _DashboardOverview : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            AgricultureContext context = new();
            ViewBag.staffCount = context.Staffs.Count();
            ViewBag.serviceCount = context.Services.Count();
            ViewBag.messageCount = context.Contacts.Count();
            ViewBag.announcementCount = context.Informations.Count();
            return View();
        }
    }
}
