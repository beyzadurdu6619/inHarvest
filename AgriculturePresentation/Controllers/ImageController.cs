using AgriculturePresentation.Models;
using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }
        public IActionResult Index()
        {
            var values = _imageService.GetAllList();
            return View(values);
        }

        [HttpGet]
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Create(Image model)
        {
            ImageValidator validationRules = new ImageValidator();
            FluentValidation.Results.ValidationResult result = validationRules.Validate(model); // Burada FluentValidation ekleniyor

            if (result.IsValid)
            {
                _imageService.Insert(model);
                return RedirectToAction("Index");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            }

            return View(model);
        }


        public IActionResult Delete(int id)
        {
            var values = _imageService.GetById(id);
            _imageService.Delete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var values = _imageService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(Image model)
        {
            _imageService.Update(model);
            return RedirectToAction("Index");


        }

    }
}
