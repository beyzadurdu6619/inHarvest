using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
    public class _BottomSocialMediaPartial : ViewComponent
    {
        private readonly ISocialMediaService _socialMediaService;

        public _BottomSocialMediaPartial(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _socialMediaService.GetAllList();
            return View(values);
        }
    }
}
