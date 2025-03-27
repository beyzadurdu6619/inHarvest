using AgriculturePresentation.Models;
using BusinessLayer.Abstract;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServicesService _servicesService;

        public ServiceController(IServicesService servicesService)
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


        public IActionResult Delete(int id)
        {
            var values = _servicesService.GetById(id);
            _servicesService.Delete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var values = _servicesService.GetById(id);
            return View(values);
        } 
        [HttpPost]
        public IActionResult Edit(Services model)
        {

            var values = _servicesService.GetById(model.ServicesID);
            model.Class1 = values.Class1;
            model.Class2 = values.Class2;

            _servicesService.Update(model);
            return RedirectToAction("Index");


        }






    }
}
