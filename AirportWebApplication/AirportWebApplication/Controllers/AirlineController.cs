using AirportWebApplication.Data;
using AirportWebApplication.Models;
using AirportWebApplication.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportWebApplication.Controllers
{
    public class AirlineController : Controller
    {
        private readonly IAirlineService airlines;

        public AirlineController(IAirlineService airlines)
        {
            this.airlines = airlines;
        }
        [HttpPost]
        public JsonResult AirlineNameAlreadyExists(string Name)
        {

            return Json(airlines.IsNameTaken(Name));

        }
        public IActionResult AddAirline()
        {
            return View();
        }
        public IActionResult AirlineSuccessfulSubmission()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAirline(AddAirlineFormModel airlineFormModel)
        {
            airlines.AddAirline(new Airline {Name = airlineFormModel.Name});

            return RedirectToAction("AirlineSuccessfulSubmission", "Airline");

        }

        public IActionResult ViewAirlines()
        {
            var airlines = this.airlines.ViewAirlines();
            return View(airlines);
        }
    }
}
