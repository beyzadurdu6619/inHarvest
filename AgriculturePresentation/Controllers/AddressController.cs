using BusinessLayer.Abstract;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }
        public IActionResult Index()
        {
            var values = _addressService.GetById(2);
            return View(values);
        }




        [HttpGet]
        public IActionResult Edit(int id)
        {
            var values = _addressService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(Address model)
        {
            _addressService.Update(model);
            return RedirectToAction("Index");


        }

    }
}
