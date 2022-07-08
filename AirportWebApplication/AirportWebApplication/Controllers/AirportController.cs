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
    public class AirportController : Controller
    {
        private readonly IAirportService airports;
        public AirportController(IAirportService airports)
        {
            this.airports = airports;
        }
        [HttpPost]
        public JsonResult AirportIdAlreadyExists(string Id)
        {

            return Json(airports.IsIdTaken(Id));

        }
        [HttpPost]
        public JsonResult AirportNameAlreadyExists(string Name)
        {
            return Json(airports.IsNameTaken(Name));
        }
        public IActionResult AddAirport()
        {
            return View();
        }
        public IActionResult AirportSuccessfulSubmission()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAirport(AddAirportFormModel model)
        {
            airports.AddAirport(new Airport { Id = model.Id, Name = model.Name, City=model.City, Country=model.Country, Address = model.Address});
            return RedirectToAction("AirportSuccessfulSubmission", "Airport");
            
        }
        public IActionResult ViewAirports()
        {
            var airports = this.airports.ViewAirports();

            return View(airports);
        }
    }
}
