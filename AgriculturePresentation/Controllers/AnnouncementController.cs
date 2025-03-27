using AgriculturePresentation.Models;
using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AgriculturePresentation.Controllers
{
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementsService;

        public AnnouncementController(IAnnouncementService announcementsService)
        {
            _announcementsService = announcementsService;
        }
        public IActionResult Index()
        {
            var values = _announcementsService.GetAllList();
            return View(values);
        }


        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Create(Announcement model)
        {
            model.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            model.Status = false;
            _announcementsService.Insert(model);
            return RedirectToAction("Index");
          
        }



        public IActionResult Delete(int id)
        {
            var values = _announcementsService.GetById(id);
            _announcementsService.Delete(values);
            return RedirectToAction("Index");
        }

        public IActionResult Active(int id)
        {
            var values = _announcementsService.GetById(id);
            if (values != null)
            {
                values.Status = true;
                _announcementsService.Update(values); // Güncellenen veriyi kaydet
            }
            return RedirectToAction("Index");
        }

        public IActionResult Deactive(int id)
        {
            var values = _announcementsService.GetById(id);
            if (values != null)
            {
                values.Status = false;
                _announcementsService.Update(values); // Güncellenen veriyi kaydet
            }
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var values = _announcementsService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(Announcement model)
        {
            _announcementsService.Update(model);
            return RedirectToAction("Index");


        }


    }
}
