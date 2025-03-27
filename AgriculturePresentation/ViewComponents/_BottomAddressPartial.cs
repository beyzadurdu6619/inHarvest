using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
    public class _BottomAddressPartial : ViewComponent
    {
        private readonly IAddressService _AddressService;

        public _BottomAddressPartial(IAddressService AddressService)
        {
            _AddressService = AddressService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _AddressService.GetAllList();
            return View(values);
        }
    }
}
