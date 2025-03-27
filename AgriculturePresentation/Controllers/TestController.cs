using AgriculturePresentation.Models;
using BusinessLayer.Abstract;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class TestController : Controller
    {
        private readonly IServicesService _servicesService;

        public TestController(IServicesService servicesService)
        {
            _servicesService = servicesService; 
        }
        public IActionResult Index()
        {
            var values = _servicesService.GetAllList();   
            return View(values);
        }

        [HttpGet]
        public IActionResult Create()
        {
     
            return View(new ServiceAddViewModel());
        }

        [HttpPost]
        public IActionResult Create(ServiceAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _servicesService.Insert(new Services()
                {
                    Title = model.Title,
                    Description = model.Description,
                    Image = model.Image
                });
                return RedirectToAction("Index");
            }
            return View(model);


        }
    }
}
