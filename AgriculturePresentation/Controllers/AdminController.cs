using AgriculturePresentation.Models;
using BusinessLayer.Abstract;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _AdminService;

        public AdminController(IAdminService AdminService)
        {
            _AdminService = AdminService;
        }
        public IActionResult Index()
        {
            var values = _AdminService.GetAllList();
            return View(values);
        }


        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Create(Admin model)
        {

            _AdminService.Insert(model);
            return RedirectToAction("Index");

        }



        public IActionResult Delete(int id)
        {
            var values = _AdminService.GetById(id);
            _AdminService.Delete(values);
            return RedirectToAction("Index");
        }




        [HttpGet]
        public IActionResult Edit(int id)
        {
            var values = _AdminService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(Admin model)
        {
            _AdminService.Update(model);
            return RedirectToAction("Index");


        }
    }
}
