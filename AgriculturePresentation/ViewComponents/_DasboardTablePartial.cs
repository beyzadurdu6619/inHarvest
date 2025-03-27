using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Text;

namespace AgriculturePresentation.ViewComponents
{
    public class _DasboardTablePartial : ViewComponent
    {
        private readonly IContactService _contactService;
        public _DasboardTablePartial(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _contactService.GetAllList();
            return View(values);
        }
    }
}
