﻿using BusinessLayer.Abstract;
using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
    public class _MapPartial : ViewComponent
    {
        private readonly IAddressService _addressService;

        public _MapPartial(IAddressService addressService)
        {
            _addressService = addressService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _addressService.GetAllList();

            return View(values);
        }
    }
}
