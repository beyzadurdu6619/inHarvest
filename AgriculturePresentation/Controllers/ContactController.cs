using BusinessLayer.Abstract;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        public IActionResult Index()
        {
            var values = _contactService.GetAllList();
            return View(values);
        }


        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Create(Contact model)
        {
     
            _contactService.Insert(model);
            return RedirectToAction("Index");

        }



        public IActionResult Delete(int id)
        {
            var values = _contactService.GetById(id);
            _contactService.Delete(values);
            return RedirectToAction("Index");
        }

      


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var values = _contactService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(Contact model)
        {
            _contactService.Update(model);
            return RedirectToAction("Index");


        }

    }
}
