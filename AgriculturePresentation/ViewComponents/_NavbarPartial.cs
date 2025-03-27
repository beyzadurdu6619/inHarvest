using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
    public class _NavbarPartial : ViewComponent
    {
        //    private readonly IAddressService _addressService;

        //public _NavbarPartial(IAddressService addressService)
        //{
        //    _addressService = addressService;
        //}
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
