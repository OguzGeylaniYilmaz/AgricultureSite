using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureSite.App.ViewComponents
{
    public class _Service : ViewComponent
    {
        private readonly IService _service;

        public _Service(IService service)
        {
            _service = service;
        }

        public IViewComponentResult Invoke()
        {
            var serviceList = _service.GetAll();
            return View(serviceList);
        }
    }
}
