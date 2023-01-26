using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureSite.App.ViewComponents
{
    public class _Galery : ViewComponent
    {
        private readonly IImageService _imageService;

        public _Galery(IImageService imageService)
        {
            _imageService = imageService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _imageService.GetAll();
            return View(values);
        }
    }
}
