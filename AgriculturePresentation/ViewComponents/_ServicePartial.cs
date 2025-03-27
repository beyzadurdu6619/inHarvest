using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
    public class _ServicePartial : ViewComponent
    {
        private readonly IServicesService _serviceService;

        public _ServicePartial(IServicesService serviceService)
        {
            _serviceService = serviceService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _serviceService.GetAllList();
            return View(values);
        }
    }
}
