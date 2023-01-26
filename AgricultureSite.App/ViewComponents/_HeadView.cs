using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgricultureSite.App.ViewComponents
{
    public class _HeadView : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
