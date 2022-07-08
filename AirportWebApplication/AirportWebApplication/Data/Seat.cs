using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirportWebApplication.Data
{
    public class Seat
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public ClassTypes Class { get; set; }
        public string Symbols { get; set; }
        public int FlightId { get; set; }
        public bool IsBooked { get; set; }

    }
}
