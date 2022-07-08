using AirportWebApplication.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirportWebApplication.Models
{
    public class AddFlightFormModel
    {
        [Remote("DoesAirlineExist", "Flight", HttpMethod = "POST", ErrorMessage = "Airline with that name was not found.")]
        public string AirlineName { get; set; }


        [Remote("DoesOriginExist", "Flight", HttpMethod = "POST", ErrorMessage = "Airport with that name was not found.")]
        public string OriginAirportName { get; set; }

        [Remote("DoesDestExist", "Flight", HttpMethod = "POST", ErrorMessage = "Airport with that name was not found.")]
        public string DestAirportName { get; set; }
        public DateTime TakeOffTime { get; set; }

        public DateTime LandingTime { get; set; }
        public List<Seat> Seats { get; set; }
        public int rowsEconomy { get; set; }
        public int rowsBusiness { get; set; }
        public int rowsFirst { get; set; }
        public int colsFirst { get; set; }
        public int colsBusiness { get; set; }
        public int colsEconomy { get; set; }
        [Key]
        public int Id { get; set; }

        public List<Airport> Airports { get; set; }
    }
}
