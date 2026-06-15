using System;
using System.Collections.Generic;
using HomeworkTHREE.Models;
using HomeworkTHREE.Services;
using Microsoft.AspNetCore.Mvc;

namespace HomeworkTHREE.Controllers
{
    public class CityController : Controller
    {
        private readonly CityServices CityServices;

        public CityController(CityServices CityServices)
        {
            this.CityServices = CityServices;
        }

        public IActionResult List()
        {
            return View(CityServices.GetMyCities());
        }
    }
}
