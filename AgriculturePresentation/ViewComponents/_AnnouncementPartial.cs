using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{

     public class _AnnouncementPartial : ViewComponent
    {
        private readonly IAnnouncementService _AnnouncementService;

        public _AnnouncementPartial(IAnnouncementService AnnouncementService)
        {
            _AnnouncementService = AnnouncementService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _AnnouncementService.GetAllList();
            return View(values);
        }
    }
}
