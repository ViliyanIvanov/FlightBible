using AirportWebApplication.Data;
using AirportWebApplication.Models;
using AirportWebApplication.Models.Seats;
using AirportWebApplication.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportWebApplication.Controllers
{
    public class SeatController : Controller
    {
        private readonly ISeatService seats;
        public SeatController(ISeatService seats)
        {
            this.seats = seats;
        }
        public IActionResult Index(int flightId)
        {
            return View(seats.GetSeats(flightId));
        }

        public IActionResult BookSeat(int seatId)
        {
            return View("Index", seats.GetSeats(seats.BookSeat(seatId)));
        }
    }
}
