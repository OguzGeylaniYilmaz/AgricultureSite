using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgricultureSite.App.ViewComponents
{
    public class _Navbar :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //var socialMedia = _socialMediaService.GetAll();
            return View();
        }
    }
}
