using AgriculturePresentation.Models;
using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using FluentValidation;
using FluentValidation.Results;


namespace AgriculturePresentation.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }
        public IActionResult Index()
        {
            var values = _teamService.GetAllList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Create(Team model)
        {
            TeamValidator validationRules = new TeamValidator();
            FluentValidation.Results.ValidationResult result = validationRules.Validate(model); // Burada FluentValidation ekleniyor

            if (result.IsValid)
            {
                _teamService.Insert(model);
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
            var values = _teamService.GetById(id);
            _teamService.Delete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var values = _teamService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(Team model)
        {
            _teamService.Update(model);
            return RedirectToAction("Index");


        }






    }
}
