using AirportWebApplication.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirportWebApplication.Models
{
    public class SearchFlightsFormModel
    { 
        [Required(ErrorMessage = "Origin is required.")]
        [Remote("DoesOriginExist", "Flight", HttpMethod = "POST", ErrorMessage = "Airport with that name not found.")]
        public string OriginAirportName { get; set; }
        [Required(ErrorMessage = "Destination is required.")]
        [Remote("DoesDestExist", "Flight", HttpMethod = "POST", ErrorMessage = "Airport with that name not found.")]
        public string DestAirportName { get; set; }
        public DateTime Date { get; set; }
    }
}
