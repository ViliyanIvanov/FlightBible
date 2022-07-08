using AirportWebApplication.Data;
using AirportWebApplication.Models;
using AirportWebApplication.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportWebApplication.Controllers
{
    public class FlightController : Controller
    {
        private readonly IFlightService flights;
        private readonly IAirportService airports;
        private readonly IAirlineService airlines;
        private readonly AirportSystem_DbContext DbContext;
        public FlightController(IFlightService flights, IAirportService airports, IAirlineService airlines, AirportSystem_DbContext DbContext)
        {
            this.flights = flights;
            this.airports = airports;
            this.airlines = airlines;
            this.DbContext = DbContext;
        }
        [HttpPost]
        public JsonResult DoesAirlineExist(string AirlineName)
        {
            return Json(airlines.DoesAirlineExist(AirlineName));
        }
        [HttpPost]
        public JsonResult DoesOriginExist(string OriginAirportName)
        {
            return Json(airports.DoesAirportExist(OriginAirportName));
        }
        [HttpPost]
        public JsonResult DoesDestExist(string DestAirportName)
        {
            return Json(airports.DoesAirportExist(DestAirportName));
        }
        public IActionResult SearchFlights()
        {
            return View(new SearchFlightsFormModel { OriginAirportName="", DestAirportName="", Date=DateTime.Today });
        }

        public IActionResult FoundFlights(SearchFlightsFormModel searchModel)
        {
            if (flights.FoundFlights(searchModel).Count==0)
            {
                return View("NoFlightsFound");
            }
            return View("ViewFlights", flights.FoundFlights(searchModel));
        }



        public IActionResult AddFlight()
        {
            var flightModel = new AddFlightFormModel();
            flightModel.Airports = airports.GetAllAirports();
            return View(flightModel);
        }
        public IActionResult FlightSuccessfulSubmission()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddFlight (AddFlightFormModel flightFormModel)
        {
            flights.AddFlight(flightFormModel);
            return RedirectToAction("FlightSuccessfulSubmission","Flight");

        }

        public IActionResult ViewFlights()
        {
            var flights = this.flights.ViewFlights();
            if (flights.Count==0)
            {
                return View("NoFlightsFound");
            }
            return View(flights);
        }
    }
}
