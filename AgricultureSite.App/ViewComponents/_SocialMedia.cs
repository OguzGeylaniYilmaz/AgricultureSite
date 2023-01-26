using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureSite.App.ViewComponents
{
    public class _SocialMedia : ViewComponent
    {
        private readonly ISocialMediaService _socialMediaService;

        public _SocialMedia(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public IViewComponentResult Invoke()
        {
            var socialMedia = _socialMediaService.GetAll();
            return View(socialMedia);
        }
    }
}
