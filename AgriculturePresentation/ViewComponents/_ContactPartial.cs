using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
    public class _ContactPartial : ViewComponent
    {
        private readonly IContactService _ContactService;

        public _ContactPartial(IContactService ContactService)
        {
            _ContactService = ContactService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _ContactService.GetAllList();
            return View(values);
        }
    }
}

