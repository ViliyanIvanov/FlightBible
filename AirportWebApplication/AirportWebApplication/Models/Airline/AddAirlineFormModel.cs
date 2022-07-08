using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirportWebApplication.Models
{
    public class AddAirlineFormModel
    {
        [Required]
        [Remote("AirlineNameAlreadyExists", "Airline", HttpMethod = "POST", ErrorMessage = "Airline with that name already exist.")]
        public string Name { get; set; }
    }
}
