using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureSite.App.ViewComponents
{
    public class _Information : ViewComponent
    {
        private readonly IInformationService _informationService;

        public _Information(IInformationService informationService)
        {
            _informationService = informationService;
        }

        public IViewComponentResult Invoke()
        {
            var informationList = _informationService.GetAll();
            return View(informationList);
        }
    }
}
