using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirportWebApplication.Models
{
    public class AddAirportFormModel
    {

        [Remote("AirportIdAlreadyExists", "Airport", HttpMethod = "POST", ErrorMessage = "Airport with the same ID exists.")]
        public string Id { get; set; }
        [Remote("AirportNameAlreadyExists", "Airport", HttpMethod = "POST", ErrorMessage = "Airport with the same name exists.")]
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Address{ get; set; }

    }
}
